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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x24FA4B0", Offset = "0x24F92B0", VA = "0x1824FA4B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class CCBLBBOJEHP : IDisposable, MIJCMCIKHMG, HJCEHBPJLFL, BNBAAEIOAJM, JDCNMNEPKKG
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class NJCEDGEJMFH : OPDNBOHNCDO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int OCIICFMDHEP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x24F81B0", Offset = "0x24F6FB0", VA = "0x1824F81B0", Slot = "5")]
		public AOGOAJLDLHM HBKBNBKJDPI(KGPBDMEACIL.FGCLOGGHAKL FLOGLGIGMAI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void KIOGPALONNO();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void DANHBBIKDJJ();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x24F8170", Offset = "0x24F6F70", VA = "0x1824F8170", Slot = "13")]
		public virtual void CPGMEHOFLKP(CCBLBBOJEHP PJMKKGHIHNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x24F8300", Offset = "0x24F7100", VA = "0x1824F8300", Slot = "14")]
		public virtual void IPJDEFPNIHK(CCBLBBOJEHP PJMKKGHIHNK, EAAKFALPLDL OOCJAOHFGJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		protected NJCEDGEJMFH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface OPDNBOHNCDO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int OCIICFMDHEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		AOGOAJLDLHM HBKBNBKJDPI(KGPBDMEACIL.FGCLOGGHAKL FLOGLGIGMAI);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KIOGPALONNO();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DANHBBIKDJJ();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CPGMEHOFLKP(CCBLBBOJEHP PJMKKGHIHNK);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void IPJDEFPNIHK(CCBLBBOJEHP PJMKKGHIHNK, EAAKFALPLDL OOCJAOHFGJK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct BMKBFALDLGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly DLKEMAONFHP<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP, LNLOKMHCLCK.MPDIIICCGGC<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP>> ONFPGHDPKKM;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x24E0CD0", Offset = "0x24DFAD0", VA = "0x1824E0CD0")]
		internal BMKBFALDLGL(DLKEMAONFHP<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP, LNLOKMHCLCK.MPDIIICCGGC<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP>> MNCBDJMAFIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class LFGNFDOFCII : LNLOKMHCLCK.MPDIIICCGGC<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly LFGNFDOFCII GGJCMHODIEM;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		private LFGNFDOFCII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x973720", Offset = "0x972520", VA = "0x180973720", Slot = "4")]
		public DJBJCCKDIDJ HNCPEJNFDBN(EAAKFALPLDL DJAJDIFOIHP)
		{
			return default(DJBJCCKDIDJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x24F65B0", Offset = "0x24F53B0", VA = "0x1824F65B0", Slot = "5")]
		public void CPGMEHOFLKP(CCBLBBOJEHP DOJENPPADJD, EAAKFALPLDL OOCJAOHFGJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x24F66B0", Offset = "0x24F54B0", VA = "0x1824F66B0", Slot = "6")]
		public void IPJDEFPNIHK(CCBLBBOJEHP DOJENPPADJD, EAAKFALPLDL OOCJAOHFGJK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct ALKJEKGHBCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public KDAFJECKBGP<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP, LNLOKMHCLCK.MPDIIICCGGC<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP>> ONFPGHDPKKM;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x24E0CC0", Offset = "0x24DFAC0", VA = "0x1824E0CC0")]
		internal ALKJEKGHBCN(KDAFJECKBGP<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP, LNLOKMHCLCK.MPDIIICCGGC<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP>> MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x24E0C70", Offset = "0x24DFA70", VA = "0x1824E0C70")]
		public static ALKJEKGHBCN MKHEJJEDOII()
		{
			return default(ALKJEKGHBCN);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct FKFOCGGBIHC : PKBKOICGLPG.HCFGEHFHCHL<EAAKFALPLDL, CCBLBBOJEHP>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct PIPFMOHHJPI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<PGOLMGNGGBM<object?, HJBBDBHAMJJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public CCBLBBOJEHP receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public EAAKFALPLDL action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public FKFOCGGBIHC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<PGOLMGNGGBM<object?, HJBBDBHAMJJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x24FD670", Offset = "0x24FC470", VA = "0x1824FD670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x24FD850", Offset = "0x24FC650", VA = "0x1824FD850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xD574A0", Offset = "0xD562A0", VA = "0x180D574A0", Slot = "4")]
		public MMBOLDIBAHF<DLLCOFBGKPH> GBJBJFFDJPF(CCBLBBOJEHP MGPKLMAHHGI)
		{
			return default(MMBOLDIBAHF<DLLCOFBGKPH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x24F0900", Offset = "0x24EF700", VA = "0x1824F0900", Slot = "5")]
		public void OPOCFLDMAIC(CCBLBBOJEHP MGPKLMAHHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x24F07D0", Offset = "0x24EF5D0", VA = "0x1824F07D0", Slot = "6")]
		[AsyncStateMachine(typeof(PIPFMOHHJPI))]
		public Task<PGOLMGNGGBM<object, HJBBDBHAMJJ>> ONPJOOFLLCF(CCBLBBOJEHP MGPKLMAHHGI, EAAKFALPLDL OOCJAOHFGJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x24F07B0", Offset = "0x24EF5B0", VA = "0x1824F07B0", Slot = "7")]
		public EAAKFALPLDL[] AFMMAIKNACH(CCBLBBOJEHP MGPKLMAHHGI)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LLNGFDLICGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<bool, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public CCBLBBOJEHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<PGOLMGNGGBM<bool, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x24F6CE0", Offset = "0x24F5AE0", VA = "0x1824F6CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x24F6F70", Offset = "0x24F5D70", VA = "0x1824F6F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct JFADNNAHHCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CCBLBBOJEHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x24F2B90", Offset = "0x24F1990", VA = "0x1824F2B90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x24F2D70", Offset = "0x24F1B70", VA = "0x1824F2D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct AFIPCEKDKDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<object?, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public CCBLBBOJEHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public EAAKFALPLDL action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<PGOLMGNGGBM<object?, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x24E07B0", Offset = "0x24DF5B0", VA = "0x1824E07B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x24E09A0", Offset = "0x24DF7A0", VA = "0x1824E09A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly MMBOLDIBAHF<DLLCOFBGKPH> BEMOHMALIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BMKBFALDLGL KEMHOKJALJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NMKOMBKFKAF NELCMJLMAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly NMELJFKGGEI JLJFGOKKCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AE8")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly HLAHDHHBGFE PGBNHHHODKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AF0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly AJACNMDPIMM.NMDKDGDLPFG DCLDJCBDJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly IKNHEIGEGAH KJHFEPGKMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly NEOKGIHHAEB DNLFDFMJFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly EPEOBGHDJLI DANGAMNDDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly HNIFIHHDBKI EMBCCJKCNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private KHBNPODOKIC KJPLAKAJKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private MAKEDNLEGEP JBJLIEKOOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B60")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly NMKOMBKFKAF.PIBPOFBHCAN MMIALPCDLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B68")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly GIGFCJMGLDN HFHNJEFOCII;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NMKOMBKFKAF POCCABILMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x24E1990", Offset = "0x24E0790", VA = "0x1824E1990")]
		get
		{
			return default(NMKOMBKFKAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal OPDNBOHNCDO LFHMDECBMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24E2560", Offset = "0x24E1360", VA = "0x1824E2560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal AOGOAJLDLHM LLJKLCOBIAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24E2C90", Offset = "0x24E1A90", VA = "0x1824E2C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x24E1D30", Offset = "0x24E0B30", VA = "0x1824E1D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool NHEFDJGMJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x24E2150", Offset = "0x24E0F50", VA = "0x1824E2150")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x24E1D50", Offset = "0x24E0B50", VA = "0x1824E1D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AKANMCEDHNB JGKLLPNKCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x24E3060", Offset = "0x24E1E60", VA = "0x1824E3060", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public OBDFILPKANB DPCFHJELEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x24E3070", Offset = "0x24E1E70", VA = "0x1824E3070", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CMBCLPOIFNM LECJNAHKJNM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x24E3090", Offset = "0x24E1E90", VA = "0x1824E3090", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GACEKJGMDDH GHLBAPCCBIF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x24E3080", Offset = "0x24E1E80", VA = "0x1824E3080", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public AJACNMDPIMM? CGDFOFGCFKK
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x24E2160", Offset = "0x24E0F60", VA = "0x1824E2160", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private EAIFHJMEAJD? KABEHMENEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x24E2740", Offset = "0x24E1540", VA = "0x1824E2740", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24E2D60", Offset = "0x24E1B60", VA = "0x1824E2D60")]
	private CCBLBBOJEHP(HLAHDHHBGFE ONBPKFMECNJ, MMBOLDIBAHF<DLLCOFBGKPH> JOGIDIAAHEC, [In] BMKBFALDLGL FBDLHMNPHDJ, [In] NMKOMBKFKAF GOFKOIDBLOE, [In] NMELJFKGGEI MBEINLJLBOC, AOGOAJLDLHM BPIBHFOAGBN, [In] AJACNMDPIMM.NMDKDGDLPFG BGIKOEKINLF, NMKOMBKFKAF.PIBPOFBHCAN KCPMGEDDAAI, GIGFCJMGLDN GIOHPADIAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x24E2B50", Offset = "0x24E1950", VA = "0x1824E2B50")]
	public static CCBLBBOJEHP MKHEJJEDOII(HLAHDHHBGFE FLOGLGIGMAI, [In] HPONJMBNNGI PABBCMOFCDG, LHDOMKCBLHM JHBICLIFKHG, [In] LGNNCEHAKHG PHJDKFEKDJP, NICNJEGNGHO IDFFHCABMKA, MMBOLDIBAHF<DLLCOFBGKPH> JOGIDIAAHEC, MMBOLDIBAHF<KPDGAFHNOBJ> HAAPCAFLFOG, FMLCFIPPIMP POAJLCGJBBJ, AHNHOJAOKFM JIIEPDFAMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x24E2870", Offset = "0x24E1670", VA = "0x1824E2870")]
	public static CCBLBBOJEHP MKHEJJEDOII(HLAHDHHBGFE ONBPKFMECNJ, [In] NMKOMBKFKAF GOFKOIDBLOE, [In] NMELJFKGGEI MBEINLJLBOC, MMBOLDIBAHF<DLLCOFBGKPH> JOGIDIAAHEC, MMBOLDIBAHF<KPDGAFHNOBJ> HAAPCAFLFOG, FMLCFIPPIMP POAJLCGJBBJ, AHNHOJAOKFM JIIEPDFAMMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x24E1F60", Offset = "0x24E0D60", VA = "0x1824E1F60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x24E2470", Offset = "0x24E1270", VA = "0x1824E2470")]
	[AsyncStateMachine(typeof(LLNGFDLICGK))]
	public Task<PGOLMGNGGBM<bool, HJBBDBHAMJJ>> IEEBJLIIGHG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x24E1E70", Offset = "0x24E0C70", VA = "0x1824E1E70")]
	[AsyncStateMachine(typeof(JFADNNAHHCN))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> DLPGILCOFCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x24E2260", Offset = "0x24E1060", VA = "0x1824E2260")]
	internal void IAKJBCFDNKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x24E21E0", Offset = "0x24E0FE0", VA = "0x1824E21E0")]
	internal HHLFAFFGDEG<EAAKFALPLDL> HIJJJBCLIEG([In] FBAIGOIMJFO MBLIEFPKFPI)
	{
		return default(HHLFAFFGDEG<EAAKFALPLDL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x24E2CA0", Offset = "0x24E1AA0", VA = "0x1824E2CA0")]
	internal bool OIAHJGIFPAG([In] FBAIGOIMJFO MBLIEFPKFPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x24E25B0", Offset = "0x24E13B0", VA = "0x1824E25B0")]
	internal PGOLMGNGGBM<EAAKFALPLDL, HJBBDBHAMJJ> KLHFAHHPFHH([In] PDKBDCEAHIH LCDNNJFKILM)
	{
		return default(PGOLMGNGGBM<EAAKFALPLDL, HJBBDBHAMJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x24E2D10", Offset = "0x24E1B10", VA = "0x1824E2D10")]
	private void OPOCFLDMAIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x24E1D60", Offset = "0x24E0B60", VA = "0x1824E1D60")]
	[AsyncStateMachine(typeof(AFIPCEKDKDM))]
	internal Task<PGOLMGNGGBM<object, HJBBDBHAMJJ>> DJKNGMFIGNE(EAAKFALPLDL OOCJAOHFGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x24E19A0", Offset = "0x24E07A0", VA = "0x1824E19A0")]
	private EAAKFALPLDL[] AFMMAIKNACH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class FEDEHAMCDDM<TData> : MFMDDJMMGHP, EAJFPACHKHP, EOABGNINGBC where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly HFJNFIGGNLC<AHIDBKDCADN>? PFGGMFLJMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string FLOGHFAIHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly TData COGAKILOFHK;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public HFJNFIGGNLC<AHIDBKDCADN>? EBGHINMCPAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2746160", Offset = "0x2744F60", VA = "0x182746160", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8F4330", Offset = "0x8F3130", VA = "0x1808F4330", Slot = "7")]
	public override string KMIKCFPGPHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4390F80", Offset = "0x438FD80", VA = "0x184390F80")]
	internal FEDEHAMCDDM([In] HFJNFIGGNLC<AHIDBKDCADN>? FPPOHACGMAB, MMBOLDIBAHF<PCJFIJFJEGH>? GAGBBENOEGA, IOKind? FGJNFNAGHIJ, string KKBJAPCBOHH, [In] TData JOAPLPPIFPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LIOOMGJKCMC
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x24F6840", Offset = "0x24F5640", VA = "0x1824F6840")]
	public static PGOLMGNGGBM<JCEBMCPIPFP, EAJFPACHKHP> KHOANHPGGPA([In] this GIIGFBHBFIL<GNLHODEGMBA> LGKOEBIPJIG)
	{
		return default(PGOLMGNGGBM<JCEBMCPIPFP, EAJFPACHKHP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x33AB0A0", Offset = "0x33A9EA0", VA = "0x1833AB0A0")]
	public static PGOLMGNGGBM<TOk, EAJFPACHKHP> KMAGJCELPAG<TOk>([In] this PGOLMGNGGBM<TOk, EAJFPACHKHP> DJAJDIFOIHP, [In] HFJNFIGGNLC<AHIDBKDCADN>? FPPOHACGMAB, MMBOLDIBAHF<PCJFIJFJEGH>? GAGBBENOEGA, IOKind? FGJNFNAGHIJ, string KKBJAPCBOHH) where TOk : notnull
	{
		return default(PGOLMGNGGBM<TOk, EAJFPACHKHP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HLAHDHHBGFE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	EEHDKMFBCJI.IMGOLDIPFAM IHIDHCMLAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	KGPBDMEACIL.FGCLOGGHAKL FOAFMFCHBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	CCBLBBOJEHP.OPDNBOHNCDO HNAGHFBGLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	HJKKBPDPHBE.GAFJEOJBDBK MGIHOOBMOPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	LNLOKMHCLCK.MPDIIICCGGC<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP> KAHHCNGOBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MDDBEOAOGLK CLDLBFJIHDC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GJPFNNNDHPI DBCFOAPAOBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	CEBIGFNNOKO ANEHNLPAJDC
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	KBIOFEKHPDF BLLMJCLKOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	DKMNPKCKKKI MFJLNOKBMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OOFGEPEMJIN
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x24FC7F0", Offset = "0x24FB5F0", VA = "0x1824FC7F0")]
	public static EAAKFALPLDL HDOLDPJNLOP(this EAAKFALPLDL DJAJDIFOIHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x24FC900", Offset = "0x24FB700", VA = "0x1824FC900")]
	public static EAAKFALPLDL PMECONPJMHG(this OCBCNHGEOLC DJAJDIFOIHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct OCBCNHGEOLC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct GABILCOGLGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<object?, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public CCBLBBOJEHP root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public OCBCNHGEOLC self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<PGOLMGNGGBM<object?, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x24F0B20", Offset = "0x24EF920", VA = "0x1824F0B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x24F0DE0", Offset = "0x24EFBE0", VA = "0x1824F0DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly ByteString HKHKCHJEPKB;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
	private OCBCNHGEOLC(ByteString IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x24FA6F0", Offset = "0x24F94F0", VA = "0x1824FA6F0")]
	public static EAAKFALPLDL LCDNOCMHFAE(ByteString IPHILEOFJLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x24FA640", Offset = "0x24F9440", VA = "0x1824FA640")]
	public static KAIBPOAMLHJ<DJBJCCKDIDJ, OCBCNHGEOLC> HPLGAAADBPI(EAAKFALPLDL LDGMFCODCED)
	{
		return default(KAIBPOAMLHJ<DJBJCCKDIDJ, OCBCNHGEOLC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x24FA530", Offset = "0x24F9330", VA = "0x1824FA530")]
	[AsyncStateMachine(typeof(GABILCOGLGM))]
	public static Task<PGOLMGNGGBM<object, HJBBDBHAMJJ>> DJKNGMFIGNE(CCBLBBOJEHP DOJENPPADJD, OCBCNHGEOLC DJAJDIFOIHP)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct HCMANCEBNPI
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x24F19F0", Offset = "0x24F07F0", VA = "0x1824F19F0")]
	public static EAAKFALPLDL LCDNOCMHFAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x24F1900", Offset = "0x24F0700", VA = "0x1824F1900")]
	public static KAIBPOAMLHJ<DJBJCCKDIDJ, HCMANCEBNPI> HPLGAAADBPI(EAAKFALPLDL LDGMFCODCED)
	{
		return default(KAIBPOAMLHJ<DJBJCCKDIDJ, HCMANCEBNPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x24F1970", Offset = "0x24F0770", VA = "0x1824F1970")]
	public static PGOLMGNGGBM<ENLEGHEGALI, NPDJLDEDKNL> JJFFEGPDIDD(CCBLBBOJEHP DOJENPPADJD, [In] HCMANCEBNPI DJAJDIFOIHP)
	{
		return default(PGOLMGNGGBM<ENLEGHEGALI, NPDJLDEDKNL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct HJKIPOEFCAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct GJDOEEBOKPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, NPDJLDEDKNL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public CCBLBBOJEHP root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public HJKIPOEFCAH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private PGOLMGNGGBM<ENLEGHEGALI, NPDJLDEDKNL> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x24F1160", Offset = "0x24EFF60", VA = "0x1824F1160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x24F14D0", Offset = "0x24F02D0", VA = "0x1824F14D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly HKNIKLFPMCJ? EBFMDBIEJOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly BGMBPJPBIDA? FCNMPPBFBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly OLIDAEPNBCP? IPFNEKHOLLF;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2419D20", Offset = "0x2418B20", VA = "0x182419D20")]
	private HJKIPOEFCAH(HKNIKLFPMCJ? PFEGEFINGEH, BGMBPJPBIDA? BHCDFOMKNBA, OLIDAEPNBCP? PDNPLFLMEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x24F1CE0", Offset = "0x24F0AE0", VA = "0x1824F1CE0")]
	public static EAAKFALPLDL? LCDNOCMHFAE(HKNIKLFPMCJ? PFEGEFINGEH, BGMBPJPBIDA? BHCDFOMKNBA, OLIDAEPNBCP? PDNPLFLMEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x24F1BD0", Offset = "0x24F09D0", VA = "0x1824F1BD0")]
	public static KAIBPOAMLHJ<DJBJCCKDIDJ, HJKIPOEFCAH> HPLGAAADBPI(EAAKFALPLDL LDGMFCODCED)
	{
		return default(KAIBPOAMLHJ<DJBJCCKDIDJ, HJKIPOEFCAH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x24F1A90", Offset = "0x24F0890", VA = "0x1824F1A90")]
	[AsyncStateMachine(typeof(GJDOEEBOKPN))]
	public static Task<PGOLMGNGGBM<ENLEGHEGALI, NPDJLDEDKNL>> DJKNGMFIGNE(CCBLBBOJEHP DOJENPPADJD, HJKIPOEFCAH DJAJDIFOIHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct PFGLCBOEHBI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct OKHCGMEMIHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<PHFHNLJGMNL, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public PFGLCBOEHBI self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public CCBLBBOJEHP root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private PGOLMGNGGBM<PHFHNLJGMNL, HJBBDBHAMJJ> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private PGOLMGNGGBM<object?, EOABGNINGBC>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private PGOLMGNGGBM<object?, EOABGNINGBC> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private PGOLMGNGGBM<object?, EOABGNINGBC>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter<PGOLMGNGGBM<object?, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x24FC0B0", Offset = "0x24FAEB0", VA = "0x1824FC0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x24FC510", Offset = "0x24FB310", VA = "0x1824FC510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly IReadOnlyList<EAAKFALPLDL> GPFOJKOEGAE;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
	private PFGLCBOEHBI(IReadOnlyList<EAAKFALPLDL> KIJMGDBLMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x24FD5B0", Offset = "0x24FC3B0", VA = "0x1824FD5B0")]
	public static EAAKFALPLDL LCDNOCMHFAE(IReadOnlyList<EAAKFALPLDL> KIJMGDBLMOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x24FD510", Offset = "0x24FC310", VA = "0x1824FD510")]
	public static KAIBPOAMLHJ<DJBJCCKDIDJ, PFGLCBOEHBI> HPLGAAADBPI(EAAKFALPLDL LDGMFCODCED)
	{
		return default(KAIBPOAMLHJ<DJBJCCKDIDJ, PFGLCBOEHBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x24FD3D0", Offset = "0x24FC1D0", VA = "0x1824FD3D0")]
	[AsyncStateMachine(typeof(OKHCGMEMIHJ))]
	public static Task<PGOLMGNGGBM<PHFHNLJGMNL, HJBBDBHAMJJ>> DJKNGMFIGNE(CCBLBBOJEHP DOJENPPADJD, PFGLCBOEHBI DJAJDIFOIHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct PDKBDCEAHIH
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class EEPHOEHCIOP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class MJNAABKACLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public HFJNFIGGNLC<EEPHOEHCIOP> actionId;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MJNAABKACLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x24F75D0", Offset = "0x24F63D0", VA = "0x1824F75D0")]
		internal EAAKFALPLDL KPANPEMJLJP(int count, int index, [In] ReadOnlySpan<byte> span)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly HFJNFIGGNLC<EEPHOEHCIOP> FBJFJFENMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly int IPKHGMJKDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly int OFCLDJHOLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly byte[] COGAKILOFHK;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x24FD3B0", Offset = "0x24FC1B0", VA = "0x1824FD3B0")]
	private PDKBDCEAHIH(HFJNFIGGNLC<EEPHOEHCIOP> AKDONJNHGLK, int BMGBDLLODJK, int KNCPCNBMDNF, byte[] JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x24FD2A0", Offset = "0x24FC0A0", VA = "0x1824FD2A0")]
	public static EAAKFALPLDL LCDNOCMHFAE(HFJNFIGGNLC<EEPHOEHCIOP> AKDONJNHGLK, int BMGBDLLODJK, int KNCPCNBMDNF, ByteString JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x24FCEA0", Offset = "0x24FBCA0", VA = "0x1824FCEA0")]
	public static EAAKFALPLDL[] ANPJJIPANPN(EAAKFALPLDL OOCJAOHFGJK, int BJNLOMPCAOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x24FCFB0", Offset = "0x24FBDB0", VA = "0x1824FCFB0")]
	public static KAIBPOAMLHJ<DJBJCCKDIDJ, PDKBDCEAHIH> HPLGAAADBPI(EAAKFALPLDL LDGMFCODCED)
	{
		return default(KAIBPOAMLHJ<DJBJCCKDIDJ, PDKBDCEAHIH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x24FD100", Offset = "0x24FBF00", VA = "0x1824FD100")]
	public static PGOLMGNGGBM<EAAKFALPLDL, HJBBDBHAMJJ> JJFFEGPDIDD(CCBLBBOJEHP DOJENPPADJD, [In] PDKBDCEAHIH DJAJDIFOIHP)
	{
		return default(PGOLMGNGGBM<EAAKFALPLDL, HJBBDBHAMJJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct FBAIGOIMJFO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct HMAMGLMFFDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<bool, NPDJLDEDKNL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CCBLBBOJEHP root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public FBAIGOIMJFO self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private PGOLMGNGGBM<bool, NPDJLDEDKNL> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, NPDJLDEDKNL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x24F1DE0", Offset = "0x24F0BE0", VA = "0x1824F1DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x24F2420", Offset = "0x24F1220", VA = "0x1824F2420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly int IPKHGMJKDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly int OFCLDJHOLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly byte[] COGAKILOFHK;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xAFF940", Offset = "0xAFE740", VA = "0x180AFF940")]
	private FBAIGOIMJFO(int BMGBDLLODJK, int KNCPCNBMDNF, byte[] JOAPLPPIFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x24F04D0", Offset = "0x24EF2D0", VA = "0x1824F04D0")]
	public static EAAKFALPLDL LCDNOCMHFAE(int BMGBDLLODJK, int KNCPCNBMDNF, ByteString JOAPLPPIFPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x24F05B0", Offset = "0x24EF3B0", VA = "0x1824F05B0")]
	public static EAAKFALPLDL?[]? OGOPEPOGGHO(int BJNLOMPCAOE, HKNIKLFPMCJ? PFEGEFINGEH, BGMBPJPBIDA? BHCDFOMKNBA, OLIDAEPNBCP? PDNPLFLMEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x24F03F0", Offset = "0x24EF1F0", VA = "0x1824F03F0")]
	public static KAIBPOAMLHJ<DJBJCCKDIDJ, FBAIGOIMJFO> HPLGAAADBPI(EAAKFALPLDL LDGMFCODCED)
	{
		return default(KAIBPOAMLHJ<DJBJCCKDIDJ, FBAIGOIMJFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x24F02C0", Offset = "0x24EF0C0", VA = "0x1824F02C0")]
	[AsyncStateMachine(typeof(HMAMGLMFFDM))]
	public static Task<PGOLMGNGGBM<bool, NPDJLDEDKNL>> DJKNGMFIGNE(CCBLBBOJEHP DOJENPPADJD, FBAIGOIMJFO DJAJDIFOIHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class IKNHEIGEGAH : AKANMCEDHNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly CCBLBBOJEHP APNMNKMKKDP;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public BEPICMBHIFF? GGJCMHODIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x24F2850", Offset = "0x24F1650", VA = "0x1824F2850", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	internal IKNHEIGEGAH(CCBLBBOJEHP PJMKKGHIHNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class CDLEIPIONCH : BEPICMBHIFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly CCBLBBOJEHP APNMNKMKKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly JKEDJAFHKDJ KCHEJHIEEOH;

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x904660", Offset = "0x903460", VA = "0x180904660")]
	public CDLEIPIONCH(CCBLBBOJEHP PJMKKGHIHNK, JKEDJAFHKDJ LNODLNHJPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x24E30A0", Offset = "0x24E1EA0", VA = "0x1824E30A0", Slot = "4")]
	public PGOLMGNGGBM<JCEBMCPIPFP, EAJFPACHKHP> EBNKCNMPPOD(HFJNFIGGNLC<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, MMBOLDIBAHF<IPGMDHDLEMN> MJCHCKFLJCD)
	{
		return default(PGOLMGNGGBM<JCEBMCPIPFP, EAJFPACHKHP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x24E3380", Offset = "0x24E2180", VA = "0x1824E3380", Slot = "5")]
	public PGOLMGNGGBM<JCEBMCPIPFP, EAJFPACHKHP> KELFBFMLKJP(HFJNFIGGNLC<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, MMBOLDIBAHF<CJABLIIDPAG> KIIIMMIFGEE)
	{
		return default(PGOLMGNGGBM<JCEBMCPIPFP, EAJFPACHKHP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class EEHDKMFBCJI : OHPAFJMFHDD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface IMGOLDIPFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<JKEDJAFHKDJ> BOLLFCJOEFG(CCBLBBOJEHP PJMKKGHIHNK, BGMBPJPBIDA? APCKKLPFEEC, OLIDAEPNBCP? FPGKIMDEMDF, CancellationToken FEHCANHDGHE);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		GGNMIHFJFJM AABLDJICLPC(CCBLBBOJEHP PJMKKGHIHNK, HKNIKLFPMCJ BMAAJHJABDD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class DCFNPOAPGMI : IMGOLDIPFAM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct JCGMBIFEKAE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public AsyncTaskMethodBuilder<JKEDJAFHKDJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public CCBLBBOJEHP circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public BGMBPJPBIDA cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public OLIDAEPNBCP cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private TaskAwaiter<HJKKBPDPHBE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x24F2950", Offset = "0x24F1750", VA = "0x1824F2950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x24F2B20", Offset = "0x24F1920", VA = "0x1824F2B20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly DCFNPOAPGMI GGJCMHODIEM;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		private DCFNPOAPGMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x24E3FA0", Offset = "0x24E2DA0", VA = "0x1824E3FA0", Slot = "4")]
		[AsyncStateMachine(typeof(JCGMBIFEKAE))]
		public Task<JKEDJAFHKDJ> BOLLFCJOEFG(CCBLBBOJEHP PJMKKGHIHNK, BGMBPJPBIDA? APCKKLPFEEC, OLIDAEPNBCP? FPGKIMDEMDF, CancellationToken FEHCANHDGHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x24E3F80", Offset = "0x24E2D80", VA = "0x1824E3F80", Slot = "5")]
		public GGNMIHFJFJM AABLDJICLPC(CCBLBBOJEHP PJMKKGHIHNK, HKNIKLFPMCJ BMAAJHJABDD)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct MPJGGPIDPFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<EEHDKMFBCJI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public CCBLBBOJEHP circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public BGMBPJPBIDA cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public OLIDAEPNBCP cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public HKNIKLFPMCJ evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private IMGOLDIPFAM <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<JKEDJAFHKDJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x24F7740", Offset = "0x24F6540", VA = "0x1824F7740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x24F7C30", Offset = "0x24F6A30", VA = "0x1824F7C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly JKEDJAFHKDJ KCHEJHIEEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly GGNMIHFJFJM BPDMHIBGLPP;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public AJACNMDPIMM CGDFOFGCFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x24F0100", Offset = "0x24EEF00", VA = "0x1824F0100", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public EAIFHJMEAJD OGKLNPPGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x24EFFE0", Offset = "0x24EEDE0", VA = "0x1824EFFE0", Slot = "5")]
		get
		{
			return default(EAIFHJMEAJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public CDLEIPIONCH IGNELGFMAEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public DFBLLIONEGD NGAKKNODBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xDCC560", Offset = "0xDCB360", VA = "0x180DCC560")]
	private EEHDKMFBCJI(JKEDJAFHKDJ LNODLNHJPOD, GGNMIHFJFJM GIAJKFDKLNL, CDLEIPIONCH GPDMHBABFLG, DFBLLIONEGD BDGJNHAHACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x24F0150", Offset = "0x24EEF50", VA = "0x1824F0150")]
	[AsyncStateMachine(typeof(MPJGGPIDPFC))]
	public static Task<EEHDKMFBCJI> KEJGOGGBELF(CCBLBBOJEHP PJMKKGHIHNK, HKNIKLFPMCJ BMAAJHJABDD, BGMBPJPBIDA? APCKKLPFEEC, OLIDAEPNBCP? FPGKIMDEMDF, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x24F00A0", Offset = "0x24EEEA0", VA = "0x1824F00A0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class KGPBDMEACIL : AOGOAJLDLHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface FGCLOGGHAKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<OHPAFJMFHDD> IDNCOLLHMFD(CCBLBBOJEHP PJMKKGHIHNK, HKNIKLFPMCJ BMAAJHJABDD, BGMBPJPBIDA? APCKKLPFEEC, OLIDAEPNBCP? FPGKIMDEMDF, CancellationToken FEHCANHDGHE);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EIFNEKDDJPA();

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PCJHCOGAOBM();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class DBAKAJGGCEK : FGCLOGGHAKL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct DJPFNLIEPJP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public AsyncTaskMethodBuilder<OHPAFJMFHDD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public CCBLBBOJEHP circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public HKNIKLFPMCJ evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public BGMBPJPBIDA cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public OLIDAEPNBCP cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private TaskAwaiter<EEHDKMFBCJI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x24E4800", Offset = "0x24E3600", VA = "0x1824E4800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x24E4B40", Offset = "0x24E3940", VA = "0x1824E4B40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x24E3E20", Offset = "0x24E2C20", VA = "0x1824E3E20", Slot = "4")]
		[AsyncStateMachine(typeof(DJPFNLIEPJP))]
		public Task<OHPAFJMFHDD> IDNCOLLHMFD(CCBLBBOJEHP PJMKKGHIHNK, HKNIKLFPMCJ BMAAJHJABDD, BGMBPJPBIDA? APCKKLPFEEC, OLIDAEPNBCP? FPGKIMDEMDF, CancellationToken FEHCANHDGHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void EIFNEKDDJPA();

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void PCJHCOGAOBM();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		protected DBAKAJGGCEK()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct OLHOKPFCCGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder<OHPAFJMFHDD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public KGPBDMEACIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private TaskAwaiter<ENLEGHEGALI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x24FC580", Offset = "0x24FB380", VA = "0x1824FC580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x24FC780", Offset = "0x24FB580", VA = "0x1824FC780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct MANBCCICJBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public KGPBDMEACIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public CCBLBBOJEHP circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public HKNIKLFPMCJ evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public BGMBPJPBIDA cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public OLIDAEPNBCP cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private TaskAwaiter<OHPAFJMFHDD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x24F6FE0", Offset = "0x24F5DE0", VA = "0x1824F6FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x24F7510", Offset = "0x24F6310", VA = "0x1824F7510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly FGCLOGGHAKL IKKBNFCGFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly TaskCompletionSource<ENLEGHEGALI> NJMNAFPMMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly TaskCompletionSource<ENLEGHEGALI> IPNAGGAFBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly CancellationTokenSource CCGBINDKGOF;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool NHEFDJGMJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x922F70", Offset = "0x921D70", VA = "0x180922F70", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x922CF0", Offset = "0x921AF0", VA = "0x180922CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FIMGNNJILII
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xC7C210", Offset = "0xC7B010", VA = "0x180C7C210", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x112AA90", Offset = "0x1129890", VA = "0x18112AA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool APAEJLHJNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x17B4C60", Offset = "0x17B3A60", VA = "0x1817B4C60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x24F3820", Offset = "0x24F2620", VA = "0x1824F3820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public OHPAFJMFHDD? EGBADIGPNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8F4480", Offset = "0x8F3280", VA = "0x1808F4480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x24F3830", Offset = "0x24F2630", VA = "0x1824F3830", Slot = "7")]
	[AsyncStateMachine(typeof(OLHOKPFCCGF))]
	public Task<OHPAFJMFHDD> KIKKCPDGOEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x24F3920", Offset = "0x24F2720", VA = "0x1824F3920")]
	public KGPBDMEACIL(FGCLOGGHAKL FLOGLGIGMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x24F3540", Offset = "0x24F2340", VA = "0x1824F3540", Slot = "8")]
	[AsyncStateMachine(typeof(MANBCCICJBI))]
	public Task BABHGOBGNEG(CCBLBBOJEHP PJMKKGHIHNK, HKNIKLFPMCJ BMAAJHJABDD, BGMBPJPBIDA? APCKKLPFEEC, OLIDAEPNBCP? FPGKIMDEMDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x24F36A0", Offset = "0x24F24A0", VA = "0x1824F36A0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class FJMDCKMNPJK : HLAMMENEKBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly DFBLLIONEGD OAOBOECLPJP;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	public FJMDCKMNPJK(DFBLLIONEGD BDGJNHAHACO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal static class IIJIJNODANK
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class IKENCKGAKDP<TGraph> : KDIJDIKDJEK where TGraph : GDJJEFHKMHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		protected readonly TGraph AMENIBNPGNE;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public virtual LCKCLOMHBDD? DMIECJBHKDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x1599BA0", Offset = "0x15989A0", VA = "0x181599BA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x46E91D0", Offset = "0x46E7FD0", VA = "0x1846E91D0", Slot = "5")]
			get
			{
				return default(MMBOLDIBAHF<CHMLMGCOLME>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public MMBOLDIBAHF<CHMLMGCOLME>? KPODNFOEHGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x46E91F0", Offset = "0x46E7FF0", VA = "0x1846E91F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
		public IKENCKGAKDP(TGraph LIPFFAIMLKE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class PPDPPAFGMOK : IKENCKGAKDP<CIEALHIHACC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override LCKCLOMHBDD? DMIECJBHKDE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x24FD8C0", Offset = "0x24FC6C0", VA = "0x1824FD8C0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x24FD8E0", Offset = "0x24FC6E0", VA = "0x1824FD8E0")]
		public PPDPPAFGMOK(CIEALHIHACC IHDKFKANDGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x24F26C0", Offset = "0x24F14C0", VA = "0x1824F26C0")]
	public static KDIJDIKDJEK MKHEJJEDOII(GDJJEFHKMHN LIPFFAIMLKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class LCMGCFILBPM : KGNFBAIEPDJ, BHENDMMDMGJ, AAFLNAOHLKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class IEFNFLNLBOA
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
			public IEFNFLNLBOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public MDDBEOAOGLK errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x24FD9B0", Offset = "0x24FC7B0", VA = "0x1824FD9B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x24FDC20", Offset = "0x24FCA20", VA = "0x1824FDC20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public LCMGCFILBPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public IEFNFLNLBOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x24F2490", Offset = "0x24F1290", VA = "0x1824F2490")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task AMEDMAOEABG(MDDBEOAOGLK errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct EAEECJLKGGF : IAsyncStateMachine
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
		public LCMGCFILBPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x24EF9B0", Offset = "0x24EE7B0", VA = "0x1824EF9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x24EFEB0", Offset = "0x24EECB0", VA = "0x1824EFEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class EBLBNMLPHPI
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
			public EBLBNMLPHPI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x24FDC80", Offset = "0x24FCA80", VA = "0x1824FDC80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x24FDF60", Offset = "0x24FCD60", VA = "0x1824FDF60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public LCMGCFILBPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public EBLBNMLPHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x24EFF10", Offset = "0x24EED10", VA = "0x1824EFF10")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task ILANNCPLLDP(MDDBEOAOGLK errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly GEBCOFGDLNO KEKFPDOHIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly ICollection<IDIGIECJIAE> HJIHDFFGNGJ;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private HLAHDHHBGFE JIDEPOKAIJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x24F5960", Offset = "0x24F4760", VA = "0x1824F5960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public MMBOLDIBAHF<IPGMDHDLEMN> IPKBOPLFBMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA76320", Offset = "0xA75120", VA = "0x180A76320", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(MMBOLDIBAHF<IPGMDHDLEMN>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xDAB0A0", Offset = "0xDA9EA0", VA = "0x180DAB0A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private MMBOLDIBAHF<KPGCHBLJMLN> MMDFEADJHPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1126B10", Offset = "0x1125910", VA = "0x181126B10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public MMBOLDIBAHF<LILDJNMHNBP> NEPENMNGHFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x91D6E0", Offset = "0x91C4E0", VA = "0x18091D6E0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(MMBOLDIBAHF<LILDJNMHNBP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public override MMBOLDIBAHF<PCJFIJFJEGH> CHNHCHMADJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x24F4450", Offset = "0x24F3250", VA = "0x1824F4450", Slot = "20")]
		get
		{
			return default(MMBOLDIBAHF<PCJFIJFJEGH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool COGOKPHFGMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x24F5F20", Offset = "0x24F4D20", VA = "0x1824F5F20", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x24F6250", Offset = "0x24F5050", VA = "0x1824F6250")]
	private LCMGCFILBPM(CCBLBBOJEHP PJMKKGHIHNK, IMCHGLPNCJE KFDHCNOCENN, GEBCOFGDLNO PBBNBPKDAMF, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, MMBOLDIBAHF<IPGMDHDLEMN> MJCHCKFLJCD, MMBOLDIBAHF<KPGCHBLJMLN> NIEPNOBACFJ, bool NMNJHMHAJDP, string PPKJBGAOBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x24F5A90", Offset = "0x24F4890", VA = "0x1824F5A90")]
	public static LCMGCFILBPM MKHEJJEDOII(CCBLBBOJEHP PJMKKGHIHNK, IMCHGLPNCJE KFDHCNOCENN, GEBCOFGDLNO HEILFBEALON, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, MMBOLDIBAHF<KPGCHBLJMLN> NIEPNOBACFJ, MMBOLDIBAHF<IPGMDHDLEMN> MJCHCKFLJCD, bool NMNJHMHAJDP, bool ELBKHDGKKCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x24F54D0", Offset = "0x24F42D0", VA = "0x1824F54D0", Slot = "21")]
	protected override void JEELJGCJJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x24F4180", Offset = "0x24F2F80", VA = "0x1824F4180", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x24F43F0", Offset = "0x24F31F0", VA = "0x1824F43F0", Slot = "30")]
	public void EJGBOHDJPAO(IDIGIECJIAE JEKEGJELBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x24F4FA0", Offset = "0x24F3DA0", VA = "0x1824F4FA0", Slot = "27")]
	public void IDHNMOKHJKM(PFGGHFNJIBB HOFNFCKJKLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x24F44A0", Offset = "0x24F32A0", VA = "0x1824F44A0", Slot = "28")]
	public void HKKPEPHODEO(LEDDOFOKGCB PDKBMLIOIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x24F42A0", Offset = "0x24F30A0", VA = "0x1824F42A0", Slot = "23")]
	protected override void EFJNFMIKNDI(IOHPNEOGGOI EMNMLJIDJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x24F4E30", Offset = "0x24F3C30", VA = "0x1824F4E30", Slot = "32")]
	public string IANKFGLCPHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x24F3EC0", Offset = "0x24F2CC0", VA = "0x1824F3EC0", Slot = "29")]
	public string DKOKBMHAMFC(int FICGKJMEBJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x24F5740", Offset = "0x24F4540", VA = "0x1824F5740")]
	private void KKDFOLJEPOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x24F3A30", Offset = "0x24F2830", VA = "0x1824F3A30", Slot = "31")]
	public void AACDKPPAIIB(IDIGIECJIAE JEKEGJELBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x24F5310", Offset = "0x24F4110", VA = "0x1824F5310")]
	private void JDCGEAFDHAA(bool IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x24F5FA0", Offset = "0x24F4DA0", VA = "0x1824F5FA0", Slot = "33")]
	[AsyncStateMachine(typeof(EAEECJLKGGF))]
	public Task PCLOAHPECJM(string IPHILEOFJLB, bool JILBLIAPLGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x24F3BD0", Offset = "0x24F29D0", VA = "0x1824F3BD0")]
	public void CPLAJKMCMAO(string IPHILEOFJLB, bool JILBLIAPLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x24F60B0", Offset = "0x24F4EB0", VA = "0x1824F60B0")]
	private void PENDNIOLBDF(int IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0xDAB0A0", Offset = "0xDA9EA0", VA = "0x180DAB0A0")]
	internal void OCOJBHAGMMC(MMBOLDIBAHF<IPGMDHDLEMN> IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x24F3BB0", Offset = "0x24F29B0", VA = "0x1824F3BB0")]
	[CompilerGenerated]
	private void AMDDOGNDAHK(string IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x24F5680", Offset = "0x24F4480", VA = "0x1824F5680")]
	[CompilerGenerated]
	private bool KHCJKDEPKDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x24F55C0", Offset = "0x24F43C0", VA = "0x1824F55C0")]
	[CompilerGenerated]
	private bool KAFNIEFGJLH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x24F5570", Offset = "0x24F4370", VA = "0x1824F5570")]
	[CompilerGenerated]
	private int LJCPEGOOIPE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x24F5E40", Offset = "0x24F4C40", VA = "0x1824F5E40")]
	[CompilerGenerated]
	private bool MPLIDBAOEGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x24F3BC0", Offset = "0x24F29C0", VA = "0x1824F3BC0")]
	[CompilerGenerated]
	private void BPGKPIJAGNA(string IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x24F3AF0", Offset = "0x24F28F0", VA = "0x1824F3AF0")]
	[CompilerGenerated]
	private bool AAHMGHFKNGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x24F5ED0", Offset = "0x24F4CD0", VA = "0x1824F5ED0")]
	[CompilerGenerated]
	private bool NAKMNIDNPEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x24F5A00", Offset = "0x24F4800", VA = "0x1824F5A00")]
	[CompilerGenerated]
	private bool MEBJJFGPCBE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x24F5570", Offset = "0x24F4370", VA = "0x1824F5570")]
	[CompilerGenerated]
	private int JMBHLLGCCAL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x24F3DF0", Offset = "0x24F2BF0", VA = "0x1824F3DF0")]
	[CompilerGenerated]
	private bool DDPBGBCHLOO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x24F5980", Offset = "0x24F4780", VA = "0x1824F5980")]
	[CompilerGenerated]
	private object MAAHDGJLBOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x24F4220", Offset = "0x24F3020", VA = "0x1824F4220")]
	[CompilerGenerated]
	private void EDLJJFCKCNM(object IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x24F3D20", Offset = "0x24F2B20", VA = "0x1824F3D20")]
	[CompilerGenerated]
	private bool DAKEBCMNKGH()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class OILNKGEPMGO
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	private sealed class OECKFCBMICC : NNFAAKCODFM<APJPNDHGCHH>
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class LEACMHKJNHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public OECKFCBMICC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public LEACMHKJNHF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x24F6470", Offset = "0x24F5270", VA = "0x1824F6470")]
			internal object CAANMBFDHPP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x24F64E0", Offset = "0x24F52E0", VA = "0x1824F64E0")]
			internal void IACEHAAHBGB(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x24FAA40", Offset = "0x24F9840", VA = "0x1824FAA40")]
		public OECKFCBMICC(CCBLBBOJEHP PJMKKGHIHNK, APJPNDHGCHH MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x24FA7B0", Offset = "0x24F95B0", VA = "0x1824FA7B0", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class MIFAABBOEKF : IBAMBBCAPKB<AFEAONBEABD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override AIPMJMOHJNA FOBLGJOFPCF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA9B090", Offset = "0xA99E90", VA = "0x180A9B090", Slot = "129")]
			get
			{
				return default(AIPMJMOHJNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x24F7570", Offset = "0x24F6370", VA = "0x1824F7570")]
		public MIFAABBOEKF(CCBLBBOJEHP PJMKKGHIHNK, AFEAONBEABD MNCBDJMAFIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class DFJDJPNIODJ : NNFAAKCODFM<AJHLHMEEMLP>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x24E44F0", Offset = "0x24E32F0", VA = "0x1824E44F0")]
		public DFJDJPNIODJ(CCBLBBOJEHP PJMKKGHIHNK, AJHLHMEEMLP KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x24E4200", Offset = "0x24E3000", VA = "0x1824E4200", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x24E44A0", Offset = "0x24E32A0", VA = "0x1824E44A0")]
		[CompilerGenerated]
		private bool OHDGLOABJNN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x24E4380", Offset = "0x24E3180", VA = "0x1824E4380")]
		[CompilerGenerated]
		private void NAPEAOAJBHC(bool IPHILEOFJLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public sealed class NCCAOKOBEPK : NNFAAKCODFM<JBBFJAFCIPO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class AKAMEOEOPMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public NCCAOKOBEPK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public AKAMEOEOPMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x24E0A10", Offset = "0x24DF810", VA = "0x1824E0A10")]
			internal void CAANMBFDHPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x24E0C20", Offset = "0x24DFA20", VA = "0x1824E0C20")]
			internal bool IACEHAAHBGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x24E0A60", Offset = "0x24DF860", VA = "0x1824E0A60")]
			internal bool FICPJHOPJNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x24E0AB0", Offset = "0x24DF8B0", VA = "0x1824E0AB0")]
			internal void HBEKIGJINMD(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x24E0BD0", Offset = "0x24DF9D0", VA = "0x1824E0BD0")]
			internal bool HCHKECBOOJO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x24F7FE0", Offset = "0x24F6DE0", VA = "0x1824F7FE0")]
		public NCCAOKOBEPK(CCBLBBOJEHP PJMKKGHIHNK, JBBFJAFCIPO KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x24F7CA0", Offset = "0x24F6AA0", VA = "0x1824F7CA0", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class CPDINMCKPCF : NNFAAKCODFM<NNLBLOOCCFE>
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class KFMMBABGMGM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public CPDINMCKPCF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public KFMMBABGMGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x24F2DE0", Offset = "0x24F1BE0", VA = "0x1824F2DE0")]
			internal object CAANMBFDHPP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x24F34C0", Offset = "0x24F22C0", VA = "0x1824F34C0")]
			internal bool PANBDAODOHN(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x24F3270", Offset = "0x24F2070", VA = "0x1824F3270")]
			internal void IACEHAAHBGB(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x24F3000", Offset = "0x24F1E00", VA = "0x1824F3000")]
			internal string FICPJHOPJNL(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x24F31B0", Offset = "0x24F1FB0", VA = "0x1824F31B0")]
			internal IReadOnlyList<object> HBEKIGJINMD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x24F3200", Offset = "0x24F2000", VA = "0x1824F3200")]
			internal bool HCHKECBOOJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x24F3160", Offset = "0x24F1F60", VA = "0x1824F3160")]
			internal bool GBFCLBDJBEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x24F2EE0", Offset = "0x24F1CE0", VA = "0x1824F2EE0")]
			internal void EBFBKKCLIEA(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x24E3DB0", Offset = "0x24E2BB0", VA = "0x1824E3DB0")]
		public CPDINMCKPCF(CCBLBBOJEHP PJMKKGHIHNK, NNLBLOOCCFE KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x24E3660", Offset = "0x24E2460", VA = "0x1824E3660", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class PDIBAPPNCAC : NNFAAKCODFM<EODPAJJOFFL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class FOGGDKCGJBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public PDIBAPPNCAC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public FOGGDKCGJBJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x24F0960", Offset = "0x24EF760", VA = "0x1824F0960")]
			internal bool CAANMBFDHPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x24F0A00", Offset = "0x24EF800", VA = "0x1824F0A00")]
			internal void IACEHAAHBGB(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x24F09B0", Offset = "0x24EF7B0", VA = "0x1824F09B0")]
			internal bool FICPJHOPJNL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x24FCE30", Offset = "0x24FBC30", VA = "0x1824FCE30")]
		public PDIBAPPNCAC(CCBLBBOJEHP PJMKKGHIHNK, EODPAJJOFFL KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x24FCC00", Offset = "0x24FBA00", VA = "0x1824FCC00", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class LCBOKNDKMKF<TNode> : NNFAAKCODFM<TNode> where TNode : notnull, LLACICBGBLF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct GHIDDHGGBNB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public AsyncTaskMethodBuilder<PGOLMGNGGBM<MMBOLDIBAHF<ECCLNDBJNAE>, HJBBDBHAMJJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public LCBOKNDKMKF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private TaskAwaiter<PGOLMGNGGBM<MMBOLDIBAHF<ECCLNDBJNAE>, HJBBDBHAMJJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x44C2450", Offset = "0x44C1250", VA = "0x1844C2450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x44C2840", Offset = "0x44C1640", VA = "0x1844C2840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct MEIELJJBAID : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public LCBOKNDKMKF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public MMBOLDIBAHF<ECCLNDBJNAE> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x4C94710", Offset = "0x4C93510", VA = "0x184C94710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x4C94B00", Offset = "0x4C93900", VA = "0x184C94B00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public sealed override bool DLACEHHEADG
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "118")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override MMBOLDIBAHF<ECCLNDBJNAE>? JCNPIIKINAM
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x4A5FDC0", Offset = "0x4A5EBC0", VA = "0x184A5FDC0", Slot = "122")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4A5FD70", Offset = "0x4A5EB70", VA = "0x184A5FD70")]
		protected LCBOKNDKMKF(CCBLBBOJEHP PJMKKGHIHNK, TNode KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4A5FC50", Offset = "0x4A5EA50", VA = "0x184A5FC50", Slot = "103")]
		[AsyncStateMachine(typeof(LCBOKNDKMKF<>.GHIDDHGGBNB))]
		public override Task<PGOLMGNGGBM<MMBOLDIBAHF<ECCLNDBJNAE>, HJBBDBHAMJJ>> PKNMOHDNCIB(string PPKJBGAOBJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4A5F960", Offset = "0x4A5E760", VA = "0x184A5F960", Slot = "127")]
		public sealed override bool IOENKGHIAHL(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4A5FAA0", Offset = "0x4A5E8A0", VA = "0x184A5FAA0", Slot = "115")]
		protected sealed override bool LFOIGPCKOPP(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4A5FA00", Offset = "0x4A5E800", VA = "0x184A5FA00", Slot = "116")]
		protected override bool LBENFNFJLHN(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4A5FB40", Offset = "0x4A5E940", VA = "0x184A5FB40", Slot = "104")]
		[AsyncStateMachine(typeof(LCBOKNDKMKF<>.MEIELJJBAID))]
		public override Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> OMJDLKCPKGJ(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class GHKGMAMKEEI : EAANAENFOMH<CAHLCKLKEFG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private sealed class IEFPKDPIADO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public GHKGMAMKEEI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public IEFPKDPIADO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x24F2640", Offset = "0x24F1440", VA = "0x1824F2640")]
			internal bool KHCIIFNHCAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x24F2580", Offset = "0x24F1380", VA = "0x1824F2580")]
			internal void ECPOANACEOO(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x24F1100", Offset = "0x24EFF00", VA = "0x1824F1100")]
		public GHKGMAMKEEI(CCBLBBOJEHP PJMKKGHIHNK, CAHLCKLKEFG MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x24F0EB0", Offset = "0x24EFCB0", VA = "0x1824F0EB0", Slot = "129")]
		protected override void LHHEJOEFICA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class GDKOFIBGJPL : GFFGOMGMOHA<JFGJKPNICGK>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xA9F400", Offset = "0xA9E200", VA = "0x180A9F400", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x24F0E50", Offset = "0x24EFC50", VA = "0x1824F0E50")]
		public GDKOFIBGJPL(CCBLBBOJEHP PJMKKGHIHNK, JFGJKPNICGK KFDHCNOCENN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public abstract class GFFGOMGMOHA<TNode> : NNFAAKCODFM<TNode> where TNode : notnull, IPEIEOFICNB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct HCCLCKDMABE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public AsyncTaskMethodBuilder<PGOLMGNGGBM<MMBOLDIBAHF<ECCLNDBJNAE>, HJBBDBHAMJJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public GFFGOMGMOHA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private TaskAwaiter<PGOLMGNGGBM<MMBOLDIBAHF<ECCLNDBJNAE>, HJBBDBHAMJJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x4552340", Offset = "0x4551140", VA = "0x184552340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x45527D0", Offset = "0x45515D0", VA = "0x1845527D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct POCLIJOBDEP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public GFFGOMGMOHA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public MMBOLDIBAHF<ECCLNDBJNAE> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x4F3D1D0", Offset = "0x4F3BFD0", VA = "0x184F3D1D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x4F3D640", Offset = "0x4F3C440", VA = "0x184F3D640", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct CHAGDKFNCJL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public AsyncTaskMethodBuilder<PGOLMGNGGBM<PHFHNLJGMNL, HJBBDBHAMJJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public GFFGOMGMOHA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private TaskAwaiter<PGOLMGNGGBM<PHFHNLJGMNL, HJBBDBHAMJJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x595C560", Offset = "0x595B360", VA = "0x18595C560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x595CC10", Offset = "0x595BA10", VA = "0x18595CC10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class GAPANLCGHKK
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
				public GAPANLCGHKK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0x3C59600", Offset = "0x3C58400", VA = "0x183C59600", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public FEMHNCEEGDK configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public GFFGOMGMOHA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public GAPANLCGHKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x44A1910", Offset = "0x44A0710", VA = "0x1844A1910")]
			internal bool EBFBKKCLIEA(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x44A1630", Offset = "0x44A0430", VA = "0x1844A1630")]
			internal void CAANMBFDHPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x44A1DE0", Offset = "0x44A0BE0", VA = "0x1844A1DE0")]
			[AsyncStateMachine(typeof(GFFGOMGMOHA<>.GAPANLCGHKK.<<BuildConfigMenuInternal>b__7>d))]
			internal void PANBDAODOHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x44A19F0", Offset = "0x44A07F0", VA = "0x1844A19F0")]
			internal bool IACEHAAHBGB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class ICGOLJJEMBD
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
				public ICGOLJJEMBD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x3C59290", Offset = "0x3C58090", VA = "0x183C59290", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
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
			public GAPANLCGHKK CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public Func<string> <>9__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Action<string> <>9__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Action <>9__5;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public ICGOLJJEMBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x46CEB10", Offset = "0x46CD910", VA = "0x1846CEB10")]
			internal void FICPJHOPJNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
			internal string HBEKIGJINMD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
			internal void HCHKECBOOJO(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x46CEF10", Offset = "0x46CDD10", VA = "0x1846CEF10")]
			[AsyncStateMachine(typeof(GFFGOMGMOHA<>.ICGOLJJEMBD.<<BuildConfigMenuInternal>b__5>d))]
			internal void GBFCLBDJBEJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class LOOGFPENJCC
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
				public LOOGFPENJCC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016C")]
				[Cpp2IlInjected.Address(RVA = "0x3C58DC0", Offset = "0x3C57BC0", VA = "0x183C58DC0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016D")]
				[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
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
				public LOOGFPENJCC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				private TaskAwaiter<PGOLMGNGGBM<MMBOLDIBAHF<KPGCHBLJMLN>, HJBBDBHAMJJ>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600016E")]
				[Cpp2IlInjected.Address(RVA = "0x3C58FA0", Offset = "0x3C57DA0", VA = "0x183C58FA0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600016F")]
				[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
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
				public LOOGFPENJCC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				private TaskAwaiter<PGOLMGNGGBM<MMBOLDIBAHF<BNKJNPHLBPJ>, HJBBDBHAMJJ>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x3C58710", Offset = "0x3C57510", VA = "0x183C58710", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public GFFGOMGMOHA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public MMBOLDIBAHF<ECCLNDBJNAE> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public FEMHNCEEGDK configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public DMICOAPJLHF nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public GIOJMNNFGKM selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public List<KHHMCBEJJCB> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public GIOJMNNFGKM selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public List<KHHMCBEJJCB> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public LOOGFPENJCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x4AAF1A0", Offset = "0x4AADFA0", VA = "0x184AAF1A0")]
			internal bool DCEHLGIGPNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x4AAF2B0", Offset = "0x4AAE0B0", VA = "0x184AAF2B0")]
			internal void GMEFFNIOCBN(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x4AAF470", Offset = "0x4AAE270", VA = "0x184AAF470")]
			internal bool ICLNDFFKBAF(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x4AAF270", Offset = "0x4AAE070", VA = "0x184AAF270")]
			internal bool FKHBAHJGAHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x4AAF0C0", Offset = "0x4AADEC0", VA = "0x184AAF0C0")]
			[AsyncStateMachine(typeof(GFFGOMGMOHA<>.LOOGFPENJCC.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void CCNJMNHFPFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x4AAF160", Offset = "0x4AADF60", VA = "0x184AAF160")]
			internal bool CKLHOGJKOCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x4AAF830", Offset = "0x4AAE630", VA = "0x184AAF830")]
			internal void NDMHHMKKEGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4AAF5B0", Offset = "0x4AAE3B0", VA = "0x184AAF5B0")]
			internal bool JDLBEPHIFEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4AAF700", Offset = "0x4AAE500", VA = "0x184AAF700")]
			internal void KMDNFMFNKEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4AAF320", Offset = "0x4AAE120", VA = "0x184AAF320")]
			internal bool GPHIIHLMHPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4AAF7C0", Offset = "0x4AAE5C0", VA = "0x184AAF7C0")]
			internal bool MNJKDHGEJFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4AAF050", Offset = "0x4AADE50", VA = "0x184AAF050")]
			internal void BNMGLNIIOJI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x4AAF3D0", Offset = "0x4AAE1D0", VA = "0x184AAF3D0")]
			[AsyncStateMachine(typeof(GFFGOMGMOHA<>.LOOGFPENJCC.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void IBKBGHKGPDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x4AAF550", Offset = "0x4AAE350", VA = "0x184AAF550")]
			internal bool IPGBHKAKJLH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x4AAEF70", Offset = "0x4AADD70", VA = "0x184AAEF70")]
			internal bool ANDOKHJHHGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4AAEFE0", Offset = "0x4AADDE0", VA = "0x184AAEFE0")]
			internal void BLHGGHEOLFG(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4AAF660", Offset = "0x4AAE460", VA = "0x184AAF660")]
			[AsyncStateMachine(typeof(GFFGOMGMOHA<>.LOOGFPENJCC.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void JEHOCJMEBOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x4AAF210", Offset = "0x4AAE010", VA = "0x184AAF210")]
			internal bool FCEJMKFKNKG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class LDPIJCMAHDF
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
				public LDPIJCMAHDF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000177")]
				[Cpp2IlInjected.Address(RVA = "0x3C58A00", Offset = "0x3C57800", VA = "0x183C58A00", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000178")]
				[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
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
			public LOOGFPENJCC CS$<>8__locals1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public Func<string> <>9__14;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public Action<string> <>9__15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public Action <>9__16;

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public LDPIJCMAHDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x4A79620", Offset = "0x4A78420", VA = "0x184A79620")]
			internal void BCBLFBLLBDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
			internal string BANKDAGNDBG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
			internal void GBPBBLIPNGL(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x4A799C0", Offset = "0x4A787C0", VA = "0x184A799C0")]
			[AsyncStateMachine(typeof(GFFGOMGMOHA<>.LDPIJCMAHDF.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void HDKNBIMFBPH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class FJILDKEFCCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public DMICOAPJLHF nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public List<KHHMCBEJJCB> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public GFFGOMGMOHA<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public MMBOLDIBAHF<ECCLNDBJNAE> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public FJILDKEFCCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x43AD7F0", Offset = "0x43AC5F0", VA = "0x1843AD7F0")]
			internal bool FHMNBPCNBDD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private sealed class NAJPPNBHJBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public AAFLNAOHLKL port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public FJILDKEFCCB CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public NAJPPNBHJBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4D17C90", Offset = "0x4D16A90", VA = "0x184D17C90")]
			internal void FIHIACHOMCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4D17F20", Offset = "0x4D16D20", VA = "0x184D17F20")]
			internal bool OHMHNBFEOCL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4D17E00", Offset = "0x4D16C00", VA = "0x184D17E00")]
			internal void LAOBAGEGNAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x4D17DA0", Offset = "0x4D16BA0", VA = "0x184D17DA0")]
			internal bool ICBOEIGHOKD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class AIOMHEGCALA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public KHHMCBEJJCB portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public NAJPPNBHJBA CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public AIOMHEGCALA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x448A960", Offset = "0x4489760", VA = "0x18448A960")]
			internal void DEIEFAIIKDL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class AGEINBCOPAD
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
				public AGEINBCOPAD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000188")]
				[Cpp2IlInjected.Address(RVA = "0x3C5AA30", Offset = "0x3C59830", VA = "0x183C5AA30", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000189")]
				[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
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
			public GIOJMNNFGKM selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public DMICOAPJLHF nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public AAFLNAOHLKL port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public AGEINBCOPAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x4480EE0", Offset = "0x447FCE0", VA = "0x184480EE0")]
			internal int JAECHAHAEFH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x4480F20", Offset = "0x447FD20", VA = "0x184480F20")]
			internal void LBKCMFGLPCJ(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490")]
			internal string JELIOPJJHGF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x4480E20", Offset = "0x447FC20", VA = "0x184480E20")]
			[AsyncStateMachine(typeof(GFFGOMGMOHA<>.AGEINBCOPAD.<<CreatePortItemV2>b__3>d))]
			internal void IFEMDKFLKOG(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x4481160", Offset = "0x447FF60", VA = "0x184481160")]
			internal bool NOLHAONAJBC(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly Dictionary<MMBOLDIBAHF<ECCLNDBJNAE>, bool> DLAAIBNPBOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly Dictionary<MMBOLDIBAHF<ECCLNDBJNAE>, bool> AMBBAOEAIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly Dictionary<MMBOLDIBAHF<ECCLNDBJNAE>, bool> OCPPLAMOPJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private Dictionary<MMBOLDIBAHF<ECCLNDBJNAE>, bool> JPKIFCLONFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private Dictionary<MMBOLDIBAHF<ECCLNDBJNAE>, bool> FMLIPJBPNJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private Dictionary<MMBOLDIBAHF<ECCLNDBJNAE>, bool> JOBBCCJNGNE;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool MGCBJJEFHCF
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "125")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected virtual bool BDCHBIFMEHC
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "129")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected virtual bool FBPFBAKECEK
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected virtual bool GCMHLFGKPGI
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "131")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override MMBOLDIBAHF<CHMLMGCOLME>? DNLBFIDHOBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x44B5000", Offset = "0x44B3E00", VA = "0x1844B5000", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override MMBOLDIBAHF<ECCLNDBJNAE>? JCNPIIKINAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x44B52D0", Offset = "0x44B40D0", VA = "0x1844B52D0", Slot = "122")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override IEnumerable<HFJNFIGGNLC<AHIDBKDCADN>>? IAONIMKHEEI
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x44B50C0", Offset = "0x44B3EC0", VA = "0x1844B50C0", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x44B4DE0", Offset = "0x44B3BE0", VA = "0x1844B4DE0")]
		public GFFGOMGMOHA(CCBLBBOJEHP PJMKKGHIHNK, TNode KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "132")]
		protected virtual bool ILHEOMJMDCF(int EFDFMACICON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "133")]
		protected virtual bool IJHICHFEHIG(int EFDFMACICON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "134")]
		protected virtual bool JHECGKNMMBC(int EFDFMACICON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "135")]
		protected virtual void MHBBPNENLOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x44B4130", Offset = "0x44B2F30", VA = "0x1844B4130", Slot = "127")]
		public override bool IOENKGHIAHL(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x44B4CC0", Offset = "0x44B3AC0", VA = "0x1844B4CC0", Slot = "103")]
		[AsyncStateMachine(typeof(GFFGOMGMOHA<>.HCCLCKDMABE))]
		public override Task<PGOLMGNGGBM<MMBOLDIBAHF<ECCLNDBJNAE>, HJBBDBHAMJJ>> PKNMOHDNCIB(string PPKJBGAOBJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x44B48B0", Offset = "0x44B36B0", VA = "0x1844B48B0", Slot = "104")]
		[AsyncStateMachine(typeof(GFFGOMGMOHA<>.POCLIJOBDEP))]
		public override Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> OMJDLKCPKGJ(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x44B4AC0", Offset = "0x44B38C0", VA = "0x1844B4AC0", Slot = "105")]
		public override void PKMNOBNOHDH(MMBOLDIBAHF<ECCLNDBJNAE> KNCPCNBMDNF, MMBOLDIBAHF<ECCLNDBJNAE> OBIPBFFAILK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x44B4640", Offset = "0x44B3440", VA = "0x1844B4640", Slot = "106")]
		public override IEnumerable<EAAKFALPLDL> OLMAHLJEBEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x44B49C0", Offset = "0x44B37C0", VA = "0x1844B49C0")]
		[AsyncStateMachine(typeof(GFFGOMGMOHA<>.CHAGDKFNCJL))]
		private Task<PGOLMGNGGBM<PHFHNLJGMNL, HJBBDBHAMJJ>> PJNAOBKOKEG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "136")]
		protected virtual bool NKIHEEJGFFE(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "137")]
		protected virtual bool HCOOMPJDJKF(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "138")]
		protected virtual bool DJCKEKHPAMH(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "139")]
		protected virtual bool FJHOPONHEGO(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "140")]
		protected virtual bool KAPFMMLIGAC(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, int CFLLIMGCEMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "141")]
		protected virtual bool BPLKMLJBHHO(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, int CFLLIMGCEMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "142")]
		protected virtual bool LKGKBDHMLNP(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, int NLGKHALDKOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "143")]
		protected virtual bool ECGIIDEJLMD(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, int NLGKHALDKOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "144")]
		protected virtual bool GAAMHLMHOMN(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, int BCFPEDLJBCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "145")]
		protected virtual bool NNONJNHHABA(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, int KADNPDEALKM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x44B43C0", Offset = "0x44B31C0", VA = "0x1844B43C0", Slot = "146")]
		protected virtual List<GIOJMNNFGKM> JNICLGNDLPN(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "147")]
		protected virtual void LNNPAFOGNJI(FEMHNCEEGDK GHICFAOGDGG, NOLFGCADBEG BKPFMGLCHLL, DMICOAPJLHF GBFONHLPEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x44B0E80", Offset = "0x44AFC80", VA = "0x1844B0E80", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x44B18D0", Offset = "0x44B06D0", VA = "0x1844B18D0")]
		private NOLFGCADBEG FBDFBINJMBB(FEMHNCEEGDK GHICFAOGDGG, DMICOAPJLHF GBFONHLPEDD, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x44B3000", Offset = "0x44B1E00", VA = "0x1844B3000")]
		private List<KHHMCBEJJCB> IFBMGNCEGIO(FEMHNCEEGDK GHICFAOGDGG, DMICOAPJLHF GBFONHLPEDD, NOLFGCADBEG DDAGKAMNMPI, bool EPHBHIHACKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x44B04B0", Offset = "0x44AF2B0", VA = "0x1844B04B0")]
		private List<KHHMCBEJJCB> BAFHLAJPHJB(FEMHNCEEGDK GHICFAOGDGG, DMICOAPJLHF GBFONHLPEDD, AAFLNAOHLKL BDPAHNFLHBO, bool EPHBHIHACKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x44B41D0", Offset = "0x44B2FD0", VA = "0x1844B41D0")]
		private GIOJMNNFGKM JNFGFEGNMPF(List<GIOJMNNFGKM> JBDOGDHKKJB, AAFLNAOHLKL BDPAHNFLHBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x44B0DF0", Offset = "0x44AFBF0", VA = "0x1844B0DF0")]
		[CompilerGenerated]
		private EAAKFALPLDL EIJIPHBONFE(IMCHGLPNCJE JELBMBFLBOP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public sealed class OPGGAJABPOE : NNFAAKCODFM<IIGFKBONMID>
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class CBKNEGDIEPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public OPGGAJABPOE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public CBKNEGDIEPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x24E18B0", Offset = "0x24E06B0", VA = "0x1824E18B0")]
			internal int CAANMBFDHPP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x24E1900", Offset = "0x24E0700", VA = "0x1824E1900")]
			internal void IACEHAAHBGB(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xEEE680", Offset = "0xEED480", VA = "0x180EEE680", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x24FCB90", Offset = "0x24FB990", VA = "0x1824FCB90")]
		public OPGGAJABPOE(CCBLBBOJEHP PJMKKGHIHNK, IIGFKBONMID KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x24FC9D0", Offset = "0x24FB7D0", VA = "0x1824FC9D0", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public sealed class DJHGIBBOOFC : EAANAENFOMH<EALAEPAANGL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private sealed class NFDMPLKOIBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public DJHGIBBOOFC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public NFDMPLKOIBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x24F80F0", Offset = "0x24F6EF0", VA = "0x1824F80F0")]
			internal int KHCIIFNHCAO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x24F8050", Offset = "0x24F6E50", VA = "0x1824F8050")]
			internal void ECPOANACEOO(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x24E47A0", Offset = "0x24E35A0", VA = "0x1824E47A0")]
		public DJHGIBBOOFC(CCBLBBOJEHP PJMKKGHIHNK, EALAEPAANGL MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x24E4560", Offset = "0x24E3360", VA = "0x1824E4560", Slot = "129")]
		protected override void LHHEJOEFICA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	private sealed class BNFCJHPLHFA : NNFAAKCODFM<JGKNMAAGJPH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xC1C950", Offset = "0xC1B750", VA = "0x180C1C950", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x24E0CE0", Offset = "0x24DFAE0", VA = "0x1824E0CE0")]
		public BNFCJHPLHFA(CCBLBBOJEHP PJMKKGHIHNK, JGKNMAAGJPH KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public sealed class NONGGKLLAEG : NNFAAKCODFM<NNIBFFKDBHJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class DLGDDEBLFGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public NONGGKLLAEG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public FEMHNCEEGDK configure;

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

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public DLGDDEBLFGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x24E5240", Offset = "0x24E4040", VA = "0x1824E5240")]
			internal bool CAANMBFDHPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x24E74E0", Offset = "0x24E62E0", VA = "0x1824E74E0")]
			internal void IACEHAAHBGB(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x24E7040", Offset = "0x24E5E40", VA = "0x1824E7040")]
			internal bool HCHKECBOOJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x24E66A0", Offset = "0x24E54A0", VA = "0x1824E66A0")]
			internal bool GBFCLBDJBEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x24E5A50", Offset = "0x24E4850", VA = "0x1824E5A50")]
			internal void EBFBKKCLIEA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x24E82D0", Offset = "0x24E70D0", VA = "0x1824E82D0")]
			internal bool LBHLAPMHJKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x24E6650", Offset = "0x24E5450", VA = "0x1824E6650")]
			internal bool FPOFLDHCJIA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x24EF780", Offset = "0x24EE580", VA = "0x1824EF780")]
			internal void PJCBOGGFNCD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x24E89B0", Offset = "0x24E77B0", VA = "0x1824E89B0")]
			internal bool MPINDIELNEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x24E6AA0", Offset = "0x24E58A0", VA = "0x1824E6AA0")]
			internal bool GLDAKADHDAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x24E5350", Offset = "0x24E4150", VA = "0x1824E5350")]
			internal void CCCBMEIMOGI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x24E75F0", Offset = "0x24E63F0", VA = "0x1824E75F0")]
			internal bool IFNLGAFPEDC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x24E5590", Offset = "0x24E4390", VA = "0x1824E5590")]
			internal bool CLEBJLFMMEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x24E55E0", Offset = "0x24E43E0", VA = "0x1824E55E0")]
			internal bool CLNBDIKBLNP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x24E7690", Offset = "0x24E6490", VA = "0x1824E7690")]
			internal bool IIIFBLMOJGC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x24EF510", Offset = "0x24EE310", VA = "0x1824EF510")]
			internal bool PBDOFFIDAKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x24E5850", Offset = "0x24E4650", VA = "0x1824E5850")]
			internal bool DHALAGFBOBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x24EECC0", Offset = "0x24EDAC0", VA = "0x1824EECC0")]
			internal bool NJNGBEAGOCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x24E8430", Offset = "0x24E7230", VA = "0x1824E8430")]
			internal bool LHBIFAFDLPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x24E5C50", Offset = "0x24E4A50", VA = "0x1824E5C50")]
			internal bool EGNJOOCFMPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x24E8740", Offset = "0x24E7540", VA = "0x1824E8740")]
			internal void MHBBFODCJAD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x24E6FF0", Offset = "0x24E5DF0", VA = "0x1824E6FF0")]
			internal bool HBDNOLKEKKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x24EEE60", Offset = "0x24EDC60", VA = "0x1824EEE60")]
			internal bool OBOJJCFFAPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x24EEC20", Offset = "0x24EDA20", VA = "0x1824EEC20")]
			internal bool NIILFPHIBEM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x24EF470", Offset = "0x24EE270", VA = "0x1824EF470")]
			internal bool OOFCOOGCFDL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x24E4E40", Offset = "0x24E3C40", VA = "0x1824E4E40")]
			internal bool AMIIBOJEJLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x24E4DF0", Offset = "0x24E3BF0", VA = "0x1824E4DF0")]
			internal bool AMDLKDFNPNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x24E7350", Offset = "0x24E6150", VA = "0x1824E7350")]
			internal bool HLAACMIIAHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x24EEFC0", Offset = "0x24EDDC0", VA = "0x1824EEFC0")]
			internal bool OEPIPHJFNOM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x24E8890", Offset = "0x24E7690", VA = "0x1824E8890")]
			internal void MMMEJBPLAOI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x24E6760", Offset = "0x24E5560", VA = "0x1824E6760")]
			internal bool GECKCKLENFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x24E5CA0", Offset = "0x24E4AA0", VA = "0x1824E5CA0")]
			internal bool EIAJGGNAHFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x24E5BA0", Offset = "0x24E49A0", VA = "0x1824E5BA0")]
			internal void EDMNFBOKHGN(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x24E67B0", Offset = "0x24E55B0", VA = "0x1824E67B0")]
			internal bool GEOLLJANCPJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x24EF6C0", Offset = "0x24EE4C0", VA = "0x1824EF6C0")]
			internal bool PIBOFHMIMBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x24E4BB0", Offset = "0x24E39B0", VA = "0x1824E4BB0")]
			internal void AAJJCEHLLLL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x24E8B10", Offset = "0x24E7910", VA = "0x1824E8B10")]
			internal List<KHHMCBEJJCB> NHCAKDDJLAN(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x24EF7E0", Offset = "0x24EE5E0", VA = "0x1824EF7E0")]
			internal bool PKAPFIIHMFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x24E5B50", Offset = "0x24E4950", VA = "0x1824E5B50")]
			internal int ECFFKJOPGEP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x24EF2B0", Offset = "0x24EE0B0", VA = "0x1824EF2B0")]
			internal void OKNICEHLHNM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x24E4DA0", Offset = "0x24E3BA0", VA = "0x1824E4DA0")]
			internal bool ALJLIDNDMDJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x24E6200", Offset = "0x24E5000", VA = "0x1824E6200")]
			internal bool FAIEDLMBBOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x24E6160", Offset = "0x24E4F60", VA = "0x1824E6160")]
			internal bool EPACOCKMEKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x24E7780", Offset = "0x24E6580", VA = "0x1824E7780")]
			internal int IJKHENJJFJP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x24E8620", Offset = "0x24E7420", VA = "0x1824E8620")]
			internal void MDOAJPFKLPO(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x24E61B0", Offset = "0x24E4FB0", VA = "0x1824E61B0")]
			internal bool FAEMJAJFHFP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x24E5540", Offset = "0x24E4340", VA = "0x1824E5540")]
			internal bool CKMBLJKOIJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x24E8050", Offset = "0x24E6E50", VA = "0x1824E8050")]
			internal bool KGJEHFANIJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x24E65B0", Offset = "0x24E53B0", VA = "0x1824E65B0")]
			internal bool FPIPCHIHLLL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x24E86F0", Offset = "0x24E74F0", VA = "0x1824E86F0")]
			internal bool MGACFIIJLAF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x24E72B0", Offset = "0x24E60B0", VA = "0x1824E72B0")]
			internal bool HHGFPAABKOP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x24E6020", Offset = "0x24E4E20", VA = "0x1824E6020")]
			internal string EKFLCHJODNH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x24E5630", Offset = "0x24E4430", VA = "0x1824E5630")]
			internal void CLOCEEFKPJC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x24E5150", Offset = "0x24E3F50", VA = "0x1824E5150")]
			internal int BJKNLBAKPMP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x24EF660", Offset = "0x24EE460", VA = "0x1824EF660")]
			internal void PEJGNOBLMJP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x24EF420", Offset = "0x24EE220", VA = "0x1824EF420")]
			internal bool OOFCAPGLCDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x24E5A00", Offset = "0x24E4800", VA = "0x1824E5A00")]
			internal bool DODAJPNEKBF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x24E76E0", Offset = "0x24E64E0", VA = "0x1824E76E0")]
			internal bool IJFEPDIMADI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x24E6A00", Offset = "0x24E5800", VA = "0x1824E6A00")]
			internal float GIPOFJJMBBL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x24E57F0", Offset = "0x24E45F0", VA = "0x1824E57F0")]
			internal void DCMGPBJLKPO(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x24E6800", Offset = "0x24E5600", VA = "0x1824E6800")]
			internal bool GFEBBFIHPKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x24E7980", Offset = "0x24E6780", VA = "0x1824E7980")]
			internal bool IOIIEEMJNJG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x24E7210", Offset = "0x24E6010", VA = "0x1824E7210")]
			internal bool HGKILHCNMBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x24E54A0", Offset = "0x24E42A0", VA = "0x1824E54A0")]
			internal bool CJCLMFHGBNO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x24E7DD0", Offset = "0x24E6BD0", VA = "0x1824E7DD0")]
			internal bool JMHKMNBPHEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x24E6600", Offset = "0x24E5400", VA = "0x1824E6600")]
			internal bool FPNDDPPCEKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x24E6C30", Offset = "0x24E5A30", VA = "0x1824E6C30")]
			internal void HAPAMEEAIKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x24E7300", Offset = "0x24E6100", VA = "0x1824E7300")]
			internal string HINIJCKELLL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x24E7D60", Offset = "0x24E6B60", VA = "0x1824E7D60")]
			internal void JLIHDGHCALH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x24EF380", Offset = "0x24EE180", VA = "0x1824EF380")]
			internal bool OMKIHLDJNDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x24E73A0", Offset = "0x24E61A0", VA = "0x1824E73A0")]
			internal bool HLJCFPAGFPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x24E7E70", Offset = "0x24E6C70", VA = "0x1824E7E70")]
			internal bool JNHGGEKGMHP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x24E5D50", Offset = "0x24E4B50", VA = "0x1824E5D50")]
			internal void EJNNAIIGLDA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x24E7BD0", Offset = "0x24E69D0", VA = "0x1824E7BD0")]
			internal bool JHBMKMHKCKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x24E7CC0", Offset = "0x24E6AC0", VA = "0x1824E7CC0")]
			internal bool JJHCFEFFHHA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x24E8000", Offset = "0x24E6E00", VA = "0x1824E8000")]
			internal bool KECGJNKBDNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x24E8580", Offset = "0x24E7380", VA = "0x1824E8580")]
			internal bool LLKFHPMGLNH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x24E7A80", Offset = "0x24E6880", VA = "0x1824E7A80")]
			internal void JEOHKCHLHBD(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x24E68A0", Offset = "0x24E56A0", VA = "0x1824E68A0")]
			internal bool GFJPPNCDGHK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x24EF830", Offset = "0x24EE630", VA = "0x1824EF830")]
			internal bool PKLJHHJNDBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x24E6390", Offset = "0x24E5190", VA = "0x1824E6390")]
			internal bool FLDJMACEIGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x24E7490", Offset = "0x24E6290", VA = "0x1824E7490")]
			internal bool HPALLHOFDCH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x24EED60", Offset = "0x24EDB60", VA = "0x1824EED60")]
			internal void NMAKPELIIJM(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x24EF260", Offset = "0x24EE060", VA = "0x1824EF260")]
			internal bool OKBHOHHLEDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x24E85D0", Offset = "0x24E73D0", VA = "0x1824E85D0")]
			internal bool MBPCDNJHJMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x24E7C20", Offset = "0x24E6A20", VA = "0x1824E7C20")]
			internal bool JIAFMLIIKLM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x24E73F0", Offset = "0x24E61F0", VA = "0x1824E73F0")]
			internal bool HNGJBDAPCBE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x24E8A00", Offset = "0x24E7800", VA = "0x1824E8A00")]
			internal object NDMEKNNKFKH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x24EF920", Offset = "0x24EE720", VA = "0x1824EF920")]
			internal void PPLEHJIFJIM(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x24EF880", Offset = "0x24EE680", VA = "0x1824EF880")]
			internal bool PLOGMHHFNEM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x24E6110", Offset = "0x24E4F10", VA = "0x1824E6110")]
			internal bool EOJGPOFPHJM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x24E50B0", Offset = "0x24E3EB0", VA = "0x1824E50B0")]
			internal int BECPDCGHBBG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x24E7590", Offset = "0x24E6390", VA = "0x1824E7590")]
			internal void IALCPINIPEE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x24E5100", Offset = "0x24E3F00", VA = "0x1824E5100")]
			internal bool BGMCMJFLMBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x24E7730", Offset = "0x24E6530", VA = "0x1824E7730")]
			internal bool IJKAHDHCKJN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x24EF5C0", Offset = "0x24EE3C0", VA = "0x1824EF5C0")]
			internal int PDCDKLDKOGD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x24E68F0", Offset = "0x24E56F0", VA = "0x1824E68F0")]
			internal void GFKJABPKHAN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x24E64F0", Offset = "0x24E52F0", VA = "0x1824E64F0")]
			internal bool FNNNDIPGFOG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x24E4CA0", Offset = "0x24E3AA0", VA = "0x1824E4CA0")]
			internal bool AEEAPHCMCFJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x24E87F0", Offset = "0x24E75F0", VA = "0x1824E87F0")]
			internal bool MJGLAMLHMFM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x24E7F60", Offset = "0x24E6D60", VA = "0x1824E7F60")]
			internal int JPGOJBJEJNO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x24E6950", Offset = "0x24E5750", VA = "0x1824E6950")]
			internal void GHEBEJAFAFN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x24EF010", Offset = "0x24EDE10", VA = "0x1824EF010")]
			internal bool OGNGDOILBEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x24E51A0", Offset = "0x24E3FA0", VA = "0x1824E51A0")]
			internal bool BMGBLHEKJII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x24EF1C0", Offset = "0x24EDFC0", VA = "0x1824EF1C0")]
			internal bool OJCJNLMGPGF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x24E6480", Offset = "0x24E5280", VA = "0x1824E6480")]
			internal object FMJPEFGFLLI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x24E4C10", Offset = "0x24E3A10", VA = "0x1824E4C10")]
			internal void ABNDEEJBBPP(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x24E59B0", Offset = "0x24E47B0", VA = "0x1824E59B0")]
			internal bool DNFPBEGEGBB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x24E5C00", Offset = "0x24E4A00", VA = "0x1824E5C00")]
			internal bool EGHLBNBKJDA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x24E58A0", Offset = "0x24E46A0", VA = "0x1824E58A0")]
			internal object DJDPDEKIPGP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x24E4F30", Offset = "0x24E3D30", VA = "0x1824E4F30")]
			internal void BCMBMKAFCBJ(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x24E51F0", Offset = "0x24E3FF0", VA = "0x1824E51F0")]
			internal bool BMHBGAMMCKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x24E80F0", Offset = "0x24E6EF0", VA = "0x1824E80F0")]
			internal int KIEBLEFCJHO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x24E4D40", Offset = "0x24E3B40", VA = "0x1824E4D40")]
			internal void ALIMPLABHKC(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x24E57A0", Offset = "0x24E45A0", VA = "0x1824E57A0")]
			internal bool DCFBJDJAHMI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x24E5910", Offset = "0x24E4710", VA = "0x1824E5910")]
			internal bool DMKABDFEPKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x24E7640", Offset = "0x24E6440", VA = "0x1824E7640")]
			internal bool IHLMIABKMIJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x24E7F10", Offset = "0x24E6D10", VA = "0x1824E7F10")]
			internal int JOKPMIEMBHN()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x24EF560", Offset = "0x24EE360", VA = "0x1824EF560")]
			internal void PBNFGCGAPKJ(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x24EEC70", Offset = "0x24EDA70", VA = "0x1824EEC70")]
			internal bool NJCCFANECIH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x24E7930", Offset = "0x24E6730", VA = "0x1824E7930")]
			internal bool INLPEOOKNLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x24E6250", Offset = "0x24E5050", VA = "0x1824E6250")]
			internal bool FDJMAONJEAI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x24E7890", Offset = "0x24E6690", VA = "0x1824E7890")]
			internal float INAPCAGMGMG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x24E8520", Offset = "0x24E7320", VA = "0x1824E8520")]
			internal void LKPGHEKKNIB(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x24E5AB0", Offset = "0x24E48B0", VA = "0x1824E5AB0")]
			internal bool EBGLMCICBMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x24E6850", Offset = "0x24E5650", VA = "0x1824E6850")]
			internal bool GFHLICOGGNI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x24E8480", Offset = "0x24E7280", VA = "0x1824E8480")]
			internal bool LJJCGPFACAG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x24EEF00", Offset = "0x24EDD00", VA = "0x1824EEF00")]
			internal float OCNIAIPDCFC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x24E79D0", Offset = "0x24E67D0", VA = "0x1824E79D0")]
			internal void JBMINMPGEBA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x24E5700", Offset = "0x24E4500", VA = "0x1824E5700")]
			internal bool DAIBDGIJJCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x24E5400", Offset = "0x24E4200", VA = "0x1824E5400")]
			internal bool CHHNEBJCDEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x24E8140", Offset = "0x24E6F40", VA = "0x1824E8140")]
			internal string KIEMAHEBKHA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x24EEF50", Offset = "0x24EDD50", VA = "0x1824EEF50")]
			internal void ODFNBCIGJEF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x24E6430", Offset = "0x24E5230", VA = "0x1824E6430")]
			internal bool FMHCGPEGDBK(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x24E60C0", Offset = "0x24E4EC0", VA = "0x1824E60C0")]
			internal bool ELMCKNLHKPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x24E6070", Offset = "0x24E4E70", VA = "0x1824E6070")]
			internal bool ELGIEGDBBPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x24E4EE0", Offset = "0x24E3CE0", VA = "0x1824E4EE0")]
			internal bool BCLEFCIHJMA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x24E7A30", Offset = "0x24E6830", VA = "0x1824E7A30")]
			internal string JBNLJDENJCA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x24EF150", Offset = "0x24EDF50", VA = "0x1824EF150")]
			internal void OJBLOMLGNFP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x24E84D0", Offset = "0x24E72D0", VA = "0x1824E84D0")]
			internal bool LKDFCIHDEHO(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x24E69B0", Offset = "0x24E57B0", VA = "0x1824E69B0")]
			internal bool GHECJGMIDBJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x24E62A0", Offset = "0x24E50A0", VA = "0x1824E62A0")]
			internal bool FDNMPKCFBBM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x24E7FB0", Offset = "0x24E6DB0", VA = "0x1824E7FB0")]
			internal bool KDFCDOMDFEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x24E5B00", Offset = "0x24E4900", VA = "0x1824E5B00")]
			internal string ECCPHDBDENF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x24E83C0", Offset = "0x24E71C0", VA = "0x1824E83C0")]
			internal void LGOHDDJEKEE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x24E8280", Offset = "0x24E7080", VA = "0x1824E8280")]
			internal bool KPPNFLLDGHI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x24E5450", Offset = "0x24E4250", VA = "0x1824E5450")]
			internal bool CIKGIEJLJCN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x24E7E20", Offset = "0x24E6C20", VA = "0x1824E7E20")]
			internal bool JMKDNIOMCAE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x24EED10", Offset = "0x24EDB10", VA = "0x1824EED10")]
			internal bool NLGCGEEEJGB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x24E5060", Offset = "0x24E3E60", VA = "0x1824E5060")]
			internal string BDLIFELMKJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x24E7090", Offset = "0x24E5E90", VA = "0x1824E7090")]
			internal void HDGMIHFBBGA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x24E4E90", Offset = "0x24E3C90", VA = "0x1824E4E90")]
			internal bool AMLDCOLNJKF(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x24E4CF0", Offset = "0x24E3AF0", VA = "0x1824E4CF0")]
			internal bool AJALIGMBIIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x24EEEB0", Offset = "0x24EDCB0", VA = "0x1824EEEB0")]
			internal bool OCNHDJGFKCF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x24E7B30", Offset = "0x24E6930", VA = "0x1824E7B30")]
			internal bool JFOJOABAMEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x24E53B0", Offset = "0x24E41B0", VA = "0x1824E53B0")]
			internal string CCJPFJFBMNJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x24E71A0", Offset = "0x24E5FA0", VA = "0x1824E71A0")]
			internal void HFEGIKPEMEA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x24E7AE0", Offset = "0x24E68E0", VA = "0x1824E7AE0")]
			internal bool JFHLAJLNAKB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x24E7100", Offset = "0x24E5F00", VA = "0x1824E7100")]
			internal bool HDJEGEEGEEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x24E8230", Offset = "0x24E7030", VA = "0x1824E8230")]
			internal bool KOKMOKAOLFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x24E5290", Offset = "0x24E4090", VA = "0x1824E5290")]
			internal bool CAEBJGJDKBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x24E6340", Offset = "0x24E5140", VA = "0x1824E6340")]
			internal string FLDINOPKHNI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x24E8940", Offset = "0x24E7740", VA = "0x1824E8940")]
			internal void MNFJBJIAJPO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x24E81E0", Offset = "0x24E6FE0", VA = "0x1824E81E0")]
			internal bool KOECIJAHNGG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x24EEE10", Offset = "0x24EDC10", VA = "0x1824EEE10")]
			internal bool OAJPBFACPLL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x24E80A0", Offset = "0x24E6EA0", VA = "0x1824E80A0")]
			internal bool KHLMFEHIEPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x24E63E0", Offset = "0x24E51E0", VA = "0x1824E63E0")]
			internal bool FLILGJKOAPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x24E5010", Offset = "0x24E3E10", VA = "0x1824E5010")]
			internal string BDLHEOGMKIM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x24E66F0", Offset = "0x24E54F0", VA = "0x1824E66F0")]
			internal void GDKINJMCJBP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x24E7D10", Offset = "0x24E6B10", VA = "0x1824E7D10")]
			internal bool JJPPAGAFJDM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x24EF0B0", Offset = "0x24EDEB0", VA = "0x1824EF0B0")]
			internal bool OIBANOEBAPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x24E54F0", Offset = "0x24E42F0", VA = "0x1824E54F0")]
			internal bool CKAPHLAGHOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x24E8370", Offset = "0x24E7170", VA = "0x1824E8370")]
			internal bool LGCPDLHCCJD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x24E87A0", Offset = "0x24E75A0", VA = "0x1824E87A0")]
			internal string MIEHOOJCDAF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x24E52E0", Offset = "0x24E40E0", VA = "0x1824E52E0")]
			internal void CBNHGGABCEF(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x24E6BE0", Offset = "0x24E59E0", VA = "0x1824E6BE0")]
			internal bool HADAPGOINEG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x24E4FC0", Offset = "0x24E3DC0", VA = "0x1824E4FC0")]
			internal bool BCNCGFNDJFE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x24EF3D0", Offset = "0x24EE1D0", VA = "0x1824EF3D0")]
			internal bool ONKHNDICMOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x24EF4C0", Offset = "0x24EE2C0", VA = "0x1824EF4C0")]
			internal bool OPOJEONFPNA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x24E62F0", Offset = "0x24E50F0", VA = "0x1824E62F0")]
			internal string FGMJLLGHCKF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x24EF710", Offset = "0x24EE510", VA = "0x1824EF710")]
			internal void PJCBHCMAMMK(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x24E7260", Offset = "0x24E6060", VA = "0x1824E7260")]
			internal bool HGMGBKGILJE(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x24EF610", Offset = "0x24EE410", VA = "0x1824EF610")]
			internal bool PEEOKKMIGLF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x24E8840", Offset = "0x24E7640", VA = "0x1824E8840")]
			internal bool MLCNMHKMMOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x24E6AF0", Offset = "0x24E58F0", VA = "0x1824E6AF0")]
			internal bool GLGIKBFAGKB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x24EF100", Offset = "0x24EDF00", VA = "0x1824EF100")]
			internal string OIOFEAKFLKB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x24EF310", Offset = "0x24EE110", VA = "0x1824EF310")]
			internal void OLCJIOOPKBI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x24E6B40", Offset = "0x24E5940", VA = "0x1824E6B40")]
			internal bool GNJGEGLDLCJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x24E6A50", Offset = "0x24E5850", VA = "0x1824E6A50")]
			internal bool GJBBJCBFKHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x24E6B90", Offset = "0x24E5990", VA = "0x1824E6B90")]
			internal bool GPOEBOGBOKE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x24E8320", Offset = "0x24E7120", VA = "0x1824E8320")]
			internal string LDDFJIHPAHA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x24E7820", Offset = "0x24E6620", VA = "0x1824E7820")]
			internal void IMMKADFONHA(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x24EEDC0", Offset = "0x24EDBC0", VA = "0x1824EEDC0")]
			internal bool NMCLHEOPJKK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x24EF210", Offset = "0x24EE010", VA = "0x1824EF210")]
			internal bool OJDCMMJNMNM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x24E7440", Offset = "0x24E6240", VA = "0x1824E7440")]
			internal bool HOEPJNJLFJB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x24E5750", Offset = "0x24E4550", VA = "0x1824E5750")]
			internal string DBGOKNAOMGP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x24E8680", Offset = "0x24E7480", VA = "0x1824E8680")]
			internal void MFFIOAEMMHP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x24E8AC0", Offset = "0x24E78C0", VA = "0x1824E8AC0")]
			internal bool NGPKJEGCCGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x24E7C70", Offset = "0x24E6A70", VA = "0x1824E7C70")]
			internal bool JIOHLIAKBGL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x24E77D0", Offset = "0x24E65D0", VA = "0x1824E77D0")]
			internal bool IKDDJEAEIME()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x24E88F0", Offset = "0x24E76F0", VA = "0x1824E88F0")]
			internal string MMMJDEFOKLD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x24E6540", Offset = "0x24E5340", VA = "0x1824E6540")]
			internal void FODFEMNMKMI(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x24E8190", Offset = "0x24E6F90", VA = "0x1824E8190")]
			internal bool KJAMEBAGPMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x24EF8D0", Offset = "0x24EE6D0", VA = "0x1824EF8D0")]
			internal bool PMMOIJLMEMH(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x24E78E0", Offset = "0x24E66E0", VA = "0x1824E78E0")]
			internal float INBPJCIEABL()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x24E56A0", Offset = "0x24E44A0", VA = "0x1824E56A0")]
			internal void CNIMPLLACBJ(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x24E7B80", Offset = "0x24E6980", VA = "0x1824E7B80")]
			internal bool JHBFKCGIFAC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x24E7540", Offset = "0x24E6340", VA = "0x1824E7540")]
			internal bool IACICOGAHLI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x24E8A70", Offset = "0x24E7870", VA = "0x1824E8A70")]
			internal bool NGNFPJCODEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x24EF060", Offset = "0x24EDE60", VA = "0x1824EF060")]
			internal int OGONMPGBFGM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x24E5CF0", Offset = "0x24E4AF0", VA = "0x1824E5CF0")]
			internal void EILEGGDPNBI(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x24E7EC0", Offset = "0x24E6CC0", VA = "0x1824E7EC0")]
			internal bool JNHHDCPFPFO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x24E7150", Offset = "0x24E5F50", VA = "0x1824E7150")]
			internal bool HFDCNHDKBPF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x24E5960", Offset = "0x24E4760", VA = "0x1824E5960")]
			internal bool DNCDMBLGBOC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class CBENHEFKMDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public DLGDDEBLFGI CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public CBENHEFKMDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x24E0D50", Offset = "0x24DFB50", VA = "0x1824E0D50")]
			internal void EPJCBFABBOL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class DEIINBNPHJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public DEIINBNPHJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x24E4180", Offset = "0x24E2F80", VA = "0x1824E4180")]
			internal bool KJLDOHCMMFF(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private readonly EILAKDKEEJE JNKHNOFJEDO;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x24FA350", Offset = "0x24F9150", VA = "0x1824FA350")]
		public NONGGKLLAEG(CCBLBBOJEHP PJMKKGHIHNK, NNIBFFKDBHJ KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x24F8580", Offset = "0x24F7380", VA = "0x1824F8580", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public sealed class GOKNMNNNGEJ : NNFAAKCODFM<NOOBOFINAGJ>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class NMMBGFDJCNG
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
				public NMMBGFDJCNG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002A6")]
				[Cpp2IlInjected.Address(RVA = "0x251C190", Offset = "0x251AF90", VA = "0x18251C190", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002A7")]
				[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016A")]
			public GOKNMNNNGEJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016B")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public NMMBGFDJCNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x24F8380", Offset = "0x24F7180", VA = "0x1824F8380")]
			internal string CAANMBFDHPP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x24F84B0", Offset = "0x24F72B0", VA = "0x1824F84B0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void IACEHAAHBGB(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x24F83D0", Offset = "0x24F71D0", VA = "0x1824F83D0")]
			internal int FICPJHOPJNL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x24F8420", Offset = "0x24F7220", VA = "0x1824F8420")]
			internal void HBEKIGJINMD(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xEEE680", Offset = "0xEED480", VA = "0x180EEE680", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x24F1890", Offset = "0x24F0690", VA = "0x1824F1890")]
		public GOKNMNNNGEJ(CCBLBBOJEHP PJMKKGHIHNK, NOOBOFINAGJ MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x24F1540", Offset = "0x24F0340", VA = "0x1824F1540", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public sealed class FGINCDMELNH : NNFAAKCODFM<CNMFHBJBDIG>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class IGCNGCOJONN
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
				public IGCNGCOJONN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x251BE50", Offset = "0x251AC50", VA = "0x18251BE50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
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
				public IGCNGCOJONN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x251C4A0", Offset = "0x251B2A0", VA = "0x18251C4A0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			public FGINCDMELNH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public IGCNGCOJONN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x250C560", Offset = "0x250B360", VA = "0x18250C560")]
			internal string CAANMBFDHPP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x250C940", Offset = "0x250B740", VA = "0x18250C940")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void IACEHAAHBGB(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x250C600", Offset = "0x250B400", VA = "0x18250C600")]
			internal int FICPJHOPJNL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x250C860", Offset = "0x250B660", VA = "0x18250C860")]
			internal void HBEKIGJINMD(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x250C8F0", Offset = "0x250B6F0", VA = "0x18250C8F0")]
			internal string HCHKECBOOJO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x250C6A0", Offset = "0x250B4A0", VA = "0x18250C6A0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void GBFCLBDJBEJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x250C5B0", Offset = "0x250B3B0", VA = "0x18250C5B0")]
			internal bool EBFBKKCLIEA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x250CB70", Offset = "0x250B970", VA = "0x18250CB70")]
			internal void PANBDAODOHN(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x250C770", Offset = "0x250B570", VA = "0x18250C770")]
			internal bool GKMOBPNMLEI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x250CA10", Offset = "0x250B810", VA = "0x18250CA10")]
			internal void LBHLAPMHJKF(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x250C650", Offset = "0x250B450", VA = "0x18250C650")]
			internal float FPOFLDHCJIA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x250CC00", Offset = "0x250BA00", VA = "0x18250CC00")]
			internal void PJCBOGGFNCD(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x250CB10", Offset = "0x250B910", VA = "0x18250CB10")]
			internal int OKLHAHOHBPO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x250C7C0", Offset = "0x250B5C0", VA = "0x18250C7C0")]
			internal void HBDLCLKIKKB(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x250CAA0", Offset = "0x250B8A0", VA = "0x18250CAA0")]
			internal bool MPINDIELNEJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xEEE680", Offset = "0xEED480", VA = "0x180EEE680", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x250A190", Offset = "0x2508F90", VA = "0x18250A190")]
		public FGINCDMELNH(CCBLBBOJEHP PJMKKGHIHNK, CNMFHBJBDIG KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x2509750", Offset = "0x2508550", VA = "0x182509750", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class NHELJACPPLB : NNFAAKCODFM<MFIFHDEMCHL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class JDMKLGBGFEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public NHELJACPPLB <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public JDMKLGBGFEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x250CD70", Offset = "0x250BB70", VA = "0x18250CD70")]
			internal Dictionary<string, NNDGLBEAKFC> CAANMBFDHPP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x250CFB0", Offset = "0x250BDB0", VA = "0x18250CFB0")]
			internal int IACEHAAHBGB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x250CE10", Offset = "0x250BC10", VA = "0x18250CE10")]
			internal void FICPJHOPJNL(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x250CF30", Offset = "0x250BD30", VA = "0x18250CF30")]
			internal bool HBEKIGJINMD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xEEE680", Offset = "0xEED480", VA = "0x180EEE680", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x25104E0", Offset = "0x250F2E0", VA = "0x1825104E0")]
		public NHELJACPPLB(CCBLBBOJEHP PJMKKGHIHNK, MFIFHDEMCHL MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x2510210", Offset = "0x250F010", VA = "0x182510210", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public sealed class DCAOCFPKFEL : NNFAAKCODFM<PAHGPOCFOAG>
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class OLIOONLOILB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public DCAOCFPKFEL <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public OLIOONLOILB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x251A9E0", Offset = "0x25197E0", VA = "0x18251A9E0")]
			internal void CAANMBFDHPP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xEEE680", Offset = "0xEED480", VA = "0x180EEE680", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x2500F00", Offset = "0x24FFD00", VA = "0x182500F00")]
		public DCAOCFPKFEL(CCBLBBOJEHP PJMKKGHIHNK, PAHGPOCFOAG MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x2500D80", Offset = "0x24FFB80", VA = "0x182500D80", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class BNHCDBBLMEI<TNode> : GFFGOMGMOHA<TNode> where TNode : notnull, GGNJBHOJMBI
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool KFMBDNDGHBG
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ELMHDOGAIGE? JMJBCMIBKBE
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x5687980", Offset = "0x5686780", VA = "0x185687980", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override bool PLPDNNOCDAM
		{
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x56879F0", Offset = "0x56867F0", VA = "0x1856879F0", Slot = "120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0xC4E5E0", Offset = "0xC4D3E0", VA = "0x180C4E5E0", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x5129C80", Offset = "0x5128A80", VA = "0x185129C80")]
		public BNHCDBBLMEI(CCBLBBOJEHP PJMKKGHIHNK, TNode KFDHCNOCENN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class EGKJLCHIKMF : BNHCDBBLMEI<MPKHEDAENNK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class ALKPEMLICCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public EGKJLCHIKMF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public ALKPEMLICCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x24FF500", Offset = "0x24FE300", VA = "0x1824FF500")]
			internal object CAANMBFDHPP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x24FF650", Offset = "0x24FE450", VA = "0x1824FF650")]
			internal void IACEHAAHBGB(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x24FF570", Offset = "0x24FE370", VA = "0x1824FF570")]
			internal void FICPJHOPJNL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private static object[]? NLKDANBHEMK;

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x2508E70", Offset = "0x2507C70", VA = "0x182508E70")]
		public EGKJLCHIKMF(CCBLBBOJEHP PJMKKGHIHNK, MPKHEDAENNK KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x25088C0", Offset = "0x25076C0", VA = "0x1825088C0", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private sealed class LGPKFAIBINL : NNFAAKCODFM<IKEMCIPFOCI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xB43560", Offset = "0xB42360", VA = "0x180B43560", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x250F1A0", Offset = "0x250DFA0", VA = "0x18250F1A0")]
		public LGPKFAIBINL(CCBLBBOJEHP PJMKKGHIHNK, IKEMCIPFOCI KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private sealed class LHMKDLDDLKB : NNFAAKCODFM<NMFEJNBCHAE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0xA9A320", Offset = "0xA99120", VA = "0x180A9A320", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x250F210", Offset = "0x250E010", VA = "0x18250F210")]
		public LHMKDLDDLKB(CCBLBBOJEHP PJMKKGHIHNK, NMFEJNBCHAE KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "115")]
		protected override bool LFOIGPCKOPP(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	private sealed class JMAPKGLJCJO : NNFAAKCODFM<DAIGANAIEBK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xA68120", Offset = "0xA66F20", VA = "0x180A68120", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override bool GKFGKLHEIBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x250D070", Offset = "0x250BE70", VA = "0x18250D070", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override bool NPPJAJKFDIB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x250D000", Offset = "0x250BE00", VA = "0x18250D000")]
		public JMAPKGLJCJO(CCBLBBOJEHP PJMKKGHIHNK, DAIGANAIEBK KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private sealed class DIPGNIBHCAA : NNFAAKCODFM<ENDEDBNBPFN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xA9B090", Offset = "0xA99E90", VA = "0x180A9B090", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool GKFGKLHEIBP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x2507FE0", Offset = "0x2506DE0", VA = "0x182507FE0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		protected override bool NPPJAJKFDIB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2507F70", Offset = "0x2506D70", VA = "0x182507F70")]
		public DIPGNIBHCAA(CCBLBBOJEHP PJMKKGHIHNK, ENDEDBNBPFN KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public sealed class NHNCBINMLJA : EAANAENFOMH<CKAJHBIOHNB>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class CLJKOJNLKII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public NHNCBINMLJA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public CLJKOJNLKII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x2500CA0", Offset = "0x24FFAA0", VA = "0x182500CA0")]
			internal float KHCIIFNHCAO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x2500C00", Offset = "0x24FFA00", VA = "0x182500C00")]
			internal void ECPOANACEOO(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x25107D0", Offset = "0x250F5D0", VA = "0x1825107D0")]
		public NHNCBINMLJA(CCBLBBOJEHP PJMKKGHIHNK, CKAJHBIOHNB MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x2510550", Offset = "0x250F350", VA = "0x182510550", Slot = "129")]
		protected override void LHHEJOEFICA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public sealed class PGIBBEBOIMI : NNFAAKCODFM<LKLEMFFHJIK>
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class MCKOBCDMDFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public PGIBBEBOIMI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public MCKOBCDMDFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x250F400", Offset = "0x250E200", VA = "0x18250F400")]
			internal bool CAANMBFDHPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x250F450", Offset = "0x250E250", VA = "0x18250F450")]
			internal void IACEHAAHBGB(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x251BA60", Offset = "0x251A860", VA = "0x18251BA60")]
		public PGIBBEBOIMI(CCBLBBOJEHP PJMKKGHIHNK, LKLEMFFHJIK MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x251B7C0", Offset = "0x251A5C0", VA = "0x18251B7C0", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class PCFPPCALLPJ : NNFAAKCODFM<HADEBKEKNPL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class NKPPFGGLMIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public PCFPPCALLPJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public NKPPFGGLMIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x2510830", Offset = "0x250F630", VA = "0x182510830")]
			internal object CAANMBFDHPP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x2510F40", Offset = "0x250FD40", VA = "0x182510F40")]
			internal bool PANBDAODOHN(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x2510CF0", Offset = "0x250FAF0", VA = "0x182510CF0")]
			internal void IACEHAAHBGB(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x2510A80", Offset = "0x250F880", VA = "0x182510A80")]
			internal string FICPJHOPJNL(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x2510C30", Offset = "0x250FA30", VA = "0x182510C30")]
			internal IReadOnlyList<object> HBEKIGJINMD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x2510C80", Offset = "0x250FA80", VA = "0x182510C80")]
			internal bool HCHKECBOOJO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x2510BE0", Offset = "0x250F9E0", VA = "0x182510BE0")]
			internal bool GBFCLBDJBEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x2510960", Offset = "0x250F760", VA = "0x182510960")]
			internal void EBFBKKCLIEA(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x251B750", Offset = "0x251A550", VA = "0x18251B750")]
		public PCFPPCALLPJ(CCBLBBOJEHP PJMKKGHIHNK, HADEBKEKNPL MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x251AF50", Offset = "0x2519D50", VA = "0x18251AF50", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class CLNBPOIEFOK : LCBOKNDKMKF<GMGOFKBNKCC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xC548E0", Offset = "0xC536E0", VA = "0x180C548E0", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x2500D20", Offset = "0x24FFB20", VA = "0x182500D20")]
		public CLNBPOIEFOK(CCBLBBOJEHP PJMKKGHIHNK, GMGOFKBNKCC KFDHCNOCENN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public sealed class MOEHDNLOMGI : EAANAENFOMH<DECKHAAELLO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		[CompilerGenerated]
		private sealed class EEGIEIHDNFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public MOEHDNLOMGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public EEGIEIHDNFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x2508590", Offset = "0x2507390", VA = "0x182508590")]
			internal int KHCIIFNHCAO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x25084F0", Offset = "0x25072F0", VA = "0x1825084F0")]
			internal void ECPOANACEOO(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x25100B0", Offset = "0x250EEB0", VA = "0x1825100B0")]
		public MOEHDNLOMGI(CCBLBBOJEHP PJMKKGHIHNK, DECKHAAELLO MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x250FDB0", Offset = "0x250EBB0", VA = "0x18250FDB0", Slot = "129")]
		protected override void LHHEJOEFICA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public sealed class OKJKIGPHCFM : NNFAAKCODFM<GENHELJCAIO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class DLFMFNJNMKC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public OKJKIGPHCFM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public DLFMFNJNMKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x2508030", Offset = "0x2506E30", VA = "0x182508030")]
			internal bool CAANMBFDHPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x2508080", Offset = "0x2506E80", VA = "0x182508080")]
			internal void IACEHAAHBGB(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x251A5B0", Offset = "0x25193B0", VA = "0x18251A5B0")]
		public OKJKIGPHCFM(CCBLBBOJEHP PJMKKGHIHNK, GENHELJCAIO MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x251A3D0", Offset = "0x25191D0", VA = "0x18251A3D0", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class MKHFPDAEHKA : NNFAAKCODFM<HOHLIBNKIBH>
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class MLHPCCADANG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public MKHFPDAEHKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public MLHPCCADANG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x250F820", Offset = "0x250E620", VA = "0x18250F820")]
			internal bool CAANMBFDHPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x250F870", Offset = "0x250E670", VA = "0x18250F870")]
			internal void IACEHAAHBGB(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x250F7B0", Offset = "0x250E5B0", VA = "0x18250F7B0")]
		public MKHFPDAEHKA(CCBLBBOJEHP PJMKKGHIHNK, HOHLIBNKIBH MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x250F5D0", Offset = "0x250E3D0", VA = "0x18250F5D0", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class BJBGKAKKNNP : NNFAAKCODFM<BMKKJNAHKOD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class NFDMPPFBBMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public BJBGKAKKNNP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public NFDMPPFBBMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x2510130", Offset = "0x250EF30", VA = "0x182510130")]
			internal int CAANMBFDHPP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x2510180", Offset = "0x250EF80", VA = "0x182510180")]
			internal void IACEHAAHBGB(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x24FFF60", Offset = "0x24FED60", VA = "0x1824FFF60")]
		public BJBGKAKKNNP(CCBLBBOJEHP PJMKKGHIHNK, BMKKJNAHKOD MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x24FFCF0", Offset = "0x24FEAF0", VA = "0x1824FFCF0", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public sealed class PBMJNCCGKGB : IBAMBBCAPKB<PEEHLCIPEOG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override AIPMJMOHJNA FOBLGJOFPCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0xA9F400", Offset = "0xA9E200", VA = "0x180A9F400", Slot = "129")]
			get
			{
				return default(AIPMJMOHJNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x251AEF0", Offset = "0x2519CF0", VA = "0x18251AEF0")]
		public PBMJNCCGKGB(CCBLBBOJEHP PJMKKGHIHNK, PEEHLCIPEOG MNCBDJMAFIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public class IJDLMKCBHKF : NNFAAKCODFM<IMCHGLPNCJE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x250CC90", Offset = "0x250BA90", VA = "0x18250CC90")]
		public IJDLMKCBHKF(CCBLBBOJEHP PJMKKGHIHNK, IMCHGLPNCJE KFDHCNOCENN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public abstract class NNFAAKCODFM<TNode> : AEBHIPCIKGL, IDisposable where TNode : notnull, IMCHGLPNCJE
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class FKDMHFJDPPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public NNFAAKCODFM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public CCBLBBOJEHP circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public FKDMHFJDPPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x43C8080", Offset = "0x43C6E80", VA = "0x1843C8080")]
			internal NPIMDGBIJLL DIEKGFEOAAH(DBKJOMHNNFA portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private struct EOPDFKEJFGB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public NNFAAKCODFM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x40072F0", Offset = "0x40060F0", VA = "0x1840072F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private struct LLOKHCLODPK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public NNFAAKCODFM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public NFJHFHNDCLG? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public GGLODEGCHGH? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x4AAA8D0", Offset = "0x4AA96D0", VA = "0x184AAA8D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x4AAAB70", Offset = "0x4AA9970", VA = "0x184AAAB70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class JPIGDBCOIAN
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
				public JPIGDBCOIAN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001C5")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60003A0")]
				[Cpp2IlInjected.Address(RVA = "0x3C59800", Offset = "0x3C58600", VA = "0x183C59800", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003A1")]
				[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
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
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public NNFAAKCODFM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001BF")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			public FEMHNCEEGDK configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public JPIGDBCOIAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
			internal string ODBBDMOAIFD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
			internal void PNKOHLHHDKC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x48F22C0", Offset = "0x48F10C0", VA = "0x1848F22C0")]
			[AsyncStateMachine(typeof(NNFAAKCODFM<>.JPIGDBCOIAN.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void IOLFLPFJLJK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private sealed class BHDJPAHKCII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public BHDJPAHKCII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x566FC20", Offset = "0x566EA20", VA = "0x18566FC20")]
			internal bool BJMJJMJPDLM(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x566FD00", Offset = "0x566EB00", VA = "0x18566FD00")]
			internal bool OOJLIHAIHAL(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private struct EOCFMCPFHCD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			public NNFAAKCODFM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x4004530", Offset = "0x4003330", VA = "0x184004530", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x4004830", Offset = "0x4003630", VA = "0x184004830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private readonly CCBLBBOJEHP APNMNKMKKDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private readonly bool CDAOHFBBAJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private BANIPINFFJB<ECCLNDBJNAE, NPIMDGBIJLL> KIEOMPJODIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private BANIPINFFJB<ECCLNDBJNAE, DMICOAPJLHF> AANBFACDGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private List<Action> PGIBAJDPICI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[CompilerGenerated]
		private Action<MMBOLDIBAHF<ECCLNDBJNAE>>? OOIKBGCAPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[CompilerGenerated]
		private Action<MMBOLDIBAHF<ECCLNDBJNAE>, DMICOAPJLHF>? DNBCFPDKKLP;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected EDALADINGLF NGAKKNODBIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x4D334B0", Offset = "0x4D322B0", VA = "0x184D334B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		protected FFFFJNHDCCA MCPLDBNPPMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x4D32DB0", Offset = "0x4D31BB0", VA = "0x184D32DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		protected TNode LGBGIDGFLIP
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public HFJNFIGGNLC<MIEFPPNINJG> MDJDBCOFJGB
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x11807B0", Offset = "0x117F5B0", VA = "0x1811807B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(HFJNFIGGNLC<MIEFPPNINJG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public MMBOLDIBAHF<DGKHNPEDJKJ> MCLEGJALKFG
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x4D384D0", Offset = "0x4D372D0", VA = "0x184D384D0", Slot = "6")]
			get
			{
				return default(MMBOLDIBAHF<DGKHNPEDJKJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public object DACMFKEKGIK
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x4052240", Offset = "0x4051040", VA = "0x184052240", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual bool HCDGNHMEPIK
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public int AMMOEPOKKMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x4D38130", Offset = "0x4D36F30", VA = "0x184D38130", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public CGBHHFFMFPE DHKEDNOLDII
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x4D380D0", Offset = "0x4D36ED0", VA = "0x184D380D0", Slot = "10")]
			get
			{
				return default(CGBHHFFMFPE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public string MPFNPJDPKCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x4D386D0", Offset = "0x4D374D0", VA = "0x184D386D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected virtual bool NPPJAJKFDIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public MMBOLDIBAHF<CFIPDELBCCO> ELJCLKLOHIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0xCFF1D0", Offset = "0xCFDFD0", VA = "0x180CFF1D0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(MMBOLDIBAHF<CFIPDELBCCO>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xCFF220", Offset = "0xCFE020", VA = "0x180CFF220")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool GKFGKLHEIBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual bool KFMBDNDGHBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "96")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual LKCBOCANPIJ PALIHOBGCDD
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xDD70F0", Offset = "0xDD5EF0", VA = "0x180DD70F0", Slot = "97")]
			get
			{
				return default(LKCBOCANPIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool OHNJCEAMOHK
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x4D37E40", Offset = "0x4D36C40", VA = "0x184D37E40", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public bool AALJKKKIKOD
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x4D37EA0", Offset = "0x4D36CA0", VA = "0x184D37EA0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool IGFMKBGBJPO
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x4D37F00", Offset = "0x4D36D00", VA = "0x184D37F00", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int FDCJBLOCNLF
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x4D38480", Offset = "0x4D37280", VA = "0x184D38480", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool ALMKIEEOCBB
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x4D382B0", Offset = "0x4D370B0", VA = "0x184D382B0", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool GGKOCODFKCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x4D38010", Offset = "0x4D36E10", VA = "0x184D38010", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool MNIFGPNLAEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x4D37FB0", Offset = "0x4D36DB0", VA = "0x184D37FB0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool PIKJGFHKPPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0xD9EE00", Offset = "0xD9DC00", VA = "0x180D9EE00", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x116CE60", Offset = "0x116BC60", VA = "0x18116CE60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool JBBKCOCMHEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "98")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual bool DBMGDJKKIGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x4D37F60", Offset = "0x4D36D60", VA = "0x184D37F60", Slot = "99")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool DJJEBDBALMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x4D381E0", Offset = "0x4D36FE0", VA = "0x184D381E0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public NFJHFHNDCLG CIIGPNLPGEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x4D383C0", Offset = "0x4D371C0", VA = "0x184D383C0", Slot = "28")]
			get
			{
				return default(NFJHFHNDCLG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public GGLODEGCHGH FDIJLBLBDEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x4D38420", Offset = "0x4D37220", VA = "0x184D38420", Slot = "30")]
			get
			{
				return default(GGLODEGCHGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool CMMJJEHEDFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "111")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual COHMEGBDNHO? FGBAMGEJHHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "112")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual ELMHDOGAIGE? JMJBCMIBKBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public virtual IEnumerable<HFJNFIGGNLC<AHIDBKDCADN>>? IAONIMKHEEI
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool CPMGPIMIBOE
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x4D38070", Offset = "0x4D36E70", VA = "0x184D38070", Slot = "117")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x4D38300", Offset = "0x4D37100", VA = "0x184D38300", Slot = "62")]
			get
			{
				return default(HFJNFIGGNLC<CHMLMGCOLME>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x4D38180", Offset = "0x4D36F80", VA = "0x184D38180", Slot = "56")]
			get
			{
				return default(MMBOLDIBAHF<CHMLMGCOLME>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual bool DLACEHHEADG
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "118")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual MMBOLDIBAHF<CHMLMGCOLME>? DNLBFIDHOBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "119")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public virtual bool PLPDNNOCDAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool HDHEGFFGPBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x4D38240", Offset = "0x4D37040", VA = "0x184D38240", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string HIGBIGGFHEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x8FC440", Offset = "0x8FB240", VA = "0x1808FC440", Slot = "65")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x8FC390", Offset = "0x8FB190", VA = "0x1808FC390")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public string PKJNADEJNIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x8FC450", Offset = "0x8FB250", VA = "0x1808FC450", Slot = "66")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x8FC3E0", Offset = "0x8FB1E0", VA = "0x1808FC3E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public MMBOLDIBAHF<AHIDBKDCADN> LEGOCGBKEJK
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x4D38550", Offset = "0x4D37350", VA = "0x184D38550", Slot = "63")]
			get
			{
				return default(MMBOLDIBAHF<AHIDBKDCADN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x4D38360", Offset = "0x4D37160", VA = "0x184D38360", Slot = "64")]
			get
			{
				return default(HFJNFIGGNLC<AHIDBKDCADN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public HFJNFIGGNLC<AHIDBKDCADN>? LAOALMNCMKG
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x4D385B0", Offset = "0x4D373B0", VA = "0x184D385B0", Slot = "121")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public AMNAKHMFIGM<ECCLNDBJNAE, DMICOAPJLHF> BGPDHEAEIOO
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x4D38690", Offset = "0x4D37490", VA = "0x184D38690", Slot = "67")]
			get
			{
				return default(AMNAKHMFIGM<ECCLNDBJNAE, DMICOAPJLHF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public virtual MMBOLDIBAHF<ECCLNDBJNAE>? JCNPIIKINAM
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "122")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public virtual bool MGCBJJEFHCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "125")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public virtual bool FFJDOKIFPOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "126")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action AKOHPKHOFMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x4D34DB0", Offset = "0x4D33BB0", VA = "0x184D34DB0", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x4D36A30", Offset = "0x4D35830", VA = "0x184D36A30", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event HKDIIGLBIGC OJHMEDCFGCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x4D36DB0", Offset = "0x4D35BB0", VA = "0x184D36DB0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x4D37660", Offset = "0x4D36460", VA = "0x184D37660", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event NDKNNIOJFFN NBCPJMMCDLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x4D34E50", Offset = "0x4D33C50", VA = "0x184D34E50", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x4D37560", Offset = "0x4D36360", VA = "0x184D37560", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action MEOCHBMMELO
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x4D36FA0", Offset = "0x4D35DA0", VA = "0x184D36FA0", Slot = "43")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x4D37600", Offset = "0x4D36400", VA = "0x184D37600", Slot = "44")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action KFKLDLDIIFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x4D34B30", Offset = "0x4D33930", VA = "0x184D34B30", Slot = "45")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x4D377D0", Offset = "0x4D365D0", VA = "0x184D377D0", Slot = "46")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<MMBOLDIBAHF<ECCLNDBJNAE>, DMICOAPJLHF> NPGELGGPIHG
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x4D37180", Offset = "0x4D35F80", VA = "0x184D37180", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x4D32E90", Offset = "0x4D31C90", VA = "0x184D32E90", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<MMBOLDIBAHF<ECCLNDBJNAE>, DMICOAPJLHF> OKCJEEJABIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x4D34F30", Offset = "0x4D33D30", VA = "0x184D34F30", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x4D34A70", Offset = "0x4D33870", VA = "0x184D34A70", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<MMBOLDIBAHF<ECCLNDBJNAE>> PHBMMBKAGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x4D32F50", Offset = "0x4D31D50", VA = "0x184D32F50", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x4D33580", Offset = "0x4D32380", VA = "0x184D33580", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<MMBOLDIBAHF<ECCLNDBJNAE>, MMBOLDIBAHF<ECCLNDBJNAE>> FMCKFCOEIAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x4D36970", Offset = "0x4D35770", VA = "0x184D36970", Slot = "75")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x4D370C0", Offset = "0x4D35EC0", VA = "0x184D370C0", Slot = "76")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<MMBOLDIBAHF<ECCLNDBJNAE>, DMICOAPJLHF> AFNFBBIMFFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x4D34FF0", Offset = "0x4D33DF0", VA = "0x184D34FF0", Slot = "77")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x4D37000", Offset = "0x4D35E00", VA = "0x184D37000", Slot = "78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<MMBOLDIBAHF<ECCLNDBJNAE>, MMBOLDIBAHF<ECCLNDBJNAE>> IDCFHDLMGOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x4D34770", Offset = "0x4D33570", VA = "0x184D34770", Slot = "79")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x4D33640", Offset = "0x4D32440", VA = "0x184D33640", Slot = "80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x4D37870", Offset = "0x4D36670", VA = "0x184D37870")]
		[OLBEHBOLMGB("Need to handle `Name` better.")]
		[OLBEHBOLMGB("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		protected NNFAAKCODFM(CCBLBBOJEHP PJMKKGHIHNK, TNode KFDHCNOCENN, bool ELBKHDGKKCC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x4D360B0", Offset = "0x4D34EB0", VA = "0x184D360B0", Slot = "90")]
		protected virtual void JEELJGCJJCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x4D33D40", Offset = "0x4D32B40", VA = "0x184D33D40", Slot = "91")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x4D367D0", Offset = "0x4D355D0", VA = "0x184D367D0", Slot = "9")]
		[AsyncStateMachine(typeof(NNFAAKCODFM<>.EOPDFKEJFGB))]
		public void JIMDDFOICKD(int ILBEDDAMMEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x4D33030", Offset = "0x4D31E30", VA = "0x184D33030")]
		public bool AMOKKIFGFAC([In] NFJHFHNDCLG IPHILEOFJLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x4D33510", Offset = "0x4D32310", VA = "0x184D33510")]
		public bool BGLGBHBGMFH([In] GGLODEGCHGH IPHILEOFJLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x4D36BB0", Offset = "0x4D359B0", VA = "0x184D36BB0", Slot = "32")]
		public void MKHDKIMHGAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x4D372B0", Offset = "0x4D360B0", VA = "0x184D372B0", Slot = "33")]
		[AsyncStateMachine(typeof(NNFAAKCODFM<>.LLOKHCLODPK))]
		public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> OIADKLIDBGJ(NFJHFHNDCLG? PFKOKOAMOAJ, GGLODEGCHGH? ACJIHPAJKOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "100")]
		public virtual void BFOJOPEDEFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "101")]
		public virtual void EOLBFHKMKEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "102")]
		public virtual void OPCKDKNLFBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0xD60D70", Offset = "0xD5FB70", VA = "0x180D60D70")]
		protected void KNJEOFMLIBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xDD0370", Offset = "0xDCF170", VA = "0x180DD0370")]
		protected void FLKDMCKGDJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x274A800", Offset = "0x2749600", VA = "0x18274A800")]
		private void DJLMIFJMCNI([In] GGLODEGCHGH CKABIAOPKPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x4D37700", Offset = "0x4D36500", VA = "0x184D37700", Slot = "103")]
		public virtual Task<PGOLMGNGGBM<MMBOLDIBAHF<ECCLNDBJNAE>, HJBBDBHAMJJ>> PKNMOHDNCIB(string PPKJBGAOBJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x4D37490", Offset = "0x4D36290", VA = "0x184D37490", Slot = "104")]
		public virtual Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> OMJDLKCPKGJ(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "105")]
		public virtual void PKMNOBNOHDH(MMBOLDIBAHF<ECCLNDBJNAE> PIKNBAHHMKC, MMBOLDIBAHF<ECCLNDBJNAE> IDBMFGJEIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x4D37400", Offset = "0x4D36200", VA = "0x184D37400", Slot = "106")]
		public virtual IEnumerable<EAAKFALPLDL> OLMAHLJEBEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x4D33700", Offset = "0x4D32500", VA = "0x184D33700", Slot = "107")]
		public PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ> BPIGJBJCOLO(string IEIADNFCLID)
		{
			return default(PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x4D34920", Offset = "0x4D33720", VA = "0x184D34920", Slot = "47")]
		public bool FKBOIHCEMHO([Out] Guid DBNKGFDNLJG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x4D338F0", Offset = "0x4D326F0", VA = "0x184D338F0")]
		public bool CBJCDADNKDD([In] Guid FDFKGMJMPMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "108")]
		public virtual void GCNCDDFOOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "109")]
		public virtual void BPPJNHDMFFD(bool HEIKJGPDHLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "110")]
		public virtual ODIPPCJINFJ FFEOGOILINP([In] CDKPLBELCPA ABNMGDINBMB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x4D34BD0", Offset = "0x4D339D0", VA = "0x184D34BD0")]
		protected void GGJCOLPBFGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x4D36AD0", Offset = "0x4D358D0", VA = "0x184D36AD0", Slot = "115")]
		protected virtual bool LFOIGPCKOPP(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x4D32D80", Offset = "0x4D31B80", VA = "0x184D32D80", Slot = "88")]
		public bool AAPOPAFABNP(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "116")]
		protected virtual bool LBENFNFJLHN(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "123")]
		protected virtual void EPNLPCMFILA(FEMHNCEEGDK NJLHPMCODEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x4D35100", Offset = "0x4D33F00", VA = "0x184D35100")]
		protected void HOLHBFENHHJ(FEMHNCEEGDK GHICFAOGDGG, Func<string> OAJFONFNPGI, Action<string> EKIIAFBBHFN, string BBAPHJINAGP, string EHPKIEIKEKD, string GMEPMGBEBIO, JOKNEJGFDBO KNFAICCMDII, KLCBIKGIGOO PPGGDCDMPCA, Func<string, bool> DGEPOGFEOCG, string EMLIKCBGBDO, Func<string, bool> NGABEPHPICN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x4D35A30", Offset = "0x4D34830", VA = "0x184D35A30")]
		protected void IHOLCIOBABB(FEMHNCEEGDK GHICFAOGDGG, Func<string> OAJFONFNPGI, Action<string> EKIIAFBBHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x4D345C0", Offset = "0x4D333C0", VA = "0x184D345C0", Slot = "124")]
		protected virtual void EKAIPIOAPML(FEMHNCEEGDK GHICFAOGDGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x4D350B0", Offset = "0x4D33EB0", VA = "0x184D350B0", Slot = "82")]
		public void HKKPEPHODEO(FEMHNCEEGDK GHICFAOGDGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x4D34830", Offset = "0x4D33630", VA = "0x184D34830", Slot = "83")]
		public JGEIPOFGAHI FALIBOMGDKK()
		{
			return default(JGEIPOFGAHI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "127")]
		public virtual bool IOENKGHIAHL(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x1CFF230", Offset = "0x1CFE030", VA = "0x181CFF230")]
		private void ODCDDNKDOFL([In] NFJHFHNDCLG AKEODPFBHJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x4D36E50", Offset = "0x4D35C50", VA = "0x184D36E50")]
		private void MPDMNEPGCFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x4D354F0", Offset = "0x4D342F0", VA = "0x184D354F0")]
		private void ICGBBNDJHGG(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, DBKJOMHNNFA ELCKGFMBOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0xEF2BF0", Offset = "0xEF19F0", VA = "0x180EF2BF0")]
		private void KMHEOEPPDHO(MMBOLDIBAHF<ECCLNDBJNAE> MIFPCBFGGLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x4D33C10", Offset = "0x4D32A10", VA = "0x184D33C10")]
		private void DIIKHFNLHAC(MMBOLDIBAHF<ECCLNDBJNAE> MIFPCBFGGLI, DBKJOMHNNFA BELJKDDFOOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x4D35D10", Offset = "0x4D34B10", VA = "0x184D35D10")]
		private void IMJOKMFNOOM(MMBOLDIBAHF<ECCLNDBJNAE> PIKNBAHHMKC, MMBOLDIBAHF<ECCLNDBJNAE> IDBMFGJEIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0xEF14B0", Offset = "0xEF02B0", VA = "0x180EF14B0")]
		private void MKHJLMFMCMH(MMBOLDIBAHF<ECCLNDBJNAE> PIKNBAHHMKC, MMBOLDIBAHF<ECCLNDBJNAE> IDBMFGJEIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x4D33010", Offset = "0x4D31E10", VA = "0x184D33010")]
		private void AJPHMNDNBPA(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x4D330A0", Offset = "0x4D31EA0", VA = "0x184D330A0")]
		private void BBMNPIGNHHD(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, DBKJOMHNNFA ELCKGFMBOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x4D36900", Offset = "0x4D35700", VA = "0x184D36900")]
		private void KGAAJBKFBKA(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, DBKJOMHNNFA BELJKDDFOOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x4D337D0", Offset = "0x4D325D0", VA = "0x184D337D0", Slot = "128")]
		[AsyncStateMachine(typeof(NNFAAKCODFM<>.EOCFMCPFHCD))]
		public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> CANHAMGAAOC(string IEIADNFCLID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x4D33BA0", Offset = "0x4D329A0", VA = "0x184D33BA0", Slot = "54")]
		private void DBNCFONBGJG(object DDMGKJODKDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x4D37240", Offset = "0x4D36040", VA = "0x184D37240", Slot = "55")]
		private void OFLMOPCOAOK(object DDMGKJODKDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x4D34EF0", Offset = "0x4D33CF0", VA = "0x184D34EF0", Slot = "29")]
		private bool GMGPGIPGNAF([In] NFJHFHNDCLG IPHILEOFJLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x4D368C0", Offset = "0x4D356C0", VA = "0x184D368C0", Slot = "31")]
		private bool KCAENKGFJJM([In] GGLODEGCHGH IPHILEOFJLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x4D33790", Offset = "0x4D32590", VA = "0x184D33790", Slot = "48")]
		private bool CAEHADIKHPJ([In] Guid FDFKGMJMPMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x4D36880", Offset = "0x4D35680", VA = "0x184D36880")]
		[CompilerGenerated]
		private string JOMMNLFEBEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x4D36B10", Offset = "0x4D35910", VA = "0x184D36B10")]
		[CompilerGenerated]
		private void MGOKEAKJEFF(string PPKJBGAOBJL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public sealed class IEFPKJBNGGF : LCBOKNDKMKF<NDBPGJBKIBL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xC1EAB0", Offset = "0xC1D8B0", VA = "0x180C1EAB0", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x250C020", Offset = "0x250AE20", VA = "0x18250C020")]
		public IEFPKJBNGGF(CCBLBBOJEHP PJMKKGHIHNK, NDBPGJBKIBL KFDHCNOCENN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	private sealed class KLKKHHMKNLI : GFFGOMGMOHA<IBBBFOKNBFI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xA9F400", Offset = "0xA9E200", VA = "0x180A9F400", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x250E5E0", Offset = "0x250D3E0", VA = "0x18250E5E0")]
		public KLKKHHMKNLI(CCBLBBOJEHP PJMKKGHIHNK, IBBBFOKNBFI KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public abstract class IBAMBBCAPKB<T> : NNFAAKCODFM<T> where T : notnull, LCJKGJGJJBP
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class GLBHOADADJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public IReadOnlyList<KeyValuePair<string, NNDGLBEAKFC>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public IBAMBBCAPKB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public AIPMJMOHJNA clipType;

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public GLBHOADADJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
			internal IReadOnlyList<KeyValuePair<string, NNDGLBEAKFC>> CAANMBFDHPP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x44CB570", Offset = "0x44CA370", VA = "0x1844CB570")]
			internal int IACEHAAHBGB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x44CAFD0", Offset = "0x44C9DD0", VA = "0x1844CAFD0")]
			internal void FICPJHOPJNL(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x44CB3D0", Offset = "0x44CA1D0", VA = "0x1844CB3D0")]
			internal void HBEKIGJINMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x44CB420", Offset = "0x44CA220", VA = "0x1844CB420")]
			internal void HCHKECBOOJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x44CB230", Offset = "0x44CA030", VA = "0x1844CB230")]
			internal bool GBFCLBDJBEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x44CAF80", Offset = "0x44C9D80", VA = "0x1844CAF80")]
			internal void EBFBKKCLIEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x44CB230", Offset = "0x44CA030", VA = "0x1844CB230")]
			internal bool PANBDAODOHN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x44CB2C0", Offset = "0x44CA0C0", VA = "0x1844CB2C0")]
			internal float GKMOBPNMLEI()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x44CB6C0", Offset = "0x44CA4C0", VA = "0x1844CB6C0")]
			internal void LBHLAPMHJKF(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x44CB1E0", Offset = "0x44C9FE0", VA = "0x1844CB1E0")]
			internal float FPOFLDHCJIA()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x44CB7D0", Offset = "0x44CA5D0", VA = "0x1844CB7D0")]
			internal void PJCBOGGFNCD(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x44CB780", Offset = "0x44CA580", VA = "0x1844CB780")]
			internal float OKLHAHOHBPO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x44CB310", Offset = "0x44CA110", VA = "0x1844CB310")]
			internal void HBDLCLKIKKB(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0xEEE680", Offset = "0xEED480", VA = "0x180EEE680", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public abstract AIPMJMOHJNA FOBLGJOFPCF
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(Slot = "129")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x449F910", Offset = "0x449E710", VA = "0x18449F910")]
		public IBAMBBCAPKB(CCBLBBOJEHP PJMKKGHIHNK, T KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x46C95B0", Offset = "0x46C83B0", VA = "0x1846C95B0", Slot = "123")]
		protected sealed override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private sealed class PKOJJEBFNFO : NNFAAKCODFM<HJFOCEBBKBC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xC1EFA0", Offset = "0xC1DDA0", VA = "0x180C1EFA0", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x251BAD0", Offset = "0x251A8D0", VA = "0x18251BAD0")]
		public PKOJJEBFNFO(CCBLBBOJEHP PJMKKGHIHNK, HJFOCEBBKBC KFDHCNOCENN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public sealed class BPHPGPIDMAK : NNFAAKCODFM<NIKNJKGCOAB>
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class EDJPCIFLJGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public BPHPGPIDMAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public EDJPCIFLJGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x25084A0", Offset = "0x25072A0", VA = "0x1825084A0")]
			internal int IACEHAAHBGB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x2508410", Offset = "0x2507210", VA = "0x182508410")]
			internal void FICPJHOPJNL(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private static Dictionary<string, NNDGLBEAKFC>? HIELGIKEDKF;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x25007D0", Offset = "0x24FF5D0", VA = "0x1825007D0")]
		public BPHPGPIDMAK(CCBLBBOJEHP PJMKKGHIHNK, NIKNJKGCOAB KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x2500440", Offset = "0x24FF240", VA = "0x182500440", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class MADMPACOOFN : IBAMBBCAPKB<IIPNBHIKBCI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public override AIPMJMOHJNA FOBLGJOFPCF
		{
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "129")]
			get
			{
				return default(AIPMJMOHJNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x250F3A0", Offset = "0x250E1A0", VA = "0x18250F3A0")]
		public MADMPACOOFN(CCBLBBOJEHP PJMKKGHIHNK, IIPNBHIKBCI MNCBDJMAFIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private sealed class OGLMEDCMBJF : GFFGOMGMOHA<FCJAJLNDFNB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0xA9F400", Offset = "0xA9E200", VA = "0x180A9F400", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x251A030", Offset = "0x2518E30", VA = "0x18251A030")]
		public OGLMEDCMBJF(CCBLBBOJEHP PJMKKGHIHNK, FCJAJLNDFNB KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	private sealed class MGCIIMDLLIG : GFFGOMGMOHA<KHGEAHHJFHL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0xA9F400", Offset = "0xA9E200", VA = "0x180A9F400", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x250F570", Offset = "0x250E370", VA = "0x18250F570")]
		public MGCIIMDLLIG(CCBLBBOJEHP PJMKKGHIHNK, KHGEAHHJFHL KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public sealed class OHHJPHPADKL : EAANAENFOMH<BNJKOAJAAHG>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		[CompilerGenerated]
		private sealed class OAJPNHMMIOC
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
				public OAJPNHMMIOC <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001DC")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001DD")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001DE")]
				private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60003D5")]
				[Cpp2IlInjected.Address(RVA = "0x251BB40", Offset = "0x251A940", VA = "0x18251BB40", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D6")]
				[Cpp2IlInjected.Address(RVA = "0x94B390", Offset = "0x94A190", VA = "0x18094B390", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public OHHJPHPADKL <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public OAJPNHMMIOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x2517270", Offset = "0x2516070", VA = "0x182517270")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void KHCIIFNHCAO(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x251A370", Offset = "0x2519170", VA = "0x18251A370")]
		public OHHJPHPADKL(CCBLBBOJEHP PJMKKGHIHNK, BNJKOAJAAHG MNCBDJMAFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x251A090", Offset = "0x2518E90", VA = "0x18251A090", Slot = "129")]
		protected override void LHHEJOEFICA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public sealed class ABKMMAJHEMD : IBAMBBCAPKB<ENOHFPEMPHM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override AIPMJMOHJNA FOBLGJOFPCF
		{
			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0xA68120", Offset = "0xA66F20", VA = "0x180A68120", Slot = "129")]
			get
			{
				return default(AIPMJMOHJNA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x24FF0E0", Offset = "0x24FDEE0", VA = "0x1824FF0E0")]
		public ABKMMAJHEMD(CCBLBBOJEHP PJMKKGHIHNK, ENOHFPEMPHM MNCBDJMAFIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	private sealed class JDCACNHJNLI : NNFAAKCODFM<NOBADCFOKPF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0xC231D0", Offset = "0xC21FD0", VA = "0x180C231D0", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x250CD00", Offset = "0x250BB00", VA = "0x18250CD00")]
		public JDCACNHJNLI(CCBLBBOJEHP PJMKKGHIHNK, NOBADCFOKPF KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public sealed class FCGEDOAOAKF : NNFAAKCODFM<JPJGPHFELJC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public sealed override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public sealed override bool GKFGKLHEIBP
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected sealed override bool NPPJAJKFDIB
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "93")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x25092E0", Offset = "0x25080E0", VA = "0x1825092E0")]
		public FCGEDOAOAKF(CCBLBBOJEHP PJMKKGHIHNK, JPJGPHFELJC KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x2508F70", Offset = "0x2507D70", VA = "0x182508F70", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x25092A0", Offset = "0x25080A0", VA = "0x1825092A0")]
		private int NAEPGIMABCC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x2509240", Offset = "0x2508040", VA = "0x182509240")]
		private void FCMABMIBLIK(int LJGAMICHBPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class MAIKLAKGBNE : IJDLMKCBHKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x250CC90", Offset = "0x250BA90", VA = "0x18250CC90")]
		public MAIKLAKGBNE(CCBLBBOJEHP PJMKKGHIHNK, IMCHGLPNCJE KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class GGJGAGONADM : EAANAENFOMH<PPIBJCJBKEK>
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x250AA10", Offset = "0x2509810", VA = "0x18250AA10")]
		public GGJGAGONADM(CCBLBBOJEHP PJMKKGHIHNK, PPIBJCJBKEK KFDHCNOCENN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public abstract class EAANAENFOMH<TVariableNode> : NNFAAKCODFM<TVariableNode> where TVariableNode : notnull, PPIBJCJBKEK
	{
		[Cpp2IlInjected.Token(Token = "0x20000A8")]
		[CompilerGenerated]
		private sealed class EHCCCCPHJDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public EAANAENFOMH<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public EHCCCCPHJDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x3FE0AC0", Offset = "0x3FDF8C0", VA = "0x183FE0AC0")]
			internal bool CAANMBFDHPP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x3FE0CF0", Offset = "0x3FDFAF0", VA = "0x183FE0CF0")]
			internal void IACEHAAHBGB(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x3FE0B20", Offset = "0x3FDF920", VA = "0x183FE0B20")]
			internal bool FICPJHOPJNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x3FE0B80", Offset = "0x3FDF980", VA = "0x183FE0B80")]
			internal void HBEKIGJINMD(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x3FE0C40", Offset = "0x3FDFA40", VA = "0x183FE0C40")]
			internal bool HCHKECBOOJO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A9")]
		[CompilerGenerated]
		private sealed class IEAOIEGPHAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public FFFFJNHDCCA nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public EAANAENFOMH<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public IEAOIEGPHAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x46D4C00", Offset = "0x46D3A00", VA = "0x1846D4C00")]
			internal void KHCIIFNHCAO(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public override NodeVisualizationKey HDKBAJIDJIH
		{
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0xAA4740", Offset = "0xAA3540", VA = "0x180AA4740", Slot = "94")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public override LKCBOCANPIJ PALIHOBGCDD
		{
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x3F5E920", Offset = "0x3F5D720", VA = "0x183F5E920", Slot = "97")]
			get
			{
				return default(LKCBOCANPIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E780", Offset = "0x3F5D580", VA = "0x183F5E780")]
		protected EAANAENFOMH(CCBLBBOJEHP PJMKKGHIHNK, TVariableNode KFDHCNOCENN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x3F5DD00", Offset = "0x3F5CB00", VA = "0x183F5DD00", Slot = "91")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x3F5DE80", Offset = "0x3F5CC80", VA = "0x183F5DE80", Slot = "123")]
		protected override void EPNLPCMFILA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E400", Offset = "0x3F5D200", VA = "0x183F5E400", Slot = "129")]
		protected virtual void LHHEJOEFICA(FEMHNCEEGDK GHICFAOGDGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E310", Offset = "0x3F5D110", VA = "0x183F5E310", Slot = "108")]
		public override void GCNCDDFOOKM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x24FAAB0", Offset = "0x24F98B0", VA = "0x1824FAAB0")]
	public static AEBHIPCIKGL MKHEJJEDOII(CCBLBBOJEHP PJMKKGHIHNK, IMCHGLPNCJE KFDHCNOCENN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public sealed class LFHJOEFBKHH : KGNFBAIEPDJ, EAKLKILMIHK, AAFLNAOHLKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public MMBOLDIBAHF<BGEDOHJDFGJ> PMENIELMLGB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0xC2A540", Offset = "0xC29340", VA = "0x180C2A540", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(MMBOLDIBAHF<BGEDOHJDFGJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public MMBOLDIBAHF<CJABLIIDPAG> PMLDJNAIIKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0xD0B410", Offset = "0xD0A210", VA = "0x180D0B410", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(MMBOLDIBAHF<CJABLIIDPAG>);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x250E640", Offset = "0x250D440", VA = "0x18250E640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	private MMBOLDIBAHF<BNKJNPHLBPJ> CLCEOIOMNDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0xC17E90", Offset = "0xC16C90", VA = "0x180C17E90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public override MMBOLDIBAHF<PCJFIJFJEGH> CHNHCHMADJF
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x250E650", Offset = "0x250D450", VA = "0x18250E650", Slot = "20")]
		get
		{
			return default(MMBOLDIBAHF<PCJFIJFJEGH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x250E9F0", Offset = "0x250D7F0", VA = "0x18250E9F0")]
	private LFHJOEFBKHH(CCBLBBOJEHP PJMKKGHIHNK, IMCHGLPNCJE KFDHCNOCENN, DFJLNBMMPNE IKJFEGAGJME, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, MMBOLDIBAHF<CJABLIIDPAG> KIIIMMIFGEE, MMBOLDIBAHF<BNKJNPHLBPJ> EHHJINIOJIN, bool NMNJHMHAJDP, string PPKJBGAOBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x250E6A0", Offset = "0x250D4A0", VA = "0x18250E6A0")]
	public static LFHJOEFBKHH MKHEJJEDOII(CCBLBBOJEHP PJMKKGHIHNK, IMCHGLPNCJE KFDHCNOCENN, DFJLNBMMPNE FJMIGJAJOBP, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, MMBOLDIBAHF<BNKJNPHLBPJ> EHHJINIOJIN, MMBOLDIBAHF<CJABLIIDPAG> KIIIMMIFGEE, bool NMNJHMHAJDP, bool ELBKHDGKKCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x250E640", Offset = "0x250D440", VA = "0x18250E640")]
	internal void GILKCCPNKGC(MMBOLDIBAHF<CJABLIIDPAG> IPHILEOFJLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public abstract class KGNFBAIEPDJ : AAFLNAOHLKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	private struct BLKGGJCDHNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private HKJBHDNHDPC? PNNOMPBEJAC;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x2500430", Offset = "0x24FF230", VA = "0x182500430")]
		public void NCEIDOKFHPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x2500390", Offset = "0x24FF190", VA = "0x182500390")]
		public HKJBHDNHDPC CCGOICENFIG(KGNFBAIEPDJ FCIDIPEEHAP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	protected readonly CCBLBBOJEHP APNMNKMKKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	protected readonly IMCHGLPNCJE PCNFINJBBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	private BLKGGJCDHNE ONNMDGOMMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private readonly POHPAKAIMGN HOFJEMHKHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private readonly List<NPNFIKDHGCP> PANIDHADAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private readonly List<DBEIAHHOIEF> FAIMONGHJNJ;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	[OLBEHBOLMGB("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> DJDHOMFABCH
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x250E330", Offset = "0x250D130", VA = "0x18250E330", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public DisplayKind NLPHKHAEOOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x905060", Offset = "0x903E60", VA = "0x180905060", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public MMBOLDIBAHF<CHMLMGCOLME> GIPCNNHCDJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x250D4E0", Offset = "0x250C2E0", VA = "0x18250D4E0", Slot = "6")]
		get
		{
			return default(MMBOLDIBAHF<CHMLMGCOLME>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x250D300", Offset = "0x250C100", VA = "0x18250D300", Slot = "7")]
		get
		{
			return default(HFJNFIGGNLC<CHMLMGCOLME>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public DPADDHBOMHL BCEKCPGBCFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xBF8D90", Offset = "0xBF7B90", VA = "0x180BF8D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public MPCKAHAFFFL AOPBPDNNDJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x250D640", Offset = "0x250C440", VA = "0x18250D640", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	protected HKJBHDNHDPC POKBCJCJKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x250D640", Offset = "0x250C440", VA = "0x18250D640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public PortImage LDIGMJAKOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x250D510", Offset = "0x250C310", VA = "0x18250D510", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x8F41B0", Offset = "0x8F2FB0", VA = "0x1808F41B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x8F4280", Offset = "0x8F3080", VA = "0x1808F4280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x250E170", Offset = "0x250CF70", VA = "0x18250E170", Slot = "9")]
		get
		{
			return default(HFJNFIGGNLC<AHIDBKDCADN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public MMBOLDIBAHF<ECCLNDBJNAE> MALGMNCJMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xBE66A0", Offset = "0xBE54A0", VA = "0x180BE66A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(MMBOLDIBAHF<ECCLNDBJNAE>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0xD0AE90", Offset = "0xD09C90", VA = "0x180D0AE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public abstract MMBOLDIBAHF<PCJFIJFJEGH> CHNHCHMADJF
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x250E480", Offset = "0x250D280", VA = "0x18250E480")]
	protected KGNFBAIEPDJ(CCBLBBOJEHP PJMKKGHIHNK, IMCHGLPNCJE KFDHCNOCENN, POHPAKAIMGN BDPAHNFLHBO, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, bool NMNJHMHAJDP, string PPKJBGAOBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x250DFA0", Offset = "0x250CDA0", VA = "0x18250DFA0", Slot = "21")]
	protected virtual void JEELJGCJJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x250D330", Offset = "0x250C130", VA = "0x18250D330", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x250D0C0", Offset = "0x250BEC0", VA = "0x18250D0C0", Slot = "14")]
	public void AGKELOFIIMF(NPNFIKDHGCP DJDAKCILPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x250D6E0", Offset = "0x250C4E0", VA = "0x18250D6E0", Slot = "15")]
	public void HLAJJHLAMPE(DBEIAHHOIEF DJDAKCILPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x250D740", Offset = "0x250C540", VA = "0x18250D740", Slot = "16")]
	public void HMKBLBECCDK(IOHPNEOGGOI EMNMLJIDJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x250D480", Offset = "0x250C280", VA = "0x18250D480", Slot = "23")]
	protected virtual void EFJNFMIKNDI(IOHPNEOGGOI EMNMLJIDJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x250D120", Offset = "0x250BF20", VA = "0x18250D120")]
	private void AIEJFCMEAEC(bool BHICHJIFLJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x250DDF0", Offset = "0x250CBF0", VA = "0x18250DDF0")]
	private void IEANLKFCPFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x250E190", Offset = "0x250CF90", VA = "0x18250E190")]
	private void OFOOEJCJPOA([In] FCGHFACELGK BLCLLKNOJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x250D2A0", Offset = "0x250C0A0", VA = "0x18250D2A0", Slot = "17")]
	public void BPPEHBKJFKM(NPNFIKDHGCP DJDAKCILPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x250E110", Offset = "0x250CF10", VA = "0x18250E110", Slot = "18")]
	public void MOHIBNHCEHP(DBEIAHHOIEF DJDAKCILPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x8F4280", Offset = "0x8F3080", VA = "0x1808F4280")]
	internal void GCNNLCHOJLH(string PPKJBGAOBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x250E0F0", Offset = "0x250CEF0", VA = "0x18250E0F0")]
	internal void KDMBDJCOCBJ(EKHJGDJBBGL FLOGLGIGMAI, DPADDHBOMHL OBDHBADPJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0xD0AE90", Offset = "0xD09C90", VA = "0x180D0AE90")]
	internal void LEIGLENNNMD(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public sealed class NPIMDGBIJLL : DMICOAPJLHF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class LJNELJOGJBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public CCBLBBOJEHP circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public IMCHGLPNCJE node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public MMBOLDIBAHF<ECCLNDBJNAE> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public LJNELJOGJBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x250F280", Offset = "0x250E080", VA = "0x18250F280")]
		internal LCMGCFILBPM HDODOKLALJE((int PortDescIndex, int PortIndex, GEBCOFGDLNO InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x250F310", Offset = "0x250E110", VA = "0x18250F310")]
		internal LFHJOEFBKHH LELAEHHPHBP(DFJLNBMMPNE i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct LGNFPGBPHHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		public NPIMDGBIJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private MDDBEOAOGLK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x250ECD0", Offset = "0x250DAD0", VA = "0x18250ECD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x250F130", Offset = "0x250DF30", VA = "0x18250F130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct BFDGHENOKGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		public NPIMDGBIJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		public MMBOLDIBAHF<KPGCHBLJMLN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private MDDBEOAOGLK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x24FF930", Offset = "0x24FE730", VA = "0x1824FF930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x24FFC80", Offset = "0x24FEA80", VA = "0x1824FFC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct OLIGDGCMFJC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public NPIMDGBIJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public MMBOLDIBAHF<BNKJNPHLBPJ> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private MDDBEOAOGLK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x251A620", Offset = "0x2519420", VA = "0x18251A620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x251A970", Offset = "0x2519770", VA = "0x18251A970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private struct IDEJAENCFFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public NPIMDGBIJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public MMBOLDIBAHF<KPGCHBLJMLN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public MMBOLDIBAHF<KPGCHBLJMLN> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private MDDBEOAOGLK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x250BC60", Offset = "0x250AA60", VA = "0x18250BC60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x250BFB0", Offset = "0x250ADB0", VA = "0x18250BFB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private struct AJMPDPCABMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public NPIMDGBIJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		public MMBOLDIBAHF<BNKJNPHLBPJ> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		public MMBOLDIBAHF<BNKJNPHLBPJ> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private MDDBEOAOGLK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x24FF140", Offset = "0x24FDF40", VA = "0x1824FF140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x24FF490", Offset = "0x24FE290", VA = "0x1824FF490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct IGADDANAOHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public NPIMDGBIJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private MDDBEOAOGLK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x250C080", Offset = "0x250AE80", VA = "0x18250C080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x250C4F0", Offset = "0x250B2F0", VA = "0x18250C4F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private struct CIPKDBHMKMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public NPIMDGBIJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private MDDBEOAOGLK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x2500840", Offset = "0x24FF640", VA = "0x182500840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x2500B90", Offset = "0x24FF990", VA = "0x182500B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct FLKCHOJJIEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public NPIMDGBIJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public MMBOLDIBAHF<KPGCHBLJMLN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private MDDBEOAOGLK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x250A200", Offset = "0x2509000", VA = "0x18250A200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x250A550", Offset = "0x2509350", VA = "0x18250A550", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct BLFLKBCELKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public NPIMDGBIJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public MMBOLDIBAHF<BNKJNPHLBPJ> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private MDDBEOAOGLK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x24FFFD0", Offset = "0x24FEDD0", VA = "0x1824FFFD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x2500320", Offset = "0x24FF120", VA = "0x182500320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct FDCFBLGKHIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public NPIMDGBIJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public GIOJMNNFGKM type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public MMBOLDIBAHF<KPGCHBLJMLN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private MDDBEOAOGLK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x2509350", Offset = "0x2508150", VA = "0x182509350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x25096E0", Offset = "0x25084E0", VA = "0x1825096E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct PBLHMDIJHMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public NPIMDGBIJLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public GIOJMNNFGKM type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public MMBOLDIBAHF<BNKJNPHLBPJ> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private MDDBEOAOGLK <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x251AAF0", Offset = "0x25198F0", VA = "0x18251AAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x251AE80", Offset = "0x2519C80", VA = "0x18251AE80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private readonly bool ANHFPJBBBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly CCBLBBOJEHP APNMNKMKKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	private readonly bool IBDDJNOJDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	private AMNAKHMFIGM<IPGMDHDLEMN, LCMGCFILBPM> LAEMLNPCEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private AMNAKHMFIGM<IPGMDHDLEMN, BHENDMMDMGJ> ICHNDGPAHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private readonly IMCHGLPNCJE PCNFINJBBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private AMNAKHMFIGM<CJABLIIDPAG, LFHJOEFBKHH> LALAFCGEIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private AMNAKHMFIGM<CJABLIIDPAG, EAKLKILMIHK> BKMHADGBMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private string? LDCPJMMAAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private readonly DBKJOMHNNFA NPMKDFOJEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private MMBOLDIBAHF<ECCLNDBJNAE> KMCOJJJPOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private readonly bool CDAOHFBBAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	[CompilerGenerated]
	private Action? KJMPICBEADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	[CompilerGenerated]
	private Action? IGJAFKFFJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	[CompilerGenerated]
	private Action<MMBOLDIBAHF<IPGMDHDLEMN>>? NIJEGHIPFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	[CompilerGenerated]
	private Action<MMBOLDIBAHF<CJABLIIDPAG>>? GJPLJIIKNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	[CompilerGenerated]
	private DMICOAPJLHF.LOHLFNCDABA? HMOIKLLBGJO;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool BMAEIPPINDP
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2515680", Offset = "0x2514480", VA = "0x182515680", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool ENNGKHIJAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x25141C0", Offset = "0x2512FC0", VA = "0x1825141C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public bool EMBABIOLGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x2511250", Offset = "0x2510050", VA = "0x182511250", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public HFJNFIGGNLC<CHMLMGCOLME> BBCLBNINCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x2511490", Offset = "0x2510290", VA = "0x182511490", Slot = "7")]
		get
		{
			return default(HFJNFIGGNLC<CHMLMGCOLME>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool KKJOCPBNEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x2513FC0", Offset = "0x2512DC0", VA = "0x182513FC0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public AMNAKHMFIGM<IPGMDHDLEMN, BHENDMMDMGJ> NPNHDLGHJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270", Slot = "9")]
		get
		{
			return default(AMNAKHMFIGM<IPGMDHDLEMN, BHENDMMDMGJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x2516E40", Offset = "0x2515C40", VA = "0x182516E40", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public HFJNFIGGNLC<AHIDBKDCADN> EMMMOJIDJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x2516E00", Offset = "0x2515C00", VA = "0x182516E00", Slot = "11")]
		get
		{
			return default(HFJNFIGGNLC<AHIDBKDCADN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public AMNAKHMFIGM<CJABLIIDPAG, EAKLKILMIHK> IEAAMABLIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x8F41B0", Offset = "0x8F2FB0", VA = "0x1808F41B0", Slot = "12")]
		get
		{
			return default(AMNAKHMFIGM<CJABLIIDPAG, EAKLKILMIHK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public MMBOLDIBAHF<ECCLNDBJNAE> MALGMNCJMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0xA75F00", Offset = "0xA74D00", VA = "0x180A75F00", Slot = "13")]
		get
		{
			return default(MMBOLDIBAHF<ECCLNDBJNAE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action POFKEMPACIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x2511CF0", Offset = "0x2510AF0", VA = "0x182511CF0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x2512170", Offset = "0x2510F70", VA = "0x182512170", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action DHALOPOJJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x25114C0", Offset = "0x25102C0", VA = "0x1825114C0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x2515CE0", Offset = "0x2514AE0", VA = "0x182515CE0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<MMBOLDIBAHF<IPGMDHDLEMN>, MMBOLDIBAHF<IPGMDHDLEMN>> NOPJNFPOAPA
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x2514380", Offset = "0x2513180", VA = "0x182514380", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x2512210", Offset = "0x2511010", VA = "0x182512210", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<MMBOLDIBAHF<IPGMDHDLEMN>, MMBOLDIBAHF<IPGMDHDLEMN>> HMNEFOBPBBN
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x2513F00", Offset = "0x2512D00", VA = "0x182513F00", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x25139B0", Offset = "0x25127B0", VA = "0x1825139B0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<MMBOLDIBAHF<CJABLIIDPAG>, MMBOLDIBAHF<CJABLIIDPAG>> EOCKLIAOFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x2514100", Offset = "0x2512F00", VA = "0x182514100", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x2514200", Offset = "0x2513000", VA = "0x182514200", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<MMBOLDIBAHF<CJABLIIDPAG>, MMBOLDIBAHF<CJABLIIDPAG>> BPDHPFOOGBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x2511FC0", Offset = "0x2510DC0", VA = "0x182511FC0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x2516C10", Offset = "0x2515A10", VA = "0x182516C10", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<MMBOLDIBAHF<IPGMDHDLEMN>, BHENDMMDMGJ> GCMNKGENGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x2514530", Offset = "0x2513330", VA = "0x182514530", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x2514040", Offset = "0x2512E40", VA = "0x182514040", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<MMBOLDIBAHF<IPGMDHDLEMN>> DCKBBKGALPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x2516B50", Offset = "0x2515950", VA = "0x182516B50", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x2516250", Offset = "0x2515050", VA = "0x182516250", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<MMBOLDIBAHF<IPGMDHDLEMN>, BHENDMMDMGJ> IMNEELHFPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x2511190", Offset = "0x250FF90", VA = "0x182511190", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x25142C0", Offset = "0x25130C0", VA = "0x1825142C0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<MMBOLDIBAHF<CJABLIIDPAG>, EAKLKILMIHK> FBJJFFMFIOH
	{
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x25110D0", Offset = "0x250FED0", VA = "0x1825110D0", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x2513070", Offset = "0x2511E70", VA = "0x182513070", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<MMBOLDIBAHF<CJABLIIDPAG>> NIGKEMFOGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x2515860", Offset = "0x2514660", VA = "0x182515860", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x25137A0", Offset = "0x25125A0", VA = "0x1825137A0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<MMBOLDIBAHF<CJABLIIDPAG>, EAKLKILMIHK> KMGGBNIDNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x25163D0", Offset = "0x25151D0", VA = "0x1825163D0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x2516310", Offset = "0x2515110", VA = "0x182516310", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x2516E70", Offset = "0x2515C70", VA = "0x182516E70")]
	private NPIMDGBIJLL(bool NMNJHMHAJDP, CCBLBBOJEHP PJMKKGHIHNK, bool JCLHIPFADPN, AMNAKHMFIGM<IPGMDHDLEMN, LCMGCFILBPM> EPHBHIHACKN, AMNAKHMFIGM<IPGMDHDLEMN, BHENDMMDMGJ> ELBLAAHDANN, IMCHGLPNCJE KFDHCNOCENN, AMNAKHMFIGM<CJABLIIDPAG, LFHJOEFBKHH> HIPEDBFNJJI, AMNAKHMFIGM<CJABLIIDPAG, EAKLKILMIHK> MJHAFAOFEMD, string? GAANNBMKPGM, DBKJOMHNNFA ELCKGFMBOEB, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, bool ELBKHDGKKCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x25165E0", Offset = "0x25153E0", VA = "0x1825165E0")]
	public static NPIMDGBIJLL MKHEJJEDOII(bool NMNJHMHAJDP, CCBLBBOJEHP PJMKKGHIHNK, bool JCLHIPFADPN, IMCHGLPNCJE KFDHCNOCENN, DBKJOMHNNFA ELCKGFMBOEB, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, bool ELBKHDGKKCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x25145F0", Offset = "0x25133F0", VA = "0x1825145F0")]
	private void JEELJGCJJCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x25122D0", Offset = "0x25110D0", VA = "0x1825122D0", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x2515590", Offset = "0x2514390", VA = "0x182515590", Slot = "38")]
	[AsyncStateMachine(typeof(LGNFPGBPHHI))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> JJKEHNNEBOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x2511D90", Offset = "0x2510B90", VA = "0x182511D90")]
	private (JBFHDIHHHFI, int)? DAJAMGIPGPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x2512080", Offset = "0x2510E80", VA = "0x182512080")]
	private void DELMHJNKDCP(int HOOPENMKPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1D1F340", Offset = "0x1D1E140", VA = "0x181D1F340")]
	private void OBHNEAODCLC(int HOOPENMKPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x2514DA0", Offset = "0x2513BA0", VA = "0x182514DA0")]
	private void JEGPNOLNJGL(int BDLNLLDHELJ, int DLFDPAHEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x2511310", Offset = "0x2510110", VA = "0x182511310")]
	private void BDDBBCAGOPB(int BDLNLLDHELJ, int DLFDPAHEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x25117B0", Offset = "0x25105B0", VA = "0x1825117B0")]
	private void CNOJMBEPOAH(int HOOPENMKPAB, MMBOLDIBAHF<IPGMDHDLEMN> MCLLNCKNMEP, GEBCOFGDLNO HLIJNINJIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x2515CC0", Offset = "0x2514AC0", VA = "0x182515CC0")]
	private void KKAHHFPMLHA(int BHICHJIFLJC, MMBOLDIBAHF<IPGMDHDLEMN> MCLLNCKNMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2511570", Offset = "0x2510370", VA = "0x182511570")]
	private void CFFIAMKFMOA(int BHICHJIFLJC, MMBOLDIBAHF<IPGMDHDLEMN> MCLLNCKNMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2515140", Offset = "0x2513F40", VA = "0x182515140")]
	private void JHEONPPJEEF(int HOOPENMKPAB, MMBOLDIBAHF<IPGMDHDLEMN> MCLLNCKNMEP, GEBCOFGDLNO HLIJNINJIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x2516490", Offset = "0x2515290", VA = "0x182516490")]
	private void MJMLOOHLCFJ(int HOOPENMKPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x1127370", Offset = "0x1126170", VA = "0x181127370")]
	private void PGJBPEOMGKJ(int HOOPENMKPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x2514440", Offset = "0x2513240", VA = "0x182514440")]
	private void INAGKECLDBM(int HOOPENMKPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x1D1F340", Offset = "0x1D1E140", VA = "0x181D1F340")]
	private void DLGNFKDLCMG(int HOOPENMKPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x2515920", Offset = "0x2514720", VA = "0x182515920")]
	private void KIPGIAEHJEL(int BDLNLLDHELJ, int DLFDPAHEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x2513010", Offset = "0x2511E10", VA = "0x182513010")]
	private void EHDOBNAGHLC(int BDLNLLDHELJ, int DLFDPAHEGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x2513130", Offset = "0x2511F30", VA = "0x182513130")]
	private void FFIKEMPANHL(int HOOPENMKPAB, MMBOLDIBAHF<CJABLIIDPAG> MCLLNCKNMEP, DFJLNBMMPNE HLIJNINJIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x2513EE0", Offset = "0x2512CE0", VA = "0x182513EE0")]
	private void GCJDHAHDAEF(int BHICHJIFLJC, MMBOLDIBAHF<CJABLIIDPAG> MCLLNCKNMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x2516E20", Offset = "0x2515C20", VA = "0x182516E20")]
	private void NNPJGPCDMJE(int BHICHJIFLJC, MMBOLDIBAHF<CJABLIIDPAG> MCLLNCKNMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2513A70", Offset = "0x2512870", VA = "0x182513A70")]
	private void GBIPDGKFOGF(int HOOPENMKPAB, MMBOLDIBAHF<CJABLIIDPAG> MCLLNCKNMEP, DFJLNBMMPNE HLIJNINJIMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x2513860", Offset = "0x2512660", VA = "0x182513860")]
	private void FKDOOOKFAFM(int HOOPENMKPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x1127370", Offset = "0x1126170", VA = "0x181127370")]
	private void FHMMMOJFILK(int HOOPENMKPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x2510FC0", Offset = "0x250FDC0", VA = "0x182510FC0", Slot = "39")]
	[AsyncStateMachine(typeof(BFDGHENOKGO))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> AFILPLIFBIM(MMBOLDIBAHF<KPGCHBLJMLN> NIEPNOBACFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x2512F00", Offset = "0x2511D00", VA = "0x182512F00", Slot = "40")]
	[AsyncStateMachine(typeof(OLIGDGCMFJC))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> EFNFOJACDKL(MMBOLDIBAHF<BNKJNPHLBPJ> EHHJINIOJIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x2511370", Offset = "0x2510170", VA = "0x182511370", Slot = "41")]
	[AsyncStateMachine(typeof(IDEJAENCFFH))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> BHDBOLFJBMB(MMBOLDIBAHF<KPGCHBLJMLN> NIEPNOBACFJ, MMBOLDIBAHF<KPGCHBLJMLN> BCIPJODLJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2515740", Offset = "0x2514540", VA = "0x182515740", Slot = "42")]
	[AsyncStateMachine(typeof(AJMPDPCABMH))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> KCJHIPEHGEF(MMBOLDIBAHF<BNKJNPHLBPJ> EHHJINIOJIN, MMBOLDIBAHF<BNKJNPHLBPJ> BCIPJODLJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x2511590", Offset = "0x2510390", VA = "0x182511590", Slot = "43")]
	[AsyncStateMachine(typeof(IGADDANAOHO))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> CJMCBPKNAAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x2515D90", Offset = "0x2514B90", VA = "0x182515D90", Slot = "44")]
	[AsyncStateMachine(typeof(CIPKDBHMKMO))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> LCPIMNMLLNE(string IEIADNFCLID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x2512DD0", Offset = "0x2511BD0", VA = "0x182512DD0", Slot = "45")]
	[AsyncStateMachine(typeof(FLKCHOJJIEB))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> EBCJHOGJJBL(MMBOLDIBAHF<KPGCHBLJMLN> NIEPNOBACFJ, string PPKJBGAOBJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x2511680", Offset = "0x2510480", VA = "0x182511680", Slot = "46")]
	[AsyncStateMachine(typeof(BLFLKBCELKN))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> CKENOJLDGLP(MMBOLDIBAHF<BNKJNPHLBPJ> EHHJINIOJIN, string PPKJBGAOBJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x2516CD0", Offset = "0x2515AD0", VA = "0x182516CD0", Slot = "47")]
	[AsyncStateMachine(typeof(FDCFBLGKHIJ))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> NDJKLJEBKNA(MMBOLDIBAHF<KPGCHBLJMLN> NIEPNOBACFJ, GIOJMNNFGKM OBDHBADPJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x2513670", Offset = "0x2512470", VA = "0x182513670", Slot = "48")]
	[AsyncStateMachine(typeof(PBLHMDIJHMO))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> FGJJAJFIILL(MMBOLDIBAHF<BNKJNPHLBPJ> EHHJINIOJIN, GIOJMNNFGKM OBDHBADPJNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x2515EB0", Offset = "0x2514CB0", VA = "0x182515EB0")]
	internal void LEIGLENNNMD(MMBOLDIBAHF<ECCLNDBJNAE> IPHILEOFJLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
public sealed class HJKKBPDPHBE : JKEDJAFHKDJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public interface GAFJEOJBDBK
	{
		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		public readonly struct DINEOCNDNCP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public readonly IReadOnlyDictionary<HFJNFIGGNLC<CHMLMGCOLME>, Guid>? DLIPHOFECAP;

			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
			public DINEOCNDNCP(IReadOnlyDictionary<HFJNFIGGNLC<CHMLMGCOLME>, Guid>? DLIPHOFECAP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		EKHJGDJBBGL PPNJJFFIAAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<BGMBPJPBIDA> KPIPKAMNHDN(CancellationToken FEHCANHDGHE);

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<OLIDAEPNBCP> CMHMHGPELHB(CancellationToken FEHCANHDGHE);

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<GKEPDEDFEAB> LOFKOFGIPFF(CancellationToken FEHCANHDGHE);

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<DINEOCNDNCP> BFJBGKFFIOB(CancellationToken FEHCANHDGHE);

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<NCHJKEEPIJI> NOBADIDMEFF(CancellationToken FEHCANHDGHE);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct OFAMPEHLBHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public AsyncTaskMethodBuilder<HJKKBPDPHBE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public CCBLBBOJEHP circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public BGMBPJPBIDA roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public OLIDAEPNBCP superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private GAFJEOJBDBK <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private BGMBPJPBIDA <downloadedRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private BGMBPJPBIDA <actualRoomData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private NCHJKEEPIJI <actualStaticConfig>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private OLIDAEPNBCP <finalSuperRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private GKEPDEDFEAB <playerSaveData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private TaskAwaiter<BGMBPJPBIDA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private BGMBPJPBIDA <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private TaskAwaiter<NCHJKEEPIJI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private TaskAwaiter<OLIDAEPNBCP> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<GKEPDEDFEAB> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private TaskAwaiter<GAFJEOJBDBK.DINEOCNDNCP> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private TaskAwaiter<AJACNMDPIMM> <>u__6;

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x2519140", Offset = "0x2517F40", VA = "0x182519140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x2519FC0", Offset = "0x2518DC0", VA = "0x182519FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private readonly AJACNMDPIMM GCMCEGMNGIJ;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public AJACNMDPIMM CGDFOFGCFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	private HJKKBPDPHBE(AJACNMDPIMM AKKBNFBHLLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0x250AE10", Offset = "0x2509C10", VA = "0x18250AE10")]
	[AsyncStateMachine(typeof(OFAMPEHLBHE))]
	public static Task<HJKKBPDPHBE> KEJGOGGBELF(CCBLBBOJEHP PJMKKGHIHNK, BGMBPJPBIDA? BGIEPHNJHFK, OLIDAEPNBCP? PDNPLFLMEMC, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x250ADF0", Offset = "0x2509BF0", VA = "0x18250ADF0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public readonly struct GIGFCJMGLDN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct NPIMNLHHGHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<object, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public GIGFCJMGLDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public EAAKFALPLDL action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private TaskAwaiter<PGOLMGNGGBM<object, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x2516F70", Offset = "0x2515D70", VA = "0x182516F70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x2517200", Offset = "0x2516000", VA = "0x182517200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct FNIHCCDMNKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<bool, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public HKNIKLFPMCJ rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public BGMBPJPBIDA circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public OLIDAEPNBCP superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public GIGFCJMGLDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private EAAKFALPLDL[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private TaskAwaiter<PGOLMGNGGBM<object, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x250A5C0", Offset = "0x25093C0", VA = "0x18250A5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x250A9A0", Offset = "0x25097A0", VA = "0x18250A9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct EFLDFKJNKIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public GIGFCJMGLDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private TaskAwaiter<PGOLMGNGGBM<object, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x2508610", Offset = "0x2507410", VA = "0x182508610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x2508850", Offset = "0x2507650", VA = "0x182508850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private readonly FMLCFIPPIMP IIIFCFKCAOI;

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0xBE6140", Offset = "0xBE4F40", VA = "0x180BE6140")]
	public GIGFCJMGLDN(FMLCFIPPIMP POAJLCGJBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x250AA70", Offset = "0x2509870", VA = "0x18250AA70")]
	[AsyncStateMachine(typeof(NPIMNLHHGHK))]
	private Task<PGOLMGNGGBM<object, HJBBDBHAMJJ>> BNAIIDEPKCK(EAAKFALPLDL OOCJAOHFGJK, bool EAJAGGAKOMP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x250AC90", Offset = "0x2509A90", VA = "0x18250AC90")]
	[AsyncStateMachine(typeof(FNIHCCDMNKE))]
	public Task<PGOLMGNGGBM<bool, HJBBDBHAMJJ?>>? PMABKCANJGN(int BJNLOMPCAOE, HKNIKLFPMCJ? PFEGEFINGEH, BGMBPJPBIDA? BHCDFOMKNBA, OLIDAEPNBCP? PDNPLFLMEMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x250ABA0", Offset = "0x25099A0", VA = "0x18250ABA0")]
	[AsyncStateMachine(typeof(EFLDFKJNKIM))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> MJMAPJMIAED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public sealed class ANOJLFMJOCD : GGNMIHFJFJM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private readonly NEKGCAKIGLB PHEJAPOOOBJ;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public NEKGCAKIGLB LFMEKOKMHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	private ANOJLFMJOCD(NEKGCAKIGLB HPBGIBCJJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x24FF740", Offset = "0x24FE540", VA = "0x1824FF740")]
	public static ANOJLFMJOCD FEIAPADJKML(CCBLBBOJEHP PJMKKGHIHNK, HKNIKLFPMCJ BMAAJHJABDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x24FF720", Offset = "0x24FE520", VA = "0x1824FF720", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public interface OHPAFJMFHDD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	AJACNMDPIMM CGDFOFGCFKK
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	EAIFHJMEAJD OGKLNPPGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	CDLEIPIONCH IGNELGFMAEG
	{
		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	DFBLLIONEGD NGAKKNODBIC
	{
		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public interface AOGOAJLDLHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	OHPAFJMFHDD? EGBADIGPNLK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool FIMGNNJILII
	{
		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool NHEFDJGMJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<OHPAFJMFHDD?>? KIKKCPDGOEC();

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task BABHGOBGNEG(CCBLBBOJEHP PJMKKGHIHNK, HKNIKLFPMCJ BMAAJHJABDD, BGMBPJPBIDA? APCKKLPFEEC, OLIDAEPNBCP? FPGKIMDEMDF);
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
[JOBGNIMLPCB("IStaticCV2Instance")]
public interface JKEDJAFHKDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	AJACNMDPIMM CGDFOFGCFKK
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[JOBGNIMLPCB("IStaticEVInstance")]
public interface GGNMIHFJFJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	NEKGCAKIGLB LFMEKOKMHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C9")]
public static class MNPAKOIPKFF
{
	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x250F900", Offset = "0x250E700", VA = "0x18250F900")]
	public static KDAFJECKBGP<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP, LNLOKMHCLCK.MPDIIICCGGC<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP>> JGLOGKNNEOA([In] this KDAFJECKBGP<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP, LNLOKMHCLCK.MPDIIICCGGC<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP>> POPIBAJHLNM)
	{
		return default(KDAFJECKBGP<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP, LNLOKMHCLCK.MPDIIICCGGC<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public sealed class NEOKGIHHAEB : OBDFILPKANB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private readonly CCBLBBOJEHP APNMNKMKKDP;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool NHEFDJGMJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x2510110", Offset = "0x250EF10", VA = "0x182510110", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	internal NEOKGIHHAEB(CCBLBBOJEHP PJMKKGHIHNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
internal sealed class EPEOBGHDJLI : GACEKJGMDDH
{
	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x2508ED0", Offset = "0x2507CD0", VA = "0x182508ED0", Slot = "4")]
	public GHBBNKLLDOI? BGJNDGIKFGP(string? JNFIKAKAPJB, string? JPCNOHEIBOE, string? KHANBOGEPMK, AJNENEIMOEM.FJLHIDGJHEJ.KPLFFPLKLEF BHCKIMBIHMM, bool JNKNMIMIGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public EPEOBGHDJLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public sealed class HNIFIHHDBKI : CMBCLPOIFNM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private struct DMBFMADDELN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public AsyncTaskMethodBuilder<EDALADINGLF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public HNIFIHHDBKI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private TaskAwaiter<OHPAFJMFHDD?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x2508110", Offset = "0x2506F10", VA = "0x182508110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x25083A0", Offset = "0x25071A0", VA = "0x1825083A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private readonly CCBLBBOJEHP APNMNKMKKDP;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public EDALADINGLF? GGJCMHODIEM
	{
		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x250B7C0", Offset = "0x250A5C0", VA = "0x18250B7C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public DFBLLIONEGD? EAEFOEINKEA
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x250B930", Offset = "0x250A730", VA = "0x18250B930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool DHOFOBMJNJB
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x250BA10", Offset = "0x250A810", VA = "0x18250BA10", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool OILDAKBFJPF
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x250B9B0", Offset = "0x250A7B0", VA = "0x18250B9B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x250BA70", Offset = "0x250A870", VA = "0x18250BA70")]
	internal HNIFIHHDBKI(CCBLBBOJEHP PJMKKGHIHNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x250B840", Offset = "0x250A640", VA = "0x18250B840", Slot = "7")]
	[AsyncStateMachine(typeof(DMBFMADDELN))]
	public Task<EDALADINGLF> JPPCNNHMDDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x250B450", Offset = "0x250A250", VA = "0x18250B450", Slot = "9")]
	public IReadOnlyDictionary<HFJNFIGGNLC<CHMLMGCOLME>, Guid> JFHAGNHGKBC(IEnumerable<DACMPOAMDBF> PGMCKOPDLFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x250AF80", Offset = "0x2509D80", VA = "0x18250AF80", Slot = "10")]
	public ENEOPEAOFOI EMLLILJBDIE(IEnumerable<DACMPOAMDBF> PGMCKOPDLFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x250B110", Offset = "0x2509F10", VA = "0x18250B110")]
	public PGOLMGNGGBM<HCAIJCFFPFA, EOABGNINGBC> GGODFDIMGPK([In] HCAIJCFFPFA MIJMPILAEHA)
	{
		return default(PGOLMGNGGBM<HCAIJCFFPFA, EOABGNINGBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x250B2B0", Offset = "0x250A0B0", VA = "0x18250B2B0", Slot = "8")]
	private PGOLMGNGGBM<HCAIJCFFPFA, EOABGNINGBC> HJDGJDHICJN([In] HCAIJCFFPFA MIJMPILAEHA)
	{
		return default(PGOLMGNGGBM<HCAIJCFFPFA, EOABGNINGBC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public sealed class DFBLLIONEGD : EDALADINGLF
{
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	internal static class OELKJKMCBEO
	{
		[Cpp2IlInjected.Token(Token = "0x20000D1")]
		[CompilerGenerated]
		private sealed class CIANNIMKEDE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000299")]
			public AJACNMDPIMM state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400029A")]
			public GDJJEFHKMHN spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public CIANNIMKEDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x251D9D0", Offset = "0x251C7D0", VA = "0x18251D9D0")]
			internal bool OCHKMAOMFLE(LEEKCEDCACA n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private sealed class APJBGDKFDOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400029B")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public APJBGDKFDOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600051C")]
			[Cpp2IlInjected.Address(RVA = "0x251D860", Offset = "0x251C660", VA = "0x18251D860")]
			internal void NMIFJFGMPLL(LEEKCEDCACA n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x2517CE0", Offset = "0x2516AE0", VA = "0x182517CE0")]
		public static PGOLMGNGGBM<EDALADINGLF.CGIKHGGGNKB, FDIBCACJGHL> NJAAPHNJHEI(DFBLLIONEGD DJAJDIFOIHP, [In] EDALADINGLF.KLKENFNIKIF EHEEIKICBAM)
		{
			return default(PGOLMGNGGBM<EDALADINGLF.CGIKHGGGNKB, FDIBCACJGHL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x2518220", Offset = "0x2517020", VA = "0x182518220")]
		internal static PGOLMGNGGBM<(JNPFNEIIMOH, FIGMLPKFFBC), FDIBCACJGHL> PLNHOMDPDMF(DFBLLIONEGD DJAJDIFOIHP, FIGMLPKFFBC IJHMLDFMLHB, bool ACAHLKCOGNJ, [In] HFJNFIGGNLC<CHMLMGCOLME> DFJIAKNCDJF, [In] int? AIPBMGOHBAF, [In] JGEIPOFGAHI? AJLGILKMDNI, [In] JGEIPOFGAHI? BAGPOALFNFJ)
		{
			return default(PGOLMGNGGBM<(JNPFNEIIMOH, FIGMLPKFFBC), FDIBCACJGHL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x2517770", Offset = "0x2516570", VA = "0x182517770")]
		private static void GIKIBPFFKOL(bool ACAHLKCOGNJ, DACMPOAMDBF HCOLLOKLDBB, JNPFNEIIMOH FFHNBBHGGKD, [In] HFJNFIGGNLC<CHMLMGCOLME> DFJIAKNCDJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x2517340", Offset = "0x2516140", VA = "0x182517340")]
		public static void AFMBDKALAJO(BDBICHMFIED JPAMFLDLBPF, [In] EDALADINGLF.AIFKNKNFJKB DMINCEOHEHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x2517BF0", Offset = "0x25169F0", VA = "0x182517BF0")]
		[CompilerGenerated]
		internal static bool IMBMOOBKMDC(AJACNMDPIMM BFEABHOJANJ, GDJJEFHKMHN BBHFCLOFJFF, LEEKCEDCACA NHJOAMCHPMM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x2517740", Offset = "0x2516540", VA = "0x182517740")]
		[CompilerGenerated]
		internal static bool AIGHLFKLKND(LEEKCEDCACA JDNLPMLJDPE)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct JPGLALFEPCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public DFBLLIONEGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public MMBOLDIBAHF<CHMLMGCOLME> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public MMBOLDIBAHF<AHIDBKDCADN> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public NFJHFHNDCLG offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public bool deleteBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x2521F20", Offset = "0x2520D20", VA = "0x182521F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0x2522170", Offset = "0x2520F70", VA = "0x182522170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private struct DDICLMOKMNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public DFBLLIONEGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public MMBOLDIBAHF<CHMLMGCOLME> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public HFJNFIGGNLC<AHIDBKDCADN> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public List<MMBOLDIBAHF<AHIDBKDCADN>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public NFJHFHNDCLG localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public GGLODEGCHGH localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public NFJHFHNDCLG offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x251E330", Offset = "0x251D130", VA = "0x18251E330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x251E5F0", Offset = "0x251D3F0", VA = "0x18251E5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct LNPBCINMCJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public DFBLLIONEGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public MMBOLDIBAHF<CHMLMGCOLME> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public HFJNFIGGNLC<AHIDBKDCADN> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		public List<MMBOLDIBAHF<AHIDBKDCADN>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x2522C70", Offset = "0x2521A70", VA = "0x182522C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x2522EB0", Offset = "0x2521CB0", VA = "0x182522EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct AGJHIEPANEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public DFBLLIONEGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public MMBOLDIBAHF<CHMLMGCOLME> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public HFJNFIGGNLC<AHIDBKDCADN> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public MMBOLDIBAHF<CHMLMGCOLME> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public List<MMBOLDIBAHF<AHIDBKDCADN>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x251D1C0", Offset = "0x251BFC0", VA = "0x18251D1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x251D400", Offset = "0x251C200", VA = "0x18251D400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct CMDNMEPNJBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public DFBLLIONEGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public HFJNFIGGNLC<CHMLMGCOLME> legacyGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public HFJNFIGGNLC<AHIDBKDCADN> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public IReadOnlyList<HFJNFIGGNLC<AHIDBKDCADN>> nodeLegacyIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public IReadOnlyDictionary<IAFCKPHMLJB, (MMBOLDIBAHF<ECCLNDBJNAE>, MMBOLDIBAHF<IPGMDHDLEMN>)> inputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public IReadOnlyDictionary<FDMDHELILLE, (MMBOLDIBAHF<ECCLNDBJNAE>, MMBOLDIBAHF<CJABLIIDPAG>)> outputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x251DCA0", Offset = "0x251CAA0", VA = "0x18251DCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x251E2D0", Offset = "0x251D0D0", VA = "0x18251E2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct GGBAOAJDPCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public DFBLLIONEGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public MMBOLDIBAHF<CHMLMGCOLME> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public MMBOLDIBAHF<BGEDOHJDFGJ> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public MMBOLDIBAHF<LILDJNMHNBP> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x251F580", Offset = "0x251E380", VA = "0x18251F580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x251FBD0", Offset = "0x251E9D0", VA = "0x18251FBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct LIEHOOGPJAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public DFBLLIONEGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public HFJNFIGGNLC<AHIDBKDCADN> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public HFJNFIGGNLC<CHMLMGCOLME> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public MMBOLDIBAHF<ECCLNDBJNAE> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public MMBOLDIBAHF<IPGMDHDLEMN> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x2522820", Offset = "0x2521620", VA = "0x182522820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x2522B60", Offset = "0x2521960", VA = "0x182522B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct GLJBHMIAJJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public DFBLLIONEGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public HFJNFIGGNLC<AHIDBKDCADN> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public HFJNFIGGNLC<CHMLMGCOLME> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public MMBOLDIBAHF<ECCLNDBJNAE> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public MMBOLDIBAHF<CJABLIIDPAG> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x251FC40", Offset = "0x251EA40", VA = "0x18251FC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x251FF80", Offset = "0x251ED80", VA = "0x18251FF80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct NFKBAGAALHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public DFBLLIONEGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x2522F80", Offset = "0x2521D80", VA = "0x182522F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x25231A0", Offset = "0x2521FA0", VA = "0x1825231A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private readonly CCBLBBOJEHP APNMNKMKKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private readonly JKEDJAFHKDJ KCHEJHIEEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private readonly GGNMIHFJFJM BPDMHIBGLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private readonly EILAKDKEEJE JNKHNOFJEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private readonly HNIFIHHDBKI CGCOHALBNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private Dictionary<HFJNFIGGNLC<AHIDBKDCADN>, AEBHIPCIKGL> GNDDNGJPCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	[CompilerGenerated]
	private Action<HFJNFIGGNLC<AHIDBKDCADN>>? MEOCHBMMELO;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public HFJNFIGGNLC<CHMLMGCOLME> AGEPPPCLNCB
	{
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x2501E40", Offset = "0x2500C40", VA = "0x182501E40", Slot = "4")]
		get
		{
			return default(HFJNFIGGNLC<CHMLMGCOLME>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public EILAKDKEEJE OENLHJCLIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x24E1990", Offset = "0x24E0790", VA = "0x1824E1990", Slot = "5")]
		get
		{
			return default(EILAKDKEEJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x2507A50", Offset = "0x2506850", VA = "0x182507A50")]
	public DFBLLIONEGD(CCBLBBOJEHP PJMKKGHIHNK, JKEDJAFHKDJ LNODLNHJPOD, GGNMIHFJFJM GIAJKFDKLNL, HNIFIHHDBKI DPJIDGKOMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x2504560", Offset = "0x2503360", VA = "0x182504560", Slot = "64")]
	public MMBOLDIBAHF<LEDHAJOPDGM> JMLCJHNNHHK(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD)
	{
		return default(MMBOLDIBAHF<LEDHAJOPDGM>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x2502ED0", Offset = "0x2501CD0", VA = "0x182502ED0", Slot = "65")]
	public MMBOLDIBAHF<DIGNAGEOFCF> GIEPHDMKDJG(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> KIIIMMIFGEE)
	{
		return default(MMBOLDIBAHF<DIGNAGEOFCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x2506300", Offset = "0x2505100", VA = "0x182506300", Slot = "6")]
	public (bool, bool) OBABNDDHMGD(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> EOFDBBEMFCB, MMBOLDIBAHF<LILDJNMHNBP> KBMDBDGLOKC)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x2503DB0", Offset = "0x2502BB0", VA = "0x182503DB0")]
	public bool JEDIKEAMNGK(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] MCCJOLAKNPC GHCCANLFLNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x2504380", Offset = "0x2503180", VA = "0x182504380", Slot = "8")]
	public bool JKHJIOGKMOM(BHENDMMDMGJ GLKKCGJJGEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x2503D30", Offset = "0x2502B30", VA = "0x182503D30", Slot = "9")]
	public bool JBCEEHOIDLG(EAKLKILMIHK DCGDNLGNDLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x2504A80", Offset = "0x2503880", VA = "0x182504A80", Slot = "10")]
	public OMDFNHPHEAE? KDJLJPIAPEG(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x2502090", Offset = "0x2500E90", VA = "0x182502090", Slot = "11")]
	public FDOBDFHDADM? DJBFONFKBJM(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> KIIIMMIFGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x2501F70", Offset = "0x2500D70", VA = "0x182501F70", Slot = "12")]
	public MMBOLDIBAHF<BGEDOHJDFGJ>? DHONJCCHFCG(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, MMBOLDIBAHF<CJABLIIDPAG> KADNPDEALKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x2505DB0", Offset = "0x2504BB0", VA = "0x182505DB0", Slot = "13")]
	public MMBOLDIBAHF<LILDJNMHNBP>? NBHLDCMMFHB(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, MMBOLDIBAHF<IPGMDHDLEMN> BCFPEDLJBCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x25079C0", Offset = "0x25067C0", VA = "0x1825079C0", Slot = "14")]
	public IEnumerable<MMBOLDIBAHF<CHMLMGCOLME>> POPBMIPKDPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x2501190", Offset = "0x24FFF90", VA = "0x182501190", Slot = "15")]
	public IEnumerable<MMBOLDIBAHF<DJIMMFKAAFA>> BHMJPEPJGEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x2506950", Offset = "0x2505750", VA = "0x182506950", Slot = "16")]
	public string OEBHKIJPENI(MMBOLDIBAHF<DJIMMFKAAFA> NGEJFEJNCIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x25040E0", Offset = "0x2502EE0", VA = "0x1825040E0", Slot = "17")]
	public string JFNBHEIBJED(MMBOLDIBAHF<DJIMMFKAAFA> NGEJFEJNCIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x2503570", Offset = "0x2502370", VA = "0x182503570")]
	public AEBHIPCIKGL? HMAJDCLHIAC([In] HFJNFIGGNLC<AHIDBKDCADN> INONPKMEIIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x25012C0", Offset = "0x25000C0", VA = "0x1825012C0", Slot = "23")]
	public MMBOLDIBAHF<DGKHNPEDJKJ> CHMECDKOOCB(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH)
	{
		return default(MMBOLDIBAHF<DGKHNPEDJKJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x2501240", Offset = "0x2500040", VA = "0x182501240")]
	public MMBOLDIBAHF<AHIDBKDCADN> BPDJIJEFKPP(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] HFJNFIGGNLC<AHIDBKDCADN> LCAEJPCMEHF)
	{
		return default(MMBOLDIBAHF<AHIDBKDCADN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x2501110", Offset = "0x24FFF10", VA = "0x182501110", Slot = "33")]
	public MMBOLDIBAHF<AHIDBKDCADN> BEIDFEHJIIG(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD)
	{
		return default(MMBOLDIBAHF<AHIDBKDCADN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x25028B0", Offset = "0x25016B0", VA = "0x1825028B0", Slot = "34")]
	public MMBOLDIBAHF<AHIDBKDCADN> FAEKGPEOGMA(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> KIIIMMIFGEE)
	{
		return default(MMBOLDIBAHF<AHIDBKDCADN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x2502E50", Offset = "0x2501C50", VA = "0x182502E50")]
	public MMBOLDIBAHF<AHIDBKDCADN>? GIBANLLMDEK(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] HFJNFIGGNLC<AHIDBKDCADN> LCAEJPCMEHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x25025E0", Offset = "0x25013E0", VA = "0x1825025E0", Slot = "25")]
	public CCAGDHJOJOO? EHAMGHMFDIO(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x25036E0", Offset = "0x25024E0", VA = "0x1825036E0", Slot = "26")]
	public long HOFILGFCDHI()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x2505070", Offset = "0x2503E70", VA = "0x182505070")]
	private void LLKFLOHMLLJ(HFJNFIGGNLC<AHIDBKDCADN> INONPKMEIIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x25023A0", Offset = "0x25011A0", VA = "0x1825023A0", Slot = "31")]
	public IEnumerable<(MMBOLDIBAHF<CHMLMGCOLME>, MMBOLDIBAHF<AHIDBKDCADN>)> DPOFHOPJEEJ(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x2505D20", Offset = "0x2504B20", VA = "0x182505D20", Slot = "32")]
	public MMBOLDIBAHF<LILDJNMHNBP> NBHLDCMMFHB(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<LEDHAJOPDGM> BCFPEDLJBCN)
	{
		return default(MMBOLDIBAHF<LILDJNMHNBP>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x2502000", Offset = "0x2500E00", VA = "0x182502000", Slot = "35")]
	public MMBOLDIBAHF<BGEDOHJDFGJ> DHONJCCHFCG(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<DIGNAGEOFCF> KADNPDEALKM)
	{
		return default(MMBOLDIBAHF<BGEDOHJDFGJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x25045E0", Offset = "0x25033E0", VA = "0x1825045E0")]
	private AEBHIPCIKGL? JPMBBGEMIBG([In] HFJNFIGGNLC<AHIDBKDCADN> INONPKMEIIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x2504B40", Offset = "0x2503940", VA = "0x182504B40")]
	public IMCHGLPNCJE? KJOECPMEKOJ([In] HFJNFIGGNLC<AHIDBKDCADN> INONPKMEIIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x2504690", Offset = "0x2503490", VA = "0x182504690")]
	public KDIJDIKDJEK? OANILKMGJDE([In] HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x2505F90", Offset = "0x2504D90", VA = "0x182505F90", Slot = "27")]
	public IEnumerable<OJCJNACIJDM> NNIBGOGGBAK(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x2504FE0", Offset = "0x2503DE0", VA = "0x182504FE0", Slot = "28")]
	public bool LHKLBMBDOGM(MMBOLDIBAHF<DJIMMFKAAFA> NGEJFEJNCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x25030D0", Offset = "0x2501ED0", VA = "0x1825030D0", Slot = "29")]
	public IEnumerable<MCCJOLAKNPC> GMJBJLHEGEK(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> EOFDBBEMFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x2503840", Offset = "0x2502640", VA = "0x182503840", Slot = "30")]
	public IEnumerable<MCCJOLAKNPC> IIJMHFEAAGJ(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> KBMDBDGLOKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x25069C0", Offset = "0x25057C0", VA = "0x1825069C0")]
	public MMBOLDIBAHF<CHMLMGCOLME> OKJLKMJLMIF([In] HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO)
	{
		return default(MMBOLDIBAHF<CHMLMGCOLME>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2502930", Offset = "0x2501730", VA = "0x182502930")]
	public MMBOLDIBAHF<CHMLMGCOLME>? IHPLDPMJPIE([In] HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2507480", Offset = "0x2506280", VA = "0x182507480")]
	private GDJJEFHKMHN? PDCLPNFJMGK([In] HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2504690", Offset = "0x2503490", VA = "0x182504690")]
	private KDIJDIKDJEK? KAJCECFJGPE([In] HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x25024B0", Offset = "0x25012B0", VA = "0x1825024B0", Slot = "21")]
	public MMBOLDIBAHF<CHMLMGCOLME>? EFNFGFKCJNM(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x2506A40", Offset = "0x2505840", VA = "0x182506A40", Slot = "39")]
	public HFJNFIGGNLC<CHMLMGCOLME> ONBNGOBIBPD(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO)
	{
		return default(HFJNFIGGNLC<CHMLMGCOLME>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x2503740", Offset = "0x2502540", VA = "0x182503740", Slot = "36")]
	public IEnumerable<GIOJMNNFGKM> IEJFAALONFI(DJKKHFLEFNP LFIIHBIAKBD, bool JCKILBAIIIL, bool PGGKHIJNADM, bool FPFHGFPOKNN, bool AIJJLDPODMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x25076C0", Offset = "0x25064C0", VA = "0x1825076C0", Slot = "37")]
	public GIOJMNNFGKM PMFIOEBPAIL(DJKKHFLEFNP LFIIHBIAKBD, AAFLNAOHLKL CLOJEHOEOGB, bool JCKILBAIIIL, bool PGGKHIJNADM, bool FPFHGFPOKNN, bool AIJJLDPODMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x2500F70", Offset = "0x24FFD70", VA = "0x182500F70")]
	public OJCJNACIJDM HDMPIIMAEDK(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] MCCJOLAKNPC GHCCANLFLNF)
	{
		return default(OJCJNACIJDM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x2504150", Offset = "0x2502F50", VA = "0x182504150", Slot = "40")]
	public MCCJOLAKNPC JJEEHJDNMGP(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> EOFDBBEMFCB, MMBOLDIBAHF<LILDJNMHNBP> KBMDBDGLOKC)
	{
		return default(MCCJOLAKNPC);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x2506800", Offset = "0x2505600", VA = "0x182506800", Slot = "41")]
	[AsyncStateMachine(typeof(JPGLALFEPCB))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> OCLNEPHMAMD(MMBOLDIBAHF<CHMLMGCOLME> OIBEPNEBAAO, MMBOLDIBAHF<AHIDBKDCADN> NGJLPFOIIME, NFJHFHNDCLG DACBEFNKNPO, bool KEONPDKIFDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x2507540", Offset = "0x2506340", VA = "0x182507540", Slot = "42")]
	[AsyncStateMachine(typeof(DDICLMOKMNM))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> PIHIGNIENOE(MMBOLDIBAHF<CHMLMGCOLME> OIBEPNEBAAO, HFJNFIGGNLC<AHIDBKDCADN> NGJLPFOIIME, List<MMBOLDIBAHF<AHIDBKDCADN>> NKEGLDNAHCJ, NFJHFHNDCLG GMIKBDHENNM, GGLODEGCHGH INMLNAMLHEP, NFJHFHNDCLG DACBEFNKNPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x2503BE0", Offset = "0x25029E0", VA = "0x182503BE0", Slot = "45")]
	[AsyncStateMachine(typeof(LNPBCINMCJF))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> IMOIAEMBLND(MMBOLDIBAHF<CHMLMGCOLME> OIBEPNEBAAO, HFJNFIGGNLC<AHIDBKDCADN> NGJLPFOIIME, List<MMBOLDIBAHF<AHIDBKDCADN>> NKEGLDNAHCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x2506050", Offset = "0x2504E50", VA = "0x182506050", Slot = "46")]
	[AsyncStateMachine(typeof(AGJHIEPANEI))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> NOPGFKLEEEN(MMBOLDIBAHF<CHMLMGCOLME> OIBEPNEBAAO, HFJNFIGGNLC<AHIDBKDCADN> NGJLPFOIIME, MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, List<MMBOLDIBAHF<AHIDBKDCADN>> NKEGLDNAHCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x2502F60", Offset = "0x2501D60", VA = "0x182502F60", Slot = "43")]
	public (IReadOnlyDictionary<IAFCKPHMLJB, (MMBOLDIBAHF<ECCLNDBJNAE>, MMBOLDIBAHF<IPGMDHDLEMN>)>, IReadOnlyDictionary<FDMDHELILLE, (MMBOLDIBAHF<ECCLNDBJNAE>, MMBOLDIBAHF<CJABLIIDPAG>)>) GMBPJDJMFMO(HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, MMBOLDIBAHF<AHIDBKDCADN> NGJLPFOIIME)
	{
		return default((IReadOnlyDictionary<IAFCKPHMLJB, (MMBOLDIBAHF<ECCLNDBJNAE>, MMBOLDIBAHF<IPGMDHDLEMN>)>, IReadOnlyDictionary<FDMDHELILLE, (MMBOLDIBAHF<ECCLNDBJNAE>, MMBOLDIBAHF<CJABLIIDPAG>)>));
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x25061B0", Offset = "0x2504FB0", VA = "0x1825061B0", Slot = "44")]
	[AsyncStateMachine(typeof(CMDNMEPNJBF))]
	public Task OAKBIFGBLCB(HFJNFIGGNLC<CHMLMGCOLME> AADNFFHAEBB, HFJNFIGGNLC<AHIDBKDCADN> NGJLPFOIIME, IReadOnlyList<HFJNFIGGNLC<AHIDBKDCADN>> FKJAMENOENO, IReadOnlyDictionary<IAFCKPHMLJB, (MMBOLDIBAHF<ECCLNDBJNAE>, MMBOLDIBAHF<IPGMDHDLEMN>)> COAHLLGEANK, IReadOnlyDictionary<FDMDHELILLE, (MMBOLDIBAHF<ECCLNDBJNAE>, MMBOLDIBAHF<CJABLIIDPAG>)> LOEOJKHFPOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x2505CB0", Offset = "0x2504AB0", VA = "0x182505CB0", Slot = "47")]
	public bool MPMHFHAPLPM(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x2505C30", Offset = "0x2504A30", VA = "0x182505C30", Slot = "48")]
	public bool MNPLAPMJIDD(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0x2502710", Offset = "0x2501510", VA = "0x182502710", Slot = "49")]
	public bool ENNCADNNMHG(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> KIIIMMIFGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x25010E0", Offset = "0x24FFEE0", VA = "0x1825010E0")]
	public PGOLMGNGGBM<EDALADINGLF.CGIKHGGGNKB, FDIBCACJGHL> AHJBNNKFFBA([In] EDALADINGLF.KLKENFNIKIF EHEEIKICBAM)
	{
		return default(PGOLMGNGGBM<EDALADINGLF.CGIKHGGGNKB, FDIBCACJGHL>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x2503350", Offset = "0x2502150", VA = "0x182503350", Slot = "51")]
	[AsyncStateMachine(typeof(GGBAOAJDPCK))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> HENMGGDKPCG(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<BGEDOHJDFGJ> EOFDBBEMFCB, MMBOLDIBAHF<LILDJNMHNBP> KBMDBDGLOKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x25046C0", Offset = "0x25034C0", VA = "0x1825046C0", Slot = "52")]
	public PGOLMGNGGBM<GMAPBEGKMND, EOABGNINGBC> KDCKBALONOM(HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO, GMAPBEGKMND MKHLMAIAGNC, GGLODEGCHGH LINILAAPDHO)
	{
		return default(PGOLMGNGGBM<GMAPBEGKMND, EOABGNINGBC>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x2502240", Offset = "0x2501040", VA = "0x182502240", Slot = "53")]
	[AsyncStateMachine(typeof(LIEHOOGPJAH))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> DPOEPBFJNIE(HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO, HFJNFIGGNLC<AHIDBKDCADN> INLGIBKCEGI, MMBOLDIBAHF<ECCLNDBJNAE> OLMIFGBPKFH, MMBOLDIBAHF<IPGMDHDLEMN> MJCHCKFLJCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x2504400", Offset = "0x2503200", VA = "0x182504400", Slot = "54")]
	[AsyncStateMachine(typeof(GLJBHMIAJJB))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> JKIPJHPIMHL(HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO, HFJNFIGGNLC<AHIDBKDCADN> NMIHPDICOOP, MMBOLDIBAHF<ECCLNDBJNAE> BANKKDDOOOP, MMBOLDIBAHF<CJABLIIDPAG> KIIIMMIFGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x2502790", Offset = "0x2501590", VA = "0x182502790", Slot = "55")]
	public LGBFPHIHMCK EPLBENJMBGL()
	{
		return default(LGBFPHIHMCK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x2503AC0", Offset = "0x25028C0", VA = "0x182503AC0", Slot = "56")]
	public LGBFPHIHMCK ILFFIALGLKO()
	{
		return default(LGBFPHIHMCK);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0x2501C90", Offset = "0x2500A90", VA = "0x182501C90")]
	private ODGCBJBCHPM CJILOCLDAMA(MGDGAGBKOEK ABLPIFLOMGE, MMBOLDIBAHF<CHMLMGCOLME> CKLHIMIDKKB, IEnumerable<HFJNFIGGNLC<CHMLMGCOLME>> BGAMLGBOIGO, IEnumerable<HFJNFIGGNLC<AHIDBKDCADN>> NKEGLDNAHCJ)
	{
		return default(ODGCBJBCHPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x2501A00", Offset = "0x2500800", VA = "0x182501A00", Slot = "57")]
	public ODGCBJBCHPM CJILOCLDAMA(MGDGAGBKOEK ABLPIFLOMGE, MMBOLDIBAHF<CHMLMGCOLME> CKLHIMIDKKB, IEnumerable<HFJNFIGGNLC<AHIDBKDCADN>> NKEGLDNAHCJ, IEnumerable<DACMPOAMDBF> NOOBFGDNPPE)
	{
		return default(ODGCBJBCHPM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x2504BD0", Offset = "0x25039D0", VA = "0x182504BD0")]
	private static IEnumerable<HFJNFIGGNLC<CHMLMGCOLME>> KMCCNIHGEPB(IEnumerable<DACMPOAMDBF> NOOBFGDNPPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x25029B0", Offset = "0x25017B0", VA = "0x1825029B0")]
	private IEnumerable<HFJNFIGGNLC<AHIDBKDCADN>> FMLCIAILEKN(IEnumerable<DACMPOAMDBF> NOOBFGDNPPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x2504F50", Offset = "0x2503D50", VA = "0x182504F50", Slot = "58")]
	public List<HOGENKMMIOH> KMEAIBFOEPC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x2501340", Offset = "0x2500140", VA = "0x182501340")]
	public (List<HOGENKMMIOH>, bool) CIPFDPKAMMC([In] BEJBGLNAANG PHLBCOGAGAP, string MOBMLKIIAJP, [In] GCFHHJINGND GHADNDJKGPE, AHMLKICPGDI BDHABOFHKHD, DHLDGGEGFKD PGHLKDEOJJB)
	{
		return default((List<HOGENKMMIOH>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x2503480", Offset = "0x2502280", VA = "0x182503480", Slot = "60")]
	public bool HJKILPILGHP(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x2505EC0", Offset = "0x2504CC0", VA = "0x182505EC0")]
	internal void NKLCDPJNPOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x2501EA0", Offset = "0x2500CA0", VA = "0x182501EA0")]
	internal Task DGAEJPIAECP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x2505100", Offset = "0x2503F00", VA = "0x182505100", Slot = "61")]
	public PGOLMGNGGBM<MMBOLDIBAHF<BGEDOHJDFGJ>?, HJBBDBHAMJJ> MFLMOLMLBMI(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<LILDJNMHNBP> MJCHCKFLJCD)
	{
		return default(PGOLMGNGGBM<MMBOLDIBAHF<BGEDOHJDFGJ>?, HJBBDBHAMJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x2506AB0", Offset = "0x25058B0", VA = "0x182506AB0", Slot = "62")]
	public PGOLMGNGGBM<MMBOLDIBAHF<LILDJNMHNBP>?, HJBBDBHAMJJ> PCIJFNHEJOB(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, MMBOLDIBAHF<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<BGEDOHJDFGJ> KIIIMMIFGEE)
	{
		return default(PGOLMGNGGBM<MMBOLDIBAHF<LILDJNMHNBP>?, HJBBDBHAMJJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x2502150", Offset = "0x2500F50", VA = "0x182502150", Slot = "63")]
	[AsyncStateMachine(typeof(NFKBAGAALHI))]
	public Task<PGOLMGNGGBM<ENLEGHEGALI, HJBBDBHAMJJ>> DPBAOOBMIBG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x2505C20", Offset = "0x2504A20", VA = "0x182505C20", Slot = "7")]
	private bool MJBIAEOJIFD(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] MCCJOLAKNPC GHCCANLFLNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2504690", Offset = "0x2503490", VA = "0x182504690", Slot = "18")]
	private KDIJDIKDJEK LGJINNBFBDI([In] HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x2502F50", Offset = "0x2501D50", VA = "0x182502F50", Slot = "19")]
	private MMBOLDIBAHF<CHMLMGCOLME> GJEFDLGPGKH([In] HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO)
	{
		return default(MMBOLDIBAHF<CHMLMGCOLME>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x2502930", Offset = "0x2501730", VA = "0x182502930", Slot = "20")]
	private MMBOLDIBAHF<CHMLMGCOLME>? FBIOGLCIHPC([In] HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x2505AD0", Offset = "0x25048D0", VA = "0x182505AD0", Slot = "22")]
	private AEBHIPCIKGL MGJMBJKMKIN([In] HFJNFIGGNLC<AHIDBKDCADN> INONPKMEIIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x2501240", Offset = "0x2500040", VA = "0x182501240", Slot = "24")]
	private MMBOLDIBAHF<AHIDBKDCADN> NFGJIJKEJME(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] HFJNFIGGNLC<AHIDBKDCADN> LCAEJPCMEHF)
	{
		return default(MMBOLDIBAHF<AHIDBKDCADN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x2500F70", Offset = "0x24FFD70", VA = "0x182500F70", Slot = "38")]
	private OJCJNACIJDM AGIMBGBALIC(MMBOLDIBAHF<CHMLMGCOLME> FDFKGMJMPMO, [In] MCCJOLAKNPC GHCCANLFLNF)
	{
		return default(OJCJNACIJDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x25010E0", Offset = "0x24FFEE0", VA = "0x1825010E0", Slot = "50")]
	private PGOLMGNGGBM<EDALADINGLF.CGIKHGGGNKB, FDIBCACJGHL> KGFIIFFOKME([In] EDALADINGLF.KLKENFNIKIF EHEEIKICBAM)
	{
		return default(PGOLMGNGGBM<EDALADINGLF.CGIKHGGGNKB, FDIBCACJGHL>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x2502450", Offset = "0x2501250", VA = "0x182502450", Slot = "59")]
	private (List<HOGENKMMIOH>, bool) EFFJINADHIO([In] BEJBGLNAANG PHLBCOGAGAP, string MOBMLKIIAJP, [In] GCFHHJINGND GHADNDJKGPE, AHMLKICPGDI BDHABOFHKHD, DHLDGGEGFKD PGHLKDEOJJB)
	{
		return default((List<HOGENKMMIOH>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x2505E40", Offset = "0x2504C40", VA = "0x182505E40")]
	[CompilerGenerated]
	private LBJJALDPLNJ NDECMEGKIKJ(DPADDHBOMHL JELBMBFLBOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x2505F20", Offset = "0x2504D20", VA = "0x182505F20")]
	[CompilerGenerated]
	private IMCHGLPNCJE NLAFMPLFJAE(HFJNFIGGNLC<AHIDBKDCADN> JELBMBFLBOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x2501F00", Offset = "0x2500D00", VA = "0x182501F00")]
	[CompilerGenerated]
	private GDJJEFHKMHN DHFNLMGNPGM(HFJNFIGGNLC<CHMLMGCOLME> JELBMBFLBOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
public sealed class LBJJALDPLNJ : GIOJMNNFGKM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct ILGCFBEICHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<MMBOLDIBAHF<KPGCHBLJMLN>, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public LBJJALDPLNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public HFJNFIGGNLC<CHMLMGCOLME> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public HFJNFIGGNLC<AHIDBKDCADN> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public MMBOLDIBAHF<ECCLNDBJNAE> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private TaskAwaiter<PGOLMGNGGBM<MMBOLDIBAHF<KPGCHBLJMLN>, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x2521A30", Offset = "0x2520830", VA = "0x182521A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x2521CB0", Offset = "0x2520AB0", VA = "0x182521CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct EMEILJIMFBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<MMBOLDIBAHF<BNKJNPHLBPJ>, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public LBJJALDPLNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public HFJNFIGGNLC<CHMLMGCOLME> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public HFJNFIGGNLC<AHIDBKDCADN> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public MMBOLDIBAHF<ECCLNDBJNAE> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private TaskAwaiter<PGOLMGNGGBM<MMBOLDIBAHF<BNKJNPHLBPJ>, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x251EF80", Offset = "0x251DD80", VA = "0x18251EF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x251F200", Offset = "0x251E000", VA = "0x18251F200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private readonly DPADDHBOMHL GMCKPJCNABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private readonly JKEDJAFHKDJ KCHEJHIEEOH;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public TypeKey DAENGAMBMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0xAB5DD0", Offset = "0xAB4BD0", VA = "0x180AB5DD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public string CEPPBACOOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x25203F0", Offset = "0x251F1F0", VA = "0x1825203F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public DPADDHBOMHL CAECPHFJGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x2522780", Offset = "0x2521580", VA = "0x182522780")]
	public LBJJALDPLNJ(DPADDHBOMHL ECJADLADMNK, JKEDJAFHKDJ LNODLNHJPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x2522610", Offset = "0x2521410", VA = "0x182522610", Slot = "6")]
	[AsyncStateMachine(typeof(ILGCFBEICHF))]
	public Task<PGOLMGNGGBM<MMBOLDIBAHF<KPGCHBLJMLN>, HJBBDBHAMJJ>> OBONDLPFBKE(HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO, HFJNFIGGNLC<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, string PPKJBGAOBJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x25224A0", Offset = "0x25212A0", VA = "0x1825224A0", Slot = "7")]
	[AsyncStateMachine(typeof(EMEILJIMFBD))]
	public Task<PGOLMGNGGBM<MMBOLDIBAHF<BNKJNPHLBPJ>, HJBBDBHAMJJ>> DENIOCJFGJK(HFJNFIGGNLC<CHMLMGCOLME> FDFKGMJMPMO, HFJNFIGGNLC<AHIDBKDCADN> INONPKMEIIH, MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM, string PPKJBGAOBJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public sealed class HKJBHDNHDPC : MPCKAHAFFFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private readonly DPADDHBOMHL IFFADEBAIFJ;

	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private static readonly HashSet<DPADDHBOMHL> JFNOEFJGDBE;

	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private static readonly HashSet<DPADDHBOMHL> DBOJLFLFAGJ;

	[Cpp2IlInjected.Token(Token = "0x40002FB")]
	private static readonly HashSet<DPADDHBOMHL> PPGLNACCAJO;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public TypeKey HDKBAJIDJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x25216D0", Offset = "0x25204D0", VA = "0x1825216D0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool EJJGOJLPAGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x25216C0", Offset = "0x25204C0", VA = "0x1825216C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool HEJDIPNHHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x2521720", Offset = "0x2520520", VA = "0x182521720", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool GOEIIELNLNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x2521640", Offset = "0x2520440", VA = "0x182521640", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x2520180", Offset = "0x251EF80", VA = "0x182520180")]
	public bool HKMCBCIEBGP(string IPHILEOFJLB, [Out] HPAPIDOHPDK OEGIPGLJFDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	public HKJBHDNHDPC(DPADDHBOMHL MNCBDJMAFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x251FFF0", Offset = "0x251EDF0", VA = "0x18251FFF0")]
	internal static TypeKey GCGFHIHCMJP(DPADDHBOMHL OBDHBADPJNM)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x25203F0", Offset = "0x251F1F0", VA = "0x1825203F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E2")]
public readonly struct CEMLGGIKLJN : PKBKOICGLPG.IKLIGLDOJCC<EAAKFALPLDL, ENLEGHEGALI>
{
	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x251D8D0", Offset = "0x251C6D0", VA = "0x18251D8D0", Slot = "4")]
	public int DEBMIBJOFMK(ENLEGHEGALI BHICHJIFLJC, EAAKFALPLDL OOCJAOHFGJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x251D960", Offset = "0x251C760", VA = "0x18251D960", Slot = "5")]
	public EAAKFALPLDL JAEKGBCJMIF(ENLEGHEGALI BHICHJIFLJC, EAAKFALPLDL OOCJAOHFGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x251D8F0", Offset = "0x251C6F0", VA = "0x18251D8F0", Slot = "6")]
	public EAAKFALPLDL ELCKMBOOJCJ(ENLEGHEGALI BHICHJIFLJC, EAAKFALPLDL OOCJAOHFGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x251D940", Offset = "0x251C740", VA = "0x18251D940", Slot = "7")]
	public IReadOnlyList<EAAKFALPLDL> GLOKJGIJMMF(ENLEGHEGALI BHICHJIFLJC, EAAKFALPLDL OOCJAOHFGJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x251D8C0", Offset = "0x251C6C0", VA = "0x18251D8C0", Slot = "8")]
	public EAAKFALPLDL[] DDLOGMMOPEG(ENLEGHEGALI BHICHJIFLJC, EAAKFALPLDL OOCJAOHFGJK, int IPMFBIMMKJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x251D970", Offset = "0x251C770", VA = "0x18251D970", Slot = "9")]
	public bool KEMADKAECGN(ENLEGHEGALI BHICHJIFLJC, EAAKFALPLDL OOCJAOHFGJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x251D990", Offset = "0x251C790", VA = "0x18251D990", Slot = "10")]
	public bool LLLBAKLNHEH(ENLEGHEGALI BHICHJIFLJC, EAAKFALPLDL OOCJAOHFGJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x251D8A0", Offset = "0x251C6A0", VA = "0x18251D8A0", Slot = "11")]
	public bool BLHBADOEFBD(ENLEGHEGALI BHICHJIFLJC, EAAKFALPLDL OOCJAOHFGJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x251D920", Offset = "0x251C720", VA = "0x18251D920", Slot = "12")]
	public bool FGDENCMJAHN(ENLEGHEGALI BHICHJIFLJC, EAAKFALPLDL OOCJAOHFGJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x251D9B0", Offset = "0x251C7B0", VA = "0x18251D9B0", Slot = "13")]
	public bool MOBNDCHJCAA(ENLEGHEGALI NJKIHEOCFHI, EAAKFALPLDL OOCJAOHFGJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x251D880", Offset = "0x251C680", VA = "0x18251D880", Slot = "14")]
	public bool BKIAIGMGPEN(ENLEGHEGALI BHICHJIFLJC, EAAKFALPLDL OOCJAOHFGJK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public abstract class LMCELBHNMNL : HLAHDHHBGFE
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public EEHDKMFBCJI.IMGOLDIPFAM IHIDHCMLAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x2522BD0", Offset = "0x25219D0", VA = "0x182522BD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public abstract KGPBDMEACIL.FGCLOGGHAKL FOAFMFCHBOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract CCBLBBOJEHP.OPDNBOHNCDO HNAGHFBGLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public abstract HJKKBPDPHBE.GAFJEOJBDBK MGIHOOBMOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public LNLOKMHCLCK.MPDIIICCGGC<DJBJCCKDIDJ, EAAKFALPLDL, CCBLBBOJEHP> KAHHCNGOBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x2522C20", Offset = "0x2521A20", VA = "0x182522C20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public abstract MDDBEOAOGLK CLDLBFJIHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public abstract GJPFNNNDHPI DBCFOAPAOBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public abstract CEBIGFNNOKO ANEHNLPAJDC
	{
		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract KBIOFEKHPDF BLLMJCLKOFH
	{
		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract DKMNPKCKKKI MFJLNOKBMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	protected LMCELBHNMNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public sealed class KJLJOHMMAGP : DAAFLKNEFAC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private struct FENEANDLCGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<object, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public KJLJOHMMAGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public EAAKFALPLDL action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private TaskAwaiter<PGOLMGNGGBM<object, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x251F270", Offset = "0x251E070", VA = "0x18251F270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x251F510", Offset = "0x251E310", VA = "0x18251F510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct AKKELGIKAIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public AsyncTaskMethodBuilder<PGOLMGNGGBM<PHFHNLJGMNL, HJBBDBHAMJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public KJLJOHMMAGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public IReadOnlyList<EAAKFALPLDL> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter<PGOLMGNGGBM<object, HJBBDBHAMJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x251D470", Offset = "0x251C270", VA = "0x18251D470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x251D7F0", Offset = "0x251C5F0", VA = "0x18251D7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FC")]
	private readonly FMLCFIPPIMP IIIFCFKCAOI;

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x8FE740", Offset = "0x8FD540", VA = "0x1808FE740")]
	public KJLJOHMMAGP(FMLCFIPPIMP POAJLCGJBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x2522370", Offset = "0x2521170", VA = "0x182522370")]
	[AsyncStateMachine(typeof(FENEANDLCGH))]
	private Task<PGOLMGNGGBM<object, HJBBDBHAMJJ>> BNAIIDEPKCK(EAAKFALPLDL OOCJAOHFGJK, bool EAJAGGAKOMP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x2522240", Offset = "0x2521040", VA = "0x182522240", Slot = "4")]
	[AsyncStateMachine(typeof(AKKELGIKAIK))]
	public Task<PGOLMGNGGBM<PHFHNLJGMNL, HJBBDBHAMJJ>> ALNGHGINJFM(IReadOnlyList<EAAKFALPLDL> KIJMGDBLMOF, bool EAJAGGAKOMP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
public struct MAKEDNLEGEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	internal HAMCBEKBCDB<PDKBDCEAHIH, HFJNFIGGNLC<PDKBDCEAHIH.EEPHOEHCIOP>, EAAKFALPLDL, JDGHHHPHGCG> IFFADEBAIFJ;

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x24E0CD0", Offset = "0x24DFAD0", VA = "0x1824E0CD0")]
	private MAKEDNLEGEP([In] HAMCBEKBCDB<PDKBDCEAHIH, HFJNFIGGNLC<PDKBDCEAHIH.EEPHOEHCIOP>, EAAKFALPLDL, JDGHHHPHGCG> FLIIGJENNMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x2522F20", Offset = "0x2521D20", VA = "0x182522F20")]
	public static MAKEDNLEGEP MKHEJJEDOII()
	{
		return default(MAKEDNLEGEP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public static class GAFOHNLJNCI
{
	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static HAMCBEKBCDB<PDKBDCEAHIH, HFJNFIGGNLC<PDKBDCEAHIH.EEPHOEHCIOP>, EAAKFALPLDL, JDGHHHPHGCG> GOELIMIGNPD(this MAKEDNLEGEP DJAJDIFOIHP)
	{
		return default(HAMCBEKBCDB<PDKBDCEAHIH, HFJNFIGGNLC<PDKBDCEAHIH.EEPHOEHCIOP>, EAAKFALPLDL, JDGHHHPHGCG>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public struct JDGHHHPHGCG : CDBGEGGDAGG.FIMOJLPOEKL<PDKBDCEAHIH, HFJNFIGGNLC<PDKBDCEAHIH.EEPHOEHCIOP>, EAAKFALPLDL>
{
	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x2521D30", Offset = "0x2520B30", VA = "0x182521D30", Slot = "7")]
	public EAAKFALPLDL FLNKCLLLGCA(PDKBDCEAHIH[] JJABPPNKPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x10B2F50", Offset = "0x10B1D50", VA = "0x1810B2F50")]
	public HFJNFIGGNLC<PDKBDCEAHIH.EEPHOEHCIOP> OBHNMLAKEMI([In] PDKBDCEAHIH NEHEDNNDNFI)
	{
		return default(HFJNFIGGNLC<PDKBDCEAHIH.EEPHOEHCIOP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0xF0A020", Offset = "0xF08E20", VA = "0x180F0A020")]
	public int JMOOMJKNOLJ([In] PDKBDCEAHIH JLODLPOJJEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x2521D20", Offset = "0x2520B20", VA = "0x182521D20")]
	public int NPINCEPMNCH([In] PDKBDCEAHIH NEHEDNNDNFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0xF0A020", Offset = "0xF08E20", VA = "0x180F0A020", Slot = "4")]
	private int FAACIKDNKHL([In] PDKBDCEAHIH NEHEDNNDNFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x2521D20", Offset = "0x2520B20", VA = "0x182521D20", Slot = "5")]
	private int FEJLPNFDOFL([In] PDKBDCEAHIH NEHEDNNDNFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x10B2F50", Offset = "0x10B1D50", VA = "0x1810B2F50", Slot = "6")]
	private HFJNFIGGNLC<PDKBDCEAHIH.EEPHOEHCIOP> DJDKAFBMALI([In] PDKBDCEAHIH NEHEDNNDNFI)
	{
		return default(HFJNFIGGNLC<PDKBDCEAHIH.EEPHOEHCIOP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public struct KHBNPODOKIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400030C")]
	internal BOKLDJDKJNN<FBAIGOIMJFO, EAAKFALPLDL, IHECAKNGNPJ> IFFADEBAIFJ;

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x24E0CD0", Offset = "0x24DFAD0", VA = "0x1824E0CD0")]
	private KHBNPODOKIC([In] BOKLDJDKJNN<FBAIGOIMJFO, EAAKFALPLDL, IHECAKNGNPJ> BNGNHJJNDPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x25221E0", Offset = "0x2520FE0", VA = "0x1825221E0")]
	public static KHBNPODOKIC MKHEJJEDOII()
	{
		return default(KHBNPODOKIC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
public static class POCAOPFJANC
{
	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510")]
	public static BOKLDJDKJNN<FBAIGOIMJFO, EAAKFALPLDL, IHECAKNGNPJ> GOELIMIGNPD(this KHBNPODOKIC DJAJDIFOIHP)
	{
		return default(BOKLDJDKJNN<FBAIGOIMJFO, EAAKFALPLDL, IHECAKNGNPJ>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000ED")]
public struct IHECAKNGNPJ : LMACLINOOPB.LMAGJFJLIKM<FBAIGOIMJFO, EAAKFALPLDL>
{
	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7E10", Offset = "0x1EF6C10", VA = "0x181EF7E10")]
	public int ODMKFJLMJBM([In] FBAIGOIMJFO JLODLPOJJEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x2521840", Offset = "0x2520640", VA = "0x182521840", Slot = "5")]
	public EAAKFALPLDL AABIHFJCAIM(FBAIGOIMJFO[] JLEOJFBODJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x1EF7E10", Offset = "0x1EF6C10", VA = "0x181EF7E10", Slot = "4")]
	private int DBCDBIOIHGK([In] FBAIGOIMJFO JLODLPOJJEB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
public class CJBLJJFIFLF : MFMDDJMMGHP, FDIBCACJGHL, HJBBDBHAMJJ, EOABGNINGBC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000310")]
	private readonly EOABGNINGBC? NBPPMDIDEON;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public HEPJDFKAIEG MNBCHBNGHEC
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE20", Offset = "0x8F9C20", VA = "0x1808FAE20", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(HEPJDFKAIEG);
		}
		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x8FAE10", Offset = "0x8F9C10", VA = "0x1808FAE10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public override EOABGNINGBC? DHBLLBIHHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x251DB50", Offset = "0x251C950", VA = "0x18251DB50", Slot = "7")]
	public override string KMIKCFPGPHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x251DC60", Offset = "0x251CA60", VA = "0x18251DC60")]
	private CJBLJJFIFLF(HEPJDFKAIEG NCGEJMOHJLG, EOABGNINGBC? DCHKEALMEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x251D9F0", Offset = "0x251C7F0", VA = "0x18251D9F0")]
	public static CJBLJJFIFLF ECDJOEBKOEF(EOABGNINGBC DCHKEALMEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x251DAE0", Offset = "0x251C8E0", VA = "0x18251DAE0")]
	public static CJBLJJFIFLF JLNFFKKLADP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x251DA70", Offset = "0x251C870", VA = "0x18251DA70")]
	public static CJBLJJFIFLF HEJEJEPAIKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public static class CFDJCLHLLEF
{
	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x30FBB10", Offset = "0x30FA910", VA = "0x1830FBB10")]
	public static PGOLMGNGGBM<TOk, FDIBCACJGHL> BHGGBHOIPCO<TOk>([In] this PGOLMGNGGBM<TOk, FDIBCACJGHL> DJAJDIFOIHP, EOABGNINGBC DCHKEALMEKF) where TOk : notnull
	{
		return default(PGOLMGNGGBM<TOk, FDIBCACJGHL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x30FBCF0", Offset = "0x30FAAF0", VA = "0x1830FBCF0")]
	public static PGOLMGNGGBM<TOk?, FDIBCACJGHL?> NBHKMJAJHGL<TOk>([In] this PGOLMGNGGBM<TOk, FDIBCACJGHL> DJAJDIFOIHP)
	{
		return default(PGOLMGNGGBM<TOk, FDIBCACJGHL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x30FBC00", Offset = "0x30FAA00", VA = "0x1830FBC00")]
	public static PGOLMGNGGBM<TOk?, FDIBCACJGHL?> MHNCEDJBOLJ<TOk>([In] this PGOLMGNGGBM<TOk, FDIBCACJGHL> DJAJDIFOIHP)
	{
		return default(PGOLMGNGGBM<TOk, FDIBCACJGHL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F1")]
public interface MDDBEOAOGLK
{
	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LBENPCIJLLD([In] PGOLMGNGGBM<ENLEGHEGALI, EOABGNINGBC> LDEANEOLAOA);
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public static class NEFKBBBHGMH
{
	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x3456150", Offset = "0x3454F50", VA = "0x183456150")]
	public static bool LBENPCIJLLD<TOk, TErr>(this MDDBEOAOGLK DJAJDIFOIHP, [In] PGOLMGNGGBM<TOk, TErr> LDEANEOLAOA) where TOk : notnull where TErr : notnull, EOABGNINGBC
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
public interface GJPFNNNDHPI
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	FCLMHDBMGIM HELGJIPGFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
public interface CEBIGFNNOKO
{
	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CGBHHFFMFPE DBANNCBDMBG(int AIIAALEAOJN);
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public interface FGILHNOBHBE
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x600058A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public interface KIGMOBPGECC
{
	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GBKOIANCBAE? BDBMLKFCPCO(MMBOLDIBAHF<ECCLNDBJNAE> EHNIHKFDBPM);
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public interface MFANDIDNMAN
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public interface GBKOIANCBAE
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	string HIGBIGGFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MFANDIDNMAN? ODBFKINHDAO(MMBOLDIBAHF<KPGCHBLJMLN> NIEPNOBACFJ);

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FGILHNOBHBE? OFMGBNABFOA(MMBOLDIBAHF<BNKJNPHLBPJ> EHHJINIOJIN);
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public interface KBIOFEKHPDF
{
	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> GHGPIBNLLEJ(string IPHILEOFJLB, string MOBMLKIIAJP);
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface DKMNPKCKKKI
{
	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KIGMOBPGECC? CBDJLLHJKPB([In] HFJNFIGGNLC<MIEFPPNINJG> KGEJKJHMGOM);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public sealed class DNNIOMCOJDD
{
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	private struct OMFEOEHAPBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public int OFCLDJHOLLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public BGMBPJPBIDA? DCODLMLJCOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public BGMBPJPBIDA? LBLMNCNLNFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public readonly List<EAAKFALPLDL> GPFOJKOEGAE;

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x25232D0", Offset = "0x25220D0", VA = "0x1825232D0")]
		private OMFEOEHAPBO(int KNCPCNBMDNF, BGMBPJPBIDA? GGHHPOPMHIH, BGMBPJPBIDA? JHLLIPNGLED, List<EAAKFALPLDL> KIJMGDBLMOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x2523210", Offset = "0x2522010", VA = "0x182523210")]
		public static OMFEOEHAPBO MKHEJJEDOII()
		{
			return default(OMFEOEHAPBO);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000313")]
	private readonly GNFPFPHGAPI<OMFEOEHAPBO> JFLLJOOFADL;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public static DNNIOMCOJDD GGJCMHODIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x251E960", Offset = "0x251D760", VA = "0x18251E960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool ENJHIPIKKPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0xB4A960", Offset = "0xB49760", VA = "0x180B4A960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0xB4BD60", Offset = "0xB4AB60", VA = "0x180B4BD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x251ED10", Offset = "0x251DB10", VA = "0x18251ED10")]
	public void NMKKGKAMCFJ(AJACNMDPIMM JHLLIPNGLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x251E660", Offset = "0x251D460", VA = "0x18251E660")]
	public void DGLPAAPFHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x251E9B0", Offset = "0x251D7B0", VA = "0x18251E9B0")]
	private static string? JPHIGHHDGMN([In] OMFEOEHAPBO LMKNHOPMHLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x251EED0", Offset = "0x251DCD0", VA = "0x18251EED0")]
	public DNNIOMCOJDD()
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
