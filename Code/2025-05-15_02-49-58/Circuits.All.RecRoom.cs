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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2751D10", Offset = "0x2750310", VA = "0x182751D10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
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
		[Cpp2IlInjected.Address(RVA = "0x2751350", Offset = "0x274F950", VA = "0x182751350", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x272BE90", Offset = "0x272A490", VA = "0x18272BE90", Slot = "13")]
		public virtual void LKBLLIFPGMA(CHIEBOEDIPK IOIBNPDJCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x27512D0", Offset = "0x274F8D0", VA = "0x1827512D0", Slot = "14")]
		public virtual void NEJGNHDJEJE(CHIEBOEDIPK IOIBNPDJCNE, AFPLFKDKJPC BDCLNIJAFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x273F2B0", Offset = "0x273D8B0", VA = "0x18273F2B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		private DIGGGJFDADD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAC3370", Offset = "0xAC1970", VA = "0x180AC3370", Slot = "4")]
		public LDKABCCJKHO HJAOCKHLDIB(AFPLFKDKJPC OCACDKEJIIB)
		{
			return default(LDKABCCJKHO);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x273B180", Offset = "0x2739780", VA = "0x18273B180", Slot = "5")]
		public void LKBLLIFPGMA(CHIEBOEDIPK KNNDNAPJIDP, AFPLFKDKJPC BDCLNIJAFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x273B280", Offset = "0x2739880", VA = "0x18273B280", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x273EB00", Offset = "0x273D100", VA = "0x18273EB00")]
		internal IPPNGOHLOIO(APNBNOIOAEH<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK, KIAIHFFPMKB.IIGBIEGDLEB<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK>> HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x273EAB0", Offset = "0x273D0B0", VA = "0x18273EAB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2738850", Offset = "0x2736E50", VA = "0x182738850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2738A30", Offset = "0x2737030", VA = "0x182738A30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA6BB20", Offset = "0xA6A120", VA = "0x180A6BB20", Slot = "4")]
		public EDBALDILLBK<FKBNPBHMLOJ> KMHJCBEOCMD(CHIEBOEDIPK NGKGGMDFKFD)
		{
			return default(EDBALDILLBK<FKBNPBHMLOJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2736870", Offset = "0x2734E70", VA = "0x182736870", Slot = "5")]
		public void HCNCNCCFCBB(CHIEBOEDIPK NGKGGMDFKFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x27368F0", Offset = "0x2734EF0", VA = "0x1827368F0", Slot = "6")]
		[AsyncStateMachine(typeof(CEOEOGIEPNJ))]
		public Task<HHHCCNLMPJL<object, DLKBDBKHJCC>> LAPMPJGNIMF(CHIEBOEDIPK NGKGGMDFKFD, AFPLFKDKJPC BDCLNIJAFBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x27368D0", Offset = "0x2734ED0", VA = "0x1827368D0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x273AE80", Offset = "0x2739480", VA = "0x18273AE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x273B110", Offset = "0x2739710", VA = "0x18273B110", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x273E070", Offset = "0x273C670", VA = "0x18273E070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x273E250", Offset = "0x273C850", VA = "0x18273E250", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x27373C0", Offset = "0x27359C0", VA = "0x1827373C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x27375B0", Offset = "0x2735BB0", VA = "0x1827375B0", Slot = "5")]
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

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B78")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly BJNBAMNJLOJ GLHNOPBCEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B80")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly KPBELAPACCB.CHHNOAJOKBL IHNJBKPOLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BA8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly IKLGHIKNMHD HDKDMHLNCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BB0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly KHOBHPDGOKL BADJNJKHLMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BB8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly GIDNBCJFJCB MPPAFDCDKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly KMNAAACLCJB AKMHFCCAMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private DCJBDNFDKJD DALIELIBHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BD8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private JEHFLBFEOGF OHMLMAGMMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BF8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly NIFCIBLABOI.BOLPADJNBNP MHNDLLOIKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C00")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly EHIAIIKPCDI GLCMCLHCGGM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NIFCIBLABOI HDBCADOKEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x273AB10", Offset = "0x2739110", VA = "0x18273AB10")]
		get
		{
			return default(NIFCIBLABOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal DFKJDGPFAAB AMIDMEHBMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x273A990", Offset = "0x2738F90", VA = "0x18273A990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal APPFAIEDIHD EMIMCJJICOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x273A000", Offset = "0x2738600", VA = "0x18273A000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x273AB20", Offset = "0x2739120", VA = "0x18273AB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool JBCLPPAPFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2739AF0", Offset = "0x27380F0", VA = "0x182739AF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x273A280", Offset = "0x2738880", VA = "0x18273A280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HNPIHBFCBED NAMDOENFKDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x273AE40", Offset = "0x2739440", VA = "0x18273AE40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public KMOLNCDGBHJ PDIDIKKKGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x273AE50", Offset = "0x2739450", VA = "0x18273AE50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BMLEPPHJDAF GJLCALKKAPO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x273AE70", Offset = "0x2739470", VA = "0x18273AE70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JMMHNPNPOEP IFLJBBGINLE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x273AE60", Offset = "0x2739460", VA = "0x18273AE60", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public KPBELAPACCB? FDFMMKMOCDC
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x273A200", Offset = "0x2738800", VA = "0x18273A200", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private JGHDENAOIDJ? EBCEMPCMDCH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x273A9E0", Offset = "0x2738FE0", VA = "0x18273A9E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x273AB40", Offset = "0x2739140", VA = "0x18273AB40")]
	private CHIEBOEDIPK(BJNBAMNJLOJ JDPKJPILGNF, EDBALDILLBK<FKBNPBHMLOJ> GIBLACJPDHG, [In] JGCLGCLKIEK KLPEKGHDEBP, [In] NIFCIBLABOI HKDJCDHGBFB, [In] IAKIAMFCMEM FHCIFLPLDEN, APPFAIEDIHD KNJOHLFGHFE, [In] KPBELAPACCB.CHHNOAJOKBL ADOMMAMDBOA, NIFCIBLABOI.BOLPADJNBNP ADAPNPGMBLM, EHIAIIKPCDI HHLKFCCMMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x27396A0", Offset = "0x2737CA0", VA = "0x1827396A0")]
	public static CHIEBOEDIPK ACADPGMDEBE(BJNBAMNJLOJ MMCKJCAOGBM, [In] KBNDDPHLMIA AJGFNGAFEMJ, GIJMANECPIC MMONHDMBMMK, [In] DDDPDFIPEGH OHDBECKBNMJ, FDHFEJOOAHB JDDKONKOEHJ, EDBALDILLBK<FKBNPBHMLOJ> GIBLACJPDHG, EDBALDILLBK<GABIPLBFMGD> JKJBFLBDLJB, HNNMKAAPCJH HIEGHANFGIK, HKMNJGAEDIC PMDKCONLANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x27397E0", Offset = "0x2737DE0", VA = "0x1827397E0")]
	public static CHIEBOEDIPK ACADPGMDEBE(BJNBAMNJLOJ JDPKJPILGNF, [In] NIFCIBLABOI HKDJCDHGBFB, [In] IAKIAMFCMEM FHCIFLPLDEN, EDBALDILLBK<FKBNPBHMLOJ> GIBLACJPDHG, EDBALDILLBK<GABIPLBFMGD> JKJBFLBDLJB, HNNMKAAPCJH HIEGHANFGIK, HKMNJGAEDIC PMDKCONLANI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x273A010", Offset = "0x2738610", VA = "0x18273A010", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x273A360", Offset = "0x2738960", VA = "0x18273A360")]
	[AsyncStateMachine(typeof(DFAAJLBFFNI))]
	public Task<HHHCCNLMPJL<bool, DLKBDBKHJCC>> KHDEBPELNMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2739B00", Offset = "0x2738100", VA = "0x182739B00")]
	[AsyncStateMachine(typeof(HEGJKLDILGA))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> AMJAJCMLKGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2739D80", Offset = "0x2738380", VA = "0x182739D80")]
	internal void BEGKAIILJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x273A290", Offset = "0x2738890", VA = "0x18273A290")]
	internal HHIMBEIEIME<AFPLFKDKJPC> FKPDHMBGAGL([In] JGDMKIEKPCF EJAMOEMBOCL)
	{
		return default(HHIMBEIEIME<AFPLFKDKJPC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2739F90", Offset = "0x2738590", VA = "0x182739F90")]
	internal bool BJHCKGNPAKH([In] JGDMKIEKPCF EJAMOEMBOCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2739BF0", Offset = "0x27381F0", VA = "0x182739BF0")]
	internal HHHCCNLMPJL<AFPLFKDKJPC, DLKBDBKHJCC> AOOMIACHCPK([In] ADPBMIFBBEH IBLAJOEDIDO)
	{
		return default(HHHCCNLMPJL<AFPLFKDKJPC, DLKBDBKHJCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x273A310", Offset = "0x2738910", VA = "0x18273A310")]
	private void HCNCNCCFCBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x273A880", Offset = "0x2738E80", VA = "0x18273A880")]
	[AsyncStateMachine(typeof(BAEALDONNCH))]
	internal Task<HHHCCNLMPJL<object, DLKBDBKHJCC>> LBGADHPEDIP(AFPLFKDKJPC BDCLNIJAFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x273A450", Offset = "0x2738A50", VA = "0x18273A450")]
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
		[Cpp2IlInjected.Address(RVA = "0x29C6C80", Offset = "0x29C5280", VA = "0x1829C6C80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820", Slot = "7")]
	public override string JJNMHFCAPPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4E87F00", Offset = "0x4E86500", VA = "0x184E87F00")]
	internal JLJAOCJOPCJ([In] IGLPJBODKFE<ALEKBGLLPHJ>? KJALFNDNKJA, EDBALDILLBK<LOPJDFBDKHF>? KMIHNFEFBJG, IOKind? FEFOBFOJDCB, string NAAMEAFIHJI, [In] TData APDBNIMCPID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class GANNHEKKPED
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x273D480", Offset = "0x273BA80", VA = "0x18273D480")]
	public static HHHCCNLMPJL<KKPOPBPFNLG, JDAHMPILPFC> ACIALOHGINP([In] this FFPLKGHGHNO<EICJJGJBGOF> OHAPHBCELFN)
	{
		return default(HHHCCNLMPJL<KKPOPBPFNLG, JDAHMPILPFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3878890", Offset = "0x3876E90", VA = "0x183878890")]
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
	[Cpp2IlInjected.Address(RVA = "0x273E730", Offset = "0x273CD30", VA = "0x18273E730")]
	public static AFPLFKDKJPC OLEDACGEPAD(this AFPLFKDKJPC OCACDKEJIIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x273E660", Offset = "0x273CC60", VA = "0x18273E660")]
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
		[Cpp2IlInjected.Address(RVA = "0x273E330", Offset = "0x273C930", VA = "0x18273E330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x273E5F0", Offset = "0x273CBF0", VA = "0x18273E5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly ByteString FPGFCMMHMJG;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xD2EEF0", Offset = "0xD2D4F0", VA = "0x180D2EEF0")]
	private BFFEIOCJBKM(ByteString OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2737840", Offset = "0x2735E40", VA = "0x182737840")]
	public static AFPLFKDKJPC ONABKJHANMG(ByteString OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2737680", Offset = "0x2735C80", VA = "0x182737680")]
	public static GPFEFANJIIE<LDKABCCJKHO, BFFEIOCJBKM> IGNPFMJNHFE(AFPLFKDKJPC OHDJAINMECK)
	{
		return default(GPFEFANJIIE<LDKABCCJKHO, BFFEIOCJBKM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2737730", Offset = "0x2735D30", VA = "0x182737730")]
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
	[Cpp2IlInjected.Address(RVA = "0x2752370", Offset = "0x2750970", VA = "0x182752370")]
	public static AFPLFKDKJPC ONABKJHANMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2752280", Offset = "0x2750880", VA = "0x182752280")]
	public static GPFEFANJIIE<LDKABCCJKHO, OFKENAMFFNC> IGNPFMJNHFE(AFPLFKDKJPC OHDJAINMECK)
	{
		return default(GPFEFANJIIE<LDKABCCJKHO, OFKENAMFFNC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27522F0", Offset = "0x27508F0", VA = "0x1827522F0")]
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
	private struct CBHBGPDMCNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, CNPJDFNBLHN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CHIEBOEDIPK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public KPOEIHFDJNJ self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private HHHCCNLMPJL<BONGKMFJEJA, CNPJDFNBLHN> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2738220", Offset = "0x2736820", VA = "0x182738220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x27387E0", Offset = "0x2736DE0", VA = "0x1827387E0", Slot = "5")]
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

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly HICCAANEDJP? NLHMKHHFEKE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x218D6E0", Offset = "0x218BCE0", VA = "0x18218D6E0")]
	private KPOEIHFDJNJ(AMICEDMCMOM? GPHGBEGKLDA, DAPEGEJBKHJ? DHMHCCKDFEA, HNAGJAILJOF? OFMJDNINMGK, HICCAANEDJP? CEMGMFOIBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x274F000", Offset = "0x274D600", VA = "0x18274F000")]
	public static AFPLFKDKJPC? ONABKJHANMG(AMICEDMCMOM? GPHGBEGKLDA, DAPEGEJBKHJ? DHMHCCKDFEA, HNAGJAILJOF? OFMJDNINMGK, HICCAANEDJP? CEMGMFOIBLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x274ED70", Offset = "0x274D370", VA = "0x18274ED70")]
	public static GPFEFANJIIE<LDKABCCJKHO, KPOEIHFDJNJ> IGNPFMJNHFE(AFPLFKDKJPC OHDJAINMECK)
	{
		return default(GPFEFANJIIE<LDKABCCJKHO, KPOEIHFDJNJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x274EEC0", Offset = "0x274D4C0", VA = "0x18274EEC0")]
	[AsyncStateMachine(typeof(CBHBGPDMCNK))]
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
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<OCIFKDPAIJK, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public EGDAACDFPLG self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CHIEBOEDIPK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private HHHCCNLMPJL<OCIFKDPAIJK, DLKBDBKHJCC> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private HHHCCNLMPJL<object?, HIKDGBNCNDJ>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private HHHCCNLMPJL<object?, HIKDGBNCNDJ> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private HHHCCNLMPJL<object?, HIKDGBNCNDJ>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter<HHHCCNLMPJL<object?, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x27529F0", Offset = "0x2750FF0", VA = "0x1827529F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x2752E50", Offset = "0x2751450", VA = "0x182752E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly IReadOnlyList<AFPLFKDKJPC> AKFHCOIGFOO;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xD2EEF0", Offset = "0xD2D4F0", VA = "0x180D2EEF0")]
	private EGDAACDFPLG(IReadOnlyList<AFPLFKDKJPC> BAHJNLHEKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x273B5E0", Offset = "0x2739BE0", VA = "0x18273B5E0")]
	public static AFPLFKDKJPC ONABKJHANMG(IReadOnlyList<AFPLFKDKJPC> BAHJNLHEKLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x273B400", Offset = "0x2739A00", VA = "0x18273B400")]
	public static GPFEFANJIIE<LDKABCCJKHO, EGDAACDFPLG> IGNPFMJNHFE(AFPLFKDKJPC OHDJAINMECK)
	{
		return default(GPFEFANJIIE<LDKABCCJKHO, EGDAACDFPLG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x273B4A0", Offset = "0x2739AA0", VA = "0x18273B4A0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IGLPJBODKFE<JDMBOMNCDND> actionId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public ILJIFIOMHOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x273E940", Offset = "0x273CF40", VA = "0x18273E940")]
		internal AFPLFKDKJPC JPEFMINNPBD(int count, int index, [In] ReadOnlySpan<byte> span)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly IGLPJBODKFE<JDMBOMNCDND> PLGPAOCFKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly int CMIOJAJFIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly int CEBFMOBHAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly byte[] HCNIDPKECHH;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2736850", Offset = "0x2734E50", VA = "0x182736850")]
	private ADPBMIFBBEH(IGLPJBODKFE<JDMBOMNCDND> FOEHMPIEIAF, int JAALIADHHOC, int OHHMJGCBCKD, byte[] APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2736740", Offset = "0x2734D40", VA = "0x182736740")]
	public static AFPLFKDKJPC ONABKJHANMG(IGLPJBODKFE<JDMBOMNCDND> FOEHMPIEIAF, int JAALIADHHOC, int OHHMJGCBCKD, ByteString APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2736350", Offset = "0x2734950", VA = "0x182736350")]
	public static AFPLFKDKJPC[] AAHOGNABLFF(AFPLFKDKJPC BDCLNIJAFBF, int BIMKIFBAABH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2736460", Offset = "0x2734A60", VA = "0x182736460")]
	public static GPFEFANJIIE<LDKABCCJKHO, ADPBMIFBBEH> IGNPFMJNHFE(AFPLFKDKJPC OHDJAINMECK)
	{
		return default(GPFEFANJIIE<LDKABCCJKHO, ADPBMIFBBEH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x27365B0", Offset = "0x2734BB0", VA = "0x1827365B0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<bool, CNPJDFNBLHN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CHIEBOEDIPK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public JGDMKIEKPCF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private HHHCCNLMPJL<bool, CNPJDFNBLHN> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, CNPJDFNBLHN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2736D10", Offset = "0x2735310", VA = "0x182736D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x2737350", Offset = "0x2735950", VA = "0x182737350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly int CMIOJAJFIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly int CEBFMOBHAGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly byte[] HCNIDPKECHH;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xC18420", Offset = "0xC16A20", VA = "0x180C18420")]
	private JGDMKIEKPCF(int JAALIADHHOC, int OHHMJGCBCKD, byte[] APDBNIMCPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x273F6D0", Offset = "0x273DCD0", VA = "0x18273F6D0")]
	public static AFPLFKDKJPC ONABKJHANMG(int JAALIADHHOC, int OHHMJGCBCKD, ByteString APDBNIMCPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x273F2C0", Offset = "0x273D8C0", VA = "0x18273F2C0")]
	public static AFPLFKDKJPC?[]? CGKCFDJDECO(int BIMKIFBAABH, AMICEDMCMOM? GPHGBEGKLDA, DAPEGEJBKHJ? DHMHCCKDFEA, HNAGJAILJOF? OFMJDNINMGK, HICCAANEDJP? CEMGMFOIBLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x273F4C0", Offset = "0x273DAC0", VA = "0x18273F4C0")]
	public static GPFEFANJIIE<LDKABCCJKHO, JGDMKIEKPCF> IGNPFMJNHFE(AFPLFKDKJPC OHDJAINMECK)
	{
		return default(GPFEFANJIIE<LDKABCCJKHO, JGDMKIEKPCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x273F5A0", Offset = "0x273DBA0", VA = "0x18273F5A0")]
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
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly CHIEBOEDIPK FBKDHJDLAOI;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public EBJFPMAKINE? MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x273E840", Offset = "0x273CE40", VA = "0x18273E840", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	internal IKLGHIKNMHD(CHIEBOEDIPK IOIBNPDJCNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class CHIBFLIIPEI : EBJFPMAKINE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly CHIEBOEDIPK FBKDHJDLAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly MGIDPOIGHNH IHDCNDNFOPP;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9F85E0", Offset = "0x9F6BE0", VA = "0x1809F85E0")]
	public CHIBFLIIPEI(CHIEBOEDIPK IOIBNPDJCNE, MGIDPOIGHNH FKPENEKJEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x27390A0", Offset = "0x27376A0", VA = "0x1827390A0", Slot = "4")]
	public HHHCCNLMPJL<KKPOPBPFNLG, JDAHMPILPFC> MOFCIJJPGKB(IGLPJBODKFE<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<IFOKEFFHPOH> MOOIAANOCKP)
	{
		return default(HHHCCNLMPJL<KKPOPBPFNLG, JDAHMPILPFC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2738AA0", Offset = "0x27370A0", VA = "0x182738AA0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AsyncTaskMethodBuilder<MGIDPOIGHNH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public CHIEBOEDIPK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public DAPEGEJBKHJ cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public HNAGJAILJOF cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private TaskAwaiter<GEGFDAOJMBC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2753590", Offset = "0x2751B90", VA = "0x182753590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2753760", Offset = "0x2751D60", VA = "0x182753760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly ENIHPCOABJO MLIJHBGBMKP;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		private ENIHPCOABJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x273B800", Offset = "0x2739E00", VA = "0x18273B800", Slot = "4")]
		[AsyncStateMachine(typeof(PGIJPPNJDAB))]
		public Task<MGIDPOIGHNH> PIMAMFOMPFL(CHIEBOEDIPK IOIBNPDJCNE, DAPEGEJBKHJ? EAACMGNPBJM, HNAGJAILJOF? CLNJANHCMJK, CancellationToken CBJPDIFOEKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x273B7E0", Offset = "0x2739DE0", VA = "0x18273B7E0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<GAPFFALNEGD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public CHIEBOEDIPK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public DAPEGEJBKHJ cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public HNAGJAILJOF cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AMICEDMCMOM evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private LKCJFGAECDF <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter<MGIDPOIGHNH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x27514A0", Offset = "0x274FAA0", VA = "0x1827514A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x27519A0", Offset = "0x274FFA0", VA = "0x1827519A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly MGIDPOIGHNH IHDCNDNFOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly GAKOAGFLBAB CANFDJPCDEA;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public KPBELAPACCB FDFMMKMOCDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x273D980", Offset = "0x273BF80", VA = "0x18273D980", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public JGHDENAOIDJ PENIDCAANBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x273D9D0", Offset = "0x273BFD0", VA = "0x18273D9D0", Slot = "5")]
		get
		{
			return default(JGHDENAOIDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CHIBFLIIPEI BPCFFGKGPON
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "6")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xEDDB40", Offset = "0xEDC140", VA = "0x180EDDB40")]
	private GAPFFALNEGD(MGIDPOIGHNH FKPENEKJEBL, GAKOAGFLBAB FGCGPJAFJOJ, CHIBFLIIPEI CLIEIKEAAAE, GDHPHGOEDFD HGHKAOGJHJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x273DA90", Offset = "0x273C090", VA = "0x18273DA90")]
	[AsyncStateMachine(typeof(NLEAIOPIHFG))]
	public static Task<GAPFFALNEGD> HADJEECNMFP(CHIEBOEDIPK IOIBNPDJCNE, AMICEDMCMOM JAPOHPBPBCE, DAPEGEJBKHJ? EAACMGNPBJM, HNAGJAILJOF? CLNJANHCMJK, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x273D920", Offset = "0x273BF20", VA = "0x18273D920", Slot = "8")]
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
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public AsyncTaskMethodBuilder<CMLPMCGBMAK> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public CHIEBOEDIPK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public AMICEDMCMOM evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public DAPEGEJBKHJ cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public HNAGJAILJOF cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private TaskAwaiter<GAPFFALNEGD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x274A530", Offset = "0x2748B30", VA = "0x18274A530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x274A870", Offset = "0x2748E70", VA = "0x18274A870", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2737900", Offset = "0x2735F00", VA = "0x182737900", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder<CMLPMCGBMAK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public OECPBGDCJOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter<BONGKMFJEJA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2752780", Offset = "0x2750D80", VA = "0x182752780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2752980", Offset = "0x2750F80", VA = "0x182752980", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public OECPBGDCJOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CHIEBOEDIPK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AMICEDMCMOM evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public DAPEGEJBKHJ cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public HNAGJAILJOF cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<CMLPMCGBMAK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x2752EC0", Offset = "0x27514C0", VA = "0x182752EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x27533F0", Offset = "0x27519F0", VA = "0x1827533F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly NPMPHEAFFHF IJFOHHKJJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly TaskCompletionSource<BONGKMFJEJA> AEGEBMKLEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly TaskCompletionSource<BONGKMFJEJA> CFLNLCDKPDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly CancellationTokenSource FFCCMDNLKAB;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool JBCLPPAPFNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA18200", Offset = "0xA16800", VA = "0x180A18200", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA18020", Offset = "0xA16620", VA = "0x180A18020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DINPHDIMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xDBB480", Offset = "0xDB9A80", VA = "0x180DBB480", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1327520", Offset = "0x1325B20", VA = "0x181327520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool PEOOKJECCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xF58400", Offset = "0xF56A00", VA = "0x180F58400")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x2751F10", Offset = "0x2750510", VA = "0x182751F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public CMLPMCGBMAK? JDIEGKJMAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x2752080", Offset = "0x2750680", VA = "0x182752080", Slot = "7")]
	[AsyncStateMachine(typeof(OKJOCKDOAJK))]
	public Task<CMLPMCGBMAK> NKLADMHDKHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x2752170", Offset = "0x2750770", VA = "0x182752170")]
	public OECPBGDCJOF(NPMPHEAFFHF MMCKJCAOGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x2751F20", Offset = "0x2750520", VA = "0x182751F20", Slot = "8")]
	[AsyncStateMachine(typeof(OLDDJOKDEGE))]
	public Task MPEIIHEPKKJ(CHIEBOEDIPK IOIBNPDJCNE, AMICEDMCMOM JAPOHPBPBCE, DAPEGEJBKHJ? EAACMGNPBJM, HNAGJAILJOF? CLNJANHCMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2751D90", Offset = "0x2750390", VA = "0x182751D90", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class IMGOOIINJBF : NAKDLCJGBIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly GDHPHGOEDFD LGNDCLHNJGL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		protected readonly TGraph EHNPMKJFGML;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual GJDJHNDBKOL? EOEGMJDNHBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x17E6300", Offset = "0x17E4900", VA = "0x1817E6300", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual IGLPJBODKFE<ALEKBGLLPHJ>? OEDCIBJDLKM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x17E6300", Offset = "0x17E4900", VA = "0x1817E6300", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public EDBALDILLBK<BIEIIMCKPHN> CNMEJNNBCFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x4B636D0", Offset = "0x4B61CD0", VA = "0x184B636D0", Slot = "5")]
			get
			{
				return default(EDBALDILLBK<BIEIIMCKPHN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public EDBALDILLBK<BIEIIMCKPHN>? HNOMMBBAEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x4B63650", Offset = "0x4B61C50", VA = "0x184B63650", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x274EBF0", Offset = "0x274D1F0", VA = "0x18274EBF0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x274EC10", Offset = "0x274D210", VA = "0x18274EC10", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x274ECA0", Offset = "0x274D2A0", VA = "0x18274ECA0")]
		public KDDBHAPOHKF(GAIABOPOIIE PEBJLOHDPEP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x2751140", Offset = "0x274F740", VA = "0x182751140")]
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
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public GCPGPJCHONA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public BODMOEILABD errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x2753CE0", Offset = "0x27522E0", VA = "0x182753CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x2753F50", Offset = "0x2752550", VA = "0x182753F50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public KCILGDEGCLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public GCPGPJCHONA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x273DC00", Offset = "0x273C200", VA = "0x18273DC00")]
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
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public KCILGDEGCLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x273EB10", Offset = "0x273D110", VA = "0x18273EB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x273F020", Offset = "0x273D620", VA = "0x18273F020", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public MBEHGBAEDMG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x2753FB0", Offset = "0x27525B0", VA = "0x182753FB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x2754290", Offset = "0x2752890", VA = "0x182754290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public KCILGDEGCLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public MBEHGBAEDMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x274F110", Offset = "0x274D710", VA = "0x18274F110")]
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
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public MOFEEDFKMCH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x2754810", Offset = "0x2752E10", VA = "0x182754810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x2754CC0", Offset = "0x27532C0", VA = "0x182754CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public KCILGDEGCLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int valueIndex;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public MOFEEDFKMCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x274F1E0", Offset = "0x274D7E0", VA = "0x18274F1E0")]
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
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public FELLICMMBKB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x27542F0", Offset = "0x27528F0", VA = "0x1827542F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x27547B0", Offset = "0x2752DB0", VA = "0x1827547B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public KCILGDEGCLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int valueIndex;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public FELLICMMBKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x273D3B0", Offset = "0x273B9B0", VA = "0x18273D3B0")]
		[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
		internal Task LKLOOLDAJFA(BODMOEILABD errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly JMMEMLBFONE MLMOBOECBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly ICollection<CMHBAPLAFMG> GEDHINBNMII;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private BJNBAMNJLOJ DNEFEDCIDAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x274E9B0", Offset = "0x274CFB0", VA = "0x18274E9B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public EDBALDILLBK<IFOKEFFHPOH> HNGBCFCIPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xF476A0", Offset = "0xF45CA0", VA = "0x180F476A0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(EDBALDILLBK<IFOKEFFHPOH>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xF46600", Offset = "0xF44C00", VA = "0x180F46600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private EDBALDILLBK<KCPNHNINCKC> CHKDGPDINHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x131BEC0", Offset = "0x131A4C0", VA = "0x18131BEC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public EDBALDILLBK<AIHJLHNMKCJ> GJIJHNKEFCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA12060", Offset = "0xA10660", VA = "0x180A12060", Slot = "26")]
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
		[Cpp2IlInjected.Address(RVA = "0x274E0D0", Offset = "0x274C6D0", VA = "0x18274E0D0", Slot = "21")]
		get
		{
			return default(EDBALDILLBK<LOPJDFBDKHF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool KMDMNIFABMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x274B1D0", Offset = "0x27497D0", VA = "0x18274B1D0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x274E9D0", Offset = "0x274CFD0", VA = "0x18274E9D0")]
	private KCILGDEGCLG(CHIEBOEDIPK IOIBNPDJCNE, GDCCFCAPGMP GOJJJBGJPAM, JMMEMLBFONE HDKBOKEPPCD, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<IFOKEFFHPOH> MOOIAANOCKP, EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK, bool OGKGFGNPDEA, string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x274ACB0", Offset = "0x27492B0", VA = "0x18274ACB0")]
	public static KCILGDEGCLG ACADPGMDEBE(CHIEBOEDIPK IOIBNPDJCNE, GDCCFCAPGMP GOJJJBGJPAM, JMMEMLBFONE HPLMFDGMJFE, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK, EDBALDILLBK<IFOKEFFHPOH> MOOIAANOCKP, bool OGKGFGNPDEA, bool FPPJBNBMHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x274B130", Offset = "0x2749730", VA = "0x18274B130", Slot = "22")]
	protected override void ANJKPBDKBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x274BC50", Offset = "0x274A250", VA = "0x18274BC50", Slot = "23")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x274C870", Offset = "0x274AE70", VA = "0x18274C870", Slot = "31")]
	public void GMNJCMMACLA(CMHBAPLAFMG GLBFCMABIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x274B480", Offset = "0x2749A80", VA = "0x18274B480", Slot = "28")]
	public void CFGFNPBIMGE(AKOMMOLMACN CHLBGLMLGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x274CC00", Offset = "0x274B200", VA = "0x18274CC00", Slot = "29")]
	public void HMHNDPEKCAL(OGFFBPIJDKD ABDHOCCLNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x274C8D0", Offset = "0x274AED0", VA = "0x18274C8D0", Slot = "24")]
	protected override void HHNKFBFEPJF(JFPHGDGHBDF NNDPLIOKOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x274CA80", Offset = "0x274B080", VA = "0x18274CA80", Slot = "33")]
	public string HMDBIFFBANE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x274C260", Offset = "0x274A860", VA = "0x18274C260", Slot = "30")]
	public string FIDCOPFFAMC(int HOMPFMAAAKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x274DC60", Offset = "0x274C260", VA = "0x18274DC60")]
	private void IEBLMJLPMMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x274BF50", Offset = "0x274A550", VA = "0x18274BF50", Slot = "32")]
	public void EGENMJADMAI(CMHBAPLAFMG GLBFCMABIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x274DF10", Offset = "0x274C510", VA = "0x18274DF10")]
	private void JJNCOMANPNK(bool OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x274BCF0", Offset = "0x274A2F0", VA = "0x18274BCF0", Slot = "34")]
	[AsyncStateMachine(typeof(JFBDCCHHCCP))]
	public Task ECAOPINDFKI(string OHLIHBDBKCE, bool LIIPBEPHFLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x274C5D0", Offset = "0x274ABD0", VA = "0x18274C5D0")]
	public void GIEJELJAOEG(string OHLIHBDBKCE, bool LIIPBEPHFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x274B7F0", Offset = "0x2749DF0", VA = "0x18274B7F0")]
	private void CHLPGMONNAD(int OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x274B250", Offset = "0x2749850", VA = "0x18274B250")]
	private void BIPNHPGCKFE(int BGBBDAECBHO, string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x274E1B0", Offset = "0x274C7B0", VA = "0x18274E1B0")]
	private void KPDOMCACGEG(int BGBBDAECBHO, string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x274BE00", Offset = "0x274A400", VA = "0x18274BE00")]
	private string EGEIGHIBOLC(int BGBBDAECBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x274E370", Offset = "0x274C970", VA = "0x18274E370")]
	private string LCDHAAFFKPO(int BGBBDAECBHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0xF46600", Offset = "0xF44C00", VA = "0x180F46600")]
	internal void OEENBNBGJGG(EDBALDILLBK<IFOKEFFHPOH> OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x274C530", Offset = "0x274AB30", VA = "0x18274C530")]
	[CompilerGenerated]
	private void FLKNFECNDFE(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x274E6B0", Offset = "0x274CCB0", VA = "0x18274E6B0")]
	[CompilerGenerated]
	private bool LMIHHEBOLGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x274ABF0", Offset = "0x27491F0", VA = "0x18274ABF0")]
	[CompilerGenerated]
	private bool AAOHJCABGFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x274BA60", Offset = "0x274A060", VA = "0x18274BA60")]
	[CompilerGenerated]
	private int DBJGDKHMCHM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x274C150", Offset = "0x274A750", VA = "0x18274C150")]
	[CompilerGenerated]
	private bool FEHHGHBPDBA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x274E7F0", Offset = "0x274CDF0", VA = "0x18274E7F0")]
	[CompilerGenerated]
	private void MMFOFLDCHPA(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x274E8F0", Offset = "0x274CEF0", VA = "0x18274E8F0")]
	[CompilerGenerated]
	private bool PIAEAIGGPNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x274CA20", Offset = "0x274B020", VA = "0x18274CA20")]
	[CompilerGenerated]
	private bool HJHGLDKGIPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x274E120", Offset = "0x274C720", VA = "0x18274E120")]
	[CompilerGenerated]
	private bool KNBBAFNOFAL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x274BA60", Offset = "0x274A060", VA = "0x18274BA60")]
	[CompilerGenerated]
	private int NPGOEFNDHFD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x274B060", Offset = "0x2749660", VA = "0x18274B060")]
	[CompilerGenerated]
	private bool AEKOBCHNCCB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x274C1E0", Offset = "0x274A7E0", VA = "0x18274C1E0")]
	[CompilerGenerated]
	private object FHCLFEHJMAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x274C550", Offset = "0x274AB50", VA = "0x18274C550")]
	[CompilerGenerated]
	private void GDKIGKPIIOB(object OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x274B990", Offset = "0x2749F90", VA = "0x18274B990")]
	[CompilerGenerated]
	private bool CNHDEBIGLNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x274E870", Offset = "0x274CE70", VA = "0x18274E870")]
	[CompilerGenerated]
	private string OLKLNBLMPPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x274E8E0", Offset = "0x274CEE0", VA = "0x18274E8E0")]
	[CompilerGenerated]
	private void PFILLDLIEOA(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x274BB80", Offset = "0x274A180", VA = "0x18274BB80")]
	[CompilerGenerated]
	private bool DPINMCNOOKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x274E780", Offset = "0x274CD80", VA = "0x18274E780")]
	[CompilerGenerated]
	private string MKFBKCHINIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x274E500", Offset = "0x274CB00", VA = "0x18274E500")]
	[CompilerGenerated]
	private void LCGGOGBJOPO(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x274BAB0", Offset = "0x274A0B0", VA = "0x18274BAB0")]
	[CompilerGenerated]
	private bool DCMDNPCOKDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x274C010", Offset = "0x274A610", VA = "0x18274C010")]
	[CompilerGenerated]
	private string EGKIELJHGKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x274C540", Offset = "0x274AB40", VA = "0x18274C540")]
	[CompilerGenerated]
	private void FOBIHJCNBMM(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x274E510", Offset = "0x274CB10", VA = "0x18274E510")]
	[CompilerGenerated]
	private bool LCPPIGALFMJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x274C7F0", Offset = "0x274ADF0", VA = "0x18274C7F0")]
	[CompilerGenerated]
	private string GLPKPFLHKMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x274E770", Offset = "0x274CD70", VA = "0x18274E770")]
	[CompilerGenerated]
	private void LNBJIMKHPFG(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x274DB90", Offset = "0x274C190", VA = "0x18274DB90")]
	[CompilerGenerated]
	private bool HNHLPKLEEEK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x274E800", Offset = "0x274CE00", VA = "0x18274E800")]
	[CompilerGenerated]
	private string NOPFLJNAJNN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x274C860", Offset = "0x274AE60", VA = "0x18274C860")]
	[CompilerGenerated]
	private void GMFAODMNFGI(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x274C080", Offset = "0x274A680", VA = "0x18274C080")]
	[CompilerGenerated]
	private bool ENJFAEEJFCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x274DEA0", Offset = "0x274C4A0", VA = "0x18274DEA0")]
	[CompilerGenerated]
	private string JILAOAJNNHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x274CA70", Offset = "0x274B070", VA = "0x18274CA70")]
	[CompilerGenerated]
	private void HLNCDGCHDBD(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x274C720", Offset = "0x274AD20", VA = "0x18274C720")]
	[CompilerGenerated]
	private bool GIGPMDOPHDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x274B410", Offset = "0x2749A10", VA = "0x18274B410")]
	[CompilerGenerated]
	private string CCGCLCNDABF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x274DE90", Offset = "0x274C490", VA = "0x18274DE90")]
	[CompilerGenerated]
	private void JCFHGPHIJGO(string OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x274E5E0", Offset = "0x274CBE0", VA = "0x18274E5E0")]
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
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public NNJGPNPLPGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public EKKCKDAAEMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x273B6A0", Offset = "0x2739CA0", VA = "0x18273B6A0")]
			internal object PMOJIBLCDBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x273B710", Offset = "0x2739D10", VA = "0x18273B710")]
			internal void POFMCLKDAFO(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2751CA0", Offset = "0x27502A0", VA = "0x182751CA0")]
		public NNJGPNPLPGN(CHIEBOEDIPK IOIBNPDJCNE, GCPKKAJPCKB HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2751A10", Offset = "0x2750010", VA = "0x182751A10", Slot = "134")]
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
			[Cpp2IlInjected.Address(RVA = "0xBD6DF0", Offset = "0xBD53F0", VA = "0x180BD6DF0", Slot = "140")]
			get
			{
				return default(AEKGKKLKPIL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2737620", Offset = "0x2735C20", VA = "0x182737620")]
		public BFBCCKMIICJ(CHIEBOEDIPK IOIBNPDJCNE, ILBBDEMBAKM HCAMONPFOJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class OILKBLKHOHO : FNEGPADGNAD<HBGMKHMEDOH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2752710", Offset = "0x2750D10", VA = "0x182752710")]
		public OILKBLKHOHO(CHIEBOEDIPK IOIBNPDJCNE, HBGMKHMEDOH GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2752410", Offset = "0x2750A10", VA = "0x182752410", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2752590", Offset = "0x2750B90", VA = "0x182752590")]
		[CompilerGenerated]
		private bool JLDOFNMGBBA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x27525E0", Offset = "0x2750BE0", VA = "0x1827525E0")]
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
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public FEAMMEJMBFM <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public PJAFKBNFHNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x27539A0", Offset = "0x2751FA0", VA = "0x1827539A0")]
			internal void PMOJIBLCDBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x27539F0", Offset = "0x2751FF0", VA = "0x1827539F0")]
			internal bool POFMCLKDAFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x27537D0", Offset = "0x2751DD0", VA = "0x1827537D0")]
			internal bool IGNBPBENOMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x2753820", Offset = "0x2751E20", VA = "0x182753820")]
			internal void NOAGHDJPGKH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x2753950", Offset = "0x2751F50", VA = "0x182753950")]
			internal bool OABKELGAFGC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x273D340", Offset = "0x273B940", VA = "0x18273D340")]
		public FEAMMEJMBFM(CHIEBOEDIPK IOIBNPDJCNE, IDFKPHFNCHO GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x273D000", Offset = "0x273B600", VA = "0x18273D000", Slot = "134")]
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
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public BNJFKCAIBOE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public ADEGAMBDAPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x2735FF0", Offset = "0x27345F0", VA = "0x182735FF0")]
			internal object PMOJIBLCDBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2735BD0", Offset = "0x27341D0", VA = "0x182735BD0")]
			internal bool EGEKFLONCNL(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x27360F0", Offset = "0x27346F0", VA = "0x1827360F0")]
			internal void POFMCLKDAFO(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x2735D80", Offset = "0x2734380", VA = "0x182735D80")]
			internal string IGNBPBENOMC(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x2735EE0", Offset = "0x27344E0", VA = "0x182735EE0")]
			internal IReadOnlyList<object> NOAGHDJPGKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x2735F30", Offset = "0x2734530", VA = "0x182735F30")]
			internal bool OABKELGAFGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x2735FA0", Offset = "0x27345A0", VA = "0x182735FA0")]
			internal bool ONMGGGFMIMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x2735C50", Offset = "0x2734250", VA = "0x182735C50")]
			internal void IEBNCJCHKNG(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x27381B0", Offset = "0x27367B0", VA = "0x1827381B0")]
		public BNJFKCAIBOE(CHIEBOEDIPK IOIBNPDJCNE, EPJLFGNOMOD GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2737A60", Offset = "0x2736060", VA = "0x182737A60", Slot = "134")]
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
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public GDPPAOCCIGP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public AMIFMNEHNDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x2736B90", Offset = "0x2735190", VA = "0x182736B90")]
			internal bool PMOJIBLCDBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x2736BE0", Offset = "0x27351E0", VA = "0x182736BE0")]
			internal void POFMCLKDAFO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x2736B40", Offset = "0x2735140", VA = "0x182736B40")]
			internal bool IGNBPBENOMC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x273DF20", Offset = "0x273C520", VA = "0x18273DF20")]
		public GDPPAOCCIGP(CHIEBOEDIPK IOIBNPDJCNE, DLIDFEBFLFF GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x273DCF0", Offset = "0x273C2F0", VA = "0x18273DCF0", Slot = "134")]
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
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public AsyncTaskMethodBuilder<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public NPCCNPOFPCI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private TaskAwaiter<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x501CBB0", Offset = "0x501B1B0", VA = "0x18501CBB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x501CFC0", Offset = "0x501B5C0", VA = "0x18501CFC0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public NPCCNPOFPCI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public EDBALDILLBK<MECIAIKJJDL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x4C2B700", Offset = "0x4C29D00", VA = "0x184C2B700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x4C2BB10", Offset = "0x4C2A110", VA = "0x184C2BB10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public sealed override bool PCNJMJHNNHM
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public sealed override EDBALDILLBK<MECIAIKJJDL>? NEHDIPFJKOB
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x5425E30", Offset = "0x5424430", VA = "0x185425E30", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5168CE0", Offset = "0x51672E0", VA = "0x185168CE0")]
		protected NPCCNPOFPCI(CHIEBOEDIPK IOIBNPDJCNE, TNode GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5425D10", Offset = "0x5424310", VA = "0x185425D10", Slot = "114")]
		[AsyncStateMachine(typeof(NPCCNPOFPCI<>.KMNLBHPFNLK))]
		public override Task<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> NLJCJIFCEPE(string NFHOBPDKIPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5425AC0", Offset = "0x54240C0", VA = "0x185425AC0", Slot = "138")]
		public sealed override bool CJLAALIHDHE(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5425B60", Offset = "0x5424160", VA = "0x185425B60", Slot = "126")]
		protected sealed override bool EIOFANCGDJC(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5425A20", Offset = "0x5424020", VA = "0x185425A20", Slot = "127")]
		protected override bool BLLOHDPAIJK(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5425C00", Offset = "0x5424200", VA = "0x185425C00", Slot = "115")]
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
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public JJJHGNMFKFG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public ONDBFJFGLMJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x2753510", Offset = "0x2751B10", VA = "0x182753510")]
			internal bool JGLMENIGIII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x2753450", Offset = "0x2751A50", VA = "0x182753450")]
			internal void EKEOADEHHLG(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x274AB30", Offset = "0x2749130", VA = "0x18274AB30")]
		public JJJHGNMFKFG(CHIEBOEDIPK IOIBNPDJCNE, DPCINDPNFPB HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x274A8E0", Offset = "0x2748EE0", VA = "0x18274A8E0", Slot = "140")]
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
			[Cpp2IlInjected.Address(RVA = "0xBEDFB0", Offset = "0xBEC5B0", VA = "0x180BEDFB0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x274AB90", Offset = "0x2749190", VA = "0x18274AB90")]
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
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public AsyncTaskMethodBuilder<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public OBDPADHLGOK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private TaskAwaiter<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x5150AA0", Offset = "0x514F0A0", VA = "0x185150AA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x5150F50", Offset = "0x514F550", VA = "0x185150F50", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public OBDPADHLGOK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public EDBALDILLBK<MECIAIKJJDL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x6413050", Offset = "0x6411650", VA = "0x186413050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x64134D0", Offset = "0x6411AD0", VA = "0x1864134D0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public AsyncTaskMethodBuilder<HHHCCNLMPJL<OCIFKDPAIJK, DLKBDBKHJCC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public OBDPADHLGOK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private TaskAwaiter<HHHCCNLMPJL<OCIFKDPAIJK, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x4AC5A90", Offset = "0x4AC4090", VA = "0x184AC5A90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x4AC6140", Offset = "0x4AC4740", VA = "0x184AC6140", Slot = "5")]
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
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				public GCGFOMGGNEF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x4070010", Offset = "0x406E610", VA = "0x184070010", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public KIEOOBCGILC configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public OBDPADHLGOK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public GCGFOMGGNEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x4AA3710", Offset = "0x4AA1D10", VA = "0x184AA3710")]
			internal bool IEBNCJCHKNG(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x4AA37F0", Offset = "0x4AA1DF0", VA = "0x184AA37F0")]
			internal void PMOJIBLCDBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x4AA3670", Offset = "0x4AA1C70", VA = "0x184AA3670")]
			[AsyncStateMachine(typeof(OBDPADHLGOK<>.GCGFOMGGNEF.<<BuildConfigMenuInternal>b__7>d))]
			internal void EGEKFLONCNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x4AA3AC0", Offset = "0x4AA20C0", VA = "0x184AA3AC0")]
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
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				public PLPBHNBMEDF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x406FCA0", Offset = "0x406E2A0", VA = "0x18406FCA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public string newFunctionName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public GCGFOMGGNEF CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public PLPBHNBMEDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x562C2E0", Offset = "0x562A8E0", VA = "0x18562C2E0")]
			internal void IGNBPBENOMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			internal string NOAGHDJPGKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
			internal void OABKELGAFGC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x562C680", Offset = "0x562AC80", VA = "0x18562C680")]
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
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				public JCMBIONDLGG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x406F7D0", Offset = "0x406DDD0", VA = "0x18406F7D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
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
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public JCMBIONDLGG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				private TaskAwaiter<HHHCCNLMPJL<EDBALDILLBK<KCPNHNINCKC>, DLKBDBKHJCC>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x406F9B0", Offset = "0x406DFB0", VA = "0x18406F9B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
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
				[Cpp2IlInjected.Token(Token = "0x4000113")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public JCMBIONDLGG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				private TaskAwaiter<HHHCCNLMPJL<EDBALDILLBK<LGADIHOLJAO>, DLKBDBKHJCC>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x406F110", Offset = "0x406D710", VA = "0x18406F110", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public OBDPADHLGOK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public EDBALDILLBK<MECIAIKJJDL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public KIEOOBCGILC configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public LCBAJMHOMEH nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public ACLPKCGEGFP selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public List<MPMMOAFDEHE> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public ACLPKCGEGFP selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public List<MPMMOAFDEHE> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public JCMBIONDLGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4E6DE30", Offset = "0x4E6C430", VA = "0x184E6DE30")]
			internal bool OAAFMLCDCMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x4E6DBF0", Offset = "0x4E6C1F0", VA = "0x184E6DBF0")]
			internal void IMDMEEMDPJA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4E6D820", Offset = "0x4E6BE20", VA = "0x184E6D820")]
			internal bool EPBBOIMBNOJ(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x4E6D6A0", Offset = "0x4E6BCA0", VA = "0x184E6D6A0")]
			internal bool AFCEFCMKOAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4E6DEA0", Offset = "0x4E6C4A0", VA = "0x184E6DEA0")]
			[AsyncStateMachine(typeof(OBDPADHLGOK<>.JCMBIONDLGG.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void OFCNDFJJFLE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x4E6DBB0", Offset = "0x4E6C1B0", VA = "0x184E6DBB0")]
			internal bool IMCHGMFLBGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x4E6DAF0", Offset = "0x4E6C0F0", VA = "0x184E6DAF0")]
			internal void GLPKDFPPDDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x4E6D900", Offset = "0x4E6BF00", VA = "0x184E6D900")]
			internal bool FAHFJKDKDIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x4E6DD10", Offset = "0x4E6C310", VA = "0x184E6DD10")]
			internal void MOBBJCGKAIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x4E6DC60", Offset = "0x4E6C260", VA = "0x184E6DC60")]
			internal bool LOOMNPCAAED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x4E6DFB0", Offset = "0x4E6C5B0", VA = "0x184E6DFB0")]
			internal bool OKALMJNILMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x4E6D6E0", Offset = "0x4E6BCE0", VA = "0x184E6D6E0")]
			internal void AMHGOLIJIII(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x4E6D9B0", Offset = "0x4E6BFB0", VA = "0x184E6D9B0")]
			[AsyncStateMachine(typeof(OBDPADHLGOK<>.JCMBIONDLGG.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void FMMMGBIHFBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x4E6D7C0", Offset = "0x4E6BDC0", VA = "0x184E6D7C0")]
			internal bool DCHMIBJKBHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x4E6D750", Offset = "0x4E6BD50", VA = "0x184E6D750")]
			internal bool DBEEGNKMAPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x4E6DF40", Offset = "0x4E6C540", VA = "0x184E6DF40")]
			internal void OIMLOHIOIGF(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x4E6DA50", Offset = "0x4E6C050", VA = "0x184E6DA50")]
			[AsyncStateMachine(typeof(OBDPADHLGOK<>.JCMBIONDLGG.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void GJOOJOOFLJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x4E6DDD0", Offset = "0x4E6C3D0", VA = "0x184E6DDD0")]
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
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public EKJCLEKPPFO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x406F400", Offset = "0x406DA00", VA = "0x18406F400", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public JCMBIONDLGG CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public EKJCLEKPPFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x45221C0", Offset = "0x45207C0", VA = "0x1845221C0")]
			internal void NDPMNKEJIOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			internal string OKBPNEJLIAG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
			internal void FNDDONMAAIG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x45225D0", Offset = "0x4520BD0", VA = "0x1845225D0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public LCBAJMHOMEH nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public List<MPMMOAFDEHE> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public OBDPADHLGOK<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public EDBALDILLBK<MECIAIKJJDL> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public PBMEIGCCCKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x5607450", Offset = "0x5605A50", VA = "0x185607450")]
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
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public HGIFBECBIMN port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public PBMEIGCCCKE CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public GOEHNHAHPMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1C80", Offset = "0x4AD0280", VA = "0x184AD1C80")]
			internal void DJIFFCEHJJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1D90", Offset = "0x4AD0390", VA = "0x184AD1D90")]
			internal bool EAHJCFONAEO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1DE0", Offset = "0x4AD03E0", VA = "0x184AD1DE0")]
			internal void GBEFEEJMKEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1F00", Offset = "0x4AD0500", VA = "0x184AD1F00")]
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
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public MPMMOAFDEHE portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public GOEHNHAHPMP CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public GMCLJFILJHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x4ACEEE0", Offset = "0x4ACD4E0", VA = "0x184ACEEE0")]
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
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				public AIAHKFLFGMI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x4071440", Offset = "0x406FA40", VA = "0x184071440", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public List<object> allTypeObjects;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public ACLPKCGEGFP selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public LCBAJMHOMEH nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public HGIFBECBIMN port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public AIAHKFLFGMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x4A852B0", Offset = "0x4A838B0", VA = "0x184A852B0")]
			internal int KOAIAMEOKMJ()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x4A84F80", Offset = "0x4A83580", VA = "0x184A84F80")]
			internal void AMDGEGBOADI(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
			internal string LAKIODLIHFB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x4A852F0", Offset = "0x4A838F0", VA = "0x184A852F0")]
			[AsyncStateMachine(typeof(OBDPADHLGOK<>.AIAHKFLFGMI.<<CreatePortItemV2>b__3>d))]
			internal void PPMMDIIGDBP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x4A851D0", Offset = "0x4A837D0", VA = "0x184A851D0")]
			internal bool JCNLPNIOOHO(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly Dictionary<EDBALDILLBK<MECIAIKJJDL>, bool> KLOLAOJMKOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<EDBALDILLBK<MECIAIKJJDL>, bool> NPNDFFAHPPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<EDBALDILLBK<MECIAIKJJDL>, bool> PHOPLPKOMND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private Dictionary<EDBALDILLBK<MECIAIKJJDL>, bool> DBIOCIEDILL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private Dictionary<EDBALDILLBK<MECIAIKJJDL>, bool> JLKPKKFDFNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private Dictionary<EDBALDILLBK<MECIAIKJJDL>, bool> ACBIJBPMHME;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool HFIAGEGNIAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected virtual bool NADBNOKNONI
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected virtual bool IFCPEFJLODD
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected virtual bool PMHMAIDFNID
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "142")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override EDBALDILLBK<BIEIIMCKPHN>? EIKAIJOGKJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x551A440", Offset = "0x5518A40", VA = "0x18551A440", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override EDBALDILLBK<MECIAIKJJDL>? NEHDIPFJKOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x551A6F0", Offset = "0x5518CF0", VA = "0x18551A6F0", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override IEnumerable<IGLPJBODKFE<ALEKBGLLPHJ>>? BGLFMODOKND
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x551A4F0", Offset = "0x5518AF0", VA = "0x18551A4F0", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x551A220", Offset = "0x5518820", VA = "0x18551A220")]
		public OBDPADHLGOK(CHIEBOEDIPK IOIBNPDJCNE, TNode GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "143")]
		protected virtual bool BOJGFFOLLMM(int KEEMGACDGMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "144")]
		protected virtual bool JOJEJFGDFNI(int KEEMGACDGMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "145")]
		protected virtual bool OKDIJONPGPD(int KEEMGACDGMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "146")]
		protected virtual void HBPEKCPKJEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x55159A0", Offset = "0x5513FA0", VA = "0x1855159A0", Slot = "138")]
		public override bool CJLAALIHDHE(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5518E60", Offset = "0x5517460", VA = "0x185518E60", Slot = "114")]
		[AsyncStateMachine(typeof(OBDPADHLGOK<>.LLLNJNJBDLM))]
		public override Task<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> NLJCJIFCEPE(string NFHOBPDKIPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5518750", Offset = "0x5516D50", VA = "0x185518750", Slot = "115")]
		[AsyncStateMachine(typeof(OBDPADHLGOK<>.BOOCCMJPFAN))]
		public override Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> HBOMGBAHBHB(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5516380", Offset = "0x5514980", VA = "0x185516380", Slot = "116")]
		public override void DOMLNJILBBI(EDBALDILLBK<MECIAIKJJDL> OHHMJGCBCKD, EDBALDILLBK<MECIAIKJJDL> FCPOJLOEIEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5518B00", Offset = "0x5517100", VA = "0x185518B00", Slot = "117")]
		public override IEnumerable<AFPLFKDKJPC> LDELJOIKHDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5518D60", Offset = "0x5517360", VA = "0x185518D60")]
		[AsyncStateMachine(typeof(OBDPADHLGOK<>.GKFNFDICENB))]
		private Task<HHHCCNLMPJL<OCIFKDPAIJK, DLKBDBKHJCC>> NJJDMAPKPKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "147")]
		protected virtual bool KHLLIPGHIMF(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "148")]
		protected virtual bool IKFOFLCFMLN(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "149")]
		protected virtual bool DBEFAGOJEJN(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "150")]
		protected virtual bool MOCMABCDADD(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "151")]
		protected virtual bool IFALGEPKPAK(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, int OOBLHGFAEBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "152")]
		protected virtual bool BFPGFMPNFHN(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, int OOBLHGFAEBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "153")]
		protected virtual bool NNJKPONAOPO(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, int HDHJPIOPNFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "154")]
		protected virtual bool BKJEMIJIJKM(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, int HDHJPIOPNFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "155")]
		protected virtual bool CMBJMOBHEAN(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, int DNBAGCFNADG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "156")]
		protected virtual bool CJIFKGFBKDL(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, int MOJFMLAABNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5518860", Offset = "0x5516E60", VA = "0x185518860", Slot = "157")]
		protected virtual List<ACLPKCGEGFP> JLHOPDDEJNA(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "158")]
		protected virtual void IJJGDGDECAA(KIEOOBCGILC PEEMKKKLLMO, PKGAMJNFCDF OHJFGJDHPPD, LCBAJMHOMEH PEOKEDEMFEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5516620", Offset = "0x5514C20", VA = "0x185516620", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5517080", Offset = "0x5515680", VA = "0x185517080")]
		private PKGAMJNFCDF GOPKHENEGJF(KIEOOBCGILC PEEMKKKLLMO, LCBAJMHOMEH PEOKEDEMFEO, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5519170", Offset = "0x5517770", VA = "0x185519170")]
		private List<MPMMOAFDEHE> PHLFOICIICP(KIEOOBCGILC PEEMKKKLLMO, LCBAJMHOMEH PEOKEDEMFEO, PKGAMJNFCDF HGFLHMEJOLB, bool ODHLNAONGFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5515A40", Offset = "0x5514040", VA = "0x185515A40")]
		private List<MPMMOAFDEHE> CPBDDNLBMPA(KIEOOBCGILC PEEMKKKLLMO, LCBAJMHOMEH PEOKEDEMFEO, HGIFBECBIMN JHMPKACOBFK, bool ODHLNAONGFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5518F80", Offset = "0x5517580", VA = "0x185518F80")]
		private ACLPKCGEGFP OPLJLBFIOOF(List<ACLPKCGEGFP> KHFGELJEHJA, HGIFBECBIMN JHMPKACOBFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5516590", Offset = "0x5514B90", VA = "0x185516590")]
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
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public JFGMMFGEMAE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public GHLIEMBLMFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x273DF90", Offset = "0x273C590", VA = "0x18273DF90")]
			internal int PMOJIBLCDBE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x273DFE0", Offset = "0x273C5E0", VA = "0x18273DFE0")]
			internal void POFMCLKDAFO(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x10C1ED0", Offset = "0x10C04D0", VA = "0x1810C1ED0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x273F240", Offset = "0x273D840", VA = "0x18273F240")]
		public JFGMMFGEMAE(CHIEBOEDIPK IOIBNPDJCNE, IBJBOPEHBJM GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x273F080", Offset = "0x273D680", VA = "0x18273F080", Slot = "134")]
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
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public PMPHPDPPFMN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public AJECCCMFOBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x2736AC0", Offset = "0x27350C0", VA = "0x182736AC0")]
			internal int JGLMENIGIII()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x2736A20", Offset = "0x2735020", VA = "0x182736A20")]
			internal void EKEOADEHHLG(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2753C80", Offset = "0x2752280", VA = "0x182753C80")]
		public PMPHPDPPFMN(CHIEBOEDIPK IOIBNPDJCNE, DOGJFMBOJPF HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x2753A40", Offset = "0x2752040", VA = "0x182753A40", Slot = "140")]
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
			[Cpp2IlInjected.Address(RVA = "0xD90A70", Offset = "0xD8F070", VA = "0x180D90A70", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x273E2C0", Offset = "0x273C8C0", VA = "0x18273E2C0")]
		public ICHNHKEJCAO(CHIEBOEDIPK IOIBNPDJCNE, IJKDPFGJJAE GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "134")]
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
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public NBMMDOFDBPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public KIEOOBCGILC configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<string> <>9__224;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Action<string> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<int> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Action<int> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<bool> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<bool> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<float> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Action<float> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<bool> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<bool> <>9__236;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<bool> <>9__237;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<string> <>9__238;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public Action<string> <>9__239;

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public JHKHDANIILP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x274A3E0", Offset = "0x27489E0", VA = "0x18274A3E0")]
			internal bool PMOJIBLCDBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x274A480", Offset = "0x2748A80", VA = "0x18274A480")]
			internal void POFMCLKDAFO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x2749B90", Offset = "0x2748190", VA = "0x182749B90")]
			internal bool OABKELGAFGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x2749F20", Offset = "0x2748520", VA = "0x182749F20")]
			internal bool ONMGGGFMIMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x2747A50", Offset = "0x2746050", VA = "0x182747A50")]
			internal void IEBNCJCHKNG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x27488C0", Offset = "0x2746EC0", VA = "0x1827488C0")]
			internal bool JPFEDGBCBJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x274A430", Offset = "0x2748A30", VA = "0x18274A430")]
			internal bool PNCCNAEJOIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x2747B70", Offset = "0x2746170", VA = "0x182747B70")]
			internal void IFOPBOHCJEJ(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2749540", Offset = "0x2747B40", VA = "0x182749540")]
			internal bool MLKHAPMBMMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x2749220", Offset = "0x2747820", VA = "0x182749220")]
			internal bool LNOGJAFDNNH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x27414C0", Offset = "0x273FAC0", VA = "0x1827414C0")]
			internal void GKAKPGKIMJK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x2740BF0", Offset = "0x273F1F0", VA = "0x182740BF0")]
			internal bool ELFIHIHEIAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x2747D30", Offset = "0x2746330", VA = "0x182747D30")]
			internal bool IJHJEBBMAHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x27403F0", Offset = "0x273E9F0", VA = "0x1827403F0")]
			internal bool DCNOMKAMMKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x274A260", Offset = "0x2748860", VA = "0x18274A260")]
			internal bool PKLPPKCDGJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x2741770", Offset = "0x273FD70", VA = "0x182741770")]
			internal bool HGKECNJHDMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x2749310", Offset = "0x2747910", VA = "0x182749310")]
			internal bool MBMCBHPBCJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x273FE00", Offset = "0x273E400", VA = "0x18273FE00")]
			internal bool BOMACFEALKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x2748870", Offset = "0x2746E70", VA = "0x182748870")]
			internal bool JNHIMAHAFPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x2747EC0", Offset = "0x27464C0", VA = "0x182747EC0")]
			internal bool JAHBGHNNOGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x2749030", Offset = "0x2747630", VA = "0x182749030")]
			internal void LGCCABAHKJI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x27401C0", Offset = "0x273E7C0", VA = "0x1827401C0")]
			internal bool CNHFKEFEDIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x27417C0", Offset = "0x273FDC0", VA = "0x1827417C0")]
			internal bool HHCMALGMPMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x2740700", Offset = "0x273ED00", VA = "0x182740700")]
			internal bool DIABECDNLGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x2749270", Offset = "0x2747870", VA = "0x182749270")]
			internal bool LOLONPNLPEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2741810", Offset = "0x273FE10", VA = "0x182741810")]
			internal bool HLDLIBFCGOK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x274A210", Offset = "0x2748810", VA = "0x18274A210")]
			internal bool PJNMLLCFPAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x2748BB0", Offset = "0x27471B0", VA = "0x182748BB0")]
			internal bool KHKEDKLPEPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x27494F0", Offset = "0x2747AF0", VA = "0x1827494F0")]
			internal bool MKHKGCBNIFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x274A160", Offset = "0x2748760", VA = "0x18274A160")]
			internal void PHKFJDFCJHI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x2748DE0", Offset = "0x27473E0", VA = "0x182748DE0")]
			internal bool KOLAAKHFINO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x2748F90", Offset = "0x2747590", VA = "0x182748F90")]
			internal bool LENMPBEGKEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x274A060", Offset = "0x2748660", VA = "0x18274A060")]
			internal void PCAFOPAANHP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x2749CB0", Offset = "0x27482B0", VA = "0x182749CB0")]
			internal bool OHJFLJBICCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x27489B0", Offset = "0x2746FB0", VA = "0x1827489B0")]
			internal bool KDBPGMFJGNN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x2741960", Offset = "0x273FF60", VA = "0x182741960")]
			internal void ICGKPJCGCJL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x2741A30", Offset = "0x2740030", VA = "0x182741A30")]
			internal List<MPMMOAFDEHE> IDCHPEPLAJD(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x2748B60", Offset = "0x2747160", VA = "0x182748B60")]
			internal bool KGBJPEGJJKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x27412D0", Offset = "0x273F8D0", VA = "0x1827412D0")]
			internal int GDEMCCNPPFL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x2740D80", Offset = "0x273F380", VA = "0x182740D80")]
			internal void FFIDENIICBK(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x273F990", Offset = "0x273DF90", VA = "0x18273F990")]
			internal bool AMIAJCAANBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x2748960", Offset = "0x2746F60", VA = "0x182748960")]
			internal bool KCGCGEKPLOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x2749E80", Offset = "0x2748480", VA = "0x182749E80")]
			internal bool OKNLHPKHPOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x2740E80", Offset = "0x273F480", VA = "0x182740E80")]
			internal int FHEPFLHKHGH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x2748810", Offset = "0x2746E10", VA = "0x182748810")]
			internal void JLIOOHJBADI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x27493B0", Offset = "0x27479B0", VA = "0x1827493B0")]
			internal bool MDCFMOLGBOI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x274A010", Offset = "0x2748610", VA = "0x18274A010")]
			internal bool PAGDGNAFFPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x2749590", Offset = "0x2747B90", VA = "0x182749590")]
			internal bool MMAPDGLHKGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x273F8A0", Offset = "0x273DEA0", VA = "0x18273F8A0")]
			internal bool AFMKILHPBPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x2748FE0", Offset = "0x27475E0", VA = "0x182748FE0")]
			internal bool LFGJDEMBDGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x2749830", Offset = "0x2747E30", VA = "0x182749830")]
			internal bool NDEKNNICKDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x2741280", Offset = "0x273F880", VA = "0x182741280")]
			internal string GDBALIPOKFK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x273FC90", Offset = "0x273E290", VA = "0x18273FC90")]
			internal void BJAEJALGIDC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x2749D50", Offset = "0x2748350", VA = "0x182749D50")]
			internal int OIEBPIFFNDC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x2740160", Offset = "0x273E760", VA = "0x182740160")]
			internal void CMDGJNMMKEB(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x27487C0", Offset = "0x2746DC0", VA = "0x1827487C0")]
			internal bool JJNDIBJFHJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x2740DE0", Offset = "0x273F3E0", VA = "0x182740DE0")]
			internal bool FHAEAEAFEMO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x2747F60", Offset = "0x2746560", VA = "0x182747F60")]
			internal bool JCPJHKDEEJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x2740610", Offset = "0x273EC10", VA = "0x182740610")]
			internal float DHBDJONJKGL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x2741900", Offset = "0x273FF00", VA = "0x182741900")]
			internal void IBOHDCDELIE(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x2747D80", Offset = "0x2746380", VA = "0x182747D80")]
			internal bool IKCBHFFMLEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x2740A10", Offset = "0x273F010", VA = "0x182740A10")]
			internal bool EEOAMLECNKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x274A110", Offset = "0x2748710", VA = "0x18274A110")]
			internal bool PHAJFIKCADM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x2748CA0", Offset = "0x27472A0", VA = "0x182748CA0")]
			internal bool KLPHELEFLMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x2749130", Offset = "0x2747730", VA = "0x182749130")]
			internal bool LJKHHCDGANI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x27491D0", Offset = "0x27477D0", VA = "0x1827491D0")]
			internal bool LMPGHECFEAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x2747FB0", Offset = "0x27465B0", VA = "0x182747FB0")]
			internal void JDFCFNPPNIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x2748580", Offset = "0x2746B80", VA = "0x182748580")]
			internal string JFPMLNGBEBI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x2747AB0", Offset = "0x27460B0", VA = "0x182747AB0")]
			internal void IFGHNNJBIAJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x2748770", Offset = "0x2746D70", VA = "0x182748770")]
			internal bool JJHDBNBEADE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x2747E70", Offset = "0x2746470", VA = "0x182747E70")]
			internal bool INPPNEDMPLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x2748D90", Offset = "0x2747390", VA = "0x182748D90")]
			internal bool KNPIBOOMOGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x27498D0", Offset = "0x2747ED0", VA = "0x1827498D0")]
			internal void NIDHJCOBCIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x274A4E0", Offset = "0x2748AE0", VA = "0x18274A4E0")]
			internal bool PPGOACIADMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x2747C90", Offset = "0x2746290", VA = "0x182747C90")]
			internal bool IHJCLCEHCKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x2741120", Offset = "0x273F720", VA = "0x182741120")]
			internal bool FPCFENNDIML()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x2740860", Offset = "0x273EE60", VA = "0x182740860")]
			internal bool DOMGLJHEDLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x273FD00", Offset = "0x273E300", VA = "0x18273FD00")]
			internal void BKAMEIPEKJP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x2749880", Offset = "0x2747E80", VA = "0x182749880")]
			internal bool NDLALIIKMCM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x27404B0", Offset = "0x273EAB0", VA = "0x1827404B0")]
			internal bool DFEEDMLNBEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x27496E0", Offset = "0x2747CE0", VA = "0x1827496E0")]
			internal bool MNINIMHCJHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x2747B20", Offset = "0x2746120", VA = "0x182747B20")]
			internal bool IFIFMMAFNPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x27497D0", Offset = "0x2747DD0", VA = "0x1827497D0")]
			internal void NAHLFKNIHKK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x27413B0", Offset = "0x273F9B0", VA = "0x1827413B0")]
			internal bool GFNPECOCOAB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x273FE50", Offset = "0x273E450", VA = "0x18273FE50")]
			internal bool BPNCMJCDMOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x2740ED0", Offset = "0x273F4D0", VA = "0x182740ED0")]
			internal bool FHJPFHMGFDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x2748AC0", Offset = "0x27470C0", VA = "0x182748AC0")]
			internal bool KFABFBCDIAA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x2749C40", Offset = "0x2748240", VA = "0x182749C40")]
			internal object OGHPGEHGNHI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x2748620", Offset = "0x2746C20", VA = "0x182748620")]
			internal void JGOHDPGCHKD(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x2740F80", Offset = "0x273F580", VA = "0x182740F80")]
			internal bool FKHCHCNOOGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x2740020", Offset = "0x273E620", VA = "0x182740020")]
			internal bool CJHAIAKGAGG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x273F940", Offset = "0x273DF40", VA = "0x18273F940")]
			internal int AKKBEHCILKO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2741220", Offset = "0x273F820", VA = "0x182741220")]
			internal void GCKHEJHBFJG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x2749780", Offset = "0x2747D80", VA = "0x182749780")]
			internal bool MPJOJCLGANH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x273FDB0", Offset = "0x273E3B0", VA = "0x18273FDB0")]
			internal bool BNBNMKFHBLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x273FA30", Offset = "0x273E030", VA = "0x18273FA30")]
			internal int APFAHKANNHK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x273FEA0", Offset = "0x273E4A0", VA = "0x18273FEA0")]
			internal void CILCGHCAHKO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x27490E0", Offset = "0x27476E0", VA = "0x1827490E0")]
			internal bool LJIDNJJPIKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x274A390", Offset = "0x2748990", VA = "0x18274A390")]
			internal bool PMMFPDDIDNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x2740CE0", Offset = "0x273F2E0", VA = "0x182740CE0")]
			internal bool EPONDLBMBJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x2747E20", Offset = "0x2746420", VA = "0x182747E20")]
			internal int INODCPKAMBM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x273FA80", Offset = "0x273E080", VA = "0x18273FA80")]
			internal void APGAMICDNBF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x2749630", Offset = "0x2747C30", VA = "0x182749630")]
			internal bool MNEOEJAHFAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x27411D0", Offset = "0x273F7D0", VA = "0x1827411D0")]
			internal bool GAJKHJFDKPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x27402B0", Offset = "0x273E8B0", VA = "0x1827402B0")]
			internal bool DADBKIJMOLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x273FF00", Offset = "0x273E500", VA = "0x18273FF00")]
			internal object CJAFMCPDKIE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x2741320", Offset = "0x273F920", VA = "0x182741320")]
			internal void GEMHPDBMDAL(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x273F8F0", Offset = "0x273DEF0", VA = "0x18273F8F0")]
			internal bool AIOHMPADNAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x2747DD0", Offset = "0x27463D0", VA = "0x182747DD0")]
			internal bool IMDOKECIOHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x2740440", Offset = "0x273EA40", VA = "0x182740440")]
			internal object DEDFEBDOAGM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x2749DA0", Offset = "0x27483A0", VA = "0x182749DA0")]
			internal void OIKMNKKAALA(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x2740500", Offset = "0x273EB00", VA = "0x182740500")]
			internal bool DFIOANHPEAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x2740970", Offset = "0x273EF70", VA = "0x182740970")]
			internal int EEGAMIKMIAM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x2741070", Offset = "0x273F670", VA = "0x182741070")]
			internal void FNILNAMBPEB(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x2740E30", Offset = "0x273F430", VA = "0x182740E30")]
			internal bool FHELDENCOGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x2740750", Offset = "0x273ED50", VA = "0x182740750")]
			internal bool DINCNAAHIJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x2748F40", Offset = "0x2747540", VA = "0x182748F40")]
			internal bool LELKGBAAHPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x273FFD0", Offset = "0x273E5D0", VA = "0x18273FFD0")]
			internal int CJDPBDKIGFH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x273FF70", Offset = "0x273E570", VA = "0x18273FF70")]
			internal void CJDFKIBJDOB(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x2740210", Offset = "0x273E810", VA = "0x182740210")]
			internal bool CPKAJMNIOMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x273FC40", Offset = "0x273E240", VA = "0x18273FC40")]
			internal bool BIELHJCPLCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x2740D30", Offset = "0x273F330", VA = "0x182740D30")]
			internal bool FDLGMPNKHCO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x27485D0", Offset = "0x2746BD0", VA = "0x1827485D0")]
			internal float JGHKLLBNPEA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2749680", Offset = "0x2747C80", VA = "0x182749680")]
			internal void MNGIJKJKMJA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x2741400", Offset = "0x273FA00", VA = "0x182741400")]
			internal bool GHDLFOHCLBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x2741660", Offset = "0x273FC60", VA = "0x182741660")]
			internal bool HCLKCEGBPJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x27494A0", Offset = "0x2747AA0", VA = "0x1827494A0")]
			internal bool MJOEFBCBCKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x27406B0", Offset = "0x273ECB0", VA = "0x1827406B0")]
			internal float DHMKCAHFJPJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x2740F20", Offset = "0x273F520", VA = "0x182740F20")]
			internal void FKAIGIGIOCN(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x2749D00", Offset = "0x2748300", VA = "0x182749D00")]
			internal bool OHPHNNJNDBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x2749ED0", Offset = "0x27484D0", VA = "0x182749ED0")]
			internal bool OMIGCOOEFAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x2748EA0", Offset = "0x27474A0", VA = "0x182748EA0")]
			internal string LDHIJHHMLOF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2741700", Offset = "0x273FD00", VA = "0x182741700")]
			internal void HFELBEOKCOG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x273FD60", Offset = "0x273E360", VA = "0x18273FD60")]
			internal bool BMPGGJICDIP(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x2747F10", Offset = "0x2746510", VA = "0x182747F10")]
			internal bool JAPLEDMEAPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x2749730", Offset = "0x2747D30", VA = "0x182749730")]
			internal bool MNKEGGFPDMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x2749F70", Offset = "0x2748570", VA = "0x182749F70")]
			internal bool OOBNOIPMBDH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x2749FC0", Offset = "0x27485C0", VA = "0x182749FC0")]
			internal string OPCEANJMMJD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x2741450", Offset = "0x273FA50", VA = "0x182741450")]
			internal void GIPGNLCGNHJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x2747CE0", Offset = "0x27462E0", VA = "0x182747CE0")]
			internal bool IIFJJDGMECE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x27492C0", Offset = "0x27478C0", VA = "0x1827492C0")]
			internal bool MBHNIFOEFNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x2740550", Offset = "0x273EB50", VA = "0x182740550")]
			internal bool DFLIBFJKCOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x27400C0", Offset = "0x273E6C0", VA = "0x1827400C0")]
			internal bool CKMKOHPKEGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x2749E30", Offset = "0x2748430", VA = "0x182749E30")]
			internal string OJEPKBCDDPN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x2748700", Offset = "0x2746D00", VA = "0x182748700")]
			internal void JILHBMPFLLD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x2740A60", Offset = "0x273F060", VA = "0x182740A60")]
			internal bool EFPNECBMEFE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x27416B0", Offset = "0x273FCB0", VA = "0x1827416B0")]
			internal bool HEDFBCDOFJA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x2740110", Offset = "0x273E710", VA = "0x182740110")]
			internal bool CKONMJEJBIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x2748490", Offset = "0x2746A90", VA = "0x182748490")]
			internal bool JELCBLOODNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x2748530", Offset = "0x2746B30", VA = "0x182748530")]
			internal string JFGMDEJGGLO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x2748A50", Offset = "0x2747050", VA = "0x182748A50")]
			internal void KECMLALOGCA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x27415C0", Offset = "0x273FBC0", VA = "0x1827415C0")]
			internal bool HBLPKMCPFGI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x27403A0", Offset = "0x273E9A0", VA = "0x1827403A0")]
			internal bool DCNACDFGHPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x274A1C0", Offset = "0x27487C0", VA = "0x18274A1C0")]
			internal bool PIKDENHNOEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x2741570", Offset = "0x273FB70", VA = "0x182741570")]
			internal bool GMEOCCGFFGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x27483F0", Offset = "0x27469F0", VA = "0x1827483F0")]
			internal string JDFDJNLFLLK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x27419C0", Offset = "0x273FFC0", VA = "0x1827419C0")]
			internal void IDCCCEFKMKJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x2740070", Offset = "0x273E670", VA = "0x182740070")]
			internal bool CKIBJHGBIJH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x2749450", Offset = "0x2747A50", VA = "0x182749450")]
			internal bool MHKHLMPNKNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x2748B10", Offset = "0x2747110", VA = "0x182748B10")]
			internal bool KGAGDAHAFLK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x27410D0", Offset = "0x273F6D0", VA = "0x1827410D0")]
			internal bool FNMMODDMJKM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x2748D40", Offset = "0x2747340", VA = "0x182748D40")]
			internal string KNJCEBDKCDP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x273FB30", Offset = "0x273E130", VA = "0x18273FB30")]
			internal void BGCKGKAPIIC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x2749400", Offset = "0x2747A00", VA = "0x182749400")]
			internal bool MDHNFFJBNDL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x2748A00", Offset = "0x2747000", VA = "0x182748A00")]
			internal bool KDKGFGHPCPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x273F850", Offset = "0x273DE50", VA = "0x18273F850")]
			internal bool ADPNHHOPBBH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x2740AB0", Offset = "0x273F0B0", VA = "0x182740AB0")]
			internal bool EGDGMDMPNLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x2749180", Offset = "0x2747780", VA = "0x182749180")]
			internal string LKLPJLFKJID()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x27407A0", Offset = "0x273EDA0", VA = "0x1827407A0")]
			internal void DJICAICGKMD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x2740660", Offset = "0x273EC60", VA = "0x182740660")]
			internal bool DHCKPFOAAMC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x2740260", Offset = "0x273E860", VA = "0x182740260")]
			internal bool CPPPAACGLOK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x2748440", Offset = "0x2746A40", VA = "0x182748440")]
			internal bool JEFIGMDLMGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x2741520", Offset = "0x273FB20", VA = "0x182741520")]
			internal bool GKCBHFNCKKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x2741610", Offset = "0x273FC10", VA = "0x182741610")]
			internal string HCBHOLOBGJI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x27408B0", Offset = "0x273EEB0", VA = "0x1827408B0")]
			internal void DPBFGKKELFB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x27495E0", Offset = "0x2747BE0", VA = "0x1827495E0")]
			internal bool MMCGECNKPOI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x2749360", Offset = "0x2747960", VA = "0x182749360")]
			internal bool MCFIPMCBPCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x2740350", Offset = "0x273E950", VA = "0x182740350")]
			internal bool DCBKLJOFOMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x2748910", Offset = "0x2746F10", VA = "0x182748910")]
			internal bool KCFMKJOHKBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x27409C0", Offset = "0x273EFC0", VA = "0x1827409C0")]
			internal string EELLABLIEAC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x274A2B0", Offset = "0x27488B0", VA = "0x18274A2B0")]
			internal void PLBGAKNEALP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x2748C50", Offset = "0x2747250", VA = "0x182748C50")]
			internal bool KKLBOLDDAOH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x2740FD0", Offset = "0x273F5D0", VA = "0x182740FD0")]
			internal bool FLPDLCBDADB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x2747BD0", Offset = "0x27461D0", VA = "0x182747BD0")]
			internal bool IGEANBEIPKD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x2748EF0", Offset = "0x27474F0", VA = "0x182748EF0")]
			internal bool LECJDCJPLAL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x273FBA0", Offset = "0x273E1A0", VA = "0x18273FBA0")]
			internal string BHBOONBIDPL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x274A320", Offset = "0x2748920", VA = "0x18274A320")]
			internal void PLDAMMDOHCN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x2748C00", Offset = "0x2747200", VA = "0x182748C00")]
			internal bool KJEALLNJKDP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x2741860", Offset = "0x273FE60", VA = "0x182741860")]
			internal bool HMIHGDEEKNJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x27484E0", Offset = "0x2746AE0", VA = "0x1827484E0")]
			internal bool JFGBGEMPPJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x2748CF0", Offset = "0x27472F0", VA = "0x182748CF0")]
			internal string KMKCEAEFFMK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x27405A0", Offset = "0x273EBA0", VA = "0x1827405A0")]
			internal void DGBAKEFFPMN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x2740B00", Offset = "0x273F100", VA = "0x182740B00")]
			internal bool EGFDOKKOGIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x273F800", Offset = "0x273DE00", VA = "0x18273F800")]
			internal bool ACOOICPEDAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x2740920", Offset = "0x273EF20", VA = "0x182740920")]
			internal bool EEEIACAHCME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x2740B50", Offset = "0x273F150", VA = "0x182740B50")]
			internal string EKJGBPONCPN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x2748E30", Offset = "0x2747430", VA = "0x182748E30")]
			internal void LCJCFCCKAKG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x2740C40", Offset = "0x273F240", VA = "0x182740C40")]
			internal bool ELNGJBAMCJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x273F9E0", Offset = "0x273DFE0", VA = "0x18273F9E0")]
			internal bool ANBDOGKJBGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x273F7B0", Offset = "0x273DDB0", VA = "0x18273F7B0")]
			internal bool ABDJODMEODD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x2740810", Offset = "0x273EE10", VA = "0x182740810")]
			internal string DJMMJJILEIJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x2747C20", Offset = "0x2746220", VA = "0x182747C20")]
			internal void IGOFHGIJHDF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x273FAE0", Offset = "0x273E0E0", VA = "0x18273FAE0")]
			internal bool BBEFCDIDGHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x2740300", Offset = "0x273E900", VA = "0x182740300")]
			internal bool DCAFBCGPPNJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x2740BA0", Offset = "0x273F1A0", VA = "0x182740BA0")]
			internal float EKONCIPJIGD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x2741170", Offset = "0x273F770", VA = "0x182741170")]
			internal void FPPJPMKKDIP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x273FBF0", Offset = "0x273E1F0", VA = "0x18273FBF0")]
			internal bool BHOPOEIOMAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x2740C90", Offset = "0x273F290", VA = "0x182740C90")]
			internal bool EMAPCLILOFN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x2749090", Offset = "0x2747690", VA = "0x182749090")]
			internal bool LGOBGOADFFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x2741020", Offset = "0x273F620", VA = "0x182741020")]
			internal int FMJDBPHLIJC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x2749BE0", Offset = "0x27481E0", VA = "0x182749BE0")]
			internal void ODBPKKLGLLF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x27418B0", Offset = "0x273FEB0", VA = "0x1827418B0")]
			internal bool IBHIPNBCAFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x27486B0", Offset = "0x2746CB0", VA = "0x1827486B0")]
			internal bool JHMDPKKCEAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x274A0C0", Offset = "0x27486C0", VA = "0x18274A0C0")]
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
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public JHKHDANIILP CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public EJGLIOEPDAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x2758980", Offset = "0x2756F80", VA = "0x182758980")]
			internal void CIMALGBPGPM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class MFDBKKAFLGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public MFDBKKAFLGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x276E100", Offset = "0x276C700", VA = "0x18276E100")]
			internal bool BBODKEOPIIE(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private readonly OMPJEELBIEL INBDDKMBHHM;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2750FE0", Offset = "0x274F5E0", VA = "0x182750FE0")]
		public NBMMDOFDBPD(CHIEBOEDIPK IOIBNPDJCNE, OHNOHCLIODK GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x274F2B0", Offset = "0x274D8B0", VA = "0x18274F2B0", Slot = "134")]
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
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public LGFHDPJIFJM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002CA")]
				[Cpp2IlInjected.Address(RVA = "0x27721C0", Offset = "0x27707C0", VA = "0x1827721C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public NFNBLEBHBGJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public LGFHDPJIFJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x276DB20", Offset = "0x276C120", VA = "0x18276DB20")]
			internal string PMOJIBLCDBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x276DB70", Offset = "0x276C170", VA = "0x18276DB70")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void POFMCLKDAFO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x276DA40", Offset = "0x276C040", VA = "0x18276DA40")]
			internal int IGNBPBENOMC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x276DA90", Offset = "0x276C090", VA = "0x18276DA90")]
			internal void NOAGHDJPGKH(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x10C1ED0", Offset = "0x10C04D0", VA = "0x1810C1ED0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x276F1B0", Offset = "0x276D7B0", VA = "0x18276F1B0")]
		public NFNBLEBHBGJ(CHIEBOEDIPK IOIBNPDJCNE, AFPLICFBEMD HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x276EE50", Offset = "0x276D450", VA = "0x18276EE50", Slot = "134")]
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
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				public NFOCOPFNBNB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x2771E80", Offset = "0x2770480", VA = "0x182771E80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
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
				[Cpp2IlInjected.Token(Token = "0x4000189")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400018A")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400018B")]
				public NFOCOPFNBNB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400018C")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400018D")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400018E")]
				private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x27724D0", Offset = "0x2770AD0", VA = "0x1827724D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public KBKDCMBMLEH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public NFOCOPFNBNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x276FAC0", Offset = "0x276E0C0", VA = "0x18276FAC0")]
			internal string PMOJIBLCDBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x276FB60", Offset = "0x276E160", VA = "0x18276FB60")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void POFMCLKDAFO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x276F6D0", Offset = "0x276DCD0", VA = "0x18276F6D0")]
			internal int IGNBPBENOMC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x276F910", Offset = "0x276DF10", VA = "0x18276F910")]
			internal void NOAGHDJPGKH(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x276F9A0", Offset = "0x276DFA0", VA = "0x18276F9A0")]
			internal string OABKELGAFGC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x276F9F0", Offset = "0x276DFF0", VA = "0x18276F9F0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void ONMGGGFMIMJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x276F5F0", Offset = "0x276DBF0", VA = "0x18276F5F0")]
			internal bool IEBNCJCHKNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x276F560", Offset = "0x276DB60", VA = "0x18276F560")]
			internal void EGEKFLONCNL(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x276F8C0", Offset = "0x276DEC0", VA = "0x18276F8C0")]
			internal bool NNMDDOCMLBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x276F720", Offset = "0x276DD20", VA = "0x18276F720")]
			internal void JPFEDGBCBJK(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x276FB10", Offset = "0x276E110", VA = "0x18276FB10")]
			internal float PNCCNAEJOIK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x276F640", Offset = "0x276DC40", VA = "0x18276F640")]
			internal void IFOPBOHCJEJ(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x276F500", Offset = "0x276DB00", VA = "0x18276F500")]
			internal int AOACIPBKBMC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x276F7B0", Offset = "0x276DDB0", VA = "0x18276F7B0")]
			internal void LECHGFPGJPC(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x276F850", Offset = "0x276DE50", VA = "0x18276F850")]
			internal bool MLKHAPMBMMP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x10C1ED0", Offset = "0x10C04D0", VA = "0x1810C1ED0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x276CC20", Offset = "0x276B220", VA = "0x18276CC20")]
		public KBKDCMBMLEH(CHIEBOEDIPK IOIBNPDJCNE, KBCHKNEHNAA GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x276C1E0", Offset = "0x276A7E0", VA = "0x18276C1E0", Slot = "134")]
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
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public PCDIBCFBCNH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public DFAAFEJPDGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x2757650", Offset = "0x2755C50", VA = "0x182757650")]
			internal Dictionary<string, FDEEMEDLPLM> PMOJIBLCDBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x27576F0", Offset = "0x2755CF0", VA = "0x1827576F0")]
			internal int POFMCLKDAFO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x27574A0", Offset = "0x2755AA0", VA = "0x1827574A0")]
			internal void IGNBPBENOMC(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x27575D0", Offset = "0x2755BD0", VA = "0x1827575D0")]
			internal bool NOAGHDJPGKH()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x10C1ED0", Offset = "0x10C04D0", VA = "0x1810C1ED0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x2770CC0", Offset = "0x276F2C0", VA = "0x182770CC0")]
		public PCDIBCFBCNH(CHIEBOEDIPK IOIBNPDJCNE, FIEHHNCKPOL HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x27709F0", Offset = "0x276EFF0", VA = "0x1827709F0", Slot = "134")]
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
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public LPBPJLKNJON <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public ODOEJGANNGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x2770760", Offset = "0x276ED60", VA = "0x182770760")]
			internal void PMOJIBLCDBE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x10C1ED0", Offset = "0x10C04D0", VA = "0x1810C1ED0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x276DFB0", Offset = "0x276C5B0", VA = "0x18276DFB0")]
		public LPBPJLKNJON(CHIEBOEDIPK IOIBNPDJCNE, DGDDEEHKDLD HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x276DE30", Offset = "0x276C430", VA = "0x18276DE30", Slot = "134")]
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
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override LHKHFOBECGD? MPNBODDFADA
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x4AC6E40", Offset = "0x4AC5440", VA = "0x184AC6E40", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override bool AHNFHPOEEOH
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x4AC6EF0", Offset = "0x4AC54F0", VA = "0x184AC6EF0", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0xDA2E50", Offset = "0xDA1450", VA = "0x180DA2E50", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x4AC6EB0", Offset = "0x4AC54B0", VA = "0x184AC6EB0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public BNMFDMDMDNG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public CADLGFIIACM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2756BA0", Offset = "0x27551A0", VA = "0x182756BA0")]
			internal object PMOJIBLCDBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x2756C10", Offset = "0x2755210", VA = "0x182756C10")]
			internal void POFMCLKDAFO(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2756AB0", Offset = "0x27550B0", VA = "0x182756AB0")]
			internal void IGNBPBENOMC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private static object[]? NPIFABICPBE;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x2756610", Offset = "0x2754C10", VA = "0x182756610")]
		public BNMFDMDMDNG(CHIEBOEDIPK IOIBNPDJCNE, MPCMGDEBFJF GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x2756070", Offset = "0x2754670", VA = "0x182756070", Slot = "134")]
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
			[Cpp2IlInjected.Address(RVA = "0xC81E70", Offset = "0xC80470", VA = "0x180C81E70", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x2755930", Offset = "0x2753F30", VA = "0x182755930")]
		public ALDIKEOLCNG(CHIEBOEDIPK IOIBNPDJCNE, MAIGKIHJJPI GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "134")]
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
			[Cpp2IlInjected.Address(RVA = "0xBD62C0", Offset = "0xBD48C0", VA = "0x180BD62C0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x2759C90", Offset = "0x2758290", VA = "0x182759C90")]
		public FGCENHIDMKL(CHIEBOEDIPK IOIBNPDJCNE, AKDPEHEBLNE GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "126")]
		protected override bool EIOFANCGDJC(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "134")]
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
			[Cpp2IlInjected.Address(RVA = "0xBC1A20", Offset = "0xBC0020", VA = "0x180BC1A20", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool PBCBCPMKOGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x27577B0", Offset = "0x2755DB0", VA = "0x1827577B0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		protected override bool GIPCIPECMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x2757740", Offset = "0x2755D40", VA = "0x182757740")]
		public DGLBFJGOPCJ(CHIEBOEDIPK IOIBNPDJCNE, BOAJFIAJAGG GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "134")]
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
			[Cpp2IlInjected.Address(RVA = "0xBD6DF0", Offset = "0xBD53F0", VA = "0x180BD6DF0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override bool PBCBCPMKOGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x27595A0", Offset = "0x2757BA0", VA = "0x1827595A0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected override bool GIPCIPECMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x2759530", Offset = "0x2757B30", VA = "0x182759530")]
		public ELIOLFAAEHN(CHIEBOEDIPK IOIBNPDJCNE, PFDJIBKGAOI GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "134")]
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
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public FAHGAJMCPDB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public LMGBCKFAICJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x276DDB0", Offset = "0x276C3B0", VA = "0x18276DDB0")]
			internal float JGLMENIGIII()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x276DD10", Offset = "0x276C310", VA = "0x18276DD10")]
			internal void EKEOADEHHLG(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x2759870", Offset = "0x2757E70", VA = "0x182759870")]
		public FAHGAJMCPDB(CHIEBOEDIPK IOIBNPDJCNE, MLJMLAKGDLM HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x27595F0", Offset = "0x2757BF0", VA = "0x1827595F0", Slot = "140")]
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
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public KBHGFFNALAI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public JBDMGAKPEED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x2765800", Offset = "0x2763E00", VA = "0x182765800")]
			internal bool PMOJIBLCDBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x2765850", Offset = "0x2763E50", VA = "0x182765850")]
			internal void POFMCLKDAFO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x276C170", Offset = "0x276A770", VA = "0x18276C170")]
		public KBHGFFNALAI(CHIEBOEDIPK IOIBNPDJCNE, BFDACMGFOEJ HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x276BEC0", Offset = "0x276A4C0", VA = "0x18276BEC0", Slot = "134")]
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
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public ODJEJADKCLE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public NBENDJAPKDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x276EA60", Offset = "0x276D060", VA = "0x18276EA60")]
			internal object PMOJIBLCDBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x276E640", Offset = "0x276CC40", VA = "0x18276E640")]
			internal bool EGEKFLONCNL(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x276EB90", Offset = "0x276D190", VA = "0x18276EB90")]
			internal void POFMCLKDAFO(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x276E7F0", Offset = "0x276CDF0", VA = "0x18276E7F0")]
			internal string IGNBPBENOMC(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x276E950", Offset = "0x276CF50", VA = "0x18276E950")]
			internal IReadOnlyList<object> NOAGHDJPGKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x276E9A0", Offset = "0x276CFA0", VA = "0x18276E9A0")]
			internal bool OABKELGAFGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x276EA10", Offset = "0x276D010", VA = "0x18276EA10")]
			internal bool ONMGGGFMIMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x276E6C0", Offset = "0x276CCC0", VA = "0x18276E6C0")]
			internal void IEBNCJCHKNG(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x27706F0", Offset = "0x276ECF0", VA = "0x1827706F0")]
		public ODJEJADKCLE(CHIEBOEDIPK IOIBNPDJCNE, PIICCOEOBBP HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x276FEE0", Offset = "0x276E4E0", VA = "0x18276FEE0", Slot = "134")]
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
			[Cpp2IlInjected.Address(RVA = "0xD91970", Offset = "0xD8FF70", VA = "0x180D91970", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x276E5E0", Offset = "0x276CBE0", VA = "0x18276E5E0")]
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
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public BMJLNJEEIND <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public MPHILEHALJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x276E560", Offset = "0x276CB60", VA = "0x18276E560")]
			internal int JGLMENIGIII()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x276E4C0", Offset = "0x276CAC0", VA = "0x18276E4C0")]
			internal void EKEOADEHHLG(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x2756010", Offset = "0x2754610", VA = "0x182756010")]
		public BMJLNJEEIND(CHIEBOEDIPK IOIBNPDJCNE, ODMJFHHFCPD HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2755D80", Offset = "0x2754380", VA = "0x182755D80", Slot = "140")]
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
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public KAGJBLIDLOJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public MDJALHEABLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x276E020", Offset = "0x276C620", VA = "0x18276E020")]
			internal bool PMOJIBLCDBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x276E070", Offset = "0x276C670", VA = "0x18276E070")]
			internal void POFMCLKDAFO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x2766CF0", Offset = "0x27652F0", VA = "0x182766CF0")]
		public KAGJBLIDLOJ(CHIEBOEDIPK IOIBNPDJCNE, ENCPOFPCDLE HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x2766B10", Offset = "0x2765110", VA = "0x182766B10", Slot = "134")]
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
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public PLODEMAGGJI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public GKFDJBCFKJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x2764800", Offset = "0x2762E00", VA = "0x182764800")]
			internal bool PMOJIBLCDBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x2764850", Offset = "0x2762E50", VA = "0x182764850")]
			internal void POFMCLKDAFO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x2771740", Offset = "0x276FD40", VA = "0x182771740")]
		public PLODEMAGGJI(CHIEBOEDIPK IOIBNPDJCNE, ADEHFDAHCIJ HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x2771560", Offset = "0x276FB60", VA = "0x182771560", Slot = "134")]
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
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public NFNNDHBPIOD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public IIMKKANEDAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x2765720", Offset = "0x2763D20", VA = "0x182765720")]
			internal int PMOJIBLCDBE()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x2765770", Offset = "0x2763D70", VA = "0x182765770")]
			internal void POFMCLKDAFO(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x276F490", Offset = "0x276DA90", VA = "0x18276F490")]
		public NFNNDHBPIOD(CHIEBOEDIPK IOIBNPDJCNE, APFOIGIFMBP HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x276F220", Offset = "0x276D820", VA = "0x18276F220", Slot = "134")]
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
			[Cpp2IlInjected.Address(RVA = "0xBEDFB0", Offset = "0xBEC5B0", VA = "0x180BEDFB0", Slot = "140")]
			get
			{
				return default(AEKGKKLKPIL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x276CD20", Offset = "0x276B320", VA = "0x18276CD20")]
		public KLDMJLEPECE(CHIEBOEDIPK IOIBNPDJCNE, BHJKPCBFIGC HCAMONPFOJM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class KIAABMIFJGK : FNEGPADGNAD<GDCCFCAPGMP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x276CCB0", Offset = "0x276B2B0", VA = "0x18276CCB0")]
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
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			public FNEGPADGNAD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			public CHIEBOEDIPK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public NIBLBMINLLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x53F8FE0", Offset = "0x53F75E0", VA = "0x1853F8FE0")]
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
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public FNEGPADGNAD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x5360580", Offset = "0x535EB80", VA = "0x185360580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public FNEGPADGNAD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public HOCBFPONHJI? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public GKMDHBAFLMJ? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x4A60AD0", Offset = "0x4A5F0D0", VA = "0x184A60AD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x4A60D70", Offset = "0x4A5F370", VA = "0x184A60D70", Slot = "5")]
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
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				public DLAHLDCIGLF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60003C6")]
				[Cpp2IlInjected.Address(RVA = "0x4070210", Offset = "0x406E810", VA = "0x184070210", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003C7")]
				[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public FNEGPADGNAD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public KIEOOBCGILC configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public DLAHLDCIGLF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			internal string BKBNGNIBHDI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
			internal void LCKCNAGKCPA(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x6A47810", Offset = "0x6A45E10", VA = "0x186A47810")]
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
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public OGLLNMKJNJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x552C8C0", Offset = "0x552AEC0", VA = "0x18552C8C0")]
			internal bool DCHOHHHCKKG(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x552C9A0", Offset = "0x552AFA0", VA = "0x18552C9A0")]
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
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public FNEGPADGNAD<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x561E050", Offset = "0x561C650", VA = "0x18561E050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x561E3E0", Offset = "0x561C9E0", VA = "0x18561E3E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private readonly CHIEBOEDIPK FBKDHJDLAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private readonly bool IKAHDLKDAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private DAABAMGFIFM<MECIAIKJJDL, KAMDBIDHFJB> PCAPKGJHNBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private DAABAMGFIFM<MECIAIKJJDL, LCBAJMHOMEH> OKKFFGDMCHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private List<Action> CGMEMDIEPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[CompilerGenerated]
		private Action<EDBALDILLBK<MECIAIKJJDL>>? HFBOGMLDHFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[CompilerGenerated]
		private Action<EDBALDILLBK<MECIAIKJJDL>, LCBAJMHOMEH>? LPFGNGPBFJF;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected BOIDOHDBGAH IKMBEHHBIHH
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x49CFC50", Offset = "0x49CE250", VA = "0x1849CFC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected KPOHEEDLBMM INMJMNDONMN
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x49CE7E0", Offset = "0x49CCDE0", VA = "0x1849CE7E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected TNode KFNFIFHNECA
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
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
			[Cpp2IlInjected.Address(RVA = "0x1369220", Offset = "0x1367820", VA = "0x181369220", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x49D28E0", Offset = "0x49D0EE0", VA = "0x1849D28E0", Slot = "6")]
			get
			{
				return default(EDBALDILLBK<APOJALOJJAE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public object LAAONLPPGKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x45812E0", Offset = "0x457F8E0", VA = "0x1845812E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual bool DEIOCHPOGPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public int FIGDBNMNPBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x49D2540", Offset = "0x49D0B40", VA = "0x1849D2540", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public GBMHCNCGHKO DJKDFMEBLMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x49D24E0", Offset = "0x49D0AE0", VA = "0x1849D24E0", Slot = "10")]
			get
			{
				return default(GBMHCNCGHKO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string JIAJMGMPCHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x49D2AE0", Offset = "0x49D10E0", VA = "0x1849D2AE0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual bool GIPCIPECMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public EDBALDILLBK<IGKACGMLLNC> KEPANGGCHJK
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xE58DB0", Offset = "0xE573B0", VA = "0x180E58DB0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(EDBALDILLBK<IGKACGMLLNC>);
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xE6D7B0", Offset = "0xE6BDB0", VA = "0x180E6D7B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool HACOJECEIDD
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool PBCBCPMKOGB
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual bool KJJGFKDOJKG
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual DIBHJHIJCOI EHMCAFAODKF
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xF74700", Offset = "0xF72D00", VA = "0x180F74700", Slot = "108")]
			get
			{
				return default(DIBHJHIJCOI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool HEKEFGNMDHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x49D2250", Offset = "0x49D0850", VA = "0x1849D2250", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool PBEDEICOIBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x49D22B0", Offset = "0x49D08B0", VA = "0x1849D22B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool EAEGMAGNJHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x49D2310", Offset = "0x49D0910", VA = "0x1849D2310", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int OABGDBHGKHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x49D2890", Offset = "0x49D0E90", VA = "0x1849D2890", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool ECEJAOOAKDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x49D26C0", Offset = "0x49D0CC0", VA = "0x1849D26C0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public DDJFHGBJPBO IBILGABBPNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x49D2420", Offset = "0x49D0A20", VA = "0x1849D2420", Slot = "23")]
			get
			{
				return default(DDJFHGBJPBO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool JCIMDBLFIHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x49D23C0", Offset = "0x49D09C0", VA = "0x1849D23C0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool CNIMKFOEKNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xF3B060", Offset = "0xF39660", VA = "0x180F3B060", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x132DEA0", Offset = "0x132C4A0", VA = "0x18132DEA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool DNJFHPFNIBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool GLGECKLAFLB
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x49D2370", Offset = "0x49D0970", VA = "0x1849D2370", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public bool CIODJOPFHJP
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x49D25F0", Offset = "0x49D0BF0", VA = "0x1849D25F0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public HOCBFPONHJI HOKNMKCMKBD
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x49D27D0", Offset = "0x49D0DD0", VA = "0x1849D27D0", Slot = "29")]
			get
			{
				return default(HOCBFPONHJI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public GKMDHBAFLMJ OIMDLFMMKJI
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x49D2830", Offset = "0x49D0E30", VA = "0x1849D2830", Slot = "31")]
			get
			{
				return default(GKMDHBAFLMJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual bool CLEKMDDFLLL
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public virtual MEJBGBIMNJP? PONKCEOENOM
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "123")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual LHKHFOBECGD? MPNBODDFADA
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual IEnumerable<IGLPJBODKFE<ALEKBGLLPHJ>>? BGLFMODOKND
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool CKIOHCJBNMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x49D2480", Offset = "0x49D0A80", VA = "0x1849D2480", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public IGLPJBODKFE<BIEIIMCKPHN> CHOAMIELENC
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x49D2710", Offset = "0x49D0D10", VA = "0x1849D2710", Slot = "63")]
			get
			{
				return default(IGLPJBODKFE<BIEIIMCKPHN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public EDBALDILLBK<BIEIIMCKPHN> CNMEJNNBCFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x49D2590", Offset = "0x49D0B90", VA = "0x1849D2590", Slot = "57")]
			get
			{
				return default(EDBALDILLBK<BIEIIMCKPHN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public virtual bool PCNJMJHNNHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public virtual EDBALDILLBK<BIEIIMCKPHN>? EIKAIJOGKJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public virtual bool AHNFHPOEEOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool GLNMCHFEANJ
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x49D2650", Offset = "0x49D0C50", VA = "0x1849D2650", Slot = "62")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string IJKBIMCGCEM
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x9F3180", Offset = "0x9F1780", VA = "0x1809F3180", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x9F3080", Offset = "0x9F1680", VA = "0x1809F3080")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public string JENOGKFLHBM
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x9F30F0", Offset = "0x9F16F0", VA = "0x1809F30F0", Slot = "67")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x9F3010", Offset = "0x9F1610", VA = "0x1809F3010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public EDBALDILLBK<ALEKBGLLPHJ> IIODNFIGJOE
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x49D2960", Offset = "0x49D0F60", VA = "0x1849D2960", Slot = "64")]
			get
			{
				return default(EDBALDILLBK<ALEKBGLLPHJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public IGLPJBODKFE<ALEKBGLLPHJ> AEFADELMNOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x49D2770", Offset = "0x49D0D70", VA = "0x1849D2770", Slot = "65")]
			get
			{
				return default(IGLPJBODKFE<ALEKBGLLPHJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public IGLPJBODKFE<ALEKBGLLPHJ>? CGIKJENKLLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x49D29C0", Offset = "0x49D0FC0", VA = "0x1849D29C0", Slot = "132")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public KOLDGJODODL<MECIAIKJJDL, LCBAJMHOMEH> DJIFCIGFLGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x49D2AA0", Offset = "0x49D10A0", VA = "0x1849D2AA0", Slot = "68")]
			get
			{
				return default(KOLDGJODODL<MECIAIKJJDL, LCBAJMHOMEH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public virtual EDBALDILLBK<MECIAIKJJDL>? NEHDIPFJKOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public virtual bool HFIAGEGNIAP
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public virtual bool IGKIADCDCPB
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "137")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action IJMGPLFFILC
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x49D1320", Offset = "0x49CF920", VA = "0x1849D1320", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x49CF860", Offset = "0x49CDE60", VA = "0x1849CF860", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event LNFJOIOMGPN EKNNJGIHMBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x49CF420", Offset = "0x49CDA20", VA = "0x1849CF420", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x49D0DA0", Offset = "0x49CF3A0", VA = "0x1849D0DA0", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event KAOEKOOECFA KBPPNEAFIDH
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x49CF530", Offset = "0x49CDB30", VA = "0x1849CF530", Slot = "42")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x49D1BA0", Offset = "0x49D01A0", VA = "0x1849D1BA0", Slot = "43")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action GHBBKKJBBCP
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x49CECD0", Offset = "0x49CD2D0", VA = "0x1849CECD0", Slot = "44")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x49D16B0", Offset = "0x49CFCB0", VA = "0x1849D16B0", Slot = "45")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action IIJNBHAPDAD
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x49D1900", Offset = "0x49CFF00", VA = "0x1849D1900", Slot = "46")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x49CFF20", Offset = "0x49CE520", VA = "0x1849CFF20", Slot = "47")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<EDBALDILLBK<MECIAIKJJDL>, LCBAJMHOMEH> GHALFBPJHCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x49CD990", Offset = "0x49CBF90", VA = "0x1849CD990", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x49D0CE0", Offset = "0x49CF2E0", VA = "0x1849D0CE0", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<EDBALDILLBK<MECIAIKJJDL>, LCBAJMHOMEH> HHKOBCNAIJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x49D1260", Offset = "0x49CF860", VA = "0x1849D1260", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x49CF360", Offset = "0x49CD960", VA = "0x1849CF360", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<EDBALDILLBK<MECIAIKJJDL>> MABHKDOOCNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x49CFCB0", Offset = "0x49CE2B0", VA = "0x1849CFCB0", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x49CE8D0", Offset = "0x49CCED0", VA = "0x1849CE8D0", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<MECIAIKJJDL>> ALEENNJIBGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x49CE720", Offset = "0x49CCD20", VA = "0x1849CE720", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x49CF5D0", Offset = "0x49CDBD0", VA = "0x1849CF5D0", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<EDBALDILLBK<MECIAIKJJDL>, LCBAJMHOMEH> FGDABIDOHOI
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x49CE990", Offset = "0x49CCF90", VA = "0x1849CE990", Slot = "78")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x49CFD70", Offset = "0x49CE370", VA = "0x1849CFD70", Slot = "79")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<MECIAIKJJDL>> PIHADOKDHNF
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x49D0B00", Offset = "0x49CF100", VA = "0x1849D0B00", Slot = "80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x49D0A40", Offset = "0x49CF040", VA = "0x1849D0A40", Slot = "81")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x49D1C80", Offset = "0x49D0280", VA = "0x1849D1C80")]
		[HCCKFFEHNEM("Need to handle `Name` better.")]
		[HCCKFFEHNEM("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected FNEGPADGNAD(CHIEBOEDIPK IOIBNPDJCNE, TNode GOJJJBGJPAM, bool FPPJBNBMHCF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x49CE480", Offset = "0x49CCA80", VA = "0x1849CE480", Slot = "100")]
		protected virtual void ANJKPBDKBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x49CEDA0", Offset = "0x49CD3A0", VA = "0x1849CEDA0", Slot = "101")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x49CF690", Offset = "0x49CDC90", VA = "0x1849CF690", Slot = "9")]
		[AsyncStateMachine(typeof(FNEGPADGNAD<>.MJICOBAAHCB))]
		public void GPLPOAMHICN(int EHDJELKNEGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x49CDA50", Offset = "0x49CC050", VA = "0x1849CDA50")]
		public bool AGKGIONFDCG([In] HOCBFPONHJI OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x49CF4C0", Offset = "0x49CDAC0", VA = "0x1849CF4C0")]
		public bool FNCDDIOOAJL([In] GKMDHBAFLMJ OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x49CEAC0", Offset = "0x49CD0C0", VA = "0x1849CEAC0", Slot = "33")]
		public void DKLNPPECIOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x49D19C0", Offset = "0x49CFFC0", VA = "0x1849D19C0", Slot = "34")]
		[AsyncStateMachine(typeof(FNEGPADGNAD<>.AECMFPIFCLO))]
		public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> ONDIIHJNKEJ(HOCBFPONHJI? IHMLAPGNLCC, GKMDHBAFLMJ? JHMNNKLOODA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "111")]
		public virtual void DPJNCOAHMEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "112")]
		public virtual void AMINAPIHPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "113")]
		public virtual void MOHEOJBDAHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xF15560", Offset = "0xF13B60", VA = "0x180F15560")]
		protected void PNIEEIGODBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0xF6F900", Offset = "0xF6DF00", VA = "0x180F6F900")]
		protected void FJLKHHLNFFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x215BDD0", Offset = "0x215A3D0", VA = "0x18215BDD0")]
		private void MGAMHGEPDFM([In] GKMDHBAFLMJ OOBEGCNALKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x49D13C0", Offset = "0x49CF9C0", VA = "0x1849D13C0", Slot = "114")]
		public virtual Task<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> NLJCJIFCEPE(string NFHOBPDKIPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x49CF740", Offset = "0x49CDD40", VA = "0x1849CF740", Slot = "115")]
		public virtual Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> HBOMGBAHBHB(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "116")]
		public virtual void DOMLNJILBBI(EDBALDILLBK<MECIAIKJJDL> GOBLBPCAJLF, EDBALDILLBK<MECIAIKJJDL> CIGKLILMOBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x49D0310", Offset = "0x49CE910", VA = "0x1849D0310", Slot = "117")]
		public virtual IEnumerable<AFPLFKDKJPC> LDELJOIKHDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x49D1B10", Offset = "0x49D0110", VA = "0x1849D1B10", Slot = "118")]
		public HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC> OPKPHBIOMGM(string NKGPMKCBABE)
		{
			return default(HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x49CF1E0", Offset = "0x49CD7E0", VA = "0x1849CF1E0", Slot = "48")]
		public bool FGOOLEAEIJD([Out] Guid MFIFMINLAOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x49D0060", Offset = "0x49CE660", VA = "0x1849D0060")]
		public bool LANIFLKJJLB([In] Guid KJCOKJBCCGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "119")]
		public virtual void KGPJOLOPJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "120")]
		public virtual void PAPPEGNGKNO(bool MNCKABJBEAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "121")]
		public virtual GDJKOKGENEI BPMDOHDDCAH([In] DABGAEBMAMH FKAPNLOLMHJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x49CF9F0", Offset = "0x49CDFF0", VA = "0x1849CF9F0")]
		protected void JKGELNPMHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x49CF1A0", Offset = "0x49CD7A0", VA = "0x1849CF1A0", Slot = "126")]
		protected virtual bool EIOFANCGDJC(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x49CF330", Offset = "0x49CD930", VA = "0x1849CF330", Slot = "89")]
		public bool FJFNPLHBBPD(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "127")]
		protected virtual bool BLLOHDPAIJK(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "134")]
		protected virtual void GKHEOHIHOAF(KIEOOBCGILC LMAAGDPIAGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x49CDAC0", Offset = "0x49CC0C0", VA = "0x1849CDAC0")]
		protected void AGNADLPHKEG(KIEOOBCGILC PEEMKKKLLMO, Func<string> LANFPAMJOEN, Action<string> CLDNNLHGKBG, string OAHHBMJFHPN, string AHNDNFIBLJP, string IKNGLHOBDCH, BNNAKOGIDLO NFKBGBCCHAD, LOHMEEOFGPN FCELLNGEKLF, Func<string, bool> DMBDJKJHGMD, string PAOOMNDAKKB, Func<string, bool> JOMCHNAJBAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x49D0750", Offset = "0x49CED50", VA = "0x1849D0750")]
		protected void LFGNIGHADEO(KIEOOBCGILC PEEMKKKLLMO, Func<string> LANFPAMJOEN, Action<string> CLDNNLHGKBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x49D1490", Offset = "0x49CFA90", VA = "0x1849D1490", Slot = "135")]
		protected virtual void NOOGFLKBKII(KIEOOBCGILC PEEMKKKLLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x49CF810", Offset = "0x49CDE10", VA = "0x1849CF810", Slot = "83")]
		public void HMHNDPEKCAL(KIEOOBCGILC PEEMKKKLLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x49CF900", Offset = "0x49CDF00", VA = "0x1849CF900", Slot = "84")]
		public FGKPLMFNBOC IMLNFPJBFLH()
		{
			return default(FGKPLMFNBOC);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "138")]
		public virtual bool CJLAALIHDHE(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x1F4C210", Offset = "0x1F4A810", VA = "0x181F4C210")]
		private void ELHKKMCKJPL([In] HOCBFPONHJI EPCLGOKLIPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x49CD840", Offset = "0x49CBE40", VA = "0x1849CD840")]
		private void ABFKHHJAKII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x49D1C40", Offset = "0x49D0240", VA = "0x1849D1C40", Slot = "90")]
		private void POOIEHIEPCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x49CDEC0", Offset = "0x49CC4C0", VA = "0x1849CDEC0", Slot = "92")]
		private void AICABCKONJA(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x10B7C40", Offset = "0x10B6240", VA = "0x1810B7C40", Slot = "94")]
		private void BBINAMCKGGK(EDBALDILLBK<MECIAIKJJDL> HJPLNJNIFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x49D1750", Offset = "0x49CFD50", VA = "0x1849D1750", Slot = "96")]
		private void OJHGLMFDOJC(EDBALDILLBK<MECIAIKJJDL> HJPLNJNIFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x49D03A0", Offset = "0x49CE9A0", VA = "0x1849D03A0", Slot = "97")]
		private void LFBBKGAGOKE(EDBALDILLBK<MECIAIKJJDL> GOBLBPCAJLF, EDBALDILLBK<MECIAIKJJDL> CIGKLILMOBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x10B8840", Offset = "0x10B6E40", VA = "0x1810B8840", Slot = "98")]
		private void BKIIENPLLHF(EDBALDILLBK<MECIAIKJJDL> GOBLBPCAJLF, EDBALDILLBK<MECIAIKJJDL> CIGKLILMOBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x49D19A0", Offset = "0x49CFFA0", VA = "0x1849D19A0", Slot = "91")]
		private void OMFKJNGMKOD(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x49D0E40", Offset = "0x49CF440", VA = "0x1849D0E40", Slot = "93")]
		private void NJDNMBKIPNC(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x49CFBE0", Offset = "0x49CE1E0", VA = "0x1849CFBE0", Slot = "95")]
		private void JOMGANLAEEL(EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x49D0BC0", Offset = "0x49CF1C0", VA = "0x1849D0BC0", Slot = "139")]
		[AsyncStateMachine(typeof(FNEGPADGNAD<>.PKELKMKEMOG))]
		public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> NCNIAMHJFOC(string NKGPMKCBABE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x49CEA50", Offset = "0x49CD050", VA = "0x1849CEA50", Slot = "55")]
		private void DKFGGBFHHDD(object CDJPOMBFFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x49CFEB0", Offset = "0x49CE4B0", VA = "0x1849CFEB0", Slot = "56")]
		private void KLMPBFOFAHI(object CDJPOMBFFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x497F6F0", Offset = "0x497DCF0", VA = "0x18497F6F0", Slot = "30")]
		private bool DGOEBMGEOIM([In] HOCBFPONHJI OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x49CFE70", Offset = "0x49CE470", VA = "0x1849CFE70", Slot = "32")]
		private bool KLJHEJMEPMN([In] GKMDHBAFLMJ OHLIHBDBKCE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x49D1710", Offset = "0x49CFD10", VA = "0x1849D1710", Slot = "49")]
		private bool OCCBBBPLIJK([In] Guid KJCOKJBCCGD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x49CFE30", Offset = "0x49CE430", VA = "0x1849CFE30")]
		[CompilerGenerated]
		private string KKEHDNIABKC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x49CFFC0", Offset = "0x49CE5C0", VA = "0x1849CFFC0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD8CBD0", Offset = "0xD8B1D0", VA = "0x180D8CBD0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x276EDF0", Offset = "0x276D3F0", VA = "0x18276EDF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xBEDFB0", Offset = "0xBEC5B0", VA = "0x180BEDFB0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x2770920", Offset = "0x276EF20", VA = "0x182770920")]
		public OMGMDOHNNFE(CHIEBOEDIPK IOIBNPDJCNE, HOOPEMPEGPI GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "134")]
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
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public IReadOnlyList<KeyValuePair<string, FDEEMEDLPLM>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public CAMHBDKBKIA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public AEKGKKLKPIL clipType;

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public JMJNDJLFPAJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			internal IReadOnlyList<KeyValuePair<string, FDEEMEDLPLM>> PMOJIBLCDBE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x4E8ADC0", Offset = "0x4E893C0", VA = "0x184E8ADC0")]
			internal int POFMCLKDAFO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x4E8A7E0", Offset = "0x4E88DE0", VA = "0x184E8A7E0")]
			internal void IGNBPBENOMC(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0x4E8ABD0", Offset = "0x4E891D0", VA = "0x184E8ABD0")]
			internal void NOAGHDJPGKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x4E8AC20", Offset = "0x4E89220", VA = "0x184E8AC20")]
			internal void OABKELGAFGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x4E8A640", Offset = "0x4E88C40", VA = "0x184E8A640")]
			internal bool ONMGGGFMIMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x4E8A6D0", Offset = "0x4E88CD0", VA = "0x184E8A6D0")]
			internal void IEBNCJCHKNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x4E8A640", Offset = "0x4E88C40", VA = "0x184E8A640")]
			internal bool EGEKFLONCNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x4E8AB80", Offset = "0x4E89180", VA = "0x184E8AB80")]
			internal float NNMDDOCMLBP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x4E8AA00", Offset = "0x4E89000", VA = "0x184E8AA00")]
			internal void JPFEDGBCBJK(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x4E8AD70", Offset = "0x4E89370", VA = "0x184E8AD70")]
			internal float PNCCNAEJOIK()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x4E8A720", Offset = "0x4E88D20", VA = "0x184E8A720")]
			internal void IFOPBOHCJEJ(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x4E8A5F0", Offset = "0x4E88BF0", VA = "0x184E8A5F0")]
			internal float AOACIPBKBMC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x4E8AAC0", Offset = "0x4E890C0", VA = "0x184E8AAC0")]
			internal void LECHGFPGJPC(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x10C1ED0", Offset = "0x10C04D0", VA = "0x1810C1ED0", Slot = "104")]
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
		[Cpp2IlInjected.Address(RVA = "0x671D0D0", Offset = "0x671B6D0", VA = "0x18671D0D0")]
		public CAMHBDKBKIA(CHIEBOEDIPK IOIBNPDJCNE, T GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x671C620", Offset = "0x671AC20", VA = "0x18671C620", Slot = "134")]
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
			[Cpp2IlInjected.Address(RVA = "0xD94550", Offset = "0xD92B50", VA = "0x180D94550", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2770980", Offset = "0x276EF80", VA = "0x182770980")]
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
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public BODLLDGDCIJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public HMHGGEOIOHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x2764970", Offset = "0x2762F70", VA = "0x182764970")]
			internal int POFMCLKDAFO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x27648E0", Offset = "0x2762EE0", VA = "0x1827648E0")]
			internal void IGNBPBENOMC(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private static Dictionary<string, FDEEMEDLPLM>? FMFOAKDAFIN;

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x27569E0", Offset = "0x2754FE0", VA = "0x1827569E0")]
		public BODLLDGDCIJ(CHIEBOEDIPK IOIBNPDJCNE, MOCMGCHEMDB GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x2756670", Offset = "0x2754C70", VA = "0x182756670", Slot = "134")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "140")]
			get
			{
				return default(AEKGKKLKPIL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x2755040", Offset = "0x2753640", VA = "0x182755040")]
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
			[Cpp2IlInjected.Address(RVA = "0xBEDFB0", Offset = "0xBEC5B0", VA = "0x180BEDFB0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x2771500", Offset = "0x276FB00", VA = "0x182771500")]
		public PJBKOPNMEEJ(CHIEBOEDIPK IOIBNPDJCNE, NKKHKKCJCOA GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "134")]
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
			[Cpp2IlInjected.Address(RVA = "0xBEDFB0", Offset = "0xBEC5B0", VA = "0x180BEDFB0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x2765660", Offset = "0x2763C60", VA = "0x182765660")]
		public IBPNIFKKEEO(CHIEBOEDIPK IOIBNPDJCNE, OEFOAADPGFK GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "134")]
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
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				public LMDCMMLOOKE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003FB")]
				[Cpp2IlInjected.Address(RVA = "0x2771B70", Offset = "0x2770170", VA = "0x182771B70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003FC")]
				[Cpp2IlInjected.Address(RVA = "0xA40260", Offset = "0xA3E860", VA = "0x180A40260", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public MHGNOKFODIN <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public LMDCMMLOOKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x276DC40", Offset = "0x276C240", VA = "0x18276DC40")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void JGLMENIGIII(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x276E460", Offset = "0x276CA60", VA = "0x18276E460")]
		public MHGNOKFODIN(CHIEBOEDIPK IOIBNPDJCNE, MCPPJFBPFKC HCAMONPFOJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x276E180", Offset = "0x276C780", VA = "0x18276E180", Slot = "140")]
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
			[Cpp2IlInjected.Address(RVA = "0xBC1A20", Offset = "0xBC0020", VA = "0x180BC1A20", Slot = "140")]
			get
			{
				return default(AEKGKKLKPIL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x2756A50", Offset = "0x2755050", VA = "0x182756A50")]
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
			[Cpp2IlInjected.Address(RVA = "0xD7F4E0", Offset = "0xD7DAE0", VA = "0x180D7F4E0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x2765980", Offset = "0x2763F80", VA = "0x182765980")]
		public JBEMECPIGEE(CHIEBOEDIPK IOIBNPDJCNE, DDJNHINCFBJ GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "134")]
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
			[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public sealed override bool PBCBCPMKOGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected sealed override bool GIPCIPECMEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0xA05830", Offset = "0xA03E30", VA = "0x180A05830", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x27558C0", Offset = "0x2753EC0", VA = "0x1827558C0")]
		public AJIEDDIOFHC(CHIEBOEDIPK IOIBNPDJCNE, OPGGOMDJCOL GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x27555B0", Offset = "0x2753BB0", VA = "0x1827555B0", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x2755880", Offset = "0x2753E80", VA = "0x182755880")]
		private int JEDEHALPHDF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x2755550", Offset = "0x2753B50", VA = "0x182755550")]
		private void AIBGNAIBCCL(int PCHMHBNEGIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public class MNLPDEGJAGN : KIAABMIFJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x276CCB0", Offset = "0x276B2B0", VA = "0x18276CCB0")]
		public MNLPDEGJAGN(CHIEBOEDIPK IOIBNPDJCNE, GDCCFCAPGMP GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public sealed class IECJGCKPFAJ : OGBFMPPEGJC<JIJCBELIJOK>
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x27656C0", Offset = "0x2763CC0", VA = "0x1827656C0")]
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
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public OGBFMPPEGJC<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public HFKFJIGEDHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0x4B0B100", Offset = "0x4B09700", VA = "0x184B0B100")]
			internal bool PMOJIBLCDBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x4B0B160", Offset = "0x4B09760", VA = "0x184B0B160")]
			internal void POFMCLKDAFO(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x4B0AF30", Offset = "0x4B09530", VA = "0x184B0AF30")]
			internal bool IGNBPBENOMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x4B0AF90", Offset = "0x4B09590", VA = "0x184B0AF90")]
			internal void NOAGHDJPGKH(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x4B0B050", Offset = "0x4B09650", VA = "0x184B0B050")]
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
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public KPOHEEDLBMM nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public OGBFMPPEGJC<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public NELBFLBLPHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x53D8F10", Offset = "0x53D7510", VA = "0x1853D8F10")]
			internal void JGLMENIGIII(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public override NodeVisualizationKey LCHJEPJMOOO
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0xBE4080", Offset = "0xBE2680", VA = "0x180BE4080", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public override DIBHJHIJCOI EHMCAFAODKF
		{
			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x552C760", Offset = "0x552AD60", VA = "0x18552C760", Slot = "108")]
			get
			{
				return default(DIBHJHIJCOI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x552C5C0", Offset = "0x552ABC0", VA = "0x18552C5C0")]
		protected OGBFMPPEGJC(CHIEBOEDIPK IOIBNPDJCNE, TVariableNode GOJJJBGJPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x552BF00", Offset = "0x552A500", VA = "0x18552BF00", Slot = "101")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x552C080", Offset = "0x552A680", VA = "0x18552C080", Slot = "134")]
		protected override void GKHEOHIHOAF(KIEOOBCGILC PEEMKKKLLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x552BB70", Offset = "0x552A170", VA = "0x18552BB70", Slot = "140")]
		protected virtual void BLDBLIFKMKL(KIEOOBCGILC PEEMKKKLLMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x552C510", Offset = "0x552AB10", VA = "0x18552C510", Slot = "119")]
		public override void KGPJOLOPJJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x273B9D0", Offset = "0x2739FD0", VA = "0x18273B9D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD75B20", Offset = "0xD74120", VA = "0x180D75B20", Slot = "25")]
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
		[Cpp2IlInjected.Address(RVA = "0xE82C40", Offset = "0xE81240", VA = "0x180E82C40", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(EDBALDILLBK<HPDCGGEBOAB>);
		}
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x2757150", Offset = "0x2755750", VA = "0x182757150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	private EDBALDILLBK<LGADIHOLJAO> NGJHFBELAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0xD7FF20", Offset = "0xD7E520", VA = "0x180D7FF20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public override EDBALDILLBK<LOPJDFBDKHF> KKPPEGHFDFH
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2757160", Offset = "0x2755760", VA = "0x182757160", Slot = "21")]
		get
		{
			return default(EDBALDILLBK<LOPJDFBDKHF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x27571B0", Offset = "0x27557B0", VA = "0x1827571B0")]
	private DEJIDOPKGLB(CHIEBOEDIPK IOIBNPDJCNE, GDCCFCAPGMP GOJJJBGJPAM, JHLHFJKDFLC NFDKKPIDAGF, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<HPDCGGEBOAB> NJKENGKIHNB, EDBALDILLBK<LGADIHOLJAO> OANGAIMOJJO, bool OGKGFGNPDEA, string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x2756E00", Offset = "0x2755400", VA = "0x182756E00")]
	public static DEJIDOPKGLB ACADPGMDEBE(CHIEBOEDIPK IOIBNPDJCNE, GDCCFCAPGMP GOJJJBGJPAM, JHLHFJKDFLC MFNAKEDKNJF, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<LGADIHOLJAO> OANGAIMOJJO, EDBALDILLBK<HPDCGGEBOAB> NJKENGKIHNB, bool OGKGFGNPDEA, bool FPPJBNBMHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x2757150", Offset = "0x2755750", VA = "0x182757150")]
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
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private LPEOOOFCFLN? GLAJFLBDENK;

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2770910", Offset = "0x276EF10", VA = "0x182770910")]
		public void INBDHNEFJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x2770870", Offset = "0x276EE70", VA = "0x182770870")]
		public LPEOOOFCFLN BFKBONPCFGN(GBODGILDCPF IFMPKPPFKAO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	protected readonly CHIEBOEDIPK FBKDHJDLAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	protected readonly GDCCFCAPGMP LIGPJFBJHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private OKGOHPNFFIP NNJPJCOIAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private readonly BKECGCMIFAG KAKNJHOJIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private readonly List<FLEABLDLCAL> FDPPJACOEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private readonly List<HGBPDLMFNAA> APLIFPAENHA;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	[HCCKFFEHNEM("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> EFHJGCECLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x275A860", Offset = "0x2758E60", VA = "0x18275A860", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public DisplayKind NCNNLKBOJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0xBF3530", Offset = "0xBF1B30", VA = "0x180BF3530", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x275B8C0", Offset = "0x2759EC0", VA = "0x18275B8C0", Slot = "6")]
		get
		{
			return default(EDBALDILLBK<BIEIIMCKPHN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public IGLPJBODKFE<BIEIIMCKPHN> CHOAMIELENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x275ADE0", Offset = "0x27593E0", VA = "0x18275ADE0", Slot = "7")]
		get
		{
			return default(IGLPJBODKFE<BIEIIMCKPHN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public HJDEFPFJDOJ BJDAICDJFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0xD51490", Offset = "0xD4FA90", VA = "0x180D51490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public DGHBNBOLGPF JAMDOIBHAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x275A520", Offset = "0x2758B20", VA = "0x18275A520", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	protected LPEOOOFCFLN EHCCONJKEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x275A520", Offset = "0x2758B20", VA = "0x18275A520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public PortImage FKJLJMIEBGP
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x275B950", Offset = "0x2759F50", VA = "0x18275B950", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB500", Offset = "0x9E9B00", VA = "0x1809EB500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public IGLPJBODKFE<ALEKBGLLPHJ> AEFADELMNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x275AB50", Offset = "0x2759150", VA = "0x18275AB50", Slot = "9")]
		get
		{
			return default(IGLPJBODKFE<ALEKBGLLPHJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public EDBALDILLBK<MECIAIKJJDL> AHJOKILIEGF
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF70", Offset = "0xD2A570", VA = "0x180D2BF70", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EDBALDILLBK<MECIAIKJJDL>);
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0xE82880", Offset = "0xE80E80", VA = "0x180E82880")]
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
	[Cpp2IlInjected.Address(RVA = "0x275BA80", Offset = "0x275A080", VA = "0x18275BA80")]
	protected GBODGILDCPF(CHIEBOEDIPK IOIBNPDJCNE, GDCCFCAPGMP GOJJJBGJPAM, BKECGCMIFAG JHMPKACOBFK, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, bool OGKGFGNPDEA, string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x275A770", Offset = "0x2758D70", VA = "0x18275A770", Slot = "22")]
	protected virtual void ANJKPBDKBKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x275AA00", Offset = "0x2759000", VA = "0x18275AA00", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x275AD20", Offset = "0x2759320", VA = "0x18275AD20", Slot = "14")]
	public void HHHMMIJELMF(FLEABLDLCAL LPLPDJPCKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x275A9A0", Offset = "0x2758FA0", VA = "0x18275A9A0", Slot = "15")]
	public void CDEDEGPGBFD(HGBPDLMFNAA LPLPDJPCKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x275AFC0", Offset = "0x27595C0", VA = "0x18275AFC0", Slot = "16")]
	public void IJJLOIMJLIL(JFPHGDGHBDF NNDPLIOKOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x275AD80", Offset = "0x2759380", VA = "0x18275AD80", Slot = "24")]
	protected virtual void HHNKFBFEPJF(JFPHGDGHBDF NNDPLIOKOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x275AB70", Offset = "0x2759170", VA = "0x18275AB70", Slot = "19")]
	private void FPHKMPIMFIH(bool COFBNOFIHKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x275A5C0", Offset = "0x2758BC0", VA = "0x18275A5C0")]
	private void AJKAMEFBFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x275AE10", Offset = "0x2759410", VA = "0x18275AE10")]
	private void IHHKOMKMPMN([In] FPIKEBBELDH IOFINHALECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x275AAF0", Offset = "0x27590F0", VA = "0x18275AAF0", Slot = "17")]
	public void FDEGCFJIFEN(FLEABLDLCAL LPLPDJPCKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x275B8F0", Offset = "0x2759EF0", VA = "0x18275B8F0", Slot = "18")]
	public void MDAMCDBLJIA(HGBPDLMFNAA LPLPDJPCKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x9EB500", Offset = "0x9E9B00", VA = "0x1809EB500")]
	internal void LJPELIJAKLM(string NFHOBPDKIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x275AD00", Offset = "0x2759300", VA = "0x18275AD00")]
	internal void GEPFJJJPGCM(DMBFCNGEBJL MMCKJCAOGBM, HJDEFPFJDOJ MLCOGCMJLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xE82880", Offset = "0xE80E80", VA = "0x180E82880")]
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
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public CHIEBOEDIPK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public GDCCFCAPGMP node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public EDBALDILLBK<MECIAIKJJDL> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public CLFBOHAJLBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x2756D70", Offset = "0x2755370", VA = "0x182756D70")]
		internal KCILGDEGCLG OAMONKHEICB((int PortDescIndex, int PortIndex, JMMEMLBFONE InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x2756CE0", Offset = "0x27552E0", VA = "0x182756CE0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x2758120", Offset = "0x2756720", VA = "0x182758120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x2758590", Offset = "0x2756B90", VA = "0x182758590", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public EDBALDILLBK<KCPNHNINCKC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x27598D0", Offset = "0x2757ED0", VA = "0x1827598D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x2759C20", Offset = "0x2758220", VA = "0x182759C20", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public EDBALDILLBK<LGADIHOLJAO> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x27717B0", Offset = "0x276FDB0", VA = "0x1827717B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x2771B00", Offset = "0x2770100", VA = "0x182771B00", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public EDBALDILLBK<KCPNHNINCKC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public EDBALDILLBK<KCPNHNINCKC> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2764DA0", Offset = "0x27633A0", VA = "0x182764DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x2765100", Offset = "0x2763700", VA = "0x182765100", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public EDBALDILLBK<LGADIHOLJAO> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public EDBALDILLBK<LGADIHOLJAO> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x2759D00", Offset = "0x2758300", VA = "0x182759D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x275A060", Offset = "0x2758660", VA = "0x18275A060", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x2765170", Offset = "0x2763770", VA = "0x182765170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x27655F0", Offset = "0x2763BF0", VA = "0x1827655F0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x2770D30", Offset = "0x276F330", VA = "0x182770D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x2771080", Offset = "0x276F680", VA = "0x182771080", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public EDBALDILLBK<KCPNHNINCKC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x27649C0", Offset = "0x2762FC0", VA = "0x1827649C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x2764D30", Offset = "0x2763330", VA = "0x182764D30", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public EDBALDILLBK<LGADIHOLJAO> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x27559A0", Offset = "0x2753FA0", VA = "0x1827559A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x2755D10", Offset = "0x2754310", VA = "0x182755D10", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public ACLPKCGEGFP type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public EDBALDILLBK<KCPNHNINCKC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x27710F0", Offset = "0x276F6F0", VA = "0x1827710F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x2771490", Offset = "0x276FA90", VA = "0x182771490", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public KAMDBIDHFJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public ACLPKCGEGFP type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public EDBALDILLBK<LGADIHOLJAO> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private BODMOEILABD <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x2757A10", Offset = "0x2756010", VA = "0x182757A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x2757DB0", Offset = "0x27563B0", VA = "0x182757DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	private readonly bool JHFHMFEHBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private readonly CHIEBOEDIPK FBKDHJDLAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly bool FJPMKKBPPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private KOLDGJODODL<IFOKEFFHPOH, KCILGDEGCLG> AHCKBOGNOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private KOLDGJODODL<IFOKEFFHPOH, IKPGAMHHELO> MCFFELOHKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	private readonly GDCCFCAPGMP LIGPJFBJHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	private KOLDGJODODL<HPDCGGEBOAB, DEJIDOPKGLB> LNBMHCCFNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private KOLDGJODODL<HPDCGGEBOAB, EDLMBADJAJJ> AAKFEKLPJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	private string? PLENDDGMCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	private readonly BAANAFJPLNG FCHEPCKGOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	private EDBALDILLBK<MECIAIKJJDL> IAOJEHGACFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private readonly bool IKAHDLKDAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	[CompilerGenerated]
	private Action? FBMOCAGKFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	[CompilerGenerated]
	private Action? LDIJKNODCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	[CompilerGenerated]
	private Action<EDBALDILLBK<IFOKEFFHPOH>>? GNLHIJGPJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	[CompilerGenerated]
	private Action<EDBALDILLBK<HPDCGGEBOAB>>? AAINNNPCNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	[CompilerGenerated]
	private LCBAJMHOMEH.FBNGGFHLHAG? HGIJOAOCBDJ;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool GAFIKDAACLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x2769990", Offset = "0x2767F90", VA = "0x182769990", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool JCNANJNIMDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x276A8E0", Offset = "0x2768EE0", VA = "0x18276A8E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool HLDDONALKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x2768BF0", Offset = "0x27671F0", VA = "0x182768BF0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public IGLPJBODKFE<BIEIIMCKPHN> CHOAMIELENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x2769F30", Offset = "0x2768530", VA = "0x182769F30", Slot = "7")]
		get
		{
			return default(IGLPJBODKFE<BIEIIMCKPHN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool AAOBHKGOKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x276ADC0", Offset = "0x27693C0", VA = "0x18276ADC0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public KOLDGJODODL<IFOKEFFHPOH, IKPGAMHHELO> BIIPMGOKIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510", Slot = "9")]
		get
		{
			return default(KOLDGJODODL<IFOKEFFHPOH, IKPGAMHHELO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string IJKBIMCGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x276A920", Offset = "0x2768F20", VA = "0x18276A920", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public IGLPJBODKFE<ALEKBGLLPHJ> AEFADELMNOF
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x27690B0", Offset = "0x27676B0", VA = "0x1827690B0", Slot = "11")]
		get
		{
			return default(IGLPJBODKFE<ALEKBGLLPHJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public KOLDGJODODL<HPDCGGEBOAB, EDLMBADJAJJ> ANMPBMMDOLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0", Slot = "12")]
		get
		{
			return default(KOLDGJODODL<HPDCGGEBOAB, EDLMBADJAJJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public EDBALDILLBK<MECIAIKJJDL> AHJOKILIEGF
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xBD3490", Offset = "0xBD1A90", VA = "0x180BD3490", Slot = "13")]
		get
		{
			return default(EDBALDILLBK<MECIAIKJJDL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? IOIONBNIFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x27685D0", Offset = "0x2766BD0", VA = "0x1827685D0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x276A780", Offset = "0x2768D80", VA = "0x18276A780", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action? NPOOIDJGJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x27698E0", Offset = "0x2767EE0", VA = "0x1827698E0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x2769680", Offset = "0x2767C80", VA = "0x182769680", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<EDBALDILLBK<IFOKEFFHPOH?>, EDBALDILLBK<IFOKEFFHPOH?>>? HCFLOKGBEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x27672D0", Offset = "0x27658D0", VA = "0x1827672D0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x2767AA0", Offset = "0x27660A0", VA = "0x182767AA0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<EDBALDILLBK<IFOKEFFHPOH?>, EDBALDILLBK<IFOKEFFHPOH?>>? LFPFLAOGMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x276AC40", Offset = "0x2769240", VA = "0x18276AC40", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x2769730", Offset = "0x2767D30", VA = "0x182769730", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<EDBALDILLBK<HPDCGGEBOAB?>, EDBALDILLBK<HPDCGGEBOAB?>>? DNDGIAONEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x276B290", Offset = "0x2769890", VA = "0x18276B290", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x276AB80", Offset = "0x2769180", VA = "0x18276AB80", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<EDBALDILLBK<HPDCGGEBOAB?>, EDBALDILLBK<HPDCGGEBOAB?>>? GEAODGODHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x2767890", Offset = "0x2765E90", VA = "0x182767890", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x276BBF0", Offset = "0x276A1F0", VA = "0x18276BBF0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<EDBALDILLBK<IFOKEFFHPOH?>, IKPGAMHHELO?>? EDLJFJDLIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x2768100", Offset = "0x2766700", VA = "0x182768100", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x2768670", Offset = "0x2766C70", VA = "0x182768670", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<EDBALDILLBK<IFOKEFFHPOH?>>? AINAHIEIDOH
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x2768510", Offset = "0x2766B10", VA = "0x182768510", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x2768450", Offset = "0x2766A50", VA = "0x182768450", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<EDBALDILLBK<IFOKEFFHPOH?>, IKPGAMHHELO?>? IMHGMCJIBAB
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x276AD00", Offset = "0x2769300", VA = "0x18276AD00", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x27682A0", Offset = "0x27668A0", VA = "0x1827682A0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<EDBALDILLBK<HPDCGGEBOAB?>, EDLMBADJAJJ?>? IHMIFGDMOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x276B5A0", Offset = "0x2769BA0", VA = "0x18276B5A0", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x276B480", Offset = "0x2769A80", VA = "0x18276B480", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<EDBALDILLBK<HPDCGGEBOAB?>>? IOIDMIKLCLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x27681E0", Offset = "0x27667E0", VA = "0x1827681E0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x27675A0", Offset = "0x2765BA0", VA = "0x1827675A0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<EDBALDILLBK<HPDCGGEBOAB?>, EDLMBADJAJJ?>? ADJBKOJFMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x27673B0", Offset = "0x27659B0", VA = "0x1827673B0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x276A820", Offset = "0x2768E20", VA = "0x18276A820", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x276BDC0", Offset = "0x276A3C0", VA = "0x18276BDC0")]
	private KAMDBIDHFJB(bool OGKGFGNPDEA, CHIEBOEDIPK IOIBNPDJCNE, bool MNNNDHNMHMF, KOLDGJODODL<IFOKEFFHPOH, KCILGDEGCLG> ODHLNAONGFG, KOLDGJODODL<IFOKEFFHPOH, IKPGAMHHELO> DDMEGPPILMJ, GDCCFCAPGMP GOJJJBGJPAM, KOLDGJODODL<HPDCGGEBOAB, DEJIDOPKGLB> JAPHJOLMCAH, KOLDGJODODL<HPDCGGEBOAB, EDLMBADJAJJ> LPPNIHGOOOE, string? GIIEOLIDNOL, BAANAFJPLNG GBMJPODLMIF, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, bool FPPJBNBMHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x2766D60", Offset = "0x2765360", VA = "0x182766D60")]
	public static KAMDBIDHFJB ACADPGMDEBE(bool OGKGFGNPDEA, CHIEBOEDIPK IOIBNPDJCNE, bool MNNNDHNMHMF, GDCCFCAPGMP GOJJJBGJPAM, BAANAFJPLNG GBMJPODLMIF, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, bool FPPJBNBMHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x2768730", Offset = "0x2766D30", VA = "0x182768730", Slot = "69")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x276A690", Offset = "0x2768C90", VA = "0x18276A690", Slot = "38")]
	[AsyncStateMachine(typeof(EHBDHFDCCKG))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC?>>? IPCEHKOKDJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2767660", Offset = "0x2765C60", VA = "0x182767660")]
	private (FMGKOMKDAHH?, int)? BBGEKEOFDGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x2768360", Offset = "0x2766960", VA = "0x182768360", Slot = "58")]
	private void CPLAOMOJBCJ(int OGANHCODKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x1F6BCC0", Offset = "0x1F6A2C0", VA = "0x181F6BCC0", Slot = "57")]
	private void OPOPDDAJJPN(int OGANHCODKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x2768D10", Offset = "0x2767310", VA = "0x182768D10", Slot = "61")]
	private void FCKJCAFLHCG(int NICFJMKACMO, int OOCILDAPIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x276B540", Offset = "0x2769B40", VA = "0x18276B540", Slot = "63")]
	private void ODFMAOJGJMG(int NICFJMKACMO, int OOCILDAPIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x276B660", Offset = "0x2769C60", VA = "0x18276B660", Slot = "50")]
	private void OJGBALJBGAA(int OGANHCODKFO, EDBALDILLBK<IFOKEFFHPOH> NLCFBAENGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x276A430", Offset = "0x2768A30", VA = "0x18276A430", Slot = "54")]
	private void IMJBGKPBNFL(int COFBNOFIHKI, EDBALDILLBK<IFOKEFFHPOH> NLCFBAENGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x27681C0", Offset = "0x27667C0", VA = "0x1827681C0", Slot = "49")]
	private void CGKOCPKDEKN(int COFBNOFIHKI, EDBALDILLBK<IFOKEFFHPOH> NLCFBAENGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x276AE40", Offset = "0x2769440", VA = "0x18276AE40", Slot = "53")]
	private void MPPCEJDLNBD(int OGANHCODKFO, EDBALDILLBK<IFOKEFFHPOH> NLCFBAENGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x276A450", Offset = "0x2768A50", VA = "0x18276A450", Slot = "66")]
	private void INDEIILHBMD(int OGANHCODKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x131BEE0", Offset = "0x131A4E0", VA = "0x18131BEE0", Slot = "65")]
	private void KEPLOGBOAEM(int OGANHCODKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x27697F0", Offset = "0x2767DF0", VA = "0x1827697F0", Slot = "60")]
	private void GOPLLEKKKMA(int OGANHCODKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x1F6BCC0", Offset = "0x1F6A2C0", VA = "0x181F6BCC0", Slot = "59")]
	private void IJPGAELGPOH(int OGANHCODKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x2769F60", Offset = "0x2768560", VA = "0x182769F60", Slot = "62")]
	private void IIBCGOAKLDB(int NICFJMKACMO, int OOCILDAPIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x2768CB0", Offset = "0x27672B0", VA = "0x182768CB0", Slot = "64")]
	private void ELIKLJDGINI(int NICFJMKACMO, int OOCILDAPIGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x27690F0", Offset = "0x27676F0", VA = "0x1827690F0", Slot = "52")]
	private void GMEKKOOMCOI(int OGANHCODKFO, EDBALDILLBK<HPDCGGEBOAB> NLCFBAENGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x2767390", Offset = "0x2765990", VA = "0x182767390", Slot = "56")]
	private void AGDGCOLILMD(int COFBNOFIHKI, EDBALDILLBK<HPDCGGEBOAB> NLCFBAENGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x27690D0", Offset = "0x27676D0", VA = "0x1827690D0", Slot = "51")]
	private void GEKDCDHKDGO(int COFBNOFIHKI, EDBALDILLBK<HPDCGGEBOAB> NLCFBAENGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x2767B60", Offset = "0x2766160", VA = "0x182767B60", Slot = "55")]
	private void CCBNCBCDNLM(int OGANHCODKFO, EDBALDILLBK<HPDCGGEBOAB> NLCFBAENGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x2767950", Offset = "0x2765F50", VA = "0x182767950", Slot = "68")]
	private void BIPIGCKLCJO(int OGANHCODKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x131BEE0", Offset = "0x131A4E0", VA = "0x18131BEE0", Slot = "67")]
	private void IBGONDCLHCD(int OGANHCODKFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x276A950", Offset = "0x2768F50", VA = "0x18276A950", Slot = "39")]
	[AsyncStateMachine(typeof(FCNBBEHMKAF))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC?>>? LNCLCOGMHNG(EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x276BCB0", Offset = "0x276A2B0", VA = "0x18276BCB0", Slot = "40")]
	[AsyncStateMachine(typeof(PPIDFBKDIKG))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC?>>? OPDJGCMMNOK(EDBALDILLBK<LGADIHOLJAO> OANGAIMOJJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x276AA60", Offset = "0x2769060", VA = "0x18276AA60", Slot = "41")]
	[AsyncStateMachine(typeof(HMMANLPCEIJ))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC?>>? MAOJMAONNGG(EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK, EDBALDILLBK<KCPNHNINCKC> JOKKHPPEGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x2768AD0", Offset = "0x27670D0", VA = "0x182768AD0", Slot = "42")]
	[AsyncStateMachine(typeof(FHCHMHGPEGK))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC?>>? EBJOJKCPGFI(EDBALDILLBK<LGADIHOLJAO> OANGAIMOJJO, EDBALDILLBK<LGADIHOLJAO> JOKKHPPEGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x276A5A0", Offset = "0x2768BA0", VA = "0x18276A5A0", Slot = "43")]
	[AsyncStateMachine(typeof(HMNLMGJCENA))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC?>>? INKDMMLEANF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2769A50", Offset = "0x2768050", VA = "0x182769A50", Slot = "44")]
	[AsyncStateMachine(typeof(PEIOOJMNLJH))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> HFNHJCIMPJG(string NKGPMKCBABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x276A300", Offset = "0x2768900", VA = "0x18276A300", Slot = "45")]
	[AsyncStateMachine(typeof(HMLCKCLGEIF))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> IKPCCLHFKND(EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK, string NFHOBPDKIPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x276B350", Offset = "0x2769950", VA = "0x18276B350", Slot = "46")]
	[AsyncStateMachine(typeof(BKIBFKKHFLG))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> NBMAIBJMBAH(EDBALDILLBK<LGADIHOLJAO> OANGAIMOJJO, string NFHOBPDKIPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x2767470", Offset = "0x2765A70", VA = "0x182767470", Slot = "47")]
	[AsyncStateMachine(typeof(PEKLGKMIMLJ))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> AMLHOHAHALH(EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK, ACLPKCGEGFP MLCOGCMJLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x2767FD0", Offset = "0x27665D0", VA = "0x182767FD0", Slot = "48")]
	[AsyncStateMachine(typeof(DLLDIJMMBGO))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> CCEDCDMOADN(EDBALDILLBK<LGADIHOLJAO> OANGAIMOJJO, ACLPKCGEGFP MLCOGCMJLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x2769B70", Offset = "0x2768170", VA = "0x182769B70")]
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
			[Cpp2IlInjected.Token(Token = "0x400026C")]
			public readonly IReadOnlyDictionary<IGLPJBODKFE<BIEIIMCKPHN>, Guid>? JIJJDJPODNM;

			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0xD2EEF0", Offset = "0xD2D4F0", VA = "0x180D2EEF0")]
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
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public AsyncTaskMethodBuilder<GEGFDAOJMBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public CHIEBOEDIPK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public DAPEGEJBKHJ roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public HNAGJAILJOF superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private FAGIEJAHGME <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private DAPEGEJBKHJ <downloadedRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private DAPEGEJBKHJ <actualRoomData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private BBFLKNGKMEG <actualStaticConfig>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private HNAGJAILJOF <finalSuperRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private CAJCOBBEPJC <roomAssetData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private COGPNGPCNGP <playerSaveData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private TaskAwaiter<DAPEGEJBKHJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private DAPEGEJBKHJ <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<BBFLKNGKMEG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private TaskAwaiter<HNAGJAILJOF> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private TaskAwaiter<CAJCOBBEPJC> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private TaskAwaiter<COGPNGPCNGP> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private TaskAwaiter<FAGIEJAHGME.EAOPGAFDPLL> <>u__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private TaskAwaiter<KPBELAPACCB> <>u__7;

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x27659F0", Offset = "0x2763FF0", VA = "0x1827659F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x2766AA0", Offset = "0x27650A0", VA = "0x182766AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private readonly KPBELAPACCB PNLHEJFLLMK;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public KPBELAPACCB FDFMMKMOCDC
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	private GEGFDAOJMBC(KPBELAPACCB IJHPLNHDKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x27642E0", Offset = "0x27628E0", VA = "0x1827642E0")]
	[AsyncStateMachine(typeof(JLKJBPDLBBG))]
	public static Task<GEGFDAOJMBC> HADJEECNMFP(CHIEBOEDIPK IOIBNPDJCNE, DAPEGEJBKHJ? MKIDPONBDDE, HNAGJAILJOF? OFMJDNINMGK, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x27642C0", Offset = "0x27628C0", VA = "0x1827642C0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public EHIAIIKPCDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public AFPLFKDKJPC action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x2757E20", Offset = "0x2756420", VA = "0x182757E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x27580B0", Offset = "0x27566B0", VA = "0x1827580B0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<bool, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public AMICEDMCMOM rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public DAPEGEJBKHJ circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public HNAGJAILJOF superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public EHIAIIKPCDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private AFPLFKDKJPC[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x275A0D0", Offset = "0x27586D0", VA = "0x18275A0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x275A4B0", Offset = "0x2758AB0", VA = "0x18275A4B0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public EHIAIIKPCDI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private TaskAwaiter<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x276FC30", Offset = "0x276E230", VA = "0x18276FC30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x276FE70", Offset = "0x276E470", VA = "0x18276FE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private readonly HNNMKAAPCJH CMAAEEHAJID;

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0xD2EEF0", Offset = "0xD2D4F0", VA = "0x180D2EEF0")]
	public EHIAIIKPCDI(HNNMKAAPCJH HIEGHANFGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x27586F0", Offset = "0x2756CF0", VA = "0x1827586F0")]
	[AsyncStateMachine(typeof(EGIPMLFPLLA))]
	private Task<HHHCCNLMPJL<object, DLKBDBKHJCC>> NGOFJAKHGMH(AFPLFKDKJPC BDCLNIJAFBF, bool CKEAKKIBMKM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x2758820", Offset = "0x2756E20", VA = "0x182758820")]
	[AsyncStateMachine(typeof(FJKCHFEPMBH))]
	public Task<HHHCCNLMPJL<bool, DLKBDBKHJCC?>>? NMJAGKADGHO(int BIMKIFBAABH, AMICEDMCMOM? GPHGBEGKLDA, DAPEGEJBKHJ? DHMHCCKDFEA, HNAGJAILJOF? OFMJDNINMGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x2758600", Offset = "0x2756C00", VA = "0x182758600")]
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
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private readonly JDNKJBFHNDM PLNEBCGHIDC;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public JDNKJBFHNDM PEGOAFKAAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	private DIEHMIIHIII(JDNKJBFHNDM HBEOFGDIPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x2757800", Offset = "0x2755E00", VA = "0x182757800")]
	public static DIEHMIIHIII AKDPGDCBDMI(CHIEBOEDIPK IOIBNPDJCNE, AMICEDMCMOM JAPOHPBPBCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x27579F0", Offset = "0x2755FF0", VA = "0x1827579F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x27550A0", Offset = "0x27536A0", VA = "0x1827550A0")]
	public static APNBNOIOAEH<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK, KIAIHFFPMKB.IIGBIEGDLEB<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK>> JPBBFEKBAGM([In] this APNBNOIOAEH<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK, KIAIHFFPMKB.IIGBIEGDLEB<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK>> IACBPLHEIBI)
	{
		return default(APNBNOIOAEH<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK, KIAIHFFPMKB.IIGBIEGDLEB<LDKABCCJKHO, AFPLFKDKJPC, CHIEBOEDIPK>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class KHOBHPDGOKL : KMOLNCDGBHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private readonly CHIEBOEDIPK FBKDHJDLAOI;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool JBCLPPAPFNP
	{
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x276CC90", Offset = "0x276B290", VA = "0x18276CC90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	internal KHOBHPDGOKL(CHIEBOEDIPK IOIBNPDJCNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
internal sealed class GIDNBCJFJCB : JMMHNPNPOEP
{
	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x2764760", Offset = "0x2762D60", VA = "0x182764760", Slot = "4")]
	public CKLHIANFCLG? DOBAEEFKNNE(string? PCMGNKOHCMI, string? KIHDBJCIMCF, string? LAPPFPKMCDH, FLBHDNOAEMF.MEOEOLPDHHE.JKBOCGPNCOP ELPDPLLJPIE, bool NAHAJHEIPMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder<BOIDOHDBGAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public KMNAAACLCJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter<CMLPMCGBMAK?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E1")]
		[Cpp2IlInjected.Address(RVA = "0x2764450", Offset = "0x2762A50", VA = "0x182764450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E2")]
		[Cpp2IlInjected.Address(RVA = "0x27646F0", Offset = "0x2762CF0", VA = "0x1827646F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private readonly CHIEBOEDIPK FBKDHJDLAOI;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public BOIDOHDBGAH? MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x276CD80", Offset = "0x276B380", VA = "0x18276CD80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public GDHPHGOEDFD? MJDFGFDAHKD
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x276D7E0", Offset = "0x276BDE0", VA = "0x18276D7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool OCCKMDALHIK
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x276CE00", Offset = "0x276B400", VA = "0x18276CE00", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool OEPHFDNLEOC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x276D780", Offset = "0x276BD80", VA = "0x18276D780", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x276D860", Offset = "0x276BE60", VA = "0x18276D860")]
	internal KMNAAACLCJB(CHIEBOEDIPK IOIBNPDJCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x276CE60", Offset = "0x276B460", VA = "0x18276CE60", Slot = "7")]
	[AsyncStateMachine(typeof(GFOEKHJHEBD))]
	public Task<BOIDOHDBGAH> IOJJGNINCJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x276D410", Offset = "0x276BA10", VA = "0x18276D410", Slot = "9")]
	public IReadOnlyDictionary<IGLPJBODKFE<BIEIIMCKPHN>, Guid> NLDDCODGGDL(IEnumerable<DJNGLNAIHJJ> EEBCGAFDBAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x276D290", Offset = "0x276B890", VA = "0x18276D290", Slot = "10")]
	public LIBBGGNKLIG MCECJOOBHMI(IEnumerable<DJNGLNAIHJJ> EEBCGAFDBAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x276CF50", Offset = "0x276B550", VA = "0x18276CF50")]
	public HHHCCNLMPJL<OIBHFMBJDCN, HIKDGBNCNDJ> JKCEFEKHIAL([In] OIBHFMBJDCN NLDKPBHAAJP)
	{
		return default(HHHCCNLMPJL<OIBHFMBJDCN, HIKDGBNCNDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x276D0F0", Offset = "0x276B6F0", VA = "0x18276D0F0", Slot = "8")]
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
			[Cpp2IlInjected.Token(Token = "0x40002AA")]
			public KPBELAPACCB state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			public CJNHJIPJPDB spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public IDOGFNOIENM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0x2779E90", Offset = "0x2778490", VA = "0x182779E90")]
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
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
			public FEPBGHKIIDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0x27795B0", Offset = "0x2777BB0", VA = "0x1827795B0")]
			internal void ENBBJGFHPAF(PMLOKGMHNIB n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x27750D0", Offset = "0x27736D0", VA = "0x1827750D0")]
		public static HHHCCNLMPJL<BOIDOHDBGAH.JKDMCLDJJOG, IADJFILHMLF> GDMALPFODEM(GDHPHGOEDFD OCACDKEJIIB, [In] BOIDOHDBGAH.HGCACJNGEEN ODJGLJIHJOP)
		{
			return default(HHHCCNLMPJL<BOIDOHDBGAH.JKDMCLDJJOG, IADJFILHMLF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x2775610", Offset = "0x2773C10", VA = "0x182775610")]
		internal static HHHCCNLMPJL<(BJLNHBIBFME, GMILLKLCECE), IADJFILHMLF> KHLFKMOBHJK(GDHPHGOEDFD OCACDKEJIIB, GMILLKLCECE FPHADMNMECP, bool CNPMPIOPELL, [In] IGLPJBODKFE<BIEIIMCKPHN> PODKNGHCBKE, [In] int? FPOMHPLJKLF, [In] FGKPLMFNBOC? PJENHCHPGKB, [In] FGKPLMFNBOC? FAMIAPEPJGF)
		{
			return default(HHHCCNLMPJL<(BJLNHBIBFME, GMILLKLCECE), IADJFILHMLF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x2774B60", Offset = "0x2773160", VA = "0x182774B60")]
		private static void EGIJLMGPECP(bool CNPMPIOPELL, DJNGLNAIHJJ BJPIFCHFNAA, BJLNHBIBFME BFGNODCMDFE, [In] IGLPJBODKFE<BIEIIMCKPHN> PODKNGHCBKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x2774760", Offset = "0x2772D60", VA = "0x182774760")]
		public static void AJCBEIADCHC(NDHLGJGDGLN MEHCLCCOAPG, [In] BOIDOHDBGAH.CHLJEEKDAII CJGMIGKBNOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x2774FE0", Offset = "0x27735E0", VA = "0x182774FE0")]
		[CompilerGenerated]
		internal static bool GCICDBDKMEG(KPBELAPACCB AOLFLFMEHMK, CJNHJIPJPDB KBGAODCBAAM, PMLOKGMHNIB DCOBAJMKGFO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x2776480", Offset = "0x2774A80", VA = "0x182776480")]
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
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public EDBALDILLBK<BIEIIMCKPHN> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public EDBALDILLBK<ALEKBGLLPHJ> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public HOCBFPONHJI offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public bool deleteBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x277B0A0", Offset = "0x27796A0", VA = "0x18277B0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x277B2F0", Offset = "0x27798F0", VA = "0x18277B2F0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public EDBALDILLBK<BIEIIMCKPHN> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public IGLPJBODKFE<ALEKBGLLPHJ> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public List<EDBALDILLBK<ALEKBGLLPHJ>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public HOCBFPONHJI localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public GKMDHBAFLMJ localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public HOCBFPONHJI offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x2779B60", Offset = "0x2778160", VA = "0x182779B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x2779E20", Offset = "0x2778420", VA = "0x182779E20", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public EDBALDILLBK<BIEIIMCKPHN> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public IGLPJBODKFE<ALEKBGLLPHJ> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public List<EDBALDILLBK<ALEKBGLLPHJ>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x277A730", Offset = "0x2778D30", VA = "0x18277A730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x277A970", Offset = "0x2778F70", VA = "0x18277A970", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public EDBALDILLBK<BIEIIMCKPHN> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public IGLPJBODKFE<ALEKBGLLPHJ> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public List<EDBALDILLBK<ALEKBGLLPHJ>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x2778370", Offset = "0x2776970", VA = "0x182778370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x27785B0", Offset = "0x2776BB0", VA = "0x1827785B0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public IGLPJBODKFE<BIEIIMCKPHN> legacyGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public IGLPJBODKFE<ALEKBGLLPHJ> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public IReadOnlyList<IGLPJBODKFE<ALEKBGLLPHJ>> nodeLegacyIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public IReadOnlyDictionary<BONKIFIDLBA, (EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<IFOKEFFHPOH>)> inputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public IReadOnlyDictionary<PIPFDBHCILD, (EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<HPDCGGEBOAB>)> outputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x2778620", Offset = "0x2776C20", VA = "0x182778620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x2778BD0", Offset = "0x27771D0", VA = "0x182778BD0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public EDBALDILLBK<MBCPFFKFBDC> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public EDBALDILLBK<AIHJLHNMKCJ> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x2776E40", Offset = "0x2775440", VA = "0x182776E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x2777490", Offset = "0x2775A90", VA = "0x182777490", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<EDBALDILLBK<ALEKBGLLPHJ>, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public EDBALDILLBK<APOJALOJJAE> nodeDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public HOCBFPONHJI localSpacePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public GKMDHBAFLMJ localSpaceRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private KPBELAPACCB <state>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private TaskAwaiter<HHHCCNLMPJL<Guid, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x2777760", Offset = "0x2775D60", VA = "0x182777760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x2777BE0", Offset = "0x27761E0", VA = "0x182777BE0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public EDBALDILLBK<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private TaskAwaiter<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x277CD10", Offset = "0x277B310", VA = "0x18277CD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x277CFB0", Offset = "0x277B5B0", VA = "0x18277CFB0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public IGLPJBODKFE<ALEKBGLLPHJ> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public IGLPJBODKFE<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public EDBALDILLBK<MECIAIKJJDL> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public EDBALDILLBK<IFOKEFFHPOH> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x277ACF0", Offset = "0x27792F0", VA = "0x18277ACF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x277B030", Offset = "0x2779630", VA = "0x18277B030", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public IGLPJBODKFE<ALEKBGLLPHJ> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public IGLPJBODKFE<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public EDBALDILLBK<MECIAIKJJDL> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public EDBALDILLBK<HPDCGGEBOAB> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x2777C50", Offset = "0x2776250", VA = "0x182777C50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x2777F90", Offset = "0x2776590", VA = "0x182777F90", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public EDBALDILLBK<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x2779FE0", Offset = "0x27785E0", VA = "0x182779FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x277A2D0", Offset = "0x27788D0", VA = "0x18277A2D0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<IEnumerable<IGLPJBODKFE<ALEKBGLLPHJ>>, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public IGLPJBODKFE<BIEIIMCKPHN> intoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public IEnumerable<DJNGLNAIHJJ> persistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public GMILLKLCECE templateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private TaskAwaiter<HHHCCNLMPJL<IEnumerable<GDCCFCAPGMP>, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000574")]
		[Cpp2IlInjected.Address(RVA = "0x2773DF0", Offset = "0x27723F0", VA = "0x182773DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000575")]
		[Cpp2IlInjected.Address(RVA = "0x2774470", Offset = "0x2772A70", VA = "0x182774470", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public EDBALDILLBK<BIEIIMCKPHN> sourceGraphId;

		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public AFAKPBOIAKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x27744E0", Offset = "0x2772AE0", VA = "0x1827744E0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x277DA70", Offset = "0x277C070", VA = "0x18277DA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x277DC90", Offset = "0x277C290", VA = "0x18277DC90", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public EDBALDILLBK<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x277D610", Offset = "0x277BC10", VA = "0x18277D610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x277D8B0", Offset = "0x277BEB0", VA = "0x18277D8B0", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public EDBALDILLBK<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public EDBALDILLBK<MECIAIKJJDL> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public EDBALDILLBK<KCPNHNINCKC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x27791D0", Offset = "0x27777D0", VA = "0x1827791D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x2779540", Offset = "0x2777B40", VA = "0x182779540", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public EDBALDILLBK<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public EDBALDILLBK<MECIAIKJJDL> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public EDBALDILLBK<KCPNHNINCKC> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x277D020", Offset = "0x277B620", VA = "0x18277D020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x277D490", Offset = "0x277BA90", VA = "0x18277D490", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public EDBALDILLBK<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x2778060", Offset = "0x2776660", VA = "0x182778060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x2778300", Offset = "0x2776900", VA = "0x182778300", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public GDHPHGOEDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public EDBALDILLBK<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public EDBALDILLBK<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public HOCBFPONHJI localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public GKMDHBAFLMJ localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private TaskAwaiter<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x277DD00", Offset = "0x277C300", VA = "0x18277DD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x277E050", Offset = "0x277C650", VA = "0x18277E050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private readonly CHIEBOEDIPK FBKDHJDLAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private readonly MGIDPOIGHNH IHDCNDNFOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private readonly GAKOAGFLBAB CANFDJPCDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	private readonly OMPJEELBIEL INBDDKMBHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private readonly KMNAAACLCJB OPANIFPHBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	private Dictionary<IGLPJBODKFE<ALEKBGLLPHJ>, CBDBLPHCHLP> LOJIEBKCALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	[CompilerGenerated]
	private Action<IGLPJBODKFE<ALEKBGLLPHJ>>? GHBBKKJBBCP;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public IGLPJBODKFE<BIEIIMCKPHN> FLIIBLGEOLB
	{
		[Cpp2IlInjected.Token(Token = "0x60004E3")]
		[Cpp2IlInjected.Address(RVA = "0x275F000", Offset = "0x275D600", VA = "0x18275F000", Slot = "4")]
		get
		{
			return default(IGLPJBODKFE<BIEIIMCKPHN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public OMPJEELBIEL EADIBKJPHLP
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x273AB10", Offset = "0x2739110", VA = "0x18273AB10", Slot = "5")]
		get
		{
			return default(OMPJEELBIEL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x2763DA0", Offset = "0x27623A0", VA = "0x182763DA0")]
	public GDHPHGOEDFD(CHIEBOEDIPK IOIBNPDJCNE, MGIDPOIGHNH FKPENEKJEBL, GAKOAGFLBAB FGCGPJAFJOJ, KMNAAACLCJB HCGLPHPPLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x2760300", Offset = "0x275E900", VA = "0x182760300", Slot = "83")]
	public EDBALDILLBK<FNLFDFELNJP> JIEIJKABFPJ(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP)
	{
		return default(EDBALDILLBK<FNLFDFELNJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x27617B0", Offset = "0x275FDB0", VA = "0x1827617B0", Slot = "84")]
	public EDBALDILLBK<CJHCCMIKJOI> LOKHNJBGBGP(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB)
	{
		return default(EDBALDILLBK<CJHCCMIKJOI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x275CB60", Offset = "0x275B160", VA = "0x18275CB60", Slot = "6")]
	public (bool, bool) BPJFFILGFML(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> DNALEDMNCKH, EDBALDILLBK<AIHJLHNMKCJ> EMINHKBJOFH)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x275D440", Offset = "0x275BA40", VA = "0x18275D440")]
	public bool DDJAAGAJJMG(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, [In] KMHJEOLAADO DHBHHDJFOLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x275DA60", Offset = "0x275C060", VA = "0x18275DA60", Slot = "8")]
	public bool DMJENECLFKI(IKPGAMHHELO EGIEFBPGJCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x27600B0", Offset = "0x275E6B0", VA = "0x1827600B0", Slot = "9")]
	public bool JBMDNBLFFAI(EDLMBADJAJJ BIEKNOCAJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x275BEE0", Offset = "0x275A4E0", VA = "0x18275BEE0", Slot = "10")]
	public GEOFGJGIEDO? AJEHJNEALBL(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x275FC70", Offset = "0x275E270", VA = "0x18275FC70", Slot = "11")]
	public PBDPJBEGCAN? ILGDJOHBCNE(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x275DF00", Offset = "0x275C500", VA = "0x18275DF00", Slot = "12")]
	public EDBALDILLBK<MBCPFFKFBDC>? ENPIOFDJKLC(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<HPDCGGEBOAB> MOJFMLAABNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x275EEE0", Offset = "0x275D4E0", VA = "0x18275EEE0", Slot = "13")]
	public EDBALDILLBK<AIHJLHNMKCJ>? GBALHODLAMB(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<IFOKEFFHPOH> DNBAGCFNADG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x2760020", Offset = "0x275E620", VA = "0x182760020", Slot = "14")]
	public IEnumerable<EDBALDILLBK<BIEIIMCKPHN>> JBHKHGGACKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x275F090", Offset = "0x275D690", VA = "0x18275F090", Slot = "15")]
	public IEnumerable<EDBALDILLBK<MLLNMGCLGAP>> GGOFDJDBDNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x275D980", Offset = "0x275BF80", VA = "0x18275D980", Slot = "16")]
	public string DKNIGPFIJKK(EDBALDILLBK<MLLNMGCLGAP> ODCAHNKPDOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2763950", Offset = "0x2761F50", VA = "0x182763950", Slot = "17")]
	public string PFBEOAFHAHP(EDBALDILLBK<MLLNMGCLGAP> ODCAHNKPDOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x275C460", Offset = "0x275AA60", VA = "0x18275C460")]
	public CBDBLPHCHLP? BGLAGCIKMIA([In] IGLPJBODKFE<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2760ED0", Offset = "0x275F4D0", VA = "0x182760ED0", Slot = "23")]
	public EDBALDILLBK<APOJALOJJAE> KACMFOJIDHL(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return default(EDBALDILLBK<APOJALOJJAE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2760130", Offset = "0x275E730", VA = "0x182760130")]
	public EDBALDILLBK<ALEKBGLLPHJ> JBOCPBIKBPG(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, [In] IGLPJBODKFE<ALEKBGLLPHJ> HEIKAAMLBBH)
	{
		return default(EDBALDILLBK<ALEKBGLLPHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x27638D0", Offset = "0x2761ED0", VA = "0x1827638D0", Slot = "33")]
	public EDBALDILLBK<ALEKBGLLPHJ> PEKMCEIBOAB(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP)
	{
		return default(EDBALDILLBK<ALEKBGLLPHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x275C5D0", Offset = "0x275ABD0", VA = "0x18275C5D0", Slot = "34")]
	public EDBALDILLBK<ALEKBGLLPHJ> BIKNLBBEAOK(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB)
	{
		return default(EDBALDILLBK<ALEKBGLLPHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x275EDE0", Offset = "0x275D3E0", VA = "0x18275EDE0")]
	public EDBALDILLBK<ALEKBGLLPHJ>? FJBAILLEFFJ(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, [In] IGLPJBODKFE<ALEKBGLLPHJ> HEIKAAMLBBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2761680", Offset = "0x275FC80", VA = "0x182761680", Slot = "25")]
	public PPJHOOAIDEI? LFHBDDBOIJH(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x275C110", Offset = "0x275A710", VA = "0x18275C110", Slot = "26")]
	public long AKLHPDBJOMJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x275FBE0", Offset = "0x275E1E0", VA = "0x18275FBE0")]
	private void IEIJBJHEBNJ(IGLPJBODKFE<ALEKBGLLPHJ> MIEKOPKCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2761240", Offset = "0x275F840", VA = "0x182761240", Slot = "31")]
	public IEnumerable<(EDBALDILLBK<BIEIIMCKPHN>, EDBALDILLBK<ALEKBGLLPHJ>)> KJKFFPJIGCI(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x275EF70", Offset = "0x275D570", VA = "0x18275EF70", Slot = "32")]
	public EDBALDILLBK<AIHJLHNMKCJ> GBALHODLAMB(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<FNLFDFELNJP> DNBAGCFNADG)
	{
		return default(EDBALDILLBK<AIHJLHNMKCJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x275DE70", Offset = "0x275C470", VA = "0x18275DE70", Slot = "35")]
	public EDBALDILLBK<MBCPFFKFBDC> ENPIOFDJKLC(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<CJHCCMIKJOI> MOJFMLAABNF)
	{
		return default(EDBALDILLBK<MBCPFFKFBDC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2763410", Offset = "0x2761A10", VA = "0x182763410")]
	private CBDBLPHCHLP? ODAMNEHJEDM([In] IGLPJBODKFE<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x275C170", Offset = "0x275A770", VA = "0x18275C170")]
	public GDCCFCAPGMP? AMNCGKGEBMF([In] IGLPJBODKFE<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x275D1C0", Offset = "0x275B7C0", VA = "0x18275D1C0")]
	public KKGGGAABFLL? DABEFHHLNPJ([In] IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2761990", Offset = "0x275FF90", VA = "0x182761990", Slot = "27")]
	public IEnumerable<JCNMIPMAFLG> MDBMHAPNGKB(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x27611B0", Offset = "0x275F7B0", VA = "0x1827611B0", Slot = "28")]
	public bool KHIGIJLGFIE(EDBALDILLBK<MLLNMGCLGAP> ODCAHNKPDOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x27639C0", Offset = "0x2761FC0", VA = "0x1827639C0", Slot = "29")]
	public IEnumerable<KMHJEOLAADO> PHLJCFJGNKO(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> DNALEDMNCKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x275EB60", Offset = "0x275D160", VA = "0x18275EB60", Slot = "30")]
	public IEnumerable<KMHJEOLAADO> FFLEHFAMEFD(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> EMINHKBJOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x275EE60", Offset = "0x275D460", VA = "0x18275EE60")]
	public EDBALDILLBK<BIEIIMCKPHN> FPIFMFOEOFB([In] IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return default(EDBALDILLBK<BIEIIMCKPHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x275E650", Offset = "0x275CC50", VA = "0x18275E650")]
	public EDBALDILLBK<BIEIIMCKPHN>? IMMNDMGFFCP([In] IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x275D8C0", Offset = "0x275BEC0", VA = "0x18275D8C0")]
	private CJNHJIPJPDB? DJFOIPOPLJI([In] IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x275D1C0", Offset = "0x275B7C0", VA = "0x18275D1C0")]
	private KKGGGAABFLL? DOEGDHEFPHG([In] IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2762DD0", Offset = "0x27613D0", VA = "0x182762DD0", Slot = "21")]
	public EDBALDILLBK<BIEIIMCKPHN>? NGKGPKKPJLD(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2761500", Offset = "0x275FB00", VA = "0x182761500", Slot = "39")]
	public IGLPJBODKFE<BIEIIMCKPHN> LBOOABGFNCH(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return default(IGLPJBODKFE<BIEIIMCKPHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x275F6C0", Offset = "0x275DCC0", VA = "0x18275F6C0", Slot = "40")]
	public IGLPJBODKFE<ALEKBGLLPHJ> HGHKGOMHDJF(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return default(IGLPJBODKFE<ALEKBGLLPHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x275D340", Offset = "0x275B940", VA = "0x18275D340", Slot = "36")]
	public IEnumerable<ACLPKCGEGFP> DCKPKGICJFJ(BDPALJAAJCF LHKMBAFKDBN, bool GFDNNEFBKFI, bool EDCEJIMLGNN, bool IIHGDNJMBDP, bool DHCFCOAKGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x275BBE0", Offset = "0x275A1E0", VA = "0x18275BBE0", Slot = "37")]
	public ACLPKCGEGFP AABFGEHOCLD(BDPALJAAJCF LHKMBAFKDBN, HGIFBECBIMN IAAAGGKEHFO, bool GFDNNEFBKFI, bool EDCEJIMLGNN, bool IIHGDNJMBDP, bool DHCFCOAKGMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x275BFA0", Offset = "0x275A5A0", VA = "0x18275BFA0")]
	public JCNMIPMAFLG EFJFDLKHCMM(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, [In] KMHJEOLAADO DHBHHDJFOLL)
	{
		return default(JCNMIPMAFLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x275F490", Offset = "0x275DA90", VA = "0x18275F490", Slot = "41")]
	public KMHJEOLAADO HEOCDNKMPOC(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> DNALEDMNCKH, EDBALDILLBK<AIHJLHNMKCJ> EMINHKBJOFH)
	{
		return default(KMHJEOLAADO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2762F00", Offset = "0x2761500", VA = "0x182762F00", Slot = "42")]
	[AsyncStateMachine(typeof(LIDGCFFFGOJ))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> NGNEAPIAHGB(EDBALDILLBK<BIEIIMCKPHN> NPCOCKHNIOK, EDBALDILLBK<ALEKBGLLPHJ> CHIEFBDHPKP, HOCBFPONHJI LLPAIMMACAP, bool PIDDFONOHBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x2760380", Offset = "0x275E980", VA = "0x182760380", Slot = "43")]
	[AsyncStateMachine(typeof(HJGEJGOIGBF))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> JLGIFPECEEK(EDBALDILLBK<BIEIIMCKPHN> NPCOCKHNIOK, IGLPJBODKFE<ALEKBGLLPHJ> CHIEFBDHPKP, List<EDBALDILLBK<ALEKBGLLPHJ>> HJGPIGMNBKJ, HOCBFPONHJI GMBPGDONOJH, GKMDHBAFLMJ LMNFECIGMFD, HOCBFPONHJI LLPAIMMACAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x275D1F0", Offset = "0x275B7F0", VA = "0x18275D1F0", Slot = "46")]
	[AsyncStateMachine(typeof(JIBAEIBFEAH))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> DCDPHPAAPBJ(EDBALDILLBK<BIEIIMCKPHN> NPCOCKHNIOK, IGLPJBODKFE<ALEKBGLLPHJ> CHIEFBDHPKP, List<EDBALDILLBK<ALEKBGLLPHJ>> HJGPIGMNBKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x2763610", Offset = "0x2761C10", VA = "0x182763610", Slot = "47")]
	[AsyncStateMachine(typeof(EIGNBPEKDJM))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> OOBPEENCKJH(EDBALDILLBK<BIEIIMCKPHN> NPCOCKHNIOK, IGLPJBODKFE<ALEKBGLLPHJ> CHIEFBDHPKP, EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, List<EDBALDILLBK<ALEKBGLLPHJ>> HJGPIGMNBKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x27620B0", Offset = "0x27606B0", VA = "0x1827620B0", Slot = "44")]
	public (IReadOnlyDictionary<BONKIFIDLBA, (EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<IFOKEFFHPOH>)>, IReadOnlyDictionary<PIPFDBHCILD, (EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<HPDCGGEBOAB>)>) MPMKKOMKKPJ(IGLPJBODKFE<BIEIIMCKPHN> IBFMGHMCEGJ, EDBALDILLBK<ALEKBGLLPHJ> CHIEFBDHPKP)
	{
		return default((IReadOnlyDictionary<BONKIFIDLBA, (EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<IFOKEFFHPOH>)>, IReadOnlyDictionary<PIPFDBHCILD, (EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<HPDCGGEBOAB>)>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x275D770", Offset = "0x275BD70", VA = "0x18275D770", Slot = "45")]
	[AsyncStateMachine(typeof(ELCGHEJHPFI))]
	public Task DIHDBDMPDMJ(IGLPJBODKFE<BIEIIMCKPHN> IBFMGHMCEGJ, IGLPJBODKFE<ALEKBGLLPHJ> CHIEFBDHPKP, IReadOnlyList<IGLPJBODKFE<ALEKBGLLPHJ>> PCEPNOKNDMM, IReadOnlyDictionary<BONKIFIDLBA, (EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<IFOKEFFHPOH>)> OAAPKHKAAOJ, IReadOnlyDictionary<PIPFDBHCILD, (EDBALDILLBK<MECIAIKJJDL>, EDBALDILLBK<HPDCGGEBOAB>)> ENDHCKGCDCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x275D9F0", Offset = "0x275BFF0", VA = "0x18275D9F0", Slot = "48")]
	public bool DKNNJEIEBDH(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x275FD30", Offset = "0x275E330", VA = "0x18275FD30", Slot = "49")]
	public bool INDFKGEHBOO(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x275F740", Offset = "0x275DD40", VA = "0x18275F740", Slot = "50")]
	public bool HGJMEGMIJLL(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x275F060", Offset = "0x275D660", VA = "0x18275F060")]
	public HHHCCNLMPJL<BOIDOHDBGAH.JKDMCLDJJOG, IADJFILHMLF> MAANCKNPMCC([In] BOIDOHDBGAH.HGCACJNGEEN ODJGLJIHJOP)
	{
		return default(HHHCCNLMPJL<BOIDOHDBGAH.JKDMCLDJJOG, IADJFILHMLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x275F8F0", Offset = "0x275DEF0", VA = "0x18275F8F0", Slot = "52")]
	[AsyncStateMachine(typeof(CBLBCACFENC))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> IAPMLLKCCHM(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> DNALEDMNCKH, EDBALDILLBK<AIHJLHNMKCJ> EMINHKBJOFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x275C650", Offset = "0x275AC50", VA = "0x18275C650", Slot = "53")]
	[AsyncStateMachine(typeof(CGHDFNNAKAN))]
	public Task<HHHCCNLMPJL<EDBALDILLBK<ALEKBGLLPHJ>, DLKBDBKHJCC>> BIOMAGGFBNK(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<APOJALOJJAE> OKDEOJNBJMA, HOCBFPONHJI ABEEIHCHBIJ, GKMDHBAFLMJ CPOAGMMGJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x2761AC0", Offset = "0x27600C0", VA = "0x182761AC0", Slot = "54")]
	[AsyncStateMachine(typeof(MENKMANDDLG))]
	public Task<HHHCCNLMPJL<EDBALDILLBK<MECIAIKJJDL>, DLKBDBKHJCC>> MEKEELJOADP(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, string NFHOBPDKIPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x2761CF0", Offset = "0x27602F0", VA = "0x182761CF0", Slot = "55")]
	public HHHCCNLMPJL<EONIJHPHNEL, HIKDGBNCNDJ> MIOKHAKHKCO(IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD, EONIJHPHNEL OLOIADOHGAE, GKMDHBAFLMJ JOICDDJMBNO)
	{
		return default(HHHCCNLMPJL<EONIJHPHNEL, HIKDGBNCNDJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x2763770", Offset = "0x2761D70", VA = "0x182763770", Slot = "56")]
	[AsyncStateMachine(typeof(LFOMLDFDBKK))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> PAHJJMEJGGI(IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD, IGLPJBODKFE<ALEKBGLLPHJ> IMOFGHNDPPL, EDBALDILLBK<MECIAIKJJDL> LOJNBPLGDKF, EDBALDILLBK<IFOKEFFHPOH> MOOIAANOCKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x2763C40", Offset = "0x2762240", VA = "0x182763C40", Slot = "57")]
	[AsyncStateMachine(typeof(COIIIDHKIGO))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> PMFMOEGEBKH(IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD, IGLPJBODKFE<ALEKBGLLPHJ> BGGDFAMPIAJ, EDBALDILLBK<MECIAIKJJDL> EPFMHBIFCFJ, EDBALDILLBK<HPDCGGEBOAB> NJKENGKIHNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x2761570", Offset = "0x275FB70", VA = "0x182761570", Slot = "58")]
	[AsyncStateMachine(typeof(JGECLJNOOFC))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> LCFHBOHOLDF(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x275D060", Offset = "0x275B660", VA = "0x18275D060", Slot = "59")]
	[AsyncStateMachine(typeof(ABEJLBKANKA))]
	public Task<HHHCCNLMPJL<IEnumerable<IGLPJBODKFE<ALEKBGLLPHJ>>, DLKBDBKHJCC>> CIBKNEFOAOP(IGLPJBODKFE<BIEIIMCKPHN> BLGHMAJKCIC, GMILLKLCECE LPMBCJIIDDD, IEnumerable<DJNGLNAIHJJ> NCOPFNGDDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x2761090", Offset = "0x275F690", VA = "0x182761090", Slot = "60")]
	public PAMKGMKMNNM KCPKPNDPEKE()
	{
		return default(PAMKGMKMNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x275C340", Offset = "0x275A940", VA = "0x18275C340", Slot = "61")]
	public PAMKGMKMNNM BBCACGFMEFG()
	{
		return default(PAMKGMKMNNM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x2762BF0", Offset = "0x27611F0", VA = "0x182762BF0", Slot = "64")]
	public KDIECECJFKA NGJCNGMKGIL(HMPEPPHBKMF CBHCMEKADCN, EDBALDILLBK<BIEIIMCKPHN> GKPONEBNEEG, IEnumerable<IGLPJBODKFE<BIEIIMCKPHN>> ABPNPJLODEN, IEnumerable<IGLPJBODKFE<ALEKBGLLPHJ>> HJGPIGMNBKJ, ISet<IGLPJBODKFE<CDCOOBOKPHM>>? HOBHPPOOAMH)
	{
		return default(KDIECECJFKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x275FA20", Offset = "0x275E020", VA = "0x18275FA20")]
	private KDIECECJFKA ICDELCGCAAF(HMPEPPHBKMF CBHCMEKADCN, EDBALDILLBK<BIEIIMCKPHN> GKPONEBNEEG, IEnumerable<IGLPJBODKFE<BIEIIMCKPHN>> ABPNPJLODEN, IEnumerable<IGLPJBODKFE<ALEKBGLLPHJ>> HJGPIGMNBKJ, ISet<IGLPJBODKFE<CDCOOBOKPHM>>? HOBHPPOOAMH)
	{
		return default(KDIECECJFKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x275C8C0", Offset = "0x275AEC0", VA = "0x18275C8C0", Slot = "62")]
	public KDIECECJFKA BJNEAMIEBAB(HMPEPPHBKMF CBHCMEKADCN, EDBALDILLBK<BIEIIMCKPHN> GKPONEBNEEG, IEnumerable<IGLPJBODKFE<ALEKBGLLPHJ>> HJGPIGMNBKJ, IEnumerable<DJNGLNAIHJJ> NCOPFNGDDLG, ISet<IGLPJBODKFE<CDCOOBOKPHM>>? HOBHPPOOAMH)
	{
		return default(KDIECECJFKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x275C7B0", Offset = "0x275ADB0", VA = "0x18275C7B0", Slot = "63")]
	public KDIECECJFKA BJNEAMIEBAB(HMPEPPHBKMF CBHCMEKADCN, EDBALDILLBK<BIEIIMCKPHN> GKPONEBNEEG, IEnumerable<EDBALDILLBK<ALEKBGLLPHJ>> HJGPIGMNBKJ, IEnumerable<DJNGLNAIHJJ> NCOPFNGDDLG, ISet<IGLPJBODKFE<CDCOOBOKPHM>>? HOBHPPOOAMH)
	{
		return default(KDIECECJFKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x275DAF0", Offset = "0x275C0F0", VA = "0x18275DAF0")]
	private static IEnumerable<IGLPJBODKFE<BIEIIMCKPHN>> EMGBIJIPFCJ(IEnumerable<DJNGLNAIHJJ> NCOPFNGDDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x275E6D0", Offset = "0x275CCD0", VA = "0x18275E6D0")]
	private IEnumerable<IGLPJBODKFE<ALEKBGLLPHJ>> FFKEFODPPEF(IEnumerable<DJNGLNAIHJJ> NCOPFNGDDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x2761000", Offset = "0x275F600", VA = "0x182761000", Slot = "65")]
	public List<ONMAHNABKDP> KCIKHHHEPLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x275DF90", Offset = "0x275C590", VA = "0x18275DF90")]
	public (List<ONMAHNABKDP>, bool) FDHOHBJKBNK([In] LHCCLMLBLGM PPPGHBABFJK, string INLEBAAACKH, [In] EHAADHBFEAM NHNPKEBGCGG, KDHKOJLLBIL DHGPBJNAEKO, DICPKAJKOBM HMMHOCJLLOI)
	{
		return default((List<ONMAHNABKDP>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x2761830", Offset = "0x275FE30", VA = "0x182761830", Slot = "67")]
	public bool LPFAAPMAOIF(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x275F280", Offset = "0x275D880", VA = "0x18275F280")]
	internal void HBDKJOCPEPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x27614A0", Offset = "0x275FAA0", VA = "0x1827614A0")]
	internal Task KNOFGBJOFBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x2760500", Offset = "0x275EB00", VA = "0x182760500", Slot = "68")]
	public HHHCCNLMPJL<EDBALDILLBK<MBCPFFKFBDC>?, DLKBDBKHJCC> JMOIOPLFBDA(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<AIHJLHNMKCJ> MOOIAANOCKP)
	{
		return default(HHHCCNLMPJL<EDBALDILLBK<MBCPFFKFBDC>?, DLKBDBKHJCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x2762220", Offset = "0x2760820", VA = "0x182762220", Slot = "69")]
	public HHHCCNLMPJL<EDBALDILLBK<AIHJLHNMKCJ>?, DLKBDBKHJCC> NDFNIGKEDDH(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MBCPFFKFBDC> NJKENGKIHNB)
	{
		return default(HHHCCNLMPJL<EDBALDILLBK<AIHJLHNMKCJ>?, DLKBDBKHJCC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x2763050", Offset = "0x2761650", VA = "0x182763050", Slot = "70")]
	[AsyncStateMachine(typeof(OMEANLLHBOC))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> NLDLAIGCHNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x2761360", Offset = "0x275F960", VA = "0x182761360", Slot = "71")]
	[AsyncStateMachine(typeof(OAKDDNLHHMD))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> KNCCANLNGGB(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, string NFHOBPDKIPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x275F7C0", Offset = "0x275DDC0", VA = "0x18275F7C0", Slot = "72")]
	public EDBALDILLBK<ALEKBGLLPHJ>? HKNDGHLKPFL(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x275F360", Offset = "0x275D960", VA = "0x18275F360", Slot = "73")]
	public EDBALDILLBK<ALEKBGLLPHJ>? HDLJJHMLMPI(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x2760F50", Offset = "0x275F550", VA = "0x182760F50", Slot = "74")]
	public int KAEFFNPJEKK(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x2761C00", Offset = "0x2760200", VA = "0x182761C00", Slot = "75")]
	public int MFGOJLJCMGH(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x27631B0", Offset = "0x27617B0", VA = "0x1827631B0", Slot = "76")]
	public int OAGBBDDOOGL(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x275FDB0", Offset = "0x275E3B0", VA = "0x18275FDB0", Slot = "77")]
	public int INODKOBBICN(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x275C200", Offset = "0x275A800", VA = "0x18275C200", Slot = "78")]
	[AsyncStateMachine(typeof(FAOKPONNBMJ))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> BAEDGLMBFOK(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x275F140", Offset = "0x275D740", VA = "0x18275F140", Slot = "79")]
	[AsyncStateMachine(typeof(NBAMFMKFBLO))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> GLCLJEFNFAD(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, EDBALDILLBK<KCPNHNINCKC> ODBMGMEHPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x27601B0", Offset = "0x275E7B0", VA = "0x1827601B0", Slot = "80")]
	public int JCMDBAIFABO(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x27634C0", Offset = "0x2761AC0", VA = "0x1827634C0", Slot = "81")]
	[AsyncStateMachine(typeof(DCONIFFGABC))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> OKHFBPJODEJ(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, string OHLIHBDBKCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x275FEC0", Offset = "0x275E4C0", VA = "0x18275FEC0", Slot = "82")]
	[AsyncStateMachine(typeof(PINHOAOJDIC))]
	public Task<HHHCCNLMPJL<BONGKMFJEJA, DLKBDBKHJCC>> IPOIBEMLDEI(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML, HOCBFPONHJI IHMLAPGNLCC, GKMDHBAFLMJ JHMNNKLOODA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x2763600", Offset = "0x2761C00", VA = "0x182763600", Slot = "7")]
	private bool OOBNELDPIOE(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, [In] KMHJEOLAADO DHBHHDJFOLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x275D1C0", Offset = "0x275B7C0", VA = "0x18275D1C0", Slot = "18")]
	private KKGGGAABFLL DGBLMGNCFLO([In] IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x275DAE0", Offset = "0x275C0E0", VA = "0x18275DAE0", Slot = "19")]
	private EDBALDILLBK<BIEIIMCKPHN> EIKNEMDBEIG([In] IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return default(EDBALDILLBK<BIEIIMCKPHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x275E650", Offset = "0x275CC50", VA = "0x18275E650", Slot = "20")]
	private EDBALDILLBK<BIEIIMCKPHN>? FDIDGNCHLAB([In] IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x27632C0", Offset = "0x27618C0", VA = "0x1827632C0", Slot = "22")]
	private CBDBLPHCHLP OAHIOOLKEPL([In] IGLPJBODKFE<ALEKBGLLPHJ> MIEKOPKCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x2760290", Offset = "0x275E890", VA = "0x182760290", Slot = "24")]
	private EDBALDILLBK<ALEKBGLLPHJ> JFPLJOPIONB(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, [In] IGLPJBODKFE<ALEKBGLLPHJ> HEIKAAMLBBH)
	{
		return default(EDBALDILLBK<ALEKBGLLPHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x275BFA0", Offset = "0x275A5A0", VA = "0x18275BFA0", Slot = "38")]
	private JCNMIPMAFLG AJLOKIBJFOE(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, [In] KMHJEOLAADO DHBHHDJFOLL)
	{
		return default(JCNMIPMAFLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x275F060", Offset = "0x275D660", VA = "0x18275F060", Slot = "51")]
	private HHHCCNLMPJL<BOIDOHDBGAH.JKDMCLDJJOG, IADJFILHMLF> GFGKLKCGELF([In] BOIDOHDBGAH.HGCACJNGEEN ODJGLJIHJOP)
	{
		return default(HHHCCNLMPJL<BOIDOHDBGAH.JKDMCLDJJOG, IADJFILHMLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x27602A0", Offset = "0x275E8A0", VA = "0x1827602A0", Slot = "66")]
	private (List<ONMAHNABKDP>, bool) JHPBLAOGABD([In] LHCCLMLBLGM PPPGHBABFJK, string INLEBAAACKH, [In] EHAADHBFEAM NHNPKEBGCGG, KDHKOJLLBIL DHGPBJNAEKO, DICPKAJKOBM HMMHOCJLLOI)
	{
		return default((List<ONMAHNABKDP>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x275F2E0", Offset = "0x275D8E0", VA = "0x18275F2E0")]
	[CompilerGenerated]
	private FGCFEGCGMAK HDDCPECHJMD(HJDEFPFJDOJ DEBKJNNAPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x2761A50", Offset = "0x2760050", VA = "0x182761A50")]
	[CompilerGenerated]
	private GDCCFCAPGMP MDOPKNNBEKB(IGLPJBODKFE<ALEKBGLLPHJ> DEBKJNNAPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x2763140", Offset = "0x2761740", VA = "0x182763140")]
	[CompilerGenerated]
	private CJNHJIPJPDB NOHLJEMGMNG(IGLPJBODKFE<BIEIIMCKPHN> DEBKJNNAPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x27612F0", Offset = "0x275F8F0", VA = "0x1827612F0")]
	[CompilerGenerated]
	private GDCCFCAPGMP KMGIHHBBNOO(IGLPJBODKFE<ALEKBGLLPHJ> DEBKJNNAPAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x2761920", Offset = "0x275FF20", VA = "0x182761920")]
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
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<EDBALDILLBK<KCPNHNINCKC>, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public FGCFEGCGMAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public IGLPJBODKFE<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public IGLPJBODKFE<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public EDBALDILLBK<MECIAIKJJDL> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private TaskAwaiter<HHHCCNLMPJL<EDBALDILLBK<KCPNHNINCKC>, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(RVA = "0x277E0C0", Offset = "0x277C6C0", VA = "0x18277E0C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x277E340", Offset = "0x277C940", VA = "0x18277E340", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<EDBALDILLBK<LGADIHOLJAO>, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public FGCFEGCGMAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public IGLPJBODKFE<BIEIIMCKPHN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public IGLPJBODKFE<ALEKBGLLPHJ> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public EDBALDILLBK<MECIAIKJJDL> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private TaskAwaiter<HHHCCNLMPJL<EDBALDILLBK<LGADIHOLJAO>, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x2778C30", Offset = "0x2777230", VA = "0x182778C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x2778EB0", Offset = "0x27774B0", VA = "0x182778EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400033B")]
	private readonly HJDEFPFJDOJ PLLBJECBPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400033C")]
	private readonly MGIDPOIGHNH IHDCNDNFOPP;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public TypeKey HEAGAKFJNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000585")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x27798B0", Offset = "0x2777EB0", VA = "0x1827798B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public HJDEFPFJDOJ KKNBAMLGLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x27798E0", Offset = "0x2777EE0", VA = "0x1827798E0")]
	public FGCFEGCGMAK(HJDEFPFJDOJ JIPIEFCLIID, MGIDPOIGHNH FKPENEKJEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x27795D0", Offset = "0x2777BD0", VA = "0x1827795D0", Slot = "6")]
	[AsyncStateMachine(typeof(PNPKONNBMHG))]
	public Task<HHHCCNLMPJL<EDBALDILLBK<KCPNHNINCKC>, DLKBDBKHJCC>> ALIPKIDGMCL(IGLPJBODKFE<BIEIIMCKPHN> KJCOKJBCCGD, IGLPJBODKFE<ALEKBGLLPHJ> MIEKOPKCEML, EDBALDILLBK<MECIAIKJJDL> CBGAMFGIPLK, string NFHOBPDKIPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x2779740", Offset = "0x2777D40", VA = "0x182779740", Slot = "7")]
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
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private readonly HJDEFPFJDOJ PCAAKKAJNLP;

	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private static readonly HashSet<HJDEFPFJDOJ> NIOPHLMJPNO;

	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private static readonly HashSet<HJDEFPFJDOJ> MBPEBMJOCJD;

	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private static readonly HashSet<HJDEFPFJDOJ> BDIHEMIPGGM;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public TypeKey LCHJEPJMOOO
	{
		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x277CBA0", Offset = "0x277B1A0", VA = "0x18277CBA0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool HOHAGBDEDHD
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x277CB90", Offset = "0x277B190", VA = "0x18277CB90", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool ELMDPDDNEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x277CBF0", Offset = "0x277B1F0", VA = "0x18277CBF0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool PPAAEDBIJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x277CB10", Offset = "0x277B110", VA = "0x18277CB10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x277B4F0", Offset = "0x2779AF0", VA = "0x18277B4F0")]
	public bool HBGMKAEOAKP(string OHLIHBDBKCE, [Out] LELDOHAKAOP LLGGNDEECGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public LPEOOOFCFLN(HJDEFPFJDOJ HCAMONPFOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x277B360", Offset = "0x2779960", VA = "0x18277B360")]
	internal static TypeKey GNKBFCMFOIG(HJDEFPFJDOJ MLCOGCMJLBB)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x27798B0", Offset = "0x2777EB0", VA = "0x1827798B0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x277DA00", Offset = "0x277C000", VA = "0x18277DA00", Slot = "4")]
	public int MJNIOHCGOFN(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x277D9A0", Offset = "0x277BFA0", VA = "0x18277D9A0", Slot = "5")]
	public AFPLFKDKJPC HKEKJJMEJGD(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x277D9D0", Offset = "0x277BFD0", VA = "0x18277D9D0", Slot = "6")]
	public AFPLFKDKJPC JONIEAFELGN(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x277D960", Offset = "0x277BF60", VA = "0x18277D960", Slot = "7")]
	public IReadOnlyList<AFPLFKDKJPC> BHIKMMGDBIL(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x277DA20", Offset = "0x277C020", VA = "0x18277DA20", Slot = "8")]
	public AFPLFKDKJPC[] MLJJHHLMPNO(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF, int JLCAEJJKIPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x277D9B0", Offset = "0x277BFB0", VA = "0x18277D9B0", Slot = "9")]
	public bool IKODBCOPDOE(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x277D980", Offset = "0x277BF80", VA = "0x18277D980", Slot = "10")]
	public bool HAKKONIKOCC(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x277D940", Offset = "0x277BF40", VA = "0x18277D940", Slot = "11")]
	public bool AFHJOLLGKAB(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x277DA50", Offset = "0x277C050", VA = "0x18277DA50", Slot = "12")]
	public bool PAHHIGLBJLF(BONGKMFJEJA COFBNOFIHKI, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0x277D920", Offset = "0x277BF20", VA = "0x18277D920", Slot = "13")]
	public bool ACHPCHDAHMC(BONGKMFJEJA NPBBBMPJKJL, AFPLFKDKJPC BDCLNIJAFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0x277DA30", Offset = "0x277C030", VA = "0x18277DA30", Slot = "14")]
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
		[Cpp2IlInjected.Address(RVA = "0x27764B0", Offset = "0x2774AB0", VA = "0x1827764B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x2776500", Offset = "0x2774B00", VA = "0x182776500", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public CEKCJHGDPCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public AFPLFKDKJPC action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private TaskAwaiter<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x277A9E0", Offset = "0x2778FE0", VA = "0x18277A9E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x277AC80", Offset = "0x2779280", VA = "0x18277AC80", Slot = "5")]
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
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<OCIFKDPAIJK, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public CEKCJHGDPCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public IReadOnlyList<AFPLFKDKJPC> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private TaskAwaiter<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x277A340", Offset = "0x2778940", VA = "0x18277A340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x277A6C0", Offset = "0x2778CC0", VA = "0x18277A6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private readonly HNNMKAAPCJH CMAAEEHAJID;

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public CEKCJHGDPCJ(HNNMKAAPCJH HIEGHANFGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x2777630", Offset = "0x2775C30", VA = "0x182777630")]
	[AsyncStateMachine(typeof(JKEAKOIEEDM))]
	private Task<HHHCCNLMPJL<object, DLKBDBKHJCC>> NGOFJAKHGMH(AFPLFKDKJPC BDCLNIJAFBF, bool CKEAKKIBMKM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0x2777500", Offset = "0x2775B00", VA = "0x182777500", Slot = "4")]
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
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	internal GOKPPJCJPIF<ADPBMIFBBEH, IGLPJBODKFE<ADPBMIFBBEH.JDMBOMNCDND>, AFPLFKDKJPC, AFDMHMHIIMC> PCAAKKAJNLP;

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x273F2B0", Offset = "0x273D8B0", VA = "0x18273F2B0")]
	private JEHFLBFEOGF([In] GOKPPJCJPIF<ADPBMIFBBEH, IGLPJBODKFE<ADPBMIFBBEH.JDMBOMNCDND>, AFPLFKDKJPC, AFDMHMHIIMC> PPIDHODIMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x2779F80", Offset = "0x2778580", VA = "0x182779F80")]
	public static JEHFLBFEOGF ACADPGMDEBE()
	{
		return default(JEHFLBFEOGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public static class ENCJCMLAEHC
{
	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
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
	[Cpp2IlInjected.Address(RVA = "0x2774570", Offset = "0x2772B70", VA = "0x182774570", Slot = "7")]
	public AFPLFKDKJPC AHGFFDDCDOG(ADPBMIFBBEH[] DCENAJLAONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0x10CF1C0", Offset = "0x10CD7C0", VA = "0x1810CF1C0")]
	public IGLPJBODKFE<ADPBMIFBBEH.JDMBOMNCDND> KGMJEJHJABK([In] ADPBMIFBBEH HOFIBHNCGHE)
	{
		return default(IGLPJBODKFE<ADPBMIFBBEH.JDMBOMNCDND>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0x10CEFB0", Offset = "0x10CD5B0", VA = "0x1810CEFB0")]
	public int PPDCCFBDOAP([In] ADPBMIFBBEH PAMLNFEPEDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0x2774750", Offset = "0x2772D50", VA = "0x182774750")]
	public int HGGLNOKKHLB([In] ADPBMIFBBEH HOFIBHNCGHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0x10CEFB0", Offset = "0x10CD5B0", VA = "0x1810CEFB0", Slot = "4")]
	private int EAHBOGKJDLH([In] ADPBMIFBBEH HOFIBHNCGHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x2774750", Offset = "0x2772D50", VA = "0x182774750", Slot = "5")]
	private int LLDOBONLLHH([In] ADPBMIFBBEH HOFIBHNCGHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0x10CF1C0", Offset = "0x10CD7C0", VA = "0x1810CF1C0", Slot = "6")]
	private IGLPJBODKFE<ADPBMIFBBEH.JDMBOMNCDND> KPENBNDCOHA([In] ADPBMIFBBEH HOFIBHNCGHE)
	{
		return default(IGLPJBODKFE<ADPBMIFBBEH.JDMBOMNCDND>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public struct DCJBDNFDKJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000362")]
	internal FACBNMEONCE<JGDMKIEKPCF, AFPLFKDKJPC, GJPHBONOGIB> PCAAKKAJNLP;

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x273F2B0", Offset = "0x273D8B0", VA = "0x18273F2B0")]
	private DCJBDNFDKJD([In] FACBNMEONCE<JGDMKIEKPCF, AFPLFKDKJPC, GJPHBONOGIB> CBJCEEDBJFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x2778000", Offset = "0x2776600", VA = "0x182778000")]
	public static DCJBDNFDKJD ACADPGMDEBE()
	{
		return default(DCJBDNFDKJD);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public static class KDPFBDKEPNN
{
	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260")]
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
	[Cpp2IlInjected.Address(RVA = "0x2171A90", Offset = "0x2170090", VA = "0x182171A90")]
	public int ECDNBKAPNNC([In] JGDMKIEKPCF PAMLNFEPEDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x2779980", Offset = "0x2777F80", VA = "0x182779980", Slot = "5")]
	public AFPLFKDKJPC FCMIAPEEKDJ(JGDMKIEKPCF[] MGNAMDKGBLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x2171A90", Offset = "0x2170090", VA = "0x182171A90", Slot = "4")]
	private int FIONNHHOBFP([In] JGDMKIEKPCF PAMLNFEPEDC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public class ENPCMMEHLEL : OGMCLKGLBPG, IADJFILHMLF, DLKBDBKHJCC, HIKDGBNCNDJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000366")]
	private readonly HIKDGBNCNDJ? PMHDLKLGNAO;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public KLAKIJLCEJL EJPNNEGOIFM
	{
		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(KLAKIJLCEJL);
		}
		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public override HIKDGBNCNDJ? GCEONJBMONL
	{
		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x2779000", Offset = "0x2777600", VA = "0x182779000", Slot = "7")]
	public override string JJNMHFCAPPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0x2779190", Offset = "0x2777790", VA = "0x182779190")]
	private ENPCMMEHLEL(KLAKIJLCEJL KOJNMKELJGK, HIKDGBNCNDJ? EMKFMGADLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0x2779110", Offset = "0x2777710", VA = "0x182779110")]
	public static ENPCMMEHLEL MPMAJPNGILG(HIKDGBNCNDJ EMKFMGADLCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0x2778F20", Offset = "0x2777520", VA = "0x182778F20")]
	public static ENPCMMEHLEL ALAGLDHGDBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x2778F90", Offset = "0x2777590", VA = "0x182778F90")]
	public static ENPCMMEHLEL JAAPPPNEDFA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
public static class NAOGAOHCECL
{
	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x39A3900", Offset = "0x39A1F00", VA = "0x1839A3900")]
	public static HHHCCNLMPJL<TOk, IADJFILHMLF> FBMLGANNNGL<TOk>([In] this HHHCCNLMPJL<TOk, IADJFILHMLF> OCACDKEJIIB, HIKDGBNCNDJ EMKFMGADLCM) where TOk : notnull
	{
		return default(HHHCCNLMPJL<TOk, IADJFILHMLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x39A39F0", Offset = "0x39A1FF0", VA = "0x1839A39F0")]
	public static HHHCCNLMPJL<TOk?, IADJFILHMLF?> IPPECGKJFFC<TOk>([In] this HHHCCNLMPJL<TOk, IADJFILHMLF> OCACDKEJIIB)
	{
		return default(HHHCCNLMPJL<TOk, IADJFILHMLF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x39A3800", Offset = "0x39A1E00", VA = "0x1839A3800")]
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
	[Cpp2IlInjected.Address(RVA = "0x39E8410", Offset = "0x39E6A10", VA = "0x1839E8410")]
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
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public int CEBFMOBHAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public DAPEGEJBKHJ? AIICEFDIFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public DAPEGEJBKHJ? HKMMOBEDFDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public readonly List<AFPLFKDKJPC> AKFHCOIGFOO;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x277D5C0", Offset = "0x277BBC0", VA = "0x18277D5C0")]
		private NEMDGMKEKMJ(int OHHMJGCBCKD, DAPEGEJBKHJ? COCBFBEDBDG, DAPEGEJBKHJ? ODLHHBFEIEF, List<AFPLFKDKJPC> BAHJNLHEKLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x277D500", Offset = "0x277BB00", VA = "0x18277D500")]
		public static NEMDGMKEKMJ ACADPGMDEBE()
		{
			return default(NEMDGMKEKMJ);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000369")]
	private readonly IBMPPKILLBB<NEMDGMKEKMJ> AJIIAFBGGMO;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public static CBCGICEGLFH MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x2776550", Offset = "0x2774B50", VA = "0x182776550")]
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
		[Cpp2IlInjected.Address(RVA = "0xC8F7E0", Offset = "0xC8DDE0", VA = "0x180C8F7E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0xC8F720", Offset = "0xC8DD20", VA = "0x180C8F720")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x2776BD0", Offset = "0x27751D0", VA = "0x182776BD0")]
	public void PPOFHGNBMIP(KPBELAPACCB ODLHHBFEIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x27765A0", Offset = "0x2774BA0", VA = "0x1827765A0")]
	public void HELHMOMIOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x2776890", Offset = "0x2774E90", VA = "0x182776890")]
	private static string? PHDNDAOKOGE([In] NEMDGMKEKMJ PDLCCJEHEEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x2776D90", Offset = "0x2775390", VA = "0x182776D90")]
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
