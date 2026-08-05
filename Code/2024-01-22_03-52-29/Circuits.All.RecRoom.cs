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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D0D730", Offset = "0x1D0CB30", VA = "0x181D0D730")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BB450", Offset = "0x7BA850", VA = "0x1807BB450")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BB490", Offset = "0x7BA890", VA = "0x1807BB490")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class DALDCDFKDNN : IDisposable, DENLLHMJOHH, COJGMIBOKKM, FIPNPMPLLBC, COKFLADBODP
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class IOMOHNGFDAL : FNGPFKGFIIB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int BCKHBMKBLHM
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1D06AB0", Offset = "0x1D05EB0", VA = "0x181D06AB0", Slot = "5")]
		public NLMBDCAJNIL EJBPDNLCEGK(PHHIANHDIJE.HADEEJMGIOL BFMHNHDBGGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void FHEDCNGGFKF();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void PKDOILKJNDK();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void GEIBFFKCMKJ();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		protected IOMOHNGFDAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface FNGPFKGFIIB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int BCKHBMKBLHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		NLMBDCAJNIL EJBPDNLCEGK(PHHIANHDIJE.HADEEJMGIOL BFMHNHDBGGN);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void FHEDCNGGFKF();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PKDOILKJNDK();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GEIBFFKCMKJ();
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct GACGIOIFAJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly AGDGPALHBLG<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN, GHNFMAMPACM.KOONEAABNAH<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN>> AFMAIMAFNHJ;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1D042B0", Offset = "0x1D036B0", VA = "0x181D042B0")]
		internal GACGIOIFAJG(AGDGPALHBLG<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN, GHNFMAMPACM.KOONEAABNAH<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN>> ABLKMCPEJAG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class GMDNFBCLNGN : GHNFMAMPACM.KOONEAABNAH<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly GMDNFBCLNGN OKALMGBNAPE;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		private GMDNFBCLNGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA100D0", Offset = "0xA0F4D0", VA = "0x180A100D0", Slot = "4")]
		public MKGDFCJGGMN OEOBLLBCLNC(PEIMDLKNNKH LHCHBOKBAPK)
		{
			return default(MKGDFCJGGMN);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		public void BLCJABPEKOE(DALDCDFKDNN MMKDJDGOBEM, PEIMDLKNNKH EEEBGEOHFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1D052A0", Offset = "0x1D046A0", VA = "0x181D052A0", Slot = "6")]
		public void IAEEHKPNGMD(DALDCDFKDNN MMKDJDGOBEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct DCKKIBNNAEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public GDNIGEHJANO<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN, GHNFMAMPACM.KOONEAABNAH<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN>> AFMAIMAFNHJ;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1CFFF80", Offset = "0x1CFF380", VA = "0x181CFFF80")]
		internal DCKKIBNNAEG(GDNIGEHJANO<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN, GHNFMAMPACM.KOONEAABNAH<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN>> ABLKMCPEJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1CFFF30", Offset = "0x1CFF330", VA = "0x181CFFF30")]
		public static DCKKIBNNAEG PIJMMFMEPKL()
		{
			return default(DCKKIBNNAEG);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct EOGEOAFLMKJ : DLPCGGHNGEA.AIFKLHHOEOP<FEKBKHFKGMJ, PEIMDLKNNKH, DALDCDFKDNN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct BPCEJDMCLHM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<EGECKPFNJNE<object, APEAMGBOOBA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public DALDCDFKDNN receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public PEIMDLKNNKH action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public EOGEOAFLMKJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<EGECKPFNJNE<object, APEAMGBOOBA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x1CFB250", Offset = "0x1CFA650", VA = "0x181CFB250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x1CFB430", Offset = "0x1CFA830", VA = "0x181CFB430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA100D0", Offset = "0xA0F4D0", VA = "0x180A100D0", Slot = "4")]
		public AFJMJHOPNGM<FEKBKHFKGMJ> FIDOELKJCAI(DALDCDFKDNN PBGFHGDDDAM)
		{
			return default(AFJMJHOPNGM<FEKBKHFKGMJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1D02780", Offset = "0x1D01B80", VA = "0x181D02780", Slot = "5")]
		[AsyncStateMachine(typeof(BPCEJDMCLHM))]
		public Task<EGECKPFNJNE<object, APEAMGBOOBA>> BFPDLBPHOHP(DALDCDFKDNN PBGFHGDDDAM, PEIMDLKNNKH EEEBGEOHFMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1D028B0", Offset = "0x1D01CB0", VA = "0x181D028B0", Slot = "6")]
		public PEIMDLKNNKH[] HDOJFEJNAEL(DALDCDFKDNN PBGFHGDDDAM)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct ILGNNHPKBPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<bool, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public DALDCDFKDNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public LDEMMCHMOMH rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public MFODOKIIMIC circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public IKAOCNCDDAM superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<EGECKPFNJNE<bool, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1D06540", Offset = "0x1D05940", VA = "0x181D06540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1D067C0", Offset = "0x1D05BC0", VA = "0x181D067C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct DAKDIMBIBON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<bool, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public DALDCDFKDNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<EGECKPFNJNE<bool, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1CFE390", Offset = "0x1CFD790", VA = "0x181CFE390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1CFE620", Offset = "0x1CFDA20", VA = "0x181CFE620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct JCAJLNJPAPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public DALDCDFKDNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1D06C00", Offset = "0x1D06000", VA = "0x181D06C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1D06DE0", Offset = "0x1D061E0", VA = "0x181D06DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct KFKBMPLBHKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<object, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public DALDCDFKDNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public PEIMDLKNNKH action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<EGECKPFNJNE<object, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1D07810", Offset = "0x1D06C10", VA = "0x181D07810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1D07A00", Offset = "0x1D06E00", VA = "0x181D07A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct DLGMKMCBCKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public DALDCDFKDNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<EGECKPFNJNE<bool, APEAMGBOOBA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1D01B80", Offset = "0x1D00F80", VA = "0x181D01B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1D02370", Offset = "0x1D01770", VA = "0x181D02370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly AFJMJHOPNGM<FEKBKHFKGMJ> MDOOJGOMABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly GACGIOIFAJG MKGKEMAFOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LHLJPLIEKNL EAJMAAEEABJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly LAFOOICCOAB NDFFCHDHKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF70")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly ANAKFIJHLMO CCOLBCGLJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF78")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly JKBOJOHMMDN.KJKBAKJAAHN NCHNOIOHNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF98")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly JFMJMDAKKDF MMDNGMPKOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFA0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly BNAEKOBLNEJ FJNCFPKDMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFA8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly BJMKNCGKMCD PGOHEOKGJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFB0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly HLBAGBKDHGF DNHKJGFLNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFB8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private LGIAPJGPHBH PNDJEDAGNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private FLPMBNFFCAO ONKDMOFOELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFE8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly LHLJPLIEKNL.JGMCEMBEMBM ELONEKNCBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly MFJEHKEAJKF GLHAGMCAAAM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public LHLJPLIEKNL PPNMMLAIGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1CFEBE0", Offset = "0x1CFDFE0", VA = "0x181CFEBE0")]
		get
		{
			return default(LHLJPLIEKNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal FNGPFKGFIIB AIALHLLPLBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1CFEBF0", Offset = "0x1CFDFF0", VA = "0x181CFEBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal NLMBDCAJNIL IHHDPFAGNIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1CFEBD0", Offset = "0x1CFDFD0", VA = "0x181CFEBD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1CFE690", Offset = "0x1CFDA90", VA = "0x181CFE690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool BPHBODJMHJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1CFE6B0", Offset = "0x1CFDAB0", VA = "0x181CFE6B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1CFED70", Offset = "0x1CFE170", VA = "0x181CFED70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LNKIIJKONKL MDEJHCAIMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1CFFEF0", Offset = "0x1CFF2F0", VA = "0x181CFFEF0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FEOJABBBJPG LHGHBHCPNMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1CFFF10", Offset = "0x1CFF310", VA = "0x181CFFF10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public MMJEHLPEICI ANPPBLHMLOO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1CFFF20", Offset = "0x1CFF320", VA = "0x181CFFF20", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NJOJJKGJIPM MCDECEIJFCF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1CFFF00", Offset = "0x1CFF300", VA = "0x181CFFF00", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private CCMKADLHPFC? FMBKEEBDOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1CFEC40", Offset = "0x1CFE040", VA = "0x181CFEC40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private DAILKDGHDEE? IMOFMHCJCIA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1CFF320", Offset = "0x1CFE720", VA = "0x181CFF320", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1CFFBD0", Offset = "0x1CFEFD0", VA = "0x181CFFBD0")]
	private DALDCDFKDNN(ANAKFIJHLMO FFGIGBONMNG, AFJMJHOPNGM<FEKBKHFKGMJ> JAPMLPNPKOP, [In] GACGIOIFAJG FLJIKOOOPPI, [In] LHLJPLIEKNL NGECGGJBLCG, [In] LAFOOICCOAB MKADPLFMNHJ, NLMBDCAJNIL IBDBEGKEKGD, [In] JKBOJOHMMDN.KJKBAKJAAHN APMMFAFHHJG, LHLJPLIEKNL.JGMCEMBEMBM HOMFCNGOHHL, MFJEHKEAJKF OKDLBBHFBNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1CFF810", Offset = "0x1CFEC10", VA = "0x181CFF810")]
	public static DALDCDFKDNN PIJMMFMEPKL(ANAKFIJHLMO BFMHNHDBGGN, LHLJPLIEKNL.ILPMEAAFKPM JFLOHJEMFBB, AFJMJHOPNGM<FEKBKHFKGMJ> JAPMLPNPKOP, AFJMJHOPNGM<CEADKNMGGJP> DAENGJKPDIF, HDDIFOJAPMO LCCNCJEPEIK, GDAFFMKHFIF HPOLPFNJPHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1CFF8F0", Offset = "0x1CFECF0", VA = "0x181CFF8F0")]
	public static DALDCDFKDNN PIJMMFMEPKL(ANAKFIJHLMO FFGIGBONMNG, [In] LHLJPLIEKNL NGECGGJBLCG, [In] LAFOOICCOAB MKADPLFMNHJ, AFJMJHOPNGM<FEKBKHFKGMJ> JAPMLPNPKOP, AFJMJHOPNGM<CEADKNMGGJP> DAENGJKPDIF, HDDIFOJAPMO LCCNCJEPEIK, GDAFFMKHFIF HPOLPFNJPHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1CFE8D0", Offset = "0x1CFDCD0", VA = "0x181CFE8D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1CFF630", Offset = "0x1CFEA30", VA = "0x181CFF630")]
	[AsyncStateMachine(typeof(ILGNNHPKBPD))]
	internal Task<EGECKPFNJNE<bool, APEAMGBOOBA>> NAGOMIBMPFF(LDEMMCHMOMH FKJEHNNJPKB, MFODOKIIMIC PKLBHCBBHOK, IKAOCNCDDAM OMKFEFIGPOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1CFF540", Offset = "0x1CFE940", VA = "0x181CFF540")]
	[AsyncStateMachine(typeof(DAKDIMBIBON))]
	public Task<EGECKPFNJNE<bool, APEAMGBOOBA>> MPJOLJGPHKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1CFF450", Offset = "0x1CFE850", VA = "0x181CFF450")]
	[AsyncStateMachine(typeof(JCAJLNJPAPA))]
	public Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> MPDIEHGDDJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1CFE6C0", Offset = "0x1CFDAC0", VA = "0x181CFE6C0")]
	internal void DMFHFGCHNAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1CFF790", Offset = "0x1CFEB90", VA = "0x181CFF790")]
	internal NMGFKHEHGDM<PEIMDLKNNKH> OKBKHADCCBE([In] HJPBJPNCHAD BHDOGMHIBAP)
	{
		return default(NMGFKHEHGDM<PEIMDLKNNKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1CFF2B0", Offset = "0x1CFE6B0", VA = "0x181CFF2B0")]
	internal bool JJKDLCFNMNH([In] HJPBJPNCHAD BHDOGMHIBAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1CFF230", Offset = "0x1CFE630", VA = "0x181CFF230")]
	internal NMGFKHEHGDM<PEIMDLKNNKH> IMDECJKEAON([In] KMGFKFEFILG IFBHPKODIPI)
	{
		return default(NMGFKHEHGDM<PEIMDLKNNKH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1CFEAC0", Offset = "0x1CFDEC0", VA = "0x181CFEAC0")]
	[AsyncStateMachine(typeof(KFKBMPLBHKK))]
	internal Task<EGECKPFNJNE<object, APEAMGBOOBA>> ENOHCMHNDIJ(PEIMDLKNNKH EEEBGEOHFMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1CFEEA0", Offset = "0x1CFE2A0", VA = "0x181CFEEA0")]
	private PEIMDLKNNKH[] HDOJFEJNAEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1CFED80", Offset = "0x1CFE180", VA = "0x181CFED80")]
	[AsyncStateMachine(typeof(DLGMKMCBCKG))]
	public Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> HDLPBEKPKMN(Guid EJDMMIAHLJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class KEBCLPFBNBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x269F4D0", Offset = "0x269E8D0", VA = "0x18269F4D0")]
	public static IKKMJLOBNNA<(TPrev?, DALDCDFKDNN?), DAILKDGHDEE> DNMBCCAGGML<TPrev>([In] this IKKMJLOBNNA<TPrev, DALDCDFKDNN> LHCHBOKBAPK)
	{
		return default(IKKMJLOBNNA<(TPrev, DALDCDFKDNN), DAILKDGHDEE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x269F2B0", Offset = "0x269E6B0", VA = "0x18269F2B0")]
	public static IKKMJLOBNNA<TPrev?, DALDCDFKDNN?> BBIMIGGKLJN<TPrev>([In] this IKKMJLOBNNA<TPrev, DALDCDFKDNN> LHCHBOKBAPK)
	{
		return default(IKKMJLOBNNA<TPrev, DALDCDFKDNN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class NBBBGMEOLLB<TData> : JIBPJLBDKCG, DKBHNOKKPAO, IGBINOOJKPE where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly OIFGKAAGFMP<FJBFPEKHLHL>? DLBMHKILBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string ICOADANDNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData LGDPHHJAFJI;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public OIFGKAAGFMP<FJBFPEKHLHL>? ALKCGHOBLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1E75900", Offset = "0x1E74D00", VA = "0x181E75900", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x793E80", Offset = "0x793280", VA = "0x180793E80", Slot = "7")]
	public override string GPDEFFKCMGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3E6FE30", Offset = "0x3E6F230", VA = "0x183E6FE30")]
	internal NBBBGMEOLLB([In] OIFGKAAGFMP<FJBFPEKHLHL>? NADCCAFLHPD, AFJMJHOPNGM<BCCHBDDNGGN>? JLKBNIIIJMJ, IOKind? CHELPDNOEMI, string AGOKDCAFCLN, [In] TData GMLIPIALCHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class LHCNEIILBJD
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1D08E80", Offset = "0x1D08280", VA = "0x181D08E80")]
	public static EGECKPFNJNE<COGAEBBGMHD, DKBHNOKKPAO> OBLMGFONJEI([In] this HHNFPIBAJMA<CHJGKAKGIIC> LEPKCOOADEO)
	{
		return default(EGECKPFNJNE<COGAEBBGMHD, DKBHNOKKPAO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x26AF310", Offset = "0x26AE710", VA = "0x1826AF310")]
	public static EGECKPFNJNE<TOk, DKBHNOKKPAO> MMFBCILIAHM<TOk>([In] this EGECKPFNJNE<TOk, DKBHNOKKPAO> LHCHBOKBAPK, [In] OIFGKAAGFMP<FJBFPEKHLHL>? NADCCAFLHPD, AFJMJHOPNGM<BCCHBDDNGGN>? JLKBNIIIJMJ, IOKind? CHELPDNOEMI, string AGOKDCAFCLN) where TOk : notnull
	{
		return default(EGECKPFNJNE<TOk, DKBHNOKKPAO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface ANAKFIJHLMO
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	JOEKCOJDIOG.CAPBICKDAIL GBHFJIBDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	PHHIANHDIJE.HADEEJMGIOL KCIIDDBDOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	DALDCDFKDNN.FNGPFKGFIIB JIFHBCDJHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	EFNHNHHDLMK.OEPCIILNFKD CKMKPGBBGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	GHNFMAMPACM.KOONEAABNAH<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN> DNLCPNKJHJI
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	LEGBEOMAGOJ EGJFHKAJEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IOGOMBHCNGB JMBGOJJIGJH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	BJBPCCCAHCK KKPJGLELEBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	FBPLGJIHNJL EOMAHCFKECO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	AGLFJDOBGND PKOFDGKMNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class HLIGDMGACJO
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1D06040", Offset = "0x1D05440", VA = "0x181D06040")]
	public static PEIMDLKNNKH JFLKKLABKAI(this PEIMDLKNNKH LHCHBOKBAPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1D06150", Offset = "0x1D05550", VA = "0x181D06150")]
	public static PEIMDLKNNKH LJIHDHBHMHP(this IOEKBIGAHFD LHCHBOKBAPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct IOEKBIGAHFD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct AFEKIKBOHLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<object, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public DALDCDFKDNN root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public IOEKBIGAHFD self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<EGECKPFNJNE<object, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1CF3220", Offset = "0x1CF2620", VA = "0x181CF3220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1CF34E0", Offset = "0x1CF28E0", VA = "0x181CF34E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString BFBAIKCHJBC;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA20", Offset = "0x8BBE20", VA = "0x1808BCA20")]
	private IOEKBIGAHFD(ByteString PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D06830", Offset = "0x1D05C30", VA = "0x181D06830")]
	public static PEIMDLKNNKH EKCGLNNPPIG(ByteString PAHKKNONPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1D06A00", Offset = "0x1D05E00", VA = "0x181D06A00")]
	public static LCIMBLMCMNC<MKGDFCJGGMN, IOEKBIGAHFD> KFJHJJBKFOB(PEIMDLKNNKH DNHKFKINIDJ)
	{
		return default(LCIMBLMCMNC<MKGDFCJGGMN, IOEKBIGAHFD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1D068F0", Offset = "0x1D05CF0", VA = "0x181D068F0")]
	[AsyncStateMachine(typeof(AFEKIKBOHLB))]
	public static Task<EGECKPFNJNE<object, APEAMGBOOBA>> ENOHCMHNDIJ(DALDCDFKDNN MMKDJDGOBEM, IOEKBIGAHFD LHCHBOKBAPK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct KIGAJLFBDDN
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1D07AF0", Offset = "0x1D06EF0", VA = "0x181D07AF0")]
	public static PEIMDLKNNKH EKCGLNNPPIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1D07B90", Offset = "0x1D06F90", VA = "0x181D07B90")]
	public static LCIMBLMCMNC<MKGDFCJGGMN, KIGAJLFBDDN> KFJHJJBKFOB(PEIMDLKNNKH DNHKFKINIDJ)
	{
		return default(LCIMBLMCMNC<MKGDFCJGGMN, KIGAJLFBDDN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1D07A70", Offset = "0x1D06E70", VA = "0x181D07A70")]
	public static EGECKPFNJNE<JDDDAABNCFI, GOLJEOBBMJE> DPKPFNOLLKN(DALDCDFKDNN MMKDJDGOBEM, [In] KIGAJLFBDDN LHCHBOKBAPK)
	{
		return default(EGECKPFNJNE<JDDDAABNCFI, GOLJEOBBMJE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct NEPIDAAEMBD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct NOOEGFKBINL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, GOLJEOBBMJE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public DALDCDFKDNN root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NEPIDAAEMBD self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private EGECKPFNJNE<JDDDAABNCFI, GOLJEOBBMJE> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1D0D050", Offset = "0x1D0C450", VA = "0x181D0D050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1D0D3C0", Offset = "0x1D0C7C0", VA = "0x181D0D3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly LDEMMCHMOMH? AKJEAKDCCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly MFODOKIIMIC? AJODIBLKEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly IKAOCNCDDAM? FFPIPLJPECL;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1A0F540", Offset = "0x1A0E940", VA = "0x181A0F540")]
	private NEPIDAAEMBD(LDEMMCHMOMH? FKJEHNNJPKB, MFODOKIIMIC? PKLBHCBBHOK, IKAOCNCDDAM? OMKFEFIGPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1D0C8A0", Offset = "0x1D0BCA0", VA = "0x181D0C8A0")]
	public static PEIMDLKNNKH? EKCGLNNPPIG(LDEMMCHMOMH? FKJEHNNJPKB, MFODOKIIMIC? PKLBHCBBHOK, IKAOCNCDDAM? OMKFEFIGPOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1D0CAE0", Offset = "0x1D0BEE0", VA = "0x181D0CAE0")]
	public static LCIMBLMCMNC<MKGDFCJGGMN, NEPIDAAEMBD> KFJHJJBKFOB(PEIMDLKNNKH DNHKFKINIDJ)
	{
		return default(LCIMBLMCMNC<MKGDFCJGGMN, NEPIDAAEMBD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1D0C9A0", Offset = "0x1D0BDA0", VA = "0x181D0C9A0")]
	[AsyncStateMachine(typeof(NOOEGFKBINL))]
	public static Task<EGECKPFNJNE<JDDDAABNCFI, GOLJEOBBMJE>> ENOHCMHNDIJ(DALDCDFKDNN MMKDJDGOBEM, NEPIDAAEMBD LHCHBOKBAPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct PDFDGEAKBHN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct BMJLIPGNCDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<BGOBFOFGNEB, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public PDFDGEAKBHN self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public DALDCDFKDNN root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private EGECKPFNJNE<BGOBFOFGNEB, APEAMGBOOBA> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private EGECKPFNJNE<object, IGBINOOJKPE>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private EGECKPFNJNE<object, IGBINOOJKPE> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private EGECKPFNJNE<object, IGBINOOJKPE>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<EGECKPFNJNE<object, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1CFACB0", Offset = "0x1CFA0B0", VA = "0x181CFACB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x1CFB120", Offset = "0x1CFA520", VA = "0x181CFB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<PEIMDLKNNKH> BABBNBICAPG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA20", Offset = "0x8BBE20", VA = "0x1808BCA20")]
	private PDFDGEAKBHN(IReadOnlyList<PEIMDLKNNKH> HDLHNKOGPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E2B0", Offset = "0x1D0D6B0", VA = "0x181D0E2B0")]
	public static PEIMDLKNNKH EKCGLNNPPIG(IReadOnlyList<PEIMDLKNNKH> HDLHNKOGPHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E4B0", Offset = "0x1D0D8B0", VA = "0x181D0E4B0")]
	public static LCIMBLMCMNC<MKGDFCJGGMN, PDFDGEAKBHN> KFJHJJBKFOB(PEIMDLKNNKH DNHKFKINIDJ)
	{
		return default(LCIMBLMCMNC<MKGDFCJGGMN, PDFDGEAKBHN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E370", Offset = "0x1D0D770", VA = "0x181D0E370")]
	[AsyncStateMachine(typeof(BMJLIPGNCDH))]
	public static Task<EGECKPFNJNE<BGOBFOFGNEB, APEAMGBOOBA>> ENOHCMHNDIJ(DALDCDFKDNN MMKDJDGOBEM, PDFDGEAKBHN LHCHBOKBAPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct KMGFKFEFILG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int IGPGGFCOPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int GOBEDCIKOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] LGDPHHJAFJI;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x17A3F70", Offset = "0x17A3370", VA = "0x1817A3F70")]
	private KMGFKFEFILG(int GNHCGOJHAJG, int FGBBDGJMFEH, byte[] GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1D07D20", Offset = "0x1D07120", VA = "0x181D07D20")]
	public static PEIMDLKNNKH EKCGLNNPPIG(int GNHCGOJHAJG, int FGBBDGJMFEH, ByteString GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1D07EE0", Offset = "0x1D072E0", VA = "0x181D07EE0")]
	public static PEIMDLKNNKH[] PHHIPFMOKPP(PEIMDLKNNKH EEEBGEOHFMI, int BGOJIMCDPJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1D07E00", Offset = "0x1D07200", VA = "0x181D07E00")]
	public static LCIMBLMCMNC<MKGDFCJGGMN, KMGFKFEFILG> KFJHJJBKFOB(PEIMDLKNNKH DNHKFKINIDJ)
	{
		return default(LCIMBLMCMNC<MKGDFCJGGMN, KMGFKFEFILG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1D07C00", Offset = "0x1D07000", VA = "0x181D07C00")]
	public static EGECKPFNJNE<PEIMDLKNNKH, GOLJEOBBMJE> DPKPFNOLLKN(DALDCDFKDNN MMKDJDGOBEM, [In] KMGFKFEFILG LHCHBOKBAPK)
	{
		return default(EGECKPFNJNE<PEIMDLKNNKH, GOLJEOBBMJE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct HJPBJPNCHAD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct GJAACFKDFND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<bool, GOLJEOBBMJE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public DALDCDFKDNN root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public HJPBJPNCHAD self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private EGECKPFNJNE<bool, GOLJEOBBMJE> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, GOLJEOBBMJE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1D04BF0", Offset = "0x1D03FF0", VA = "0x181D04BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1D05230", Offset = "0x1D04630", VA = "0x181D05230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int IGPGGFCOPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int GOBEDCIKOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] LGDPHHJAFJI;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x17A3F70", Offset = "0x17A3370", VA = "0x1817A3F70")]
	private HJPBJPNCHAD(int GNHCGOJHAJG, int FGBBDGJMFEH, byte[] GMLIPIALCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1D05950", Offset = "0x1D04D50", VA = "0x181D05950")]
	public static PEIMDLKNNKH EKCGLNNPPIG(int GNHCGOJHAJG, int FGBBDGJMFEH, ByteString GMLIPIALCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x1D05C40", Offset = "0x1D05040", VA = "0x181D05C40")]
	public static PEIMDLKNNKH?[]? LDODHNDNKAM(int BGOJIMCDPJG, LDEMMCHMOMH? FKJEHNNJPKB, MFODOKIIMIC? PKLBHCBBHOK, IKAOCNCDDAM? OMKFEFIGPOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1D05B60", Offset = "0x1D04F60", VA = "0x181D05B60")]
	public static LCIMBLMCMNC<MKGDFCJGGMN, HJPBJPNCHAD> KFJHJJBKFOB(PEIMDLKNNKH DNHKFKINIDJ)
	{
		return default(LCIMBLMCMNC<MKGDFCJGGMN, HJPBJPNCHAD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1D05A30", Offset = "0x1D04E30", VA = "0x181D05A30")]
	[AsyncStateMachine(typeof(GJAACFKDFND))]
	public static Task<EGECKPFNJNE<bool, GOLJEOBBMJE>> ENOHCMHNDIJ(DALDCDFKDNN MMKDJDGOBEM, HJPBJPNCHAD LHCHBOKBAPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class JFMJMDAKKDF : LNKIIJKONKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly DALDCDFKDNN KDPEGNEFKDO;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AFHNPDIFAPP? OKALMGBNAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1D07040", Offset = "0x1D06440", VA = "0x181D07040", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	internal JFMJMDAKKDF(DALDCDFKDNN MOBBAFLLKOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class HENHOMDKABN : AFHNPDIFAPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly DALDCDFKDNN KDPEGNEFKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly NGINKNDGHIG NDFALOLJEGL;

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7999C0", Offset = "0x798DC0", VA = "0x1807999C0")]
	public HENHOMDKABN(DALDCDFKDNN MOBBAFLLKOI, NGINKNDGHIG PEBABINGPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1D05680", Offset = "0x1D04A80", VA = "0x181D05680", Slot = "4")]
	public EGECKPFNJNE<COGAEBBGMHD, DKBHNOKKPAO> EAABFMMGFND(OIFGKAAGFMP<FJBFPEKHLHL> CEPBGHOOFFL, AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK, AFJMJHOPNGM<OHLBKLDAFGN> OFNFNBNPADI)
	{
		return default(EGECKPFNJNE<COGAEBBGMHD, DKBHNOKKPAO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1D053B0", Offset = "0x1D047B0", VA = "0x181D053B0", Slot = "5")]
	public EGECKPFNJNE<COGAEBBGMHD, DKBHNOKKPAO> BBNNDLNKDJH(OIFGKAAGFMP<FJBFPEKHLHL> CEPBGHOOFFL, AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK, AFJMJHOPNGM<MNKAKLAHHBM> MMEEKIELCPF)
	{
		return default(EGECKPFNJNE<COGAEBBGMHD, DKBHNOKKPAO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class JOEKCOJDIOG : JKHINAONMHD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface CAPBICKDAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<NGINKNDGHIG> HDMGNLPAGKI(DALDCDFKDNN MOBBAFLLKOI, MFODOKIIMIC? LCHKIMPFMFD, IKAOCNCDDAM? LPHAKLKNHJF, CancellationToken HHHPDCGPCML);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ELJGELLHKOJ KGCMBGAAKDP(DALDCDFKDNN MOBBAFLLKOI, LDEMMCHMOMH ONOOEHGMGOH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class IEDGEADIMHI : CAPBICKDAIL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct KEGPNBCJIMI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public AsyncTaskMethodBuilder<NGINKNDGHIG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public DALDCDFKDNN circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public MFODOKIIMIC cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public IKAOCNCDDAM cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private TaskAwaiter<EFNHNHHDLMK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x1D07470", Offset = "0x1D06870", VA = "0x181D07470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x1D077A0", Offset = "0x1D06BA0", VA = "0x181D077A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly IEDGEADIMHI OKALMGBNAPE;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		private IEDGEADIMHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1D062E0", Offset = "0x1D056E0", VA = "0x181D062E0", Slot = "4")]
		[AsyncStateMachine(typeof(KEGPNBCJIMI))]
		public Task<NGINKNDGHIG> HDMGNLPAGKI(DALDCDFKDNN MOBBAFLLKOI, MFODOKIIMIC? LCHKIMPFMFD, IKAOCNCDDAM? LPHAKLKNHJF, CancellationToken HHHPDCGPCML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x1D06440", Offset = "0x1D05840", VA = "0x181D06440", Slot = "5")]
		public ELJGELLHKOJ KGCMBGAAKDP(DALDCDFKDNN MOBBAFLLKOI, LDEMMCHMOMH ONOOEHGMGOH)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct AGJNPBIBDMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<JOEKCOJDIOG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public DALDCDFKDNN circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public MFODOKIIMIC cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public IKAOCNCDDAM cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public LDEMMCHMOMH evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private CAPBICKDAIL <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<NGINKNDGHIG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1CF3550", Offset = "0x1CF2950", VA = "0x181CF3550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1CF3AB0", Offset = "0x1CF2EB0", VA = "0x181CF3AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly NGINKNDGHIG NDFALOLJEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly ELJGELLHKOJ FFPOMGBCJPF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public CCMKADLHPFC BLHDFLICNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1D07320", Offset = "0x1D06720", VA = "0x181D07320", Slot = "4")]
		get
		{
			return default(CCMKADLHPFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public DAILKDGHDEE JIDIEELLPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1D07380", Offset = "0x1D06780", VA = "0x181D07380", Slot = "5")]
		get
		{
			return default(DAILKDGHDEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public HENHOMDKABN BCMPANDIGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MKDKNKLFJPF EBJIDIIMLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7940D0", Offset = "0x7934D0", VA = "0x1807940D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public MDIEALGKACB NBOHNPCDDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x793FD0", Offset = "0x7933D0", VA = "0x180793FD0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1D073E0", Offset = "0x1D067E0", VA = "0x181D073E0")]
	private JOEKCOJDIOG(NGINKNDGHIG PEBABINGPIA, ELJGELLHKOJ DCEAJGHOLFJ, HENHOMDKABN KNLCOIGJKCD, MKDKNKLFJPF PFCIOPNADEA, MDIEALGKACB NDOPJBJIECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D07150", Offset = "0x1D06550", VA = "0x181D07150")]
	[AsyncStateMachine(typeof(AGJNPBIBDMM))]
	public static Task<JOEKCOJDIOG> AIPKKCDPFED(DALDCDFKDNN MOBBAFLLKOI, LDEMMCHMOMH ONOOEHGMGOH, MFODOKIIMIC? LCHKIMPFMFD, IKAOCNCDDAM? LPHAKLKNHJF, CancellationToken HHHPDCGPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D072C0", Offset = "0x1D066C0", VA = "0x181D072C0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class PHHIANHDIJE : NLMBDCAJNIL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface HADEEJMGIOL
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<JKHINAONMHD> FJHBBDAMMNN(DALDCDFKDNN MOBBAFLLKOI, LDEMMCHMOMH ONOOEHGMGOH, MFODOKIIMIC? LCHKIMPFMFD, IKAOCNCDDAM? LPHAKLKNHJF, CancellationToken HHHPDCGPCML);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PJKKALANIKO();

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ADJIPJDEMLP();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class EEGIJDOOAPL : HADEEJMGIOL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct ANKHAIEECBA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AsyncTaskMethodBuilder<JKHINAONMHD> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public DALDCDFKDNN circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public LDEMMCHMOMH evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public MFODOKIIMIC cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public IKAOCNCDDAM cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<JOEKCOJDIOG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x1CF3B20", Offset = "0x1CF2F20", VA = "0x181CF3B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x1CF3E60", Offset = "0x1CF3260", VA = "0x181CF3E60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1D024A0", Offset = "0x1D018A0", VA = "0x181D024A0", Slot = "4")]
		[AsyncStateMachine(typeof(ANKHAIEECBA))]
		public Task<JKHINAONMHD> FJHBBDAMMNN(DALDCDFKDNN MOBBAFLLKOI, LDEMMCHMOMH ONOOEHGMGOH, MFODOKIIMIC? LCHKIMPFMFD, IKAOCNCDDAM? LPHAKLKNHJF, CancellationToken HHHPDCGPCML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void PJKKALANIKO();

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void ADJIPJDEMLP();

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		protected EEGIJDOOAPL()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct LFHCBKBHAPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<JKHINAONMHD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public PHHIANHDIJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter<JDDDAABNCFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1D08850", Offset = "0x1D07C50", VA = "0x181D08850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x1D08A50", Offset = "0x1D07E50", VA = "0x181D08A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct DGKGJDNCEOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public PHHIANHDIJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public DALDCDFKDNN circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public LDEMMCHMOMH evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public MFODOKIIMIC cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public IKAOCNCDDAM cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<JKHINAONMHD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1D00880", Offset = "0x1CFFC80", VA = "0x181D00880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1D00DB0", Offset = "0x1D001B0", VA = "0x181D00DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly HADEEJMGIOL BCBDJODLAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<JDDDAABNCFI> HPOKPDCPJMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<JDDDAABNCFI> LJBJPJICNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly CancellationTokenSource LANLGLJICMO;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool BPHBODJMHJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7E49A0", Offset = "0x7E3DA0", VA = "0x1807E49A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7E4980", Offset = "0x7E3D80", VA = "0x1807E4980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KJBEDCLLEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8C5140", Offset = "0x8C4540", VA = "0x1808C5140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8C5150", Offset = "0x8C4550", VA = "0x1808C5150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool GMPDAAFHDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xE9B040", Offset = "0xE9A440", VA = "0x180E9B040")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1D0EA60", Offset = "0x1D0DE60", VA = "0x181D0EA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public JKHINAONMHD? EPLAGCEOCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x793ED0", Offset = "0x7932D0", VA = "0x180793ED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7940F0", Offset = "0x7934F0", VA = "0x1807940F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E800", Offset = "0x1D0DC00", VA = "0x181D0E800", Slot = "7")]
	[AsyncStateMachine(typeof(LFHCBKBHAPA))]
	public Task<JKHINAONMHD> COIEJNDMFEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1D0EA70", Offset = "0x1D0DE70", VA = "0x181D0EA70")]
	public PHHIANHDIJE(HADEEJMGIOL BFMHNHDBGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E6A0", Offset = "0x1D0DAA0", VA = "0x181D0E6A0", Slot = "8")]
	[AsyncStateMachine(typeof(DGKGJDNCEOB))]
	public Task ACBGHIPAKNC(DALDCDFKDNN MOBBAFLLKOI, LDEMMCHMOMH ONOOEHGMGOH, MFODOKIIMIC? LCHKIMPFMFD, IKAOCNCDDAM? LPHAKLKNHJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1D0E8F0", Offset = "0x1D0DCF0", VA = "0x181D0E8F0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class KOJHJHLNCON : ECBCLGMNNDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly MKDKNKLFJPF BCLIBNMJDIN;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	public KOJHJHLNCON(MKDKNKLFJPF PFCIOPNADEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class FGEAILGFPHK
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class PJDHHCOFEMO<TGraph> : NCFEJMLBHNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		protected readonly TGraph PPNEIDGHBEP;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual DBKOCFHHLHN? BHOKGEDMOJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xD0AAD0", Offset = "0xD09ED0", VA = "0x180D0AAD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
		public PJDHHCOFEMO(TGraph GEBIGMANBLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class HKOIGHFEGFF : PJDHHCOFEMO<LBADGLFHLDB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override DBKOCFHHLHN? BHOKGEDMOJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x1D05E40", Offset = "0x1D05240", VA = "0x181D05E40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1D05E60", Offset = "0x1D05260", VA = "0x181D05E60")]
		public HKOIGHFEGFF(LBADGLFHLDB JMGCHIEOMIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1D02CF0", Offset = "0x1D020F0", VA = "0x181D02CF0")]
	public static NCFEJMLBHNC PIJMMFMEPKL(NKGOABMFHOA GEBIGMANBLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class CDAMOCOJBOI : FNHIOCLGMMN, ONMOMFIOLAG, MHKCJADFHJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class PFLKMLDAPEJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public PFLKMLDAPEJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public LEGBEOMAGOJ errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x1D0F080", Offset = "0x1D0E480", VA = "0x181D0F080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x1D0F2F0", Offset = "0x1D0E6F0", VA = "0x181D0F2F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CDAMOCOJBOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public PFLKMLDAPEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1D0E5B0", Offset = "0x1D0D9B0", VA = "0x181D0E5B0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task MCNBMHJAOBF(LEGBEOMAGOJ errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct MBOKCADNHKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public CDAMOCOJBOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1D09B40", Offset = "0x1D08F40", VA = "0x181D09B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x1D0A030", Offset = "0x1D09430", VA = "0x181D0A030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class MNDBCMEHOFE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public MNDBCMEHOFE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x1D0F350", Offset = "0x1D0E750", VA = "0x181D0F350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x1D0F630", Offset = "0x1D0EA30", VA = "0x181D0F630", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public CDAMOCOJBOI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public MNDBCMEHOFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1D0C7D0", Offset = "0x1D0BBD0", VA = "0x181D0C7D0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task GLLBOHPEFHN(LEGBEOMAGOJ errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly JMHHBOHCGHD JPCIOELAJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ICollection<CPJIJEHJDMH> AJCHJPDCILH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private ANAKFIJHLMO DPFDEDMMKGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1CFC890", Offset = "0x1CFBC90", VA = "0x181CFC890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public AFJMJHOPNGM<OHLBKLDAFGN> HCBBGJMCLPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA31A90", Offset = "0xA30E90", VA = "0x180A31A90", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(AFJMJHOPNGM<OHLBKLDAFGN>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA66050", Offset = "0xA65450", VA = "0x180A66050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public override AFJMJHOPNGM<BCCHBDDNGGN> CIOGEALBLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1CFDBC0", Offset = "0x1CFCFC0", VA = "0x181CFDBC0", Slot = "19")]
		get
		{
			return default(AFJMJHOPNGM<BCCHBDDNGGN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FBEBEFBFOJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1CFCC90", Offset = "0x1CFC090", VA = "0x181CFCC90", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1CFE290", Offset = "0x1CFD690", VA = "0x181CFE290")]
	private CDAMOCOJBOI(DALDCDFKDNN MOBBAFLLKOI, GHHMADPKFFJ LJOKPMONGEA, JMHHBOHCGHD GDIPKKHEKHA, AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK, AFJMJHOPNGM<OHLBKLDAFGN> OFNFNBNPADI, bool CHFNKCCFOOI, string ADLKEGECLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1CFDD50", Offset = "0x1CFD150", VA = "0x181CFDD50")]
	public static CDAMOCOJBOI PIJMMFMEPKL(DALDCDFKDNN MOBBAFLLKOI, GHHMADPKFFJ LJOKPMONGEA, JMHHBOHCGHD KJOOLMAMLNL, AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK, AFJMJHOPNGM<KHHKPFPBNCK> HAIFMEEGDIN, AFJMJHOPNGM<OHLBKLDAFGN> OFNFNBNPADI, bool CHFNKCCFOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC6D0", Offset = "0x1CFBAD0", VA = "0x181CFC6D0", Slot = "20")]
	protected override void FILODNFGCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC510", Offset = "0x1CFB910", VA = "0x181CFC510", Slot = "21")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD6A0", Offset = "0x1CFCAA0", VA = "0x181CFD6A0", Slot = "28")]
	public void KLLNOMNMFPE(CPJIJEHJDMH OGOJNCDOHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC8B0", Offset = "0x1CFBCB0", VA = "0x181CFC8B0", Slot = "25")]
	public void HMJCEPEGDMC(HKNGLMGAKBO LIIFJPLEAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB6B0", Offset = "0x1CFAAB0", VA = "0x181CFB6B0", Slot = "26")]
	public void APAOJEPLKOK(IAIDPAFCNMF FBPFGEBILAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1CFE1B0", Offset = "0x1CFD5B0", VA = "0x181CFE1B0", Slot = "22")]
	protected override void POMEHJNFNCO(DNHGDPHEENP JNEOKNMEADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC1B0", Offset = "0x1CFB5B0", VA = "0x181CFC1B0", Slot = "30")]
	public string BNDPOBMHAJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1CFCE90", Offset = "0x1CFC290", VA = "0x181CFCE90", Slot = "27")]
	public string HOOGMNMOHJM(int GHHLCKKCGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD990", Offset = "0x1CFCD90", VA = "0x181CFD990")]
	private void OEPHHMIENFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC0E0", Offset = "0x1CFB4E0", VA = "0x181CFC0E0", Slot = "29")]
	public void BHKMKADKMNJ(CPJIJEHJDMH OGOJNCDOHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD410", Offset = "0x1CFC810", VA = "0x181CFD410")]
	private void IFOCOPFGOJF(bool PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD1C0", Offset = "0x1CFC5C0", VA = "0x181CFD1C0", Slot = "31")]
	[AsyncStateMachine(typeof(MBOKCADNHKJ))]
	public Task IDIKBFCHDKI(string PAHKKNONPEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB580", Offset = "0x1CFA980", VA = "0x181CFB580")]
	public void AKGJIHBEHCF(string PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC370", Offset = "0x1CFB770", VA = "0x181CFC370")]
	private void DDMCKJJAFNB(int PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0xA66050", Offset = "0xA65450", VA = "0x180A66050")]
	internal void FNFPFHDGHNG(AFJMJHOPNGM<OHLBKLDAFGN> PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1CFDC00", Offset = "0x1CFD000", VA = "0x181CFDC00")]
	[CompilerGenerated]
	private bool PHABHAPNKMD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD770", Offset = "0x1CFCB70", VA = "0x181CFD770")]
	[CompilerGenerated]
	private bool LAECKHENHGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC320", Offset = "0x1CFB720", VA = "0x181CFC320")]
	[CompilerGenerated]
	private int CKONONIBCHM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC050", Offset = "0x1CFB450", VA = "0x181CFC050")]
	[CompilerGenerated]
	private bool BCGGLIOGJOH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD2C0", Offset = "0x1CFC6C0", VA = "0x181CFD2C0")]
	[CompilerGenerated]
	private bool IFNALNDCGOL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD940", Offset = "0x1CFCD40", VA = "0x181CFD940")]
	[CompilerGenerated]
	private bool NMNEEDENFLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB4F0", Offset = "0x1CFA8F0", VA = "0x181CFB4F0")]
	[CompilerGenerated]
	private bool AGGIGMDKLMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1CFC320", Offset = "0x1CFB720", VA = "0x181CFC320")]
	[CompilerGenerated]
	private int LNJGBLBEPKJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1CFE0E0", Offset = "0x1CFD4E0", VA = "0x181CFE0E0")]
	[CompilerGenerated]
	private bool PNNACPKMIEB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1CFB4A0", Offset = "0x1CFA8A0", VA = "0x181CFB4A0")]
	[CompilerGenerated]
	private int ACBPMNKDFII()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD8C0", Offset = "0x1CFCCC0", VA = "0x181CFD8C0")]
	[CompilerGenerated]
	private void MBDJIJFFCGJ(object PAHKKNONPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1CFD5D0", Offset = "0x1CFC9D0", VA = "0x181CFD5D0")]
	[CompilerGenerated]
	private bool JHJOHEINKPI()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class KPIDIBFKKDE
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private abstract class LCNMOGHNLJE<TNode> : PLNKLFHNAFI<TNode> where TNode : notnull, GOFKGLEDMAI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct POHLPONELFO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public AsyncTaskMethodBuilder<EGECKPFNJNE<AFJMJHOPNGM<MEBANFLFBPD>, APEAMGBOOBA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public LCNMOGHNLJE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private TaskAwaiter<EGECKPFNJNE<AFJMJHOPNGM<MEBANFLFBPD>, APEAMGBOOBA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x4088250", Offset = "0x4087650", VA = "0x184088250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x4088620", Offset = "0x4087A20", VA = "0x184088620", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct MLHNFLCLOEH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public LCNMOGHNLJE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public AFJMJHOPNGM<MEBANFLFBPD> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x3E0F310", Offset = "0x3E0E710", VA = "0x183E0F310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x3E0F6E0", Offset = "0x3E0EAE0", VA = "0x183E0F6E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public sealed override bool OMMLGFCLCAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "111")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public sealed override AFJMJHOPNGM<MEBANFLFBPD>? EEIKJAKEJPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x3BF5D90", Offset = "0x3BF5190", VA = "0x183BF5D90", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x381D050", Offset = "0x381C450", VA = "0x18381D050")]
		public LCNMOGHNLJE(DALDCDFKDNN MOBBAFLLKOI, TNode LJOKPMONGEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5980", Offset = "0x3BF4D80", VA = "0x183BF5980", Slot = "94")]
		[AsyncStateMachine(typeof(LCNMOGHNLJE<>.POHLPONELFO))]
		public override Task<EGECKPFNJNE<AFJMJHOPNGM<MEBANFLFBPD>, APEAMGBOOBA>> HBEEPGCDBBN(string ADLKEGECLOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5AA0", Offset = "0x3BF4EA0", VA = "0x183BF5AA0", Slot = "118")]
		public sealed override bool JDDGBKHNECF(AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5CF0", Offset = "0x3BF50F0", VA = "0x183BF5CF0", Slot = "108")]
		protected sealed override bool NHBIDBEIPFL(AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5B40", Offset = "0x3BF4F40", VA = "0x183BF5B40", Slot = "109")]
		protected override bool LBJCPNLOBFJ(AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5BE0", Offset = "0x3BF4FE0", VA = "0x183BF5BE0", Slot = "95")]
		[AsyncStateMachine(typeof(LCNMOGHNLJE<>.MLHNFLCLOEH))]
		public override Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> LKKEAMKIGGJ(AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private sealed class IHAHLBLEECI : HGDNLICIKHB<PMIHGHHKJHJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x894FC0", Offset = "0x8943C0", VA = "0x180894FC0", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1D064E0", Offset = "0x1D058E0", VA = "0x181D064E0")]
		public IHAHLBLEECI(DALDCDFKDNN MOBBAFLLKOI, PMIHGHHKJHJ LJOKPMONGEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private abstract class HGDNLICIKHB<TNode> : PLNKLFHNAFI<TNode> where TNode : notnull, BNKOAPKNIGE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private struct MBNOJOHAGJL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<EGECKPFNJNE<AFJMJHOPNGM<MEBANFLFBPD>, APEAMGBOOBA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public HGDNLICIKHB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private TaskAwaiter<EGECKPFNJNE<AFJMJHOPNGM<MEBANFLFBPD>, APEAMGBOOBA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x3DFBC40", Offset = "0x3DFB040", VA = "0x183DFBC40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x3DFBFB0", Offset = "0x3DFB3B0", VA = "0x183DFBFB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct NHMBMFNICAN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public HGDNLICIKHB<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public AFJMJHOPNGM<MEBANFLFBPD> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x3E9ABF0", Offset = "0x3E99FF0", VA = "0x183E9ABF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x3E9AF40", Offset = "0x3E9A340", VA = "0x183E9AF40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override OIFGKAAGFMP<FKEJMIAIMND>? KGIDOGDGHLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x381D070", Offset = "0x381C470", VA = "0x18381D070", Slot = "112")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override AFJMJHOPNGM<MEBANFLFBPD>? EEIKJAKEJPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x381D0C0", Offset = "0x381C4C0", VA = "0x18381D0C0", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x381D050", Offset = "0x381C450", VA = "0x18381D050")]
		public HGDNLICIKHB(DALDCDFKDNN MOBBAFLLKOI, TNode LJOKPMONGEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x381CC40", Offset = "0x381C040", VA = "0x18381CC40", Slot = "94")]
		[AsyncStateMachine(typeof(HGDNLICIKHB<>.MBNOJOHAGJL))]
		public override Task<EGECKPFNJNE<AFJMJHOPNGM<MEBANFLFBPD>, APEAMGBOOBA>> HBEEPGCDBBN(string ADLKEGECLOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x381CD60", Offset = "0x381C160", VA = "0x18381CD60", Slot = "118")]
		public sealed override bool JDDGBKHNECF(AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x381CFB0", Offset = "0x381C3B0", VA = "0x18381CFB0", Slot = "108")]
		protected sealed override bool NHBIDBEIPFL(AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x381CE00", Offset = "0x381C200", VA = "0x18381CE00", Slot = "109")]
		protected override bool LBJCPNLOBFJ(AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x381CEA0", Offset = "0x381C2A0", VA = "0x18381CEA0", Slot = "95")]
		[AsyncStateMachine(typeof(HGDNLICIKHB<>.NHMBMFNICAN))]
		public override Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> LKKEAMKIGGJ(AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class EAAHKFGJCDK : PLNKLFHNAFI<DNEGJIPOPCL>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x9BA210", Offset = "0x9B9610", VA = "0x1809BA210", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1D02440", Offset = "0x1D01840", VA = "0x181D02440")]
		public EAAHKFGJCDK(DALDCDFKDNN MOBBAFLLKOI, DNEGJIPOPCL LJOKPMONGEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class BODACCJFEHM : HGDNLICIKHB<FCJPAFEOGBC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool HEJHKHDDODJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "86")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool GDIHMMLEDAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1CFB210", Offset = "0x1CFA610", VA = "0x181CFB210", Slot = "113")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8888C0", Offset = "0x887CC0", VA = "0x1808888C0", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1CFB1B0", Offset = "0x1CFA5B0", VA = "0x181CFB1B0")]
		public BODACCJFEHM(DALDCDFKDNN MOBBAFLLKOI, FCJPAFEOGBC LJOKPMONGEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class NJNCPMJMJAN : PLNKLFHNAFI<OJEGLABOANE>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xFD33C0", Offset = "0xFD27C0", VA = "0x180FD33C0", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1D0CBF0", Offset = "0x1D0BFF0", VA = "0x181D0CBF0")]
		public NJNCPMJMJAN(DALDCDFKDNN MOBBAFLLKOI, OJEGLABOANE LJOKPMONGEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class BLHFKLABGDC : PLNKLFHNAFI<EONPPNGBECI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x889BC0", Offset = "0x888FC0", VA = "0x180889BC0", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1CFAC50", Offset = "0x1CFA050", VA = "0x181CFAC50")]
		public BLHFKLABGDC(DALDCDFKDNN MOBBAFLLKOI, EONPPNGBECI LJOKPMONGEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "108")]
		protected override bool NHBIDBEIPFL(AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class GBFEIHFKBEF : PLNKLFHNAFI<FAOAPKFHJDO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x89E400", Offset = "0x89D800", VA = "0x18089E400", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool FEDJPDAJLIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x1D04320", Offset = "0x1D03720", VA = "0x181D04320", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected override bool LEOGDFEJPCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "83")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1D042C0", Offset = "0x1D036C0", VA = "0x181D042C0")]
		public GBFEIHFKBEF(DALDCDFKDNN MOBBAFLLKOI, FAOAPKFHJDO LJOKPMONGEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class LPNNNLFDFJP : PLNKLFHNAFI<PIKEKFPBPGF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x887860", Offset = "0x886C60", VA = "0x180887860", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override bool FEDJPDAJLIE
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x1D09AF0", Offset = "0x1D08EF0", VA = "0x181D09AF0", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected override bool LEOGDFEJPCG
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "83")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x1D09A90", Offset = "0x1D08E90", VA = "0x181D09A90")]
		public LPNNNLFDFJP(DALDCDFKDNN MOBBAFLLKOI, PIKEKFPBPGF LJOKPMONGEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class PEDCLPPFFAO : LCNMOGHNLJE<OAGKLDJGAIN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8946B0", Offset = "0x893AB0", VA = "0x1808946B0", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1D0E550", Offset = "0x1D0D950", VA = "0x181D0E550")]
		public PEDCLPPFFAO(DALDCDFKDNN MOBBAFLLKOI, OAGKLDJGAIN LJOKPMONGEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class PLNKLFHNAFI<TNode> : JAIBKPJGPDB, IDisposable where TNode : notnull, GHHMADPKFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class EOALMMKJICA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public PLNKLFHNAFI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public DALDCDFKDNN circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public EOALMMKJICA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x32F8B50", Offset = "0x32F7F50", VA = "0x1832F8B50")]
			internal BFAIKFKHJCC BNFDKCMFLJM(ENBMMJNFDJI portGroup, int index)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct KLAGNMAIEPK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public PLNKLFHNAFI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public AJFHPAINAFB? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public KLPEPKLOMOM? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x3B56840", Offset = "0x3B55C40", VA = "0x183B56840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x3B56AE0", Offset = "0x3B55EE0", VA = "0x183B56AE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct PJLDOEINEDI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public PLNKLFHNAFI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x405BD50", Offset = "0x405B150", VA = "0x18405BD50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x405BFB0", Offset = "0x405B3B0", VA = "0x18405BFB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private DALDCDFKDNN KDPEGNEFKDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private IBDIOALHDNN<MEBANFLFBPD, BFAIKFKHJCC> FJDOBOMFJFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private IBDIOALHDNN<MEBANFLFBPD, MMKLAHOIFLE> CLPHOFNAHJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private List<Action> LIMDHMHFNAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[CompilerGenerated]
		private Action<AFJMJHOPNGM<MEBANFLFBPD>>? DGOEGGBOOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[CompilerGenerated]
		private Action<AFJMJHOPNGM<MEBANFLFBPD>, MMKLAHOIFLE>? PJHKFKJBACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[CompilerGenerated]
		private Action<AFJMJHOPNGM<MEBANFLFBPD>, AFJMJHOPNGM<MEBANFLFBPD>>? FIFFIGLMADK;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected TNode LBPIDMGJBEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7940D0", Offset = "0x7934D0", VA = "0x1807940D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public OIFGKAAGFMP<PPGDEHKJPIO> AOOOMCBJOAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xE38C90", Offset = "0xE38090", VA = "0x180E38C90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(OIFGKAAGFMP<PPGDEHKJPIO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public object PEGLAKOCCNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x333A500", Offset = "0x3339900", VA = "0x18333A500", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public virtual bool ACJNPOPPAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "81")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int JPJAEGPCJKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x4077C70", Offset = "0x4077070", VA = "0x184077C70", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public HOANIEENNCJ EEGKFJHKJGL
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x4077C20", Offset = "0x4077020", VA = "0x184077C20", Slot = "9")]
			get
			{
				return default(HOANIEENNCJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string JLIBIEHMEJM
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x40780B0", Offset = "0x40774B0", VA = "0x1840780B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected virtual bool LEOGDFEJPCG
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "83")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public AFJMJHOPNGM<MDFPPNDOOGL> MMLNNBOCGIP
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7A0110", Offset = "0x79F510", VA = "0x1807A0110", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(AFJMJHOPNGM<MDFPPNDOOGL>);
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7DC260", Offset = "0x7DB660", VA = "0x1807DC260")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public virtual bool FEDJPDAJLIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual bool HEJHKHDDODJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "86")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public virtual KOEMGCAGALG KOIADNBEAAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x87F990", Offset = "0x87ED90", VA = "0x18087F990", Slot = "87")]
			get
			{
				return default(KOEMGCAGALG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool JAMJFGHOJGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x4077A40", Offset = "0x4076E40", VA = "0x184077A40", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool IPBLLKLAHEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x4077A90", Offset = "0x4076E90", VA = "0x184077A90", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public bool ONOFMBFCHDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x4077AE0", Offset = "0x4076EE0", VA = "0x184077AE0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int INJMBDFCDDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x4077F00", Offset = "0x4077300", VA = "0x184077F00", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool LKMIMNIEINE
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x4077E20", Offset = "0x4077220", VA = "0x184077E20", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string NGAMHNAADOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x4077D30", Offset = "0x4077130", VA = "0x184077D30", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool MEDABAEHDDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x4077B80", Offset = "0x4076F80", VA = "0x184077B80", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool MLKIMAIHADM
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xBA7AF0", Offset = "0xBA6EF0", VA = "0x180BA7AF0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xBC3910", Offset = "0xBC2D10", VA = "0x180BC3910")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool DFCLEKBBINI
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual bool BHJKHOCFMDD
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x4077B30", Offset = "0x4076F30", VA = "0x184077B30", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool NNILPKNLNJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x4077D70", Offset = "0x4077170", VA = "0x184077D70", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public AJFHPAINAFB IIMAAFEMNON
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x4077E60", Offset = "0x4077260", VA = "0x184077E60", Slot = "27")]
			get
			{
				return default(AJFHPAINAFB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public KLPEPKLOMOM NEELOJMOJMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x4077EB0", Offset = "0x40772B0", VA = "0x184077EB0", Slot = "29")]
			get
			{
				return default(KLPEPKLOMOM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual bool OLOBGPEKIMN
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "103")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual ONOOKKHEIJC? EGPOPALFIDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "104")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual AALEGMCOCMN? JFGBANGHCBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual IEnumerable<OIFGKAAGFMP<FJBFPEKHLHL>>? LIBEJCEACPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "106")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool MOOALHEDKGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x4077BD0", Offset = "0x4076FD0", VA = "0x184077BD0", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public OIFGKAAGFMP<FKEJMIAIMND> FJJPDNKJMJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x4077CB0", Offset = "0x40770B0", VA = "0x184077CB0", Slot = "55")]
			get
			{
				return default(OIFGKAAGFMP<FKEJMIAIMND>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool OMMLGFCLCAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "111")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual OIFGKAAGFMP<FKEJMIAIMND>? KGIDOGDGHLN
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x4077D00", Offset = "0x4077100", VA = "0x184077D00", Slot = "112")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual bool GDIHMMLEDAB
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "113")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool BIHOLPAHPKI
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x4077DC0", Offset = "0x40771C0", VA = "0x184077DC0", Slot = "60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string DACJMNMHBIF
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x793FA0", Offset = "0x7933A0", VA = "0x180793FA0", Slot = "62")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x793FB0", Offset = "0x7933B0", VA = "0x180793FB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public OIFGKAAGFMP<FJBFPEKHLHL> HHEMLCFLGJE
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x4077F40", Offset = "0x4077340", VA = "0x184077F40", Slot = "61")]
			get
			{
				return default(OIFGKAAGFMP<FJBFPEKHLHL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public OIFGKAAGFMP<FJBFPEKHLHL>? OJBAJEMEJPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x4077F90", Offset = "0x4077390", VA = "0x184077F90", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public JPIOHCCBMDN<MEBANFLFBPD, MMKLAHOIFLE> OBFHBOPMDJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4078070", Offset = "0x4077470", VA = "0x184078070", Slot = "63")]
			get
			{
				return default(JPIOHCCBMDN<MEBANFLFBPD, MMKLAHOIFLE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual AFJMJHOPNGM<MEBANFLFBPD>? EEIKJAKEJPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NCLDHCPJCEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x4075120", Offset = "0x4074520", VA = "0x184075120", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x4075280", Offset = "0x4074680", VA = "0x184075280", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event BJCKFDLCNJB EOIJNHGJANA
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x4075ED0", Offset = "0x40752D0", VA = "0x184075ED0", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x4076F30", Offset = "0x4076330", VA = "0x184076F30", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event KDHMHJNENHA JLDFFFKKJCF
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x4075DA0", Offset = "0x40751A0", VA = "0x184075DA0", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x4076D10", Offset = "0x4076110", VA = "0x184076D10", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action FFLOFJAOADN
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x4076420", Offset = "0x4075820", VA = "0x184076420", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x40750C0", Offset = "0x40744C0", VA = "0x1840750C0", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action JGENBNHPBHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x4077610", Offset = "0x4076A10", VA = "0x184077610", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x4073F10", Offset = "0x4073310", VA = "0x184073F10", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<AFJMJHOPNGM<MEBANFLFBPD>, MMKLAHOIFLE> IJGPLBNJGFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4077560", Offset = "0x4076960", VA = "0x184077560", Slot = "65")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4074750", Offset = "0x4073B50", VA = "0x184074750", Slot = "66")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<AFJMJHOPNGM<MEBANFLFBPD>, MMKLAHOIFLE> IDOGGPAMOPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x40744D0", Offset = "0x40738D0", VA = "0x1840744D0", Slot = "69")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x40751C0", Offset = "0x40745C0", VA = "0x1840751C0", Slot = "70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<AFJMJHOPNGM<MEBANFLFBPD>> KALEOGFEOJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x4074690", Offset = "0x4073A90", VA = "0x184074690", Slot = "67")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x4073CF0", Offset = "0x40730F0", VA = "0x184073CF0", Slot = "68")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<AFJMJHOPNGM<MEBANFLFBPD>, AFJMJHOPNGM<MEBANFLFBPD>> BMIKPJGKEDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4076DB0", Offset = "0x40761B0", VA = "0x184076DB0", Slot = "71")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4076E70", Offset = "0x4076270", VA = "0x184076E70", Slot = "72")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<AFJMJHOPNGM<MEBANFLFBPD>, MMKLAHOIFLE> ADOLMPODLLA
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x4076100", Offset = "0x4075500", VA = "0x184076100", Slot = "73")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x40761C0", Offset = "0x40755C0", VA = "0x1840761C0", Slot = "74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4077700", Offset = "0x4076B00", VA = "0x184077700")]
		[BHFIKJBBKEL("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[BHFIKJBBKEL("Need to handle `Name` better.")]
		public PLNKLFHNAFI(DALDCDFKDNN MOBBAFLLKOI, TNode LJOKPMONGEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4075590", Offset = "0x4074990", VA = "0x184075590", Slot = "79")]
		protected virtual void FILODNFGCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4074800", Offset = "0x4073C00", VA = "0x184074800", Slot = "80")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4073EC0", Offset = "0x40732C0", VA = "0x184073EC0", Slot = "82")]
		public virtual void BCIFMONMCEI(int HFGHAJGPIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x40765F0", Offset = "0x40759F0", VA = "0x1840765F0")]
		public bool JHACPGGNEGO([In] AJFHPAINAFB PAHKKNONPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x40773B0", Offset = "0x40767B0", VA = "0x1840773B0")]
		public bool NPHKJKJIOCG([In] KLPEPKLOMOM PAHKKNONPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x4075F70", Offset = "0x4075370", VA = "0x184075F70", Slot = "90")]
		public virtual void GOGOCKMHDBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4077410", Offset = "0x4076810", VA = "0x184077410", Slot = "32")]
		[AsyncStateMachine(typeof(PLNKLFHNAFI<>.KLAGNMAIEPK))]
		public Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> OKDKBGMFLKC(AJFHPAINAFB? OHOMLOMNFJE, KLPEPKLOMOM? MCGHOJEKKGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "91")]
		public virtual void CKMAJPCFLAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "92")]
		public virtual void MLCGJKHMDAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "93")]
		public virtual void FFDHCILADDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x147C190", Offset = "0x147B590", VA = "0x18147C190")]
		protected void MJBNNDPMOAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x11A4AF0", Offset = "0x11A3EF0", VA = "0x1811A4AF0")]
		protected void IAOJGNCALOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1181B50", Offset = "0x1180F50", VA = "0x181181B50")]
		private void BALCIDADJEO([In] KLPEPKLOMOM GIJALKLADPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4075FC0", Offset = "0x40753C0", VA = "0x184075FC0", Slot = "94")]
		public virtual Task<EGECKPFNJNE<AFJMJHOPNGM<MEBANFLFBPD>, APEAMGBOOBA>> HBEEPGCDBBN(string ADLKEGECLOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4076C10", Offset = "0x4076010", VA = "0x184076C10", Slot = "95")]
		public virtual Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> LKKEAMKIGGJ(AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4075320", Offset = "0x4074720", VA = "0x184075320", Slot = "96")]
		public virtual void EMPPGBPOMLH(AFJMJHOPNGM<MEBANFLFBPD> FGBBDGJMFEH, AFJMJHOPNGM<MEBANFLFBPD> GOOANMNBGEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4075E40", Offset = "0x4075240", VA = "0x184075E40", Slot = "97")]
		public virtual IEnumerable<PEIMDLKNNKH> GDMONEMPMCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4075370", Offset = "0x4074770", VA = "0x184075370", Slot = "98")]
		public EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA> ENHMOPCDKPP(string BOMNJHKKKDF)
		{
			return default(EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x40762D0", Offset = "0x40756D0", VA = "0x1840762D0", Slot = "46")]
		public bool IGHBFPBDEPB([Out] Guid OKLMKFMFKLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4075070", Offset = "0x4074470", VA = "0x184075070", Slot = "99")]
		public virtual bool ECACNDIHLCH([In] Guid GILNCNDAFEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4073DB0", Offset = "0x40731B0", VA = "0x184073DB0", Slot = "100")]
		public virtual void AIKIIHKLAJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "101")]
		public virtual void JILGDHMMJMI(bool ADIOHOIDING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "102")]
		public virtual GPGNOHAEIBN AMGGCEKLACA([In] PAINDOECJIF GAGDCKKHOBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4075C80", Offset = "0x4075080", VA = "0x184075C80")]
		protected void FMPONPEOHCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "107")]
		protected virtual void IMICGEMCIFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4076FD0", Offset = "0x40763D0", VA = "0x184076FD0", Slot = "108")]
		protected virtual bool NHBIDBEIPFL(AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "109")]
		protected virtual bool LBJCPNLOBFJ(AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "116")]
		protected virtual void BBGHJANBHJB(LGFFGCPPIPB HIICDEKEPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "117")]
		protected virtual void DCEAAJHKIGC(LGFFGCPPIPB GCEABECLALA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x4073E70", Offset = "0x4073270", VA = "0x184073E70", Slot = "75")]
		public void APAOJEPLKOK(LGFFGCPPIPB GCEABECLALA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x4076700", Offset = "0x4075B00", VA = "0x184076700", Slot = "76")]
		public GNLPJKAHBMM KIEFJIAPOEM()
		{
			return default(GNLPJKAHBMM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "118")]
		public virtual bool JDDGBKHNECF(AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4075D80", Offset = "0x4075180", VA = "0x184075D80")]
		private void FNLDMDKIKJA([In] AJFHPAINAFB BCGGHPIMKDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x4074590", Offset = "0x4073990", VA = "0x184074590")]
		private void DDOJGPBCMKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x4073FB0", Offset = "0x40733B0", VA = "0x184073FB0")]
		private void CMDJGIBFEEE(int CNBNJGGABMG, ENBMMJNFDJI CKKJFNIJPON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x40776B0", Offset = "0x4076AB0", VA = "0x1840776B0")]
		private void PNFJGIPPBNG(int FGBBDGJMFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x4075450", Offset = "0x4074850", VA = "0x184075450")]
		private void FHHHHDOINHD(int FGBBDGJMFEH, ENBMMJNFDJI PDLENPDPJEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x4077000", Offset = "0x4076400", VA = "0x184077000")]
		private void NNENJJFHPAH(int KKOPNHGCOGA, int HKGGBCFBHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x40753F0", Offset = "0x40747F0", VA = "0x1840753F0")]
		private void FDHEJCEJDBN(int KKOPNHGCOGA, int HKGGBCFBHAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x4076280", Offset = "0x4075680", VA = "0x184076280")]
		private void IFGFMCALLKE(int FGBBDGJMFEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x40767E0", Offset = "0x4075BE0", VA = "0x1840767E0")]
		private void KMLLJCAJGHB(int CNBNJGGABMG, ENBMMJNFDJI CKKJFNIJPON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4076650", Offset = "0x4075A50", VA = "0x184076650")]
		private void JHHFFMAKCOD(int FGBBDGJMFEH, ENBMMJNFDJI PDLENPDPJEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x40764D0", Offset = "0x40758D0", VA = "0x1840764D0", Slot = "119")]
		[AsyncStateMachine(typeof(PLNKLFHNAFI<>.PJLDOEINEDI))]
		public virtual Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> IOAFLGGNCOF(string BOMNJHKKKDF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4073E00", Offset = "0x4073200", VA = "0x184073E00", Slot = "53")]
		private void ALFGDPELGKL(object JMDHBEMFJEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4076090", Offset = "0x4075490", VA = "0x184076090", Slot = "54")]
		private void HDBEKGDFPDG(object JMDHBEMFJEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x40766D0", Offset = "0x4075AD0", VA = "0x1840766D0", Slot = "28")]
		private bool JNLJJGLABGH([In] AJFHPAINAFB PAHKKNONPEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4076CE0", Offset = "0x40760E0", VA = "0x184076CE0", Slot = "30")]
		private bool LNDNPOFCMAO([In] KLPEPKLOMOM PAHKKNONPEO)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class HOLFDHPGPOC : LCNMOGHNLJE<KDOMBFOIOCN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public override NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAA9370", Offset = "0xAA8770", VA = "0x180AA9370", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x1D06280", Offset = "0x1D05680", VA = "0x181D06280")]
		public HOLFDHPGPOC(DALDCDFKDNN MOBBAFLLKOI, KDOMBFOIOCN LJOKPMONGEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class MJHLGMKDECH : HGDNLICIKHB<BKOJOBCKLJO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public override NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x894FC0", Offset = "0x8943C0", VA = "0x180894FC0", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1D0A5F0", Offset = "0x1D099F0", VA = "0x181D0A5F0")]
		public MJHLGMKDECH(DALDCDFKDNN MOBBAFLLKOI, BKOJOBCKLJO LJOKPMONGEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private sealed class BGCBGMGGBGK : PLNKLFHNAFI<CDLICFHIOFC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public override NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x859E30", Offset = "0x859230", VA = "0x180859E30", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9FC0", Offset = "0x1CF93C0", VA = "0x181CF9FC0")]
		public BGCBGMGGBGK(DALDCDFKDNN MOBBAFLLKOI, CDLICFHIOFC LJOKPMONGEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class MKFEHHJFHBN : HGDNLICIKHB<JEHFCEJFPNL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public override NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x894FC0", Offset = "0x8943C0", VA = "0x180894FC0", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x1D0C770", Offset = "0x1D0BB70", VA = "0x181D0C770")]
		public MKFEHHJFHBN(DALDCDFKDNN MOBBAFLLKOI, JEHFCEJFPNL LJOKPMONGEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private sealed class FDLLFAHNIBI : HGDNLICIKHB<FACDHKOECGM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public override NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x894FC0", Offset = "0x8943C0", VA = "0x180894FC0", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1D02C90", Offset = "0x1D02090", VA = "0x181D02C90")]
		public FDLLFAHNIBI(DALDCDFKDNN MOBBAFLLKOI, FACDHKOECGM LJOKPMONGEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private sealed class HOGKKBDNBNI : PLNKLFHNAFI<BOOGIEOKEIA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public override NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x9169E0", Offset = "0x915DE0", VA = "0x1809169E0", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1D06220", Offset = "0x1D05620", VA = "0x181D06220")]
		public HOGKKBDNBNI(DALDCDFKDNN MOBBAFLLKOI, BOOGIEOKEIA LJOKPMONGEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private sealed class DOBADBCMFDO : PLNKLFHNAFI<BGPBKPGMFJK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public override NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x791450", Offset = "0x790850", VA = "0x180791450", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected override bool LEOGDFEJPCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "83")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x1D023E0", Offset = "0x1D017E0", VA = "0x181D023E0")]
		public DOBADBCMFDO(DALDCDFKDNN MOBBAFLLKOI, BGPBKPGMFJK LJOKPMONGEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private sealed class OFKILFMOEJP : PLNKLFHNAFI<NADGMCOCHBB>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public override NodeVisualizationKey EALKNHCDKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x889200", Offset = "0x888600", VA = "0x180889200", Slot = "84")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DE90", Offset = "0x1D0D290", VA = "0x181D0DE90")]
		public OFKILFMOEJP(DALDCDFKDNN MOBBAFLLKOI, NADGMCOCHBB LJOKPMONGEA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1D08020", Offset = "0x1D07420", VA = "0x181D08020")]
	internal static JAIBKPJGPDB PIJMMFMEPKL(DALDCDFKDNN MOBBAFLLKOI, GHHMADPKFFJ LJOKPMONGEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class GIPBCMLHNIB : FNHIOCLGMMN, JOHJOIANCFH, MHKCJADFHJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public AFJMJHOPNGM<MNKAKLAHHBM> CMNAACCIFDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xD0CDE0", Offset = "0xD0C1E0", VA = "0x180D0CDE0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(AFJMJHOPNGM<MNKAKLAHHBM>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xD0C970", Offset = "0xD0BD70", VA = "0x180D0C970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public override AFJMJHOPNGM<BCCHBDDNGGN> CIOGEALBLDI
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1D04840", Offset = "0x1D03C40", VA = "0x181D04840", Slot = "19")]
		get
		{
			return default(AFJMJHOPNGM<BCCHBDDNGGN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1D04BA0", Offset = "0x1D03FA0", VA = "0x181D04BA0")]
	private GIPBCMLHNIB(DALDCDFKDNN MOBBAFLLKOI, GHHMADPKFFJ LJOKPMONGEA, OFPJIIECDIB MIHKLGIFPEF, AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK, AFJMJHOPNGM<MNKAKLAHHBM> MMEEKIELCPF, bool CHFNKCCFOOI, string ADLKEGECLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1D04880", Offset = "0x1D03C80", VA = "0x181D04880")]
	public static GIPBCMLHNIB PIJMMFMEPKL(DALDCDFKDNN MOBBAFLLKOI, GHHMADPKFFJ LJOKPMONGEA, OFPJIIECDIB NOBJGCEECEA, AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK, AFJMJHOPNGM<EOMHPAMKBIG> POFGGOGBDJH, AFJMJHOPNGM<MNKAKLAHHBM> MMEEKIELCPF, bool CHFNKCCFOOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0xD0C970", Offset = "0xD0BD70", VA = "0x180D0C970")]
	internal void MIEBDGMHCBD(AFJMJHOPNGM<MNKAKLAHHBM> PAHKKNONPEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class FNHIOCLGMMN : MHKCJADFHJC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct LPDMICLHFHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private ADABIMNIDDN? PKMBMOCPAMK;

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1D09A80", Offset = "0x1D08E80", VA = "0x181D09A80")]
		public void EKABOMHIFDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1D099E0", Offset = "0x1D08DE0", VA = "0x181D099E0")]
		public ADABIMNIDDN CCILDKOPCBM(FNHIOCLGMMN BKBCIFEIADA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	protected readonly DALDCDFKDNN KDPEGNEFKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	protected readonly GHHMADPKFFJ GEJPKKLCDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private LPDMICLHFHD HMEHABLLMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly CDOPCGIIMLJ BFOPDCODABO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<DMHNAGFOBHA> JLPNLMHNCEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly List<AAMJEDDPBKK> BOIOONLBNNK;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IEnumerable<StaticEdge> KFFAFPJAELN
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x1D02F20", Offset = "0x1D02320", VA = "0x181D02F20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public DisplayKind AGFGENJMOFO
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7A0110", Offset = "0x79F510", VA = "0x1807A0110", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public OIFGKAAGFMP<FKEJMIAIMND> FJJPDNKJMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x1D03D00", Offset = "0x1D03100", VA = "0x181D03D00", Slot = "6")]
		get
		{
			return default(OIFGKAAGFMP<FKEJMIAIMND>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public ILHPDGFJEIK BBEKAPONFNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x999CD0", Offset = "0x9990D0", VA = "0x180999CD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public HDHCEOIMPNG JCENGJEPDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x1D02E80", Offset = "0x1D02280", VA = "0x181D02E80", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	protected ADABIMNIDDN HEIJODOOPMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D02E80", Offset = "0x1D02280", VA = "0x181D02E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public PortImage MGDAHJCLANH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1D03FC0", Offset = "0x1D033C0", VA = "0x181D03FC0", Slot = "12")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public string DACJMNMHBIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x78F350", Offset = "0x78E750", VA = "0x18078F350", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x78F1C0", Offset = "0x78E5C0", VA = "0x18078F1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public OIFGKAAGFMP<FJBFPEKHLHL> HHEMLCFLGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1D03D90", Offset = "0x1D03190", VA = "0x181D03D90", Slot = "8")]
		get
		{
			return default(OIFGKAAGFMP<FJBFPEKHLHL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public AFJMJHOPNGM<MEBANFLFBPD> FDBJFEMDCMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x874EE0", Offset = "0x8742E0", VA = "0x180874EE0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(AFJMJHOPNGM<MEBANFLFBPD>);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1768D50", Offset = "0x1768150", VA = "0x181768D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public abstract AFJMJHOPNGM<BCCHBDDNGGN> CIOGEALBLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x1D04150", Offset = "0x1D03550", VA = "0x181D04150")]
	protected FNHIOCLGMMN(DALDCDFKDNN MOBBAFLLKOI, GHHMADPKFFJ LJOKPMONGEA, CDOPCGIIMLJ HKGKDHIIFJP, AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK, bool CHFNKCCFOOI, string ADLKEGECLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x1D03600", Offset = "0x1D02A00", VA = "0x181D03600", Slot = "20")]
	protected virtual void FILODNFGCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x1D033F0", Offset = "0x1D027F0", VA = "0x181D033F0", Slot = "21")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1D03540", Offset = "0x1D02940", VA = "0x181D03540", Slot = "13")]
	public void ENOIHAMJJHF(DMHNAGFOBHA IBMIOMMKLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1D035A0", Offset = "0x1D029A0", VA = "0x181D035A0", Slot = "14")]
	public void EOKCOEJBKHH(AAMJEDDPBKK IBMIOMMKLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1D03750", Offset = "0x1D02B50", VA = "0x181D03750", Slot = "15")]
	public void FMNLLIIOGBN(DNHGDPHEENP JNEOKNMEADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x1D040F0", Offset = "0x1D034F0", VA = "0x181D040F0", Slot = "22")]
	protected virtual void POMEHJNFNCO(DNHGDPHEENP JNEOKNMEADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x1D03260", Offset = "0x1D02660", VA = "0x181D03260")]
	private void CGADHDBBBMM(bool IBGLEOLMNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x1D03DB0", Offset = "0x1D031B0", VA = "0x181D03DB0")]
	private void LFAMAFMCABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x1D030B0", Offset = "0x1D024B0", VA = "0x181D030B0")]
	private void BPDNMDCCBIH([In] FBAGGHNMCAA EFJKINFOPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x1D03D30", Offset = "0x1D03130", VA = "0x181D03D30", Slot = "16")]
	public void HMLBGFNMIID(DMHNAGFOBHA IBMIOMMKLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1D03F60", Offset = "0x1D03360", VA = "0x181D03F60", Slot = "17")]
	public void LFKPOGENFNM(AAMJEDDPBKK IBMIOMMKLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x78F1C0", Offset = "0x78E5C0", VA = "0x18078F1C0")]
	internal void EGIOJJOGMDN(string ADLKEGECLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x1D03CE0", Offset = "0x1D030E0", VA = "0x181D03CE0")]
	internal void HEIDAJIKEOD(GIPJGPAPNHP BFMHNHDBGGN, ILHPDGFJEIK KHENBEDBKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1768D50", Offset = "0x1768150", VA = "0x181768D50")]
	internal void GKPNLJKLNAB(AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class BFAIKFKHJCC : MMKLAHOIFLE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class PIDNGPJABKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public DALDCDFKDNN circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GHHMADPKFFJ node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AFJMJHOPNGM<MEBANFLFBPD> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public bool canInteract;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
		public PIDNGPJABKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x1D0EC00", Offset = "0x1D0E000", VA = "0x181D0EC00")]
		internal CDAMOCOJBOI JHDMDGLPKBD((int PortDescIndex, int PortIndex, JMHHBOHCGHD InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1D0EB80", Offset = "0x1D0DF80", VA = "0x181D0EB80")]
		internal GIPBCMLHNIB INMMCMCEEDM(OFPJIIECDIB i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct DJPOPMCPFKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public BFAIKFKHJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private LEGBEOMAGOJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1D00E10", Offset = "0x1D00210", VA = "0x181D00E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1D01270", Offset = "0x1D00670", VA = "0x181D01270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct LNCPDAOGNCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public BFAIKFKHJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AFJMJHOPNGM<KHHKPFPBNCK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private LEGBEOMAGOJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x1D09260", Offset = "0x1D08660", VA = "0x181D09260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x1D095B0", Offset = "0x1D089B0", VA = "0x181D095B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct PBILBHFEJOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public BFAIKFKHJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public AFJMJHOPNGM<EOMHPAMKBIG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private LEGBEOMAGOJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DEF0", Offset = "0x1D0D2F0", VA = "0x181D0DEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1D0E240", Offset = "0x1D0D640", VA = "0x181D0E240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct LGKCHANFJAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public BFAIKFKHJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public AFJMJHOPNGM<KHHKPFPBNCK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public AFJMJHOPNGM<KHHKPFPBNCK> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private LEGBEOMAGOJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1D08AC0", Offset = "0x1D07EC0", VA = "0x181D08AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1D08E10", Offset = "0x1D08210", VA = "0x181D08E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct FDDEOGCEOLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public BFAIKFKHJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public AFJMJHOPNGM<EOMHPAMKBIG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public AFJMJHOPNGM<EOMHPAMKBIG> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private LEGBEOMAGOJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x1D028D0", Offset = "0x1D01CD0", VA = "0x181D028D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1D02C20", Offset = "0x1D02020", VA = "0x181D02C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct DLENBPNHCHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public BFAIKFKHJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private LEGBEOMAGOJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1D016A0", Offset = "0x1D00AA0", VA = "0x181D016A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1D01B10", Offset = "0x1D00F10", VA = "0x181D01B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct DKOAJLGJPGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public BFAIKFKHJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private LEGBEOMAGOJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x1D012E0", Offset = "0x1D006E0", VA = "0x181D012E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x1D01630", Offset = "0x1D00A30", VA = "0x181D01630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct LNGALLMNIKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public BFAIKFKHJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public AFJMJHOPNGM<KHHKPFPBNCK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private LEGBEOMAGOJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1D09620", Offset = "0x1D08A20", VA = "0x181D09620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x1D09970", Offset = "0x1D08D70", VA = "0x181D09970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct OBHOOFPHMOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public BFAIKFKHJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public AFJMJHOPNGM<EOMHPAMKBIG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private LEGBEOMAGOJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1D0D7B0", Offset = "0x1D0CBB0", VA = "0x181D0D7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DB00", Offset = "0x1D0CF00", VA = "0x181D0DB00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct PLOCAICEIOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public BFAIKFKHJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public GGDJPHKMPIL type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public AFJMJHOPNGM<KHHKPFPBNCK> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private LEGBEOMAGOJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1D0EC80", Offset = "0x1D0E080", VA = "0x181D0EC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1D0F010", Offset = "0x1D0E410", VA = "0x181D0F010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct NKGFAKPIECP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public BFAIKFKHJCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public GGDJPHKMPIL type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AFJMJHOPNGM<EOMHPAMKBIG> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private LEGBEOMAGOJ <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1D0CC50", Offset = "0x1D0C050", VA = "0x181D0CC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1D0CFE0", Offset = "0x1D0C3E0", VA = "0x181D0CFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly bool KACFPFHGOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly DALDCDFKDNN KDPEGNEFKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly bool JBPMOPMKGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private JPIOHCCBMDN<OHLBKLDAFGN, CDAMOCOJBOI> BAGJHNOMAON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private JPIOHCCBMDN<OHLBKLDAFGN, ONMOMFIOLAG> GCBBGNCIKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly GHHMADPKFFJ GEJPKKLCDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private JPIOHCCBMDN<MNKAKLAHHBM, GIPBCMLHNIB> IEPPIODGMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private JPIOHCCBMDN<MNKAKLAHHBM, JOHJOIANCFH> HDIEGCGMBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private string? OIJCALJCMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly ENBMMJNFDJI NLEBGBDLFPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private AFJMJHOPNGM<MEBANFLFBPD> NFFOKBHLNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[CompilerGenerated]
	private Action? AAPAOEDOAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	[CompilerGenerated]
	private Action? PKCGACLEGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[CompilerGenerated]
	private Action? FPCAHPAPAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	[CompilerGenerated]
	private Action<AFJMJHOPNGM<OHLBKLDAFGN>>? FNLGAEPJJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[CompilerGenerated]
	private Action<AFJMJHOPNGM<MNKAKLAHHBM>>? HGIDCLFIDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	[CompilerGenerated]
	private MMKLAHOIFLE.CLOHNCDPIMD? PHEMHOLCPNH;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool LNMGIDPEPGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1CF4320", Offset = "0x1CF3720", VA = "0x181CF4320", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool ABFGLHCLHEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9450", Offset = "0x1CF8850", VA = "0x181CF9450", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public bool FLLFBPEFGKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9550", Offset = "0x1CF8950", VA = "0x181CF9550", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public OIFGKAAGFMP<FKEJMIAIMND> FJJPDNKJMJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1CF81B0", Offset = "0x1CF75B0", VA = "0x181CF81B0", Slot = "7")]
		get
		{
			return default(OIFGKAAGFMP<FKEJMIAIMND>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public bool CCHLDOKGMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1CF5F30", Offset = "0x1CF5330", VA = "0x181CF5F30", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public JPIOHCCBMDN<OHLBKLDAFGN, ONMOMFIOLAG> EIKABNLHBMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x793FD0", Offset = "0x7933D0", VA = "0x180793FD0", Slot = "9")]
		get
		{
			return default(JPIOHCCBMDN<OHLBKLDAFGN, ONMOMFIOLAG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public string DACJMNMHBIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9130", Offset = "0x1CF8530", VA = "0x181CF9130", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public OIFGKAAGFMP<FJBFPEKHLHL> HHEMLCFLGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1CF8530", Offset = "0x1CF7930", VA = "0x181CF8530", Slot = "11")]
		get
		{
			return default(OIFGKAAGFMP<FJBFPEKHLHL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public JPIOHCCBMDN<MNKAKLAHHBM, JOHJOIANCFH> EJOHEPOMKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x78F350", Offset = "0x78E750", VA = "0x18078F350", Slot = "12")]
		get
		{
			return default(JPIOHCCBMDN<MNKAKLAHHBM, JOHJOIANCFH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public AFJMJHOPNGM<MEBANFLFBPD> FDBJFEMDCMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x9A3160", Offset = "0x9A2560", VA = "0x1809A3160", Slot = "13")]
		get
		{
			return default(AFJMJHOPNGM<MEBANFLFBPD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action? KNDLCPKGIKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x1CF8610", Offset = "0x1CF7A10", VA = "0x181CF8610", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1CF4730", Offset = "0x1CF3B30", VA = "0x181CF4730", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? COAEEEIOLBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1CF43E0", Offset = "0x1CF37E0", VA = "0x181CF43E0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1CF4680", Offset = "0x1CF3A80", VA = "0x181CF4680", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<AFJMJHOPNGM<OHLBKLDAFGN?>, AFJMJHOPNGM<OHLBKLDAFGN?>>? ODFICHOMMJD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1CF80F0", Offset = "0x1CF74F0", VA = "0x181CF80F0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1CF86B0", Offset = "0x1CF7AB0", VA = "0x181CF86B0", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<AFJMJHOPNGM<MNKAKLAHHBM?>, AFJMJHOPNGM<MNKAKLAHHBM?>>? MIKCMANLKHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1CF64D0", Offset = "0x1CF58D0", VA = "0x181CF64D0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1CF4FD0", Offset = "0x1CF43D0", VA = "0x181CF4FD0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<AFJMJHOPNGM<OHLBKLDAFGN?>, ONMOMFIOLAG?>? DMHNBDBDLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x1CF8550", Offset = "0x1CF7950", VA = "0x181CF8550", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9490", Offset = "0x1CF8890", VA = "0x181CF9490", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<AFJMJHOPNGM<OHLBKLDAFGN?>>? IBDDKFNJPNA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x1CF47D0", Offset = "0x1CF3BD0", VA = "0x181CF47D0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x1CF8E60", Offset = "0x1CF8260", VA = "0x181CF8E60", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<AFJMJHOPNGM<OHLBKLDAFGN?>, ONMOMFIOLAG?>? NIBAEFBDPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x1CF45C0", Offset = "0x1CF39C0", VA = "0x181CF45C0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1CF4F10", Offset = "0x1CF4310", VA = "0x181CF4F10", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<AFJMJHOPNGM<MNKAKLAHHBM?>, JOHJOIANCFH?>? ABEIEFIAPPB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x1CF9160", Offset = "0x1CF8560", VA = "0x181CF9160", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1CF6D40", Offset = "0x1CF6140", VA = "0x181CF6D40", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<AFJMJHOPNGM<MNKAKLAHHBM?>>? JHEDHAFKANH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x1CF4B00", Offset = "0x1CF3F00", VA = "0x181CF4B00", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1CF4BC0", Offset = "0x1CF3FC0", VA = "0x181CF4BC0", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<AFJMJHOPNGM<MNKAKLAHHBM?>, JOHJOIANCFH?>? KMLKOBCGNMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1CF8B10", Offset = "0x1CF7F10", VA = "0x181CF8B10", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x1CF7B80", Offset = "0x1CF6F80", VA = "0x181CF7B80", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9ED0", Offset = "0x1CF92D0", VA = "0x181CF9ED0")]
	private BFAIKFKHJCC(bool CHFNKCCFOOI, DALDCDFKDNN MOBBAFLLKOI, bool KOCGCINLNCJ, JPIOHCCBMDN<OHLBKLDAFGN, CDAMOCOJBOI> KPAAJJLDABA, JPIOHCCBMDN<OHLBKLDAFGN, ONMOMFIOLAG> DBKAKLNFFCN, GHHMADPKFFJ LJOKPMONGEA, JPIOHCCBMDN<MNKAKLAHHBM, GIPBCMLHNIB> OFHIKDPPEHH, JPIOHCCBMDN<MNKAKLAHHBM, JOHJOIANCFH> IBPOFBGLBND, string? HGBGJJFOKJO, ENBMMJNFDJI CKKJFNIJPON, AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9890", Offset = "0x1CF8C90", VA = "0x181CF9890")]
	public static BFAIKFKHJCC PIJMMFMEPKL(bool CHFNKCCFOOI, DALDCDFKDNN MOBBAFLLKOI, bool KOCGCINLNCJ, GHHMADPKFFJ LJOKPMONGEA, ENBMMJNFDJI CKKJFNIJPON, AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6590", Offset = "0x1CF5990", VA = "0x181CF6590")]
	private void FILODNFGCKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5090", Offset = "0x1CF4490", VA = "0x181CF5090", Slot = "45")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x1CF49C0", Offset = "0x1CF3DC0", VA = "0x181CF49C0", Slot = "34")]
	[AsyncStateMachine(typeof(DJPOPMCPFKA))]
	public Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA?>>? CDMDPKNGNPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9220", Offset = "0x1CF8620", VA = "0x181CF9220")]
	private (BLPFHPJEIPP?, int)? OBHEOOMIBAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4E20", Offset = "0x1CF4220", VA = "0x181CF4E20")]
	private void DDONNFGLKPF(int PHMGHLMHGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x11A4AF0", Offset = "0x11A3EF0", VA = "0x1811A4AF0")]
	private void PHMIBLGHPLB(int PHMGHLMHGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8770", Offset = "0x1CF7B70", VA = "0x181CF8770")]
	private void KHABJHOGPHO(int IHOFBCBMCMM, int KEOGNAMPGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x1880F10", Offset = "0x1880310", VA = "0x181880F10")]
	private void INOFJMKEHKE(int PHMGHLMHGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x1CF6E00", Offset = "0x1CF6200", VA = "0x181CF6E00")]
	private void GEJALHIJANF(int PHMGHLMHGCE, int LMIPIHNAFHD, JMHHBOHCGHD GIFLIOHDCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4AB0", Offset = "0x1CF3EB0", VA = "0x181CF4AB0")]
	private void CINGCKAKCNA(int IBGLEOLMNIG, int LMIPIHNAFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8E10", Offset = "0x1CF8210", VA = "0x181CF8E10")]
	private void MCPCDICKNFB(int IBGLEOLMNIG, int LMIPIHNAFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7C40", Offset = "0x1CF7040", VA = "0x181CF7C40")]
	private void GOLJBCJJNDL(int PHMGHLMHGCE, int LMIPIHNAFHD, JMHHBOHCGHD GIFLIOHDCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9610", Offset = "0x1CF8A10", VA = "0x181CF9610")]
	private void PDAKCJIMMPB(int PHMGHLMHGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8BDF10", Offset = "0x8BD310", VA = "0x1808BDF10")]
	private void AKEKEFLMIMO(int PHMGHLMHGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9DE0", Offset = "0x1CF91E0", VA = "0x181CF9DE0")]
	private void PPCFOCNPNCD(int PHMGHLMHGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x11A4AF0", Offset = "0x11A3EF0", VA = "0x1811A4AF0")]
	private void ENACBDEPIFH(int PHMGHLMHGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5B90", Offset = "0x1CF4F90", VA = "0x181CF5B90")]
	private void EIEAJAEBOKN(int IHOFBCBMCMM, int KEOGNAMPGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1880F10", Offset = "0x1880310", VA = "0x181880F10")]
	private void OJOFJCDONOM(int PHMGHLMHGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x1CF5FB0", Offset = "0x1CF53B0", VA = "0x181CF5FB0")]
	private void FDDGJOMHDOK(int PHMGHLMHGCE, int LMIPIHNAFHD, OFPJIIECDIB GIFLIOHDCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x1CF80A0", Offset = "0x1CF74A0", VA = "0x181CF80A0")]
	private void HEJODFEIMEM(int IBGLEOLMNIG, int LMIPIHNAFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4C80", Offset = "0x1CF4080", VA = "0x181CF4C80")]
	private void DBEFJFNHHOM(int IBGLEOLMNIG, int LMIPIHNAFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1CF7330", Offset = "0x1CF6730", VA = "0x181CF7330")]
	private void GHCMANGPHFM(int PHMGHLMHGCE, int LMIPIHNAFHD, OFPJIIECDIB GIFLIOHDCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4CD0", Offset = "0x1CF40D0", VA = "0x181CF4CD0")]
	private void DCKKAPDGFAJ(int PHMGHLMHGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8BDF10", Offset = "0x8BD310", VA = "0x1808BDF10")]
	private void BFHKHLAPOCK(int PHMGHLMHGCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8BD0", Offset = "0x1CF7FD0", VA = "0x181CF8BD0", Slot = "35")]
	[AsyncStateMachine(typeof(LNCPDAOGNCL))]
	public Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA?>>? LMNPBGPAMJA(AFJMJHOPNGM<KHHKPFPBNCK> HAIFMEEGDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x1CF81E0", Offset = "0x1CF75E0", VA = "0x181CF81E0", Slot = "36")]
	[AsyncStateMachine(typeof(PBILBHFEJOD))]
	public Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA?>>? HLICFPOKPOM(AFJMJHOPNGM<EOMHPAMKBIG> POFGGOGBDJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8410", Offset = "0x1CF7810", VA = "0x181CF8410", Slot = "37")]
	[AsyncStateMachine(typeof(LGKCHANFJAP))]
	public Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA?>>? IIAAODIJIGP(AFJMJHOPNGM<KHHKPFPBNCK> HAIFMEEGDIN, AFJMJHOPNGM<KHHKPFPBNCK> HKGGBCFBHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x1CF82F0", Offset = "0x1CF76F0", VA = "0x181CF82F0", Slot = "38")]
	[AsyncStateMachine(typeof(FDDEOGCEOLM))]
	public Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA?>>? IEBNLCENOJG(AFJMJHOPNGM<EOMHPAMKBIG> POFGGOGBDJH, AFJMJHOPNGM<EOMHPAMKBIG> HKGGBCFBHAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9040", Offset = "0x1CF8440", VA = "0x181CF9040", Slot = "39")]
	[AsyncStateMachine(typeof(DLENBPNHCHP))]
	public Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA?>>? NKJCOJBGGKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8F20", Offset = "0x1CF8320", VA = "0x181CF8F20", Slot = "40")]
	[AsyncStateMachine(typeof(DKOAJLGJPGL))]
	public Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> NJFEBJDMCEJ(string BOMNJHKKKDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x1CF8CE0", Offset = "0x1CF80E0", VA = "0x181CF8CE0", Slot = "41")]
	[AsyncStateMachine(typeof(LNGALLMNIKA))]
	public Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> MCLCBAJJLKN(AFJMJHOPNGM<KHHKPFPBNCK> HAIFMEEGDIN, string ADLKEGECLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x1CF9760", Offset = "0x1CF8B60", VA = "0x181CF9760", Slot = "42")]
	[AsyncStateMachine(typeof(OBHOOFPHMOI))]
	public Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> PIAHLCJMMOF(AFJMJHOPNGM<EOMHPAMKBIG> POFGGOGBDJH, string ADLKEGECLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4490", Offset = "0x1CF3890", VA = "0x181CF4490", Slot = "43")]
	[AsyncStateMachine(typeof(PLOCAICEIOF))]
	public Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> AHPKFIAPIIJ(AFJMJHOPNGM<KHHKPFPBNCK> HAIFMEEGDIN, GGDJPHKMPIL KHENBEDBKDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x1CF4890", Offset = "0x1CF3C90", VA = "0x181CF4890", Slot = "44")]
	[AsyncStateMachine(typeof(NKGFAKPIECP))]
	public Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> BICJEAALCDG(AFJMJHOPNGM<EOMHPAMKBIG> POFGGOGBDJH, GGDJPHKMPIL KHENBEDBKDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x1CF77B0", Offset = "0x1CF6BB0", VA = "0x181CF77B0")]
	internal void GKPNLJKLNAB(AFJMJHOPNGM<MEBANFLFBPD> PAHKKNONPEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public sealed class EFNHNHHDLMK : NGINKNDGHIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public interface OEPCIILNFKD
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		GIPJGPAPNHP IIHCGCJBEGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<MFODOKIIMIC> MDHGLPABAIJ(CancellationToken HHHPDCGPCML);

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<IKAOCNCDDAM> NDMEAKBFKJH(CancellationToken HHHPDCGPCML);

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<KBGAMAMFNLE> NLILIBNPGCL(CancellationToken HHHPDCGPCML);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct DGBLPKPAMLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<EFNHNHHDLMK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public DALDCDFKDNN circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public MFODOKIIMIC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public IKAOCNCDDAM superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private OEPCIILNFKD <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private IKAOCNCDDAM <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter<MFODOKIIMIC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private TaskAwaiter<IKAOCNCDDAM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private TaskAwaiter<KBGAMAMFNLE> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1CFFF90", Offset = "0x1CFF390", VA = "0x181CFFF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1D00810", Offset = "0x1CFFC10", VA = "0x181D00810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly JKBOJOHMMDN NMIHBALMBGI;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public JKBOJOHMMDN DEEDGALNKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	private EFNHNHHDLMK(JKBOJOHMMDN EBOELGBPMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x1D02600", Offset = "0x1D01A00", VA = "0x181D02600")]
	[AsyncStateMachine(typeof(DGBLPKPAMLF))]
	public static Task<EFNHNHHDLMK> AIPKKCDPFED(DALDCDFKDNN MOBBAFLLKOI, MFODOKIIMIC? BLCBNGIOOOL, IKAOCNCDDAM? OMKFEFIGPOF, CancellationToken HHHPDCGPCML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x1D02760", Offset = "0x1D01B60", VA = "0x181D02760", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct MFJEHKEAJKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct NPAPLHMLDDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<object, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public MFJEHKEAJKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public PEIMDLKNNKH action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private TaskAwaiter<EGECKPFNJNE<object, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x1D0D430", Offset = "0x1D0C830", VA = "0x181D0D430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x1D0D6C0", Offset = "0x1D0CAC0", VA = "0x181D0D6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct APOJOICBDKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<bool, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public LDEMMCHMOMH rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public MFODOKIIMIC circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public IKAOCNCDDAM superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public MFJEHKEAJKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private PEIMDLKNNKH[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private TaskAwaiter<EGECKPFNJNE<object, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x1CF3ED0", Offset = "0x1CF32D0", VA = "0x181CF3ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1CF42B0", Offset = "0x1CF36B0", VA = "0x181CF42B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct MKBPHIEPEFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public MFJEHKEAJKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private TaskAwaiter<EGECKPFNJNE<object, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x1D0A650", Offset = "0x1D09A50", VA = "0x181D0A650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1D0A930", Offset = "0x1D09D30", VA = "0x181D0A930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private readonly HDDIFOJAPMO JLPJFDNLBGK;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8BCA20", Offset = "0x8BBE20", VA = "0x1808BCA20")]
	public MFJEHKEAJKF(HDDIFOJAPMO LCCNCJEPEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A270", Offset = "0x1D09670", VA = "0x181D0A270")]
	[AsyncStateMachine(typeof(NPAPLHMLDDI))]
	private Task<EGECKPFNJNE<object, APEAMGBOOBA>> BJLEFAOBBGB(PEIMDLKNNKH EEEBGEOHFMI, bool CDDKLPOEMLG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A3A0", Offset = "0x1D097A0", VA = "0x181D0A3A0")]
	[AsyncStateMachine(typeof(APOJOICBDKC))]
	public Task<EGECKPFNJNE<bool, APEAMGBOOBA?>>? GINHAAPFDDE(int BGOJIMCDPJG, LDEMMCHMOMH? FKJEHNNJPKB, MFODOKIIMIC? PKLBHCBBHOK, IKAOCNCDDAM? OMKFEFIGPOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A500", Offset = "0x1D09900", VA = "0x181D0A500")]
	[AsyncStateMachine(typeof(MKBPHIEPEFJ))]
	public Task<EGECKPFNJNE<JDDDAABNCFI, APEAMGBOOBA>> GOHOEIHDKHJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public sealed class JEIPPAFPICI : ELJGELLHKOJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly GPLKBNNNOBB MCIOJOCILJC;

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public GPLKBNNNOBB LMNBGIGHGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	private JEIPPAFPICI(GPLKBNNNOBB BEHPACIKMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x1D06E50", Offset = "0x1D06250", VA = "0x181D06E50")]
	public static JEIPPAFPICI BOEOGBDBLGM(DALDCDFKDNN MOBBAFLLKOI, LDEMMCHMOMH ONOOEHGMGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1D07020", Offset = "0x1D06420", VA = "0x181D07020", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface JKHINAONMHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	CCMKADLHPFC BLHDFLICNEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	DAILKDGHDEE JIDIEELLPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	HENHOMDKABN BCMPANDIGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	MDIEALGKACB NBOHNPCDDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	MKDKNKLFJPF EBJIDIIMLLP
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface NLMBDCAJNIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	JKHINAONMHD? EPLAGCEOCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	bool KJBEDCLLEIF
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool BPHBODJMHJL
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<JKHINAONMHD?>? COIEJNDMFEF();

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task ACBGHIPAKNC(DALDCDFKDNN MOBBAFLLKOI, LDEMMCHMOMH ONOOEHGMGOH, MFODOKIIMIC? LCHKIMPFMFD, IKAOCNCDDAM? LPHAKLKNHJF);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[PPBKPNMCKIN("IStaticCV2Instance")]
public interface NGINKNDGHIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	JKBOJOHMMDN DEEDGALNKPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[PPBKPNMCKIN("IStaticEVInstance")]
public interface ELJGELLHKOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	GPLKBNNNOBB LMNBGIGHGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public sealed class HLBAGBKDHGF : NJOJJKGJIPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly DALDCDFKDNN KDPEGNEFKDO;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public DHMCKKKBDFM? OKALMGBNAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1D05F30", Offset = "0x1D05330", VA = "0x181D05F30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	internal HLBAGBKDHGF(DALDCDFKDNN MOBBAFLLKOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public sealed class MDIEALGKACB : DHMCKKKBDFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly NGINKNDGHIG NDFALOLJEGL;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public JNMAFEOHMJA BJLEFAOBBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1D0A1A0", Offset = "0x1D095A0", VA = "0x181D0A1A0", Slot = "4")]
		get
		{
			return default(JNMAFEOHMJA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public PEADCNKPIFC HEJMAPFCOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1D0A0F0", Offset = "0x1D094F0", VA = "0x181D0A0F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public OIFGKAAGFMP<FKEJMIAIMND> IIPLBNNIHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1D0A090", Offset = "0x1D09490", VA = "0x181D0A090", Slot = "6")]
		get
		{
			return default(OIFGKAAGFMP<FKEJMIAIMND>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public JKBOJOHMMDN JAKILFAENMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1D0A150", Offset = "0x1D09550", VA = "0x181D0A150", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	public MDIEALGKACB(NGINKNDGHIG PEBABINGPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A200", Offset = "0x1D09600", VA = "0x181D0A200")]
	public bool MDFJINFCBHM([In] OIFGKAAGFMP<FKEJMIAIMND> GILNCNDAFEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A200", Offset = "0x1D09600", VA = "0x181D0A200", Slot = "8")]
	private bool PEDNBEMLOFO([In] OIFGKAAGFMP<FKEJMIAIMND> GILNCNDAFEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class GDDFMPKOIOF
{
	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x1D04370", Offset = "0x1D03770", VA = "0x181D04370")]
	public static GDNIGEHJANO<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN, GHNFMAMPACM.KOONEAABNAH<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN>> GIMIGGPPAJM([In] this GDNIGEHJANO<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN, GHNFMAMPACM.KOONEAABNAH<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN>> DFCOCKDPCBP)
	{
		return default(GDNIGEHJANO<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN, GHNFMAMPACM.KOONEAABNAH<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public sealed class BNAEKOBLNEJ : FEOJABBBJPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly DALDCDFKDNN KDPEGNEFKDO;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool BPHBODJMHJL
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x1CFB190", Offset = "0x1CFA590", VA = "0x181CFB190", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	internal BNAEKOBLNEJ(DALDCDFKDNN MOBBAFLLKOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class BJMKNCGKMCD : MMJEHLPEICI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct OEJNHNCDOJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public AsyncTaskMethodBuilder<EMNIIMAFOAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public BJMKNCGKMCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private TaskAwaiter<JKHINAONMHD?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DB70", Offset = "0x1D0CF70", VA = "0x181D0DB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x1D0DE20", Offset = "0x1D0D220", VA = "0x181D0DE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly DALDCDFKDNN KDPEGNEFKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private IReadOnlyList<OIFGKAAGFMP<PPGDEHKJPIO>>? HACCFCIHMCE;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public EMNIIMAFOAI? OKALMGBNAPE
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1CFA4E0", Offset = "0x1CF98E0", VA = "0x181CFA4E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool BCLCPJHDMCC
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1CFA220", Offset = "0x1CF9620", VA = "0x181CFA220", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool IMMJPFEJBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1CFA280", Offset = "0x1CF9680", VA = "0x181CFA280", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	internal BJMKNCGKMCD(DALDCDFKDNN MOBBAFLLKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x1CFAB60", Offset = "0x1CF9F60", VA = "0x181CFAB60", Slot = "7")]
	[AsyncStateMachine(typeof(OEJNHNCDOJF))]
	public Task<EMNIIMAFOAI> PHELJLKIILG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x1CFA560", Offset = "0x1CF9960", VA = "0x181CFA560")]
	internal Dictionary<OIFGKAAGFMP<FKEJMIAIMND>, Guid> GPOHKDICJFF(IEnumerable<KLJIPFAKCGO> APPBPLMJLBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x1CFA2E0", Offset = "0x1CF96E0", VA = "0x181CFA2E0")]
	public EGECKPFNJNE<BLIBHMMJKHI, IGBINOOJKPE> DHEIHBKOIMH([In] BLIBHMMJKHI MNJIIKAFHDJ, IEnumerable<KLJIPFAKCGO> NLMHJAEOOOJ, int DLBPIJHNDEI)
	{
		return default(EGECKPFNJNE<BLIBHMMJKHI, IGBINOOJKPE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x1CFAB20", Offset = "0x1CF9F20", VA = "0x181CFAB20")]
	internal static GNLPJKAHBMM MMAJPKOFEFE(ANKILEPMKAO FNJCHFDFKHL, GHHMADPKFFJ LJOKPMONGEA)
	{
		return default(GNLPJKAHBMM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x1CFA020", Offset = "0x1CF9420", VA = "0x181CFA020", Slot = "8")]
	private EGECKPFNJNE<BLIBHMMJKHI, IGBINOOJKPE> ABILMCEEDCC([In] BLIBHMMJKHI MNJIIKAFHDJ, IEnumerable<KLJIPFAKCGO> NLMHJAEOOOJ, int DLBPIJHNDEI)
	{
		return default(EGECKPFNJNE<BLIBHMMJKHI, IGBINOOJKPE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x1CFA8D0", Offset = "0x1CF9CD0", VA = "0x181CFA8D0")]
	[CompilerGenerated]
	internal static GNLPJKAHBMM HHOHGFEGJOA(ANKILEPMKAO KNDKAODOLHA, GHHMADPKFFJ ENMEFGEDBAK)
	{
		return default(GNLPJKAHBMM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public sealed class MKDKNKLFJPF : EMNIIMAFOAI
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class HOOMCPJHNGB
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class IBONFCBGJEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public NKGOABMFHOA spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public IBONFCBGJEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x1D14C40", Offset = "0x1D14040", VA = "0x181D14C40")]
			internal bool NLLBINAIDEJ(EBGIKBNGAMA n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class GPHDCLCCIJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public GPHDCLCCIJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x1D12BB0", Offset = "0x1D11FB0", VA = "0x181D12BB0")]
			internal void DOPEGOLLLHO(EBGIKBNGAMA n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x1D13F00", Offset = "0x1D13300", VA = "0x181D13F00")]
		public static EGECKPFNJNE<EMNIIMAFOAI.OGBEAAGHAKE, IGBINOOJKPE> ENCHDBDKILG(MKDKNKLFJPF LHCHBOKBAPK, [In] EMNIIMAFOAI.DJABFLDBIKJ CNLJFDAGKBD)
		{
			return default(EGECKPFNJNE<EMNIIMAFOAI.OGBEAAGHAKE, IGBINOOJKPE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x1D12CE0", Offset = "0x1D120E0", VA = "0x181D12CE0")]
		internal static EGECKPFNJNE<(BINEOMJKEHB, IOOCBJLDIOD), APEAMGBOOBA> ALNOBHCDAEE(MKDKNKLFJPF LHCHBOKBAPK, IOOCBJLDIOD GHBGIIFOKAO, bool PJCKDEMBJIE, [In] OIFGKAAGFMP<FKEJMIAIMND> BELFMHBJOOO, [In] int? NPCEKIGBNOA, [In] GNLPJKAHBMM? DMDKOELLLJI, [In] GNLPJKAHBMM? JMNJEOJGMAO)
		{
			return default(EGECKPFNJNE<(BINEOMJKEHB, IOOCBJLDIOD), APEAMGBOOBA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x1D13A70", Offset = "0x1D12E70", VA = "0x181D13A70")]
		private static void EBGADLDINJE(bool PJCKDEMBJIE, KLJIPFAKCGO EHOBCDNONMP, BINEOMJKEHB EMNODFBMDIK, [In] OIFGKAAGFMP<FKEJMIAIMND> BELFMHBJOOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x1D14440", Offset = "0x1D13840", VA = "0x181D14440")]
		public static void KEGHMCKNBCB(KDFCDBKMDNP FCJAGFBCEMG, [In] EMNIIMAFOAI.JJAOAEDKLGK PGOCEHAFPHA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly DALDCDFKDNN KDPEGNEFKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly NGINKNDGHIG NDFALOLJEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly ELJGELLHKOJ FFPOMGBCJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly KOCMFODJHFE GCMOPPLKOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly BJMKNCGKMCD OGCBELNPIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private Dictionary<OIFGKAAGFMP<FJBFPEKHLHL>, JAIBKPJGPDB> AGACOJPGLBL;

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x1D0C3F0", Offset = "0x1D0B7F0", VA = "0x181D0C3F0")]
	public MKDKNKLFJPF(DALDCDFKDNN MOBBAFLLKOI, NGINKNDGHIG PEBABINGPIA, ELJGELLHKOJ DCEAJGHOLFJ, BJMKNCGKMCD GDCOKCJOIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x1D0B4D0", Offset = "0x1D0A8D0", VA = "0x181D0B4D0")]
	public JAIBKPJGPDB? IEHGPDMHFIH([In] OIFGKAAGFMP<FJBFPEKHLHL> CEPBGHOOFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x1D0AEC0", Offset = "0x1D0A2C0", VA = "0x181D0AEC0")]
	private void BCPLHFDGLAJ(OIFGKAAGFMP<FJBFPEKHLHL> CEPBGHOOFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1D0B0F0", Offset = "0x1D0A4F0", VA = "0x181D0B0F0")]
	private JAIBKPJGPDB? CPAPKNJEKDE([In] OIFGKAAGFMP<FJBFPEKHLHL> CEPBGHOOFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x1D0B1A0", Offset = "0x1D0A5A0", VA = "0x181D0B1A0")]
	public GHHMADPKFFJ? ENGKHGABCKK([In] OIFGKAAGFMP<FJBFPEKHLHL> CEPBGHOOFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x1D0B070", Offset = "0x1D0A470", VA = "0x181D0B070")]
	public NCFEJMLBHNC? CBBMFJGDINM([In] OIFGKAAGFMP<FKEJMIAIMND> GILNCNDAFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x1D0C2E0", Offset = "0x1D0B6E0", VA = "0x181D0C2E0")]
	private NKGOABMFHOA? OKEDOJKMAIP([In] OIFGKAAGFMP<FKEJMIAIMND> GILNCNDAFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x1D0B2C0", Offset = "0x1D0A6C0", VA = "0x181D0B2C0")]
	private NCFEJMLBHNC? FMNAFADGBFP([In] OIFGKAAGFMP<FKEJMIAIMND> GILNCNDAFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x1D0BAE0", Offset = "0x1D0AEE0", VA = "0x181D0BAE0", Slot = "6")]
	public IEnumerable<GGDJPHKMPIL> KEKIJNECANE(bool CMHLHMBOLJL, bool NOGFCPGMPEJ, bool BOIKPFPMBBO, bool CAEAKJBKLJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1D0AE90", Offset = "0x1D0A290", VA = "0x181D0AE90")]
	public EGECKPFNJNE<EMNIIMAFOAI.OGBEAAGHAKE, IGBINOOJKPE> JDIGJGAODDP([In] EMNIIMAFOAI.DJABFLDBIKJ CNLJFDAGKBD)
	{
		return default(EGECKPFNJNE<EMNIIMAFOAI.OGBEAAGHAKE, IGBINOOJKPE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1D0BC50", Offset = "0x1D0B050", VA = "0x181D0BC50", Slot = "8")]
	public MHMIJBNEDFO MINOGJKKNIF(IEnumerable<KLJIPFAKCGO> NLMHJAEOOOJ)
	{
		return default(MHMIJBNEDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1D0C1C0", Offset = "0x1D0B5C0", VA = "0x181D0C1C0", Slot = "9")]
	public MHMIJBNEDFO NKCIPFHCMMJ()
	{
		return default(MHMIJBNEDFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A9A0", Offset = "0x1D09DA0", VA = "0x181D0A9A0")]
	private PEGECLPIIDO AHBCNABPGNE(ILGHOHLPOAM AGCAECBIAAC, AFJMJHOPNGM<FKEJMIAIMND> KNBMGJBJOJF, IEnumerable<OIFGKAAGFMP<FKEJMIAIMND>> GANDBFLOKFE, IEnumerable<OIFGKAAGFMP<FJBFPEKHLHL>> MEHONFMPEGJ)
	{
		return default(PEGECLPIIDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x1D0AB50", Offset = "0x1D09F50", VA = "0x181D0AB50", Slot = "10")]
	public PEGECLPIIDO AHBCNABPGNE(ILGHOHLPOAM AGCAECBIAAC, AFJMJHOPNGM<FKEJMIAIMND> KNBMGJBJOJF, IEnumerable<OIFGKAAGFMP<FJBFPEKHLHL>> MEHONFMPEGJ, IEnumerable<KLJIPFAKCGO> NLMHJAEOOOJ)
	{
		return default(PEGECLPIIDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x1D0BE40", Offset = "0x1D0B240", VA = "0x181D0BE40")]
	private static IEnumerable<OIFGKAAGFMP<FKEJMIAIMND>> NEKEHPPNHJL(IEnumerable<KLJIPFAKCGO> NLMHJAEOOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x1D0B640", Offset = "0x1D0AA40", VA = "0x181D0B640")]
	private IEnumerable<OIFGKAAGFMP<FJBFPEKHLHL>> JOFBDMHDHBA(IEnumerable<KLJIPFAKCGO> NLMHJAEOOOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1D0B230", Offset = "0x1D0A630", VA = "0x181D0B230", Slot = "11")]
	public List<GCMAGEMPFOJ> ENPMFHIHBFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1D0B070", Offset = "0x1D0A470", VA = "0x181D0B070", Slot = "4")]
	private NCFEJMLBHNC KBHPBHCPEFO([In] OIFGKAAGFMP<FKEJMIAIMND> GILNCNDAFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1D0AF20", Offset = "0x1D0A320", VA = "0x181D0AF20", Slot = "5")]
	private JAIBKPJGPDB BFKKLAJIMHC([In] OIFGKAAGFMP<FJBFPEKHLHL> CEPBGHOOFFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1D0AE90", Offset = "0x1D0A290", VA = "0x181D0AE90", Slot = "7")]
	private EGECKPFNJNE<EMNIIMAFOAI.OGBEAAGHAKE, IGBINOOJKPE> AMONLAKLEGE([In] EMNIIMAFOAI.DJABFLDBIKJ CNLJFDAGKBD)
	{
		return default(EGECKPFNJNE<EMNIIMAFOAI.OGBEAAGHAKE, IGBINOOJKPE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1D0BBD0", Offset = "0x1D0AFD0", VA = "0x181D0BBD0")]
	[CompilerGenerated]
	private LDLKABPOJJK LEHBGIHNBDL(ILHPDGFJEIK AMJKHBKANHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x1D0C380", Offset = "0x1D0B780", VA = "0x181D0C380")]
	[CompilerGenerated]
	private GHHMADPKFFJ PGJNAGFOANJ(OIFGKAAGFMP<FJBFPEKHLHL> AMJKHBKANHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1D0B080", Offset = "0x1D0A480", VA = "0x181D0B080")]
	[CompilerGenerated]
	private NKGOABMFHOA CHFMCMHBBAP(OIFGKAAGFMP<FKEJMIAIMND> AMJKHBKANHA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public sealed class LDLKABPOJJK : GGDJPHKMPIL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct FEBEAOLGHEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<AFJMJHOPNGM<KHHKPFPBNCK>, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public LDLKABPOJJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public OIFGKAAGFMP<FKEJMIAIMND> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public OIFGKAAGFMP<FJBFPEKHLHL> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public AFJMJHOPNGM<MEBANFLFBPD> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private TaskAwaiter<EGECKPFNJNE<AFJMJHOPNGM<KHHKPFPBNCK>, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1D12600", Offset = "0x1D11A00", VA = "0x181D12600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1D12880", Offset = "0x1D11C80", VA = "0x181D12880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct PJNCGLLLJHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<AFJMJHOPNGM<EOMHPAMKBIG>, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public LDLKABPOJJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public OIFGKAAGFMP<FKEJMIAIMND> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public OIFGKAAGFMP<FJBFPEKHLHL> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public AFJMJHOPNGM<MEBANFLFBPD> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter<EGECKPFNJNE<AFJMJHOPNGM<EOMHPAMKBIG>, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1D154A0", Offset = "0x1D148A0", VA = "0x181D154A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1D15720", Offset = "0x1D14B20", VA = "0x181D15720", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly ILHPDGFJEIK MJPHBNIMNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly NGINKNDGHIG NDFALOLJEGL;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public TypeKey KBGLEALBAGC
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5130", Offset = "0x8C4530", VA = "0x1808C5130", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public string ANDGCAIIOCA
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x1D10EC0", Offset = "0x1D102C0", VA = "0x181D10EC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public ILHPDGFJEIK KEBNLJDGONA
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x793920", Offset = "0x792D20", VA = "0x180793920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1D151B0", Offset = "0x1D145B0", VA = "0x181D151B0")]
	public LDLKABPOJJK(ILHPDGFJEIK IODEMODPMGP, NGINKNDGHIG PEBABINGPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x1D14ED0", Offset = "0x1D142D0", VA = "0x181D14ED0", Slot = "6")]
	[AsyncStateMachine(typeof(FEBEAOLGHEM))]
	public Task<EGECKPFNJNE<AFJMJHOPNGM<KHHKPFPBNCK>, APEAMGBOOBA>> JGLDKECPBOG(OIFGKAAGFMP<FKEJMIAIMND> GILNCNDAFEF, OIFGKAAGFMP<FJBFPEKHLHL> CEPBGHOOFFL, AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK, string ADLKEGECLOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x1D15040", Offset = "0x1D14440", VA = "0x181D15040", Slot = "7")]
	[AsyncStateMachine(typeof(PJNCGLLLJHF))]
	public Task<EGECKPFNJNE<AFJMJHOPNGM<EOMHPAMKBIG>, APEAMGBOOBA>> KNDDGNICBLL(OIFGKAAGFMP<FKEJMIAIMND> GILNCNDAFEF, OIFGKAAGFMP<FJBFPEKHLHL> CEPBGHOOFFL, AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK, string ADLKEGECLOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public sealed class ADABIMNIDDN : HDHCEOIMPNG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private readonly ILHPDGFJEIK NELFDJGOCDK;

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private static readonly HashSet<ILHPDGFJEIK> JCOOBJLAFDH;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static readonly HashSet<ILHPDGFJEIK> IJIGNFKLODF;

	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private static readonly HashSet<ILHPDGFJEIK> FNJNKKCNLMA;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public TypeKey EALKNHCDKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1D11F90", Offset = "0x1D11390", VA = "0x181D11F90", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool AIPKJMIDAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1D11F80", Offset = "0x1D11380", VA = "0x181D11F80", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public bool CKJOLBHBBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1D11FE0", Offset = "0x1D113E0", VA = "0x181D11FE0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool BAJADBOJBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1D11F00", Offset = "0x1D11300", VA = "0x181D11F00", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x1D10C50", Offset = "0x1D10050", VA = "0x181D10C50")]
	public bool JGFBPBIFHKF(string PAHKKNONPEO, [Out] PLOFFLCAHOM KLAJIEPGJKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	public ADABIMNIDDN(ILHPDGFJEIK ABLKMCPEJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x1D10AC0", Offset = "0x1D0FEC0", VA = "0x181D10AC0")]
	internal static TypeKey BMEAFAPMBEN(ILHPDGFJEIK KHENBEDBKDI)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x1D10EC0", Offset = "0x1D102C0", VA = "0x181D10EC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct BOKABJBPPKG : DLPCGGHNGEA.LOPGOAMIJMK<PEIMDLKNNKH, JDDDAABNCFI>
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x1D12230", Offset = "0x1D11630", VA = "0x181D12230", Slot = "4")]
	public int PDCMCILBHFM(JDDDAABNCFI IBGLEOLMNIG, PEIMDLKNNKH EEEBGEOHFMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x1D121B0", Offset = "0x1D115B0", VA = "0x181D121B0", Slot = "5")]
	public PEIMDLKNNKH FLOPGMKFDIL(JDDDAABNCFI IBGLEOLMNIG, PEIMDLKNNKH EEEBGEOHFMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x1D121E0", Offset = "0x1D115E0", VA = "0x181D121E0", Slot = "6")]
	public PEIMDLKNNKH JDFNGMNKLOL(JDDDAABNCFI IBGLEOLMNIG, PEIMDLKNNKH EEEBGEOHFMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x1D12150", Offset = "0x1D11550", VA = "0x181D12150", Slot = "7")]
	public IReadOnlyList<PEIMDLKNNKH> CMCGCBFFCGI(JDDDAABNCFI IBGLEOLMNIG, PEIMDLKNNKH EEEBGEOHFMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x1D12100", Offset = "0x1D11500", VA = "0x181D12100", Slot = "8")]
	public PEIMDLKNNKH[] BGKLHILNBBF(JDDDAABNCFI IBGLEOLMNIG, PEIMDLKNNKH EEEBGEOHFMI, int LNBDAKHHFJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1D12130", Offset = "0x1D11530", VA = "0x181D12130", Slot = "9")]
	public bool BNCIPDCMCJO(JDDDAABNCFI IBGLEOLMNIG, PEIMDLKNNKH EEEBGEOHFMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x1D12170", Offset = "0x1D11570", VA = "0x181D12170", Slot = "10")]
	public bool DCBEBCBEAOH(JDDDAABNCFI IBGLEOLMNIG, PEIMDLKNNKH EEEBGEOHFMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x1D121C0", Offset = "0x1D115C0", VA = "0x181D121C0", Slot = "11")]
	public bool GCPKBDDJBNC(JDDDAABNCFI IBGLEOLMNIG, PEIMDLKNNKH EEEBGEOHFMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x1D12210", Offset = "0x1D11610", VA = "0x181D12210", Slot = "12")]
	public bool LPAPMPDPFGG(JDDDAABNCFI IBGLEOLMNIG, PEIMDLKNNKH EEEBGEOHFMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x1D12190", Offset = "0x1D11590", VA = "0x181D12190", Slot = "13")]
	public bool DCJBDHOJNHH(JDDDAABNCFI AICHEBOPGIK, PEIMDLKNNKH EEEBGEOHFMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x1D12110", Offset = "0x1D11510", VA = "0x181D12110", Slot = "14")]
	public bool BIBHDMOGMMN(JDDDAABNCFI IBGLEOLMNIG, PEIMDLKNNKH EEEBGEOHFMI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public abstract class CMPCLJJLGNC : ANAKFIJHLMO
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public JOEKCOJDIOG.CAPBICKDAIL GBHFJIBDCFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1D12250", Offset = "0x1D11650", VA = "0x181D12250", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public abstract PHHIANHDIJE.HADEEJMGIOL KCIIDDBDOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public abstract DALDCDFKDNN.FNGPFKGFIIB JIFHBCDJHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public abstract EFNHNHHDLMK.OEPCIILNFKD CKMKPGBBGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public GHNFMAMPACM.KOONEAABNAH<MKGDFCJGGMN, PEIMDLKNNKH, DALDCDFKDNN> DNLCPNKJHJI
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1D122A0", Offset = "0x1D116A0", VA = "0x181D122A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public abstract LEGBEOMAGOJ EGJFHKAJEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public abstract IOGOMBHCNGB JMBGOJJIGJH
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public abstract BJBPCCCAHCK KKPJGLELEBI
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public abstract FBPLGJIHNJL EOMAHCFKECO
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public abstract AGLFJDOBGND PKOFDGKMNAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	protected CMPCLJJLGNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public sealed class GPCBBEEDPIP : PEADCNKPIFC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct CNLJCIPAFEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<object, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public GPCBBEEDPIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public PEIMDLKNNKH action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private TaskAwaiter<EGECKPFNJNE<object, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x1D122F0", Offset = "0x1D116F0", VA = "0x181D122F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x1D12590", Offset = "0x1D11990", VA = "0x181D12590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct HPGPBHLBFMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public AsyncTaskMethodBuilder<EGECKPFNJNE<BGOBFOFGNEB, APEAMGBOOBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public GPCBBEEDPIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public IReadOnlyList<PEIMDLKNNKH> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private TaskAwaiter<EGECKPFNJNE<object, APEAMGBOOBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x1D14850", Offset = "0x1D13C50", VA = "0x181D14850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1D14BD0", Offset = "0x1D13FD0", VA = "0x181D14BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly HDDIFOJAPMO JLPJFDNLBGK;

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x7967D0", Offset = "0x795BD0", VA = "0x1807967D0")]
	public GPCBBEEDPIP(HDDIFOJAPMO LCCNCJEPEIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x1D12950", Offset = "0x1D11D50", VA = "0x181D12950")]
	[AsyncStateMachine(typeof(CNLJCIPAFEM))]
	private Task<EGECKPFNJNE<object, APEAMGBOOBA>> BJLEFAOBBGB(PEIMDLKNNKH EEEBGEOHFMI, bool CDDKLPOEMLG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x1D12A80", Offset = "0x1D11E80", VA = "0x181D12A80", Slot = "4")]
	[AsyncStateMachine(typeof(HPGPBHLBFMN))]
	public Task<EGECKPFNJNE<BGOBFOFGNEB, APEAMGBOOBA>> GLGKPIPCOKK(IReadOnlyList<PEIMDLKNNKH> HDLHNKOGPHF, bool CDDKLPOEMLG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct FLPMBNFFCAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	internal IAKLEJCIEOM<KMGFKFEFILG, PEIMDLKNNKH, OLFIABPAFGJ> NELFDJGOCDK;

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x1D042B0", Offset = "0x1D036B0", VA = "0x181D042B0")]
	private FLPMBNFFCAO([In] IAKLEJCIEOM<KMGFKFEFILG, PEIMDLKNNKH, OLFIABPAFGJ> DKHBMKOPIAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x1D128F0", Offset = "0x1D11CF0", VA = "0x181D128F0")]
	public static FLPMBNFFCAO PIJMMFMEPKL()
	{
		return default(FLPMBNFFCAO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class DBMOMFEEELG
{
	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
	public static IAKLEJCIEOM<KMGFKFEFILG, PEIMDLKNNKH, OLFIABPAFGJ> MBKMANMAECC(this FLPMBNFFCAO LHCHBOKBAPK)
	{
		return default(IAKLEJCIEOM<KMGFKFEFILG, PEIMDLKNNKH, OLFIABPAFGJ>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct OLFIABPAFGJ : POICDENFELB.JLADOGCNHGF<KMGFKFEFILG, PEIMDLKNNKH>
{
	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x1D152B0", Offset = "0x1D146B0", VA = "0x181D152B0", Slot = "5")]
	public PEIMDLKNNKH LFGPDFHNFNN(KMGFKFEFILG[] MMFFNLNIEHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x131AA70", Offset = "0x1319E70", VA = "0x18131AA70")]
	public int DGNMCEEMEGM([In] KMGFKFEFILG DCOAHGHIADK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x131AA70", Offset = "0x1319E70", VA = "0x18131AA70", Slot = "4")]
	private int FNKEPBNCMKK([In] KMGFKFEFILG NEDJGBBPLAE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct LGIAPJGPHBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	internal OCGDFHJCFNJ<HJPBJPNCHAD, PEIMDLKNNKH, LBHBIMLNGIA> NELFDJGOCDK;

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x1D042B0", Offset = "0x1D036B0", VA = "0x181D042B0")]
	private LGIAPJGPHBH([In] OCGDFHJCFNJ<HJPBJPNCHAD, PEIMDLKNNKH, LBHBIMLNGIA> GPICKIAFLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x1D15250", Offset = "0x1D14650", VA = "0x181D15250")]
	public static LGIAPJGPHBH PIJMMFMEPKL()
	{
		return default(LGIAPJGPHBH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class IKBJHAOIGMK
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x872DE0", Offset = "0x8721E0", VA = "0x180872DE0")]
	public static OCGDFHJCFNJ<HJPBJPNCHAD, PEIMDLKNNKH, LBHBIMLNGIA> MBKMANMAECC(this LGIAPJGPHBH LHCHBOKBAPK)
	{
		return default(OCGDFHJCFNJ<HJPBJPNCHAD, PEIMDLKNNKH, LBHBIMLNGIA>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct LBHBIMLNGIA : LHJMDCAAFGG.MLDEBNHELCH<HJPBJPNCHAD, PEIMDLKNNKH>
{
	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x131AA70", Offset = "0x1319E70", VA = "0x18131AA70")]
	public int MOOFJHJGBKO([In] HJPBJPNCHAD DCOAHGHIADK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x1D14CE0", Offset = "0x1D140E0", VA = "0x181D14CE0", Slot = "5")]
	public PEIMDLKNNKH NNGKCMELOPJ(HJPBJPNCHAD[] LCBOCFJGGPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x131AA70", Offset = "0x1319E70", VA = "0x18131AA70", Slot = "4")]
	private int HMNNPGLOCIP([In] HJPBJPNCHAD DCOAHGHIADK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface LEGBEOMAGOJ
{
	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DPPIKONPGDO([In] EGECKPFNJNE<JDDDAABNCFI, IGBINOOJKPE> APCONDCGDJA);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class MIOBBOCHBBB
{
	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x26F3630", Offset = "0x26F2A30", VA = "0x1826F3630")]
	public static bool DPPIKONPGDO<TOk, TErr>(this LEGBEOMAGOJ LHCHBOKBAPK, [In] EGECKPFNJNE<TOk, TErr> APCONDCGDJA) where TOk : notnull where TErr : notnull, IGBINOOJKPE
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public interface IOGOMBHCNGB
{
	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	BNEDKEFLHKF LGLJDLKCIDF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public interface BJBPCCCAHCK
{
	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOANIEENNCJ BEJBMOLMJJH(int CCIEGNIEGMC);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public interface DDAMIIPEDJO
{
	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	string DACJMNMHBIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public interface FMDOLJLNOKL
{
	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FGHGHEPFDNE? IPIHOPIKMAJ(AFJMJHOPNGM<MEBANFLFBPD> IAHEFEMONNK);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public interface CECLBDIAPNM
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	string DACJMNMHBIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public interface FGHGHEPFDNE
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	string DACJMNMHBIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CECLBDIAPNM? LPAOMMLCKNH(AFJMJHOPNGM<KHHKPFPBNCK> HAIFMEEGDIN);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DDAMIIPEDJO? DCNPCEOGKFD(AFJMJHOPNGM<EOMHPAMKBIG> POFGGOGBDJH);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public interface FBPLGJIHNJL
{
	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> BFEGMGBKCCJ(string PAHKKNONPEO, string AOGDICEMNLI);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public interface AGLFJDOBGND
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FMDOLJLNOKL? FHOIMMLHIKD([In] OIFGKAAGFMP<PPGDEHKJPIO> DEBHFMJBDEH);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public sealed class ABFOFCGHKCM
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct HEGPBKOHIND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public int GOBEDCIKOGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public MFODOKIIMIC? FAFNIKACLLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public MFODOKIIMIC? MFALGNPOINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public readonly List<PEIMDLKNNKH> BABBNBICAPG;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x1D12C90", Offset = "0x1D12090", VA = "0x181D12C90")]
		private HEGPBKOHIND(int FGBBDGJMFEH, MFODOKIIMIC? COAJPEGIMKK, MFODOKIIMIC? JNLAIDHDKNF, List<PEIMDLKNNKH> HDLHNKOGPHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x1D12BD0", Offset = "0x1D11FD0", VA = "0x181D12BD0")]
		public static HEGPBKOHIND PIJMMFMEPKL()
		{
			return default(HEGPBKOHIND);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private readonly JPGGFGAALLI<HEGPBKOHIND> CDMAEHCHAGG;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public static ABFOFCGHKCM OKALMGBNAPE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x1D10280", Offset = "0x1D0F680", VA = "0x181D10280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool PIMJECJFKCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7E0B90", Offset = "0x7DFF90", VA = "0x1807E0B90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x97ED30", Offset = "0x97E130", VA = "0x18097ED30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x1D101C0", Offset = "0x1D0F5C0", VA = "0x181D101C0")]
	public void BHBEGEAOHLH(JKBOJOHMMDN JNLAIDHDKNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x1D102D0", Offset = "0x1D0F6D0", VA = "0x181D102D0")]
	public void KEOPHBBMDGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x1D105D0", Offset = "0x1D0F9D0", VA = "0x181D105D0")]
	private static string? PBOFLKHLJDN([In] HEGPBKOHIND MEHCNMCKAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x1D10A10", Offset = "0x1D0FE10", VA = "0x181D10A10")]
	public ABFOFCGHKCM()
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
