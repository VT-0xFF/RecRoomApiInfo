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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2750A00", Offset = "0x274FA00", VA = "0x182750A00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class CHIEBOEDIPK : IDisposable, GLOHIKFGMIK, NEOBJAGGBHJ, EGGNIAAEKHF, HDDOJCEAEAO
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class NJKLPINBMFN : DFKJDGPFAAB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int ENGHGCBIFIG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2750040", Offset = "0x274F040", VA = "0x182750040", Slot = "5")]
		public APPFAIEDIHD PGOGCJDDMOG(OECPBGDCJOF.NPMPHEAFFHF MMCKJCAOGBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void MADKIDGOKCA();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void HMMKECCMIMD();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x272AC70", Offset = "0x2729C70", VA = "0x18272AC70", Slot = "13")]
		public virtual void LKBLLIFPGMA(CHIEBOEDIPK IOIBNPDJCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x274FFC0", Offset = "0x274EFC0", VA = "0x18274FFC0", Slot = "14")]
		public virtual void NEJGNHDJEJE(CHIEBOEDIPK IOIBNPDJCNE, AFPLFKDKJPC BDCLNIJAFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		protected NJKLPINBMFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface DFKJDGPFAAB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int ENGHGCBIFIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		APPFAIEDIHD PGOGCJDDMOG(OECPBGDCJOF.NPMPHEAFFHF MMCKJCAOGBM);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MADKIDGOKCA();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HMMKECCMIMD();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LKBLLIFPGMA(CHIEBOEDIPK IOIBNPDJCNE);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NEJGNHDJEJE(CHIEBOEDIPK IOIBNPDJCNE, AFPLFKDKJPC BDCLNIJAFBF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct JGCLGCLKIEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly HLMEOCKMCND<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK, KIAIHFFPMKB.IIGBIEGDLEB<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK>> PJAGFJDHAKD;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x273DE00", Offset = "0x273CE00", VA = "0x18273DE00")]
		internal JGCLGCLKIEK(HLMEOCKMCND<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK, KIAIHFFPMKB.IIGBIEGDLEB<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK>> HCAMONPFOJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class DIGGGJFDADD : KIAIHFFPMKB.IIGBIEGDLEB<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly DIGGGJFDADD MLIJHBGBMKP;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		private DIGGGJFDADD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAB2BB0", Offset = "0xAB1BB0", VA = "0x180AB2BB0", Slot = "4")]
		public LDKABCCJKHO HJAOCKHLDIB(AFPLFKDKJPC OCACDKEJIIB)
		{
			return default(LDKABCCJKHO);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2739900", Offset = "0x2738900", VA = "0x182739900", Slot = "5")]
		public void LKBLLIFPGMA(CHIEBOEDIPK KNNDNAPJIDP, AFPLFKDKJPC BDCLNIJAFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2739A00", Offset = "0x2738A00", VA = "0x182739A00", Slot = "6")]
		public void NEJGNHDJEJE(CHIEBOEDIPK KNNDNAPJIDP, AFPLFKDKJPC BDCLNIJAFBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct IPPNGOHLOIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public APNBNOIOAEH<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK, KIAIHFFPMKB.IIGBIEGDLEB<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK>> PJAGFJDHAKD;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x273D650", Offset = "0x273C650", VA = "0x18273D650")]
		internal IPPNGOHLOIO(APNBNOIOAEH<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK, KIAIHFFPMKB.IIGBIEGDLEB<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK>> HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x273D600", Offset = "0x273C600", VA = "0x18273D600")]
		public static IPPNGOHLOIO ACADPGMDEBE()
		{
			return default(IPPNGOHLOIO);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct AHIMNGFGGHN : GAIDIFCBGED.ADHEJIAJDIB<AFPLFKDKJPC, CHIEBOEDIPK>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct CEOEOGIEPNJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<HHHCCNLMPJL<object?, DLKBDBKHJCC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public CHIEBOEDIPK receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public AFPLFKDKJPC action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AHIMNGFGGHN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<HHHCCNLMPJL<object?, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2737090", Offset = "0x2736090", VA = "0x182737090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2737270", Offset = "0x2736270", VA = "0x182737270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA8E300", Offset = "0xA8D300", VA = "0x180A8E300", Slot = "4")]
		public EDBALDILLBK<FKBNPBHMLOJ> KMHJCBEOCMD(CHIEBOEDIPK NGKGGMDFKFD)
		{
			return default(EDBALDILLBK<FKBNPBHMLOJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x27356E0", Offset = "0x27346E0", VA = "0x1827356E0", Slot = "5")]
		public void HCNCNCCFCBB(CHIEBOEDIPK NGKGGMDFKFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2735760", Offset = "0x2734760", VA = "0x182735760", Slot = "6")]
		[AsyncStateMachine(typeof(CEOEOGIEPNJ))]
		public Task<HHHCCNLMPJL<object, DLKBDBKHJCC>> LAPMPJGNIMF(CHIEBOEDIPK NGKGGMDFKFD, AFPLFKDKJPC BDCLNIJAFBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2735740", Offset = "0x2734740", VA = "0x182735740", Slot = "7")]
		public AFPLFKDKJPC[] KMEJLNCHILD(CHIEBOEDIPK NGKGGMDFKFD)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DFAAJLBFFNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<bool, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CHIEBOEDIPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<HHHCCNLMPJL<bool, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2739600", Offset = "0x2738600", VA = "0x182739600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2739890", Offset = "0x2738890", VA = "0x182739890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct HEGJKLDILGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CHIEBOEDIPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x273CBC0", Offset = "0x273BBC0", VA = "0x18273CBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x273CDA0", Offset = "0x273BDA0", VA = "0x18273CDA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BAEALDONNCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<object?, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public CHIEBOEDIPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AFPLFKDKJPC action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<HHHCCNLMPJL<object?, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2736230", Offset = "0x2735230", VA = "0x182736230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2736420", Offset = "0x2735420", VA = "0x182736420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EDBALDILLBK<FKBNPBHMLOJ> HKFBINAKIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JGCLGCLKIEK GBABCMIAFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NIFCIBLABOI JLPAFBOFDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly IAKIAMFCMEM JNCKODFOCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B70")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly BJNBAMNJLOJ GLHNOPBCEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B78")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly KPBELAPACCB.CHHNOAJOKBL IHNJBKPOLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BA0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly IKLGHIKNMHD HDKDMHLNCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BA8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly KHOBHPDGOKL BADJNJKHLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BB0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly GIDNBCJFJCB MPPAFDCDKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BB8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly KMNAAACLCJB AKMHFCCAMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private DCJBDNFDKJD DALIELIBHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BD0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private JEHFLBFEOGF OHMLMAGMMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BF0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly NIFCIBLABOI.BOLPADJNBNP MHNDLLOIKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BF8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly EHIAIIKPCDI GLCMCLHCGGM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NIFCIBLABOI HDBCADOKEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2739290", Offset = "0x2738290", VA = "0x182739290")]
		get
		{
			return default(NIFCIBLABOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal DFKJDGPFAAB AMIDMEHBMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2739110", Offset = "0x2738110", VA = "0x182739110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal APPFAIEDIHD EMIMCJJICOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2738820", Offset = "0x2737820", VA = "0x182738820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x27392A0", Offset = "0x27382A0", VA = "0x1827392A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool JBCLPPAPFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2738310", Offset = "0x2737310", VA = "0x182738310")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2738AA0", Offset = "0x2737AA0", VA = "0x182738AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HNPIHBFCBED NAMDOENFKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x27395C0", Offset = "0x27385C0", VA = "0x1827395C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KMOLNCDGBHJ PDIDIKKKGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x27395D0", Offset = "0x27385D0", VA = "0x1827395D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BMLEPPHJDAF GJLCALKKAPO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x27395F0", Offset = "0x27385F0", VA = "0x1827395F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JMMHNPNPOEP IFLJBBGINLE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x27395E0", Offset = "0x27385E0", VA = "0x1827395E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KPBELAPACCB? FDFMMKMOCDC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2738A20", Offset = "0x2737A20", VA = "0x182738A20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private JGHDENAOIDJ? EBCEMPCMDCH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2739160", Offset = "0x2738160", VA = "0x182739160", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27392C0", Offset = "0x27382C0", VA = "0x1827392C0")]
	private CHIEBOEDIPK(BJNBAMNJLOJ JDPKJPILGNF, EDBALDILLBK<FKBNPBHMLOJ> GIBLACJPDHG, [In] JGCLGCLKIEK KLPEKGHDEBP, [In] NIFCIBLABOI HKDJCDHGBFB, [In] IAKIAMFCMEM FHCIFLPLDEN, APPFAIEDIHD KNJOHLFGHFE, [In] KPBELAPACCB.CHHNOAJOKBL ADOMMAMDBOA, NIFCIBLABOI.BOLPADJNBNP ADAPNPGMBLM, EHIAIIKPCDI HHLKFCCMMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2737EC0", Offset = "0x2736EC0", VA = "0x182737EC0")]
	public static CHIEBOEDIPK ACADPGMDEBE(BJNBAMNJLOJ MMCKJCAOGBM, [In] KBNDDPHLMIA AJGFNGAFEMJ, GIJMANECPIC MMONHDMBMMK, [In] DDDPDFIPEGH OHDBECKBNMJ, FDHFEJOOAHB JDDKONKOEHJ, EDBALDILLBK<FKBNPBHMLOJ> GIBLACJPDHG, EDBALDILLBK<GABIPLBFMGD> JKJBFLBDLJB, HNNMKAAPCJH HIEGHANFGIK, HKMNJGAEDIC PMDKCONLANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2738000", Offset = "0x2737000", VA = "0x182738000")]
	public static CHIEBOEDIPK ACADPGMDEBE(BJNBAMNJLOJ JDPKJPILGNF, [In] NIFCIBLABOI HKDJCDHGBFB, [In] IAKIAMFCMEM FHCIFLPLDEN, EDBALDILLBK<FKBNPBHMLOJ> GIBLACJPDHG, EDBALDILLBK<GABIPLBFMGD> JKJBFLBDLJB, HNNMKAAPCJH HIEGHANFGIK, HKMNJGAEDIC PMDKCONLANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2738830", Offset = "0x2737830", VA = "0x182738830", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2738B80", Offset = "0x2737B80", VA = "0x182738B80")]
	[AsyncStateMachine(typeof(DFAAJLBFFNI))]
	public Task<HHHCCNLMPJL<bool, DLKBDBKHJCC>> KHDEBPELNMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2738320", Offset = "0x2737320", VA = "0x182738320")]
	[AsyncStateMachine(typeof(HEGJKLDILGA))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> AMJAJCMLKGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x27385A0", Offset = "0x27375A0", VA = "0x1827385A0")]
	internal void BEGKAIILJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2738AB0", Offset = "0x2737AB0", VA = "0x182738AB0")]
	internal HHIMBEIEIME<AFPLFKDKJPC> FKPDHMBGAGL([In] JGDMKIEKPCF EJAMOEMBOCL)
	{
		return default(HHIMBEIEIME<AFPLFKDKJPC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x27387B0", Offset = "0x27377B0", VA = "0x1827387B0")]
	internal bool BJHCKGNPAKH([In] JGDMKIEKPCF EJAMOEMBOCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2738410", Offset = "0x2737410", VA = "0x182738410")]
	internal HHHCCNLMPJL<AFPLFKDKJPC, DLKBDBKHJCC> AOOMIACHCPK([In] ADPBMIFBBEH IBLAJOEDIDO)
	{
		return default(HHHCCNLMPJL<AFPLFKDKJPC, DLKBDBKHJCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2738B30", Offset = "0x2737B30", VA = "0x182738B30")]
	private void HCNCNCCFCBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2739000", Offset = "0x2738000", VA = "0x182739000")]
	[AsyncStateMachine(typeof(BAEALDONNCH))]
	internal Task<HHHCCNLMPJL<object, DLKBDBKHJCC>> LBGADHPEDIP(AFPLFKDKJPC BDCLNIJAFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2738C70", Offset = "0x2737C70", VA = "0x182738C70")]
	private AFPLFKDKJPC[] KMEJLNCHILD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class JLJAOCJOPCJ<TData> : OGMCLKGLBPG, JDAHMPILPFC, HIKDGBNCNDJ where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly IGLPJBODKFE<ALEKBGLLPHJ>? BONBPAGHGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string LNILHMKIEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly TData HCNIDPKECHH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IGLPJBODKFE<ALEKBGLLPHJ>? CLBHPBMBHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x29C5BF0", Offset = "0x29C4BF0", VA = "0x1829C5BF0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810", Slot = "7")]
	public override string JJNMHFCAPPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4E3FF30", Offset = "0x4E3EF30", VA = "0x184E3FF30")]
	internal JLJAOCJOPCJ([In] IGLPJBODKFE<ALEKBGLLPHJ>? KJALFNDNKJA, EDBALDILLBK<LOPJDFBDKHF>? KMIHNFEFBJG, IOKind? FEFOBFOJDCB, string NAAMEAFIHJI, [In] TData APDBNIMCPID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class GANNHEKKPED
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x273BBF0", Offset = "0x273ABF0", VA = "0x18273BBF0")]
	public static HHHCCNLMPJL<KKPOPBPFNLG, JDAHMPILPFC> ACIALOHGINP([In] this FFPLKGHGHNO<EICJJGJBGOF> OHAPHBCELFN)
	{
		return default(HHHCCNLMPJL<KKPOPBPFNLG, JDAHMPILPFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x385A420", Offset = "0x3859420", VA = "0x18385A420")]
	public static HHHCCNLMPJL<TOk, JDAHMPILPFC> FHPEBMCAKED<TOk>([In] this HHHCCNLMPJL<TOk, JDAHMPILPFC> OCACDKEJIIB, [In] IGLPJBODKFE<ALEKBGLLPHJ>? KJALFNDNKJA, EDBALDILLBK<LOPJDFBDKHF>? KMIHNFEFBJG, IOKind? FEFOBFOJDCB, string NAAMEAFIHJI) where TOk : notnull
	{
		return default(HHHCCNLMPJL<TOk, JDAHMPILPFC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BJNBAMNJLOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GAPFFALNEGD.LKCJFGAECDF MHGBPMPNHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	OECPBGDCJOF.NPMPHEAFFHF FOIDDNFBBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	CHIEBOEDIPK.DFKJDGPFAAB ANJGIFEEJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	GEGFDAOJMBC.FAGIEJAHGME LLGFEMAKEDP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KIAIHFFPMKB.IIGBIEGDLEB<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK> CFLMHIKJCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	JOGINOGJMGE.LHKMMBFACNA KIAKPPMDKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	BODMOEILABD EFLGGEMJMCL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	GEKBNBNBOEG FPJHEICFEAD
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	FPIKGFGEAGP PMAKAKOKOEG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	JHMJKGDAMCI KAELNAOJPFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	KDKCJHJLCDA IIAPDDDOKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IELGBOJBMGC
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x273D280", Offset = "0x273C280", VA = "0x18273D280")]
	public static AFPLFKDKJPC OLEDACGEPAD(this AFPLFKDKJPC OCACDKEJIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x273D1B0", Offset = "0x273C1B0", VA = "0x18273D1B0")]
	public static AFPLFKDKJPC CJKGINPLMMF(this BFFEIOCJBKM OCACDKEJIIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct BFFEIOCJBKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct IDPIHJBMJCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<object?, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public CHIEBOEDIPK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public BFFEIOCJBKM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<HHHCCNLMPJL<object?, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x273CE80", Offset = "0x273BE80", VA = "0x18273CE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x273D140", Offset = "0x273C140", VA = "0x18273D140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly ByteString FPGFCMMHMJG;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xCFF9B0", Offset = "0xCFE9B0", VA = "0x180CFF9B0")]
	private BFFEIOCJBKM(ByteString OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27366B0", Offset = "0x27356B0", VA = "0x1827366B0")]
	public static AFPLFKDKJPC ONABKJHANMG(ByteString OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x27364F0", Offset = "0x27354F0", VA = "0x1827364F0")]
	public static GPFEFANJIIE<LDKABCCJKHO, BFFEIOCJBKM> IGNPFMJNHFE(AFPLFKDKJPC OHDJAINMECK)
	{
		return default(GPFEFANJIIE<LDKABCCJKHO, BFFEIOCJBKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x27365A0", Offset = "0x27355A0", VA = "0x1827365A0")]
	[AsyncStateMachine(typeof(IDPIHJBMJCK))]
	public static Task<HHHCCNLMPJL<object, DLKBDBKHJCC>> LBGADHPEDIP(CHIEBOEDIPK KNNDNAPJIDP, BFFEIOCJBKM OCACDKEJIIB)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct OFKENAMFFNC
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2751060", Offset = "0x2750060", VA = "0x182751060")]
	public static AFPLFKDKJPC ONABKJHANMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2750F70", Offset = "0x274FF70", VA = "0x182750F70")]
	public static GPFEFANJIIE<LDKABCCJKHO, OFKENAMFFNC> IGNPFMJNHFE(AFPLFKDKJPC OHDJAINMECK)
	{
		return default(GPFEFANJIIE<LDKABCCJKHO, OFKENAMFFNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2750FE0", Offset = "0x274FFE0", VA = "0x182750FE0")]
	public static HHHCCNLMPJL<BONGKMFJEJA, CNPJDFNBLHN> KGIFNIAOLDC(CHIEBOEDIPK KNNDNAPJIDP, [In] OFKENAMFFNC OCACDKEJIIB)
	{
		return default(HHHCCNLMPJL<BONGKMFJEJA, CNPJDFNBLHN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct KPOEIHFDJNJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct GDAKCFMLLFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, CNPJDFNBLHN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CHIEBOEDIPK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public KPOEIHFDJNJ self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private HHHCCNLMPJL<BONGKMFJEJA, CNPJDFNBLHN> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x273C460", Offset = "0x273B460", VA = "0x18273C460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x273C7D0", Offset = "0x273B7D0", VA = "0x18273C7D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly AMICEDMCMOM? OINKOPKLOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly DAPEGEJBKHJ? CGAFOMOBNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly HNAGJAILJOF? JMEEIAJHJEB;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2654370", Offset = "0x2653370", VA = "0x182654370")]
	private KPOEIHFDJNJ(AMICEDMCMOM? GPHGBEGKLDA, DAPEGEJBKHJ? DHMHCCKDFEA, HNAGJAILJOF? OFMJDNINMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x274DC60", Offset = "0x274CC60", VA = "0x18274DC60")]
	public static AFPLFKDKJPC? ONABKJHANMG(AMICEDMCMOM? GPHGBEGKLDA, DAPEGEJBKHJ? DHMHCCKDFEA, HNAGJAILJOF? OFMJDNINMGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x274DA10", Offset = "0x274CA10", VA = "0x18274DA10")]
	public static GPFEFANJIIE<LDKABCCJKHO, KPOEIHFDJNJ> IGNPFMJNHFE(AFPLFKDKJPC OHDJAINMECK)
	{
		return default(GPFEFANJIIE<LDKABCCJKHO, KPOEIHFDJNJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x274DB20", Offset = "0x274CB20", VA = "0x18274DB20")]
	[AsyncStateMachine(typeof(GDAKCFMLLFB))]
	public static Task<HHHCCNLMPJL<BONGKMFJEJA, CNPJDFNBLHN>> LBGADHPEDIP(CHIEBOEDIPK KNNDNAPJIDP, KPOEIHFDJNJ OCACDKEJIIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct EGDAACDFPLG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct OKNGBGGHJDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<OCIFKDPAIJK, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public EGDAACDFPLG self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CHIEBOEDIPK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private HHHCCNLMPJL<OCIFKDPAIJK, DLKBDBKHJCC> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private HHHCCNLMPJL<object?, HIKDGBNCNDJ>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private HHHCCNLMPJL<object?, HIKDGBNCNDJ> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private HHHCCNLMPJL<object?, HIKDGBNCNDJ>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter<HHHCCNLMPJL<object?, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x27516E0", Offset = "0x27506E0", VA = "0x1827516E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2751B40", Offset = "0x2750B40", VA = "0x182751B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly IReadOnlyList<AFPLFKDKJPC> AKFHCOIGFOO;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xCFF9B0", Offset = "0xCFE9B0", VA = "0x180CFF9B0")]
	private EGDAACDFPLG(IReadOnlyList<AFPLFKDKJPC> BAHJNLHEKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2739D70", Offset = "0x2738D70", VA = "0x182739D70")]
	public static AFPLFKDKJPC ONABKJHANMG(IReadOnlyList<AFPLFKDKJPC> BAHJNLHEKLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x2739B90", Offset = "0x2738B90", VA = "0x182739B90")]
	public static GPFEFANJIIE<LDKABCCJKHO, EGDAACDFPLG> IGNPFMJNHFE(AFPLFKDKJPC OHDJAINMECK)
	{
		return default(GPFEFANJIIE<LDKABCCJKHO, EGDAACDFPLG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2739C30", Offset = "0x2738C30", VA = "0x182739C30")]
	[AsyncStateMachine(typeof(OKNGBGGHJDA))]
	public static Task<HHHCCNLMPJL<OCIFKDPAIJK, DLKBDBKHJCC>> LBGADHPEDIP(CHIEBOEDIPK KNNDNAPJIDP, EGDAACDFPLG OCACDKEJIIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct ADPBMIFBBEH
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class JDMBOMNCDND
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class ILJIFIOMHOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IGLPJBODKFE<JDMBOMNCDND> actionId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public ILJIFIOMHOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x273D490", Offset = "0x273C490", VA = "0x18273D490")]
		internal AFPLFKDKJPC JPEFMINNPBD(int count, int index, [In] ReadOnlySpan<byte> span)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly IGLPJBODKFE<JDMBOMNCDND> PLGPAOCFKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly int CMIOJAJFIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly int CEBFMOBHAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly byte[] HCNIDPKECHH;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x27356C0", Offset = "0x27346C0", VA = "0x1827356C0")]
	private ADPBMIFBBEH(IGLPJBODKFE<JDMBOMNCDND> FOEHMPIEIAF, int JAALIADHHOC, int OHHMJGCBCKD, byte[] APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x27355B0", Offset = "0x27345B0", VA = "0x1827355B0")]
	public static AFPLFKDKJPC ONABKJHANMG(IGLPJBODKFE<JDMBOMNCDND> FOEHMPIEIAF, int JAALIADHHOC, int OHHMJGCBCKD, ByteString APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x27351B0", Offset = "0x27341B0", VA = "0x1827351B0")]
	public static AFPLFKDKJPC[] AAHOGNABLFF(AFPLFKDKJPC BDCLNIJAFBF, int BIMKIFBAABH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x27352C0", Offset = "0x27342C0", VA = "0x1827352C0")]
	public static GPFEFANJIIE<LDKABCCJKHO, ADPBMIFBBEH> IGNPFMJNHFE(AFPLFKDKJPC OHDJAINMECK)
	{
		return default(GPFEFANJIIE<LDKABCCJKHO, ADPBMIFBBEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2735410", Offset = "0x2734410", VA = "0x182735410")]
	public static HHHCCNLMPJL<AFPLFKDKJPC, DLKBDBKHJCC> KGIFNIAOLDC(CHIEBOEDIPK KNNDNAPJIDP, [In] ADPBMIFBBEH OCACDKEJIIB)
	{
		return default(HHHCCNLMPJL<AFPLFKDKJPC, DLKBDBKHJCC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct JGDMKIEKPCF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct APECAJEJABG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<bool, CNPJDFNBLHN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CHIEBOEDIPK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public JGDMKIEKPCF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private HHHCCNLMPJL<bool, CNPJDFNBLHN> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, CNPJDFNBLHN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2735B80", Offset = "0x2734B80", VA = "0x182735B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x27361C0", Offset = "0x27351C0", VA = "0x1827361C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly int CMIOJAJFIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly int CEBFMOBHAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly byte[] HCNIDPKECHH;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xC161B0", Offset = "0xC151B0", VA = "0x180C161B0")]
	private JGDMKIEKPCF(int JAALIADHHOC, int OHHMJGCBCKD, byte[] APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x273E220", Offset = "0x273D220", VA = "0x18273E220")]
	public static AFPLFKDKJPC ONABKJHANMG(int JAALIADHHOC, int OHHMJGCBCKD, ByteString APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x273DE10", Offset = "0x273CE10", VA = "0x18273DE10")]
	public static AFPLFKDKJPC?[]? CGKCFDJDECO(int BIMKIFBAABH, AMICEDMCMOM? GPHGBEGKLDA, DAPEGEJBKHJ? DHMHCCKDFEA, HNAGJAILJOF? OFMJDNINMGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x273E010", Offset = "0x273D010", VA = "0x18273E010")]
	public static GPFEFANJIIE<LDKABCCJKHO, JGDMKIEKPCF> IGNPFMJNHFE(AFPLFKDKJPC OHDJAINMECK)
	{
		return default(GPFEFANJIIE<LDKABCCJKHO, JGDMKIEKPCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x273E0F0", Offset = "0x273D0F0", VA = "0x18273E0F0")]
	[AsyncStateMachine(typeof(APECAJEJABG))]
	public static Task<HHHCCNLMPJL<bool, CNPJDFNBLHN>> LBGADHPEDIP(CHIEBOEDIPK KNNDNAPJIDP, JGDMKIEKPCF OCACDKEJIIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class IKLGHIKNMHD : HNPIHBFCBED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly CHIEBOEDIPK FBKDHJDLAOI;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public EBJFPMAKINE? MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x273D390", Offset = "0x273C390", VA = "0x18273D390", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	internal IKLGHIKNMHD(CHIEBOEDIPK IOIBNPDJCNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class CHIBFLIIPEI : EBJFPMAKINE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly CHIEBOEDIPK FBKDHJDLAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly MGIDPOIGHNH IHDCNDNFOPP;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9FE5E0", Offset = "0x9FD5E0", VA = "0x1809FE5E0")]
	public CHIBFLIIPEI(CHIEBOEDIPK IOIBNPDJCNE, MGIDPOIGHNH FKPENEKJEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x27378D0", Offset = "0x27368D0", VA = "0x1827378D0", Slot = "4")]
	public HHHCCNLMPJL<KKPOPBPFNLG, JDAHMPILPFC> MOFCIJJPGKB(IGLPJBODKFE<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<IFOKEFFHPOH> MOOIAANOCKP)
	{
		return default(HHHCCNLMPJL<KKPOPBPFNLG, JDAHMPILPFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x27372E0", Offset = "0x27362E0", VA = "0x1827372E0", Slot = "5")]
	public HHHCCNLMPJL<KKPOPBPFNLG, JDAHMPILPFC> DBMJOAFLJGK(IGLPJBODKFE<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<HPDCGGEBOAB> NJKENGKIHNB)
	{
		return default(HHHCCNLMPJL<KKPOPBPFNLG, JDAHMPILPFC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class GAPFFALNEGD : CMLPMCGBMAK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface LKCJFGAECDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<MGIDPOIGHNH> PIMAMFOMPFL(CHIEBOEDIPK IOIBNPDJCNE, DAPEGEJBKHJ? EAACMGNPBJM, HNAGJAILJOF? CLNJANHCMJK, CancellationToken CBJPDIFOEKF);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GAKOAGFLBAB ALMMEBEAPHJ(CHIEBOEDIPK IOIBNPDJCNE, AMICEDMCMOM JAPOHPBPBCE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class ENIHPCOABJO : LKCJFGAECDF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct PGIJPPNJDAB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AsyncTaskMethodBuilder<MGIDPOIGHNH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public CHIEBOEDIPK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public DAPEGEJBKHJ cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public HNAGJAILJOF cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<GEGFDAOJMBC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2752280", Offset = "0x2751280", VA = "0x182752280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2752450", Offset = "0x2751450", VA = "0x182752450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly ENIHPCOABJO MLIJHBGBMKP;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		private ENIHPCOABJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x2739F90", Offset = "0x2738F90", VA = "0x182739F90", Slot = "4")]
		[AsyncStateMachine(typeof(PGIJPPNJDAB))]
		public Task<MGIDPOIGHNH> PIMAMFOMPFL(CHIEBOEDIPK IOIBNPDJCNE, DAPEGEJBKHJ? EAACMGNPBJM, HNAGJAILJOF? CLNJANHCMJK, CancellationToken CBJPDIFOEKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2739F70", Offset = "0x2738F70", VA = "0x182739F70", Slot = "5")]
		public GAKOAGFLBAB ALMMEBEAPHJ(CHIEBOEDIPK IOIBNPDJCNE, AMICEDMCMOM JAPOHPBPBCE)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct NLEAIOPIHFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<GAPFFALNEGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CHIEBOEDIPK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public DAPEGEJBKHJ cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public HNAGJAILJOF cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AMICEDMCMOM evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private LKCJFGAECDF <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<MGIDPOIGHNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2750190", Offset = "0x274F190", VA = "0x182750190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2750690", Offset = "0x274F690", VA = "0x182750690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly MGIDPOIGHNH IHDCNDNFOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GAKOAGFLBAB CANFDJPCDEA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public KPBELAPACCB FDFMMKMOCDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x273C0F0", Offset = "0x273B0F0", VA = "0x18273C0F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public JGHDENAOIDJ PENIDCAANBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x273C140", Offset = "0x273B140", VA = "0x18273C140", Slot = "5")]
		get
		{
			return default(JGHDENAOIDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CHIBFLIIPEI BPCFFGKGPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public GDHPHGOEDFD IKMBEHHBIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xECD3A0", Offset = "0xECC3A0", VA = "0x180ECD3A0")]
	private GAPFFALNEGD(MGIDPOIGHNH FKPENEKJEBL, GAKOAGFLBAB FGCGPJAFJOJ, CHIBFLIIPEI CLIEIKEAAAE, GDHPHGOEDFD HGHKAOGJHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x273C200", Offset = "0x273B200", VA = "0x18273C200")]
	[AsyncStateMachine(typeof(NLEAIOPIHFG))]
	public static Task<GAPFFALNEGD> HADJEECNMFP(CHIEBOEDIPK IOIBNPDJCNE, AMICEDMCMOM JAPOHPBPBCE, DAPEGEJBKHJ? EAACMGNPBJM, HNAGJAILJOF? CLNJANHCMJK, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x273C090", Offset = "0x273B090", VA = "0x18273C090", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class OECPBGDCJOF : APPFAIEDIHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface NPMPHEAFFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CMLPMCGBMAK> GCMGKLANABG(CHIEBOEDIPK IOIBNPDJCNE, AMICEDMCMOM JAPOHPBPBCE, DAPEGEJBKHJ? EAACMGNPBJM, HNAGJAILJOF? CLNJANHCMJK, CancellationToken CBJPDIFOEKF);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KJDBFBBHJLK();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EOGHGCJBPPM();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class BGNCPHKBPDL : NPMPHEAFFHF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct JJCLIBPIAFB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public AsyncTaskMethodBuilder<CMLPMCGBMAK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public CHIEBOEDIPK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public AMICEDMCMOM evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public DAPEGEJBKHJ cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public HNAGJAILJOF cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private TaskAwaiter<GAPFFALNEGD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x27491B0", Offset = "0x27481B0", VA = "0x1827491B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x27494F0", Offset = "0x27484F0", VA = "0x1827494F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2736770", Offset = "0x2735770", VA = "0x182736770", Slot = "4")]
		[AsyncStateMachine(typeof(JJCLIBPIAFB))]
		public Task<CMLPMCGBMAK> GCMGKLANABG(CHIEBOEDIPK IOIBNPDJCNE, AMICEDMCMOM JAPOHPBPBCE, DAPEGEJBKHJ? EAACMGNPBJM, HNAGJAILJOF? CLNJANHCMJK, CancellationToken CBJPDIFOEKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void KJDBFBBHJLK();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void EOGHGCJBPPM();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		protected BGNCPHKBPDL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct OKJOCKDOAJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<CMLPMCGBMAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public OECPBGDCJOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<BONGKMFJEJA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2751470", Offset = "0x2750470", VA = "0x182751470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2751670", Offset = "0x2750670", VA = "0x182751670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct OLDDJOKDEGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public OECPBGDCJOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CHIEBOEDIPK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AMICEDMCMOM evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public DAPEGEJBKHJ cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public HNAGJAILJOF cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<CMLPMCGBMAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2751BB0", Offset = "0x2750BB0", VA = "0x182751BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x27520E0", Offset = "0x27510E0", VA = "0x1827520E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly NPMPHEAFFHF IJFOHHKJJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TaskCompletionSource<BONGKMFJEJA> AEGEBMKLEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly TaskCompletionSource<BONGKMFJEJA> CFLNLCDKPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly CancellationTokenSource FFCCMDNLKAB;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool JBCLPPAPFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA1DF60", Offset = "0xA1CF60", VA = "0x180A1DF60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA1DD80", Offset = "0xA1CD80", VA = "0x180A1DD80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DINPHDIMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xDA8D50", Offset = "0xDA7D50", VA = "0x180DA8D50", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x12F0210", Offset = "0x12EF210", VA = "0x1812F0210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool PEOOKJECCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x19C3FD0", Offset = "0x19C2FD0", VA = "0x1819C3FD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2750C00", Offset = "0x274FC00", VA = "0x182750C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public CMLPMCGBMAK? JDIEGKJMAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2750D70", Offset = "0x274FD70", VA = "0x182750D70", Slot = "7")]
	[AsyncStateMachine(typeof(OKJOCKDOAJK))]
	public Task<CMLPMCGBMAK> NKLADMHDKHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2750E60", Offset = "0x274FE60", VA = "0x182750E60")]
	public OECPBGDCJOF(NPMPHEAFFHF MMCKJCAOGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2750C10", Offset = "0x274FC10", VA = "0x182750C10", Slot = "8")]
	[AsyncStateMachine(typeof(OLDDJOKDEGE))]
	public Task MPEIIHEPKKJ(CHIEBOEDIPK IOIBNPDJCNE, AMICEDMCMOM JAPOHPBPBCE, DAPEGEJBKHJ? EAACMGNPBJM, HNAGJAILJOF? CLNJANHCMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2750A80", Offset = "0x274FA80", VA = "0x182750A80", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class IMGOOIINJBF : NAKDLCJGBIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly GDHPHGOEDFD LGNDCLHNJGL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public IMGOOIINJBF(GDHPHGOEDFD HGHKAOGJHJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal static class NGFJKFKBHDI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class HLOPDMIHOGK<TGraph> : KKGGGAABFLL where TGraph : CJNHJIPJPDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		protected readonly TGraph EHNPMKJFGML;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual GJDJHNDBKOL? EOEGMJDNHBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x17CB8C0", Offset = "0x17CA8C0", VA = "0x1817CB8C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual IGLPJBODKFE<ALEKBGLLPHJ>? OEDCIBJDLKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x17CB8C0", Offset = "0x17CA8C0", VA = "0x1817CB8C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public EDBALDILLBK<BIEIIMCKPHN> CNMEJNNBCFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x4B0A890", Offset = "0x4B09890", VA = "0x184B0A890", Slot = "5")]
			get
			{
				return default(EDBALDILLBK<BIEIIMCKPHN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public EDBALDILLBK<BIEIIMCKPHN>? HNOMMBBAEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x4B0A810", Offset = "0x4B09810", VA = "0x184B0A810", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
		public HLOPDMIHOGK(TGraph NOKCJFMDPME)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class KDDBHAPOHKF : HLOPDMIHOGK<GAIABOPOIIE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override GJDJHNDBKOL? EOEGMJDNHBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x274D890", Offset = "0x274C890", VA = "0x18274D890", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override IGLPJBODKFE<ALEKBGLLPHJ>? OEDCIBJDLKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x274D8B0", Offset = "0x274C8B0", VA = "0x18274D8B0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x274D940", Offset = "0x274C940", VA = "0x18274D940")]
		public KDDBHAPOHKF(GAIABOPOIIE PEBJLOHDPEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x274FE30", Offset = "0x274EE30", VA = "0x18274FE30")]
	public static KKGGGAABFLL ACADPGMDEBE(CJNHJIPJPDB NOKCJFMDPME)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class KCILGDEGCLG : GBODGILDCPF, IKPGAMHHELO, HGIFBECBIMN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class GCPGPJCHONA
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
			public GCPGPJCHONA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public BODMOEILABD errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x27529D0", Offset = "0x27519D0", VA = "0x1827529D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2752C40", Offset = "0x2751C40", VA = "0x182752C40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public KCILGDEGCLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public GCPGPJCHONA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x273C370", Offset = "0x273B370", VA = "0x18273C370")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task FEAHGNLDBJJ(BODMOEILABD errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct JFBDCCHHCCP : IAsyncStateMachine
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
		public KCILGDEGCLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x273D660", Offset = "0x273C660", VA = "0x18273D660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x273DB70", Offset = "0x273CB70", VA = "0x18273DB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class MBEHGBAEDMG
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
			public MBEHGBAEDMG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2752CA0", Offset = "0x2751CA0", VA = "0x182752CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2752F80", Offset = "0x2751F80", VA = "0x182752F80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public KCILGDEGCLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public MBEHGBAEDMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x274DD60", Offset = "0x274CD60", VA = "0x18274DD60")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task JOJHCJJDOLO(BODMOEILABD errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class MOFEEDFKMCH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		private struct <<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public MOFEEDFKMCH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x2753500", Offset = "0x2752500", VA = "0x182753500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x27539B0", Offset = "0x27529B0", VA = "0x1827539B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public KCILGDEGCLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public int valueIndex;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public MOFEEDFKMCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x274DE30", Offset = "0x274CE30", VA = "0x18274DE30")]
		[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
		internal Task FOLDBAJCKHL(BODMOEILABD errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class FELLICMMBKB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct <<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public FELLICMMBKB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2752FE0", Offset = "0x2751FE0", VA = "0x182752FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x27534A0", Offset = "0x27524A0", VA = "0x1827534A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public KCILGDEGCLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int valueIndex;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public FELLICMMBKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x273BB20", Offset = "0x273AB20", VA = "0x18273BB20")]
		[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
		internal Task LKLOOLDAJFA(BODMOEILABD errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly JMMEMLBFONE MLMOBOECBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly ICollection<CMHBAPLAFMG> GEDHINBNMII;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private BJNBAMNJLOJ DNEFEDCIDAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x274D650", Offset = "0x274C650", VA = "0x18274D650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public EDBALDILLBK<IFOKEFFHPOH> HNGBCFCIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xF360F0", Offset = "0xF350F0", VA = "0x180F360F0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(EDBALDILLBK<IFOKEFFHPOH>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xF35050", Offset = "0xF34050", VA = "0x180F35050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private EDBALDILLBK<KCPNHNINCKC> CHKDGPDINHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x12E4C70", Offset = "0x12E3C70", VA = "0x1812E4C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public EDBALDILLBK<AIHJLHNMKCJ> GJIJHNKEFCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA17D90", Offset = "0xA16D90", VA = "0x180A17D90", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(EDBALDILLBK<AIHJLHNMKCJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override EDBALDILLBK<LOPJDFBDKHF> KKPPEGHFDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x274CD70", Offset = "0x274BD70", VA = "0x18274CD70", Slot = "21")]
		get
		{
			return default(EDBALDILLBK<LOPJDFBDKHF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool KMDMNIFABMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x2749E50", Offset = "0x2748E50", VA = "0x182749E50", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x274D670", Offset = "0x274C670", VA = "0x18274D670")]
	private KCILGDEGCLG(CHIEBOEDIPK IOIBNPDJCNE, GDCCFCAPGMP GOJJJBGJPAM, JMMEMLBFONE HDKBOKEPPCD, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<IFOKEFFHPOH> MOOIAANOCKP, EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK, bool OGKGFGNPDEA, string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2749930", Offset = "0x2748930", VA = "0x182749930")]
	public static KCILGDEGCLG ACADPGMDEBE(CHIEBOEDIPK IOIBNPDJCNE, GDCCFCAPGMP GOJJJBGJPAM, JMMEMLBFONE HPLMFDGMJFE, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK, EDBALDILLBK<IFOKEFFHPOH> MOOIAANOCKP, bool OGKGFGNPDEA, bool FPPJBNBMHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2749DB0", Offset = "0x2748DB0", VA = "0x182749DB0", Slot = "22")]
	protected override void ANJKPBDKBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x274A8D0", Offset = "0x27498D0", VA = "0x18274A8D0", Slot = "23")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x274B4F0", Offset = "0x274A4F0", VA = "0x18274B4F0", Slot = "31")]
	public void GMNJCMMACLA(CMHBAPLAFMG GLBFCMABIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x274A100", Offset = "0x2749100", VA = "0x18274A100", Slot = "28")]
	public void CFGFNPBIMGE(AKOMMOLMACN CHLBGLMLGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x274B880", Offset = "0x274A880", VA = "0x18274B880", Slot = "29")]
	public void HMHNDPEKCAL(OGFFBPIJDKD ABDHOCCLNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x274B550", Offset = "0x274A550", VA = "0x18274B550", Slot = "24")]
	protected override void HHNKFBFEPJF(JFPHGDGHBDF NNDPLIOKOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x274B700", Offset = "0x274A700", VA = "0x18274B700", Slot = "33")]
	public string HMDBIFFBANE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x274AEE0", Offset = "0x2749EE0", VA = "0x18274AEE0", Slot = "30")]
	public string FIDCOPFFAMC(int HOMPFMAAAKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x274C900", Offset = "0x274B900", VA = "0x18274C900")]
	private void IEBLMJLPMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x274ABD0", Offset = "0x2749BD0", VA = "0x18274ABD0", Slot = "32")]
	public void EGENMJADMAI(CMHBAPLAFMG GLBFCMABIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x274CBB0", Offset = "0x274BBB0", VA = "0x18274CBB0")]
	private void JJNCOMANPNK(bool OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x274A970", Offset = "0x2749970", VA = "0x18274A970", Slot = "34")]
	[AsyncStateMachine(typeof(JFBDCCHHCCP))]
	public Task ECAOPINDFKI(string OHLIHBDBKCE, bool LIIPBEPHFLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x274B250", Offset = "0x274A250", VA = "0x18274B250")]
	public void GIEJELJAOEG(string OHLIHBDBKCE, bool LIIPBEPHFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x274A470", Offset = "0x2749470", VA = "0x18274A470")]
	private void CHLPGMONNAD(int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2749ED0", Offset = "0x2748ED0", VA = "0x182749ED0")]
	private void BIPNHPGCKFE(int BGBBDAECBHO, string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x274CE50", Offset = "0x274BE50", VA = "0x18274CE50")]
	private void KPDOMCACGEG(int BGBBDAECBHO, string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x274AA80", Offset = "0x2749A80", VA = "0x18274AA80")]
	private string EGEIGHIBOLC(int BGBBDAECBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x274D010", Offset = "0x274C010", VA = "0x18274D010")]
	private string LCDHAAFFKPO(int BGBBDAECBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0xF35050", Offset = "0xF34050", VA = "0x180F35050")]
	internal void OEENBNBGJGG(EDBALDILLBK<IFOKEFFHPOH> OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x274B1B0", Offset = "0x274A1B0", VA = "0x18274B1B0")]
	[CompilerGenerated]
	private void FLKNFECNDFE(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x274D350", Offset = "0x274C350", VA = "0x18274D350")]
	[CompilerGenerated]
	private bool LMIHHEBOLGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x2749870", Offset = "0x2748870", VA = "0x182749870")]
	[CompilerGenerated]
	private bool AAOHJCABGFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x274A6E0", Offset = "0x27496E0", VA = "0x18274A6E0")]
	[CompilerGenerated]
	private int DBJGDKHMCHM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x274ADD0", Offset = "0x2749DD0", VA = "0x18274ADD0")]
	[CompilerGenerated]
	private bool FEHHGHBPDBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x274D490", Offset = "0x274C490", VA = "0x18274D490")]
	[CompilerGenerated]
	private void MMFOFLDCHPA(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x274D590", Offset = "0x274C590", VA = "0x18274D590")]
	[CompilerGenerated]
	private bool PIAEAIGGPNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x274B6A0", Offset = "0x274A6A0", VA = "0x18274B6A0")]
	[CompilerGenerated]
	private bool HJHGLDKGIPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x274CDC0", Offset = "0x274BDC0", VA = "0x18274CDC0")]
	[CompilerGenerated]
	private bool KNBBAFNOFAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x274A6E0", Offset = "0x27496E0", VA = "0x18274A6E0")]
	[CompilerGenerated]
	private int NPGOEFNDHFD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2749CE0", Offset = "0x2748CE0", VA = "0x182749CE0")]
	[CompilerGenerated]
	private bool AEKOBCHNCCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x274AE60", Offset = "0x2749E60", VA = "0x18274AE60")]
	[CompilerGenerated]
	private object FHCLFEHJMAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x274B1D0", Offset = "0x274A1D0", VA = "0x18274B1D0")]
	[CompilerGenerated]
	private void GDKIGKPIIOB(object OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x274A610", Offset = "0x2749610", VA = "0x18274A610")]
	[CompilerGenerated]
	private bool CNHDEBIGLNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x274D510", Offset = "0x274C510", VA = "0x18274D510")]
	[CompilerGenerated]
	private string OLKLNBLMPPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x274D580", Offset = "0x274C580", VA = "0x18274D580")]
	[CompilerGenerated]
	private void PFILLDLIEOA(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x274A800", Offset = "0x2749800", VA = "0x18274A800")]
	[CompilerGenerated]
	private bool DPINMCNOOKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x274D420", Offset = "0x274C420", VA = "0x18274D420")]
	[CompilerGenerated]
	private string MKFBKCHINIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x274D1A0", Offset = "0x274C1A0", VA = "0x18274D1A0")]
	[CompilerGenerated]
	private void LCGGOGBJOPO(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x274A730", Offset = "0x2749730", VA = "0x18274A730")]
	[CompilerGenerated]
	private bool DCMDNPCOKDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x274AC90", Offset = "0x2749C90", VA = "0x18274AC90")]
	[CompilerGenerated]
	private string EGKIELJHGKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x274B1C0", Offset = "0x274A1C0", VA = "0x18274B1C0")]
	[CompilerGenerated]
	private void FOBIHJCNBMM(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x274D1B0", Offset = "0x274C1B0", VA = "0x18274D1B0")]
	[CompilerGenerated]
	private bool LCPPIGALFMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x274B470", Offset = "0x274A470", VA = "0x18274B470")]
	[CompilerGenerated]
	private string GLPKPFLHKMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x274D410", Offset = "0x274C410", VA = "0x18274D410")]
	[CompilerGenerated]
	private void LNBJIMKHPFG(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x274C830", Offset = "0x274B830", VA = "0x18274C830")]
	[CompilerGenerated]
	private bool HNHLPKLEEEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x274D4A0", Offset = "0x274C4A0", VA = "0x18274D4A0")]
	[CompilerGenerated]
	private string NOPFLJNAJNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x274B4E0", Offset = "0x274A4E0", VA = "0x18274B4E0")]
	[CompilerGenerated]
	private void GMFAODMNFGI(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x274AD00", Offset = "0x2749D00", VA = "0x18274AD00")]
	[CompilerGenerated]
	private bool ENJFAEEJFCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x274CB40", Offset = "0x274BB40", VA = "0x18274CB40")]
	[CompilerGenerated]
	private string JILAOAJNNHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x274B6F0", Offset = "0x274A6F0", VA = "0x18274B6F0")]
	[CompilerGenerated]
	private void HLNCDGCHDBD(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x274B3A0", Offset = "0x274A3A0", VA = "0x18274B3A0")]
	[CompilerGenerated]
	private bool GIGPMDOPHDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x274A090", Offset = "0x2749090", VA = "0x18274A090")]
	[CompilerGenerated]
	private string CCGCLCNDABF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x274CB30", Offset = "0x274BB30", VA = "0x18274CB30")]
	[CompilerGenerated]
	private void JCFHGPHIJGO(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x274D280", Offset = "0x274C280", VA = "0x18274D280")]
	[CompilerGenerated]
	private bool LEAAKFOGMKA()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class EOMMPJMBEKM
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private sealed class NNJGPNPLPGN : FNEGPADGNAD<GCPKKAJPCKB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class EKKCKDAAEMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public NNJGPNPLPGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public EKKCKDAAEMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x2739E30", Offset = "0x2738E30", VA = "0x182739E30")]
			internal object PMOJIBLCDBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x2739EA0", Offset = "0x2738EA0", VA = "0x182739EA0")]
			internal void POFMCLKDAFO(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2750990", Offset = "0x274F990", VA = "0x182750990")]
		public NNJGPNPLPGN(CHIEBOEDIPK IOIBNPDJCNE, GCPKKAJPCKB HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2750700", Offset = "0x274F700", VA = "0x182750700", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class BFBCCKMIICJ : CAMHBDKBKIA<ILBBDEMBAKM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override AEKGKKLKPIL EPPODOEMAIM
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xBCB9B0", Offset = "0xBCA9B0", VA = "0x180BCB9B0", Slot = "140")]
			get
			{
				return default(AEKGKKLKPIL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2736490", Offset = "0x2735490", VA = "0x182736490")]
		public BFBCCKMIICJ(CHIEBOEDIPK IOIBNPDJCNE, ILBBDEMBAKM HCAMONPFOJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class OILKBLKHOHO : FNEGPADGNAD<HBGMKHMEDOH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2751400", Offset = "0x2750400", VA = "0x182751400")]
		public OILKBLKHOHO(CHIEBOEDIPK IOIBNPDJCNE, HBGMKHMEDOH GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2751100", Offset = "0x2750100", VA = "0x182751100", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2751280", Offset = "0x2750280", VA = "0x182751280")]
		[CompilerGenerated]
		private bool JLDOFNMGBBA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x27512D0", Offset = "0x27502D0", VA = "0x1827512D0")]
		[CompilerGenerated]
		private void PHPDFLHALAO(bool OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class FEAMMEJMBFM : FNEGPADGNAD<IDFKPHFNCHO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class PJAFKBNFHNM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public FEAMMEJMBFM <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public PJAFKBNFHNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x2752690", Offset = "0x2751690", VA = "0x182752690")]
			internal void PMOJIBLCDBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x27526E0", Offset = "0x27516E0", VA = "0x1827526E0")]
			internal bool POFMCLKDAFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x27524C0", Offset = "0x27514C0", VA = "0x1827524C0")]
			internal bool IGNBPBENOMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x2752510", Offset = "0x2751510", VA = "0x182752510")]
			internal void NOAGHDJPGKH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x2752640", Offset = "0x2751640", VA = "0x182752640")]
			internal bool OABKELGAFGC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x273BAB0", Offset = "0x273AAB0", VA = "0x18273BAB0")]
		public FEAMMEJMBFM(CHIEBOEDIPK IOIBNPDJCNE, IDFKPHFNCHO GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x273B770", Offset = "0x273A770", VA = "0x18273B770", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class BNJFKCAIBOE : FNEGPADGNAD<EPJLFGNOMOD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class ADEGAMBDAPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public BNJFKCAIBOE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public ADEGAMBDAPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2734E50", Offset = "0x2733E50", VA = "0x182734E50")]
			internal object PMOJIBLCDBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2734A20", Offset = "0x2733A20", VA = "0x182734A20")]
			internal bool EGEKFLONCNL(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x2734F50", Offset = "0x2733F50", VA = "0x182734F50")]
			internal void POFMCLKDAFO(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x2734BD0", Offset = "0x2733BD0", VA = "0x182734BD0")]
			internal string IGNBPBENOMC(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2734D40", Offset = "0x2733D40", VA = "0x182734D40")]
			internal IReadOnlyList<object> NOAGHDJPGKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2734D90", Offset = "0x2733D90", VA = "0x182734D90")]
			internal bool OABKELGAFGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2734E00", Offset = "0x2733E00", VA = "0x182734E00")]
			internal bool ONMGGGFMIMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2734AA0", Offset = "0x2733AA0", VA = "0x182734AA0")]
			internal void IEBNCJCHKNG(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2737020", Offset = "0x2736020", VA = "0x182737020")]
		public BNJFKCAIBOE(CHIEBOEDIPK IOIBNPDJCNE, EPJLFGNOMOD GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x27368D0", Offset = "0x27358D0", VA = "0x1827368D0", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class GDPPAOCCIGP : FNEGPADGNAD<DLIDFEBFLFF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class AMIFMNEHNDP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public GDPPAOCCIGP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public AMIFMNEHNDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x2735A00", Offset = "0x2734A00", VA = "0x182735A00")]
			internal bool PMOJIBLCDBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x2735A50", Offset = "0x2734A50", VA = "0x182735A50")]
			internal void POFMCLKDAFO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x27359B0", Offset = "0x27349B0", VA = "0x1827359B0")]
			internal bool IGNBPBENOMC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x273CA70", Offset = "0x273BA70", VA = "0x18273CA70")]
		public GDPPAOCCIGP(CHIEBOEDIPK IOIBNPDJCNE, DLIDFEBFLFF GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x273C840", Offset = "0x273B840", VA = "0x18273C840", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public abstract class NPCCNPOFPCI<TNode> : FNEGPADGNAD<TNode> where TNode : notnull, KODFGBCADPG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct KMNLBHPFNLK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public NPCCNPOFPCI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x4FECC00", Offset = "0x4FEBC00", VA = "0x184FECC00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x4FED020", Offset = "0x4FEC020", VA = "0x184FED020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct IDICNKCKMLD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public NPCCNPOFPCI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public EDBALDILLBK<MECIAIKJJDL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x4BF5660", Offset = "0x4BF4660", VA = "0x184BF5660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x4BF5A80", Offset = "0x4BF4A80", VA = "0x184BF5A80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public sealed override bool PCNJMJHNNHM
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public sealed override EDBALDILLBK<MECIAIKJJDL>? NEHDIPFJKOB
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x5407F80", Offset = "0x5406F80", VA = "0x185407F80", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x513AAC0", Offset = "0x5139AC0", VA = "0x18513AAC0")]
		protected NPCCNPOFPCI(CHIEBOEDIPK IOIBNPDJCNE, TNode GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5407E60", Offset = "0x5406E60", VA = "0x185407E60", Slot = "114")]
		[AsyncStateMachine(typeof(NPCCNPOFPCI<>.KMNLBHPFNLK))]
		public override Task<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> NLJCJIFCEPE(string NFHOBPDKIPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5407C10", Offset = "0x5406C10", VA = "0x185407C10", Slot = "138")]
		public sealed override bool CJLAALIHDHE(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5407CB0", Offset = "0x5406CB0", VA = "0x185407CB0", Slot = "126")]
		protected sealed override bool EIOFANCGDJC(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5407B70", Offset = "0x5406B70", VA = "0x185407B70", Slot = "127")]
		protected override bool BLLOHDPAIJK(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5407D50", Offset = "0x5406D50", VA = "0x185407D50", Slot = "115")]
		[AsyncStateMachine(typeof(NPCCNPOFPCI<>.IDICNKCKMLD))]
		public override Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> HBOMGBAHBHB(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class JJJHGNMFKFG : OGBFMPPEGJC<DPCINDPNFPB>
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class ONDBFJFGLMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public JJJHGNMFKFG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public ONDBFJFGLMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x2752200", Offset = "0x2751200", VA = "0x182752200")]
			internal bool JGLMENIGIII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x2752140", Offset = "0x2751140", VA = "0x182752140")]
			internal void EKEOADEHHLG(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x27497B0", Offset = "0x27487B0", VA = "0x1827497B0")]
		public JJJHGNMFKFG(CHIEBOEDIPK IOIBNPDJCNE, DPCINDPNFPB HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x2749560", Offset = "0x2748560", VA = "0x182749560", Slot = "140")]
		protected override void BLDBLIFKMKL(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class KBOGGBLMHOG : OBDPADHLGOK<JENICIOFEDF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xBDE1B0", Offset = "0xBDD1B0", VA = "0x180BDE1B0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2749810", Offset = "0x2748810", VA = "0x182749810")]
		public KBOGGBLMHOG(CHIEBOEDIPK IOIBNPDJCNE, JENICIOFEDF GOJJJBGJPAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public abstract class OBDPADHLGOK<TNode> : FNEGPADGNAD<TNode> where TNode : notnull, IPDDMCHPANF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct LLLNJNJBDLM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public OBDPADHLGOK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			private TaskAwaiter<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x51220A0", Offset = "0x51210A0", VA = "0x1851220A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x5122560", Offset = "0x5121560", VA = "0x185122560", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct BOOCCMJPFAN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public OBDPADHLGOK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public EDBALDILLBK<MECIAIKJJDL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x63B3BF0", Offset = "0x63B2BF0", VA = "0x1863B3BF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x63B4080", Offset = "0x63B3080", VA = "0x1863B4080", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private struct GKFNFDICENB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public AsyncTaskMethodBuilder<HHHCCNLMPJL<OCIFKDPAIJK, DLKBDBKHJCC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public OBDPADHLGOK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private TaskAwaiter<HHHCCNLMPJL<OCIFKDPAIJK, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x4A890C0", Offset = "0x4A880C0", VA = "0x184A890C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x4A89790", Offset = "0x4A88790", VA = "0x184A89790", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class GCGFOMGGNEF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000055")]
			private struct <<BuildConfigMenuInternal>b__7>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public GCGFOMGGNEF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x402F2F0", Offset = "0x402E2F0", VA = "0x18402F2F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public KIEOOBCGILC configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public OBDPADHLGOK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public GCGFOMGGNEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x4A4C090", Offset = "0x4A4B090", VA = "0x184A4C090")]
			internal bool IEBNCJCHKNG(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x4A4C170", Offset = "0x4A4B170", VA = "0x184A4C170")]
			internal void PMOJIBLCDBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x4A4BFF0", Offset = "0x4A4AFF0", VA = "0x184A4BFF0")]
			[AsyncStateMachine(typeof(OBDPADHLGOK<>.GCGFOMGGNEF.<<BuildConfigMenuInternal>b__7>d))]
			internal void EGEKFLONCNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x4A4C460", Offset = "0x4A4B460", VA = "0x184A4C460")]
			internal bool POFMCLKDAFO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private sealed class PLPBHNBMEDF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000057")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public PLPBHNBMEDF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x402EF80", Offset = "0x402DF80", VA = "0x18402EF80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public GCGFOMGGNEF CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public PLPBHNBMEDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x561EA00", Offset = "0x561DA00", VA = "0x18561EA00")]
			internal void IGNBPBENOMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			internal string NOAGHDJPGKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
			internal void OABKELGAFGC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x561EDB0", Offset = "0x561DDB0", VA = "0x18561EDB0")]
			[AsyncStateMachine(typeof(OBDPADHLGOK<>.PLPBHNBMEDF.<<BuildConfigMenuInternal>b__5>d))]
			internal void ONMGGGFMIMJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class JCMBIONDLGG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000059")]
			private struct <<AddDynamicNodeGroupSettingV2>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				public JCMBIONDLGG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x402EAB0", Offset = "0x402DAB0", VA = "0x18402EAB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005A")]
			private struct <<AddDynamicNodeGroupSettingV2>b__6>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public JCMBIONDLGG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				private TaskAwaiter<HHHCCNLMPJL<EDBALDILLBK<KCPNHNINCKC>, DLKBDBKHJCC>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x402EC90", Offset = "0x402DC90", VA = "0x18402EC90", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			private struct <<AddDynamicNodeGroupSettingV2>b__10>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000113")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public JCMBIONDLGG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				private TaskAwaiter<HHHCCNLMPJL<EDBALDILLBK<LGADIHOLJAO>, DLKBDBKHJCC>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x402E3F0", Offset = "0x402D3F0", VA = "0x18402E3F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public OBDPADHLGOK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public EDBALDILLBK<MECIAIKJJDL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public KIEOOBCGILC configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public LCBAJMHOMEH nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public ACLPKCGEGFP selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public List<MPMMOAFDEHE> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public ACLPKCGEGFP selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public List<MPMMOAFDEHE> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public JCMBIONDLGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4E251F0", Offset = "0x4E241F0", VA = "0x184E251F0")]
			internal bool OAAFMLCDCMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x4E24FB0", Offset = "0x4E23FB0", VA = "0x184E24FB0")]
			internal void IMDMEEMDPJA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4E24BE0", Offset = "0x4E23BE0", VA = "0x184E24BE0")]
			internal bool EPBBOIMBNOJ(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x4E24A60", Offset = "0x4E23A60", VA = "0x184E24A60")]
			internal bool AFCEFCMKOAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4E25260", Offset = "0x4E24260", VA = "0x184E25260")]
			[AsyncStateMachine(typeof(OBDPADHLGOK<>.JCMBIONDLGG.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void OFCNDFJJFLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x4E24F70", Offset = "0x4E23F70", VA = "0x184E24F70")]
			internal bool IMCHGMFLBGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x4E24EB0", Offset = "0x4E23EB0", VA = "0x184E24EB0")]
			internal void GLPKDFPPDDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x4E24CC0", Offset = "0x4E23CC0", VA = "0x184E24CC0")]
			internal bool FAHFJKDKDIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x4E250D0", Offset = "0x4E240D0", VA = "0x184E250D0")]
			internal void MOBBJCGKAIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x4E25020", Offset = "0x4E24020", VA = "0x184E25020")]
			internal bool LOOMNPCAAED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x4E25370", Offset = "0x4E24370", VA = "0x184E25370")]
			internal bool OKALMJNILMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x4E24AA0", Offset = "0x4E23AA0", VA = "0x184E24AA0")]
			internal void AMHGOLIJIII(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x4E24D70", Offset = "0x4E23D70", VA = "0x184E24D70")]
			[AsyncStateMachine(typeof(OBDPADHLGOK<>.JCMBIONDLGG.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void FMMMGBIHFBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x4E24B80", Offset = "0x4E23B80", VA = "0x184E24B80")]
			internal bool DCHMIBJKBHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x4E24B10", Offset = "0x4E23B10", VA = "0x184E24B10")]
			internal bool DBEEGNKMAPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x4E25300", Offset = "0x4E24300", VA = "0x184E25300")]
			internal void OIMLOHIOIGF(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x4E24E10", Offset = "0x4E23E10", VA = "0x184E24E10")]
			[AsyncStateMachine(typeof(OBDPADHLGOK<>.JCMBIONDLGG.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void GJOOJOOFLJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x4E25190", Offset = "0x4E24190", VA = "0x184E25190")]
			internal bool NKHDDGJIHEO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class EKJCLEKPPFO
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200005D")]
			private struct <<AddDynamicNodeGroupSettingV2>b__16>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public EKJCLEKPPFO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x402E6E0", Offset = "0x402D6E0", VA = "0x18402E6E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public JCMBIONDLGG CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public EKJCLEKPPFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x44E16D0", Offset = "0x44E06D0", VA = "0x1844E16D0")]
			internal void NDPMNKEJIOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			internal string OKBPNEJLIAG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
			internal void FNDDONMAAIG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x44E1AF0", Offset = "0x44E0AF0", VA = "0x1844E1AF0")]
			[AsyncStateMachine(typeof(OBDPADHLGOK<>.EKJCLEKPPFO.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void NLHDALOANKA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class PBMEIGCCCKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public LCBAJMHOMEH nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public List<MPMMOAFDEHE> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public OBDPADHLGOK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public EDBALDILLBK<MECIAIKJJDL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public PBMEIGCCCKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x55F63E0", Offset = "0x55F53E0", VA = "0x1855F63E0")]
			internal bool BKKCPMNKNJE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class GOEHNHAHPMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public HGIFBECBIMN port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public PBMEIGCCCKE CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public GOEHNHAHPMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x4A956D0", Offset = "0x4A946D0", VA = "0x184A956D0")]
			internal void DJIFFCEHJJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x4A957E0", Offset = "0x4A947E0", VA = "0x184A957E0")]
			internal bool EAHJCFONAEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x4A95830", Offset = "0x4A94830", VA = "0x184A95830")]
			internal void GBEFEEJMKEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x4A95950", Offset = "0x4A94950", VA = "0x184A95950")]
			internal bool HPMBNECEJAI()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class GMCLJFILJHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public MPMMOAFDEHE portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public GOEHNHAHPMP CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public GMCLJFILJHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x4A92810", Offset = "0x4A91810", VA = "0x184A92810")]
			internal void GLIHELNLLFB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class AIAHKFLFGMI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000062")]
			private struct <<CreatePortItemV2>b__3>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				public AIAHKFLFGMI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x4030730", Offset = "0x402F730", VA = "0x184030730", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public ACLPKCGEGFP selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public LCBAJMHOMEH nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public HGIFBECBIMN port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public AIAHKFLFGMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x4A642A0", Offset = "0x4A632A0", VA = "0x184A642A0")]
			internal int KOAIAMEOKMJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x4A63F70", Offset = "0x4A62F70", VA = "0x184A63F70")]
			internal void AMDGEGBOADI(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
			internal string LAKIODLIHFB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x4A642E0", Offset = "0x4A632E0", VA = "0x184A642E0")]
			[AsyncStateMachine(typeof(OBDPADHLGOK<>.AIAHKFLFGMI.<<CreatePortItemV2>b__3>d))]
			internal void PPMMDIIGDBP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x4A641C0", Offset = "0x4A631C0", VA = "0x184A641C0")]
			internal bool JCNLPNIOOHO(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly Dictionary<EDBALDILLBK<MECIAIKJJDL>, bool> KLOLAOJMKOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly Dictionary<EDBALDILLBK<MECIAIKJJDL>, bool> NPNDFFAHPPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<EDBALDILLBK<MECIAIKJJDL>, bool> PHOPLPKOMND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private Dictionary<EDBALDILLBK<MECIAIKJJDL>, bool> DBIOCIEDILL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private Dictionary<EDBALDILLBK<MECIAIKJJDL>, bool> JLKPKKFDFNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private Dictionary<EDBALDILLBK<MECIAIKJJDL>, bool> ACBIJBPMHME;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool HFIAGEGNIAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected virtual bool NADBNOKNONI
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected virtual bool IFCPEFJLODD
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected virtual bool PMHMAIDFNID
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "142")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override EDBALDILLBK<BIEIIMCKPHN>? EIKAIJOGKJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x5504830", Offset = "0x5503830", VA = "0x185504830", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override EDBALDILLBK<MECIAIKJJDL>? NEHDIPFJKOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x5504B00", Offset = "0x5503B00", VA = "0x185504B00", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override IEnumerable<IGLPJBODKFE<ALEKBGLLPHJ>>? BGLFMODOKND
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x55048F0", Offset = "0x55038F0", VA = "0x1855048F0", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5504610", Offset = "0x5503610", VA = "0x185504610")]
		public OBDPADHLGOK(CHIEBOEDIPK IOIBNPDJCNE, TNode GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "143")]
		protected virtual bool BOJGFFOLLMM(int KEEMGACDGMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "144")]
		protected virtual bool JOJEJFGDFNI(int KEEMGACDGMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "145")]
		protected virtual bool OKDIJONPGPD(int KEEMGACDGMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "146")]
		protected virtual void HBPEKCPKJEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x54FFCF0", Offset = "0x54FECF0", VA = "0x1854FFCF0", Slot = "138")]
		public override bool CJLAALIHDHE(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5503230", Offset = "0x5502230", VA = "0x185503230", Slot = "114")]
		[AsyncStateMachine(typeof(OBDPADHLGOK<>.LLLNJNJBDLM))]
		public override Task<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> NLJCJIFCEPE(string NFHOBPDKIPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5502B00", Offset = "0x5501B00", VA = "0x185502B00", Slot = "115")]
		[AsyncStateMachine(typeof(OBDPADHLGOK<>.BOOCCMJPFAN))]
		public override Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> HBOMGBAHBHB(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x55006E0", Offset = "0x54FF6E0", VA = "0x1855006E0", Slot = "116")]
		public override void DOMLNJILBBI(EDBALDILLBK<MECIAIKJJDL> OHHMJGCBCKD, EDBALDILLBK<MECIAIKJJDL> FCPOJLOEIEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5502EB0", Offset = "0x5501EB0", VA = "0x185502EB0", Slot = "117")]
		public override IEnumerable<AFPLFKDKJPC> LDELJOIKHDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5503130", Offset = "0x5502130", VA = "0x185503130")]
		[AsyncStateMachine(typeof(OBDPADHLGOK<>.GKFNFDICENB))]
		private Task<HHHCCNLMPJL<OCIFKDPAIJK, DLKBDBKHJCC>> NJJDMAPKPKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "147")]
		protected virtual bool KHLLIPGHIMF(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "148")]
		protected virtual bool IKFOFLCFMLN(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "149")]
		protected virtual bool DBEFAGOJEJN(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "150")]
		protected virtual bool MOCMABCDADD(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "151")]
		protected virtual bool IFALGEPKPAK(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, int OOBLHGFAEBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "152")]
		protected virtual bool BFPGFMPNFHN(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, int OOBLHGFAEBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "153")]
		protected virtual bool NNJKPONAOPO(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, int HDHJPIOPNFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "154")]
		protected virtual bool BKJEMIJIJKM(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, int HDHJPIOPNFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "155")]
		protected virtual bool CMBJMOBHEAN(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, int DNBAGCFNADG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "156")]
		protected virtual bool CJIFKGFBKDL(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, int MOJFMLAABNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5502C10", Offset = "0x5501C10", VA = "0x185502C10", Slot = "157")]
		protected virtual List<ACLPKCGEGFP> JLHOPDDEJNA(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "158")]
		protected virtual void IJJGDGDECAA(KIEOOBCGILC PEEMKKKLLMO, PKGAMJNFCDF OHJFGJDHPPD, LCBAJMHOMEH PEOKEDEMFEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5500990", Offset = "0x54FF990", VA = "0x185500990", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5501400", Offset = "0x5500400", VA = "0x185501400")]
		private PKGAMJNFCDF GOPKHENEGJF(KIEOOBCGILC PEEMKKKLLMO, LCBAJMHOMEH PEOKEDEMFEO, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5503540", Offset = "0x5502540", VA = "0x185503540")]
		private List<MPMMOAFDEHE> PHLFOICIICP(KIEOOBCGILC PEEMKKKLLMO, LCBAJMHOMEH PEOKEDEMFEO, PKGAMJNFCDF HGFLHMEJOLB, bool ODHLNAONGFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x54FFD90", Offset = "0x54FED90", VA = "0x1854FFD90")]
		private List<MPMMOAFDEHE> CPBDDNLBMPA(KIEOOBCGILC PEEMKKKLLMO, LCBAJMHOMEH PEOKEDEMFEO, HGIFBECBIMN JHMPKACOBFK, bool ODHLNAONGFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5503350", Offset = "0x5502350", VA = "0x185503350")]
		private ACLPKCGEGFP OPLJLBFIOOF(List<ACLPKCGEGFP> KHFGELJEHJA, HGIFBECBIMN JHMPKACOBFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5500900", Offset = "0x54FF900", VA = "0x185500900")]
		[CompilerGenerated]
		private AFPLFKDKJPC ENOPFFBHLHB(GDCCFCAPGMP DEBKJNNAPAB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class JFGMMFGEMAE : FNEGPADGNAD<IBJBOPEHBJM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class GHLIEMBLMFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public JFGMMFGEMAE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public GHLIEMBLMFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x273CAE0", Offset = "0x273BAE0", VA = "0x18273CAE0")]
			internal int PMOJIBLCDBE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x273CB30", Offset = "0x273BB30", VA = "0x18273CB30")]
			internal void POFMCLKDAFO(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x10AE210", Offset = "0x10AD210", VA = "0x1810AE210", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x273DD90", Offset = "0x273CD90", VA = "0x18273DD90")]
		public JFGMMFGEMAE(CHIEBOEDIPK IOIBNPDJCNE, IBJBOPEHBJM GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x273DBD0", Offset = "0x273CBD0", VA = "0x18273DBD0", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class PMPHPDPPFMN : OGBFMPPEGJC<DOGJFMBOJPF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class AJECCCMFOBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public PMPHPDPPFMN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public AJECCCMFOBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x2735930", Offset = "0x2734930", VA = "0x182735930")]
			internal int JGLMENIGIII()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x2735890", Offset = "0x2734890", VA = "0x182735890")]
			internal void EKEOADEHHLG(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2752970", Offset = "0x2751970", VA = "0x182752970")]
		public PMPHPDPPFMN(CHIEBOEDIPK IOIBNPDJCNE, DOGJFMBOJPF HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2752730", Offset = "0x2751730", VA = "0x182752730", Slot = "140")]
		protected override void BLDBLIFKMKL(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private sealed class ICHNHKEJCAO : FNEGPADGNAD<IJKDPFGJJAE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xD7E220", Offset = "0xD7D220", VA = "0x180D7E220", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x273CE10", Offset = "0x273BE10", VA = "0x18273CE10")]
		public ICHNHKEJCAO(CHIEBOEDIPK IOIBNPDJCNE, IJKDPFGJJAE GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class NBMMDOFDBPD : FNEGPADGNAD<OHNOHCLIODK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class JHKHDANIILP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			public NBMMDOFDBPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public KIEOOBCGILC configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public JHKHDANIILP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x2749060", Offset = "0x2748060", VA = "0x182749060")]
			internal bool PMOJIBLCDBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x2749100", Offset = "0x2748100", VA = "0x182749100")]
			internal void POFMCLKDAFO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x2748810", Offset = "0x2747810", VA = "0x182748810")]
			internal bool OABKELGAFGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x2748BA0", Offset = "0x2747BA0", VA = "0x182748BA0")]
			internal bool ONMGGGFMIMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x27466A0", Offset = "0x27456A0", VA = "0x1827466A0")]
			internal void IEBNCJCHKNG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x2747530", Offset = "0x2746530", VA = "0x182747530")]
			internal bool JPFEDGBCBJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x27490B0", Offset = "0x27480B0", VA = "0x1827490B0")]
			internal bool PNCCNAEJOIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x27467C0", Offset = "0x27457C0", VA = "0x1827467C0")]
			internal void IFOPBOHCJEJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x27481B0", Offset = "0x27471B0", VA = "0x1827481B0")]
			internal bool MLKHAPMBMMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x2747E90", Offset = "0x2746E90", VA = "0x182747E90")]
			internal bool LNOGJAFDNNH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x2740010", Offset = "0x273F010", VA = "0x182740010")]
			internal void GKAKPGKIMJK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x273F740", Offset = "0x273E740", VA = "0x18273F740")]
			internal bool ELFIHIHEIAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x2746980", Offset = "0x2745980", VA = "0x182746980")]
			internal bool IJHJEBBMAHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x273EF40", Offset = "0x273DF40", VA = "0x18273EF40")]
			internal bool DCNOMKAMMKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x2748EE0", Offset = "0x2747EE0", VA = "0x182748EE0")]
			internal bool PKLPPKCDGJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x27402C0", Offset = "0x273F2C0", VA = "0x1827402C0")]
			internal bool HGKECNJHDMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x2747F80", Offset = "0x2746F80", VA = "0x182747F80")]
			internal bool MBMCBHPBCJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x273E950", Offset = "0x273D950", VA = "0x18273E950")]
			internal bool BOMACFEALKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x27474E0", Offset = "0x27464E0", VA = "0x1827474E0")]
			internal bool JNHIMAHAFPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x2746B10", Offset = "0x2745B10", VA = "0x182746B10")]
			internal bool JAHBGHNNOGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x2747CA0", Offset = "0x2746CA0", VA = "0x182747CA0")]
			internal void LGCCABAHKJI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x273ED10", Offset = "0x273DD10", VA = "0x18273ED10")]
			internal bool CNHFKEFEDIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x2740310", Offset = "0x273F310", VA = "0x182740310")]
			internal bool HHCMALGMPMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x273F250", Offset = "0x273E250", VA = "0x18273F250")]
			internal bool DIABECDNLGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x2747EE0", Offset = "0x2746EE0", VA = "0x182747EE0")]
			internal bool LOLONPNLPEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2740360", Offset = "0x273F360", VA = "0x182740360")]
			internal bool HLDLIBFCGOK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2748E90", Offset = "0x2747E90", VA = "0x182748E90")]
			internal bool PJNMLLCFPAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2747820", Offset = "0x2746820", VA = "0x182747820")]
			internal bool KHKEDKLPEPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x2748160", Offset = "0x2747160", VA = "0x182748160")]
			internal bool MKHKGCBNIFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x2748DE0", Offset = "0x2747DE0", VA = "0x182748DE0")]
			internal void PHKFJDFCJHI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x2747A50", Offset = "0x2746A50", VA = "0x182747A50")]
			internal bool KOLAAKHFINO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x2747C00", Offset = "0x2746C00", VA = "0x182747C00")]
			internal bool LENMPBEGKEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x2748CE0", Offset = "0x2747CE0", VA = "0x182748CE0")]
			internal void PCAFOPAANHP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x2748930", Offset = "0x2747930", VA = "0x182748930")]
			internal bool OHJFLJBICCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x2747620", Offset = "0x2746620", VA = "0x182747620")]
			internal bool KDBPGMFJGNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x27404B0", Offset = "0x273F4B0", VA = "0x1827404B0")]
			internal void ICGKPJCGCJL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2740580", Offset = "0x273F580", VA = "0x182740580")]
			internal List<MPMMOAFDEHE> IDCHPEPLAJD(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x27477D0", Offset = "0x27467D0", VA = "0x1827477D0")]
			internal bool KGBJPEGJJKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x273FE20", Offset = "0x273EE20", VA = "0x18273FE20")]
			internal int GDEMCCNPPFL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x273F8D0", Offset = "0x273E8D0", VA = "0x18273F8D0")]
			internal void FFIDENIICBK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x273E4E0", Offset = "0x273D4E0", VA = "0x18273E4E0")]
			internal bool AMIAJCAANBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x27475D0", Offset = "0x27465D0", VA = "0x1827475D0")]
			internal bool KCGCGEKPLOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x2748B00", Offset = "0x2747B00", VA = "0x182748B00")]
			internal bool OKNLHPKHPOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x273F9D0", Offset = "0x273E9D0", VA = "0x18273F9D0")]
			internal int FHEPFLHKHGH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2747480", Offset = "0x2746480", VA = "0x182747480")]
			internal void JLIOOHJBADI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x2748020", Offset = "0x2747020", VA = "0x182748020")]
			internal bool MDCFMOLGBOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x2748C90", Offset = "0x2747C90", VA = "0x182748C90")]
			internal bool PAGDGNAFFPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x2748200", Offset = "0x2747200", VA = "0x182748200")]
			internal bool MMAPDGLHKGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x273E3F0", Offset = "0x273D3F0", VA = "0x18273E3F0")]
			internal bool AFMKILHPBPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x2747C50", Offset = "0x2746C50", VA = "0x182747C50")]
			internal bool LFGJDEMBDGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x27484A0", Offset = "0x27474A0", VA = "0x1827484A0")]
			internal bool NDEKNNICKDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x273FDD0", Offset = "0x273EDD0", VA = "0x18273FDD0")]
			internal string GDBALIPOKFK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x273E7E0", Offset = "0x273D7E0", VA = "0x18273E7E0")]
			internal void BJAEJALGIDC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x27489D0", Offset = "0x27479D0", VA = "0x1827489D0")]
			internal int OIEBPIFFNDC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x273ECB0", Offset = "0x273DCB0", VA = "0x18273ECB0")]
			internal void CMDGJNMMKEB(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x2747430", Offset = "0x2746430", VA = "0x182747430")]
			internal bool JJNDIBJFHJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x273F930", Offset = "0x273E930", VA = "0x18273F930")]
			internal bool FHAEAEAFEMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x2746BB0", Offset = "0x2745BB0", VA = "0x182746BB0")]
			internal bool JCPJHKDEEJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x273F160", Offset = "0x273E160", VA = "0x18273F160")]
			internal float DHBDJONJKGL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x2740450", Offset = "0x273F450", VA = "0x182740450")]
			internal void IBOHDCDELIE(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x27469D0", Offset = "0x27459D0", VA = "0x1827469D0")]
			internal bool IKCBHFFMLEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x273F560", Offset = "0x273E560", VA = "0x18273F560")]
			internal bool EEOAMLECNKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x2748D90", Offset = "0x2747D90", VA = "0x182748D90")]
			internal bool PHAJFIKCADM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x2747910", Offset = "0x2746910", VA = "0x182747910")]
			internal bool KLPHELEFLMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x2747DA0", Offset = "0x2746DA0", VA = "0x182747DA0")]
			internal bool LJKHHCDGANI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x2747E40", Offset = "0x2746E40", VA = "0x182747E40")]
			internal bool LMPGHECFEAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x2746C00", Offset = "0x2745C00", VA = "0x182746C00")]
			internal void JDFCFNPPNIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x27471F0", Offset = "0x27461F0", VA = "0x1827471F0")]
			internal string JFPMLNGBEBI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x2746700", Offset = "0x2745700", VA = "0x182746700")]
			internal void IFGHNNJBIAJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x27473E0", Offset = "0x27463E0", VA = "0x1827473E0")]
			internal bool JJHDBNBEADE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x2746AC0", Offset = "0x2745AC0", VA = "0x182746AC0")]
			internal bool INPPNEDMPLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x2747A00", Offset = "0x2746A00", VA = "0x182747A00")]
			internal bool KNPIBOOMOGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x2748540", Offset = "0x2747540", VA = "0x182748540")]
			internal void NIDHJCOBCIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x2749160", Offset = "0x2748160", VA = "0x182749160")]
			internal bool PPGOACIADMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x27468E0", Offset = "0x27458E0", VA = "0x1827468E0")]
			internal bool IHJCLCEHCKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x273FC70", Offset = "0x273EC70", VA = "0x18273FC70")]
			internal bool FPCFENNDIML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x273F3B0", Offset = "0x273E3B0", VA = "0x18273F3B0")]
			internal bool DOMGLJHEDLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x273E850", Offset = "0x273D850", VA = "0x18273E850")]
			internal void BKAMEIPEKJP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x27484F0", Offset = "0x27474F0", VA = "0x1827484F0")]
			internal bool NDLALIIKMCM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x273F000", Offset = "0x273E000", VA = "0x18273F000")]
			internal bool DFEEDMLNBEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x2748350", Offset = "0x2747350", VA = "0x182748350")]
			internal bool MNINIMHCJHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x2746770", Offset = "0x2745770", VA = "0x182746770")]
			internal bool IFIFMMAFNPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x2748440", Offset = "0x2747440", VA = "0x182748440")]
			internal void NAHLFKNIHKK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x273FF00", Offset = "0x273EF00", VA = "0x18273FF00")]
			internal bool GFNPECOCOAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x273E9A0", Offset = "0x273D9A0", VA = "0x18273E9A0")]
			internal bool BPNCMJCDMOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x273FA20", Offset = "0x273EA20", VA = "0x18273FA20")]
			internal bool FHJPFHMGFDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x2747730", Offset = "0x2746730", VA = "0x182747730")]
			internal bool KFABFBCDIAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x27488C0", Offset = "0x27478C0", VA = "0x1827488C0")]
			internal object OGHPGEHGNHI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2747290", Offset = "0x2746290", VA = "0x182747290")]
			internal void JGOHDPGCHKD(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x273FAD0", Offset = "0x273EAD0", VA = "0x18273FAD0")]
			internal bool FKHCHCNOOGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x273EB70", Offset = "0x273DB70", VA = "0x18273EB70")]
			internal bool CJHAIAKGAGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x273E490", Offset = "0x273D490", VA = "0x18273E490")]
			internal int AKKBEHCILKO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x273FD70", Offset = "0x273ED70", VA = "0x18273FD70")]
			internal void GCKHEJHBFJG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x27483F0", Offset = "0x27473F0", VA = "0x1827483F0")]
			internal bool MPJOJCLGANH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x273E900", Offset = "0x273D900", VA = "0x18273E900")]
			internal bool BNBNMKFHBLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x273E580", Offset = "0x273D580", VA = "0x18273E580")]
			internal int APFAHKANNHK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x273E9F0", Offset = "0x273D9F0", VA = "0x18273E9F0")]
			internal void CILCGHCAHKO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x2747D50", Offset = "0x2746D50", VA = "0x182747D50")]
			internal bool LJIDNJJPIKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x2749010", Offset = "0x2748010", VA = "0x182749010")]
			internal bool PMMFPDDIDNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x273F830", Offset = "0x273E830", VA = "0x18273F830")]
			internal bool EPONDLBMBJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x2746A70", Offset = "0x2745A70", VA = "0x182746A70")]
			internal int INODCPKAMBM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x273E5D0", Offset = "0x273D5D0", VA = "0x18273E5D0")]
			internal void APGAMICDNBF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x27482A0", Offset = "0x27472A0", VA = "0x1827482A0")]
			internal bool MNEOEJAHFAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x273FD20", Offset = "0x273ED20", VA = "0x18273FD20")]
			internal bool GAJKHJFDKPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x273EE00", Offset = "0x273DE00", VA = "0x18273EE00")]
			internal bool DADBKIJMOLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x273EA50", Offset = "0x273DA50", VA = "0x18273EA50")]
			internal object CJAFMCPDKIE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x273FE70", Offset = "0x273EE70", VA = "0x18273FE70")]
			internal void GEMHPDBMDAL(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x273E440", Offset = "0x273D440", VA = "0x18273E440")]
			internal bool AIOHMPADNAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x2746A20", Offset = "0x2745A20", VA = "0x182746A20")]
			internal bool IMDOKECIOHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x273EF90", Offset = "0x273DF90", VA = "0x18273EF90")]
			internal object DEDFEBDOAGM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x2748A20", Offset = "0x2747A20", VA = "0x182748A20")]
			internal void OIKMNKKAALA(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x273F050", Offset = "0x273E050", VA = "0x18273F050")]
			internal bool DFIOANHPEAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x273F4C0", Offset = "0x273E4C0", VA = "0x18273F4C0")]
			internal int EEGAMIKMIAM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x273FBC0", Offset = "0x273EBC0", VA = "0x18273FBC0")]
			internal void FNILNAMBPEB(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x273F980", Offset = "0x273E980", VA = "0x18273F980")]
			internal bool FHELDENCOGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x273F2A0", Offset = "0x273E2A0", VA = "0x18273F2A0")]
			internal bool DINCNAAHIJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x2747BB0", Offset = "0x2746BB0", VA = "0x182747BB0")]
			internal bool LELKGBAAHPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x273EB20", Offset = "0x273DB20", VA = "0x18273EB20")]
			internal int CJDPBDKIGFH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x273EAC0", Offset = "0x273DAC0", VA = "0x18273EAC0")]
			internal void CJDFKIBJDOB(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x273ED60", Offset = "0x273DD60", VA = "0x18273ED60")]
			internal bool CPKAJMNIOMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x273E790", Offset = "0x273D790", VA = "0x18273E790")]
			internal bool BIELHJCPLCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x273F880", Offset = "0x273E880", VA = "0x18273F880")]
			internal bool FDLGMPNKHCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x2747240", Offset = "0x2746240", VA = "0x182747240")]
			internal float JGHKLLBNPEA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x27482F0", Offset = "0x27472F0", VA = "0x1827482F0")]
			internal void MNGIJKJKMJA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x273FF50", Offset = "0x273EF50", VA = "0x18273FF50")]
			internal bool GHDLFOHCLBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x27401B0", Offset = "0x273F1B0", VA = "0x1827401B0")]
			internal bool HCLKCEGBPJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x2748110", Offset = "0x2747110", VA = "0x182748110")]
			internal bool MJOEFBCBCKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x273F200", Offset = "0x273E200", VA = "0x18273F200")]
			internal float DHMKCAHFJPJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x273FA70", Offset = "0x273EA70", VA = "0x18273FA70")]
			internal void FKAIGIGIOCN(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2748980", Offset = "0x2747980", VA = "0x182748980")]
			internal bool OHPHNNJNDBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x2748B50", Offset = "0x2747B50", VA = "0x182748B50")]
			internal bool OMIGCOOEFAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x2747B10", Offset = "0x2746B10", VA = "0x182747B10")]
			internal string LDHIJHHMLOF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2740250", Offset = "0x273F250", VA = "0x182740250")]
			internal void HFELBEOKCOG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x273E8B0", Offset = "0x273D8B0", VA = "0x18273E8B0")]
			internal bool BMPGGJICDIP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2746B60", Offset = "0x2745B60", VA = "0x182746B60")]
			internal bool JAPLEDMEAPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x27483A0", Offset = "0x27473A0", VA = "0x1827483A0")]
			internal bool MNKEGGFPDMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2748BF0", Offset = "0x2747BF0", VA = "0x182748BF0")]
			internal bool OOBNOIPMBDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2748C40", Offset = "0x2747C40", VA = "0x182748C40")]
			internal string OPCEANJMMJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x273FFA0", Offset = "0x273EFA0", VA = "0x18273FFA0")]
			internal void GIPGNLCGNHJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x2746930", Offset = "0x2745930", VA = "0x182746930")]
			internal bool IIFJJDGMECE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x2747F30", Offset = "0x2746F30", VA = "0x182747F30")]
			internal bool MBHNIFOEFNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x273F0A0", Offset = "0x273E0A0", VA = "0x18273F0A0")]
			internal bool DFLIBFJKCOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x273EC10", Offset = "0x273DC10", VA = "0x18273EC10")]
			internal bool CKMKOHPKEGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x2748AB0", Offset = "0x2747AB0", VA = "0x182748AB0")]
			internal string OJEPKBCDDPN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x2747370", Offset = "0x2746370", VA = "0x182747370")]
			internal void JILHBMPFLLD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x273F5B0", Offset = "0x273E5B0", VA = "0x18273F5B0")]
			internal bool EFPNECBMEFE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x2740200", Offset = "0x273F200", VA = "0x182740200")]
			internal bool HEDFBCDOFJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x273EC60", Offset = "0x273DC60", VA = "0x18273EC60")]
			internal bool CKONMJEJBIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x2747100", Offset = "0x2746100", VA = "0x182747100")]
			internal bool JELCBLOODNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x27471A0", Offset = "0x27461A0", VA = "0x1827471A0")]
			internal string JFGMDEJGGLO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x27476C0", Offset = "0x27466C0", VA = "0x1827476C0")]
			internal void KECMLALOGCA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x2740110", Offset = "0x273F110", VA = "0x182740110")]
			internal bool HBLPKMCPFGI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x273EEF0", Offset = "0x273DEF0", VA = "0x18273EEF0")]
			internal bool DCNACDFGHPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x2748E40", Offset = "0x2747E40", VA = "0x182748E40")]
			internal bool PIKDENHNOEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x27400C0", Offset = "0x273F0C0", VA = "0x1827400C0")]
			internal bool GMEOCCGFFGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x2747060", Offset = "0x2746060", VA = "0x182747060")]
			internal string JDFDJNLFLLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x2740510", Offset = "0x273F510", VA = "0x182740510")]
			internal void IDCCCEFKMKJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x273EBC0", Offset = "0x273DBC0", VA = "0x18273EBC0")]
			internal bool CKIBJHGBIJH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x27480C0", Offset = "0x27470C0", VA = "0x1827480C0")]
			internal bool MHKHLMPNKNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x2747780", Offset = "0x2746780", VA = "0x182747780")]
			internal bool KGAGDAHAFLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x273FC20", Offset = "0x273EC20", VA = "0x18273FC20")]
			internal bool FNMMODDMJKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x27479B0", Offset = "0x27469B0", VA = "0x1827479B0")]
			internal string KNJCEBDKCDP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x273E680", Offset = "0x273D680", VA = "0x18273E680")]
			internal void BGCKGKAPIIC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x2748070", Offset = "0x2747070", VA = "0x182748070")]
			internal bool MDHNFFJBNDL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x2747670", Offset = "0x2746670", VA = "0x182747670")]
			internal bool KDKGFGHPCPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x273E3A0", Offset = "0x273D3A0", VA = "0x18273E3A0")]
			internal bool ADPNHHOPBBH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x273F600", Offset = "0x273E600", VA = "0x18273F600")]
			internal bool EGDGMDMPNLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x2747DF0", Offset = "0x2746DF0", VA = "0x182747DF0")]
			internal string LKLPJLFKJID()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x273F2F0", Offset = "0x273E2F0", VA = "0x18273F2F0")]
			internal void DJICAICGKMD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x273F1B0", Offset = "0x273E1B0", VA = "0x18273F1B0")]
			internal bool DHCKPFOAAMC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x273EDB0", Offset = "0x273DDB0", VA = "0x18273EDB0")]
			internal bool CPPPAACGLOK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x27470B0", Offset = "0x27460B0", VA = "0x1827470B0")]
			internal bool JEFIGMDLMGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x2740070", Offset = "0x273F070", VA = "0x182740070")]
			internal bool GKCBHFNCKKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x2740160", Offset = "0x273F160", VA = "0x182740160")]
			internal string HCBHOLOBGJI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x273F400", Offset = "0x273E400", VA = "0x18273F400")]
			internal void DPBFGKKELFB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x2748250", Offset = "0x2747250", VA = "0x182748250")]
			internal bool MMCGECNKPOI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x2747FD0", Offset = "0x2746FD0", VA = "0x182747FD0")]
			internal bool MCFIPMCBPCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x273EEA0", Offset = "0x273DEA0", VA = "0x18273EEA0")]
			internal bool DCBKLJOFOMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x2747580", Offset = "0x2746580", VA = "0x182747580")]
			internal bool KCFMKJOHKBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x273F510", Offset = "0x273E510", VA = "0x18273F510")]
			internal string EELLABLIEAC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x2748F30", Offset = "0x2747F30", VA = "0x182748F30")]
			internal void PLBGAKNEALP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x27478C0", Offset = "0x27468C0", VA = "0x1827478C0")]
			internal bool KKLBOLDDAOH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x273FB20", Offset = "0x273EB20", VA = "0x18273FB20")]
			internal bool FLPDLCBDADB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x2746820", Offset = "0x2745820", VA = "0x182746820")]
			internal bool IGEANBEIPKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x2747B60", Offset = "0x2746B60", VA = "0x182747B60")]
			internal bool LECJDCJPLAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x273E6F0", Offset = "0x273D6F0", VA = "0x18273E6F0")]
			internal string BHBOONBIDPL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x2748FA0", Offset = "0x2747FA0", VA = "0x182748FA0")]
			internal void PLDAMMDOHCN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x2747870", Offset = "0x2746870", VA = "0x182747870")]
			internal bool KJEALLNJKDP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x27403B0", Offset = "0x273F3B0", VA = "0x1827403B0")]
			internal bool HMIHGDEEKNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x2747150", Offset = "0x2746150", VA = "0x182747150")]
			internal bool JFGBGEMPPJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x2747960", Offset = "0x2746960", VA = "0x182747960")]
			internal string KMKCEAEFFMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x273F0F0", Offset = "0x273E0F0", VA = "0x18273F0F0")]
			internal void DGBAKEFFPMN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x273F650", Offset = "0x273E650", VA = "0x18273F650")]
			internal bool EGFDOKKOGIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x273E350", Offset = "0x273D350", VA = "0x18273E350")]
			internal bool ACOOICPEDAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x273F470", Offset = "0x273E470", VA = "0x18273F470")]
			internal bool EEEIACAHCME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x273F6A0", Offset = "0x273E6A0", VA = "0x18273F6A0")]
			internal string EKJGBPONCPN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x2747AA0", Offset = "0x2746AA0", VA = "0x182747AA0")]
			internal void LCJCFCCKAKG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x273F790", Offset = "0x273E790", VA = "0x18273F790")]
			internal bool ELNGJBAMCJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x273E530", Offset = "0x273D530", VA = "0x18273E530")]
			internal bool ANBDOGKJBGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x273E300", Offset = "0x273D300", VA = "0x18273E300")]
			internal bool ABDJODMEODD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x273F360", Offset = "0x273E360", VA = "0x18273F360")]
			internal string DJMMJJILEIJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x2746870", Offset = "0x2745870", VA = "0x182746870")]
			internal void IGOFHGIJHDF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x273E630", Offset = "0x273D630", VA = "0x18273E630")]
			internal bool BBEFCDIDGHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x273EE50", Offset = "0x273DE50", VA = "0x18273EE50")]
			internal bool DCAFBCGPPNJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x273F6F0", Offset = "0x273E6F0", VA = "0x18273F6F0")]
			internal float EKONCIPJIGD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x273FCC0", Offset = "0x273ECC0", VA = "0x18273FCC0")]
			internal void FPPJPMKKDIP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x273E740", Offset = "0x273D740", VA = "0x18273E740")]
			internal bool BHOPOEIOMAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x273F7E0", Offset = "0x273E7E0", VA = "0x18273F7E0")]
			internal bool EMAPCLILOFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x2747D00", Offset = "0x2746D00", VA = "0x182747D00")]
			internal bool LGOBGOADFFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x273FB70", Offset = "0x273EB70", VA = "0x18273FB70")]
			internal int FMJDBPHLIJC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x2748860", Offset = "0x2747860", VA = "0x182748860")]
			internal void ODBPKKLGLLF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x2740400", Offset = "0x273F400", VA = "0x182740400")]
			internal bool IBHIPNBCAFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x2747320", Offset = "0x2746320", VA = "0x182747320")]
			internal bool JHMDPKKCEAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x2748D40", Offset = "0x2747D40", VA = "0x182748D40")]
			internal bool PFKDECJFMGG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class EJGLIOEPDAL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public JHKHDANIILP CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public EJGLIOEPDAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x27576E0", Offset = "0x27566E0", VA = "0x1827576E0")]
			internal void CIMALGBPGPM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class MFDBKKAFLGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public MFDBKKAFLGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x276CED0", Offset = "0x276BED0", VA = "0x18276CED0")]
			internal bool BBODKEOPIIE(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private readonly OMPJEELBIEL INBDDKMBHHM;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x274FCD0", Offset = "0x274ECD0", VA = "0x18274FCD0")]
		public NBMMDOFDBPD(CHIEBOEDIPK IOIBNPDJCNE, OHNOHCLIODK GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x274DF00", Offset = "0x274CF00", VA = "0x18274DF00", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class NFNBLEBHBGJ : FNEGPADGNAD<AFPLICFBEMD>
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class LGFHDPJIFJM
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006F")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public LGFHDPJIFJM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x2770FA0", Offset = "0x276FFA0", VA = "0x182770FA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public NFNBLEBHBGJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public LGFHDPJIFJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x276C8F0", Offset = "0x276B8F0", VA = "0x18276C8F0")]
			internal string PMOJIBLCDBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x276C940", Offset = "0x276B940", VA = "0x18276C940")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void POFMCLKDAFO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x276C810", Offset = "0x276B810", VA = "0x18276C810")]
			internal int IGNBPBENOMC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x276C860", Offset = "0x276B860", VA = "0x18276C860")]
			internal void NOAGHDJPGKH(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x10AE210", Offset = "0x10AD210", VA = "0x1810AE210", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x276DF90", Offset = "0x276CF90", VA = "0x18276DF90")]
		public NFNBLEBHBGJ(CHIEBOEDIPK IOIBNPDJCNE, AFPLICFBEMD HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x276DC30", Offset = "0x276CC30", VA = "0x18276DC30", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class KBKDCMBMLEH : FNEGPADGNAD<KBCHKNEHNAA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class NFOCOPFNBNB
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000072")]
			private struct <<BuildConfigMenuInternal>b__1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				public NFOCOPFNBNB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x2770C60", Offset = "0x276FC60", VA = "0x182770C60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000073")]
			private struct <<BuildConfigMenuInternal>b__5>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000189")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400018A")]
				public NFOCOPFNBNB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400018B")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400018C")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400018D")]
				private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x27712B0", Offset = "0x27702B0", VA = "0x1827712B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public KBKDCMBMLEH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public NFOCOPFNBNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x276E8A0", Offset = "0x276D8A0", VA = "0x18276E8A0")]
			internal string PMOJIBLCDBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x276E940", Offset = "0x276D940", VA = "0x18276E940")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void POFMCLKDAFO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x276E4B0", Offset = "0x276D4B0", VA = "0x18276E4B0")]
			internal int IGNBPBENOMC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x276E6F0", Offset = "0x276D6F0", VA = "0x18276E6F0")]
			internal void NOAGHDJPGKH(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x276E780", Offset = "0x276D780", VA = "0x18276E780")]
			internal string OABKELGAFGC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x276E7D0", Offset = "0x276D7D0", VA = "0x18276E7D0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void ONMGGGFMIMJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x276E3D0", Offset = "0x276D3D0", VA = "0x18276E3D0")]
			internal bool IEBNCJCHKNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x276E340", Offset = "0x276D340", VA = "0x18276E340")]
			internal void EGEKFLONCNL(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x276E6A0", Offset = "0x276D6A0", VA = "0x18276E6A0")]
			internal bool NNMDDOCMLBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x276E500", Offset = "0x276D500", VA = "0x18276E500")]
			internal void JPFEDGBCBJK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x276E8F0", Offset = "0x276D8F0", VA = "0x18276E8F0")]
			internal float PNCCNAEJOIK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x276E420", Offset = "0x276D420", VA = "0x18276E420")]
			internal void IFOPBOHCJEJ(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x276E2E0", Offset = "0x276D2E0", VA = "0x18276E2E0")]
			internal int AOACIPBKBMC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x276E590", Offset = "0x276D590", VA = "0x18276E590")]
			internal void LECHGFPGJPC(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x276E630", Offset = "0x276D630", VA = "0x18276E630")]
			internal bool MLKHAPMBMMP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x10AE210", Offset = "0x10AD210", VA = "0x1810AE210", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x276B9D0", Offset = "0x276A9D0", VA = "0x18276B9D0")]
		public KBKDCMBMLEH(CHIEBOEDIPK IOIBNPDJCNE, KBCHKNEHNAA GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x276AF90", Offset = "0x2769F90", VA = "0x18276AF90", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public sealed class PCDIBCFBCNH : FNEGPADGNAD<FIEHHNCKPOL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class DFAAFEJPDGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public PCDIBCFBCNH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public DFAAFEJPDGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x27563B0", Offset = "0x27553B0", VA = "0x1827563B0")]
			internal Dictionary<string, FDEEMEDLPLM> PMOJIBLCDBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x2756450", Offset = "0x2755450", VA = "0x182756450")]
			internal int POFMCLKDAFO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x2756200", Offset = "0x2755200", VA = "0x182756200")]
			internal void IGNBPBENOMC(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x2756330", Offset = "0x2755330", VA = "0x182756330")]
			internal bool NOAGHDJPGKH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x10AE210", Offset = "0x10AD210", VA = "0x1810AE210", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x276FAA0", Offset = "0x276EAA0", VA = "0x18276FAA0")]
		public PCDIBCFBCNH(CHIEBOEDIPK IOIBNPDJCNE, FIEHHNCKPOL HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x276F7D0", Offset = "0x276E7D0", VA = "0x18276F7D0", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public sealed class LPBPJLKNJON : FNEGPADGNAD<DGDDEEHKDLD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class ODOEJGANNGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public LPBPJLKNJON <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public ODOEJGANNGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x276F540", Offset = "0x276E540", VA = "0x18276F540")]
			internal void PMOJIBLCDBE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x10AE210", Offset = "0x10AD210", VA = "0x1810AE210", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x276CD80", Offset = "0x276BD80", VA = "0x18276CD80")]
		public LPBPJLKNJON(CHIEBOEDIPK IOIBNPDJCNE, DGDDEEHKDLD HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x276CC00", Offset = "0x276BC00", VA = "0x18276CC00", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class GLMOJONJFAE<TNode> : OBDPADHLGOK<TNode> where TNode : notnull, LFNDEJJNPJO
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool KJJGFKDOJKG
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override LHKHFOBECGD? MPNBODDFADA
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x4A8A4D0", Offset = "0x4A894D0", VA = "0x184A8A4D0", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override bool AHNFHPOEEOH
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x4A8A590", Offset = "0x4A89590", VA = "0x184A8A590", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xD908B0", Offset = "0xD8F8B0", VA = "0x180D908B0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x4A8A550", Offset = "0x4A89550", VA = "0x184A8A550")]
		public GLMOJONJFAE(CHIEBOEDIPK IOIBNPDJCNE, TNode GOJJJBGJPAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class BNMFDMDMDNG : GLMOJONJFAE<MPCMGDEBFJF>
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class CADLGFIIACM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public BNMFDMDMDNG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public CADLGFIIACM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2755900", Offset = "0x2754900", VA = "0x182755900")]
			internal object PMOJIBLCDBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x2755970", Offset = "0x2754970", VA = "0x182755970")]
			internal void POFMCLKDAFO(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2755810", Offset = "0x2754810", VA = "0x182755810")]
			internal void IGNBPBENOMC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private static object[]? NPIFABICPBE;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x2755350", Offset = "0x2754350", VA = "0x182755350")]
		public BNMFDMDMDNG(CHIEBOEDIPK IOIBNPDJCNE, MPCMGDEBFJF GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x2754DA0", Offset = "0x2753DA0", VA = "0x182754DA0", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class ALDIKEOLCNG : FNEGPADGNAD<MAIGKIHJJPI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xC59900", Offset = "0xC58900", VA = "0x180C59900", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2754660", Offset = "0x2753660", VA = "0x182754660")]
		public ALDIKEOLCNG(CHIEBOEDIPK IOIBNPDJCNE, MAIGKIHJJPI GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private sealed class FGCENHIDMKL : FNEGPADGNAD<AKDPEHEBLNE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xBCAD30", Offset = "0xBC9D30", VA = "0x180BCAD30", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x2758A10", Offset = "0x2757A10", VA = "0x182758A10")]
		public FGCENHIDMKL(CHIEBOEDIPK IOIBNPDJCNE, AKDPEHEBLNE GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "126")]
		protected override bool EIOFANCGDJC(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class DGLBFJGOPCJ : FNEGPADGNAD<BOAJFIAJAGG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xB83650", Offset = "0xB82650", VA = "0x180B83650", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool PBCBCPMKOGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x2756510", Offset = "0x2755510", VA = "0x182756510", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		protected override bool GIPCIPECMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x27564A0", Offset = "0x27554A0", VA = "0x1827564A0")]
		public DGLBFJGOPCJ(CHIEBOEDIPK IOIBNPDJCNE, BOAJFIAJAGG GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class ELIOLFAAEHN : FNEGPADGNAD<PFDJIBKGAOI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0xBCB9B0", Offset = "0xBCA9B0", VA = "0x180BCB9B0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override bool PBCBCPMKOGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x2758320", Offset = "0x2757320", VA = "0x182758320", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected override bool GIPCIPECMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x27582B0", Offset = "0x27572B0", VA = "0x1827582B0")]
		public ELIOLFAAEHN(CHIEBOEDIPK IOIBNPDJCNE, PFDJIBKGAOI GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class FAHGAJMCPDB : OGBFMPPEGJC<MLJMLAKGDLM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class LMGBCKFAICJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public FAHGAJMCPDB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public LMGBCKFAICJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x276CB80", Offset = "0x276BB80", VA = "0x18276CB80")]
			internal float JGLMENIGIII()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x276CAE0", Offset = "0x276BAE0", VA = "0x18276CAE0")]
			internal void EKEOADEHHLG(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x27585F0", Offset = "0x27575F0", VA = "0x1827585F0")]
		public FAHGAJMCPDB(CHIEBOEDIPK IOIBNPDJCNE, MLJMLAKGDLM HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x2758370", Offset = "0x2757370", VA = "0x182758370", Slot = "140")]
		protected override void BLDBLIFKMKL(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class KBHGFFNALAI : FNEGPADGNAD<BFDACMGFOEJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class JBDMGAKPEED
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public KBHGFFNALAI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public JBDMGAKPEED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x27645B0", Offset = "0x27635B0", VA = "0x1827645B0")]
			internal bool PMOJIBLCDBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x2764600", Offset = "0x2763600", VA = "0x182764600")]
			internal void POFMCLKDAFO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x276AF20", Offset = "0x2769F20", VA = "0x18276AF20")]
		public KBHGFFNALAI(CHIEBOEDIPK IOIBNPDJCNE, BFDACMGFOEJ HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x276AC70", Offset = "0x2769C70", VA = "0x18276AC70", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class ODJEJADKCLE : FNEGPADGNAD<PIICCOEOBBP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class NBENDJAPKDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public ODJEJADKCLE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public NBENDJAPKDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x276D840", Offset = "0x276C840", VA = "0x18276D840")]
			internal object PMOJIBLCDBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x276D410", Offset = "0x276C410", VA = "0x18276D410")]
			internal bool EGEKFLONCNL(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x276D970", Offset = "0x276C970", VA = "0x18276D970")]
			internal void POFMCLKDAFO(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x276D5C0", Offset = "0x276C5C0", VA = "0x18276D5C0")]
			internal string IGNBPBENOMC(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x276D730", Offset = "0x276C730", VA = "0x18276D730")]
			internal IReadOnlyList<object> NOAGHDJPGKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x276D780", Offset = "0x276C780", VA = "0x18276D780")]
			internal bool OABKELGAFGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x276D7F0", Offset = "0x276C7F0", VA = "0x18276D7F0")]
			internal bool ONMGGGFMIMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x276D490", Offset = "0x276C490", VA = "0x18276D490")]
			internal void IEBNCJCHKNG(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x276F4D0", Offset = "0x276E4D0", VA = "0x18276F4D0")]
		public ODJEJADKCLE(CHIEBOEDIPK IOIBNPDJCNE, PIICCOEOBBP HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x276ECC0", Offset = "0x276DCC0", VA = "0x18276ECC0", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class MPHLEJMFDHK : NPCCNPOFPCI<EJCGHOGLGPP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0xD7F130", Offset = "0xD7E130", VA = "0x180D7F130", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x276D3B0", Offset = "0x276C3B0", VA = "0x18276D3B0")]
		public MPHLEJMFDHK(CHIEBOEDIPK IOIBNPDJCNE, EJCGHOGLGPP GOJJJBGJPAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class BMJLNJEEIND : OGBFMPPEGJC<ODMJFHHFCPD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class MPHILEHALJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public BMJLNJEEIND <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public MPHILEHALJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x276D330", Offset = "0x276C330", VA = "0x18276D330")]
			internal int JGLMENIGIII()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x276D290", Offset = "0x276C290", VA = "0x18276D290")]
			internal void EKEOADEHHLG(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2754D40", Offset = "0x2753D40", VA = "0x182754D40")]
		public BMJLNJEEIND(CHIEBOEDIPK IOIBNPDJCNE, ODMJFHHFCPD HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2754AB0", Offset = "0x2753AB0", VA = "0x182754AB0", Slot = "140")]
		protected override void BLDBLIFKMKL(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class KAGJBLIDLOJ : FNEGPADGNAD<ENCPOFPCDLE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class MDJALHEABLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public KAGJBLIDLOJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public MDJALHEABLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x276CDF0", Offset = "0x276BDF0", VA = "0x18276CDF0")]
			internal bool PMOJIBLCDBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x276CE40", Offset = "0x276BE40", VA = "0x18276CE40")]
			internal void POFMCLKDAFO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x2765AA0", Offset = "0x2764AA0", VA = "0x182765AA0")]
		public KAGJBLIDLOJ(CHIEBOEDIPK IOIBNPDJCNE, ENCPOFPCDLE HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x27658C0", Offset = "0x27648C0", VA = "0x1827658C0", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class PLODEMAGGJI : FNEGPADGNAD<ADEHFDAHCIJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		[CompilerGenerated]
		private sealed class GKFDJBCFKJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public PLODEMAGGJI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public GKFDJBCFKJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x27635B0", Offset = "0x27625B0", VA = "0x1827635B0")]
			internal bool PMOJIBLCDBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x2763600", Offset = "0x2762600", VA = "0x182763600")]
			internal void POFMCLKDAFO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x2770520", Offset = "0x276F520", VA = "0x182770520")]
		public PLODEMAGGJI(CHIEBOEDIPK IOIBNPDJCNE, ADEHFDAHCIJ HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2770340", Offset = "0x276F340", VA = "0x182770340", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class NFNNDHBPIOD : FNEGPADGNAD<APFOIGIFMBP>
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class IIMKKANEDAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public NFNNDHBPIOD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public IIMKKANEDAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x27644D0", Offset = "0x27634D0", VA = "0x1827644D0")]
			internal int PMOJIBLCDBE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x2764520", Offset = "0x2763520", VA = "0x182764520")]
			internal void POFMCLKDAFO(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x276E270", Offset = "0x276D270", VA = "0x18276E270")]
		public NFNNDHBPIOD(CHIEBOEDIPK IOIBNPDJCNE, APFOIGIFMBP HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x276E000", Offset = "0x276D000", VA = "0x18276E000", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public sealed class KLDMJLEPECE : CAMHBDKBKIA<BHJKPCBFIGC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public override AEKGKKLKPIL EPPODOEMAIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0xBDE1B0", Offset = "0xBDD1B0", VA = "0x180BDE1B0", Slot = "140")]
			get
			{
				return default(AEKGKKLKPIL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x276BAD0", Offset = "0x276AAD0", VA = "0x18276BAD0")]
		public KLDMJLEPECE(CHIEBOEDIPK IOIBNPDJCNE, BHJKPCBFIGC HCAMONPFOJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class KIAABMIFJGK : FNEGPADGNAD<GDCCFCAPGMP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x276BA60", Offset = "0x276AA60", VA = "0x18276BA60")]
		public KIAABMIFJGK(CHIEBOEDIPK IOIBNPDJCNE, GDCCFCAPGMP GOJJJBGJPAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public abstract class FNEGPADGNAD<TNode> : CBDBLPHCHLP, IDisposable where TNode : notnull, GDCCFCAPGMP
	{
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private sealed class NIBLBMINLLF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public FNEGPADGNAD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public CHIEBOEDIPK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public NIBLBMINLLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x53CA540", Offset = "0x53C9540", VA = "0x1853CA540")]
			internal KAMDBIDHFJB JGDCEDMCENF(BAANAFJPLNG portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private struct MJICOBAAHCB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public FNEGPADGNAD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x533C6C0", Offset = "0x533B6C0", VA = "0x18533C6C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private struct AECMFPIFCLO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public FNEGPADGNAD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public HOCBFPONHJI? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public GKMDHBAFLMJ? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x4A25130", Offset = "0x4A24130", VA = "0x184A25130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x4A253E0", Offset = "0x4A243E0", VA = "0x184A253E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class DLAHLDCIGLF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000095")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public DLAHLDCIGLF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60003C6")]
				[Cpp2IlInjected.Address(RVA = "0x402F4F0", Offset = "0x402E4F0", VA = "0x18402F4F0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C7")]
				[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public FNEGPADGNAD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public KIEOOBCGILC configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public DLAHLDCIGLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			internal string BKBNGNIBHDI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
			internal void LCKCNAGKCPA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x6A659E0", Offset = "0x6A649E0", VA = "0x186A659E0")]
			[AsyncStateMachine(typeof(FNEGPADGNAD<>.DLAHLDCIGLF.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void PMCCKFGCILC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private sealed class OGLLNMKJNJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public OGLLNMKJNJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x5517110", Offset = "0x5516110", VA = "0x185517110")]
			internal bool DCHOHHHCKKG(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x55171F0", Offset = "0x55161F0", VA = "0x1855171F0")]
			internal bool PMDGAEIGFBL(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private struct PKELKMKEMOG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public FNEGPADGNAD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x5610430", Offset = "0x560F430", VA = "0x185610430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x56107C0", Offset = "0x560F7C0", VA = "0x1856107C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private readonly CHIEBOEDIPK FBKDHJDLAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private readonly bool IKAHDLKDAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private DAABAMGFIFM<MECIAIKJJDL, KAMDBIDHFJB> PCAPKGJHNBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private DAABAMGFIFM<MECIAIKJJDL, LCBAJMHOMEH> OKKFFGDMCHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private List<Action> CGMEMDIEPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[CompilerGenerated]
		private Action<EDBALDILLBK<MECIAIKJJDL>>? HFBOGMLDHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[CompilerGenerated]
		private Action<EDBALDILLBK<MECIAIKJJDL>, LCBAJMHOMEH>? LPFGNGPBFJF;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected BOIDOHDBGAH IKMBEHHBIHH
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x4990E10", Offset = "0x498FE10", VA = "0x184990E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected KPOHEEDLBMM INMJMNDONMN
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x498F970", Offset = "0x498E970", VA = "0x18498F970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected TNode KFNFIFHNECA
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public IGLPJBODKFE<OGFNHMCGFPC> IBPEKFHGKOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x134D260", Offset = "0x134C260", VA = "0x18134D260", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(IGLPJBODKFE<OGFNHMCGFPC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public EDBALDILLBK<APOJALOJJAE> JNNEAADALHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x4993B60", Offset = "0x4992B60", VA = "0x184993B60", Slot = "6")]
			get
			{
				return default(EDBALDILLBK<APOJALOJJAE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public object LAAONLPPGKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x4546C90", Offset = "0x4545C90", VA = "0x184546C90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual bool DEIOCHPOGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public int FIGDBNMNPBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x49937B0", Offset = "0x49927B0", VA = "0x1849937B0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public GBMHCNCGHKO DJKDFMEBLMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x4993750", Offset = "0x4992750", VA = "0x184993750", Slot = "10")]
			get
			{
				return default(GBMHCNCGHKO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string JIAJMGMPCHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x4993D60", Offset = "0x4992D60", VA = "0x184993D60", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual bool GIPCIPECMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public EDBALDILLBK<IGKACGMLLNC> KEPANGGCHJK
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xE31160", Offset = "0xE30160", VA = "0x180E31160", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(EDBALDILLBK<IGKACGMLLNC>);
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xE45C50", Offset = "0xE44C50", VA = "0x180E45C50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool HACOJECEIDD
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool PBCBCPMKOGB
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual bool KJJGFKDOJKG
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual DIBHJHIJCOI EHMCAFAODKF
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xF63780", Offset = "0xF62780", VA = "0x180F63780", Slot = "108")]
			get
			{
				return default(DIBHJHIJCOI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HEKEFGNMDHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x4993460", Offset = "0x4992460", VA = "0x184993460", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool PBEDEICOIBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x49934D0", Offset = "0x49924D0", VA = "0x1849934D0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool EAEGMAGNJHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x4993540", Offset = "0x4992540", VA = "0x184993540", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int OABGDBHGKHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x4993B10", Offset = "0x4992B10", VA = "0x184993B10", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool ECEJAOOAKDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x4993930", Offset = "0x4992930", VA = "0x184993930", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public DDJFHGBJPBO IBILGABBPNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x4993670", Offset = "0x4992670", VA = "0x184993670", Slot = "23")]
			get
			{
				return default(DDJFHGBJPBO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool JCIMDBLFIHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x4993600", Offset = "0x4992600", VA = "0x184993600", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool CNIMKFOEKNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xF299C0", Offset = "0xF289C0", VA = "0x180F299C0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x12F9350", Offset = "0x12F8350", VA = "0x1812F9350")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool DNJFHPFNIBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool GLGECKLAFLB
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x49935B0", Offset = "0x49925B0", VA = "0x1849935B0", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public bool CIODJOPFHJP
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x4993860", Offset = "0x4992860", VA = "0x184993860", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public HOCBFPONHJI HOKNMKCMKBD
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x4993A50", Offset = "0x4992A50", VA = "0x184993A50", Slot = "29")]
			get
			{
				return default(HOCBFPONHJI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public GKMDHBAFLMJ OIMDLFMMKJI
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x4993AB0", Offset = "0x4992AB0", VA = "0x184993AB0", Slot = "31")]
			get
			{
				return default(GKMDHBAFLMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual bool CLEKMDDFLLL
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public virtual MEJBGBIMNJP? PONKCEOENOM
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "123")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual LHKHFOBECGD? MPNBODDFADA
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual IEnumerable<IGLPJBODKFE<ALEKBGLLPHJ>>? BGLFMODOKND
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool CKIOHCJBNMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x49936E0", Offset = "0x49926E0", VA = "0x1849936E0", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public IGLPJBODKFE<BIEIIMCKPHN> CHOAMIELENC
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x4993990", Offset = "0x4992990", VA = "0x184993990", Slot = "63")]
			get
			{
				return default(IGLPJBODKFE<BIEIIMCKPHN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public EDBALDILLBK<BIEIIMCKPHN> CNMEJNNBCFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x4993800", Offset = "0x4992800", VA = "0x184993800", Slot = "57")]
			get
			{
				return default(EDBALDILLBK<BIEIIMCKPHN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public virtual bool PCNJMJHNNHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public virtual EDBALDILLBK<BIEIIMCKPHN>? EIKAIJOGKJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public virtual bool AHNFHPOEEOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool GLNMCHFEANJ
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x49938C0", Offset = "0x49928C0", VA = "0x1849938C0", Slot = "62")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x9F9180", Offset = "0x9F8180", VA = "0x1809F9180", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x9F9080", Offset = "0x9F8080", VA = "0x1809F9080")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string JENOGKFLHBM
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x9F90F0", Offset = "0x9F80F0", VA = "0x1809F90F0", Slot = "67")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x9F9010", Offset = "0x9F8010", VA = "0x1809F9010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public EDBALDILLBK<ALEKBGLLPHJ> IIODNFIGJOE
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x4993BE0", Offset = "0x4992BE0", VA = "0x184993BE0", Slot = "64")]
			get
			{
				return default(EDBALDILLBK<ALEKBGLLPHJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public IGLPJBODKFE<ALEKBGLLPHJ> AEFADELMNOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x49939F0", Offset = "0x49929F0", VA = "0x1849939F0", Slot = "65")]
			get
			{
				return default(IGLPJBODKFE<ALEKBGLLPHJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public IGLPJBODKFE<ALEKBGLLPHJ>? CGIKJENKLLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x4993C40", Offset = "0x4992C40", VA = "0x184993C40", Slot = "132")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public KOLDGJODODL<MECIAIKJJDL, LCBAJMHOMEH> DJIFCIGFLGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x4993D20", Offset = "0x4992D20", VA = "0x184993D20", Slot = "68")]
			get
			{
				return default(KOLDGJODODL<MECIAIKJJDL, LCBAJMHOMEH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public virtual EDBALDILLBK<MECIAIKJJDL>? NEHDIPFJKOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public virtual bool HFIAGEGNIAP
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public virtual bool IGKIADCDCPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "137")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action IJMGPLFFILC
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x4992500", Offset = "0x4991500", VA = "0x184992500", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x4990A10", Offset = "0x498FA10", VA = "0x184990A10", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event LNFJOIOMGPN EKNNJGIHMBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x49905D0", Offset = "0x498F5D0", VA = "0x1849905D0", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x4991F80", Offset = "0x4990F80", VA = "0x184991F80", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event KAOEKOOECFA KBPPNEAFIDH
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x49906E0", Offset = "0x498F6E0", VA = "0x1849906E0", Slot = "42")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x4992D90", Offset = "0x4991D90", VA = "0x184992D90", Slot = "43")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action GHBBKKJBBCP
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x498FE70", Offset = "0x498EE70", VA = "0x18498FE70", Slot = "44")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x4992890", Offset = "0x4991890", VA = "0x184992890", Slot = "45")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action IIJNBHAPDAD
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x4992AF0", Offset = "0x4991AF0", VA = "0x184992AF0", Slot = "46")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x49910E0", Offset = "0x49900E0", VA = "0x1849910E0", Slot = "47")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<EDBALDILLBK<MECIAIKJJDL>, LCBAJMHOMEH> GHALFBPJHCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x498EB10", Offset = "0x498DB10", VA = "0x18498EB10", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x4991EC0", Offset = "0x4990EC0", VA = "0x184991EC0", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<EDBALDILLBK<MECIAIKJJDL>, LCBAJMHOMEH> HHKOBCNAIJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x4992440", Offset = "0x4991440", VA = "0x184992440", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x4990510", Offset = "0x498F510", VA = "0x184990510", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<EDBALDILLBK<MECIAIKJJDL>> MABHKDOOCNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x4990E70", Offset = "0x498FE70", VA = "0x184990E70", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x498FA60", Offset = "0x498EA60", VA = "0x18498FA60", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<MECIAIKJJDL>> ALEENNJIBGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x498F8B0", Offset = "0x498E8B0", VA = "0x18498F8B0", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x4990780", Offset = "0x498F780", VA = "0x184990780", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<EDBALDILLBK<MECIAIKJJDL>, LCBAJMHOMEH> FGDABIDOHOI
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x498FB20", Offset = "0x498EB20", VA = "0x18498FB20", Slot = "78")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x4990F30", Offset = "0x498FF30", VA = "0x184990F30", Slot = "79")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<MECIAIKJJDL>> PIHADOKDHNF
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x4991CE0", Offset = "0x4990CE0", VA = "0x184991CE0", Slot = "80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x4991C20", Offset = "0x4990C20", VA = "0x184991C20", Slot = "81")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x4992E70", Offset = "0x4991E70", VA = "0x184992E70")]
		[HCCKFFEHNEM("Need to handle `Name` better.")]
		[HCCKFFEHNEM("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected FNEGPADGNAD(CHIEBOEDIPK IOIBNPDJCNE, TNode GOJJJBGJPAM, bool FPPJBNBMHCF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x498F600", Offset = "0x498E600", VA = "0x18498F600", Slot = "100")]
		protected virtual void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x498FF40", Offset = "0x498EF40", VA = "0x18498FF40", Slot = "101")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x4990840", Offset = "0x498F840", VA = "0x184990840", Slot = "9")]
		[AsyncStateMachine(typeof(FNEGPADGNAD<>.MJICOBAAHCB))]
		public void GPLPOAMHICN(int EHDJELKNEGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x498EBD0", Offset = "0x498DBD0", VA = "0x18498EBD0")]
		public bool AGKGIONFDCG([In] HOCBFPONHJI OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x4990670", Offset = "0x498F670", VA = "0x184990670")]
		public bool FNCDDIOOAJL([In] GKMDHBAFLMJ OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x498FC50", Offset = "0x498EC50", VA = "0x18498FC50", Slot = "33")]
		public void DKLNPPECIOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x4992BB0", Offset = "0x4991BB0", VA = "0x184992BB0", Slot = "34")]
		[AsyncStateMachine(typeof(FNEGPADGNAD<>.AECMFPIFCLO))]
		public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> ONDIIHJNKEJ(HOCBFPONHJI? IHMLAPGNLCC, GKMDHBAFLMJ? JHMNNKLOODA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "111")]
		public virtual void DPJNCOAHMEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "112")]
		public virtual void AMINAPIHPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "113")]
		public virtual void MOHEOJBDAHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xF03C00", Offset = "0xF02C00", VA = "0x180F03C00")]
		protected void PNIEEIGODBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xF5E970", Offset = "0xF5D970", VA = "0x180F5E970")]
		protected void FJLKHHLNFFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x21443C0", Offset = "0x21433C0", VA = "0x1821443C0")]
		private void MGAMHGEPDFM([In] GKMDHBAFLMJ OOBEGCNALKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x49925A0", Offset = "0x49915A0", VA = "0x1849925A0", Slot = "114")]
		public virtual Task<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> NLJCJIFCEPE(string NFHOBPDKIPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x49908F0", Offset = "0x498F8F0", VA = "0x1849908F0", Slot = "115")]
		public virtual Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> HBOMGBAHBHB(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "116")]
		public virtual void DOMLNJILBBI(EDBALDILLBK<MECIAIKJJDL> GOBLBPCAJLF, EDBALDILLBK<MECIAIKJJDL> CIGKLILMOBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x49914F0", Offset = "0x49904F0", VA = "0x1849914F0", Slot = "117")]
		public virtual IEnumerable<AFPLFKDKJPC> LDELJOIKHDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x4992D00", Offset = "0x4991D00", VA = "0x184992D00", Slot = "118")]
		public HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC> OPKPHBIOMGM(string NKGPMKCBABE)
		{
			return default(HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x4990390", Offset = "0x498F390", VA = "0x184990390", Slot = "48")]
		public bool FGOOLEAEIJD([Out] Guid MFIFMINLAOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x4991230", Offset = "0x4990230", VA = "0x184991230")]
		public bool LANIFLKJJLB([In] Guid KJCOKJBCCGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "119")]
		public virtual void KGPJOLOPJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "120")]
		public virtual void PAPPEGNGKNO(bool MNCKABJBEAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "121")]
		public virtual GDJKOKGENEI BPMDOHDDCAH([In] DABGAEBMAMH FKAPNLOLMHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x4990BB0", Offset = "0x498FBB0", VA = "0x184990BB0")]
		protected void JKGELNPMHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x4990350", Offset = "0x498F350", VA = "0x184990350", Slot = "126")]
		protected virtual bool EIOFANCGDJC(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x49904E0", Offset = "0x498F4E0", VA = "0x1849904E0", Slot = "89")]
		public bool FJFNPLHBBPD(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "127")]
		protected virtual bool BLLOHDPAIJK(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "134")]
		protected virtual void GKHEOHIHOAF(KIEOOBCGILC LMAAGDPIAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x498EC40", Offset = "0x498DC40", VA = "0x18498EC40")]
		protected void AGNADLPHKEG(KIEOOBCGILC PEEMKKKLLMO, Func<string> LANFPAMJOEN, Action<string> CLDNNLHGKBG, string OAHHBMJFHPN, string AHNDNFIBLJP, string IKNGLHOBDCH, BNNAKOGIDLO NFKBGBCCHAD, LOHMEEOFGPN FCELLNGEKLF, Func<string, bool> DMBDJKJHGMD, string PAOOMNDAKKB, Func<string, bool> JOMCHNAJBAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x4991930", Offset = "0x4990930", VA = "0x184991930")]
		protected void LFGNIGHADEO(KIEOOBCGILC PEEMKKKLLMO, Func<string> LANFPAMJOEN, Action<string> CLDNNLHGKBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x4992670", Offset = "0x4991670", VA = "0x184992670", Slot = "135")]
		protected virtual void NOOGFLKBKII(KIEOOBCGILC PEEMKKKLLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x49909C0", Offset = "0x498F9C0", VA = "0x1849909C0", Slot = "83")]
		public void HMHNDPEKCAL(KIEOOBCGILC PEEMKKKLLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x4990AB0", Offset = "0x498FAB0", VA = "0x184990AB0", Slot = "84")]
		public FGKPLMFNBOC IMLNFPJBFLH()
		{
			return default(FGKPLMFNBOC);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "138")]
		public virtual bool CJLAALIHDHE(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x1F36C70", Offset = "0x1F35C70", VA = "0x181F36C70")]
		private void ELHKKMCKJPL([In] HOCBFPONHJI EPCLGOKLIPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x498E9B0", Offset = "0x498D9B0", VA = "0x18498E9B0")]
		private void ABFKHHJAKII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x4992E30", Offset = "0x4991E30", VA = "0x184992E30", Slot = "90")]
		private void POOIEHIEPCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x498F040", Offset = "0x498E040", VA = "0x18498F040", Slot = "92")]
		private void AICABCKONJA(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x10A3F70", Offset = "0x10A2F70", VA = "0x1810A3F70", Slot = "94")]
		private void BBINAMCKGGK(EDBALDILLBK<MECIAIKJJDL> HJPLNJNIFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x4992930", Offset = "0x4991930", VA = "0x184992930", Slot = "96")]
		private void OJHGLMFDOJC(EDBALDILLBK<MECIAIKJJDL> HJPLNJNIFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x4991580", Offset = "0x4990580", VA = "0x184991580", Slot = "97")]
		private void LFBBKGAGOKE(EDBALDILLBK<MECIAIKJJDL> GOBLBPCAJLF, EDBALDILLBK<MECIAIKJJDL> CIGKLILMOBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x10A4B70", Offset = "0x10A3B70", VA = "0x1810A4B70", Slot = "98")]
		private void BKIIENPLLHF(EDBALDILLBK<MECIAIKJJDL> GOBLBPCAJLF, EDBALDILLBK<MECIAIKJJDL> CIGKLILMOBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x4992B90", Offset = "0x4991B90", VA = "0x184992B90", Slot = "91")]
		private void OMFKJNGMKOD(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x4992020", Offset = "0x4991020", VA = "0x184992020", Slot = "93")]
		private void NJDNMBKIPNC(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x4990DA0", Offset = "0x498FDA0", VA = "0x184990DA0", Slot = "95")]
		private void JOMGANLAEEL(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x4991DA0", Offset = "0x4990DA0", VA = "0x184991DA0", Slot = "139")]
		[AsyncStateMachine(typeof(FNEGPADGNAD<>.PKELKMKEMOG))]
		public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> NCNIAMHJFOC(string NKGPMKCBABE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x498FBE0", Offset = "0x498EBE0", VA = "0x18498FBE0", Slot = "55")]
		private void DKFGGBFHHDD(object CDJPOMBFFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x4991070", Offset = "0x4990070", VA = "0x184991070", Slot = "56")]
		private void KLMPBFOFAHI(object CDJPOMBFFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x494F9A0", Offset = "0x494E9A0", VA = "0x18494F9A0", Slot = "30")]
		private bool DGOEBMGEOIM([In] HOCBFPONHJI OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x4991030", Offset = "0x4990030", VA = "0x184991030", Slot = "32")]
		private bool KLJHEJMEPMN([In] GKMDHBAFLMJ OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x49928F0", Offset = "0x49918F0", VA = "0x1849928F0", Slot = "49")]
		private bool OCCBBBPLIJK([In] Guid KJCOKJBCCGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x4990FF0", Offset = "0x498FFF0", VA = "0x184990FF0")]
		[CompilerGenerated]
		private string KKEHDNIABKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x4991180", Offset = "0x4990180", VA = "0x184991180")]
		[CompilerGenerated]
		private void KNDGIHINCLI(string NFHOBPDKIPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public sealed class NEHDEDPNPDN : NPCCNPOFPCI<DJAFPBFODNL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0xD7A330", Offset = "0xD79330", VA = "0x180D7A330", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x276DBD0", Offset = "0x276CBD0", VA = "0x18276DBD0")]
		public NEHDEDPNPDN(CHIEBOEDIPK IOIBNPDJCNE, DJAFPBFODNL GOJJJBGJPAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	private sealed class OMGMDOHNNFE : OBDPADHLGOK<HOOPEMPEGPI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xBDE1B0", Offset = "0xBDD1B0", VA = "0x180BDE1B0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x276F700", Offset = "0x276E700", VA = "0x18276F700")]
		public OMGMDOHNNFE(CHIEBOEDIPK IOIBNPDJCNE, HOOPEMPEGPI GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public abstract class CAMHBDKBKIA<T> : FNEGPADGNAD<T> where T : notnull, EOEHGGFODJP
	{
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[CompilerGenerated]
		private sealed class JMJNDJLFPAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public IReadOnlyList<KeyValuePair<string, FDEEMEDLPLM>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public CAMHBDKBKIA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public AEKGKKLKPIL clipType;

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public JMJNDJLFPAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			internal IReadOnlyList<KeyValuePair<string, FDEEMEDLPLM>> PMOJIBLCDBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x4E42310", Offset = "0x4E41310", VA = "0x184E42310")]
			internal int POFMCLKDAFO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x4E41D10", Offset = "0x4E40D10", VA = "0x184E41D10")]
			internal void IGNBPBENOMC(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x4E42110", Offset = "0x4E41110", VA = "0x184E42110")]
			internal void NOAGHDJPGKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x4E42160", Offset = "0x4E41160", VA = "0x184E42160")]
			internal void OABKELGAFGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x4E41B70", Offset = "0x4E40B70", VA = "0x184E41B70")]
			internal bool ONMGGGFMIMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x4E41C00", Offset = "0x4E40C00", VA = "0x184E41C00")]
			internal void IEBNCJCHKNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x4E41B70", Offset = "0x4E40B70", VA = "0x184E41B70")]
			internal bool EGEKFLONCNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x4E420B0", Offset = "0x4E410B0", VA = "0x184E420B0")]
			internal float NNMDDOCMLBP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x4E41F30", Offset = "0x4E40F30", VA = "0x184E41F30")]
			internal void JPFEDGBCBJK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x4E422B0", Offset = "0x4E412B0", VA = "0x184E422B0")]
			internal float PNCCNAEJOIK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x4E41C50", Offset = "0x4E40C50", VA = "0x184E41C50")]
			internal void IFOPBOHCJEJ(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x4E41B10", Offset = "0x4E40B10", VA = "0x184E41B10")]
			internal float AOACIPBKBMC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x4E41FF0", Offset = "0x4E40FF0", VA = "0x184E41FF0")]
			internal void LECHGFPGJPC(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x10AE210", Offset = "0x10AD210", VA = "0x1810AE210", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public abstract AEKGKKLKPIL EPPODOEMAIM
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(Slot = "140")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x679FFE0", Offset = "0x679EFE0", VA = "0x18679FFE0")]
		public CAMHBDKBKIA(CHIEBOEDIPK IOIBNPDJCNE, T GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x679F510", Offset = "0x679E510", VA = "0x18679F510", Slot = "134")]
		protected sealed override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	private sealed class ONKNFJNPNJO : FNEGPADGNAD<ECHDHDHNEBA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0xD81DB0", Offset = "0xD80DB0", VA = "0x180D81DB0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x276F760", Offset = "0x276E760", VA = "0x18276F760")]
		public ONKNFJNPNJO(CHIEBOEDIPK IOIBNPDJCNE, ECHDHDHNEBA GOJJJBGJPAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public sealed class BODLLDGDCIJ : FNEGPADGNAD<MOCMGCHEMDB>
	{
		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[CompilerGenerated]
		private sealed class HMHGGEOIOHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public BODLLDGDCIJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public HMHGGEOIOHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x2763720", Offset = "0x2762720", VA = "0x182763720")]
			internal int POFMCLKDAFO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x2763690", Offset = "0x2762690", VA = "0x182763690")]
			internal void IGNBPBENOMC(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private static Dictionary<string, FDEEMEDLPLM>? FMFOAKDAFIN;

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2755740", Offset = "0x2754740", VA = "0x182755740")]
		public BODLLDGDCIJ(CHIEBOEDIPK IOIBNPDJCNE, MOCMGCHEMDB GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x27553B0", Offset = "0x27543B0", VA = "0x1827553B0", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public sealed class AEEFGHGHEIM : CAMHBDKBKIA<LHHFDCOBDHI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public override AEKGKKLKPIL EPPODOEMAIM
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "140")]
			get
			{
				return default(AEKGKKLKPIL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2753D70", Offset = "0x2752D70", VA = "0x182753D70")]
		public AEEFGHGHEIM(CHIEBOEDIPK IOIBNPDJCNE, LHHFDCOBDHI HCAMONPFOJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	private sealed class PJBKOPNMEEJ : OBDPADHLGOK<NKKHKKCJCOA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0xBDE1B0", Offset = "0xBDD1B0", VA = "0x180BDE1B0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x27702E0", Offset = "0x276F2E0", VA = "0x1827702E0")]
		public PJBKOPNMEEJ(CHIEBOEDIPK IOIBNPDJCNE, NKKHKKCJCOA GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private sealed class IBPNIFKKEEO : OBDPADHLGOK<OEFOAADPGFK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xBDE1B0", Offset = "0xBDD1B0", VA = "0x180BDE1B0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x2764410", Offset = "0x2763410", VA = "0x182764410")]
		public IBPNIFKKEEO(CHIEBOEDIPK IOIBNPDJCNE, OEFOAADPGFK GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class MHGNOKFODIN : OGBFMPPEGJC<MCPPJFBPFKC>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class LMDCMMLOOKE
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000A5")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public LMDCMMLOOKE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0x2770950", Offset = "0x276F950", VA = "0x182770950", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0xA45C40", Offset = "0xA44C40", VA = "0x180A45C40", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public MHGNOKFODIN <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public LMDCMMLOOKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x276CA10", Offset = "0x276BA10", VA = "0x18276CA10")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void JGLMENIGIII(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x276D230", Offset = "0x276C230", VA = "0x18276D230")]
		public MHGNOKFODIN(CHIEBOEDIPK IOIBNPDJCNE, MCPPJFBPFKC HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x276CF50", Offset = "0x276BF50", VA = "0x18276CF50", Slot = "140")]
		protected override void BLDBLIFKMKL(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class BOGILLFJKAO : CAMHBDKBKIA<ACIJGECJPHA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override AEKGKKLKPIL EPPODOEMAIM
		{
			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0xB83650", Offset = "0xB82650", VA = "0x180B83650", Slot = "140")]
			get
			{
				return default(AEKGKKLKPIL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x27557B0", Offset = "0x27547B0", VA = "0x1827557B0")]
		public BOGILLFJKAO(CHIEBOEDIPK IOIBNPDJCNE, ACIJGECJPHA HCAMONPFOJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private sealed class JBEMECPIGEE : FNEGPADGNAD<DDJNHINCFBJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0xD6CAB0", Offset = "0xD6BAB0", VA = "0x180D6CAB0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x2764730", Offset = "0x2763730", VA = "0x182764730")]
		public JBEMECPIGEE(CHIEBOEDIPK IOIBNPDJCNE, DDJNHINCFBJ GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public sealed class AJIEDDIOFHC : FNEGPADGNAD<OPGGOMDJCOL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public sealed override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public sealed override bool PBCBCPMKOGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected sealed override bool GIPCIPECMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A680", VA = "0x180A0B680", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x27545F0", Offset = "0x27535F0", VA = "0x1827545F0")]
		public AJIEDDIOFHC(CHIEBOEDIPK IOIBNPDJCNE, OPGGOMDJCOL GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x27542E0", Offset = "0x27532E0", VA = "0x1827542E0", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x27545B0", Offset = "0x27535B0", VA = "0x1827545B0")]
		private int JEDEHALPHDF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x2754280", Offset = "0x2753280", VA = "0x182754280")]
		private void AIBGNAIBCCL(int PCHMHBNEGIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class MNLPDEGJAGN : KIAABMIFJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x276BA60", Offset = "0x276AA60", VA = "0x18276BA60")]
		public MNLPDEGJAGN(CHIEBOEDIPK IOIBNPDJCNE, GDCCFCAPGMP GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class IECJGCKPFAJ : OGBFMPPEGJC<JIJCBELIJOK>
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x2764470", Offset = "0x2763470", VA = "0x182764470")]
		public IECJGCKPFAJ(CHIEBOEDIPK IOIBNPDJCNE, JIJCBELIJOK GOJJJBGJPAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public abstract class OGBFMPPEGJC<TVariableNode> : FNEGPADGNAD<TVariableNode> where TVariableNode : notnull, JIJCBELIJOK
	{
		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		[CompilerGenerated]
		private sealed class HFKFJIGEDHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public OGBFMPPEGJC<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public HFKFJIGEDHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x4AD24E0", Offset = "0x4AD14E0", VA = "0x184AD24E0")]
			internal bool PMOJIBLCDBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x4AD2540", Offset = "0x4AD1540", VA = "0x184AD2540")]
			internal void POFMCLKDAFO(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x4AD2310", Offset = "0x4AD1310", VA = "0x184AD2310")]
			internal bool IGNBPBENOMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x4AD2370", Offset = "0x4AD1370", VA = "0x184AD2370")]
			internal void NOAGHDJPGKH(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x4AD2430", Offset = "0x4AD1430", VA = "0x184AD2430")]
			internal bool OABKELGAFGC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		[CompilerGenerated]
		private sealed class NELBFLBLPHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public OGBFMPPEGJC<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public NELBFLBLPHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x53A9880", Offset = "0x53A8880", VA = "0x1853A9880")]
			internal void JGLMENIGIII(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xBD6960", Offset = "0xBD5960", VA = "0x180BD6960", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public override DIBHJHIJCOI EHMCAFAODKF
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x5516FB0", Offset = "0x5515FB0", VA = "0x185516FB0", Slot = "108")]
			get
			{
				return default(DIBHJHIJCOI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x5516E10", Offset = "0x5515E10", VA = "0x185516E10")]
		protected OGBFMPPEGJC(CHIEBOEDIPK IOIBNPDJCNE, TVariableNode GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x5516710", Offset = "0x5515710", VA = "0x185516710", Slot = "101")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x55168A0", Offset = "0x55158A0", VA = "0x1855168A0", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x5516380", Offset = "0x5515380", VA = "0x185516380", Slot = "140")]
		protected virtual void BLDBLIFKMKL(KIEOOBCGILC PEEMKKKLLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x5516D50", Offset = "0x5515D50", VA = "0x185516D50", Slot = "119")]
		public override void KGPJOLOPJJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x273A170", Offset = "0x2739170", VA = "0x18273A170")]
	public static CBDBLPHCHLP ACADPGMDEBE(CHIEBOEDIPK IOIBNPDJCNE, GDCCFCAPGMP GOJJJBGJPAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class DEJIDOPKGLB : GBODGILDCPF, EDLMBADJAJJ, HGIFBECBIMN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public EDBALDILLBK<MBCPFFKFBDC> KJIBDALKEBE
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0xD62EF0", Offset = "0xD61EF0", VA = "0x180D62EF0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(EDBALDILLBK<MBCPFFKFBDC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public EDBALDILLBK<HPDCGGEBOAB> JHCAOAKHAIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0xE5B230", Offset = "0xE5A230", VA = "0x180E5B230", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(EDBALDILLBK<HPDCGGEBOAB>);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x2755EB0", Offset = "0x2754EB0", VA = "0x182755EB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private EDBALDILLBK<LGADIHOLJAO> NGJHFBELAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xD6D4F0", Offset = "0xD6C4F0", VA = "0x180D6D4F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public override EDBALDILLBK<LOPJDFBDKHF> KKPPEGHFDFH
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2755EC0", Offset = "0x2754EC0", VA = "0x182755EC0", Slot = "21")]
		get
		{
			return default(EDBALDILLBK<LOPJDFBDKHF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x2755F10", Offset = "0x2754F10", VA = "0x182755F10")]
	private DEJIDOPKGLB(CHIEBOEDIPK IOIBNPDJCNE, GDCCFCAPGMP GOJJJBGJPAM, JHLHFJKDFLC NFDKKPIDAGF, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<HPDCGGEBOAB> NJKENGKIHNB, EDBALDILLBK<LGADIHOLJAO> OANGAIMOJJO, bool OGKGFGNPDEA, string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x2755B60", Offset = "0x2754B60", VA = "0x182755B60")]
	public static DEJIDOPKGLB ACADPGMDEBE(CHIEBOEDIPK IOIBNPDJCNE, GDCCFCAPGMP GOJJJBGJPAM, JHLHFJKDFLC MFNAKEDKNJF, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<LGADIHOLJAO> OANGAIMOJJO, EDBALDILLBK<HPDCGGEBOAB> NJKENGKIHNB, bool OGKGFGNPDEA, bool FPPJBNBMHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x2755EB0", Offset = "0x2754EB0", VA = "0x182755EB0")]
	internal void FDAAINJNADK(EDBALDILLBK<HPDCGGEBOAB> OHLIHBDBKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public abstract class GBODGILDCPF : HGIFBECBIMN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	private struct OKGOHPNFFIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private LPEOOOFCFLN? GLAJFLBDENK;

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x276F6F0", Offset = "0x276E6F0", VA = "0x18276F6F0")]
		public void INBDHNEFJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x276F650", Offset = "0x276E650", VA = "0x18276F650")]
		public LPEOOOFCFLN BFKBONPCFGN(GBODGILDCPF IFMPKPPFKAO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	protected readonly CHIEBOEDIPK FBKDHJDLAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	protected readonly GDCCFCAPGMP LIGPJFBJHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private OKGOHPNFFIP NNJPJCOIAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly BKECGCMIFAG KAKNJHOJIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly List<FLEABLDLCAL> FDPPJACOEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly List<HGBPDLMFNAA> APLIFPAENHA;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	[HCCKFFEHNEM("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> EFHJGCECLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x27595E0", Offset = "0x27585E0", VA = "0x1827595E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public DisplayKind NCNNLKBOJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xA00120", Offset = "0x9FF120", VA = "0x180A00120", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public EDBALDILLBK<BIEIIMCKPHN> CNMEJNNBCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x275A650", Offset = "0x2759650", VA = "0x18275A650", Slot = "6")]
		get
		{
			return default(EDBALDILLBK<BIEIIMCKPHN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public IGLPJBODKFE<BIEIIMCKPHN> CHOAMIELENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2759B70", Offset = "0x2758B70", VA = "0x182759B70", Slot = "7")]
		get
		{
			return default(IGLPJBODKFE<BIEIIMCKPHN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public HJDEFPFJDOJ BJDAICDJFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xD3E3B0", Offset = "0xD3D3B0", VA = "0x180D3E3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public DGHBNBOLGPF JAMDOIBHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x27592A0", Offset = "0x27582A0", VA = "0x1827592A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	protected LPEOOOFCFLN EHCCONJKEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x27592A0", Offset = "0x27582A0", VA = "0x1827592A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public PortImage FKJLJMIEBGP
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x275A6E0", Offset = "0x27596E0", VA = "0x18275A6E0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1500", Offset = "0x9F0500", VA = "0x1809F1500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IGLPJBODKFE<ALEKBGLLPHJ> AEFADELMNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x27598E0", Offset = "0x27588E0", VA = "0x1827598E0", Slot = "9")]
		get
		{
			return default(IGLPJBODKFE<ALEKBGLLPHJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public EDBALDILLBK<MECIAIKJJDL> AHJOKILIEGF
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xCFC9F0", Offset = "0xCFB9F0", VA = "0x180CFC9F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EDBALDILLBK<MECIAIKJJDL>);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xE5AE60", Offset = "0xE59E60", VA = "0x180E5AE60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public abstract EDBALDILLBK<LOPJDFBDKHF> KKPPEGHFDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x275A810", Offset = "0x2759810", VA = "0x18275A810")]
	protected GBODGILDCPF(CHIEBOEDIPK IOIBNPDJCNE, GDCCFCAPGMP GOJJJBGJPAM, BKECGCMIFAG JHMPKACOBFK, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, bool OGKGFGNPDEA, string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x27594F0", Offset = "0x27584F0", VA = "0x1827594F0", Slot = "22")]
	protected virtual void ANJKPBDKBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x2759790", Offset = "0x2758790", VA = "0x182759790", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x2759AB0", Offset = "0x2758AB0", VA = "0x182759AB0", Slot = "14")]
	public void HHHMMIJELMF(FLEABLDLCAL LPLPDJPCKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x2759730", Offset = "0x2758730", VA = "0x182759730", Slot = "15")]
	public void CDEDEGPGBFD(HGBPDLMFNAA LPLPDJPCKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x2759D50", Offset = "0x2758D50", VA = "0x182759D50", Slot = "16")]
	public void IJJLOIMJLIL(JFPHGDGHBDF NNDPLIOKOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x2759B10", Offset = "0x2758B10", VA = "0x182759B10", Slot = "24")]
	protected virtual void HHNKFBFEPJF(JFPHGDGHBDF NNDPLIOKOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x2759900", Offset = "0x2758900", VA = "0x182759900", Slot = "19")]
	private void FPHKMPIMFIH(bool COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x2759340", Offset = "0x2758340", VA = "0x182759340")]
	private void AJKAMEFBFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x2759BA0", Offset = "0x2758BA0", VA = "0x182759BA0")]
	private void IHHKOMKMPMN([In] FPIKEBBELDH IOFINHALECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x2759880", Offset = "0x2758880", VA = "0x182759880", Slot = "17")]
	public void FDEGCFJIFEN(FLEABLDLCAL LPLPDJPCKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x275A680", Offset = "0x2759680", VA = "0x18275A680", Slot = "18")]
	public void MDAMCDBLJIA(HGBPDLMFNAA LPLPDJPCKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x9F1500", Offset = "0x9F0500", VA = "0x1809F1500")]
	internal void LJPELIJAKLM(string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x2759A90", Offset = "0x2758A90", VA = "0x182759A90")]
	internal void GEPFJJJPGCM(DMBFCNGEBJL MMCKJCAOGBM, HJDEFPFJDOJ MLCOGCMJLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xE5AE60", Offset = "0xE59E60", VA = "0x180E5AE60")]
	internal void HJHAAFGDNFJ(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public sealed class KAMDBIDHFJB : LCBAJMHOMEH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class CLFBOHAJLBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public CHIEBOEDIPK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public GDCCFCAPGMP node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public EDBALDILLBK<MECIAIKJJDL> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public CLFBOHAJLBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x2755AD0", Offset = "0x2754AD0", VA = "0x182755AD0")]
		internal KCILGDEGCLG OAMONKHEICB((int PortDescIndex, int PortIndex, JMMEMLBFONE InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x2755A40", Offset = "0x2754A40", VA = "0x182755A40")]
		internal DEJIDOPKGLB MLCPMKNJPGL(JHLHFJKDFLC i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct EHBDHFDCCKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x2756E80", Offset = "0x2755E80", VA = "0x182756E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x27572F0", Offset = "0x27562F0", VA = "0x1827572F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct FCNBBEHMKAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public EDBALDILLBK<KCPNHNINCKC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x2758650", Offset = "0x2757650", VA = "0x182758650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x27589A0", Offset = "0x27579A0", VA = "0x1827589A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct PPIDFBKDIKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public EDBALDILLBK<LGADIHOLJAO> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x2770590", Offset = "0x276F590", VA = "0x182770590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x27708E0", Offset = "0x276F8E0", VA = "0x1827708E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct HMMANLPCEIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public EDBALDILLBK<KCPNHNINCKC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public EDBALDILLBK<KCPNHNINCKC> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2763B50", Offset = "0x2762B50", VA = "0x182763B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x2763EB0", Offset = "0x2762EB0", VA = "0x182763EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct FHCHMHGPEGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public EDBALDILLBK<LGADIHOLJAO> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public EDBALDILLBK<LGADIHOLJAO> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x2758A80", Offset = "0x2757A80", VA = "0x182758A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x2758DE0", Offset = "0x2757DE0", VA = "0x182758DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct HMNLMGJCENA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2763F20", Offset = "0x2762F20", VA = "0x182763F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x27643A0", Offset = "0x27633A0", VA = "0x1827643A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct PEIOOJMNLJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x276FB10", Offset = "0x276EB10", VA = "0x18276FB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x276FE60", Offset = "0x276EE60", VA = "0x18276FE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct HMLCKCLGEIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public EDBALDILLBK<KCPNHNINCKC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x2763770", Offset = "0x2762770", VA = "0x182763770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2763AE0", Offset = "0x2762AE0", VA = "0x182763AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct BKIBFKKHFLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public EDBALDILLBK<LGADIHOLJAO> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x27546D0", Offset = "0x27536D0", VA = "0x1827546D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2754A40", Offset = "0x2753A40", VA = "0x182754A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct PEKLGKMIMLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public ACLPKCGEGFP type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public EDBALDILLBK<KCPNHNINCKC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x276FED0", Offset = "0x276EED0", VA = "0x18276FED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x2770270", Offset = "0x276F270", VA = "0x182770270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct DLLDIJMMBGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public ACLPKCGEGFP type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public EDBALDILLBK<LGADIHOLJAO> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x2756770", Offset = "0x2755770", VA = "0x182756770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x2756B10", Offset = "0x2755B10", VA = "0x182756B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	private readonly bool JHFHMFEHBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly CHIEBOEDIPK FBKDHJDLAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly bool FJPMKKBPPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private KOLDGJODODL<IFOKEFFHPOH, KCILGDEGCLG> AHCKBOGNOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private KOLDGJODODL<IFOKEFFHPOH, IKPGAMHHELO> MCFFELOHKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly GDCCFCAPGMP LIGPJFBJHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private KOLDGJODODL<HPDCGGEBOAB, DEJIDOPKGLB> LNBMHCCFNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private KOLDGJODODL<HPDCGGEBOAB, EDLMBADJAJJ> AAKFEKLPJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private string? PLENDDGMCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private readonly BAANAFJPLNG FCHEPCKGOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private EDBALDILLBK<MECIAIKJJDL> IAOJEHGACFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private readonly bool IKAHDLKDAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	[CompilerGenerated]
	private Action? FBMOCAGKFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private Action? LDIJKNODCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	[CompilerGenerated]
	private Action<EDBALDILLBK<IFOKEFFHPOH>>? GNLHIJGPJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	[CompilerGenerated]
	private Action<EDBALDILLBK<HPDCGGEBOAB>>? AAINNNPCNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	[CompilerGenerated]
	private LCBAJMHOMEH.FBNGGFHLHAG? HGIJOAOCBDJ;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool GAFIKDAACLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x2768740", Offset = "0x2767740", VA = "0x182768740", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool JCNANJNIMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x2769690", Offset = "0x2768690", VA = "0x182769690", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool HLDDONALKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x27679A0", Offset = "0x27669A0", VA = "0x1827679A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public IGLPJBODKFE<BIEIIMCKPHN> CHOAMIELENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2768CE0", Offset = "0x2767CE0", VA = "0x182768CE0", Slot = "7")]
		get
		{
			return default(IGLPJBODKFE<BIEIIMCKPHN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool AAOBHKGOKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2769B70", Offset = "0x2768B70", VA = "0x182769B70", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public KOLDGJODODL<IFOKEFFHPOH, IKPGAMHHELO> BIIPMGOKIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510", Slot = "9")]
		get
		{
			return default(KOLDGJODODL<IFOKEFFHPOH, IKPGAMHHELO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x27696D0", Offset = "0x27686D0", VA = "0x1827696D0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public IGLPJBODKFE<ALEKBGLLPHJ> AEFADELMNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x2767E60", Offset = "0x2766E60", VA = "0x182767E60", Slot = "11")]
		get
		{
			return default(IGLPJBODKFE<ALEKBGLLPHJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public KOLDGJODODL<HPDCGGEBOAB, EDLMBADJAJJ> ANMPBMMDOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0", Slot = "12")]
		get
		{
			return default(KOLDGJODODL<HPDCGGEBOAB, EDLMBADJAJJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public EDBALDILLBK<MECIAIKJJDL> AHJOKILIEGF
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xBB0C40", Offset = "0xBAFC40", VA = "0x180BB0C40", Slot = "13")]
		get
		{
			return default(EDBALDILLBK<MECIAIKJJDL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? IOIONBNIFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x2767380", Offset = "0x2766380", VA = "0x182767380", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x2769530", Offset = "0x2768530", VA = "0x182769530", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action? NPOOIDJGJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x2768690", Offset = "0x2767690", VA = "0x182768690", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2768430", Offset = "0x2767430", VA = "0x182768430", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<EDBALDILLBK<IFOKEFFHPOH?>, EDBALDILLBK<IFOKEFFHPOH?>>? HCFLOKGBEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x2766080", Offset = "0x2765080", VA = "0x182766080", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2766850", Offset = "0x2765850", VA = "0x182766850", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<EDBALDILLBK<IFOKEFFHPOH?>, EDBALDILLBK<IFOKEFFHPOH?>>? LFPFLAOGMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x27699F0", Offset = "0x27689F0", VA = "0x1827699F0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x27684E0", Offset = "0x27674E0", VA = "0x1827684E0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<EDBALDILLBK<HPDCGGEBOAB?>, EDBALDILLBK<HPDCGGEBOAB?>>? DNDGIAONEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x276A040", Offset = "0x2769040", VA = "0x18276A040", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x2769930", Offset = "0x2768930", VA = "0x182769930", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<EDBALDILLBK<HPDCGGEBOAB?>, EDBALDILLBK<HPDCGGEBOAB?>>? GEAODGODHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2766640", Offset = "0x2765640", VA = "0x182766640", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x276A9A0", Offset = "0x27699A0", VA = "0x18276A9A0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<EDBALDILLBK<IFOKEFFHPOH?>, IKPGAMHHELO?>? EDLJFJDLIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2766EB0", Offset = "0x2765EB0", VA = "0x182766EB0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x2767420", Offset = "0x2766420", VA = "0x182767420", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<EDBALDILLBK<IFOKEFFHPOH?>>? AINAHIEIDOH
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x27672C0", Offset = "0x27662C0", VA = "0x1827672C0", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2767200", Offset = "0x2766200", VA = "0x182767200", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<EDBALDILLBK<IFOKEFFHPOH?>, IKPGAMHHELO?>? IMHGMCJIBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x2769AB0", Offset = "0x2768AB0", VA = "0x182769AB0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x2767050", Offset = "0x2766050", VA = "0x182767050", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<EDBALDILLBK<HPDCGGEBOAB?>, EDLMBADJAJJ?>? IHMIFGDMOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x276A350", Offset = "0x2769350", VA = "0x18276A350", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x276A230", Offset = "0x2769230", VA = "0x18276A230", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<EDBALDILLBK<HPDCGGEBOAB?>>? IOIDMIKLCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x2766F90", Offset = "0x2765F90", VA = "0x182766F90", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x2766350", Offset = "0x2765350", VA = "0x182766350", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<EDBALDILLBK<HPDCGGEBOAB?>, EDLMBADJAJJ?>? ADJBKOJFMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x2766160", Offset = "0x2765160", VA = "0x182766160", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x27695D0", Offset = "0x27685D0", VA = "0x1827695D0", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x276AB70", Offset = "0x2769B70", VA = "0x18276AB70")]
	private KAMDBIDHFJB(bool OGKGFGNPDEA, CHIEBOEDIPK IOIBNPDJCNE, bool MNNNDHNMHMF, KOLDGJODODL<IFOKEFFHPOH, KCILGDEGCLG> ODHLNAONGFG, KOLDGJODODL<IFOKEFFHPOH, IKPGAMHHELO> DDMEGPPILMJ, GDCCFCAPGMP GOJJJBGJPAM, KOLDGJODODL<HPDCGGEBOAB, DEJIDOPKGLB> JAPHJOLMCAH, KOLDGJODODL<HPDCGGEBOAB, EDLMBADJAJJ> LPPNIHGOOOE, string? GIIEOLIDNOL, BAANAFJPLNG GBMJPODLMIF, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, bool FPPJBNBMHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x2765B10", Offset = "0x2764B10", VA = "0x182765B10")]
	public static KAMDBIDHFJB ACADPGMDEBE(bool OGKGFGNPDEA, CHIEBOEDIPK IOIBNPDJCNE, bool MNNNDHNMHMF, GDCCFCAPGMP GOJJJBGJPAM, BAANAFJPLNG GBMJPODLMIF, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, bool FPPJBNBMHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x27674E0", Offset = "0x27664E0", VA = "0x1827674E0", Slot = "69")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x2769440", Offset = "0x2768440", VA = "0x182769440", Slot = "38")]
	[AsyncStateMachine(typeof(EHBDHFDCCKG))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC?>>? IPCEHKOKDJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2766410", Offset = "0x2765410", VA = "0x182766410")]
	private (FMGKOMKDAHH?, int)? BBGEKEOFDGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x2767110", Offset = "0x2766110", VA = "0x182767110", Slot = "58")]
	private void CPLAOMOJBCJ(int OGANHCODKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x1F56730", Offset = "0x1F55730", VA = "0x181F56730", Slot = "57")]
	private void OPOPDDAJJPN(int OGANHCODKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x2767AC0", Offset = "0x2766AC0", VA = "0x182767AC0", Slot = "61")]
	private void FCKJCAFLHCG(int NICFJMKACMO, int OOCILDAPIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x276A2F0", Offset = "0x27692F0", VA = "0x18276A2F0", Slot = "63")]
	private void ODFMAOJGJMG(int NICFJMKACMO, int OOCILDAPIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x276A410", Offset = "0x2769410", VA = "0x18276A410", Slot = "50")]
	private void OJGBALJBGAA(int OGANHCODKFO, EDBALDILLBK<IFOKEFFHPOH> NLCFBAENGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x27691E0", Offset = "0x27681E0", VA = "0x1827691E0", Slot = "54")]
	private void IMJBGKPBNFL(int COFBNOFIHKI, EDBALDILLBK<IFOKEFFHPOH> NLCFBAENGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x2766F70", Offset = "0x2765F70", VA = "0x182766F70", Slot = "49")]
	private void CGKOCPKDEKN(int COFBNOFIHKI, EDBALDILLBK<IFOKEFFHPOH> NLCFBAENGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x2769BF0", Offset = "0x2768BF0", VA = "0x182769BF0", Slot = "53")]
	private void MPPCEJDLNBD(int OGANHCODKFO, EDBALDILLBK<IFOKEFFHPOH> NLCFBAENGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x2769200", Offset = "0x2768200", VA = "0x182769200", Slot = "66")]
	private void INDEIILHBMD(int OGANHCODKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x12E4C90", Offset = "0x12E3C90", VA = "0x1812E4C90", Slot = "65")]
	private void KEPLOGBOAEM(int OGANHCODKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x27685A0", Offset = "0x27675A0", VA = "0x1827685A0", Slot = "60")]
	private void GOPLLEKKKMA(int OGANHCODKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x1F56730", Offset = "0x1F55730", VA = "0x181F56730", Slot = "59")]
	private void IJPGAELGPOH(int OGANHCODKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x2768D10", Offset = "0x2767D10", VA = "0x182768D10", Slot = "62")]
	private void IIBCGOAKLDB(int NICFJMKACMO, int OOCILDAPIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x2767A60", Offset = "0x2766A60", VA = "0x182767A60", Slot = "64")]
	private void ELIKLJDGINI(int NICFJMKACMO, int OOCILDAPIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2767EA0", Offset = "0x2766EA0", VA = "0x182767EA0", Slot = "52")]
	private void GMEKKOOMCOI(int OGANHCODKFO, EDBALDILLBK<HPDCGGEBOAB> NLCFBAENGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x2766140", Offset = "0x2765140", VA = "0x182766140", Slot = "56")]
	private void AGDGCOLILMD(int COFBNOFIHKI, EDBALDILLBK<HPDCGGEBOAB> NLCFBAENGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x2767E80", Offset = "0x2766E80", VA = "0x182767E80", Slot = "51")]
	private void GEKDCDHKDGO(int COFBNOFIHKI, EDBALDILLBK<HPDCGGEBOAB> NLCFBAENGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x2766910", Offset = "0x2765910", VA = "0x182766910", Slot = "55")]
	private void CCBNCBCDNLM(int OGANHCODKFO, EDBALDILLBK<HPDCGGEBOAB> NLCFBAENGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x2766700", Offset = "0x2765700", VA = "0x182766700", Slot = "68")]
	private void BIPIGCKLCJO(int OGANHCODKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x12E4C90", Offset = "0x12E3C90", VA = "0x1812E4C90", Slot = "67")]
	private void IBGONDCLHCD(int OGANHCODKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x2769700", Offset = "0x2768700", VA = "0x182769700", Slot = "39")]
	[AsyncStateMachine(typeof(FCNBBEHMKAF))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC?>>? LNCLCOGMHNG(EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x276AA60", Offset = "0x2769A60", VA = "0x18276AA60", Slot = "40")]
	[AsyncStateMachine(typeof(PPIDFBKDIKG))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC?>>? OPDJGCMMNOK(EDBALDILLBK<LGADIHOLJAO> OANGAIMOJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x2769810", Offset = "0x2768810", VA = "0x182769810", Slot = "41")]
	[AsyncStateMachine(typeof(HMMANLPCEIJ))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC?>>? MAOJMAONNGG(EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK, EDBALDILLBK<KCPNHNINCKC> JOKKHPPEGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x2767880", Offset = "0x2766880", VA = "0x182767880", Slot = "42")]
	[AsyncStateMachine(typeof(FHCHMHGPEGK))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC?>>? EBJOJKCPGFI(EDBALDILLBK<LGADIHOLJAO> OANGAIMOJJO, EDBALDILLBK<LGADIHOLJAO> JOKKHPPEGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x2769350", Offset = "0x2768350", VA = "0x182769350", Slot = "43")]
	[AsyncStateMachine(typeof(HMNLMGJCENA))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC?>>? INKDMMLEANF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2768800", Offset = "0x2767800", VA = "0x182768800", Slot = "44")]
	[AsyncStateMachine(typeof(PEIOOJMNLJH))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> HFNHJCIMPJG(string NKGPMKCBABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x27690B0", Offset = "0x27680B0", VA = "0x1827690B0", Slot = "45")]
	[AsyncStateMachine(typeof(HMLCKCLGEIF))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> IKPCCLHFKND(EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK, string NFHOBPDKIPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x276A100", Offset = "0x2769100", VA = "0x18276A100", Slot = "46")]
	[AsyncStateMachine(typeof(BKIBFKKHFLG))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> NBMAIBJMBAH(EDBALDILLBK<LGADIHOLJAO> OANGAIMOJJO, string NFHOBPDKIPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x2766220", Offset = "0x2765220", VA = "0x182766220", Slot = "47")]
	[AsyncStateMachine(typeof(PEKLGKMIMLJ))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> AMLHOHAHALH(EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK, ACLPKCGEGFP MLCOGCMJLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x2766D80", Offset = "0x2765D80", VA = "0x182766D80", Slot = "48")]
	[AsyncStateMachine(typeof(DLLDIJMMBGO))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> CCEDCDMOADN(EDBALDILLBK<LGADIHOLJAO> OANGAIMOJJO, ACLPKCGEGFP MLCOGCMJLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x2768920", Offset = "0x2767920", VA = "0x182768920")]
	internal void HJHAAFGDNFJ(EDBALDILLBK<MECIAIKJJDL> OHLIHBDBKCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public sealed class GEGFDAOJMBC : MGIDPOIGHNH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public interface FAGIEJAHGME
	{
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		public readonly struct EAOPGAFDPLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026B")]
			public readonly IReadOnlyDictionary<IGLPJBODKFE<BIEIIMCKPHN>, Guid>? JIJJDJPODNM;

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0xCFF9B0", Offset = "0xCFE9B0", VA = "0x180CFF9B0")]
			public EAOPGAFDPLL(IReadOnlyDictionary<IGLPJBODKFE<BIEIIMCKPHN>, Guid>? JIJJDJPODNM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		DMBFCNGEBJL HMMDAMLCMFM
		{
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<DAPEGEJBKHJ> GPIGCHMOJGM(CancellationToken CBJPDIFOEKF);

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<HNAGJAILJOF> CKHJNFCNAMB(CancellationToken CBJPDIFOEKF);

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<CAJCOBBEPJC> LKLBDKIKGED(CancellationToken CBJPDIFOEKF);

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<COGPNGPCNGP> JHODFEDJKJM(CancellationToken CBJPDIFOEKF);

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<EAOPGAFDPLL> HGOMFBADFDK(CancellationToken CBJPDIFOEKF);

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<BBFLKNGKMEG> GFIGPAHMGJI(CancellationToken CBJPDIFOEKF);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct JLKJBPDLBBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public AsyncTaskMethodBuilder<GEGFDAOJMBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public CHIEBOEDIPK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public DAPEGEJBKHJ roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public HNAGJAILJOF superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private FAGIEJAHGME <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private DAPEGEJBKHJ <downloadedRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private DAPEGEJBKHJ <actualRoomData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private BBFLKNGKMEG <actualStaticConfig>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private HNAGJAILJOF <finalSuperRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private CAJCOBBEPJC <roomAssetData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private COGPNGPCNGP <playerSaveData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<DAPEGEJBKHJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private DAPEGEJBKHJ <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private TaskAwaiter<BBFLKNGKMEG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<HNAGJAILJOF> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private TaskAwaiter<CAJCOBBEPJC> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<COGPNGPCNGP> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<FAGIEJAHGME.EAOPGAFDPLL> <>u__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private TaskAwaiter<KPBELAPACCB> <>u__7;

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x27647A0", Offset = "0x27637A0", VA = "0x1827647A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x2765850", Offset = "0x2764850", VA = "0x182765850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private readonly KPBELAPACCB PNLHEJFLLMK;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public KPBELAPACCB FDFMMKMOCDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	private GEGFDAOJMBC(KPBELAPACCB IJHPLNHDKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x2763090", Offset = "0x2762090", VA = "0x182763090")]
	[AsyncStateMachine(typeof(JLKJBPDLBBG))]
	public static Task<GEGFDAOJMBC> HADJEECNMFP(CHIEBOEDIPK IOIBNPDJCNE, DAPEGEJBKHJ? MKIDPONBDDE, HNAGJAILJOF? OFMJDNINMGK, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x2763070", Offset = "0x2762070", VA = "0x182763070", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public readonly struct EHIAIIKPCDI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct EGIPMLFPLLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public EHIAIIKPCDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public AFPLFKDKJPC action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private TaskAwaiter<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x2756B80", Offset = "0x2755B80", VA = "0x182756B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x2756E10", Offset = "0x2755E10", VA = "0x182756E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private struct FJKCHFEPMBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<bool, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public AMICEDMCMOM rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public DAPEGEJBKHJ circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public HNAGJAILJOF superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public EHIAIIKPCDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private AFPLFKDKJPC[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private TaskAwaiter<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x2758E50", Offset = "0x2757E50", VA = "0x182758E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x2759230", Offset = "0x2758230", VA = "0x182759230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private struct NKJJAEFPMPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public EHIAIIKPCDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private TaskAwaiter<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x276EA10", Offset = "0x276DA10", VA = "0x18276EA10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x276EC50", Offset = "0x276DC50", VA = "0x18276EC50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private readonly HNNMKAAPCJH CMAAEEHAJID;

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0xCFF9B0", Offset = "0xCFE9B0", VA = "0x180CFF9B0")]
	public EHIAIIKPCDI(HNNMKAAPCJH HIEGHANFGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x2757450", Offset = "0x2756450", VA = "0x182757450")]
	[AsyncStateMachine(typeof(EGIPMLFPLLA))]
	private Task<HHHCCNLMPJL<object, DLKBDBKHJCC>> NGOFJAKHGMH(AFPLFKDKJPC BDCLNIJAFBF, bool CKEAKKIBMKM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x2757580", Offset = "0x2756580", VA = "0x182757580")]
	[AsyncStateMachine(typeof(FJKCHFEPMBH))]
	public Task<HHHCCNLMPJL<bool, DLKBDBKHJCC?>>? NMJAGKADGHO(int BIMKIFBAABH, AMICEDMCMOM? GPHGBEGKLDA, DAPEGEJBKHJ? DHMHCCKDFEA, HNAGJAILJOF? OFMJDNINMGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x2757360", Offset = "0x2756360", VA = "0x182757360")]
	[AsyncStateMachine(typeof(NKJJAEFPMPM))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> HMHHJKJOIHP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public sealed class DIEHMIIHIII : GAKOAGFLBAB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private readonly JDNKJBFHNDM PLNEBCGHIDC;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public JDNKJBFHNDM PEGOAFKAAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	private DIEHMIIHIII(JDNKJBFHNDM HBEOFGDIPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x2756560", Offset = "0x2755560", VA = "0x182756560")]
	public static DIEHMIIHIII AKDPGDCBDMI(CHIEBOEDIPK IOIBNPDJCNE, AMICEDMCMOM JAPOHPBPBCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x2756750", Offset = "0x2755750", VA = "0x182756750", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public interface CMLPMCGBMAK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	KPBELAPACCB FDFMMKMOCDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	JGHDENAOIDJ PENIDCAANBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	CHIBFLIIPEI BPCFFGKGPON
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	GDHPHGOEDFD IKMBEHHBIHH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public interface APPFAIEDIHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	CMLPMCGBMAK? JDIEGKJMAEC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	bool DINPHDIMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	bool JBCLPPAPFNP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<CMLPMCGBMAK?>? NKLADMHDKHC();

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task MPEIIHEPKKJ(CHIEBOEDIPK IOIBNPDJCNE, AMICEDMCMOM JAPOHPBPBCE, DAPEGEJBKHJ? EAACMGNPBJM, HNAGJAILJOF? CLNJANHCMJK);
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[FCJMCJGJBOE("IStaticCV2Instance")]
public interface MGIDPOIGHNH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	KPBELAPACCB FDFMMKMOCDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
[FCJMCJGJBOE("IStaticEVInstance")]
public interface GAKOAGFLBAB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	JDNKJBFHNDM PEGOAFKAAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CD")]
public static class AIDBDMJIAED
{
	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x2753DD0", Offset = "0x2752DD0", VA = "0x182753DD0")]
	public static APNBNOIOAEH<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK, KIAIHFFPMKB.IIGBIEGDLEB<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK>> JPBBFEKBAGM([In] this APNBNOIOAEH<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK, KIAIHFFPMKB.IIGBIEGDLEB<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK>> IACBPLHEIBI)
	{
		return default(APNBNOIOAEH<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK, KIAIHFFPMKB.IIGBIEGDLEB<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class KHOBHPDGOKL : KMOLNCDGBHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private readonly CHIEBOEDIPK FBKDHJDLAOI;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool JBCLPPAPFNP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x276BA40", Offset = "0x276AA40", VA = "0x18276BA40", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	internal KHOBHPDGOKL(CHIEBOEDIPK IOIBNPDJCNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal sealed class GIDNBCJFJCB : JMMHNPNPOEP
{
	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x2763510", Offset = "0x2762510", VA = "0x182763510", Slot = "4")]
	public CKLHIANFCLG? DOBAEEFKNNE(string? PCMGNKOHCMI, string? KIHDBJCIMCF, string? LAPPFPKMCDH, FLBHDNOAEMF.MEOEOLPDHHE.JKBOCGPNCOP ELPDPLLJPIE, bool NAHAJHEIPMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public GIDNBCJFJCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public sealed class KMNAAACLCJB : BMLEPPHJDAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private struct GFOEKHJHEBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public AsyncTaskMethodBuilder<BOIDOHDBGAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public KMNAAACLCJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private TaskAwaiter<CMLPMCGBMAK?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x2763200", Offset = "0x2762200", VA = "0x182763200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x27634A0", Offset = "0x27624A0", VA = "0x1827634A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private readonly CHIEBOEDIPK FBKDHJDLAOI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public BOIDOHDBGAH? MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x276BB30", Offset = "0x276AB30", VA = "0x18276BB30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public GDHPHGOEDFD? MJDFGFDAHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x276C5A0", Offset = "0x276B5A0", VA = "0x18276C5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool OCCKMDALHIK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x276BBB0", Offset = "0x276ABB0", VA = "0x18276BBB0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool OEPHFDNLEOC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x276C540", Offset = "0x276B540", VA = "0x18276C540", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x276C620", Offset = "0x276B620", VA = "0x18276C620")]
	internal KMNAAACLCJB(CHIEBOEDIPK IOIBNPDJCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x276BC10", Offset = "0x276AC10", VA = "0x18276BC10", Slot = "7")]
	[AsyncStateMachine(typeof(GFOEKHJHEBD))]
	public Task<BOIDOHDBGAH> IOJJGNINCJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x276C1D0", Offset = "0x276B1D0", VA = "0x18276C1D0", Slot = "9")]
	public IReadOnlyDictionary<IGLPJBODKFE<BIEIIMCKPHN>, Guid> NLDDCODGGDL(IEnumerable<DJNGLNAIHJJ> EEBCGAFDBAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x276C040", Offset = "0x276B040", VA = "0x18276C040", Slot = "10")]
	public LIBBGGNKLIG MCECJOOBHMI(IEnumerable<DJNGLNAIHJJ> EEBCGAFDBAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x276BD00", Offset = "0x276AD00", VA = "0x18276BD00")]
	public HHHCCNLMPJL<OIBHFMBJDCN, HIKDGBNCNDJ> JKCEFEKHIAL([In] OIBHFMBJDCN NLDKPBHAAJP)
	{
		return default(HHHCCNLMPJL<OIBHFMBJDCN, HIKDGBNCNDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x276BEA0", Offset = "0x276AEA0", VA = "0x18276BEA0", Slot = "8")]
	private HHHCCNLMPJL<OIBHFMBJDCN, HIKDGBNCNDJ> JLJLJCMMKKO([In] OIBHFMBJDCN NLDKPBHAAJP)
	{
		return default(HHHCCNLMPJL<OIBHFMBJDCN, HIKDGBNCNDJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public sealed class GDHPHGOEDFD : BOIDOHDBGAH
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	internal static class AGDFFKAGMLK
	{
		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class IDOGFNOIENM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			public KPBELAPACCB state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			public CJNHJIPJPDB spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public IDOGFNOIENM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0x2778E10", Offset = "0x2777E10", VA = "0x182778E10")]
			internal bool JGMDHBGOAED(PMLOKGMHNIB n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		[CompilerGenerated]
		private sealed class FEPBGHKIIDF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
			public FEPBGHKIIDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0x2778520", Offset = "0x2777520", VA = "0x182778520")]
			internal void ENBBJGFHPAF(PMLOKGMHNIB n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x2774010", Offset = "0x2773010", VA = "0x182774010")]
		public static HHHCCNLMPJL<BOIDOHDBGAH.JKDMCLDJJOG, IADJFILHMLF> GDMALPFODEM(GDHPHGOEDFD OCACDKEJIIB, [In] BOIDOHDBGAH.HGCACJNGEEN ODJGLJIHJOP)
		{
			return default(HHHCCNLMPJL<BOIDOHDBGAH.JKDMCLDJJOG, IADJFILHMLF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x2774550", Offset = "0x2773550", VA = "0x182774550")]
		internal static HHHCCNLMPJL<(BJLNHBIBFME, GMILLKLCECE), IADJFILHMLF> KHLFKMOBHJK(GDHPHGOEDFD OCACDKEJIIB, GMILLKLCECE FPHADMNMECP, bool CNPMPIOPELL, [In] IGLPJBODKFE<BIEIIMCKPHN> PODKNGHCBKE, [In] int? FPOMHPLJKLF, [In] FGKPLMFNBOC? PJENHCHPGKB, [In] FGKPLMFNBOC? FAMIAPEPJGF)
		{
			return default(HHHCCNLMPJL<(BJLNHBIBFME, GMILLKLCECE), IADJFILHMLF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x2773A90", Offset = "0x2772A90", VA = "0x182773A90")]
		private static void EGIJLMGPECP(bool CNPMPIOPELL, DJNGLNAIHJJ BJPIFCHFNAA, BJLNHBIBFME BFGNODCMDFE, [In] IGLPJBODKFE<BIEIIMCKPHN> PODKNGHCBKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x2773690", Offset = "0x2772690", VA = "0x182773690")]
		public static void AJCBEIADCHC(NDHLGJGDGLN MEHCLCCOAPG, [In] BOIDOHDBGAH.CHLJEEKDAII CJGMIGKBNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x2773F20", Offset = "0x2772F20", VA = "0x182773F20")]
		[CompilerGenerated]
		internal static bool GCICDBDKMEG(KPBELAPACCB AOLFLFMEHMK, CJNHJIPJPDB KBGAODCBAAM, PMLOKGMHNIB DCOBAJMKGFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x27753C0", Offset = "0x27743C0", VA = "0x1827753C0")]
		[CompilerGenerated]
		internal static bool PHCIMLOJOBA(PMLOKGMHNIB MECICAJOHBD)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct LIDGCFFFGOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public EDBALDILLBK<BIEIIMCKPHN> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public EDBALDILLBK<ALEKBGLLPHJ> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public HOCBFPONHJI offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public bool deleteBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x277A020", Offset = "0x2779020", VA = "0x18277A020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x277A270", Offset = "0x2779270", VA = "0x18277A270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct HJGEJGOIGBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public EDBALDILLBK<BIEIIMCKPHN> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public IGLPJBODKFE<ALEKBGLLPHJ> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public List<EDBALDILLBK<ALEKBGLLPHJ>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public HOCBFPONHJI localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public GKMDHBAFLMJ localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public HOCBFPONHJI offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2778AE0", Offset = "0x2777AE0", VA = "0x182778AE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2778DA0", Offset = "0x2777DA0", VA = "0x182778DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct JIBAEIBFEAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public EDBALDILLBK<BIEIIMCKPHN> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public IGLPJBODKFE<ALEKBGLLPHJ> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public List<EDBALDILLBK<ALEKBGLLPHJ>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x27796B0", Offset = "0x27786B0", VA = "0x1827796B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x27798F0", Offset = "0x27788F0", VA = "0x1827798F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct EIGNBPEKDJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public EDBALDILLBK<BIEIIMCKPHN> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public IGLPJBODKFE<ALEKBGLLPHJ> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public List<EDBALDILLBK<ALEKBGLLPHJ>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x27772E0", Offset = "0x27762E0", VA = "0x1827772E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x2777520", Offset = "0x2776520", VA = "0x182777520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct ELCGHEJHPFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public IGLPJBODKFE<BIEIIMCKPHN> legacyGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public IGLPJBODKFE<ALEKBGLLPHJ> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public IReadOnlyList<IGLPJBODKFE<ALEKBGLLPHJ>> nodeLegacyIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public IReadOnlyDictionary<BONKIFIDLBA, (EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<IFOKEFFHPOH>)> inputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public IReadOnlyDictionary<PIPFDBHCILD, (EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<HPDCGGEBOAB>)> outputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2777590", Offset = "0x2776590", VA = "0x182777590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2777B40", Offset = "0x2776B40", VA = "0x182777B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private struct CBLBCACFENC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public EDBALDILLBK<MBCPFFKFBDC> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public EDBALDILLBK<AIHJLHNMKCJ> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x2775DB0", Offset = "0x2774DB0", VA = "0x182775DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x2776400", Offset = "0x2775400", VA = "0x182776400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct CGHDFNNAKAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<EDBALDILLBK<ALEKBGLLPHJ>, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public EDBALDILLBK<APOJALOJJAE> nodeDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public HOCBFPONHJI localSpacePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public GKMDHBAFLMJ localSpaceRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private KPBELAPACCB <state>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private TaskAwaiter<HHHCCNLMPJL<Guid, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x27766D0", Offset = "0x27756D0", VA = "0x1827766D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x2776B50", Offset = "0x2775B50", VA = "0x182776B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct MENKMANDDLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public EDBALDILLBK<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private TaskAwaiter<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x277BD60", Offset = "0x277AD60", VA = "0x18277BD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x277C000", Offset = "0x277B000", VA = "0x18277C000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private struct LFOMLDFDBKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public IGLPJBODKFE<ALEKBGLLPHJ> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public IGLPJBODKFE<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public EDBALDILLBK<MECIAIKJJDL> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public EDBALDILLBK<IFOKEFFHPOH> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x2779C70", Offset = "0x2778C70", VA = "0x182779C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x2779FB0", Offset = "0x2778FB0", VA = "0x182779FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private struct COIIIDHKIGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public IGLPJBODKFE<ALEKBGLLPHJ> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public IGLPJBODKFE<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public EDBALDILLBK<MECIAIKJJDL> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public EDBALDILLBK<HPDCGGEBOAB> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x2776BC0", Offset = "0x2775BC0", VA = "0x182776BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x2776F00", Offset = "0x2775F00", VA = "0x182776F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private struct JGECLJNOOFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public EDBALDILLBK<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x2778F60", Offset = "0x2777F60", VA = "0x182778F60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x2779250", Offset = "0x2778250", VA = "0x182779250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private struct ABEJLBKANKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<IEnumerable<IGLPJBODKFE<ALEKBGLLPHJ>>, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public IGLPJBODKFE<BIEIIMCKPHN> intoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public IEnumerable<DJNGLNAIHJJ> persistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public GMILLKLCECE templateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		private TaskAwaiter<HHHCCNLMPJL<IEnumerable<GDCCFCAPGMP>, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x2772D00", Offset = "0x2771D00", VA = "0x182772D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x2773390", Offset = "0x2772390", VA = "0x182773390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class AFAKPBOIAKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public EDBALDILLBK<BIEIIMCKPHN> sourceGraphId;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public AFAKPBOIAKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x2773400", Offset = "0x2772400", VA = "0x182773400")]
		internal IGLPJBODKFE<ALEKBGLLPHJ> OGCENBPFANP(EDBALDILLBK<ALEKBGLLPHJ> i)
		{
			return default(IGLPJBODKFE<ALEKBGLLPHJ>);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct OMEANLLHBOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x277CAC0", Offset = "0x277BAC0", VA = "0x18277CAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x277CCE0", Offset = "0x277BCE0", VA = "0x18277CCE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private struct OAKDDNLHHMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public EDBALDILLBK<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x277C660", Offset = "0x277B660", VA = "0x18277C660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x277C900", Offset = "0x277B900", VA = "0x18277C900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private struct FAOKPONNBMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public EDBALDILLBK<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public EDBALDILLBK<MECIAIKJJDL> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public EDBALDILLBK<KCPNHNINCKC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x2778140", Offset = "0x2777140", VA = "0x182778140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x27784B0", Offset = "0x27774B0", VA = "0x1827784B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private struct NBAMFMKFBLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public EDBALDILLBK<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public EDBALDILLBK<MECIAIKJJDL> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public EDBALDILLBK<KCPNHNINCKC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x277C070", Offset = "0x277B070", VA = "0x18277C070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x277C4E0", Offset = "0x277B4E0", VA = "0x18277C4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct DCONIFFGABC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public EDBALDILLBK<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x2776FD0", Offset = "0x2775FD0", VA = "0x182776FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x2777270", Offset = "0x2776270", VA = "0x182777270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct PINHOAOJDIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public EDBALDILLBK<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public HOCBFPONHJI localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public GKMDHBAFLMJ localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x277CD50", Offset = "0x277BD50", VA = "0x18277CD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x277D0A0", Offset = "0x277C0A0", VA = "0x18277D0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	private readonly CHIEBOEDIPK FBKDHJDLAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private readonly MGIDPOIGHNH IHDCNDNFOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private readonly GAKOAGFLBAB CANFDJPCDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private readonly OMPJEELBIEL INBDDKMBHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private readonly KMNAAACLCJB OPANIFPHBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private Dictionary<IGLPJBODKFE<ALEKBGLLPHJ>, CBDBLPHCHLP> LOJIEBKCALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	[CompilerGenerated]
	private Action<IGLPJBODKFE<ALEKBGLLPHJ>>? GHBBKKJBBCP;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public IGLPJBODKFE<BIEIIMCKPHN> FLIIBLGEOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x275DDB0", Offset = "0x275CDB0", VA = "0x18275DDB0", Slot = "4")]
		get
		{
			return default(IGLPJBODKFE<BIEIIMCKPHN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public OMPJEELBIEL EADIBKJPHLP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x2739290", Offset = "0x2738290", VA = "0x182739290", Slot = "5")]
		get
		{
			return default(OMPJEELBIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x2762B50", Offset = "0x2761B50", VA = "0x182762B50")]
	public GDHPHGOEDFD(CHIEBOEDIPK IOIBNPDJCNE, MGIDPOIGHNH FKPENEKJEBL, GAKOAGFLBAB FGCGPJAFJOJ, KMNAAACLCJB HCGLPHPPLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x275F0B0", Offset = "0x275E0B0", VA = "0x18275F0B0", Slot = "83")]
	public EDBALDILLBK<FNLFDFELNJP> JIEIJKABFPJ(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP)
	{
		return default(EDBALDILLBK<FNLFDFELNJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2760560", Offset = "0x275F560", VA = "0x182760560", Slot = "84")]
	public EDBALDILLBK<CJHCCMIKJOI> LOKHNJBGBGP(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB)
	{
		return default(EDBALDILLBK<CJHCCMIKJOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x275B8F0", Offset = "0x275A8F0", VA = "0x18275B8F0", Slot = "6")]
	public (bool, bool) BPJFFILGFML(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> DNALEDMNCKH, EDBALDILLBK<AIHJLHNMKCJ> EMINHKBJOFH)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x275C1D0", Offset = "0x275B1D0", VA = "0x18275C1D0")]
	public bool DDJAAGAJJMG(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, [In] KMHJEOLAADO DHBHHDJFOLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x275C7F0", Offset = "0x275B7F0", VA = "0x18275C7F0", Slot = "8")]
	public bool DMJENECLFKI(IKPGAMHHELO EGIEFBPGJCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x275EE60", Offset = "0x275DE60", VA = "0x18275EE60", Slot = "9")]
	public bool JBMDNBLFFAI(EDLMBADJAJJ BIEKNOCAJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x275AC70", Offset = "0x2759C70", VA = "0x18275AC70", Slot = "10")]
	public GEOFGJGIEDO? AJEHJNEALBL(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x275EA20", Offset = "0x275DA20", VA = "0x18275EA20", Slot = "11")]
	public PBDPJBEGCAN? ILGDJOHBCNE(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x275CC90", Offset = "0x275BC90", VA = "0x18275CC90", Slot = "12")]
	public EDBALDILLBK<MBCPFFKFBDC>? ENPIOFDJKLC(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<HPDCGGEBOAB> MOJFMLAABNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x275DC90", Offset = "0x275CC90", VA = "0x18275DC90", Slot = "13")]
	public EDBALDILLBK<AIHJLHNMKCJ>? GBALHODLAMB(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<IFOKEFFHPOH> DNBAGCFNADG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x275EDD0", Offset = "0x275DDD0", VA = "0x18275EDD0", Slot = "14")]
	public IEnumerable<EDBALDILLBK<BIEIIMCKPHN>> JBHKHGGACKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x275DE40", Offset = "0x275CE40", VA = "0x18275DE40", Slot = "15")]
	public IEnumerable<EDBALDILLBK<MLLNMGCLGAP>> GGOFDJDBDNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x275C710", Offset = "0x275B710", VA = "0x18275C710", Slot = "16")]
	public string DKNIGPFIJKK(EDBALDILLBK<MLLNMGCLGAP> ODCAHNKPDOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2762700", Offset = "0x2761700", VA = "0x182762700", Slot = "17")]
	public string PFBEOAFHAHP(EDBALDILLBK<MLLNMGCLGAP> ODCAHNKPDOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x275B1F0", Offset = "0x275A1F0", VA = "0x18275B1F0")]
	public CBDBLPHCHLP? BGLAGCIKMIA([In] IGLPJBODKFE<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x275FC80", Offset = "0x275EC80", VA = "0x18275FC80", Slot = "23")]
	public EDBALDILLBK<APOJALOJJAE> KACMFOJIDHL(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return default(EDBALDILLBK<APOJALOJJAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x275EEE0", Offset = "0x275DEE0", VA = "0x18275EEE0")]
	public EDBALDILLBK<ALEKBGLLPHJ> JBOCPBIKBPG(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, [In] IGLPJBODKFE<ALEKBGLLPHJ> HEIKAAMLBBH)
	{
		return default(EDBALDILLBK<ALEKBGLLPHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2762680", Offset = "0x2761680", VA = "0x182762680", Slot = "33")]
	public EDBALDILLBK<ALEKBGLLPHJ> PEKMCEIBOAB(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP)
	{
		return default(EDBALDILLBK<ALEKBGLLPHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x275B360", Offset = "0x275A360", VA = "0x18275B360", Slot = "34")]
	public EDBALDILLBK<ALEKBGLLPHJ> BIKNLBBEAOK(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB)
	{
		return default(EDBALDILLBK<ALEKBGLLPHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x275DB90", Offset = "0x275CB90", VA = "0x18275DB90")]
	public EDBALDILLBK<ALEKBGLLPHJ>? FJBAILLEFFJ(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, [In] IGLPJBODKFE<ALEKBGLLPHJ> HEIKAAMLBBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2760430", Offset = "0x275F430", VA = "0x182760430", Slot = "25")]
	public PPJHOOAIDEI? LFHBDDBOIJH(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x275AEA0", Offset = "0x2759EA0", VA = "0x18275AEA0", Slot = "26")]
	public long AKLHPDBJOMJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x275E990", Offset = "0x275D990", VA = "0x18275E990")]
	private void IEIJBJHEBNJ(IGLPJBODKFE<ALEKBGLLPHJ> MIEKOPKCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x275FFF0", Offset = "0x275EFF0", VA = "0x18275FFF0", Slot = "31")]
	public IEnumerable<(EDBALDILLBK<BIEIIMCKPHN>, EDBALDILLBK<ALEKBGLLPHJ>)> KJKFFPJIGCI(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x275DD20", Offset = "0x275CD20", VA = "0x18275DD20", Slot = "32")]
	public EDBALDILLBK<AIHJLHNMKCJ> GBALHODLAMB(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<FNLFDFELNJP> DNBAGCFNADG)
	{
		return default(EDBALDILLBK<AIHJLHNMKCJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x275CC00", Offset = "0x275BC00", VA = "0x18275CC00", Slot = "35")]
	public EDBALDILLBK<MBCPFFKFBDC> ENPIOFDJKLC(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<CJHCCMIKJOI> MOJFMLAABNF)
	{
		return default(EDBALDILLBK<MBCPFFKFBDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x27621C0", Offset = "0x27611C0", VA = "0x1827621C0")]
	private CBDBLPHCHLP? ODAMNEHJEDM([In] IGLPJBODKFE<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x275AF00", Offset = "0x2759F00", VA = "0x18275AF00")]
	public GDCCFCAPGMP? AMNCGKGEBMF([In] IGLPJBODKFE<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x275BF50", Offset = "0x275AF50", VA = "0x18275BF50")]
	public KKGGGAABFLL? DABEFHHLNPJ([In] IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2760740", Offset = "0x275F740", VA = "0x182760740", Slot = "27")]
	public IEnumerable<JCNMIPMAFLG> MDBMHAPNGKB(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x275FF60", Offset = "0x275EF60", VA = "0x18275FF60", Slot = "28")]
	public bool KHIGIJLGFIE(EDBALDILLBK<MLLNMGCLGAP> ODCAHNKPDOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2762770", Offset = "0x2761770", VA = "0x182762770", Slot = "29")]
	public IEnumerable<KMHJEOLAADO> PHLJCFJGNKO(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> DNALEDMNCKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x275D910", Offset = "0x275C910", VA = "0x18275D910", Slot = "30")]
	public IEnumerable<KMHJEOLAADO> FFLEHFAMEFD(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> EMINHKBJOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x275DC10", Offset = "0x275CC10", VA = "0x18275DC10")]
	public EDBALDILLBK<BIEIIMCKPHN> FPIFMFOEOFB([In] IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return default(EDBALDILLBK<BIEIIMCKPHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x275D3F0", Offset = "0x275C3F0", VA = "0x18275D3F0")]
	public EDBALDILLBK<BIEIIMCKPHN>? IMMNDMGFFCP([In] IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x275C650", Offset = "0x275B650", VA = "0x18275C650")]
	private CJNHJIPJPDB? DJFOIPOPLJI([In] IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x275BF50", Offset = "0x275AF50", VA = "0x18275BF50")]
	private KKGGGAABFLL? DOEGDHEFPHG([In] IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2761B80", Offset = "0x2760B80", VA = "0x182761B80", Slot = "21")]
	public EDBALDILLBK<BIEIIMCKPHN>? NGKGPKKPJLD(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x27602B0", Offset = "0x275F2B0", VA = "0x1827602B0", Slot = "39")]
	public IGLPJBODKFE<BIEIIMCKPHN> LBOOABGFNCH(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return default(IGLPJBODKFE<BIEIIMCKPHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x275E470", Offset = "0x275D470", VA = "0x18275E470", Slot = "40")]
	public IGLPJBODKFE<ALEKBGLLPHJ> HGHKGOMHDJF(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return default(IGLPJBODKFE<ALEKBGLLPHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x275C0D0", Offset = "0x275B0D0", VA = "0x18275C0D0", Slot = "36")]
	public IEnumerable<ACLPKCGEGFP> DCKPKGICJFJ(BDPALJAAJCF LHKMBAFKDBN, bool GFDNNEFBKFI, bool EDCEJIMLGNN, bool IIHGDNJMBDP, bool DHCFCOAKGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x275A970", Offset = "0x2759970", VA = "0x18275A970", Slot = "37")]
	public ACLPKCGEGFP AABFGEHOCLD(BDPALJAAJCF LHKMBAFKDBN, HGIFBECBIMN IAAAGGKEHFO, bool GFDNNEFBKFI, bool EDCEJIMLGNN, bool IIHGDNJMBDP, bool DHCFCOAKGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x275AD30", Offset = "0x2759D30", VA = "0x18275AD30")]
	public JCNMIPMAFLG EFJFDLKHCMM(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, [In] KMHJEOLAADO DHBHHDJFOLL)
	{
		return default(JCNMIPMAFLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x275E240", Offset = "0x275D240", VA = "0x18275E240", Slot = "41")]
	public KMHJEOLAADO HEOCDNKMPOC(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> DNALEDMNCKH, EDBALDILLBK<AIHJLHNMKCJ> EMINHKBJOFH)
	{
		return default(KMHJEOLAADO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2761CB0", Offset = "0x2760CB0", VA = "0x182761CB0", Slot = "42")]
	[AsyncStateMachine(typeof(LIDGCFFFGOJ))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> NGNEAPIAHGB(EDBALDILLBK<BIEIIMCKPHN> NPCOCKHNIOK, EDBALDILLBK<ALEKBGLLPHJ> CHIEFBDHPKP, HOCBFPONHJI LLPAIMMACAP, bool PIDDFONOHBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x275F130", Offset = "0x275E130", VA = "0x18275F130", Slot = "43")]
	[AsyncStateMachine(typeof(HJGEJGOIGBF))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> JLGIFPECEEK(EDBALDILLBK<BIEIIMCKPHN> NPCOCKHNIOK, IGLPJBODKFE<ALEKBGLLPHJ> CHIEFBDHPKP, List<EDBALDILLBK<ALEKBGLLPHJ>> HJGPIGMNBKJ, HOCBFPONHJI GMBPGDONOJH, GKMDHBAFLMJ LMNFECIGMFD, HOCBFPONHJI LLPAIMMACAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x275BF80", Offset = "0x275AF80", VA = "0x18275BF80", Slot = "46")]
	[AsyncStateMachine(typeof(JIBAEIBFEAH))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> DCDPHPAAPBJ(EDBALDILLBK<BIEIIMCKPHN> NPCOCKHNIOK, IGLPJBODKFE<ALEKBGLLPHJ> CHIEFBDHPKP, List<EDBALDILLBK<ALEKBGLLPHJ>> HJGPIGMNBKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x27623C0", Offset = "0x27613C0", VA = "0x1827623C0", Slot = "47")]
	[AsyncStateMachine(typeof(EIGNBPEKDJM))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> OOBPEENCKJH(EDBALDILLBK<BIEIIMCKPHN> NPCOCKHNIOK, IGLPJBODKFE<ALEKBGLLPHJ> CHIEFBDHPKP, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, List<EDBALDILLBK<ALEKBGLLPHJ>> HJGPIGMNBKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x2760E60", Offset = "0x275FE60", VA = "0x182760E60", Slot = "44")]
	public (IReadOnlyDictionary<BONKIFIDLBA, (EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<IFOKEFFHPOH>)>, IReadOnlyDictionary<PIPFDBHCILD, (EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<HPDCGGEBOAB>)>) MPMKKOMKKPJ(IGLPJBODKFE<BIEIIMCKPHN> IBFMGHMCEGJ, EDBALDILLBK<ALEKBGLLPHJ> CHIEFBDHPKP)
	{
		return default((IReadOnlyDictionary<BONKIFIDLBA, (EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<IFOKEFFHPOH>)>, IReadOnlyDictionary<PIPFDBHCILD, (EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<HPDCGGEBOAB>)>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x275C500", Offset = "0x275B500", VA = "0x18275C500", Slot = "45")]
	[AsyncStateMachine(typeof(ELCGHEJHPFI))]
	public Task DIHDBDMPDMJ(IGLPJBODKFE<BIEIIMCKPHN> IBFMGHMCEGJ, IGLPJBODKFE<ALEKBGLLPHJ> CHIEFBDHPKP, IReadOnlyList<IGLPJBODKFE<ALEKBGLLPHJ>> PCEPNOKNDMM, IReadOnlyDictionary<BONKIFIDLBA, (EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<IFOKEFFHPOH>)> OAAPKHKAAOJ, IReadOnlyDictionary<PIPFDBHCILD, (EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<HPDCGGEBOAB>)> ENDHCKGCDCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x275C780", Offset = "0x275B780", VA = "0x18275C780", Slot = "48")]
	public bool DKNNJEIEBDH(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x275EAE0", Offset = "0x275DAE0", VA = "0x18275EAE0", Slot = "49")]
	public bool INDFKGEHBOO(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x275E4F0", Offset = "0x275D4F0", VA = "0x18275E4F0", Slot = "50")]
	public bool HGJMEGMIJLL(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x275DE10", Offset = "0x275CE10", VA = "0x18275DE10")]
	public HHHCCNLMPJL<BOIDOHDBGAH.JKDMCLDJJOG, IADJFILHMLF> MAANCKNPMCC([In] BOIDOHDBGAH.HGCACJNGEEN ODJGLJIHJOP)
	{
		return default(HHHCCNLMPJL<BOIDOHDBGAH.JKDMCLDJJOG, IADJFILHMLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x275E6A0", Offset = "0x275D6A0", VA = "0x18275E6A0", Slot = "52")]
	[AsyncStateMachine(typeof(CBLBCACFENC))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> IAPMLLKCCHM(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> DNALEDMNCKH, EDBALDILLBK<AIHJLHNMKCJ> EMINHKBJOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x275B3E0", Offset = "0x275A3E0", VA = "0x18275B3E0", Slot = "53")]
	[AsyncStateMachine(typeof(CGHDFNNAKAN))]
	public Task<HHHCCNLMPJL<EDBALDILLBK<ALEKBGLLPHJ>, DLKBDBKHJCC>> BIOMAGGFBNK(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<APOJALOJJAE> OKDEOJNBJMA, HOCBFPONHJI ABEEIHCHBIJ, GKMDHBAFLMJ CPOAGMMGJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2760870", Offset = "0x275F870", VA = "0x182760870", Slot = "54")]
	[AsyncStateMachine(typeof(MENKMANDDLG))]
	public Task<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> MEKEELJOADP(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, string NFHOBPDKIPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2760AA0", Offset = "0x275FAA0", VA = "0x182760AA0", Slot = "55")]
	public HHHCCNLMPJL<EONIJHPHNEL, HIKDGBNCNDJ> MIOKHAKHKCO(IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD, EONIJHPHNEL OLOIADOHGAE, GKMDHBAFLMJ JOICDDJMBNO)
	{
		return default(HHHCCNLMPJL<EONIJHPHNEL, HIKDGBNCNDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2762520", Offset = "0x2761520", VA = "0x182762520", Slot = "56")]
	[AsyncStateMachine(typeof(LFOMLDFDBKK))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> PAHJJMEJGGI(IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD, IGLPJBODKFE<ALEKBGLLPHJ> IMOFGHNDPPL, EDBALDILLBK<MECIAIKJJDL> LOJNBPLGDKF, EDBALDILLBK<IFOKEFFHPOH> MOOIAANOCKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x27629F0", Offset = "0x27619F0", VA = "0x1827629F0", Slot = "57")]
	[AsyncStateMachine(typeof(COIIIDHKIGO))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> PMFMOEGEBKH(IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD, IGLPJBODKFE<ALEKBGLLPHJ> BGGDFAMPIAJ, EDBALDILLBK<MECIAIKJJDL> EPFMHBIFCFJ, EDBALDILLBK<HPDCGGEBOAB> NJKENGKIHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2760320", Offset = "0x275F320", VA = "0x182760320", Slot = "58")]
	[AsyncStateMachine(typeof(JGECLJNOOFC))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> LCFHBOHOLDF(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x275BDF0", Offset = "0x275ADF0", VA = "0x18275BDF0", Slot = "59")]
	[AsyncStateMachine(typeof(ABEJLBKANKA))]
	public Task<HHHCCNLMPJL<IEnumerable<IGLPJBODKFE<ALEKBGLLPHJ>>, DLKBDBKHJCC>> CIBKNEFOAOP(IGLPJBODKFE<BIEIIMCKPHN> BLGHMAJKCIC, GMILLKLCECE LPMBCJIIDDD, IEnumerable<DJNGLNAIHJJ> NCOPFNGDDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x275FE40", Offset = "0x275EE40", VA = "0x18275FE40", Slot = "60")]
	public PAMKGMKMNNM KCPKPNDPEKE()
	{
		return default(PAMKGMKMNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x275B0D0", Offset = "0x275A0D0", VA = "0x18275B0D0", Slot = "61")]
	public PAMKGMKMNNM BBCACGFMEFG()
	{
		return default(PAMKGMKMNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x27619A0", Offset = "0x27609A0", VA = "0x1827619A0", Slot = "64")]
	public KDIECECJFKA NGJCNGMKGIL(HMPEPPHBKMF CBHCMEKADCN, EDBALDILLBK<BIEIIMCKPHN> GKPONEBNEEG, IEnumerable<IGLPJBODKFE<BIEIIMCKPHN>> ABPNPJLODEN, IEnumerable<IGLPJBODKFE<ALEKBGLLPHJ>> HJGPIGMNBKJ, ISet<IGLPJBODKFE<CDCOOBOKPHM>>? HOBHPPOOAMH)
	{
		return default(KDIECECJFKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x275E7D0", Offset = "0x275D7D0", VA = "0x18275E7D0")]
	private KDIECECJFKA ICDELCGCAAF(HMPEPPHBKMF CBHCMEKADCN, EDBALDILLBK<BIEIIMCKPHN> GKPONEBNEEG, IEnumerable<IGLPJBODKFE<BIEIIMCKPHN>> ABPNPJLODEN, IEnumerable<IGLPJBODKFE<ALEKBGLLPHJ>> HJGPIGMNBKJ, ISet<IGLPJBODKFE<CDCOOBOKPHM>>? HOBHPPOOAMH)
	{
		return default(KDIECECJFKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x275B650", Offset = "0x275A650", VA = "0x18275B650", Slot = "62")]
	public KDIECECJFKA BJNEAMIEBAB(HMPEPPHBKMF CBHCMEKADCN, EDBALDILLBK<BIEIIMCKPHN> GKPONEBNEEG, IEnumerable<IGLPJBODKFE<ALEKBGLLPHJ>> HJGPIGMNBKJ, IEnumerable<DJNGLNAIHJJ> NCOPFNGDDLG, ISet<IGLPJBODKFE<CDCOOBOKPHM>>? HOBHPPOOAMH)
	{
		return default(KDIECECJFKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x275B540", Offset = "0x275A540", VA = "0x18275B540", Slot = "63")]
	public KDIECECJFKA BJNEAMIEBAB(HMPEPPHBKMF CBHCMEKADCN, EDBALDILLBK<BIEIIMCKPHN> GKPONEBNEEG, IEnumerable<EDBALDILLBK<ALEKBGLLPHJ>> HJGPIGMNBKJ, IEnumerable<DJNGLNAIHJJ> NCOPFNGDDLG, ISet<IGLPJBODKFE<CDCOOBOKPHM>>? HOBHPPOOAMH)
	{
		return default(KDIECECJFKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x275C880", Offset = "0x275B880", VA = "0x18275C880")]
	private static IEnumerable<IGLPJBODKFE<BIEIIMCKPHN>> EMGBIJIPFCJ(IEnumerable<DJNGLNAIHJJ> NCOPFNGDDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x275D470", Offset = "0x275C470", VA = "0x18275D470")]
	private IEnumerable<IGLPJBODKFE<ALEKBGLLPHJ>> FFKEFODPPEF(IEnumerable<DJNGLNAIHJJ> NCOPFNGDDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x275FDB0", Offset = "0x275EDB0", VA = "0x18275FDB0", Slot = "65")]
	public List<ONMAHNABKDP> KCIKHHHEPLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x275CD20", Offset = "0x275BD20", VA = "0x18275CD20")]
	public (List<ONMAHNABKDP>, bool) FDHOHBJKBNK([In] LHCCLMLBLGM PPPGHBABFJK, string INLEBAAACKH, [In] EHAADHBFEAM NHNPKEBGCGG, KDHKOJLLBIL DHGPBJNAEKO, DICPKAJKOBM HMMHOCJLLOI)
	{
		return default((List<ONMAHNABKDP>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x27605E0", Offset = "0x275F5E0", VA = "0x1827605E0", Slot = "67")]
	public bool LPFAAPMAOIF(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x275E030", Offset = "0x275D030", VA = "0x18275E030")]
	internal void HBDKJOCPEPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x2760250", Offset = "0x275F250", VA = "0x182760250")]
	internal Task KNOFGBJOFBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x275F2B0", Offset = "0x275E2B0", VA = "0x18275F2B0", Slot = "68")]
	public HHHCCNLMPJL<EDBALDILLBK<MBCPFFKFBDC>?, DLKBDBKHJCC> JMOIOPLFBDA(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP)
	{
		return default(HHHCCNLMPJL<EDBALDILLBK<MBCPFFKFBDC>?, DLKBDBKHJCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x2760FD0", Offset = "0x275FFD0", VA = "0x182760FD0", Slot = "69")]
	public HHHCCNLMPJL<EDBALDILLBK<AIHJLHNMKCJ>?, DLKBDBKHJCC> NDFNIGKEDDH(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB)
	{
		return default(HHHCCNLMPJL<EDBALDILLBK<AIHJLHNMKCJ>?, DLKBDBKHJCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x2761E00", Offset = "0x2760E00", VA = "0x182761E00", Slot = "70")]
	[AsyncStateMachine(typeof(OMEANLLHBOC))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> NLDLAIGCHNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x2760110", Offset = "0x275F110", VA = "0x182760110", Slot = "71")]
	[AsyncStateMachine(typeof(OAKDDNLHHMD))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> KNCCANLNGGB(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, string NFHOBPDKIPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x275E570", Offset = "0x275D570", VA = "0x18275E570", Slot = "72")]
	public EDBALDILLBK<ALEKBGLLPHJ>? HKNDGHLKPFL(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x275E110", Offset = "0x275D110", VA = "0x18275E110", Slot = "73")]
	public EDBALDILLBK<ALEKBGLLPHJ>? HDLJJHMLMPI(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x275FD00", Offset = "0x275ED00", VA = "0x18275FD00", Slot = "74")]
	public int KAEFFNPJEKK(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x27609B0", Offset = "0x275F9B0", VA = "0x1827609B0", Slot = "75")]
	public int MFGOJLJCMGH(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2761F60", Offset = "0x2760F60", VA = "0x182761F60", Slot = "76")]
	public int OAGBBDDOOGL(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x275EB60", Offset = "0x275DB60", VA = "0x18275EB60", Slot = "77")]
	public int INODKOBBICN(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x275AF90", Offset = "0x2759F90", VA = "0x18275AF90", Slot = "78")]
	[AsyncStateMachine(typeof(FAOKPONNBMJ))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> BAEDGLMBFOK(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x275DEF0", Offset = "0x275CEF0", VA = "0x18275DEF0", Slot = "79")]
	[AsyncStateMachine(typeof(NBAMFMKFBLO))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> GLCLJEFNFAD(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x275EF60", Offset = "0x275DF60", VA = "0x18275EF60", Slot = "80")]
	public int JCMDBAIFABO(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x2762270", Offset = "0x2761270", VA = "0x182762270", Slot = "81")]
	[AsyncStateMachine(typeof(DCONIFFGABC))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> OKHFBPJODEJ(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, string OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x275EC70", Offset = "0x275DC70", VA = "0x18275EC70", Slot = "82")]
	[AsyncStateMachine(typeof(PINHOAOJDIC))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> IPOIBEMLDEI(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, HOCBFPONHJI IHMLAPGNLCC, GKMDHBAFLMJ JHMNNKLOODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x27623B0", Offset = "0x27613B0", VA = "0x1827623B0", Slot = "7")]
	private bool OOBNELDPIOE(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, [In] KMHJEOLAADO DHBHHDJFOLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x275BF50", Offset = "0x275AF50", VA = "0x18275BF50", Slot = "18")]
	private KKGGGAABFLL DGBLMGNCFLO([In] IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x275C870", Offset = "0x275B870", VA = "0x18275C870", Slot = "19")]
	private EDBALDILLBK<BIEIIMCKPHN> EIKNEMDBEIG([In] IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return default(EDBALDILLBK<BIEIIMCKPHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x275D3F0", Offset = "0x275C3F0", VA = "0x18275D3F0", Slot = "20")]
	private EDBALDILLBK<BIEIIMCKPHN>? FDIDGNCHLAB([In] IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x2762070", Offset = "0x2761070", VA = "0x182762070", Slot = "22")]
	private CBDBLPHCHLP OAHIOOLKEPL([In] IGLPJBODKFE<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x275F040", Offset = "0x275E040", VA = "0x18275F040", Slot = "24")]
	private EDBALDILLBK<ALEKBGLLPHJ> JFPLJOPIONB(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, [In] IGLPJBODKFE<ALEKBGLLPHJ> HEIKAAMLBBH)
	{
		return default(EDBALDILLBK<ALEKBGLLPHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x275AD30", Offset = "0x2759D30", VA = "0x18275AD30", Slot = "38")]
	private JCNMIPMAFLG AJLOKIBJFOE(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, [In] KMHJEOLAADO DHBHHDJFOLL)
	{
		return default(JCNMIPMAFLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x275DE10", Offset = "0x275CE10", VA = "0x18275DE10", Slot = "51")]
	private HHHCCNLMPJL<BOIDOHDBGAH.JKDMCLDJJOG, IADJFILHMLF> GFGKLKCGELF([In] BOIDOHDBGAH.HGCACJNGEEN ODJGLJIHJOP)
	{
		return default(HHHCCNLMPJL<BOIDOHDBGAH.JKDMCLDJJOG, IADJFILHMLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x275F050", Offset = "0x275E050", VA = "0x18275F050", Slot = "66")]
	private (List<ONMAHNABKDP>, bool) JHPBLAOGABD([In] LHCCLMLBLGM PPPGHBABFJK, string INLEBAAACKH, [In] EHAADHBFEAM NHNPKEBGCGG, KDHKOJLLBIL DHGPBJNAEKO, DICPKAJKOBM HMMHOCJLLOI)
	{
		return default((List<ONMAHNABKDP>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x275E090", Offset = "0x275D090", VA = "0x18275E090")]
	[CompilerGenerated]
	private FGCFEGCGMAK HDDCPECHJMD(HJDEFPFJDOJ DEBKJNNAPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2760800", Offset = "0x275F800", VA = "0x182760800")]
	[CompilerGenerated]
	private GDCCFCAPGMP MDOPKNNBEKB(IGLPJBODKFE<ALEKBGLLPHJ> DEBKJNNAPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2761EF0", Offset = "0x2760EF0", VA = "0x182761EF0")]
	[CompilerGenerated]
	private CJNHJIPJPDB NOHLJEMGMNG(IGLPJBODKFE<BIEIIMCKPHN> DEBKJNNAPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x27600A0", Offset = "0x275F0A0", VA = "0x1827600A0")]
	[CompilerGenerated]
	private GDCCFCAPGMP KMGIHHBBNOO(IGLPJBODKFE<ALEKBGLLPHJ> DEBKJNNAPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x27606D0", Offset = "0x275F6D0", VA = "0x1827606D0")]
	[CompilerGenerated]
	private CJNHJIPJPDB MCHJMPNAMOJ(IGLPJBODKFE<BIEIIMCKPHN> DEBKJNNAPAB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public sealed class FGCFEGCGMAK : ACLPKCGEGFP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct PNPKONNBMHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<EDBALDILLBK<KCPNHNINCKC>, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public FGCFEGCGMAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public IGLPJBODKFE<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public IGLPJBODKFE<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public EDBALDILLBK<MECIAIKJJDL> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private TaskAwaiter<HHHCCNLMPJL<EDBALDILLBK<KCPNHNINCKC>, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x277D110", Offset = "0x277C110", VA = "0x18277D110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x277D390", Offset = "0x277C390", VA = "0x18277D390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct ELPJKDDALII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<EDBALDILLBK<LGADIHOLJAO>, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public FGCFEGCGMAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public IGLPJBODKFE<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public IGLPJBODKFE<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public EDBALDILLBK<MECIAIKJJDL> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private TaskAwaiter<HHHCCNLMPJL<EDBALDILLBK<LGADIHOLJAO>, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x2777BA0", Offset = "0x2776BA0", VA = "0x182777BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x2777E20", Offset = "0x2776E20", VA = "0x182777E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400033A")]
	private readonly HJDEFPFJDOJ PLLBJECBPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly MGIDPOIGHNH IHDCNDNFOPP;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public TypeKey HEAGAKFJNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xBEA640", Offset = "0xBE9640", VA = "0x180BEA640", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public string MPEGGBIEOKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x2778820", Offset = "0x2777820", VA = "0x182778820", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public HJDEFPFJDOJ KKNBAMLGLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x2778850", Offset = "0x2777850", VA = "0x182778850")]
	public FGCFEGCGMAK(HJDEFPFJDOJ JIPIEFCLIID, MGIDPOIGHNH FKPENEKJEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2778540", Offset = "0x2777540", VA = "0x182778540", Slot = "6")]
	[AsyncStateMachine(typeof(PNPKONNBMHG))]
	public Task<HHHCCNLMPJL<EDBALDILLBK<KCPNHNINCKC>, DLKBDBKHJCC>> ALIPKIDGMCL(IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD, IGLPJBODKFE<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, string NFHOBPDKIPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x27786B0", Offset = "0x27776B0", VA = "0x1827786B0", Slot = "7")]
	[AsyncStateMachine(typeof(ELPJKDDALII))]
	public Task<HHHCCNLMPJL<EDBALDILLBK<LGADIHOLJAO>, DLKBDBKHJCC>> KDINMBLKFAF(IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD, IGLPJBODKFE<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, string NFHOBPDKIPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public sealed class LPEOOOFCFLN : DGHBNBOLGPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private readonly HJDEFPFJDOJ PCAAKKAJNLP;

	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private static readonly HashSet<HJDEFPFJDOJ> NIOPHLMJPNO;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private static readonly HashSet<HJDEFPFJDOJ> MBPEBMJOCJD;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private static readonly HashSet<HJDEFPFJDOJ> BDIHEMIPGGM;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public TypeKey LCHJEPJMOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x277BBF0", Offset = "0x277ABF0", VA = "0x18277BBF0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool HOHAGBDEDHD
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x277BBE0", Offset = "0x277ABE0", VA = "0x18277BBE0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool ELMDPDDNEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x277BC40", Offset = "0x277AC40", VA = "0x18277BC40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool PPAAEDBIJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x277BB60", Offset = "0x277AB60", VA = "0x18277BB60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x277A470", Offset = "0x2779470", VA = "0x18277A470")]
	public bool HBGMKAEOAKP(string OHLIHBDBKCE, [Out] LELDOHAKAOP LLGGNDEECGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public LPEOOOFCFLN(HJDEFPFJDOJ HCAMONPFOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x277A2E0", Offset = "0x27792E0", VA = "0x18277A2E0")]
	internal static TypeKey GNKBFCMFOIG(HJDEFPFJDOJ MLCOGCMJLBB)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x2778820", Offset = "0x2777820", VA = "0x182778820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public readonly struct OKJFFIABILO : GAIDIFCBGED.GEGLOHJNKDC<AFPLFKDKJPC, BONGKMFJEJA>
{
	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x277CA50", Offset = "0x277BA50", VA = "0x18277CA50", Slot = "4")]
	public int MJNIOHCGOFN(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x277C9F0", Offset = "0x277B9F0", VA = "0x18277C9F0", Slot = "5")]
	public AFPLFKDKJPC HKEKJJMEJGD(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x277CA20", Offset = "0x277BA20", VA = "0x18277CA20", Slot = "6")]
	public AFPLFKDKJPC JONIEAFELGN(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x277C9B0", Offset = "0x277B9B0", VA = "0x18277C9B0", Slot = "7")]
	public IReadOnlyList<AFPLFKDKJPC> BHIKMMGDBIL(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x277CA70", Offset = "0x277BA70", VA = "0x18277CA70", Slot = "8")]
	public AFPLFKDKJPC[] MLJJHHLMPNO(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF, int JLCAEJJKIPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x277CA00", Offset = "0x277BA00", VA = "0x18277CA00", Slot = "9")]
	public bool IKODBCOPDOE(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x277C9D0", Offset = "0x277B9D0", VA = "0x18277C9D0", Slot = "10")]
	public bool HAKKONIKOCC(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x277C990", Offset = "0x277B990", VA = "0x18277C990", Slot = "11")]
	public bool AFHJOLLGKAB(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x277CAA0", Offset = "0x277BAA0", VA = "0x18277CAA0", Slot = "12")]
	public bool PAHHIGLBJLF(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x277C970", Offset = "0x277B970", VA = "0x18277C970", Slot = "13")]
	public bool ACHPCHDAHMC(BONGKMFJEJA NPBBBMPJKJL, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x277CA80", Offset = "0x277BA80", VA = "0x18277CA80", Slot = "14")]
	public bool PAEEBKHMBGP(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public abstract class BDCCFONEBBK : BJNBAMNJLOJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public GAPFFALNEGD.LKCJFGAECDF MHGBPMPNHOG
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x27753F0", Offset = "0x27743F0", VA = "0x1827753F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract OECPBGDCJOF.NPMPHEAFFHF FOIDDNFBBPI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract CHIEBOEDIPK.DFKJDGPFAAB ANJGIFEEJID
	{
		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract GEGFDAOJMBC.FAGIEJAHGME LLGFEMAKEDP
	{
		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public KIAIHFFPMKB.IIGBIEGDLEB<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK> CFLMHIKJCKB
	{
		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x2775440", Offset = "0x2774440", VA = "0x182775440", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract JOGINOGJMGE.LHKMMBFACNA KIAKPPMDKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public abstract BODMOEILABD EFLGGEMJMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public abstract GEKBNBNBOEG FPJHEICFEAD
	{
		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public abstract FPIKGFGEAGP PMAKAKOKOEG
	{
		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public abstract JHMJKGDAMCI KAELNAOJPFC
	{
		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public abstract KDKCJHJLCDA IIAPDDDOKBC
	{
		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	protected BDCCFONEBBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class CEKCJHGDPCJ : OAMECGAHMHA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct JKEAKOIEEDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public CEKCJHGDPCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public AFPLFKDKJPC action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private TaskAwaiter<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x2779960", Offset = "0x2778960", VA = "0x182779960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x2779C00", Offset = "0x2778C00", VA = "0x182779C00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct JGKONEDFKKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<OCIFKDPAIJK, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public CEKCJHGDPCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public IReadOnlyList<AFPLFKDKJPC> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private TaskAwaiter<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x27792C0", Offset = "0x27782C0", VA = "0x1827792C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x2779640", Offset = "0x2778640", VA = "0x182779640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private readonly HNNMKAAPCJH CMAAEEHAJID;

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public CEKCJHGDPCJ(HNNMKAAPCJH HIEGHANFGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x27765A0", Offset = "0x27755A0", VA = "0x1827765A0")]
	[AsyncStateMachine(typeof(JKEAKOIEEDM))]
	private Task<HHHCCNLMPJL<object, DLKBDBKHJCC>> NGOFJAKHGMH(AFPLFKDKJPC BDCLNIJAFBF, bool CKEAKKIBMKM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x2776470", Offset = "0x2775470", VA = "0x182776470", Slot = "4")]
	[AsyncStateMachine(typeof(JGKONEDFKKO))]
	public Task<HHHCCNLMPJL<OCIFKDPAIJK, DLKBDBKHJCC>> ACCLOLGAPFF(IReadOnlyList<AFPLFKDKJPC> BAHJNLHEKLC, bool CKEAKKIBMKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public struct JEHFLBFEOGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	internal GOKPPJCJPIF<ADPBMIFBBEH, IGLPJBODKFE<ADPBMIFBBEH.JDMBOMNCDND>, AFPLFKDKJPC, AFDMHMHIIMC> PCAAKKAJNLP;

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x273DE00", Offset = "0x273CE00", VA = "0x18273DE00")]
	private JEHFLBFEOGF([In] GOKPPJCJPIF<ADPBMIFBBEH, IGLPJBODKFE<ADPBMIFBBEH.JDMBOMNCDND>, AFPLFKDKJPC, AFDMHMHIIMC> PPIDHODIMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x2778F00", Offset = "0x2777F00", VA = "0x182778F00")]
	public static JEHFLBFEOGF ACADPGMDEBE()
	{
		return default(JEHFLBFEOGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class ENCJCMLAEHC
{
	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0xC771F0", Offset = "0xC761F0", VA = "0x180C771F0")]
	public static GOKPPJCJPIF<ADPBMIFBBEH, IGLPJBODKFE<ADPBMIFBBEH.JDMBOMNCDND>, AFPLFKDKJPC, AFDMHMHIIMC> FDIDAJJKIPC(this JEHFLBFEOGF OCACDKEJIIB)
	{
		return default(GOKPPJCJPIF<ADPBMIFBBEH, IGLPJBODKFE<ADPBMIFBBEH.JDMBOMNCDND>, AFPLFKDKJPC, AFDMHMHIIMC>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public struct AFDMHMHIIMC : PBFLHEPEKPA.KOCEAODONMI<ADPBMIFBBEH, IGLPJBODKFE<ADPBMIFBBEH.JDMBOMNCDND>, AFPLFKDKJPC>
{
	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x2773490", Offset = "0x2772490", VA = "0x182773490", Slot = "7")]
	public AFPLFKDKJPC AHGFFDDCDOG(ADPBMIFBBEH[] DCENAJLAONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x10BB5A0", Offset = "0x10BA5A0", VA = "0x1810BB5A0")]
	public IGLPJBODKFE<ADPBMIFBBEH.JDMBOMNCDND> KGMJEJHJABK([In] ADPBMIFBBEH HOFIBHNCGHE)
	{
		return default(IGLPJBODKFE<ADPBMIFBBEH.JDMBOMNCDND>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x10BB370", Offset = "0x10BA370", VA = "0x1810BB370")]
	public int PPDCCFBDOAP([In] ADPBMIFBBEH PAMLNFEPEDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x2773680", Offset = "0x2772680", VA = "0x182773680")]
	public int HGGLNOKKHLB([In] ADPBMIFBBEH HOFIBHNCGHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x10BB370", Offset = "0x10BA370", VA = "0x1810BB370", Slot = "4")]
	private int EAHBOGKJDLH([In] ADPBMIFBBEH HOFIBHNCGHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x2773680", Offset = "0x2772680", VA = "0x182773680", Slot = "5")]
	private int LLDOBONLLHH([In] ADPBMIFBBEH HOFIBHNCGHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x10BB5A0", Offset = "0x10BA5A0", VA = "0x1810BB5A0", Slot = "6")]
	private IGLPJBODKFE<ADPBMIFBBEH.JDMBOMNCDND> KPENBNDCOHA([In] ADPBMIFBBEH HOFIBHNCGHE)
	{
		return default(IGLPJBODKFE<ADPBMIFBBEH.JDMBOMNCDND>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public struct DCJBDNFDKJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	internal FACBNMEONCE<JGDMKIEKPCF, AFPLFKDKJPC, GJPHBONOGIB> PCAAKKAJNLP;

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x273DE00", Offset = "0x273CE00", VA = "0x18273DE00")]
	private DCJBDNFDKJD([In] FACBNMEONCE<JGDMKIEKPCF, AFPLFKDKJPC, GJPHBONOGIB> CBJCEEDBJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x2776F70", Offset = "0x2775F70", VA = "0x182776F70")]
	public static DCJBDNFDKJD ACADPGMDEBE()
	{
		return default(DCJBDNFDKJD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public static class KDPFBDKEPNN
{
	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0xC771F0", Offset = "0xC761F0", VA = "0x180C771F0")]
	public static FACBNMEONCE<JGDMKIEKPCF, AFPLFKDKJPC, GJPHBONOGIB> FDIDAJJKIPC(this DCJBDNFDKJD OCACDKEJIIB)
	{
		return default(FACBNMEONCE<JGDMKIEKPCF, AFPLFKDKJPC, GJPHBONOGIB>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public struct GJPHBONOGIB : LMAKIANMGBK.KPNNEDLGNKF<JGDMKIEKPCF, AFPLFKDKJPC>
{
	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x2159BE0", Offset = "0x2158BE0", VA = "0x182159BE0")]
	public int ECDNBKAPNNC([In] JGDMKIEKPCF PAMLNFEPEDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x27788F0", Offset = "0x27778F0", VA = "0x1827788F0", Slot = "5")]
	public AFPLFKDKJPC FCMIAPEEKDJ(JGDMKIEKPCF[] MGNAMDKGBLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x2159BE0", Offset = "0x2158BE0", VA = "0x182159BE0", Slot = "4")]
	private int FIONNHHOBFP([In] JGDMKIEKPCF PAMLNFEPEDC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class ENPCMMEHLEL : OGMCLKGLBPG, IADJFILHMLF, DLKBDBKHJCC, HIKDGBNCNDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000365")]
	private readonly HIKDGBNCNDJ? PMHDLKLGNAO;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public KLAKIJLCEJL EJPNNEGOIFM
	{
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(KLAKIJLCEJL);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public override HIKDGBNCNDJ? GCEONJBMONL
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x2777F70", Offset = "0x2776F70", VA = "0x182777F70", Slot = "7")]
	public override string JJNMHFCAPPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x2778100", Offset = "0x2777100", VA = "0x182778100")]
	private ENPCMMEHLEL(KLAKIJLCEJL KOJNMKELJGK, HIKDGBNCNDJ? EMKFMGADLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x2778080", Offset = "0x2777080", VA = "0x182778080")]
	public static ENPCMMEHLEL MPMAJPNGILG(HIKDGBNCNDJ EMKFMGADLCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x2777E90", Offset = "0x2776E90", VA = "0x182777E90")]
	public static ENPCMMEHLEL ALAGLDHGDBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x2777F00", Offset = "0x2776F00", VA = "0x182777F00")]
	public static ENPCMMEHLEL JAAPPPNEDFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public static class NAOGAOHCECL
{
	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x39870C0", Offset = "0x39860C0", VA = "0x1839870C0")]
	public static HHHCCNLMPJL<TOk, IADJFILHMLF> FBMLGANNNGL<TOk>([In] this HHHCCNLMPJL<TOk, IADJFILHMLF> OCACDKEJIIB, HIKDGBNCNDJ EMKFMGADLCM) where TOk : notnull
	{
		return default(HHHCCNLMPJL<TOk, IADJFILHMLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x39871B0", Offset = "0x39861B0", VA = "0x1839871B0")]
	public static HHHCCNLMPJL<TOk?, IADJFILHMLF?> IPPECGKJFFC<TOk>([In] this HHHCCNLMPJL<TOk, IADJFILHMLF> OCACDKEJIIB)
	{
		return default(HHHCCNLMPJL<TOk, IADJFILHMLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x3986FC0", Offset = "0x3985FC0", VA = "0x183986FC0")]
	public static HHHCCNLMPJL<TOk?, IADJFILHMLF?> BPDIEGEAOEN<TOk>([In] this HHHCCNLMPJL<TOk, IADJFILHMLF> OCACDKEJIIB)
	{
		return default(HHHCCNLMPJL<TOk, IADJFILHMLF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public interface BODMOEILABD
{
	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IEIDPGHPIFJ([In] HHHCCNLMPJL<BONGKMFJEJA, HIKDGBNCNDJ> OBOOAPELMPF);
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public static class OCJGPMFNING
{
	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x39CBA90", Offset = "0x39CAA90", VA = "0x1839CBA90")]
	public static bool IEIDPGHPIFJ<TOk, TErr>(this BODMOEILABD OCACDKEJIIB, [In] HHHCCNLMPJL<TOk, TErr> OBOOAPELMPF) where TOk : notnull where TErr : notnull, HIKDGBNCNDJ
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000101")]
public interface GEKBNBNBOEG
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	HNHCLDDOLLE LABAGLOOHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000102")]
public interface FPIKGFGEAGP
{
	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GBMHCNCGHKO KFELHOBOKFP(int HNCPHCOBGLB);
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public interface HAOJHJDGKPH
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public interface FCIIBJCBNNA
{
	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	COLJOLOCMBG? FJOBFEJGJNF(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK);
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public interface MLHCIMGPGKP
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public interface COLJOLOCMBG
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MLHCIMGPGKP? AKCOFEODJLL(EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK);

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HAOJHJDGKPH? LDPAINKJAKJ(EDBALDILLBK<LGADIHOLJAO> OANGAIMOJJO);
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public interface JHMJKGDAMCI
{
	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> OANDFACMHHK(string OHLIHBDBKCE, string INLEBAAACKH);
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public interface KDKCJHJLCDA
{
	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FCIIBJCBNNA? CAHFJIEKOBL([In] IGLPJBODKFE<OGFNHMCGFPC> OKDEOJNBJMA);
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public sealed class CBCGICEGLFH
{
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	private struct NEMDGMKEKMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public int CEBFMOBHAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public DAPEGEJBKHJ? AIICEFDIFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public DAPEGEJBKHJ? HKMMOBEDFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public readonly List<AFPLFKDKJPC> AKFHCOIGFOO;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x277C610", Offset = "0x277B610", VA = "0x18277C610")]
		private NEMDGMKEKMJ(int OHHMJGCBCKD, DAPEGEJBKHJ? COCBFBEDBDG, DAPEGEJBKHJ? ODLHHBFEIEF, List<AFPLFKDKJPC> BAHJNLHEKLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x277C550", Offset = "0x277B550", VA = "0x18277C550")]
		public static NEMDGMKEKMJ ACADPGMDEBE()
		{
			return default(NEMDGMKEKMJ);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000368")]
	private readonly IBMPPKILLBB<NEMDGMKEKMJ> AJIIAFBGGMO;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public static CBCGICEGLFH MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2775490", Offset = "0x2774490", VA = "0x182775490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public bool PCOFGCIKEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0xC649F0", Offset = "0xC639F0", VA = "0x180C649F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xC648C0", Offset = "0xC638C0", VA = "0x180C648C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x2775B40", Offset = "0x2774B40", VA = "0x182775B40")]
	public void PPOFHGNBMIP(KPBELAPACCB ODLHHBFEIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x27754E0", Offset = "0x27744E0", VA = "0x1827754E0")]
	public void HELHMOMIOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x27757E0", Offset = "0x27747E0", VA = "0x1827757E0")]
	private static string? PHDNDAOKOGE([In] NEMDGMKEKMJ PDLCCJEHEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x2775D00", Offset = "0x2774D00", VA = "0x182775D00")]
	public CBCGICEGLFH()
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
