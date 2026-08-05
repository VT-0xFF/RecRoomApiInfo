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
		[Cpp2IlInjected.Address(RVA = "0x7E57E0", Offset = "0x7E49E0", VA = "0x1807E57E0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1DA5190", Offset = "0x1DA4390", VA = "0x181DA5190")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C40", Offset = "0x7E4E40", VA = "0x1807E5C40")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5C80", Offset = "0x7E4E80", VA = "0x1807E5C80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class FNBPJGFILDN : IDisposable, CBJBNKFLGHK, KOOMEOOHFDB, GHMBBHJIKOD, IDKHHBHIMDP
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class PLOJEFJBEFL : AIODEBHCMHF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int IEMGINALNAK
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1DA6F40", Offset = "0x1DA6140", VA = "0x181DA6F40", Slot = "5")]
		public LOHNCJMLFJL LHHAPPEMKLJ(JKFDEPKPCOO.GGBKPCLHEHB ECDJFINNJIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void GMJMGLNEAOM();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void DKNBGGGAKCB();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1DA6E00", Offset = "0x1DA6000", VA = "0x181DA6E00", Slot = "13")]
		public virtual void AMHFHAFGDMM(FNBPJGFILDN ONJFHIILPIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1DA6E80", Offset = "0x1DA6080", VA = "0x181DA6E80", Slot = "14")]
		public virtual void LALOHGOKMGI(FNBPJGFILDN ONJFHIILPIE, GFABBJEKLJG CEBHNDLCHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		protected PLOJEFJBEFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface AIODEBHCMHF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int IEMGINALNAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LOHNCJMLFJL LHHAPPEMKLJ(JKFDEPKPCOO.GGBKPCLHEHB ECDJFINNJIE);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GMJMGLNEAOM();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DKNBGGGAKCB();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AMHFHAFGDMM(FNBPJGFILDN ONJFHIILPIE);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void LALOHGOKMGI(FNBPJGFILDN ONJFHIILPIE, GFABBJEKLJG CEBHNDLCHED);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct KOPEPADDNAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly KFOBLBCKJEC<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN, CMJGBBOLMCF.MPBGOOCJJMA<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN>> EPECBIPPACC;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1DA28E0", Offset = "0x1DA1AE0", VA = "0x181DA28E0")]
		internal KOPEPADDNAI(KFOBLBCKJEC<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN, CMJGBBOLMCF.MPBGOOCJJMA<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN>> BFLJLPICFCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class BJEHGGDKHIJ : CMJGBBOLMCF.MPBGOOCJJMA<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly BJEHGGDKHIJ MJANIPKLNPJ;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		private BJEHGGDKHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAC2850", Offset = "0xAC1A50", VA = "0x180AC2850", Slot = "4")]
		public JFONOMFMEKP GICCMFOGOAN(GFABBJEKLJG KPBGCHDNDLM)
		{
			return default(JFONOMFMEKP);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1D93520", Offset = "0x1D92720", VA = "0x181D93520", Slot = "5")]
		public void AMHFHAFGDMM(FNBPJGFILDN EAMCHADGEIB, GFABBJEKLJG CEBHNDLCHED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1D93630", Offset = "0x1D92830", VA = "0x181D93630", Slot = "6")]
		public void LALOHGOKMGI(FNBPJGFILDN EAMCHADGEIB, GFABBJEKLJG CEBHNDLCHED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct LPLHCNIEPDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public KPFNCFLBNFC<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN, CMJGBBOLMCF.MPBGOOCJJMA<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN>> EPECBIPPACC;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1DA3690", Offset = "0x1DA2890", VA = "0x181DA3690")]
		internal LPLHCNIEPDC(KPFNCFLBNFC<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN, CMJGBBOLMCF.MPBGOOCJJMA<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN>> BFLJLPICFCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1DA3640", Offset = "0x1DA2840", VA = "0x181DA3640")]
		public static LPLHCNIEPDC GOMGEEBODDD()
		{
			return default(LPLHCNIEPDC);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct GLHJCCKAEKF : HBOOKNPCBKB.EHLOEBPABHB<CEIKCEJFMBI, GFABBJEKLJG, FNBPJGFILDN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct ADIMOOJMBDL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public FNBPJGFILDN receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public GFABBJEKLJG action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public GLHJCCKAEKF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1D8A8E0", Offset = "0x1D89AE0", VA = "0x181D8A8E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1D8AAC0", Offset = "0x1D89CC0", VA = "0x181D8AAC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAC2850", Offset = "0xAC1A50", VA = "0x180AC2850", Slot = "4")]
		public IJMPLGOCAIG<CEIKCEJFMBI> DOMPLANOFHO(FNBPJGFILDN CJEFKAMCPLH)
		{
			return default(IJMPLGOCAIG<CEIKCEJFMBI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1D9D6F0", Offset = "0x1D9C8F0", VA = "0x181D9D6F0", Slot = "5")]
		[AsyncStateMachine(typeof(ADIMOOJMBDL))]
		public Task<BLNBDNPDEEM<object, NGDCAOKOLMO>> OCDIAEAKAFO(FNBPJGFILDN CJEFKAMCPLH, GFABBJEKLJG CEBHNDLCHED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1D9D6D0", Offset = "0x1D9C8D0", VA = "0x181D9D6D0", Slot = "6")]
		public GFABBJEKLJG[] LLOLPDDIHGL(FNBPJGFILDN CJEFKAMCPLH)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GOGGNLIKKBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<bool, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FNBPJGFILDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public GLPPJOHAHLM rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public LNMBGNPCGOG circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public EKCGLIJJMGJ superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<BLNBDNPDEEM<bool, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1D9D820", Offset = "0x1D9CA20", VA = "0x181D9D820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1D9DAA0", Offset = "0x1D9CCA0", VA = "0x181D9DAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct HAPCCJCELND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<bool, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public FNBPJGFILDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<BLNBDNPDEEM<bool, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1D9DC90", Offset = "0x1D9CE90", VA = "0x181D9DC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1D9DF20", Offset = "0x1D9D120", VA = "0x181D9DF20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct GBCBDGINEDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public FNBPJGFILDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1D9D220", Offset = "0x1D9C420", VA = "0x181D9D220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1D9D400", Offset = "0x1D9C600", VA = "0x181D9D400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GBPCKDJNCHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public FNBPJGFILDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public GFABBJEKLJG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1D9D470", Offset = "0x1D9C670", VA = "0x181D9D470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1D9D660", Offset = "0x1D9C860", VA = "0x181D9D660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MMIMIFFMKFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public FNBPJGFILDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<BLNBDNPDEEM<bool, NGDCAOKOLMO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1DA3700", Offset = "0x1DA2900", VA = "0x181DA3700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1DA3EF0", Offset = "0x1DA30F0", VA = "0x181DA3EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IJMPLGOCAIG<CEIKCEJFMBI> GGNAIKALDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly KOPEPADDNAI CMGOAOMCCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LPNLFLPHKOD HFJBGFBOABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly ADADJDIPOJD HOCCFBLJDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1030")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly JFJMFHHMLJN DFMLHGLOAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1038")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly FDNAGLPJLED.DMCOBAOBDCA KNPJLKHNMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1058")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly KCCOBEHPEDA OHAODEBMLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1060")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly JMMELGEPHME KDNCLJMJLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1068")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly OAMJEOIIBCH KBEAHDGMIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1070")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly ECGHJJINALF MCMMIPELDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1078")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private DDACHCOMDOC MPHAPOFAHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1088")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private PBGMLLOAOBA GKFKHOBIDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10A8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly LPNLFLPHKOD.DHHLJBKBAAD EOJNFCOMFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10B0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly JDIJLIEFLBC EPGGKHJEPHN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public LPNLFLPHKOD JMPIFMNOGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1D9C7D0", Offset = "0x1D9B9D0", VA = "0x181D9C7D0")]
		get
		{
			return default(LPNLFLPHKOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal AIODEBHCMHF IACNPKMOKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1D9C780", Offset = "0x1D9B980", VA = "0x181D9C780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal LOHNCJMLFJL BFEKEJOHKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1D9CB90", Offset = "0x1D9BD90", VA = "0x181D9CB90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1D9C6E0", Offset = "0x1D9B8E0", VA = "0x181D9C6E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool FNMNCNKKGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1D9CB80", Offset = "0x1D9BD80", VA = "0x181D9CB80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1D9CB70", Offset = "0x1D9BD70", VA = "0x181D9CB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public GOCFJBPFCNB PPKOJDCONNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1D9CEC0", Offset = "0x1D9C0C0", VA = "0x181D9CEC0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GOADEFPFPNH NMNKJJBKJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1D9CEE0", Offset = "0x1D9C0E0", VA = "0x181D9CEE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LLDGIOJNCEP FBCHAAGKJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D9CEF0", Offset = "0x1D9C0F0", VA = "0x181D9CEF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DIBPGOMADEL MFGEFOFBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1D9CED0", Offset = "0x1D9C0D0", VA = "0x181D9CED0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private JJIKOOMAOKJ? AJMOPFHOLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1D9BCC0", Offset = "0x1D9AEC0", VA = "0x181D9BCC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private IDKBGAMJALG? NBKFBCPPLDM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1D9B6D0", Offset = "0x1D9A8D0", VA = "0x181D9B6D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1D9CBA0", Offset = "0x1D9BDA0", VA = "0x181D9CBA0")]
	private FNBPJGFILDN(JFJMFHHMLJN NKDHCPOIGEJ, IJMPLGOCAIG<CEIKCEJFMBI> GMBNCAOLOEM, [In] KOPEPADDNAI AIOENBDOPHG, [In] LPNLFLPHKOD ODIPEKDICEN, [In] ADADJDIPOJD BBCJNFHPOKD, LOHNCJMLFJL GHODAKPHDGJ, [In] FDNAGLPJLED.DMCOBAOBDCA KOKLABDNHHE, LPNLFLPHKOD.DHHLJBKBAAD CFOJCNJGEMI, JDIJLIEFLBC GKOHDAHLFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D9C250", Offset = "0x1D9B450", VA = "0x181D9C250")]
	public static FNBPJGFILDN GOMGEEBODDD(JFJMFHHMLJN ECDJFINNJIE, LPNLFLPHKOD.OKGFDLMDOMM BMIODCPEMAF, IJMPLGOCAIG<CEIKCEJFMBI> GMBNCAOLOEM, IJMPLGOCAIG<APCCKMJMPBA> GFDCJICAEHO, OJPAADNIADI LNMNAOOCBEN, MFNBDMHIHOH EFKCOFCMJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D9BF70", Offset = "0x1D9B170", VA = "0x181D9BF70")]
	public static FNBPJGFILDN GOMGEEBODDD(JFJMFHHMLJN NKDHCPOIGEJ, [In] LPNLFLPHKOD ODIPEKDICEN, [In] ADADJDIPOJD BBCJNFHPOKD, IJMPLGOCAIG<CEIKCEJFMBI> GMBNCAOLOEM, IJMPLGOCAIG<APCCKMJMPBA> GFDCJICAEHO, OJPAADNIADI LNMNAOOCBEN, MFNBDMHIHOH EFKCOFCMJML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1D9B880", Offset = "0x1D9AA80", VA = "0x181D9B880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1D9BA70", Offset = "0x1D9AC70", VA = "0x181D9BA70")]
	[AsyncStateMachine(typeof(GOGGNLIKKBK))]
	internal Task<BLNBDNPDEEM<bool, NGDCAOKOLMO>> EKACJOOHHFD(GLPPJOHAHLM MILEALDCLGB, LNMBGNPCGOG KMPEDLCINIF, EKCGLIJJMGJ GEFOMNELNJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1D9BBD0", Offset = "0x1D9ADD0", VA = "0x181D9BBD0")]
	[AsyncStateMachine(typeof(HAPCCJCELND))]
	public Task<BLNBDNPDEEM<bool, NGDCAOKOLMO>> EOENIDGMJPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D9B5E0", Offset = "0x1D9A7E0", VA = "0x181D9B5E0")]
	[AsyncStateMachine(typeof(GBCBDGINEDP))]
	public Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> CKHMIEHEEKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1D9C3B0", Offset = "0x1D9B5B0", VA = "0x181D9C3B0")]
	internal void HMCHGEAGBCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D9B800", Offset = "0x1D9AA00", VA = "0x181D9B800")]
	internal CKBGFGHPBIC<GFABBJEKLJG> DLNBJJKKPGA([In] HLKGPMPGGBE MMLCOICEKEA)
	{
		return default(CKBGFGHPBIC<GFABBJEKLJG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1D9BDF0", Offset = "0x1D9AFF0", VA = "0x181D9BDF0")]
	internal bool FOLMKGOIONP([In] HLKGPMPGGBE MMLCOICEKEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1D9C700", Offset = "0x1D9B900", VA = "0x181D9C700")]
	internal CKBGFGHPBIC<GFABBJEKLJG> JJEHKBHFKBN([In] CGJBIEAJEAP AOJGKHJIPGH)
	{
		return default(CKBGFGHPBIC<GFABBJEKLJG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1D9BE60", Offset = "0x1D9B060", VA = "0x181D9BE60")]
	[AsyncStateMachine(typeof(GBPCKDJNCHH))]
	internal Task<BLNBDNPDEEM<object, NGDCAOKOLMO>> GBHAGJNMALO(GFABBJEKLJG CEBHNDLCHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1D9C7E0", Offset = "0x1D9B9E0", VA = "0x181D9C7E0")]
	private GFABBJEKLJG[] LLOLPDDIHGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1D9C5C0", Offset = "0x1D9B7C0", VA = "0x181D9C5C0")]
	[AsyncStateMachine(typeof(MMIMIFFMKFH))]
	public Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> IKODDDLLKIF(Guid OBENJPGNOFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class IAEAPICNPCP
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x27B12B0", Offset = "0x27B04B0", VA = "0x1827B12B0")]
	public static CMCGHIJBNJE<(TPrev?, FNBPJGFILDN?), IDKBGAMJALG> HCBIFPFPMGL<TPrev>([In] this CMCGHIJBNJE<TPrev, FNBPJGFILDN> KPBGCHDNDLM)
	{
		return default(CMCGHIJBNJE<(TPrev, FNBPJGFILDN), IDKBGAMJALG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x27B1050", Offset = "0x27B0250", VA = "0x1827B1050")]
	public static CMCGHIJBNJE<TPrev?, FNBPJGFILDN?> GGGIHDFBNKO<TPrev>([In] this CMCGHIJBNJE<TPrev, FNBPJGFILDN> KPBGCHDNDLM)
	{
		return default(CMCGHIJBNJE<TPrev, FNBPJGFILDN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class LECEOKHBMCD<TData> : EICMLFAAIEJ, ADPPGMNMAJE, CHOGLKODFOC where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JJGAGGDHEOK<CNEFPEIGAAA>? BMMIACLHGEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string FANNLPKLMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData DOMOOIMCODE;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JJGAGGDHEOK<CNEFPEIGAAA>? IALIHGHENJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1F652E0", Offset = "0x1F644E0", VA = "0x181F652E0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D60", Offset = "0x7C0F60", VA = "0x1807C1D60", Slot = "7")]
	public override string OKCJCMAJCGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3C156A0", Offset = "0x3C148A0", VA = "0x183C156A0")]
	internal LECEOKHBMCD([In] JJGAGGDHEOK<CNEFPEIGAAA>? AHCMBHFBBJG, IJMPLGOCAIG<LHBCDNLAFEP>? OMKLNEPEOCN, IOKind? LKOADHBLPFA, string LFMFEFFGFLH, [In] TData GKNJGNIHLDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class AELFHHNCGMI
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1D8AB30", Offset = "0x1D89D30", VA = "0x181D8AB30")]
	public static BLNBDNPDEEM<AOKAFMIHLPF, ADPPGMNMAJE> NOCLMHBKIDB([In] this LHKBNINAJAB<FDAPAEIJOOJ> OAAEOCHEJIA)
	{
		return default(BLNBDNPDEEM<AOKAFMIHLPF, ADPPGMNMAJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2D4F100", Offset = "0x2D4E300", VA = "0x182D4F100")]
	public static BLNBDNPDEEM<TOk, ADPPGMNMAJE> AOHCAJHGNKB<TOk>([In] this BLNBDNPDEEM<TOk, ADPPGMNMAJE> KPBGCHDNDLM, [In] JJGAGGDHEOK<CNEFPEIGAAA>? AHCMBHFBBJG, IJMPLGOCAIG<LHBCDNLAFEP>? OMKLNEPEOCN, IOKind? LKOADHBLPFA, string LFMFEFFGFLH) where TOk : notnull
	{
		return default(BLNBDNPDEEM<TOk, ADPPGMNMAJE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface JFJMFHHMLJN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	NNGNCBFENCB.NOALEMLEOMN OOHNOBGEPFG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	JKFDEPKPCOO.GGBKPCLHEHB EAIKKEMFHNE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	FNBPJGFILDN.AIODEBHCMHF FINPHKANEFK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	GPFAAHLMODN.INMMNOCHLPF NIPOELLPJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	CMJGBBOLMCF.MPBGOOCJJMA<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN> JBMHGFCBPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MHGAHEKEAGE JPEKFOPEJCH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PPNPLKCOJDJ MBLKLFNDBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	GNNFEJEGGMM ILDHKNKCHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	CGKODALMLJD HJFDMBEEMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	FKCCMCACDOG LKEKIKJDFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CBMAFACBFHB
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1D94230", Offset = "0x1D93430", VA = "0x181D94230")]
	public static GFABBJEKLJG GGFMAMCKGCG(this GFABBJEKLJG KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D94340", Offset = "0x1D93540", VA = "0x181D94340")]
	public static GFABBJEKLJG GKBONBLHLGO(this FIDPAOFANEE KPBGCHDNDLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct FIDPAOFANEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct CIAGANFKBIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public FNBPJGFILDN root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public FIDPAOFANEE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1D94C00", Offset = "0x1D93E00", VA = "0x181D94C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1D94EC0", Offset = "0x1D940C0", VA = "0x181D94EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString FMINBKHGIKA;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x947980", Offset = "0x946B80", VA = "0x180947980")]
	private FIDPAOFANEE(ByteString AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1D9B220", Offset = "0x1D9A420", VA = "0x181D9B220")]
	public static GFABBJEKLJG LHDIKPNFFNE(ByteString AFCGKMGKPEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1D9B060", Offset = "0x1D9A260", VA = "0x181D9B060")]
	public static NHNCPMGLFBJ<JFONOMFMEKP, FIDPAOFANEE> EAKOLOGIIJC(GFABBJEKLJG KIDMNFEEABK)
	{
		return default(NHNCPMGLFBJ<JFONOMFMEKP, FIDPAOFANEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1D9B110", Offset = "0x1D9A310", VA = "0x181D9B110")]
	[AsyncStateMachine(typeof(CIAGANFKBIE))]
	public static Task<BLNBDNPDEEM<object, NGDCAOKOLMO>> GBHAGJNMALO(FNBPJGFILDN EAMCHADGEIB, FIDPAOFANEE KPBGCHDNDLM)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct EICEJIOLIBH
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1D97D20", Offset = "0x1D96F20", VA = "0x181D97D20")]
	public static GFABBJEKLJG LHDIKPNFFNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1D97CB0", Offset = "0x1D96EB0", VA = "0x181D97CB0")]
	public static NHNCPMGLFBJ<JFONOMFMEKP, EICEJIOLIBH> EAKOLOGIIJC(GFABBJEKLJG KIDMNFEEABK)
	{
		return default(NHNCPMGLFBJ<JFONOMFMEKP, EICEJIOLIBH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1D97C30", Offset = "0x1D96E30", VA = "0x181D97C30")]
	public static BLNBDNPDEEM<PGENBOHGKNI, DLKKNPCBHBE> CIBAIPAFHOL(FNBPJGFILDN EAMCHADGEIB, [In] EICEJIOLIBH KPBGCHDNDLM)
	{
		return default(BLNBDNPDEEM<PGENBOHGKNI, DLKKNPCBHBE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct JGHEDABDODB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct OPODFNBMGBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, DLKKNPCBHBE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public FNBPJGFILDN root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public JGHEDABDODB self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private BLNBDNPDEEM<PGENBOHGKNI, DLKKNPCBHBE> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1DA60B0", Offset = "0x1DA52B0", VA = "0x181DA60B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1DA6420", Offset = "0x1DA5620", VA = "0x181DA6420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly GLPPJOHAHLM? GILFJNHJICM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly LNMBGNPCGOG? EPOCLMOPIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly EKCGLIJJMGJ? FMFNGAEJMID;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1AED9E0", Offset = "0x1AECBE0", VA = "0x181AED9E0")]
	private JGHEDABDODB(GLPPJOHAHLM? MILEALDCLGB, LNMBGNPCGOG? KMPEDLCINIF, EKCGLIJJMGJ? GEFOMNELNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1A50", Offset = "0x1DA0C50", VA = "0x181DA1A50")]
	public static GFABBJEKLJG? LHDIKPNFFNE(GLPPJOHAHLM? MILEALDCLGB, LNMBGNPCGOG? KMPEDLCINIF, EKCGLIJJMGJ? GEFOMNELNJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1800", Offset = "0x1DA0A00", VA = "0x181DA1800")]
	public static NHNCPMGLFBJ<JFONOMFMEKP, JGHEDABDODB> EAKOLOGIIJC(GFABBJEKLJG KIDMNFEEABK)
	{
		return default(NHNCPMGLFBJ<JFONOMFMEKP, JGHEDABDODB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1910", Offset = "0x1DA0B10", VA = "0x181DA1910")]
	[AsyncStateMachine(typeof(OPODFNBMGBM))]
	public static Task<BLNBDNPDEEM<PGENBOHGKNI, DLKKNPCBHBE>> GBHAGJNMALO(FNBPJGFILDN EAMCHADGEIB, JGHEDABDODB KPBGCHDNDLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct AFGLFAAEMCF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct HOJNIMEOAID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<GEFCMJJLDCN, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AFGLFAAEMCF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public FNBPJGFILDN root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private BLNBDNPDEEM<GEFCMJJLDCN, NGDCAOKOLMO> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private BLNBDNPDEEM<object, CHOGLKODFOC>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private BLNBDNPDEEM<object, CHOGLKODFOC> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private BLNBDNPDEEM<object, CHOGLKODFOC>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1D9FBD0", Offset = "0x1D9EDD0", VA = "0x181D9FBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0040", Offset = "0x1D9F240", VA = "0x181DA0040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<GFABBJEKLJG> HADHODENJLB;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x947980", Offset = "0x946B80", VA = "0x180947980")]
	private AFGLFAAEMCF(IReadOnlyList<GFABBJEKLJG> GEPECELMEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1D8B0F0", Offset = "0x1D8A2F0", VA = "0x181D8B0F0")]
	public static GFABBJEKLJG LHDIKPNFFNE(IReadOnlyList<GFABBJEKLJG> GEPECELMEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1D8AF10", Offset = "0x1D8A110", VA = "0x181D8AF10")]
	public static NHNCPMGLFBJ<JFONOMFMEKP, AFGLFAAEMCF> EAKOLOGIIJC(GFABBJEKLJG KIDMNFEEABK)
	{
		return default(NHNCPMGLFBJ<JFONOMFMEKP, AFGLFAAEMCF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D8AFB0", Offset = "0x1D8A1B0", VA = "0x181D8AFB0")]
	[AsyncStateMachine(typeof(HOJNIMEOAID))]
	public static Task<BLNBDNPDEEM<GEFCMJJLDCN, NGDCAOKOLMO>> GBHAGJNMALO(FNBPJGFILDN EAMCHADGEIB, AFGLFAAEMCF KPBGCHDNDLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct CGJBIEAJEAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int MNPNLHNEGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int ANPNOFMCDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] DOMOOIMCODE;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1892C50", Offset = "0x1891E50", VA = "0x181892C50")]
	private CGJBIEAJEAP(int BNPJLEJJKIB, int ILNNGHKJMBD, byte[] GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1D94B20", Offset = "0x1D93D20", VA = "0x181D94B20")]
	public static GFABBJEKLJG LHDIKPNFFNE(int BNPJLEJJKIB, int ILNNGHKJMBD, ByteString GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1D949E0", Offset = "0x1D93BE0", VA = "0x181D949E0")]
	public static GFABBJEKLJG[] JCMMDCFMCGD(GFABBJEKLJG CEBHNDLCHED, int MIFABPLDJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1D94900", Offset = "0x1D93B00", VA = "0x181D94900")]
	public static NHNCPMGLFBJ<JFONOMFMEKP, CGJBIEAJEAP> EAKOLOGIIJC(GFABBJEKLJG KIDMNFEEABK)
	{
		return default(NHNCPMGLFBJ<JFONOMFMEKP, CGJBIEAJEAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D947E0", Offset = "0x1D939E0", VA = "0x181D947E0")]
	public static BLNBDNPDEEM<GFABBJEKLJG, DLKKNPCBHBE> CIBAIPAFHOL(FNBPJGFILDN EAMCHADGEIB, [In] CGJBIEAJEAP KPBGCHDNDLM)
	{
		return default(BLNBDNPDEEM<GFABBJEKLJG, DLKKNPCBHBE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct HLKGPMPGGBE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct BMPFGLOEPMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<bool, DLKKNPCBHBE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public FNBPJGFILDN root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public HLKGPMPGGBE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private BLNBDNPDEEM<bool, DLKKNPCBHBE> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, DLKKNPCBHBE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1D937C0", Offset = "0x1D929C0", VA = "0x181D937C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1D93E00", Offset = "0x1D93000", VA = "0x181D93E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int MNPNLHNEGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int ANPNOFMCDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] DOMOOIMCODE;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1892C50", Offset = "0x1891E50", VA = "0x181892C50")]
	private HLKGPMPGGBE(int BNPJLEJJKIB, int ILNNGHKJMBD, byte[] GKNJGNIHLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1D9EFB0", Offset = "0x1D9E1B0", VA = "0x181D9EFB0")]
	public static GFABBJEKLJG LHDIKPNFFNE(int BNPJLEJJKIB, int ILNNGHKJMBD, ByteString GKNJGNIHLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1D9EC80", Offset = "0x1D9DE80", VA = "0x181D9EC80")]
	public static GFABBJEKLJG?[]? FBIIBAFDJMP(int MIFABPLDJBP, GLPPJOHAHLM? MILEALDCLGB, LNMBGNPCGOG? KMPEDLCINIF, EKCGLIJJMGJ? GEFOMNELNJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1D9EBA0", Offset = "0x1D9DDA0", VA = "0x181D9EBA0")]
	public static NHNCPMGLFBJ<JFONOMFMEKP, HLKGPMPGGBE> EAKOLOGIIJC(GFABBJEKLJG KIDMNFEEABK)
	{
		return default(NHNCPMGLFBJ<JFONOMFMEKP, HLKGPMPGGBE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1D9EE80", Offset = "0x1D9E080", VA = "0x181D9EE80")]
	[AsyncStateMachine(typeof(BMPFGLOEPMO))]
	public static Task<BLNBDNPDEEM<bool, DLKKNPCBHBE>> GBHAGJNMALO(FNBPJGFILDN EAMCHADGEIB, HLKGPMPGGBE KPBGCHDNDLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KCCOBEHPEDA : GOCFJBPFCNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly FNBPJGFILDN IOEBOFEFKBF;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public GKELBMIFBLD? MJANIPKLNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2560", Offset = "0x1DA1760", VA = "0x181DA2560", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	internal KCCOBEHPEDA(FNBPJGFILDN ONJFHIILPIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class DLFDADOKPDM : GKELBMIFBLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly FNBPJGFILDN IOEBOFEFKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly GODFEFLGLEG PAGIBGGPOPH;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7BB6A0", Offset = "0x7BA8A0", VA = "0x1807BB6A0")]
	public DLFDADOKPDM(FNBPJGFILDN ONJFHIILPIE, GODFEFLGLEG ADAKDDJLKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1D97850", Offset = "0x1D96A50", VA = "0x181D97850", Slot = "4")]
	public BLNBDNPDEEM<AOKAFMIHLPF, ADPPGMNMAJE> NAFNGLDKLNC(JJGAGGDHEOK<CNEFPEIGAAA> CPDCLGDPBBB, IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK, IJMPLGOCAIG<JMAMHDJNNLP> MPKOHKKPBDB)
	{
		return default(BLNBDNPDEEM<AOKAFMIHLPF, ADPPGMNMAJE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D97580", Offset = "0x1D96780", VA = "0x181D97580", Slot = "5")]
	public BLNBDNPDEEM<AOKAFMIHLPF, ADPPGMNMAJE> DKBMOJCOOLK(JJGAGGDHEOK<CNEFPEIGAAA> CPDCLGDPBBB, IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK, IJMPLGOCAIG<HBBCJEFCPDN> MPELNFINDJE)
	{
		return default(BLNBDNPDEEM<AOKAFMIHLPF, ADPPGMNMAJE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class NNGNCBFENCB : KEFKCLNCGAN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface NOALEMLEOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<GODFEFLGLEG> IDFKAACOLIA(FNBPJGFILDN ONJFHIILPIE, LNMBGNPCGOG? PCCOKDNFFCH, EKCGLIJJMGJ? IGMCEBBAMAG, CancellationToken OBNOJDAGGOE);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		KHOFFOEEIGN OKHJEJPIBKH(FNBPJGFILDN ONJFHIILPIE, GLPPJOHAHLM OJFIHCLFNCD);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class AHMJNLOPAOK : NOALEMLEOMN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct LHPDLAAGNFK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public AsyncTaskMethodBuilder<GODFEFLGLEG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public FNBPJGFILDN circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public LNMBGNPCGOG cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public EKCGLIJJMGJ cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private TaskAwaiter<GPFAAHLMODN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1DA32B0", Offset = "0x1DA24B0", VA = "0x181DA32B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1DA35D0", Offset = "0x1DA27D0", VA = "0x181DA35D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly AHMJNLOPAOK MJANIPKLNPJ;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		private AHMJNLOPAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1D8B2A0", Offset = "0x1D8A4A0", VA = "0x181D8B2A0", Slot = "4")]
		[AsyncStateMachine(typeof(LHPDLAAGNFK))]
		public Task<GODFEFLGLEG> IDFKAACOLIA(FNBPJGFILDN ONJFHIILPIE, LNMBGNPCGOG? PCCOKDNFFCH, EKCGLIJJMGJ? IGMCEBBAMAG, CancellationToken OBNOJDAGGOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1D8B400", Offset = "0x1D8A600", VA = "0x181D8B400", Slot = "5")]
		public KHOFFOEEIGN OKHJEJPIBKH(FNBPJGFILDN ONJFHIILPIE, GLPPJOHAHLM OJFIHCLFNCD)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct NLPPLMHKDNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<NNGNCBFENCB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public FNBPJGFILDN circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LNMBGNPCGOG cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public EKCGLIJJMGJ cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public GLPPJOHAHLM evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private NOALEMLEOMN <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<GODFEFLGLEG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4830", Offset = "0x1DA3A30", VA = "0x181DA4830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4D90", Offset = "0x1DA3F90", VA = "0x181DA4D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly GODFEFLGLEG PAGIBGGPOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly KHOFFOEEIGN LMNGCNOHPFO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public JJIKOOMAOKJ FIDCGPAFCCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4E60", Offset = "0x1DA4060", VA = "0x181DA4E60", Slot = "4")]
		get
		{
			return default(JJIKOOMAOKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public IDKBGAMJALG MFOFKHKDDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4EC0", Offset = "0x1DA40C0", VA = "0x181DA4EC0", Slot = "5")]
		get
		{
			return default(IDKBGAMJALG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public DLFDADOKPDM PJBPKBAFDPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7BA390", Offset = "0x7B9590", VA = "0x1807BA390", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CMIMGBAEJKG LKKAGEIPGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3D0", Offset = "0x7B95D0", VA = "0x1807BA3D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IHMNJMJCBJI LBJLKFMFGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5090", Offset = "0x1DA4290", VA = "0x181DA5090")]
	private NNGNCBFENCB(GODFEFLGLEG ADAKDDJLKBA, KHOFFOEEIGN CKECPJLAMBE, DLFDADOKPDM JGKDKMJLDGG, CMIMGBAEJKG JKEFMKHPILE, IHMNJMJCBJI MJHIAEFHNMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4F20", Offset = "0x1DA4120", VA = "0x181DA4F20")]
	[AsyncStateMachine(typeof(NLPPLMHKDNH))]
	public static Task<NNGNCBFENCB> MKLNCNNEGKA(FNBPJGFILDN ONJFHIILPIE, GLPPJOHAHLM OJFIHCLFNCD, LNMBGNPCGOG? PCCOKDNFFCH, EKCGLIJJMGJ? IGMCEBBAMAG, CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4E00", Offset = "0x1DA4000", VA = "0x181DA4E00", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class JKFDEPKPCOO : LOHNCJMLFJL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface GGBKPCLHEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<KEFKCLNCGAN> GEKOKBOGFAO(FNBPJGFILDN ONJFHIILPIE, GLPPJOHAHLM OJFIHCLFNCD, LNMBGNPCGOG? PCCOKDNFFCH, EKCGLIJJMGJ? IGMCEBBAMAG, CancellationToken OBNOJDAGGOE);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FHOBAHPIMIM();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HIPOOBCKBPP();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class CMFLHINOJJE : GGBKPCLHEHB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct NGIGDJPLDCC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AsyncTaskMethodBuilder<KEFKCLNCGAN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public FNBPJGFILDN circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public GLPPJOHAHLM evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public LNMBGNPCGOG cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public EKCGLIJJMGJ cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<NNGNCBFENCB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1DA3F60", Offset = "0x1DA3160", VA = "0x181DA3F60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1DA42A0", Offset = "0x1DA34A0", VA = "0x181DA42A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D94F30", Offset = "0x1D94130", VA = "0x181D94F30", Slot = "4")]
		[AsyncStateMachine(typeof(NGIGDJPLDCC))]
		public Task<KEFKCLNCGAN> GEKOKBOGFAO(FNBPJGFILDN ONJFHIILPIE, GLPPJOHAHLM OJFIHCLFNCD, LNMBGNPCGOG? PCCOKDNFFCH, EKCGLIJJMGJ? IGMCEBBAMAG, CancellationToken OBNOJDAGGOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void FHOBAHPIMIM();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void HIPOOBCKBPP();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		protected CMFLHINOJJE()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct KDMPOMJCHBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<KEFKCLNCGAN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public JKFDEPKPCOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter<PGENBOHGKNI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2670", Offset = "0x1DA1870", VA = "0x181DA2670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2870", Offset = "0x1DA1A70", VA = "0x181DA2870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct LFJPLOAMBNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public JKFDEPKPCOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public FNBPJGFILDN circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public GLPPJOHAHLM evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public LNMBGNPCGOG cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public EKCGLIJJMGJ cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<KEFKCLNCGAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2D20", Offset = "0x1DA1F20", VA = "0x181DA2D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1DA3250", Offset = "0x1DA2450", VA = "0x181DA3250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly GGBKPCLHEHB CCPNGOJFLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<PGENBOHGKNI> MPKPPODIOMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<PGENBOHGKNI> PEOKEONKCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly CancellationTokenSource AIKFLIHJFMI;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FNMNCNKKGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x885A60", Offset = "0x884C60", VA = "0x180885A60", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x969E00", Offset = "0x969000", VA = "0x180969E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NHGADOFHDEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x969DE0", Offset = "0x968FE0", VA = "0x180969DE0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x969DB0", Offset = "0x968FB0", VA = "0x180969DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool ADNCEMNEEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xF5D810", Offset = "0xF5CA10", VA = "0x180F5D810")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1DA1B50", Offset = "0x1DA0D50", VA = "0x181DA1B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public KEFKCLNCGAN? ADHFFBOMNIA
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7C1BE0", Offset = "0x7C0DE0", VA = "0x1807C1BE0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D70", Offset = "0x7C0F70", VA = "0x1807C1D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1E30", Offset = "0x1DA1030", VA = "0x181DA1E30", Slot = "7")]
	[AsyncStateMachine(typeof(KDMPOMJCHBC))]
	public Task<KEFKCLNCGAN> KGEHLCBADAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1F20", Offset = "0x1DA1120", VA = "0x181DA1F20")]
	public JKFDEPKPCOO(GGBKPCLHEHB ECDJFINNJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1CD0", Offset = "0x1DA0ED0", VA = "0x181DA1CD0", Slot = "8")]
	[AsyncStateMachine(typeof(LFJPLOAMBNL))]
	public Task HIPAOPBPKDI(FNBPJGFILDN ONJFHIILPIE, GLPPJOHAHLM OJFIHCLFNCD, LNMBGNPCGOG? PCCOKDNFFCH, EKCGLIJJMGJ? IGMCEBBAMAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1B60", Offset = "0x1DA0D60", VA = "0x181DA1B60", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class FCGIFBPICLH : BCIFEIKDKCN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly CMIMGBAEJKG AAKEBBEOJND;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	public FCGIFBPICLH(CMIMGBAEJKG JKEFMKHPILE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class OCMEFNNBKDN
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class KLMGIOEHCIF<TGraph> : JHKEKFANGED where TGraph : ACLGEAAINGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		protected readonly TGraph BOABMJLIBEK;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual DKBBCJFJMMA? LPEMCHPOHGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xDAB990", Offset = "0xDAAB90", VA = "0x180DAB990", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
		public KLMGIOEHCIF(TGraph MJIPOIHPELF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class JKGHPAELIPE : KLMGIOEHCIF<HJGAONDPMHA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override DKBBCJFJMMA? LPEMCHPOHGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x1DA2030", Offset = "0x1DA1230", VA = "0x181DA2030", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2050", Offset = "0x1DA1250", VA = "0x181DA2050")]
		public JKGHPAELIPE(HJGAONDPMHA BNNJBGDBELD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5EC0", Offset = "0x1DA50C0", VA = "0x181DA5EC0")]
	public static JHKEKFANGED GOMGEEBODDD(ACLGEAAINGH MJIPOIHPELF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class FFIKDJAKOLO : BJEGNLAMNAP, OJNHKBCFLFO, MHPILBAHAKP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class AGMCOGNEEIF
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
			public AGMCOGNEEIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public MHGAHEKEAGE errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1DA7560", Offset = "0x1DA6760", VA = "0x181DA7560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1DA77D0", Offset = "0x1DA69D0", VA = "0x181DA77D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public FFIKDJAKOLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public AGMCOGNEEIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1D8B1B0", Offset = "0x1D8A3B0", VA = "0x181D8B1B0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task DAGCBCOAHKO(MHGAHEKEAGE errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct HIIDCBJDJMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public FFIKDJAKOLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1D9E650", Offset = "0x1D9D850", VA = "0x181D9E650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1D9EB40", Offset = "0x1D9DD40", VA = "0x181D9EB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class JBHKGPLALPM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public JBHKGPLALPM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1DA7830", Offset = "0x1DA6A30", VA = "0x181DA7830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1DA7B10", Offset = "0x1DA6D10", VA = "0x181DA7B10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public FFIKDJAKOLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public JBHKGPLALPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0B50", Offset = "0x1D9FD50", VA = "0x181DA0B50")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task OJMEBPBCOFF(MHGAHEKEAGE errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly NICBKOGHEEA PNBFLIOCIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ICollection<NCGLMGAKJMM> FKIOHNKKEJJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private JFJMFHHMLJN DBAMCJNOBON
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1D9A5C0", Offset = "0x1D997C0", VA = "0x181D9A5C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public IJMPLGOCAIG<JMAMHDJNNLP> KBFIPKNNFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8849D0", Offset = "0x883BD0", VA = "0x1808849D0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(IJMPLGOCAIG<JMAMHDJNNLP>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xB2F9D0", Offset = "0xB2EBD0", VA = "0x180B2F9D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private IJMPLGOCAIG<CJHOFKFEOGB> COEGMOCGDDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x961870", Offset = "0x960A70", VA = "0x180961870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public override IJMPLGOCAIG<LHBCDNLAFEP> DCANCFOPLGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1D9AA40", Offset = "0x1D99C40", VA = "0x181D9AA40", Slot = "19")]
		get
		{
			return default(IJMPLGOCAIG<LHBCDNLAFEP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool DPOJODBKHIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x1D98B10", Offset = "0x1D97D10", VA = "0x181D98B10", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1D9AF50", Offset = "0x1D9A150", VA = "0x181D9AF50")]
	private FFIKDJAKOLO(FNBPJGFILDN ONJFHIILPIE, IDNPEHCMMLO DEBAEMIFHOC, NICBKOGHEEA LANIOBLDNAO, IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK, IJMPLGOCAIG<JMAMHDJNNLP> MPKOHKKPBDB, IJMPLGOCAIG<CJHOFKFEOGB> OCGGOKMCDHH, bool MOPMIMMICDI, string NLBAJPAADNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1D99830", Offset = "0x1D98A30", VA = "0x181D99830")]
	public static FFIKDJAKOLO GOMGEEBODDD(FNBPJGFILDN ONJFHIILPIE, IDNPEHCMMLO DEBAEMIFHOC, NICBKOGHEEA NKIKIMMJFMI, IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK, IJMPLGOCAIG<CJHOFKFEOGB> OCGGOKMCDHH, IJMPLGOCAIG<JMAMHDJNNLP> MPKOHKKPBDB, bool MOPMIMMICDI, bool MGNFMDBDFDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1D98180", Offset = "0x1D97380", VA = "0x181D98180", Slot = "20")]
	protected override void AKCGAJHNOGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1D98CD0", Offset = "0x1D97ED0", VA = "0x181D98CD0", Slot = "21")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1D9AC50", Offset = "0x1D99E50", VA = "0x181D9AC50", Slot = "28")]
	public void ONJNMPCAENM(NCGLMGAKJMM EDHKLOMDACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1D984E0", Offset = "0x1D976E0", VA = "0x181D984E0", Slot = "25")]
	public void BGMHBLMDGFC(FONOODFEPDJ JPOGNLFDCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1D98E90", Offset = "0x1D98090", VA = "0x181D98E90", Slot = "26")]
	public void EEOOBDEBNDF(OCCJCGDABPD FKBELECCJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1D9A860", Offset = "0x1D99A60", VA = "0x181D9A860", Slot = "22")]
	protected override void MJNFEKHFJFO(MILMCJCPECN DDNCACHIOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1D98950", Offset = "0x1D97B50", VA = "0x181D98950", Slot = "30")]
	public string CGNNOGDAMGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1D9A1C0", Offset = "0x1D993C0", VA = "0x181D9A1C0", Slot = "27")]
	public string JNPEALPEKOB(int GCBBIJKLBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1D9A5E0", Offset = "0x1D997E0", VA = "0x181D9A5E0")]
	private void LFOBIFJGALM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1D9AD20", Offset = "0x1D99F20", VA = "0x181D9AD20", Slot = "29")]
	public void PBHKKDDNBKP(NCGLMGAKJMM EDHKLOMDACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1D9A000", Offset = "0x1D99200", VA = "0x181D9A000")]
	private void JKADLKKAHHJ(bool AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1D9A940", Offset = "0x1D99B40", VA = "0x181D9A940", Slot = "31")]
	[AsyncStateMachine(typeof(HIIDCBJDJMJ))]
	public Task MKFHEHGDIPG(string AFCGKMGKPEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1D99BE0", Offset = "0x1D98DE0", VA = "0x181D99BE0")]
	public void HDEPJIHKAFO(string AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1D98340", Offset = "0x1D97540", VA = "0x181D98340")]
	private void BBNKJPBMGJK(int AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0xB2F9D0", Offset = "0xB2EBD0", VA = "0x180B2F9D0")]
	internal void MADLMKBLLAN(IJMPLGOCAIG<JMAMHDJNNLP> AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1D99EB0", Offset = "0x1D990B0", VA = "0x181D99EB0")]
	[CompilerGenerated]
	private bool JHPCMFNKJJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1D99D10", Offset = "0x1D98F10", VA = "0x181D99D10")]
	[CompilerGenerated]
	private bool IOPLGAMKPIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1D9A810", Offset = "0x1D99A10", VA = "0x181D9A810")]
	[CompilerGenerated]
	private int PLIIHHGPHOE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1D988C0", Offset = "0x1D97AC0", VA = "0x181D988C0")]
	[CompilerGenerated]
	private bool BMJPCGHGLPG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1D9AB00", Offset = "0x1D99D00", VA = "0x181D9AB00")]
	[CompilerGenerated]
	private bool OEPBBABOBFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1D99E60", Offset = "0x1D99060", VA = "0x181D99E60")]
	[CompilerGenerated]
	private bool JHNCPBAOMOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1D9ADF0", Offset = "0x1D99FF0", VA = "0x181D9ADF0")]
	[CompilerGenerated]
	private bool PHBECKKAOHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1D9A810", Offset = "0x1D99A10", VA = "0x181D9A810")]
	[CompilerGenerated]
	private int LMIBKHLHGDO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1D9A4F0", Offset = "0x1D996F0", VA = "0x181D9A4F0")]
	[CompilerGenerated]
	private bool KBDDIHHCFEP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1D98AC0", Offset = "0x1D97CC0", VA = "0x181D98AC0")]
	[CompilerGenerated]
	private int DAMNIIEOMFP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1D9AA80", Offset = "0x1D99C80", VA = "0x181D9AA80")]
	[CompilerGenerated]
	private void OAGOCPIDIGJ(object AFCGKMGKPEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1D9AE80", Offset = "0x1D9A080", VA = "0x181D9AE80")]
	[CompilerGenerated]
	private bool PKKODPGOHEC()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class JCHNEJLJJPA
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private abstract class JMKMBODHLLG<TNode> : MGNEEKBGALO<TNode> where TNode : notnull, PBMPAJKCOCC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct AHLNOFNLOMP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public AsyncTaskMethodBuilder<BLNBDNPDEEM<IJMPLGOCAIG<KPOOLCGJDAJ>, NGDCAOKOLMO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public JMKMBODHLLG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private TaskAwaiter<BLNBDNPDEEM<IJMPLGOCAIG<KPOOLCGJDAJ>, NGDCAOKOLMO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x37A3A60", Offset = "0x37A2C60", VA = "0x1837A3A60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x37A3E30", Offset = "0x37A3030", VA = "0x1837A3E30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct FBFDJEMMHAL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public JMKMBODHLLG<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public IJMPLGOCAIG<KPOOLCGJDAJ> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x360F540", Offset = "0x360E740", VA = "0x18360F540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x360F910", Offset = "0x360EB10", VA = "0x18360F910", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public sealed override bool OONBELBLFPB
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public sealed override IJMPLGOCAIG<KPOOLCGJDAJ>? EILLDDFBHFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x3AC60D0", Offset = "0x3AC52D0", VA = "0x183AC60D0", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x32AA500", Offset = "0x32A9700", VA = "0x1832AA500")]
		public JMKMBODHLLG(FNBPJGFILDN ONJFHIILPIE, TNode DEBAEMIFHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3AC5D60", Offset = "0x3AC4F60", VA = "0x183AC5D60", Slot = "95")]
		[AsyncStateMachine(typeof(JMKMBODHLLG<>.AHLNOFNLOMP))]
		public override Task<BLNBDNPDEEM<IJMPLGOCAIG<KPOOLCGJDAJ>, NGDCAOKOLMO>> CFNKMKKCKBC(string NLBAJPAADNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3AC5CC0", Offset = "0x3AC4EC0", VA = "0x183AC5CC0", Slot = "119")]
		public sealed override bool BNPJHPBPJAP(IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3AC6030", Offset = "0x3AC5230", VA = "0x183AC6030", Slot = "109")]
		protected sealed override bool LACAHDEDPJM(IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3AC5E80", Offset = "0x3AC5080", VA = "0x183AC5E80", Slot = "110")]
		protected override bool FHDMFKPIJAA(IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3AC5F20", Offset = "0x3AC5120", VA = "0x183AC5F20", Slot = "96")]
		[AsyncStateMachine(typeof(JMKMBODHLLG<>.FBFDJEMMHAL))]
		public override Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> KCHNAMNOCIB(IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private sealed class OOMFPEKNFDD : ECEAGPPONAM<FLNOOOGPKAG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x87EF20", Offset = "0x87E120", VA = "0x18087EF20", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1DA6050", Offset = "0x1DA5250", VA = "0x181DA6050")]
		public OOMFPEKNFDD(FNBPJGFILDN ONJFHIILPIE, FLNOOOGPKAG DEBAEMIFHOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private abstract class ECEAGPPONAM<TNode> : MGNEEKBGALO<TNode> where TNode : notnull, AOLIJIEDCML
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private struct HLIEHIOADPK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public AsyncTaskMethodBuilder<BLNBDNPDEEM<IJMPLGOCAIG<KPOOLCGJDAJ>, NGDCAOKOLMO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public ECEAGPPONAM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<BLNBDNPDEEM<IJMPLGOCAIG<KPOOLCGJDAJ>, NGDCAOKOLMO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x37F9440", Offset = "0x37F8640", VA = "0x1837F9440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x37F97B0", Offset = "0x37F89B0", VA = "0x1837F97B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct AAPAMKEMNGF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public ECEAGPPONAM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public IJMPLGOCAIG<KPOOLCGJDAJ> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x3704E70", Offset = "0x3704070", VA = "0x183704E70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x37051C0", Offset = "0x37043C0", VA = "0x1837051C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override IJMPLGOCAIG<ENDAAFIJDLG>? NAOJMNJCPKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x32AA530", Offset = "0x32A9730", VA = "0x1832AA530", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override IJMPLGOCAIG<KPOOLCGJDAJ>? EILLDDFBHFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x32AA5E0", Offset = "0x32A97E0", VA = "0x1832AA5E0", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x32AA500", Offset = "0x32A9700", VA = "0x1832AA500")]
		public ECEAGPPONAM(FNBPJGFILDN ONJFHIILPIE, TNode DEBAEMIFHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x32AA190", Offset = "0x32A9390", VA = "0x1832AA190", Slot = "95")]
		[AsyncStateMachine(typeof(ECEAGPPONAM<>.HLIEHIOADPK))]
		public override Task<BLNBDNPDEEM<IJMPLGOCAIG<KPOOLCGJDAJ>, NGDCAOKOLMO>> CFNKMKKCKBC(string NLBAJPAADNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x32AA0F0", Offset = "0x32A92F0", VA = "0x1832AA0F0", Slot = "119")]
		public sealed override bool BNPJHPBPJAP(IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x32AA460", Offset = "0x32A9660", VA = "0x1832AA460", Slot = "109")]
		protected sealed override bool LACAHDEDPJM(IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x32AA2B0", Offset = "0x32A94B0", VA = "0x1832AA2B0", Slot = "110")]
		protected override bool FHDMFKPIJAA(IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x32AA350", Offset = "0x32A9550", VA = "0x1832AA350", Slot = "96")]
		[AsyncStateMachine(typeof(ECEAGPPONAM<>.AAPAMKEMNGF))]
		public override Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> KCHNAMNOCIB(IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class BFEOAPMDJBF : MGNEEKBGALO<AOBLFOMMGME>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xA4B3F0", Offset = "0xA4A5F0", VA = "0x180A4B3F0", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1D91690", Offset = "0x1D90890", VA = "0x181D91690")]
		public BFEOAPMDJBF(FNBPJGFILDN ONJFHIILPIE, AOBLFOMMGME DEBAEMIFHOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class PCOCGEJANJO : ECEAGPPONAM<KLEKPIJFGCJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool HCBDCADBPFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool NPHHHIJLOEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x1DA68F0", Offset = "0x1DA5AF0", VA = "0x181DA68F0", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x9263B0", Offset = "0x9255B0", VA = "0x1809263B0", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1DA6890", Offset = "0x1DA5A90", VA = "0x181DA6890")]
		public PCOCGEJANJO(FNBPJGFILDN ONJFHIILPIE, KLEKPIJFGCJ DEBAEMIFHOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class NLOBNBMDBNK : MGNEEKBGALO<GKPDGEPKKID>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x102BD70", Offset = "0x102AF70", VA = "0x18102BD70", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x1DA47C0", Offset = "0x1DA39C0", VA = "0x181DA47C0")]
		public NLOBNBMDBNK(FNBPJGFILDN ONJFHIILPIE, GKPDGEPKKID DEBAEMIFHOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class LELMKKANNNA : MGNEEKBGALO<BMNEBKLEBDB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x927750", Offset = "0x926950", VA = "0x180927750", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2CB0", Offset = "0x1DA1EB0", VA = "0x181DA2CB0")]
		public LELMKKANNNA(FNBPJGFILDN ONJFHIILPIE, BMNEBKLEBDB DEBAEMIFHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300", Slot = "109")]
		protected override bool LACAHDEDPJM(IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class ALOIJEPFGCA : MGNEEKBGALO<OBPKJFJPJPD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x934A50", Offset = "0x933C50", VA = "0x180934A50", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override bool CNGKIHCONPI
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1D8B510", Offset = "0x1D8A710", VA = "0x181D8B510", Slot = "86")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override bool NCKJDIKNIEB
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1D8B4A0", Offset = "0x1D8A6A0", VA = "0x181D8B4A0")]
		public ALOIJEPFGCA(FNBPJGFILDN ONJFHIILPIE, OBPKJFJPJPD DEBAEMIFHOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class HBDFDDAJBNF : MGNEEKBGALO<OOBDBIHKOBN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x90CC40", Offset = "0x90BE40", VA = "0x18090CC40", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool CNGKIHCONPI
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x1D9E000", Offset = "0x1D9D200", VA = "0x181D9E000", Slot = "86")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected override bool NCKJDIKNIEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1D9DF90", Offset = "0x1D9D190", VA = "0x181D9DF90")]
		public HBDFDDAJBNF(FNBPJGFILDN ONJFHIILPIE, OOBDBIHKOBN DEBAEMIFHOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class MEAEPHOEIPJ : JMKMBODHLLG<LBGELJGNBNL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x9323A0", Offset = "0x9315A0", VA = "0x1809323A0", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1DA36A0", Offset = "0x1DA28A0", VA = "0x181DA36A0")]
		public MEAEPHOEIPJ(FNBPJGFILDN ONJFHIILPIE, LBGELJGNBNL DEBAEMIFHOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class MGNEEKBGALO<TNode> : KCPNJNKEDLG, IDisposable where TNode : notnull, IDNPEHCMMLO
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class BMGJAECLFAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public MGNEEKBGALO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public FNBPJGFILDN circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
			public BMGJAECLFAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x47B8F50", Offset = "0x47B8150", VA = "0x1847B8F50")]
			internal ANFMFCILJBE FDFPJDPFIPK(HKKGJGOFILO portGroup, int index)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct APANHKBNEOI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public MGNEEKBGALO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public LKLCPOLAEPE? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public MCNNNFLOCPG? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x37B38E0", Offset = "0x37B2AE0", VA = "0x1837B38E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x37B3B80", Offset = "0x37B2D80", VA = "0x1837B3B80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct CCDAEDAGBHK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public MGNEEKBGALO<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x48E67E0", Offset = "0x48E59E0", VA = "0x1848E67E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x48E6A40", Offset = "0x48E5C40", VA = "0x1848E6A40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private FNBPJGFILDN IOEBOFEFKBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly bool FMAPEHAPFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private DFFADLPNANF<KPOOLCGJDAJ, ANFMFCILJBE> BNNBNILKKEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private DFFADLPNANF<KPOOLCGJDAJ, AJCDKPOOFEA> HAEKANJLHPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private List<Action> HDMABMADLMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[CompilerGenerated]
		private Action<IJMPLGOCAIG<KPOOLCGJDAJ>>? KOIGPMFIJLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[CompilerGenerated]
		private Action<IJMPLGOCAIG<KPOOLCGJDAJ>, AJCDKPOOFEA>? ALBKJNGNCOL;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected TNode LNOHHBJJFMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public JJGAGGDHEOK<ILILDDKGAMF> HMAEFHFJEIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9C5230", Offset = "0x9C4430", VA = "0x1809C5230", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(JJGAGGDHEOK<ILILDDKGAMF>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public object DMCMBOAAOKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x3321520", Offset = "0x3320720", VA = "0x183321520", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public virtual bool OLNDCEJNCGP
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int ONEIJGNKADH
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x3E74DF0", Offset = "0x3E73FF0", VA = "0x183E74DF0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public CNBKCAOOBLL EICGJOGALNB
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x3E74DA0", Offset = "0x3E73FA0", VA = "0x183E74DA0", Slot = "9")]
			get
			{
				return default(CNBKCAOOBLL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string OECCGCLODNE
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x3E751C0", Offset = "0x3E743C0", VA = "0x183E751C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected virtual bool NCKJDIKNIEB
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public virtual NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public IJMPLGOCAIG<FAENPHADCHB> AENBJDBKPGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x950810", Offset = "0x94FA10", VA = "0x180950810", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(IJMPLGOCAIG<FAENPHADCHB>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x9B7A80", Offset = "0x9B6C80", VA = "0x1809B7A80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual bool CNGKIHCONPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "86")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public virtual bool HCBDCADBPFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public virtual DJCABCMBBCN FBJJGNIBGBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x923BE0", Offset = "0x922DE0", VA = "0x180923BE0", Slot = "88")]
			get
			{
				return default(DJCABCMBBCN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool KGJNCDEDEBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x3E74BC0", Offset = "0x3E73DC0", VA = "0x183E74BC0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public bool FOPNDICMIKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x3E74C10", Offset = "0x3E73E10", VA = "0x183E74C10", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool PEHIBBGKCBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x3E74C60", Offset = "0x3E73E60", VA = "0x183E74C60", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int CDAJMJEJODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x3E75010", Offset = "0x3E74210", VA = "0x183E75010", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool OJBLBOOKHOC
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x3E74EE0", Offset = "0x3E740E0", VA = "0x183E74EE0", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool FDLOEDHEEIA
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x3E74D00", Offset = "0x3E73F00", VA = "0x183E74D00", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool NKBNKMACHAA
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xB00960", Offset = "0xAFFB60", VA = "0x180B00960", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xB00C30", Offset = "0xAFFE30", VA = "0x180B00C30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool KGFFMMIOPNH
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual bool OHHFNOJBEGM
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x3E74CB0", Offset = "0x3E73EB0", VA = "0x183E74CB0", Slot = "90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool PFPKKOEDLAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x3E74E30", Offset = "0x3E74030", VA = "0x183E74E30", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public LKLCPOLAEPE PIJKGFEDPFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x3E74F70", Offset = "0x3E74170", VA = "0x183E74F70", Slot = "26")]
			get
			{
				return default(LKLCPOLAEPE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public MCNNNFLOCPG DANCMHBIDIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x3E74FC0", Offset = "0x3E741C0", VA = "0x183E74FC0", Slot = "28")]
			get
			{
				return default(MCNNNFLOCPG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual bool JNLONCDJLIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "104")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual GEGCHOIOFDO? GIDHMKPAFPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual LNPKFFODDCJ? OODCKGAMNMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "106")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual IEnumerable<JJGAGGDHEOK<CNEFPEIGAAA>>? POLEBFHDCNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "107")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool PKBPMDGKHKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x3E74D50", Offset = "0x3E73F50", VA = "0x183E74D50", Slot = "111")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public JJGAGGDHEOK<ENDAAFIJDLG> NGNHBFEAKJO
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3E74F20", Offset = "0x3E74120", VA = "0x183E74F20", Slot = "54")]
			get
			{
				return default(JJGAGGDHEOK<ENDAAFIJDLG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool OONBELBLFPB
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual IJMPLGOCAIG<ENDAAFIJDLG>? NAOJMNJCPKF
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual bool NPHHHIJLOEK
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool IHHDEGEJLJB
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x3E74E80", Offset = "0x3E74080", VA = "0x183E74E80", Slot = "59")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string IHKMJLPGIHG
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x7C9450", Offset = "0x7C8650", VA = "0x1807C9450", Slot = "61")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x7C9340", Offset = "0x7C8540", VA = "0x1807C9340")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public JJGAGGDHEOK<CNEFPEIGAAA> LNOFEGNKKHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x3E75050", Offset = "0x3E74250", VA = "0x183E75050", Slot = "60")]
			get
			{
				return default(JJGAGGDHEOK<CNEFPEIGAAA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public JJGAGGDHEOK<CNEFPEIGAAA>? PKMKMNMKIFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3E750A0", Offset = "0x3E742A0", VA = "0x183E750A0", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public PHLMBNFCDFO<KPOOLCGJDAJ, AJCDKPOOFEA> MAONGMLJFNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3E75180", Offset = "0x3E74380", VA = "0x183E75180", Slot = "62")]
			get
			{
				return default(PHLMBNFCDFO<KPOOLCGJDAJ, AJCDKPOOFEA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual IJMPLGOCAIG<KPOOLCGJDAJ>? EILLDDFBHFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "116")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action MEBNDIBCOFP
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x3E70F00", Offset = "0x3E70100", VA = "0x183E70F00", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x3E71960", Offset = "0x3E70B60", VA = "0x183E71960", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event GPCDHIFDADF INNPFBBDGEF
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x3E72D00", Offset = "0x3E71F00", VA = "0x183E72D00", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x3E71B20", Offset = "0x3E70D20", VA = "0x183E71B20", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HFMBJHLLKEJ CNAJFCHHJMG
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x3E72C60", Offset = "0x3E71E60", VA = "0x183E72C60", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x3E742E0", Offset = "0x3E734E0", VA = "0x183E742E0", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action CHFACLMDCFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x3E74580", Offset = "0x3E73780", VA = "0x183E74580", Slot = "41")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x3E716F0", Offset = "0x3E708F0", VA = "0x183E716F0", Slot = "42")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action PANNCLPAMMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x3E73210", Offset = "0x3E72410", VA = "0x183E73210", Slot = "43")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x3E71C80", Offset = "0x3E70E80", VA = "0x183E71C80", Slot = "44")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<IJMPLGOCAIG<KPOOLCGJDAJ>, AJCDKPOOFEA> DBOFGADKHNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3E70D20", Offset = "0x3E6FF20", VA = "0x183E70D20", Slot = "64")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3E71BC0", Offset = "0x3E70DC0", VA = "0x183E71BC0", Slot = "65")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<IJMPLGOCAIG<KPOOLCGJDAJ>, AJCDKPOOFEA> IAFIEPGNGJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x3E72970", Offset = "0x3E71B70", VA = "0x183E72970", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3E74110", Offset = "0x3E73310", VA = "0x183E74110", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<IJMPLGOCAIG<KPOOLCGJDAJ>> KNJLBHNPHHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3E732B0", Offset = "0x3E724B0", VA = "0x183E732B0", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3E746F0", Offset = "0x3E738F0", VA = "0x183E746F0", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<IJMPLGOCAIG<KPOOLCGJDAJ>, IJMPLGOCAIG<KPOOLCGJDAJ>> IFHFCINNILO
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x3E71F20", Offset = "0x3E71120", VA = "0x183E71F20", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x3E72DA0", Offset = "0x3E71FA0", VA = "0x183E72DA0", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<IJMPLGOCAIG<KPOOLCGJDAJ>, AJCDKPOOFEA> OJJKHJOHAID
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3E74630", Offset = "0x3E73830", VA = "0x183E74630", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x3E71750", Offset = "0x3E70950", VA = "0x183E71750", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<IJMPLGOCAIG<KPOOLCGJDAJ>, IJMPLGOCAIG<KPOOLCGJDAJ>> CEEDAIFHIMO
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x3E70E40", Offset = "0x3E70040", VA = "0x183E70E40", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x3E744C0", Offset = "0x3E736C0", VA = "0x183E744C0", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3E74880", Offset = "0x3E73A80", VA = "0x183E74880")]
		[MNMOIINOFAC("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[MNMOIINOFAC("Need to handle `Name` better.")]
		public MGNEEKBGALO(FNBPJGFILDN ONJFHIILPIE, TNode DEBAEMIFHOC, bool MGNFMDBDFDA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3E70FA0", Offset = "0x3E701A0", VA = "0x183E70FA0", Slot = "80")]
		protected virtual void AKCGAJHNOGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3E720B0", Offset = "0x3E712B0", VA = "0x183E720B0", Slot = "81")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x3E73850", Offset = "0x3E72A50", VA = "0x183E73850", Slot = "83")]
		public virtual void HDCFCPFPFPP(int JKJMBHOMKCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x3E70DE0", Offset = "0x3E6FFE0", VA = "0x183E70DE0")]
		public bool AGJPDNHKLDD([In] LKLCPOLAEPE AFCGKMGKPEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3E71690", Offset = "0x3E70890", VA = "0x183E71690")]
		public bool APMECKMPHAO([In] MCNNNFLOCPG AFCGKMGKPEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x3E71A00", Offset = "0x3E70C00", VA = "0x183E71A00", Slot = "91")]
		public virtual void BNFDBLCLAEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x3E71810", Offset = "0x3E70A10", VA = "0x183E71810", Slot = "31")]
		[AsyncStateMachine(typeof(MGNEEKBGALO<>.APANHKBNEOI))]
		public Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> BBBCJJNNBMB(LKLCPOLAEPE? FFOFALOECNI, MCNNNFLOCPG? CPDEPCOMBII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "92")]
		public virtual void INEMHPMBIEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "93")]
		public virtual void EONFKALCLEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "94")]
		public virtual void NEDGBECMKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1AE9A70", Offset = "0x1AE8C70", VA = "0x181AE9A70")]
		protected void LDNDAAOOCMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3E73DD0", Offset = "0x3E72FD0", VA = "0x183E73DD0")]
		protected void IEJPNBINEAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x1F5A750", Offset = "0x1F59950", VA = "0x181F5A750")]
		private void PGDECDLIKCK([In] MCNNNFLOCPG KIIONLKEIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x3E71A50", Offset = "0x3E70C50", VA = "0x183E71A50", Slot = "95")]
		public virtual Task<BLNBDNPDEEM<IJMPLGOCAIG<KPOOLCGJDAJ>, NGDCAOKOLMO>> CFNKMKKCKBC(string NLBAJPAADNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3E73FA0", Offset = "0x3E731A0", VA = "0x183E73FA0", Slot = "96")]
		public virtual Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> KCHNAMNOCIB(IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x3E74830", Offset = "0x3E73A30", VA = "0x183E74830", Slot = "97")]
		public virtual void PLOHOCDDJCA(IJMPLGOCAIG<KPOOLCGJDAJ> ILNNGHKJMBD, IJMPLGOCAIG<KPOOLCGJDAJ> MJBOJGOCOJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x3E73DF0", Offset = "0x3E72FF0", VA = "0x183E73DF0", Slot = "98")]
		public virtual IEnumerable<GFABBJEKLJG> IKKBCBOOALE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x3E71FE0", Offset = "0x3E711E0", VA = "0x183E71FE0", Slot = "99")]
		public BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO> DKLJJPDFONA(string ADPBOGMKGIE)
		{
			return default(BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3E72A30", Offset = "0x3E71C30", VA = "0x183E72A30", Slot = "45")]
		public bool FEADOKJOBAD([Out] Guid KHGFFMFIFOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3E74290", Offset = "0x3E73490", VA = "0x183E74290", Slot = "100")]
		public virtual bool MDKNNJLAAGM([In] Guid JAKGJEDDCHL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3E73800", Offset = "0x3E72A00", VA = "0x183E73800", Slot = "101")]
		public virtual void HBHCINBKNHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "102")]
		public virtual void EHJLOIIABGN(bool OJMPIMHMGHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "103")]
		public virtual DPPKONPPDJF FMCPEIOHHJG([In] DGOPMOMIIOB NIIPHIJBOEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3E71E20", Offset = "0x3E71020", VA = "0x183E71E20")]
		protected void DIGCAIFEJPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "108")]
		protected virtual void FKDPLEJBJMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3E74070", Offset = "0x3E73270", VA = "0x183E74070", Slot = "109")]
		protected virtual bool LACAHDEDPJM(IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "110")]
		protected virtual bool FHDMFKPIJAA(IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "117")]
		protected virtual void EPEGEEOOPON(JCNHKKKMIBF GHOJCIFDOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "118")]
		protected virtual void BDKCFDBNNLH(JCNHKKKMIBF DICCGHCNJCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3E72920", Offset = "0x3E71B20", VA = "0x183E72920", Slot = "76")]
		public void EEOOBDEBNDF(JCNHKKKMIBF DICCGHCNJCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3E72B80", Offset = "0x3E71D80", VA = "0x183E72B80", Slot = "77")]
		public ACLKEIAFHHL FEFIODOKIDJ()
		{
			return default(ACLKEIAFHHL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "119")]
		public virtual bool BNPJHPBPJAP(IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x1232160", Offset = "0x1231360", VA = "0x181232160")]
		private void NBPAKPCMJOI([In] LKLCPOLAEPE HBEJPCPOKJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x3E71D20", Offset = "0x3E70F20", VA = "0x183E71D20")]
		private void DBKANBLKAIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x3E738A0", Offset = "0x3E72AA0", VA = "0x183E738A0")]
		private void HOJAJGEEAJH(int FBCBBKPNPLN, HKKGJGOFILO AFHADLKPOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3E74240", Offset = "0x3E73440", VA = "0x183E74240")]
		private void MBGNCFJDJIF(int ILNNGHKJMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x3E74380", Offset = "0x3E73580", VA = "0x183E74380")]
		private void NJHPFBABMAC(int ILNNGHKJMBD, HKKGJGOFILO ADEEFHFKGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x3E72E60", Offset = "0x3E72060", VA = "0x183E72E60")]
		private void GDOAFKCGPGA(int MGEAFBGLBMF, int HILDJIMNBDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x3E70CC0", Offset = "0x3E6FEC0", VA = "0x183E70CC0")]
		private void ADDJIEAOBKC(int MGEAFBGLBMF, int HILDJIMNBDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x3E72060", Offset = "0x3E71260", VA = "0x183E72060")]
		private void DNNFCGBHLOB(int ILNNGHKJMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x3E733A0", Offset = "0x3E725A0", VA = "0x183E733A0")]
		private void GOKPIBKPKBM(int FBCBBKPNPLN, HKKGJGOFILO AFHADLKPOHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x3E747B0", Offset = "0x3E739B0", VA = "0x183E747B0")]
		private void PKFHGNFBKML(int ILNNGHKJMBD, HKKGJGOFILO ADEEFHFKGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x3E73E80", Offset = "0x3E73080", VA = "0x183E73E80", Slot = "120")]
		[AsyncStateMachine(typeof(MGNEEKBGALO<>.CCDAEDAGBHK))]
		public virtual Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> JFNKFCBBECC(string ADPBOGMKGIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x3E741D0", Offset = "0x3E733D0", VA = "0x183E741D0", Slot = "52")]
		private void LHAFPJHDMDO(object EPFPKAOCDMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x3E740A0", Offset = "0x3E732A0", VA = "0x183E740A0", Slot = "53")]
		private void LBFLFBEHNAC(object EPFPKAOCDMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3E737D0", Offset = "0x3E729D0", VA = "0x183E737D0", Slot = "27")]
		private bool HBCDBHGDMGF([In] LKLCPOLAEPE AFCGKMGKPEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x3E73370", Offset = "0x3E72570", VA = "0x183E73370", Slot = "29")]
		private bool GMOKCMKGIHO([In] MCNNNFLOCPG AFCGKMGKPEF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class JNBKDINKKOI : JMKMBODHLLG<LFIOCLABEKJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public override NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xC1FDB0", Offset = "0xC1EFB0", VA = "0x180C1FDB0", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2140", Offset = "0x1DA1340", VA = "0x181DA2140")]
		public JNBKDINKKOI(FNBPJGFILDN ONJFHIILPIE, LFIOCLABEKJ DEBAEMIFHOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class BEIMEGKPDKP : ECEAGPPONAM<PBIMLCPPNLI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public override NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x87EF20", Offset = "0x87E120", VA = "0x18087EF20", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x1D91630", Offset = "0x1D90830", VA = "0x181D91630")]
		public BEIMEGKPDKP(FNBPJGFILDN ONJFHIILPIE, PBIMLCPPNLI DEBAEMIFHOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private sealed class NOCAMCJNGEP : MGNEEKBGALO<DKLDHDODEOL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public override NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x8DAFC0", Offset = "0x8DA1C0", VA = "0x1808DAFC0", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1DA5120", Offset = "0x1DA4320", VA = "0x181DA5120")]
		public NOCAMCJNGEP(FNBPJGFILDN ONJFHIILPIE, DKLDHDODEOL DEBAEMIFHOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class PKCGJDBJAEF : ECEAGPPONAM<DNPJPLADCIG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public override NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x87EF20", Offset = "0x87E120", VA = "0x18087EF20", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1DA6DA0", Offset = "0x1DA5FA0", VA = "0x181DA6DA0")]
		public PKCGJDBJAEF(FNBPJGFILDN ONJFHIILPIE, DNPJPLADCIG DEBAEMIFHOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private sealed class DHDPMMLIBMI : ECEAGPPONAM<EJGCAFIBDEP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public override NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x87EF20", Offset = "0x87E120", VA = "0x18087EF20", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1D97330", Offset = "0x1D96530", VA = "0x181D97330")]
		public DHDPMMLIBMI(FNBPJGFILDN ONJFHIILPIE, EJGCAFIBDEP DEBAEMIFHOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private sealed class LEAMJAKAOEO : MGNEEKBGALO<DBGPHEDFGBC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public override NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xC528D0", Offset = "0xC51AD0", VA = "0x180C528D0", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2C40", Offset = "0x1DA1E40", VA = "0x181DA2C40")]
		public LEAMJAKAOEO(FNBPJGFILDN ONJFHIILPIE, DBGPHEDFGBC DEBAEMIFHOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private sealed class PECOJJGKFAP : MGNEEKBGALO<DNCDHIIHCJB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public override NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7BC7C0", Offset = "0x7BB9C0", VA = "0x1807BC7C0", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected override bool NCKJDIKNIEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1DA6930", Offset = "0x1DA5B30", VA = "0x181DA6930")]
		public PECOJJGKFAP(FNBPJGFILDN ONJFHIILPIE, DNCDHIIHCJB DEBAEMIFHOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private sealed class AABFDOIHFKO : MGNEEKBGALO<FAFMDBEOOAD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public override NodeVisualizationKey OMEPDDHLMOB
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x926D40", Offset = "0x925F40", VA = "0x180926D40", Slot = "85")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x1D8A870", Offset = "0x1D89A70", VA = "0x181D8A870")]
		public AABFDOIHFKO(FNBPJGFILDN ONJFHIILPIE, FAFMDBEOOAD DEBAEMIFHOC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1DA0C20", Offset = "0x1D9FE20", VA = "0x181DA0C20")]
	internal static KCPNJNKEDLG GOMGEEBODDD(FNBPJGFILDN ONJFHIILPIE, IDNPEHCMMLO DEBAEMIFHOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class CGABOBBNAGE : BJEGNLAMNAP, IKFBKMGNOIE, MHPILBAHAKP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public IJMPLGOCAIG<HBBCJEFCPDN> OJDNJKOBOED
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xDADB00", Offset = "0xDACD00", VA = "0x180DADB00", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(IJMPLGOCAIG<HBBCJEFCPDN>);
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xDAC360", Offset = "0xDAB560", VA = "0x180DAC360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private IJMPLGOCAIG<EJMHDNENAPL> CHBBFAJDMGM
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x1D94410", Offset = "0x1D93610", VA = "0x181D94410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public override IJMPLGOCAIG<LHBCDNLAFEP> DCANCFOPLGK
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x1D94750", Offset = "0x1D93950", VA = "0x181D94750", Slot = "19")]
		get
		{
			return default(IJMPLGOCAIG<LHBCDNLAFEP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1D94790", Offset = "0x1D93990", VA = "0x181D94790")]
	private CGABOBBNAGE(FNBPJGFILDN ONJFHIILPIE, IDNPEHCMMLO DEBAEMIFHOC, HNFPMHGLHKB HHFAPFFFDGG, IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK, IJMPLGOCAIG<HBBCJEFCPDN> MPELNFINDJE, IJMPLGOCAIG<EJMHDNENAPL> DGCONFGIFIE, bool MOPMIMMICDI, string NLBAJPAADNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x1D94420", Offset = "0x1D93620", VA = "0x181D94420")]
	public static CGABOBBNAGE GOMGEEBODDD(FNBPJGFILDN ONJFHIILPIE, IDNPEHCMMLO DEBAEMIFHOC, HNFPMHGLHKB DHLDOFLJLMH, IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK, IJMPLGOCAIG<EJMHDNENAPL> DGCONFGIFIE, IJMPLGOCAIG<HBBCJEFCPDN> MPELNFINDJE, bool MOPMIMMICDI, bool MGNFMDBDFDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0xDAC360", Offset = "0xDAB560", VA = "0x180DAC360")]
	internal void OOEPHHKBMCD(IJMPLGOCAIG<HBBCJEFCPDN> AFCGKMGKPEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class BJEGNLAMNAP : MHPILBAHAKP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct IECDJNNCFDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private FHIFEBEMLPO? PHFOJMALFPC;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1DA08C0", Offset = "0x1D9FAC0", VA = "0x181DA08C0")]
		public void IICCKONGNNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1DA08D0", Offset = "0x1D9FAD0", VA = "0x181DA08D0")]
		public FHIFEBEMLPO MHJJPEIDEFJ(BJEGNLAMNAP DIKILFBEJDC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	protected readonly FNBPJGFILDN IOEBOFEFKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected readonly IDNPEHCMMLO IFFKKMPHGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private IECDJNNCFDI IFPCDMFOIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly AHLKMBEEGCM NJEFIDHLJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly List<KJLEFEFILPO> LHPPCFAACKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly List<OGOJICHKHOJ> JABFBHMODHI;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IEnumerable<StaticEdge> BGKCIGAGBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D930B0", Offset = "0x1D922B0", VA = "0x181D930B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public DisplayKind KBKCGMFCKKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7CB110", Offset = "0x7CA310", VA = "0x1807CB110", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public JJGAGGDHEOK<ENDAAFIJDLG> LIMODNNMPAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1D93390", Offset = "0x1D92590", VA = "0x181D93390", Slot = "6")]
		get
		{
			return default(JJGAGGDHEOK<ENDAAFIJDLG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public BIOGPKOIHNJ NOLFGAGECBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x198E620", Offset = "0x198D820", VA = "0x18198E620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public JLMPEGMBPLO BGNEFHGKJNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1D926E0", Offset = "0x1D918E0", VA = "0x181D926E0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	protected FHIFEBEMLPO KMMJGMEDLBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1D926E0", Offset = "0x1D918E0", VA = "0x181D926E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public PortImage JMADPEPOKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1D93200", Offset = "0x1D92400", VA = "0x181D93200", Slot = "12")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public string IHKMJLPGIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D40", Offset = "0x7C0F40", VA = "0x1807C1D40", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D80", Offset = "0x7C0F80", VA = "0x1807C1D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public JJGAGGDHEOK<CNEFPEIGAAA> LNOFEGNKKHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x1D92930", Offset = "0x1D91B30", VA = "0x181D92930", Slot = "8")]
		get
		{
			return default(JJGAGGDHEOK<CNEFPEIGAAA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public IJMPLGOCAIG<KPOOLCGJDAJ> IEIBMJEEBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x85E0E0", Offset = "0x85D2E0", VA = "0x18085E0E0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(IJMPLGOCAIG<KPOOLCGJDAJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x183B270", Offset = "0x183A470", VA = "0x18183B270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public abstract IJMPLGOCAIG<LHBCDNLAFEP> DCANCFOPLGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1D933C0", Offset = "0x1D925C0", VA = "0x181D933C0")]
	protected BJEGNLAMNAP(FNBPJGFILDN ONJFHIILPIE, IDNPEHCMMLO DEBAEMIFHOC, AHLKMBEEGCM IHCAGGOMLOI, IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK, bool MOPMIMMICDI, string NLBAJPAADNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x1D92190", Offset = "0x1D91390", VA = "0x181D92190", Slot = "20")]
	protected virtual void AKCGAJHNOGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x1D92780", Offset = "0x1D91980", VA = "0x181D92780", Slot = "21")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x1D928D0", Offset = "0x1D91AD0", VA = "0x181D928D0", Slot = "13")]
	public void FLGFOKNODDH(KJLEFEFILPO FMBMJNHALKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x1D92680", Offset = "0x1D91880", VA = "0x181D92680", Slot = "14")]
	public void BOJFEIPPPCB(OGOJICHKHOJ FMBMJNHALKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x1D92B00", Offset = "0x1D91D00", VA = "0x181D92B00", Slot = "15")]
	public void JIMMBEKBEJO(MILMCJCPECN DDNCACHIOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1D93330", Offset = "0x1D92530", VA = "0x181D93330", Slot = "22")]
	protected virtual void MJNFEKHFJFO(MILMCJCPECN DDNCACHIOBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1D924F0", Offset = "0x1D916F0", VA = "0x181D924F0")]
	private void BLLDJJEGHNL(bool BBEDKDLIKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x1D92950", Offset = "0x1D91B50", VA = "0x181D92950")]
	private void ICEOKJIJBAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1D922E0", Offset = "0x1D914E0", VA = "0x181D922E0")]
	private void BJKHLCOFBEH([In] DKPCLMBOKML FEGNFKDCLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x1D92130", Offset = "0x1D91330", VA = "0x181D92130", Slot = "16")]
	public void AJEFDKLGHKP(KJLEFEFILPO FMBMJNHALKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x1D92490", Offset = "0x1D91690", VA = "0x181D92490", Slot = "17")]
	public void BKDFDOKDBHO(OGOJICHKHOJ FMBMJNHALKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x7C1D80", Offset = "0x7C0F80", VA = "0x1807C1D80")]
	internal void FIGBDNOIKHH(string NLBAJPAADNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1D93090", Offset = "0x1D92290", VA = "0x181D93090")]
	internal void KHOFMCEJOMF(PCCLNNEMDBC ECDJFINNJIE, BIOGPKOIHNJ DMEGHACCPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x183B270", Offset = "0x183A470", VA = "0x18183B270")]
	internal void BGHGILHNLOE(IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class ANFMFCILJBE : AJCDKPOOFEA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class HEACAPKOFEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public FNBPJGFILDN circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public IDNPEHCMMLO node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public IJMPLGOCAIG<KPOOLCGJDAJ> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public HEACAPKOFEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x1D9E050", Offset = "0x1D9D250", VA = "0x181D9E050")]
		internal FFIKDJAKOLO JMGBCFJIHFJ((int PortDescIndex, int PortIndex, NICBKOGHEEA InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1D9E0E0", Offset = "0x1D9D2E0", VA = "0x181D9E0E0")]
		internal CGABOBBNAGE MLKNLGKIEDH(HNFPMHGLHKB i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct POGBJOLGADE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public ANFMFCILJBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private MHGAHEKEAGE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1DA7090", Offset = "0x1DA6290", VA = "0x181DA7090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1DA74F0", Offset = "0x1DA66F0", VA = "0x181DA74F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct EMBLDNOKFBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public ANFMFCILJBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public IJMPLGOCAIG<CJHOFKFEOGB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private MHGAHEKEAGE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1D97DC0", Offset = "0x1D96FC0", VA = "0x181D97DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x1D98110", Offset = "0x1D97310", VA = "0x181D98110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct HMGGDLJFBMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public ANFMFCILJBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public IJMPLGOCAIG<EJMHDNENAPL> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private MHGAHEKEAGE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x1D9F450", Offset = "0x1D9E650", VA = "0x181D9F450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1D9F7A0", Offset = "0x1D9E9A0", VA = "0x181D9F7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct IDIHEHLHHIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public ANFMFCILJBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public IJMPLGOCAIG<CJHOFKFEOGB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public IJMPLGOCAIG<CJHOFKFEOGB> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private MHGAHEKEAGE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0500", Offset = "0x1D9F700", VA = "0x181DA0500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0850", Offset = "0x1D9FA50", VA = "0x181DA0850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct HLMDAMKCDJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public ANFMFCILJBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public IJMPLGOCAIG<EJMHDNENAPL> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public IJMPLGOCAIG<EJMHDNENAPL> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private MHGAHEKEAGE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1D9F090", Offset = "0x1D9E290", VA = "0x181D9F090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1D9F3E0", Offset = "0x1D9E5E0", VA = "0x181D9F3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct HHAPAONMIHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public ANFMFCILJBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private MHGAHEKEAGE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1D9E170", Offset = "0x1D9D370", VA = "0x181D9E170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1D9E5E0", Offset = "0x1D9D7E0", VA = "0x181D9E5E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct JNNMHIBNHNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public ANFMFCILJBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private MHGAHEKEAGE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1DA21A0", Offset = "0x1DA13A0", VA = "0x181DA21A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1DA24F0", Offset = "0x1DA16F0", VA = "0x181DA24F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct HMOJLPMFGJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ANFMFCILJBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public IJMPLGOCAIG<CJHOFKFEOGB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private MHGAHEKEAGE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1D9F810", Offset = "0x1D9EA10", VA = "0x181D9F810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x1D9FB60", Offset = "0x1D9ED60", VA = "0x181D9FB60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct BPCAPEKAOLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public ANFMFCILJBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public IJMPLGOCAIG<EJMHDNENAPL> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private MHGAHEKEAGE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x1D93E70", Offset = "0x1D93070", VA = "0x181D93E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x1D941C0", Offset = "0x1D933C0", VA = "0x181D941C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct PFBCLAPMKJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ANFMFCILJBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public GNBGPAGNAII type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public IJMPLGOCAIG<CJHOFKFEOGB> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private MHGAHEKEAGE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1DA69A0", Offset = "0x1DA5BA0", VA = "0x181DA69A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1DA6D30", Offset = "0x1DA5F30", VA = "0x181DA6D30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct PANKKONGABG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public ANFMFCILJBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public GNBGPAGNAII type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public IJMPLGOCAIG<EJMHDNENAPL> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private MHGAHEKEAGE <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x1DA6490", Offset = "0x1DA5690", VA = "0x181DA6490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1DA6820", Offset = "0x1DA5A20", VA = "0x181DA6820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly bool OHHIFKNHBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly FNBPJGFILDN IOEBOFEFKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly bool HFPENKBLPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private PHLMBNFCDFO<JMAMHDJNNLP, FFIKDJAKOLO> IAJJLCEJFMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private PHLMBNFCDFO<JMAMHDJNNLP, OJNHKBCFLFO> HJLKGCMAPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly IDNPEHCMMLO IFFKKMPHGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private PHLMBNFCDFO<HBBCJEFCPDN, CGABOBBNAGE> NCIIKMOPEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private PHLMBNFCDFO<HBBCJEFCPDN, IKFBKMGNOIE> MCMIHFJCPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private string? BGGJPEJAAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly HKKGJGOFILO FPOBLDPALPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private IJMPLGOCAIG<KPOOLCGJDAJ> JAILEIOLJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly bool FMAPEHAPFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[CompilerGenerated]
	private Action? LEGIKOJNDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[CompilerGenerated]
	private Action? DEAGEOJELIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	[CompilerGenerated]
	private Action<IJMPLGOCAIG<JMAMHDJNNLP>>? JNCNDOLFAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	[CompilerGenerated]
	private Action<IJMPLGOCAIG<HBBCJEFCPDN>>? CCFAHBPHKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	[CompilerGenerated]
	private AJCDKPOOFEA.MOGFLDAPEFA? CAJICNKAEED;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool LDGBIIMPCNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1D913B0", Offset = "0x1D905B0", VA = "0x181D913B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public bool MCKAJCKNCKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1D90610", Offset = "0x1D8F810", VA = "0x181D90610", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool ALOFAHPAJDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D90310", Offset = "0x1D8F510", VA = "0x181D90310", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public JJGAGGDHEOK<ENDAAFIJDLG> LIMODNNMPAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1D90650", Offset = "0x1D8F850", VA = "0x181D90650", Slot = "7")]
		get
		{
			return default(JJGAGGDHEOK<ENDAAFIJDLG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool PBPAJJGJFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x1D8DED0", Offset = "0x1D8D0D0", VA = "0x181D8DED0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public PHLMBNFCDFO<JMAMHDJNNLP, OJNHKBCFLFO> IEKILAHOPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3C0", Offset = "0x7B95C0", VA = "0x1807BA3C0", Slot = "9")]
		get
		{
			return default(PHLMBNFCDFO<JMAMHDJNNLP, OJNHKBCFLFO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public string IHKMJLPGIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1D8B560", Offset = "0x1D8A760", VA = "0x181D8B560", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public JJGAGGDHEOK<CNEFPEIGAAA> LNOFEGNKKHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1D8EB80", Offset = "0x1D8DD80", VA = "0x181D8EB80", Slot = "11")]
		get
		{
			return default(JJGAGGDHEOK<CNEFPEIGAAA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public PHLMBNFCDFO<HBBCJEFCPDN, IKFBKMGNOIE> MAGEJBCGJEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x7C1D40", Offset = "0x7C0F40", VA = "0x1807C1D40", Slot = "12")]
		get
		{
			return default(PHLMBNFCDFO<HBBCJEFCPDN, IKFBKMGNOIE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public IJMPLGOCAIG<KPOOLCGJDAJ> IEIBMJEEBLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA30B20", Offset = "0xA2FD20", VA = "0x180A30B20", Slot = "13")]
		get
		{
			return default(IJMPLGOCAIG<KPOOLCGJDAJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action NFCFLNHJOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1D8E660", Offset = "0x1D8D860", VA = "0x181D8E660", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1D8C7A0", Offset = "0x1D8B9A0", VA = "0x181D8C7A0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action GLNCIOJJCAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1D8DE20", Offset = "0x1D8D020", VA = "0x181D8DE20", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x1D8E5B0", Offset = "0x1D8D7B0", VA = "0x181D8E5B0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<IJMPLGOCAIG<JMAMHDJNNLP>, IJMPLGOCAIG<JMAMHDJNNLP>> NEIFBGCEGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1D8FE90", Offset = "0x1D8F090", VA = "0x181D8FE90", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x1D8DD60", Offset = "0x1D8CF60", VA = "0x181D8DD60", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<IJMPLGOCAIG<JMAMHDJNNLP>, IJMPLGOCAIG<JMAMHDJNNLP>> GMOGAACAGGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D820", Offset = "0x1D8CA20", VA = "0x181D8D820", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x1D8F880", Offset = "0x1D8EA80", VA = "0x181D8F880", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<IJMPLGOCAIG<HBBCJEFCPDN>, IJMPLGOCAIG<HBBCJEFCPDN>> JPCGGOCDDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1D90550", Offset = "0x1D8F750", VA = "0x181D90550", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x1D8F7C0", Offset = "0x1D8E9C0", VA = "0x181D8F7C0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<IJMPLGOCAIG<HBBCJEFCPDN>, IJMPLGOCAIG<HBBCJEFCPDN>> IBDPOFEINBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1D90060", Offset = "0x1D8F260", VA = "0x181D90060", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x1D903D0", Offset = "0x1D8F5D0", VA = "0x181D903D0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<IJMPLGOCAIG<JMAMHDJNNLP>, OJNHKBCFLFO> ANHIBFDLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1D90250", Offset = "0x1D8F450", VA = "0x181D90250", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1D90490", Offset = "0x1D8F690", VA = "0x181D90490", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<IJMPLGOCAIG<JMAMHDJNNLP>> LIOJLGCDNNE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x1D912F0", Offset = "0x1D904F0", VA = "0x181D912F0", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x1D91470", Offset = "0x1D90670", VA = "0x181D91470", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<IJMPLGOCAIG<JMAMHDJNNLP>, OJNHKBCFLFO> DOGCPHOFFFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1D8CA50", Offset = "0x1D8BC50", VA = "0x181D8CA50", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x1D8EAC0", Offset = "0x1D8DCC0", VA = "0x181D8EAC0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<IJMPLGOCAIG<HBBCJEFCPDN>, IKFBKMGNOIE> MGIFBLEGHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x1D8F170", Offset = "0x1D8E370", VA = "0x181D8F170", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x1D8F230", Offset = "0x1D8E430", VA = "0x181D8F230", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<IJMPLGOCAIG<HBBCJEFCPDN>> NDOMAOBBIIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x1D8BDA0", Offset = "0x1D8AFA0", VA = "0x181D8BDA0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x1D8C840", Offset = "0x1D8BA40", VA = "0x181D8C840", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<IJMPLGOCAIG<HBBCJEFCPDN>, IKFBKMGNOIE> MOHKMMMJHEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x1D8F0B0", Offset = "0x1D8E2B0", VA = "0x181D8F0B0", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x1D8C690", Offset = "0x1D8B890", VA = "0x181D8C690", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x1D91530", Offset = "0x1D90730", VA = "0x181D91530")]
	private ANFMFCILJBE(bool MOPMIMMICDI, FNBPJGFILDN ONJFHIILPIE, bool FJBGOPCDPNP, PHLMBNFCDFO<JMAMHDJNNLP, FFIKDJAKOLO> GOLPEMIKAPA, PHLMBNFCDFO<JMAMHDJNNLP, OJNHKBCFLFO> PMOIMCFOBMN, IDNPEHCMMLO DEBAEMIFHOC, PHLMBNFCDFO<HBBCJEFCPDN, CGABOBBNAGE> MDOJGMHFPEM, PHLMBNFCDFO<HBBCJEFCPDN, IKFBKMGNOIE> BLDNGGCKOAC, string? BMOJIDMPFIM, HKKGJGOFILO AFHADLKPOHM, IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK, bool MGNFMDBDFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x1D8DF50", Offset = "0x1D8D150", VA = "0x181D8DF50")]
	public static ANFMFCILJBE GOMGEEBODDD(bool MOPMIMMICDI, FNBPJGFILDN ONJFHIILPIE, bool FJBGOPCDPNP, IDNPEHCMMLO DEBAEMIFHOC, HKKGJGOFILO AFHADLKPOHM, IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK, bool MGNFMDBDFDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x1D8B5F0", Offset = "0x1D8A7F0", VA = "0x181D8B5F0")]
	private void AKCGAJHNOGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x1D8CD20", Offset = "0x1D8BF20", VA = "0x181D8CD20", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x1D8CC30", Offset = "0x1D8BE30", VA = "0x181D8CC30", Slot = "38")]
	[AsyncStateMachine(typeof(POGBJOLGADE))]
	public Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> DODIKAHNGEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1D907B0", Offset = "0x1D8F9B0", VA = "0x181D907B0")]
	private (NIABCPNGCOF, int)? OFEBABNIOGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E4C0", Offset = "0x1D8D6C0", VA = "0x181D8E4C0")]
	private void GPFMLHEEOKP(int HKODJIJHNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x1255310", Offset = "0x1254510", VA = "0x181255310")]
	private void DHONGGPLNBI(int HKODJIJHNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F420", Offset = "0x1D8E620", VA = "0x181D8F420")]
	private void KDKPOLHOJKK(int LBHPIOBHNLO, int MNCDLNBFAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x1D8B590", Offset = "0x1D8A790", VA = "0x181D8B590")]
	private void AFAMOOLNAOK(int LBHPIOBHNLO, int MNCDLNBFAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1D90DB0", Offset = "0x1D8FFB0", VA = "0x181D90DB0")]
	private void OPNMLDENGDG(int HKODJIJHNPF, int MBKHEIGBFMN, NICBKOGHEEA MLNANLHFBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1D8EF40", Offset = "0x1D8E140", VA = "0x181D8EF40")]
	private void IIILMIGJJKL(int BBEDKDLIKBI, int MBKHEIGBFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x1D8C750", Offset = "0x1D8B950", VA = "0x181D8C750")]
	private void CJMIIDNFOJP(int BBEDKDLIKBI, int MBKHEIGBFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1D8BE60", Offset = "0x1D8B060", VA = "0x181D8BE60")]
	private void BBJNCLKGOIG(int HKODJIJHNPF, int MBKHEIGBFMN, NICBKOGHEEA MLNANLHFBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1D8C900", Offset = "0x1D8BB00", VA = "0x181D8C900")]
	private void COIBIPMODNI(int HKODJIJHNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x961900", Offset = "0x960B00", VA = "0x180961900")]
	private void HBOLEMLMCHM(int HKODJIJHNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E840", Offset = "0x1D8DA40", VA = "0x181D8E840")]
	private void HFPPGOBCMCL(int HKODJIJHNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1255310", Offset = "0x1254510", VA = "0x181255310")]
	private void KGOPBCNMGEP(int HKODJIJHNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x1D8EBA0", Offset = "0x1D8DDA0", VA = "0x181D8EBA0")]
	private void IFHIJGOHJAA(int LBHPIOBHNLO, int MNCDLNBFAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x1D8EA60", Offset = "0x1D8DC60", VA = "0x181D8EA60")]
	private void HNJDEEOOIGP(int LBHPIOBHNLO, int MNCDLNBFAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F940", Offset = "0x1D8EB40", VA = "0x181D8F940")]
	private void KOBLDEGJDHA(int HKODJIJHNPF, int MBKHEIGBFMN, HNFPMHGLHKB MLNANLHFBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x1D90D60", Offset = "0x1D8FF60", VA = "0x181D90D60")]
	private void OOAHIEMCGMF(int BBEDKDLIKBI, int MBKHEIGBFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E7F0", Offset = "0x1D8D9F0", VA = "0x181D8E7F0")]
	private void HFNMOOEIGEH(int BBEDKDLIKBI, int MBKHEIGBFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x1D8D8E0", Offset = "0x1D8CAE0", VA = "0x181D8D8E0")]
	private void EIIJJFINIIJ(int HKODJIJHNPF, int MBKHEIGBFMN, HNFPMHGLHKB MLNANLHFBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x1D90C10", Offset = "0x1D8FE10", VA = "0x181D90C10")]
	private void OLPBFOKNLHI(int HKODJIJHNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x961900", Offset = "0x960B00", VA = "0x180961900")]
	private void LIDHBLDIJGA(int HKODJIJHNPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x1D909E0", Offset = "0x1D8FBE0", VA = "0x181D909E0", Slot = "39")]
	[AsyncStateMachine(typeof(EMBLDNOKFBH))]
	public Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> OIEKPNMMJNN(IJMPLGOCAIG<CJHOFKFEOGB> OCGGOKMCDHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x1D8FF50", Offset = "0x1D8F150", VA = "0x181D8FF50", Slot = "40")]
	[AsyncStateMachine(typeof(HMGGDLJFBMO))]
	public Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> LBILLOJLABM(IJMPLGOCAIG<EJMHDNENAPL> DGCONFGIFIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x1D8EF90", Offset = "0x1D8E190", VA = "0x181D8EF90", Slot = "41")]
	[AsyncStateMachine(typeof(IDIHEHLHHIA))]
	public Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> IMCCJNCCPLK(IJMPLGOCAIG<CJHOFKFEOGB> OCGGOKMCDHH, IJMPLGOCAIG<CJHOFKFEOGB> HILDJIMNBDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x1D8CB10", Offset = "0x1D8BD10", VA = "0x181D8CB10", Slot = "42")]
	[AsyncStateMachine(typeof(HLMDAMKCDJB))]
	public Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> DFBLADFLALH(IJMPLGOCAIG<EJMHDNENAPL> DGCONFGIFIE, IJMPLGOCAIG<EJMHDNENAPL> HILDJIMNBDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E700", Offset = "0x1D8D900", VA = "0x181D8E700", Slot = "43")]
	[AsyncStateMachine(typeof(HHAPAONMIHG))]
	public Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> HFCHAHHFINE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x1D90AF0", Offset = "0x1D8FCF0", VA = "0x181D90AF0", Slot = "44")]
	[AsyncStateMachine(typeof(JNNMHIBNHNG))]
	public Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> OKFFDNKLLEM(string ADPBOGMKGIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x1D8E930", Offset = "0x1D8DB30", VA = "0x181D8E930", Slot = "45")]
	[AsyncStateMachine(typeof(HMOJLPMFGJP))]
	public Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> HLLCDDCILOO(IJMPLGOCAIG<CJHOFKFEOGB> OCGGOKMCDHH, string NLBAJPAADNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x1D90680", Offset = "0x1D8F880", VA = "0x181D90680", Slot = "46")]
	[AsyncStateMachine(typeof(BPCAPEKAOLJ))]
	public Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> ODNIJLFEHCC(IJMPLGOCAIG<EJMHDNENAPL> DGCONFGIFIE, string NLBAJPAADNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x1D90120", Offset = "0x1D8F320", VA = "0x181D90120", Slot = "47")]
	[AsyncStateMachine(typeof(PFBCLAPMKJA))]
	public Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> LOLONKIBPGP(IJMPLGOCAIG<CJHOFKFEOGB> OCGGOKMCDHH, GNBGPAGNAII DMEGHACCPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x1D8F2F0", Offset = "0x1D8E4F0", VA = "0x181D8F2F0", Slot = "48")]
	[AsyncStateMachine(typeof(PANKKONGABG))]
	public Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> JPDEEKEOMCD(IJMPLGOCAIG<EJMHDNENAPL> DGCONFGIFIE, GNBGPAGNAII DMEGHACCPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x1D8C2C0", Offset = "0x1D8B4C0", VA = "0x181D8C2C0")]
	internal void BGHGILHNLOE(IJMPLGOCAIG<KPOOLCGJDAJ> AFCGKMGKPEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public sealed class GPFAAHLMODN : GODFEFLGLEG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public interface INMMNOCHLPF
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		PCCLNNEMDBC KGFEKIDLFBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<LNMBGNPCGOG> LMABINPDCIL(CancellationToken OBNOJDAGGOE);

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<EKCGLIJJMGJ> EKCFNGLCGOC(CancellationToken OBNOJDAGGOE);

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<PKLIMKBHLBL> BHOCKGDLKIF(CancellationToken OBNOJDAGGOE);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct BGHLGHLDBBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public AsyncTaskMethodBuilder<GPFAAHLMODN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public FNBPJGFILDN circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public LNMBGNPCGOG roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public EKCGLIJJMGJ superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private INMMNOCHLPF <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private EKCGLIJJMGJ <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private TaskAwaiter<LNMBGNPCGOG> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter<EKCGLIJJMGJ> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<PKLIMKBHLBL> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter<FDNAGLPJLED> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1D91700", Offset = "0x1D90900", VA = "0x181D91700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x1D920C0", Offset = "0x1D912C0", VA = "0x181D920C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private readonly FDNAGLPJLED FDMKDGHLLPC;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public FDNAGLPJLED AIDPBLANOFL
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	private GPFAAHLMODN(FDNAGLPJLED OCJLJKLDFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x1D9DB30", Offset = "0x1D9CD30", VA = "0x181D9DB30")]
	[AsyncStateMachine(typeof(BGHLGHLDBBH))]
	public static Task<GPFAAHLMODN> MKLNCNNEGKA(FNBPJGFILDN ONJFHIILPIE, LNMBGNPCGOG? OMKGFBDCDEE, EKCGLIJJMGJ? GEFOMNELNJN, CancellationToken OBNOJDAGGOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x1D9DB10", Offset = "0x1D9CD10", VA = "0x181D9DB10", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct JDIJLIEFLBC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct FMNPFMNAPBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public JDIJLIEFLBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public GFABBJEKLJG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TaskAwaiter<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x1D9B2E0", Offset = "0x1D9A4E0", VA = "0x181D9B2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x1D9B570", Offset = "0x1D9A770", VA = "0x181D9B570", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct ICJIOMNHLBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<bool, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public GLPPJOHAHLM rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public LNMBGNPCGOG circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public EKCGLIJJMGJ superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public JDIJLIEFLBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private GFABBJEKLJG[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private TaskAwaiter<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x1DA00B0", Offset = "0x1D9F2B0", VA = "0x181DA00B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0490", Offset = "0x1D9F690", VA = "0x181DA0490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct LAJNBBEHNNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public JDIJLIEFLBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private TaskAwaiter<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x1DA28F0", Offset = "0x1DA1AF0", VA = "0x181DA28F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2BD0", Offset = "0x1DA1DD0", VA = "0x181DA2BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly OJPAADNIADI NGPDPOEJBED;

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x947980", Offset = "0x946B80", VA = "0x180947980")]
	public JDIJLIEFLBC(OJPAADNIADI LNMNAOOCBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1570", Offset = "0x1DA0770", VA = "0x181DA1570")]
	[AsyncStateMachine(typeof(FMNPFMNAPBG))]
	private Task<BLNBDNPDEEM<object, NGDCAOKOLMO>> KPFPONPDKAN(GFABBJEKLJG CEBHNDLCHED, bool CECOGGPIDAC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x1DA16A0", Offset = "0x1DA08A0", VA = "0x181DA16A0")]
	[AsyncStateMachine(typeof(ICJIOMNHLBA))]
	public Task<BLNBDNPDEEM<bool, NGDCAOKOLMO?>>? NOBEKNPKODC(int MIFABPLDJBP, GLPPJOHAHLM? MILEALDCLGB, LNMBGNPCGOG? KMPEDLCINIF, EKCGLIJJMGJ? GEFOMNELNJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1DA1480", Offset = "0x1DA0680", VA = "0x181DA1480")]
	[AsyncStateMachine(typeof(LAJNBBEHNNG))]
	public Task<BLNBDNPDEEM<PGENBOHGKNI, NGDCAOKOLMO>> JNJLPFFCJBK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public sealed class DJCGOKBFCHM : KHOFFOEEIGN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly DEPGEFJDAKB DGEEGJMNAJM;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public DEPGEFJDAKB PLCCFDJOKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	private DJCGOKBFCHM(DEPGEFJDAKB EJIIFGPEFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x1D97390", Offset = "0x1D96590", VA = "0x181D97390")]
	public static DJCGOKBFCHM APPDJDLGIOH(FNBPJGFILDN ONJFHIILPIE, GLPPJOHAHLM OJFIHCLFNCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x1D97560", Offset = "0x1D96760", VA = "0x181D97560", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface KEFKCLNCGAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	JJIKOOMAOKJ FIDCGPAFCCA
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	IDKBGAMJALG MFOFKHKDDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	DLFDADOKPDM PJBPKBAFDPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	IHMNJMJCBJI LBJLKFMFGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	CMIMGBAEJKG LKKAGEIPGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface LOHNCJMLFJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	KEFKCLNCGAN? ADHFFBOMNIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool NHGADOFHDEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	bool FNMNCNKKGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<KEFKCLNCGAN?>? KGEHLCBADAD();

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HIPAOPBPKDI(FNBPJGFILDN ONJFHIILPIE, GLPPJOHAHLM OJFIHCLFNCD, LNMBGNPCGOG? PCCOKDNFFCH, EKCGLIJJMGJ? IGMCEBBAMAG);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[OLCPCAGCGFL("IStaticCV2Instance")]
public interface GODFEFLGLEG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	FDNAGLPJLED AIDPBLANOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[OLCPCAGCGFL("IStaticEVInstance")]
public interface KHOFFOEEIGN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	DEPGEFJDAKB PLCCFDJOKCI
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public sealed class ECGHJJINALF : DIBPGOMADEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly FNBPJGFILDN IOEBOFEFKBF;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public DIHMGGEGPIP? MJANIPKLNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x1D97B20", Offset = "0x1D96D20", VA = "0x181D97B20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	internal ECGHJJINALF(FNBPJGFILDN ONJFHIILPIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public sealed class IHMNJMJCBJI : DIHMGGEGPIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly GODFEFLGLEG PAGIBGGPOPH;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public AKGMBBMCJCI KPFPONPDKAN
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1DA09E0", Offset = "0x1D9FBE0", VA = "0x181DA09E0", Slot = "4")]
		get
		{
			return default(AKGMBBMCJCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public KABKGLOPGJF PKODKEIOKEE
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0A40", Offset = "0x1D9FC40", VA = "0x181DA0A40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public JJGAGGDHEOK<ENDAAFIJDLG> JKFFMKBKJLD
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0AF0", Offset = "0x1D9FCF0", VA = "0x181DA0AF0", Slot = "6")]
		get
		{
			return default(JJGAGGDHEOK<ENDAAFIJDLG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public FDNAGLPJLED PFLCOIOIIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1DA0AA0", Offset = "0x1D9FCA0", VA = "0x181DA0AA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	public IHMNJMJCBJI(GODFEFLGLEG ADAKDDJLKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x1DA0970", Offset = "0x1D9FB70", VA = "0x181DA0970")]
	public bool EFHGDFIAOGK([In] JJGAGGDHEOK<ENDAAFIJDLG> JAKGJEDDCHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x1DA0970", Offset = "0x1D9FB70", VA = "0x181DA0970", Slot = "8")]
	private bool JICCGNCPDAO([In] JJGAGGDHEOK<ENDAAFIJDLG> JAKGJEDDCHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class NKGOGLCKJEK
{
	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4310", Offset = "0x1DA3510", VA = "0x181DA4310")]
	public static KPFNCFLBNFC<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN, CMJGBBOLMCF.MPBGOOCJJMA<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN>> HAAJPOBEDAC([In] this KPFNCFLBNFC<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN, CMJGBBOLMCF.MPBGOOCJJMA<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN>> BJAGIPHNFNL)
	{
		return default(KPFNCFLBNFC<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN, CMJGBBOLMCF.MPBGOOCJJMA<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public sealed class JMMELGEPHME : GOADEFPFPNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly FNBPJGFILDN IOEBOFEFKBF;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool FNMNCNKKGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2120", Offset = "0x1DA1320", VA = "0x181DA2120", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	internal JMMELGEPHME(FNBPJGFILDN ONJFHIILPIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class OAMJEOIIBCH : LLDGIOJNCEP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct FPOHOECJDBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder<DPFEBOHIMHK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public OAMJEOIIBCH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<KEFKCLNCGAN?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x1D9CF00", Offset = "0x1D9C100", VA = "0x181D9CF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1D9D1B0", Offset = "0x1D9C3B0", VA = "0x181D9D1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly FNBPJGFILDN IOEBOFEFKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private IReadOnlyList<JJGAGGDHEOK<ILILDDKGAMF>>? HJPBMFKLLHC;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public DPFEBOHIMHK? MJANIPKLNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1DA55E0", Offset = "0x1DA47E0", VA = "0x181DA55E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public CMIMGBAEJKG? MMIOFCBLGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1DA5DE0", Offset = "0x1DA4FE0", VA = "0x181DA5DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool FDMMCEPLJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x1DA5E60", Offset = "0x1DA5060", VA = "0x181DA5E60", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool PLNFOBHILFD
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1DA5580", Offset = "0x1DA4780", VA = "0x181DA5580", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	internal OAMJEOIIBCH(FNBPJGFILDN ONJFHIILPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5AB0", Offset = "0x1DA4CB0", VA = "0x181DA5AB0", Slot = "7")]
	[AsyncStateMachine(typeof(FPOHOECJDBJ))]
	public Task<DPFEBOHIMHK> HHGEEFHMCIN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5210", Offset = "0x1DA4410", VA = "0x181DA5210")]
	internal Dictionary<JJGAGGDHEOK<ENDAAFIJDLG>, Guid> BHKFBKMMCAC(IEnumerable<ENBAAEOIEMA> CGFJGLIEOLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5BE0", Offset = "0x1DA4DE0", VA = "0x181DA5BE0")]
	public BLNBDNPDEEM<KNANKFAFGKO, CHOGLKODFOC> KANJFBCHEDD([In] KNANKFAFGKO APALHCHEGKM, IEnumerable<ENBAAEOIEMA> MHGAALOFKAO, int DBOHFFJIPOK)
	{
		return default(BLNBDNPDEEM<KNANKFAFGKO, CHOGLKODFOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5BA0", Offset = "0x1DA4DA0", VA = "0x181DA5BA0")]
	internal static ACLKEIAFHHL IIPFOLDBKKH(PLLJFMMMKKL ONDINBPNLJN, IDNPEHCMMLO DEBAEMIFHOC)
	{
		return default(ACLKEIAFHHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5660", Offset = "0x1DA4860", VA = "0x181DA5660", Slot = "8")]
	private BLNBDNPDEEM<KNANKFAFGKO, CHOGLKODFOC> GHIPPCHIBGL([In] KNANKFAFGKO APALHCHEGKM, IEnumerable<ENBAAEOIEMA> MHGAALOFKAO, int DBOHFFJIPOK)
	{
		return default(BLNBDNPDEEM<KNANKFAFGKO, CHOGLKODFOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5860", Offset = "0x1DA4A60", VA = "0x181DA5860")]
	[CompilerGenerated]
	internal static ACLKEIAFHHL HAHIDKIPCGG(PLLJFMMMKKL GFMNHFDJCJN, IDNPEHCMMLO OOGEGMBJOCB)
	{
		return default(ACLKEIAFHHL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public sealed class CMIMGBAEJKG : DPFEBOHIMHK
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class JHOIEGJBLAD
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class BMBABHMNCPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public FDNAGLPJLED state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public ACLGEAAINGH spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
			public BMBABHMNCPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x1DA85F0", Offset = "0x1DA77F0", VA = "0x181DA85F0")]
			internal bool JHFLOJBBIAO(HNHNHHNHOJH n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class GGJFPHNIIHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
			public GGJFPHNIIHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x1DAA660", Offset = "0x1DA9860", VA = "0x181DAA660")]
			internal void ENGINFMBLEC(HNHNHHNHOJH n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x1DACCE0", Offset = "0x1DABEE0", VA = "0x181DACCE0")]
		public static BLNBDNPDEEM<DPFEBOHIMHK.PBJPJPJABAC, CHOGLKODFOC> PNGLLFMNHOL(CMIMGBAEJKG KPBGCHDNDLM, [In] DPFEBOHIMHK.LHLCMFOLHIM KFIENCBOEKJ)
		{
			return default(BLNBDNPDEEM<DPFEBOHIMHK.PBJPJPJABAC, CHOGLKODFOC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1DABF90", Offset = "0x1DAB190", VA = "0x181DABF90")]
		internal static BLNBDNPDEEM<(BFKKFKDLMGP, KIAFFLIDGPN), NGDCAOKOLMO> NCFEKKADPED(CMIMGBAEJKG KPBGCHDNDLM, KIAFFLIDGPN PIOGJLMAIBC, bool MNOHNHCMFPF, [In] JJGAGGDHEOK<ENDAAFIJDLG> KPCBIBNBDIN, [In] int? NLBDOABIIEE, [In] ACLKEIAFHHL? AOELCPAFHDM, [In] ACLKEIAFHHL? KLFNDNMIABE)
		{
			return default(BLNBDNPDEEM<(BFKKFKDLMGP, KIAFFLIDGPN), NGDCAOKOLMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1DAB6F0", Offset = "0x1DAA8F0", VA = "0x181DAB6F0")]
		private static void HEAKADNOLNJ(bool MNOHNHCMFPF, ENBAAEOIEMA KPJGGGPNEJL, BFKKFKDLMGP ODIIIKDGMOH, [In] JJGAGGDHEOK<ENDAAFIJDLG> KPCBIBNBDIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1DABB80", Offset = "0x1DAAD80", VA = "0x181DABB80")]
		public static void HIGFOINCGAH(BDJLPIAJMMF BCAEGNDLFOK, [In] DPFEBOHIMHK.IFMHGKCAMMM IJIBAKNPJKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1DAB600", Offset = "0x1DAA800", VA = "0x181DAB600")]
		[CompilerGenerated]
		internal static bool CHMGPJMKJHN(FDNAGLPJLED FBKEKHEHGDL, ACLGEAAINGH LHHBEOLCGPC, HNHNHHNHOJH OGOFOPPHOLO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly FNBPJGFILDN IOEBOFEFKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly GODFEFLGLEG PAGIBGGPOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly KHOFFOEEIGN LMNGCNOHPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly EFPPNAEPHDC CPBOAKCIGNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly OAMJEOIIBCH LPEOACLJNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	private Dictionary<JJGAGGDHEOK<CNEFPEIGAAA>, KCPNJNKEDLG> ONDDMHEJGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	[CompilerGenerated]
	private Action<JJGAGGDHEOK<CNEFPEIGAAA>>? CHFACLMDCFL;

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1D96FB0", Offset = "0x1D961B0", VA = "0x181D96FB0")]
	public CMIMGBAEJKG(FNBPJGFILDN ONJFHIILPIE, GODFEFLGLEG ADAKDDJLKBA, KHOFFOEEIGN CKECPJLAMBE, OAMJEOIIBCH JGBEEMPDJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1D95220", Offset = "0x1D94420", VA = "0x181D95220")]
	public KCPNJNKEDLG? EDBKEMHICJB([In] JJGAGGDHEOK<CNEFPEIGAAA> CPDCLGDPBBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x1D962C0", Offset = "0x1D954C0", VA = "0x181D962C0")]
	private void LBEBBBHLMHA(JJGAGGDHEOK<CNEFPEIGAAA> CPDCLGDPBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x1D96210", Offset = "0x1D95410", VA = "0x181D96210")]
	private KCPNJNKEDLG? KMHIPNDELBP([In] JJGAGGDHEOK<CNEFPEIGAAA> CPDCLGDPBBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x1D95490", Offset = "0x1D94690", VA = "0x181D95490")]
	public IDNPEHCMMLO? HGAKJMEKFEA([In] JJGAGGDHEOK<CNEFPEIGAAA> CPDCLGDPBBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x1D95210", Offset = "0x1D94410", VA = "0x181D95210")]
	public JHKEKFANGED? CEEGHIBGICM([In] JJGAGGDHEOK<ENDAAFIJDLG> JAKGJEDDCHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1D95390", Offset = "0x1D94590", VA = "0x181D95390")]
	private ACLGEAAINGH? EFBBGOMMBDC([In] JJGAGGDHEOK<ENDAAFIJDLG> JAKGJEDDCHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1D95610", Offset = "0x1D94810", VA = "0x181D95610")]
	private JHKEKFANGED? IMDEEOLLLAI([In] JJGAGGDHEOK<ENDAAFIJDLG> JAKGJEDDCHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1D95520", Offset = "0x1D94720", VA = "0x181D95520", Slot = "6")]
	public IEnumerable<GNBGPAGNAII> HPPAFJGCHPL(bool DAECHDOOKDD, bool CKHJAMPINDI, bool FJCDCLFCMFD, bool POGBCEGDAMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1D95090", Offset = "0x1D94290", VA = "0x181D95090")]
	public BLNBDNPDEEM<DPFEBOHIMHK.PBJPJPJABAC, CHOGLKODFOC> AHDHGDDNENH([In] DPFEBOHIMHK.LHLCMFOLHIM KFIENCBOEKJ)
	{
		return default(BLNBDNPDEEM<DPFEBOHIMHK.PBJPJPJABAC, CHOGLKODFOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1D967E0", Offset = "0x1D959E0", VA = "0x181D967E0", Slot = "8")]
	public BLNBDNPDEEM<DKBHHBJIEIC, CHOGLKODFOC> MMKCAOFLHPK(JJGAGGDHEOK<ENDAAFIJDLG> JAKGJEDDCHL, DKBHHBJIEIC GJCMGKDNEDI, MCNNNFLOCPG FNDGMDKLMDB)
	{
		return default(BLNBDNPDEEM<DKBHHBJIEIC, CHOGLKODFOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x1D96DC0", Offset = "0x1D95FC0", VA = "0x181D96DC0", Slot = "9")]
	public IAMGFNAOCEC PAHEHBEHLLI(IEnumerable<ENBAAEOIEMA> MHGAALOFKAO)
	{
		return default(IAMGFNAOCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1D96340", Offset = "0x1D95540", VA = "0x181D96340", Slot = "10")]
	public IAMGFNAOCEC LPKAIFALHBM()
	{
		return default(IAMGFNAOCEC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1D95BC0", Offset = "0x1D94DC0", VA = "0x181D95BC0")]
	private LDDAKDLMING JHEIOFANNKB(EMHMDEFCEPO MHMONDKDCML, IJMPLGOCAIG<ENDAAFIJDLG> NJMLNHMKDLP, IEnumerable<JJGAGGDHEOK<ENDAAFIJDLG>> MPFODFKLNAG, IEnumerable<JJGAGGDHEOK<CNEFPEIGAAA>> DHGLALHJIDO)
	{
		return default(LDDAKDLMING);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1D95880", Offset = "0x1D94A80", VA = "0x181D95880", Slot = "11")]
	public LDDAKDLMING JHEIOFANNKB(EMHMDEFCEPO MHMONDKDCML, IJMPLGOCAIG<ENDAAFIJDLG> NJMLNHMKDLP, IEnumerable<JJGAGGDHEOK<CNEFPEIGAAA>> DHGLALHJIDO, IEnumerable<ENBAAEOIEMA> MHGAALOFKAO)
	{
		return default(LDDAKDLMING);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1D96460", Offset = "0x1D95660", VA = "0x181D96460")]
	private static IEnumerable<JJGAGGDHEOK<ENDAAFIJDLG>> MHGGACNCOPL(IEnumerable<ENBAAEOIEMA> MHGAALOFKAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1D95D70", Offset = "0x1D94F70", VA = "0x181D95D70")]
	private IEnumerable<JJGAGGDHEOK<CNEFPEIGAAA>> JJGEMDFLFFK(IEnumerable<ENBAAEOIEMA> MHGAALOFKAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1D96CC0", Offset = "0x1D95EC0", VA = "0x181D96CC0", Slot = "12")]
	public List<JCJBLBNEMKC> ODELICCCMLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1D95820", Offset = "0x1D94A20", VA = "0x181D95820")]
	internal void JBDCPKOJDGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x1D95430", Offset = "0x1D94630", VA = "0x181D95430")]
	internal Task FIFNFGHICJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x1D95210", Offset = "0x1D94410", VA = "0x181D95210", Slot = "4")]
	private JHKEKFANGED GHHFOLODEOP([In] JJGAGGDHEOK<ENDAAFIJDLG> JAKGJEDDCHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1D950C0", Offset = "0x1D942C0", VA = "0x181D950C0", Slot = "5")]
	private KCPNJNKEDLG CBHNEHBNGCO([In] JJGAGGDHEOK<CNEFPEIGAAA> CPDCLGDPBBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x1D95090", Offset = "0x1D94290", VA = "0x181D95090", Slot = "7")]
	private BLNBDNPDEEM<DPFEBOHIMHK.PBJPJPJABAC, CHOGLKODFOC> PNEKDNFHADI([In] DPFEBOHIMHK.LHLCMFOLHIM KFIENCBOEKJ)
	{
		return default(BLNBDNPDEEM<DPFEBOHIMHK.PBJPJPJABAC, CHOGLKODFOC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x1D96BD0", Offset = "0x1D95DD0", VA = "0x181D96BD0")]
	[CompilerGenerated]
	private FFONHKKMHFD NCECJFBFPBN(BIOGPKOIHNJ ABHDANNAKPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x1D96D50", Offset = "0x1D95F50", VA = "0x181D96D50")]
	[CompilerGenerated]
	private IDNPEHCMMLO OGLDMEJIFHA(JJGAGGDHEOK<CNEFPEIGAAA> ABHDANNAKPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x1D96C50", Offset = "0x1D95E50", VA = "0x181D96C50")]
	[CompilerGenerated]
	private ACLGEAAINGH OCJLEIDACFB(JJGAGGDHEOK<ENDAAFIJDLG> ABHDANNAKPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public sealed class FFONHKKMHFD : GNBGPAGNAII
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct OKOAPMLNCFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<IJMPLGOCAIG<CJHOFKFEOGB>, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public FFONHKKMHFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public JJGAGGDHEOK<ENDAAFIJDLG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public JJGAGGDHEOK<CNEFPEIGAAA> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public IJMPLGOCAIG<KPOOLCGJDAJ> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter<BLNBDNPDEEM<IJMPLGOCAIG<CJHOFKFEOGB>, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD960", Offset = "0x1DACB60", VA = "0x181DAD960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x1DADBE0", Offset = "0x1DACDE0", VA = "0x181DADBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct MKEAIBHANLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<IJMPLGOCAIG<EJMHDNENAPL>, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public FFONHKKMHFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public JJGAGGDHEOK<ENDAAFIJDLG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public JJGAGGDHEOK<CNEFPEIGAAA> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public IJMPLGOCAIG<KPOOLCGJDAJ> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private TaskAwaiter<BLNBDNPDEEM<IJMPLGOCAIG<EJMHDNENAPL>, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD410", Offset = "0x1DAC610", VA = "0x181DAD410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD690", Offset = "0x1DAC890", VA = "0x181DAD690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly BIOGPKOIHNJ GPOGEEFGHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private readonly GODFEFLGLEG PAGIBGGPOPH;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public TypeKey FMIOEGBPJIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x969DC0", Offset = "0x968FC0", VA = "0x180969DC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public string HJODJDPNPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1DA8890", Offset = "0x1DA7A90", VA = "0x181DA8890", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public BIOGPKOIHNJ HMFHMAPNLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7BA3A0", Offset = "0x7B95A0", VA = "0x1807BA3A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8BA0", Offset = "0x1DA7DA0", VA = "0x181DA8BA0")]
	public FFONHKKMHFD(BIOGPKOIHNJ LFFAFMBBEAA, GODFEFLGLEG ADAKDDJLKBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8A30", Offset = "0x1DA7C30", VA = "0x181DA8A30", Slot = "6")]
	[AsyncStateMachine(typeof(OKOAPMLNCFA))]
	public Task<BLNBDNPDEEM<IJMPLGOCAIG<CJHOFKFEOGB>, NGDCAOKOLMO>> LNBKPLMBCDH(JJGAGGDHEOK<ENDAAFIJDLG> JAKGJEDDCHL, JJGAGGDHEOK<CNEFPEIGAAA> CPDCLGDPBBB, IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK, string NLBAJPAADNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x1DA88C0", Offset = "0x1DA7AC0", VA = "0x181DA88C0", Slot = "7")]
	[AsyncStateMachine(typeof(MKEAIBHANLM))]
	public Task<BLNBDNPDEEM<IJMPLGOCAIG<EJMHDNENAPL>, NGDCAOKOLMO>> GFKPIGIEHNP(JJGAGGDHEOK<ENDAAFIJDLG> JAKGJEDDCHL, JJGAGGDHEOK<CNEFPEIGAAA> CPDCLGDPBBB, IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK, string NLBAJPAADNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public sealed class FHIFEBEMLPO : JLMPEGMBPLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly BIOGPKOIHNJ JBGGBHLFPGE;

	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly HashSet<BIOGPKOIHNJ> NLODLMAIHOH;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly HashSet<BIOGPKOIHNJ> LCJNGKCNOFF;

	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private static readonly HashSet<BIOGPKOIHNJ> ANNDLEJEJGF;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public TypeKey OMEPDDHLMOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA0D0", Offset = "0x1DA92D0", VA = "0x181DAA0D0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool BNGGOCLNDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA0C0", Offset = "0x1DA92C0", VA = "0x181DAA0C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool MIHDKBLCOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA120", Offset = "0x1DA9320", VA = "0x181DAA120", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool ELOBEADMLDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA040", Offset = "0x1DA9240", VA = "0x181DAA040", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8DD0", Offset = "0x1DA7FD0", VA = "0x181DA8DD0")]
	public bool CCKELONHMDN(string AFCGKMGKPEF, [Out] GHJBDLIMPCF MCBONHLFNBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	public FHIFEBEMLPO(BIOGPKOIHNJ BFLJLPICFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8C40", Offset = "0x1DA7E40", VA = "0x181DA8C40")]
	internal static TypeKey AJIBLPBIPPG(BIOGPKOIHNJ DMEGHACCPAC)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8890", Offset = "0x1DA7A90", VA = "0x181DA8890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct EJPIOAHLHNG : HBOOKNPCBKB.OFADBMBLIMP<GFABBJEKLJG, PGENBOHGKNI>
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x1DA87D0", Offset = "0x1DA79D0", VA = "0x181DA87D0", Slot = "4")]
	public int JOKALODLPNF(PGENBOHGKNI BBEDKDLIKBI, GFABBJEKLJG CEBHNDLCHED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8740", Offset = "0x1DA7940", VA = "0x181DA8740", Slot = "5")]
	public GFABBJEKLJG DELJDJGAMAJ(PGENBOHGKNI BBEDKDLIKBI, GFABBJEKLJG CEBHNDLCHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8810", Offset = "0x1DA7A10", VA = "0x181DA8810", Slot = "6")]
	public GFABBJEKLJG KOEFONIFEGC(PGENBOHGKNI BBEDKDLIKBI, GFABBJEKLJG CEBHNDLCHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8790", Offset = "0x1DA7990", VA = "0x181DA8790", Slot = "7")]
	public IReadOnlyList<GFABBJEKLJG> HFMJOIOGGAB(PGENBOHGKNI BBEDKDLIKBI, GFABBJEKLJG CEBHNDLCHED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8880", Offset = "0x1DA7A80", VA = "0x181DA8880", Slot = "8")]
	public GFABBJEKLJG[] PKKNOKKLNNF(PGENBOHGKNI BBEDKDLIKBI, GFABBJEKLJG CEBHNDLCHED, int MBAAJBKDENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8750", Offset = "0x1DA7950", VA = "0x181DA8750", Slot = "9")]
	public bool ECIPFGIEPGM(PGENBOHGKNI BBEDKDLIKBI, GFABBJEKLJG CEBHNDLCHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x1DA87F0", Offset = "0x1DA79F0", VA = "0x181DA87F0", Slot = "10")]
	public bool KHPIBMIJJLJ(PGENBOHGKNI BBEDKDLIKBI, GFABBJEKLJG CEBHNDLCHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x1DA87B0", Offset = "0x1DA79B0", VA = "0x181DA87B0", Slot = "11")]
	public bool HLECOAOMNDP(PGENBOHGKNI BBEDKDLIKBI, GFABBJEKLJG CEBHNDLCHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8860", Offset = "0x1DA7A60", VA = "0x181DA8860", Slot = "12")]
	public bool MHIBOJHJMIA(PGENBOHGKNI BBEDKDLIKBI, GFABBJEKLJG CEBHNDLCHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8840", Offset = "0x1DA7A40", VA = "0x181DA8840", Slot = "13")]
	public bool LCCAFPEMDMO(PGENBOHGKNI DLMEIBGFBFB, GFABBJEKLJG CEBHNDLCHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8770", Offset = "0x1DA7970", VA = "0x181DA8770", Slot = "14")]
	public bool EIILNPONNIL(PGENBOHGKNI BBEDKDLIKBI, GFABBJEKLJG CEBHNDLCHED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public abstract class INOFNLFOAPN : JFJMFHHMLJN
{
	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public NNGNCBFENCB.NOALEMLEOMN OOHNOBGEPFG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x1DAAC60", Offset = "0x1DA9E60", VA = "0x181DAAC60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public abstract JKFDEPKPCOO.GGBKPCLHEHB EAIKKEMFHNE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public abstract FNBPJGFILDN.AIODEBHCMHF FINPHKANEFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public abstract GPFAAHLMODN.INMMNOCHLPF NIPOELLPJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public CMJGBBOLMCF.MPBGOOCJJMA<JFONOMFMEKP, GFABBJEKLJG, FNBPJGFILDN> JBMHGFCBPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x1DAACB0", Offset = "0x1DA9EB0", VA = "0x181DAACB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public abstract MHGAHEKEAGE JPEKFOPEJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public abstract PPNPLKCOJDJ MBLKLFNDBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public abstract GNNFEJEGGMM ILDHKNKCHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public abstract CGKODALMLJD HJFDMBEEMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public abstract FKCCMCACDOG LKEKIKJDFND
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
	protected INOFNLFOAPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public sealed class OBKMJIGCCMJ : KABKGLOPGJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct FIMKAFKNLIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public OBKMJIGCCMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public GFABBJEKLJG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private TaskAwaiter<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA240", Offset = "0x1DA9440", VA = "0x181DAA240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA4E0", Offset = "0x1DA96E0", VA = "0x181DAA4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct GJKFHPINLDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public AsyncTaskMethodBuilder<BLNBDNPDEEM<GEFCMJJLDCN, NGDCAOKOLMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public OBKMJIGCCMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public IReadOnlyList<GFABBJEKLJG> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private TaskAwaiter<BLNBDNPDEEM<object, NGDCAOKOLMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA680", Offset = "0x1DA9880", VA = "0x181DAA680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x1DAAA00", Offset = "0x1DA9C00", VA = "0x181DAAA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private readonly OJPAADNIADI NGPDPOEJBED;

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB0", Offset = "0x7C51B0", VA = "0x1807C5FB0")]
	public OBKMJIGCCMJ(OJPAADNIADI LNMNAOOCBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD830", Offset = "0x1DACA30", VA = "0x181DAD830")]
	[AsyncStateMachine(typeof(FIMKAFKNLIG))]
	private Task<BLNBDNPDEEM<object, NGDCAOKOLMO>> KPFPONPDKAN(GFABBJEKLJG CEBHNDLCHED, bool CECOGGPIDAC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD700", Offset = "0x1DAC900", VA = "0x181DAD700", Slot = "4")]
	[AsyncStateMachine(typeof(GJKFHPINLDI))]
	public Task<BLNBDNPDEEM<GEFCMJJLDCN, NGDCAOKOLMO>> GPHLCNCBHGN(IReadOnlyList<GFABBJEKLJG> GEPECELMEGE, bool CECOGGPIDAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct PBGMLLOAOBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	internal FLPFBEBLEAM<CGJBIEAJEAP, GFABBJEKLJG, HLJIEECBHIE> JBGGBHLFPGE;

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x1DA28E0", Offset = "0x1DA1AE0", VA = "0x181DA28E0")]
	private PBGMLLOAOBA([In] FLPFBEBLEAM<CGJBIEAJEAP, GFABBJEKLJG, HLJIEECBHIE> FOHPKCBDIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x1DADC50", Offset = "0x1DACE50", VA = "0x181DADC50")]
	public static PBGMLLOAOBA GOMGEEBODDD()
	{
		return default(PBGMLLOAOBA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class BGDBDLPAGAH
{
	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x87D8F0", Offset = "0x87CAF0", VA = "0x18087D8F0")]
	public static FLPFBEBLEAM<CGJBIEAJEAP, GFABBJEKLJG, HLJIEECBHIE> HJLJOCFPLOL(this PBGMLLOAOBA KPBGCHDNDLM)
	{
		return default(FLPFBEBLEAM<CGJBIEAJEAP, GFABBJEKLJG, HLJIEECBHIE>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct HLJIEECBHIE : PIKGCDFDGJH.LIBDEDBELGC<CGJBIEAJEAP, GFABBJEKLJG>
{
	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x1DAAA70", Offset = "0x1DA9C70", VA = "0x181DAAA70", Slot = "5")]
	public GFABBJEKLJG JDMDMDEAMFC(CGJBIEAJEAP[] AJLCLDLIAKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x13C39A0", Offset = "0x13C2BA0", VA = "0x1813C39A0")]
	public int BPMOHKEBPCE([In] CGJBIEAJEAP CDNNJLDLIEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x13C39A0", Offset = "0x13C2BA0", VA = "0x1813C39A0", Slot = "4")]
	private int MEKANMDPOCI([In] CGJBIEAJEAP FMJAMFMABFO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct DDACHCOMDOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	internal IOGAOHEMBEF<HLKGPMPGGBE, GFABBJEKLJG, LOFFDNLBBJG> JBGGBHLFPGE;

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x1DA28E0", Offset = "0x1DA1AE0", VA = "0x181DA28E0")]
	private DDACHCOMDOC([In] IOGAOHEMBEF<HLKGPMPGGBE, GFABBJEKLJG, LOFFDNLBBJG> GDHBLBOLHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x1DA86E0", Offset = "0x1DA78E0", VA = "0x181DA86E0")]
	public static DDACHCOMDOC GOMGEEBODDD()
	{
		return default(DDACHCOMDOC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class OFCLMPJNIFC
{
	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x87D8F0", Offset = "0x87CAF0", VA = "0x18087D8F0")]
	public static IOGAOHEMBEF<HLKGPMPGGBE, GFABBJEKLJG, LOFFDNLBBJG> HJLJOCFPLOL(this DDACHCOMDOC KPBGCHDNDLM)
	{
		return default(IOGAOHEMBEF<HLKGPMPGGBE, GFABBJEKLJG, LOFFDNLBBJG>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct LOFFDNLBBJG : ADDBHHMMMCO.AFHDNLBNPII<HLKGPMPGGBE, GFABBJEKLJG>
{
	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x13C39A0", Offset = "0x13C2BA0", VA = "0x1813C39A0")]
	public int HKCLPDEINJL([In] HLKGPMPGGBE CDNNJLDLIEI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD220", Offset = "0x1DAC420", VA = "0x181DAD220", Slot = "5")]
	public GFABBJEKLJG DEBJMGHLPAA(HLKGPMPGGBE[] LJIBOAGGPKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x13C39A0", Offset = "0x13C2BA0", VA = "0x1813C39A0", Slot = "4")]
	private int OKNEAJCEFMO([In] HLKGPMPGGBE CDNNJLDLIEI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface MHGAHEKEAGE
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LDKMDNFEMBP([In] BLNBDNPDEEM<PGENBOHGKNI, CHOGLKODFOC> JKJJELABMHK);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class IAOHGBGOFEI
{
	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x27B2F90", Offset = "0x27B2190", VA = "0x1827B2F90")]
	public static bool LDKMDNFEMBP<TOk, TErr>(this MHGAHEKEAGE KPBGCHDNDLM, [In] BLNBDNPDEEM<TOk, TErr> JKJJELABMHK) where TOk : notnull where TErr : notnull, CHOGLKODFOC
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public interface PPNPLKCOJDJ
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	MLLHFJLIPBI PEHNKOIDDHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public interface GNNFEJEGGMM
{
	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CNBKCAOOBLL FNIENJINFGA(int EMBMAPFCOIF);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public interface ABGJMFBOJOJ
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	string IHKMJLPGIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public interface LCIJHKNJDGN
{
	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LEDCECELLAI? EFCEBAPNAIF(IJMPLGOCAIG<KPOOLCGJDAJ> NPHLPLLMGCK);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public interface KPPOLJIEFNJ
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	string IHKMJLPGIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public interface LEDCECELLAI
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	string IHKMJLPGIHG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KPPOLJIEFNJ? CONCBKMPBGP(IJMPLGOCAIG<CJHOFKFEOGB> OCGGOKMCDHH);

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ABGJMFBOJOJ? NHKIGJCDBOE(IJMPLGOCAIG<EJMHDNENAPL> DGCONFGIFIE);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public interface CGKODALMLJD
{
	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> BBHEOIDPKCP(string AFCGKMGKPEF, string HFFDKMJEBIA);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public interface FKCCMCACDOG
{
	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LCIJHKNJDGN? NLKLNPFAEIK([In] JJGAGGDHEOK<ILILDDKGAMF> GAKLOFMOMNB);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public sealed class JCLCKLOFCKI
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct GGDNJIHKEMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public int ANPNOFMCDKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public LNMBGNPCGOG? KICBBBEAFFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public LNMBGNPCGOG? MOAPEPOJEMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public readonly List<GFABBJEKLJG> HADHODENJLB;

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA610", Offset = "0x1DA9810", VA = "0x181DAA610")]
		private GGDNJIHKEMD(int ILNNGHKJMBD, LNMBGNPCGOG? MBIIJAEJBMD, LNMBGNPCGOG? FLNGLDLAHJH, List<GFABBJEKLJG> GEPECELMEGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA550", Offset = "0x1DA9750", VA = "0x181DAA550")]
		public static GGDNJIHKEMD GOMGEEBODDD()
		{
			return default(GGDNJIHKEMD);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly ALOEKPHFBNG<GGDNJIHKEMD> MNENDHNMKND;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public static JCLCKLOFCKI MJANIPKLNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x1DAADC0", Offset = "0x1DA9FC0", VA = "0x181DAADC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool GDLBPKBGNEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x80DD00", Offset = "0x80CF00", VA = "0x18080DD00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x879340", Offset = "0x878540", VA = "0x180879340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x1DAAD00", Offset = "0x1DA9F00", VA = "0x181DAAD00")]
	public void ADMKANHIMAN(FDNAGLPJLED FLNGLDLAHJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x1DAB150", Offset = "0x1DAA350", VA = "0x181DAB150")]
	public void KEKDJDLBNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x1DAAE10", Offset = "0x1DAA010", VA = "0x181DAAE10")]
	private static string? HHDHDNAFJDC([In] GGDNJIHKEMD GJABBJCHFOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x1DAB550", Offset = "0x1DAA750", VA = "0x181DAB550")]
	public JCLCKLOFCKI()
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
