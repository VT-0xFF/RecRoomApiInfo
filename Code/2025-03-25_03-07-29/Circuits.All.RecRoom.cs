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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x260ED60", Offset = "0x260E160", VA = "0x18260ED60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9BC6F0", Offset = "0x9BBAF0", VA = "0x1809BC6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class DJHNEBOJMKB : IDisposable, CFKHGHGHLEB, FDPFJPKNMAA, HLBIAMDBOBH, ADLDPKNJNJI
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class FNBHIEGMCLN : LOFMILLKJAH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int MHEBDEHOPGC
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x26051B0", Offset = "0x26045B0", VA = "0x1826051B0", Slot = "5")]
		public DJDAGJGAJNO PBGHFEHGDEF(MGALOLPCIOG.OIHFANDIDBI EIHGNKDHDGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void PPJNJCNFLBB();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void HDMJJFCIKKL();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x26050F0", Offset = "0x26044F0", VA = "0x1826050F0", Slot = "13")]
		public virtual void DOEAIPJBEHB(DJHNEBOJMKB EGMIBAJCGJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2605130", Offset = "0x2604530", VA = "0x182605130", Slot = "14")]
		public virtual void EENKEDKPKDG(DJHNEBOJMKB EGMIBAJCGJC, IJHNHGOIIEG AKLHLNJOCEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		protected FNBHIEGMCLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LOFMILLKJAH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int MHEBDEHOPGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DJDAGJGAJNO PBGHFEHGDEF(MGALOLPCIOG.OIHFANDIDBI EIHGNKDHDGF);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PPJNJCNFLBB();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HDMJJFCIKKL();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DOEAIPJBEHB(DJHNEBOJMKB EGMIBAJCGJC);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void EENKEDKPKDG(DJHNEBOJMKB EGMIBAJCGJC, IJHNHGOIIEG AKLHLNJOCEK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct JMEIPGDNAPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly LOKNPOBJGCO<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB, JCAMIECDDEF.FOIFKKFBMDJ<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB>> NBCLFPBJMAA;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x260B7B0", Offset = "0x260ABB0", VA = "0x18260B7B0")]
		internal JMEIPGDNAPI(LOKNPOBJGCO<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB, JCAMIECDDEF.FOIFKKFBMDJ<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB>> KKDALLBMKBI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class COLMEENHIID : JCAMIECDDEF.FOIFKKFBMDJ<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly COLMEENHIID DMADMDPHOOL;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		private COLMEENHIID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA19630", Offset = "0xA18A30", VA = "0x180A19630", Slot = "4")]
		public OOKMKACJEON MCBNPKKPKNJ(IJHNHGOIIEG CAMFIHKHJNG)
		{
			return default(OOKMKACJEON);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x25F7470", Offset = "0x25F6870", VA = "0x1825F7470", Slot = "5")]
		public void DOEAIPJBEHB(DJHNEBOJMKB FDNIDHBNFHE, IJHNHGOIIEG AKLHLNJOCEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x25F7580", Offset = "0x25F6980", VA = "0x1825F7580", Slot = "6")]
		public void EENKEDKPKDG(DJHNEBOJMKB FDNIDHBNFHE, IJHNHGOIIEG AKLHLNJOCEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct PFPEJCDHJEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public HCJMMGBLEBD<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB, JCAMIECDDEF.FOIFKKFBMDJ<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB>> NBCLFPBJMAA;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x26107B0", Offset = "0x260FBB0", VA = "0x1826107B0")]
		internal PFPEJCDHJEM(HCJMMGBLEBD<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB, JCAMIECDDEF.FOIFKKFBMDJ<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB>> KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2610760", Offset = "0x260FB60", VA = "0x182610760")]
		public static PFPEJCDHJEM AFLKMMODJAC()
		{
			return default(PFPEJCDHJEM);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct BMDHBPCAIOC : ODFAMDDBIDD.LBCCDLCNGDI<IJHNHGOIIEG, DJHNEBOJMKB>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct KMPAHOHEHPM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<AEAAIINGJNL<object?, GJDNFLPCNNP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public DJHNEBOJMKB receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IJHNHGOIIEG action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public BMDHBPCAIOC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<AEAAIINGJNL<object?, GJDNFLPCNNP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x260BD20", Offset = "0x260B120", VA = "0x18260BD20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x260BF00", Offset = "0x260B300", VA = "0x18260BF00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA140E0", Offset = "0xA134E0", VA = "0x180A140E0", Slot = "4")]
		public EECNAGIPCBM<PAHGPENHMCA> GKBJDHFGGHJ(DJHNEBOJMKB LPKAAAAGEAF)
		{
			return default(EECNAGIPCBM<PAHGPENHMCA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x25F6820", Offset = "0x25F5C20", VA = "0x1825F6820", Slot = "5")]
		public void KCDOMNOHINF(DJHNEBOJMKB LPKAAAAGEAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x25F6880", Offset = "0x25F5C80", VA = "0x1825F6880", Slot = "6")]
		[AsyncStateMachine(typeof(KMPAHOHEHPM))]
		public Task<AEAAIINGJNL<object, GJDNFLPCNNP>> NLPECAPDGKH(DJHNEBOJMKB LPKAAAAGEAF, IJHNHGOIIEG AKLHLNJOCEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x25F6800", Offset = "0x25F5C00", VA = "0x1825F6800", Slot = "7")]
		public IJHNHGOIIEG[] ECCJLJFJFIP(DJHNEBOJMKB LPKAAAAGEAF)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct JHJIALCHJFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<bool, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public DJHNEBOJMKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<AEAAIINGJNL<bool, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x260B4B0", Offset = "0x260A8B0", VA = "0x18260B4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x260B740", Offset = "0x260AB40", VA = "0x18260B740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct ALHKOMDFALC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public DJHNEBOJMKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x25F6200", Offset = "0x25F5600", VA = "0x1825F6200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x25F63E0", Offset = "0x25F57E0", VA = "0x1825F63E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GLLNPDMCEGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<object?, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public DJHNEBOJMKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public IJHNHGOIIEG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<AEAAIINGJNL<object?, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2605870", Offset = "0x2604C70", VA = "0x182605870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2605A60", Offset = "0x2604E60", VA = "0x182605A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EECNAGIPCBM<PAHGPENHMCA> BCJBMHMDBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JMEIPGDNAPI ANOADHABFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FENEJNMGNEA CLJMPCDOHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly PFBFNICDHJE NLAPMGBNGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly AJBMMLPNPPG KJGKEJILJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly JFCLCBLPGED.OMJAOFLEANA EPOHEDHGMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B48")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly PIAHCHCOGGM FFOMKNGEOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B50")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly BPMAKMBHLND HHNCLMIAEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B58")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly FCLMGEBHDLM HFMFBHEBOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B60")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly BLMADFMAKJO EEJLBJEPBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B68")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private DKEIKPIKBBC EKAGCIDGMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B78")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private KPBAOAPDGOM IJAGMHMJBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B98")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly FENEJNMGNEA.JIADBKGLHND KMEOODHEFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BA0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly NEMGLABGMNM KHAEFJMJFOH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FENEJNMGNEA CMLCFJHPNJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x26038C0", Offset = "0x2602CC0", VA = "0x1826038C0")]
		get
		{
			return default(FENEJNMGNEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal LOFMILLKJAH BFOMBPPJBOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2603E10", Offset = "0x2603210", VA = "0x182603E10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal DJDAGJGAJNO GELMIAFEAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2603040", Offset = "0x2602440", VA = "0x182603040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2603CE0", Offset = "0x26030E0", VA = "0x182603CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool DKGNFPDJAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2603050", Offset = "0x2602450", VA = "0x182603050")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x26038B0", Offset = "0x2602CB0", VA = "0x1826038B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public KJMBHIBMIFJ BPBKEAIPMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2604160", Offset = "0x2603560", VA = "0x182604160", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AGBKEPLGOPM HJELDJNLIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2604170", Offset = "0x2603570", VA = "0x182604170", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public EOJAHLPCJOG ABJLBCIOGIK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2604190", Offset = "0x2603590", VA = "0x182604190", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BLAHGDPPDCH GADMPABMKMA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2604180", Offset = "0x2603580", VA = "0x182604180", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JFCLCBLPGED? MNBJKKJGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2603650", Offset = "0x2602A50", VA = "0x182603650", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private GPBAAJANPDN? AFAFAFIFGGO
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2603B60", Offset = "0x2602F60", VA = "0x182603B60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2603E60", Offset = "0x2603260", VA = "0x182603E60")]
	private DJHNEBOJMKB(AJBMMLPNPPG CLKKBOEEKDJ, EECNAGIPCBM<PAHGPENHMCA> CGDOJFDLEME, [In] JMEIPGDNAPI EECNPPAEJHG, [In] FENEJNMGNEA NMGMIAFBJKO, [In] PFBFNICDHJE FJDOGJGPPNG, DJDAGJGAJNO LFENNGLFPKN, [In] JFCLCBLPGED.OMJAOFLEANA DJPDGPFMEBG, FENEJNMGNEA.JIADBKGLHND LBJHOPOAFGF, NEMGLABGMNM LMEBMDOKAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2602A60", Offset = "0x2601E60", VA = "0x182602A60")]
	public static DJHNEBOJMKB AFLKMMODJAC(AJBMMLPNPPG EIHGNKDHDGF, [In] BDALOCNMEBC BNEBDMPIONM, GCOFLPNBILM OKBHEIPEDEE, [In] GNFICOKGOGH NLGIMAPEJIP, CEHJEABKECC HEJLDLLPPOP, EECNAGIPCBM<PAHGPENHMCA> CGDOJFDLEME, EECNAGIPCBM<LFIIHMIGBGO> PGCLNOAAFLP, NEGLMDBBMLE BKFLLLKFECH, MNJECOBLHHA EKGIADDIHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2602BA0", Offset = "0x2601FA0", VA = "0x182602BA0")]
	public static DJHNEBOJMKB AFLKMMODJAC(AJBMMLPNPPG CLKKBOEEKDJ, [In] FENEJNMGNEA NMGMIAFBJKO, [In] PFBFNICDHJE FJDOGJGPPNG, EECNAGIPCBM<PAHGPENHMCA> CGDOJFDLEME, EECNAGIPCBM<LFIIHMIGBGO> PGCLNOAAFLP, NEGLMDBBMLE BKFLLLKFECH, MNJECOBLHHA EKGIADDIHFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x26030D0", Offset = "0x26024D0", VA = "0x1826030D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x26037C0", Offset = "0x2602BC0", VA = "0x1826037C0")]
	[AsyncStateMachine(typeof(JHJIALCHJFB))]
	public Task<AEAAIINGJNL<bool, GJDNFLPCNNP>> FNCOGBKLGJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x26036D0", Offset = "0x2602AD0", VA = "0x1826036D0")]
	[AsyncStateMachine(typeof(ALHKOMDFALC))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> FACKMGHCAFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x26038D0", Offset = "0x2602CD0", VA = "0x1826038D0")]
	internal void IICCPEFBAHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2603AE0", Offset = "0x2602EE0", VA = "0x182603AE0")]
	internal DGLIKEIKEPL<IJHNHGOIIEG> JDBFAODIAOD([In] JPMIHCAALBE CAHCCPCNCHB)
	{
		return default(DGLIKEIKEPL<IJHNHGOIIEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2603060", Offset = "0x2602460", VA = "0x182603060")]
	internal bool DNCPCOBEEBI([In] JPMIHCAALBE CAHCCPCNCHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2602EB0", Offset = "0x26022B0", VA = "0x182602EB0")]
	internal AEAAIINGJNL<IJHNHGOIIEG, GJDNFLPCNNP> ANMMAHEPBJA([In] OOHMFJDOIPO IBKPBBHEFFK)
	{
		return default(AEAAIINGJNL<IJHNHGOIIEG, GJDNFLPCNNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2603C90", Offset = "0x2603090", VA = "0x182603C90")]
	private void KCDOMNOHINF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x2603D00", Offset = "0x2603100", VA = "0x182603D00")]
	[AsyncStateMachine(typeof(GLLNPDMCEGN))]
	internal Task<AEAAIINGJNL<object, GJDNFLPCNNP>> PILHFDBHFIE(IJHNHGOIIEG AKLHLNJOCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x26032C0", Offset = "0x26026C0", VA = "0x1826032C0")]
	private IJHNHGOIIEG[] ECCJLJFJFIP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class KECLPEEJDHK<TData> : BPMPLDFNAFC, LPGDDLPNEDI, EPFFDEGDAEO where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly IEBAHENHLEA<DJONKGBCHFD>? KPIHPGLNLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string DCKEPMDAMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly TData CBNHMBHNHHG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEBAHENHLEA<DJONKGBCHFD>? OAJJNJLDGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2875FC0", Offset = "0x28753C0", VA = "0x182875FC0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x993430", Offset = "0x992830", VA = "0x180993430", Slot = "7")]
	public override string CHDHFHDBOKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4CCC290", Offset = "0x4CCB690", VA = "0x184CCC290")]
	internal KECLPEEJDHK([In] IEBAHENHLEA<DJONKGBCHFD>? OJALPEANODH, EECNAGIPCBM<PHNBHNIJDOG>? CHCDFLAODPP, IOKind? JDFHKJJOLFM, string EIGJGBPHOMK, [In] TData AMHCLKHIFKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LDDHBPJFBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x260BF70", Offset = "0x260B370", VA = "0x18260BF70")]
	public static AEAAIINGJNL<OBBLHLJFIJF, LPGDDLPNEDI> GJNGGNGKDCI([In] this DCMDOGAMABH<JNLLIFKLKJK> KBPIGJOAOIB)
	{
		return default(AEAAIINGJNL<OBBLHLJFIJF, LPGDDLPNEDI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x36BBF40", Offset = "0x36BB340", VA = "0x1836BBF40")]
	public static AEAAIINGJNL<TOk, LPGDDLPNEDI> NKFGAEMANAO<TOk>([In] this AEAAIINGJNL<TOk, LPGDDLPNEDI> CAMFIHKHJNG, [In] IEBAHENHLEA<DJONKGBCHFD>? OJALPEANODH, EECNAGIPCBM<PHNBHNIJDOG>? CHCDFLAODPP, IOKind? JDFHKJJOLFM, string EIGJGBPHOMK) where TOk : notnull
	{
		return default(AEAAIINGJNL<TOk, LPGDDLPNEDI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface AJBMMLPNPPG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GJGHLAIIHED.KJKECFDKKOM GELCPPLINCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	MGALOLPCIOG.OIHFANDIDBI EMNOMCALKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	DJHNEBOJMKB.LOFMILLKJAH CPLLCCEEMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	IGMHMMGMENM.MFOKDBPCJIG BOBLJCIDDEN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	JCAMIECDDEF.FOIFKKFBMDJ<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB> ELDBOCCFGHA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DKCGBDMFMOE.MDNNENMIHJH BOPGCKOFJKL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	OJNPGCHDMOP EPGNNBPOOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	AAPEHCLIBNH LOOOAPFMDIK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	PNONDFODKJN MFLPADFCMJN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	JLKFEPJGAAB ICBNAJIPIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	DIEBIEHHCDJ HAIKHDHDFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OJKMFFECKHL
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2610060", Offset = "0x260F460", VA = "0x182610060")]
	public static IJHNHGOIIEG AJNGLDFDOAB(this IJHNHGOIIEG CAMFIHKHJNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2610170", Offset = "0x260F570", VA = "0x182610170")]
	public static IJHNHGOIIEG CNIEONFNGBM(this PNKCLJDNHOE CAMFIHKHJNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct PNKCLJDNHOE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct CNPKBGDMPGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<object?, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public DJHNEBOJMKB root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public PNKCLJDNHOE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<AEAAIINGJNL<object?, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x25F6B80", Offset = "0x25F5F80", VA = "0x1825F6B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x25F6E40", Offset = "0x25F6240", VA = "0x1825F6E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly ByteString HNMCNCHEPGK;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC670E0", VA = "0x180C67CE0")]
	private PNKCLJDNHOE(ByteString FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2611150", Offset = "0x2610550", VA = "0x182611150")]
	public static IJHNHGOIIEG MBFHBINFJLA(ByteString FIIKLGCIAGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x26110A0", Offset = "0x26104A0", VA = "0x1826110A0")]
	public static IHLPCODOJJK<OOKMKACJEON, PNKCLJDNHOE> CEKDKBIJMEO(IJHNHGOIIEG BFIJPNPGJMJ)
	{
		return default(IHLPCODOJJK<OOKMKACJEON, PNKCLJDNHOE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2611210", Offset = "0x2610610", VA = "0x182611210")]
	[AsyncStateMachine(typeof(CNPKBGDMPGH))]
	public static Task<AEAAIINGJNL<object, GJDNFLPCNNP>> PILHFDBHFIE(DJHNEBOJMKB FDNIDHBNFHE, PNKCLJDNHOE CAMFIHKHJNG)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct NJPDNNHHOBA
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x260EBD0", Offset = "0x260DFD0", VA = "0x18260EBD0")]
	public static IJHNHGOIIEG MBFHBINFJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x260EAE0", Offset = "0x260DEE0", VA = "0x18260EAE0")]
	public static IHLPCODOJJK<OOKMKACJEON, NJPDNNHHOBA> CEKDKBIJMEO(IJHNHGOIIEG BFIJPNPGJMJ)
	{
		return default(IHLPCODOJJK<OOKMKACJEON, NJPDNNHHOBA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x260EB50", Offset = "0x260DF50", VA = "0x18260EB50")]
	public static AEAAIINGJNL<DKANDHFOMPH, ABNNHKJOOMD> KMKOBGLALNC(DJHNEBOJMKB FDNIDHBNFHE, [In] NJPDNNHHOBA CAMFIHKHJNG)
	{
		return default(AEAAIINGJNL<DKANDHFOMPH, ABNNHKJOOMD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct LPDGNKBJKCK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct MLJONLCEGMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, ABNNHKJOOMD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public DJHNEBOJMKB root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public LPDGNKBJKCK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private AEAAIINGJNL<DKANDHFOMPH, ABNNHKJOOMD> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x260D310", Offset = "0x260C710", VA = "0x18260D310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x260D680", Offset = "0x260CA80", VA = "0x18260D680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly JOFFGAJEOAD? GHGDNIIEBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly DAAAEMKKFPO? KAJDJFMOADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly EKENJADJMDF? JOCKPMEMAMJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2530340", Offset = "0x252F740", VA = "0x182530340")]
	private LPDGNKBJKCK(JOFFGAJEOAD? NLKDNDLFMAK, DAAAEMKKFPO? IJGCGJIIJKL, EKENJADJMDF? EDHFJOANBFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x260C890", Offset = "0x260BC90", VA = "0x18260C890")]
	public static IJHNHGOIIEG? MBFHBINFJLA(JOFFGAJEOAD? NLKDNDLFMAK, DAAAEMKKFPO? IJGCGJIIJKL, EKENJADJMDF? EDHFJOANBFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x260C780", Offset = "0x260BB80", VA = "0x18260C780")]
	public static IHLPCODOJJK<OOKMKACJEON, LPDGNKBJKCK> CEKDKBIJMEO(IJHNHGOIIEG BFIJPNPGJMJ)
	{
		return default(IHLPCODOJJK<OOKMKACJEON, LPDGNKBJKCK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x260C990", Offset = "0x260BD90", VA = "0x18260C990")]
	[AsyncStateMachine(typeof(MLJONLCEGMB))]
	public static Task<AEAAIINGJNL<DKANDHFOMPH, ABNNHKJOOMD>> PILHFDBHFIE(DJHNEBOJMKB FDNIDHBNFHE, LPDGNKBJKCK CAMFIHKHJNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct DHGACPOGNDB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct DOJCLKCINKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<AJEHNEOFKOC, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public DHGACPOGNDB self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public DJHNEBOJMKB root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private AEAAIINGJNL<AJEHNEOFKOC, GJDNFLPCNNP> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private AEAAIINGJNL<object?, EPFFDEGDAEO>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private AEAAIINGJNL<object?, EPFFDEGDAEO> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private AEAAIINGJNL<object?, EPFFDEGDAEO>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter<AEAAIINGJNL<object?, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2604550", Offset = "0x2603950", VA = "0x182604550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x26049C0", Offset = "0x2603DC0", VA = "0x1826049C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly IReadOnlyList<IJHNHGOIIEG> CDGAGHLJGOE;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC670E0", VA = "0x180C67CE0")]
	private DHGACPOGNDB(IReadOnlyList<IJHNHGOIIEG> NLNFFLCOOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x2602860", Offset = "0x2601C60", VA = "0x182602860")]
	public static IJHNHGOIIEG MBFHBINFJLA(IReadOnlyList<IJHNHGOIIEG> NLNFFLCOOFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x26027C0", Offset = "0x2601BC0", VA = "0x1826027C0")]
	public static IHLPCODOJJK<OOKMKACJEON, DHGACPOGNDB> CEKDKBIJMEO(IJHNHGOIIEG BFIJPNPGJMJ)
	{
		return default(IHLPCODOJJK<OOKMKACJEON, DHGACPOGNDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2602920", Offset = "0x2601D20", VA = "0x182602920")]
	[AsyncStateMachine(typeof(DOJCLKCINKG))]
	public static Task<AEAAIINGJNL<AJEHNEOFKOC, GJDNFLPCNNP>> PILHFDBHFIE(DJHNEBOJMKB FDNIDHBNFHE, DHGACPOGNDB CAMFIHKHJNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct OOHMFJDOIPO
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class AELFAPHCBKI
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class AFLIEABCAIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IEBAHENHLEA<AELFAPHCBKI> actionId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public AFLIEABCAIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x25F6090", Offset = "0x25F5490", VA = "0x1825F6090")]
		internal IJHNHGOIIEG KBKMKOCGMFP(int count, int index, [In] ReadOnlySpan<byte> span)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly IEBAHENHLEA<AELFAPHCBKI> LFHHIKLKKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly int DLMGPHHMEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly int BNBIOAJGDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly byte[] CBNHMBHNHHG;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2610740", Offset = "0x260FB40", VA = "0x182610740")]
	private OOHMFJDOIPO(IEBAHENHLEA<AELFAPHCBKI> PIDONNEPPLK, int PPLOBPJCNII, int KDCAMOIGIMA, byte[] AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2610630", Offset = "0x260FA30", VA = "0x182610630")]
	public static IJHNHGOIIEG MBFHBINFJLA(IEBAHENHLEA<AELFAPHCBKI> PIDONNEPPLK, int PPLOBPJCNII, int KDCAMOIGIMA, ByteString AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x2610520", Offset = "0x260F920", VA = "0x182610520")]
	public static IJHNHGOIIEG[] LMPMJAOCJFA(IJHNHGOIIEG AKLHLNJOCEK, int ELJPGAILLJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2610240", Offset = "0x260F640", VA = "0x182610240")]
	public static IHLPCODOJJK<OOKMKACJEON, OOHMFJDOIPO> CEKDKBIJMEO(IJHNHGOIIEG BFIJPNPGJMJ)
	{
		return default(IHLPCODOJJK<OOKMKACJEON, OOHMFJDOIPO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2610390", Offset = "0x260F790", VA = "0x182610390")]
	public static AEAAIINGJNL<IJHNHGOIIEG, GJDNFLPCNNP> KMKOBGLALNC(DJHNEBOJMKB FDNIDHBNFHE, [In] OOHMFJDOIPO CAMFIHKHJNG)
	{
		return default(AEAAIINGJNL<IJHNHGOIIEG, GJDNFLPCNNP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct JPMIHCAALBE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct NJPDDFJLKMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<bool, ABNNHKJOOMD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public DJHNEBOJMKB root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public JPMIHCAALBE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private AEAAIINGJNL<bool, ABNNHKJOOMD> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, ABNNHKJOOMD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x260E430", Offset = "0x260D830", VA = "0x18260E430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x260EA70", Offset = "0x260DE70", VA = "0x18260EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly int DLMGPHHMEHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly int BNBIOAJGDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly byte[] CBNHMBHNHHG;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xB6CEE0", Offset = "0xB6C2E0", VA = "0x180B6CEE0")]
	private JPMIHCAALBE(int PPLOBPJCNII, int KDCAMOIGIMA, byte[] AMHCLKHIFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x260B8A0", Offset = "0x260ACA0", VA = "0x18260B8A0")]
	public static IJHNHGOIIEG MBFHBINFJLA(int PPLOBPJCNII, int KDCAMOIGIMA, ByteString AMHCLKHIFKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x260BAB0", Offset = "0x260AEB0", VA = "0x18260BAB0")]
	public static IJHNHGOIIEG?[]? PJADMJJDAOC(int ELJPGAILLJI, JOFFGAJEOAD? NLKDNDLFMAK, DAAAEMKKFPO? IJGCGJIIJKL, EKENJADJMDF? EDHFJOANBFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x260B7C0", Offset = "0x260ABC0", VA = "0x18260B7C0")]
	public static IHLPCODOJJK<OOKMKACJEON, JPMIHCAALBE> CEKDKBIJMEO(IJHNHGOIIEG BFIJPNPGJMJ)
	{
		return default(IHLPCODOJJK<OOKMKACJEON, JPMIHCAALBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x260B980", Offset = "0x260AD80", VA = "0x18260B980")]
	[AsyncStateMachine(typeof(NJPDDFJLKMO))]
	public static Task<AEAAIINGJNL<bool, ABNNHKJOOMD>> PILHFDBHFIE(DJHNEBOJMKB FDNIDHBNFHE, JPMIHCAALBE CAMFIHKHJNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class PIAHCHCOGGM : KJMBHIBMIFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly DJHNEBOJMKB HOMGCJPPDEM;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public FPLHHHNJKAA? DMADMDPHOOL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x26107C0", Offset = "0x260FBC0", VA = "0x1826107C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	internal PIAHCHCOGGM(DJHNEBOJMKB EGMIBAJCGJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class COINHKMADKL : FPLHHHNJKAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly DJHNEBOJMKB HOMGCJPPDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly LAHKLODPGDN ALGDCGCLECN;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x995770", Offset = "0x994B70", VA = "0x180995770")]
	public COINHKMADKL(DJHNEBOJMKB EGMIBAJCGJC, LAHKLODPGDN MMDMGLMFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x25F7190", Offset = "0x25F6590", VA = "0x1825F7190", Slot = "4")]
	public AEAAIINGJNL<OBBLHLJFIJF, LPGDDLPNEDI> KMEBDBPFEKP(IEBAHENHLEA<DJONKGBCHFD> GNBPFKJNJLF, EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, EECNAGIPCBM<HICCHPCIPHD> MFEIHBHGIDP)
	{
		return default(AEAAIINGJNL<OBBLHLJFIJF, LPGDDLPNEDI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x25F6EB0", Offset = "0x25F62B0", VA = "0x1825F6EB0", Slot = "5")]
	public AEAAIINGJNL<OBBLHLJFIJF, LPGDDLPNEDI> ELNCMBBIKBE(IEBAHENHLEA<DJONKGBCHFD> GNBPFKJNJLF, EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, EECNAGIPCBM<NJMBLJHEMGJ> CLMAEMHEFIF)
	{
		return default(AEAAIINGJNL<OBBLHLJFIJF, LPGDDLPNEDI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class GJGHLAIIHED : ACFCLILAAPO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface KJKECFDKKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<LAHKLODPGDN> CIIOJPIKGKD(DJHNEBOJMKB EGMIBAJCGJC, DAAAEMKKFPO? LCADMIDFFFI, EKENJADJMDF? CKNLBPIIMCE, CancellationToken BLABAMPAGAH);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		CKKKMJLDAPJ KEHEJAOOJDM(DJHNEBOJMKB EGMIBAJCGJC, JOFFGAJEOAD FHABEGGDEAK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class MJAJMOAPJAK : KJKECFDKKOM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct INFLKJFOHNH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AsyncTaskMethodBuilder<LAHKLODPGDN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public DJHNEBOJMKB circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public DAAAEMKKFPO cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public EKENJADJMDF cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<IGMHMMGMENM> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x2608560", Offset = "0x2607960", VA = "0x182608560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x2608730", Offset = "0x2607B30", VA = "0x182608730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly MJAJMOAPJAK DMADMDPHOOL;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		private MJAJMOAPJAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x260D030", Offset = "0x260C430", VA = "0x18260D030", Slot = "4")]
		[AsyncStateMachine(typeof(INFLKJFOHNH))]
		public Task<LAHKLODPGDN> CIIOJPIKGKD(DJHNEBOJMKB EGMIBAJCGJC, DAAAEMKKFPO? LCADMIDFFFI, EKENJADJMDF? CKNLBPIIMCE, CancellationToken BLABAMPAGAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x260D190", Offset = "0x260C590", VA = "0x18260D190", Slot = "5")]
		public CKKKMJLDAPJ KEHEJAOOJDM(DJHNEBOJMKB EGMIBAJCGJC, JOFFGAJEOAD FHABEGGDEAK)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct OCLJLFEBDCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<GJGHLAIIHED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public DJHNEBOJMKB circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public DAAAEMKKFPO cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public EKENJADJMDF cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public JOFFGAJEOAD evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private KJKECFDKKOM <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<LAHKLODPGDN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x260EF00", Offset = "0x260E300", VA = "0x18260EF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x260F400", Offset = "0x260E800", VA = "0x18260F400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly LAHKLODPGDN ALGDCGCLECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly CKKKMJLDAPJ CFDCJLJNJGO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public JFCLCBLPGED MNBJKKJGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2605820", Offset = "0x2604C20", VA = "0x182605820", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GPBAAJANPDN AMOOINHEBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x2605700", Offset = "0x2604B00", VA = "0x182605700", Slot = "5")]
		get
		{
			return default(GPBAAJANPDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public COINHKMADKL FPCJHEOLHCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public LFOLNLEMMBJ FLFPDHIBEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xE0BF60", Offset = "0xE0B360", VA = "0x180E0BF60")]
	private GJGHLAIIHED(LAHKLODPGDN MMDMGLMFBGG, CKKKMJLDAPJ GIDLGACHPBN, COINHKMADKL PFMMKDIMIJA, LFOLNLEMMBJ GEMHFNIDKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2605590", Offset = "0x2604990", VA = "0x182605590")]
	[AsyncStateMachine(typeof(OCLJLFEBDCJ))]
	public static Task<GJGHLAIIHED> AGCAEOGDOPN(DJHNEBOJMKB EGMIBAJCGJC, JOFFGAJEOAD FHABEGGDEAK, DAAAEMKKFPO? LCADMIDFFFI, EKENJADJMDF? CKNLBPIIMCE, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x26057C0", Offset = "0x2604BC0", VA = "0x1826057C0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class MGALOLPCIOG : DJDAGJGAJNO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface OIHFANDIDBI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<ACFCLILAAPO> LHOMFFCMILP(DJHNEBOJMKB EGMIBAJCGJC, JOFFGAJEOAD FHABEGGDEAK, DAAAEMKKFPO? LCADMIDFFFI, EKENJADJMDF? CKNLBPIIMCE, CancellationToken BLABAMPAGAH);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KCIEFDBLLMJ();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IGJAJOEPMJN();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class FOKAJJMKCAI : OIHFANDIDBI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct DKPPEGFDPCC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public AsyncTaskMethodBuilder<ACFCLILAAPO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public DJHNEBOJMKB circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public JOFFGAJEOAD evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public DAAAEMKKFPO cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public EKENJADJMDF cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private TaskAwaiter<GJGHLAIIHED> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x26041A0", Offset = "0x26035A0", VA = "0x1826041A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x26044E0", Offset = "0x26038E0", VA = "0x1826044E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2605300", Offset = "0x2604700", VA = "0x182605300", Slot = "4")]
		[AsyncStateMachine(typeof(DKPPEGFDPCC))]
		public Task<ACFCLILAAPO> LHOMFFCMILP(DJHNEBOJMKB EGMIBAJCGJC, JOFFGAJEOAD FHABEGGDEAK, DAAAEMKKFPO? LCADMIDFFFI, EKENJADJMDF? CKNLBPIIMCE, CancellationToken BLABAMPAGAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void KCIEFDBLLMJ();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void IGJAJOEPMJN();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		protected FOKAJJMKCAI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct IEKCJNJEFIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<ACFCLILAAPO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public MGALOLPCIOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<DKANDHFOMPH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x26069F0", Offset = "0x2605DF0", VA = "0x1826069F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2606BF0", Offset = "0x2605FF0", VA = "0x182606BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct NBIENAFKLKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public MGALOLPCIOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public DJHNEBOJMKB circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public JOFFGAJEOAD evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public DAAAEMKKFPO cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public EKENJADJMDF cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<ACFCLILAAPO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x260DC60", Offset = "0x260D060", VA = "0x18260DC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x260E1A0", Offset = "0x260D5A0", VA = "0x18260E1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly OIHFANDIDBI EGDADDGFBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TaskCompletionSource<DKANDHFOMPH> IIBALDNJMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly TaskCompletionSource<DKANDHFOMPH> HGCGEIICBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly CancellationTokenSource HFAAAEKPGLF;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DKGNFPDJAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9BF180", Offset = "0x9BE580", VA = "0x1809BF180", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9BEF00", Offset = "0x9BE300", VA = "0x1809BEF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NFLEONEBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xCFD050", Offset = "0xCFC450", VA = "0x180CFD050", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x11F7970", Offset = "0x11F6D70", VA = "0x1811F7970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool OJJBBNFJMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x18A59A0", Offset = "0x18A4DA0", VA = "0x1818A59A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x260CF10", Offset = "0x260C310", VA = "0x18260CF10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ACFCLILAAPO? BFMJDCCDPDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x993560", Offset = "0x992960", VA = "0x180993560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x260CCC0", Offset = "0x260C0C0", VA = "0x18260CCC0", Slot = "7")]
	[AsyncStateMachine(typeof(IEKCJNJEFIL))]
	public Task<ACFCLILAAPO> LCIHMLHPFBJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x260CF20", Offset = "0x260C320", VA = "0x18260CF20")]
	public MGALOLPCIOG(OIHFANDIDBI EIHGNKDHDGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x260CDB0", Offset = "0x260C1B0", VA = "0x18260CDB0", Slot = "8")]
	[AsyncStateMachine(typeof(NBIENAFKLKB))]
	public Task MAKJPMJEFIC(DJHNEBOJMKB EGMIBAJCGJC, JOFFGAJEOAD FHABEGGDEAK, DAAAEMKKFPO? LCADMIDFFFI, EKENJADJMDF? CKNLBPIIMCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x260CB40", Offset = "0x260BF40", VA = "0x18260CB40", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class MPKFPCBLFPL : CPGCBBIHCNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly LFOLNLEMMBJ NAGLMDODIKC;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	public MPKFPCBLFPL(LFOLNLEMMBJ GEMHFNIDKMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal static class OEGMPDBPGDG
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class ILBMLBGHJBI<TGraph> : FOBIELMFHMM where TGraph : AFFPINOIDCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		protected readonly TGraph ODCMMEFKGIF;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual GBADKHFJPJD? NKCJGJHHBBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x169C080", Offset = "0x169B480", VA = "0x18169C080", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public EECNAGIPCBM<JJJHHLABGOM> HALDBNDBBAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x49D72F0", Offset = "0x49D66F0", VA = "0x1849D72F0", Slot = "5")]
			get
			{
				return default(EECNAGIPCBM<JJJHHLABGOM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public EECNAGIPCBM<JJJHHLABGOM>? NDAIJMOKFEB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x49D7310", Offset = "0x49D6710", VA = "0x1849D7310", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
		public ILBMLBGHJBI(TGraph GJFMFEGOIPL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class NMFNHPBAHIK : ILBMLBGHJBI<OBJELLHNIOF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override GBADKHFJPJD? NKCJGJHHBBC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x260EC70", Offset = "0x260E070", VA = "0x18260EC70", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x260EC90", Offset = "0x260E090", VA = "0x18260EC90")]
		public NMFNHPBAHIK(OBJELLHNIOF MPCHDHBCBDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x260FC00", Offset = "0x260F000", VA = "0x18260FC00")]
	public static FOBIELMFHMM AFLKMMODJAC(AFFPINOIDCK GJFMFEGOIPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class JFPNAONGGLG : AGBCEPDAIHL, AIDKDGHFPLJ, KALOLKFHOKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class MKKGFIMNAPH
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
			public MKKGFIMNAPH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public OJNPGCHDMOP errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x26131E0", Offset = "0x26125E0", VA = "0x1826131E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x2613450", Offset = "0x2612850", VA = "0x182613450", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public JFPNAONGGLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public MKKGFIMNAPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x260D220", Offset = "0x260C620", VA = "0x18260D220")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task APFJLMHAHCJ(OJNPGCHDMOP errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct MPNDNKNLGJD : IAsyncStateMachine
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
		public JFPNAONGGLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x260D6F0", Offset = "0x260CAF0", VA = "0x18260D6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x260DC00", Offset = "0x260D000", VA = "0x18260DC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class GBLDHBBEAAO
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
			public GBLDHBBEAAO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x26134B0", Offset = "0x26128B0", VA = "0x1826134B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x2613790", Offset = "0x2612B90", VA = "0x182613790", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public JFPNAONGGLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GBLDHBBEAAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x2605460", Offset = "0x2604860", VA = "0x182605460")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task CEDBHPGBFMM(OJNPGCHDMOP errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly HGLJGFLMDDD BBCMJLBOAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly ICollection<DMBJPCNMJBE> IAEMDECHDNM;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private AJBMMLPNPPG NIOAFJFNFFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x2608A50", Offset = "0x2607E50", VA = "0x182608A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public EECNAGIPCBM<HICCHPCIPHD> HHAJJDCIHDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xE58260", Offset = "0xE57660", VA = "0x180E58260", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(EECNAGIPCBM<HICCHPCIPHD>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xE57A50", Offset = "0xE56E50", VA = "0x180E57A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private EECNAGIPCBM<GFAOCBCKMMM> BFBECFBHHLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x11DB1C0", Offset = "0x11DA5C0", VA = "0x1811DB1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public EECNAGIPCBM<BOBCICDOPCN> LCGIHJONPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9B9020", Offset = "0x9B8420", VA = "0x1809B9020", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(EECNAGIPCBM<BOBCICDOPCN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override EECNAGIPCBM<PHNBHNIJDOG> INCIDJBMNNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x260AE30", Offset = "0x260A230", VA = "0x18260AE30", Slot = "21")]
		get
		{
			return default(EECNAGIPCBM<PHNBHNIJDOG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool FJIEKJHCCAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x2609990", Offset = "0x2608D90", VA = "0x182609990", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x260B290", Offset = "0x260A690", VA = "0x18260B290")]
	private JFPNAONGGLG(DJHNEBOJMKB EGMIBAJCGJC, BPKOHJDNEKO JOMDOBIKCNM, HGLJGFLMDDD JIDLJFPCCEC, EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, EECNAGIPCBM<HICCHPCIPHD> MFEIHBHGIDP, EECNAGIPCBM<GFAOCBCKMMM> CLEKIHEJJEC, bool LLAHIHAIOJM, string MPGDCPPMNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x2608A70", Offset = "0x2607E70", VA = "0x182608A70")]
	public static JFPNAONGGLG AFLKMMODJAC(DJHNEBOJMKB EGMIBAJCGJC, BPKOHJDNEKO JOMDOBIKCNM, HGLJGFLMDDD BEAPIEHNNIB, EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, EECNAGIPCBM<GFAOCBCKMMM> CLEKIHEJJEC, EECNAGIPCBM<HICCHPCIPHD> MFEIHBHGIDP, bool LLAHIHAIOJM, bool HBOPKMBIJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x260AE80", Offset = "0x260A280", VA = "0x18260AE80", Slot = "22")]
	protected override void MBHBIOMKKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2609790", Offset = "0x2608B90", VA = "0x182609790", Slot = "23")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2609730", Offset = "0x2608B30", VA = "0x182609730", Slot = "31")]
	public void DOKMGBLOIMI(DMBJPCNMJBE GCIIAFAHIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x2609C40", Offset = "0x2609040", VA = "0x182609C40", Slot = "28")]
	public void IAACMOFFIKC(KMIMCKHNFOI LIAJLGBDCDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x2609FB0", Offset = "0x26093B0", VA = "0x182609FB0", Slot = "29")]
	public void JCOCKLCIKBE(HDGBDCDIGOF CBPFAPKEKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x260A950", Offset = "0x2609D50", VA = "0x18260A950", Slot = "24")]
	protected override void JLKDMNEKCMG(GKJGINDFPME CMAHNGHDHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x2609830", Offset = "0x2608C30", VA = "0x182609830", Slot = "33")]
	public string EKNCJLCLKAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x260AAA0", Offset = "0x2609EA0", VA = "0x18260AAA0", Slot = "30")]
	public string JNOJKNMEPMB(int CGKHNEOJKPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2608EF0", Offset = "0x26082F0", VA = "0x182608EF0")]
	private void AOKJGGFNJLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2609B70", Offset = "0x2608F70", VA = "0x182609B70", Slot = "32")]
	public void HMNAIENKKNI(DMBJPCNMJBE GCIIAFAHIMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x260B010", Offset = "0x260A410", VA = "0x18260B010")]
	private void PGNJNGEEBNO(bool FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x2609120", Offset = "0x2608520", VA = "0x182609120", Slot = "34")]
	[AsyncStateMachine(typeof(MPNDNKNLGJD))]
	public Task BFEJNBLGJKL(string FIIKLGCIAGG, bool DGPACOHJGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x26095E0", Offset = "0x26089E0", VA = "0x1826095E0")]
	public void DNBLJAFBOEC(string FIIKLGCIAGG, bool DGPACOHJGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x2609440", Offset = "0x2608840", VA = "0x182609440")]
	private void DMAACIPHLJL(int FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0xE57A50", Offset = "0xE56E50", VA = "0x180E57A50")]
	internal void HNCIDCKNANO(EECNAGIPCBM<HICCHPCIPHD> FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x260AFB0", Offset = "0x260A3B0", VA = "0x18260AFB0")]
	[CompilerGenerated]
	private void NBIDIDPBEFB(string FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x260AD60", Offset = "0x260A160", VA = "0x18260AD60")]
	[CompilerGenerated]
	private bool KHEMNBNMMLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x260B1D0", Offset = "0x260A5D0", VA = "0x18260B1D0")]
	[CompilerGenerated]
	private bool PJGEECLLCCG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x2609A90", Offset = "0x2608E90", VA = "0x182609A90")]
	[CompilerGenerated]
	private int FIHKJCLCCLC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x2609AE0", Offset = "0x2608EE0", VA = "0x182609AE0")]
	[CompilerGenerated]
	private bool GFNEJAGIJJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x260AE20", Offset = "0x260A220", VA = "0x18260AE20")]
	[CompilerGenerated]
	private void KIHLMHMJKHK(string FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2609380", Offset = "0x2608780", VA = "0x182609380")]
	[CompilerGenerated]
	private bool DDEBOLOMNHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x260AFC0", Offset = "0x260A3C0", VA = "0x18260AFC0")]
	[CompilerGenerated]
	private bool NDIJLLEECCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x260AF20", Offset = "0x260A320", VA = "0x18260AF20")]
	[CompilerGenerated]
	private bool MHPNPDMNJCI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x2609A90", Offset = "0x2608E90", VA = "0x182609A90")]
	[CompilerGenerated]
	private int JJLCLLMBKGG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2609230", Offset = "0x2608630", VA = "0x182609230")]
	[CompilerGenerated]
	private bool BKCIMLBLJNH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2609A10", Offset = "0x2608E10", VA = "0x182609A10")]
	[CompilerGenerated]
	private object FDNAMBJIJCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2609300", Offset = "0x2608700", VA = "0x182609300")]
	[CompilerGenerated]
	private void CONIMOFBGOK(object FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x2608E20", Offset = "0x2608220", VA = "0x182608E20")]
	[CompilerGenerated]
	private bool ANAOMBJADHL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class IGKOKDHIMKA
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private sealed class ILEAIAHOLKB : PLKGMELDIMJ<LDCMOMADELC>
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class HMEFOPJDOKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public ILEAIAHOLKB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public HMEFOPJDOKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x2606980", Offset = "0x2605D80", VA = "0x182606980")]
			internal object EGBBPMAANLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x26068B0", Offset = "0x2605CB0", VA = "0x1826068B0")]
			internal void CLGLLFKFENF(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x26084F0", Offset = "0x26078F0", VA = "0x1826084F0")]
		public ILEAIAHOLKB(DJHNEBOJMKB EGMIBAJCGJC, LDCMOMADELC KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2608260", Offset = "0x2607660", VA = "0x182608260", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class OGKJDEFJIOF : PHFAJMKIHEI<ANKMJKFFJAP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override BIGAOKINCIB DLBEIGACCLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xB1EC30", Offset = "0xB1E030", VA = "0x180B1EC30", Slot = "140")]
			get
			{
				return default(BIGAOKINCIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x260FD90", Offset = "0x260F190", VA = "0x18260FD90")]
		public OGKJDEFJIOF(DJHNEBOJMKB EGMIBAJCGJC, ANKMJKFFJAP KKDALLBMKBI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class LHAKKJLFLPP : PLKGMELDIMJ<KCHBPLCPONJ>
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x260C710", Offset = "0x260BB10", VA = "0x18260C710")]
		public LHAKKJLFLPP(DJHNEBOJMKB EGMIBAJCGJC, KCHBPLCPONJ JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x260C410", Offset = "0x260B810", VA = "0x18260C410", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x260C590", Offset = "0x260B990", VA = "0x18260C590")]
		[CompilerGenerated]
		private bool JBJIOKKCBCN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x260C5E0", Offset = "0x260B9E0", VA = "0x18260C5E0")]
		[CompilerGenerated]
		private void KDDFNLNOIJO(bool FIIKLGCIAGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class BCFFOHBPOOH : PLKGMELDIMJ<CGGFLODMFAP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class OJKKEOHBKDK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public BCFFOHBPOOH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public OJKKEOHBKDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x260FE40", Offset = "0x260F240", VA = "0x18260FE40")]
			internal void EGBBPMAANLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x260FDF0", Offset = "0x260F1F0", VA = "0x18260FDF0")]
			internal bool CLGLLFKFENF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x260FEE0", Offset = "0x260F2E0", VA = "0x18260FEE0")]
			internal bool HDCDJCJBGOC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x260FF30", Offset = "0x260F330", VA = "0x18260FF30")]
			internal void PLLLOFKOIMP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x260FE90", Offset = "0x260F290", VA = "0x18260FE90")]
			internal bool HBGFIPOPPBP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x25F6790", Offset = "0x25F5B90", VA = "0x1825F6790")]
		public BCFFOHBPOOH(DJHNEBOJMKB EGMIBAJCGJC, CGGFLODMFAP JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x25F6450", Offset = "0x25F5850", VA = "0x1825F6450", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class PIDPCLKEGGD : PLKGMELDIMJ<BLNHANIIONJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class ODNNFMFEIID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public PIDPCLKEGGD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public ODNNFMFEIID()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x260F720", Offset = "0x260EB20", VA = "0x18260F720")]
			internal object EGBBPMAANLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x260FA00", Offset = "0x260EE00", VA = "0x18260FA00")]
			internal bool JIJNJKLHHBH(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x260F470", Offset = "0x260E870", VA = "0x18260F470")]
			internal void CLGLLFKFENF(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x260F890", Offset = "0x260EC90", VA = "0x18260F890")]
			internal string HDCDJCJBGOC(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x260FBB0", Offset = "0x260EFB0", VA = "0x18260FBB0")]
			internal IReadOnlyList<object> PLLLOFKOIMP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x260F820", Offset = "0x260EC20", VA = "0x18260F820")]
			internal bool HBGFIPOPPBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x260F6D0", Offset = "0x260EAD0", VA = "0x18260F6D0")]
			internal bool CLJKEHJEAMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x260FA80", Offset = "0x260EE80", VA = "0x18260FA80")]
			internal void NJKGPCFLDDO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2611030", Offset = "0x2610430", VA = "0x182611030")]
		public PIDPCLKEGGD(DJHNEBOJMKB EGMIBAJCGJC, BLNHANIIONJ JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x26108D0", Offset = "0x260FCD0", VA = "0x1826108D0", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class FIHBCPNALPN : PLKGMELDIMJ<JKHEBKAOJLP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class BNGLOKBPMEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public FIHBCPNALPN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public BNGLOKBPMEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x25F6AE0", Offset = "0x25F5EE0", VA = "0x1825F6AE0")]
			internal bool EGBBPMAANLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x25F69B0", Offset = "0x25F5DB0", VA = "0x1825F69B0")]
			internal void CLGLLFKFENF(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x25F6B30", Offset = "0x25F5F30", VA = "0x1825F6B30")]
			internal bool HDCDJCJBGOC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2604E80", Offset = "0x2604280", VA = "0x182604E80")]
		public FIHBCPNALPN(DJHNEBOJMKB EGMIBAJCGJC, JKHEBKAOJLP JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2604C50", Offset = "0x2604050", VA = "0x182604C50", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class JNMCMNGHCEO<TNode> : PLKGMELDIMJ<TNode> where TNode : notnull, PNPPELIDDGA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct FKHBJAOGCPJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public AsyncTaskMethodBuilder<AEAAIINGJNL<EECNAGIPCBM<NBDDIELADOM>, GJDNFLPCNNP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public JNMCMNGHCEO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private TaskAwaiter<AEAAIINGJNL<EECNAGIPCBM<NBDDIELADOM>, GJDNFLPCNNP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x46E7530", Offset = "0x46E6930", VA = "0x1846E7530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x46E7940", Offset = "0x46E6D40", VA = "0x1846E7940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct IKPIOPGJIDB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public JNMCMNGHCEO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public EECNAGIPCBM<NBDDIELADOM> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x49D6980", Offset = "0x49D5D80", VA = "0x1849D6980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x49D6D90", Offset = "0x49D6190", VA = "0x1849D6D90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override bool ALLEIHGKGMP
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public sealed override EECNAGIPCBM<NBDDIELADOM>? BMLGFEBOKDH
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x4C0C490", Offset = "0x4C0B890", VA = "0x184C0C490", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4C0C440", Offset = "0x4C0B840", VA = "0x184C0C440")]
		protected JNMCMNGHCEO(DJHNEBOJMKB EGMIBAJCGJC, TNode JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4C0C140", Offset = "0x4C0B540", VA = "0x184C0C140", Slot = "114")]
		[AsyncStateMachine(typeof(JNMCMNGHCEO<>.FKHBJAOGCPJ))]
		public override Task<AEAAIINGJNL<EECNAGIPCBM<NBDDIELADOM>, GJDNFLPCNNP>> GJJMDKBOHHL(string MPGDCPPMNJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4C0C260", Offset = "0x4C0B660", VA = "0x184C0C260", Slot = "138")]
		public sealed override bool LHPOHLBIOMM(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4C0C300", Offset = "0x4C0B700", VA = "0x184C0C300", Slot = "126")]
		protected sealed override bool NCPJDEJCKAA(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4C0C3A0", Offset = "0x4C0B7A0", VA = "0x184C0C3A0", Slot = "127")]
		protected override bool PAJNNJPKCHB(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4C0C030", Offset = "0x4C0B430", VA = "0x184C0C030", Slot = "115")]
		[AsyncStateMachine(typeof(JNMCMNGHCEO<>.IKPIOPGJIDB))]
		public override Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> DOIMEGCHPLA(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class JFMNLILBFIJ : FHOENDLGMDB<FHIOPFNFALB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class FHFDONNKJIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public JFMNLILBFIJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public FHFDONNKJIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x2604B10", Offset = "0x2603F10", VA = "0x182604B10")]
			internal bool HNBFOOJPLBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x2604B90", Offset = "0x2603F90", VA = "0x182604B90")]
			internal void JGIJDKFFJHI(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x26089F0", Offset = "0x2607DF0", VA = "0x1826089F0")]
		public JFMNLILBFIJ(DJHNEBOJMKB EGMIBAJCGJC, FHIOPFNFALB KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x26087A0", Offset = "0x2607BA0", VA = "0x1826087A0", Slot = "140")]
		protected override void DMEODAIMGHO(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class GFGLGKLBGPA : IFPNFMBFIIL<KOLAJPBBMFC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xB2B4E0", Offset = "0xB2A8E0", VA = "0x180B2B4E0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2605530", Offset = "0x2604930", VA = "0x182605530")]
		public GFGLGKLBGPA(DJHNEBOJMKB EGMIBAJCGJC, KOLAJPBBMFC JOMDOBIKCNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public abstract class IFPNFMBFIIL<TNode> : PLKGMELDIMJ<TNode> where TNode : notnull, BDJBAPGCHOL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct HAGDAHMNEAH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public AsyncTaskMethodBuilder<AEAAIINGJNL<EECNAGIPCBM<NBDDIELADOM>, GJDNFLPCNNP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public IFPNFMBFIIL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private TaskAwaiter<AEAAIINGJNL<EECNAGIPCBM<NBDDIELADOM>, GJDNFLPCNNP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x486ABC0", Offset = "0x4869FC0", VA = "0x18486ABC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x486B070", Offset = "0x486A470", VA = "0x18486B070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct BNEBKHDGHCA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public IFPNFMBFIIL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public EECNAGIPCBM<NBDDIELADOM> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x5D70E30", Offset = "0x5D70230", VA = "0x185D70E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x5D712B0", Offset = "0x5D706B0", VA = "0x185D712B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct BMJENFGEEOH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<AEAAIINGJNL<AJEHNEOFKOC, GJDNFLPCNNP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public IFPNFMBFIIL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private TaskAwaiter<AEAAIINGJNL<AJEHNEOFKOC, GJDNFLPCNNP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x5D6F960", Offset = "0x5D6ED60", VA = "0x185D6F960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x5D70010", Offset = "0x5D6F410", VA = "0x185D70010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class DLFHDMGJNIJ
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
				public DLFHDMGJNIJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0x3E57920", Offset = "0x3E56D20", VA = "0x183E57920", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000152")]
				[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public ALEICLAOMCP configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public IFPNFMBFIIL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public DLFHDMGJNIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x65F2020", Offset = "0x65F1420", VA = "0x1865F2020")]
			internal bool NJKGPCFLDDO(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x65F1CB0", Offset = "0x65F10B0", VA = "0x1865F1CB0")]
			internal void EGBBPMAANLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x65F1F80", Offset = "0x65F1380", VA = "0x1865F1F80")]
			[AsyncStateMachine(typeof(IFPNFMBFIIL<>.DLFHDMGJNIJ.<<BuildConfigMenuInternal>b__7>d))]
			internal void JIJNJKLHHBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x65F18C0", Offset = "0x65F0CC0", VA = "0x1865F18C0")]
			internal bool CLGLLFKFENF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class EIGFBLKFCAI
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
				public EIGFBLKFCAI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x3E575B0", Offset = "0x3E569B0", VA = "0x183E575B0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
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
			public DLFHDMGJNIJ CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public EIGFBLKFCAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x4281ED0", Offset = "0x42812D0", VA = "0x184281ED0")]
			internal void HDCDJCJBGOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
			internal string PLLLOFKOIMP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
			internal void HBGFIPOPPBP(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x4281E30", Offset = "0x4281230", VA = "0x184281E30")]
			[AsyncStateMachine(typeof(IFPNFMBFIIL<>.EIGFBLKFCAI.<<BuildConfigMenuInternal>b__5>d))]
			internal void CLJKEHJEAMH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class PGNCIGOCDEC
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
				public PGNCIGOCDEC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x3E570E0", Offset = "0x3E564E0", VA = "0x183E570E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
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
				public PGNCIGOCDEC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				private TaskAwaiter<AEAAIINGJNL<EECNAGIPCBM<GFAOCBCKMMM>, GJDNFLPCNNP>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x3E572C0", Offset = "0x3E566C0", VA = "0x183E572C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
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
				public PGNCIGOCDEC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				private TaskAwaiter<AEAAIINGJNL<EECNAGIPCBM<FPPJALEEIOP>, GJDNFLPCNNP>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x3E56A20", Offset = "0x3E55E20", VA = "0x183E56A20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000172")]
				[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public IFPNFMBFIIL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public EECNAGIPCBM<NBDDIELADOM> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public ALEICLAOMCP configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public LCCAOFCLIML nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public PGCCEHDKJMM selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public List<ONHJBOCCDFO> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public PGCCEHDKJMM selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public List<ONHJBOCCDFO> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public PGNCIGOCDEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x52D5650", Offset = "0x52D4A50", VA = "0x1852D5650")]
			internal bool MGNMGGNJBGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x52D5430", Offset = "0x52D4830", VA = "0x1852D5430")]
			internal void HMPKDBDMFGO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x52D5770", Offset = "0x52D4B70", VA = "0x1852D5770")]
			internal bool NPCNNJDJCKB(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x52D52D0", Offset = "0x52D46D0", VA = "0x1852D52D0")]
			internal bool DLKOFPHAAJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x52D54A0", Offset = "0x52D48A0", VA = "0x1852D54A0")]
			[AsyncStateMachine(typeof(IFPNFMBFIIL<>.PGNCIGOCDEC.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void HPHCMJDGCCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x52D5310", Offset = "0x52D4710", VA = "0x1852D5310")]
			internal bool EKKJIKFGGPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x52D57E0", Offset = "0x52D4BE0", VA = "0x1852D57E0")]
			internal void OBOKPOFGHNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x52D56C0", Offset = "0x52D4AC0", VA = "0x1852D56C0")]
			internal bool NCKCGFJKOND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x52D5060", Offset = "0x52D4460", VA = "0x1852D5060")]
			internal void BCKDKGFOCBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x52D5120", Offset = "0x52D4520", VA = "0x1852D5120")]
			internal bool BHIODCEIJDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x52D4FF0", Offset = "0x52D43F0", VA = "0x1852D4FF0")]
			internal bool ADAPMNLBBIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x52D55E0", Offset = "0x52D49E0", VA = "0x1852D55E0")]
			internal void MEKCPFEGAJN(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x52D5540", Offset = "0x52D4940", VA = "0x1852D5540")]
			[AsyncStateMachine(typeof(IFPNFMBFIIL<>.PGNCIGOCDEC.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void KJDOAJNJKHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x52D51D0", Offset = "0x52D45D0", VA = "0x1852D51D0")]
			internal bool CANEJADPAHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x52D5350", Offset = "0x52D4750", VA = "0x1852D5350")]
			internal bool FDDCBAFBGEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x52D53C0", Offset = "0x52D47C0", VA = "0x1852D53C0")]
			internal void GOBEPHLPEKM(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x52D5230", Offset = "0x52D4630", VA = "0x1852D5230")]
			[AsyncStateMachine(typeof(IFPNFMBFIIL<>.PGNCIGOCDEC.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void CHDLJLFFJNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x52D58A0", Offset = "0x52D4CA0", VA = "0x1852D58A0")]
			internal bool POMPFLGLGBL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class BJOOLPICAOL
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
				public BJOOLPICAOL <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0x3E56D10", Offset = "0x3E56110", VA = "0x183E56D10", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
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
			public PGNCIGOCDEC CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public BJOOLPICAOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x5D664A0", Offset = "0x5D658A0", VA = "0x185D664A0")]
			internal void DHGGDNJHBCD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
			internal string ICIMBFJAKGC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
			internal void GOFPANFKJMM(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x5D66840", Offset = "0x5D65C40", VA = "0x185D66840")]
			[AsyncStateMachine(typeof(IFPNFMBFIIL<>.BJOOLPICAOL.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void PGOFPAIMLLH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class HCNLMKPNFNI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public LCCAOFCLIML nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public List<ONHJBOCCDFO> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public IFPNFMBFIIL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public EECNAGIPCBM<NBDDIELADOM> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public HCNLMKPNFNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x4878000", Offset = "0x4877400", VA = "0x184878000")]
			internal bool JHEGFMDJOJA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class MNPOPEOCNHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public KALOLKFHOKO port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public HCNLMKPNFNI CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public MNPOPEOCNHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4FA3FC0", Offset = "0x4FA33C0", VA = "0x184FA3FC0")]
			internal void GHKGJONLEOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4FA3F70", Offset = "0x4FA3370", VA = "0x184FA3F70")]
			internal bool BOOFHDCCLCP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x4FA40D0", Offset = "0x4FA34D0", VA = "0x184FA40D0")]
			internal void MDJDEBFIPGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4FA41F0", Offset = "0x4FA35F0", VA = "0x184FA41F0")]
			internal bool OLCHPJPOPMK()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class PJHHMPAJEGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public ONHJBOCCDFO portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public MNPOPEOCNHJ CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public PJHHMPAJEGO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x52E2FA0", Offset = "0x52E23A0", VA = "0x1852E2FA0")]
			internal void HKHLFPHNKLC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class PDCAOCGLPIO
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
				public PDCAOCGLPIO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000189")]
				[Cpp2IlInjected.Address(RVA = "0x3E58D60", Offset = "0x3E58160", VA = "0x183E58D60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018A")]
				[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
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
			public PGCCEHDKJMM selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public LCCAOFCLIML nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public KALOLKFHOKO port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public PDCAOCGLPIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x52C86B0", Offset = "0x52C7AB0", VA = "0x1852C86B0")]
			internal int MKGCENBCBNA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x52C8470", Offset = "0x52C7870", VA = "0x1852C8470")]
			internal void HMFPMCFFEBK(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450")]
			internal string NILIBMNOBDJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x52C83B0", Offset = "0x52C77B0", VA = "0x1852C83B0")]
			[AsyncStateMachine(typeof(IFPNFMBFIIL<>.PDCAOCGLPIO.<<CreatePortItemV2>b__3>d))]
			internal void FEPFAMGOAFH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x52C86F0", Offset = "0x52C7AF0", VA = "0x1852C86F0")]
			internal bool OGJHHIDMMEC(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly Dictionary<EECNAGIPCBM<NBDDIELADOM>, bool> NMOHMDFJDKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly Dictionary<EECNAGIPCBM<NBDDIELADOM>, bool> EHFJDIFPKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly Dictionary<EECNAGIPCBM<NBDDIELADOM>, bool> ODGHOFCLIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private Dictionary<EECNAGIPCBM<NBDDIELADOM>, bool> KJHFPPFPCJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<EECNAGIPCBM<NBDDIELADOM>, bool> NCMNAOEGMMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private Dictionary<EECNAGIPCBM<NBDDIELADOM>, bool> HMPPNIBPHPN;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool AMMOJKFIBGM
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool IHODAHANFCE
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool AHGJPAIDCOH
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected virtual bool KPBDFMDHJJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "142")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override EECNAGIPCBM<JJJHHLABGOM>? IABJJLHODDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x49C9310", Offset = "0x49C8710", VA = "0x1849C9310", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override EECNAGIPCBM<NBDDIELADOM>? BMLGFEBOKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x49C95C0", Offset = "0x49C89C0", VA = "0x1849C95C0", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override IEnumerable<IEBAHENHLEA<DJONKGBCHFD>>? AGOHNBBJCEL
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x49C93C0", Offset = "0x49C87C0", VA = "0x1849C93C0", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x49C90F0", Offset = "0x49C84F0", VA = "0x1849C90F0")]
		public IFPNFMBFIIL(DJHNEBOJMKB EGMIBAJCGJC, TNode JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "143")]
		protected virtual bool BENGPJMHLCD(int JDFACDHHANI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "144")]
		protected virtual bool MHPJOLAOBJL(int JDFACDHHANI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "145")]
		protected virtual bool EPODGEJJDPB(int JDFACDHHANI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "146")]
		protected virtual void LMPPAGADPNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x49C8CB0", Offset = "0x49C80B0", VA = "0x1849C8CB0", Slot = "138")]
		public override bool LHPOHLBIOMM(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x49C71A0", Offset = "0x49C65A0", VA = "0x1849C71A0", Slot = "114")]
		[AsyncStateMachine(typeof(IFPNFMBFIIL<>.HAGDAHMNEAH))]
		public override Task<AEAAIINGJNL<EECNAGIPCBM<NBDDIELADOM>, GJDNFLPCNNP>> GJJMDKBOHHL(string MPGDCPPMNJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x49C4BC0", Offset = "0x49C3FC0", VA = "0x1849C4BC0", Slot = "115")]
		[AsyncStateMachine(typeof(IFPNFMBFIIL<>.BNEBKHDGHCA))]
		public override Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> DOIMEGCHPLA(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x49C8E50", Offset = "0x49C8250", VA = "0x1849C8E50", Slot = "116")]
		public override void MMBAAJBHGKA(EECNAGIPCBM<NBDDIELADOM> KDCAMOIGIMA, EECNAGIPCBM<NBDDIELADOM> JMBMDICGCNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x49C4960", Offset = "0x49C3D60", VA = "0x1849C4960", Slot = "117")]
		public override IEnumerable<IJHNHGOIIEG> CPMAMODKMMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x49C8D50", Offset = "0x49C8150", VA = "0x1849C8D50")]
		[AsyncStateMachine(typeof(IFPNFMBFIIL<>.BMJENFGEEOH))]
		private Task<AEAAIINGJNL<AJEHNEOFKOC, GJDNFLPCNNP>> LPGBIEPFELM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "147")]
		protected virtual bool EPHLPENFPGK(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "148")]
		protected virtual bool ELEMHDIKGAE(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "149")]
		protected virtual bool DEFOPLIEPEA(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "150")]
		protected virtual bool NANDCKLHIAG(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "151")]
		protected virtual bool NEHIFPKLDLB(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, int DADECMGLJAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "152")]
		protected virtual bool ILDAKNCGIOB(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, int DADECMGLJAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "153")]
		protected virtual bool EKEFLKEBBDM(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, int DEIGKPKAELB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "154")]
		protected virtual bool LBCNNNOINDI(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, int DEIGKPKAELB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "155")]
		protected virtual bool BKOADBJLAFM(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, int FEFGMNOLHFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "156")]
		protected virtual bool NLBHJHFAIBC(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, int DLNGNEBLCOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x49C8A10", Offset = "0x49C7E10", VA = "0x1849C8A10", Slot = "157")]
		protected virtual List<PGCCEHDKJMM> IOJFHDIOJFA(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "158")]
		protected virtual void BGKOKGJBIKL(ALEICLAOMCP BEGAPFGOGEG, IHHLOOFNCPC JBBNLMGMAMF, LCCAOFCLIML CNALIJJILKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x49C5620", Offset = "0x49C4A20", VA = "0x1849C5620", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x49C72C0", Offset = "0x49C66C0", VA = "0x1849C72C0")]
		private IHHLOOFNCPC HKLGCMAMJJC(ALEICLAOMCP BEGAPFGOGEG, LCCAOFCLIML CNALIJJILKN, EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x49C6080", Offset = "0x49C5480", VA = "0x1849C6080")]
		private List<ONHJBOCCDFO> GIJLCLBGOME(ALEICLAOMCP BEGAPFGOGEG, LCCAOFCLIML CNALIJJILKN, IHHLOOFNCPC AMOEHJOIEPH, bool NNIOOLEBNGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x49C4CD0", Offset = "0x49C40D0", VA = "0x1849C4CD0")]
		private List<ONHJBOCCDFO> EHPJLLGHHKJ(ALEICLAOMCP BEGAPFGOGEG, LCCAOFCLIML CNALIJJILKN, KALOLKFHOKO MDPDGBLOFCH, bool NNIOOLEBNGG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x49C4770", Offset = "0x49C3B70", VA = "0x1849C4770")]
		private PGCCEHDKJMM CDCDIBMMHDL(List<PGCCEHDKJMM> MOEBCAGKOGH, KALOLKFHOKO MDPDGBLOFCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x49C9060", Offset = "0x49C8460", VA = "0x1849C9060")]
		[CompilerGenerated]
		private IJHNHGOIIEG ODDBBFKIDLJ(BPKOHJDNEKO EAOFLAGMNJO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class NFPHNGINHIE : PLKGMELDIMJ<CEAFLBBEECJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class EPBIDDJPOLI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public NFPHNGINHIE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public EPBIDDJPOLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x2604AC0", Offset = "0x2603EC0", VA = "0x182604AC0")]
			internal int EGBBPMAANLH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x2604A30", Offset = "0x2603E30", VA = "0x182604A30")]
			internal void CLGLLFKFENF(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xFAEEF0", Offset = "0xFAE2F0", VA = "0x180FAEEF0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x260E3C0", Offset = "0x260D7C0", VA = "0x18260E3C0")]
		public NFPHNGINHIE(DJHNEBOJMKB EGMIBAJCGJC, CEAFLBBEECJ JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x260E200", Offset = "0x260D600", VA = "0x18260E200", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class HJHMKBLLJMG : FHOENDLGMDB<OALCHMGKPKF>
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private sealed class OBPDMAOHGKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public HJHMKBLLJMG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public OBPDMAOHGKO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x260EDE0", Offset = "0x260E1E0", VA = "0x18260EDE0")]
			internal int HNBFOOJPLBC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x260EE60", Offset = "0x260E260", VA = "0x18260EE60")]
			internal void JGIJDKFFJHI(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2606850", Offset = "0x2605C50", VA = "0x182606850")]
		public HJHMKBLLJMG(DJHNEBOJMKB EGMIBAJCGJC, OALCHMGKPKF KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2606610", Offset = "0x2605A10", VA = "0x182606610", Slot = "140")]
		protected override void DMEODAIMGHO(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private sealed class LPEDKAJHCHJ : PLKGMELDIMJ<HKHGDNIPFNB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xCF66A0", Offset = "0xCF5AA0", VA = "0x180CF66A0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x260CAD0", Offset = "0x260BED0", VA = "0x18260CAD0")]
		public LPEDKAJHCHJ(DJHNEBOJMKB EGMIBAJCGJC, HKHGDNIPFNB JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class PPHLMMONIMH : PLKGMELDIMJ<IADKOJIEIJH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class DBAHEFIDMOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public PPHLMMONIMH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public ALEICLAOMCP configure;

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
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public DBAHEFIDMOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x25F8FE0", Offset = "0x25F83E0", VA = "0x1825F8FE0")]
			internal bool EGBBPMAANLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x25F88C0", Offset = "0x25F7CC0", VA = "0x1825F88C0")]
			internal void CLGLLFKFENF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x25F9F50", Offset = "0x25F9350", VA = "0x1825F9F50")]
			internal bool HBGFIPOPPBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x25F8920", Offset = "0x25F7D20", VA = "0x1825F8920")]
			internal bool CLJKEHJEAMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x25FBD00", Offset = "0x25FB100", VA = "0x1825FBD00")]
			internal void NJKGPCFLDDO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x25FAF90", Offset = "0x25FA390", VA = "0x1825FAF90")]
			internal bool KCBANGHNAMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x25FB750", Offset = "0x25FAB50", VA = "0x1825FB750")]
			internal bool MDCFNOKCEPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x25FA980", Offset = "0x25F9D80", VA = "0x1825FA980")]
			internal void IMCMHAOBEMM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x2602680", Offset = "0x2601A80", VA = "0x182602680")]
			internal bool PMENACMHJBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x25F9B60", Offset = "0x25F8F60", VA = "0x1825F9B60")]
			internal bool FMLPKIGIICM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x25FAE90", Offset = "0x25FA290", VA = "0x1825FAE90")]
			internal void JOCHCKBMLPE(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x25FC000", Offset = "0x25FB400", VA = "0x1825FC000")]
			internal bool OFCHGKJPKNG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x25FAAA0", Offset = "0x25F9EA0", VA = "0x1825FAAA0")]
			internal bool IMPFKEIEKOE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x25F9B10", Offset = "0x25F8F10", VA = "0x1825F9B10")]
			internal bool FMHKEOABGGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x25FB2E0", Offset = "0x25FA6E0", VA = "0x1825FB2E0")]
			internal bool KOJBNMEMHIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x25F8820", Offset = "0x25F7C20", VA = "0x1825F8820")]
			internal bool CIDPNHDJEIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x25FB450", Offset = "0x25FA850", VA = "0x1825FB450")]
			internal bool LGLJDJIPNEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x25FBA80", Offset = "0x25FAE80", VA = "0x1825FBA80")]
			internal bool MMMOLJEKGKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x25F7B10", Offset = "0x25F6F10", VA = "0x1825F7B10")]
			internal bool ADDFHFFFCFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x25F80F0", Offset = "0x25F74F0", VA = "0x1825F80F0")]
			internal bool BHDJHPDJAMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x25FA1D0", Offset = "0x25F95D0", VA = "0x1825FA1D0")]
			internal void HJHKJCLJAEL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x25FA6B0", Offset = "0x25F9AB0", VA = "0x1825FA6B0")]
			internal bool IFHFNIMNELC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x25F90D0", Offset = "0x25F84D0", VA = "0x1825F90D0")]
			internal bool EJCCBHMEDIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x25FC0B0", Offset = "0x25FB4B0", VA = "0x1825FC0B0")]
			internal bool OFFDFKOCJEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x25FA280", Offset = "0x25F9680", VA = "0x1825FA280")]
			internal bool HLBFFFPGCMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x25F82E0", Offset = "0x25F76E0", VA = "0x1825F82E0")]
			internal bool BNNHNDMHLJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x25FA230", Offset = "0x25F9630", VA = "0x1825FA230")]
			internal bool HJPJOCIJFMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x25FB7A0", Offset = "0x25FABA0", VA = "0x1825FB7A0")]
			internal bool MDFOAAINACM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x25F8EB0", Offset = "0x25F82B0", VA = "0x1825F8EB0")]
			internal bool DOEGJCFABDB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x25FC050", Offset = "0x25FB450", VA = "0x1825FC050")]
			internal void OFDNCNCOOGP(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x25FA700", Offset = "0x25F9B00", VA = "0x1825FA700")]
			internal bool IFIPLIKHDPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x25F7F10", Offset = "0x25F7310", VA = "0x1825F7F10")]
			internal bool APFKMGFMLGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x25FB4A0", Offset = "0x25FA8A0", VA = "0x1825FB4A0")]
			internal void LHCIDPFCCBN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x25F8D00", Offset = "0x25F8100", VA = "0x1825F8D00")]
			internal bool DJJPLMBIEAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x25FA320", Offset = "0x25F9720", VA = "0x1825FA320")]
			internal bool HLPCCOKKDBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x25F81E0", Offset = "0x25F75E0", VA = "0x1825F81E0")]
			internal void BJOLFGOKHGO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x25FC1A0", Offset = "0x25FB5A0", VA = "0x1825FC1A0")]
			internal List<ONHJBOCCDFO> OKEDIOGKMHJ(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x25FBA30", Offset = "0x25FAE30", VA = "0x1825FBA30")]
			internal bool MLGLGIHCJHJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x25F89C0", Offset = "0x25F7DC0", VA = "0x1825F89C0")]
			internal int CMOEJINAMNA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x25F9E50", Offset = "0x25F9250", VA = "0x1825F9E50")]
			internal void GPIKDCLMNIF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x25F8AB0", Offset = "0x25F7EB0", VA = "0x1825F8AB0")]
			internal bool DAHJFABMNKL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x25FAC40", Offset = "0x25FA040", VA = "0x1825FAC40")]
			internal bool JGFDLPCEHPM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x25F7F60", Offset = "0x25F7360", VA = "0x1825F7F60")]
			internal bool BEBANPDDBOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x2602380", Offset = "0x2601780", VA = "0x182602380")]
			internal int PCMJMNCKDNB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x25FA120", Offset = "0x25F9520", VA = "0x1825FA120")]
			internal void HHIFOLOJGEF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x25FAEF0", Offset = "0x25FA2F0", VA = "0x1825FAEF0")]
			internal bool KADCMAPDMME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x25FBF10", Offset = "0x25FB310", VA = "0x1825FBF10")]
			internal bool NOMPHBPDDIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x25F7C70", Offset = "0x25F7070", VA = "0x1825F7C70")]
			internal bool AHMEFELPKDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x25FA500", Offset = "0x25F9900", VA = "0x1825FA500")]
			internal bool IBBHFJHBBKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x25FB500", Offset = "0x25FA900", VA = "0x1825FB500")]
			internal bool LHHMGOMLFID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x25F9310", Offset = "0x25F8710", VA = "0x1825F9310")]
			internal bool EMBLPOCCHNC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x25F8A10", Offset = "0x25F7E10", VA = "0x1825F8A10")]
			internal string COBLOODEIDI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x25F9360", Offset = "0x25F8760", VA = "0x1825F9360")]
			internal void EMGJGFENGIM(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x25F93D0", Offset = "0x25F87D0", VA = "0x1825F93D0")]
			internal int ENIAOHDHBEO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x25FAAF0", Offset = "0x25F9EF0", VA = "0x1825FAAF0")]
			internal void IPADKINCFKA(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x25FB610", Offset = "0x25FAA10", VA = "0x1825FB610")]
			internal bool LLJPJILDEHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x25F8870", Offset = "0x25F7C70", VA = "0x1825F8870")]
			internal bool CLCBDGGIPNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x25F9D50", Offset = "0x25F9150", VA = "0x1825F9D50")]
			internal bool GIIEFGMDKEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x25F8C10", Offset = "0x25F8010", VA = "0x1825F8C10")]
			internal float DBJLMADNODN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x25F9DF0", Offset = "0x25F91F0", VA = "0x1825F9DF0")]
			internal void GLHHMFPOGDB(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x25FA5A0", Offset = "0x25F99A0", VA = "0x1825FA5A0")]
			internal bool IDDALFKOLIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x25FA030", Offset = "0x25F9430", VA = "0x1825FA030")]
			internal bool HCFFLLFGAKJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x25FA4B0", Offset = "0x25F98B0", VA = "0x1825FA4B0")]
			internal bool IBAICDHHCOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x25F8140", Offset = "0x25F7540", VA = "0x1825F8140")]
			internal bool BIMOEHFAMAM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x25F9120", Offset = "0x25F8520", VA = "0x1825F9120")]
			internal bool EJDHBJBACHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x25FBE70", Offset = "0x25FB270", VA = "0x1825FBE70")]
			internal bool NNNJGDKPIOD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x25F9510", Offset = "0x25F8910", VA = "0x1825F9510")]
			internal void FDENFMGPABD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x25F9C00", Offset = "0x25F9000", VA = "0x1825F9C00")]
			internal string GAMKFDOKNHB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x25FA9E0", Offset = "0x25F9DE0", VA = "0x1825FA9E0")]
			internal void IMOCILOFLMP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x25FA0D0", Offset = "0x25F94D0", VA = "0x1825FA0D0")]
			internal bool HHAFCIOBGIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x25FB700", Offset = "0x25FAB00", VA = "0x1825FB700")]
			internal bool MCJAIJGFANM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x25F9420", Offset = "0x25F8820", VA = "0x1825F9420")]
			internal bool ENNPOBGCBKG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x25F8510", Offset = "0x25F7910", VA = "0x1825F8510")]
			internal void CGEABHJEBOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x25F8290", Offset = "0x25F7690", VA = "0x1825F8290")]
			internal bool BNAEHDCIINF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x25FB1F0", Offset = "0x25FA5F0", VA = "0x1825FB1F0")]
			internal bool KMFMEODGNPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x25F9DA0", Offset = "0x25F91A0", VA = "0x1825F9DA0")]
			internal bool GIJMEGDBPAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x26024E0", Offset = "0x26018E0", VA = "0x1826024E0")]
			internal bool PJHPDLKAMGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x25F91C0", Offset = "0x25F85C0", VA = "0x1825F91C0")]
			internal void EKGBMCJINJC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x25F80A0", Offset = "0x25F74A0", VA = "0x1825F80A0")]
			internal bool BGNDDFBNJON()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x25F9220", Offset = "0x25F8620", VA = "0x1825F9220")]
			internal bool ELDFGFGHMIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x25FA930", Offset = "0x25F9D30", VA = "0x1825FA930")]
			internal bool IJOLLCAFBGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x2602720", Offset = "0x2601B20", VA = "0x182602720")]
			internal bool POLGABDIPKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x25F9910", Offset = "0x25F8D10", VA = "0x1825F9910")]
			internal void FHJNMBMGFBG(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x25F8E60", Offset = "0x25F8260", VA = "0x1825F8E60")]
			internal bool DODGIGFGAIL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x25F7AC0", Offset = "0x25F6EC0", VA = "0x1825F7AC0")]
			internal bool AAAILLCCCND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x25FA550", Offset = "0x25F9950", VA = "0x1825FA550")]
			internal bool IBLNIMAJODN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x25F7BD0", Offset = "0x25F6FD0", VA = "0x1825F7BD0")]
			internal bool ADILCKGMADK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x25FAE20", Offset = "0x25FA220", VA = "0x1825FAE20")]
			internal object JLNNIGIMGGK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x25FA8A0", Offset = "0x25F9CA0", VA = "0x1825FA8A0")]
			internal void IJGKIOMIACM(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x25FC150", Offset = "0x25FB550", VA = "0x1825FC150")]
			internal bool OJAFJHOPBHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x25FA3C0", Offset = "0x25F97C0", VA = "0x1825FA3C0")]
			internal bool HNCHAIKJNLP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x2602290", Offset = "0x2601690", VA = "0x182602290")]
			internal int ONDKOBDHNOG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x25FB9D0", Offset = "0x25FADD0", VA = "0x1825FB9D0")]
			internal void MJEHIBLMKNE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x25FAFE0", Offset = "0x25FA3E0", VA = "0x1825FAFE0")]
			internal bool KCNMGBMJPGE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x25FAF40", Offset = "0x25FA340", VA = "0x1825FAF40")]
			internal bool KBJBFDKAMKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x25F8C60", Offset = "0x25F8060", VA = "0x1825F8C60")]
			internal int DEIIPMODDPI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x25FB550", Offset = "0x25FA950", VA = "0x1825FB550")]
			internal void LJKILNIDHCB(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x25FAC90", Offset = "0x25FA090", VA = "0x1825FAC90")]
			internal bool JHIINAGMGLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x25F9AC0", Offset = "0x25F8EC0", VA = "0x1825F9AC0")]
			internal bool FLCIJMHOCEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x25FB850", Offset = "0x25FAC50", VA = "0x1825FB850")]
			internal bool MFFFPMOGLCJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x25FB330", Offset = "0x25FA730", VA = "0x1825FB330")]
			internal int KPEGJCMINBA()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x25FB120", Offset = "0x25FA520", VA = "0x1825FB120")]
			internal void KHDMCOLACGH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x25F9CB0", Offset = "0x25F90B0", VA = "0x1825F9CB0")]
			internal bool GDKBDJIKJJC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x25F8B50", Offset = "0x25F7F50", VA = "0x1825F8B50")]
			internal bool DAPHKIIJLIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x25F7E70", Offset = "0x25F7270", VA = "0x1825F7E70")]
			internal bool AOIGHKHBBNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x25FB960", Offset = "0x25FAD60", VA = "0x1825FB960")]
			internal object MGHNKJDCBPN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x26025F0", Offset = "0x26019F0", VA = "0x1826025F0")]
			internal void PLLMDJEBPMM(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x25FAA50", Offset = "0x25F9E50", VA = "0x1825FAA50")]
			internal bool IMPCNBHJFPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x25FBCB0", Offset = "0x25FB0B0", VA = "0x1825FBCB0")]
			internal bool NFPCGKJCKHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x25F7D10", Offset = "0x25F7110", VA = "0x1825F7D10")]
			internal object ALNDHAEGHEJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x25F9FA0", Offset = "0x25F93A0", VA = "0x1825F9FA0")]
			internal void HCCLAFOBICG(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x25FAD30", Offset = "0x25FA130", VA = "0x1825FAD30")]
			internal bool JLEHDDJNDLN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x25F8330", Offset = "0x25F7730", VA = "0x1825F8330")]
			internal int BONLGAMHDOL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x25FB5B0", Offset = "0x25FA9B0", VA = "0x1825FB5B0")]
			internal void LKBGAFHFCFH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x25F9030", Offset = "0x25F8430", VA = "0x1825F9030")]
			internal bool EHENDBFNIPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x25FABA0", Offset = "0x25F9FA0", VA = "0x1825FABA0")]
			internal bool JDGIFJBKBDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x25F9970", Offset = "0x25F8D70", VA = "0x1825F9970")]
			internal bool FHKAMELGLPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x26026D0", Offset = "0x2601AD0", VA = "0x1826026D0")]
			internal int POGEKPGCLKM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x25F99C0", Offset = "0x25F8DC0", VA = "0x1825F99C0")]
			internal void FIIHEMBHBKJ(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x26023D0", Offset = "0x26017D0", VA = "0x1826023D0")]
			internal bool PIDDDFCHAJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x25FB240", Offset = "0x25FA640", VA = "0x1825FB240")]
			internal bool KMJBMNIFOMD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x25F8470", Offset = "0x25F7870", VA = "0x1825F8470")]
			internal bool CCIKGHPGOEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x25FA5F0", Offset = "0x25F99F0", VA = "0x1825FA5F0")]
			internal float IFCHLMOLPMH()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x25FB7F0", Offset = "0x25FABF0", VA = "0x1825FB7F0")]
			internal void MEOOGPDCFMK(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x25FAD80", Offset = "0x25FA180", VA = "0x1825FAD80")]
			internal bool JLJBLIBGNNP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x25FA7F0", Offset = "0x25F9BF0", VA = "0x1825FA7F0")]
			internal bool IHFCMBDEIDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x25FBB70", Offset = "0x25FAF70", VA = "0x1825FBB70")]
			internal bool NADDMOJJNCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x25F9D00", Offset = "0x25F9100", VA = "0x1825F9D00")]
			internal float GFNGOELCPIL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x25FB380", Offset = "0x25FA780", VA = "0x1825FB380")]
			internal void LFKAECHPDOC(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x25F7FB0", Offset = "0x25F73B0", VA = "0x1825F7FB0")]
			internal bool BEEFNCEJAPN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x25FA410", Offset = "0x25F9810", VA = "0x1825FA410")]
			internal bool HPHHADIAPBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x25F94C0", Offset = "0x25F88C0", VA = "0x1825F94C0")]
			internal string FAOECHIGFIP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x25FBD60", Offset = "0x25FB160", VA = "0x1825FBD60")]
			internal void NKAKKOGKHAL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x25F8050", Offset = "0x25F7450", VA = "0x1825F8050")]
			internal bool BFMBCHPCIBF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x2602490", Offset = "0x2601890", VA = "0x182602490")]
			internal bool PIPDCHAKAGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x25F83D0", Offset = "0x25F77D0", VA = "0x1825F83D0")]
			internal bool CBDADAENEMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x25F8DC0", Offset = "0x25F81C0", VA = "0x1825F8DC0")]
			internal bool DNGNLHFFGBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x25FB660", Offset = "0x25FAA60", VA = "0x1825FB660")]
			internal string LMLIGPBFEBK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x25F8F70", Offset = "0x25F8370", VA = "0x1825F8F70")]
			internal void EBGBBGHAEFP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x25F9A20", Offset = "0x25F8E20", VA = "0x1825F9A20")]
			internal bool FILDKDDAFNF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x2602330", Offset = "0x2601730", VA = "0x182602330")]
			internal bool OOGEKLIHCEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x25FBE20", Offset = "0x25FB220", VA = "0x1825FBE20")]
			internal bool NLPFFDOAOCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x25FABF0", Offset = "0x25F9FF0", VA = "0x1825FABF0")]
			internal bool JDGKHKHPDDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x25FA2D0", Offset = "0x25F96D0", VA = "0x1825FA2D0")]
			internal string HLEOPCPKKOB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x2602420", Offset = "0x2601820", VA = "0x182602420")]
			internal void PIJAPKHOKAN(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x25FB080", Offset = "0x25FA480", VA = "0x1825FB080")]
			internal bool KFPJPDCFGOH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x25F7D80", Offset = "0x25F7180", VA = "0x1825F7D80")]
			internal bool AMBJMLIPNPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x25FBEC0", Offset = "0x25FB2C0", VA = "0x1825FBEC0")]
			internal bool NOAPAMKOCDN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x26022E0", Offset = "0x26016E0", VA = "0x1826022E0")]
			internal bool ONDMLHOIEBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x25F98C0", Offset = "0x25F8CC0", VA = "0x1825F98C0")]
			internal string FHHFOPKMBIF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x25F7B60", Offset = "0x25F6F60", VA = "0x1825F7B60")]
			internal void ADIBHDIBFOO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x25F7EC0", Offset = "0x25F72C0", VA = "0x1825F7EC0")]
			internal bool AOOKANODHEA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x25F8190", Offset = "0x25F7590", VA = "0x1825F8190")]
			internal bool BJMLPDOELEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x25FAB50", Offset = "0x25F9F50", VA = "0x1825FAB50")]
			internal bool IPOBDPIAHOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x25FBFB0", Offset = "0x25FB3B0", VA = "0x1825FBFB0")]
			internal bool ODMIJHEPGNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x25FBAD0", Offset = "0x25FAED0", VA = "0x1825FBAD0")]
			internal string MNFPKALCEHE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x26021D0", Offset = "0x26015D0", VA = "0x1826021D0")]
			internal void OLOFHPGCDDJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x25FACE0", Offset = "0x25FA0E0", VA = "0x1825FACE0")]
			internal bool JKPMMPFOMPB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x2602530", Offset = "0x2601930", VA = "0x182602530")]
			internal bool PJIJACMIGBL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x25FBDD0", Offset = "0x25FB1D0", VA = "0x1825FBDD0")]
			internal bool NKNHIOFPCEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x25FA080", Offset = "0x25F9480", VA = "0x1825FA080")]
			internal bool HFOLKHCFMKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x25F8CB0", Offset = "0x25F80B0", VA = "0x1825F8CB0")]
			internal string DHGJEMPKGCC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x2602580", Offset = "0x2601980", VA = "0x182602580")]
			internal void PLBKHMOADOG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x25F92C0", Offset = "0x25F86C0", VA = "0x1825F92C0")]
			internal bool ELPEBILAJIG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x25F84C0", Offset = "0x25F78C0", VA = "0x1825F84C0")]
			internal bool CFOCJKFAOGN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x25F7DD0", Offset = "0x25F71D0", VA = "0x1825F7DD0")]
			internal bool AMLCEGOILBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x25FBC10", Offset = "0x25FB010", VA = "0x1825FBC10")]
			internal bool NEFMIHLEKPA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x25F9470", Offset = "0x25F8870", VA = "0x1825F9470")]
			internal string EOADDOILHAG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x25FB8A0", Offset = "0x25FACA0", VA = "0x1825FB8A0")]
			internal void MFHCKAOGBPL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x25F9EB0", Offset = "0x25F92B0", VA = "0x1825F9EB0")]
			internal bool HAELLEGPKFJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x25F7C20", Offset = "0x25F7020", VA = "0x1825F7C20")]
			internal bool AFLEICPKEFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x25FA370", Offset = "0x25F9770", VA = "0x1825FA370")]
			internal bool HNACBNJNIGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x25FADD0", Offset = "0x25FA1D0", VA = "0x1825FADD0")]
			internal bool JLLAAJEIDCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x25F9270", Offset = "0x25F8670", VA = "0x1825F9270")]
			internal string ELHBMAIBCLA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x25FA640", Offset = "0x25F9A40", VA = "0x1825FA640")]
			internal void IFCMAMAECKI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x25FBF60", Offset = "0x25FB360", VA = "0x1825FBF60")]
			internal bool OBFMOLFLEDG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x25FB910", Offset = "0x25FAD10", VA = "0x1825FB910")]
			internal bool MGGEGFAPGIN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x25FA180", Offset = "0x25F9580", VA = "0x1825FA180")]
			internal bool HHKMHCEKHND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x25FA750", Offset = "0x25F9B50", VA = "0x1825FA750")]
			internal bool IGBJDCPMJKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x25F8970", Offset = "0x25F7D70", VA = "0x1825F8970")]
			internal string CMCBIKCHLEN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x25F8F00", Offset = "0x25F8300", VA = "0x1825F8F00")]
			internal void EACHCLFEGJP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x2602770", Offset = "0x2601B70", VA = "0x182602770")]
			internal bool POMJFLLLGHO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x25F8A60", Offset = "0x25F7E60", VA = "0x1825F8A60")]
			internal bool CPJLBLFIOOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x25F8420", Offset = "0x25F7820", VA = "0x1825F8420")]
			internal bool CCEKPNPDAEF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x25F9080", Offset = "0x25F8480", VA = "0x1825F9080")]
			internal bool EHPCMBIEAFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x25F8380", Offset = "0x25F7780", VA = "0x1825F8380")]
			internal string CAPNBMHDABF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x25F8D50", Offset = "0x25F8150", VA = "0x1825F8D50")]
			internal void DJNKOFMGGGF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x25FB290", Offset = "0x25FA690", VA = "0x1825FB290")]
			internal bool KMLDEAGDONL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x25F7E20", Offset = "0x25F7220", VA = "0x1825F7E20")]
			internal bool AOHAHFLODHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x25FC100", Offset = "0x25FB500", VA = "0x1825FC100")]
			internal bool OFIEKIFFENO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x25F8E10", Offset = "0x25F8210", VA = "0x1825F8E10")]
			internal string DNGNPAJKLMB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x25FB180", Offset = "0x25FA580", VA = "0x1825FB180")]
			internal void KLANAKGCNEF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x25FBB20", Offset = "0x25FAF20", VA = "0x1825FBB20")]
			internal bool MNGGMKHBOIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x25F7CC0", Offset = "0x25F70C0", VA = "0x1825F7CC0")]
			internal bool AHNBDFBEJJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x25F8B00", Offset = "0x25F7F00", VA = "0x1825F8B00")]
			internal bool DAOGBDIJEOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x25FB0D0", Offset = "0x25FA4D0", VA = "0x1825FB0D0")]
			internal string KGEAOGPKFMH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x25F8BA0", Offset = "0x25F7FA0", VA = "0x1825F8BA0")]
			internal void DBCFJFGDADF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x25F9170", Offset = "0x25F8570", VA = "0x1825F9170")]
			internal bool EKFIIMICMIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x25FBC60", Offset = "0x25FB060", VA = "0x1825FBC60")]
			internal bool NFCIPIMKKAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x25F87D0", Offset = "0x25F7BD0", VA = "0x1825F87D0")]
			internal bool CHGFOKAKLAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x25FA460", Offset = "0x25F9860", VA = "0x1825FA460")]
			internal string HPLDFFCLBEG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x25FB3E0", Offset = "0x25FA7E0", VA = "0x1825FB3E0")]
			internal void LGJGHGFMEBB(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x25F9F00", Offset = "0x25F9300", VA = "0x1825F9F00")]
			internal bool HAFLBOMDMGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x25FBBC0", Offset = "0x25FAFC0", VA = "0x1825FBBC0")]
			internal bool NBKLDMLNGDA(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x25F8000", Offset = "0x25F7400", VA = "0x1825F8000")]
			internal float BFDIFADOLAF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x25FA840", Offset = "0x25F9C40", VA = "0x1825FA840")]
			internal void IILKANBHAAF(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x25F9BB0", Offset = "0x25F8FB0", VA = "0x1825F9BB0")]
			internal bool GAIEJEBALHG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x2602240", Offset = "0x2601640", VA = "0x182602240")]
			internal bool OLPJFLAOHMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x25FB6B0", Offset = "0x25FAAB0", VA = "0x1825FB6B0")]
			internal bool LNJBCKCOGGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x25FB030", Offset = "0x25FA430", VA = "0x1825FB030")]
			internal int KFMMIIBLANL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x25F9C50", Offset = "0x25F9050", VA = "0x1825F9C50")]
			internal void GCPCJFHGGBD(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x25FA7A0", Offset = "0x25F9BA0", VA = "0x1825FA7A0")]
			internal bool IGIHBGEPGED()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x25F9A70", Offset = "0x25F8E70", VA = "0x1825F9A70")]
			internal bool FLBIEDHPEHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x25F8240", Offset = "0x25F7640", VA = "0x1825F8240")]
			internal bool BKOEFEPMCIE()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class HJFJJGIJCDK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public DBAHEFIDMOK CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public HJFJJGIJCDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x2605AD0", Offset = "0x2604ED0", VA = "0x182605AD0")]
			internal void ILINDOEFKGN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class KFPFNMJDGAM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public KFPFNMJDGAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x260BCA0", Offset = "0x260B0A0", VA = "0x18260BCA0")]
			internal bool IDFKMAOOEPF(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly DLAPHFJGCDO OGFJEOKELHO;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2613080", Offset = "0x2612480", VA = "0x182613080")]
		public PPHLMMONIMH(DJHNEBOJMKB EGMIBAJCGJC, IADKOJIEIJH JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x2611320", Offset = "0x2610720", VA = "0x182611320", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class CPHCABFBLOP : PLKGMELDIMJ<PBOGCOGOJNH>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class FMEEPKJACAF
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
				public FMEEPKJACAF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x2631020", Offset = "0x2630420", VA = "0x182631020", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A8")]
				[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public CPHCABFBLOP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public FMEEPKJACAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x2604FC0", Offset = "0x26043C0", VA = "0x182604FC0")]
			internal string EGBBPMAANLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x2604EF0", Offset = "0x26042F0", VA = "0x182604EF0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void CLGLLFKFENF(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x2605010", Offset = "0x2604410", VA = "0x182605010")]
			internal int HDCDJCJBGOC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x2605060", Offset = "0x2604460", VA = "0x182605060")]
			internal void PLLLOFKOIMP(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xFAEEF0", Offset = "0xFAE2F0", VA = "0x180FAEEF0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x25F7A50", Offset = "0x25F6E50", VA = "0x1825F7A50")]
		public CPHCABFBLOP(DJHNEBOJMKB EGMIBAJCGJC, PBOGCOGOJNH KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x25F7700", Offset = "0x25F6B00", VA = "0x1825F7700", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class CNOIGMLMJDA : PLKGMELDIMJ<HMHKHDJCMOM>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class GKFCAOLPLBE
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
				public GKFCAOLPLBE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x2630CE0", Offset = "0x26300E0", VA = "0x182630CE0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
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
				public GKFCAOLPLBE <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x2631330", Offset = "0x2630730", VA = "0x182631330", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BF")]
				[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public CNOIGMLMJDA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public GKFCAOLPLBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x2623D80", Offset = "0x2623180", VA = "0x182623D80")]
			internal string EGBBPMAANLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x2623BE0", Offset = "0x2622FE0", VA = "0x182623BE0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void CLGLLFKFENF(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x2623E20", Offset = "0x2623220", VA = "0x182623E20")]
			internal int HDCDJCJBGOC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x2624210", Offset = "0x2623610", VA = "0x182624210")]
			internal void PLLLOFKOIMP(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x2623DD0", Offset = "0x26231D0", VA = "0x182623DD0")]
			internal string HBGFIPOPPBP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x2623CB0", Offset = "0x26230B0", VA = "0x182623CB0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void CLJKEHJEAMH(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x26241C0", Offset = "0x26235C0", VA = "0x1826241C0")]
			internal bool NJKGPCFLDDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x2623FF0", Offset = "0x26233F0", VA = "0x182623FF0")]
			internal void JIJNJKLHHBH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x2623E70", Offset = "0x2623270", VA = "0x182623E70")]
			internal bool HGPJOJOAGCI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x26240E0", Offset = "0x26234E0", VA = "0x1826240E0")]
			internal void KCBANGHNAMB(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x2624170", Offset = "0x2623570", VA = "0x182624170")]
			internal float MDCFNOKCEPB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x2623F60", Offset = "0x2623360", VA = "0x182623F60")]
			internal void IMCMHAOBEMM(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x2624080", Offset = "0x2623480", VA = "0x182624080")]
			internal int JNJANBDBMIN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x2623EC0", Offset = "0x26232C0", VA = "0x182623EC0")]
			internal void IGFCFDJIBAD(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x26242A0", Offset = "0x26236A0", VA = "0x1826242A0")]
			internal bool PMENACMHJBA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xFAEEF0", Offset = "0xFAE2F0", VA = "0x180FAEEF0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x261A6E0", Offset = "0x2619AE0", VA = "0x18261A6E0")]
		public CNOIGMLMJDA(DJHNEBOJMKB EGMIBAJCGJC, HMHKHDJCMOM JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x2619C90", Offset = "0x2619090", VA = "0x182619C90", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class BGCDOAIFBNH : PLKGMELDIMJ<PKFJFPLMAIJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class NFNNKGPHEBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public BGCDOAIFBNH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public NFNNKGPHEBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x262F190", Offset = "0x262E590", VA = "0x18262F190")]
			internal Dictionary<string, FMBCGIKOAML> EGBBPMAANLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x262F140", Offset = "0x262E540", VA = "0x18262F140")]
			internal int CLGLLFKFENF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x262F230", Offset = "0x262E630", VA = "0x18262F230")]
			internal void HDCDJCJBGOC(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x262F360", Offset = "0x262E760", VA = "0x18262F360")]
			internal bool PLLLOFKOIMP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0xFAEEF0", Offset = "0xFAE2F0", VA = "0x180FAEEF0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x26183E0", Offset = "0x26177E0", VA = "0x1826183E0")]
		public BGCDOAIFBNH(DJHNEBOJMKB EGMIBAJCGJC, PKFJFPLMAIJ KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x2618110", Offset = "0x2617510", VA = "0x182618110", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class MDCNPBMDMEH : PLKGMELDIMJ<IHFBEHAFONC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class FOJOCNLBNIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public MDCNPBMDMEH <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public FOJOCNLBNIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x26216C0", Offset = "0x2620AC0", VA = "0x1826216C0")]
			internal void EGBBPMAANLH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0xFAEEF0", Offset = "0xFAE2F0", VA = "0x180FAEEF0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x262DDD0", Offset = "0x262D1D0", VA = "0x18262DDD0")]
		public MDCNPBMDMEH(DJHNEBOJMKB EGMIBAJCGJC, IHFBEHAFONC KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x262DC50", Offset = "0x262D050", VA = "0x18262DC50", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class FPHFHBLGAGJ<TNode> : IFPNFMBFIIL<TNode> where TNode : notnull, EIFMDMPGBFK
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override bool AJCKKNOCKCL
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override LEAFJKBCFMF? ODEGPDAGIGM
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x4750630", Offset = "0x474FA30", VA = "0x184750630", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool HICCCGKAEHM
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x47506E0", Offset = "0x474FAE0", VA = "0x1847506E0", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0xCE8030", Offset = "0xCE7430", VA = "0x180CE8030", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x47506A0", Offset = "0x474FAA0", VA = "0x1847506A0")]
		public FPHFHBLGAGJ(DJHNEBOJMKB EGMIBAJCGJC, TNode JOMDOBIKCNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class LDADEKHPIII : FPHFHBLGAGJ<BEMKNLNMMCD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class OEKKPKAMOPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public LDADEKHPIII <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public OEKKPKAMOPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x2630000", Offset = "0x262F400", VA = "0x182630000")]
			internal object EGBBPMAANLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x262FF30", Offset = "0x262F330", VA = "0x18262FF30")]
			internal void CLGLLFKFENF(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x2630070", Offset = "0x262F470", VA = "0x182630070")]
			internal void HDCDJCJBGOC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static object[]? LKONJADCFHK;

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x2626820", Offset = "0x2625C20", VA = "0x182626820")]
		public LDADEKHPIII(DJHNEBOJMKB EGMIBAJCGJC, BEMKNLNMMCD JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x2626270", Offset = "0x2625670", VA = "0x182626270", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class GJGICJEMPJE : PLKGMELDIMJ<LAGDIDADPAF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xBE28A0", Offset = "0xBE1CA0", VA = "0x180BE28A0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x2623B70", Offset = "0x2622F70", VA = "0x182623B70")]
		public GJGICJEMPJE(DJHNEBOJMKB EGMIBAJCGJC, LAGDIDADPAF JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private sealed class EAFMBLGAIHF : PLKGMELDIMJ<LMFIIBJKNMG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xB16190", Offset = "0xB15590", VA = "0x180B16190", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x2620750", Offset = "0x261FB50", VA = "0x182620750")]
		public EAFMBLGAIHF(DJHNEBOJMKB EGMIBAJCGJC, LMFIIBJKNMG JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "126")]
		protected override bool NCPJDEJCKAA(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class GJANFINFNJG : PLKGMELDIMJ<IHHGONGDCGK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xAFEEC0", Offset = "0xAFE2C0", VA = "0x180AFEEC0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override bool DDCLAKKCJKP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x2623B20", Offset = "0x2622F20", VA = "0x182623B20", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override bool CPIBJIDEMII
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x2623AB0", Offset = "0x2622EB0", VA = "0x182623AB0")]
		public GJANFINFNJG(DJHNEBOJMKB EGMIBAJCGJC, IHHGONGDCGK JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class AJMPEIFIHAN : PLKGMELDIMJ<GNAIEKONDHP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xB1EC30", Offset = "0xB1E030", VA = "0x180B1EC30", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool DDCLAKKCJKP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x26160B0", Offset = "0x26154B0", VA = "0x1826160B0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		protected override bool CPIBJIDEMII
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x2616040", Offset = "0x2615440", VA = "0x182616040")]
		public AJMPEIFIHAN(DJHNEBOJMKB EGMIBAJCGJC, GNAIEKONDHP JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class CFNJGNBLOMC : FHOENDLGMDB<IFGKFHLPKNF>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class EBJFIHAMNFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public CFNJGNBLOMC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public EBJFIHAMNFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x26207C0", Offset = "0x261FBC0", VA = "0x1826207C0")]
			internal float HNBFOOJPLBC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x2620840", Offset = "0x261FC40", VA = "0x182620840")]
			internal void JGIJDKFFJHI(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2619B60", Offset = "0x2618F60", VA = "0x182619B60")]
		public CFNJGNBLOMC(DJHNEBOJMKB EGMIBAJCGJC, IFGKFHLPKNF KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x26198E0", Offset = "0x2618CE0", VA = "0x1826198E0", Slot = "140")]
		protected override void DMEODAIMGHO(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class IPDCMKHIKNI : PLKGMELDIMJ<FEJAKJJHJIO>
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class ANNDFLOAFMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public IPDCMKHIKNI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public ANNDFLOAFMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x2617730", Offset = "0x2616B30", VA = "0x182617730")]
			internal bool EGBBPMAANLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x2617600", Offset = "0x2616A00", VA = "0x182617600")]
			internal void CLGLLFKFENF(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x26252E0", Offset = "0x26246E0", VA = "0x1826252E0")]
		public IPDCMKHIKNI(DJHNEBOJMKB EGMIBAJCGJC, FEJAKJJHJIO KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x2625030", Offset = "0x2624430", VA = "0x182625030", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class DMLKCOBKHFN : PLKGMELDIMJ<ALJNDFPEJKO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class NNIKJEEEAOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public DMLKCOBKHFN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public NNIKJEEEAOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x262FA20", Offset = "0x262EE20", VA = "0x18262FA20")]
			internal object EGBBPMAANLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x262FD30", Offset = "0x262F130", VA = "0x18262FD30")]
			internal bool JIJNJKLHHBH(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x262F770", Offset = "0x262EB70", VA = "0x18262F770")]
			internal void CLGLLFKFENF(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x262FBC0", Offset = "0x262EFC0", VA = "0x18262FBC0")]
			internal string HDCDJCJBGOC(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x262FEE0", Offset = "0x262F2E0", VA = "0x18262FEE0")]
			internal IReadOnlyList<object> PLLLOFKOIMP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x262FB50", Offset = "0x262EF50", VA = "0x18262FB50")]
			internal bool HBGFIPOPPBP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x262F9D0", Offset = "0x262EDD0", VA = "0x18262F9D0")]
			internal bool CLJKEHJEAMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x262FDB0", Offset = "0x262F1B0", VA = "0x18262FDB0")]
			internal void NJKGPCFLDDO(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x261B370", Offset = "0x261A770", VA = "0x18261B370")]
		public DMLKCOBKHFN(DJHNEBOJMKB EGMIBAJCGJC, ALJNDFPEJKO KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x261AB30", Offset = "0x2619F30", VA = "0x18261AB30", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class OGOKEHKBMMK : JNMCMNGHCEO<HMIBDHNJILI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0xCF6970", Offset = "0xCF5D70", VA = "0x180CF6970", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x2630160", Offset = "0x262F560", VA = "0x182630160")]
		public OGOKEHKBMMK(DJHNEBOJMKB EGMIBAJCGJC, HMIBDHNJILI JOMDOBIKCNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class GFHMACEICBC : FHOENDLGMDB<JNMMMFHNEBM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class NFHKNFMNPMG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public GFHMACEICBC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public NFHKNFMNPMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x262F020", Offset = "0x262E420", VA = "0x18262F020")]
			internal int HNBFOOJPLBC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x262F0A0", Offset = "0x262E4A0", VA = "0x18262F0A0")]
			internal void JGIJDKFFJHI(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x2623840", Offset = "0x2622C40", VA = "0x182623840")]
		public GFHMACEICBC(DJHNEBOJMKB EGMIBAJCGJC, JNMMMFHNEBM KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x2623540", Offset = "0x2622940", VA = "0x182623540", Slot = "140")]
		protected override void DMEODAIMGHO(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class NMDFDJAFOND : PLKGMELDIMJ<JHEEMDGDELA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class NIAGAPNIONK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public NMDFDJAFOND <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public NIAGAPNIONK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x262F4D0", Offset = "0x262E8D0", VA = "0x18262F4D0")]
			internal bool EGBBPMAANLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x262F440", Offset = "0x262E840", VA = "0x18262F440")]
			internal void CLGLLFKFENF(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x262F700", Offset = "0x262EB00", VA = "0x18262F700")]
		public NMDFDJAFOND(DJHNEBOJMKB EGMIBAJCGJC, JHEEMDGDELA KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x262F520", Offset = "0x262E920", VA = "0x18262F520", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class PNLICANILON : PLKGMELDIMJ<FKMHGKIJPGD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class DOIDBPOPFHP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public PNLICANILON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public DOIDBPOPFHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x261B590", Offset = "0x261A990", VA = "0x18261B590")]
			internal bool EGBBPMAANLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x261B500", Offset = "0x261A900", VA = "0x18261B500")]
			internal void CLGLLFKFENF(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x2630960", Offset = "0x262FD60", VA = "0x182630960")]
		public PNLICANILON(DJHNEBOJMKB EGMIBAJCGJC, FKMHGKIJPGD KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x2630780", Offset = "0x262FB80", VA = "0x182630780", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class KBKDKKKGNPJ : PLKGMELDIMJ<CJDPHJKKJJB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class JGAEDEMHHGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public KBKDKKKGNPJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public JGAEDEMHHGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x26257F0", Offset = "0x2624BF0", VA = "0x1826257F0")]
			internal int EGBBPMAANLH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x2625760", Offset = "0x2624B60", VA = "0x182625760")]
			internal void CLGLLFKFENF(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x2625EC0", Offset = "0x26252C0", VA = "0x182625EC0")]
		public KBKDKKKGNPJ(DJHNEBOJMKB EGMIBAJCGJC, CJDPHJKKJJB KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x2625C50", Offset = "0x2625050", VA = "0x182625C50", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class HMBJNACLGOF : PHFAJMKIHEI<HDEKIIACHIO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override BIGAOKINCIB DLBEIGACCLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xB2B4E0", Offset = "0xB2A8E0", VA = "0x180B2B4E0", Slot = "140")]
			get
			{
				return default(BIGAOKINCIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x26243C0", Offset = "0x26237C0", VA = "0x1826243C0")]
		public HMBJNACLGOF(DJHNEBOJMKB EGMIBAJCGJC, HDEKIIACHIO KKDALLBMKBI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class MMFLKPDHNHE : PLKGMELDIMJ<BPKOHJDNEKO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x26217D0", Offset = "0x2620BD0", VA = "0x1826217D0")]
		public MMFLKPDHNHE(DJHNEBOJMKB EGMIBAJCGJC, BPKOHJDNEKO JOMDOBIKCNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public abstract class PLKGMELDIMJ<TNode> : JJPIPKOGLIO, IDisposable where TNode : notnull, BPKOHJDNEKO
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class ANCGGLKIJLJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public PLKGMELDIMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public DJHNEBOJMKB circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public ANCGGLKIJLJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x4A1BAB0", Offset = "0x4A1AEB0", VA = "0x184A1BAB0")]
			internal DOJNPNKKIIB PEDMBJHMEEB(JCFPOPJNPGC portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private struct IKFOOJCFEEJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public PLKGMELDIMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x49D6700", Offset = "0x49D5B00", VA = "0x1849D6700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private struct FOPLBLFJKAP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public PLKGMELDIMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public BHMHOLKPBFF? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public BIJNJDLMCFA? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x474F6C0", Offset = "0x474EAC0", VA = "0x18474F6C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x474F960", Offset = "0x474ED60", VA = "0x18474F960", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class FHPGGOGDIOG
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
				public FHPGGOGDIOG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60003A3")]
				[Cpp2IlInjected.Address(RVA = "0x3E57B20", Offset = "0x3E56F20", VA = "0x183E57B20", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003A4")]
				[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
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
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public PLKGMELDIMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public ALEICLAOMCP configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public FHPGGOGDIOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
			internal string OOEKANDFLKB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
			internal void OMJJGGMKHAC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x46E3EF0", Offset = "0x46E32F0", VA = "0x1846E3EF0")]
			[AsyncStateMachine(typeof(PLKGMELDIMJ<>.FHPGGOGDIOG.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void GOGAGHNLDPJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private sealed class NCIAAOBOKOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public NCIAAOBOKOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x4FE8F80", Offset = "0x4FE8380", VA = "0x184FE8F80")]
			internal bool ADNDHFCKAGI(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x4FE9060", Offset = "0x4FE8460", VA = "0x184FE9060")]
			internal bool KCEDKHFGJMB(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private struct HCHLALPIJAD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public PLKGMELDIMJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x4877350", Offset = "0x4876750", VA = "0x184877350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x48776E0", Offset = "0x4876AE0", VA = "0x1848776E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private readonly DJHNEBOJMKB HOMGCJPPDEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private readonly bool CBIEGFFHDBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private FENCAGBAMDI<NBDDIELADOM, DOJNPNKKIIB> BBHPELGNLOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private FENCAGBAMDI<NBDDIELADOM, LCCAOFCLIML> ADIDIABPGNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private List<Action> OGFDNIBGDGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[CompilerGenerated]
		private Action<EECNAGIPCBM<NBDDIELADOM>>? EAIABIBIKCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[CompilerGenerated]
		private Action<EECNAGIPCBM<NBDDIELADOM>, LCCAOFCLIML>? FGKECHAGMLF;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected JKEAOGPLPFE FLFPDHIBEGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x52EAB10", Offset = "0x52E9F10", VA = "0x1852EAB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		protected KHHLGPIKIKO LMGJLGPFNIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x52EA3B0", Offset = "0x52E97B0", VA = "0x1852EA3B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected TNode OPKMPGPMHAL
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public IEBAHENHLEA<HAGICHLJINH> FBFNCEFMNFG
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x12332A0", Offset = "0x12326A0", VA = "0x1812332A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(IEBAHENHLEA<HAGICHLJINH>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public EECNAGIPCBM<APMGFEHLJPN> DGDNGAEIAAO
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x52EDBD0", Offset = "0x52ECFD0", VA = "0x1852EDBD0", Slot = "6")]
			get
			{
				return default(EECNAGIPCBM<APMGFEHLJPN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public object NIIDGBCBCIG
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x42A0DA0", Offset = "0x42A01A0", VA = "0x1842A0DA0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual bool MHENNHIIEPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int NHAFOJLJLLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x52ED830", Offset = "0x52ECC30", VA = "0x1852ED830", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public EJPPFNLOKLD FLKJLHOAPKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x52ED7D0", Offset = "0x52ECBD0", VA = "0x1852ED7D0", Slot = "10")]
			get
			{
				return default(EJPPFNLOKLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string NIDOKEDICHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x52EDDD0", Offset = "0x52ED1D0", VA = "0x1852EDDD0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual bool CPIBJIDEMII
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public EECNAGIPCBM<JMLCMMBCIKH> ANCCCEPKHAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xDA2D00", Offset = "0xDA2100", VA = "0x180DA2D00", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(EECNAGIPCBM<JMLCMMBCIKH>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0xDA65F0", Offset = "0xDA59F0", VA = "0x180DA65F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual bool IFEKBINNBNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual bool DDCLAKKCJKP
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool AJCKKNOCKCL
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual KDILCNDIDLC CEKKIPFLPME
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xE849E0", Offset = "0xE83DE0", VA = "0x180E849E0", Slot = "108")]
			get
			{
				return default(KDILCNDIDLC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool NPOPEGICONP
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x52ED540", Offset = "0x52EC940", VA = "0x1852ED540", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool ACLCIJDBLEC
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x52ED5A0", Offset = "0x52EC9A0", VA = "0x1852ED5A0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool GBCJDEIFPPK
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x52ED600", Offset = "0x52ECA00", VA = "0x1852ED600", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int IDMNGGLMGLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x52EDB80", Offset = "0x52ECF80", VA = "0x1852EDB80", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool KIFCNCJNHFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x52ED9B0", Offset = "0x52ECDB0", VA = "0x1852ED9B0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool MPAFNJJCMME
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x52ED710", Offset = "0x52ECB10", VA = "0x1852ED710", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool FDKHHAIBOFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x52ED6B0", Offset = "0x52ECAB0", VA = "0x1852ED6B0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool BLIKBOGMJKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0xE4BAC0", Offset = "0xE4AEC0", VA = "0x180E4BAC0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x120BFC0", Offset = "0x120B3C0", VA = "0x18120BFC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool AHOECCHNMKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public virtual bool FLKPOBKMIDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x52ED660", Offset = "0x52ECA60", VA = "0x1852ED660", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool IGFBGOAIMLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x52ED8E0", Offset = "0x52ECCE0", VA = "0x1852ED8E0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public BHMHOLKPBFF FGILNKLNPNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x52EDAC0", Offset = "0x52ECEC0", VA = "0x1852EDAC0", Slot = "29")]
			get
			{
				return default(BHMHOLKPBFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public BIJNJDLMCFA MECFJFDBHCH
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x52EDB20", Offset = "0x52ECF20", VA = "0x1852EDB20", Slot = "31")]
			get
			{
				return default(BIJNJDLMCFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual bool APJODHKNJLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public virtual OOJPOJKLIOG? GKDOMLFPIOA
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "123")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual LEAFJKBCFMF? ODEGPDAGIGM
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "124")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public virtual IEnumerable<IEBAHENHLEA<DJONKGBCHFD>>? AGOHNBBJCEL
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "125")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool BLKLKNDINNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x52ED770", Offset = "0x52ECB70", VA = "0x1852ED770", Slot = "128")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public IEBAHENHLEA<JJJHHLABGOM> GLEPNCFICPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x52EDA00", Offset = "0x52ECE00", VA = "0x1852EDA00", Slot = "63")]
			get
			{
				return default(IEBAHENHLEA<JJJHHLABGOM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public EECNAGIPCBM<JJJHHLABGOM> HALDBNDBBAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x52ED880", Offset = "0x52ECC80", VA = "0x1852ED880", Slot = "57")]
			get
			{
				return default(EECNAGIPCBM<JJJHHLABGOM>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public virtual bool ALLEIHGKGMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public virtual EECNAGIPCBM<JJJHHLABGOM>? IABJJLHODDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public virtual bool HICCCGKAEHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public bool NDPKCNMMNCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x52ED940", Offset = "0x52ECD40", VA = "0x1852ED940", Slot = "62")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public string EDDDAEGNADF
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x99A8A0", Offset = "0x999CA0", VA = "0x18099A8A0", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x99A9E0", Offset = "0x999DE0", VA = "0x18099A9E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public string HNCHENINBHC
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x99AA50", Offset = "0x999E50", VA = "0x18099AA50", Slot = "67")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x99A960", Offset = "0x999D60", VA = "0x18099A960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public EECNAGIPCBM<DJONKGBCHFD> JKGNFCKKGKB
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x52EDC50", Offset = "0x52ED050", VA = "0x1852EDC50", Slot = "64")]
			get
			{
				return default(EECNAGIPCBM<DJONKGBCHFD>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public IEBAHENHLEA<DJONKGBCHFD> MBOFLIIPNLN
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x52EDA60", Offset = "0x52ECE60", VA = "0x1852EDA60", Slot = "65")]
			get
			{
				return default(IEBAHENHLEA<DJONKGBCHFD>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public IEBAHENHLEA<DJONKGBCHFD>? BLCHJHNLKNP
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x52EDCB0", Offset = "0x52ED0B0", VA = "0x1852EDCB0", Slot = "132")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public ICNPICGMOCM<NBDDIELADOM, LCCAOFCLIML> HHPPBPJJGPD
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x52EDD90", Offset = "0x52ED190", VA = "0x1852EDD90", Slot = "68")]
			get
			{
				return default(ICNPICGMOCM<NBDDIELADOM, LCCAOFCLIML>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public virtual EECNAGIPCBM<NBDDIELADOM>? BMLGFEBOKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "133")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public virtual bool AMMOJKFIBGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public virtual bool JBEODDGLOML
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "137")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action HPMFDHBMECD
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x52E8D10", Offset = "0x52E8110", VA = "0x1852E8D10", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x52EA8E0", Offset = "0x52E9CE0", VA = "0x1852EA8E0", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event FGNOCBNPLGM MEOCBJOBAIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x52ECA40", Offset = "0x52EBE40", VA = "0x1852ECA40", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x52ECB20", Offset = "0x52EBF20", VA = "0x1852ECB20", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event KLAIKJEHLJF MGGAAHMGLNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x52EC9A0", Offset = "0x52EBDA0", VA = "0x1852EC9A0", Slot = "42")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x52E9E40", Offset = "0x52E9240", VA = "0x1852E9E40", Slot = "43")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action DACJJDAPLLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x52EBA60", Offset = "0x52EAE60", VA = "0x1852EBA60", Slot = "44")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x52E98E0", Offset = "0x52E8CE0", VA = "0x1852E98E0", Slot = "45")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action ACOILIBAHJD
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x52EA780", Offset = "0x52E9B80", VA = "0x1852EA780", Slot = "46")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x52EB220", Offset = "0x52EA620", VA = "0x1852EB220", Slot = "47")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<EECNAGIPCBM<NBDDIELADOM>, LCCAOFCLIML> DBPAENEMNMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x52E8E50", Offset = "0x52E8250", VA = "0x1852E8E50", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x52EAD80", Offset = "0x52EA180", VA = "0x1852EAD80", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<EECNAGIPCBM<NBDDIELADOM>, LCCAOFCLIML> EKCNABHPKOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x52EC300", Offset = "0x52EB700", VA = "0x1852EC300", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x52EA820", Offset = "0x52E9C20", VA = "0x1852EA820", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<EECNAGIPCBM<NBDDIELADOM>> LFKCOKOEDLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x52ECBC0", Offset = "0x52EBFC0", VA = "0x1852ECBC0", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x52E9940", Offset = "0x52E8D40", VA = "0x1852E9940", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<EECNAGIPCBM<NBDDIELADOM>, EECNAGIPCBM<NBDDIELADOM>> IGAMJKKLMCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x52EB8E0", Offset = "0x52EACE0", VA = "0x1852EB8E0", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x52E8C50", Offset = "0x52E8050", VA = "0x1852E8C50", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<EECNAGIPCBM<NBDDIELADOM>, LCCAOFCLIML> HGCMIJMFDBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x52ECEA0", Offset = "0x52EC2A0", VA = "0x1852ECEA0", Slot = "78")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x52EA4D0", Offset = "0x52E98D0", VA = "0x1852EA4D0", Slot = "79")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<EECNAGIPCBM<NBDDIELADOM>, EECNAGIPCBM<NBDDIELADOM>> GBJFFLANOFE
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x52E9560", Offset = "0x52E8960", VA = "0x1852E9560", Slot = "80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x52EB010", Offset = "0x52EA410", VA = "0x1852EB010", Slot = "81")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x52ECF60", Offset = "0x52EC360", VA = "0x1852ECF60")]
		[FCLLJJAPAHC("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[FCLLJJAPAHC("Need to handle `Name` better.")]
		protected PLKGMELDIMJ(DJHNEBOJMKB EGMIBAJCGJC, TNode JOMDOBIKCNM, bool HBOPKMBIJKM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x52EC3C0", Offset = "0x52EB7C0", VA = "0x1852EC3C0", Slot = "100")]
		protected virtual void MBHBIOMKKEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x52E9FB0", Offset = "0x52E93B0", VA = "0x1852E9FB0", Slot = "101")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x52EBAC0", Offset = "0x52EAEC0", VA = "0x1852EBAC0", Slot = "9")]
		[AsyncStateMachine(typeof(PLKGMELDIMJ<>.IKFOOJCFEEJ))]
		public void JLODJBGIKCE(int INOKEMEOJEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x52EBB70", Offset = "0x52EAF70", VA = "0x1852EBB70")]
		public bool KEMAIDDMPDD([In] BHMHOLKPBFF FIIKLGCIAGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x52EB9F0", Offset = "0x52EADF0", VA = "0x1852EB9F0")]
		public bool JEOBNALELCB([In] BIJNJDLMCFA FIIKLGCIAGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x52ECC80", Offset = "0x52EC080", VA = "0x1852ECC80", Slot = "33")]
		public void PJEAKDDLFMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x52EA980", Offset = "0x52E9D80", VA = "0x1852EA980", Slot = "34")]
		[AsyncStateMachine(typeof(PLKGMELDIMJ<>.FOPLBLFJKAP))]
		public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> FALFNGHIFME(BHMHOLKPBFF? PFOFJFECKOD, BIJNJDLMCFA? HKMKFJAMILI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "111")]
		public virtual void GIHDIMLBGIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "112")]
		public virtual void HBABIADGBFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "113")]
		public virtual void MFGMJHHJFJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xE29F20", Offset = "0xE29320", VA = "0x180E29F20")]
		protected void CCMAPONLGBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0xE7E350", Offset = "0xE7D750", VA = "0x180E7E350")]
		protected void OBMMLODKIHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x2014C30", Offset = "0x2014030", VA = "0x182014C30")]
		private void JNFLFBGJJNE([In] BIJNJDLMCFA BENMKDDDBDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x52EAED0", Offset = "0x52EA2D0", VA = "0x1852EAED0", Slot = "114")]
		public virtual Task<AEAAIINGJNL<EECNAGIPCBM<NBDDIELADOM>, GJDNFLPCNNP>> GJJMDKBOHHL(string MPGDCPPMNJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x52E9EE0", Offset = "0x52E92E0", VA = "0x1852E9EE0", Slot = "115")]
		public virtual Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> DOIMEGCHPLA(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "116")]
		public virtual void MMBAAJBHGKA(EECNAGIPCBM<NBDDIELADOM> NIAABNDCGGG, EECNAGIPCBM<NBDDIELADOM> OPLDEENLAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x52E9A00", Offset = "0x52E8E00", VA = "0x1852E9A00", Slot = "117")]
		public virtual IEnumerable<IJHNHGOIIEG> CPMAMODKMMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x52EAE40", Offset = "0x52EA240", VA = "0x1852EAE40", Slot = "118")]
		public AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP> GGBKNKHNLDP(string KEEILLBICAJ)
		{
			return default(AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x52EC660", Offset = "0x52EBA60", VA = "0x1852EC660", Slot = "48")]
		public bool MCJKMJGDPEJ([Out] Guid GGIEFFHJLPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x52EBBE0", Offset = "0x52EAFE0", VA = "0x1852EBBE0")]
		public bool KFADDNPFMEC([In] Guid LJPNEOLHCOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "119")]
		public virtual void CNJFGCHCFHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "120")]
		public virtual void LNOFEDNMNKN(bool FDOOPGCCLBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "121")]
		public virtual OBIKEAPJGME HHCAKOPIHJF([In] CBNMLIFIDKL GPLBAOJCKOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x52EA590", Offset = "0x52E9990", VA = "0x1852EA590")]
		protected void EKBHLIINPPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x52EC960", Offset = "0x52EBD60", VA = "0x1852EC960", Slot = "126")]
		protected virtual bool NCPJDEJCKAA(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x52EA4A0", Offset = "0x52E98A0", VA = "0x1852EA4A0", Slot = "89")]
		public bool EGALGOFIGIL(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "127")]
		protected virtual bool PAJNNJPKCHB(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "134")]
		protected virtual void FHHKGIEKPFM(ALEICLAOMCP KOMAPPFDBGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x52EB2C0", Offset = "0x52EA6C0", VA = "0x1852EB2C0")]
		protected void HNIEOLNNIJA(ALEICLAOMCP BEGAPFGOGEG, Func<string> BFFMCELADKE, Action<string> GMMHMMHCCPI, string CCEIGCIBLOF, string BKANKAJODLG, string JEENHJPNMAB, KNNFNEJICPD BJHKLBCPJKN, DANOKDJALKM MHHAHOJGFLO, Func<string, bool> NLLDCILJJLK, string FDLODPOKMBF, Func<string, bool> FBMAPMPMNDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x52E9620", Offset = "0x52E8A20", VA = "0x1852E9620")]
		protected void BKLBPOMCJFK(ALEICLAOMCP BEGAPFGOGEG, Func<string> BFFMCELADKE, Action<string> GMMHMMHCCPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x52EC7B0", Offset = "0x52EBBB0", VA = "0x1852EC7B0", Slot = "135")]
		protected virtual void MGMGBFAAMEC(ALEICLAOMCP BEGAPFGOGEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x52EB9A0", Offset = "0x52EADA0", VA = "0x1852EB9A0", Slot = "83")]
		public void JCOCKLCIKBE(ALEICLAOMCP BEGAPFGOGEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x52EAC90", Offset = "0x52EA090", VA = "0x1852EAC90", Slot = "84")]
		public AGDIGDNFMBO FHEJPMABLLI()
		{
			return default(AGDIGDNFMBO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x9DBC10", Offset = "0x9DB010", VA = "0x1809DBC10", Slot = "138")]
		public virtual bool LHPOHLBIOMM(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x1E05D20", Offset = "0x1E05120", VA = "0x181E05D20")]
		private void FGCAAKHGEBE([In] BHMHOLKPBFF JPKKPDPLAGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x52EB0D0", Offset = "0x52EA4D0", VA = "0x1852EB0D0")]
		private void HEFKNDDPPON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x52EBEA0", Offset = "0x52EB2A0", VA = "0x1852EBEA0", Slot = "90")]
		private void KGAEADONNKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x52E8F10", Offset = "0x52E8310", VA = "0x1852E8F10", Slot = "92")]
		private void APEPDKAODJE(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xFA3510", Offset = "0xFA2910", VA = "0x180FA3510", Slot = "94")]
		private void HAMHNNIBCOL(EECNAGIPCBM<NBDDIELADOM> IIKCEJDFBDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x52EB6C0", Offset = "0x52EAAC0", VA = "0x1852EB6C0", Slot = "96")]
		private void IHODHIDLCMG(EECNAGIPCBM<NBDDIELADOM> IIKCEJDFBDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x52E9A90", Offset = "0x52E8E90", VA = "0x1852E9A90", Slot = "97")]
		private void DCJJMGCHNDJ(EECNAGIPCBM<NBDDIELADOM> NIAABNDCGGG, EECNAGIPCBM<NBDDIELADOM> OPLDEENLAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xFA3830", Offset = "0xFA2C30", VA = "0x180FA3830", Slot = "98")]
		private void OMDNHOOOJPB(EECNAGIPCBM<NBDDIELADOM> NIAABNDCGGG, EECNAGIPCBM<NBDDIELADOM> OPLDEENLAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x52E94D0", Offset = "0x52E88D0", VA = "0x1852E94D0", Slot = "91")]
		private void BAMONDJHMBD(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x52EBEE0", Offset = "0x52EB2E0", VA = "0x1852EBEE0", Slot = "93")]
		private void KKMFIAKLDPF(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x52EB870", Offset = "0x52EAC70", VA = "0x1852EB870", Slot = "95")]
		private void IJPMJPMCFIE(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x52EAB70", Offset = "0x52E9F70", VA = "0x1852EAB70", Slot = "139")]
		[AsyncStateMachine(typeof(PLKGMELDIMJ<>.HCHLALPIJAD))]
		public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> FGMNMBBAEKN(string KEEILLBICAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x52EAFA0", Offset = "0x52EA3A0", VA = "0x1852EAFA0", Slot = "55")]
		private void GOBDDOEGLME(object HMLFJDCDADA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x52E94F0", Offset = "0x52E88F0", VA = "0x1852E94F0", Slot = "56")]
		private void BGKGFBBCILH(object HMLFJDCDADA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x50171B0", Offset = "0x50165B0", VA = "0x1850171B0", Slot = "30")]
		private bool MMNIAAAIMFO([In] BHMHOLKPBFF FIIKLGCIAGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x52EAAD0", Offset = "0x52E9ED0", VA = "0x1852EAAD0", Slot = "32")]
		private bool FALPKGGMHNN([In] BIJNJDLMCFA FIIKLGCIAGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x52ECAE0", Offset = "0x52EBEE0", VA = "0x1852ECAE0", Slot = "49")]
		private bool NNODDMCKFPB([In] Guid LJPNEOLHCOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x52E98A0", Offset = "0x52E8CA0", VA = "0x1852E98A0")]
		[CompilerGenerated]
		private string BLDFGKIIKGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x52E8DB0", Offset = "0x52E81B0", VA = "0x1852E8DB0")]
		[CompilerGenerated]
		private void ALHAHOJHAKF(string MPGDCPPMNJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class OOGGFCHBEDC : JNMCMNGHCEO<LGLJJPLBLOH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0xCE6520", Offset = "0xCE5920", VA = "0x180CE6520", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x26305F0", Offset = "0x262F9F0", VA = "0x1826305F0")]
		public OOGGFCHBEDC(DJHNEBOJMKB EGMIBAJCGJC, LGLJJPLBLOH JOMDOBIKCNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class NGCOGPPEAGP : IFPNFMBFIIL<MNIIEDDDJHE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0xB2B4E0", Offset = "0xB2A8E0", VA = "0x180B2B4E0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x262F3E0", Offset = "0x262E7E0", VA = "0x18262F3E0")]
		public NGCOGPPEAGP(DJHNEBOJMKB EGMIBAJCGJC, MNIIEDDDJHE JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public abstract class PHFAJMKIHEI<T> : PLKGMELDIMJ<T> where T : notnull, CEAHFFOIBLO
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class NKLNDHDHEFM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public IReadOnlyList<KeyValuePair<string, FMBCGIKOAML>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public PHFAJMKIHEI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public BIGAOKINCIB clipType;

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public NKLNDHDHEFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
			internal IReadOnlyList<KeyValuePair<string, FMBCGIKOAML>> EGBBPMAANLH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x5029890", Offset = "0x5028C90", VA = "0x185029890")]
			internal int CLGLLFKFENF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x5029BD0", Offset = "0x5028FD0", VA = "0x185029BD0")]
			internal void HDCDJCJBGOC(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x502A170", Offset = "0x5029570", VA = "0x18502A170")]
			internal void PLLLOFKOIMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x5029A80", Offset = "0x5028E80", VA = "0x185029A80")]
			internal void HBGFIPOPPBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x50299F0", Offset = "0x5028DF0", VA = "0x1850299F0")]
			internal bool CLJKEHJEAMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x502A120", Offset = "0x5029520", VA = "0x18502A120")]
			internal void NJKGPCFLDDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x50299F0", Offset = "0x5028DF0", VA = "0x1850299F0")]
			internal bool JIJNJKLHHBH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x5029DF0", Offset = "0x50291F0", VA = "0x185029DF0")]
			internal float HGPJOJOAGCI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x502A010", Offset = "0x5029410", VA = "0x18502A010")]
			internal void KCBANGHNAMB(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x502A0D0", Offset = "0x50294D0", VA = "0x18502A0D0")]
			internal float MDCFNOKCEPB()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x5029F00", Offset = "0x5029300", VA = "0x185029F00")]
			internal void IMCMHAOBEMM(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x5029FC0", Offset = "0x50293C0", VA = "0x185029FC0")]
			internal float JNJANBDBMIN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x5029E40", Offset = "0x5029240", VA = "0x185029E40")]
			internal void IGFCFDJIBAD(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0xFAEEF0", Offset = "0xFAE2F0", VA = "0x180FAEEF0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public abstract BIGAOKINCIB DLBEIGACCLN
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(Slot = "140")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x52D85E0", Offset = "0x52D79E0", VA = "0x1852D85E0")]
		public PHFAJMKIHEI(DJHNEBOJMKB EGMIBAJCGJC, T JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x52D7B20", Offset = "0x52D6F20", VA = "0x1852D7B20", Slot = "134")]
		protected sealed override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private sealed class MOBMMKHFKEB : PLKGMELDIMJ<PNGOCELILFN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0xCE9B60", Offset = "0xCE8F60", VA = "0x180CE9B60", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x262EC30", Offset = "0x262E030", VA = "0x18262EC30")]
		public MOBMMKHFKEB(DJHNEBOJMKB EGMIBAJCGJC, PNGOCELILFN JOMDOBIKCNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class CEMPEBFEKJD : PLKGMELDIMJ<LAMECEOOKMN>
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class LLLAHJPIHLI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public CEMPEBFEKJD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public LLLAHJPIHLI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x262DB70", Offset = "0x262CF70", VA = "0x18262DB70")]
			internal int CLGLLFKFENF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x262DBC0", Offset = "0x262CFC0", VA = "0x18262DBC0")]
			internal void HDCDJCJBGOC(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static Dictionary<string, FMBCGIKOAML>? CMMMPGNDPCP;

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x2619870", Offset = "0x2618C70", VA = "0x182619870")]
		public CEMPEBFEKJD(DJHNEBOJMKB EGMIBAJCGJC, LAMECEOOKMN JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x2619500", Offset = "0x2618900", VA = "0x182619500", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class OHALMCDEEBM : PHFAJMKIHEI<HKBHMEBJCKB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override BIGAOKINCIB DLBEIGACCLN
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "140")]
			get
			{
				return default(BIGAOKINCIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x26301C0", Offset = "0x262F5C0", VA = "0x1826301C0")]
		public OHALMCDEEBM(DJHNEBOJMKB EGMIBAJCGJC, HKBHMEBJCKB KKDALLBMKBI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private sealed class EJKMCPNAMCP : IFPNFMBFIIL<BGGMCPDBJEP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0xB2B4E0", Offset = "0xB2A8E0", VA = "0x180B2B4E0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x26208E0", Offset = "0x261FCE0", VA = "0x1826208E0")]
		public EJKMCPNAMCP(DJHNEBOJMKB EGMIBAJCGJC, BGGMCPDBJEP JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private sealed class PMHHHHKEELP : IFPNFMBFIIL<JHBPDAGBAHP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0xB2B4E0", Offset = "0xB2A8E0", VA = "0x180B2B4E0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2630720", Offset = "0x262FB20", VA = "0x182630720")]
		public PMHHHHKEELP(DJHNEBOJMKB EGMIBAJCGJC, JHBPDAGBAHP JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class KNIHDAHFNMJ : FHOENDLGMDB<EBFLIJOAGFK>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private sealed class PAPJPJDFIGB
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
				public PAPJPJDFIGB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001DC")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001DD")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001DE")]
				private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003D8")]
				[Cpp2IlInjected.Address(RVA = "0x26309D0", Offset = "0x262FDD0", VA = "0x1826309D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D9")]
				[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public KNIHDAHFNMJ <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public PAPJPJDFIGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x2630650", Offset = "0x262FA50", VA = "0x182630650")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void HNBFOOJPLBC(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2626210", Offset = "0x2625610", VA = "0x182626210")]
		public KNIHDAHFNMJ(DJHNEBOJMKB EGMIBAJCGJC, EBFLIJOAGFK KKDALLBMKBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x2625F30", Offset = "0x2625330", VA = "0x182625F30", Slot = "140")]
		protected override void DMEODAIMGHO(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public sealed class FLOBCDPLANP : PHFAJMKIHEI<JJFMCLFBGKD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public override BIGAOKINCIB DLBEIGACCLN
		{
			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0xAFEEC0", Offset = "0xAFE2C0", VA = "0x180AFEEC0", Slot = "140")]
			get
			{
				return default(BIGAOKINCIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x26212A0", Offset = "0x26206A0", VA = "0x1826212A0")]
		public FLOBCDPLANP(DJHNEBOJMKB EGMIBAJCGJC, JJFMCLFBGKD KKDALLBMKBI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private sealed class CHJPFDNJPEL : PLKGMELDIMJ<KGAFLBMLAMC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xCCABA0", Offset = "0xCC9FA0", VA = "0x180CCABA0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x2619BC0", Offset = "0x2618FC0", VA = "0x182619BC0")]
		public CHJPFDNJPEL(DJHNEBOJMKB EGMIBAJCGJC, KGAFLBMLAMC JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class IEGPBPBOCDK : PLKGMELDIMJ<KPBILJFHKMC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public sealed override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public sealed override bool DDCLAKKCJKP
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected sealed override bool CPIBJIDEMII
		{
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0x9AC6E0", Offset = "0x9ABAE0", VA = "0x1809AC6E0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x2624E30", Offset = "0x2624230", VA = "0x182624E30")]
		public IEGPBPBOCDK(DJHNEBOJMKB EGMIBAJCGJC, KPBILJFHKMC JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x2624B20", Offset = "0x2623F20", VA = "0x182624B20", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x2624DF0", Offset = "0x26241F0", VA = "0x182624DF0")]
		private int IEBNPNFEFIE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x2624AC0", Offset = "0x2623EC0", VA = "0x182624AC0")]
		private void ADINHPBKHLK(int KBBLKNKJAHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class FOPBIFGIGNB : MMFLKPDHNHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x26217D0", Offset = "0x2620BD0", VA = "0x1826217D0")]
		public FOPBIFGIGNB(DJHNEBOJMKB EGMIBAJCGJC, BPKOHJDNEKO JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class CNAIHNIKIOI : FHOENDLGMDB<GPPINOAPODO>
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x2619C30", Offset = "0x2619030", VA = "0x182619C30")]
		public CNAIHNIKIOI(DJHNEBOJMKB EGMIBAJCGJC, GPPINOAPODO JOMDOBIKCNM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public abstract class FHOENDLGMDB<TVariableNode> : PLKGMELDIMJ<TVariableNode> where TVariableNode : notnull, GPPINOAPODO
	{
		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class HFGKPDACHLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public FHOENDLGMDB<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public HFGKPDACHLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x4883E40", Offset = "0x4883240", VA = "0x184883E40")]
			internal bool EGBBPMAANLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x4883D80", Offset = "0x4883180", VA = "0x184883D80")]
			internal void CLGLLFKFENF(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x4883F50", Offset = "0x4883350", VA = "0x184883F50")]
			internal bool HDCDJCJBGOC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x4883FB0", Offset = "0x48833B0", VA = "0x184883FB0")]
			internal void PLLLOFKOIMP(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x4883EA0", Offset = "0x48832A0", VA = "0x184883EA0")]
			internal bool HBGFIPOPPBP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		[CompilerGenerated]
		private sealed class NMODHCFEIFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public KHHLGPIKIKO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public FHOENDLGMDB<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public NMODHCFEIFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x5038100", Offset = "0x5037500", VA = "0x185038100")]
			internal void HNBFOOJPLBC(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public override NodeVisualizationKey CIMPFBFFMBE
		{
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0xB236B0", Offset = "0xB22AB0", VA = "0x180B236B0", Slot = "104")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public override KDILCNDIDLC CEKKIPFLPME
		{
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x46E3B40", Offset = "0x46E2F40", VA = "0x1846E3B40", Slot = "108")]
			get
			{
				return default(KDILCNDIDLC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x46E39A0", Offset = "0x46E2DA0", VA = "0x1846E39A0")]
		protected FHOENDLGMDB(DJHNEBOJMKB EGMIBAJCGJC, TVariableNode JOMDOBIKCNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x46E3390", Offset = "0x46E2790", VA = "0x1846E3390", Slot = "101")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x46E3510", Offset = "0x46E2910", VA = "0x1846E3510", Slot = "134")]
		protected override void FHHKGIEKPFM(ALEICLAOMCP BEGAPFGOGEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x46E3000", Offset = "0x46E2400", VA = "0x1846E3000", Slot = "140")]
		protected virtual void DMEODAIMGHO(ALEICLAOMCP BEGAPFGOGEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x46E2F50", Offset = "0x46E2350", VA = "0x1846E2F50", Slot = "119")]
		public override void CNJFGCHCFHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2606C60", Offset = "0x2606060", VA = "0x182606C60")]
	public static JJPIPKOGLIO AFLKMMODJAC(DJHNEBOJMKB EGMIBAJCGJC, BPKOHJDNEKO JOMDOBIKCNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class IEFFJHLMINL : AGBCEPDAIHL, FPEPDAKCCOK, KALOLKFHOKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public EECNAGIPCBM<BPHLKFKIMPM> IEHBBMPKIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xCC2500", Offset = "0xCC1900", VA = "0x180CC2500", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(EECNAGIPCBM<BPHLKFKIMPM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public EECNAGIPCBM<NJMBLJHEMGJ> GAFMOPDIOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0xDB0220", Offset = "0xDAF620", VA = "0x180DB0220", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(EECNAGIPCBM<NJMBLJHEMGJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x2624770", Offset = "0x2623B70", VA = "0x182624770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private EECNAGIPCBM<FPPJALEEIOP> GHGKBMCCFJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0xCCA980", Offset = "0xCC9D80", VA = "0x180CCA980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public override EECNAGIPCBM<PHNBHNIJDOG> INCIDJBMNNG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x2624780", Offset = "0x2623B80", VA = "0x182624780", Slot = "21")]
		get
		{
			return default(EECNAGIPCBM<PHNBHNIJDOG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x26247D0", Offset = "0x2623BD0", VA = "0x1826247D0")]
	private IEFFJHLMINL(DJHNEBOJMKB EGMIBAJCGJC, BPKOHJDNEKO JOMDOBIKCNM, OFNNHKNMMGL ENDDCCDDNPH, EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, EECNAGIPCBM<NJMBLJHEMGJ> CLMAEMHEFIF, EECNAGIPCBM<FPPJALEEIOP> HPABFAJEOGG, bool LLAHIHAIOJM, string MPGDCPPMNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x2624420", Offset = "0x2623820", VA = "0x182624420")]
	public static IEFFJHLMINL AFLKMMODJAC(DJHNEBOJMKB EGMIBAJCGJC, BPKOHJDNEKO JOMDOBIKCNM, OFNNHKNMMGL BJMJFECFHCC, EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, EECNAGIPCBM<FPPJALEEIOP> HPABFAJEOGG, EECNAGIPCBM<NJMBLJHEMGJ> CLMAEMHEFIF, bool LLAHIHAIOJM, bool HBOPKMBIJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2624770", Offset = "0x2623B70", VA = "0x182624770")]
	internal void PJMDCIKDIHA(EECNAGIPCBM<NJMBLJHEMGJ> FIIKLGCIAGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public abstract class AGBCEPDAIHL : KALOLKFHOKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private struct HICPDJCDIFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private FKJOGAHEKEE? IELHFMJNGCD;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x2624310", Offset = "0x2623710", VA = "0x182624310")]
		public void GAPBPDEBKKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x2624320", Offset = "0x2623720", VA = "0x182624320")]
		public FKJOGAHEKEE PKKNMKFDKOB(AGBCEPDAIHL NIEBNIMDKGG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	protected readonly DJHNEBOJMKB HOMGCJPPDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	protected readonly BPKOHJDNEKO JMEIBFOJAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private HICPDJCDIFJ IKNFOHOPLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private readonly IALOPNHIEOL NKPHCINLANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private readonly List<KMPKBFDGFFF> ONGNDBDIDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly List<KJGOFLHNNAE> ILOHCJFOCFC;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	[FCLLJJAPAHC("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> BMOPGMIADFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x2615BC0", Offset = "0x2614FC0", VA = "0x182615BC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public DisplayKind BEDOKLCBHKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x9A1080", Offset = "0x9A0480", VA = "0x1809A1080", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public EECNAGIPCBM<JJJHHLABGOM> HALDBNDBBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x2615D00", Offset = "0x2615100", VA = "0x182615D00", Slot = "6")]
		get
		{
			return default(EECNAGIPCBM<JJJHHLABGOM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public IEBAHENHLEA<JJJHHLABGOM> GLEPNCFICPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x2615B90", Offset = "0x2614F90", VA = "0x182615B90", Slot = "7")]
		get
		{
			return default(IEBAHENHLEA<JJJHHLABGOM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public PACCEJFECHL LOFAEMMIOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xC8ACB0", Offset = "0xC8A0B0", VA = "0x180C8ACB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public CFDPDFCKCED DFCGMLPKGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x2614D00", Offset = "0x2614100", VA = "0x182614D00", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	protected FKJOGAHEKEE DIOADNJNIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x2614D00", Offset = "0x2614100", VA = "0x182614D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public PortImage GBDMGBEFNIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x2614BD0", Offset = "0x2613FD0", VA = "0x182614BD0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public string EDDDAEGNADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x993290", Offset = "0x992690", VA = "0x180993290", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x993400", Offset = "0x992800", VA = "0x180993400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IEBAHENHLEA<DJONKGBCHFD> MBOFLIIPNLN
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x26154B0", Offset = "0x26148B0", VA = "0x1826154B0", Slot = "9")]
		get
		{
			return default(IEBAHENHLEA<DJONKGBCHFD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public EECNAGIPCBM<NBDDIELADOM> FDMPNBFCANM
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xC6BF50", Offset = "0xC6B350", VA = "0x180C6BF50", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EECNAGIPCBM<NBDDIELADOM>);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0xD9E070", Offset = "0xD9D470", VA = "0x180D9E070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public abstract EECNAGIPCBM<PHNBHNIJDOG> INCIDJBMNNG
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x2615EE0", Offset = "0x26152E0", VA = "0x182615EE0")]
	protected AGBCEPDAIHL(DJHNEBOJMKB EGMIBAJCGJC, BPKOHJDNEKO JOMDOBIKCNM, IALOPNHIEOL MDPDGBLOFCH, EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, bool LLAHIHAIOJM, string MPGDCPPMNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x2615D30", Offset = "0x2615130", VA = "0x182615D30", Slot = "22")]
	protected virtual void MBHBIOMKKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x26154D0", Offset = "0x26148D0", VA = "0x1826154D0", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x2615E20", Offset = "0x2615220", VA = "0x182615E20", Slot = "14")]
	public void NCDPLKKFJDK(KMPKBFDGFFF JDJFEKKOFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x2615790", Offset = "0x2614B90", VA = "0x182615790", Slot = "15")]
	public void HFBNHCFPEHN(KJGOFLHNNAE JDJFEKKOFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x2614DA0", Offset = "0x26141A0", VA = "0x182614DA0", Slot = "16")]
	public void BMICBNLKDLB(GKJGINDFPME CMAHNGHDHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x2615980", Offset = "0x2614D80", VA = "0x182615980", Slot = "24")]
	protected virtual void JLKDMNEKCMG(GKJGINDFPME CMAHNGHDHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x26157F0", Offset = "0x2614BF0", VA = "0x1826157F0", Slot = "19")]
	private void IDBLJBGPPFE(bool OICAMEEFOOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x26155C0", Offset = "0x26149C0", VA = "0x1826155C0")]
	private void EGLIJMNCHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x26159E0", Offset = "0x2614DE0", VA = "0x1826159E0")]
	private void JNDMPBEGMEE([In] JOMKCEJJNMA LIBFHHEIEJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x2615E80", Offset = "0x2615280", VA = "0x182615E80", Slot = "17")]
	public void POJGBBNJHIM(KMPKBFDGFFF JDJFEKKOFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x2615450", Offset = "0x2614850", VA = "0x182615450", Slot = "18")]
	public void CFCGBMAPMKL(KJGOFLHNNAE JDJFEKKOFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x993400", Offset = "0x992800", VA = "0x180993400")]
	internal void EPJFGOCJOBP(string MPGDCPPMNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x2615770", Offset = "0x2614B70", VA = "0x182615770")]
	internal void HCDHFMFENFN(PAJOEFEBPCI EIHGNKDHDGF, PACCEJFECHL MAIGGPEPIHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0xD9E070", Offset = "0xD9D470", VA = "0x180D9E070")]
	internal void BFIEGNMIKCF(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class DOJNPNKKIIB : LCCAOFCLIML, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class DNPHBCEGOBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public DJHNEBOJMKB circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public BPKOHJDNEKO node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public EECNAGIPCBM<NBDDIELADOM> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public DNPHBCEGOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x261B3E0", Offset = "0x261A7E0", VA = "0x18261B3E0")]
		internal JFPNAONGGLG JCIIBAMDFDN((int PortDescIndex, int PortIndex, HGLJGFLMDDD InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x261B470", Offset = "0x261A870", VA = "0x18261B470")]
		internal IEFFJHLMINL NBJFJCFKEAP(OFNNHKNMMGL i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct FCMMHKCNJDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public DOJNPNKKIIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private OJNPGCHDMOP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x26209E0", Offset = "0x261FDE0", VA = "0x1826209E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x2620E50", Offset = "0x2620250", VA = "0x182620E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct BDCMHJLHNBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public DOJNPNKKIIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public EECNAGIPCBM<GFAOCBCKMMM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private OJNPGCHDMOP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x2617D50", Offset = "0x2617150", VA = "0x182617D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x26180A0", Offset = "0x26174A0", VA = "0x1826180A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct FLOCKFFHFLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public DOJNPNKKIIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public EECNAGIPCBM<FPPJALEEIOP> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private OJNPGCHDMOP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x2621300", Offset = "0x2620700", VA = "0x182621300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x2621650", Offset = "0x2620A50", VA = "0x182621650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct OHEJEBDODLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public DOJNPNKKIIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public EECNAGIPCBM<GFAOCBCKMMM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public EECNAGIPCBM<GFAOCBCKMMM> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private OJNPGCHDMOP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x2630220", Offset = "0x262F620", VA = "0x182630220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x2630580", Offset = "0x262F980", VA = "0x182630580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct BMNLMBKICCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public DOJNPNKKIIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public EECNAGIPCBM<FPPJALEEIOP> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public EECNAGIPCBM<FPPJALEEIOP> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private OJNPGCHDMOP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x2619110", Offset = "0x2618510", VA = "0x182619110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x2619470", Offset = "0x2618870", VA = "0x182619470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct MKDNKFPLJIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public DOJNPNKKIIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private OJNPGCHDMOP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x262E290", Offset = "0x262D690", VA = "0x18262E290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x262E710", Offset = "0x262DB10", VA = "0x18262E710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct AMBCCCMEDIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public DOJNPNKKIIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private OJNPGCHDMOP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x2617240", Offset = "0x2616640", VA = "0x182617240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x2617590", Offset = "0x2616990", VA = "0x182617590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct FLGMBIKJKHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public DOJNPNKKIIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public EECNAGIPCBM<GFAOCBCKMMM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private OJNPGCHDMOP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x2620EC0", Offset = "0x26202C0", VA = "0x182620EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2621230", Offset = "0x2620630", VA = "0x182621230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct DBJLGNOJGAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public DOJNPNKKIIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public EECNAGIPCBM<FPPJALEEIOP> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private OJNPGCHDMOP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x261A750", Offset = "0x2619B50", VA = "0x18261A750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x261AAC0", Offset = "0x2619EC0", VA = "0x18261AAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct JAPLJAHNEGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public DOJNPNKKIIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public PGCCEHDKJMM type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public EECNAGIPCBM<GFAOCBCKMMM> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private OJNPGCHDMOP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x2625350", Offset = "0x2624750", VA = "0x182625350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x26256F0", Offset = "0x2624AF0", VA = "0x1826256F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct JIGOGEHDKAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public DOJNPNKKIIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public PGCCEHDKJMM type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public EECNAGIPCBM<FPPJALEEIOP> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private OJNPGCHDMOP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x2625840", Offset = "0x2624C40", VA = "0x182625840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x2625BE0", Offset = "0x2624FE0", VA = "0x182625BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly bool LFPFCOIHPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly DJHNEBOJMKB HOMGCJPPDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private readonly bool HEAGGJLCENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private ICNPICGMOCM<HICCHPCIPHD, JFPNAONGGLG> LKNKCHFMLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private ICNPICGMOCM<HICCHPCIPHD, AIDKDGHFPLJ> JBNFHJOOGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly BPKOHJDNEKO JMEIBFOJAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private ICNPICGMOCM<NJMBLJHEMGJ, IEFFJHLMINL> NIGIMOOJHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private ICNPICGMOCM<NJMBLJHEMGJ, FPEPDAKCCOK> POIINCADEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private string? FALINFIICCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly JCFPOPJNPGC AGPIMOLOIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private EECNAGIPCBM<NBDDIELADOM> LAIHFLDGBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly bool CBIEGFFHDBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	[CompilerGenerated]
	private Action? LOFIIBPNEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	[CompilerGenerated]
	private Action? EKHKBLGMLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	[CompilerGenerated]
	private Action<EECNAGIPCBM<HICCHPCIPHD>>? CJDHPHMJIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	[CompilerGenerated]
	private Action<EECNAGIPCBM<NJMBLJHEMGJ>>? GELCIBNAGBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private LCCAOFCLIML.FCDANOHENGK? PCNAJNLDJJF;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool AJPDJDHGBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x261E300", Offset = "0x261D700", VA = "0x18261E300", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool LDNNNKMKNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x261C210", Offset = "0x261B610", VA = "0x18261C210", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool EKKGPLJKJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x261FE10", Offset = "0x261F210", VA = "0x18261FE10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public IEBAHENHLEA<JJJHHLABGOM> GLEPNCFICPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x261E760", Offset = "0x261DB60", VA = "0x18261E760", Slot = "7")]
		get
		{
			return default(IEBAHENHLEA<JJJHHLABGOM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool KJFNLOHKONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x261D030", Offset = "0x261C430", VA = "0x18261D030", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public ICNPICGMOCM<HICCHPCIPHD, AIDKDGHFPLJ> IOBDOMJCHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540", Slot = "9")]
		get
		{
			return default(ICNPICGMOCM<HICCHPCIPHD, AIDKDGHFPLJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public string EDDDAEGNADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x261F2F0", Offset = "0x261E6F0", VA = "0x18261F2F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public IEBAHENHLEA<DJONKGBCHFD> MBOFLIIPNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x261C440", Offset = "0x261B840", VA = "0x18261C440", Slot = "11")]
		get
		{
			return default(IEBAHENHLEA<DJONKGBCHFD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public ICNPICGMOCM<NJMBLJHEMGJ, FPEPDAKCCOK> CPANJPEFECG
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x993290", Offset = "0x992690", VA = "0x180993290", Slot = "12")]
		get
		{
			return default(ICNPICGMOCM<NJMBLJHEMGJ, FPEPDAKCCOK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public EECNAGIPCBM<NBDDIELADOM> FDMPNBFCANM
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0xB10960", Offset = "0xB0FD60", VA = "0x180B10960", Slot = "13")]
		get
		{
			return default(EECNAGIPCBM<NBDDIELADOM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? BOBPINDMDGC
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x261D170", Offset = "0x261C570", VA = "0x18261D170", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x261E140", Offset = "0x261D540", VA = "0x18261E140", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action? GIOAAIFMPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x261CD50", Offset = "0x261C150", VA = "0x18261CD50", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x261D360", Offset = "0x261C760", VA = "0x18261D360", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<EECNAGIPCBM<HICCHPCIPHD?>, EECNAGIPCBM<HICCHPCIPHD?>>? NPDFHJBIPJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x261EBC0", Offset = "0x261DFC0", VA = "0x18261EBC0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x261D980", Offset = "0x261CD80", VA = "0x18261D980", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<EECNAGIPCBM<HICCHPCIPHD?>, EECNAGIPCBM<HICCHPCIPHD?>>? IIGMCGJDBLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x261F230", Offset = "0x261E630", VA = "0x18261F230", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x261C380", Offset = "0x261B780", VA = "0x18261C380", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<EECNAGIPCBM<NJMBLJHEMGJ?>, EECNAGIPCBM<NJMBLJHEMGJ?>>? MLEOHAMBPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x26204D0", Offset = "0x261F8D0", VA = "0x1826204D0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x261F320", Offset = "0x261E720", VA = "0x18261F320", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<EECNAGIPCBM<NJMBLJHEMGJ?>, EECNAGIPCBM<NJMBLJHEMGJ?>>? LFJGHMNKJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x261DB00", Offset = "0x261CF00", VA = "0x18261DB00", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x261BD80", Offset = "0x261B180", VA = "0x18261BD80", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<EECNAGIPCBM<HICCHPCIPHD?>, AIDKDGHFPLJ?>? FHKGFIOAFJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x261D0B0", Offset = "0x261C4B0", VA = "0x18261D0B0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x261D590", Offset = "0x261C990", VA = "0x18261D590", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<EECNAGIPCBM<HICCHPCIPHD?>>? HBIOJBGGJGH
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x261DA40", Offset = "0x261CE40", VA = "0x18261DA40", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x261D4D0", Offset = "0x261C8D0", VA = "0x18261D4D0", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<EECNAGIPCBM<HICCHPCIPHD?>, AIDKDGHFPLJ?>? MDMBFFJCMLG
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x261F3E0", Offset = "0x261E7E0", VA = "0x18261F3E0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x2620590", Offset = "0x261F990", VA = "0x182620590", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<EECNAGIPCBM<NJMBLJHEMGJ?>, FPEPDAKCCOK?>? DLHCFIBNICF
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x261FED0", Offset = "0x261F2D0", VA = "0x18261FED0", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x261C460", Offset = "0x261B860", VA = "0x18261C460", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<EECNAGIPCBM<NJMBLJHEMGJ?>>? NBPJLKLCLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x261D410", Offset = "0x261C810", VA = "0x18261D410", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x261F7C0", Offset = "0x261EBC0", VA = "0x18261F7C0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<EECNAGIPCBM<NJMBLJHEMGJ?>, FPEPDAKCCOK?>? ICOLNABHEEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x261D8A0", Offset = "0x261CCA0", VA = "0x18261D8A0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x261BCA0", Offset = "0x261B0A0", VA = "0x18261BCA0", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x2620650", Offset = "0x261FA50", VA = "0x182620650")]
	private DOJNPNKKIIB(bool LLAHIHAIOJM, DJHNEBOJMKB EGMIBAJCGJC, bool MHPPDMOFFGF, ICNPICGMOCM<HICCHPCIPHD, JFPNAONGGLG> NNIOOLEBNGG, ICNPICGMOCM<HICCHPCIPHD, AIDKDGHFPLJ> MHPIIOMMLBK, BPKOHJDNEKO JOMDOBIKCNM, ICNPICGMOCM<NJMBLJHEMGJ, IEFFJHLMINL> FDNLBCHEHEB, ICNPICGMOCM<NJMBLJHEMGJ, FPEPDAKCCOK> HLPNLKIGHFM, string? NHNAMOMJGIL, JCFPOPJNPGC GFOKBGDKAOJ, EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, bool HBOPKMBIJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x261B5E0", Offset = "0x261A9E0", VA = "0x18261B5E0")]
	public static DOJNPNKKIIB AFLKMMODJAC(bool LLAHIHAIOJM, DJHNEBOJMKB EGMIBAJCGJC, bool MHPPDMOFFGF, BPKOHJDNEKO JOMDOBIKCNM, JCFPOPJNPGC GFOKBGDKAOJ, EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, bool HBOPKMBIJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x261C9B0", Offset = "0x261BDB0", VA = "0x18261C9B0", Slot = "69")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x261E790", Offset = "0x261DB90", VA = "0x18261E790", Slot = "38")]
	[AsyncStateMachine(typeof(FCMMHKCNJDK))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP?>>? KFBCFHMEKLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x261CE00", Offset = "0x261C200", VA = "0x18261CE00")]
	private (HHADAONIAGM?, int)? EMMCGABBILL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x261FF90", Offset = "0x261F390", VA = "0x18261FF90", Slot = "58")]
	private void PENGMPJLFNN(int AIABICOOIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x1E25F00", Offset = "0x1E25300", VA = "0x181E25F00", Slot = "57")]
	private void BHOGBBAMPLL(int AIABICOOIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x261E3C0", Offset = "0x261D7C0", VA = "0x18261E3C0", Slot = "61")]
	private void JPCKECJODPM(int BMFIBGECCIB, int CCNMHBKGDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x261E8E0", Offset = "0x261DCE0", VA = "0x18261E8E0", Slot = "63")]
	private void KGOIOIPKGNP(int BMFIBGECCIB, int CCNMHBKGDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x261F880", Offset = "0x261EC80", VA = "0x18261F880", Slot = "50")]
	private void OBDFPLDILAI(int AIABICOOIIC, EECNAGIPCBM<HICCHPCIPHD> PEAHEFMLMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x261D960", Offset = "0x261CD60", VA = "0x18261D960", Slot = "54")]
	private void GHPHJMDMMEJ(int OICAMEEFOOB, EECNAGIPCBM<HICCHPCIPHD> PEAHEFMLMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x261BD60", Offset = "0x261B160", VA = "0x18261BD60", Slot = "49")]
	private void BCGDDCJEKDL(int OICAMEEFOOB, EECNAGIPCBM<HICCHPCIPHD> PEAHEFMLMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2620080", Offset = "0x261F480", VA = "0x182620080", Slot = "53")]
	private void PIDLILLKOIE(int AIABICOOIIC, EECNAGIPCBM<HICCHPCIPHD> PEAHEFMLMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x261EA70", Offset = "0x261DE70", VA = "0x18261EA70", Slot = "66")]
	private void LEOLGHCOOGL(int AIABICOOIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x11DBA00", Offset = "0x11DAE00", VA = "0x1811DBA00", Slot = "65")]
	private void DOOOPILOHIN(int AIABICOOIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x261C8C0", Offset = "0x261BCC0", VA = "0x18261C8C0", Slot = "60")]
	private void DPDMCLFNGJN(int AIABICOOIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x1E25F00", Offset = "0x1E25300", VA = "0x181E25F00", Slot = "59")]
	private void PAGCGANCDNE(int AIABICOOIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x261C520", Offset = "0x261B920", VA = "0x18261C520", Slot = "62")]
	private void DDCHGEOAKBP(int BMFIBGECCIB, int CCNMHBKGDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x261E880", Offset = "0x261DC80", VA = "0x18261E880", Slot = "64")]
	private void KFLNIEDAJOA(int BMFIBGECCIB, int CCNMHBKGDFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x261EC80", Offset = "0x261E080", VA = "0x18261EC80", Slot = "52")]
	private void MLENCPIHEOH(int AIABICOOIIC, EECNAGIPCBM<NJMBLJHEMGJ> PEAHEFMLMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x261BC80", Offset = "0x261B080", VA = "0x18261BC80", Slot = "56")]
	private void ALAMELANOOA(int OICAMEEFOOB, EECNAGIPCBM<NJMBLJHEMGJ> PEAHEFMLMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x261F210", Offset = "0x261E610", VA = "0x18261F210", Slot = "51")]
	private void MLPPHPMIFIA(int OICAMEEFOOB, EECNAGIPCBM<NJMBLJHEMGJ> PEAHEFMLMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x261DBC0", Offset = "0x261CFC0", VA = "0x18261DBC0", Slot = "55")]
	private void HILAJIALNDN(int AIABICOOIIC, EECNAGIPCBM<NJMBLJHEMGJ> PEAHEFMLMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x261D210", Offset = "0x261C610", VA = "0x18261D210", Slot = "68")]
	private void FNFNOOJJKLO(int AIABICOOIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x11DBA00", Offset = "0x11DAE00", VA = "0x1811DBA00", Slot = "67")]
	private void OFCCINKJIEI(int AIABICOOIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x261E030", Offset = "0x261D430", VA = "0x18261E030", Slot = "39")]
	[AsyncStateMachine(typeof(BDCMHJLHNBL))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP?>>? IDENGFHLKFL(EECNAGIPCBM<GFAOCBCKMMM> CLEKIHEJJEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x261F6B0", Offset = "0x261EAB0", VA = "0x18261F6B0", Slot = "40")]
	[AsyncStateMachine(typeof(FLOCKFFHFLN))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP?>>? NKGDIBLCIAO(EECNAGIPCBM<FPPJALEEIOP> HPABFAJEOGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x261D650", Offset = "0x261CA50", VA = "0x18261D650", Slot = "41")]
	[AsyncStateMachine(typeof(OHEJEBDODLJ))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP?>>? FPICBEAJMFB(EECNAGIPCBM<GFAOCBCKMMM> CLEKIHEJJEC, EECNAGIPCBM<GFAOCBCKMMM> OFNEHKIHOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x261E1E0", Offset = "0x261D5E0", VA = "0x18261E1E0", Slot = "42")]
	[AsyncStateMachine(typeof(BMNLMBKICCK))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP?>>? IMMABJAGGEN(EECNAGIPCBM<FPPJALEEIOP> HPABFAJEOGG, EECNAGIPCBM<FPPJALEEIOP> OFNEHKIHOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x261F4A0", Offset = "0x261E8A0", VA = "0x18261F4A0", Slot = "43")]
	[AsyncStateMachine(typeof(MKDNKFPLJIK))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP?>>? NFOKPDCDDKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x261F590", Offset = "0x261E990", VA = "0x18261F590", Slot = "44")]
	[AsyncStateMachine(typeof(AMBCCCMEDIB))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> NJHENICLAFN(string KEEILLBICAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x261C250", Offset = "0x261B650", VA = "0x18261C250", Slot = "45")]
	[AsyncStateMachine(typeof(FLGMBIKJKHE))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> CBLBFCBPOAP(EECNAGIPCBM<GFAOCBCKMMM> CLEKIHEJJEC, string MPGDCPPMNJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x261D770", Offset = "0x261CB70", VA = "0x18261D770", Slot = "46")]
	[AsyncStateMachine(typeof(DBJLGNOJGAP))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> GGMKIFAJMBI(EECNAGIPCBM<FPPJALEEIOP> HPABFAJEOGG, string MPGDCPPMNJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x261E940", Offset = "0x261DD40", VA = "0x18261E940", Slot = "47")]
	[AsyncStateMachine(typeof(JAPLJAHNEGC))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> LDEBLHCHEHE(EECNAGIPCBM<GFAOCBCKMMM> CLEKIHEJJEC, PGCCEHDKJMM MAIGGPEPIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x261BB50", Offset = "0x261AF50", VA = "0x18261BB50", Slot = "48")]
	[AsyncStateMachine(typeof(JIGOGEHDKAK))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> AIHMEPLEJCD(EECNAGIPCBM<FPPJALEEIOP> HPABFAJEOGG, PGCCEHDKJMM MAIGGPEPIHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x261BE40", Offset = "0x261B240", VA = "0x18261BE40")]
	internal void BFIEGNMIKCF(EECNAGIPCBM<NBDDIELADOM> FIIKLGCIAGG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public sealed class IGMHMMGMENM : LAHKLODPGDN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public interface MFOKDBPCJIG
	{
		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public readonly struct DMGKGLBHDHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public readonly IReadOnlyDictionary<IEBAHENHLEA<JJJHHLABGOM>, Guid>? JMDDLLHBMEE;

			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC670E0", VA = "0x180C67CE0")]
			public DMGKGLBHDHL(IReadOnlyDictionary<IEBAHENHLEA<JJJHHLABGOM>, Guid>? JMDDLLHBMEE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		PAJOEFEBPCI HHNMGPNKPCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<DAAAEMKKFPO> LCOMLDEMPGN(CancellationToken BLABAMPAGAH);

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<EKENJADJMDF> EJFNNCEIFJD(CancellationToken BLABAMPAGAH);

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<PBLEPHJAMPK> KMAMEDJHIIO(CancellationToken BLABAMPAGAH);

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<KBLNENNOAFL> KGMDJHPNCAK(CancellationToken BLABAMPAGAH);

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<DMGKGLBHDHL> BANBGJBNHCI(CancellationToken BLABAMPAGAH);

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<PDCOEAFHPAK> LBGAKOLECAE(CancellationToken BLABAMPAGAH);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct AKGGBFDFDDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public AsyncTaskMethodBuilder<IGMHMMGMENM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public DJHNEBOJMKB circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public DAAAEMKKFPO roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public EKENJADJMDF superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private MFOKDBPCJIG <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private DAAAEMKKFPO <downloadedRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private DAAAEMKKFPO <actualRoomData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private PDCOEAFHPAK <actualStaticConfig>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private EKENJADJMDF <finalSuperRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private PBLEPHJAMPK <roomAssetData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private KBLNENNOAFL <playerSaveData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private TaskAwaiter<DAAAEMKKFPO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private DAAAEMKKFPO <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<PDCOEAFHPAK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<EKENJADJMDF> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private TaskAwaiter<PBLEPHJAMPK> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private TaskAwaiter<KBLNENNOAFL> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private TaskAwaiter<MFOKDBPCJIG.DMGKGLBHDHL> <>u__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private TaskAwaiter<JFCLCBLPGED> <>u__7;

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x2616100", Offset = "0x2615500", VA = "0x182616100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x26171D0", Offset = "0x26165D0", VA = "0x1826171D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private readonly JFCLCBLPGED OPEGEKFBAED;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public JFCLCBLPGED MNBJKKJGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	private IGMHMMGMENM(JFCLCBLPGED BBLNAIHDBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0x2624EA0", Offset = "0x26242A0", VA = "0x182624EA0")]
	[AsyncStateMachine(typeof(AKGGBFDFDDI))]
	public static Task<IGMHMMGMENM> AGCAEOGDOPN(DJHNEBOJMKB EGMIBAJCGJC, DAAAEMKKFPO? BDAPIDPALOK, EKENJADJMDF? EDHFJOANBFH, CancellationToken BLABAMPAGAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x2625010", Offset = "0x2624410", VA = "0x182625010", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public readonly struct NEMGLABGMNM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct AECEPBAGOGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<object, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public NEMGLABGMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public IJHNHGOIIEG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private TaskAwaiter<AEAAIINGJNL<object, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x26148D0", Offset = "0x2613CD0", VA = "0x1826148D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2614B60", Offset = "0x2613F60", VA = "0x182614B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct MIKJIPINPNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<bool, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public JOFFGAJEOAD rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public DAAAEMKKFPO circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public EKENJADJMDF superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public NEMGLABGMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private IJHNHGOIIEG[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private TaskAwaiter<AEAAIINGJNL<object, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x262DE40", Offset = "0x262D240", VA = "0x18262DE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x262E220", Offset = "0x262D620", VA = "0x18262E220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct AODDMGLLJFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public NEMGLABGMNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private TaskAwaiter<AEAAIINGJNL<object, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x2617780", Offset = "0x2616B80", VA = "0x182617780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x26179C0", Offset = "0x2616DC0", VA = "0x1826179C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private readonly NEGLMDBBMLE ONKIPENHAPK;

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0xC67CE0", Offset = "0xC670E0", VA = "0x180C67CE0")]
	public NEMGLABGMNM(NEGLMDBBMLE BKFLLLKFECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x262ED90", Offset = "0x262E190", VA = "0x18262ED90")]
	[AsyncStateMachine(typeof(AECEPBAGOGD))]
	private Task<AEAAIINGJNL<object, GJDNFLPCNNP>> KFLHDDIJBBK(IJHNHGOIIEG AKLHLNJOCEK, bool LECKBHBGKBF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x262EEC0", Offset = "0x262E2C0", VA = "0x18262EEC0")]
	[AsyncStateMachine(typeof(MIKJIPINPNP))]
	public Task<AEAAIINGJNL<bool, GJDNFLPCNNP?>>? MDMKEGHMJNP(int ELJPGAILLJI, JOFFGAJEOAD? NLKDNDLFMAK, DAAAEMKKFPO? IJGCGJIIJKL, EKENJADJMDF? EDHFJOANBFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x262ECA0", Offset = "0x262E0A0", VA = "0x18262ECA0")]
	[AsyncStateMachine(typeof(AODDMGLLJFO))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> DPGGICHIMDD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public sealed class GFPFCLCLMCK : CKKKMJLDAPJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private readonly JOMLLANPIFO GDJPCCLOAFO;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public JOMLLANPIFO JHHGBNCIMFC
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	private GFPFCLCLMCK(JOMLLANPIFO IJPGMHNHCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x26238C0", Offset = "0x2622CC0", VA = "0x1826238C0")]
	public static GFPFCLCLMCK OJJOMCGFFJC(DJHNEBOJMKB EGMIBAJCGJC, JOFFGAJEOAD FHABEGGDEAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x26238A0", Offset = "0x2622CA0", VA = "0x1826238A0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public interface ACFCLILAAPO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	JFCLCBLPGED MNBJKKJGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	GPBAAJANPDN AMOOINHEBDB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	COINHKMADKL FPCJHEOLHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	LFOLNLEMMBJ FLFPDHIBEGG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public interface DJDAGJGAJNO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	ACFCLILAAPO? BFMJDCCDPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	bool NFLEONEBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	bool DKGNFPDJAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<ACFCLILAAPO?>? LCIHMLHPFBJ();

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task MAKJPMJEFIC(DJHNEBOJMKB EGMIBAJCGJC, JOFFGAJEOAD FHABEGGDEAK, DAAAEMKKFPO? LCADMIDFFFI, EKENJADJMDF? CKNLBPIIMCE);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[BHADCGLBNFD("IStaticCV2Instance")]
public interface LAHKLODPGDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	JFCLCBLPGED MNBJKKJGHLN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[BHADCGLBNFD("IStaticEVInstance")]
public interface CKKKMJLDAPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	JOMLLANPIFO JHHGBNCIMFC
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class MNFICPHGGIG
{
	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x262E780", Offset = "0x262DB80", VA = "0x18262E780")]
	public static HCJMMGBLEBD<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB, JCAMIECDDEF.FOIFKKFBMDJ<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB>> NJPNEKMICAI([In] this HCJMMGBLEBD<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB, JCAMIECDDEF.FOIFKKFBMDJ<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB>> NPKDLKCDCGB)
	{
		return default(HCJMMGBLEBD<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB, JCAMIECDDEF.FOIFKKFBMDJ<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class BPMAKMBHLND : AGBKEPLGOPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private readonly DJHNEBOJMKB HOMGCJPPDEM;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool DKGNFPDJAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x26194E0", Offset = "0x26188E0", VA = "0x1826194E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	internal BPMAKMBHLND(DJHNEBOJMKB EGMIBAJCGJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal sealed class FCLMGEBHDLM : BLAHGDPPDCH
{
	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x2620940", Offset = "0x261FD40", VA = "0x182620940", Slot = "4")]
	public KBINDKFIBFL? CBIIDFHACMB(string? KLELKFDGBKN, string? NFJDKJPCHLC, string? JGJBPCEEMIF, BBFOJLMAODD.NAJEIAFHJNM.OEADJBNGOAI OOFHOPPBEHK, bool JACGCKCJCJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public FCLMGEBHDLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class BLMADFMAKJO : EOJAHLPCJOG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct BDCALLCHLNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public AsyncTaskMethodBuilder<JKEAOGPLPFE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public BLMADFMAKJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private TaskAwaiter<ACFCLILAAPO?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x2617A30", Offset = "0x2616E30", VA = "0x182617A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x2617CE0", Offset = "0x26170E0", VA = "0x182617CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private readonly DJHNEBOJMKB HOMGCJPPDEM;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public JKEAOGPLPFE? DMADMDPHOOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x2618B40", Offset = "0x2617F40", VA = "0x182618B40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public LFOLNLEMMBJ? APHJJNBHDFP
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x2618A60", Offset = "0x2617E60", VA = "0x182618A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool BOEFABNGJHK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x2618AE0", Offset = "0x2617EE0", VA = "0x182618AE0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool DEKHCPHIHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x26186E0", Offset = "0x2617AE0", VA = "0x1826186E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x2618F30", Offset = "0x2618330", VA = "0x182618F30")]
	internal BLMADFMAKJO(DJHNEBOJMKB EGMIBAJCGJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x2618450", Offset = "0x2617850", VA = "0x182618450", Slot = "7")]
	[AsyncStateMachine(typeof(BDCALLCHLNJ))]
	public Task<JKEAOGPLPFE> CHOKOJFLHCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x2618BC0", Offset = "0x2617FC0", VA = "0x182618BC0", Slot = "9")]
	public IReadOnlyDictionary<IEBAHENHLEA<JJJHHLABGOM>, Guid> PDJBLGGGLEO(IEnumerable<EBFEMKEPGFD> JPPNCKGBDBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x2618740", Offset = "0x2617B40", VA = "0x182618740", Slot = "10")]
	public LOEPLDJCOLJ EMKFGKMPHGL(IEnumerable<EBFEMKEPGFD> JPPNCKGBDBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x2618540", Offset = "0x2617940", VA = "0x182618540")]
	public AEAAIINGJNL<EHPPDLFJFMN, EPFFDEGDAEO> EHAMGOEHECD([In] EHPPDLFJFMN CLNFMIOOIOL)
	{
		return default(AEAAIINGJNL<EHPPDLFJFMN, EPFFDEGDAEO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x26188C0", Offset = "0x2617CC0", VA = "0x1826188C0", Slot = "8")]
	private AEAAIINGJNL<EHPPDLFJFMN, EPFFDEGDAEO> HOELDGAKBOP([In] EHPPDLFJFMN CLNFMIOOIOL)
	{
		return default(AEAAIINGJNL<EHPPDLFJFMN, EPFFDEGDAEO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class LFOLNLEMMBJ : JKEAOGPLPFE
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	internal static class FPLHOJFCMBE
	{
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class OBGENKLKKPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			public JFCLCBLPGED state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400029C")]
			public AFFPINOIDCK spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public OBGENKLKKPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x2637520", Offset = "0x2636920", VA = "0x182637520")]
			internal bool HHLHFLJPOJI(GLEDMEBDEEF n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class HNKDEHBNDJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029D")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
			public HNKDEHBNDJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0x2636860", Offset = "0x2635C60", VA = "0x182636860")]
			internal void KIDHFNPOKPP(GLEDMEBDEEF n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x2621840", Offset = "0x2620C40", VA = "0x182621840")]
		public static AEAAIINGJNL<JKEAOGPLPFE.BDEGFDOELKN, EIBOIADIOGN> CAFDDKMELKN(LFOLNLEMMBJ CAMFIHKHJNG, [In] JKEAOGPLPFE.MMEOKBIMPLH JOIGLCNPHIH)
		{
			return default(AEAAIINGJNL<JKEAOGPLPFE.BDEGFDOELKN, EIBOIADIOGN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x2621DB0", Offset = "0x26211B0", VA = "0x182621DB0")]
		internal static AEAAIINGJNL<(PACNOBDPBEH, NBEIAGBHDLI), EIBOIADIOGN> HEKPKDAFGCL(LFOLNLEMMBJ CAMFIHKHJNG, NBEIAGBHDLI LNADPIILIHC, bool OKBKPAOGGHG, [In] IEBAHENHLEA<JJJHHLABGOM> IGBEDKLHICF, [In] int? GECCHKJFLDL, [In] AGDIGDNFMBO? ONGDNJNAONJ, [In] AGDIGDNFMBO? EMLCODOLKDB)
		{
			return default(AEAAIINGJNL<(PACNOBDPBEH, NBEIAGBHDLI), EIBOIADIOGN>);
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x2622FD0", Offset = "0x26223D0", VA = "0x182622FD0")]
		private static void KHNOGHCLFHI(bool OKBKPAOGGHG, EBFEMKEPGFD IBPIFPONGON, PACNOBDPBEH BKICILIFBKK, [In] IEBAHENHLEA<JJJHHLABGOM> IGBEDKLHICF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x2622BC0", Offset = "0x2621FC0", VA = "0x182622BC0")]
		public static void KGGFEJPAKJC(KLOIJACNDNF NFIMJKCPLAG, [In] JKEAOGPLPFE.LFHHGCFOOLJ BMDEJDIIDHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x2623450", Offset = "0x2622850", VA = "0x182623450")]
		[CompilerGenerated]
		internal static bool MJPKMAONIGP(JFCLCBLPGED MNCLBPINKGC, AFFPINOIDCK PEKAHGAOPNH, GLEDMEBDEEF EAELFJNPCHI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x2621D80", Offset = "0x2621180", VA = "0x182621D80")]
		[CompilerGenerated]
		internal static bool GNICCEPMLOH(GLEDMEBDEEF DBBKCMNDDPN)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct DHKABLMMMPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public LFOLNLEMMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public EECNAGIPCBM<JJJHHLABGOM> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public EECNAGIPCBM<DJONKGBCHFD> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public BHMHOLKPBFF offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public bool deleteBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x26326A0", Offset = "0x2631AA0", VA = "0x1826326A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x26328F0", Offset = "0x2631CF0", VA = "0x1826328F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct EKFAKGOHMCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public LFOLNLEMMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public EECNAGIPCBM<JJJHHLABGOM> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public IEBAHENHLEA<DJONKGBCHFD> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public List<EECNAGIPCBM<DJONKGBCHFD>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public BHMHOLKPBFF localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public BIJNJDLMCFA localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public BHMHOLKPBFF offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x2633CF0", Offset = "0x26330F0", VA = "0x182633CF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x2633FB0", Offset = "0x26333B0", VA = "0x182633FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct LNEINPCGCBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public LFOLNLEMMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public EECNAGIPCBM<JJJHHLABGOM> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		public IEBAHENHLEA<DJONKGBCHFD> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public List<EECNAGIPCBM<DJONKGBCHFD>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x2636EC0", Offset = "0x26362C0", VA = "0x182636EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x2637100", Offset = "0x2636500", VA = "0x182637100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct FCKAFOJGKCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public LFOLNLEMMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public EECNAGIPCBM<JJJHHLABGOM> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public IEBAHENHLEA<DJONKGBCHFD> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public EECNAGIPCBM<JJJHHLABGOM> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public List<EECNAGIPCBM<DJONKGBCHFD>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x2634020", Offset = "0x2633420", VA = "0x182634020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x2634260", Offset = "0x2633660", VA = "0x182634260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct EHFNKDBNKML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public LFOLNLEMMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public IEBAHENHLEA<JJJHHLABGOM> legacyGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public IEBAHENHLEA<DJONKGBCHFD> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public IReadOnlyList<IEBAHENHLEA<DJONKGBCHFD>> nodeLegacyIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public IReadOnlyDictionary<BBHKKNFEHIE, (EECNAGIPCBM<NBDDIELADOM>, EECNAGIPCBM<HICCHPCIPHD>)> inputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public IReadOnlyDictionary<NMLOOHDKDDB, (EECNAGIPCBM<NBDDIELADOM>, EECNAGIPCBM<NJMBLJHEMGJ>)> outputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x2633660", Offset = "0x2632A60", VA = "0x182633660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x2633C90", Offset = "0x2633090", VA = "0x182633C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct GNJIANMGBOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public LFOLNLEMMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public EECNAGIPCBM<JJJHHLABGOM> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public EECNAGIPCBM<BPHLKFKIMPM> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public EECNAGIPCBM<BOBCICDOPCN> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2635FB0", Offset = "0x26353B0", VA = "0x182635FB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x2636600", Offset = "0x2635A00", VA = "0x182636600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct NCAKGLBJMPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public LFOLNLEMMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public IEBAHENHLEA<DJONKGBCHFD> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public IEBAHENHLEA<JJJHHLABGOM> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public EECNAGIPCBM<NBDDIELADOM> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public EECNAGIPCBM<HICCHPCIPHD> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x2637170", Offset = "0x2636570", VA = "0x182637170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x26374B0", Offset = "0x26368B0", VA = "0x1826374B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct FMDGCCCAAGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public LFOLNLEMMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public IEBAHENHLEA<DJONKGBCHFD> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public IEBAHENHLEA<JJJHHLABGOM> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public EECNAGIPCBM<NBDDIELADOM> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public EECNAGIPCBM<NJMBLJHEMGJ> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x2635B60", Offset = "0x2634F60", VA = "0x182635B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x2635EA0", Offset = "0x26352A0", VA = "0x182635EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct BINFDAFPJBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public LFOLNLEMMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private TaskAwaiter<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x2632230", Offset = "0x2631630", VA = "0x182632230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x2632450", Offset = "0x2631850", VA = "0x182632450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private readonly DJHNEBOJMKB HOMGCJPPDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private readonly LAHKLODPGDN ALGDCGCLECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private readonly CKKKMJLDAPJ CFDCJLJNJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private readonly DLAPHFJGCDO OGFJEOKELHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private readonly BLMADFMAKJO MMKIMMNBJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private Dictionary<IEBAHENHLEA<DJONKGBCHFD>, JJPIPKOGLIO> CDOFKIMOCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	[CompilerGenerated]
	private Action<IEBAHENHLEA<DJONKGBCHFD>>? DACJJDAPLLE;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public IEBAHENHLEA<JJJHHLABGOM> HBFILHILCAF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x26284B0", Offset = "0x26278B0", VA = "0x1826284B0", Slot = "4")]
		get
		{
			return default(IEBAHENHLEA<JJJHHLABGOM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public DLAPHFJGCDO LABBJLPMNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x26038C0", Offset = "0x2602CC0", VA = "0x1826038C0", Slot = "5")]
		get
		{
			return default(DLAPHFJGCDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x262D650", Offset = "0x262CA50", VA = "0x18262D650")]
	public LFOLNLEMMBJ(DJHNEBOJMKB EGMIBAJCGJC, LAHKLODPGDN MMDMGLMFBGG, CKKKMJLDAPJ GIDLGACHPBN, BLMADFMAKJO ACIBIKFNIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x26274F0", Offset = "0x26268F0", VA = "0x1826274F0", Slot = "65")]
	public EECNAGIPCBM<KNJNFDCAPDP> BPJBLCJPOCK(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP)
	{
		return default(EECNAGIPCBM<KNJNFDCAPDP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x262C530", Offset = "0x262B930", VA = "0x18262C530", Slot = "66")]
	public EECNAGIPCBM<HHIAEMDAKGK> LJEIIFDJIMH(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BPHLKFKIMPM> CLMAEMHEFIF)
	{
		return default(EECNAGIPCBM<HHIAEMDAKGK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x26277B0", Offset = "0x2626BB0", VA = "0x1826277B0", Slot = "6")]
	public (bool, bool) DFKBFDEBLCJ(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BPHLKFKIMPM> CMABHCGNAMF, EECNAGIPCBM<BOBCICDOPCN> EOKNBAMNPJE)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2627CB0", Offset = "0x26270B0", VA = "0x182627CB0")]
	public bool DGKJEGHAEAC(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, [In] OOHCKOAJCGO IHCNNCPHKDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x2626880", Offset = "0x2625C80", VA = "0x182626880", Slot = "8")]
	public bool ABOMPEEEOOL(AIDKDGHFPLJ HFPMABFGFMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x262D360", Offset = "0x262C760", VA = "0x18262D360", Slot = "9")]
	public bool PCLFMCIEFMD(FPEPDAKCCOK NMDIBNPIGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2626900", Offset = "0x2625D00", VA = "0x182626900", Slot = "10")]
	public LKMEGEJFEKK? AEIOIHLJEFJ(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x2626D00", Offset = "0x2626100", VA = "0x182626D00", Slot = "11")]
	public OPEGJIIOHOL? AKPPKEPOMKP(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BPHLKFKIMPM> CLMAEMHEFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x26293D0", Offset = "0x26287D0", VA = "0x1826293D0", Slot = "12")]
	public EECNAGIPCBM<BPHLKFKIMPM>? HBNIMCCNPOJ(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<DJONKGBCHFD> GNBPFKJNJLF, EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, EECNAGIPCBM<NJMBLJHEMGJ> DLNGNEBLCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x262CF80", Offset = "0x262C380", VA = "0x18262CF80", Slot = "13")]
	public EECNAGIPCBM<BOBCICDOPCN>? OHDOGIKMJGH(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<DJONKGBCHFD> GNBPFKJNJLF, EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, EECNAGIPCBM<HICCHPCIPHD> FEFGMNOLHFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x262B3E0", Offset = "0x262A7E0", VA = "0x18262B3E0", Slot = "14")]
	public IEnumerable<EECNAGIPCBM<JJJHHLABGOM>> JLLNPDBAIFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x2629520", Offset = "0x2628920", VA = "0x182629520", Slot = "15")]
	public IEnumerable<EECNAGIPCBM<AFJOLFCJBPJ>> HPDKADIAEAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x262D2F0", Offset = "0x262C6F0", VA = "0x18262D2F0", Slot = "16")]
	public string PBLJCEDNBIA(EECNAGIPCBM<AFJOLFCJBPJ> EFJOLPNGLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x2627630", Offset = "0x2626A30", VA = "0x182627630", Slot = "17")]
	public string DBGAPAAPPNA(EECNAGIPCBM<AFJOLFCJBPJ> EFJOLPNGLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x2626FA0", Offset = "0x26263A0", VA = "0x182626FA0")]
	public JJPIPKOGLIO? BGBKHBNAIPE([In] IEBAHENHLEA<DJONKGBCHFD> GNBPFKJNJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x2627FE0", Offset = "0x26273E0", VA = "0x182627FE0", Slot = "23")]
	public EECNAGIPCBM<APMGFEHLJPN> DIBAGOMDHBK(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<DJONKGBCHFD> GNBPFKJNJLF)
	{
		return default(EECNAGIPCBM<APMGFEHLJPN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2626EB0", Offset = "0x26262B0", VA = "0x182626EB0")]
	public EECNAGIPCBM<DJONKGBCHFD> MDGOABOPGJD(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, [In] IEBAHENHLEA<DJONKGBCHFD> PONBILFJKBH)
	{
		return default(EECNAGIPCBM<DJONKGBCHFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x2626B10", Offset = "0x2625F10", VA = "0x182626B10", Slot = "33")]
	public EECNAGIPCBM<DJONKGBCHFD> AGLDBKJGMDL(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP)
	{
		return default(EECNAGIPCBM<DJONKGBCHFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x262B470", Offset = "0x262A870", VA = "0x18262B470", Slot = "34")]
	public EECNAGIPCBM<DJONKGBCHFD> JLNIIPAIFHN(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BPHLKFKIMPM> CLMAEMHEFIF)
	{
		return default(EECNAGIPCBM<DJONKGBCHFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x262B5A0", Offset = "0x262A9A0", VA = "0x18262B5A0")]
	public EECNAGIPCBM<DJONKGBCHFD>? JPMOONDIAJE(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, [In] IEBAHENHLEA<DJONKGBCHFD> PONBILFJKBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x2628B10", Offset = "0x2627F10", VA = "0x182628B10", Slot = "25")]
	public PMNPIABGANI? FPLLGMHNDBJ(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2626E50", Offset = "0x2626250", VA = "0x182626E50", Slot = "26")]
	public long APDKBECOEHA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x2628120", Offset = "0x2627520", VA = "0x182628120")]
	private void DODBEHIPDBK(IEBAHENHLEA<DJONKGBCHFD> GNBPFKJNJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x262B4F0", Offset = "0x262A8F0", VA = "0x18262B4F0", Slot = "31")]
	public IEnumerable<(EECNAGIPCBM<JJJHHLABGOM>, EECNAGIPCBM<DJONKGBCHFD>)> JOOGCHJGFBH(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x262D010", Offset = "0x262C410", VA = "0x18262D010", Slot = "32")]
	public EECNAGIPCBM<BOBCICDOPCN> OHDOGIKMJGH(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<DJONKGBCHFD> GNBPFKJNJLF, EECNAGIPCBM<KNJNFDCAPDP> FEFGMNOLHFG)
	{
		return default(EECNAGIPCBM<BOBCICDOPCN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2629460", Offset = "0x2628860", VA = "0x182629460", Slot = "35")]
	public EECNAGIPCBM<BPHLKFKIMPM> HBNIMCCNPOJ(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<DJONKGBCHFD> GNBPFKJNJLF, EECNAGIPCBM<HHIAEMDAKGK> DLNGNEBLCOK)
	{
		return default(EECNAGIPCBM<BPHLKFKIMPM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x262D5A0", Offset = "0x262C9A0", VA = "0x18262D5A0")]
	private JJPIPKOGLIO? PLIMKAEDJHM([In] IEBAHENHLEA<DJONKGBCHFD> GNBPFKJNJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x2626DC0", Offset = "0x26261C0", VA = "0x182626DC0")]
	public BPKOHJDNEKO? ANHIGLGPKCE([In] IEBAHENHLEA<DJONKGBCHFD> GNBPFKJNJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x26294F0", Offset = "0x26288F0", VA = "0x1826294F0")]
	public FOBIELMFHMM? LEOPMGHAKBM([In] IEBAHENHLEA<JJJHHLABGOM> LJPNEOLHCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x262ABC0", Offset = "0x2629FC0", VA = "0x18262ABC0", Slot = "27")]
	public IEnumerable<BOJBCNOKBBG> JHBJNFPMICC(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x2628090", Offset = "0x2627490", VA = "0x182628090", Slot = "28")]
	public bool DLHFODGLICM(EECNAGIPCBM<AFJOLFCJBPJ> EFJOLPNGLOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x262C5B0", Offset = "0x262B9B0", VA = "0x18262C5B0", Slot = "29")]
	public IEnumerable<OOHCKOAJCGO> LPEKHCBAGCC(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BPHLKFKIMPM> CMABHCGNAMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x262C990", Offset = "0x262BD90", VA = "0x18262C990", Slot = "30")]
	public IEnumerable<OOHCKOAJCGO> MCOOLJPAPLF(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BOBCICDOPCN> EOKNBAMNPJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2628510", Offset = "0x2627910", VA = "0x182628510")]
	public EECNAGIPCBM<JJJHHLABGOM> FAMNBJNNACD([In] IEBAHENHLEA<JJJHHLABGOM> LJPNEOLHCOO)
	{
		return default(EECNAGIPCBM<JJJHHLABGOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x2627110", Offset = "0x2626510", VA = "0x182627110")]
	public EECNAGIPCBM<JJJHHLABGOM>? BLEBLMLAMIE([In] IEBAHENHLEA<JJJHHLABGOM> LJPNEOLHCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x2627570", Offset = "0x2626970", VA = "0x182627570")]
	private AFFPINOIDCK? DBEFHKBDBPC([In] IEBAHENHLEA<JJJHHLABGOM> LJPNEOLHCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x26294F0", Offset = "0x26288F0", VA = "0x1826294F0")]
	private FOBIELMFHMM? MGNBHPIAHGC([In] IEBAHENHLEA<JJJHHLABGOM> LJPNEOLHCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x26273C0", Offset = "0x26267C0", VA = "0x1826273C0", Slot = "21")]
	public EECNAGIPCBM<JJJHHLABGOM>? BNKPFMGHBDH(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<DJONKGBCHFD> GNBPFKJNJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x262A020", Offset = "0x2629420", VA = "0x18262A020", Slot = "39")]
	public IEBAHENHLEA<JJJHHLABGOM> IBNLGGMPDEJ(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO)
	{
		return default(IEBAHENHLEA<JJJHHLABGOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x26276A0", Offset = "0x2626AA0", VA = "0x1826276A0", Slot = "36")]
	public IEnumerable<PGCCEHDKJMM> DCAFDNPGENC(LJMKDLLFMLE KLEPNKCFGHC, bool IDLHNOBEHHE, bool LOPLOPBHMCJ, bool ABLCDABCPME, bool OCJFKIACBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x262A1F0", Offset = "0x26295F0", VA = "0x18262A1F0", Slot = "37")]
	public PGCCEHDKJMM IIJJHKNNMEM(LJMKDLLFMLE KLEPNKCFGHC, KALOLKFHOKO PHAHLKKNJDI, bool IDLHNOBEHHE, bool LOPLOPBHMCJ, bool ABLCDABCPME, bool OCJFKIACBFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2626B90", Offset = "0x2625F90", VA = "0x182626B90")]
	public BOJBCNOKBBG JJEOCODAEHH(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, [In] OOHCKOAJCGO IHCNNCPHKDE)
	{
		return default(BOJBCNOKBBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2627190", Offset = "0x2626590", VA = "0x182627190", Slot = "40")]
	public OOHCKOAJCGO BMICBJLAFCF(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BPHLKFKIMPM> CMABHCGNAMF, EECNAGIPCBM<BOBCICDOPCN> EOKNBAMNPJE)
	{
		return default(OOHCKOAJCGO);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x26269C0", Offset = "0x2625DC0", VA = "0x1826269C0", Slot = "41")]
	[AsyncStateMachine(typeof(DHKABLMMMPC))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> AFNFMKLBGLA(EECNAGIPCBM<JJJHHLABGOM> GJFGEPCEPKM, EECNAGIPCBM<DJONKGBCHFD> ICMHLAFAMCB, BHMHOLKPBFF NPELPNMIGOA, bool MPNHDFPKAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2628990", Offset = "0x2627D90", VA = "0x182628990", Slot = "42")]
	[AsyncStateMachine(typeof(EKFAKGOHMCD))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> FNEOLPAGOEI(EECNAGIPCBM<JJJHHLABGOM> GJFGEPCEPKM, IEBAHENHLEA<DJONKGBCHFD> ICMHLAFAMCB, List<EECNAGIPCBM<DJONKGBCHFD>> IKHBGDFGLAF, BHMHOLKPBFF POAJNHALNJN, BIJNJDLMCFA LDKDDMGMKHG, BHMHOLKPBFF NPELPNMIGOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x262D450", Offset = "0x262C850", VA = "0x18262D450", Slot = "45")]
	[AsyncStateMachine(typeof(LNEINPCGCBE))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> PGPKJICBJHI(EECNAGIPCBM<JJJHHLABGOM> GJFGEPCEPKM, IEBAHENHLEA<DJONKGBCHFD> ICMHLAFAMCB, List<EECNAGIPCBM<DJONKGBCHFD>> IKHBGDFGLAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x262D0A0", Offset = "0x262C4A0", VA = "0x18262D0A0", Slot = "46")]
	[AsyncStateMachine(typeof(FCKAFOJGKCG))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> PABMLBMJMCP(EECNAGIPCBM<JJJHHLABGOM> GJFGEPCEPKM, IEBAHENHLEA<DJONKGBCHFD> ICMHLAFAMCB, EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, List<EECNAGIPCBM<DJONKGBCHFD>> IKHBGDFGLAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x262B270", Offset = "0x262A670", VA = "0x18262B270", Slot = "43")]
	public (IReadOnlyDictionary<BBHKKNFEHIE, (EECNAGIPCBM<NBDDIELADOM>, EECNAGIPCBM<HICCHPCIPHD>)>, IReadOnlyDictionary<NMLOOHDKDDB, (EECNAGIPCBM<NBDDIELADOM>, EECNAGIPCBM<NJMBLJHEMGJ>)>) JJNEAOECHBP(IEBAHENHLEA<JJJHHLABGOM> JBLIPBFMGBD, EECNAGIPCBM<DJONKGBCHFD> ICMHLAFAMCB)
	{
		return default((IReadOnlyDictionary<BBHKKNFEHIE, (EECNAGIPCBM<NBDDIELADOM>, EECNAGIPCBM<HICCHPCIPHD>)>, IReadOnlyDictionary<NMLOOHDKDDB, (EECNAGIPCBM<NBDDIELADOM>, EECNAGIPCBM<NJMBLJHEMGJ>)>));
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x262B120", Offset = "0x262A520", VA = "0x18262B120", Slot = "44")]
	[AsyncStateMachine(typeof(EHFNKDBNKML))]
	public Task JICILGIGNCC(IEBAHENHLEA<JJJHHLABGOM> JBLIPBFMGBD, IEBAHENHLEA<DJONKGBCHFD> ICMHLAFAMCB, IReadOnlyList<IEBAHENHLEA<DJONKGBCHFD>> BCPDPIMNMJC, IReadOnlyDictionary<BBHKKNFEHIE, (EECNAGIPCBM<NBDDIELADOM>, EECNAGIPCBM<HICCHPCIPHD>)> NJPMHHMLMJB, IReadOnlyDictionary<NMLOOHDKDDB, (EECNAGIPCBM<NBDDIELADOM>, EECNAGIPCBM<NJMBLJHEMGJ>)> NIDBBAEJHFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x262CDE0", Offset = "0x262C1E0", VA = "0x18262CDE0", Slot = "47")]
	public bool ODPJKBJCIND(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2628910", Offset = "0x2627D10", VA = "0x182628910", Slot = "48")]
	public bool FLLKEGGDFLP(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x2628E00", Offset = "0x2628200", VA = "0x182628E00", Slot = "49")]
	public bool GFLEEFBCMLP(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BPHLKFKIMPM> CLMAEMHEFIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2628060", Offset = "0x2627460", VA = "0x182628060")]
	public AEAAIINGJNL<JKEAOGPLPFE.BDEGFDOELKN, EIBOIADIOGN> DLLPPMFDNNH([In] JKEAOGPLPFE.MMEOKBIMPLH JOIGLCNPHIH)
	{
		return default(AEAAIINGJNL<JKEAOGPLPFE.BDEGFDOELKN, EIBOIADIOGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x262CE50", Offset = "0x262C250", VA = "0x18262CE50", Slot = "51")]
	[AsyncStateMachine(typeof(GNJIANMGBOF))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> OGHHBNIEABB(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<BPHLKFKIMPM> CMABHCGNAMF, EECNAGIPCBM<BOBCICDOPCN> EOKNBAMNPJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x262C110", Offset = "0x262B510", VA = "0x18262C110", Slot = "52")]
	public AEAAIINGJNL<CGINHGKIHNF, EPFFDEGDAEO> LAAAOEALGCL(IEBAHENHLEA<JJJHHLABGOM> LJPNEOLHCOO, CGINHGKIHNF GCDBBJMCCAM, BIJNJDLMCFA KBEINNJJJMO)
	{
		return default(AEAAIINGJNL<CGINHGKIHNF, EPFFDEGDAEO>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x262C830", Offset = "0x262BC30", VA = "0x18262C830", Slot = "53")]
	[AsyncStateMachine(typeof(NCAKGLBJMPJ))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> MACOMMAGKKN(IEBAHENHLEA<JJJHHLABGOM> LJPNEOLHCOO, IEBAHENHLEA<DJONKGBCHFD> CMELHOKCDFA, EECNAGIPCBM<NBDDIELADOM> JNACMOALMLA, EECNAGIPCBM<HICCHPCIPHD> MFEIHBHGIDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x262A090", Offset = "0x2629490", VA = "0x18262A090", Slot = "54")]
	[AsyncStateMachine(typeof(FMDGCCCAAGI))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> IGJOFNBAEMN(IEBAHENHLEA<JJJHHLABGOM> LJPNEOLHCOO, IEBAHENHLEA<DJONKGBCHFD> MAFHMMIMOPE, EECNAGIPCBM<NBDDIELADOM> FNOGDGFINFC, EECNAGIPCBM<NJMBLJHEMGJ> CLMAEMHEFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2628390", Offset = "0x2627790", VA = "0x182628390", Slot = "55")]
	public MIHBFHEALDD ELKPEHMODJB()
	{
		return default(MIHBFHEALDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x262B620", Offset = "0x262AA20", VA = "0x18262B620", Slot = "56")]
	public MIHBFHEALDD KDPHELOIFKE()
	{
		return default(MIHBFHEALDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x2628E90", Offset = "0x2628290", VA = "0x182628E90", Slot = "58")]
	public BCKKNDPGFGN GMFFMHDIOAI(CPLJDLKPMMA IBJJPMNCGPL, EECNAGIPCBM<JJJHHLABGOM> NAOCMNCGBGA, IEnumerable<IEBAHENHLEA<JJJHHLABGOM>> HAIJICLKMPF, IEnumerable<IEBAHENHLEA<DJONKGBCHFD>> IKHBGDFGLAF, ISet<IEBAHENHLEA<POBMEBKLCBD>>? JAFOCEBLHNO)
	{
		return default(BCKKNDPGFGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x2628C40", Offset = "0x2628040", VA = "0x182628C40")]
	private BCKKNDPGFGN GEGHBEKKMFL(CPLJDLKPMMA IBJJPMNCGPL, EECNAGIPCBM<JJJHHLABGOM> NAOCMNCGBGA, IEnumerable<IEBAHENHLEA<JJJHHLABGOM>> HAIJICLKMPF, IEnumerable<IEBAHENHLEA<DJONKGBCHFD>> IKHBGDFGLAF, ISet<IEBAHENHLEA<POBMEBKLCBD>>? JAFOCEBLHNO)
	{
		return default(BCKKNDPGFGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x26290D0", Offset = "0x26284D0", VA = "0x1826290D0", Slot = "57")]
	public BCKKNDPGFGN GOLMJJDKOCH(CPLJDLKPMMA IBJJPMNCGPL, EECNAGIPCBM<JJJHHLABGOM> NAOCMNCGBGA, IEnumerable<IEBAHENHLEA<DJONKGBCHFD>> IKHBGDFGLAF, IEnumerable<EBFEMKEPGFD> LMHGCJEGHLD, ISet<IEBAHENHLEA<POBMEBKLCBD>>? JAFOCEBLHNO)
	{
		return default(BCKKNDPGFGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2628590", Offset = "0x2627990", VA = "0x182628590")]
	private static IEnumerable<IEBAHENHLEA<JJJHHLABGOM>> FCKJMDJBAOK(IEnumerable<EBFEMKEPGFD> LMHGCJEGHLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x262AC80", Offset = "0x262A080", VA = "0x18262AC80")]
	private IEnumerable<IEBAHENHLEA<DJONKGBCHFD>> JHMABPNLCFA(IEnumerable<EBFEMKEPGFD> LMHGCJEGHLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2628300", Offset = "0x2627700", VA = "0x182628300", Slot = "59")]
	public List<AEOGPJIODBG> EKALJMIBBIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x262A500", Offset = "0x2629900", VA = "0x18262A500")]
	public (List<AEOGPJIODBG>, bool) JFCAMNJPKIM([In] COANIBAEEEM OBHBIALCBIN, string PFPNPMCGHHC, [In] EJLACCJGNKG LFCJNILAHLP, JGBGDKEEJNG LOENCIEKBKD, JPOHMBJKEDA LGDAHNEIMJA)
	{
		return default((List<AEOGPJIODBG>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x262D200", Offset = "0x262C600", VA = "0x18262D200", Slot = "61")]
	public bool PAKNDGKBJFP(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x262C4D0", Offset = "0x262B8D0", VA = "0x18262C4D0")]
	internal void LAOGAKADGGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x2629370", Offset = "0x2628770", VA = "0x182629370")]
	internal Task GPIPILKJELF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x262B740", Offset = "0x262AB40", VA = "0x18262B740", Slot = "62")]
	public AEAAIINGJNL<EECNAGIPCBM<BPHLKFKIMPM>?, GJDNFLPCNNP> KHIDKCNHOCD(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<DJONKGBCHFD> GNBPFKJNJLF, EECNAGIPCBM<BOBCICDOPCN> MFEIHBHGIDP)
	{
		return default(AEAAIINGJNL<EECNAGIPCBM<BPHLKFKIMPM>?, GJDNFLPCNNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x26295D0", Offset = "0x26289D0", VA = "0x1826295D0", Slot = "63")]
	public AEAAIINGJNL<EECNAGIPCBM<BOBCICDOPCN>?, GJDNFLPCNNP> HPEEJKPLJAC(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, EECNAGIPCBM<DJONKGBCHFD> GNBPFKJNJLF, EECNAGIPCBM<BPHLKFKIMPM> CLMAEMHEFIF)
	{
		return default(AEAAIINGJNL<EECNAGIPCBM<BOBCICDOPCN>?, GJDNFLPCNNP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x262CC80", Offset = "0x262C080", VA = "0x18262CC80", Slot = "64")]
	[AsyncStateMachine(typeof(BINFDAFPJBM))]
	public Task<AEAAIINGJNL<DKANDHFOMPH, GJDNFLPCNNP>> NJDHFMDNAGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x26277A0", Offset = "0x2626BA0", VA = "0x1826277A0", Slot = "7")]
	private bool DCHEKDOLOEH(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, [In] OOHCKOAJCGO IHCNNCPHKDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x26294F0", Offset = "0x26288F0", VA = "0x1826294F0", Slot = "18")]
	private FOBIELMFHMM HKFJCLHPGFG([In] IEBAHENHLEA<JJJHHLABGOM> LJPNEOLHCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2628E80", Offset = "0x2628280", VA = "0x182628E80", Slot = "19")]
	private EECNAGIPCBM<JJJHHLABGOM> GGEKIPFLLON([In] IEBAHENHLEA<JJJHHLABGOM> LJPNEOLHCOO)
	{
		return default(EECNAGIPCBM<JJJHHLABGOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x2627110", Offset = "0x2626510", VA = "0x182627110", Slot = "20")]
	private EECNAGIPCBM<JJJHHLABGOM>? OIHMLGCJKME([In] IEBAHENHLEA<JJJHHLABGOM> LJPNEOLHCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x26281B0", Offset = "0x26275B0", VA = "0x1826281B0", Slot = "22")]
	private JJPIPKOGLIO EELFJCFCJHC([In] IEBAHENHLEA<DJONKGBCHFD> GNBPFKJNJLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x2626EB0", Offset = "0x26262B0", VA = "0x182626EB0", Slot = "24")]
	private EECNAGIPCBM<DJONKGBCHFD> BEGLBJLJNMB(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, [In] IEBAHENHLEA<DJONKGBCHFD> PONBILFJKBH)
	{
		return default(EECNAGIPCBM<DJONKGBCHFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2626B90", Offset = "0x2625F90", VA = "0x182626B90", Slot = "38")]
	private BOJBCNOKBBG AKJFIJPNIIK(EECNAGIPCBM<JJJHHLABGOM> LJPNEOLHCOO, [In] OOHCKOAJCGO IHCNNCPHKDE)
	{
		return default(BOJBCNOKBBG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2628060", Offset = "0x2627460", VA = "0x182628060", Slot = "50")]
	private AEAAIINGJNL<JKEAOGPLPFE.BDEGFDOELKN, EIBOIADIOGN> DKFNEFBHEAE([In] JKEAOGPLPFE.MMEOKBIMPLH JOIGLCNPHIH)
	{
		return default(AEAAIINGJNL<JKEAOGPLPFE.BDEGFDOELKN, EIBOIADIOGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x2629070", Offset = "0x2628470", VA = "0x182629070", Slot = "60")]
	private (List<AEOGPJIODBG>, bool) GNHBILIEBMN([In] COANIBAEEEM OBHBIALCBIN, string PFPNPMCGHHC, [In] EJLACCJGNKG LFCJNILAHLP, JGBGDKEEJNG LOENCIEKBKD, JPOHMBJKEDA LGDAHNEIMJA)
	{
		return default((List<AEOGPJIODBG>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x2629FA0", Offset = "0x26293A0", VA = "0x182629FA0")]
	[CompilerGenerated]
	private JMOCADIMOMF IAOBDOFHNNB(PACCEJFECHL EAOFLAGMNJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x262D3E0", Offset = "0x262C7E0", VA = "0x18262D3E0")]
	[CompilerGenerated]
	private BPKOHJDNEKO PFCPPMCIDBM(IEBAHENHLEA<DJONKGBCHFD> EAOFLAGMNJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x262CD70", Offset = "0x262C170", VA = "0x18262CD70")]
	[CompilerGenerated]
	private AFFPINOIDCK NOJIICFNKHJ(IEBAHENHLEA<JJJHHLABGOM> EAOFLAGMNJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x2626F30", Offset = "0x2626330", VA = "0x182626F30")]
	[CompilerGenerated]
	private BPKOHJDNEKO BFJFFIONGJL(IEBAHENHLEA<DJONKGBCHFD> EAOFLAGMNJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x262CC10", Offset = "0x262C010", VA = "0x18262CC10")]
	[CompilerGenerated]
	private AFFPINOIDCK NBOGEOPDHBM(IEBAHENHLEA<JJJHHLABGOM> EAOFLAGMNJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class JMOCADIMOMF : PGCCEHDKJMM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct PGAGEOIKHLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<EECNAGIPCBM<GFAOCBCKMMM>, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public JMOCADIMOMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public IEBAHENHLEA<JJJHHLABGOM> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public IEBAHENHLEA<DJONKGBCHFD> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public EECNAGIPCBM<NBDDIELADOM> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private TaskAwaiter<AEAAIINGJNL<EECNAGIPCBM<GFAOCBCKMMM>, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x2637540", Offset = "0x2636940", VA = "0x182637540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x26377C0", Offset = "0x2636BC0", VA = "0x1826377C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct EBOMNOJCENL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<EECNAGIPCBM<FPPJALEEIOP>, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public JMOCADIMOMF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public IEBAHENHLEA<JJJHHLABGOM> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public IEBAHENHLEA<DJONKGBCHFD> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public EECNAGIPCBM<NBDDIELADOM> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private TaskAwaiter<AEAAIINGJNL<EECNAGIPCBM<FPPJALEEIOP>, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x2633370", Offset = "0x2632770", VA = "0x182633370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x26335F0", Offset = "0x26329F0", VA = "0x1826335F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private readonly PACCEJFECHL LANLCKBNFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private readonly LAHKLODPGDN ALGDCGCLECN;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public TypeKey JMMJNJPBIJA
	{
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xB327A0", Offset = "0xB31BA0", VA = "0x180B327A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public string MKNNFMEBHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x26346D0", Offset = "0x2633AD0", VA = "0x1826346D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public PACCEJFECHL DHPCABGLHFF
	{
		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x2636CB0", Offset = "0x26360B0", VA = "0x182636CB0")]
	public JMOCADIMOMF(PACCEJFECHL CFACKENIBIA, LAHKLODPGDN MMDMGLMFBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x2636B40", Offset = "0x2635F40", VA = "0x182636B40", Slot = "6")]
	[AsyncStateMachine(typeof(PGAGEOIKHLG))]
	public Task<AEAAIINGJNL<EECNAGIPCBM<GFAOCBCKMMM>, GJDNFLPCNNP>> ILLDCHEAGIJ(IEBAHENHLEA<JJJHHLABGOM> LJPNEOLHCOO, IEBAHENHLEA<DJONKGBCHFD> GNBPFKJNJLF, EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, string MPGDCPPMNJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x26369D0", Offset = "0x2635DD0", VA = "0x1826369D0", Slot = "7")]
	[AsyncStateMachine(typeof(EBOMNOJCENL))]
	public Task<AEAAIINGJNL<EECNAGIPCBM<FPPJALEEIOP>, GJDNFLPCNNP>> ACGOOHCKLPP(IEBAHENHLEA<JJJHHLABGOM> LJPNEOLHCOO, IEBAHENHLEA<DJONKGBCHFD> GNBPFKJNJLF, EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE, string MPGDCPPMNJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class FKJOGAHEKEE : CFDPDFCKCED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private readonly PACCEJFECHL JHKDEKNHDAJ;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private static readonly HashSet<PACCEJFECHL> GFAAEILFIFH;

	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private static readonly HashSet<PACCEJFECHL> KAANDBOBEND;

	[Cpp2IlInjected.Token(Token = "0x40002FD")]
	private static readonly HashSet<PACCEJFECHL> EOPNGOKDLGI;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TypeKey CIMPFBFFMBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x26359F0", Offset = "0x2634DF0", VA = "0x1826359F0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool KDLOKFJDNIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x26359E0", Offset = "0x2634DE0", VA = "0x1826359E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool FFAGLFFANLB
	{
		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x2635A40", Offset = "0x2634E40", VA = "0x182635A40", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool NHKCMPJGGEI
	{
		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x2635960", Offset = "0x2634D60", VA = "0x182635960", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x26342D0", Offset = "0x26336D0", VA = "0x1826342D0")]
	public bool JJNCKOILBME(string FIIKLGCIAGG, [Out] MFCEBKHHBOA LAGCJKPLADK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	public FKJOGAHEKEE(PACCEJFECHL KKDALLBMKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x2634540", Offset = "0x2633940", VA = "0x182634540")]
	internal static TypeKey JKEAPMBJLFO(PACCEJFECHL MAIGGPEPIHD)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x26346D0", Offset = "0x2633AD0", VA = "0x1826346D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public readonly struct JCJELEOEIDN : ODFAMDDBIDD.CPBKMGBPIMA<IJHNHGOIIEG, DKANDHFOMPH>
{
	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x26368C0", Offset = "0x2635CC0", VA = "0x1826368C0", Slot = "4")]
	public int FEIOLAOPGEJ(DKANDHFOMPH OICAMEEFOOB, IJHNHGOIIEG AKLHLNJOCEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x2636950", Offset = "0x2635D50", VA = "0x182636950", Slot = "5")]
	public IJHNHGOIIEG MFFMODHHNHK(DKANDHFOMPH OICAMEEFOOB, IJHNHGOIIEG AKLHLNJOCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x26369A0", Offset = "0x2635DA0", VA = "0x1826369A0", Slot = "6")]
	public IJHNHGOIIEG PKHFFPILMFJ(DKANDHFOMPH OICAMEEFOOB, IJHNHGOIIEG AKLHLNJOCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x2636960", Offset = "0x2635D60", VA = "0x182636960", Slot = "7")]
	public IReadOnlyList<IJHNHGOIIEG> NKECJJIFCHE(DKANDHFOMPH OICAMEEFOOB, IJHNHGOIIEG AKLHLNJOCEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x2636920", Offset = "0x2635D20", VA = "0x182636920", Slot = "8")]
	public IJHNHGOIIEG[] INPKDMMBENC(DKANDHFOMPH OICAMEEFOOB, IJHNHGOIIEG AKLHLNJOCEK, int HDJHFCIAFFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x26368E0", Offset = "0x2635CE0", VA = "0x1826368E0", Slot = "9")]
	public bool HLGNJMKPNBI(DKANDHFOMPH OICAMEEFOOB, IJHNHGOIIEG AKLHLNJOCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x2636980", Offset = "0x2635D80", VA = "0x182636980", Slot = "10")]
	public bool OBPABOMJLCI(DKANDHFOMPH OICAMEEFOOB, IJHNHGOIIEG AKLHLNJOCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x2636880", Offset = "0x2635C80", VA = "0x182636880", Slot = "11")]
	public bool CBBJBAEIFDB(DKANDHFOMPH OICAMEEFOOB, IJHNHGOIIEG AKLHLNJOCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x26368A0", Offset = "0x2635CA0", VA = "0x1826368A0", Slot = "12")]
	public bool CIPMJEFJCHB(DKANDHFOMPH OICAMEEFOOB, IJHNHGOIIEG AKLHLNJOCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x2636900", Offset = "0x2635D00", VA = "0x182636900", Slot = "13")]
	public bool IAEFFIGLAHD(DKANDHFOMPH ECFGOPEGNEO, IJHNHGOIIEG AKLHLNJOCEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x2636930", Offset = "0x2635D30", VA = "0x182636930", Slot = "14")]
	public bool KADBKNGNMMG(DKANDHFOMPH OICAMEEFOOB, IJHNHGOIIEG AKLHLNJOCEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public abstract class GLOCJHFEEAC : AJBMMLPNPPG
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public GJGHLAIIHED.KJKECFDKKOM GELCPPLINCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x2635F60", Offset = "0x2635360", VA = "0x182635F60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract MGALOLPCIOG.OIHFANDIDBI EMNOMCALKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public abstract DJHNEBOJMKB.LOFMILLKJAH CPLLCCEEMIM
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract IGMHMMGMENM.MFOKDBPCJIG BOBLJCIDDEN
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public JCAMIECDDEF.FOIFKKFBMDJ<OOKMKACJEON, IJHNHGOIIEG, DJHNEBOJMKB> ELDBOCCFGHA
	{
		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x2635F10", Offset = "0x2635310", VA = "0x182635F10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract DKCGBDMFMOE.MDNNENMIHJH BOPGCKOFJKL
	{
		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract OJNPGCHDMOP EPGNNBPOOKF
	{
		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract AAPEHCLIBNH LOOOAPFMDIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public abstract PNONDFODKJN MFLPADFCMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public abstract JLKFEPJGAAB ICBNAJIPIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public abstract DIEBIEHHCDJ HAIKHDHDFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	protected GLOCJHFEEAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class AEOCBEJEJEB : JBEGJOONHIJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private struct DPJMAFJCDME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<object, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AEOCBEJEJEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public IJHNHGOIIEG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter<AEAAIINGJNL<object, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x2632C70", Offset = "0x2632070", VA = "0x182632C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x2632F10", Offset = "0x2632310", VA = "0x182632F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct DPPDFDCIAAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public AsyncTaskMethodBuilder<AEAAIINGJNL<AJEHNEOFKOC, GJDNFLPCNNP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public AEOCBEJEJEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public IReadOnlyList<IJHNHGOIIEG> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private TaskAwaiter<AEAAIINGJNL<object, GJDNFLPCNNP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x2632F80", Offset = "0x2632380", VA = "0x182632F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x2633300", Offset = "0x2632700", VA = "0x182633300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FE")]
	private readonly NEGLMDBBMLE ONKIPENHAPK;

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x999BC0", Offset = "0x998FC0", VA = "0x180999BC0")]
	public AEOCBEJEJEB(NEGLMDBBMLE BKFLLLKFECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x2632100", Offset = "0x2631500", VA = "0x182632100")]
	[AsyncStateMachine(typeof(DPJMAFJCDME))]
	private Task<AEAAIINGJNL<object, GJDNFLPCNNP>> KFLHDDIJBBK(IJHNHGOIIEG AKLHLNJOCEK, bool LECKBHBGKBF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x2631FD0", Offset = "0x26313D0", VA = "0x182631FD0", Slot = "4")]
	[AsyncStateMachine(typeof(DPPDFDCIAAJ))]
	public Task<AEAAIINGJNL<AJEHNEOFKOC, GJDNFLPCNNP>> IAJNPPDJOMI(IReadOnlyList<IJHNHGOIIEG> NLNFFLCOOFE, bool LECKBHBGKBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public struct KPBAOAPDGOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400030B")]
	internal OAIKKOAJMCI<OOHMFJDOIPO, IEBAHENHLEA<OOHMFJDOIPO.AELFAPHCBKI>, IJHNHGOIIEG, GNLGHIEOHAE> JHKDEKNHDAJ;

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x260B7B0", Offset = "0x260ABB0", VA = "0x18260B7B0")]
	private KPBAOAPDGOM([In] OAIKKOAJMCI<OOHMFJDOIPO, IEBAHENHLEA<OOHMFJDOIPO.AELFAPHCBKI>, IJHNHGOIIEG, GNLGHIEOHAE> IODEJOKMHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x2636E60", Offset = "0x2636260", VA = "0x182636E60")]
	public static KPBAOAPDGOM AFLKMMODJAC()
	{
		return default(KPBAOAPDGOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public static class BKHDAMOOOKN
{
	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
	public static OAIKKOAJMCI<OOHMFJDOIPO, IEBAHENHLEA<OOHMFJDOIPO.AELFAPHCBKI>, IJHNHGOIIEG, GNLGHIEOHAE> JDAEKGDGELP(this KPBAOAPDGOM CAMFIHKHJNG)
	{
		return default(OAIKKOAJMCI<OOHMFJDOIPO, IEBAHENHLEA<OOHMFJDOIPO.AELFAPHCBKI>, IJHNHGOIIEG, GNLGHIEOHAE>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct GNLGHIEOHAE : PNGBDFKALLO.PCJCJPKDOCL<OOHMFJDOIPO, IEBAHENHLEA<OOHMFJDOIPO.AELFAPHCBKI>, IJHNHGOIIEG>
{
	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x2636670", Offset = "0x2635A70", VA = "0x182636670", Slot = "7")]
	public IJHNHGOIIEG ACFLKOEAMLG(OOHMFJDOIPO[] IKFCGNFJFIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0xFBADA0", Offset = "0xFBA1A0", VA = "0x180FBADA0")]
	public IEBAHENHLEA<OOHMFJDOIPO.AELFAPHCBKI> BIDBJKDANKN([In] OOHMFJDOIPO DHKEIGKPJAB)
	{
		return default(IEBAHENHLEA<OOHMFJDOIPO.AELFAPHCBKI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0xFBADB0", Offset = "0xFBA1B0", VA = "0x180FBADB0")]
	public int ACMKDDBNFMK([In] OOHMFJDOIPO IHENEGANNAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x2636850", Offset = "0x2635C50", VA = "0x182636850")]
	public int FNPBHKPAGAA([In] OOHMFJDOIPO DHKEIGKPJAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0xFBADB0", Offset = "0xFBA1B0", VA = "0x180FBADB0", Slot = "4")]
	private int OBGPLDCHKNF([In] OOHMFJDOIPO DHKEIGKPJAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x2636850", Offset = "0x2635C50", VA = "0x182636850", Slot = "5")]
	private int COGLFDHCKFI([In] OOHMFJDOIPO DHKEIGKPJAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0xFBADA0", Offset = "0xFBA1A0", VA = "0x180FBADA0", Slot = "6")]
	private IEBAHENHLEA<OOHMFJDOIPO.AELFAPHCBKI> MPGBEKJILCO([In] OOHMFJDOIPO DHKEIGKPJAB)
	{
		return default(IEBAHENHLEA<OOHMFJDOIPO.AELFAPHCBKI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public struct DKEIKPIKBBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400030E")]
	internal FBGAHKBIKDM<JPMIHCAALBE, IJHNHGOIIEG, CKNEDEJJHFP> JHKDEKNHDAJ;

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x260B7B0", Offset = "0x260ABB0", VA = "0x18260B7B0")]
	private DKEIKPIKBBC([In] FBGAHKBIKDM<JPMIHCAALBE, IJHNHGOIIEG, CKNEDEJJHFP> HNHCHINFPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x2632960", Offset = "0x2631D60", VA = "0x182632960")]
	public static DKEIKPIKBBC AFLKMMODJAC()
	{
		return default(DKEIKPIKBBC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class JFOBPPCLNIN
{
	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0xBD0860", Offset = "0xBCFC60", VA = "0x180BD0860")]
	public static FBGAHKBIKDM<JPMIHCAALBE, IJHNHGOIIEG, CKNEDEJJHFP> JDAEKGDGELP(this DKEIKPIKBBC CAMFIHKHJNG)
	{
		return default(FBGAHKBIKDM<JPMIHCAALBE, IJHNHGOIIEG, CKNEDEJJHFP>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public struct CKNEDEJJHFP : OCPNJIPBJJE.FMCEOOOKOIB<JPMIHCAALBE, IJHNHGOIIEG>
{
	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x20137E0", Offset = "0x2012BE0", VA = "0x1820137E0")]
	public int DGNHLMGGNCG([In] JPMIHCAALBE IHENEGANNAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x26324C0", Offset = "0x26318C0", VA = "0x1826324C0", Slot = "5")]
	public IJHNHGOIIEG FELPJFNAGEB(JPMIHCAALBE[] BPLPFPPIJOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x20137E0", Offset = "0x2012BE0", VA = "0x1820137E0", Slot = "4")]
	private int HDGHJBGLAAP([In] JPMIHCAALBE IHENEGANNAN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class DOMLALHAKDF : BPMPLDFNAFC, EIBOIADIOGN, GJDNFLPCNNP, EPFFDEGDAEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000312")]
	private readonly EPFFDEGDAEO? JJLKFMELEEN;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public DECIJFCBPCL CKDPKKPOENP
	{
		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x991DB0", Offset = "0x9911B0", VA = "0x180991DB0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(DECIJFCBPCL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x992550", Offset = "0x991950", VA = "0x180992550")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public override EPFFDEGDAEO? JALJHBAMAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x2632AB0", Offset = "0x2631EB0", VA = "0x182632AB0", Slot = "7")]
	public override string CHDHFHDBOKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x2632C30", Offset = "0x2632030", VA = "0x182632C30")]
	private DOMLALHAKDF(DECIJFCBPCL BKKCGGLCOFC, EPFFDEGDAEO? LALFNMHNPEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x26329C0", Offset = "0x2631DC0", VA = "0x1826329C0")]
	public static DOMLALHAKDF ABCBBKIEAPB(EPFFDEGDAEO LALFNMHNPEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x2632BC0", Offset = "0x2631FC0", VA = "0x182632BC0")]
	public static DOMLALHAKDF NFGICBJDJCB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x2632A40", Offset = "0x2631E40", VA = "0x182632A40")]
	public static DOMLALHAKDF BNDPPLNDIPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public static class AAGMDLBBAAH
{
	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x3D519A0", Offset = "0x3D50DA0", VA = "0x183D519A0")]
	public static AEAAIINGJNL<TOk, EIBOIADIOGN> KCECKAMBPBF<TOk>([In] this AEAAIINGJNL<TOk, EIBOIADIOGN> CAMFIHKHJNG, EPFFDEGDAEO LALFNMHNPEN) where TOk : notnull
	{
		return default(AEAAIINGJNL<TOk, EIBOIADIOGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x3D51B80", Offset = "0x3D50F80", VA = "0x183D51B80")]
	public static AEAAIINGJNL<TOk?, EIBOIADIOGN?> NICANALCBGO<TOk>([In] this AEAAIINGJNL<TOk, EIBOIADIOGN> CAMFIHKHJNG)
	{
		return default(AEAAIINGJNL<TOk, EIBOIADIOGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x3D51A90", Offset = "0x3D50E90", VA = "0x183D51A90")]
	public static AEAAIINGJNL<TOk?, EIBOIADIOGN?> LINHBNCMOGN<TOk>([In] this AEAAIINGJNL<TOk, EIBOIADIOGN> CAMFIHKHJNG)
	{
		return default(AEAAIINGJNL<TOk, EIBOIADIOGN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public interface OJNPGCHDMOP
{
	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GMAGBMPFGJF([In] AEAAIINGJNL<DKANDHFOMPH, EPFFDEGDAEO> KGODHHBLJOE);
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public static class ABNDCGAPNPB
{
	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x3D56E30", Offset = "0x3D56230", VA = "0x183D56E30")]
	public static bool GMAGBMPFGJF<TOk, TErr>(this OJNPGCHDMOP CAMFIHKHJNG, [In] AEAAIINGJNL<TOk, TErr> KGODHHBLJOE) where TOk : notnull where TErr : notnull, EPFFDEGDAEO
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public interface AAPEHCLIBNH
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	ONIGOHKHJLL NHCDFCCFHHE
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public interface PNONDFODKJN
{
	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EJPPFNLOKLD DMCMGCFPFOD(int FDJCPKKEGGI);
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public interface OMFKGJGAPBO
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	string EDDDAEGNADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public interface CKBINBLFEGM
{
	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LBCKKCBAKEJ? ECFBAKGEAAC(EECNAGIPCBM<NBDDIELADOM> COKEGEILIKE);
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface KEKBGEANFML
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	string EDDDAEGNADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface LBCKKCBAKEJ
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	string EDDDAEGNADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KEKBGEANFML? NIPNBONBNFG(EECNAGIPCBM<GFAOCBCKMMM> CLEKIHEJJEC);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OMFKGJGAPBO? FMAKBAJMKEO(EECNAGIPCBM<FPPJALEEIOP> HPABFAJEOGG);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface JLKFEPJGAAB
{
	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> CKEKKKMDJKN(string FIIKLGCIAGG, string PFPNPMCGHHC);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface DIEBIEHHCDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CKBINBLFEGM? PBEEBCONAPO([In] IEBAHENHLEA<HAGICHLJINH> CHJFMEINOMN);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class PIDJCDFJOMB
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private struct KAAMGHKIKOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public int BNBIOAJGDHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public DAAAEMKKFPO? OLNAFEJCGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public DAAAEMKKFPO? BAIGFCMCDFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public readonly List<IJHNHGOIIEG> CDGAGHLJGOE;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x2636E10", Offset = "0x2636210", VA = "0x182636E10")]
		private KAAMGHKIKOO(int KDCAMOIGIMA, DAAAEMKKFPO? HLMFCKPGFNJ, DAAAEMKKFPO? MLMHCPJIEDP, List<IJHNHGOIIEG> NLNFFLCOOFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x2636D50", Offset = "0x2636150", VA = "0x182636D50")]
		public static KAAMGHKIKOO AFLKMMODJAC()
		{
			return default(KAAMGHKIKOO);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000315")]
	private readonly AOOCMNPBGFC<KAAMGHKIKOO> ECDJCIJCPGM;

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public static PIDJCDFJOMB DMADMDPHOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x2637F40", Offset = "0x2637340", VA = "0x182637F40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public bool BNPPPPKDMMH
	{
		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0xBD2B40", Offset = "0xBD1F40", VA = "0x180BD2B40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0xBD2770", Offset = "0xBD1B70", VA = "0x180BD2770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x2637E80", Offset = "0x2637280", VA = "0x182637E80")]
	public void NAMGOKELAPK(JFCLCBLPGED MLMHCPJIEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x2637B90", Offset = "0x2636F90", VA = "0x182637B90")]
	public void MGPOHIFEHDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0x2637830", Offset = "0x2636C30", VA = "0x182637830")]
	private static string? CEAOOIMPDHP([In] KAAMGHKIKOO KODMKOJFMOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0x2638090", Offset = "0x2637490", VA = "0x182638090")]
	public PIDJCDFJOMB()
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
