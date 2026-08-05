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
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C23070", Offset = "0x1C21870", VA = "0x181C23070")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78D440", Offset = "0x78BC40", VA = "0x18078D440")]
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
		[Cpp2IlInjected.Address(RVA = "0x78D480", Offset = "0x78BC80", VA = "0x18078D480")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class AANLPGCMHPA : IDisposable, FJLLFGOPHEB, EKJMONIPLDD, GGILPEFPGLI, NKMFDIJOCEH, NCFBGMCOELI
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class OBHCDBFNLDI : MCCCHBFGCBB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int CIBGMNNOJPA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1C230F0", Offset = "0x1C218F0", VA = "0x181C230F0", Slot = "5")]
		public IILLBOBJCJM MANGAJOIMIA(FAAPDBBLBEL.BDIIKOBHCOF JOGDKLBFLFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void KGBKIMLLDFF();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void NLGGLBCPGOF();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		protected OBHCDBFNLDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface MCCCHBFGCBB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int CIBGMNNOJPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IILLBOBJCJM MANGAJOIMIA(FAAPDBBLBEL.BDIIKOBHCOF JOGDKLBFLFJ);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KGBKIMLLDFF();

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NLGGLBCPGOF();
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct ENKJBPBCIFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly DNMOCJLFELM<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA, DFLBEHIMOOF.GMDCOPMPIHF<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA>> HDDKOOHNGPB;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1C11F50", Offset = "0x1C10750", VA = "0x181C11F50")]
		internal ENKJBPBCIFA(DNMOCJLFELM<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA, DFLBEHIMOOF.GMDCOPMPIHF<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA>> PCEPPDLMHCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class BBDKLPLFHHE : DFLBEHIMOOF.GMDCOPMPIHF<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly BBDKLPLFHHE FLMPJFHFLHM;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		private BBDKLPLFHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9522C0", Offset = "0x950AC0", VA = "0x1809522C0", Slot = "4")]
		public KAGCBACHCOA MBPAFGMEBLB(GMCGHACCLIF AFFJMIFONEM)
		{
			return default(KAGCBACHCOA);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "5")]
		public void CIMBMHDLNLL(AANLPGCMHPA DIPDOFGLHFF, GMCGHACCLIF OONIIOMBHJI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct PFAPAEFOIGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public IACGCHNPDDC<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA, DFLBEHIMOOF.GMDCOPMPIHF<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA>> HDDKOOHNGPB;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1C23C20", Offset = "0x1C22420", VA = "0x181C23C20")]
		internal PFAPAEFOIGE(IACGCHNPDDC<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA, DFLBEHIMOOF.GMDCOPMPIHF<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA>> PCEPPDLMHCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1C23BD0", Offset = "0x1C223D0", VA = "0x181C23BD0")]
		public static PFAPAEFOIGE KKMBICLNKPK()
		{
			return default(PFAPAEFOIGE);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct PHNJPBIEMHO : OAGEFHGOAGE.EHONACAFGBI<OKKLNFDCIEA, GMCGHACCLIF, AANLPGCMHPA>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct HKAGLALKOLG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public AsyncTaskMethodBuilder<EOPMGLNDIOA<object, NHKNMEADEEO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AANLPGCMHPA receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public GMCGHACCLIF action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public PHNJPBIEMHO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<EOPMGLNDIOA<object, NHKNMEADEEO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1C17D80", Offset = "0x1C16580", VA = "0x181C17D80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x1C17F60", Offset = "0x1C16760", VA = "0x181C17F60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9522C0", Offset = "0x950AC0", VA = "0x1809522C0", Slot = "4")]
		public CJFFNAOEMIF<OKKLNFDCIEA> LBLCNPLBMBJ(AANLPGCMHPA PPKFMHJLLNO)
		{
			return default(CJFFNAOEMIF<OKKLNFDCIEA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1C23C30", Offset = "0x1C22430", VA = "0x181C23C30", Slot = "5")]
		[AsyncStateMachine(typeof(HKAGLALKOLG))]
		public Task<EOPMGLNDIOA<object, NHKNMEADEEO>> EPMLBNCCMNN(AANLPGCMHPA PPKFMHJLLNO, GMCGHACCLIF OONIIOMBHJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1C23D60", Offset = "0x1C22560", VA = "0x181C23D60", Slot = "6")]
		public GMCGHACCLIF[] ODHGNIDNEPO(AANLPGCMHPA PPKFMHJLLNO)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct DBIFBDKCOHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<bool, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AANLPGCMHPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FDICFACCMJK rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public KGOIBMCNEGI circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public FFPNNGOGOKI superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<EOPMGLNDIOA<bool, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1C0E250", Offset = "0x1C0CA50", VA = "0x181C0E250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1C0E4D0", Offset = "0x1C0CCD0", VA = "0x181C0E4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct FMOLBGDBOCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<bool, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AANLPGCMHPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<EOPMGLNDIOA<bool, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1C164F0", Offset = "0x1C14CF0", VA = "0x181C164F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1C16770", Offset = "0x1C14F70", VA = "0x181C16770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct PIMGNGBDLON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AANLPGCMHPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1C23D80", Offset = "0x1C22580", VA = "0x181C23D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1C23F60", Offset = "0x1C22760", VA = "0x181C23F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct KHGJIEICIGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<object, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AANLPGCMHPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public GMCGHACCLIF action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<EOPMGLNDIOA<object, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1C1EB20", Offset = "0x1C1D320", VA = "0x181C1EB20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1C1ED10", Offset = "0x1C1D510", VA = "0x181C1ED10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct ANBFMEDOPIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AANLPGCMHPA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<EOPMGLNDIOA<bool, NHKNMEADEEO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1C0A1E0", Offset = "0x1C089E0", VA = "0x181C0A1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1C0A9D0", Offset = "0x1C091D0", VA = "0x181C0A9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly CJFFNAOEMIF<OKKLNFDCIEA> KBAHADPCDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly ENKJBPBCIFA GANIKPBAGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly HDEPNCPKPDN HGDKJEOGFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly LINLPDMNAJD MHGBJPCGLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly GMCALCOKFAM.BBCIGLCOFHF BNKAGFLEFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly JAPJGMAEMLA KKPHJEIBCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly ICEMHPGPPAA DEDLLBICBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly ELHOFFKHCMG OLPLKIOJPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly HEOHLKBONPB HDDEMPKGKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private FDOANNKBHOH MFFEHKHFKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CNIPAPLOGEF IFFIDPENGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly HDEPNCPKPDN.EJFAKLKCDCB NEHMFMENDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly FIMEDEAJAGK JDEBJKHPHED;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HDEPNCPKPDN JCOIAMLOFAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1C08530", Offset = "0x1C06D30", VA = "0x181C08530")]
		get
		{
			return default(HDEPNCPKPDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal MCCCHBFGCBB PGNOHBPCFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1C08B40", Offset = "0x1C07340", VA = "0x181C08B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal IILLBOBJCJM IHAICJCJPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x768290", Offset = "0x766A90", VA = "0x180768290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x768270", Offset = "0x766A70", VA = "0x180768270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool FBKNHMFKEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x938C60", Offset = "0x937460", VA = "0x180938C60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9382D0", Offset = "0x936AD0", VA = "0x1809382D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EDBLICMHNBN KLLNIFJJJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x768E20", Offset = "0x767620", VA = "0x180768E20", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GCHMOHKJOEG MDNFMKHONOP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8A33B0", Offset = "0x8A1BB0", VA = "0x1808A33B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AGAFDPMCJJG GBOIACBCABM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x768200", Offset = "0x766A00", VA = "0x180768200", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public EBOHAPONLKL OHMGJHMPPFF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8B6300", Offset = "0x8B4B00", VA = "0x1808B6300", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private PKCEAOHPJDG? AEMFLOIOOMK
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1C09150", Offset = "0x1C07950", VA = "0x181C09150", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private MGMENGBEKEA? BKPHMJNJOOI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1C08540", Offset = "0x1C06D40", VA = "0x181C08540", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1C097A0", Offset = "0x1C07FA0", VA = "0x181C097A0")]
	private AANLPGCMHPA(LINLPDMNAJD AJDKMCHGGOD, CJFFNAOEMIF<OKKLNFDCIEA> MPCNBDJNPDD, ENKJBPBCIFA PMEENNBKMHD, HDEPNCPKPDN LDGJLLAHGBA, IILLBOBJCJM KOJOEBGFGAH, [In] GMCALCOKFAM.BBCIGLCOFHF IFNKLGGLCME, HDEPNCPKPDN.EJFAKLKCDCB JEBFMKHNLGK, FIMEDEAJAGK GGCFFJEIGFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1C08C10", Offset = "0x1C07410", VA = "0x181C08C10")]
	public static AANLPGCMHPA KKMBICLNKPK(LINLPDMNAJD JOGDKLBFLFJ, HDEPNCPKPDN.NJCHMADINDJ JJGJNPOJMHB, CJFFNAOEMIF<OKKLNFDCIEA> MPCNBDJNPDD, CJFFNAOEMIF<DALGPLJOFBP> GFACLENAOIN, OANIKMDLOIC FGOFNFFEGME, KMJDOOKEBIN GGDKIPNLNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1C08CC0", Offset = "0x1C074C0", VA = "0x181C08CC0")]
	public static AANLPGCMHPA KKMBICLNKPK(LINLPDMNAJD AJDKMCHGGOD, [In] HDEPNCPKPDN LDGJLLAHGBA, CJFFNAOEMIF<OKKLNFDCIEA> MPCNBDJNPDD, CJFFNAOEMIF<DALGPLJOFBP> GFACLENAOIN, OANIKMDLOIC FGOFNFFEGME, KMJDOOKEBIN GGDKIPNLNAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1C08670", Offset = "0x1C06E70", VA = "0x181C08670", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1C08270", Offset = "0x1C06A70", VA = "0x181C08270")]
	[AsyncStateMachine(typeof(DBIFBDKCOHC))]
	internal Task<EOPMGLNDIOA<bool, NHKNMEADEEO>> BAFBMOJLLPF(FDICFACCMJK IGHNNKNKLIG, KGOIBMCNEGI NKLOAMFHFJB, FFPNNGOGOKI LAPMLCJGBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1C083D0", Offset = "0x1C06BD0", VA = "0x181C083D0")]
	[AsyncStateMachine(typeof(FMOLBGDBOCJ))]
	public Task<EOPMGLNDIOA<bool, NHKNMEADEEO>> BLGDDODOOIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1C08A50", Offset = "0x1C07250", VA = "0x181C08A50")]
	[AsyncStateMachine(typeof(PIMGNGBDLON))]
	public Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> FJMFHPJNCGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1C08850", Offset = "0x1C07050", VA = "0x181C08850")]
	internal void EIJHCBMNPIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1C09720", Offset = "0x1C07F20", VA = "0x181C09720")]
	internal KMLMHBDHBHH<GMCGHACCLIF> PBDCEIDINFB([In] JPJJKLKILGH CHGJIELLIKH)
	{
		return default(KMLMHBDHBHH<GMCGHACCLIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1C084C0", Offset = "0x1C06CC0", VA = "0x181C084C0")]
	internal bool CFEBLNHPAMN([In] JPJJKLKILGH CHGJIELLIKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1C08B90", Offset = "0x1C07390", VA = "0x181C08B90")]
	internal KMLMHBDHBHH<GMCGHACCLIF> IFGOEMEHIHE([In] MKCLGLMNAIG CIOKALEJMFL)
	{
		return default(KMLMHBDHBHH<GMCGHACCLIF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1C09280", Offset = "0x1C07A80", VA = "0x181C09280")]
	[AsyncStateMachine(typeof(KHGJIEICIGN))]
	internal Task<EOPMGLNDIOA<object, NHKNMEADEEO>> NEOFPIJMFCI(GMCGHACCLIF OONIIOMBHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1C09390", Offset = "0x1C07B90", VA = "0x181C09390")]
	private GMCGHACCLIF[] ODHGNIDNEPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1C09030", Offset = "0x1C07830", VA = "0x181C09030")]
	[AsyncStateMachine(typeof(ANBFMEDOPIO))]
	public Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> LFEKNBCPFEE(Guid PFBCMMCNDLO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LAAJKIBLEMA
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2406600", Offset = "0x2404E00", VA = "0x182406600")]
	public static LIIJPHIPJGA<(TPrev?, AANLPGCMHPA?), MGMENGBEKEA> DOACABJBICA<TPrev>([In] this LIIJPHIPJGA<TPrev, AANLPGCMHPA> AFFJMIFONEM)
	{
		return default(LIIJPHIPJGA<(TPrev, AANLPGCMHPA), MGMENGBEKEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x24068A0", Offset = "0x24050A0", VA = "0x1824068A0")]
	public static LIIJPHIPJGA<TPrev?, AANLPGCMHPA?> GLOOAOLFHEN<TPrev>([In] this LIIJPHIPJGA<TPrev, AANLPGCMHPA> AFFJMIFONEM)
	{
		return default(LIIJPHIPJGA<TPrev, AANLPGCMHPA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class DICMJANLEHL<TData> : BJFJCNKKJDP, NDFPOBIEMDE, HNHFFBALMII where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly OKMFLAIJCBC<IKFKOGPAMKO>? CEODJHOCNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly string IDHPNAJLNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly TData IDDGLNBEBBG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public OKMFLAIJCBC<IKFKOGPAMKO>? OIJOPGJLBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1F33D80", Offset = "0x1F32580", VA = "0x181F33D80", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x766140", Offset = "0x764940", VA = "0x180766140", Slot = "7")]
	public override string DGMFKNHADKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4D18650", Offset = "0x4D16E50", VA = "0x184D18650")]
	internal DICMJANLEHL([In] OKMFLAIJCBC<IKFKOGPAMKO>? JNOEMBCBPII, CJFFNAOEMIF<LELJNFMCDIJ>? IHMAIEGNCMF, IOKind? AILMLNHEPMI, string BKGEBGGPBLH, [In] TData AELCABDCBDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class NGACOBPJKPM
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1C22970", Offset = "0x1C21170", VA = "0x181C22970")]
	public static EOPMGLNDIOA<NAGGMEDHLNM, NDFPOBIEMDE> DBGHPDGGJHJ([In] this EKKJHLIEDBL<KKJKIMJADCN> BMGKCOLEOBN)
	{
		return default(EOPMGLNDIOA<NAGGMEDHLNM, NDFPOBIEMDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x24B2370", Offset = "0x24B0B70", VA = "0x1824B2370")]
	public static EOPMGLNDIOA<TOk, NDFPOBIEMDE> CANAGKDKFAK<TOk>([In] this EOPMGLNDIOA<TOk, NDFPOBIEMDE> AFFJMIFONEM, [In] OKMFLAIJCBC<IKFKOGPAMKO>? JNOEMBCBPII, CJFFNAOEMIF<LELJNFMCDIJ>? IHMAIEGNCMF, IOKind? AILMLNHEPMI, string BKGEBGGPBLH) where TOk : notnull
	{
		return default(EOPMGLNDIOA<TOk, NDFPOBIEMDE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface LINLPDMNAJD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FDPBCGEEFBG.LGFCCGOJABI JNHJMOIMAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	FAAPDBBLBEL.BDIIKOBHCOF EEELHIBMIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	AANLPGCMHPA.MCCCHBFGCBB GEEFKMDCJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	JBOLJFCPGHK.JJPEENJBBFG EHDEDPPMFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DFLBEHIMOOF.GMDCOPMPIHF<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA> MFLJJFIMMIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DEHANOACHCB MIFDCAOPDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IBDFCDNBPGH JDONKKMFFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	FHAMKKPFCCL EDAKFEKBMAE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	HHNLAHJNOGM NIBHBLPKHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	CDAIJGJBAHP KBDMJFPLMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CPHAGMKMAPD
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1C0DA10", Offset = "0x1C0C210", VA = "0x181C0DA10")]
	public static GMCGHACCLIF HODJOELIKDE(this GMCGHACCLIF AFFJMIFONEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1C0DB20", Offset = "0x1C0C320", VA = "0x181C0DB20")]
	public static GMCGHACCLIF OMEBCFMMGFE(this BIKPFMPHLHF AFFJMIFONEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct BIKPFMPHLHF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct GDMBPCPAOLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<object, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AANLPGCMHPA root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public BIKPFMPHLHF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private TaskAwaiter<EOPMGLNDIOA<object, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1C16E90", Offset = "0x1C15690", VA = "0x181C16E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1C17150", Offset = "0x1C15950", VA = "0x181C17150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly ByteString PENMJFOMGMH;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7ECAD0", Offset = "0x7EB2D0", VA = "0x1807ECAD0")]
	private BIKPFMPHLHF(ByteString FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1C0B830", Offset = "0x1C0A030", VA = "0x181C0B830")]
	public static GMCGHACCLIF FBILPAIJDBC(ByteString FKKGMPDEPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1C0B780", Offset = "0x1C09F80", VA = "0x181C0B780")]
	public static BCLLIHGKLIK<KAGCBACHCOA, BIKPFMPHLHF> BAGPOPBJDHN(GMCGHACCLIF INDHMPENLMA)
	{
		return default(BCLLIHGKLIK<KAGCBACHCOA, BIKPFMPHLHF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1C0B8F0", Offset = "0x1C0A0F0", VA = "0x181C0B8F0")]
	[AsyncStateMachine(typeof(GDMBPCPAOLG))]
	public static Task<EOPMGLNDIOA<object, NHKNMEADEEO>> NEOFPIJMFCI(AANLPGCMHPA DIPDOFGLHFF, BIKPFMPHLHF AFFJMIFONEM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct FINMCKLBJPE
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1C163D0", Offset = "0x1C14BD0", VA = "0x181C163D0")]
	public static GMCGHACCLIF FBILPAIJDBC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1C16360", Offset = "0x1C14B60", VA = "0x181C16360")]
	public static BCLLIHGKLIK<KAGCBACHCOA, FINMCKLBJPE> BAGPOPBJDHN(GMCGHACCLIF INDHMPENLMA)
	{
		return default(BCLLIHGKLIK<KAGCBACHCOA, FINMCKLBJPE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1C16470", Offset = "0x1C14C70", VA = "0x181C16470")]
	public static EOPMGLNDIOA<JGIANJFFIJK, HIMCMICGGGI> IMHAEKCMPEM(AANLPGCMHPA DIPDOFGLHFF, [In] FINMCKLBJPE AFFJMIFONEM)
	{
		return default(EOPMGLNDIOA<JGIANJFFIJK, HIMCMICGGGI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct FFGGMKAIHBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct DFPNIDFCIGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, HIMCMICGGGI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AANLPGCMHPA root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public FFGGMKAIHBO self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private EOPMGLNDIOA<JGIANJFFIJK, HIMCMICGGGI> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1C0E540", Offset = "0x1C0CD40", VA = "0x181C0E540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1C0E8B0", Offset = "0x1C0D0B0", VA = "0x181C0E8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly FDICFACCMJK? EBLLBLJEFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly KGOIBMCNEGI? HEAFJCBEFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly FFPNNGOGOKI? DCPNJNPEPBD;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x18C6B30", Offset = "0x18C5330", VA = "0x1818C6B30")]
	private FFGGMKAIHBO(FDICFACCMJK? IGHNNKNKLIG, KGOIBMCNEGI? NKLOAMFHFJB, FFPNNGOGOKI? LAPMLCJGBLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1C156A0", Offset = "0x1C13EA0", VA = "0x181C156A0")]
	public static GMCGHACCLIF? FBILPAIJDBC(FDICFACCMJK? IGHNNKNKLIG, KGOIBMCNEGI? NKLOAMFHFJB, FFPNNGOGOKI? LAPMLCJGBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1C15590", Offset = "0x1C13D90", VA = "0x181C15590")]
	public static BCLLIHGKLIK<KAGCBACHCOA, FFGGMKAIHBO> BAGPOPBJDHN(GMCGHACCLIF INDHMPENLMA)
	{
		return default(BCLLIHGKLIK<KAGCBACHCOA, FFGGMKAIHBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1C157A0", Offset = "0x1C13FA0", VA = "0x181C157A0")]
	[AsyncStateMachine(typeof(DFPNIDFCIGN))]
	public static Task<EOPMGLNDIOA<JGIANJFFIJK, HIMCMICGGGI>> NEOFPIJMFCI(AANLPGCMHPA DIPDOFGLHFF, FFGGMKAIHBO AFFJMIFONEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct DBBIBGDHPLK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct PKAHJNIFIKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<PCHKDILKBNI, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public DBBIBGDHPLK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AANLPGCMHPA root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private EOPMGLNDIOA<PCHKDILKBNI, NHKNMEADEEO> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private EOPMGLNDIOA<object, HNHFFBALMII>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private EOPMGLNDIOA<object, HNHFFBALMII> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private EOPMGLNDIOA<object, HNHFFBALMII>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter<EOPMGLNDIOA<object, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1C23FD0", Offset = "0x1C227D0", VA = "0x181C23FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1C24440", Offset = "0x1C22C40", VA = "0x181C24440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IReadOnlyList<GMCGHACCLIF> FNNNEENGINP;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7ECAD0", Offset = "0x7EB2D0", VA = "0x1807ECAD0")]
	private DBBIBGDHPLK(IReadOnlyList<GMCGHACCLIF> CLEMKBFECGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1C0E050", Offset = "0x1C0C850", VA = "0x181C0E050")]
	public static GMCGHACCLIF FBILPAIJDBC(IReadOnlyList<GMCGHACCLIF> CLEMKBFECGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1C0DFB0", Offset = "0x1C0C7B0", VA = "0x181C0DFB0")]
	public static BCLLIHGKLIK<KAGCBACHCOA, DBBIBGDHPLK> BAGPOPBJDHN(GMCGHACCLIF INDHMPENLMA)
	{
		return default(BCLLIHGKLIK<KAGCBACHCOA, DBBIBGDHPLK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1C0E110", Offset = "0x1C0C910", VA = "0x181C0E110")]
	[AsyncStateMachine(typeof(PKAHJNIFIKL))]
	public static Task<EOPMGLNDIOA<PCHKDILKBNI, NHKNMEADEEO>> NEOFPIJMFCI(AANLPGCMHPA DIPDOFGLHFF, DBBIBGDHPLK AFFJMIFONEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct MKCLGLMNAIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly int HLNPNOBJJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int NEMCGPAIDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly byte[] IDDGLNBEBBG;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1665140", Offset = "0x1663940", VA = "0x181665140")]
	private MKCLGLMNAIG(int EHGKBCBKPCI, int LFEFGCGCIAG, byte[] AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1C21D30", Offset = "0x1C20530", VA = "0x181C21D30")]
	public static GMCGHACCLIF FBILPAIJDBC(int EHGKBCBKPCI, int LFEFGCGCIAG, ByteString AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1C21BF0", Offset = "0x1C203F0", VA = "0x181C21BF0")]
	public static GMCGHACCLIF[] CMPKMAEPFJA(GMCGHACCLIF OONIIOMBHJI, int CIGNOIJEBJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1C21B10", Offset = "0x1C20310", VA = "0x181C21B10")]
	public static BCLLIHGKLIK<KAGCBACHCOA, MKCLGLMNAIG> BAGPOPBJDHN(GMCGHACCLIF INDHMPENLMA)
	{
		return default(BCLLIHGKLIK<KAGCBACHCOA, MKCLGLMNAIG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1C21E10", Offset = "0x1C20610", VA = "0x181C21E10")]
	public static EOPMGLNDIOA<GMCGHACCLIF, HIMCMICGGGI> IMHAEKCMPEM(AANLPGCMHPA DIPDOFGLHFF, [In] MKCLGLMNAIG AFFJMIFONEM)
	{
		return default(EOPMGLNDIOA<GMCGHACCLIF, HIMCMICGGGI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct JPJJKLKILGH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct FPNKDHHIKNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<bool, HIMCMICGGGI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AANLPGCMHPA root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public JPJJKLKILGH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private EOPMGLNDIOA<bool, HIMCMICGGGI> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, HIMCMICGGGI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1C167E0", Offset = "0x1C14FE0", VA = "0x181C167E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1C16E20", Offset = "0x1C15620", VA = "0x181C16E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly int HLNPNOBJJGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int NEMCGPAIDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly byte[] IDDGLNBEBBG;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1665140", Offset = "0x1663940", VA = "0x181665140")]
	private JPJJKLKILGH(int EHGKBCBKPCI, int LFEFGCGCIAG, byte[] AELCABDCBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E4A0", Offset = "0x1C1CCA0", VA = "0x181C1E4A0")]
	public static GMCGHACCLIF FBILPAIJDBC(int EHGKBCBKPCI, int LFEFGCGCIAG, ByteString AELCABDCBDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E6B0", Offset = "0x1C1CEB0", VA = "0x181C1E6B0")]
	public static GMCGHACCLIF?[]? NKHBIBOMCCK(int CIGNOIJEBJA, FDICFACCMJK? IGHNNKNKLIG, KGOIBMCNEGI? NKLOAMFHFJB, FFPNNGOGOKI? LAPMLCJGBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E3C0", Offset = "0x1C1CBC0", VA = "0x181C1E3C0")]
	public static BCLLIHGKLIK<KAGCBACHCOA, JPJJKLKILGH> BAGPOPBJDHN(GMCGHACCLIF INDHMPENLMA)
	{
		return default(BCLLIHGKLIK<KAGCBACHCOA, JPJJKLKILGH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E580", Offset = "0x1C1CD80", VA = "0x181C1E580")]
	[AsyncStateMachine(typeof(FPNKDHHIKNF))]
	public static Task<EOPMGLNDIOA<bool, HIMCMICGGGI>> NEOFPIJMFCI(AANLPGCMHPA DIPDOFGLHFF, JPJJKLKILGH AFFJMIFONEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class JAPJGMAEMLA : EDBLICMHNBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly AANLPGCMHPA GHODDNNEGJK;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IJPAICBLKAL? FLMPJFHFLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1C1DF50", Offset = "0x1C1C750", VA = "0x181C1DF50", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	internal JAPJGMAEMLA(AANLPGCMHPA GKEFFDGGLDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class FHLBCBCJKFF : IJPAICBLKAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly AANLPGCMHPA GHODDNNEGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly AHEJKJNNJIC KOLLFPODLJE;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7619F0", Offset = "0x7601F0", VA = "0x1807619F0")]
	public FHLBCBCJKFF(AANLPGCMHPA GKEFFDGGLDF, AHEJKJNNJIC FNGCMEJBGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1C15C10", Offset = "0x1C14410", VA = "0x181C15C10", Slot = "4")]
	public EOPMGLNDIOA<NAGGMEDHLNM, NDFPOBIEMDE> GHNKPBMJJPH(OKMFLAIJCBC<IKFKOGPAMKO> AACPINCHENM, CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF, CJFFNAOEMIF<BEFHGJIIOCM> JLDMBOFGGGB)
	{
		return default(EOPMGLNDIOA<NAGGMEDHLNM, NDFPOBIEMDE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1C15940", Offset = "0x1C14140", VA = "0x181C15940", Slot = "5")]
	public EOPMGLNDIOA<NAGGMEDHLNM, NDFPOBIEMDE> FKBCIBEAIHK(OKMFLAIJCBC<IKFKOGPAMKO> AACPINCHENM, CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF, CJFFNAOEMIF<KLHHMAILMHO> IPMLDIJFFGD)
	{
		return default(EOPMGLNDIOA<NAGGMEDHLNM, NDFPOBIEMDE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class FDPBCGEEFBG : GGLILNOFHFM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface LGFCCGOJABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<AHEJKJNNJIC> HKOBLGDKEDO(AANLPGCMHPA GKEFFDGGLDF, KGOIBMCNEGI? MDDKEDBIHGL, FFPNNGOGOKI? LEBPAOPGOHF, CancellationToken EHCFBFBFEDH);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		HHJIOOCKCEP BLELENNBHJM(AANLPGCMHPA GKEFFDGGLDF, FDICFACCMJK MNENONEGHAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class KAIMJFOKJCL : LGFCCGOJABI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct BDMFJMBPPDK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<AHEJKJNNJIC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public AANLPGCMHPA circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public KGOIBMCNEGI cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public FFPNNGOGOKI cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<JBOLJFCPGHK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x1C0B3E0", Offset = "0x1C09BE0", VA = "0x181C0B3E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1C0B710", Offset = "0x1C09F10", VA = "0x181C0B710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly KAIMJFOKJCL FLMPJFHFLHM;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		private KAIMJFOKJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E940", Offset = "0x1C1D140", VA = "0x181C1E940", Slot = "4")]
		[AsyncStateMachine(typeof(BDMFJMBPPDK))]
		public Task<AHEJKJNNJIC> HKOBLGDKEDO(AANLPGCMHPA GKEFFDGGLDF, KGOIBMCNEGI? MDDKEDBIHGL, FFPNNGOGOKI? LEBPAOPGOHF, CancellationToken EHCFBFBFEDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E8B0", Offset = "0x1C1D0B0", VA = "0x181C1E8B0", Slot = "5")]
		public HHJIOOCKCEP BLELENNBHJM(AANLPGCMHPA GKEFFDGGLDF, FDICFACCMJK MNENONEGHAJ)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct KOPGLHGKLDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<FDPBCGEEFBG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AANLPGCMHPA circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public KGOIBMCNEGI cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public FFPNNGOGOKI cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public FDICFACCMJK evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private LGFCCGOJABI <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<AHEJKJNNJIC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1C1F7F0", Offset = "0x1C1DFF0", VA = "0x181C1F7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1C1FD50", Offset = "0x1C1E550", VA = "0x181C1FD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly AHEJKJNNJIC KOLLFPODLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly HHJIOOCKCEP HJKGJHCEGPB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public PKCEAOHPJDG MOEDOFDKFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1C12670", Offset = "0x1C10E70", VA = "0x181C12670", Slot = "4")]
		get
		{
			return default(PKCEAOHPJDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public MGMENGBEKEA FONMMLAFCBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1C12440", Offset = "0x1C10C40", VA = "0x181C12440", Slot = "5")]
		get
		{
			return default(MGMENGBEKEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FHLBCBCJKFF KAKOEJCMCDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public BLAMPPCHKOL DKKPNLIGOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x765D00", Offset = "0x764500", VA = "0x180765D00", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public JKHEKPJJGIB JGKIDIDCKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1C126D0", Offset = "0x1C10ED0", VA = "0x181C126D0")]
	private FDPBCGEEFBG(AHEJKJNNJIC FNGCMEJBGEO, HHJIOOCKCEP BOHCLNCBFJJ, FHLBCBCJKFF MAALDGIBDOE, BLAMPPCHKOL ECIENLKGJCA, JKHEKPJJGIB JMLCKKNCCAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1C124A0", Offset = "0x1C10CA0", VA = "0x181C124A0")]
	[AsyncStateMachine(typeof(KOPGLHGKLDJ))]
	public static Task<FDPBCGEEFBG> DNOENLJOICC(AANLPGCMHPA GKEFFDGGLDF, FDICFACCMJK MNENONEGHAJ, KGOIBMCNEGI? MDDKEDBIHGL, FFPNNGOGOKI? LEBPAOPGOHF, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1C12610", Offset = "0x1C10E10", VA = "0x181C12610", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class FAAPDBBLBEL : IILLBOBJCJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface BDIIKOBHCOF
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<GGLILNOFHFM> KLKBCNDFPOI(AANLPGCMHPA GKEFFDGGLDF, FDICFACCMJK MNENONEGHAJ, KGOIBMCNEGI? MDDKEDBIHGL, FFPNNGOGOKI? LEBPAOPGOHF, CancellationToken EHCFBFBFEDH);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void POAEKACPMBA();

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void JPCDPLDPLEG();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class MMLDEPIOJMA : BDIIKOBHCOF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct LCNONNFOOAD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<GGLILNOFHFM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AANLPGCMHPA circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public FDICFACCMJK evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public KGOIBMCNEGI cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public FFPNNGOGOKI cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<FDPBCGEEFBG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x1C1FDC0", Offset = "0x1C1E5C0", VA = "0x181C1FDC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x1C20100", Offset = "0x1C1E900", VA = "0x181C20100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1C22810", Offset = "0x1C21010", VA = "0x181C22810", Slot = "4")]
		[AsyncStateMachine(typeof(LCNONNFOOAD))]
		public Task<GGLILNOFHFM> KLKBCNDFPOI(AANLPGCMHPA GKEFFDGGLDF, FDICFACCMJK MNENONEGHAJ, KGOIBMCNEGI? MDDKEDBIHGL, FFPNNGOGOKI? LEBPAOPGOHF, CancellationToken EHCFBFBFEDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void POAEKACPMBA();

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void JPCDPLDPLEG();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		protected MMLDEPIOJMA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct HHDCPIOCPJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<GGLILNOFHFM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public FAAPDBBLBEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<JGIANJFFIJK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1C17750", Offset = "0x1C15F50", VA = "0x181C17750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1C17950", Offset = "0x1C16150", VA = "0x181C17950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct KJGIDFBCEGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public FAAPDBBLBEL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AANLPGCMHPA circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public FDICFACCMJK evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public KGOIBMCNEGI cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public FFPNNGOGOKI cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<GGLILNOFHFM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1C1F260", Offset = "0x1C1DA60", VA = "0x181C1F260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1C1F790", Offset = "0x1C1DF90", VA = "0x181C1F790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly BDIIKOBHCOF DDBMMBAAAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<JGIANJFFIJK> BAIMEMHOPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<JGIANJFFIJK> NJHPBPFIEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource CIBODFDHLCI;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FBKNHMFKEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7C00", Offset = "0x7B6400", VA = "0x1807B7C00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7B8160", Offset = "0x7B6960", VA = "0x1807B8160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool PODDKBEPHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x80C110", Offset = "0x80A910", VA = "0x18080C110", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x80C120", Offset = "0x80A920", VA = "0x18080C120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool OMIALDOHDEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xDBED00", Offset = "0xDBD500", VA = "0x180DBED00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1C121C0", Offset = "0x1C109C0", VA = "0x181C121C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public GGLILNOFHFM? FPMDMOBKBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7660F0", Offset = "0x7648F0", VA = "0x1807660F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x76E4B0", Offset = "0x76CCB0", VA = "0x18076E4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1C120D0", Offset = "0x1C108D0", VA = "0x181C120D0", Slot = "7")]
	[AsyncStateMachine(typeof(HHDCPIOCPJH))]
	public Task<GGLILNOFHFM> EDJKJJEAJAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1C12330", Offset = "0x1C10B30", VA = "0x181C12330")]
	public FAAPDBBLBEL(BDIIKOBHCOF JOGDKLBFLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1C121D0", Offset = "0x1C109D0", VA = "0x181C121D0", Slot = "8")]
	[AsyncStateMachine(typeof(KJGIDFBCEGG))]
	public Task LGENDODCDOO(AANLPGCMHPA GKEFFDGGLDF, FDICFACCMJK MNENONEGHAJ, KGOIBMCNEGI? MDDKEDBIHGL, FFPNNGOGOKI? LEBPAOPGOHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1C11F60", Offset = "0x1C10760", VA = "0x181C11F60", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class DOJEAHJLAIN : BCOLHPFPACE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly BLAMPPCHKOL PHKFKFCGMIA;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	public DOJEAHJLAIN(BLAMPPCHKOL ECIENLKGJCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class CDNHLIBECGP
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class HJFADFKEJHN<TGraph> : MCLBNDOONCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph BNLAHNHBHGN;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual CAOPHKCPDGA? JKAEEMCHAII
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xC4FF20", Offset = "0xC4E720", VA = "0x180C4FF20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
		public HJFADFKEJHN(TGraph OKFJLNJMHFK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class EJACOOOMGNJ : HJFADFKEJHN<BIFNEACMAMA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override CAOPHKCPDGA? JKAEEMCHAII
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x1C0F640", Offset = "0x1C0DE40", VA = "0x181C0F640", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1C0F660", Offset = "0x1C0DE60", VA = "0x181C0F660")]
		public EJACOOOMGNJ(BIFNEACMAMA HHLGBBIMIMG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1C0D880", Offset = "0x1C0C080", VA = "0x181C0D880")]
	public static MCLBNDOONCF KKMBICLNKPK(FIDJKEIGAGK OKFJLNJMHFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class FEODNONGHBN : LHBEDNMEKMJ, JMDINOFHLGI, LLPGEAFDKFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class DMDNOCFEJGA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public DMDNOCFEJGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public DEHANOACHCB errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x1C244B0", Offset = "0x1C22CB0", VA = "0x181C244B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x1C24720", Offset = "0x1C22F20", VA = "0x181C24720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public FEODNONGHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public DMDNOCFEJGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1C0E920", Offset = "0x1C0D120", VA = "0x181C0E920")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task LGDPJKHNBAJ(DEHANOACHCB errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct EBKFBPDAKCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public FEODNONGHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1C0F100", Offset = "0x1C0D900", VA = "0x181C0F100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1C0F5E0", Offset = "0x1C0DDE0", VA = "0x181C0F5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class ENJAFJCGFFP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public ENJAFJCGFFP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1C24780", Offset = "0x1C22F80", VA = "0x181C24780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1C24A60", Offset = "0x1C23260", VA = "0x181C24A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public FEODNONGHBN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public ENJAFJCGFFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1C11E80", Offset = "0x1C10680", VA = "0x181C11E80")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task CGFNJDOOGOI(DEHANOACHCB errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly LJKICLAAKIK FOKPHGAMCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<GOMCEGLLNLE> KNEBCLJKJFJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private LINLPDMNAJD LKJJLBFNOII
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1C13E70", Offset = "0x1C12670", VA = "0x181C13E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public CJFFNAOEMIF<BEFHGJIIOCM> AKOKDPMLCGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x955E60", Offset = "0x954660", VA = "0x180955E60", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(CJFFNAOEMIF<BEFHGJIIOCM>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x99EA70", Offset = "0x99D270", VA = "0x18099EA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public override CJFFNAOEMIF<LELJNFMCDIJ> BGPHEPJNBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1C12A80", Offset = "0x1C11280", VA = "0x181C12A80", Slot = "19")]
		get
		{
			return default(CJFFNAOEMIF<LELJNFMCDIJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool JDCMGPFMPNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1C15290", Offset = "0x1C13A90", VA = "0x181C15290", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1C15490", Offset = "0x1C13C90", VA = "0x181C15490")]
	private FEODNONGHBN(AANLPGCMHPA GKEFFDGGLDF, HBAGMPEDPLJ GIJABPPCKCI, LJKICLAAKIK DJOOCHGDDMI, CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF, CJFFNAOEMIF<BEFHGJIIOCM> JLDMBOFGGGB, bool FFAKFHHJKML, string HNHMJGCODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1C14180", Offset = "0x1C12980", VA = "0x181C14180")]
	public static FEODNONGHBN KKMBICLNKPK(AANLPGCMHPA GKEFFDGGLDF, HBAGMPEDPLJ GIJABPPCKCI, LJKICLAAKIK EIGOIPKAPOI, CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF, CJFFNAOEMIF<NDGNKDNEMLN> PNBJCJCOJOE, CJFFNAOEMIF<BEFHGJIIOCM> JLDMBOFGGGB, bool FFAKFHHJKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1C139F0", Offset = "0x1C121F0", VA = "0x181C139F0", Slot = "20")]
	protected override void GLJEDCMMNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1C12AC0", Offset = "0x1C112C0", VA = "0x181C12AC0", Slot = "21")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1C151C0", Offset = "0x1C139C0", VA = "0x181C151C0", Slot = "28")]
	public void PHPFENNEICO(GOMCEGLLNLE DFOIKOMHGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1C14B10", Offset = "0x1C13310", VA = "0x181C14B10", Slot = "25")]
	public void MPGHFPBLFEP(BBCLDOGMOMH CMHDNKCJDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1C13050", Offset = "0x1C11850", VA = "0x181C13050", Slot = "26")]
	public void GHKOGDEMMPH(BLGDFJGOIIN IIKLBKKLKNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1C12C80", Offset = "0x1C11480", VA = "0x181C12C80", Slot = "22")]
	protected override void EAABCBPBINN(JDLCMOHMNFG DNEAJJNKOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1C149A0", Offset = "0x1C131A0", VA = "0x181C149A0", Slot = "30")]
	public string MKIDIPCFHFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1C14690", Offset = "0x1C12E90", VA = "0x181C14690", Slot = "27")]
	public string MCAFMAKGHKO(int IFKKCMGLINO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1C13C40", Offset = "0x1C12440", VA = "0x181C13C40")]
	private void HFNKJNOOECG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1C14F10", Offset = "0x1C13710", VA = "0x181C14F10", Slot = "29")]
	public void OGPJPMIGLFP(GOMCEGLLNLE DFOIKOMHGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1C12D60", Offset = "0x1C11560", VA = "0x181C12D60")]
	private void FBNJBLPOLID(bool FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1C13E90", Offset = "0x1C12690", VA = "0x181C13E90", Slot = "31")]
	[AsyncStateMachine(typeof(EBKFBPDAKCG))]
	public Task IKFGDPEMGED(string FKKGMPDEPMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1C12980", Offset = "0x1C11180", VA = "0x181C12980")]
	public void CMACBCJFCEE(string FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1C14510", Offset = "0x1C12D10", VA = "0x181C14510")]
	private void LCPGKFFAIPK(int FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x99EA70", Offset = "0x99D270", VA = "0x18099EA70")]
	internal void KCDPIACLDMK(CJFFNAOEMIF<BEFHGJIIOCM> FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1C12760", Offset = "0x1C10F60", VA = "0x181C12760")]
	[CompilerGenerated]
	private bool AJHKAKEAPKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1C15070", Offset = "0x1C13870", VA = "0x181C15070")]
	[CompilerGenerated]
	private bool PGNDOOPBHJO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1C128B0", Offset = "0x1C110B0", VA = "0x181C128B0")]
	[CompilerGenerated]
	private int PFFGNMJMEFK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1C14FE0", Offset = "0x1C137E0", VA = "0x181C14FE0")]
	[CompilerGenerated]
	private bool ONGHFBMICFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1C12F00", Offset = "0x1C11700", VA = "0x181C12F00")]
	[CompilerGenerated]
	private bool FKFEHPLDNBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1C14EC0", Offset = "0x1C136C0", VA = "0x181C14EC0")]
	[CompilerGenerated]
	private bool ODOBBIAEOCN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1C13BB0", Offset = "0x1C123B0", VA = "0x181C13BB0")]
	[CompilerGenerated]
	private bool HFLFJMIKLOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1C128B0", Offset = "0x1C110B0", VA = "0x181C128B0")]
	[CompilerGenerated]
	private int BGKIKEJJNHP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1C13F90", Offset = "0x1C12790", VA = "0x181C13F90")]
	[CompilerGenerated]
	private bool JDEEHEJLNPL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1C14130", Offset = "0x1C12930", VA = "0x181C14130")]
	[CompilerGenerated]
	private int KDLEKFMPLOI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1C12900", Offset = "0x1C11100", VA = "0x181C12900")]
	[CompilerGenerated]
	private void CFJNLDNICIF(object FKKGMPDEPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1C14060", Offset = "0x1C12860", VA = "0x181C14060")]
	[CompilerGenerated]
	private bool JLCEBLMLAOK()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class DOLKOGBDMDI
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private abstract class KMGDFGGPNHB<TNode> : DFKPCFJKAMP<TNode> where TNode : notnull, JOGDEMNNLAF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct EKKEPEGNBAG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public AsyncTaskMethodBuilder<EOPMGLNDIOA<CJFFNAOEMIF<FFBJLJKKEOB>, NHKNMEADEEO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public KMGDFGGPNHB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private TaskAwaiter<EOPMGLNDIOA<CJFFNAOEMIF<FFBJLJKKEOB>, NHKNMEADEEO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x3091AF0", Offset = "0x30902F0", VA = "0x183091AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x3091EC0", Offset = "0x30906C0", VA = "0x183091EC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct GEHPEIAMNDI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public KMGDFGGPNHB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public CJFFNAOEMIF<FFBJLJKKEOB> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x34D3870", Offset = "0x34D2070", VA = "0x1834D3870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x34D3C40", Offset = "0x34D2440", VA = "0x1834D3C40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public sealed override bool IPHBLNNOJCO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public sealed override CJFFNAOEMIF<FFBJLJKKEOB>? PPBPAJKGNKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x3882030", Offset = "0x3880830", VA = "0x183882030", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3882010", Offset = "0x3880810", VA = "0x183882010")]
		public KMGDFGGPNHB(AANLPGCMHPA GKEFFDGGLDF, TNode GIJABPPCKCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3881C00", Offset = "0x3880400", VA = "0x183881C00", Slot = "93")]
		[AsyncStateMachine(typeof(KMGDFGGPNHB<>.EKKEPEGNBAG))]
		public override Task<EOPMGLNDIOA<CJFFNAOEMIF<FFBJLJKKEOB>, NHKNMEADEEO>> DCCKHAHNLAI(string HNHMJGCODBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3881D20", Offset = "0x3880520", VA = "0x183881D20", Slot = "118")]
		public sealed override bool KHEIPLNLMNH(CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x3881F70", Offset = "0x3880770", VA = "0x183881F70", Slot = "107")]
		protected sealed override bool PLMLBLFLJID(CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3881DC0", Offset = "0x38805C0", VA = "0x183881DC0", Slot = "108")]
		protected override bool MMLIOMFKDJO(CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3881E60", Offset = "0x3880660", VA = "0x183881E60", Slot = "94")]
		[AsyncStateMachine(typeof(KMGDFGGPNHB<>.GEHPEIAMNDI))]
		public override Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> OHDPDKIPOEL(CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private sealed class OIGFIGJIDKL : CAOEILJNHHF<JLHCBHHEIDO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override NodeVisualizationKey LKLFDONKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7E1100", Offset = "0x7DF900", VA = "0x1807E1100", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool INMBJMFHIDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "86")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1C236F0", Offset = "0x1C21EF0", VA = "0x181C236F0")]
		public OIGFIGJIDKL(AANLPGCMHPA GKEFFDGGLDF, JLHCBHHEIDO GIJABPPCKCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private abstract class CAOEILJNHHF<TNode> : DFKPCFJKAMP<TNode> where TNode : notnull, GPMCOPPGLHE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private struct AOHIAIMEIPO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<EOPMGLNDIOA<CJFFNAOEMIF<FFBJLJKKEOB>, NHKNMEADEEO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public CAOEILJNHHF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<EOPMGLNDIOA<CJFFNAOEMIF<FFBJLJKKEOB>, NHKNMEADEEO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x365E1E0", Offset = "0x365C9E0", VA = "0x18365E1E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x365E550", Offset = "0x365CD50", VA = "0x18365E550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct LLJOICPJJBK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public CAOEILJNHHF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public CJFFNAOEMIF<FFBJLJKKEOB> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x3925960", Offset = "0x3924160", VA = "0x183925960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x3925CB0", Offset = "0x39244B0", VA = "0x183925CB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override OKMFLAIJCBC<PEKCPKJHMHE>? BCIJMJNHPCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x357CEF0", Offset = "0x357B6F0", VA = "0x18357CEF0", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override CJFFNAOEMIF<FFBJLJKKEOB>? PPBPAJKGNKE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x4A837A0", Offset = "0x4A81FA0", VA = "0x184A837A0", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3882010", Offset = "0x3880810", VA = "0x183882010")]
		public CAOEILJNHHF(AANLPGCMHPA GKEFFDGGLDF, TNode GIJABPPCKCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4A83390", Offset = "0x4A81B90", VA = "0x184A83390", Slot = "93")]
		[AsyncStateMachine(typeof(CAOEILJNHHF<>.AOHIAIMEIPO))]
		public override Task<EOPMGLNDIOA<CJFFNAOEMIF<FFBJLJKKEOB>, NHKNMEADEEO>> DCCKHAHNLAI(string HNHMJGCODBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4A834B0", Offset = "0x4A81CB0", VA = "0x184A834B0", Slot = "118")]
		public sealed override bool KHEIPLNLMNH(CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4A83700", Offset = "0x4A81F00", VA = "0x184A83700", Slot = "107")]
		protected sealed override bool PLMLBLFLJID(CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4A83550", Offset = "0x4A81D50", VA = "0x184A83550", Slot = "108")]
		protected override bool MMLIOMFKDJO(CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4A835F0", Offset = "0x4A81DF0", VA = "0x184A835F0", Slot = "94")]
		[AsyncStateMachine(typeof(CAOEILJNHHF<>.LLJOICPJJBK))]
		public override Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> OHDPDKIPOEL(CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class ALPBDGEKOEM : DFKPCFJKAMP<EHHFJGLKEKA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey LKLFDONKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8D5CF0", Offset = "0x8D44F0", VA = "0x1808D5CF0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1C09E30", Offset = "0x1C08630", VA = "0x181C09E30")]
		public ALPBDGEKOEM(AANLPGCMHPA GKEFFDGGLDF, EHHFJGLKEKA GIJABPPCKCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class GLFKOBKDINN : CAOEILJNHHF<FKDOLAPPDNI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool PJAAOOFAENK
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override NodeVisualizationKey LKLFDONKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x7D3070", Offset = "0x7D1870", VA = "0x1807D3070", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1C17580", Offset = "0x1C15D80", VA = "0x181C17580")]
		public GLFKOBKDINN(AANLPGCMHPA GKEFFDGGLDF, FKDOLAPPDNI GIJABPPCKCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class LICCGCLCAOF : DFKPCFJKAMP<PLLMEIBBOEK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey LKLFDONKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xEE3060", Offset = "0xEE1860", VA = "0x180EE3060", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1C21630", Offset = "0x1C1FE30", VA = "0x181C21630")]
		public LICCGCLCAOF(AANLPGCMHPA GKEFFDGGLDF, PLLMEIBBOEK GIJABPPCKCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class PFABPFBIIKK : DFKPCFJKAMP<JGFIKFFFGHE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override NodeVisualizationKey LKLFDONKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7D4490", Offset = "0x7D2C90", VA = "0x1807D4490", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1C23B70", Offset = "0x1C22370", VA = "0x181C23B70")]
		public PFABPFBIIKK(AANLPGCMHPA GKEFFDGGLDF, JGFIKFFFGHE GIJABPPCKCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "107")]
		protected override bool PLMLBLFLJID(CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class PCKEJLEFPPJ : DFKPCFJKAMP<GINIJFDIOFE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override NodeVisualizationKey LKLFDONKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7E3CE0", Offset = "0x7E24E0", VA = "0x1807E3CE0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1C23B10", Offset = "0x1C22310", VA = "0x181C23B10")]
		public PCKEJLEFPPJ(AANLPGCMHPA GKEFFDGGLDF, GINIJFDIOFE GIJABPPCKCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class FGHGDHBKPOL : DFKPCFJKAMP<FONAOAKIIIG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override NodeVisualizationKey LKLFDONKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7D0D80", Offset = "0x7CF580", VA = "0x1807D0D80", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1C158E0", Offset = "0x1C140E0", VA = "0x181C158E0")]
		public FGHGDHBKPOL(AANLPGCMHPA GKEFFDGGLDF, FONAOAKIIIG GIJABPPCKCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class GPHJMENHPBM : KMGDFGGPNHB<EPAOBLKAECG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override NodeVisualizationKey LKLFDONKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7E07D0", Offset = "0x7DEFD0", VA = "0x1807E07D0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1C175E0", Offset = "0x1C15DE0", VA = "0x181C175E0")]
		public GPHJMENHPBM(AANLPGCMHPA GKEFFDGGLDF, EPAOBLKAECG GIJABPPCKCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class DFKPCFJKAMP<TNode> : CAMCHJLFJJP, IDisposable where TNode : notnull, HBAGMPEDPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class GJONNJAPIIJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public DFKPCFJKAMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public AANLPGCMHPA circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public GJONNJAPIIJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x34E8220", Offset = "0x34E6A20", VA = "0x1834E8220")]
			internal HOCAEPGIMEB DKIMDJAOJCE(NODFOJBDBAO portGroup, int index)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct OFJCCNGLBIE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public DFKPCFJKAMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public FPLGDJMPCLI? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public KOMAGDOGKIC? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3CD3F30", Offset = "0x3CD2730", VA = "0x183CD3F30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3CD41D0", Offset = "0x3CD29D0", VA = "0x183CD41D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct PEDPKKJOJNH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public DFKPCFJKAMP<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3DA4650", Offset = "0x3DA2E50", VA = "0x183DA4650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x3DA48B0", Offset = "0x3DA30B0", VA = "0x183DA48B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private AANLPGCMHPA GHODDNNEGJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private KPFIMPCPLPO<FFBJLJKKEOB, HOCAEPGIMEB> DMLNCPJKOOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private KPFIMPCPLPO<FFBJLJKKEOB, JLAHKJKKBHG> FICKLJIGGIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[CompilerGenerated]
		private Action<CJFFNAOEMIF<FFBJLJKKEOB>>? LDGNJEFLCDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[CompilerGenerated]
		private Action<CJFFNAOEMIF<FFBJLJKKEOB>, JLAHKJKKBHG>? IMFOFCAFLMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[CompilerGenerated]
		private Action<CJFFNAOEMIF<FFBJLJKKEOB>, CJFFNAOEMIF<FFBJLJKKEOB>>? EMDBNPAICEH;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected TNode DNGIKBEBBEK
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x765D00", Offset = "0x764500", VA = "0x180765D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public OKMFLAIJCBC<CJBAFCLDANB> JMNPPGJLBDN
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xD5F460", Offset = "0xD5DC60", VA = "0x180D5F460", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(OKMFLAIJCBC<CJBAFCLDANB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public object IOCOFAMFJOP
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x30EF790", Offset = "0x30EDF90", VA = "0x1830EF790", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public virtual bool PONJGIHAAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x77D0F0", Offset = "0x77B8F0", VA = "0x18077D0F0", Slot = "80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int LMLJLPKFPPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x4D16EF0", Offset = "0x4D156F0", VA = "0x184D16EF0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public APNJAMHPFDA AFHIFMPFIEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x4D16EA0", Offset = "0x4D156A0", VA = "0x184D16EA0", Slot = "9")]
			get
			{
				return default(APNJAMHPFDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string NFJGODEFPOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x4D17330", Offset = "0x4D15B30", VA = "0x184D17330", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		protected virtual bool FOGMFHCHEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public virtual NodeVisualizationKey LKLFDONKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public CJFFNAOEMIF<LBMKJLDKPPF> KLMCFDHIFAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x772110", Offset = "0x770910", VA = "0x180772110", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(CJFFNAOEMIF<LBMKJLDKPPF>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7B00E0", Offset = "0x7AE8E0", VA = "0x1807B00E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public virtual bool KHHHOCCPLML
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public virtual bool PJAAOOFAENK
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual bool INMBJMFHIDD
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "86")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public virtual DHLFNBCCPOP EBICMJCOCHC
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7D0160", Offset = "0x7CE960", VA = "0x1807D0160", Slot = "87")]
			get
			{
				return default(DHLFNBCCPOP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool PPNBAPCIGKN
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x4D16CC0", Offset = "0x4D154C0", VA = "0x184D16CC0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool EFGODNDEKEG
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x4D16D10", Offset = "0x4D15510", VA = "0x184D16D10", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool CMHJAFENNAG
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x4D16D60", Offset = "0x4D15560", VA = "0x184D16D60", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int LHMKIAJIJGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x4D17180", Offset = "0x4D15980", VA = "0x184D17180", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool KHOHCFFBBCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x4D170A0", Offset = "0x4D158A0", VA = "0x184D170A0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string MOGBJGLJCDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x4D16FB0", Offset = "0x4D157B0", VA = "0x184D16FB0", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool BKHDMAOEHOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x4D16E00", Offset = "0x4D15600", VA = "0x184D16E00", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool FDIKAJFHJGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xAE4A00", Offset = "0xAE3200", VA = "0x180AE4A00", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xAF1980", Offset = "0xAF0180", VA = "0x180AF1980")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public virtual bool IJEKNOIGNMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool HJKFDJEBFGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x4D16DB0", Offset = "0x4D155B0", VA = "0x184D16DB0", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool COKMJHPNEPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x4D16FF0", Offset = "0x4D157F0", VA = "0x184D16FF0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public FPLGDJMPCLI MJCFJPNCBDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x4D170E0", Offset = "0x4D158E0", VA = "0x184D170E0", Slot = "27")]
			get
			{
				return default(FPLGDJMPCLI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public KOMAGDOGKIC CGLJKEJLMFK
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x4D17130", Offset = "0x4D15930", VA = "0x184D17130", Slot = "29")]
			get
			{
				return default(KOMAGDOGKIC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual bool KCBOPGFIJBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public virtual PKPAEGACLAA? OAMABKCBFFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "103")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual BKGNBGOJMBL? CKPKPBFCNGH
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "104")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual IEnumerable<OKMFLAIJCBC<IKFKOGPAMKO>>? LBGMMBLPNCN
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool ECOLJOBAIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x4D16E50", Offset = "0x4D15650", VA = "0x184D16E50", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public OKMFLAIJCBC<PEKCPKJHMHE> ICJDKOGMPJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x4D16F30", Offset = "0x4D15730", VA = "0x184D16F30", Slot = "54")]
			get
			{
				return default(OKMFLAIJCBC<PEKCPKJHMHE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool IPHBLNNOJCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual OKMFLAIJCBC<PEKCPKJHMHE>? BCIJMJNHPCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x4D16F80", Offset = "0x4D15780", VA = "0x184D16F80", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool ECLIKEDFNMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x4D17040", Offset = "0x4D15840", VA = "0x184D17040", Slot = "59")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual string MBENGICGPDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x761C20", Offset = "0x760420", VA = "0x180761C20", Slot = "112")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x761C40", Offset = "0x760440", VA = "0x180761C40", Slot = "113")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public OKMFLAIJCBC<IKFKOGPAMKO> ICMFPJGJGNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x4D171C0", Offset = "0x4D159C0", VA = "0x184D171C0", Slot = "60")]
			get
			{
				return default(OKMFLAIJCBC<IKFKOGPAMKO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public OKMFLAIJCBC<IKFKOGPAMKO>? JOKLGOGOEEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x4D17210", Offset = "0x4D15A10", VA = "0x184D17210", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public AHJINMGOCCN<FFBJLJKKEOB, JLAHKJKKBHG> CCOMEEIAEGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x4D172F0", Offset = "0x4D15AF0", VA = "0x184D172F0", Slot = "62")]
			get
			{
				return default(AHJINMGOCCN<FFBJLJKKEOB, JLAHKJKKBHG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public virtual CJFFNAOEMIF<FFBJLJKKEOB>? PPBPAJKGNKE
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action ODKLDHEGFLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x4D160F0", Offset = "0x4D148F0", VA = "0x184D160F0", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x4D13B70", Offset = "0x4D12370", VA = "0x184D13B70", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event LJGNFHMMIGB IBKPKNPOMKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x4D13A00", Offset = "0x4D12200", VA = "0x184D13A00", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x4D16890", Offset = "0x4D15090", VA = "0x184D16890", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event ICIJLPBJPFO INCHLHHCFDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x4D16930", Offset = "0x4D15130", VA = "0x184D16930", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x4D15260", Offset = "0x4D13A60", VA = "0x184D15260", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action PIABKMBOKKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x4D15160", Offset = "0x4D13960", VA = "0x184D15160", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x4D15DE0", Offset = "0x4D145E0", VA = "0x184D15DE0", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action JHCDLLIKPBM
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x4D14E30", Offset = "0x4D13630", VA = "0x184D14E30", Slot = "43")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x4D13C10", Offset = "0x4D12410", VA = "0x184D13C10", Slot = "44")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<CJFFNAOEMIF<FFBJLJKKEOB>, JLAHKJKKBHG> KEPGLDDEEGO
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x4D15C80", Offset = "0x4D14480", VA = "0x184D15C80", Slot = "64")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x4D15D30", Offset = "0x4D14530", VA = "0x184D15D30", Slot = "65")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<CJFFNAOEMIF<FFBJLJKKEOB>, JLAHKJKKBHG> JAJKEDFLNFB
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x4D150A0", Offset = "0x4D138A0", VA = "0x184D150A0", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x4D163D0", Offset = "0x4D14BD0", VA = "0x184D163D0", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<CJFFNAOEMIF<FFBJLJKKEOB>> OOHOCCGPLAM
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x4D14ED0", Offset = "0x4D136D0", VA = "0x184D14ED0", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x4D167A0", Offset = "0x4D14FA0", VA = "0x184D167A0", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<CJFFNAOEMIF<FFBJLJKKEOB>, CJFFNAOEMIF<FFBJLJKKEOB>> KGOOEBIOGFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4D13940", Offset = "0x4D12140", VA = "0x184D13940", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4D14570", Offset = "0x4D12D70", VA = "0x184D14570", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<CJFFNAOEMIF<FFBJLJKKEOB>, JLAHKJKKBHG> ONPBPDPGKBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4D15EE0", Offset = "0x4D146E0", VA = "0x184D15EE0", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4D14FE0", Offset = "0x4D137E0", VA = "0x184D14FE0", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4D169D0", Offset = "0x4D151D0", VA = "0x184D169D0")]
		[OHFLGEFENIF("Need to handle `Name` better.")]
		[OHFLGEFENIF("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		public DFKPCFJKAMP(AANLPGCMHPA GKEFFDGGLDF, TNode GIJABPPCKCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4D146D0", Offset = "0x4D12ED0", VA = "0x184D146D0", Slot = "78")]
		protected virtual void GLJEDCMMNGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4D13CB0", Offset = "0x4D124B0", VA = "0x184D13CB0", Slot = "79")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4D15800", Offset = "0x4D14000", VA = "0x184D15800", Slot = "81")]
		public virtual void LCFGJPJOAHH(int DPEHGCLHJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4D15E80", Offset = "0x4D14680", VA = "0x184D15E80")]
		public bool MIIIKADDLOA([In] FPLGDJMPCLI FKKGMPDEPMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4D15200", Offset = "0x4D13A00", VA = "0x184D15200")]
		public bool JJILKKNPGPB([In] KOMAGDOGKIC FKKGMPDEPMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4D13590", Offset = "0x4D11D90", VA = "0x184D13590", Slot = "90")]
		public virtual void BFKIEKHDKAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4D13770", Offset = "0x4D11F70", VA = "0x184D13770", Slot = "32")]
		[AsyncStateMachine(typeof(DFKPCFJKAMP<>.OFJCCNGLBIE))]
		public Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> CBOOHEJCPII(FPLGDJMPCLI? ALAOAMBMFBH, KOMAGDOGKIC? KCMFIPCJPAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "91")]
		public virtual void EAMLAPPBBAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "92")]
		public virtual void BFDPBFCICHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x136B310", Offset = "0x1369B10", VA = "0x18136B310")]
		protected void MPLMIKJOBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1C1BBA0", Offset = "0x1C1A3A0", VA = "0x181C1BBA0")]
		protected void HEOAHICJOHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x102D9C0", Offset = "0x102C1C0", VA = "0x18102D9C0")]
		private void PGLEDKLLPPM([In] KOMAGDOGKIC OHMBDAJNEIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4D13AA0", Offset = "0x4D122A0", VA = "0x184D13AA0", Slot = "93")]
		public virtual Task<EOPMGLNDIOA<CJFFNAOEMIF<FFBJLJKKEOB>, NHKNMEADEEO>> DCCKHAHNLAI(string HNHMJGCODBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4D162B0", Offset = "0x4D14AB0", VA = "0x184D162B0", Slot = "94")]
		public virtual Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> OHDPDKIPOEL(CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4D14520", Offset = "0x4D12D20", VA = "0x184D14520", Slot = "95")]
		public virtual void EFOLHLBBKPE(CJFFNAOEMIF<FFBJLJKKEOB> LFEFGCGCIAG, CJFFNAOEMIF<FFBJLJKKEOB> KMJKCJJHEFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x4D153C0", Offset = "0x4D13BC0", VA = "0x184D153C0", Slot = "96")]
		public virtual IEnumerable<GMCGHACCLIF> KOIBBIHLHAG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4D12F90", Offset = "0x4D11790", VA = "0x184D12F90", Slot = "97")]
		public EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO> AAHLAAGCEEL(string PDDEIOPJGCC)
		{
			return default(EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4D15FA0", Offset = "0x4D147A0", VA = "0x184D15FA0", Slot = "45")]
		public bool NEACBJNFDAF([Out] Guid ANCBIKEPBGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4D135E0", Offset = "0x4D11DE0", VA = "0x184D135E0", Slot = "98")]
		public virtual bool BHGNLODHLOO([In] Guid HGPLGELHGLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4D14630", Offset = "0x4D12E30", VA = "0x184D14630", Slot = "99")]
		public virtual void FCKDKLKEHNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "100")]
		public virtual void ACGEKCAIMJN(bool GOMHBMLPGGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x764500", Offset = "0x762D00", VA = "0x180764500", Slot = "101")]
		public virtual ICMHAOEBMOH GOGLDJKMHBF([In] EKAMPPMMIKN BBONHFGFPIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4D16590", Offset = "0x4D14D90", VA = "0x184D16590")]
		protected void OMCMADGPLHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "106")]
		protected virtual void GHNMNFHNLEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4D16860", Offset = "0x4D15060", VA = "0x184D16860", Slot = "107")]
		protected virtual bool PLMLBLFLJID(CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "108")]
		protected virtual bool MMLIOMFKDJO(CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "116")]
		protected virtual void ACDGINBCKPL(BKOBEOBGMBI CGMNBKHJKDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7644F0", Offset = "0x762CF0", VA = "0x1807644F0", Slot = "117")]
		protected virtual void GNGKEIOMJFF(BKOBEOBGMBI JNECHMIEIKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4D14680", Offset = "0x4D12E80", VA = "0x184D14680", Slot = "74")]
		public void GHKOGDEMMPH(BKOBEOBGMBI JNECHMIEIKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x4D166C0", Offset = "0x4D14EC0", VA = "0x184D166C0", Slot = "75")]
		public ICGPIDNEGNK PFELCAFPFDE()
		{
			return default(ICGPIDNEGNK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AAB70", VA = "0x1807AC370", Slot = "118")]
		public virtual bool KHEIPLNLMNH(CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x4D153A0", Offset = "0x4D13BA0", VA = "0x184D153A0")]
		private void KIACMKGNICC([In] FPLGDJMPCLI MCLBBPPAHAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x4D16490", Offset = "0x4D14C90", VA = "0x184D16490")]
		private void OIICJOBNLHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x4D13070", Offset = "0x4D11870", VA = "0x184D13070")]
		private void ALMANKHFHBI(int MCCKOLFMNBK, NODFOJBDBAO FBFPJBHNDMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x4D14F90", Offset = "0x4D13790", VA = "0x184D14F90")]
		private void HOAPPGAKDFO(int LFEFGCGCIAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x4D13630", Offset = "0x4D11E30", VA = "0x184D13630")]
		private void CALJOKJLNDE(int LFEFGCGCIAG, NODFOJBDBAO KMLIJCDKHJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4D15450", Offset = "0x4D13C50", VA = "0x184D15450")]
		private void LAMCCKNFLHN(int JFHHMBFANNE, int HNIEDOIGJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4D13010", Offset = "0x4D11810", VA = "0x184D13010")]
		private void ABGIHPKHJLI(int JFHHMBFANNE, int HNIEDOIGJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4D16380", Offset = "0x4D14B80", VA = "0x184D16380")]
		private void OHIJPHDKBJA(int LFEFGCGCIAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4D15850", Offset = "0x4D14050", VA = "0x184D15850")]
		private void LDNFJCKILHF(int MCCKOLFMNBK, NODFOJBDBAO FBFPJBHNDMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4D138C0", Offset = "0x4D120C0", VA = "0x184D138C0")]
		private void CKPDPMGEFGE(int LFEFGCGCIAG, NODFOJBDBAO KMLIJCDKHJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4D16190", Offset = "0x4D14990", VA = "0x184D16190", Slot = "119")]
		[AsyncStateMachine(typeof(DFKPCFJKAMP<>.PEDPKKJOJNH))]
		public virtual Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> OGIEFLEKIAK(string PDDEIOPJGCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x4D14DC0", Offset = "0x4D135C0", VA = "0x184D14DC0", Slot = "52")]
		private void HJCALBDFGCN(object PMBANMJEEBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x4D15330", Offset = "0x4D13B30", VA = "0x184D15330", Slot = "53")]
		private void KCNHMONHNNE(object PMBANMJEEBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x4D16690", Offset = "0x4D14E90", VA = "0x184D16690", Slot = "28")]
		private bool ONBLGDNGOKI([In] FPLGDJMPCLI FKKGMPDEPMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x4D15300", Offset = "0x4D13B00", VA = "0x184D15300", Slot = "30")]
		private bool JPEBIJIKEPH([In] KOMAGDOGKIC FKKGMPDEPMA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class LOOHMLBJMKL : KMGDFGGPNHB<CKAMJHIJJAP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override NodeVisualizationKey LKLFDONKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xA5CF90", Offset = "0xA5B790", VA = "0x180A5CF90", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x1C21AB0", Offset = "0x1C202B0", VA = "0x181C21AB0")]
		public LOOHMLBJMKL(AANLPGCMHPA GKEFFDGGLDF, CKAMJHIJJAP GIJABPPCKCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class DOLLCEGMBLP : DFKPCFJKAMP<EOLMPMOGJAB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override NodeVisualizationKey LKLFDONKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x17A9280", Offset = "0x17A7A80", VA = "0x1817A9280", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1C0F0A0", Offset = "0x1C0D8A0", VA = "0x181C0F0A0")]
		public DOLLCEGMBLP(AANLPGCMHPA GKEFFDGGLDF, EOLMPMOGJAB GIJABPPCKCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private sealed class LJNDONLOPBC : DFKPCFJKAMP<OIFBGGIIBJD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public override NodeVisualizationKey LKLFDONKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xABC3F0", Offset = "0xABABF0", VA = "0x180ABC3F0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x1C21690", Offset = "0x1C1FE90", VA = "0x181C21690")]
		public LJNDONLOPBC(AANLPGCMHPA GKEFFDGGLDF, OIFBGGIIBJD GIJABPPCKCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class BMIGEHMGICG : DFKPCFJKAMP<DNLBPFFBHEM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public override NodeVisualizationKey LKLFDONKJGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7D3A50", Offset = "0x7D2250", VA = "0x1807D3A50", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x1C0D820", Offset = "0x1C0C020", VA = "0x181C0D820")]
		public BMIGEHMGICG(AANLPGCMHPA GKEFFDGGLDF, DNLBPFFBHEM GIJABPPCKCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1C0EA10", Offset = "0x1C0D210", VA = "0x181C0EA10")]
	internal static CAMCHJLFJJP KKMBICLNKPK(AANLPGCMHPA GKEFFDGGLDF, HBAGMPEDPLJ GIJABPPCKCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class IJBBBHKGCCO : LHBEDNMEKMJ, BJMMGIBNAGM, LLPGEAFDKFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public CJFFNAOEMIF<KLHHMAILMHO> CHJLHGLLEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xEB7870", Offset = "0xEB6070", VA = "0x180EB7870", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(CJFFNAOEMIF<KLHHMAILMHO>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x1074A60", Offset = "0x1073260", VA = "0x181074A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public override CJFFNAOEMIF<LELJNFMCDIJ> BGPHEPJNBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x1C1D4E0", Offset = "0x1C1BCE0", VA = "0x181C1D4E0", Slot = "19")]
		get
		{
			return default(CJFFNAOEMIF<LELJNFMCDIJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x1C1D840", Offset = "0x1C1C040", VA = "0x181C1D840")]
	private IJBBBHKGCCO(AANLPGCMHPA GKEFFDGGLDF, HBAGMPEDPLJ GIJABPPCKCI, GPIKJJGEENM BHFIEOOPGEN, CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF, CJFFNAOEMIF<KLHHMAILMHO> IPMLDIJFFGD, bool FFAKFHHJKML, string HNHMJGCODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x1C1D520", Offset = "0x1C1BD20", VA = "0x181C1D520")]
	public static IJBBBHKGCCO KKMBICLNKPK(AANLPGCMHPA GKEFFDGGLDF, HBAGMPEDPLJ GIJABPPCKCI, GPIKJJGEENM DEDFPNOAEBD, CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF, CJFFNAOEMIF<BEGPJCNMDJN> BEDKCOKPODJ, CJFFNAOEMIF<KLHHMAILMHO> IPMLDIJFFGD, bool FFAKFHHJKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x1074A60", Offset = "0x1073260", VA = "0x181074A60")]
	internal void BBOLKPHLEKD(CJFFNAOEMIF<KLHHMAILMHO> FKKGMPDEPMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public abstract class LHBEDNMEKMJ : LLPGEAFDKFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private struct ICLAAOKFFFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private OBCKDAMLIDB? INKLMNEALOO;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1C1D430", Offset = "0x1C1BC30", VA = "0x181C1D430")]
		public void BEIKHFOBAHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1C1D440", Offset = "0x1C1BC40", VA = "0x181C1D440")]
		public OBCKDAMLIDB KKOMBDBPHJN(LHBEDNMEKMJ HOFFHALJEHA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	protected readonly AANLPGCMHPA GHODDNNEGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	protected readonly HBAGMPEDPLJ HBDBPDCAEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private ICLAAOKFFFH DPFMOGMFHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly HFBEAMKKBEA IKCABGKFNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly List<KGLEBBNNJGF> EHIHPPAEHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<DEKKFOJNNMC> FLKGCMMNKAK;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public IEnumerable<StaticEdge> NNPNICEIHFE
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x1C20930", Offset = "0x1C1F130", VA = "0x181C20930", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public DisplayKind KPFEBCDHLFG
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x772110", Offset = "0x770910", VA = "0x180772110", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public OKMFLAIJCBC<PEKCPKJHMHE> ICJDKOGMPJC
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1C202C0", Offset = "0x1C1EAC0", VA = "0x181C202C0", Slot = "6")]
		get
		{
			return default(OKMFLAIJCBC<PEKCPKJHMHE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	protected DHHCBGJBCFH FLJMICDBDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8ACCD0", Offset = "0x8AB4D0", VA = "0x1808ACCD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public BPGFPAAJOEJ JGDIAIFDEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x1C20220", Offset = "0x1C1EA20", VA = "0x181C20220", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	protected OBCKDAMLIDB KLLAMEPDDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1C20220", Offset = "0x1C1EA20", VA = "0x181C20220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public PortImage APPFMPLKBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1C20650", Offset = "0x1C1EE50", VA = "0x181C20650", Slot = "12")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public string MBENGICGPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x768D80", Offset = "0x767580", VA = "0x180768D80", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x768E00", Offset = "0x767600", VA = "0x180768E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public OKMFLAIJCBC<IKFKOGPAMKO> ICMFPJGJGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1C20B20", Offset = "0x1C1F320", VA = "0x181C20B20", Slot = "8")]
		get
		{
			return default(OKMFLAIJCBC<IKFKOGPAMKO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public CJFFNAOEMIF<FFBJLJKKEOB> DGEIGPEOGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xC52230", Offset = "0xC50A30", VA = "0x180C52230", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(CJFFNAOEMIF<FFBJLJKKEOB>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xC50E90", Offset = "0xC4F690", VA = "0x180C50E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public abstract CJFFNAOEMIF<LELJNFMCDIJ> BGPHEPJNBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1C214D0", Offset = "0x1C1FCD0", VA = "0x181C214D0")]
	protected LHBEDNMEKMJ(AANLPGCMHPA GKEFFDGGLDF, HBAGMPEDPLJ GIJABPPCKCI, HFBEAMKKBEA KNFDIBCGIDO, CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF, bool FFAKFHHJKML, string HNHMJGCODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1C20780", Offset = "0x1C1EF80", VA = "0x181C20780", Slot = "20")]
	protected virtual void GLJEDCMMNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1C202F0", Offset = "0x1C1EAF0", VA = "0x181C202F0", Slot = "21")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x1C20EE0", Offset = "0x1C1F6E0", VA = "0x181C20EE0", Slot = "13")]
	public void OLLLHDCBBLA(KGLEBBNNJGF DEEMBLOLCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1C208D0", Offset = "0x1C1F0D0", VA = "0x181C208D0", Slot = "14")]
	public void HOIFEKHFFAC(DEKKFOJNNMC DEEMBLOLCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x1C20F40", Offset = "0x1C1F740", VA = "0x181C20F40", Slot = "15")]
	public void POKMIJCNKBE(JDLCMOHMNFG DNEAJJNKOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1C20440", Offset = "0x1C1EC40", VA = "0x181C20440", Slot = "22")]
	protected virtual void EAABCBPBINN(JDLCMOHMNFG DNEAJJNKOBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x1C20B40", Offset = "0x1C1F340", VA = "0x181C20B40")]
	private void NIJFKGHPCCG(bool EANKMFHELBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x1C20CD0", Offset = "0x1C1F4D0", VA = "0x181C20CD0")]
	private void NMLBJBEIJGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x1C204A0", Offset = "0x1C1ECA0", VA = "0x181C204A0")]
	private void FFPGPIEMMFD([In] INNJILDLELF GCCKADBKCHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x1C20AC0", Offset = "0x1C1F2C0", VA = "0x181C20AC0", Slot = "16")]
	public void INGMPNGIFOD(KGLEBBNNJGF DEEMBLOLCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x1C20E80", Offset = "0x1C1F680", VA = "0x181C20E80", Slot = "17")]
	public void OHLMHOHGBEI(DEKKFOJNNMC DEEMBLOLCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x768E00", Offset = "0x767600", VA = "0x180768E00")]
	internal void DKMEPGCIOAJ(string HNHMJGCODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0xC50E90", Offset = "0xC4F690", VA = "0x180C50E90")]
	internal void KFFOIJMCGLL(CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class HOCAEPGIMEB : JLAHKJKKBHG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class FINEMFLBEHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public AANLPGCMHPA circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public HBAGMPEDPLJ node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public CJFFNAOEMIF<FFBJLJKKEOB> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public bool canInteract;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public FINEMFLBEHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1C162E0", Offset = "0x1C14AE0", VA = "0x181C162E0")]
		internal FEODNONGHBN NOIOMLEONOL((int PortDescIndex, int PortIndex, LJKICLAAKIK InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x1C16260", Offset = "0x1C14A60", VA = "0x181C16260")]
		internal IJBBBHKGCCO MPHDGELIEJK(GPIKJJGEENM i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct BDCDHHDLHIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public HOCAEPGIMEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private DEHANOACHCB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x1C0AF10", Offset = "0x1C09710", VA = "0x181C0AF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x1C0B370", Offset = "0x1C09B70", VA = "0x181C0B370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct GIGLMJDILEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public HOCAEPGIMEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public CJFFNAOEMIF<NDGNKDNEMLN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private DEHANOACHCB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1C171C0", Offset = "0x1C159C0", VA = "0x181C171C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1C17510", Offset = "0x1C15D10", VA = "0x181C17510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct HHHMCMOINDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public HOCAEPGIMEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public CJFFNAOEMIF<BEGPJCNMDJN> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private DEHANOACHCB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1C179C0", Offset = "0x1C161C0", VA = "0x181C179C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1C17D10", Offset = "0x1C16510", VA = "0x181C17D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct AFIOPGKBOAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public HOCAEPGIMEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public CJFFNAOEMIF<NDGNKDNEMLN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public CJFFNAOEMIF<NDGNKDNEMLN> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private DEHANOACHCB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x1C09A70", Offset = "0x1C08270", VA = "0x181C09A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x1C09DC0", Offset = "0x1C085C0", VA = "0x181C09DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct IJJLMBKABJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public HOCAEPGIMEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public CJFFNAOEMIF<BEGPJCNMDJN> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public CJFFNAOEMIF<BEGPJCNMDJN> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private DEHANOACHCB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x1C1D890", Offset = "0x1C1C090", VA = "0x181C1D890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1C1DBE0", Offset = "0x1C1C3E0", VA = "0x181C1DBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct KIKHJEHOHHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public HOCAEPGIMEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private DEHANOACHCB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1C1ED80", Offset = "0x1C1D580", VA = "0x181C1ED80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1C1F1F0", Offset = "0x1C1D9F0", VA = "0x181C1F1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct DAAKPBHKAAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public HOCAEPGIMEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private DEHANOACHCB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x1C0DBF0", Offset = "0x1C0C3F0", VA = "0x181C0DBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1C0DF40", Offset = "0x1C0C740", VA = "0x181C0DF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct LLPPECMDIFL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public HOCAEPGIMEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public CJFFNAOEMIF<NDGNKDNEMLN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private DEHANOACHCB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x1C216F0", Offset = "0x1C1FEF0", VA = "0x181C216F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1C21A40", Offset = "0x1C20240", VA = "0x181C21A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct OOMNHGAIGDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public HOCAEPGIMEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public CJFFNAOEMIF<BEGPJCNMDJN> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private DEHANOACHCB <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private TaskAwaiter<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x1C23750", Offset = "0x1C21F50", VA = "0x181C23750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x1C23AA0", Offset = "0x1C222A0", VA = "0x181C23AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly bool GCLKLHNFMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly AANLPGCMHPA GHODDNNEGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly bool KPMKOMEKHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private AHJINMGOCCN<BEFHGJIIOCM, FEODNONGHBN> CFCEMPFDAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private AHJINMGOCCN<BEFHGJIIOCM, JMDINOFHLGI> HCMEIKBIGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly HBAGMPEDPLJ HBDBPDCAEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private AHJINMGOCCN<KLHHMAILMHO, IJBBBHKGCCO> GCPJOGBDGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private AHJINMGOCCN<KLHHMAILMHO, BJMMGIBNAGM> KMGEBGIAICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private string? ENLOOHAJPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly NODFOJBDBAO BHCEANDCEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private CJFFNAOEMIF<FFBJLJKKEOB> EBKPMKKEJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[CompilerGenerated]
	private Action? LJLDDKKPEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[CompilerGenerated]
	private Action? LBGDNNOOHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[CompilerGenerated]
	private Action<CJFFNAOEMIF<BEFHGJIIOCM>>? CBGNCNIKCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	[CompilerGenerated]
	private Action<CJFFNAOEMIF<KLHHMAILMHO>>? BOGFGDCDMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	[CompilerGenerated]
	private JLAHKJKKBHG.ELAOMJLBIHK? INKHFNOPLED;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool CEMNHMHEDDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x1C18150", Offset = "0x1C16950", VA = "0x181C18150", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool GEBCCJGPAGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x1C1CE60", Offset = "0x1C1B660", VA = "0x181C1CE60", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool INOCKMODILM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AFA0", Offset = "0x1C197A0", VA = "0x181C1AFA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public OKMFLAIJCBC<PEKCPKJHMHE> ICJDKOGMPJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x1C18930", Offset = "0x1C17130", VA = "0x181C18930", Slot = "7")]
		get
		{
			return default(OKMFLAIJCBC<PEKCPKJHMHE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool INLHGKMHINA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x1C18730", Offset = "0x1C16F30", VA = "0x181C18730", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public AHJINMGOCCN<BEFHGJIIOCM, JMDINOFHLGI> CFGGNLAGBHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0", Slot = "9")]
		get
		{
			return default(AHJINMGOCCN<BEFHGJIIOCM, JMDINOFHLGI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public string MBENGICGPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1C19330", Offset = "0x1C17B30", VA = "0x181C19330", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public OKMFLAIJCBC<IKFKOGPAMKO> ICMFPJGJGNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x1C1BBC0", Offset = "0x1C1A3C0", VA = "0x181C1BBC0", Slot = "11")]
		get
		{
			return default(OKMFLAIJCBC<IKFKOGPAMKO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public AHJINMGOCCN<KLHHMAILMHO, BJMMGIBNAGM> MCPJMIBLIPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x768D80", Offset = "0x767580", VA = "0x180768D80", Slot = "12")]
		get
		{
			return default(AHJINMGOCCN<KLHHMAILMHO, BJMMGIBNAGM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public CJFFNAOEMIF<FFBJLJKKEOB> DGEIGPEOGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C0AF0", Offset = "0x8BF2F0", VA = "0x1808C0AF0", Slot = "13")]
		get
		{
			return default(CJFFNAOEMIF<FFBJLJKKEOB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action PNBGNJJMLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x1C1B4F0", Offset = "0x1C19CF0", VA = "0x181C1B4F0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1C1A8D0", Offset = "0x1C190D0", VA = "0x181C1A8D0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action<CJFFNAOEMIF<BEFHGJIIOCM>, CJFFNAOEMIF<BEFHGJIIOCM>> FFNMNELMDEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1C1CDA0", Offset = "0x1C1B5A0", VA = "0x181C1CDA0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1C1A120", Offset = "0x1C18920", VA = "0x181C1A120", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<CJFFNAOEMIF<KLHHMAILMHO>, CJFFNAOEMIF<KLHHMAILMHO>> LDGEMLKNBKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C570", Offset = "0x1C1AD70", VA = "0x181C1C570", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1C18090", Offset = "0x1C16890", VA = "0x181C18090", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<CJFFNAOEMIF<BEFHGJIIOCM>, JMDINOFHLGI> OPDKMCGNAIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1C1A810", Offset = "0x1C19010", VA = "0x181C1A810", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x1C182D0", Offset = "0x1C16AD0", VA = "0x181C182D0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<CJFFNAOEMIF<BEFHGJIIOCM>> EKAAEELKCNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1C18870", Offset = "0x1C17070", VA = "0x181C18870", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AA90", Offset = "0x1C19290", VA = "0x181C1AA90", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<CJFFNAOEMIF<BEFHGJIIOCM>, JMDINOFHLGI> MOCBJNKFADA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1C1ABF0", Offset = "0x1C193F0", VA = "0x181C1ABF0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1C1BAE0", Offset = "0x1C1A2E0", VA = "0x181C1BAE0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<CJFFNAOEMIF<KLHHMAILMHO>, BJMMGIBNAGM> DIAHPFBFIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1C187B0", Offset = "0x1C16FB0", VA = "0x181C187B0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1C18210", Offset = "0x1C16A10", VA = "0x181C18210", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<CJFFNAOEMIF<KLHHMAILMHO>> MBKAKEDKCOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1C1B060", Offset = "0x1C19860", VA = "0x181C1B060", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1C17FD0", Offset = "0x1C167D0", VA = "0x181C17FD0", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<CJFFNAOEMIF<KLHHMAILMHO>, BJMMGIBNAGM> EPBOCJPBPBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AEE0", Offset = "0x1C196E0", VA = "0x181C1AEE0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x1C1C370", Offset = "0x1C1AB70", VA = "0x181C1C370", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1C1D320", Offset = "0x1C1BB20", VA = "0x181C1D320")]
	private HOCAEPGIMEB(bool FFAKFHHJKML, AANLPGCMHPA GKEFFDGGLDF, bool BMECHEICMDO, AHJINMGOCCN<BEFHGJIIOCM, FEODNONGHBN> CMAAOKAAHMO, AHJINMGOCCN<BEFHGJIIOCM, JMDINOFHLGI> IGOAAKOMEDP, HBAGMPEDPLJ GIJABPPCKCI, AHJINMGOCCN<KLHHMAILMHO, IJBBBHKGCCO> OJFPLIKDOJL, AHJINMGOCCN<KLHHMAILMHO, BJMMGIBNAGM> LNFKMJNINKL, string? IFGFIBNCMLO, NODFOJBDBAO FBFPJBHNDMF, CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1C1B590", Offset = "0x1C19D90", VA = "0x181C1B590")]
	public static HOCAEPGIMEB KKMBICLNKPK(bool FFAKFHHJKML, AANLPGCMHPA GKEFFDGGLDF, bool BMECHEICMDO, HBAGMPEDPLJ GIJABPPCKCI, NODFOJBDBAO FBFPJBHNDMF, CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x1C1A1E0", Offset = "0x1C189E0", VA = "0x181C1A1E0")]
	private void GLJEDCMMNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x1C189B0", Offset = "0x1C171B0", VA = "0x181C189B0", Slot = "41")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x1C1C280", Offset = "0x1C1AA80", VA = "0x181C1C280", Slot = "32")]
	[AsyncStateMachine(typeof(BDCDHHDLHIL))]
	public Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> MIOAPEBCPJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1C1ACB0", Offset = "0x1C194B0", VA = "0x181C1ACB0")]
	private (OKCKHKADDJC, int)? IKLPMGJDAHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x1C19B10", Offset = "0x1C18310", VA = "0x181C19B10")]
	private void FJFBAPICKCN(int DKBAKHAFPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x1C1BBA0", Offset = "0x1C1A3A0", VA = "0x181C1BBA0")]
	private void KOJJDGGIMCE(int DKBAKHAFPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1C19D80", Offset = "0x1C18580", VA = "0x181C19D80")]
	private void GJJCJADBEEI(int IEJMCOBPPMN, int DKFCPNJJLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x80D840", Offset = "0x80C040", VA = "0x18080D840")]
	private void OIBMLJGAFJK(int DKBAKHAFPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x1C1C870", Offset = "0x1C1B070", VA = "0x181C1C870")]
	private void OOMKFGFCAIP(int DKBAKHAFPCE, int JCNGBCNKANA, LJKICLAAKIK EJOBIJGJEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x1C1ABA0", Offset = "0x1C193A0", VA = "0x181C1ABA0")]
	private void IGHCFJHAOHJ(int EANKMFHELBA, int JCNGBCNKANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x1C1C520", Offset = "0x1C1AD20", VA = "0x181C1C520")]
	private void NMPFIGJKJJJ(int EANKMFHELBA, int JCNGBCNKANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x1C1BBE0", Offset = "0x1C1A3E0", VA = "0x181C1BBE0")]
	private void LLCLFOKOBGK(int DKBAKHAFPCE, int JCNGBCNKANA, LJKICLAAKIK EJOBIJGJEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x1C199B0", Offset = "0x1C181B0", VA = "0x181C199B0")]
	private void FGFDDBPCMFD(int DKBAKHAFPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x1C1BBA0", Offset = "0x1C1A3A0", VA = "0x181C1BBA0")]
	private void LHNDHLFNANK(int DKBAKHAFPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x1C18390", Offset = "0x1C16B90", VA = "0x181C18390")]
	private void BLAOMANNBGI(int IEJMCOBPPMN, int DKFCPNJJLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x80D840", Offset = "0x80C040", VA = "0x18080D840")]
	private void BIKFPAMEPCI(int DKBAKHAFPCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1C19360", Offset = "0x1C17B60", VA = "0x181C19360")]
	private void EJBKCMGGJEF(int DKBAKHAFPCE, int JCNGBCNKANA, GPIKJJGEENM EJOBIJGJEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x1C18960", Offset = "0x1C17160", VA = "0x181C18960")]
	private void DGODNHNHGKJ(int EANKMFHELBA, int JCNGBCNKANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x1C1AB50", Offset = "0x1C19350", VA = "0x181C1AB50")]
	private void IDPGEHKJIBN(int EANKMFHELBA, int JCNGBCNKANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x1C1CEA0", Offset = "0x1C1B6A0", VA = "0x181C1CEA0")]
	private void PPKMGAGMPLK(int DKBAKHAFPCE, int JCNGBCNKANA, GPIKJJGEENM EJOBIJGJEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x1C19C70", Offset = "0x1C18470", VA = "0x181C19C70", Slot = "33")]
	[AsyncStateMachine(typeof(GIGLMJDILEK))]
	public Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> GANGHNKBADG(CJFFNAOEMIF<NDGNKDNEMLN> PNBJCJCOJOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1C1C040", Offset = "0x1C1A840", VA = "0x181C1C040", Slot = "34")]
	[AsyncStateMachine(typeof(HHHMCMOINDL))]
	public Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> MABNHKJCDKL(CJFFNAOEMIF<BEGPJCNMDJN> BEDKCOKPODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x1C1A970", Offset = "0x1C19170", VA = "0x181C1A970", Slot = "35")]
	[AsyncStateMachine(typeof(AFIOPGKBOAM))]
	public Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> HDNKKGKHDBK(CJFFNAOEMIF<NDGNKDNEMLN> PNBJCJCOJOE, CJFFNAOEMIF<NDGNKDNEMLN> HNIEDOIGJBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1C1C630", Offset = "0x1C1AE30", VA = "0x181C1C630", Slot = "36")]
	[AsyncStateMachine(typeof(IJJLMBKABJA))]
	public Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> ODMHKIFPLHG(CJFFNAOEMIF<BEGPJCNMDJN> BEDKCOKPODJ, CJFFNAOEMIF<BEGPJCNMDJN> HNIEDOIGJBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1C1C430", Offset = "0x1C1AC30", VA = "0x181C1C430", Slot = "37")]
	[AsyncStateMachine(typeof(KIKHJEHOHHE))]
	public Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> NJBHELDBBEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x1C1C750", Offset = "0x1C1AF50", VA = "0x181C1C750", Slot = "38")]
	[AsyncStateMachine(typeof(DAAKPBHKAAM))]
	public Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> OHMOGFFJNEK(string PDDEIOPJGCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x1C19880", Offset = "0x1C18080", VA = "0x181C19880", Slot = "39")]
	[AsyncStateMachine(typeof(LLPPECMDIFL))]
	public Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> EPNNGBMOIPC(CJFFNAOEMIF<NDGNKDNEMLN> PNBJCJCOJOE, string HNHMJGCODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x1C1C150", Offset = "0x1C1A950", VA = "0x181C1C150", Slot = "40")]
	[AsyncStateMachine(typeof(OOMNHGAIGDE))]
	public Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> MAKLIBAIACF(CJFFNAOEMIF<BEGPJCNMDJN> BEDKCOKPODJ, string HNHMJGCODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x1C1B120", Offset = "0x1C19920", VA = "0x181C1B120")]
	internal void KFFOIJMCGLL(CJFFNAOEMIF<FFBJLJKKEOB> FKKGMPDEPMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public sealed class JBOLJFCPGHK : AHEJKJNNJIC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface JJPEENJBBFG
	{
		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		DAPGEFDGMNH EIPFBMOJLCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<KGOIBMCNEGI> DIIOMDDIEHM(CancellationToken EHCFBFBFEDH);

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<FFPNNGOGOKI> LFOMLKELBIN(CancellationToken EHCFBFBFEDH);

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<KCHEFKPEJHC> PIFLALFIKCL(CancellationToken EHCFBFBFEDH);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct MLLDNCBEIIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder<JBOLJFCPGHK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AANLPGCMHPA circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public KGOIBMCNEGI roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public FFPNNGOGOKI superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private JJPEENJBBFG <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private FFPNNGOGOKI <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TaskAwaiter<KGOIBMCNEGI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private TaskAwaiter<FFPNNGOGOKI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TaskAwaiter<KCHEFKPEJHC> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1C21F30", Offset = "0x1C20730", VA = "0x181C21F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x1C227A0", Offset = "0x1C20FA0", VA = "0x181C227A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly GMCALCOKFAM JDJMFBLMGOB;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public GMCALCOKFAM DJNBEMAOFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	private JBOLJFCPGHK(GMCALCOKFAM ACBKGKJCONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E060", Offset = "0x1C1C860", VA = "0x181C1E060")]
	[AsyncStateMachine(typeof(MLLDNCBEIIG))]
	public static Task<JBOLJFCPGHK> DNOENLJOICC(AANLPGCMHPA GKEFFDGGLDF, KGOIBMCNEGI? KAGMDCLCJHI, FFPNNGOGOKI? LAPMLCJGBLE, CancellationToken EHCFBFBFEDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E1C0", Offset = "0x1C1C9C0", VA = "0x181C1E1C0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public readonly struct FIMEDEAJAGK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct IMALKBDHLKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<object, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public FIMEDEAJAGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public GMCGHACCLIF action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private TaskAwaiter<EOPMGLNDIOA<object, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1C1DC50", Offset = "0x1C1C450", VA = "0x181C1DC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1C1DEE0", Offset = "0x1C1C6E0", VA = "0x181C1DEE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct BBPNNIOGIFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<bool, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public FDICFACCMJK rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public KGOIBMCNEGI circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public FFPNNGOGOKI superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public FIMEDEAJAGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private GMCGHACCLIF[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private TaskAwaiter<EOPMGLNDIOA<object, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x1C0AAC0", Offset = "0x1C092C0", VA = "0x181C0AAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1C0AEA0", Offset = "0x1C096A0", VA = "0x181C0AEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct AMFCDBPHPOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public FIMEDEAJAGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private TaskAwaiter<EOPMGLNDIOA<object, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1C09E90", Offset = "0x1C08690", VA = "0x181C09E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1C0A170", Offset = "0x1C08970", VA = "0x181C0A170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly OANIKMDLOIC AGDLPINNPEF;

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x7ECAD0", Offset = "0x7EB2D0", VA = "0x1807ECAD0")]
	public FIMEDEAJAGK(OANIKMDLOIC FGOFNFFEGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x1C15EE0", Offset = "0x1C146E0", VA = "0x181C15EE0")]
	[AsyncStateMachine(typeof(IMALKBDHLKA))]
	private Task<EOPMGLNDIOA<object, NHKNMEADEEO>> FHGPLMACHNO(GMCGHACCLIF OONIIOMBHJI, bool MBFIBHOAEDA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x1C16010", Offset = "0x1C14810", VA = "0x181C16010")]
	[AsyncStateMachine(typeof(BBPNNIOGIFG))]
	public Task<EOPMGLNDIOA<bool, NHKNMEADEEO?>>? MLMKPDONMEI(int CIGNOIJEBJA, FDICFACCMJK? IGHNNKNKLIG, KGOIBMCNEGI? NKLOAMFHFJB, FFPNNGOGOKI? LAPMLCJGBLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x1C16170", Offset = "0x1C14970", VA = "0x181C16170")]
	[AsyncStateMachine(typeof(AMFCDBPHPOL))]
	public Task<EOPMGLNDIOA<JGIANJFFIJK, NHKNMEADEEO>> NAKDAJJPGKJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public sealed class LDPLCKDDIKO : HHJIOOCKCEP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly CDJIHFPDDBL NNNBNHJAJHF;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public CDJIHFPDDBL BCEFNBJIFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x765EF0", Offset = "0x7646F0", VA = "0x180765EF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	private LDPLCKDDIKO(CDJIHFPDDBL NAIAAADOFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x1C20190", Offset = "0x1C1E990", VA = "0x181C20190")]
	public static LDPLCKDDIKO PFKIHJFLILM(AANLPGCMHPA GKEFFDGGLDF, FDICFACCMJK MNENONEGHAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x1C20170", Offset = "0x1C1E970", VA = "0x181C20170", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public interface GGLILNOFHFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	PKCEAOHPJDG MOEDOFDKFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	MGMENGBEKEA FONMMLAFCBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	FHLBCBCJKFF KAKOEJCMCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	JKHEKPJJGIB JGKIDIDCKDA
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	BLAMPPCHKOL DKKPNLIGOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public interface IILLBOBJCJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000082")]
	GGLILNOFHFM? FPMDMOBKBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool PODDKBEPHJP
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool FBKNHMFKEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<GGLILNOFHFM?>? EDJKJJEAJAF();

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task LGENDODCDOO(AANLPGCMHPA GKEFFDGGLDF, FDICFACCMJK MNENONEGHAJ, KGOIBMCNEGI? MDDKEDBIHGL, FFPNNGOGOKI? LEBPAOPGOHF);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[BOIBKOKHMEP("IStaticCV2Instance")]
public interface AHEJKJNNJIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	GMCALCOKFAM DJNBEMAOFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[BOIBKOKHMEP("IStaticEVInstance")]
public interface HHJIOOCKCEP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	CDJIHFPDDBL BCEFNBJIFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public sealed class HEOHLKBONPB : EBOHAPONLKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private readonly AANLPGCMHPA GHODDNNEGJK;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public OAACHNGMKHH? FLMPJFHFLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1C17640", Offset = "0x1C15E40", VA = "0x181C17640", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	internal HEOHLKBONPB(AANLPGCMHPA GKEFFDGGLDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public sealed class JKHEKPJJGIB : OAACHNGMKHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly AHEJKJNNJIC KOLLFPODLJE;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public MOOIJPDONPC FHGPLMACHNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E1E0", Offset = "0x1C1C9E0", VA = "0x181C1E1E0", Slot = "4")]
		get
		{
			return default(MOOIJPDONPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public MFOMFPFALFD JCMPLFJBPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E360", Offset = "0x1C1CB60", VA = "0x181C1E360", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public OKMFLAIJCBC<PEKCPKJHMHE> KBGGDAOAJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E240", Offset = "0x1C1CA40", VA = "0x181C1E240", Slot = "6")]
		get
		{
			return default(OKMFLAIJCBC<PEKCPKJHMHE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public GMCALCOKFAM NKKEFJOIEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x1C1E310", Offset = "0x1C1CB10", VA = "0x181C1E310", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	public JKHEKPJJGIB(AHEJKJNNJIC FNGCMEJBGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E2A0", Offset = "0x1C1CAA0", VA = "0x181C1E2A0")]
	public bool OEGOFINBMGG([In] OKMFLAIJCBC<PEKCPKJHMHE> HGPLGELHGLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x1C1E2A0", Offset = "0x1C1CAA0", VA = "0x181C1E2A0", Slot = "8")]
	private bool EHHKHCPKEAP([In] OKMFLAIJCBC<PEKCPKJHMHE> HGPLGELHGLG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class ODOENFFMBEA
{
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x1C23240", Offset = "0x1C21A40", VA = "0x181C23240")]
	public static IACGCHNPDDC<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA, DFLBEHIMOOF.GMDCOPMPIHF<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA>> PHNCEHEKCOE([In] this IACGCHNPDDC<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA, DFLBEHIMOOF.GMDCOPMPIHF<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA>> OHEECIICLKN)
	{
		return default(IACGCHNPDDC<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA, DFLBEHIMOOF.GMDCOPMPIHF<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public sealed class ICEMHPGPPAA : GCHMOHKJOEG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly AANLPGCMHPA GHODDNNEGJK;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool FBKNHMFKEPK
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x1C1D410", Offset = "0x1C1BC10", VA = "0x181C1D410", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	internal ICEMHPGPPAA(AANLPGCMHPA GKEFFDGGLDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public sealed class ELHOFFKHCMG : AGAFDPMCJJG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct NLFCKNNBKEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public AsyncTaskMethodBuilder<CLINDLPGIOG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public ELHOFFKHCMG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TaskAwaiter<GGLILNOFHFM?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1C22D50", Offset = "0x1C21550", VA = "0x181C22D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x1C23000", Offset = "0x1C21800", VA = "0x181C23000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly AANLPGCMHPA GHODDNNEGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private IReadOnlyList<OKMFLAIJCBC<CJBAFCLDANB>>? BEHFCHDEJHH;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public CLINDLPGIOG? FLMPJFHFLHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x1C119B0", Offset = "0x1C101B0", VA = "0x181C119B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool CMAICCNKAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1C11250", Offset = "0x1C0FA50", VA = "0x181C11250", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool EKFJBNBCABF
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x1C11750", Offset = "0x1C0FF50", VA = "0x181C11750", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	internal ELHOFFKHCMG(AANLPGCMHPA GKEFFDGGLDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1C11660", Offset = "0x1C0FE60", VA = "0x181C11660", Slot = "7")]
	[AsyncStateMachine(typeof(NLFCKNNBKEF))]
	public Task<CLINDLPGIOG> IPBDJPAEEFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x1C112B0", Offset = "0x1C0FAB0", VA = "0x181C112B0")]
	internal Dictionary<OKMFLAIJCBC<PEKCPKJHMHE>, Guid> DOAMLLHBJEJ(IEnumerable<KAGLGJLPIBC> HAFPIDLBEPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x1C11A30", Offset = "0x1C10230", VA = "0x181C11A30")]
	public EOPMGLNDIOA<BOCOKLBKDIB, HNHFFBALMII> NFICEPLMJHB([In] BOCOKLBKDIB LCOOPLOHNDD, IEnumerable<KAGLGJLPIBC> ADPACPMPOKE, int PMMGNNOPNCK)
	{
		return default(EOPMGLNDIOA<BOCOKLBKDIB, HNHFFBALMII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x1C11620", Offset = "0x1C0FE20", VA = "0x181C11620")]
	internal static ICGPIDNEGNK EDHCNLKODIC(NCFBIMECDBA DPBANNAIBDE, HBAGMPEDPLJ GIJABPPCKCI)
	{
		return default(ICGPIDNEGNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x1C117B0", Offset = "0x1C0FFB0", VA = "0x181C117B0", Slot = "8")]
	private EOPMGLNDIOA<BOCOKLBKDIB, HNHFFBALMII> JPPCMMEOMED([In] BOCOKLBKDIB LCOOPLOHNDD, IEnumerable<KAGLGJLPIBC> ADPACPMPOKE, int PMMGNNOPNCK)
	{
		return default(EOPMGLNDIOA<BOCOKLBKDIB, HNHFFBALMII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x1C11C20", Offset = "0x1C10420", VA = "0x181C11C20")]
	[CompilerGenerated]
	internal static ICGPIDNEGNK OOPOJJICEGN(NCFBIMECDBA GLPBFACJGMG, HBAGMPEDPLJ HICOIFBGKGA)
	{
		return default(ICGPIDNEGNK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public sealed class BLAMPPCHKOL : CLINDLPGIOG
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	internal static class EKEGGPIMEPD
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class GJKOLIOBCCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public FIDJKEIGAGK spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public GJKOLIOBCCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x1C26150", Offset = "0x1C24950", VA = "0x181C26150")]
			internal bool NLHOCJKHPKD(EAIADKNGDME n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class JGPNKFCDODI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
			public JGPNKFCDODI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x1C26BA0", Offset = "0x1C253A0", VA = "0x181C26BA0")]
			internal void HOJEMCACFGG(EAIADKNGDME n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1C10D20", Offset = "0x1C0F520", VA = "0x181C10D20")]
		public static EOPMGLNDIOA<CLINDLPGIOG.MBNPOLMNKDE, HNHFFBALMII> MFGPHFHEOBL(BLAMPPCHKOL AFFJMIFONEM, [In] CLINDLPGIOG.DDDGFAJJOMP CCBNPDAGICC)
		{
			return default(EOPMGLNDIOA<CLINDLPGIOG.MBNPOLMNKDE, HNHFFBALMII>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1C0FBC0", Offset = "0x1C0E3C0", VA = "0x181C0FBC0")]
		internal static EOPMGLNDIOA<(JKJCHIBAFMP, DPHHCHDLLDE), NHKNMEADEEO> DCOBEADBCKH(BLAMPPCHKOL AFFJMIFONEM, DPHHCHDLLDE PBEMMAINFJN, bool PDNJGMCGCMG, [In] OKMFLAIJCBC<PEKCPKJHMHE> HMHCHMJBAAC, [In] int? KIBNCGDDJJH, [In] ICGPIDNEGNK? CDCKFFOFOMC, [In] ICGPIDNEGNK? MGJEBIMCIJI)
		{
			return default(EOPMGLNDIOA<(JKJCHIBAFMP, DPHHCHDLLDE), NHKNMEADEEO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1C0F730", Offset = "0x1C0DF30", VA = "0x181C0F730")]
		private static void CNCBMFDAKAB(bool PDNJGMCGCMG, KAGLGJLPIBC CDHDPJPOJHJ, JKJCHIBAFMP AHNNMFMENJG, [In] OKMFLAIJCBC<PEKCPKJHMHE> HMHCHMJBAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1C10910", Offset = "0x1C0F110", VA = "0x181C10910")]
		public static void ELGPLCDCNCH(GBCIKKIPJHE FFJDMFBHDPI, [In] CLINDLPGIOG.ANPFPIDNDLC LNIALAGKGJJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly AANLPGCMHPA GHODDNNEGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private readonly AHEJKJNNJIC KOLLFPODLJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private readonly HHJIOOCKCEP HJKGJHCEGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private readonly DBBOBFACOHE GGDHPGFPCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private readonly ELHOFFKHCMG LKOJCAPNDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private Dictionary<OKMFLAIJCBC<IKFKOGPAMKO>, CAMCHJLFJJP> OOCELEEFGPG;

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x1C0D4A0", Offset = "0x1C0BCA0", VA = "0x181C0D4A0")]
	public BLAMPPCHKOL(AANLPGCMHPA GKEFFDGGLDF, AHEJKJNNJIC FNGCMEJBGEO, HHJIOOCKCEP BOHCLNCBFJJ, ELHOFFKHCMG BMKHGDNCGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x1C0CB50", Offset = "0x1C0B350", VA = "0x181C0CB50")]
	public CAMCHJLFJJP? JJEPDHJHPFI([In] OKMFLAIJCBC<IKFKOGPAMKO> AACPINCHENM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x1C0D0B0", Offset = "0x1C0B8B0", VA = "0x181C0D0B0")]
	private void MNHLMNECPOJ(OKMFLAIJCBC<IKFKOGPAMKO> AACPINCHENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x1C0C0D0", Offset = "0x1C0A8D0", VA = "0x181C0C0D0")]
	private CAMCHJLFJJP? ELMNJGBENME([In] OKMFLAIJCBC<IKFKOGPAMKO> AACPINCHENM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x1C0C5C0", Offset = "0x1C0ADC0", VA = "0x181C0C5C0")]
	public HBAGMPEDPLJ? GOJINPCNGCG([In] OKMFLAIJCBC<IKFKOGPAMKO> AACPINCHENM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x1C0C200", Offset = "0x1C0AA00", VA = "0x181C0C200")]
	public MCLBNDOONCF? FEFMKNPIFKO([In] OKMFLAIJCBC<PEKCPKJHMHE> HGPLGELHGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x1C0BEC0", Offset = "0x1C0A6C0", VA = "0x181C0BEC0")]
	private FIDJKEIGAGK? BOONIIBIGGB([In] OKMFLAIJCBC<PEKCPKJHMHE> HGPLGELHGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x1C0D300", Offset = "0x1C0BB00", VA = "0x181C0D300")]
	private MCLBNDOONCF? PMEPNGHNLCC([In] OKMFLAIJCBC<PEKCPKJHMHE> HGPLGELHGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x1C0C4D0", Offset = "0x1C0ACD0", VA = "0x181C0C4D0", Slot = "6")]
	public IEnumerable<INDBJHJMBMA> FMMEFJIMEPK(bool EBKIOHADLLA, bool ECNHFAJLPJA, bool KFGMIPCLJIL, bool FNCFPFAKEND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x1C0BF50", Offset = "0x1C0A750", VA = "0x181C0BF50")]
	public EOPMGLNDIOA<CLINDLPGIOG.MBNPOLMNKDE, HNHFFBALMII> CKNEKACGPEC([In] CLINDLPGIOG.DDDGFAJJOMP CCBNPDAGICC)
	{
		return default(EOPMGLNDIOA<CLINDLPGIOG.MBNPOLMNKDE, HNHFFBALMII>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x1C0D110", Offset = "0x1C0B910", VA = "0x181C0D110", Slot = "8")]
	public DCNPGOFDKGI NEHHKIBDMNG(IEnumerable<KAGLGJLPIBC> ADPACPMPOKE)
	{
		return default(DCNPGOFDKGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x1C0C3B0", Offset = "0x1C0ABB0", VA = "0x181C0C3B0", Slot = "9")]
	public DCNPGOFDKGI FLGPBKEDNLH()
	{
		return default(DCNPGOFDKGI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x1C0BD20", Offset = "0x1C0A520", VA = "0x181C0BD20")]
	private CHOIBEAOALD BOMLILGNDOM(HPPICHAHICC PMLPBMNHCPH, IEnumerable<OKMFLAIJCBC<PEKCPKJHMHE>> NDKJICGGCFG, IEnumerable<OKMFLAIJCBC<IKFKOGPAMKO>> CMAPNNMBKEN)
	{
		return default(CHOIBEAOALD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x1C0BA00", Offset = "0x1C0A200", VA = "0x181C0BA00", Slot = "10")]
	public CHOIBEAOALD BOMLILGNDOM(HPPICHAHICC PMLPBMNHCPH, IEnumerable<OKMFLAIJCBC<IKFKOGPAMKO>> CMAPNNMBKEN, IEnumerable<KAGLGJLPIBC> ADPACPMPOKE)
	{
		return default(CHOIBEAOALD);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x1C0CCB0", Offset = "0x1C0B4B0", VA = "0x181C0CCB0")]
	private static IEnumerable<OKMFLAIJCBC<PEKCPKJHMHE>> KBDLHAEGKIE(IEnumerable<KAGLGJLPIBC> ADPACPMPOKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x1C0C6B0", Offset = "0x1C0AEB0", VA = "0x181C0C6B0")]
	private IEnumerable<OKMFLAIJCBC<IKFKOGPAMKO>> HMILPFDCAHM(IEnumerable<KAGLGJLPIBC> ADPACPMPOKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x1C0D0A0", Offset = "0x1C0B8A0", VA = "0x181C0D0A0", Slot = "4")]
	private MCLBNDOONCF LIFNAIBCGOH([In] OKMFLAIJCBC<PEKCPKJHMHE> HGPLGELHGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x1C0BF80", Offset = "0x1C0A780", VA = "0x181C0BF80", Slot = "5")]
	private CAMCHJLFJJP CLFGAICMODJ([In] OKMFLAIJCBC<IKFKOGPAMKO> AACPINCHENM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1C0BF50", Offset = "0x1C0A750", VA = "0x181C0BF50", Slot = "7")]
	private EOPMGLNDIOA<CLINDLPGIOG.MBNPOLMNKDE, HNHFFBALMII> DKIFFJINPJC([In] CLINDLPGIOG.DDDGFAJJOMP CCBNPDAGICC)
	{
		return default(EOPMGLNDIOA<CLINDLPGIOG.MBNPOLMNKDE, HNHFFBALMII>);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x1C0C180", Offset = "0x1C0A980", VA = "0x181C0C180")]
	[CompilerGenerated]
	private IJKPNMCDKCD EPOIKBCJKHP(DHHCBGJBCFH DKLECPOCCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x1C0D030", Offset = "0x1C0B830", VA = "0x181C0D030")]
	[CompilerGenerated]
	private HBAGMPEDPLJ LCLJNOMKBEK(OKMFLAIJCBC<IKFKOGPAMKO> DKLECPOCCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x1C0C640", Offset = "0x1C0AE40", VA = "0x181C0C640")]
	[CompilerGenerated]
	private FIDJKEIGAGK HHFJGEJKMLL(OKMFLAIJCBC<PEKCPKJHMHE> DKLECPOCCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class IJKPNMCDKCD : INDBJHJMBMA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct JFNLEGOECPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<CJFFNAOEMIF<NDGNKDNEMLN>, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public IJKPNMCDKCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public OKMFLAIJCBC<PEKCPKJHMHE> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public OKMFLAIJCBC<IKFKOGPAMKO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public CJFFNAOEMIF<FFBJLJKKEOB> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter<EOPMGLNDIOA<CJFFNAOEMIF<NDGNKDNEMLN>, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x1C268B0", Offset = "0x1C250B0", VA = "0x181C268B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1C26B30", Offset = "0x1C25330", VA = "0x181C26B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private struct KKJMMFGANGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<CJFFNAOEMIF<BEGPJCNMDJN>, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public IJKPNMCDKCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public OKMFLAIJCBC<PEKCPKJHMHE> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public OKMFLAIJCBC<IKFKOGPAMKO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public CJFFNAOEMIF<FFBJLJKKEOB> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private TaskAwaiter<EOPMGLNDIOA<CJFFNAOEMIF<BEGPJCNMDJN>, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x1C26BC0", Offset = "0x1C253C0", VA = "0x181C26BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1C26E40", Offset = "0x1C25640", VA = "0x181C26E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly DHHCBGJBCFH KDLOPBADBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly AHEJKJNNJIC KOLLFPODLJE;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public string KDDDOFENJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1C267E0", Offset = "0x1C24FE0", VA = "0x181C267E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x1C26810", Offset = "0x1C25010", VA = "0x181C26810")]
	public IJKPNMCDKCD(DHHCBGJBCFH LOHKDKFEJKG, AHEJKJNNJIC FNGCMEJBGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x1C26500", Offset = "0x1C24D00", VA = "0x181C26500", Slot = "5")]
	[AsyncStateMachine(typeof(JFNLEGOECPD))]
	public Task<EOPMGLNDIOA<CJFFNAOEMIF<NDGNKDNEMLN>, NHKNMEADEEO>> ADEPNOCLNFB(OKMFLAIJCBC<PEKCPKJHMHE> HGPLGELHGLG, OKMFLAIJCBC<IKFKOGPAMKO> AACPINCHENM, CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF, string HNHMJGCODBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1C26670", Offset = "0x1C24E70", VA = "0x181C26670", Slot = "6")]
	[AsyncStateMachine(typeof(KKJMMFGANGB))]
	public Task<EOPMGLNDIOA<CJFFNAOEMIF<BEGPJCNMDJN>, NHKNMEADEEO>> FMMOENFHEDO(OKMFLAIJCBC<PEKCPKJHMHE> HGPLGELHGLG, OKMFLAIJCBC<IKFKOGPAMKO> AACPINCHENM, CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF, string HNHMJGCODBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public sealed class OBCKDAMLIDB : BPGFPAAJOEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly DHHCBGJBCFH IHHNBBMCFIJ;

	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private static readonly HashSet<DHHCBGJBCFH> NFNIDOKMMMJ;

	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static readonly HashSet<DHHCBGJBCFH> BEHMFKNODLL;

	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private static readonly HashSet<DHHCBGJBCFH> JBJJBPBFOOB;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public TypeKey LKLFDONKJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x1C28EE0", Offset = "0x1C276E0", VA = "0x181C28EE0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool PAEGBGOPBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1C28ED0", Offset = "0x1C276D0", VA = "0x181C28ED0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool HGJFOJOGFGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x1C28F30", Offset = "0x1C27730", VA = "0x181C28F30", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool IDCKNGGKAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x1C28E50", Offset = "0x1C27650", VA = "0x181C28E50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1C27BD0", Offset = "0x1C263D0", VA = "0x181C27BD0")]
	public bool PAABAFJNNHM(string FKKGMPDEPMA, [Out] NMKGEGLAKEO INKIPFPBCKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	public OBCKDAMLIDB(DHHCBGJBCFH PCEPPDLMHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x1C27A40", Offset = "0x1C26240", VA = "0x181C27A40")]
	internal static TypeKey OFBFEPEDPPH(DHHCBGJBCFH GFGNPBCFEMC)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x1C267E0", Offset = "0x1C24FE0", VA = "0x181C267E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct DKMDBDNPKKO : OAGEFHGOAGE.FEONKILMDED<GMCGHACCLIF, JGIANJFFIJK>
{
	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1C25DD0", Offset = "0x1C245D0", VA = "0x181C25DD0", Slot = "4")]
	public int PKJNOGONKFL(JGIANJFFIJK EANKMFHELBA, GMCGHACCLIF OONIIOMBHJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1C25D90", Offset = "0x1C24590", VA = "0x181C25D90", Slot = "5")]
	public GMCGHACCLIF MFGIFMHBLPI(JGIANJFFIJK EANKMFHELBA, GMCGHACCLIF OONIIOMBHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1C25D20", Offset = "0x1C24520", VA = "0x181C25D20", Slot = "6")]
	public GMCGHACCLIF HFOENLPAEHM(JGIANJFFIJK EANKMFHELBA, GMCGHACCLIF OONIIOMBHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1C25CA0", Offset = "0x1C244A0", VA = "0x181C25CA0", Slot = "7")]
	public IReadOnlyList<GMCGHACCLIF> BAGNPMINFJB(JGIANJFFIJK EANKMFHELBA, GMCGHACCLIF OONIIOMBHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x1C25DA0", Offset = "0x1C245A0", VA = "0x181C25DA0", Slot = "8")]
	public GMCGHACCLIF[] MILHIICPBEO(JGIANJFFIJK EANKMFHELBA, GMCGHACCLIF OONIIOMBHJI, int LPFPKBOEAKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1C25CC0", Offset = "0x1C244C0", VA = "0x181C25CC0", Slot = "9")]
	public bool CIIIOFFPFJB(JGIANJFFIJK EANKMFHELBA, GMCGHACCLIF OONIIOMBHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1C25CE0", Offset = "0x1C244E0", VA = "0x181C25CE0", Slot = "10")]
	public bool EAEAANECEOD(JGIANJFFIJK EANKMFHELBA, GMCGHACCLIF OONIIOMBHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1C25DB0", Offset = "0x1C245B0", VA = "0x181C25DB0", Slot = "11")]
	public bool NJELFPNOHNE(JGIANJFFIJK EANKMFHELBA, GMCGHACCLIF OONIIOMBHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1C25D70", Offset = "0x1C24570", VA = "0x181C25D70", Slot = "12")]
	public bool KNHBOOJLMCG(JGIANJFFIJK EANKMFHELBA, GMCGHACCLIF OONIIOMBHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1C25D50", Offset = "0x1C24550", VA = "0x181C25D50", Slot = "13")]
	public bool KJCBIDNELHJ(JGIANJFFIJK MEAOIIOHJDC, GMCGHACCLIF OONIIOMBHJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1C25D00", Offset = "0x1C24500", VA = "0x181C25D00", Slot = "14")]
	public bool EICBHCOKNOE(JGIANJFFIJK EANKMFHELBA, GMCGHACCLIF OONIIOMBHJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public abstract class LADBMFOGHDO : LINLPDMNAJD
{
	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public FDPBCGEEFBG.LGFCCGOJABI JNHJMOIMAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x1C270A0", Offset = "0x1C258A0", VA = "0x181C270A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public abstract FAAPDBBLBEL.BDIIKOBHCOF EEELHIBMIME
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public abstract AANLPGCMHPA.MCCCHBFGCBB GEEFKMDCJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public abstract JBOLJFCPGHK.JJPEENJBBFG EHDEDPPMFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public DFLBEHIMOOF.GMDCOPMPIHF<KAGCBACHCOA, GMCGHACCLIF, AANLPGCMHPA> MFLJJFIMMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1C270F0", Offset = "0x1C258F0", VA = "0x181C270F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public abstract DEHANOACHCB MIFDCAOPDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public abstract IBDFCDNBPGH JDONKKMFFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public abstract FHAMKKPFCCL EDAKFEKBMAE
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public abstract HHNLAHJNOGM NIBHBLPKHFK
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public abstract CDAIJGJBAHP KBDMJFPLMGH
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	protected LADBMFOGHDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public sealed class BCEMHMPJPFI : MFOMFPFALFD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct IDPOELONDPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<object, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public BCEMHMPJPFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public GMCGHACCLIF action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private TaskAwaiter<EOPMGLNDIOA<object, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1C261F0", Offset = "0x1C249F0", VA = "0x181C261F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1C26490", Offset = "0x1C24C90", VA = "0x181C26490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct CHADBDLBCKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public AsyncTaskMethodBuilder<EOPMGLNDIOA<PCHKDILKBNI, NHKNMEADEEO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public BCEMHMPJPFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public IReadOnlyList<GMCGHACCLIF> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter<EOPMGLNDIOA<object, NHKNMEADEEO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1C25850", Offset = "0x1C24050", VA = "0x181C25850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1C25BD0", Offset = "0x1C243D0", VA = "0x181C25BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private readonly OANIKMDLOIC AGDLPINNPEF;

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x768BD0", Offset = "0x7673D0", VA = "0x180768BD0")]
	public BCEMHMPJPFI(OANIKMDLOIC FGOFNFFEGME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x1C255F0", Offset = "0x1C23DF0", VA = "0x181C255F0")]
	[AsyncStateMachine(typeof(IDPOELONDPG))]
	private Task<EOPMGLNDIOA<object, NHKNMEADEEO>> FHGPLMACHNO(GMCGHACCLIF OONIIOMBHJI, bool MBFIBHOAEDA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1C25720", Offset = "0x1C23F20", VA = "0x181C25720", Slot = "4")]
	[AsyncStateMachine(typeof(CHADBDLBCKO))]
	public Task<EOPMGLNDIOA<PCHKDILKBNI, NHKNMEADEEO>> NNIIKMGKENH(IReadOnlyList<GMCGHACCLIF> CLEMKBFECGL, bool MBFIBHOAEDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct CNIPAPLOGEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	internal PHHJBEJCNGM<MKCLGLMNAIG, GMCGHACCLIF, DMBMNGFHEMF> IHHNBBMCFIJ;

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x1C11F50", Offset = "0x1C10750", VA = "0x181C11F50")]
	private CNIPAPLOGEF([In] PHHJBEJCNGM<MKCLGLMNAIG, GMCGHACCLIF, DMBMNGFHEMF> CDOHIJGNPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x1C25C40", Offset = "0x1C24440", VA = "0x181C25C40")]
	public static CNIPAPLOGEF KKMBICLNKPK()
	{
		return default(CNIPAPLOGEF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class AMEMHMCNDBO
{
	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0")]
	public static PHHJBEJCNGM<MKCLGLMNAIG, GMCGHACCLIF, DMBMNGFHEMF> GMKIFEJCBDI(this CNIPAPLOGEF AFFJMIFONEM)
	{
		return default(PHHJBEJCNGM<MKCLGLMNAIG, GMCGHACCLIF, DMBMNGFHEMF>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct DMBMNGFHEMF : KKIDBIAFFND.EIFHKGBGGJG<MKCLGLMNAIG, GMCGHACCLIF>
{
	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x1C25DF0", Offset = "0x1C245F0", VA = "0x181C25DF0", Slot = "5")]
	public GMCGHACCLIF JPFOGFMPHDH(MKCLGLMNAIG[] KNOPIFNOHFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x1200EC0", Offset = "0x11FF6C0", VA = "0x181200EC0")]
	public int FDCIOPONKNM([In] MKCLGLMNAIG LLMJAANBHOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x1200EC0", Offset = "0x11FF6C0", VA = "0x181200EC0", Slot = "4")]
	private int BJOHBBOHHKN([In] MKCLGLMNAIG BNFDBGHADLF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct FDOANNKBHOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	internal FKLNAHCNMEL<JPJJKLKILGH, GMCGHACCLIF, KLECCLBLMJJ> IHHNBBMCFIJ;

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1C11F50", Offset = "0x1C10750", VA = "0x181C11F50")]
	private FDOANNKBHOH([In] FKLNAHCNMEL<JPJJKLKILGH, GMCGHACCLIF, KLECCLBLMJJ> JFAGPFKEFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x1C260F0", Offset = "0x1C248F0", VA = "0x181C260F0")]
	public static FDOANNKBHOH KKMBICLNKPK()
	{
		return default(FDOANNKBHOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class PBACLHHKJJH
{
	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0xA223A0", Offset = "0xA20BA0", VA = "0x180A223A0")]
	public static FKLNAHCNMEL<JPJJKLKILGH, GMCGHACCLIF, KLECCLBLMJJ> GMKIFEJCBDI(this FDOANNKBHOH AFFJMIFONEM)
	{
		return default(FKLNAHCNMEL<JPJJKLKILGH, GMCGHACCLIF, KLECCLBLMJJ>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct KLECCLBLMJJ : FDPHGNLLDNL.MDILGELDEMC<JPJJKLKILGH, GMCGHACCLIF>
{
	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x1200EC0", Offset = "0x11FF6C0", VA = "0x181200EC0")]
	public int GCPIIOIGPHE([In] JPJJKLKILGH LLMJAANBHOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x1C26EB0", Offset = "0x1C256B0", VA = "0x181C26EB0", Slot = "5")]
	public GMCGHACCLIF AJPFCPGKAHH(JPJJKLKILGH[] DPELOCLANGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x1200EC0", Offset = "0x11FF6C0", VA = "0x181200EC0", Slot = "4")]
	private int LEKMBGBAAOJ([In] JPJJKLKILGH LLMJAANBHOG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface DEHANOACHCB
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HNNLLCMKDMK([In] EOPMGLNDIOA<JGIANJFFIJK, HNHFFBALMII> KMHAEDONIKI);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class DJDFGKMEKFC
{
	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x2216210", Offset = "0x2214A10", VA = "0x182216210")]
	public static bool HNNLLCMKDMK<TOk, TErr>(this DEHANOACHCB AFFJMIFONEM, [In] EOPMGLNDIOA<TOk, TErr> KMHAEDONIKI) where TOk : notnull where TErr : notnull, HNHFFBALMII
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface IBDFCDNBPGH
{
	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	DBONKCNFGMA IKMMEPOPOLN
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface FHAMKKPFCCL
{
	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	APNJAMHPFDA CJNBEPFFOII(int DMJAABFNGIE);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface MFINEBHFKMC
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	string MBENGICGPDH
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface HIAIGJFOFHC
{
	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMEHDEJPCIC? INALAFPFEOG(CJFFNAOEMIF<FFBJLJKKEOB> BDAGPGKIGOF);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface NFHFFFFBJAI
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	string MBENGICGPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public interface OMEHDEJPCIC
{
	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	string MBENGICGPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NFHFFFFBJAI? DFEMABDOIBK(CJFFNAOEMIF<NDGNKDNEMLN> PNBJCJCOJOE);

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MFINEBHFKMC? NNPKLBPPNEN(CJFFNAOEMIF<BEGPJCNMDJN> BEDKCOKPODJ);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public interface HHNLAHJNOGM
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> JFHEJAAOMGO(string FKKGMPDEPMA, string FJNGJOFLBMD);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public interface CDAIJGJBAHP
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HIAIGJFOFHC? JFMBGIKILEH([In] OKMFLAIJCBC<CJBAFCLDANB> OPPGLGHAAMO);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public sealed class NLGFGNKLAMD
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private struct FDABAPCMLKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int NEMCGPAIDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public KGOIBMCNEGI? EMLPPBBFGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public KGOIBMCNEGI? CMIKAMJKACA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public readonly List<GMCGHACCLIF> FNNNEENGINP;

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1C260A0", Offset = "0x1C248A0", VA = "0x181C260A0")]
		private FDABAPCMLKC(int LFEFGCGCIAG, KGOIBMCNEGI? LDILEHBIPGD, KGOIBMCNEGI? JOCKGPKMJNO, List<GMCGHACCLIF> CLEMKBFECGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1C25FE0", Offset = "0x1C247E0", VA = "0x181C25FE0")]
		public static FDABAPCMLKC KKMBICLNKPK()
		{
			return default(FDABAPCMLKC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly GDFFIHDGPCO<FDABAPCMLKC> EGOKHBODLEK;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public static NLGFGNKLAMD FLMPJFHFLHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x1C27140", Offset = "0x1C25940", VA = "0x181C27140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool LPMHLGBAMLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B39F0", Offset = "0x7B21F0", VA = "0x1807B39F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x89BFC0", Offset = "0x89A7C0", VA = "0x18089BFC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x1C27490", Offset = "0x1C25C90", VA = "0x181C27490")]
	public void OMPBCJJKFIE(GMCALCOKFAM JOCKGPKMJNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x1C27190", Offset = "0x1C25990", VA = "0x181C27190")]
	public void NPMLICMOOEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x1C27550", Offset = "0x1C25D50", VA = "0x181C27550")]
	private static string? OOIIOOGGGPC([In] FDABAPCMLKC HOKHMLLLACJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x1C27990", Offset = "0x1C26190", VA = "0x181C27990")]
	public NLGFGNKLAMD()
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
