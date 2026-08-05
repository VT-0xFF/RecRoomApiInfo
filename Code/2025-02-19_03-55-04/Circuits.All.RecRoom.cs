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
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2500DE0", Offset = "0x24FF9E0", VA = "0x182500DE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9836D0", Offset = "0x9822D0", VA = "0x1809836D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x983710", Offset = "0x982310", VA = "0x180983710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class FAMECBPCILE : IDisposable, FMOGFKNKNKL, DEJEPLCAGLC, HBOGJGANDCI, EPPBLBBNOOD
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class NNCDBFNMFJO : LIBMCMEJNKP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int IAEDNAJCNNE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x25006D0", Offset = "0x24FF2D0", VA = "0x1825006D0", Slot = "5")]
		public IEFLCGHIFON KAICGPBKCBC(FLDCIAOHJGA.GILFJLNDKHL CJMMHNIMOJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void CPBFGKNCJPC();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void PHDLMAEFCBF();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2500690", Offset = "0x24FF290", VA = "0x182500690", Slot = "13")]
		public virtual void CDJCEHFNLCB(FAMECBPCILE JKPOOJNKKFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2500610", Offset = "0x24FF210", VA = "0x182500610", Slot = "14")]
		public virtual void AKGAPEJCOMO(FAMECBPCILE JKPOOJNKKFK, JCKDHEKPOIA OAGMINHECCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		protected NNCDBFNMFJO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LIBMCMEJNKP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int IAEDNAJCNNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IEFLCGHIFON KAICGPBKCBC(FLDCIAOHJGA.GILFJLNDKHL CJMMHNIMOJB);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CPBFGKNCJPC();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PHDLMAEFCBF();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CDJCEHFNLCB(FAMECBPCILE JKPOOJNKKFK);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void AKGAPEJCOMO(FAMECBPCILE JKPOOJNKKFK, JCKDHEKPOIA OAGMINHECCA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct MLFNONLAAEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly AIHCJGIHFDN<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE, PPMIOCPEKCK.INGEHKDCKHO<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE>> BLANNJFJBMH;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x24FDEB0", Offset = "0x24FCAB0", VA = "0x1824FDEB0")]
		internal MLFNONLAAEJ(AIHCJGIHFDN<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE, PPMIOCPEKCK.INGEHKDCKHO<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE>> FOBBPKHANPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class PEEPLHAGKIO : PPMIOCPEKCK.INGEHKDCKHO<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly PEEPLHAGKIO FFLNCJPMHOJ;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		private PEEPLHAGKIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD8A0", VA = "0x1809DECA0", Slot = "4")]
		public BCOHPOMJGNP IEEKIBFHEBF(JCKDHEKPOIA DKGDAEBOJKO)
		{
			return default(BCOHPOMJGNP);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2501A20", Offset = "0x2500620", VA = "0x182501A20", Slot = "5")]
		public void CDJCEHFNLCB(FAMECBPCILE EBMDCHEPJIM, JCKDHEKPOIA OAGMINHECCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2501910", Offset = "0x2500510", VA = "0x182501910", Slot = "6")]
		public void AKGAPEJCOMO(FAMECBPCILE EBMDCHEPJIM, JCKDHEKPOIA OAGMINHECCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct BDLKPNMGAFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public HLKPIDMGNGP<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE, PPMIOCPEKCK.INGEHKDCKHO<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE>> BLANNJFJBMH;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x24E60B0", Offset = "0x24E4CB0", VA = "0x1824E60B0")]
		internal BDLKPNMGAFN(HLKPIDMGNGP<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE, PPMIOCPEKCK.INGEHKDCKHO<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE>> FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x24E6060", Offset = "0x24E4C60", VA = "0x1824E6060")]
		public static BDLKPNMGAFN JPHABLICNHB()
		{
			return default(BDLKPNMGAFN);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct IDBHILLDPLL : CCLOFBBKKLB.LGLKAJIIEPN<JCKDHEKPOIA, FAMECBPCILE>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct PMLGNPBKKKC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<PNJEPLMEKHI<object?, GEJJJMKDLKA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public FAMECBPCILE receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public JCKDHEKPOIA action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public IDBHILLDPLL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<PNJEPLMEKHI<object?, GEJJJMKDLKA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2502600", Offset = "0x2501200", VA = "0x182502600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x25027E0", Offset = "0x25013E0", VA = "0x1825027E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xD3AF20", Offset = "0xD39B20", VA = "0x180D3AF20", Slot = "4")]
		public ENBGACDEBPI<PMFEOFKHFCA> GJMNAILNJGA(FAMECBPCILE JHNAPAEKPAE)
		{
			return default(ENBGACDEBPI<PMFEOFKHFCA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x24FA2C0", Offset = "0x24F8EC0", VA = "0x1824FA2C0", Slot = "5")]
		public void IOHKGDAEKFH(FAMECBPCILE JHNAPAEKPAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x24FA320", Offset = "0x24F8F20", VA = "0x1824FA320", Slot = "6")]
		[AsyncStateMachine(typeof(PMLGNPBKKKC))]
		public Task<PNJEPLMEKHI<object, GEJJJMKDLKA>> NABGEEFFHOC(FAMECBPCILE JHNAPAEKPAE, JCKDHEKPOIA OAGMINHECCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x24FA2A0", Offset = "0x24F8EA0", VA = "0x1824FA2A0", Slot = "7")]
		public JCKDHEKPOIA[] HEHDFCFLGLM(FAMECBPCILE JHNAPAEKPAE)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MJHLAKIGGAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<bool, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FAMECBPCILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<PNJEPLMEKHI<bool, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x24FDBB0", Offset = "0x24FC7B0", VA = "0x1824FDBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x24FDE40", Offset = "0x24FCA40", VA = "0x1824FDE40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct KBEMJCKGIAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public FAMECBPCILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x24FBB40", Offset = "0x24FA740", VA = "0x1824FBB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x24FBD20", Offset = "0x24FA920", VA = "0x1824FBD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PEHLFDPFHBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<object?, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public FAMECBPCILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public JCKDHEKPOIA action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<PNJEPLMEKHI<object?, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2501B90", Offset = "0x2500790", VA = "0x182501B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2501D80", Offset = "0x2500980", VA = "0x182501D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly ENBGACDEBPI<PMFEOFKHFCA> CMGCJLKGOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MLFNONLAAEJ BEIFGKBEDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FIANBPDFJBN KIEOEMDNHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly OFFPIGABHML PCFFHLKGGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AE8")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly JJOBOHLBIDN JILFFJDGMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AF0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly DELENLBBKCB.GGJAFNIHPKO CHDGOMPPBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly NBKNFKFADCG DFPKAGNGOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly BIAJHOHJBIG APBINGODGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly FHJNFCIOFGM DHEAHDGELMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly GNPAOPFFEGL HLCHELJLKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B38")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ICOPDIIIHOM EPOOIEFFFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private JCBAGCFGJIB MOHLJMOEPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B68")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly FIANBPDFJBN.HGDKJEDFIMI EAIAJAHMIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B70")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly BCDBLHFOEPC JKBNMBEGJPL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FIANBPDFJBN OHHICMAKAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x24F7DD0", Offset = "0x24F69D0", VA = "0x1824F7DD0")]
		get
		{
			return default(FIANBPDFJBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal LIBMCMEJNKP FFCMINMOLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24F6C80", Offset = "0x24F5880", VA = "0x1824F6C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal IEFLCGHIFON PJMNBOANAHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24F7E50", Offset = "0x24F6A50", VA = "0x1824F7E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x24F77A0", Offset = "0x24F63A0", VA = "0x1824F77A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool FIPLCPLLIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x24F6C70", Offset = "0x24F5870", VA = "0x1824F6C70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x24F6DE0", Offset = "0x24F59E0", VA = "0x1824F6DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MKADBPKMOJC IBOFPEGFALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x24F8370", Offset = "0x24F6F70", VA = "0x1824F8370", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AEEDCGAAPOH LIEDPHLIAHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x24F8380", Offset = "0x24F6F80", VA = "0x1824F8380", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public KNKBDNIEGJI BCGDPAMDHNK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x24F83A0", Offset = "0x24F6FA0", VA = "0x1824F83A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FAEGGAOPDAM KBEOHCLDLKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x24F8390", Offset = "0x24F6F90", VA = "0x1824F8390", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DELENLBBKCB? BKMAEFICBFD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x24F7200", Offset = "0x24F5E00", VA = "0x1824F7200", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private DKLABFLPJCL? FGHDJFLICEB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x24F6FE0", Offset = "0x24F5BE0", VA = "0x1824F6FE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24F8070", Offset = "0x24F6C70", VA = "0x1824F8070")]
	private FAMECBPCILE(JJOBOHLBIDN ENEHENBPLMA, ENBGACDEBPI<PMFEOFKHFCA> BLMGFGJJCEO, [In] MLFNONLAAEJ KNHCBCCDJHD, [In] FIANBPDFJBN BHPAAPCBOGP, [In] OFFPIGABHML NILJFBALPFN, IEFLCGHIFON IDPJNHDJMBK, [In] DELENLBBKCB.GGJAFNIHPKO LAFKHEFCKOD, FIANBPDFJBN.HGDKJEDFIMI NLPEFANDEKP, BCDBLHFOEPC AFOOOOJLINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x24F7B20", Offset = "0x24F6720", VA = "0x1824F7B20")]
	public static FAMECBPCILE JPHABLICNHB(JJOBOHLBIDN CJMMHNIMOJB, [In] OOEPGOKMHIJ GILKHLLJIHG, FMLDLKGKEPL FICFNBJKIGA, [In] OEPOLKCKGNO LCMFGILJEEI, KABFGPJCPKG KFMFANIDCEO, ENBGACDEBPI<PMFEOFKHFCA> BLMGFGJJCEO, ENBGACDEBPI<FOCADPKCIFL> NLFJCBFCDPP, EBONHPPPMND LHEPEPAJBFM, GFDIJEBPNLM BEPENDLANPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x24F7810", Offset = "0x24F6410", VA = "0x1824F7810")]
	public static FAMECBPCILE JPHABLICNHB(JJOBOHLBIDN ENEHENBPLMA, [In] FIANBPDFJBN BHPAAPCBOGP, [In] OFFPIGABHML NILJFBALPFN, ENBGACDEBPI<PMFEOFKHFCA> BLMGFGJJCEO, ENBGACDEBPI<FOCADPKCIFL> NLFJCBFCDPP, EBONHPPPMND LHEPEPAJBFM, GFDIJEBPNLM BEPENDLANPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x24F6DF0", Offset = "0x24F59F0", VA = "0x1824F6DF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x24F7C60", Offset = "0x24F6860", VA = "0x1824F7C60")]
	[AsyncStateMachine(typeof(MJHLAKIGGAH))]
	public Task<PNJEPLMEKHI<bool, GEJJJMKDLKA>> KGELHADJDHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x24F7110", Offset = "0x24F5D10", VA = "0x1824F7110")]
	[AsyncStateMachine(typeof(KBEMJCKGIAJ))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> EKAKOOLOGIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x24F7E60", Offset = "0x24F6A60", VA = "0x1824F7E60")]
	internal void OIAGPCPPAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x24F7D50", Offset = "0x24F6950", VA = "0x1824F7D50")]
	internal AKMEDOPOELG<JCKDHEKPOIA> LEEPINMJHDK([In] EMBPPNGFJBE DKFFEPIOFFG)
	{
		return default(AKMEDOPOELG<JCKDHEKPOIA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x24F7DE0", Offset = "0x24F69E0", VA = "0x1824F7DE0")]
	internal bool LOKGABNPDAL([In] EMBPPNGFJBE DKFFEPIOFFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x24F7280", Offset = "0x24F5E80", VA = "0x1824F7280")]
	internal PNJEPLMEKHI<JCKDHEKPOIA, GEJJJMKDLKA> GANAJJHENGI([In] MDNIFNNFLMC KKMLNLNILMH)
	{
		return default(PNJEPLMEKHI<JCKDHEKPOIA, GEJJJMKDLKA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x24F77C0", Offset = "0x24F63C0", VA = "0x1824F77C0")]
	private void IOHKGDAEKFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x24F6CD0", Offset = "0x24F58D0", VA = "0x1824F6CD0")]
	[AsyncStateMachine(typeof(PEHLFDPFHBC))]
	internal Task<PNJEPLMEKHI<object, GEJJJMKDLKA>> CKMGLNDJKLH(JCKDHEKPOIA OAGMINHECCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x24F7410", Offset = "0x24F6010", VA = "0x1824F7410")]
	private JCKDHEKPOIA[] HEHDFCFLGLM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class HJAPJNJEHKI<TData> : KLJHHNJNNDG, AHEFNIMCMGM, PKJJHJMDMCJ where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly LFHLJBHJLKP<CALHCHFEDII>? LCNPOILNPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string JMJNOKCIMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly TData JBDHCGELIFD;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LFHLJBHJLKP<CALHCHFEDII>? FNAKFMFBEDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x27541E0", Offset = "0x2752DE0", VA = "0x1827541E0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x961640", Offset = "0x960240", VA = "0x180961640", Slot = "7")]
	public override string CNPDCBKGCII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x462B530", Offset = "0x462A130", VA = "0x18462B530")]
	internal HJAPJNJEHKI([In] LFHLJBHJLKP<CALHCHFEDII>? LCJDDNFCPNK, ENBGACDEBPI<JDGCKBCLIAF>? LIGJKNHNBJH, IOKind? IKFJAMKOEPN, string KBPDEFFIKOJ, [In] TData LLDJIJICLJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class PLHECGDGCPA
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2502160", Offset = "0x2500D60", VA = "0x182502160")]
	public static PNJEPLMEKHI<JDMLLGMMNJP, AHEFNIMCMGM> JLBABKDOLNC([In] this MGOFCDFKGLE<HOKCHJGJLKJ> LECHMGBABBE)
	{
		return default(PNJEPLMEKHI<JDMLLGMMNJP, AHEFNIMCMGM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3561860", Offset = "0x3560460", VA = "0x183561860")]
	public static PNJEPLMEKHI<TOk, AHEFNIMCMGM> CFEGDPDCIPK<TOk>([In] this PNJEPLMEKHI<TOk, AHEFNIMCMGM> DKGDAEBOJKO, [In] LFHLJBHJLKP<CALHCHFEDII>? LCJDDNFCPNK, ENBGACDEBPI<JDGCKBCLIAF>? LIGJKNHNBJH, IOKind? IKFJAMKOEPN, string KBPDEFFIKOJ) where TOk : notnull
	{
		return default(PNJEPLMEKHI<TOk, AHEFNIMCMGM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JJOBOHLBIDN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	OHGCALJMIBE.HJKHHLLJCMB DCLKGPLGIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	FLDCIAOHJGA.GILFJLNDKHL FJPGNANBPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	FAMECBPCILE.LIBMCMEJNKP JFKAMACEHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DADMLIBEGLD.BIPNEMHDEGD JAMIBHHKGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	PPMIOCPEKCK.INGEHKDCKHO<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE> GFJHJODOOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	POOPHPOENFE.OOKJCIKIFAI CAHKCKLIAMK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MBINOHCLPKN LEEIKBEEILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	PIMLOOPHOFJ FHANKAIJPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	DDJFMMCPKIO KADLNKIDEDN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	IDFHECOJNDK NKPDNIEMBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	AGKNGCJHOEN BKGAPIAAPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GHPOMDFFCAI
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x24F94B0", Offset = "0x24F80B0", VA = "0x1824F94B0")]
	public static JCKDHEKPOIA JBAGCGMNPAK(this JCKDHEKPOIA DKGDAEBOJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x24F95C0", Offset = "0x24F81C0", VA = "0x1824F95C0")]
	public static JCKDHEKPOIA KJOPHADKAHF(this JHHPPFHOONH DKGDAEBOJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct JHHPPFHOONH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct FNIAHJBKPMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<object?, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public FAMECBPCILE root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public JHHPPFHOONH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<PNJEPLMEKHI<object?, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x24F8DD0", Offset = "0x24F79D0", VA = "0x1824F8DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x24F9090", Offset = "0x24F7C90", VA = "0x1824F9090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly ByteString GNLOKINMAMH;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xBDB470", Offset = "0xBDA070", VA = "0x180BDB470")]
	private JHHPPFHOONH(ByteString MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x24FB1B0", Offset = "0x24F9DB0", VA = "0x1824FB1B0")]
	public static JCKDHEKPOIA ILDFKLEKGBC(ByteString MPDLOLIOGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x24FB100", Offset = "0x24F9D00", VA = "0x1824FB100")]
	public static IGLANCPFJMB<BCOHPOMJGNP, JHHPPFHOONH> DJKEMDCHMGJ(JCKDHEKPOIA INOICDEKJOE)
	{
		return default(IGLANCPFJMB<BCOHPOMJGNP, JHHPPFHOONH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x24FAFF0", Offset = "0x24F9BF0", VA = "0x1824FAFF0")]
	[AsyncStateMachine(typeof(FNIAHJBKPMD))]
	public static Task<PNJEPLMEKHI<object, GEJJJMKDLKA>> CKMGLNDJKLH(FAMECBPCILE EBMDCHEPJIM, JHHPPFHOONH DKGDAEBOJKO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct LAIIPPLIAFG
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x24FC0A0", Offset = "0x24FACA0", VA = "0x1824FC0A0")]
	public static JCKDHEKPOIA ILDFKLEKGBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x24FC030", Offset = "0x24FAC30", VA = "0x1824FC030")]
	public static IGLANCPFJMB<BCOHPOMJGNP, LAIIPPLIAFG> DJKEMDCHMGJ(JCKDHEKPOIA INOICDEKJOE)
	{
		return default(IGLANCPFJMB<BCOHPOMJGNP, LAIIPPLIAFG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x24FC140", Offset = "0x24FAD40", VA = "0x1824FC140")]
	public static PNJEPLMEKHI<BODKGJBCKHC, HJOMFIPJJDB> KPDHBIJEMPN(FAMECBPCILE EBMDCHEPJIM, [In] LAIIPPLIAFG DKGDAEBOJKO)
	{
		return default(PNJEPLMEKHI<BODKGJBCKHC, HJOMFIPJJDB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct DKIHEBDFAJK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct MBNOOPBLBKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, HJOMFIPJJDB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public FAMECBPCILE root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public DKIHEBDFAJK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private PNJEPLMEKHI<BODKGJBCKHC, HJOMFIPJJDB> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x24FC1C0", Offset = "0x24FADC0", VA = "0x1824FC1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x24FC530", Offset = "0x24FB130", VA = "0x1824FC530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly KHCNLKFLBAB? DBEEOHAKMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly POJLNBCFFCA? AFFABMEGFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly PGMIGGEMMKL? EIEFIGNAFLG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x241F880", Offset = "0x241E480", VA = "0x18241F880")]
	private DKIHEBDFAJK(KHCNLKFLBAB? BDMCKILHPML, POJLNBCFFCA? PKGBNKHOGNB, PGMIGGEMMKL? MAGHCEFJIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x24EB9A0", Offset = "0x24EA5A0", VA = "0x1824EB9A0")]
	public static JCKDHEKPOIA? ILDFKLEKGBC(KHCNLKFLBAB? BDMCKILHPML, POJLNBCFFCA? PKGBNKHOGNB, PGMIGGEMMKL? MAGHCEFJIPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x24EB890", Offset = "0x24EA490", VA = "0x1824EB890")]
	public static IGLANCPFJMB<BCOHPOMJGNP, DKIHEBDFAJK> DJKEMDCHMGJ(JCKDHEKPOIA INOICDEKJOE)
	{
		return default(IGLANCPFJMB<BCOHPOMJGNP, DKIHEBDFAJK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x24EB750", Offset = "0x24EA350", VA = "0x1824EB750")]
	[AsyncStateMachine(typeof(MBNOOPBLBKB))]
	public static Task<PNJEPLMEKHI<BODKGJBCKHC, HJOMFIPJJDB>> CKMGLNDJKLH(FAMECBPCILE EBMDCHEPJIM, DKIHEBDFAJK DKGDAEBOJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct HLJADOGCOLP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct FJGIBODABCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BDEHFKIJKJD, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public HLJADOGCOLP self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public FAMECBPCILE root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private PNJEPLMEKHI<BDEHFKIJKJD, GEJJJMKDLKA> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private PNJEPLMEKHI<object?, PKJJHJMDMCJ>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private PNJEPLMEKHI<object?, PKJJHJMDMCJ> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private PNJEPLMEKHI<object?, PKJJHJMDMCJ>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter<PNJEPLMEKHI<object?, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x24F8410", Offset = "0x24F7010", VA = "0x1824F8410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x24F8870", Offset = "0x24F7470", VA = "0x1824F8870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly IReadOnlyList<JCKDHEKPOIA> ADHFFIHONNO;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xBDB470", Offset = "0xBDA070", VA = "0x180BDB470")]
	private HLJADOGCOLP(IReadOnlyList<JCKDHEKPOIA> KMELAGHIBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x24FA0A0", Offset = "0x24F8CA0", VA = "0x1824FA0A0")]
	public static JCKDHEKPOIA ILDFKLEKGBC(IReadOnlyList<JCKDHEKPOIA> KMELAGHIBII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x24FA000", Offset = "0x24F8C00", VA = "0x1824FA000")]
	public static IGLANCPFJMB<BCOHPOMJGNP, HLJADOGCOLP> DJKEMDCHMGJ(JCKDHEKPOIA INOICDEKJOE)
	{
		return default(IGLANCPFJMB<BCOHPOMJGNP, HLJADOGCOLP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x24F9EC0", Offset = "0x24F8AC0", VA = "0x1824F9EC0")]
	[AsyncStateMachine(typeof(FJGIBODABCN))]
	public static Task<PNJEPLMEKHI<BDEHFKIJKJD, GEJJJMKDLKA>> CKMGLNDJKLH(FAMECBPCILE EBMDCHEPJIM, HLJADOGCOLP DKGDAEBOJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct MDNIFNNFLMC
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class BCEIIGFEKCN
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class ADBFIMPIFAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public LFHLJBHJLKP<BCEIIGFEKCN> actionId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public ADBFIMPIFAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x24E5CF0", Offset = "0x24E48F0", VA = "0x1824E5CF0")]
		internal JCKDHEKPOIA HEHNBPDKLDB(int count, int index, [In] ReadOnlySpan<byte> span)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly LFHLJBHJLKP<BCEIIGFEKCN> JBGBLPFKCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly int PHJGKILIPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly int AHDPANGFLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly byte[] JBDHCGELIFD;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x24FD810", Offset = "0x24FC410", VA = "0x1824FD810")]
	private MDNIFNNFLMC(LFHLJBHJLKP<BCEIIGFEKCN> INAINOPOPPP, int EBDKDADIOBA, int BIEEMEKMINN, byte[] LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x24FD570", Offset = "0x24FC170", VA = "0x1824FD570")]
	public static JCKDHEKPOIA ILDFKLEKGBC(LFHLJBHJLKP<BCEIIGFEKCN> INAINOPOPPP, int EBDKDADIOBA, int BIEEMEKMINN, ByteString LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x24FD460", Offset = "0x24FC060", VA = "0x1824FD460")]
	public static JCKDHEKPOIA[] IDBGBIFOCMB(JCKDHEKPOIA OAGMINHECCA, int KOFLHFCAHKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x24FD310", Offset = "0x24FBF10", VA = "0x1824FD310")]
	public static IGLANCPFJMB<BCOHPOMJGNP, MDNIFNNFLMC> DJKEMDCHMGJ(JCKDHEKPOIA INOICDEKJOE)
	{
		return default(IGLANCPFJMB<BCOHPOMJGNP, MDNIFNNFLMC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x24FD680", Offset = "0x24FC280", VA = "0x1824FD680")]
	public static PNJEPLMEKHI<JCKDHEKPOIA, GEJJJMKDLKA> KPDHBIJEMPN(FAMECBPCILE EBMDCHEPJIM, [In] MDNIFNNFLMC DKGDAEBOJKO)
	{
		return default(PNJEPLMEKHI<JCKDHEKPOIA, GEJJJMKDLKA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct EMBPPNGFJBE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct OALGGEEGNNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<bool, HJOMFIPJJDB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public FAMECBPCILE root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public EMBPPNGFJBE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private PNJEPLMEKHI<bool, HJOMFIPJJDB> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, HJOMFIPJJDB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2500E60", Offset = "0x24FFA60", VA = "0x182500E60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x25014A0", Offset = "0x25000A0", VA = "0x1825014A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly int PHJGKILIPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly int AHDPANGFLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly byte[] JBDHCGELIFD;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xAB56E0", Offset = "0xAB42E0", VA = "0x180AB56E0")]
	private EMBPPNGFJBE(int EBDKDADIOBA, int BIEEMEKMINN, byte[] LLDJIJICLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x24EBEA0", Offset = "0x24EAAA0", VA = "0x1824EBEA0")]
	public static JCKDHEKPOIA ILDFKLEKGBC(int EBDKDADIOBA, int BIEEMEKMINN, ByteString LLDJIJICLJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x24EBAA0", Offset = "0x24EA6A0", VA = "0x1824EBAA0")]
	public static JCKDHEKPOIA?[]? AAGJHNAAOOH(int KOFLHFCAHKH, KHCNLKFLBAB? BDMCKILHPML, POJLNBCFFCA? PKGBNKHOGNB, PGMIGGEMMKL? MAGHCEFJIPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x24EBDC0", Offset = "0x24EA9C0", VA = "0x1824EBDC0")]
	public static IGLANCPFJMB<BCOHPOMJGNP, EMBPPNGFJBE> DJKEMDCHMGJ(JCKDHEKPOIA INOICDEKJOE)
	{
		return default(IGLANCPFJMB<BCOHPOMJGNP, EMBPPNGFJBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x24EBC90", Offset = "0x24EA890", VA = "0x1824EBC90")]
	[AsyncStateMachine(typeof(OALGGEEGNNE))]
	public static Task<PNJEPLMEKHI<bool, HJOMFIPJJDB>> CKMGLNDJKLH(FAMECBPCILE EBMDCHEPJIM, EMBPPNGFJBE DKGDAEBOJKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class NBKNFKFADCG : MKADBPKMOJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly FAMECBPCILE PEFFIDGBCHC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public ONKECEIMBGM? FFLNCJPMHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x25000B0", Offset = "0x24FECB0", VA = "0x1825000B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	internal NBKNFKFADCG(FAMECBPCILE JKPOOJNKKFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class NPGGLANEANB : ONKECEIMBGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly FAMECBPCILE PEFFIDGBCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly BFFHCAJILDC LKNEOBMBGIJ;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9677A0", Offset = "0x9663A0", VA = "0x1809677A0")]
	public NPGGLANEANB(FAMECBPCILE JKPOOJNKKFK, BFFHCAJILDC HCIBFGNDAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2500B00", Offset = "0x24FF700", VA = "0x182500B00", Slot = "4")]
	public PNJEPLMEKHI<JDMLLGMMNJP, AHEFNIMCMGM> LGGPMDPNBCK(LFHLJBHJLKP<CALHCHFEDII> HNIBCCHLOFE, ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, ENBGACDEBPI<GBFFCGKIBLH> CKEOHJKPLCO)
	{
		return default(PNJEPLMEKHI<JDMLLGMMNJP, AHEFNIMCMGM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2500820", Offset = "0x24FF420", VA = "0x182500820", Slot = "5")]
	public PNJEPLMEKHI<JDMLLGMMNJP, AHEFNIMCMGM> JOLAMBEIDMD(LFHLJBHJLKP<CALHCHFEDII> HNIBCCHLOFE, ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, ENBGACDEBPI<JCNFOBNEGFN> GDGENKFJMLI)
	{
		return default(PNJEPLMEKHI<JDMLLGMMNJP, AHEFNIMCMGM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class OHGCALJMIBE : BKLFMJCJHKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface HJKHHLLJCMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<BFFHCAJILDC> LOMBDIMFFJK(FAMECBPCILE JKPOOJNKKFK, POJLNBCFFCA? HFCNDBLKEMI, PGMIGGEMMKL? FDOBECGAACK, CancellationToken NAOIMKEDKEJ);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FFLMAEEJCDD DCJDAFHAABH(FAMECBPCILE JKPOOJNKKFK, KHCNLKFLBAB BLBGBHAGDIN);
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class MJBJKOOEJBN : HJKHHLLJCMB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct DDCNKMFHOJH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AsyncTaskMethodBuilder<BFFHCAJILDC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public FAMECBPCILE circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public POJLNBCFFCA cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public PGMIGGEMMKL cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<DADMLIBEGLD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x24EB100", Offset = "0x24E9D00", VA = "0x1824EB100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x24EB2D0", Offset = "0x24E9ED0", VA = "0x1824EB2D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly MJBJKOOEJBN FFLNCJPMHOJ;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		private MJBJKOOEJBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x24FD9E0", Offset = "0x24FC5E0", VA = "0x1824FD9E0", Slot = "4")]
		[AsyncStateMachine(typeof(DDCNKMFHOJH))]
		public Task<BFFHCAJILDC> LOMBDIMFFJK(FAMECBPCILE JKPOOJNKKFK, POJLNBCFFCA? HFCNDBLKEMI, PGMIGGEMMKL? FDOBECGAACK, CancellationToken NAOIMKEDKEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x24FD9C0", Offset = "0x24FC5C0", VA = "0x1824FD9C0", Slot = "5")]
		public FFLMAEEJCDD DCJDAFHAABH(FAMECBPCILE JKPOOJNKKFK, KHCNLKFLBAB BLBGBHAGDIN)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct CFHKJHNDLGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<OHGCALJMIBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public FAMECBPCILE circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public POJLNBCFFCA cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public PGMIGGEMMKL cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public KHCNLKFLBAB evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private HJKHHLLJCMB <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<BFFHCAJILDC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x24E63E0", Offset = "0x24E4FE0", VA = "0x1824E63E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x24E68E0", Offset = "0x24E54E0", VA = "0x1824E68E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly BFFHCAJILDC LKNEOBMBGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly FFLMAEEJCDD BKIEDLKJNDO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public DELENLBBKCB BKMAEFICBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2501750", Offset = "0x2500350", VA = "0x182501750", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public DKLABFLPJCL PPGKBDFKDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2501630", Offset = "0x2500230", VA = "0x182501630", Slot = "5")]
		get
		{
			return default(DKLABFLPJCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public NPGGLANEANB IGOHNHJDIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public NGODBPJEIPG PMKNAIKJCBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xDB6CE0", Offset = "0xDB58E0", VA = "0x180DB6CE0")]
	private OHGCALJMIBE(BFFHCAJILDC HCIBFGNDAHP, FFLMAEEJCDD LHMPGJGABPJ, NPGGLANEANB HCPLDDAHCCB, NGODBPJEIPG JJMMLKNNIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x25017A0", Offset = "0x25003A0", VA = "0x1825017A0")]
	[AsyncStateMachine(typeof(CFHKJHNDLGB))]
	public static Task<OHGCALJMIBE> HMALLHBANCC(FAMECBPCILE JKPOOJNKKFK, KHCNLKFLBAB BLBGBHAGDIN, POJLNBCFFCA? HFCNDBLKEMI, PGMIGGEMMKL? FDOBECGAACK, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x25016F0", Offset = "0x25002F0", VA = "0x1825016F0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class FLDCIAOHJGA : IEFLCGHIFON, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface GILFJLNDKHL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<BKLFMJCJHKB> GANCGJPIHOE(FAMECBPCILE JKPOOJNKKFK, KHCNLKFLBAB BLBGBHAGDIN, POJLNBCFFCA? HFCNDBLKEMI, PGMIGGEMMKL? FDOBECGAACK, CancellationToken NAOIMKEDKEJ);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CKMNPNIANGM();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LCIIPKHPEFL();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class NCBHDNMLDAJ : GILFJLNDKHL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct GDDIPPFPLOL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public AsyncTaskMethodBuilder<BKLFMJCJHKB> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public FAMECBPCILE circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public KHCNLKFLBAB evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public POJLNBCFFCA cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public PGMIGGEMMKL cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private TaskAwaiter<OHGCALJMIBE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x24F9100", Offset = "0x24F7D00", VA = "0x1824F9100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x24F9440", Offset = "0x24F8040", VA = "0x1824F9440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x25001B0", Offset = "0x24FEDB0", VA = "0x1825001B0", Slot = "4")]
		[AsyncStateMachine(typeof(GDDIPPFPLOL))]
		public Task<BKLFMJCJHKB> GANCGJPIHOE(FAMECBPCILE JKPOOJNKKFK, KHCNLKFLBAB BLBGBHAGDIN, POJLNBCFFCA? HFCNDBLKEMI, PGMIGGEMMKL? FDOBECGAACK, CancellationToken NAOIMKEDKEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void CKMNPNIANGM();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void LCIIPKHPEFL();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		protected NCBHDNMLDAJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct MLLMDIKOGFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<BKLFMJCJHKB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public FLDCIAOHJGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<BODKGJBCKHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x24FDF90", Offset = "0x24FCB90", VA = "0x1824FDF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x24FE190", Offset = "0x24FCD90", VA = "0x1824FE190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct CFPGGKCIFFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public FLDCIAOHJGA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public FAMECBPCILE circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public KHCNLKFLBAB evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public POJLNBCFFCA cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public PGMIGGEMMKL cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<BKLFMJCJHKB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x24E6950", Offset = "0x24E5550", VA = "0x1824E6950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x24E6E80", Offset = "0x24E5A80", VA = "0x1824E6E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly GILFJLNDKHL IHDBCEJNIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TaskCompletionSource<BODKGJBCKHC> GCLFJGPOBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly TaskCompletionSource<BODKGJBCKHC> BGEGJPCFDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly CancellationTokenSource KGKLOJNBANF;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FIPLCPLLIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x986300", Offset = "0x984F00", VA = "0x180986300", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x986080", Offset = "0x984C80", VA = "0x180986080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DFIMOLGJAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xC46300", Offset = "0xC44F00", VA = "0x180C46300", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x110F670", Offset = "0x110E270", VA = "0x18110F670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool HNNGGLJNIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1778920", Offset = "0x1777520", VA = "0x181778920")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x24F8A60", Offset = "0x24F7660", VA = "0x1824F8A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public BKLFMJCJHKB? KIGNANOAJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x95CEF0", Offset = "0x95BAF0", VA = "0x18095CEF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x95D140", Offset = "0x95BD40", VA = "0x18095D140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x24F8A70", Offset = "0x24F7670", VA = "0x1824F8A70", Slot = "7")]
	[AsyncStateMachine(typeof(MLLMDIKOGFL))]
	public Task<BKLFMJCJHKB> PELDAEBIMFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x24F8CC0", Offset = "0x24F78C0", VA = "0x1824F8CC0")]
	public FLDCIAOHJGA(GILFJLNDKHL CJMMHNIMOJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x24F8B60", Offset = "0x24F7760", VA = "0x1824F8B60", Slot = "8")]
	[AsyncStateMachine(typeof(CFPGGKCIFFL))]
	public Task PHDLHFBCKLO(FAMECBPCILE JKPOOJNKKFK, KHCNLKFLBAB BLBGBHAGDIN, POJLNBCFFCA? HFCNDBLKEMI, PGMIGGEMMKL? FDOBECGAACK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x24F88E0", Offset = "0x24F74E0", VA = "0x1824F88E0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class AJKDMCBIKLE : LEHABKNJEKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly NGODBPJEIPG CGMLFEFGGLP;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	public AJKDMCBIKLE(NGODBPJEIPG JJMMLKNNIHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal static class MGHAGKLILKO
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class FOMIMFJGIOM<TGraph> : PFLINFPPFJG where TGraph : MKDBBOIDICN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		protected readonly TGraph HBCEDKNKJCE;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual JPMOJNMOFDI? MDALJAAMMPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1596050", Offset = "0x1594C50", VA = "0x181596050", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public ENBGACDEBPI<DGPIFHHHHCH> MLPOHMLJLBB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x4422E80", Offset = "0x4421A80", VA = "0x184422E80", Slot = "5")]
			get
			{
				return default(ENBGACDEBPI<DGPIFHHHHCH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public ENBGACDEBPI<DGPIFHHHHCH>? MMCGGMEHFJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x4422E00", Offset = "0x4421A00", VA = "0x184422E00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
		public FOMIMFJGIOM(TGraph GGBMBLFEJIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class JBFFJJMKDNO : FOMIMFJGIOM<OEDEGEKLNDI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override JPMOJNMOFDI? MDALJAAMMPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x24FAC50", Offset = "0x24F9850", VA = "0x1824FAC50", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x24FAC70", Offset = "0x24F9870", VA = "0x1824FAC70")]
		public JBFFJJMKDNO(OEDEGEKLNDI GGPFEKLNHGN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x24FD830", Offset = "0x24FC430", VA = "0x1824FD830")]
	public static PFLINFPPFJG JPHABLICNHB(MKDBBOIDICN GGBMBLFEJIF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class COEGKLDIKHF : IEKFOPGJECA, NIONFIGLCKL, GJPMPHEFBOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class CODACBOCDLB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public CODACBOCDLB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public MBINOHCLPKN errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x2502850", Offset = "0x2501450", VA = "0x182502850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x2502AC0", Offset = "0x25016C0", VA = "0x182502AC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public COEGKLDIKHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public CODACBOCDLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x24E6FC0", Offset = "0x24E5BC0", VA = "0x1824E6FC0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task HCHNEEBCCKC(MBINOHCLPKN errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct ACOLMJNJKMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public COEGKLDIKHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x24E5780", Offset = "0x24E4380", VA = "0x1824E5780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x24E5C90", Offset = "0x24E4890", VA = "0x1824E5C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class MLHNGJLKDIJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public MLHNGJLKDIJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x2502B20", Offset = "0x2501720", VA = "0x182502B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x2502E00", Offset = "0x2501A00", VA = "0x182502E00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public COEGKLDIKHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public MLHNGJLKDIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x24FDEC0", Offset = "0x24FCAC0", VA = "0x1824FDEC0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task LFDOGOLHOEF(MBINOHCLPKN errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly MJFKIBKLKDD FNNIKEIFBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly ICollection<DBGAIKOKDNG> CHGCOPPCHIB;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private JJOBOHLBIDN ADPFGNLLLFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x24E73B0", Offset = "0x24E5FB0", VA = "0x1824E73B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public ENBGACDEBPI<GBFFCGKIBLH> HEFPODHMGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xD75340", Offset = "0xD73F40", VA = "0x180D75340", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(ENBGACDEBPI<GBFFCGKIBLH>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xD74780", Offset = "0xD73380", VA = "0x180D74780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private ENBGACDEBPI<NKPIAFBIEBF> FEJGMFAMMFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x110CF70", Offset = "0x110BB70", VA = "0x18110CF70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public ENBGACDEBPI<NKOHBHOJOIJ> DJNGHHFIBGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x97FE30", Offset = "0x97EA30", VA = "0x18097FE30", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(ENBGACDEBPI<NKOHBHOJOIJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override ENBGACDEBPI<JDGCKBCLIAF> BDBIIAAAJLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x24E93D0", Offset = "0x24E7FD0", VA = "0x1824E93D0", Slot = "21")]
		get
		{
			return default(ENBGACDEBPI<JDGCKBCLIAF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool LMMJBIEGDKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x24E9420", Offset = "0x24E8020", VA = "0x1824E9420", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x24E98E0", Offset = "0x24E84E0", VA = "0x1824E98E0")]
	private COEGKLDIKHF(FAMECBPCILE JKPOOJNKKFK, LJNEMHENPLP PCMPEACCDMA, MJFKIBKLKDD AEMADKEAPOB, ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, ENBGACDEBPI<GBFFCGKIBLH> CKEOHJKPLCO, ENBGACDEBPI<NKPIAFBIEBF> BHGEFCDONFK, bool BIODMIKFGFC, string BGKKCEGMOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x24E8C50", Offset = "0x24E7850", VA = "0x1824E8C50")]
	public static COEGKLDIKHF JPHABLICNHB(FAMECBPCILE JKPOOJNKKFK, LJNEMHENPLP PCMPEACCDMA, MJFKIBKLKDD CPPOMEHPJCH, ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, ENBGACDEBPI<NKPIAFBIEBF> BHGEFCDONFK, ENBGACDEBPI<GBFFCGKIBLH> CKEOHJKPLCO, bool BIODMIKFGFC, bool DMADAMBBKKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x24E70B0", Offset = "0x24E5CB0", VA = "0x1824E70B0", Slot = "22")]
	protected override void AIMKJDEKJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x24E73D0", Offset = "0x24E5FD0", VA = "0x1824E73D0", Slot = "23")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x24E9880", Offset = "0x24E8480", VA = "0x1824E9880", Slot = "31")]
	public void PMHEOCIPFFP(DBGAIKOKDNG IIMGCHEJKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x24E82F0", Offset = "0x24E6EF0", VA = "0x1824E82F0", Slot = "28")]
	public void GONKJPAEGME(GJCOAPKCFKD OEKLFCDODDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x24E7540", Offset = "0x24E6140", VA = "0x1824E7540", Slot = "29")]
	public void EFJIOBCCABG(FALDLKPNMAN AEGAGOGLKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x24E9730", Offset = "0x24E8330", VA = "0x1824E9730", Slot = "24")]
	protected override void PGPGIGPLHLB(PLGCMHMLCPK FJECIINKNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x24E9270", Offset = "0x24E7E70", VA = "0x1824E9270", Slot = "33")]
	public string NKLNOPACKKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x24E8030", Offset = "0x24E6C30", VA = "0x1824E8030", Slot = "30")]
	public string FPNJLPHIAND(int NGOEEBFMFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x24E8660", Offset = "0x24E7260", VA = "0x1824E8660")]
	private void GOOCPKIBFFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x24E9000", Offset = "0x24E7C00", VA = "0x1824E9000", Slot = "32")]
	public void LKECJBKOEOC(DBGAIKOKDNG IIMGCHEJKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x24E94A0", Offset = "0x24E80A0", VA = "0x1824E94A0")]
	private void OMLIJIKGFLH(bool MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x24E8890", Offset = "0x24E7490", VA = "0x1824E8890", Slot = "34")]
	[AsyncStateMachine(typeof(ACOLMJNJKMJ))]
	public Task IHBHFKNPBLB(string MPDLOLIOGJL, bool HMJOCKGIAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x24E7EE0", Offset = "0x24E6AE0", VA = "0x1824E7EE0")]
	public void FAHPJCJLCJB(string MPDLOLIOGJL, bool HMJOCKGIAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x24E8AB0", Offset = "0x24E76B0", VA = "0x1824E8AB0")]
	private void JOLANAFHOAO(int MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0xD74780", Offset = "0xD73380", VA = "0x180D74780")]
	internal void EDLBILEOFJA(ENBGACDEBPI<GBFFCGKIBLH> MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x24E9190", Offset = "0x24E7D90", VA = "0x1824E9190")]
	[CompilerGenerated]
	private void NFCAFACIICP(string MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x24E7150", Offset = "0x24E5D50", VA = "0x1824E7150")]
	[CompilerGenerated]
	private bool AJNGPIAJGLO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x24E89A0", Offset = "0x24E75A0", VA = "0x1824E89A0")]
	[CompilerGenerated]
	private bool JGNCANNDBHN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x24E90C0", Offset = "0x24E7CC0", VA = "0x1824E90C0")]
	[CompilerGenerated]
	private int MJBAAMINOKP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x24E72A0", Offset = "0x24E5EA0", VA = "0x1824E72A0")]
	[CompilerGenerated]
	private bool BIFAFKOMJOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x24E7470", Offset = "0x24E6070", VA = "0x1824E7470")]
	[CompilerGenerated]
	private void EDAODDNGIDG(string MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x24E7480", Offset = "0x24E6080", VA = "0x1824E7480")]
	[CompilerGenerated]
	private bool EDHBAKKBKDD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x24E8A60", Offset = "0x24E7660", VA = "0x1824E8A60")]
	[CompilerGenerated]
	private bool JKFCCKKJCML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x24E7210", Offset = "0x24E5E10", VA = "0x1824E7210")]
	[CompilerGenerated]
	private bool BGICLJALBFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x24E90C0", Offset = "0x24E7CC0", VA = "0x1824E90C0")]
	[CompilerGenerated]
	private int MGOFAGOLJDM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x24E9660", Offset = "0x24E8260", VA = "0x1824E9660")]
	[CompilerGenerated]
	private bool ONEMAAAKBEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x24E9110", Offset = "0x24E7D10", VA = "0x1824E9110")]
	[CompilerGenerated]
	private object NEDLADCFIOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x24E7330", Offset = "0x24E5F30", VA = "0x1824E7330")]
	[CompilerGenerated]
	private void BKJHHIFJHMO(object MPDLOLIOGJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x24E91A0", Offset = "0x24E7DA0", VA = "0x1824E91A0")]
	[CompilerGenerated]
	private bool NHJAAGOAACK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CPLECPHBOCA
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private sealed class NIPDIPNBOCO : LLFAKGDCGIP<AGGKFBGPFAK>
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class HLMIEFBCIHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public NIPDIPNBOCO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public HLMIEFBCIHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x24FA160", Offset = "0x24F8D60", VA = "0x1824FA160")]
			internal object ECKGNBOKHAD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x24FA1D0", Offset = "0x24F8DD0", VA = "0x1824FA1D0")]
			internal void IODFOKGBFJC(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x25005A0", Offset = "0x24FF1A0", VA = "0x1825005A0")]
		public NIPDIPNBOCO(FAMECBPCILE JKPOOJNKKFK, AGGKFBGPFAK FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2500310", Offset = "0x24FEF10", VA = "0x182500310", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class FHGNHAHCOBM : NPFMMHGJODH<CGLCDKHHMJD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override IPBDEJGDKMN IKGNOOAGKHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA7F430", Offset = "0xA7E030", VA = "0x180A7F430", Slot = "138")]
			get
			{
				return default(IPBDEJGDKMN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x24F83B0", Offset = "0x24F6FB0", VA = "0x1824F83B0")]
		public FHGNHAHCOBM(FAMECBPCILE JKPOOJNKKFK, CGLCDKHHMJD FOBBPKHANPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class PKECJLIJMCF : LLFAKGDCGIP<KGFLNPJJEID>
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x25020F0", Offset = "0x2500CF0", VA = "0x1825020F0")]
		public PKECJLIJMCF(FAMECBPCILE JKPOOJNKKFK, KGFLNPJJEID PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x2501E40", Offset = "0x2500A40", VA = "0x182501E40", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x2501DF0", Offset = "0x25009F0", VA = "0x182501DF0")]
		[CompilerGenerated]
		private bool COJPFNECABF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2501FC0", Offset = "0x2500BC0", VA = "0x182501FC0")]
		[CompilerGenerated]
		private void NKJFLDLNNNL(bool MPDLOLIOGJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class DDKFOJCKJHD : LLFAKGDCGIP<PKNJANNCFEP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class IHOIGGHFIOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public DDKFOJCKJHD <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public IHOIGGHFIOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x24FA5D0", Offset = "0x24F91D0", VA = "0x1824FA5D0")]
			internal void ECKGNBOKHAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x24FA670", Offset = "0x24F9270", VA = "0x1824FA670")]
			internal bool IODFOKGBFJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x24FA450", Offset = "0x24F9050", VA = "0x1824FA450")]
			internal bool APCHIBOENLE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x24FA4A0", Offset = "0x24F90A0", VA = "0x1824FA4A0")]
			internal void CFKDKHFDFHN(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x24FA620", Offset = "0x24F9220", VA = "0x1824FA620")]
			internal bool HGCJLPFAHJL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x24EB680", Offset = "0x24EA280", VA = "0x1824EB680")]
		public DDKFOJCKJHD(FAMECBPCILE JKPOOJNKKFK, PKNJANNCFEP PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x24EB340", Offset = "0x24E9F40", VA = "0x1824EB340", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class GOBHCGJODDF : LLFAKGDCGIP<NAGNHLBJDGM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class JHMKOEPCLIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public GOBHCGJODDF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public JHMKOEPCLIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x24FB5E0", Offset = "0x24FA1E0", VA = "0x1824FB5E0")]
			internal object ECKGNBOKHAD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x24FB3E0", Offset = "0x24F9FE0", VA = "0x1824FB3E0")]
			internal bool BOLAFHBOCHN(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x24FB750", Offset = "0x24FA350", VA = "0x1824FB750")]
			internal void IODFOKGBFJC(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x24FB270", Offset = "0x24F9E70", VA = "0x1824FB270")]
			internal string APCHIBOENLE(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x24FB460", Offset = "0x24FA060", VA = "0x1824FB460")]
			internal IReadOnlyList<object> CFKDKHFDFHN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x24FB6E0", Offset = "0x24FA2E0", VA = "0x1824FB6E0")]
			internal bool HGCJLPFAHJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x24FB9B0", Offset = "0x24FA5B0", VA = "0x1824FB9B0")]
			internal bool JDNCLAOOCPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x24FB4B0", Offset = "0x24FA0B0", VA = "0x1824FB4B0")]
			internal void EBJCNPJBEJG(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x24F9DE0", Offset = "0x24F89E0", VA = "0x1824F9DE0")]
		public GOBHCGJODDF(FAMECBPCILE JKPOOJNKKFK, NAGNHLBJDGM PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x24F9690", Offset = "0x24F8290", VA = "0x1824F9690", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class BLLANOBKMKH : LLFAKGDCGIP<EPMDOEEOMKM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class IOPLONIBKFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public BLLANOBKMKH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public IOPLONIBKFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x24FAAD0", Offset = "0x24F96D0", VA = "0x1824FAAD0")]
			internal bool ECKGNBOKHAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x24FAB20", Offset = "0x24F9720", VA = "0x1824FAB20")]
			internal void IODFOKGBFJC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x24FAA80", Offset = "0x24F9680", VA = "0x1824FAA80")]
			internal bool APCHIBOENLE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x24E6370", Offset = "0x24E4F70", VA = "0x1824E6370")]
		public BLLANOBKMKH(FAMECBPCILE JKPOOJNKKFK, EPMDOEEOMKM PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x24E6140", Offset = "0x24E4D40", VA = "0x1824E6140", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class FBCEFDDOKPD<TNode> : LLFAKGDCGIP<TNode> where TNode : notnull, FCCGCFOGDGI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct IHMEMJEPPLD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public AsyncTaskMethodBuilder<PNJEPLMEKHI<ENBGACDEBPI<IEOKEELCLHA>, GEJJJMKDLKA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public FBCEFDDOKPD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private TaskAwaiter<PNJEPLMEKHI<ENBGACDEBPI<IEOKEELCLHA>, GEJJJMKDLKA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x46FE0F0", Offset = "0x46FCCF0", VA = "0x1846FE0F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x46FE510", Offset = "0x46FD110", VA = "0x1846FE510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct ODELBPJCKCF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public FBCEFDDOKPD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public ENBGACDEBPI<IEOKEELCLHA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x4F705D0", Offset = "0x4F6F1D0", VA = "0x184F705D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x4F709F0", Offset = "0x4F6F5F0", VA = "0x184F709F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override bool BJKMHFIBGCN
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public sealed override ENBGACDEBPI<IEOKEELCLHA>? AHEEEHMNEOD
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x438A730", Offset = "0x4389330", VA = "0x18438A730", Slot = "131")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x438A6E0", Offset = "0x43892E0", VA = "0x18438A6E0")]
		protected FBCEFDDOKPD(FAMECBPCILE JKPOOJNKKFK, TNode PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x438A520", Offset = "0x4389120", VA = "0x18438A520", Slot = "112")]
		[AsyncStateMachine(typeof(FBCEFDDOKPD<>.IHMEMJEPPLD))]
		public override Task<PNJEPLMEKHI<ENBGACDEBPI<IEOKEELCLHA>, GEJJJMKDLKA>> MBGKBOGINKG(string BGKKCEGMOKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x438A370", Offset = "0x4388F70", VA = "0x18438A370", Slot = "136")]
		public sealed override bool FPHCNJJKEGJ(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x438A640", Offset = "0x4389240", VA = "0x18438A640", Slot = "124")]
		protected sealed override bool MDBNHGLBHIP(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x438A2D0", Offset = "0x4388ED0", VA = "0x18438A2D0", Slot = "125")]
		protected override bool CHIJJHCICDN(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x438A410", Offset = "0x4389010", VA = "0x18438A410", Slot = "113")]
		[AsyncStateMachine(typeof(FBCEFDDOKPD<>.ODELBPJCKCF))]
		public override Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> HNGHMHLJJLI(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class JEKMFGCEBBL : FKBLAAIAIDN<MKOLNFGOFDM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class JLLIKJGJGKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public JEKMFGCEBBL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public JLLIKJGJGKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x24FBAC0", Offset = "0x24FA6C0", VA = "0x1824FBAC0")]
			internal bool OGBCDOPDHMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x24FBA00", Offset = "0x24FA600", VA = "0x1824FBA00")]
			internal void GOMGGBCIMOO(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x24FAF90", Offset = "0x24F9B90", VA = "0x1824FAF90")]
		public JEKMFGCEBBL(FAMECBPCILE JKPOOJNKKFK, MKOLNFGOFDM FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x24FAD40", Offset = "0x24F9940", VA = "0x1824FAD40", Slot = "138")]
		protected override void GMHOCGONOMO(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class DEPCJPBBJJP : HFMAADDLBNH<JGGLNBCAPJN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xA78B70", Offset = "0xA77770", VA = "0x180A78B70", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x24EB6F0", Offset = "0x24EA2F0", VA = "0x1824EB6F0")]
		public DEPCJPBBJJP(FAMECBPCILE JKPOOJNKKFK, JGGLNBCAPJN PCMPEACCDMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public abstract class HFMAADDLBNH<TNode> : LLFAKGDCGIP<TNode> where TNode : notnull, KPLHJJGBEMO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct IJLEKDABLIE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public AsyncTaskMethodBuilder<PNJEPLMEKHI<ENBGACDEBPI<IEOKEELCLHA>, GEJJJMKDLKA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public HFMAADDLBNH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private TaskAwaiter<PNJEPLMEKHI<ENBGACDEBPI<IEOKEELCLHA>, GEJJJMKDLKA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x4706740", Offset = "0x4705340", VA = "0x184706740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x4706C00", Offset = "0x4705800", VA = "0x184706C00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct JNLODIHELEI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public HFMAADDLBNH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public ENBGACDEBPI<IEOKEELCLHA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x4949E50", Offset = "0x4948A50", VA = "0x184949E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x494A2E0", Offset = "0x4948EE0", VA = "0x18494A2E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct KABCLMPAIJF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<PNJEPLMEKHI<BDEHFKIJKJD, GEJJJMKDLKA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public HFMAADDLBNH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private TaskAwaiter<PNJEPLMEKHI<BDEHFKIJKJD, GEJJJMKDLKA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x4A04E10", Offset = "0x4A03A10", VA = "0x184A04E10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x4A054E0", Offset = "0x4A040E0", VA = "0x184A054E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class DGJCGAFOGHM
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000051")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public DGJCGAFOGHM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0x3CADE70", Offset = "0x3CACA70", VA = "0x183CADE70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000152")]
				[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public EFGCLJPHEPI configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public HFMAADDLBNH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public DGJCGAFOGHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x630D080", Offset = "0x630BC80", VA = "0x18630D080")]
			internal bool EBJCNPJBEJG(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x630D160", Offset = "0x630BD60", VA = "0x18630D160")]
			internal void ECKGNBOKHAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x630CFE0", Offset = "0x630BBE0", VA = "0x18630CFE0")]
			[AsyncStateMachine(typeof(HFMAADDLBNH<>.DGJCGAFOGHM.<<BuildConfigMenuInternal>b__7>d))]
			internal void BOLAFHBOCHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x630D450", Offset = "0x630C050", VA = "0x18630D450")]
			internal bool IODFOKGBFJC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class FDLFHFKHCAP
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				public FDLFHFKHCAP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x3CADAF0", Offset = "0x3CAC6F0", VA = "0x183CADAF0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public DGJCGAFOGHM CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public FDLFHFKHCAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x438F500", Offset = "0x438E100", VA = "0x18438F500")]
			internal void APCHIBOENLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
			internal string CFKDKHFDFHN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
			internal void HGCJLPFAHJL(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x438F8B0", Offset = "0x438E4B0", VA = "0x18438F8B0")]
			[AsyncStateMachine(typeof(HFMAADDLBNH<>.FDLFHFKHCAP.<<BuildConfigMenuInternal>b__5>d))]
			internal void JDNCLAOOCPA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class BAGCDACFJDA
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				public BAGCDACFJDA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x3CAD620", Offset = "0x3CAC220", VA = "0x183CAD620", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000056")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				public BAGCDACFJDA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				private TaskAwaiter<PNJEPLMEKHI<ENBGACDEBPI<NKPIAFBIEBF>, GEJJJMKDLKA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x3CAD800", Offset = "0x3CAC400", VA = "0x183CAD800", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000057")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				public BAGCDACFJDA <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				private TaskAwaiter<PNJEPLMEKHI<ENBGACDEBPI<KANNHDBHICO>, GEJJJMKDLKA>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x3CACF50", Offset = "0x3CABB50", VA = "0x183CACF50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public HFMAADDLBNH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public ENBGACDEBPI<IEOKEELCLHA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public EFGCLJPHEPI configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public LAPGJAKNNOF nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public OFHLJOHAOPH selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public List<GMAOOIBOAHF> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public OFHLJOHAOPH selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public List<GMAOOIBOAHF> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public BAGCDACFJDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x57E83D0", Offset = "0x57E6FD0", VA = "0x1857E83D0")]
			internal bool GJGDDKFCOBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x57E8860", Offset = "0x57E7460", VA = "0x1857E8860")]
			internal void NKIIOACGPGM(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x57E8480", Offset = "0x57E7080", VA = "0x1857E8480")]
			internal bool HJMBIHIANAO(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x57E8630", Offset = "0x57E7230", VA = "0x1857E8630")]
			internal bool JKMCAODIAHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x57E8670", Offset = "0x57E7270", VA = "0x1857E8670")]
			[AsyncStateMachine(typeof(HFMAADDLBNH<>.BAGCDACFJDA.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void KLCBAACKJFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x57E8440", Offset = "0x57E7040", VA = "0x1857E8440")]
			internal bool GLPHPHAKHJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x57E88D0", Offset = "0x57E74D0", VA = "0x1857E88D0")]
			internal void NMNMCAICDGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x57E8320", Offset = "0x57E6F20", VA = "0x1857E8320")]
			internal bool BOIEHBKJIHE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x57E8A70", Offset = "0x57E7670", VA = "0x1857E8A70")]
			internal void PIACJPOILGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x57E87B0", Offset = "0x57E73B0", VA = "0x1857E87B0")]
			internal bool NBOBBFFDBAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x57E8A00", Offset = "0x57E7600", VA = "0x1857E8A00")]
			internal bool PHIKBENCKAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x57E8990", Offset = "0x57E7590", VA = "0x1857E8990")]
			internal void OOOHFMKKKEI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x57E8710", Offset = "0x57E7310", VA = "0x1857E8710")]
			[AsyncStateMachine(typeof(HFMAADDLBNH<>.BAGCDACFJDA.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void MOAIDLAOPEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x57E82C0", Offset = "0x57E6EC0", VA = "0x1857E82C0")]
			internal bool BDEPMPADHAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x57E8250", Offset = "0x57E6E50", VA = "0x1857E8250")]
			internal bool BANLKBALADF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x57E8560", Offset = "0x57E7160", VA = "0x1857E8560")]
			internal void IMMBMEGFGPJ(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x57E81B0", Offset = "0x57E6DB0", VA = "0x1857E81B0")]
			[AsyncStateMachine(typeof(HFMAADDLBNH<>.BAGCDACFJDA.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void AGEDHFPCMJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x57E85D0", Offset = "0x57E71D0", VA = "0x1857E85D0")]
			internal bool JKJKDFFMCPO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class JKBKJCOLBAF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public JKBKJCOLBAF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0x3CAD240", Offset = "0x3CABE40", VA = "0x183CAD240", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public BAGCDACFJDA CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public JKBKJCOLBAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x493FD60", Offset = "0x493E960", VA = "0x18493FD60")]
			internal void NDOGPBBBNJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
			internal string NOBKFKOONFI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
			internal void BEJHALKFELL(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x4940180", Offset = "0x493ED80", VA = "0x184940180")]
			[AsyncStateMachine(typeof(HFMAADDLBNH<>.JKBKJCOLBAF.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void OAFFEKFOFIK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class IJNBKFBEEHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public LAPGJAKNNOF nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public List<GMAOOIBOAHF> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public HFMAADDLBNH<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public ENBGACDEBPI<IEOKEELCLHA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public IJNBKFBEEHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x4706C70", Offset = "0x4705870", VA = "0x184706C70")]
			internal bool KKEAAKMIIDI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class ILNJBFOKNOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public GJPMPHEFBOE port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public IJNBKFBEEHC CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public ILNJBFOKNOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x470C660", Offset = "0x470B260", VA = "0x18470C660")]
			internal void OFFOFBOFOBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x470C4F0", Offset = "0x470B0F0", VA = "0x18470C4F0")]
			internal bool MICFHIJENAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x470C540", Offset = "0x470B140", VA = "0x18470C540")]
			internal void MKMCECJKPDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x470C490", Offset = "0x470B090", VA = "0x18470C490")]
			internal bool FFAGOCMCKHJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class DJIJDJFBJNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public GMAOOIBOAHF portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public ILNJBFOKNOI CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public DJIJDJFBJNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x631DCB0", Offset = "0x631C8B0", VA = "0x18631DCB0")]
			internal void BDFHHNCDKHM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class PLIKJEBJIAH
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				public PLIKJEBJIAH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000189")]
				[Cpp2IlInjected.Address(RVA = "0x3CAF2E0", Offset = "0x3CADEE0", VA = "0x183CAF2E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public OFHLJOHAOPH selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public LAPGJAKNNOF nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public GJPMPHEFBOE port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public PLIKJEBJIAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x5059FE0", Offset = "0x5058BE0", VA = "0x185059FE0")]
			internal int BDEBOGOOPNC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x505A0E0", Offset = "0x5058CE0", VA = "0x18505A0E0")]
			internal void MNLMAGMOKKB(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x95CEF0", Offset = "0x95BAF0", VA = "0x18095CEF0")]
			internal string NADHLBIMFGJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x505A020", Offset = "0x5058C20", VA = "0x18505A020")]
			[AsyncStateMachine(typeof(HFMAADDLBNH<>.PLIKJEBJIAH.<<CreatePortItemV2>b__3>d))]
			internal void MLBMLLKCHBP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x505A330", Offset = "0x5058F30", VA = "0x18505A330")]
			internal bool OIIAGONLDOG(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly Dictionary<ENBGACDEBPI<IEOKEELCLHA>, bool> DEIBCNGNFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly Dictionary<ENBGACDEBPI<IEOKEELCLHA>, bool> NGAPHNFOBCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly Dictionary<ENBGACDEBPI<IEOKEELCLHA>, bool> HPIBFOHMGIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private Dictionary<ENBGACDEBPI<IEOKEELCLHA>, bool> LGOALEAONCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<ENBGACDEBPI<IEOKEELCLHA>, bool> MBJIHPACENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private Dictionary<ENBGACDEBPI<IEOKEELCLHA>, bool> NAGMEKGFMOL;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool CGIJHAMNCCI
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "134")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool OMDDACMJDGC
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "138")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool AHHCKOEAIHK
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "139")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected virtual bool CLDICBDOMLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override ENBGACDEBPI<DGPIFHHHHCH>? AIBEGIJMEAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x45AC9C0", Offset = "0x45AB5C0", VA = "0x1845AC9C0", Slot = "128")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ENBGACDEBPI<IEOKEELCLHA>? AHEEEHMNEOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x45ACC90", Offset = "0x45AB890", VA = "0x1845ACC90", Slot = "131")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override IEnumerable<LFHLJBHJLKP<CALHCHFEDII>>? ELKCDKJFGOO
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x45ACA80", Offset = "0x45AB680", VA = "0x1845ACA80", Slot = "123")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x45AC7A0", Offset = "0x45AB3A0", VA = "0x1845AC7A0")]
		public HFMAADDLBNH(FAMECBPCILE JKPOOJNKKFK, TNode PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "141")]
		protected virtual bool IJOCFMJPGEH(int DKECDNLKHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "142")]
		protected virtual bool LDPCKLKFBNP(int DKECDNLKHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "143")]
		protected virtual bool KMPEAEDCEOD(int DKECDNLKHOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "144")]
		protected virtual void MIDOOACEMKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x45A9B20", Offset = "0x45A8720", VA = "0x1845A9B20", Slot = "136")]
		public override bool FPHCNJJKEGJ(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x45AB880", Offset = "0x45AA480", VA = "0x1845AB880", Slot = "112")]
		[AsyncStateMachine(typeof(HFMAADDLBNH<>.IJLEKDABLIE))]
		public override Task<PNJEPLMEKHI<ENBGACDEBPI<IEOKEELCLHA>, GEJJJMKDLKA>> MBGKBOGINKG(string BGKKCEGMOKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x45A9CC0", Offset = "0x45A88C0", VA = "0x1845A9CC0", Slot = "113")]
		[AsyncStateMachine(typeof(HFMAADDLBNH<>.JNLODIHELEI))]
		public override Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> HNGHMHLJJLI(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x45AC580", Offset = "0x45AB180", VA = "0x1845AC580", Slot = "114")]
		public override void PBKAMELKEJC(ENBGACDEBPI<IEOKEELCLHA> BIEEMEKMINN, ENBGACDEBPI<IEOKEELCLHA> EJGAMJDEIEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x45AC300", Offset = "0x45AAF00", VA = "0x1845AC300", Slot = "115")]
		public override IEnumerable<JCKDHEKPOIA> ONNCPLDEEFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x45A9BC0", Offset = "0x45A87C0", VA = "0x1845A9BC0")]
		[AsyncStateMachine(typeof(HFMAADDLBNH<>.KABCLMPAIJF))]
		private Task<PNJEPLMEKHI<BDEHFKIJKJD, GEJJJMKDLKA>> HEDFLCPHNEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "145")]
		protected virtual bool NOFIJGEOBOO(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "146")]
		protected virtual bool MPGHDALKCDN(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "147")]
		protected virtual bool GIOABFKDAEH(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "148")]
		protected virtual bool EDFMDFOGEDN(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "149")]
		protected virtual bool HDMAJMBONCI(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, int KIANILGALBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "150")]
		protected virtual bool PAGHCHJLDOD(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, int KIANILGALBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "151")]
		protected virtual bool LCEIDCGIJOH(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, int AEJHPJAJIKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "152")]
		protected virtual bool DABPNMEBNGC(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, int AEJHPJAJIKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "153")]
		protected virtual bool PPHDMHJOFPN(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, int KLJFFOHNJFC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "154")]
		protected virtual bool JHADNPFDMLL(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, int LIILEGNGJIN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x45AB5E0", Offset = "0x45AA1E0", VA = "0x1845AB5E0", Slot = "155")]
		protected virtual List<OFHLJOHAOPH> LOBNDAMJLJE(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "156")]
		protected virtual void LPOOMDOLDBP(EFGCLJPHEPI GHDIMMIOLAG, MKDPKLMMABI GJBINEDECGN, LAPGJAKNNOF GONEFAKEFLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x45A7F60", Offset = "0x45A6B60", VA = "0x1845A7F60", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x45A9DD0", Offset = "0x45A89D0", VA = "0x1845A9DD0")]
		private MKDPKLMMABI JEPCLHEOKEI(EFGCLJPHEPI GHDIMMIOLAG, LAPGJAKNNOF GONEFAKEFLI, ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x45A89D0", Offset = "0x45A75D0", VA = "0x1845A89D0")]
		private List<GMAOOIBOAHF> FMJCPNLLDNO(EFGCLJPHEPI GHDIMMIOLAG, LAPGJAKNNOF GONEFAKEFLI, MKDPKLMMABI FEIFEIFGDAG, bool FFLPFHIJDHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x45AB9A0", Offset = "0x45AA5A0", VA = "0x1845AB9A0")]
		private List<GMAOOIBOAHF> OEKLMKEALLF(EFGCLJPHEPI GHDIMMIOLAG, LAPGJAKNNOF GONEFAKEFLI, GJPMPHEFBOE JCJFNFCDOLA, bool FFLPFHIJDHD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x45A7D70", Offset = "0x45A6970", VA = "0x1845A7D70")]
		private OFHLJOHAOPH CHDECJHMPCL(List<OFHLJOHAOPH> GGEJLGCCDPL, GJPMPHEFBOE JCJFNFCDOLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x45AB550", Offset = "0x45AA150", VA = "0x1845AB550")]
		[CompilerGenerated]
		private JCKDHEKPOIA KEHNOMBDOGJ(LJNEMHENPLP GFMJIHODIPC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class MDLHDCHAHEK : LLFAKGDCGIP<KHBCHIPNFPO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class CMODAALJOAF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public MDLHDCHAHEK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public CMODAALJOAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x24E6EE0", Offset = "0x24E5AE0", VA = "0x1824E6EE0")]
			internal int ECKGNBOKHAD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x24E6F30", Offset = "0x24E5B30", VA = "0x1824E6F30")]
			internal void IODFOKGBFJC(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xEE17D0", Offset = "0xEE03D0", VA = "0x180EE17D0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x24FD2A0", Offset = "0x24FBEA0", VA = "0x1824FD2A0")]
		public MDLHDCHAHEK(FAMECBPCILE JKPOOJNKKFK, KHBCHIPNFPO PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x24FD0E0", Offset = "0x24FBCE0", VA = "0x1824FD0E0", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class KMPIDENJGDD : FKBLAAIAIDN<HJMKFBNJLCA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private sealed class ODDCECGFIIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public KMPIDENJGDD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public ODDCECGFIIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x25015B0", Offset = "0x25001B0", VA = "0x1825015B0")]
			internal int OGBCDOPDHMA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x2501510", Offset = "0x2500110", VA = "0x182501510")]
			internal void GOMGGBCIMOO(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x24FBFD0", Offset = "0x24FABD0", VA = "0x1824FBFD0")]
		public KMPIDENJGDD(FAMECBPCILE JKPOOJNKKFK, HJMKFBNJLCA FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x24FBD90", Offset = "0x24FA990", VA = "0x1824FBD90", Slot = "138")]
		protected override void GMHOCGONOMO(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private sealed class HKMGOCJPHDB : LLFAKGDCGIP<PMPIMIAMPHN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xC084D0", Offset = "0xC070D0", VA = "0x180C084D0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x24F9E50", Offset = "0x24F8A50", VA = "0x1824F9E50")]
		public HKMGOCJPHDB(FAMECBPCILE JKPOOJNKKFK, PMPIMIAMPHN PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class NBBNHCEHAHA : LLFAKGDCGIP<GLAJKNBGNNA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class EMGGBKPFBAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public NBBNHCEHAHA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public EFGCLJPHEPI configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public EMGGBKPFBAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x24F3470", Offset = "0x24F2070", VA = "0x1824F3470")]
			internal bool ECKGNBOKHAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x24F4AC0", Offset = "0x24F36C0", VA = "0x1824F4AC0")]
			internal void IODFOKGBFJC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x24F4310", Offset = "0x24F2F10", VA = "0x1824F4310")]
			internal bool HGCJLPFAHJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x24F4D50", Offset = "0x24F3950", VA = "0x1824F4D50")]
			internal bool JDNCLAOOCPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x24F33C0", Offset = "0x24F1FC0", VA = "0x1824F33C0")]
			internal void EBJCNPJBEJG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x24F3110", Offset = "0x24F1D10", VA = "0x1824F3110")]
			internal bool DOIEFLDMNNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x24F40C0", Offset = "0x24F2CC0", VA = "0x1824F40C0")]
			internal bool HCAMHFPCDIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x24F55B0", Offset = "0x24F41B0", VA = "0x1824F55B0")]
			internal void LJJAJDDHMNM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x24F6900", Offset = "0x24F5500", VA = "0x1824F6900")]
			internal bool PDIFDFEJLMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x24F63D0", Offset = "0x24F4FD0", VA = "0x1824F63D0")]
			internal bool OBBCHLCNPMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x24F54B0", Offset = "0x24F40B0", VA = "0x1824F54B0")]
			internal void LEGCGCHLKMF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x24EC020", Offset = "0x24EAC20", VA = "0x1824EC020")]
			internal bool AEAENEEIAIN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x24F6BD0", Offset = "0x24F57D0", VA = "0x1824F6BD0")]
			internal bool PNNDKANNLBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x24F6C20", Offset = "0x24F5820", VA = "0x1824F6C20")]
			internal bool POMBCDHEJPL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x24F3ED0", Offset = "0x24F2AD0", VA = "0x1824F3ED0")]
			internal bool GLPEFFKGFEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x24F62C0", Offset = "0x24F4EC0", VA = "0x1824F62C0")]
			internal bool NNMLNDPIPOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x24EBFD0", Offset = "0x24EABD0", VA = "0x1824EBFD0")]
			internal bool ADPNMDFIOPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x24F4B20", Offset = "0x24F3720", VA = "0x1824F4B20")]
			internal bool IPFNFIPPHGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x24EBF80", Offset = "0x24EAB80", VA = "0x1824EBF80")]
			internal bool AAAOKNPGMKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x24ECBE0", Offset = "0x24EB7E0", VA = "0x1824ECBE0")]
			internal bool CBKJDCBNLNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x24F4010", Offset = "0x24F2C10", VA = "0x1824F4010")]
			internal void HAHBOCKFNFK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x24F6680", Offset = "0x24F5280", VA = "0x1824F6680")]
			internal bool OKNDOHKNIKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x24EC560", Offset = "0x24EB160", VA = "0x1824EC560")]
			internal bool AKCCOIDANEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x24EC510", Offset = "0x24EB110", VA = "0x1824EC510")]
			internal bool AJIMEPONKNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x24F69A0", Offset = "0x24F55A0", VA = "0x1824F69A0")]
			internal bool PGOHNNOJOLO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x24F6090", Offset = "0x24F4C90", VA = "0x1824F6090")]
			internal bool NHDDLOJEIAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x24F4FA0", Offset = "0x24F3BA0", VA = "0x1824F4FA0")]
			internal bool KBKKGBBDMCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x24F4DF0", Offset = "0x24F39F0", VA = "0x1824F4DF0")]
			internal bool JGFBLPMHHAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x24F5E20", Offset = "0x24F4A20", VA = "0x1824F5E20")]
			internal bool NCBIDBLKJAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x24F3660", Offset = "0x24F2260", VA = "0x1824F3660")]
			internal void EMFPJLPGGBG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x24F5610", Offset = "0x24F4210", VA = "0x1824F5610")]
			internal bool LJJJDCBFOFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x24F36C0", Offset = "0x24F22C0", VA = "0x1824F36C0")]
			internal bool ENHOLCEGHPD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x24F4470", Offset = "0x24F3070", VA = "0x1824F4470")]
			internal void HOENEODJJCD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x24F5770", Offset = "0x24F4370", VA = "0x1824F5770")]
			internal bool MBDOGFLKNEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x24ECC90", Offset = "0x24EB890", VA = "0x1824ECC90")]
			internal bool CDCHICPNOFI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x24F57C0", Offset = "0x24F43C0", VA = "0x1824F57C0")]
			internal void MBLAPCMDILM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x24ECDF0", Offset = "0x24EB9F0", VA = "0x1824ECDF0")]
			internal List<GMAOOIBOAHF> CMDKCCLDFDM(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x24F4160", Offset = "0x24F2D60", VA = "0x1824F4160")]
			internal bool HEEHLBEPPEL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x24EC7D0", Offset = "0x24EB3D0", VA = "0x1824EC7D0")]
			internal int BBCPNHPBGMI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x24F3210", Offset = "0x24F1E10", VA = "0x1824F3210")]
			internal void EAPFMPHCMIM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x24EC9B0", Offset = "0x24EB5B0", VA = "0x1824EC9B0")]
			internal bool BKJGLMOLLGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x24F53C0", Offset = "0x24F3FC0", VA = "0x1824F53C0")]
			internal bool LAMIFAIDKIF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x24F2E60", Offset = "0x24F1A60", VA = "0x1824F2E60")]
			internal bool DCJDJANCKLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x24ECAA0", Offset = "0x24EB6A0", VA = "0x1824ECAA0")]
			internal int BOPIPHJFIGO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x24F3600", Offset = "0x24F2200", VA = "0x1824F3600")]
			internal void EKFBKOGGHGN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x24F5FA0", Offset = "0x24F4BA0", VA = "0x1824F5FA0")]
			internal bool NENJLOEKCFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x24EC6A0", Offset = "0x24EB2A0", VA = "0x1824EC6A0")]
			internal bool BAJCONJBKIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x24F3F20", Offset = "0x24F2B20", VA = "0x1824F3F20")]
			internal bool GNEAOCENPMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x24F42C0", Offset = "0x24F2EC0", VA = "0x1824F42C0")]
			internal bool HFOPPBANKGI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x24F58C0", Offset = "0x24F44C0", VA = "0x1824F58C0")]
			internal bool MEIKJOLKOJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x24F3BA0", Offset = "0x24F27A0", VA = "0x1824F3BA0")]
			internal bool FMICMALEEFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x24F3B00", Offset = "0x24F2700", VA = "0x1824F3B00")]
			internal string FKOEHEHAPJC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x24F2FF0", Offset = "0x24F1BF0", VA = "0x1824F2FF0")]
			internal void DIKLEILKGLB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x24F4800", Offset = "0x24F3400", VA = "0x1824F4800")]
			internal int IGAKKOOOHNL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x24F41B0", Offset = "0x24F2DB0", VA = "0x1824F41B0")]
			internal void HEIAPOKIMAH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x24F5230", Offset = "0x24F3E30", VA = "0x1824F5230")]
			internal bool KFMDKIPBBPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x24F5460", Offset = "0x24F4060", VA = "0x1824F5460")]
			internal bool LDCOJLCJNHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x24F64D0", Offset = "0x24F50D0", VA = "0x1824F64D0")]
			internal bool OCOIJPKBGDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x24F48A0", Offset = "0x24F34A0", VA = "0x1824F48A0")]
			internal float IGLFKKPDGFN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x24F3870", Offset = "0x24F2470", VA = "0x1824F3870")]
			internal void EPODKLGBCIA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x24F3760", Offset = "0x24F2360", VA = "0x1824F3760")]
			internal bool EOGBCLNFFAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x24F6AE0", Offset = "0x24F56E0", VA = "0x1824F6AE0")]
			internal bool PJINADLLGPD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x24F4A70", Offset = "0x24F3670", VA = "0x1824F4A70")]
			internal bool IMMABJGLJJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x24F69F0", Offset = "0x24F55F0", VA = "0x1824F69F0")]
			internal bool PHFMKBLJCOH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x24F5960", Offset = "0x24F4560", VA = "0x1824F5960")]
			internal bool MHGBAPNCNBH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x24F2E10", Offset = "0x24F1A10", VA = "0x1824F2E10")]
			internal bool DCDCMACBDOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x24EC070", Offset = "0x24EAC70", VA = "0x1824EC070")]
			internal void AEHCEKMDBOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x24F5E70", Offset = "0x24F4A70", VA = "0x1824F5E70")]
			internal string NDPPMKKCBKM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x24F3D10", Offset = "0x24F2910", VA = "0x1824F3D10")]
			internal void FPMGJLLJBBM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x24F6860", Offset = "0x24F5460", VA = "0x1824F6860")]
			internal bool OPNHOKCBALD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x24ECD50", Offset = "0x24EB950", VA = "0x1824ECD50")]
			internal bool CHDCOEIIIDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x24F59B0", Offset = "0x24F45B0", VA = "0x1824F59B0")]
			internal bool MIADMFNEJDP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x24F5A00", Offset = "0x24F4600", VA = "0x1824F5A00")]
			internal void MJCFHICIJMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x24F5870", Offset = "0x24F4470", VA = "0x1824F5870")]
			internal bool MDNGNKAFIKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x24F5910", Offset = "0x24F4510", VA = "0x1824F5910")]
			internal bool MEKOFPPEABJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x24F6130", Offset = "0x24F4D30", VA = "0x1824F6130")]
			internal bool NJCEDADLDPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x24F4EE0", Offset = "0x24F3AE0", VA = "0x1824F4EE0")]
			internal bool JMENEIACCAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x24F3BF0", Offset = "0x24F27F0", VA = "0x1824F3BF0")]
			internal void FOBCJIKMACJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x24F5410", Offset = "0x24F4010", VA = "0x1824F5410")]
			internal bool LBCHCONOJNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x24F3820", Offset = "0x24F2420", VA = "0x1824F3820")]
			internal bool EPNJAPAIAKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x24F5720", Offset = "0x24F4320", VA = "0x1824F5720")]
			internal bool MBABAAEAFID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x24F6570", Offset = "0x24F5170", VA = "0x1824F6570")]
			internal bool OJBCGEAGIHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x24F3270", Offset = "0x24F1E70", VA = "0x1824F3270")]
			internal void EBBHNEBEFHH(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x24F68B0", Offset = "0x24F54B0", VA = "0x1824F68B0")]
			internal bool PAELPLIOKDP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x24F5560", Offset = "0x24F4160", VA = "0x1824F5560")]
			internal bool LIMKGBENGEH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x24F48F0", Offset = "0x24F34F0", VA = "0x1824F48F0")]
			internal bool IGNOCDFOIMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x24F5660", Offset = "0x24F4260", VA = "0x1824F5660")]
			internal bool LLAAIAOPLNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x24F43B0", Offset = "0x24F2FB0", VA = "0x1824F43B0")]
			internal object HLIEKGGJOJC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x24EC820", Offset = "0x24EB420", VA = "0x1824EC820")]
			internal void BCEJNEPAHKK(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x24F4B70", Offset = "0x24F3770", VA = "0x1824F4B70")]
			internal bool IPOACJAODID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x24F3560", Offset = "0x24F2160", VA = "0x1824F3560")]
			internal bool EGDEOBONOPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x24F66D0", Offset = "0x24F52D0", VA = "0x1824F66D0")]
			internal int OKNIAJOMEMG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x24F4210", Offset = "0x24F2E10", VA = "0x1824F4210")]
			internal void HFCMBGGNCLM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x24F4C60", Offset = "0x24F3860", VA = "0x1824F4C60")]
			internal bool JBKOHAKMAFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x24F4BC0", Offset = "0x24F37C0", VA = "0x1824F4BC0")]
			internal bool JBADPLAMOMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x24F4760", Offset = "0x24F3360", VA = "0x1824F4760")]
			internal int IFCPLLCCDBL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x24F6420", Offset = "0x24F5020", VA = "0x1824F6420")]
			internal void OCGPPKLEGBM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x24F34C0", Offset = "0x24F20C0", VA = "0x1824F34C0")]
			internal bool EEDAMJLHADJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x24F39C0", Offset = "0x24F25C0", VA = "0x1824F39C0")]
			internal bool FDFEFANLIKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x24F6480", Offset = "0x24F5080", VA = "0x1824F6480")]
			internal bool OCMAAAOGMJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x24F51E0", Offset = "0x24F3DE0", VA = "0x1824F51E0")]
			internal int KDKFALNFNBO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x24ECC30", Offset = "0x24EB830", VA = "0x1824ECC30")]
			internal void CBLMJJEIHGH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x24F5D10", Offset = "0x24F4910", VA = "0x1824F5D10")]
			internal bool MOIEENFMGCJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x24F3320", Offset = "0x24F1F20", VA = "0x1824F3320")]
			internal bool EBHCHOPIPEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x24ECDA0", Offset = "0x24EB9A0", VA = "0x1824ECDA0")]
			internal bool CIPDBIKBCHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x24F45A0", Offset = "0x24F31A0", VA = "0x1824F45A0")]
			internal object HPHHKLJNNFG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x24EC740", Offset = "0x24EB340", VA = "0x1824EC740")]
			internal void BANIEKKIEFH(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x24EC470", Offset = "0x24EB070", VA = "0x1824EC470")]
			internal bool AFLIICFKOAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x24ECAF0", Offset = "0x24EB6F0", VA = "0x1824ECAF0")]
			internal bool BPFLIMPOLJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x24F6360", Offset = "0x24F4F60", VA = "0x1824F6360")]
			internal object OAFHMCHEELK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x24F5F10", Offset = "0x24F4B10", VA = "0x1824F5F10")]
			internal void NEICKLDGNIN(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x24F4D00", Offset = "0x24F3900", VA = "0x1824F4D00")]
			internal bool JCHEHFCCGOK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x24F5FF0", Offset = "0x24F4BF0", VA = "0x1824F5FF0")]
			internal int NGAMJMCHGJA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x24F30B0", Offset = "0x24F1CB0", VA = "0x1824F30B0")]
			internal void DKIOOOEBHHJ(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x24F2EB0", Offset = "0x24F1AB0", VA = "0x1824F2EB0")]
			internal bool DFCKHNNHOJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x24F3A10", Offset = "0x24F2610", VA = "0x1824F3A10")]
			internal bool FHJLEPMKMNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x24F3060", Offset = "0x24F1C60", VA = "0x1824F3060")]
			internal bool DINJDDFJPGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x24F4940", Offset = "0x24F3540", VA = "0x1824F4940")]
			internal int IIADNFJJAEJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x24F31B0", Offset = "0x24F1DB0", VA = "0x1824F31B0")]
			internal void EAFCMAJCNII(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x24F60E0", Offset = "0x24F4CE0", VA = "0x1824F60E0")]
			internal bool NINHPGDDMIF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x24F6B80", Offset = "0x24F5780", VA = "0x1824F6B80")]
			internal bool PMPAPMDGAPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x24EC960", Offset = "0x24EB560", VA = "0x1824EC960")]
			internal bool BIJNDPHJCAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x24F35B0", Offset = "0x24F21B0", VA = "0x1824F35B0")]
			internal float EJLFNMAHMLF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x24F3D80", Offset = "0x24F2980", VA = "0x1824F3D80")]
			internal void GABMDJBIOBP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x24F5280", Offset = "0x24F3E80", VA = "0x1824F5280")]
			internal bool KKGLDBFNAKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x24F2FA0", Offset = "0x24F1BA0", VA = "0x1824F2FA0")]
			internal bool DIEPFOJDEHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x24F6950", Offset = "0x24F5550", VA = "0x1824F6950")]
			internal bool PDKPADEPALE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x24F4CB0", Offset = "0x24F38B0", VA = "0x1824F4CB0")]
			internal float JCANJNPJCGP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x24EC900", Offset = "0x24EB500", VA = "0x1824EC900")]
			internal void BHKDAAODBKH(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x24F6310", Offset = "0x24F4F10", VA = "0x1824F6310")]
			internal bool NOMEBONJLMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x24EC4C0", Offset = "0x24EB0C0", VA = "0x1824EC4C0")]
			internal bool AJEOHCHJMON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x24F5510", Offset = "0x24F4110", VA = "0x1824F5510")]
			internal string LFAGHIJJDJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x24F3CA0", Offset = "0x24F28A0", VA = "0x1824F3CA0")]
			internal void FOOJNKDPKAA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x24F6270", Offset = "0x24F4E70", VA = "0x1824F6270")]
			internal bool NMFPLINHDOA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x24F4420", Offset = "0x24F3020", VA = "0x1824F4420")]
			internal bool HNDLIPCFKPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x24F6630", Offset = "0x24F5230", VA = "0x1824F6630")]
			internal bool OKAOOPJNADB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x24F5EC0", Offset = "0x24F4AC0", VA = "0x1824F5EC0")]
			internal bool NEDLIHHOEGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x24F3E30", Offset = "0x24F2A30", VA = "0x1824F3E30")]
			internal string GAJBOGEPCCG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x24F4F30", Offset = "0x24F3B30", VA = "0x1824F4F30")]
			internal void KAHDBIHJPPF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x24F5DD0", Offset = "0x24F49D0", VA = "0x1824F5DD0")]
			internal bool NBGCBDIOJPI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x24F3B50", Offset = "0x24F2750", VA = "0x1824F3B50")]
			internal bool FLJCELDPIGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x24F3920", Offset = "0x24F2520", VA = "0x1824F3920")]
			internal bool FCCGEICCKOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x24EC420", Offset = "0x24EB020", VA = "0x1824EC420")]
			internal bool AEOHALPKODI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x24EC600", Offset = "0x24EB200", VA = "0x1824EC600")]
			internal string AOJAAFDELHM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x24F44D0", Offset = "0x24F30D0", VA = "0x1824F44D0")]
			internal void HOJEPACIIEK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x24F3710", Offset = "0x24F2310", VA = "0x1824F3710")]
			internal bool EODPMFBCNLP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x24F4110", Offset = "0x24F2D10", VA = "0x1824F4110")]
			internal bool HCILPGCHCHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x24F5320", Offset = "0x24F3F20", VA = "0x1824F5320")]
			internal bool KMHJIPJNLCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x24EC5B0", Offset = "0x24EB1B0", VA = "0x1824EC5B0")]
			internal bool ALHLHCNOHEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x24ECB90", Offset = "0x24EB790", VA = "0x1824ECB90")]
			internal string CALNKNJOPFF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x24F5040", Offset = "0x24F3C40", VA = "0x1824F5040")]
			internal void KCELCJHEGMG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x24F2F00", Offset = "0x24F1B00", VA = "0x1824F2F00")]
			internal bool DFENCLKOLGE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x24F4660", Offset = "0x24F3260", VA = "0x1824F4660")]
			internal bool IAPPHKNDBKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x24F6220", Offset = "0x24F4E20", VA = "0x1824F6220")]
			internal bool NLGHKHGBKBH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x24F4360", Offset = "0x24F2F60", VA = "0x1824F4360")]
			internal bool HJCCEGHDGAN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x24ECA50", Offset = "0x24EB650", VA = "0x1824ECA50")]
			internal string BOJLODHODKP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x24F4990", Offset = "0x24F3590", VA = "0x1824F4990")]
			internal void IIAHPBIOGAJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x24F3A60", Offset = "0x24F2660", VA = "0x1824F3A60")]
			internal bool FILPONILJBD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x24F67C0", Offset = "0x24F53C0", VA = "0x1824F67C0")]
			internal bool ONOPFBLAOHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x24F3F70", Offset = "0x24F2B70", VA = "0x1824F3F70")]
			internal bool GNHDKFCEEHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x24F4DA0", Offset = "0x24F39A0", VA = "0x1824F4DA0")]
			internal bool JEIJMHBADCB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x24F3510", Offset = "0x24F2110", VA = "0x1824F3510")]
			internal string EELNOJDODAA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x24F37B0", Offset = "0x24F23B0", VA = "0x1824F37B0")]
			internal void EOOBHEJKFLI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x24F2F50", Offset = "0x24F1B50", VA = "0x1824F2F50")]
			internal bool DGHJBOHHGJD(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x24F4FF0", Offset = "0x24F3BF0", VA = "0x1824F4FF0")]
			internal bool KCACLNDJCAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x24F4E90", Offset = "0x24F3A90", VA = "0x1824F4E90")]
			internal bool JKFFPNGBMEN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x24F3E80", Offset = "0x24F2A80", VA = "0x1824F3E80")]
			internal bool GGAININILKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x24F4E40", Offset = "0x24F3A40", VA = "0x1824F4E40")]
			internal string JGJCPCPCPOF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x24F65C0", Offset = "0x24F51C0", VA = "0x1824F65C0")]
			internal void OKALHGDOKFO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x24F3370", Offset = "0x24F1F70", VA = "0x1824F3370")]
			internal bool EBIBMGHOHCB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x24F47B0", Offset = "0x24F33B0", VA = "0x1824F47B0")]
			internal bool IFDHHDFCLKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x24F5820", Offset = "0x24F4420", VA = "0x1824F5820")]
			internal bool MBMIEDNDGFM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x24ECA00", Offset = "0x24EB600", VA = "0x1824ECA00")]
			internal bool BNGKAMPJEPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x24F3C50", Offset = "0x24F2850", VA = "0x1824F3C50")]
			internal string FOFHOFAMKDE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x24F4A00", Offset = "0x24F3600", VA = "0x1824F4A00")]
			internal void IMBBBLIOJHJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x24F38D0", Offset = "0x24F24D0", VA = "0x1824F38D0")]
			internal bool FAPAHIBPMLM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x24F32D0", Offset = "0x24F1ED0", VA = "0x1824F32D0")]
			internal bool EBDAOHBKMIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x24F4710", Offset = "0x24F3310", VA = "0x1824F4710")]
			internal bool IFCIOMKBMGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x24F6810", Offset = "0x24F5410", VA = "0x1824F6810")]
			internal bool OOPNNJHIGHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x24F4610", Offset = "0x24F3210", VA = "0x1824F4610")]
			internal string IAGJIKBLLHF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x24F50B0", Offset = "0x24F3CB0", VA = "0x1824F50B0")]
			internal void KCGAMJDKKOK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x24EC8B0", Offset = "0x24EB4B0", VA = "0x1824EC8B0")]
			internal bool BGPFJOCLIKI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x24F4070", Offset = "0x24F2C70", VA = "0x1824F4070")]
			internal bool HBCIEDOPMIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x24F6A40", Offset = "0x24F5640", VA = "0x1824F6A40")]
			internal bool PHIJNANMCEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x24ECB40", Offset = "0x24EB740", VA = "0x1824ECB40")]
			internal bool BPHBDHEKCNE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x24EC650", Offset = "0x24EB250", VA = "0x1824EC650")]
			internal string APDCFLIMKPH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x24F5D60", Offset = "0x24F4960", VA = "0x1824F5D60")]
			internal void MOONEMJJBGO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x24F5CC0", Offset = "0x24F48C0", VA = "0x1824F5CC0")]
			internal bool MJCMJPJJLKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x24F6040", Offset = "0x24F4C40", VA = "0x1824F6040")]
			internal bool NGDKELPOMLD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x24F3970", Offset = "0x24F2570", VA = "0x1824F3970")]
			internal bool FCMAIEOELIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x24F6180", Offset = "0x24F4D80", VA = "0x1824F6180")]
			internal string NJPEMICHOIB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x24F5120", Offset = "0x24F3D20", VA = "0x1824F5120")]
			internal void KDGFGOJGFMJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x24F4C10", Offset = "0x24F3810", VA = "0x1824F4C10")]
			internal bool JBBDDKFIMEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x24F3160", Offset = "0x24F1D60", VA = "0x1824F3160")]
			internal bool DPBDOCAODIB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x24F4850", Offset = "0x24F3450", VA = "0x1824F4850")]
			internal bool IGKCIKBGFBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x24F5190", Offset = "0x24F3D90", VA = "0x1824F5190")]
			internal string KDKEDCHFNBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x24ECCE0", Offset = "0x24EB8E0", VA = "0x1824ECCE0")]
			internal void CENHNCAIPHF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x24F3420", Offset = "0x24F2020", VA = "0x1824F3420")]
			internal bool ECIPJIHKKDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x24F6770", Offset = "0x24F5370", VA = "0x1824F6770")]
			internal bool ONLOEGHACEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x24F6720", Offset = "0x24F5320", VA = "0x1824F6720")]
			internal bool OLINLCPBGLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x24F3FC0", Offset = "0x24F2BC0", VA = "0x1824F3FC0")]
			internal string GONBCJJCBKI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x24F56B0", Offset = "0x24F42B0", VA = "0x1824F56B0")]
			internal void LOGHACIGCGC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x24F4270", Offset = "0x24F2E70", VA = "0x1824F4270")]
			internal bool HFIDEIHICHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x24F6520", Offset = "0x24F5120", VA = "0x1824F6520")]
			internal bool OFMHIMBLMBP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x24F61D0", Offset = "0x24F4DD0", VA = "0x1824F61D0")]
			internal float NJPKJOIMLJK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x24F46B0", Offset = "0x24F32B0", VA = "0x1824F46B0")]
			internal void ICMNNOEOENP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x24F6B30", Offset = "0x24F5730", VA = "0x1824F6B30")]
			internal bool PLFGJPDHOLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x24F52D0", Offset = "0x24F3ED0", VA = "0x1824F52D0")]
			internal bool KMHCFMNFOLN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x24EC6F0", Offset = "0x24EB2F0", VA = "0x1824EC6F0")]
			internal bool BAKADGNGFEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x24F3DE0", Offset = "0x24F29E0", VA = "0x1824F3DE0")]
			internal int GAGHIHMOKHC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x24F4540", Offset = "0x24F3140", VA = "0x1824F4540")]
			internal void HOKJFBAKCJK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x24F6A90", Offset = "0x24F5690", VA = "0x1824F6A90")]
			internal bool PIDJEGPCBKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x24F3AB0", Offset = "0x24F26B0", VA = "0x1824F3AB0")]
			internal bool FKIIADGLLDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x24F5370", Offset = "0x24F3F70", VA = "0x1824F5370")]
			internal bool LALPHADDHFA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class MDAPLAGKCBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public EMGGBKPFBAA CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public MDAPLAGKCBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x24FC5A0", Offset = "0x24FB1A0", VA = "0x1824FC5A0")]
			internal void BLMGNHLFAGM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class BFHJGJONJGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public BFHJGJONJGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x24E60C0", Offset = "0x24E4CC0", VA = "0x1824E60C0")]
			internal bool PNEPBNHCMPD(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly OIFFEODOPDD OMJGMGFKLNH;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x24FFF50", Offset = "0x24FEB50", VA = "0x1824FFF50")]
		public NBBNHCEHAHA(FAMECBPCILE JKPOOJNKKFK, GLAJKNBGNNA PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x24FE200", Offset = "0x24FCE00", VA = "0x1824FE200", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class IMGLACJNLLN : LLFAKGDCGIP<PBPDIIICHHB>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class AKHKJNIIGLD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006B")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				public AKHKJNIIGLD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x25200E0", Offset = "0x251ECE0", VA = "0x1825200E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public IMGLACJNLLN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public AKHKJNIIGLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x24E5F40", Offset = "0x24E4B40", VA = "0x1824E5F40")]
			internal string ECKGNBOKHAD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x24E5F90", Offset = "0x24E4B90", VA = "0x1824E5F90")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void IODFOKGBFJC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x24E5E60", Offset = "0x24E4A60", VA = "0x1824E5E60")]
			internal int APCHIBOENLE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x24E5EB0", Offset = "0x24E4AB0", VA = "0x1824E5EB0")]
			internal void CFKDKHFDFHN(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xEE17D0", Offset = "0xEE03D0", VA = "0x180EE17D0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x24FAA10", Offset = "0x24F9610", VA = "0x1824FAA10")]
		public IMGLACJNLLN(FAMECBPCILE JKPOOJNKKFK, PBPDIIICHHB FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x24FA6C0", Offset = "0x24F92C0", VA = "0x1824FA6C0", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class LBOGICAFBKA : LLFAKGDCGIP<JBGJKCHMDDL>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class JIOLGAJBKIK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006E")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				public JIOLGAJBKIK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x25203F0", Offset = "0x251EFF0", VA = "0x1825203F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006F")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public JIOLGAJBKIK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x2520730", Offset = "0x251F330", VA = "0x182520730", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public LBOGICAFBKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public JIOLGAJBKIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x2515BB0", Offset = "0x25147B0", VA = "0x182515BB0")]
			internal string ECKGNBOKHAD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x2515D00", Offset = "0x2514900", VA = "0x182515D00")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void IODFOKGBFJC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x2515910", Offset = "0x2514510", VA = "0x182515910")]
			internal int APCHIBOENLE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x2515A40", Offset = "0x2514640", VA = "0x182515A40")]
			internal void CFKDKHFDFHN(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x2515C50", Offset = "0x2514850", VA = "0x182515C50")]
			internal string HGCJLPFAHJL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x2515DD0", Offset = "0x25149D0", VA = "0x182515DD0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void JDNCLAOOCPA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x2515B60", Offset = "0x2514760", VA = "0x182515B60")]
			internal bool EBJCNPJBEJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x25159B0", Offset = "0x25145B0", VA = "0x1825159B0")]
			internal void BOLAFHBOCHN(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x2515960", Offset = "0x2514560", VA = "0x182515960")]
			internal bool BCMPBIOEJKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x2515AD0", Offset = "0x25146D0", VA = "0x182515AD0")]
			internal void DOIEFLDMNNF(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x2515C00", Offset = "0x2514800", VA = "0x182515C00")]
			internal float HCAMHFPCDIB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x2515F40", Offset = "0x2514B40", VA = "0x182515F40")]
			internal void LJJAJDDHMNM(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x2515CA0", Offset = "0x25148A0", VA = "0x182515CA0")]
			internal int ICCJPHAOILJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x2515EA0", Offset = "0x2514AA0", VA = "0x182515EA0")]
			internal void KPKEKGFGFMG(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x2515FD0", Offset = "0x2514BD0", VA = "0x182515FD0")]
			internal bool PDIFDFEJLMB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xEE17D0", Offset = "0xEE03D0", VA = "0x180EE17D0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x2517370", Offset = "0x2515F70", VA = "0x182517370")]
		public LBOGICAFBKA(FAMECBPCILE JKPOOJNKKFK, JBGJKCHMDDL PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2516920", Offset = "0x2515520", VA = "0x182516920", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class OODENEGMDNK : LLFAKGDCGIP<NNOOBPIEABP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class FICJICJGBAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public OODENEGMDNK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public FICJICJGBAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x250DE50", Offset = "0x250CA50", VA = "0x18250DE50")]
			internal Dictionary<string, JJHGKOMIDDI> ECKGNBOKHAD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x250DEF0", Offset = "0x250CAF0", VA = "0x18250DEF0")]
			internal int IODFOKGBFJC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x250DCA0", Offset = "0x250C8A0", VA = "0x18250DCA0")]
			internal void APCHIBOENLE(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x250DDD0", Offset = "0x250C9D0", VA = "0x18250DDD0")]
			internal bool CFKDKHFDFHN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0xEE17D0", Offset = "0xEE03D0", VA = "0x180EE17D0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x251F490", Offset = "0x251E090", VA = "0x18251F490")]
		public OODENEGMDNK(FAMECBPCILE JKPOOJNKKFK, NNOOBPIEABP FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x251F1C0", Offset = "0x251DDC0", VA = "0x18251F1C0", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class FBMKGFKCCMB : LLFAKGDCGIP<CCIADNLKPBP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class EGDJMIENMHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public FBMKGFKCCMB <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public EGDJMIENMHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x250C670", Offset = "0x250B270", VA = "0x18250C670")]
			internal void ECKGNBOKHAD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xEE17D0", Offset = "0xEE03D0", VA = "0x180EE17D0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x250D5D0", Offset = "0x250C1D0", VA = "0x18250D5D0")]
		public FBMKGFKCCMB(FAMECBPCILE JKPOOJNKKFK, CCIADNLKPBP FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x250D450", Offset = "0x250C050", VA = "0x18250D450", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class JOJALGHKBIM<TNode> : HFMAADDLBNH<TNode> where TNode : notnull, HKPBLFONEDL
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool AGNHPPJABNK
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override IPGGHDECEIB? ANEKFCBECMN
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x494E520", Offset = "0x494D120", VA = "0x18494E520", Slot = "122")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool PEBEEKINBJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x494E5E0", Offset = "0x494D1E0", VA = "0x18494E5E0", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xC211F0", Offset = "0xC1FDF0", VA = "0x180C211F0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x494E5A0", Offset = "0x494D1A0", VA = "0x18494E5A0")]
		public JOJALGHKBIM(FAMECBPCILE JKPOOJNKKFK, TNode PCMPEACCDMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class CIFGPNEFOOB : JOJALGHKBIM<NKPPAOHDFDC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class IJDMFJMPGGC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public CIFGPNEFOOB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public IJDMFJMPGGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x2514730", Offset = "0x2513330", VA = "0x182514730")]
			internal object ECKGNBOKHAD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x25147A0", Offset = "0x25133A0", VA = "0x1825147A0")]
			internal void IODFOKGBFJC(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x2514640", Offset = "0x2513240", VA = "0x182514640")]
			internal void APCHIBOENLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static object[]? DPPKJGGJLJN;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x250B730", Offset = "0x250A330", VA = "0x18250B730")]
		public CIFGPNEFOOB(FAMECBPCILE JKPOOJNKKFK, NKPPAOHDFDC PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x250B190", Offset = "0x2509D90", VA = "0x18250B190", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class PEEGPOAANOJ : LLFAKGDCGIP<NOOFJDAFLBO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xB3F8B0", Offset = "0xB3E4B0", VA = "0x180B3F8B0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x251F8C0", Offset = "0x251E4C0", VA = "0x18251F8C0")]
		public PEEGPOAANOJ(FAMECBPCILE JKPOOJNKKFK, NOOFJDAFLBO PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private sealed class BAJCEJCGKEO : LLFAKGDCGIP<KPPDCJDEAPN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xA6E220", Offset = "0xA6CE20", VA = "0x180A6E220", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x2509C50", Offset = "0x2508850", VA = "0x182509C50")]
		public BAJCEJCGKEO(FAMECBPCILE JKPOOJNKKFK, KPPDCJDEAPN PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "124")]
		protected override bool MDBNHGLBHIP(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class OEKHOEMFIFM : LLFAKGDCGIP<DPDKCDCEGPP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xA5CE90", Offset = "0xA5BA90", VA = "0x180A5CE90", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool FFGLPEBPIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x251F170", Offset = "0x251DD70", VA = "0x18251F170", Slot = "104")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override bool CJILPBNMBIA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x251F100", Offset = "0x251DD00", VA = "0x18251F100")]
		public OEKHOEMFIFM(FAMECBPCILE JKPOOJNKKFK, DPDKCDCEGPP PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class CAGDKKPJKAI : LLFAKGDCGIP<OPENKJAFJHP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xA7F430", Offset = "0xA7E030", VA = "0x180A7F430", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool FFGLPEBPIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x250A9F0", Offset = "0x25095F0", VA = "0x18250A9F0", Slot = "104")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		protected override bool CJILPBNMBIA
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x250A980", Offset = "0x2509580", VA = "0x18250A980")]
		public CAGDKKPJKAI(FAMECBPCILE JKPOOJNKKFK, OPENKJAFJHP PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class FFHLLLOAAIC : FKBLAAIAIDN<NMHNNLIFLDN>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class HLNPIGHBDBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public FFHLLLOAAIC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public HLNPIGHBDBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x2512A60", Offset = "0x2511660", VA = "0x182512A60")]
			internal float OGBCDOPDHMA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x25129C0", Offset = "0x25115C0", VA = "0x1825129C0")]
			internal void GOMGGBCIMOO(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x250DBA0", Offset = "0x250C7A0", VA = "0x18250DBA0")]
		public FFHLLLOAAIC(FAMECBPCILE JKPOOJNKKFK, NMHNNLIFLDN FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x250D920", Offset = "0x250C520", VA = "0x18250D920", Slot = "138")]
		protected override void GMHOCGONOMO(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class FAFDHCHKOPI : LLFAKGDCGIP<ILMMHLLNBOD>
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class DEOAJBCMIKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public FAFDHCHKOPI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public DEOAJBCMIKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x250BCF0", Offset = "0x250A8F0", VA = "0x18250BCF0")]
			internal bool ECKGNBOKHAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x250BD40", Offset = "0x250A940", VA = "0x18250BD40")]
			internal void IODFOKGBFJC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x250CF30", Offset = "0x250BB30", VA = "0x18250CF30")]
		public FAFDHCHKOPI(FAMECBPCILE JKPOOJNKKFK, ILMMHLLNBOD FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x250CC80", Offset = "0x250B880", VA = "0x18250CC80", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class JGGLOCNHAFG : LLFAKGDCGIP<FHGILELEINE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class IMPBNOOBCJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public JGGLOCNHAFG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public IMPBNOOBCJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2514BE0", Offset = "0x25137E0", VA = "0x182514BE0")]
			internal object ECKGNBOKHAD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x25149E0", Offset = "0x25135E0", VA = "0x1825149E0")]
			internal bool BOLAFHBOCHN(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2514D80", Offset = "0x2513980", VA = "0x182514D80")]
			internal void IODFOKGBFJC(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x2514870", Offset = "0x2513470", VA = "0x182514870")]
			internal string APCHIBOENLE(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2514A60", Offset = "0x2513660", VA = "0x182514A60")]
			internal IReadOnlyList<object> CFKDKHFDFHN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x2514D10", Offset = "0x2513910", VA = "0x182514D10")]
			internal bool HGCJLPFAHJL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x2514FE0", Offset = "0x2513BE0", VA = "0x182514FE0")]
			internal bool JDNCLAOOCPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x2514AB0", Offset = "0x25136B0", VA = "0x182514AB0")]
			internal void EBJCNPJBEJG(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x25158A0", Offset = "0x25144A0", VA = "0x1825158A0")]
		public JGGLOCNHAFG(FAMECBPCILE JKPOOJNKKFK, FHGILELEINE FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x2515090", Offset = "0x2513C90", VA = "0x182515090", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class AHNEIHGMGDF : FBCEFDDOKPD<NNDNGBMHIJG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xC07BB0", Offset = "0xC067B0", VA = "0x180C07BB0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x2509700", Offset = "0x2508300", VA = "0x182509700")]
		public AHNEIHGMGDF(FAMECBPCILE JKPOOJNKKFK, NNDNGBMHIJG PCMPEACCDMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class PFFBIFPMAJE : FKBLAAIAIDN<BCCPMDIPMHL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class ENMAJDPNGCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public PFFBIFPMAJE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public ENMAJDPNGCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x250CC00", Offset = "0x250B800", VA = "0x18250CC00")]
			internal int OGBCDOPDHMA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x250CB60", Offset = "0x250B760", VA = "0x18250CB60")]
			internal void GOMGGBCIMOO(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x251FC30", Offset = "0x251E830", VA = "0x18251FC30")]
		public PFFBIFPMAJE(FAMECBPCILE JKPOOJNKKFK, BCCPMDIPMHL FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x251F930", Offset = "0x251E530", VA = "0x18251F930", Slot = "138")]
		protected override void GMHOCGONOMO(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class MGFEIELNIBP : LLFAKGDCGIP<ALFAKAMGNOF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class BHKKHJAFBFO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public MGFEIELNIBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public BHKKHJAFBFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x250A3D0", Offset = "0x2508FD0", VA = "0x18250A3D0")]
			internal bool ECKGNBOKHAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x250A420", Offset = "0x2509020", VA = "0x18250A420")]
			internal void IODFOKGBFJC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x2517A10", Offset = "0x2516610", VA = "0x182517A10")]
		public MGFEIELNIBP(FAMECBPCILE JKPOOJNKKFK, ALFAKAMGNOF FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x2517830", Offset = "0x2516430", VA = "0x182517830", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class AGBHDNLBBLJ : LLFAKGDCGIP<PIMFOCLPAKH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class PHDNHOPPKPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public AGBHDNLBBLJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public PHDNHOPPKPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x251FC90", Offset = "0x251E890", VA = "0x18251FC90")]
			internal bool ECKGNBOKHAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x251FCE0", Offset = "0x251E8E0", VA = "0x18251FCE0")]
			internal void IODFOKGBFJC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x2504530", Offset = "0x2503130", VA = "0x182504530")]
		public AGBHDNLBBLJ(FAMECBPCILE JKPOOJNKKFK, PIMFOCLPAKH FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x2504350", Offset = "0x2502F50", VA = "0x182504350", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class FDKFNEJMFOD : LLFAKGDCGIP<IAMHMNPOACF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class KGJJNMDIOBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public FDKFNEJMFOD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public KGJJNMDIOBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x2516840", Offset = "0x2515440", VA = "0x182516840")]
			internal int ECKGNBOKHAD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x2516890", Offset = "0x2515490", VA = "0x182516890")]
			internal void IODFOKGBFJC(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x250D8B0", Offset = "0x250C4B0", VA = "0x18250D8B0")]
		public FDKFNEJMFOD(FAMECBPCILE JKPOOJNKKFK, IAMHMNPOACF FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x250D640", Offset = "0x250C240", VA = "0x18250D640", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class BJELMKJCGNG : NPFMMHGJODH<IMGININPEGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override IPBDEJGDKMN IKGNOOAGKHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xA78B70", Offset = "0xA77770", VA = "0x180A78B70", Slot = "138")]
			get
			{
				return default(IPBDEJGDKMN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x250A4D0", Offset = "0x25090D0", VA = "0x18250A4D0")]
		public BJELMKJCGNG(FAMECBPCILE JKPOOJNKKFK, IMGININPEGJ FOBBPKHANPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class AAJIPNHJMAF : LLFAKGDCGIP<LJNEMHENPLP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x2503FA0", Offset = "0x2502BA0", VA = "0x182503FA0")]
		public AAJIPNHJMAF(FAMECBPCILE JKPOOJNKKFK, LJNEMHENPLP PCMPEACCDMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public abstract class LLFAKGDCGIP<TNode> : PJCAPLMNIMG, IDisposable where TNode : notnull, LJNEMHENPLP
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class BJIJHANEKDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public LLFAKGDCGIP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public FAMECBPCILE circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public BJIJHANEKDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x580A0D0", Offset = "0x5808CD0", VA = "0x18580A0D0")]
			internal AGLEKNPGMHN BACKGHNLMOJ(BENFDNEBPGP portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private struct KIEOAADKDKN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public LLFAKGDCGIP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x4A6DDD0", Offset = "0x4A6C9D0", VA = "0x184A6DDD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private struct MMJOCJGEFJO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public LLFAKGDCGIP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public DNFPMKILKNL? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public ONBJGGOKCEK? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x4D8AE60", Offset = "0x4D89A60", VA = "0x184D8AE60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x4D8B110", Offset = "0x4D89D10", VA = "0x184D8B110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class PPKBAIPKFPM
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000091")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C2")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C3")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C4")]
				public PPKBAIPKFPM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60003A2")]
				[Cpp2IlInjected.Address(RVA = "0x3CAE080", Offset = "0x3CACC80", VA = "0x183CAE080", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public LLFAKGDCGIP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public EFGCLJPHEPI configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public PPKBAIPKFPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
			internal string DNHJHKOFLAI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
			internal void GDBLEJLFGOC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x5089F80", Offset = "0x5088B80", VA = "0x185089F80")]
			[AsyncStateMachine(typeof(LLFAKGDCGIP<>.PPKBAIPKFPM.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void MFONKJEAIIK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private sealed class FOKJNPJEEAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public FOKJNPJEEAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x4422D20", Offset = "0x4421920", VA = "0x184422D20")]
			internal bool OMPLKMJKPBH(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x4422D10", Offset = "0x4421910", VA = "0x184422D10")]
			internal bool CGFBFPBKBHN(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private struct GKOIODKEJDK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public LLFAKGDCGIP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x44DF450", Offset = "0x44DE050", VA = "0x1844DF450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x44DF760", Offset = "0x44DE360", VA = "0x1844DF760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private readonly FAMECBPCILE PEFFIDGBCHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private readonly bool PLGMCCOLOGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private HKEHJPOMAJA<IEOKEELCLHA, AGLEKNPGMHN> PEPLJNPPPHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private HKEHJPOMAJA<IEOKEELCLHA, LAPGJAKNNOF> DNGJENMJCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private List<Action> DAKNMFLDJNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[CompilerGenerated]
		private Action<ENBGACDEBPI<IEOKEELCLHA>>? FPKPPEAANEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[CompilerGenerated]
		private Action<ENBGACDEBPI<IEOKEELCLHA>, LAPGJAKNNOF>? JBALDPAPNNN;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected OHBPKAHMOIH PMKNAIKJCBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x4B42D40", Offset = "0x4B41940", VA = "0x184B42D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		protected EBFPIMNMNKD AKBFMPNNAMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x4B43210", Offset = "0x4B41E10", VA = "0x184B43210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected TNode ACIONEPINEI
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public LFHLJBHJLKP<DKFBPKOALCJ> EAGJEEJMBLG
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x1165BC0", Offset = "0x11647C0", VA = "0x181165BC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(LFHLJBHJLKP<DKFBPKOALCJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public ENBGACDEBPI<FBBBJKCECFN> DBANJOKPEKL
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x4B46EC0", Offset = "0x4B45AC0", VA = "0x184B46EC0", Slot = "6")]
			get
			{
				return default(ENBGACDEBPI<FBBBJKCECFN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public object GGPPCPGJBHC
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x4055590", Offset = "0x4054190", VA = "0x184055590", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual bool INPDKACGMLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "101")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int HDIDGNBMAFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x4B46AF0", Offset = "0x4B456F0", VA = "0x184B46AF0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public DLLKDAPGHJF NIJOGLJOEOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x4B46A90", Offset = "0x4B45690", VA = "0x184B46A90", Slot = "10")]
			get
			{
				return default(DLLKDAPGHJF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string JACFKGEDGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x4B470E0", Offset = "0x4B45CE0", VA = "0x184B470E0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual bool CJILPBNMBIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public ENBGACDEBPI<LGJHJOEJNHP> BMKCGAJMMBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xCED400", Offset = "0xCEC000", VA = "0x180CED400", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(ENBGACDEBPI<LGJHJOEJNHP>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0xCED410", Offset = "0xCEC010", VA = "0x180CED410")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual bool FFGLPEBPIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "104")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual bool AGNHPPJABNK
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual JPKMCBBAEKK BMDCBAGMOCE
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xDA0BE0", Offset = "0xD9F7E0", VA = "0x180DA0BE0", Slot = "106")]
			get
			{
				return default(JPKMCBBAEKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool KGNGPCBHGIK
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x4B467A0", Offset = "0x4B453A0", VA = "0x184B467A0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool IKPNJDODGOM
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x4B46810", Offset = "0x4B45410", VA = "0x184B46810", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool FBEMOBKEAEA
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x4B46880", Offset = "0x4B45480", VA = "0x184B46880", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public int AGICLDKDNCH
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x4B46E60", Offset = "0x4B45A60", VA = "0x184B46E60", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool KAIABPKCNFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x4B46C80", Offset = "0x4B45880", VA = "0x184B46C80", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool EODHODINEKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x4B469B0", Offset = "0x4B455B0", VA = "0x184B469B0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool MKADBBKOLOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x4B46940", Offset = "0x4B45540", VA = "0x184B46940", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool IKBNMDCEAJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0xD68880", Offset = "0xD67480", VA = "0x180D68880", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x113BCF0", Offset = "0x113A8F0", VA = "0x18113BCF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual bool KKPLEGMPHPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool KBFDJPNNFBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x4B468F0", Offset = "0x4B454F0", VA = "0x184B468F0", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool GJHGKDHDADC
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x4B46BB0", Offset = "0x4B457B0", VA = "0x184B46BB0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public DNFPMKILKNL FIAHPIOKJMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x4B46DA0", Offset = "0x4B459A0", VA = "0x184B46DA0", Slot = "28")]
			get
			{
				return default(DNFPMKILKNL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public ONBJGGOKCEK GFLBEFOIGBB
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x4B46E00", Offset = "0x4B45A00", VA = "0x184B46E00", Slot = "30")]
			get
			{
				return default(ONBJGGOKCEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual bool FABHEBJJBFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual CJGGJCGBOCI? LECJCPGEANB
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public virtual IPGGHDECEIB? ANEKFCBECMN
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "122")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual IEnumerable<LFHLJBHJLKP<CALHCHFEDII>>? ELKCDKJFGOO
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "123")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool MMFAGMLFPGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x4B46A20", Offset = "0x4B45620", VA = "0x184B46A20", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public LFHLJBHJLKP<DGPIFHHHHCH> DMDLHJDIMLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x4B46CE0", Offset = "0x4B458E0", VA = "0x184B46CE0", Slot = "62")]
			get
			{
				return default(LFHLJBHJLKP<DGPIFHHHHCH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public ENBGACDEBPI<DGPIFHHHHCH> MLPOHMLJLBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x4B46B50", Offset = "0x4B45750", VA = "0x184B46B50", Slot = "56")]
			get
			{
				return default(ENBGACDEBPI<DGPIFHHHHCH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool BJKMHFIBGCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public virtual ENBGACDEBPI<DGPIFHHHHCH>? AIBEGIJMEAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "128")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public virtual bool PEBEEKINBJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public bool EKMDJMLLGLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x4B46C10", Offset = "0x4B45810", VA = "0x184B46C10", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string NMFKAOGOELC
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x963230", Offset = "0x961E30", VA = "0x180963230", Slot = "65")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x963150", Offset = "0x961D50", VA = "0x180963150")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public string NNABJDJEFFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x963180", Offset = "0x961D80", VA = "0x180963180", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x9631B0", Offset = "0x961DB0", VA = "0x1809631B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public ENBGACDEBPI<CALHCHFEDII> HAICHNBGFBB
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x4B46F50", Offset = "0x4B45B50", VA = "0x184B46F50", Slot = "63")]
			get
			{
				return default(ENBGACDEBPI<CALHCHFEDII>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public LFHLJBHJLKP<CALHCHFEDII> OCHMPKCAHKO
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x4B46D40", Offset = "0x4B45940", VA = "0x184B46D40", Slot = "64")]
			get
			{
				return default(LFHLJBHJLKP<CALHCHFEDII>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public LFHLJBHJLKP<CALHCHFEDII>? GNBLOBBMLLD
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x4B46FB0", Offset = "0x4B45BB0", VA = "0x184B46FB0", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public EMOAAMIFIJJ<IEOKEELCLHA, LAPGJAKNNOF> PACIIEFFHDM
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x4B470A0", Offset = "0x4B45CA0", VA = "0x184B470A0", Slot = "67")]
			get
			{
				return default(EMOAAMIFIJJ<IEOKEELCLHA, LAPGJAKNNOF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public virtual ENBGACDEBPI<IEOKEELCLHA>? AHEEEHMNEOD
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "131")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public virtual bool CGIJHAMNCCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "134")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public virtual bool GHJEJBKIAEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "135")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action OFOPAHLDOBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x4B454A0", Offset = "0x4B440A0", VA = "0x184B454A0", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x4B42A50", Offset = "0x4B41650", VA = "0x184B42A50", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event FANHMHBFLIN BIECDGGJOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x4B42910", Offset = "0x4B41510", VA = "0x184B42910", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x4B42360", Offset = "0x4B40F60", VA = "0x184B42360", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event OLLMAEAHMJN BBJDBGCCALP
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x4B44D70", Offset = "0x4B43970", VA = "0x184B44D70", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x4B46100", Offset = "0x4B44D00", VA = "0x184B46100", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action AHPHFCDHMGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x4B43F10", Offset = "0x4B42B10", VA = "0x184B43F10", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x4B429F0", Offset = "0x4B415F0", VA = "0x184B429F0", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action PMKFCILKIGN
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x4B42CA0", Offset = "0x4B418A0", VA = "0x184B42CA0", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x4B45B50", Offset = "0x4B44750", VA = "0x184B45B50", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<ENBGACDEBPI<IEOKEELCLHA>, LAPGJAKNNOF> HMDHOKMNKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x4B43FE0", Offset = "0x4B42BE0", VA = "0x184B43FE0", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x4B43E50", Offset = "0x4B42A50", VA = "0x184B43E50", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<ENBGACDEBPI<IEOKEELCLHA>, LAPGJAKNNOF> NIFKAFHOMLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x4B440A0", Offset = "0x4B42CA0", VA = "0x184B440A0", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x4B453E0", Offset = "0x4B43FE0", VA = "0x184B453E0", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<ENBGACDEBPI<IEOKEELCLHA>> HFCBOFHGNJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x4B44BF0", Offset = "0x4B437F0", VA = "0x184B44BF0", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x4B46040", Offset = "0x4B44C40", VA = "0x184B46040", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<ENBGACDEBPI<IEOKEELCLHA>, ENBGACDEBPI<IEOKEELCLHA>> EGFEEPNFNMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x4B45800", Offset = "0x4B44400", VA = "0x184B45800", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x4B44CB0", Offset = "0x4B438B0", VA = "0x184B44CB0", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<ENBGACDEBPI<IEOKEELCLHA>, LAPGJAKNNOF> BFOIHHFBACP
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x4B44B30", Offset = "0x4B43730", VA = "0x184B44B30", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x4B43370", Offset = "0x4B41F70", VA = "0x184B43370", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<ENBGACDEBPI<IEOKEELCLHA>, ENBGACDEBPI<IEOKEELCLHA>> MGLBNOKBFEA
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x4B42400", Offset = "0x4B41000", VA = "0x184B42400", Slot = "79")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x4B45740", Offset = "0x4B44340", VA = "0x184B45740", Slot = "80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x4B461A0", Offset = "0x4B44DA0", VA = "0x184B461A0")]
		[LDOMFOOMHLM("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[LDOMFOOMHLM("Need to handle `Name` better.")]
		protected LLFAKGDCGIP(FAMECBPCILE JKPOOJNKKFK, TNode PCMPEACCDMA, bool DMADAMBBKKK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x4B420B0", Offset = "0x4B40CB0", VA = "0x184B420B0", Slot = "99")]
		protected virtual void AIMKJDEKJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x4B42DA0", Offset = "0x4B419A0", VA = "0x184B42DA0", Slot = "100")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x4B43730", Offset = "0x4B42330", VA = "0x184B43730", Slot = "9")]
		[AsyncStateMachine(typeof(LLFAKGDCGIP<>.KIEOAADKDKN))]
		public void GFDEABLGCNI(int DCPLPAILHGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x4B45FD0", Offset = "0x4B44BD0", VA = "0x184B45FD0")]
		public bool PIOFCCFCOMD([In] DNFPMKILKNL MPDLOLIOGJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x4B445E0", Offset = "0x4B431E0", VA = "0x184B445E0")]
		public bool IGMBLBIJEJF([In] ONBJGGOKCEK MPDLOLIOGJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x4B45D80", Offset = "0x4B44980", VA = "0x184B45D80", Slot = "32")]
		public void PBPLDLOOFHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x4B42B10", Offset = "0x4B41710", VA = "0x184B42B10", Slot = "33")]
		[AsyncStateMachine(typeof(LLFAKGDCGIP<>.MMJOCJGEFJO))]
		public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> DELNMKKLBBL(DNFPMKILKNL? DDPAPHFNFJI, ONBJGGOKCEK? CIDNHFONBIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "109")]
		public virtual void HNDJNLDILOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "110")]
		public virtual void EBFFPOELNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "111")]
		public virtual void GDELKEKAAED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xD472D0", Offset = "0xD45ED0", VA = "0x180D472D0")]
		protected void AODNOMFPMKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xD993B0", Offset = "0xD97FB0", VA = "0x180D993B0")]
		protected void KDOJCMAOADI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x4B43710", Offset = "0x4B42310", VA = "0x184B43710")]
		private void GECPGNCLBPP([In] ONBJGGOKCEK APLHHNGOEFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x4B452D0", Offset = "0x4B43ED0", VA = "0x184B452D0", Slot = "112")]
		public virtual Task<PNJEPLMEKHI<ENBGACDEBPI<IEOKEELCLHA>, GEJJJMKDLKA>> MBGKBOGINKG(string BGKKCEGMOKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x4B44160", Offset = "0x4B42D60", VA = "0x184B44160", Slot = "113")]
		public virtual Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> HNGHMHLJJLI(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "114")]
		public virtual void PBKAMELKEJC(ENBGACDEBPI<IEOKEELCLHA> BKIPLAIOAJI, ENBGACDEBPI<IEOKEELCLHA> LBKEBCEAGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x4B45BF0", Offset = "0x4B447F0", VA = "0x184B45BF0", Slot = "115")]
		public virtual IEnumerable<JCKDHEKPOIA> ONNCPLDEEFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x4B45AC0", Offset = "0x4B446C0", VA = "0x184B45AC0", Slot = "116")]
		public PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA> OJHIHBCAHFA(string BKCFGJBABFD)
		{
			return default(PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x4B424C0", Offset = "0x4B410C0", VA = "0x184B424C0", Slot = "47")]
		public bool BEBGGLLKCCN([Out] Guid NHDBIBGECPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x4B42650", Offset = "0x4B41250", VA = "0x184B42650")]
		public bool BJDLHLJAMOA([In] Guid OJOHECDAGPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "117")]
		public virtual void EDPJFJHBEFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "118")]
		public virtual void BKBKDFGMLHC(bool OMMHNJIICCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "119")]
		public virtual PACLOCJJNCH HJNAPDBMEMN([In] ANPLDAJLOOE IMJBIBCBMFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x4B45540", Offset = "0x4B44140", VA = "0x184B45540")]
		protected void MPFEMNDBJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x4B453A0", Offset = "0x4B43FA0", VA = "0x184B453A0", Slot = "124")]
		protected virtual bool MDBNHGLBHIP(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x4B45FA0", Offset = "0x4B44BA0", VA = "0x184B45FA0", Slot = "88")]
		public bool PIMDDAFKNMA(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "125")]
		protected virtual bool CHIJJHCICDN(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "132")]
		protected virtual void DGPHNKAMBPD(EFGCLJPHEPI OEGLCHBMCKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x4B44EC0", Offset = "0x4B43AC0", VA = "0x184B44EC0")]
		protected void MBDJHNKFPAF(EFGCLJPHEPI GHDIMMIOLAG, Func<string> ONHHLICMPMF, Action<string> AMENMNKOLPB, string PHNKGKOOMFK, string EMBKNOGEIDF, string CMFIKLEIKJF, NCGKFCOACAA LCBCOHFFAPC, HOEHDJGMMIJ DKGNMNFCAFC, Func<string, bool> AICCBFGNMGK, string FBNEAMBLMHB, Func<string, bool> MAIAGJGEOAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x4B446C0", Offset = "0x4B432C0", VA = "0x184B446C0")]
		protected void JBEJDBKAFPN(EFGCLJPHEPI GHDIMMIOLAG, Func<string> ONHHLICMPMF, Action<string> AMENMNKOLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x4B43430", Offset = "0x4B42030", VA = "0x184B43430", Slot = "133")]
		protected virtual void FOLMLELOLKG(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x4B431C0", Offset = "0x4B41DC0", VA = "0x184B431C0", Slot = "82")]
		public void EFJIOBCCABG(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x4B45C80", Offset = "0x4B44880", VA = "0x184B45C80", Slot = "83")]
		public OJLANLIGMEM PADPFENDAHG()
		{
			return default(OJLANLIGMEM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "136")]
		public virtual bool FPHCNJJKEGJ(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x1CECCB0", Offset = "0x1CEB8B0", VA = "0x181CECCB0")]
		private void ICKHFNDHMGK([In] DNFPMKILKNL FCININPMBGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x4B449C0", Offset = "0x4B435C0", VA = "0x184B449C0")]
		private void KOOMJAPACPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x4B42C60", Offset = "0x4B41860", VA = "0x184B42C60", Slot = "89")]
		private void DLPGGMMJBFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x4B43890", Offset = "0x4B42490", VA = "0x184B43890", Slot = "91")]
		private void GICHLGINHBC(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0xED5130", Offset = "0xED3D30", VA = "0x180ED5130", Slot = "93")]
		private void LEJAJJBGPDE(ENBGACDEBPI<IEOKEELCLHA> HGEMPDBGGBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x4B45900", Offset = "0x4B44500", VA = "0x184B45900", Slot = "95")]
		private void OGCFKCBKBLB(ENBGACDEBPI<IEOKEELCLHA> HGEMPDBGGBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x4B44230", Offset = "0x4B42E30", VA = "0x184B44230", Slot = "96")]
		private void HPGFDIGGHCI(ENBGACDEBPI<IEOKEELCLHA> BKIPLAIOAJI, ENBGACDEBPI<IEOKEELCLHA> LBKEBCEAGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0xED5150", Offset = "0xED3D50", VA = "0x180ED5150", Slot = "97")]
		private void OKIKPNOALNK(ENBGACDEBPI<IEOKEELCLHA> BKIPLAIOAJI, ENBGACDEBPI<IEOKEELCLHA> LBKEBCEAGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x4B42AF0", Offset = "0x4B416F0", VA = "0x184B42AF0", Slot = "90")]
		private void DCNBEBOMCJA(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x4B41C90", Offset = "0x4B40890", VA = "0x184B41C90", Slot = "92")]
		private void ABPLDKNJCCH(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x4B44650", Offset = "0x4B43250", VA = "0x184B44650", Slot = "94")]
		private void IHOPMICCNEO(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x4B435F0", Offset = "0x4B421F0", VA = "0x184B435F0", Slot = "137")]
		[AsyncStateMachine(typeof(LLFAKGDCGIP<>.GKOIODKEJDK))]
		public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> GBMDHALKPHN(string BKCFGJBABFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x4B43300", Offset = "0x4B41F00", VA = "0x184B43300", Slot = "54")]
		private void FHNGMNECIEF(object EBEBJNFIBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x4B437E0", Offset = "0x4B423E0", VA = "0x184B437E0", Slot = "55")]
		private void GFHHELGHHMP(object EBEBJNFIBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x4B42610", Offset = "0x4B41210", VA = "0x184B42610", Slot = "29")]
		private bool BHABEIPBHEA([In] DNFPMKILKNL MPDLOLIOGJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x4B43850", Offset = "0x4B42450", VA = "0x184B43850", Slot = "31")]
		private bool GGMPHMPEHJJ([In] ONBJGGOKCEK MPDLOLIOGJL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x4B429B0", Offset = "0x4B415B0", VA = "0x184B429B0", Slot = "48")]
		private bool BOOCOEDIMFF([In] Guid OJOHECDAGPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x4B458C0", Offset = "0x4B444C0", VA = "0x184B458C0")]
		[CompilerGenerated]
		private string OFEIAKFANJA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x4B44E10", Offset = "0x4B43A10", VA = "0x184B44E10")]
		[CompilerGenerated]
		private void MADMKHIFMEL(string BGKKCEGMOKH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class AAENPOFBBLC : FBCEFDDOKPD<ILJLJJMELGN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xC08010", Offset = "0xC06C10", VA = "0x180C08010", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x2503F40", Offset = "0x2502B40", VA = "0x182503F40")]
		public AAENPOFBBLC(FAMECBPCILE JKPOOJNKKFK, ILJLJJMELGN PCMPEACCDMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class PKHPCDDOFNH : HFMAADDLBNH<PANFCJNHDJA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0xA78B70", Offset = "0xA77770", VA = "0x180A78B70", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x251FD70", Offset = "0x251E970", VA = "0x18251FD70")]
		public PKHPCDDOFNH(FAMECBPCILE JKPOOJNKKFK, PANFCJNHDJA PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public abstract class NPFMMHGJODH<T> : LLFAKGDCGIP<T> where T : notnull, LJDMOOOPJLK
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class EAPMPEBPKGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public IReadOnlyList<KeyValuePair<string, JJHGKOMIDDI>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public NPFMMHGJODH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public IPBDEJGDKMN clipType;

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public EAPMPEBPKGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
			internal IReadOnlyList<KeyValuePair<string, JJHGKOMIDDI>> ECKGNBOKHAD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x3FB0D60", Offset = "0x3FAF960", VA = "0x183FB0D60")]
			internal int IODFOKGBFJC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x3FB06E0", Offset = "0x3FAF2E0", VA = "0x183FB06E0")]
			internal void APCHIBOENLE(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x3FB09F0", Offset = "0x3FAF5F0", VA = "0x183FB09F0")]
			internal void CFKDKHFDFHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x3FB0BB0", Offset = "0x3FAF7B0", VA = "0x183FB0BB0")]
			internal void HGCJLPFAHJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x3FB0960", Offset = "0x3FAF560", VA = "0x183FB0960")]
			internal bool JDNCLAOOCPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x3FB0B00", Offset = "0x3FAF700", VA = "0x183FB0B00")]
			internal void EBJCNPJBEJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x3FB0960", Offset = "0x3FAF560", VA = "0x183FB0960")]
			internal bool BOLAFHBOCHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x3FB0900", Offset = "0x3FAF500", VA = "0x183FB0900")]
			internal float BCMPBIOEJKE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x3FB0A40", Offset = "0x3FAF640", VA = "0x183FB0A40")]
			internal void DOIEFLDMNNF(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x3FB0B50", Offset = "0x3FAF750", VA = "0x183FB0B50")]
			internal float HCAMHFPCDIB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x3FB0F80", Offset = "0x3FAFB80", VA = "0x183FB0F80")]
			internal void LJJAJDDHMNM(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x3FB0D00", Offset = "0x3FAF900", VA = "0x183FB0D00")]
			internal float ICCJPHAOILJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x3FB0EC0", Offset = "0x3FAFAC0", VA = "0x183FB0EC0")]
			internal void KPKEKGFGFMG(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0xEE17D0", Offset = "0xEE03D0", VA = "0x180EE17D0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public abstract IPBDEJGDKMN IKGNOOAGKHC
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(Slot = "138")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x4D3D780", Offset = "0x4D3C380", VA = "0x184D3D780")]
		public NPFMMHGJODH(FAMECBPCILE JKPOOJNKKFK, T PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x4E68590", Offset = "0x4E67190", VA = "0x184E68590", Slot = "132")]
		protected sealed override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private sealed class MJIHEMCOPJJ : LLFAKGDCGIP<HCCCOIJCKPG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0xC180F0", Offset = "0xC16CF0", VA = "0x180C180F0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x2517A80", Offset = "0x2516680", VA = "0x182517A80")]
		public MJIHEMCOPJJ(FAMECBPCILE JKPOOJNKKFK, HCCCOIJCKPG PCMPEACCDMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class EBOAPLHAEKF : LLFAKGDCGIP<KCOGDACDFHE>
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class BFCBFJGNGOC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public EBOAPLHAEKF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public BFCBFJGNGOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x250A380", Offset = "0x2508F80", VA = "0x18250A380")]
			internal int IODFOKGBFJC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x250A2F0", Offset = "0x2508EF0", VA = "0x18250A2F0")]
			internal void APCHIBOENLE(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static Dictionary<string, JJHGKOMIDDI>? JKADFHCODJM;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x250C5A0", Offset = "0x250B1A0", VA = "0x18250C5A0")]
		public EBOAPLHAEKF(FAMECBPCILE JKPOOJNKKFK, KCOGDACDFHE PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x250C230", Offset = "0x250AE30", VA = "0x18250C230", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class AOHKAJIGJEG : NPFMMHGJODH<HEMPONJPABE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override IPBDEJGDKMN IKGNOOAGKHC
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "138")]
			get
			{
				return default(IPBDEJGDKMN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x2509BF0", Offset = "0x25087F0", VA = "0x182509BF0")]
		public AOHKAJIGJEG(FAMECBPCILE JKPOOJNKKFK, HEMPONJPABE FOBBPKHANPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private sealed class GOGIOHLAALI : HFMAADDLBNH<BMEJOGNNOKA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0xA78B70", Offset = "0xA77770", VA = "0x180A78B70", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x2510830", Offset = "0x250F430", VA = "0x182510830")]
		public GOGIOHLAALI(FAMECBPCILE JKPOOJNKKFK, BMEJOGNNOKA PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private sealed class EDHEAKJGGNN : HFMAADDLBNH<FLAEHIJIGBE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0xA78B70", Offset = "0xA77770", VA = "0x180A78B70", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x250C610", Offset = "0x250B210", VA = "0x18250C610")]
		public EDHEAKJGGNN(FAMECBPCILE JKPOOJNKKFK, FLAEHIJIGBE PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class AANGADEEOBK : FKBLAAIAIDN<IEDOANOOEKJ>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private sealed class AMIBLJOCKNH
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000A1")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D9")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001DA")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001DB")]
				public AMIBLJOCKNH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001DC")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001DD")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001DE")]
				private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003D7")]
				[Cpp2IlInjected.Address(RVA = "0x251FDD0", Offset = "0x251E9D0", VA = "0x18251FDD0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public AANGADEEOBK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public AMIBLJOCKNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x2509B20", Offset = "0x2508720", VA = "0x182509B20")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void OGBCDOPDHMA(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x25042F0", Offset = "0x2502EF0", VA = "0x1825042F0")]
		public AANGADEEOBK(FAMECBPCILE JKPOOJNKKFK, IEDOANOOEKJ FOBBPKHANPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2504010", Offset = "0x2502C10", VA = "0x182504010", Slot = "138")]
		protected override void GMHOCGONOMO(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public sealed class JCNNJDFBIJM : NPFMMHGJODH<EBNKPHCHGIE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public override IPBDEJGDKMN IKGNOOAGKHC
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xA5CE90", Offset = "0xA5BA90", VA = "0x180A5CE90", Slot = "138")]
			get
			{
				return default(IPBDEJGDKMN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x2515030", Offset = "0x2513C30", VA = "0x182515030")]
		public JCNNJDFBIJM(FAMECBPCILE JKPOOJNKKFK, EBNKPHCHGIE FOBBPKHANPP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private sealed class LDBJHPPNKLL : LLFAKGDCGIP<EBIPMJHMDGE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xC1E180", Offset = "0xC1CD80", VA = "0x180C1E180", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x25177C0", Offset = "0x25163C0", VA = "0x1825177C0")]
		public LDBJHPPNKLL(FAMECBPCILE JKPOOJNKKFK, EBIPMJHMDGE PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class LCMLFMCCEPE : LLFAKGDCGIP<MLOPPHLHELH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public sealed override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public sealed override bool FFGLPEBPIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "104")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		protected sealed override bool CJILPBNMBIA
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x2517750", Offset = "0x2516350", VA = "0x182517750")]
		public LCMLFMCCEPE(FAMECBPCILE JKPOOJNKKFK, MLOPPHLHELH PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x25173E0", Offset = "0x2515FE0", VA = "0x1825173E0", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x2517710", Offset = "0x2516310", VA = "0x182517710")]
		private int NHDMHADIFDC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x25176B0", Offset = "0x25162B0", VA = "0x1825176B0")]
		private void MELDFFGEGID(int HLFIFJFGNJJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class HMIFEOIHFLC : AAJIPNHJMAF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x2503FA0", Offset = "0x2502BA0", VA = "0x182503FA0")]
		public HMIFEOIHFLC(FAMECBPCILE JKPOOJNKKFK, LJNEMHENPLP PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class NFGBOFCAANN : FKBLAAIAIDN<CEOKIPELMCN>
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2517DF0", Offset = "0x25169F0", VA = "0x182517DF0")]
		public NFGBOFCAANN(FAMECBPCILE JKPOOJNKKFK, CEOKIPELMCN PCMPEACCDMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public abstract class FKBLAAIAIDN<TVariableNode> : LLFAKGDCGIP<TVariableNode> where TVariableNode : notnull, CEOKIPELMCN
	{
		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class GHIEPABPFMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public FKBLAAIAIDN<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public GHIEPABPFMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x44D9CF0", Offset = "0x44D88F0", VA = "0x1844D9CF0")]
			internal bool ECKGNBOKHAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x44D9E80", Offset = "0x44D8A80", VA = "0x1844D9E80")]
			internal void IODFOKGBFJC(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x44D9BD0", Offset = "0x44D87D0", VA = "0x1844D9BD0")]
			internal bool APCHIBOENLE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x44D9C30", Offset = "0x44D8830", VA = "0x1844D9C30")]
			internal void CFKDKHFDFHN(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x44D9D50", Offset = "0x44D8950", VA = "0x1844D9D50")]
			internal bool HGCJLPFAHJL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		[CompilerGenerated]
		private sealed class MDHLAMPKFFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public EBFPIMNMNKD nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public FKBLAAIAIDN<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public MDHLAMPKFFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x4D3CA90", Offset = "0x4D3B690", VA = "0x184D3CA90")]
			internal void OGBCDOPDHMA(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public override NodeVisualizationKey JFPNHMHDAFB
		{
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0xA79860", Offset = "0xA78460", VA = "0x180A79860", Slot = "103")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public override JPKMCBBAEKK BMDCBAGMOCE
		{
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x4412D10", Offset = "0x4411910", VA = "0x184412D10", Slot = "106")]
			get
			{
				return default(JPKMCBBAEKK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x4412B60", Offset = "0x4411760", VA = "0x184412B60")]
		protected FKBLAAIAIDN(FAMECBPCILE JKPOOJNKKFK, TVariableNode PCMPEACCDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x4412520", Offset = "0x4411120", VA = "0x184412520", Slot = "100")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x4412070", Offset = "0x4410C70", VA = "0x184412070", Slot = "132")]
		protected override void DGPHNKAMBPD(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x44127C0", Offset = "0x44113C0", VA = "0x1844127C0", Slot = "138")]
		protected virtual void GMHOCGONOMO(EFGCLJPHEPI GHDIMMIOLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x44126C0", Offset = "0x44112C0", VA = "0x1844126C0", Slot = "117")]
		public override void EDPJFJHBEFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x24E9B00", Offset = "0x24E8700", VA = "0x1824E9B00")]
	public static PJCAPLMNIMG JPHABLICNHB(FAMECBPCILE JKPOOJNKKFK, LJNEMHENPLP PCMPEACCDMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class CAOIEFKBMAO : IEKFOPGJECA, OADLLJHELHI, GJPMPHEFBOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public ENBGACDEBPI<BEIDLONMPPN> BHDEOIDKDGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xBEA7E0", Offset = "0xBE93E0", VA = "0x180BEA7E0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(ENBGACDEBPI<BEIDLONMPPN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public ENBGACDEBPI<JCNFOBNEGFN> JLIDOPMOHFD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xCFFAD0", Offset = "0xCFE6D0", VA = "0x180CFFAD0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(ENBGACDEBPI<JCNFOBNEGFN>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x250AA40", Offset = "0x2509640", VA = "0x18250AA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	private ENBGACDEBPI<KANNHDBHICO> GMJFHEFOHCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xBE8FF0", Offset = "0xBE7BF0", VA = "0x180BE8FF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public override ENBGACDEBPI<JDGCKBCLIAF> BDBIIAAAJLN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x250ADA0", Offset = "0x25099A0", VA = "0x18250ADA0", Slot = "21")]
		get
		{
			return default(ENBGACDEBPI<JDGCKBCLIAF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x250ADF0", Offset = "0x25099F0", VA = "0x18250ADF0")]
	private CAOIEFKBMAO(FAMECBPCILE JKPOOJNKKFK, LJNEMHENPLP PCMPEACCDMA, LDIJBPKAEPP FDJDGEIHMFC, ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, ENBGACDEBPI<JCNFOBNEGFN> GDGENKFJMLI, ENBGACDEBPI<KANNHDBHICO> CHKKMPEGFNO, bool BIODMIKFGFC, string BGKKCEGMOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x250AA50", Offset = "0x2509650", VA = "0x18250AA50")]
	public static CAOIEFKBMAO JPHABLICNHB(FAMECBPCILE JKPOOJNKKFK, LJNEMHENPLP PCMPEACCDMA, LDIJBPKAEPP EPOPAMDLOCM, ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, ENBGACDEBPI<KANNHDBHICO> CHKKMPEGFNO, ENBGACDEBPI<JCNFOBNEGFN> GDGENKFJMLI, bool BIODMIKFGFC, bool DMADAMBBKKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x250AA40", Offset = "0x2509640", VA = "0x18250AA40")]
	internal void FGNEAKBIPPE(ENBGACDEBPI<JCNFOBNEGFN> MPDLOLIOGJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public abstract class IEKFOPGJECA : GJPMPHEFBOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private struct CHOPHKILNEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private NNBODIKACMF? JCBOOPOOFLM;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x250B180", Offset = "0x2509D80", VA = "0x18250B180")]
		public void NGMONOEHMBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x250B0E0", Offset = "0x2509CE0", VA = "0x18250B0E0")]
		public NNBODIKACMF JFBGIFPFGEP(IEKFOPGJECA MOPJHMEAAHF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	protected readonly FAMECBPCILE PEFFIDGBCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	protected readonly LJNEMHENPLP FEPPGMKMBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private CHOPHKILNEH JGMLCHKMNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private readonly IJEHCGPBGHE NOGPCKGHICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private readonly List<BCKIKIAHNAL> HHNAEMMMMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly List<LGBBOLCBPOI> IPCMIHLJJOF;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	[LDOMFOOMHLM("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> HFJPAFMNDMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x25140D0", Offset = "0x2512CD0", VA = "0x1825140D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public DisplayKind HCBPABNJICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x968110", Offset = "0x966D10", VA = "0x180968110", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public ENBGACDEBPI<DGPIFHHHHCH> MLPOHMLJLBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x25134B0", Offset = "0x25120B0", VA = "0x1825134B0", Slot = "6")]
		get
		{
			return default(ENBGACDEBPI<DGPIFHHHHCH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public LFHLJBHJLKP<DGPIFHHHHCH> DMDLHJDIMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x2514060", Offset = "0x2512C60", VA = "0x182514060", Slot = "7")]
		get
		{
			return default(LFHLJBHJLKP<DGPIFHHHHCH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public NOLLBBDMJJO DJBPBFFLLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xBF1390", Offset = "0xBEFF90", VA = "0x180BF1390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public EBDFOIFILCK EENDPMLGPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x2513910", Offset = "0x2512510", VA = "0x182513910", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	protected NNBODIKACMF KOAOPHNFEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x2513910", Offset = "0x2512510", VA = "0x182513910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public PortImage PJNABPBEOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x25137E0", Offset = "0x25123E0", VA = "0x1825137E0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public string NMFKAOGOELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x95D120", Offset = "0x95BD20", VA = "0x18095D120", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x95D110", Offset = "0x95BD10", VA = "0x18095D110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public LFHLJBHJLKP<CALHCHFEDII> OCHMPKCAHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x25140B0", Offset = "0x2512CB0", VA = "0x1825140B0", Slot = "9")]
		get
		{
			return default(LFHLJBHJLKP<CALHCHFEDII>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public ENBGACDEBPI<IEOKEELCLHA> GEDKKBIAHPA
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0xBD46A0", Offset = "0xBD32A0", VA = "0x180BD46A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(ENBGACDEBPI<IEOKEELCLHA>);
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xCFF540", Offset = "0xCFE140", VA = "0x180CFF540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public abstract ENBGACDEBPI<JDGCKBCLIAF> BDBIIAAAJLN
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x25144E0", Offset = "0x25130E0", VA = "0x1825144E0")]
	protected IEKFOPGJECA(FAMECBPCILE JKPOOJNKKFK, LJNEMHENPLP PCMPEACCDMA, IJEHCGPBGHE JCJFNFCDOLA, ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, bool BIODMIKFGFC, string BGKKCEGMOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2513360", Offset = "0x2511F60", VA = "0x182513360", Slot = "22")]
	protected virtual void AIMKJDEKJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x2513690", Offset = "0x2512290", VA = "0x182513690", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x25142D0", Offset = "0x2512ED0", VA = "0x1825142D0", Slot = "14")]
	public void PMOOCFGFMEK(BCKIKIAHNAL JDLCKFEIKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x2514210", Offset = "0x2512E10", VA = "0x182514210", Slot = "15")]
	public void PBEEKBDLFEI(LGBBOLCBPOI JDLCKFEIKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x25139B0", Offset = "0x25125B0", VA = "0x1825139B0", Slot = "16")]
	public void JGENKHDOAJE(PLGCMHMLCPK FJECIINKNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2514270", Offset = "0x2512E70", VA = "0x182514270", Slot = "24")]
	protected virtual void PGPGIGPLHLB(PLGCMHMLCPK FJECIINKNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x25131D0", Offset = "0x2511DD0", VA = "0x1825131D0", Slot = "19")]
	private void AHCAFDGDMMB(bool LOJMCGAMMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x25134E0", Offset = "0x25120E0", VA = "0x1825134E0")]
	private void DLNCBBEIGOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x2514330", Offset = "0x2512F30", VA = "0x182514330")]
	private void POGAMEAMMCH([In] KOOALDDHOFM CCIFCGOIMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x2513780", Offset = "0x2512380", VA = "0x182513780", Slot = "17")]
	public void HEANDCIJLED(BCKIKIAHNAL JDLCKFEIKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2513450", Offset = "0x2512050", VA = "0x182513450", Slot = "18")]
	public void AOOEOHBOGDI(LGBBOLCBPOI JDLCKFEIKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x95D110", Offset = "0x95BD10", VA = "0x18095D110")]
	internal void IOEPHEIDOFD(string BGKKCEGMOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x2514090", Offset = "0x2512C90", VA = "0x182514090")]
	internal void MNIFGAIGOAM(PDBAPHICGIJ CJMMHNIMOJB, NOLLBBDMJJO ADFFEBFOCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0xCFF540", Offset = "0xCFE140", VA = "0x180CFF540")]
	internal void CBMANOMEOPN(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class AGLEKNPGMHN : LAPGJAKNNOF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class GCOEEGBAFDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public FAMECBPCILE circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public LJNEMHENPLP node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public ENBGACDEBPI<IEOKEELCLHA> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public GCOEEGBAFDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x250E760", Offset = "0x250D360", VA = "0x18250E760")]
		internal COEGKLDIKHF JCLDDHEGPLB((int PortDescIndex, int PortIndex, MJFKIBKLKDD InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x250E7F0", Offset = "0x250D3F0", VA = "0x18250E7F0")]
		internal CAOIEFKBMAO PIGKHCKHAKP(LDIJBPKAEPP i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct HMNCJIHLEBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public AGLEKNPGMHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private MBINOHCLPKN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x2512AE0", Offset = "0x25116E0", VA = "0x182512AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x2512F50", Offset = "0x2511B50", VA = "0x182512F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct AJEKJFFHMBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public AGLEKNPGMHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public ENBGACDEBPI<NKPIAFBIEBF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private MBINOHCLPKN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x2509760", Offset = "0x2508360", VA = "0x182509760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2509AB0", Offset = "0x25086B0", VA = "0x182509AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct DNJPCBBCEKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public AGLEKNPGMHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public ENBGACDEBPI<KANNHDBHICO> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private MBINOHCLPKN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x250BE70", Offset = "0x250AA70", VA = "0x18250BE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x250C1C0", Offset = "0x250ADC0", VA = "0x18250C1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct GDEKOCKCJHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public AGLEKNPGMHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public ENBGACDEBPI<NKPIAFBIEBF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public ENBGACDEBPI<NKPIAFBIEBF> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private MBINOHCLPKN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x250E880", Offset = "0x250D480", VA = "0x18250E880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x250EBE0", Offset = "0x250D7E0", VA = "0x18250EBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct CLCHHMKGDGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public AGLEKNPGMHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public ENBGACDEBPI<KANNHDBHICO> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public ENBGACDEBPI<KANNHDBHICO> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private MBINOHCLPKN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x250B790", Offset = "0x250A390", VA = "0x18250B790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x250BAF0", Offset = "0x250A6F0", VA = "0x18250BAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct JLLCCJKMINO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public AGLEKNPGMHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private MBINOHCLPKN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2516040", Offset = "0x2514C40", VA = "0x182516040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x25164C0", Offset = "0x25150C0", VA = "0x1825164C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct PDNINBLLJDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AGLEKNPGMHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private MBINOHCLPKN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x251F500", Offset = "0x251E100", VA = "0x18251F500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x251F850", Offset = "0x251E450", VA = "0x18251F850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct HGPIGAJIHHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public AGLEKNPGMHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public ENBGACDEBPI<NKPIAFBIEBF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private MBINOHCLPKN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x25125E0", Offset = "0x25111E0", VA = "0x1825125E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2512950", Offset = "0x2511550", VA = "0x182512950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct ENEJKBOMFHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public AGLEKNPGMHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public ENBGACDEBPI<KANNHDBHICO> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private MBINOHCLPKN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x250C780", Offset = "0x250B380", VA = "0x18250C780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x250CAF0", Offset = "0x250B6F0", VA = "0x18250CAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct GCCEPDBHLGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AGLEKNPGMHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public OFHLJOHAOPH type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public ENBGACDEBPI<NKPIAFBIEBF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private MBINOHCLPKN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x250E350", Offset = "0x250CF50", VA = "0x18250E350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x250E6F0", Offset = "0x250D2F0", VA = "0x18250E6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct FMINPGNMDKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AGLEKNPGMHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public OFHLJOHAOPH type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public ENBGACDEBPI<KANNHDBHICO> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private MBINOHCLPKN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x250DF40", Offset = "0x250CB40", VA = "0x18250DF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x250E2E0", Offset = "0x250CEE0", VA = "0x18250E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly bool AFEOABMPEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly FAMECBPCILE PEFFIDGBCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private readonly bool DEBAJNAOEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private EMOAAMIFIJJ<GBFFCGKIBLH, COEGKLDIKHF> ILKDJEDDFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private EMOAAMIFIJJ<GBFFCGKIBLH, NIONFIGLCKL> NEBMABIIEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly LJNEMHENPLP FEPPGMKMBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private EMOAAMIFIJJ<JCNFOBNEGFN, CAOIEFKBMAO> FNHBFGFOPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private EMOAAMIFIJJ<JCNFOBNEGFN, OADLLJHELHI> IONCHJGLGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private string? DAEDLCMBLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly BENFDNEBPGP JKFANBOFKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private ENBGACDEBPI<IEOKEELCLHA> PJMGJANBKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly bool PLGMCCOLOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	[CompilerGenerated]
	private Action? GFAHOLAELIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	[CompilerGenerated]
	private Action? GNIFNBAHHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	[CompilerGenerated]
	private Action<ENBGACDEBPI<GBFFCGKIBLH>>? OAEKAGDFPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	[CompilerGenerated]
	private Action<ENBGACDEBPI<JCNFOBNEGFN>>? MEHCIBJBKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private LAPGJAKNNOF.LGCPCCLCCBN? FBLOFDFBAGD;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool AGGBNHPMFPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x25052A0", Offset = "0x2503EA0", VA = "0x1825052A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool KOGGLDNMPKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2504AD0", Offset = "0x25036D0", VA = "0x182504AD0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool BFCIIEJIBAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2508C80", Offset = "0x2507880", VA = "0x182508C80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public LFHLJBHJLKP<DGPIFHHHHCH> DMDLHJDIMLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x2507800", Offset = "0x2506400", VA = "0x182507800", Slot = "7")]
		get
		{
			return default(LFHLJBHJLKP<DGPIFHHHHCH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool OPEFPBLKPBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2505CD0", Offset = "0x25048D0", VA = "0x182505CD0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public EMOAAMIFIJJ<GBFFCGKIBLH, NIONFIGLCKL> AAMNDDCCDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0", Slot = "9")]
		get
		{
			return default(EMOAAMIFIJJ<GBFFCGKIBLH, NIONFIGLCKL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public string NMFKAOGOELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x2508B30", Offset = "0x2507730", VA = "0x182508B30", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public LFHLJBHJLKP<CALHCHFEDII> OCHMPKCAHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x25092E0", Offset = "0x2507EE0", VA = "0x1825092E0", Slot = "11")]
		get
		{
			return default(LFHLJBHJLKP<CALHCHFEDII>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public EMOAAMIFIJJ<JCNFOBNEGFN, OADLLJHELHI> AAAMKHDINAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x95D120", Offset = "0x95BD20", VA = "0x18095D120", Slot = "12")]
		get
		{
			return default(EMOAAMIFIJJ<JCNFOBNEGFN, OADLLJHELHI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public ENBGACDEBPI<IEOKEELCLHA> GEDKKBIAHPA
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E0B0", Offset = "0xA6CCB0", VA = "0x180A6E0B0", Slot = "13")]
		get
		{
			return default(ENBGACDEBPI<IEOKEELCLHA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? OAKMPJHLHID
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x2508A90", Offset = "0x2507690", VA = "0x182508A90", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2507ED0", Offset = "0x2506AD0", VA = "0x182507ED0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action? NILNNCKANNC
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2505D50", Offset = "0x2504950", VA = "0x182505D50", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2506640", Offset = "0x2505240", VA = "0x182506640", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<ENBGACDEBPI<GBFFCGKIBLH?>, ENBGACDEBPI<GBFFCGKIBLH?>>? NCJBOKMPHKC
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2507BD0", Offset = "0x25067D0", VA = "0x182507BD0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x2506580", Offset = "0x2505180", VA = "0x182506580", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<ENBGACDEBPI<GBFFCGKIBLH?>, ENBGACDEBPI<GBFFCGKIBLH?>>? LHNKJNHBPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2505A00", Offset = "0x2504600", VA = "0x182505A00", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2506BD0", Offset = "0x25057D0", VA = "0x182506BD0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<ENBGACDEBPI<JCNFOBNEGFN?>, ENBGACDEBPI<JCNFOBNEGFN?>>? ODLDKEJNKEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2505AC0", Offset = "0x25046C0", VA = "0x182505AC0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2507E10", Offset = "0x2506A10", VA = "0x182507E10", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<ENBGACDEBPI<JCNFOBNEGFN?>, ENBGACDEBPI<JCNFOBNEGFN?>>? BFKOIPFBGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x2506A30", Offset = "0x2505630", VA = "0x182506A30", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2509430", Offset = "0x2508030", VA = "0x182509430", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<ENBGACDEBPI<GBFFCGKIBLH?>, NIONFIGLCKL?>? JBIBLCJHAMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2507C90", Offset = "0x2506890", VA = "0x182507C90", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x25089D0", Offset = "0x25075D0", VA = "0x1825089D0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<ENBGACDEBPI<GBFFCGKIBLH?>>? MOBOBCPAOHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x2507D50", Offset = "0x2506950", VA = "0x182507D50", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x2505490", Offset = "0x2504090", VA = "0x182505490", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<ENBGACDEBPI<GBFFCGKIBLH?>, NIONFIGLCKL?>? OJGPCHDHBNK
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x25064C0", Offset = "0x25050C0", VA = "0x1825064C0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x25045A0", Offset = "0x25031A0", VA = "0x1825045A0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<ENBGACDEBPI<JCNFOBNEGFN?>, OADLLJHELHI?>? EKLFKMJJMMD
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x25051E0", Offset = "0x2503DE0", VA = "0x1825051E0", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x2506EA0", Offset = "0x2505AA0", VA = "0x182506EA0", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<ENBGACDEBPI<JCNFOBNEGFN?>>? MMKFGLIKCNO
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x2507740", Offset = "0x2506340", VA = "0x182507740", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2506880", Offset = "0x2505480", VA = "0x182506880", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<ENBGACDEBPI<JCNFOBNEGFN?>, OADLLJHELHI?>? OPDBLBGMIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2506AF0", Offset = "0x25056F0", VA = "0x182506AF0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x2504ED0", Offset = "0x2503AD0", VA = "0x182504ED0", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x2509600", Offset = "0x2508200", VA = "0x182509600")]
	private AGLEKNPGMHN(bool BIODMIKFGFC, FAMECBPCILE JKPOOJNKKFK, bool PNJFEJNIECG, EMOAAMIFIJJ<GBFFCGKIBLH, COEGKLDIKHF> FFLPFHIJDHD, EMOAAMIFIJJ<GBFFCGKIBLH, NIONFIGLCKL> IOOMFCNCKIH, LJNEMHENPLP PCMPEACCDMA, EMOAAMIFIJJ<JCNFOBNEGFN, CAOIEFKBMAO> JJJIDDAMLHL, EMOAAMIFIJJ<JCNFOBNEGFN, OADLLJHELHI> BDICJKGDHGH, string? IBCDNAHKFME, BENFDNEBPGP JJKJHHAKPEK, ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, bool DMADAMBBKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x25070B0", Offset = "0x2505CB0", VA = "0x1825070B0")]
	public static AGLEKNPGMHN JPHABLICNHB(bool BIODMIKFGFC, FAMECBPCILE JKPOOJNKKFK, bool PNJFEJNIECG, LJNEMHENPLP PCMPEACCDMA, BENFDNEBPGP JJKJHHAKPEK, ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, bool DMADAMBBKKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2505640", Offset = "0x2504240", VA = "0x182505640", Slot = "69")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x2506DB0", Offset = "0x25059B0", VA = "0x182506DB0", Slot = "38")]
	[AsyncStateMachine(typeof(HMNCJIHLEBH))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA?>>? JLEMDMEKGHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2504FB0", Offset = "0x2503BB0", VA = "0x182504FB0")]
	private (EOOBIHFDLPF?, int)? DBBNOKAMJMK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x25091F0", Offset = "0x2507DF0", VA = "0x1825091F0", Slot = "58")]
	private void OHHEPFNEHGC(int PJNMCGNIDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F0E0", Offset = "0x1D0DCE0", VA = "0x181D0F0E0", Slot = "57")]
	private void EOFAGFNPNBC(int PJNMCGNIDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2507830", Offset = "0x2506430", VA = "0x182507830", Slot = "61")]
	private void KDLELHBIKNH(int PEINGJDKCCE, int AHHFGGMCFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x2507F90", Offset = "0x2506B90", VA = "0x182507F90", Slot = "63")]
	private void MFLOGAJCHJI(int PEINGJDKCCE, int AHHFGGMCFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2505E00", Offset = "0x2504A00", VA = "0x182505E00", Slot = "50")]
	private void FJKBPEJJEHJ(int PJNMCGNIDLE, ENBGACDEBPI<GBFFCGKIBLH> MHJKHPGEEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x25059E0", Offset = "0x25045E0", VA = "0x1825059E0", Slot = "54")]
	private void EBAABGHIFHH(int LOJMCGAMMAK, ENBGACDEBPI<GBFFCGKIBLH> MHJKHPGEEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2507F70", Offset = "0x2506B70", VA = "0x182507F70", Slot = "49")]
	private void LLKMOILGHPE(int LOJMCGAMMAK, ENBGACDEBPI<GBFFCGKIBLH> MHJKHPGEEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x2508580", Offset = "0x2507180", VA = "0x182508580", Slot = "53")]
	private void MIGLAOAPNPC(int PJNMCGNIDLE, ENBGACDEBPI<GBFFCGKIBLH> MHJKHPGEEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2505B80", Offset = "0x2504780", VA = "0x182505B80", Slot = "66")]
	private void ELBEILHCGFH(int PJNMCGNIDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x110D750", Offset = "0x110C350", VA = "0x18110D750", Slot = "65")]
	private void FHOPJLIGFOM(int PJNMCGNIDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x2506940", Offset = "0x2505540", VA = "0x182506940", Slot = "60")]
	private void IKMCDLMCFJD(int PJNMCGNIDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1D0F0E0", Offset = "0x1D0DCE0", VA = "0x181D0F0E0", Slot = "59")]
	private void KGPBPECMKHM(int PJNMCGNIDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2508E50", Offset = "0x2507A50", VA = "0x182508E50", Slot = "62")]
	private void OEMKKNFLFKF(int PEINGJDKCCE, int AHHFGGMCFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2506820", Offset = "0x2505420", VA = "0x182506820", Slot = "64")]
	private void IBCKKCPJPJK(int PEINGJDKCCE, int AHHFGGMCFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2507FF0", Offset = "0x2506BF0", VA = "0x182507FF0", Slot = "52")]
	private void MHAICONKMBF(int PJNMCGNIDLE, ENBGACDEBPI<JCNFOBNEGFN> MHJKHPGEEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2506BB0", Offset = "0x25057B0", VA = "0x182506BB0", Slot = "56")]
	private void IPOGJPGHKMI(int LOJMCGAMMAK, ENBGACDEBPI<JCNFOBNEGFN> MHJKHPGEEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2504F90", Offset = "0x2503B90", VA = "0x182504F90", Slot = "51")]
	private void CMNPNGFNAAN(int LOJMCGAMMAK, ENBGACDEBPI<JCNFOBNEGFN> MHJKHPGEEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2504660", Offset = "0x2503260", VA = "0x182504660", Slot = "55")]
	private void BGLJKKLGHMP(int PJNMCGNIDLE, ENBGACDEBPI<JCNFOBNEGFN> MHJKHPGEEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x2506F60", Offset = "0x2505B60", VA = "0x182506F60", Slot = "68")]
	private void JPDGKGEBLPI(int PJNMCGNIDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x110D750", Offset = "0x110C350", VA = "0x18110D750", Slot = "67")]
	private void CIMKGOCDJFB(int PJNMCGNIDLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x25094F0", Offset = "0x25080F0", VA = "0x1825094F0", Slot = "39")]
	[AsyncStateMachine(typeof(AJEKJFFHMBM))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA?>>? PKJHEPCAAPK(ENBGACDEBPI<NKPIAFBIEBF> BHGEFCDONFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2508D40", Offset = "0x2507940", VA = "0x182508D40", Slot = "40")]
	[AsyncStateMachine(typeof(DNJPCBBCEKJ))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA?>>? OBMMBBIAAJI(ENBGACDEBPI<KANNHDBHICO> CHKKMPEGFNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2506C90", Offset = "0x2505890", VA = "0x182506C90", Slot = "41")]
	[AsyncStateMachine(typeof(GDEKOCKCJHF))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA?>>? JKKOEBMOIPK(ENBGACDEBPI<NKPIAFBIEBF> BHGEFCDONFK, ENBGACDEBPI<NKPIAFBIEBF> EGMIMDCOMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2508B60", Offset = "0x2507760", VA = "0x182508B60", Slot = "42")]
	[AsyncStateMachine(typeof(CLCHHMKGDGO))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA?>>? NNHDFJMNCHD(ENBGACDEBPI<KANNHDBHICO> CHKKMPEGFNO, ENBGACDEBPI<KANNHDBHICO> EGMIMDCOMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2505550", Offset = "0x2504150", VA = "0x182505550", Slot = "43")]
	[AsyncStateMachine(typeof(JLLCCJKMINO))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA?>>? DNJNEIFDPAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2507620", Offset = "0x2506220", VA = "0x182507620", Slot = "44")]
	[AsyncStateMachine(typeof(PDNINBLLJDE))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> JPJPDLAIMOI(string BKCFGJBABFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2505360", Offset = "0x2503F60", VA = "0x182505360", Slot = "45")]
	[AsyncStateMachine(typeof(HGPIGAJIHHO))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> DHFDNJCNGME(ENBGACDEBPI<NKPIAFBIEBF> BHGEFCDONFK, string BGKKCEGMOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2509300", Offset = "0x2507F00", VA = "0x182509300", Slot = "46")]
	[AsyncStateMachine(typeof(ENEJKBOMFHB))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> OLGEEGOANNN(ENBGACDEBPI<KANNHDBHICO> CHKKMPEGFNO, string BGKKCEGMOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x25066F0", Offset = "0x25052F0", VA = "0x1825066F0", Slot = "47")]
	[AsyncStateMachine(typeof(GCCEPDBHLGK))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> IAPAGODEJCA(ENBGACDEBPI<NKPIAFBIEBF> BHGEFCDONFK, OFHLJOHAOPH ADFFEBFOCBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x2506390", Offset = "0x2504F90", VA = "0x182506390", Slot = "48")]
	[AsyncStateMachine(typeof(FMINPGNMDKK))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> GIAHCFHDKIN(ENBGACDEBPI<KANNHDBHICO> CHKKMPEGFNO, OFHLJOHAOPH ADFFEBFOCBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2504B10", Offset = "0x2503710", VA = "0x182504B10")]
	internal void CBMANOMEOPN(ENBGACDEBPI<IEOKEELCLHA> MPDLOLIOGJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public sealed class DADMLIBEGLD : BFFHCAJILDC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public interface BIPNEMHDEGD
	{
		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public readonly struct NOMCKPMBHEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public readonly IReadOnlyDictionary<LFHLJBHJLKP<DGPIFHHHHCH>, Guid>? MKCBKBKKOGD;

			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0xBDB470", Offset = "0xBDA070", VA = "0x180BDB470")]
			public NOMCKPMBHEF(IReadOnlyDictionary<LFHLJBHJLKP<DGPIFHHHHCH>, Guid>? MKCBKBKKOGD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		PDBAPHICGIJ MHCBOIGOBOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<POJLNBCFFCA> OMEKNPBNPIG(CancellationToken NAOIMKEDKEJ);

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<PGMIGGEMMKL> CKDLNFNIMOJ(CancellationToken NAOIMKEDKEJ);

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<KPGCKGMEOEP> DBKCPCPNNFK(CancellationToken NAOIMKEDKEJ);

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<NOMCKPMBHEF> LCJOMFJCBEI(CancellationToken NAOIMKEDKEJ);

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<EKNMIFCEOAA> ELHFMHIGNNJ(CancellationToken NAOIMKEDKEJ);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct GOBEKKCEEPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public AsyncTaskMethodBuilder<DADMLIBEGLD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public FAMECBPCILE circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public POJLNBCFFCA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public PGMIGGEMMKL superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private BIPNEMHDEGD <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private POJLNBCFFCA <downloadedRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private POJLNBCFFCA <actualRoomData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private EKNMIFCEOAA <actualStaticConfig>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private PGMIGGEMMKL <finalSuperRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private KPGCKGMEOEP <playerSaveData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private TaskAwaiter<POJLNBCFFCA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private POJLNBCFFCA <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<EKNMIFCEOAA> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<PGMIGGEMMKL> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<KPGCKGMEOEP> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private TaskAwaiter<BIPNEMHDEGD.NOMCKPMBHEF> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private TaskAwaiter<DELENLBBKCB> <>u__6;

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x250F910", Offset = "0x250E510", VA = "0x18250F910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x25107C0", Offset = "0x250F3C0", VA = "0x1825107C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private readonly DELENLBBKCB FPBAGJIBFCM;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public DELENLBBKCB BKMAEFICBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	private DADMLIBEGLD(DELENLBBKCB NPBJEAEPANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x250BB80", Offset = "0x250A780", VA = "0x18250BB80")]
	[AsyncStateMachine(typeof(GOBEKKCEEPB))]
	public static Task<DADMLIBEGLD> HMALLHBANCC(FAMECBPCILE JKPOOJNKKFK, POJLNBCFFCA? FDFFMDBCAPG, PGMIGGEMMKL? MAGHCEFJIPG, CancellationToken NAOIMKEDKEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x250BB60", Offset = "0x250A760", VA = "0x18250BB60", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public readonly struct BCDBLHFOEPC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct MOCKHFLJCKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<object, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public BCDBLHFOEPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public JCKDHEKPOIA action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<PNJEPLMEKHI<object, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x2517AF0", Offset = "0x25166F0", VA = "0x182517AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x2517D80", Offset = "0x2516980", VA = "0x182517D80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct BKOCBONKMFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<bool, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public KHCNLKFLBAB rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public POJLNBCFFCA circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public PGMIGGEMMKL superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public BCDBLHFOEPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private JCKDHEKPOIA[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private TaskAwaiter<PNJEPLMEKHI<object, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x250A530", Offset = "0x2509130", VA = "0x18250A530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x250A910", Offset = "0x2509510", VA = "0x18250A910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct BDNKPGCADJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public BCDBLHFOEPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private TaskAwaiter<PNJEPLMEKHI<object, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x250A040", Offset = "0x2508C40", VA = "0x18250A040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x250A280", Offset = "0x2508E80", VA = "0x18250A280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private readonly EBONHPPPMND HKOEBKBNDDP;

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0xBDB470", Offset = "0xBDA070", VA = "0x180BDB470")]
	public BCDBLHFOEPC(EBONHPPPMND LHEPEPAJBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x2509F10", Offset = "0x2508B10", VA = "0x182509F10")]
	[AsyncStateMachine(typeof(MOCKHFLJCKH))]
	private Task<PNJEPLMEKHI<object, GEJJJMKDLKA>> NFJBIGODKBH(JCKDHEKPOIA OAGMINHECCA, bool HECHFLLKKPC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x2509CC0", Offset = "0x25088C0", VA = "0x182509CC0")]
	[AsyncStateMachine(typeof(BKOCBONKMFJ))]
	public Task<PNJEPLMEKHI<bool, GEJJJMKDLKA?>>? ANIDNPFAOLJ(int KOFLHFCAHKH, KHCNLKFLBAB? BDMCKILHPML, POJLNBCFFCA? PKGBNKHOGNB, PGMIGGEMMKL? MAGHCEFJIPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x2509E20", Offset = "0x2508A20", VA = "0x182509E20")]
	[AsyncStateMachine(typeof(BDNKPGCADJK))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> LOIALHEPEBI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public sealed class HNFDCLOJMFA : FFLMAEEJCDD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly COBEKGMADLH PLFDEPFKBJO;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public COBEKGMADLH ALDNDLAIPOB
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	private HNFDCLOJMFA(COBEKGMADLH LJGEFMIHDOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x2512FE0", Offset = "0x2511BE0", VA = "0x182512FE0")]
	public static HNFDCLOJMFA KOHMJABOPGF(FAMECBPCILE JKPOOJNKKFK, KHCNLKFLBAB BLBGBHAGDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x2512FC0", Offset = "0x2511BC0", VA = "0x182512FC0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public interface BKLFMJCJHKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	DELENLBBKCB BKMAEFICBFD
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	DKLABFLPJCL PPGKBDFKDOP
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	NPGGLANEANB IGOHNHJDIGK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	NGODBPJEIPG PMKNAIKJCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public interface IEFLCGHIFON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	BKLFMJCJHKB? KIGNANOAJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool DFIMOLGJAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	bool FIPLCPLLIFD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<BKLFMJCJHKB?>? PELDAEBIMFI();

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PHDLHFBCKLO(FAMECBPCILE JKPOOJNKKFK, KHCNLKFLBAB BLBGBHAGDIN, POJLNBCFFCA? HFCNDBLKEMI, PGMIGGEMMKL? FDOBECGAACK);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[OMFHMOMEMHL("IStaticCV2Instance")]
public interface BFFHCAJILDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	DELENLBBKCB BKMAEFICBFD
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[OMFHMOMEMHL("IStaticEVInstance")]
public interface FFLMAEEJCDD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	COBEKGMADLH ALDNDLAIPOB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class FBAGCKPNIDH
{
	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x250CFA0", Offset = "0x250BBA0", VA = "0x18250CFA0")]
	public static HLKPIDMGNGP<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE, PPMIOCPEKCK.INGEHKDCKHO<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE>> PCGBHOLHCFI([In] this HLKPIDMGNGP<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE, PPMIOCPEKCK.INGEHKDCKHO<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE>> BCPJELKOPLA)
	{
		return default(HLKPIDMGNGP<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE, PPMIOCPEKCK.INGEHKDCKHO<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class BIAJHOHJBIG : AEEDCGAAPOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private readonly FAMECBPCILE PEFFIDGBCHC;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool FIPLCPLLIFD
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x250A4B0", Offset = "0x25090B0", VA = "0x18250A4B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	internal BIAJHOHJBIG(FAMECBPCILE JKPOOJNKKFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal sealed class FHJNFCIOFGM : FAEGGAOPDAM
{
	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x250DC00", Offset = "0x250C800", VA = "0x18250DC00", Slot = "4")]
	public AEOEDAJHIIG? GNGLLNIFBJI(string? MODFNHOHCHN, string? BNGKPMKOCEH, string? GGGENGLIAAB, NIAMKDBHCGN.DLPEMKKKAKH.ADPDILODGAD OLNCCJAIELJ, bool JNIDMKMOMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	public FHJNFCIOFGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class GNPAOPFFEGL : KNKBDNIEGJI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct KFKDGIOCEKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public AsyncTaskMethodBuilder<OHBPKAHMOIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public GNPAOPFFEGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter<BKLFMJCJHKB?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x2516530", Offset = "0x2515130", VA = "0x182516530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x25167D0", Offset = "0x25153D0", VA = "0x1825167D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private readonly FAMECBPCILE PEFFIDGBCHC;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public OHBPKAHMOIH? FFLNCJPMHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x250F5C0", Offset = "0x250E1C0", VA = "0x18250F5C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public NGODBPJEIPG? KAMGEGGCHBM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x250F020", Offset = "0x250DC20", VA = "0x18250F020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool KIBACLBCABI
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x250EC50", Offset = "0x250D850", VA = "0x18250EC50", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool BAHHBMOPFHA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x250F240", Offset = "0x250DE40", VA = "0x18250F240", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x250F730", Offset = "0x250E330", VA = "0x18250F730")]
	internal GNPAOPFFEGL(FAMECBPCILE JKPOOJNKKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x250F640", Offset = "0x250E240", VA = "0x18250F640", Slot = "7")]
	[AsyncStateMachine(typeof(KFKDGIOCEKA))]
	public Task<OHBPKAHMOIH> OKEINDANDIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x250ECB0", Offset = "0x250D8B0", VA = "0x18250ECB0", Slot = "9")]
	public IReadOnlyDictionary<LFHLJBHJLKP<DGPIFHHHHCH>, Guid> BPNKFFJMCDP(IEnumerable<IJKLPCMEAKO> CHIIPNHDMJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x250F2A0", Offset = "0x250DEA0", VA = "0x18250F2A0", Slot = "10")]
	public NCAAAPNFBEM GHBHDAOAHIP(IEnumerable<IJKLPCMEAKO> CHIIPNHDMJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x250F0A0", Offset = "0x250DCA0", VA = "0x18250F0A0")]
	public PNJEPLMEKHI<LAILBCBKHFH, PKJJHJMDMCJ> DDCPHAJLDFH([In] LAILBCBKHFH JBCBKNHJOPC)
	{
		return default(PNJEPLMEKHI<LAILBCBKHFH, PKJJHJMDMCJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x250F420", Offset = "0x250E020", VA = "0x18250F420", Slot = "8")]
	private PNJEPLMEKHI<LAILBCBKHFH, PKJJHJMDMCJ> GMPKKFHPMMM([In] LAILBCBKHFH JBCBKNHJOPC)
	{
		return default(PNJEPLMEKHI<LAILBCBKHFH, PKJJHJMDMCJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class NGODBPJEIPG : OHBPKAHMOIH
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	internal static class GPPCFDLIENK
	{
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class LIHHMJOGAGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000299")]
			public DELENLBBKCB state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400029A")]
			public MKDBBOIDICN spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600051D")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public LIHHMJOGAGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x2524A70", Offset = "0x2523670", VA = "0x182524A70")]
			internal bool DIKOAKDLDNL(JECOFFIBOIC n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class KCHLDMCAOBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public KCHLDMCAOBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x2524870", Offset = "0x2523470", VA = "0x182524870")]
			internal void LGIPFOPENHB(JECOFFIBOIC n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x2510890", Offset = "0x250F490", VA = "0x182510890")]
		public static PNJEPLMEKHI<OHBPKAHMOIH.OHAGMFDCMEF, LEALKEHEBGH> BDNCCGGPJGH(NGODBPJEIPG DKGDAEBOJKO, [In] OHBPKAHMOIH.LLOCJJKNKPO IGPONJDPFGI)
		{
			return default(PNJEPLMEKHI<OHBPKAHMOIH.OHAGMFDCMEF, LEALKEHEBGH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x2511370", Offset = "0x250FF70", VA = "0x182511370")]
		internal static PNJEPLMEKHI<(DMCPODDELKN, PJGIOMOJKDJ), LEALKEHEBGH> MNEMGGLHJKP(NGODBPJEIPG DKGDAEBOJKO, PJGIOMOJKDJ KEAFKPJFJBO, bool MMHHGCPEPKO, [In] LFHLJBHJLKP<DGPIFHHHHCH> GKILPDBCBDI, [In] int? CCLLCELINGD, [In] OJLANLIGMEM? MHMEBIBPOLL, [In] OJLANLIGMEM? CDHHCBLDMFH)
		{
			return default(PNJEPLMEKHI<(DMCPODDELKN, PJGIOMOJKDJ), LEALKEHEBGH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2510DD0", Offset = "0x250F9D0", VA = "0x182510DD0")]
		private static void EBNHPCCAHJG(bool MMHHGCPEPKO, IJKLPCMEAKO AIINMDJLKBF, DMCPODDELKN PFIJNLDMPNL, [In] LFHLJBHJLKP<DGPIFHHHHCH> GKILPDBCBDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x25121E0", Offset = "0x2510DE0", VA = "0x1825121E0")]
		public static void ODIHNOHGDKM(KDJKOMDCFOO HMJOBPLGHIP, [In] OHBPKAHMOIH.JJMIFEADLCK FHGBCCOPHIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x2511280", Offset = "0x250FE80", VA = "0x182511280")]
		[CompilerGenerated]
		internal static bool LDKPONDIFML(DELENLBBKCB LMPLLJKPEJB, MKDBBOIDICN MNDHJKNGING, JECOFFIBOIC OIAMEPOCGLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x2511250", Offset = "0x250FE50", VA = "0x182511250")]
		[CompilerGenerated]
		internal static bool ENNNAFOBFJE(JECOFFIBOIC HDBPBMNJNAE)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct DIIHEGLOJPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public NGODBPJEIPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public ENBGACDEBPI<DGPIFHHHHCH> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public ENBGACDEBPI<CALHCHFEDII> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public DNFPMKILKNL offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public bool deleteBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x2523240", Offset = "0x2521E40", VA = "0x182523240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x2523490", Offset = "0x2522090", VA = "0x182523490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct EKBKBOPDCPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public NGODBPJEIPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public ENBGACDEBPI<DGPIFHHHHCH> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public LFHLJBHJLKP<CALHCHFEDII> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public List<ENBGACDEBPI<CALHCHFEDII>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public DNFPMKILKNL localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public ONBJGGOKCEK localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public DNFPMKILKNL offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x2523AE0", Offset = "0x25226E0", VA = "0x182523AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x2523DA0", Offset = "0x25229A0", VA = "0x182523DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct ONHKBBKJLFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public NGODBPJEIPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public ENBGACDEBPI<DGPIFHHHHCH> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public LFHLJBHJLKP<CALHCHFEDII> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public List<ENBGACDEBPI<CALHCHFEDII>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x2526C00", Offset = "0x2525800", VA = "0x182526C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x2526E40", Offset = "0x2525A40", VA = "0x182526E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct HHDHMEFKBGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public NGODBPJEIPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public ENBGACDEBPI<DGPIFHHHHCH> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public LFHLJBHJLKP<CALHCHFEDII> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public ENBGACDEBPI<DGPIFHHHHCH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public List<ENBGACDEBPI<CALHCHFEDII>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x2524310", Offset = "0x2522F10", VA = "0x182524310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x2524550", Offset = "0x2523150", VA = "0x182524550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct LNIACGHFOKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public NGODBPJEIPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public LFHLJBHJLKP<DGPIFHHHHCH> legacyGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public LFHLJBHJLKP<CALHCHFEDII> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public IReadOnlyList<LFHLJBHJLKP<CALHCHFEDII>> nodeLegacyIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public IReadOnlyDictionary<HENAEMNINOA, (ENBGACDEBPI<IEOKEELCLHA>, ENBGACDEBPI<GBFFCGKIBLH>)> inputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public IReadOnlyDictionary<EJBEEAFAOGP, (ENBGACDEBPI<IEOKEELCLHA>, ENBGACDEBPI<JCNFOBNEGFN>)> outputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x2524A90", Offset = "0x2523690", VA = "0x182524A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x25250D0", Offset = "0x2523CD0", VA = "0x1825250D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct CPPFKPHMPFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public NGODBPJEIPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public ENBGACDEBPI<DGPIFHHHHCH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public ENBGACDEBPI<BEIDLONMPPN> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public ENBGACDEBPI<NKOHBHOJOIJ> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x2522B80", Offset = "0x2521780", VA = "0x182522B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x25231D0", Offset = "0x2521DD0", VA = "0x1825231D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct GNFCIGGDODF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public NGODBPJEIPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public LFHLJBHJLKP<CALHCHFEDII> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public LFHLJBHJLKP<DGPIFHHHHCH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public ENBGACDEBPI<IEOKEELCLHA> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public ENBGACDEBPI<GBFFCGKIBLH> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2523F60", Offset = "0x2522B60", VA = "0x182523F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x25242A0", Offset = "0x2522EA0", VA = "0x1825242A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct AIKMMNFCCJE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public NGODBPJEIPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public LFHLJBHJLKP<CALHCHFEDII> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public LFHLJBHJLKP<DGPIFHHHHCH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public ENBGACDEBPI<IEOKEELCLHA> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public ENBGACDEBPI<JCNFOBNEGFN> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x2521380", Offset = "0x251FF80", VA = "0x182521380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x25216C0", Offset = "0x25202C0", VA = "0x1825216C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct BKCNPLACHFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public NGODBPJEIPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x2522430", Offset = "0x2521030", VA = "0x182522430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x2522650", Offset = "0x2521250", VA = "0x182522650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private readonly FAMECBPCILE PEFFIDGBCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private readonly BFFHCAJILDC LKNEOBMBGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private readonly FFLMAEEJCDD BKIEDLKJNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private readonly OIFFEODOPDD OMJGMGFKLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private readonly GNPAOPFFEGL FKIMADCDEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private Dictionary<LFHLJBHJLKP<CALHCHFEDII>, PJCAPLMNIMG> FEKLLLPAAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	[CompilerGenerated]
	private Action<LFHLJBHJLKP<CALHCHFEDII>>? AHPHFCDHMGA;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public LFHLJBHJLKP<DGPIFHHHHCH> ILPFLELNGDG
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x2519480", Offset = "0x2518080", VA = "0x182519480", Slot = "4")]
		get
		{
			return default(LFHLJBHJLKP<DGPIFHHHHCH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public OIFFEODOPDD NEPGLPJDJPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x24F7DD0", Offset = "0x24F69D0", VA = "0x1824F7DD0", Slot = "5")]
		get
		{
			return default(OIFFEODOPDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x251EBE0", Offset = "0x251D7E0", VA = "0x18251EBE0")]
	public NGODBPJEIPG(FAMECBPCILE JKPOOJNKKFK, BFFHCAJILDC HCIBFGNDAHP, FFLMAEEJCDD LHMPGJGABPJ, GNPAOPFFEGL FKLOBKAIMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x251B870", Offset = "0x251A470", VA = "0x18251B870", Slot = "65")]
	public ENBGACDEBPI<NAOPKJNGDJB> HGJGMAMLMHO(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO)
	{
		return default(ENBGACDEBPI<NAOPKJNGDJB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x251E250", Offset = "0x251CE50", VA = "0x18251E250", Slot = "66")]
	public ENBGACDEBPI<AHANBBHMAKL> NPONDLEJKJE(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<BEIDLONMPPN> GDGENKFJMLI)
	{
		return default(ENBGACDEBPI<AHANBBHMAKL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x2517E50", Offset = "0x2516A50", VA = "0x182517E50", Slot = "6")]
	public (bool, bool) AAICODPKOJO(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<BEIDLONMPPN> HLINBFIEHON, ENBGACDEBPI<NKOHBHOJOIJ> CJOPNCBBOIK)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x2519150", Offset = "0x2517D50", VA = "0x182519150")]
	public bool BIJJOKNAOML(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, [In] EFPFAEGPELE IGNPBBPJCJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x251CC60", Offset = "0x251B860", VA = "0x18251CC60", Slot = "8")]
	public bool JGLDBLOICOA(NIONFIGLCKL KCMNPBLDMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x251DE50", Offset = "0x251CA50", VA = "0x18251DE50", Slot = "9")]
	public bool LNKHIAHOFJB(OADLLJHELHI DDACJNJHBOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x251DD80", Offset = "0x251C980", VA = "0x18251DD80", Slot = "10")]
	public BFBFNPLOCIF? LCPGLNCKKBC(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2518A10", Offset = "0x2517610", VA = "0x182518A10", Slot = "11")]
	public ABGKOJMCNGI? ADCFODGMJEB(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<BEIDLONMPPN> GDGENKFJMLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x251B110", Offset = "0x2519D10", VA = "0x18251B110", Slot = "12")]
	public ENBGACDEBPI<BEIDLONMPPN>? FHOLNOEPGFG(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<CALHCHFEDII> HNIBCCHLOFE, ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, ENBGACDEBPI<JCNFOBNEGFN> LIILEGNGJIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x251DB10", Offset = "0x251C710", VA = "0x18251DB10", Slot = "13")]
	public ENBGACDEBPI<NKOHBHOJOIJ>? KLEEGLFJKFF(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<CALHCHFEDII> HNIBCCHLOFE, ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, ENBGACDEBPI<GBFFCGKIBLH> KLJFFOHNJFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x251DF50", Offset = "0x251CB50", VA = "0x18251DF50", Slot = "14")]
	public IEnumerable<ENBGACDEBPI<DGPIFHHHHCH>> MJABHCJDPAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x251E1A0", Offset = "0x251CDA0", VA = "0x18251E1A0", Slot = "15")]
	public IEnumerable<ENBGACDEBPI<CHLFCAFHMPN>> NMJGJCPBCLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x2518C10", Offset = "0x2517810", VA = "0x182518C10", Slot = "16")]
	public string AODLOPNIEGE(ENBGACDEBPI<CHLFCAFHMPN> BDFJOHFNHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x251BD20", Offset = "0x251A920", VA = "0x18251BD20", Slot = "17")]
	public string IKLIEEDJCII(ENBGACDEBPI<CHLFCAFHMPN> BDFJOHFNHDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x251D910", Offset = "0x251C510", VA = "0x18251D910")]
	public PJCAPLMNIMG? KKGHLELKBNH([In] LFHLJBHJLKP<CALHCHFEDII> HNIBCCHLOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x251B470", Offset = "0x251A070", VA = "0x18251B470", Slot = "23")]
	public ENBGACDEBPI<FBBBJKCECFN> GGMBNPKNPNI(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<CALHCHFEDII> HNIBCCHLOFE)
	{
		return default(ENBGACDEBPI<FBBBJKCECFN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x251C940", Offset = "0x251B540", VA = "0x18251C940")]
	public ENBGACDEBPI<CALHCHFEDII> JAHHJLCANDO(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, [In] LFHLJBHJLKP<CALHCHFEDII> OKMGFKBPLEK)
	{
		return default(ENBGACDEBPI<CALHCHFEDII>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x251A310", Offset = "0x2518F10", VA = "0x18251A310", Slot = "33")]
	public ENBGACDEBPI<CALHCHFEDII> EICFLICHFCF(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO)
	{
		return default(ENBGACDEBPI<CALHCHFEDII>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x251DED0", Offset = "0x251CAD0", VA = "0x18251DED0", Slot = "34")]
	public ENBGACDEBPI<CALHCHFEDII> MENBGHIALGE(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<BEIDLONMPPN> GDGENKFJMLI)
	{
		return default(ENBGACDEBPI<CALHCHFEDII>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x25190D0", Offset = "0x2517CD0", VA = "0x1825190D0")]
	public ENBGACDEBPI<CALHCHFEDII>? BGNIGMKLKPI(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, [In] LFHLJBHJLKP<CALHCHFEDII> OKMGFKBPLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x251C9C0", Offset = "0x251B5C0", VA = "0x18251C9C0", Slot = "25")]
	public CHKJFJGHLBL? JEGLANFFMOG(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x251B790", Offset = "0x251A390", VA = "0x18251B790", Slot = "26")]
	public long GJOOMOMLKBA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x251BEE0", Offset = "0x251AAE0", VA = "0x18251BEE0")]
	private void IMCADFBAEFH(LFHLJBHJLKP<CALHCHFEDII> HNIBCCHLOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2519BA0", Offset = "0x25187A0", VA = "0x182519BA0", Slot = "31")]
	public IEnumerable<(ENBGACDEBPI<DGPIFHHHHCH>, ENBGACDEBPI<CALHCHFEDII>)> CNNIDINIMLB(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x251DA80", Offset = "0x251C680", VA = "0x18251DA80", Slot = "32")]
	public ENBGACDEBPI<NKOHBHOJOIJ> KLEEGLFJKFF(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<CALHCHFEDII> HNIBCCHLOFE, ENBGACDEBPI<NAOPKJNGDJB> KLJFFOHNJFC)
	{
		return default(ENBGACDEBPI<NKOHBHOJOIJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x251B1A0", Offset = "0x2519DA0", VA = "0x18251B1A0", Slot = "35")]
	public ENBGACDEBPI<BEIDLONMPPN> FHOLNOEPGFG(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<CALHCHFEDII> HNIBCCHLOFE, ENBGACDEBPI<AHANBBHMAKL> LIILEGNGJIN)
	{
		return default(ENBGACDEBPI<BEIDLONMPPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x251D7F0", Offset = "0x251C3F0", VA = "0x18251D7F0")]
	private PJCAPLMNIMG? KDHOLJELJFH([In] LFHLJBHJLKP<CALHCHFEDII> HNIBCCHLOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2518B50", Offset = "0x2517750", VA = "0x182518B50")]
	public LJNEMHENPLP? AJAIBJJKHNA([In] LFHLJBHJLKP<CALHCHFEDII> HNIBCCHLOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2518BE0", Offset = "0x25177E0", VA = "0x182518BE0")]
	public PFLINFPPFJG? MGBGHFIGAIO([In] LFHLJBHJLKP<DGPIFHHHHCH> OJOHECDAGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x251DBA0", Offset = "0x251C7A0", VA = "0x18251DBA0", Slot = "27")]
	public IEnumerable<ELCNFHDIEHF> KMABMEHEBOP(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x251DC60", Offset = "0x251C860", VA = "0x18251DC60", Slot = "28")]
	public bool KNGMLLHJDOE(ENBGACDEBPI<CHLFCAFHMPN> BDFJOHFNHDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x2519FC0", Offset = "0x2518BC0", VA = "0x182519FC0", Slot = "29")]
	public IEnumerable<EFPFAEGPELE> DMONIPDHFJN(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<BEIDLONMPPN> HLINBFIEHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x251BAA0", Offset = "0x251A6A0", VA = "0x18251BAA0", Slot = "30")]
	public IEnumerable<EFPFAEGPELE> HMPGAOHNIJO(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<NKOHBHOJOIJ> CJOPNCBBOIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x251A6C0", Offset = "0x25192C0", VA = "0x18251A6C0")]
	public ENBGACDEBPI<DGPIFHHHHCH> FAFDKCAAPPK([In] LFHLJBHJLKP<DGPIFHHHHCH> OJOHECDAGPC)
	{
		return default(ENBGACDEBPI<DGPIFHHHHCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2518AD0", Offset = "0x25176D0", VA = "0x182518AD0")]
	public ENBGACDEBPI<DGPIFHHHHCH>? DHMIALJAPBC([In] LFHLJBHJLKP<DGPIFHHHHCH> OJOHECDAGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x251A250", Offset = "0x2518E50", VA = "0x18251A250")]
	private MKDBBOIDICN? EBMPMOFBBLA([In] LFHLJBHJLKP<DGPIFHHHHCH> OJOHECDAGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x2518BE0", Offset = "0x25177E0", VA = "0x182518BE0")]
	private PFLINFPPFJG? ALKBGMFNKDG([In] LFHLJBHJLKP<DGPIFHHHHCH> OJOHECDAGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x251E330", Offset = "0x251CF30", VA = "0x18251E330", Slot = "21")]
	public ENBGACDEBPI<DGPIFHHHHCH>? OLOGBLAHCAE(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<CALHCHFEDII> HNIBCCHLOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x251E460", Offset = "0x251D060", VA = "0x18251E460", Slot = "39")]
	public LFHLJBHJLKP<DGPIFHHHHCH> OMBMAOEABEK(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC)
	{
		return default(LFHLJBHJLKP<DGPIFHHHHCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x251A540", Offset = "0x2519140", VA = "0x18251A540", Slot = "36")]
	public IEnumerable<OFHLJOHAOPH> ELLNNHGIIBH(BFFJBEALPMP LPBJGDEGIIP, bool KMNNKGGBHCE, bool GAINGCPFLBA, bool ABDHAONNCLN, bool LGKDHMFKEMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2519C50", Offset = "0x2518850", VA = "0x182519C50", Slot = "37")]
	public OFHLJOHAOPH CPAJBGECBBB(BFFJBEALPMP LPBJGDEGIIP, GJPMPHEFBOE PEOOCFNLAOA, bool KMNNKGGBHCE, bool GAINGCPFLBA, bool ABDHAONNCLN, bool LGKDHMFKEMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x251CAF0", Offset = "0x251B6F0", VA = "0x18251CAF0")]
	public ELCNFHDIEHF JFPBJICEDOC(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, [In] EFPFAEGPELE IGNPBBPJCJJ)
	{
		return default(ELCNFHDIEHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x251E640", Offset = "0x251D240", VA = "0x18251E640", Slot = "40")]
	public EFPFAEGPELE PFMIDKPCMGN(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<BEIDLONMPPN> HLINBFIEHON, ENBGACDEBPI<NKOHBHOJOIJ> CJOPNCBBOIK)
	{
		return default(EFPFAEGPELE);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x251BD90", Offset = "0x251A990", VA = "0x18251BD90", Slot = "41")]
	[AsyncStateMachine(typeof(DIIHEGLOJPG))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> ILOFHJNBEFM(ENBGACDEBPI<DGPIFHHHHCH> HACCPIPJKED, ENBGACDEBPI<CALHCHFEDII> JAJDEJICBLH, DNFPMKILKNL KKHFKGIPICC, bool LNPDOJAPDMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x251B610", Offset = "0x251A210", VA = "0x18251B610", Slot = "42")]
	[AsyncStateMachine(typeof(EKBKBOPDCPD))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> GILDLCMMMDG(ENBGACDEBPI<DGPIFHHHHCH> HACCPIPJKED, LFHLJBHJLKP<CALHCHFEDII> JAJDEJICBLH, List<ENBGACDEBPI<CALHCHFEDII>> JLFFLLJFFON, DNFPMKILKNL EKKBACKEBDI, ONBJGGOKCEK IAPDHJPLJOC, DNFPMKILKNL KKHFKGIPICC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x251E870", Offset = "0x251D470", VA = "0x18251E870", Slot = "45")]
	[AsyncStateMachine(typeof(ONHKBBKJLFP))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> PJNBGMMHFLO(ENBGACDEBPI<DGPIFHHHHCH> HACCPIPJKED, LFHLJBHJLKP<CALHCHFEDII> JAJDEJICBLH, List<ENBGACDEBPI<CALHCHFEDII>> JLFFLLJFFON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x251CCE0", Offset = "0x251B8E0", VA = "0x18251CCE0", Slot = "46")]
	[AsyncStateMachine(typeof(HHDHMEFKBGH))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> JHGCIELGHJE(ENBGACDEBPI<DGPIFHHHHCH> HACCPIPJKED, LFHLJBHJLKP<CALHCHFEDII> JAJDEJICBLH, ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, List<ENBGACDEBPI<CALHCHFEDII>> JLFFLLJFFON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2519640", Offset = "0x2518240", VA = "0x182519640", Slot = "43")]
	public (IReadOnlyDictionary<HENAEMNINOA, (ENBGACDEBPI<IEOKEELCLHA>, ENBGACDEBPI<GBFFCGKIBLH>)>, IReadOnlyDictionary<EJBEEAFAOGP, (ENBGACDEBPI<IEOKEELCLHA>, ENBGACDEBPI<JCNFOBNEGFN>)>) CHHCPENPHCO(LFHLJBHJLKP<DGPIFHHHHCH> JCPGFLONBML, ENBGACDEBPI<CALHCHFEDII> JAJDEJICBLH)
	{
		return default((IReadOnlyDictionary<HENAEMNINOA, (ENBGACDEBPI<IEOKEELCLHA>, ENBGACDEBPI<GBFFCGKIBLH>)>, IReadOnlyDictionary<EJBEEAFAOGP, (ENBGACDEBPI<IEOKEELCLHA>, ENBGACDEBPI<JCNFOBNEGFN>)>));
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x251E050", Offset = "0x251CC50", VA = "0x18251E050", Slot = "44")]
	[AsyncStateMachine(typeof(LNIACGHFOKK))]
	public Task NMGPGPLKEGK(LFHLJBHJLKP<DGPIFHHHHCH> JCPGFLONBML, LFHLJBHJLKP<CALHCHFEDII> JAJDEJICBLH, IReadOnlyList<LFHLJBHJLKP<CALHCHFEDII>> JBFLBPNGJCH, IReadOnlyDictionary<HENAEMNINOA, (ENBGACDEBPI<IEOKEELCLHA>, ENBGACDEBPI<GBFFCGKIBLH>)> JKCHFBFBFKI, IReadOnlyDictionary<EJBEEAFAOGP, (ENBGACDEBPI<IEOKEELCLHA>, ENBGACDEBPI<JCNFOBNEGFN>)> CCIHHKANGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x251B800", Offset = "0x251A400", VA = "0x18251B800", Slot = "47")]
	public bool GPGMCKIDGNA(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x251E4D0", Offset = "0x251D0D0", VA = "0x18251E4D0", Slot = "48")]
	public bool OOPOBKCBCPA(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x251A640", Offset = "0x2519240", VA = "0x18251A640", Slot = "49")]
	public bool EMHLNMKCDLM(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<BEIDLONMPPN> GDGENKFJMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x25197B0", Offset = "0x25183B0", VA = "0x1825197B0")]
	public PNJEPLMEKHI<OHBPKAHMOIH.OHAGMFDCMEF, LEALKEHEBGH> CHPHCBJHLHL([In] OHBPKAHMOIH.LLOCJJKNKPO IGPONJDPFGI)
	{
		return default(PNJEPLMEKHI<OHBPKAHMOIH.OHAGMFDCMEF, LEALKEHEBGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x251EAB0", Offset = "0x251D6B0", VA = "0x18251EAB0", Slot = "51")]
	[AsyncStateMachine(typeof(CPPFKPHMPFB))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> PMFDBFOHDEP(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<BEIDLONMPPN> HLINBFIEHON, ENBGACDEBPI<NKOHBHOJOIJ> CJOPNCBBOIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x25197E0", Offset = "0x25183E0", VA = "0x1825197E0", Slot = "52")]
	public PNJEPLMEKHI<NAHIANKHBFJ, PKJJHJMDMCJ> CJHPLGBKDBH(LFHLJBHJLKP<DGPIFHHHHCH> OJOHECDAGPC, NAHIANKHBFJ OMIFDIGAFAM, ONBJGGOKCEK EFLMPGOCNAB)
	{
		return default(PNJEPLMEKHI<NAHIANKHBFJ, PKJJHJMDMCJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x25194E0", Offset = "0x25180E0", VA = "0x1825194E0", Slot = "53")]
	[AsyncStateMachine(typeof(GNFCIGGDODF))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> CHDLLGEDONB(LFHLJBHJLKP<DGPIFHHHHCH> OJOHECDAGPC, LFHLJBHJLKP<CALHCHFEDII> IEGJPHONADG, ENBGACDEBPI<IEOKEELCLHA> DOIADADCHKE, ENBGACDEBPI<GBFFCGKIBLH> CKEOHJKPLCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2518F70", Offset = "0x2517B70", VA = "0x182518F70", Slot = "54")]
	[AsyncStateMachine(typeof(AIKMMNFCCJE))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> BCLICBAGOPG(LFHLJBHJLKP<DGPIFHHHHCH> OJOHECDAGPC, LFHLJBHJLKP<CALHCHFEDII> PAMGKPIOIFL, ENBGACDEBPI<IEOKEELCLHA> PDIEDPDIIBN, ENBGACDEBPI<JCNFOBNEGFN> GDGENKFJMLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x251B4F0", Offset = "0x251A0F0", VA = "0x18251B4F0", Slot = "55")]
	public MDDELKCCLHH GGNDHNKLMNG()
	{
		return default(MDDELKCCLHH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x251D350", Offset = "0x251BF50", VA = "0x18251D350", Slot = "56")]
	public MDDELKCCLHH KBBBJAPLKFD()
	{
		return default(MDDELKCCLHH);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x251B2A0", Offset = "0x2519EA0", VA = "0x18251B2A0", Slot = "58")]
	public DFENOMPLCEJ GCKOOJIPHKL(KAPFOGFENJP CLNNLNNPLFM, ENBGACDEBPI<DGPIFHHHHCH> NFHEPCKJDMF, IEnumerable<LFHLJBHJLKP<DGPIFHHHHCH>> NADHJHONEDI, IEnumerable<LFHLJBHJLKP<CALHCHFEDII>> JLFFLLJFFON)
	{
		return default(DFENOMPLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x251A390", Offset = "0x2518F90", VA = "0x18251A390")]
	private DFENOMPLCEJ EJOAHDDHLDA(KAPFOGFENJP CLNNLNNPLFM, ENBGACDEBPI<DGPIFHHHHCH> NFHEPCKJDMF, IEnumerable<LFHLJBHJLKP<DGPIFHHHHCH>> NADHJHONEDI, IEnumerable<LFHLJBHJLKP<CALHCHFEDII>> JLFFLLJFFON)
	{
		return default(DFENOMPLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x2518C80", Offset = "0x2517880", VA = "0x182518C80", Slot = "57")]
	public DFENOMPLCEJ APIOAMCLPIB(KAPFOGFENJP CLNNLNNPLFM, ENBGACDEBPI<DGPIFHHHHCH> NFHEPCKJDMF, IEnumerable<LFHLJBHJLKP<CALHCHFEDII>> JLFFLLJFFON, IEnumerable<IJKLPCMEAKO> IIKONCIHAIC)
	{
		return default(DFENOMPLCEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x251D470", Offset = "0x251C070", VA = "0x18251D470")]
	private static IEnumerable<LFHLJBHJLKP<DGPIFHHHHCH>> KDEIIGCKAPC(IEnumerable<IJKLPCMEAKO> IIKONCIHAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x251CE40", Offset = "0x251BA40", VA = "0x18251CE40")]
	private IEnumerable<LFHLJBHJLKP<CALHCHFEDII>> JKCKABBKAJJ(IEnumerable<IJKLPCMEAKO> IIKONCIHAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x251DCF0", Offset = "0x251C8F0", VA = "0x18251DCF0", Slot = "59")]
	public List<HNPHHMKLMBO> KNOBFMJGMOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2518350", Offset = "0x2516F50", VA = "0x182518350")]
	public (List<HNPHHMKLMBO>, bool) AAKGNEAEJJJ([In] FJEMFGOMGHK FNBMJBALBNL, string HJIAOGEIAJO, [In] KLGOFGIBFIA DEOOIOMAFFF, IPNNIDKJJBE HEDPLMAMAGJ, NNAHCNHKMIJ OMJLOFNDPCB)
	{
		return default((List<HNPHHMKLMBO>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x251E9C0", Offset = "0x251D5C0", VA = "0x18251E9C0", Slot = "61")]
	public bool PKDEKKAHPML(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x251B8F0", Offset = "0x251A4F0", VA = "0x18251B8F0")]
	internal void HIKGBEPEGPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x251E2D0", Offset = "0x251CED0", VA = "0x18251E2D0")]
	internal Task OLGDOELKAEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x251BF70", Offset = "0x251AB70", VA = "0x18251BF70", Slot = "62")]
	public PNJEPLMEKHI<ENBGACDEBPI<BEIDLONMPPN>?, GEJJJMKDLKA> IPKADAPFPNI(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<CALHCHFEDII> HNIBCCHLOFE, ENBGACDEBPI<NKOHBHOJOIJ> CKEOHJKPLCO)
	{
		return default(PNJEPLMEKHI<ENBGACDEBPI<BEIDLONMPPN>?, GEJJJMKDLKA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x251A740", Offset = "0x2519340", VA = "0x18251A740", Slot = "63")]
	public PNJEPLMEKHI<ENBGACDEBPI<NKOHBHOJOIJ>?, GEJJJMKDLKA> FALLDKJHEGA(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, ENBGACDEBPI<CALHCHFEDII> HNIBCCHLOFE, ENBGACDEBPI<BEIDLONMPPN> GDGENKFJMLI)
	{
		return default(PNJEPLMEKHI<ENBGACDEBPI<NKOHBHOJOIJ>?, GEJJJMKDLKA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x251E550", Offset = "0x251D150", VA = "0x18251E550", Slot = "64")]
	[AsyncStateMachine(typeof(BKCNPLACHFI))]
	public Task<PNJEPLMEKHI<BODKGJBCKHC, GEJJJMKDLKA>> OPPCIOCBOBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x251DE40", Offset = "0x251CA40", VA = "0x18251DE40", Slot = "7")]
	private bool LLOBAFDDBOC(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, [In] EFPFAEGPELE IGNPBBPJCJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x2518BE0", Offset = "0x25177E0", VA = "0x182518BE0", Slot = "18")]
	private PFLINFPPFJG FENHMBPMNCE([In] LFHLJBHJLKP<DGPIFHHHHCH> OJOHECDAGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x251B7F0", Offset = "0x251A3F0", VA = "0x18251B7F0", Slot = "19")]
	private ENBGACDEBPI<DGPIFHHHHCH> GONFNIMDAJP([In] LFHLJBHJLKP<DGPIFHHHHCH> OJOHECDAGPC)
	{
		return default(ENBGACDEBPI<DGPIFHHHHCH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2518AD0", Offset = "0x25176D0", VA = "0x182518AD0", Slot = "20")]
	private ENBGACDEBPI<DGPIFHHHHCH>? AIEEGNOEHDH([In] LFHLJBHJLKP<DGPIFHHHHCH> OJOHECDAGPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x251B950", Offset = "0x251A550", VA = "0x18251B950", Slot = "22")]
	private PJCAPLMNIMG HJPAEHPCIEM([In] LFHLJBHJLKP<CALHCHFEDII> HNIBCCHLOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x251C940", Offset = "0x251B540", VA = "0x18251C940", Slot = "24")]
	private ENBGACDEBPI<CALHCHFEDII> OHFNFKOGNCB(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, [In] LFHLJBHJLKP<CALHCHFEDII> OKMGFKBPLEK)
	{
		return default(ENBGACDEBPI<CALHCHFEDII>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x251CAF0", Offset = "0x251B6F0", VA = "0x18251CAF0", Slot = "38")]
	private ELCNFHDIEHF PPNDJMBEJNP(ENBGACDEBPI<DGPIFHHHHCH> OJOHECDAGPC, [In] EFPFAEGPELE IGNPBBPJCJJ)
	{
		return default(ELCNFHDIEHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x25197B0", Offset = "0x25183B0", VA = "0x1825197B0", Slot = "50")]
	private PNJEPLMEKHI<OHBPKAHMOIH.OHAGMFDCMEF, LEALKEHEBGH> CKDFHBEEHAN([In] OHBPKAHMOIH.LLOCJJKNKPO IGPONJDPFGI)
	{
		return default(PNJEPLMEKHI<OHBPKAHMOIH.OHAGMFDCMEF, LEALKEHEBGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2518F10", Offset = "0x2517B10", VA = "0x182518F10", Slot = "60")]
	private (List<HNPHHMKLMBO>, bool) APKMNJPNDJD([In] FJEMFGOMGHK FNBMJBALBNL, string HJIAOGEIAJO, [In] KLGOFGIBFIA DEOOIOMAFFF, IPNNIDKJJBE HEDPLMAMAGJ, NNAHCNHKMIJ OMJLOFNDPCB)
	{
		return default((List<HNPHHMKLMBO>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x251D2D0", Offset = "0x251BED0", VA = "0x18251D2D0")]
	[CompilerGenerated]
	private CIODLCABELF KAEFGDOMJEE(NOLLBBDMJJO GFMJIHODIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x2519F50", Offset = "0x2518B50", VA = "0x182519F50")]
	[CompilerGenerated]
	private LJNEMHENPLP DIACEHBIBLN(LFHLJBHJLKP<CALHCHFEDII> GFMJIHODIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x251DFE0", Offset = "0x251CBE0", VA = "0x18251DFE0")]
	[CompilerGenerated]
	private MKDBBOIDICN MPFFIMCMIIG(LFHLJBHJLKP<DGPIFHHHHCH> GFMJIHODIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x251B230", Offset = "0x2519E30", VA = "0x18251B230")]
	[CompilerGenerated]
	private LJNEMHENPLP FJEOCCMHEPB(LFHLJBHJLKP<CALHCHFEDII> GFMJIHODIPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x251D8A0", Offset = "0x251C4A0", VA = "0x18251D8A0")]
	[CompilerGenerated]
	private MKDBBOIDICN KEDGPGGCFKC(LFHLJBHJLKP<DGPIFHHHHCH> GFMJIHODIPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class CIODLCABELF : OFHLJOHAOPH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct DLALOHNKKCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<ENBGACDEBPI<NKPIAFBIEBF>, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public CIODLCABELF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public LFHLJBHJLKP<DGPIFHHHHCH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public LFHLJBHJLKP<CALHCHFEDII> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public ENBGACDEBPI<IEOKEELCLHA> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private TaskAwaiter<PNJEPLMEKHI<ENBGACDEBPI<NKPIAFBIEBF>, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x2523500", Offset = "0x2522100", VA = "0x182523500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x2523780", Offset = "0x2522380", VA = "0x182523780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct EKAOCIJOBNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<ENBGACDEBPI<KANNHDBHICO>, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public CIODLCABELF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public LFHLJBHJLKP<DGPIFHHHHCH> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public LFHLJBHJLKP<CALHCHFEDII> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public ENBGACDEBPI<IEOKEELCLHA> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private TaskAwaiter<PNJEPLMEKHI<ENBGACDEBPI<KANNHDBHICO>, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x25237F0", Offset = "0x25223F0", VA = "0x1825237F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x2523A70", Offset = "0x2522670", VA = "0x182523A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private readonly NOLLBBDMJJO JCJBIOIBHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private readonly BFFHCAJILDC LKNEOBMBGIJ;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public TypeKey OPIHFMICKND
	{
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0xA90E00", Offset = "0xA8FA00", VA = "0x180A90E00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public string EPEKMHGDGGH
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x25227D0", Offset = "0x25213D0", VA = "0x1825227D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public NOLLBBDMJJO EONCMHBFCIA
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2522AE0", Offset = "0x25216E0", VA = "0x182522AE0")]
	public CIODLCABELF(NOLLBBDMJJO KLOHCIMGLCI, BFFHCAJILDC HCIBFGNDAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x2522800", Offset = "0x2521400", VA = "0x182522800", Slot = "6")]
	[AsyncStateMachine(typeof(DLALOHNKKCF))]
	public Task<PNJEPLMEKHI<ENBGACDEBPI<NKPIAFBIEBF>, GEJJJMKDLKA>> INJJCGAMKOI(LFHLJBHJLKP<DGPIFHHHHCH> OJOHECDAGPC, LFHLJBHJLKP<CALHCHFEDII> HNIBCCHLOFE, ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, string BGKKCEGMOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x2522970", Offset = "0x2521570", VA = "0x182522970", Slot = "7")]
	[AsyncStateMachine(typeof(EKAOCIJOBNM))]
	public Task<PNJEPLMEKHI<ENBGACDEBPI<KANNHDBHICO>, GEJJJMKDLKA>> PFELPBBOHHP(LFHLJBHJLKP<DGPIFHHHHCH> OJOHECDAGPC, LFHLJBHJLKP<CALHCHFEDII> HNIBCCHLOFE, ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE, string BGKKCEGMOKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class NNBODIKACMF : EBDFOIFILCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private readonly NOLLBBDMJJO KKNEOBDIJPA;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private static readonly HashSet<NOLLBBDMJJO> DONAPBDCNMH;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private static readonly HashSet<NOLLBBDMJJO> IJGPGKHJNJM;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private static readonly HashSet<NOLLBBDMJJO> GAMEANIBCFD;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public TypeKey JFPNHMHDAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2526A90", Offset = "0x2525690", VA = "0x182526A90", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool FAFBBECIKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2526A80", Offset = "0x2525680", VA = "0x182526A80", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool DCNJOGOBPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x2526AE0", Offset = "0x25256E0", VA = "0x182526AE0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool EMJDGFOHNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x2526A00", Offset = "0x2525600", VA = "0x182526A00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2525430", Offset = "0x2524030", VA = "0x182525430")]
	public bool BBJMAAOBHIC(string MPDLOLIOGJL, [Out] GPKJCGAEABM GDNFLJELDGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	public NNBODIKACMF(NOLLBBDMJJO FOBBPKHANPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x25256A0", Offset = "0x25242A0", VA = "0x1825256A0")]
	internal static TypeKey MLNAJOPIMAO(NOLLBBDMJJO ADFFEBFOCBD)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x25227D0", Offset = "0x25213D0", VA = "0x1825227D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public readonly struct FFELLMHEGAL : CCLOFBBKKLB.HMFLNPMMBHB<JCKDHEKPOIA, BODKGJBCKHC>
{
	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x2523EB0", Offset = "0x2522AB0", VA = "0x182523EB0", Slot = "4")]
	public int IJGOECDICEF(BODKGJBCKHC LOJMCGAMMAK, JCKDHEKPOIA OAGMINHECCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2523E70", Offset = "0x2522A70", VA = "0x182523E70", Slot = "5")]
	public JCKDHEKPOIA ENHMENIGJDI(BODKGJBCKHC LOJMCGAMMAK, JCKDHEKPOIA OAGMINHECCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x2523F10", Offset = "0x2522B10", VA = "0x182523F10", Slot = "6")]
	public JCKDHEKPOIA OGEEDEIGACF(BODKGJBCKHC LOJMCGAMMAK, JCKDHEKPOIA OAGMINHECCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x2523E50", Offset = "0x2522A50", VA = "0x182523E50", Slot = "7")]
	public IReadOnlyList<JCKDHEKPOIA> CIIBNENFMJM(BODKGJBCKHC LOJMCGAMMAK, JCKDHEKPOIA OAGMINHECCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x2523E80", Offset = "0x2522A80", VA = "0x182523E80", Slot = "8")]
	public JCKDHEKPOIA[] GHOHABIEJDC(BODKGJBCKHC LOJMCGAMMAK, JCKDHEKPOIA OAGMINHECCA, int OOPCBFMOOEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2523E30", Offset = "0x2522A30", VA = "0x182523E30", Slot = "9")]
	public bool CCBJHOMCCMD(BODKGJBCKHC LOJMCGAMMAK, JCKDHEKPOIA OAGMINHECCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2523EF0", Offset = "0x2522AF0", VA = "0x182523EF0", Slot = "10")]
	public bool NGKDMKBHDIM(BODKGJBCKHC LOJMCGAMMAK, JCKDHEKPOIA OAGMINHECCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x2523ED0", Offset = "0x2522AD0", VA = "0x182523ED0", Slot = "11")]
	public bool IMGEKPKKHDJ(BODKGJBCKHC LOJMCGAMMAK, JCKDHEKPOIA OAGMINHECCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x2523E90", Offset = "0x2522A90", VA = "0x182523E90", Slot = "12")]
	public bool GOOJDNGELNA(BODKGJBCKHC LOJMCGAMMAK, JCKDHEKPOIA OAGMINHECCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2523E10", Offset = "0x2522A10", VA = "0x182523E10", Slot = "13")]
	public bool BKOIPLLADNC(BODKGJBCKHC DLFCNPDKING, JCKDHEKPOIA OAGMINHECCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x2523F40", Offset = "0x2522B40", VA = "0x182523F40", Slot = "14")]
	public bool OGKCEJLJKHM(BODKGJBCKHC LOJMCGAMMAK, JCKDHEKPOIA OAGMINHECCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public abstract class NCCFLBHFMLC : JJOBOHLBIDN
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public OHGCALJMIBE.HJKHHLLJCMB DCLKGPLGIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x25253E0", Offset = "0x2523FE0", VA = "0x1825253E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract FLDCIAOHJGA.GILFJLNDKHL FJPGNANBPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract FAMECBPCILE.LIBMCMEJNKP JFKAMACEHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract DADMLIBEGLD.BIPNEMHDEGD JAMIBHHKGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public PPMIOCPEKCK.INGEHKDCKHO<BCOHPOMJGNP, JCKDHEKPOIA, FAMECBPCILE> GFJHJODOOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x2525390", Offset = "0x2523F90", VA = "0x182525390", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract POOPHPOENFE.OOKJCIKIFAI CAHKCKLIAMK
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract MBINOHCLPKN LEEIKBEEILJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract PIMLOOPHOFJ FHANKAIJPFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract DDJFMMCPKIO KADLNKIDEDN
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public abstract IDFHECOJNDK NKPDNIEMBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public abstract AGKNGCJHOEN BKGAPIAAPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
	protected NCCFLBHFMLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class LOBNICFBGPG : IFOIJJNFHMN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private struct PKNODIBEOJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<object, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public LOBNICFBGPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public JCKDHEKPOIA action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private TaskAwaiter<PNJEPLMEKHI<object, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2527160", Offset = "0x2525D60", VA = "0x182527160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2527400", Offset = "0x2526000", VA = "0x182527400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct BJINHKHBGPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder<PNJEPLMEKHI<BDEHFKIJKJD, GEJJJMKDLKA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public LOBNICFBGPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public IReadOnlyList<JCKDHEKPOIA> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter<PNJEPLMEKHI<object, GEJJJMKDLKA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x2522040", Offset = "0x2520C40", VA = "0x182522040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x25223C0", Offset = "0x2520FC0", VA = "0x1825223C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private readonly EBONHPPPMND HKOEBKBNDDP;

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	public LOBNICFBGPG(EBONHPPPMND LHEPEPAJBFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x2525130", Offset = "0x2523D30", VA = "0x182525130")]
	[AsyncStateMachine(typeof(PKNODIBEOJJ))]
	private Task<PNJEPLMEKHI<object, GEJJJMKDLKA>> NFJBIGODKBH(JCKDHEKPOIA OAGMINHECCA, bool HECHFLLKKPC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x2525260", Offset = "0x2523E60", VA = "0x182525260", Slot = "4")]
	[AsyncStateMachine(typeof(BJINHKHBGPE))]
	public Task<PNJEPLMEKHI<BDEHFKIJKJD, GEJJJMKDLKA>> NKFJFCIMOLM(IReadOnlyList<JCKDHEKPOIA> KMELAGHIBII, bool HECHFLLKKPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public struct JCBAGCFGJIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	internal LHFPJNNGEAB<MDNIFNNFLMC, LFHLJBHJLKP<MDNIFNNFLMC.BCEIIGFEKCN>, JCKDHEKPOIA, IJAOBDLKHKF> KKNEOBDIJPA;

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x24FDEB0", Offset = "0x24FCAB0", VA = "0x1824FDEB0")]
	private JCBAGCFGJIB([In] LHFPJNNGEAB<MDNIFNNFLMC, LFHLJBHJLKP<MDNIFNNFLMC.BCEIIGFEKCN>, JCKDHEKPOIA, IJAOBDLKHKF> IIFJFNAHEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x2524810", Offset = "0x2523410", VA = "0x182524810")]
	public static JCBAGCFGJIB JPHABLICNHB()
	{
		return default(JCBAGCFGJIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public static class JPOPGDHNBCL
{
	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static LHFPJNNGEAB<MDNIFNNFLMC, LFHLJBHJLKP<MDNIFNNFLMC.BCEIIGFEKCN>, JCKDHEKPOIA, IJAOBDLKHKF> KHOGGPCAJLK(this JCBAGCFGJIB DKGDAEBOJKO)
	{
		return default(LHFPJNNGEAB<MDNIFNNFLMC, LFHLJBHJLKP<MDNIFNNFLMC.BCEIIGFEKCN>, JCKDHEKPOIA, IJAOBDLKHKF>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct IJAOBDLKHKF : FPMBHMHGPLM.PCMEJEFLEAD<MDNIFNNFLMC, LFHLJBHJLKP<MDNIFNNFLMC.BCEIIGFEKCN>, JCKDHEKPOIA>
{
	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x2524620", Offset = "0x2523220", VA = "0x182524620", Slot = "7")]
	public JCKDHEKPOIA BJIAJNGDFCM(MDNIFNNFLMC[] CGCHHAGOMMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x1093C70", Offset = "0x1092870", VA = "0x181093C70")]
	public LFHLJBHJLKP<MDNIFNNFLMC.BCEIIGFEKCN> GCJGMAADACK([In] MDNIFNNFLMC DEHKJKCLMJL)
	{
		return default(LFHLJBHJLKP<MDNIFNNFLMC.BCEIIGFEKCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0xEED040", Offset = "0xEEBC40", VA = "0x180EED040")]
	public int NJHCAOAABOI([In] MDNIFNNFLMC OFBAKBPDANK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x2524800", Offset = "0x2523400", VA = "0x182524800")]
	public int MAGPJKEHBKB([In] MDNIFNNFLMC DEHKJKCLMJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0xEED040", Offset = "0xEEBC40", VA = "0x180EED040", Slot = "4")]
	private int HHLIABFAHCE([In] MDNIFNNFLMC DEHKJKCLMJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x2524800", Offset = "0x2523400", VA = "0x182524800", Slot = "5")]
	private int HCNDEOFFIOL([In] MDNIFNNFLMC DEHKJKCLMJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x1093C70", Offset = "0x1092870", VA = "0x181093C70", Slot = "6")]
	private LFHLJBHJLKP<MDNIFNNFLMC.BCEIIGFEKCN> JBFKMDENJLG([In] MDNIFNNFLMC DEHKJKCLMJL)
	{
		return default(LFHLJBHJLKP<MDNIFNNFLMC.BCEIIGFEKCN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public struct ICOPDIIIHOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	internal FDCKFAKAFJO<EMBPPNGFJBE, JCKDHEKPOIA, KHEIHPBCDFG> KKNEOBDIJPA;

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x24FDEB0", Offset = "0x24FCAB0", VA = "0x1824FDEB0")]
	private ICOPDIIIHOM([In] FDCKFAKAFJO<EMBPPNGFJBE, JCKDHEKPOIA, KHEIHPBCDFG> BGJLOLNGDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x25245C0", Offset = "0x25231C0", VA = "0x1825245C0")]
	public static ICOPDIIIHOM JPHABLICNHB()
	{
		return default(ICOPDIIIHOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class ANMIHMDIABF
{
	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0xB17D80", Offset = "0xB16980", VA = "0x180B17D80")]
	public static FDCKFAKAFJO<EMBPPNGFJBE, JCKDHEKPOIA, KHEIHPBCDFG> KHOGGPCAJLK(this ICOPDIIIHOM DKGDAEBOJKO)
	{
		return default(FDCKFAKAFJO<EMBPPNGFJBE, JCKDHEKPOIA, KHEIHPBCDFG>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public struct KHEIHPBCDFG : FAMOFOFFPLI.CIKKDBIIHDP<EMBPPNGFJBE, JCKDHEKPOIA>
{
	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x1EE94C0", Offset = "0x1EE80C0", VA = "0x181EE94C0")]
	public int KNCNCIDABJG([In] EMBPPNGFJBE OFBAKBPDANK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x2524890", Offset = "0x2523490", VA = "0x182524890", Slot = "5")]
	public JCKDHEKPOIA PHHLKIHLMEJ(EMBPPNGFJBE[] FECBGLIKLHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x1EE94C0", Offset = "0x1EE80C0", VA = "0x181EE94C0", Slot = "4")]
	private int APNLDGHOION([In] EMBPPNGFJBE OFBAKBPDANK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class PBGEBANDBBD : KLJHHNJNNDG, LEALKEHEBGH, GEJJJMKDLKA, PKJJHJMDMCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private readonly PKJJHJMDMCJ? PGGODHBHMHE;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public GNOFONIOCEK NMBGIIICMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x95B870", Offset = "0x95A470", VA = "0x18095B870", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(GNOFONIOCEK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x95B860", Offset = "0x95A460", VA = "0x18095B860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public override PKJJHJMDMCJ? ACBMIEHDCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x2526EB0", Offset = "0x2525AB0", VA = "0x182526EB0", Slot = "7")]
	public override string CNPDCBKGCII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x2527120", Offset = "0x2525D20", VA = "0x182527120")]
	private PBGEBANDBBD(GNOFONIOCEK KMMNOOJNABL, PKJJHJMDMCJ? HJBKCNKGFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x2527030", Offset = "0x2525C30", VA = "0x182527030")]
	public static PBGEBANDBBD KECEGGNHCKP(PKJJHJMDMCJ HJBKCNKGFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x2526FC0", Offset = "0x2525BC0", VA = "0x182526FC0")]
	public static PBGEBANDBBD FCOCMHLKAAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x25270B0", Offset = "0x2525CB0", VA = "0x1825270B0")]
	public static PBGEBANDBBD MGNPJKCIDLM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public static class IBFOLKGOOBG
{
	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x33AFE10", Offset = "0x33AEA10", VA = "0x1833AFE10")]
	public static PNJEPLMEKHI<TOk, LEALKEHEBGH> JEDLGANBKJC<TOk>([In] this PNJEPLMEKHI<TOk, LEALKEHEBGH> DKGDAEBOJKO, PKJJHJMDMCJ HJBKCNKGFFM) where TOk : notnull
	{
		return default(PNJEPLMEKHI<TOk, LEALKEHEBGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x33AFC20", Offset = "0x33AE820", VA = "0x1833AFC20")]
	public static PNJEPLMEKHI<TOk?, LEALKEHEBGH?> IMMNLBKEMLM<TOk>([In] this PNJEPLMEKHI<TOk, LEALKEHEBGH> DKGDAEBOJKO)
	{
		return default(PNJEPLMEKHI<TOk, LEALKEHEBGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x33AFD10", Offset = "0x33AE910", VA = "0x1833AFD10")]
	public static PNJEPLMEKHI<TOk?, LEALKEHEBGH?> JBMMDPKDIGK<TOk>([In] this PNJEPLMEKHI<TOk, LEALKEHEBGH> DKGDAEBOJKO)
	{
		return default(PNJEPLMEKHI<TOk, LEALKEHEBGH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public interface MBINOHCLPKN
{
	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KCKNGLDPAED([In] PNJEPLMEKHI<BODKGJBCKHC, PKJJHJMDMCJ> HBANOBDOKBJ);
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public static class FDKLDKEEHDM
{
	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x3351210", Offset = "0x334FE10", VA = "0x183351210")]
	public static bool KCKNGLDPAED<TOk, TErr>(this MBINOHCLPKN DKGDAEBOJKO, [In] PNJEPLMEKHI<TOk, TErr> HBANOBDOKBJ) where TOk : notnull where TErr : notnull, PKJJHJMDMCJ
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public interface PIMLOOPHOFJ
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	JLOMMENDEJL GEFPHFEGBHM
	{
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public interface DDJFMMCPKIO
{
	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DLLKDAPGHJF PNIGDLKAHML(int PCPKKEMBCIC);
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public interface GKAODMJLEPK
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string NMFKAOGOELC
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public interface HOFIBJIFKEO
{
	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GHLNJJLDEMB? KGLAEFENHED(ENBGACDEBPI<IEOKEELCLHA> DCEGDKKPCJE);
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface GEFBIODLFHL
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	string NMFKAOGOELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface GHLNJJLDEMB
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	string NMFKAOGOELC
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GEFBIODLFHL? HLOBEMBAGAH(ENBGACDEBPI<NKPIAFBIEBF> BHGEFCDONFK);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GKAODMJLEPK? ILNJEHBEIPN(ENBGACDEBPI<KANNHDBHICO> CHKKMPEGFNO);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface IDFHECOJNDK
{
	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> IEPBOGLHIGP(string MPDLOLIOGJL, string HJIAOGEIAJO);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface AGKNGCJHOEN
{
	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOFIBJIFKEO? JIJOCMEGBMI([In] LFHLJBHJLKP<DKFBPKOALCJ> EIBMNHGOJCE);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class ANBLPFKBALF
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private struct CGCDCLCBGBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int AHDPANGFLKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public POJLNBCFFCA? NDBEFOIHBFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public POJLNBCFFCA? ANCHLHPOMJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public readonly List<JCKDHEKPOIA> ADHFFIHONNO;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x2522780", Offset = "0x2521380", VA = "0x182522780")]
		private CGCDCLCBGBC(int BIEEMEKMINN, POJLNBCFFCA? EEADKHIKLJC, POJLNBCFFCA? CFIIFFLAEBM, List<JCKDHEKPOIA> KMELAGHIBII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x25226C0", Offset = "0x25212C0", VA = "0x1825226C0")]
		public static CGCDCLCBGBC JPHABLICNHB()
		{
			return default(CGCDCLCBGBC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private readonly LAFPKBLCCHA<CGCDCLCBGBC> LLGMDAPOHLG;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public static ANBLPFKBALF FFLNCJPMHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x2521AE0", Offset = "0x25206E0", VA = "0x182521AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public bool PJNAKIACPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xB435D0", Offset = "0xB421D0", VA = "0x180B435D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0xB43A50", Offset = "0xB42650", VA = "0x180B43A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x2521A20", Offset = "0x2520620", VA = "0x182521A20")]
	public void GNHCLJIBEHP(DELENLBBKCB CFIIFFLAEBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x2521730", Offset = "0x2520330", VA = "0x182521730")]
	public void DKLAEPBENBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2521B30", Offset = "0x2520730", VA = "0x182521B30")]
	private static string? PADCELDJCJP([In] CGCDCLCBGBC IHAOEDBPCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x2521F90", Offset = "0x2520B90", VA = "0x182521F90")]
	public ANBLPFKBALF()
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
