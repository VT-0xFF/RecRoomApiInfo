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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1D6E720", Offset = "0x1D6D520", VA = "0x181D6E720")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D3170", VA = "0x1807D4370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class BODFBMBPPDB : IDisposable, OBMAJDJMDEP, DBFHOKONHHH, ECFELILMBLG, POFHMOEKJAI
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class GOLAGPGJHPA : DGDHAKMIEGP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int HGNDGDOEGJF
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1D603F0", Offset = "0x1D5F1F0", VA = "0x181D603F0", Slot = "5")]
		public FBDFODNOFNG IOGOHNCJBAF(LOCEGJFBBLM.DPBEEFGICNA DNHMNAAINOD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void KGPJKJJAJNA();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void FEMGAEICLOH();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1D60370", Offset = "0x1D5F170", VA = "0x181D60370", Slot = "13")]
		public virtual void FIPNDFIAHNG(BODFBMBPPDB DBCGMJGIMKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1D60540", Offset = "0x1D5F340", VA = "0x181D60540", Slot = "14")]
		public virtual void JNCOLNCHJCH(BODFBMBPPDB DBCGMJGIMKF, BJFPGMKAPEG ENHEBPDFNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		protected GOLAGPGJHPA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface DGDHAKMIEGP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int HGNDGDOEGJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FBDFODNOFNG IOGOHNCJBAF(LOCEGJFBBLM.DPBEEFGICNA DNHMNAAINOD);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void KGPJKJJAJNA();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void FEMGAEICLOH();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FIPNDFIAHNG(BODFBMBPPDB DBCGMJGIMKF);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void JNCOLNCHJCH(BODFBMBPPDB DBCGMJGIMKF, BJFPGMKAPEG ENHEBPDFNME);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct DLHGGCIJBEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly GINCPANCIHD<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB, LKOCHJGKODG.CNIKFMHFKKB<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB>> AJLKPLFIPKM;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1D5DDE0", Offset = "0x1D5CBE0", VA = "0x181D5DDE0")]
		internal DLHGGCIJBEJ(GINCPANCIHD<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB, LKOCHJGKODG.CNIKFMHFKKB<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB>> HBHLLIKFPMD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class OHLOLIFHDFI : LKOCHJGKODG.CNIKFMHFKKB<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly OHLOLIFHDFI AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private OHLOLIFHDFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA31640", Offset = "0xA30440", VA = "0x180A31640", Slot = "4")]
		public KDMILAKAAFH AJEDKLCPAHO(BJFPGMKAPEG CNFBJPGPBBJ)
		{
			return default(KDMILAKAAFH);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1D6E7A0", Offset = "0x1D6D5A0", VA = "0x181D6E7A0", Slot = "5")]
		public void FIPNDFIAHNG(BODFBMBPPDB ADCDJFADKCK, BJFPGMKAPEG ENHEBPDFNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1D6E8B0", Offset = "0x1D6D6B0", VA = "0x181D6E8B0", Slot = "6")]
		public void JNCOLNCHJCH(BODFBMBPPDB ADCDJFADKCK, BJFPGMKAPEG ENHEBPDFNME)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct AIOLNGEEJCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public BOCBPIMJLDE<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB, LKOCHJGKODG.CNIKFMHFKKB<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB>> AJLKPLFIPKM;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1D546F0", Offset = "0x1D534F0", VA = "0x181D546F0")]
		internal AIOLNGEEJCN(BOCBPIMJLDE<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB, LKOCHJGKODG.CNIKFMHFKKB<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB>> HBHLLIKFPMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1D546A0", Offset = "0x1D534A0", VA = "0x181D546A0")]
		public static AIOLNGEEJCN KJKFMOENPNA()
		{
			return default(AIOLNGEEJCN);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct HIGPILFOHKE : EIHKPAGLLNA.ECNBCHMOLIL<NBIFPHEEBEM, BJFPGMKAPEG, BODFBMBPPDB>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct KHOGMIHGOMA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public BODFBMBPPDB receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public BJFPGMKAPEG action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public HIGPILFOHKE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x1D651B0", Offset = "0x1D63FB0", VA = "0x181D651B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1D65390", Offset = "0x1D64190", VA = "0x181D65390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA31640", Offset = "0xA30440", VA = "0x180A31640", Slot = "4")]
		public HIGDJMOGOKB<NBIFPHEEBEM> AGJKOHOLKPN(BODFBMBPPDB KKEOLOLGJJJ)
		{
			return default(HIGDJMOGOKB<NBIFPHEEBEM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1D61210", Offset = "0x1D60010", VA = "0x181D61210", Slot = "5")]
		[AsyncStateMachine(typeof(KHOGMIHGOMA))]
		public Task<FBEPHKHKLJE<object, BEPKJMJJJMM>> DCICANPEFKC(BODFBMBPPDB KKEOLOLGJJJ, BJFPGMKAPEG ENHEBPDFNME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1D61340", Offset = "0x1D60140", VA = "0x181D61340", Slot = "6")]
		public BJFPGMKAPEG[] EKIPGNNFKFC(BODFBMBPPDB KKEOLOLGJJJ)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CAJPANGNEHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<bool, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public BODFBMBPPDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public KHOGAKDFAOE rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public PBEFNMAHMLC circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public PGADOMLEMBK superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter<FBEPHKHKLJE<bool, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D010", Offset = "0x1D5BE10", VA = "0x181D5D010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D290", Offset = "0x1D5C090", VA = "0x181D5D290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct DFOKDJDGNNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<bool, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public BODFBMBPPDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter<FBEPHKHKLJE<bool, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D7B0", Offset = "0x1D5C5B0", VA = "0x181D5D7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1D5DA40", Offset = "0x1D5C840", VA = "0x181D5DA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct GFNHEAOGGEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public BODFBMBPPDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FD60", Offset = "0x1D5EB60", VA = "0x181D5FD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FF40", Offset = "0x1D5ED40", VA = "0x181D5FF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct ABNHGCMACCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public BODFBMBPPDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public BJFPGMKAPEG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1D53E70", Offset = "0x1D52C70", VA = "0x181D53E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1D54060", Offset = "0x1D52E60", VA = "0x181D54060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MDACBPGFBAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public BODFBMBPPDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<FBEPHKHKLJE<bool, BEPKJMJJJMM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1D66550", Offset = "0x1D65350", VA = "0x181D66550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1D66D40", Offset = "0x1D65B40", VA = "0x181D66D40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly HIGDJMOGOKB<NBIFPHEEBEM> HNHIIEHLFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly DLHGGCIJBEJ DANFFAKHCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly BDLFGAKBPMJ HEGMOHNIONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly GOENGJALEIP HMPDKPOBGBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly IEMHDKADMOP CKKLAGFGFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly CDDENKAFMJG.HDDBCPBDCJP PBJAPHDEHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFF8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly OJEFGDMOCAC MAICNMFCBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1000")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly BCEDGGBFDNC MMNNGCEFIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1008")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly NBFFMEGJPNK PKPPJBOJHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1010")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly EMILAHPBFLO ABPBMDMOHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1018")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private DECBJPKGHCI GCPCBMLBOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1028")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private PKAFDBOAGHK LOPNENJMBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1048")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly BDLFGAKBPMJ.CBLBOIGCIMD MKEIMHGKLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1050")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly MBPGECPHPPC HLGLCGDLJLK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public BDLFGAKBPMJ LBGLHMKHEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C090", Offset = "0x1D5AE90", VA = "0x181D5C090")]
		get
		{
			return default(BDLFGAKBPMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal DGDHAKMIEGP KPGDGDCEJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1D5B0A0", Offset = "0x1D59EA0", VA = "0x181D5B0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal FBDFODNOFNG KFCNCBOPMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C0A0", Offset = "0x1D5AEA0", VA = "0x181D5C0A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C400", Offset = "0x1D5B200", VA = "0x181D5C400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool GEDFHPAGPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1D5B980", Offset = "0x1D5A780", VA = "0x181D5B980")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C1E0", Offset = "0x1D5AFE0", VA = "0x181D5C1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public DJNPAJIEAJG JFHCEELDNKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C740", Offset = "0x1D5B540", VA = "0x181D5C740", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public AMBHOMEMAJO AMILDDKCLII
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C760", Offset = "0x1D5B560", VA = "0x181D5C760", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JEGOOMBHNCI EEIDBNEGMBG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C770", Offset = "0x1D5B570", VA = "0x181D5C770", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public GFPHBHPBJGO ILLFHBHFGHD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C750", Offset = "0x1D5B550", VA = "0x181D5C750", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private MPILBLNPGJG? GMCDAMJHEGB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C0B0", Offset = "0x1D5AEB0", VA = "0x181D5C0B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private EKEPFKCLHFA? AIIGGFEKCNL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1D5AE60", Offset = "0x1D59C60", VA = "0x181D5AE60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C420", Offset = "0x1D5B220", VA = "0x181D5C420")]
	private BODFBMBPPDB(IEMHDKADMOP BBHBOBFDCMB, HIGDJMOGOKB<NBIFPHEEBEM> PMIHOHEADPP, [In] DLHGGCIJBEJ BOALOCJEPLJ, [In] BDLFGAKBPMJ MPEOGFCLGNK, [In] GOENGJALEIP GEIILOMMBLD, FBDFODNOFNG GHAPNLANMJI, [In] CDDENKAFMJG.HDDBCPBDCJP DNHDGLCNDDM, BDLFGAKBPMJ.CBLBOIGCIMD INDBBMHLEAG, MBPGECPHPPC CFKONHFKPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1D5BF30", Offset = "0x1D5AD30", VA = "0x181D5BF30")]
	public static BODFBMBPPDB KJKFMOENPNA(IEMHDKADMOP DNHMNAAINOD, BDLFGAKBPMJ.MLEMANMNNID BLJLFKDDFNL, HIGDJMOGOKB<NBIFPHEEBEM> PMIHOHEADPP, HIGDJMOGOKB<KLKJEIMLOBN> CALCHJKGMHC, DJONIENCBMN LKEMBNMEKNK, MLHJOGNBDLF OLJGKDNPLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D5BC50", Offset = "0x1D5AA50", VA = "0x181D5BC50")]
	public static BODFBMBPPDB KJKFMOENPNA(IEMHDKADMOP BBHBOBFDCMB, [In] BDLFGAKBPMJ MPEOGFCLGNK, [In] GOENGJALEIP GEIILOMMBLD, HIGDJMOGOKB<NBIFPHEEBEM> PMIHOHEADPP, HIGDJMOGOKB<KLKJEIMLOBN> CALCHJKGMHC, DJONIENCBMN LKEMBNMEKNK, MLHJOGNBDLF OLJGKDNPLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B0F0", Offset = "0x1D59EF0", VA = "0x181D5B0F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B990", Offset = "0x1D5A790", VA = "0x181D5B990")]
	[AsyncStateMachine(typeof(CAJPANGNEHN))]
	internal Task<FBEPHKHKLJE<bool, BEPKJMJJJMM>> KCMOPCLNAJH(KHOGAKDFAOE HHFGPPAPFJC, PBEFNMAHMLC MBNJMAICHBF, PGADOMLEMBK KOLMPBPLBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B790", Offset = "0x1D5A590", VA = "0x181D5B790")]
	[AsyncStateMachine(typeof(DFOKDJDGNNL))]
	public Task<FBEPHKHKLJE<bool, BEPKJMJJJMM>> HCKAAJINGFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1D5BAF0", Offset = "0x1D5A8F0", VA = "0x181D5BAF0")]
	[AsyncStateMachine(typeof(GFNHEAOGGEH))]
	public Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> KEEKCKLKMLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1D5C1F0", Offset = "0x1D5AFF0", VA = "0x181D5C1F0")]
	internal void NMNEFNPOCCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B900", Offset = "0x1D5A700", VA = "0x181D5B900")]
	internal OPMELBICLMG<BJFPGMKAPEG> IGOEBJBJLJJ([In] PGHLBGFMJIE EFJKDOFPFMJ)
	{
		return default(OPMELBICLMG<BJFPGMKAPEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1D5BBE0", Offset = "0x1D5A9E0", VA = "0x181D5BBE0")]
	internal bool KGHNNBCBEOF([In] PGHLBGFMJIE EFJKDOFPFMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B880", Offset = "0x1D5A680", VA = "0x181D5B880")]
	internal OPMELBICLMG<BJFPGMKAPEG> HGGHBJONEAD([In] LHMMGAHDLML ANIENHLBADO)
	{
		return default(OPMELBICLMG<BJFPGMKAPEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1D5AF90", Offset = "0x1D59D90", VA = "0x181D5AF90")]
	[AsyncStateMachine(typeof(ABNHGCMACCK))]
	internal Task<FBEPHKHKLJE<object, BEPKJMJJJMM>> AMFPILJNGNA(BJFPGMKAPEG ENHEBPDFNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B2E0", Offset = "0x1D5A0E0", VA = "0x181D5B2E0")]
	private BJFPGMKAPEG[] EKIPGNNFKFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1D5B670", Offset = "0x1D5A470", VA = "0x181D5B670")]
	[AsyncStateMachine(typeof(MDACBPGFBAO))]
	public Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> GJGIOFHOAOH(Guid OAOPNFJAJDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ELNNNGCKIEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x25CAEA0", Offset = "0x25C9CA0", VA = "0x1825CAEA0")]
	public static GLLPPGCHFOG<(TPrev?, BODFBMBPPDB?), EKEPFKCLHFA> NLGIFACOKNM<TPrev>([In] this GLLPPGCHFOG<TPrev, BODFBMBPPDB> CNFBJPGPBBJ)
	{
		return default(GLLPPGCHFOG<(TPrev, BODFBMBPPDB), EKEPFKCLHFA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x25CAC80", Offset = "0x25C9A80", VA = "0x1825CAC80")]
	public static GLLPPGCHFOG<TPrev?, BODFBMBPPDB?> JGPLFHDJMGK<TPrev>([In] this GLLPPGCHFOG<TPrev, BODFBMBPPDB> CNFBJPGPBBJ)
	{
		return default(GLLPPGCHFOG<TPrev, BODFBMBPPDB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class FFADMJNPOOE<TData> : KOAMPGHKKDA, BJHMKOMGNHJ, LNKCFDGMPAP where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly ANCACCNALNI<HBKIGHMDJGP>? NDFCCNGOJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly string EPAABOBMNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly TData GHKHBJDIPKA;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ANCACCNALNI<HBKIGHMDJGP>? NGFJFMIODAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1EFD540", Offset = "0x1EFC340", VA = "0x181EFD540", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7AD190", Offset = "0x7ABF90", VA = "0x1807AD190", Slot = "7")]
	public override string EMIBBFOKDML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x35C1870", Offset = "0x35C0670", VA = "0x1835C1870")]
	internal FFADMJNPOOE([In] ANCACCNALNI<HBKIGHMDJGP>? LDGOOHMBDKD, HIGDJMOGOKB<FOJMALNNKMD>? IAPLPBIDDNE, IOKind? FJPOMKKONLE, string EMKENBOOEOH, [In] TData OMHIFBJFAGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BNMHHDBOHOD
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1D5AA80", Offset = "0x1D59880", VA = "0x181D5AA80")]
	public static FBEPHKHKLJE<ANGHONGPLDK, BJHMKOMGNHJ> EEIKIKCENPI([In] this AIJGEFOINLN<KGONDHDJNMH> CMBGCICAPGJ)
	{
		return default(FBEPHKHKLJE<ANGHONGPLDK, BJHMKOMGNHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x24EB080", Offset = "0x24E9E80", VA = "0x1824EB080")]
	public static FBEPHKHKLJE<TOk, BJHMKOMGNHJ> AKMBMCJLEGI<TOk>([In] this FBEPHKHKLJE<TOk, BJHMKOMGNHJ> CNFBJPGPBBJ, [In] ANCACCNALNI<HBKIGHMDJGP>? LDGOOHMBDKD, HIGDJMOGOKB<FOJMALNNKMD>? IAPLPBIDDNE, IOKind? FJPOMKKONLE, string EMKENBOOEOH) where TOk : notnull
	{
		return default(FBEPHKHKLJE<TOk, BJHMKOMGNHJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface IEMHDKADMOP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	DBFGDHNMHGG.HECNBPNPPBP MKBCNHOGBCK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	LOCEGJFBBLM.DPBEEFGICNA NFIJHMPLLIP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	BODFBMBPPDB.DGDHAKMIEGP CMCBMMHOJEM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	EMHHJOLCDPN.NFCLJJJDKMJ CADIJIAIGJD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	LKOCHJGKODG.CNIKFMHFKKB<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB> MLOCDHLGJIL
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	INFNPELKBBP KENDMBKJAAD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GCOCIIGIFEF PNCAFKCNOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	OJFEDBNCEOP PNCHCBNKJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	BOAAANKCKNK LFLGMNANANG
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	IDJFBGHMOGA OLGNNEDBNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class JFAJGILOPCL
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1D63220", Offset = "0x1D62020", VA = "0x181D63220")]
	public static BJFPGMKAPEG DPLJMMLPJGK(this BJFPGMKAPEG CNFBJPGPBBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1D63330", Offset = "0x1D62130", VA = "0x181D63330")]
	public static BJFPGMKAPEG LCNHDFHOKMI(this HMOMHDLEBBK CNFBJPGPBBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct HMOMHDLEBBK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct DKIHAJNPHMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public BODFBMBPPDB root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HMOMHDLEBBK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1D5DAB0", Offset = "0x1D5C8B0", VA = "0x181D5DAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1D5DD70", Offset = "0x1D5CB70", VA = "0x181D5DD70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ByteString DFPHMDCMPIO;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A60", Offset = "0x8D3860", VA = "0x1808D4A60")]
	private HMOMHDLEBBK(ByteString NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1D61470", Offset = "0x1D60270", VA = "0x181D61470")]
	public static BJFPGMKAPEG BCNFGAKHMDJ(ByteString NKKIECLCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1D61530", Offset = "0x1D60330", VA = "0x181D61530")]
	public static IDHAJELEGOB<KDMILAKAAFH, HMOMHDLEBBK> NNLAPPIBECG(BJFPGMKAPEG OOJOMJIGCBD)
	{
		return default(IDHAJELEGOB<KDMILAKAAFH, HMOMHDLEBBK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1D61360", Offset = "0x1D60160", VA = "0x181D61360")]
	[AsyncStateMachine(typeof(DKIHAJNPHMH))]
	public static Task<FBEPHKHKLJE<object, BEPKJMJJJMM>> AMFPILJNGNA(BODFBMBPPDB ADCDJFADKCK, HMOMHDLEBBK CNFBJPGPBBJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct BNFPKFAAKLE
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1D5A8F0", Offset = "0x1D596F0", VA = "0x181D5A8F0")]
	public static BJFPGMKAPEG BCNFGAKHMDJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1D5AA10", Offset = "0x1D59810", VA = "0x181D5AA10")]
	public static IDHAJELEGOB<KDMILAKAAFH, BNFPKFAAKLE> NNLAPPIBECG(BJFPGMKAPEG OOJOMJIGCBD)
	{
		return default(IDHAJELEGOB<KDMILAKAAFH, BNFPKFAAKLE>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1D5A990", Offset = "0x1D59790", VA = "0x181D5A990")]
	public static FBEPHKHKLJE<JEGFFGGMBEH, AGGGGDAGIKE> FPLCDEOCDCK(BODFBMBPPDB ADCDJFADKCK, [In] BNFPKFAAKLE CNFBJPGPBBJ)
	{
		return default(FBEPHKHKLJE<JEGFFGGMBEH, AGGGGDAGIKE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct AKHOLHGFILM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct FHNEEIHOBPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, AGGGGDAGIKE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public BODFBMBPPDB root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AKHOLHGFILM self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private FBEPHKHKLJE<JEGFFGGMBEH, AGGGGDAGIKE> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1D5EF00", Offset = "0x1D5DD00", VA = "0x181D5EF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F270", Offset = "0x1D5E070", VA = "0x181D5F270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly KHOGAKDFAOE? NHODOBEJMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly PBEFNMAHMLC? FFEKOHOIKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly PGADOMLEMBK? AJLMIBPNFNE;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1A5D790", Offset = "0x1A5C590", VA = "0x181A5D790")]
	private AKHOLHGFILM(KHOGAKDFAOE? HHFGPPAPFJC, PBEFNMAHMLC? MBNJMAICHBF, PGADOMLEMBK? KOLMPBPLBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1D54990", Offset = "0x1D53790", VA = "0x181D54990")]
	public static BJFPGMKAPEG? BCNFGAKHMDJ(KHOGAKDFAOE? HHFGPPAPFJC, PBEFNMAHMLC? MBNJMAICHBF, PGADOMLEMBK? KOLMPBPLBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1D54A90", Offset = "0x1D53890", VA = "0x181D54A90")]
	public static IDHAJELEGOB<KDMILAKAAFH, AKHOLHGFILM> NNLAPPIBECG(BJFPGMKAPEG OOJOMJIGCBD)
	{
		return default(IDHAJELEGOB<KDMILAKAAFH, AKHOLHGFILM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1D54850", Offset = "0x1D53650", VA = "0x181D54850")]
	[AsyncStateMachine(typeof(FHNEEIHOBPM))]
	public static Task<FBEPHKHKLJE<JEGFFGGMBEH, AGGGGDAGIKE>> AMFPILJNGNA(BODFBMBPPDB ADCDJFADKCK, AKHOLHGFILM CNFBJPGPBBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct ALHLECFMDJP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct HPAOLNIMBKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<OBGAFDCEFFC, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public ALHLECFMDJP self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public BODFBMBPPDB root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private FBEPHKHKLJE<OBGAFDCEFFC, BEPKJMJJJMM> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private FBEPHKHKLJE<object, LNKCFDGMPAP>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private FBEPHKHKLJE<object, LNKCFDGMPAP> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private FBEPHKHKLJE<object, LNKCFDGMPAP>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x1D615E0", Offset = "0x1D603E0", VA = "0x181D615E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1D61A50", Offset = "0x1D60850", VA = "0x181D61A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly IReadOnlyList<BJFPGMKAPEG> OGMPLPJCIEC;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A60", Offset = "0x8D3860", VA = "0x1808D4A60")]
	private ALHLECFMDJP(IReadOnlyList<BJFPGMKAPEG> IDENKDINEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1D54CE0", Offset = "0x1D53AE0", VA = "0x181D54CE0")]
	public static BJFPGMKAPEG BCNFGAKHMDJ(IReadOnlyList<BJFPGMKAPEG> IDENKDINEDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1D54DA0", Offset = "0x1D53BA0", VA = "0x181D54DA0")]
	public static IDHAJELEGOB<KDMILAKAAFH, ALHLECFMDJP> NNLAPPIBECG(BJFPGMKAPEG OOJOMJIGCBD)
	{
		return default(IDHAJELEGOB<KDMILAKAAFH, ALHLECFMDJP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1D54BA0", Offset = "0x1D539A0", VA = "0x181D54BA0")]
	[AsyncStateMachine(typeof(HPAOLNIMBKJ))]
	public static Task<FBEPHKHKLJE<OBGAFDCEFFC, BEPKJMJJJMM>> AMFPILJNGNA(BODFBMBPPDB ADCDJFADKCK, ALHLECFMDJP CNFBJPGPBBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct LHMMGAHDLML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int DDMEKBICEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int CCEAOHGDFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly byte[] GHKHBJDIPKA;

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x17CDEA0", Offset = "0x17CCCA0", VA = "0x1817CDEA0")]
	private LHMMGAHDLML(int BPFMGMBDOBA, int ENPOKNEMOMH, byte[] OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1D654B0", Offset = "0x1D642B0", VA = "0x181D654B0")]
	public static BJFPGMKAPEG BCNFGAKHMDJ(int BPFMGMBDOBA, int ENPOKNEMOMH, ByteString OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1D65590", Offset = "0x1D64390", VA = "0x181D65590")]
	public static BJFPGMKAPEG[] ENAKKLCMNMK(BJFPGMKAPEG ENHEBPDFNME, int PMMNCFHMBPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1D657F0", Offset = "0x1D645F0", VA = "0x181D657F0")]
	public static IDHAJELEGOB<KDMILAKAAFH, LHMMGAHDLML> NNLAPPIBECG(BJFPGMKAPEG OOJOMJIGCBD)
	{
		return default(IDHAJELEGOB<KDMILAKAAFH, LHMMGAHDLML>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1D656D0", Offset = "0x1D644D0", VA = "0x181D656D0")]
	public static FBEPHKHKLJE<BJFPGMKAPEG, AGGGGDAGIKE> FPLCDEOCDCK(BODFBMBPPDB ADCDJFADKCK, [In] LHMMGAHDLML CNFBJPGPBBJ)
	{
		return default(FBEPHKHKLJE<BJFPGMKAPEG, AGGGGDAGIKE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct PGHLBGFMJIE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct IDIKMHEFCHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<bool, AGGGGDAGIKE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public BODFBMBPPDB root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public PGHLBGFMJIE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private FBEPHKHKLJE<bool, AGGGGDAGIKE> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, AGGGGDAGIKE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1D61B80", Offset = "0x1D60980", VA = "0x181D61B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1D621C0", Offset = "0x1D60FC0", VA = "0x181D621C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int DDMEKBICEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int CCEAOHGDFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly byte[] GHKHBJDIPKA;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x17CDEA0", Offset = "0x17CCCA0", VA = "0x1817CDEA0")]
	private PGHLBGFMJIE(int BPFMGMBDOBA, int ENPOKNEMOMH, byte[] OMHIFBJFAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x1D6F6A0", Offset = "0x1D6E4A0", VA = "0x181D6F6A0")]
	public static BJFPGMKAPEG BCNFGAKHMDJ(int BPFMGMBDOBA, int ENPOKNEMOMH, ByteString OMHIFBJFAGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1D6F780", Offset = "0x1D6E580", VA = "0x181D6F780")]
	public static BJFPGMKAPEG?[]? GNAJPGPHEJH(int PMMNCFHMBPD, KHOGAKDFAOE? HHFGPPAPFJC, PBEFNMAHMLC? MBNJMAICHBF, PGADOMLEMBK? KOLMPBPLBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1D6F980", Offset = "0x1D6E780", VA = "0x181D6F980")]
	public static IDHAJELEGOB<KDMILAKAAFH, PGHLBGFMJIE> NNLAPPIBECG(BJFPGMKAPEG OOJOMJIGCBD)
	{
		return default(IDHAJELEGOB<KDMILAKAAFH, PGHLBGFMJIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1D6F570", Offset = "0x1D6E370", VA = "0x181D6F570")]
	[AsyncStateMachine(typeof(IDIKMHEFCHD))]
	public static Task<FBEPHKHKLJE<bool, AGGGGDAGIKE>> AMFPILJNGNA(BODFBMBPPDB ADCDJFADKCK, PGHLBGFMJIE CNFBJPGPBBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class OJEFGDMOCAC : DJNPAJIEAJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly BODFBMBPPDB KFLCPEEFEAL;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public CJLAECENLDB? AHFNEPHAKHC
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1D6EA40", Offset = "0x1D6D840", VA = "0x181D6EA40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	internal OJEFGDMOCAC(BODFBMBPPDB DBCGMJGIMKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class MKBDDGFNINH : CJLAECENLDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly BODFBMBPPDB KFLCPEEFEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly EJMOLLGHOHJ BMCLHGENKOJ;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F90", Offset = "0x7B0D90", VA = "0x1807B1F90")]
	public MKBDDGFNINH(BODFBMBPPDB DBCGMJGIMKF, EJMOLLGHOHJ FJEKHMPDEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1D67140", Offset = "0x1D65F40", VA = "0x181D67140", Slot = "4")]
	public FBEPHKHKLJE<ANGHONGPLDK, BJHMKOMGNHJ> JJCDDEPKBOF(ANCACCNALNI<HBKIGHMDJGP> IBLKHIACFEF, HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG, HIGDJMOGOKB<CCHBPKLALHB> PABKLBOPHNB)
	{
		return default(FBEPHKHKLJE<ANGHONGPLDK, BJHMKOMGNHJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1D66E70", Offset = "0x1D65C70", VA = "0x181D66E70", Slot = "5")]
	public FBEPHKHKLJE<ANGHONGPLDK, BJHMKOMGNHJ> AFNLDFLDIOK(ANCACCNALNI<HBKIGHMDJGP> IBLKHIACFEF, HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG, HIGDJMOGOKB<PEBEFBLFADC> DGADLNLIIAJ)
	{
		return default(FBEPHKHKLJE<ANGHONGPLDK, BJHMKOMGNHJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class DBFGDHNMHGG : EFAPLJIBJFH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface HECNBPNPPBP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<EJMOLLGHOHJ> FBMCOOLFNJL(BODFBMBPPDB DBCGMJGIMKF, PBEFNMAHMLC? IMFELFINHNF, PGADOMLEMBK? NENJNDANDMP, CancellationToken HHBHDBLGMFA);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ADJBEMJLPBC FPPJNCLHOAK(BODFBMBPPDB DBCGMJGIMKF, KHOGAKDFAOE JNPCHOEAOCL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class DOKKONCNAJM : HECNBPNPPBP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct KGLFFPLDLJJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public AsyncTaskMethodBuilder<EJMOLLGHOHJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public BODFBMBPPDB circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public PBEFNMAHMLC cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public PGADOMLEMBK cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private TaskAwaiter<EMHHJOLCDPN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x1D64E20", Offset = "0x1D63C20", VA = "0x181D64E20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1D65140", Offset = "0x1D63F40", VA = "0x181D65140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly DOKKONCNAJM AHFNEPHAKHC;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		private DOKKONCNAJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1D5DDF0", Offset = "0x1D5CBF0", VA = "0x181D5DDF0", Slot = "4")]
		[AsyncStateMachine(typeof(KGLFFPLDLJJ))]
		public Task<EJMOLLGHOHJ> FBMCOOLFNJL(BODFBMBPPDB DBCGMJGIMKF, PBEFNMAHMLC? IMFELFINHNF, PGADOMLEMBK? NENJNDANDMP, CancellationToken HHBHDBLGMFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1D5DF50", Offset = "0x1D5CD50", VA = "0x181D5DF50", Slot = "5")]
		public ADJBEMJLPBC FPPJNCLHOAK(BODFBMBPPDB DBCGMJGIMKF, KHOGAKDFAOE JNPCHOEAOCL)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct ACBBIKBHHHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public AsyncTaskMethodBuilder<DBFGDHNMHGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public BODFBMBPPDB circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public PBEFNMAHMLC cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public PGADOMLEMBK cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public KHOGAKDFAOE evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private HECNBPNPPBP <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<EJMOLLGHOHJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1D540D0", Offset = "0x1D52ED0", VA = "0x181D540D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1D54630", Offset = "0x1D53430", VA = "0x181D54630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly EJMOLLGHOHJ BMCLHGENKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly ADJBEMJLPBC INMGKFMBHNB;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MPILBLNPGJG MPAGNCPFFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D490", Offset = "0x1D5C290", VA = "0x181D5D490", Slot = "4")]
		get
		{
			return default(MPILBLNPGJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public EKEPFKCLHFA AJJONCHALDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D4F0", Offset = "0x1D5C2F0", VA = "0x181D5D4F0", Slot = "5")]
		get
		{
			return default(EKEPFKCLHFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public MKBDDGFNINH GNDLFFFMCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public BAKHJGAMGLO ABOANDBGFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public PHNDNLMAHGD LONMJHNBLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1D5D720", Offset = "0x1D5C520", VA = "0x181D5D720")]
	private DBFGDHNMHGG(EJMOLLGHOHJ FJEKHMPDEFG, ADJBEMJLPBC DELKDDPGCEC, MKBDDGFNINH BJPEJCONFNO, BAKHJGAMGLO AAFIHIPNOOM, PHNDNLMAHGD IEDGHEEBENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1D5D550", Offset = "0x1D5C350", VA = "0x181D5D550")]
	[AsyncStateMachine(typeof(ACBBIKBHHHM))]
	public static Task<DBFGDHNMHGG> CLKFGJJOIEK(BODFBMBPPDB DBCGMJGIMKF, KHOGAKDFAOE JNPCHOEAOCL, PBEFNMAHMLC? IMFELFINHNF, PGADOMLEMBK? NENJNDANDMP, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1D5D6C0", Offset = "0x1D5C4C0", VA = "0x181D5D6C0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class LOCEGJFBBLM : FBDFODNOFNG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface DPBEEFGICNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<EFAPLJIBJFH> EHLHAHFBCCP(BODFBMBPPDB DBCGMJGIMKF, KHOGAKDFAOE JNPCHOEAOCL, PBEFNMAHMLC? IMFELFINHNF, PGADOMLEMBK? NENJNDANDMP, CancellationToken HHBHDBLGMFA);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GBLNMEHPOFL();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OABOLKFPAIC();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class KBDEIDCPDBB : DPBEEFGICNA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct JBPPCMEBDCE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AsyncTaskMethodBuilder<EFAPLJIBJFH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public BODFBMBPPDB circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public KHOGAKDFAOE evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public PBEFNMAHMLC cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public PGADOMLEMBK cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<DBFGDHNMHGG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x1D62E70", Offset = "0x1D61C70", VA = "0x181D62E70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1D631B0", Offset = "0x1D61FB0", VA = "0x181D631B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D64CC0", Offset = "0x1D63AC0", VA = "0x181D64CC0", Slot = "4")]
		[AsyncStateMachine(typeof(JBPPCMEBDCE))]
		public Task<EFAPLJIBJFH> EHLHAHFBCCP(BODFBMBPPDB DBCGMJGIMKF, KHOGAKDFAOE JNPCHOEAOCL, PBEFNMAHMLC? IMFELFINHNF, PGADOMLEMBK? NENJNDANDMP, CancellationToken HHBHDBLGMFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void GBLNMEHPOFL();

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void OABOLKFPAIC();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		protected KBDEIDCPDBB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct FMJJDCMFFGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AsyncTaskMethodBuilder<EFAPLJIBJFH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public LOCEGJFBBLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter<JEGFFGGMBEH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F340", Offset = "0x1D5E140", VA = "0x181D5F340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F540", Offset = "0x1D5E340", VA = "0x181D5F540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct FAMMFMNMIAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public LOCEGJFBBLM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public BODFBMBPPDB circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public KHOGAKDFAOE evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public PBEFNMAHMLC cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public PGADOMLEMBK cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TaskAwaiter<EFAPLJIBJFH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1D5E420", Offset = "0x1D5D220", VA = "0x181D5E420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1D5E950", Offset = "0x1D5D750", VA = "0x181D5E950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly DPBEEFGICNA PHADKJKPPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<JEGFFGGMBEH> CLBOMCKIKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<JEGFFGGMBEH> LIGCJNNLAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly CancellationTokenSource CJEOCDMKJHL;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool GEDFHPAGPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x800F00", Offset = "0x7FFD00", VA = "0x180800F00", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x800B30", Offset = "0x7FF930", VA = "0x180800B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool LICKKMNBHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDB0", Offset = "0x8CABB0", VA = "0x1808CBDB0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDD0", Offset = "0x8CABD0", VA = "0x1808CBDD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool PHKDDNICJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xECBDD0", Offset = "0xECABD0", VA = "0x180ECBDD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1D66050", Offset = "0x1D64E50", VA = "0x181D66050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public EFAPLJIBJFH? IHBNPAKBPMF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD180", Offset = "0x7ABF80", VA = "0x1807AD180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x1D65F60", Offset = "0x1D64D60", VA = "0x181D65F60", Slot = "7")]
	[AsyncStateMachine(typeof(FMJJDCMFFGF))]
	public Task<EFAPLJIBJFH> EKBPDNMAFND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1D66060", Offset = "0x1D64E60", VA = "0x181D66060")]
	public LOCEGJFBBLM(DPBEEFGICNA DNHMNAAINOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1D65C90", Offset = "0x1D64A90", VA = "0x181D65C90", Slot = "8")]
	[AsyncStateMachine(typeof(FAMMFMNMIAL))]
	public Task ALKFGMCFLHJ(BODFBMBPPDB DBCGMJGIMKF, KHOGAKDFAOE JNPCHOEAOCL, PBEFNMAHMLC? IMFELFINHNF, PGADOMLEMBK? NENJNDANDMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1D65DF0", Offset = "0x1D64BF0", VA = "0x181D65DF0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class JAIBPKBPIHD : DHKBCNPHOGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly BAKHJGAMGLO MAHCIMLAHNK;

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public JAIBPKBPIHD(BAKHJGAMGLO AAFIHIPNOOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class IMBOCFCDJOA
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class AEKMFHEKLPG<TGraph> : MPOMNDOPLNE where TGraph : OKIFPBKFAPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		protected readonly TGraph AEAEFCMEIJP;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual HHLKDDLHNEK? ONLHHOICHAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xD14B40", Offset = "0xD13940", VA = "0x180D14B40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
		public AEKMFHEKLPG(TGraph DOAPLFMMIBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class AJOEPGIOFPH : AEKMFHEKLPG<DBPECHCMBCK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override HHLKDDLHNEK? ONLHHOICHAO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x1D54760", Offset = "0x1D53560", VA = "0x181D54760", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1D54780", Offset = "0x1D53580", VA = "0x181D54780")]
		public AJOEPGIOFPH(DBPECHCMBCK NPADMFNGBCD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x1D62C80", Offset = "0x1D61A80", VA = "0x181D62C80")]
	public static MPOMNDOPLNE KJKFMOENPNA(OKIFPBKFAPF DOAPLFMMIBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class ANAGCIFPPCA : JPPMOBBDEAK, HPOLKCOMHFH, IFFIKBKCPPD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class NKJFOLIJPGL
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
			public NKJFOLIJPGL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public INFNPELKBBP errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1D707B0", Offset = "0x1D6F5B0", VA = "0x181D707B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1D70A20", Offset = "0x1D6F820", VA = "0x181D70A20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public ANAGCIFPPCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public NKJFOLIJPGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1D6DE60", Offset = "0x1D6CC60", VA = "0x181D6DE60")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task CDMJBALEHMO(INFNPELKBBP errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct FGOEMEFHFBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public ANAGCIFPPCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x1D5E9B0", Offset = "0x1D5D7B0", VA = "0x181D5E9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x1D5EEA0", Offset = "0x1D5DCA0", VA = "0x181D5EEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class EMIDNGNLEIG
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
			public EMIDNGNLEIG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1D70A80", Offset = "0x1D6F880", VA = "0x181D70A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1D70D60", Offset = "0x1D6FB60", VA = "0x181D70D60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public ANAGCIFPPCA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public EMIDNGNLEIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1D5E1D0", Offset = "0x1D5CFD0", VA = "0x181D5E1D0")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task HNLEIGJPKNN(INFNPELKBBP errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly BLCBNJIOAJP BHGNJDKJFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly ICollection<PDKEAMMPLOF> HEOEOHJJGDF;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private IEMHDKADMOP IOBKGEEKHIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1D55430", Offset = "0x1D54230", VA = "0x181D55430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public HIGDJMOGOKB<CCHBPKLALHB> DEDOEDMBACD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA34F40", Offset = "0xA33D40", VA = "0x180A34F40", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(HIGDJMOGOKB<CCHBPKLALHB>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA7E110", Offset = "0xA7CF10", VA = "0x180A7E110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private HIGDJMOGOKB<PCHPOCELAEL> HBGFPNINNJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8CD350", Offset = "0x8CC150", VA = "0x1808CD350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public override HIGDJMOGOKB<FOJMALNNKMD> MDEKNEHFFDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1D578C0", Offset = "0x1D566C0", VA = "0x181D578C0", Slot = "19")]
		get
		{
			return default(HIGDJMOGOKB<FOJMALNNKMD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PIDODABMPOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x1D562D0", Offset = "0x1D550D0", VA = "0x181D562D0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1D57C10", Offset = "0x1D56A10", VA = "0x181D57C10")]
	private ANAGCIFPPCA(BODFBMBPPDB DBCGMJGIMKF, NNBKMHBHPNK ACNLHBNEANJ, BLCBNJIOAJP NDIKPKCEHDH, HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG, HIGDJMOGOKB<CCHBPKLALHB> PABKLBOPHNB, HIGDJMOGOKB<PCHPOCELAEL> PIFGCICDBNJ, bool ONFGLFDNIJE, string OHHBGJPCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1D568B0", Offset = "0x1D556B0", VA = "0x181D568B0")]
	public static ANAGCIFPPCA KJKFMOENPNA(BODFBMBPPDB DBCGMJGIMKF, NNBKMHBHPNK ACNLHBNEANJ, BLCBNJIOAJP ECKJJAACLOE, HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG, HIGDJMOGOKB<PCHPOCELAEL> PIFGCICDBNJ, HIGDJMOGOKB<CCHBPKLALHB> PABKLBOPHNB, bool ONFGLFDNIJE, bool HPEKJEGJNJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1D55FC0", Offset = "0x1D54DC0", VA = "0x181D55FC0", Slot = "20")]
	protected override void FCIFMHNEBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1D55730", Offset = "0x1D54530", VA = "0x181D55730", Slot = "21")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1D57B40", Offset = "0x1D56940", VA = "0x181D57B40", Slot = "28")]
	public void OCABIBKHOBC(PDKEAMMPLOF OHLECACLHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1D558F0", Offset = "0x1D546F0", VA = "0x181D558F0", Slot = "25")]
	public void EEIFILHHPLE(ABJBGAPGEOA MPMGEKIGHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1D56F20", Offset = "0x1D55D20", VA = "0x181D56F20", Slot = "26")]
	public void MHPLCDEFMLE(ICPHJHIKODO IBKGHNPBBKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1D54E40", Offset = "0x1D53C40", VA = "0x181D54E40", Slot = "22")]
	protected override void AJBOGHNKAEF(FFHMBDJDPHI OJBJEFDFADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1D555C0", Offset = "0x1D543C0", VA = "0x181D555C0", Slot = "30")]
	public string CPPGLLLBBBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1D55100", Offset = "0x1D53F00", VA = "0x181D55100", Slot = "27")]
	public string BBDOCANINBC(int ENMILGMCCJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1D56C60", Offset = "0x1D55A60", VA = "0x181D56C60")]
	private void KMIGIAJJEED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1D554F0", Offset = "0x1D542F0", VA = "0x181D554F0", Slot = "29")]
	public void BNJGMJIKHGL(PDKEAMMPLOF OHLECACLHIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1D57980", Offset = "0x1D56780", VA = "0x181D57980")]
	private void NLFNPEFLEFN(bool NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1D56680", Offset = "0x1D55480", VA = "0x181D56680", Slot = "31")]
	[AsyncStateMachine(typeof(FGOEMEFHFBO))]
	public Task JMIMEHNGGGN(string NKKIECLCEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1D56780", Offset = "0x1D55580", VA = "0x181D56780")]
	public void KIIONPBJODB(string NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1D55E20", Offset = "0x1D54C20", VA = "0x181D55E20")]
	private void EKJEMCPEGEN(int NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0xA7E110", Offset = "0xA7CF10", VA = "0x180A7E110")]
	internal void ONDOOIILIAJ(HIGDJMOGOKB<CCHBPKLALHB> NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1D54F20", Offset = "0x1D53D20", VA = "0x181D54F20")]
	[CompilerGenerated]
	private bool AKAMNJELHDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1D56180", Offset = "0x1D54F80", VA = "0x181D56180")]
	[CompilerGenerated]
	private bool HBEHMNMPLOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1D56560", Offset = "0x1D55360", VA = "0x181D56560")]
	[CompilerGenerated]
	private int NGMHFHAHADE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1D56E90", Offset = "0x1D55C90", VA = "0x181D56E90")]
	[CompilerGenerated]
	private bool MHNNNOIMMDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1D55CD0", Offset = "0x1D54AD0", VA = "0x181D55CD0")]
	[CompilerGenerated]
	private bool EIHENNDPBID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1D55450", Offset = "0x1D54250", VA = "0x181D55450")]
	[CompilerGenerated]
	private bool BIMJCPIEOLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1D55070", Offset = "0x1D53E70", VA = "0x181D55070")]
	[CompilerGenerated]
	private bool ANPFFIMDBKG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1D56560", Offset = "0x1D55360", VA = "0x181D56560")]
	[CompilerGenerated]
	private int IEPMNCKCIIF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1D56490", Offset = "0x1D55290", VA = "0x181D56490")]
	[CompilerGenerated]
	private bool HJLIPMEODFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1D554A0", Offset = "0x1D542A0", VA = "0x181D554A0")]
	[CompilerGenerated]
	private int BLNKIDOCDIF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1D57900", Offset = "0x1D56700", VA = "0x181D57900")]
	[CompilerGenerated]
	private void NBMJELNCJIO(object NKKIECLCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1D565B0", Offset = "0x1D553B0", VA = "0x181D565B0")]
	[CompilerGenerated]
	private bool IOIMLPCNALF()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class IGKDHMPBOLP
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private abstract class GHODGBOFBED<TNode> : DGKLCBKBHJC<TNode> where TNode : notnull, ELOACBEDDKN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct LCDPEAOECDA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public AsyncTaskMethodBuilder<FBEPHKHKLJE<HIGDJMOGOKB<GCNKIDOJOMK>, BEPKJMJJJMM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public GHODGBOFBED<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private TaskAwaiter<FBEPHKHKLJE<HIGDJMOGOKB<GCNKIDOJOMK>, BEPKJMJJJMM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x3BA32C0", Offset = "0x3BA20C0", VA = "0x183BA32C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3BA3690", Offset = "0x3BA2490", VA = "0x183BA3690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct DJMHNIOHBJE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public GHODGBOFBED<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public HIGDJMOGOKB<GCNKIDOJOMK> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x4F45BA0", Offset = "0x4F449A0", VA = "0x184F45BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x4F45F70", Offset = "0x4F44D70", VA = "0x184F45F70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public sealed override bool MINPDIJGGIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x7C4100", Offset = "0x7C2F00", VA = "0x1807C4100", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public sealed override HIGDJMOGOKB<GCNKIDOJOMK>? LKJDINGNCIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x36BE9A0", Offset = "0x36BD7A0", VA = "0x1836BE9A0", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x36BE970", Offset = "0x36BD770", VA = "0x1836BE970")]
		public GHODGBOFBED(BODFBMBPPDB DBCGMJGIMKF, TNode ACNLHBNEANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x36BE6A0", Offset = "0x36BD4A0", VA = "0x1836BE6A0", Slot = "93")]
		[AsyncStateMachine(typeof(GHODGBOFBED<>.LCDPEAOECDA))]
		public override Task<FBEPHKHKLJE<HIGDJMOGOKB<GCNKIDOJOMK>, BEPKJMJJJMM>> MDPDFEBOBMI(string OHHBGJPCFJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x36BE7C0", Offset = "0x36BD5C0", VA = "0x1836BE7C0", Slot = "117")]
		public sealed override bool NHONHHKGEBF(HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x36BE560", Offset = "0x36BD360", VA = "0x1836BE560", Slot = "107")]
		protected sealed override bool BIPLJIJLJED(HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x36BE600", Offset = "0x36BD400", VA = "0x1836BE600", Slot = "108")]
		protected override bool KNNDKCHOLOD(HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x36BE860", Offset = "0x36BD660", VA = "0x1836BE860", Slot = "94")]
		[AsyncStateMachine(typeof(GHODGBOFBED<>.DJMHNIOHBJE))]
		public override Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> OOHHEIMHAGM(HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private sealed class EEFONPAONDN : DCAPAKNFDIN<APGAHKMNHFD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x7F52E0", Offset = "0x7F40E0", VA = "0x1807F52E0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1D5DFF0", Offset = "0x1D5CDF0", VA = "0x181D5DFF0")]
		public EEFONPAONDN(BODFBMBPPDB DBCGMJGIMKF, APGAHKMNHFD ACNLHBNEANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private abstract class DCAPAKNFDIN<TNode> : DGKLCBKBHJC<TNode> where TNode : notnull, EEFEPBEHDDK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private struct OLCBKMMDNNE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public AsyncTaskMethodBuilder<FBEPHKHKLJE<HIGDJMOGOKB<GCNKIDOJOMK>, BEPKJMJJJMM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public DCAPAKNFDIN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<FBEPHKHKLJE<HIGDJMOGOKB<GCNKIDOJOMK>, BEPKJMJJJMM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x3F7A730", Offset = "0x3F79530", VA = "0x183F7A730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3F7AAA0", Offset = "0x3F798A0", VA = "0x183F7AAA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct APMIPMONHEH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public DCAPAKNFDIN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public HIGDJMOGOKB<GCNKIDOJOMK> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x3852270", Offset = "0x3851070", VA = "0x183852270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x38525C0", Offset = "0x38513C0", VA = "0x1838525C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override HIGDJMOGOKB<IAFEEIBLHGA>? IKIMANOFNKK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x4F1FF20", Offset = "0x4F1ED20", VA = "0x184F1FF20", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override HIGDJMOGOKB<GCNKIDOJOMK>? LKJDINGNCIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x4F1FFD0", Offset = "0x4F1EDD0", VA = "0x184F1FFD0", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x36BE970", Offset = "0x36BD770", VA = "0x1836BE970")]
		public DCAPAKNFDIN(BODFBMBPPDB DBCGMJGIMKF, TNode ACNLHBNEANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x4F1FC50", Offset = "0x4F1EA50", VA = "0x184F1FC50", Slot = "93")]
		[AsyncStateMachine(typeof(DCAPAKNFDIN<>.OLCBKMMDNNE))]
		public override Task<FBEPHKHKLJE<HIGDJMOGOKB<GCNKIDOJOMK>, BEPKJMJJJMM>> MDPDFEBOBMI(string OHHBGJPCFJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4F1FD70", Offset = "0x4F1EB70", VA = "0x184F1FD70", Slot = "117")]
		public sealed override bool NHONHHKGEBF(HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4F1FB10", Offset = "0x4F1E910", VA = "0x184F1FB10", Slot = "107")]
		protected sealed override bool BIPLJIJLJED(HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4F1FBB0", Offset = "0x4F1E9B0", VA = "0x184F1FBB0", Slot = "108")]
		protected override bool KNNDKCHOLOD(HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4F1FE10", Offset = "0x4F1EC10", VA = "0x184F1FE10", Slot = "94")]
		[AsyncStateMachine(typeof(DCAPAKNFDIN<>.APMIPMONHEH))]
		public override Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> OOHHEIMHAGM(HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class HHAMDIHPEAK : DGKLCBKBHJC<KIECKPGHPKH>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x9CEDE0", Offset = "0x9CDBE0", VA = "0x1809CEDE0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1D60E80", Offset = "0x1D5FC80", VA = "0x181D60E80")]
		public HHAMDIHPEAK(BODFBMBPPDB DBCGMJGIMKF, KIECKPGHPKH ACNLHBNEANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class GABDGHFEEAF : DCAPAKNFDIN<NKINIKFPCBD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool FFCHKHEOLLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7C4100", Offset = "0x7C2F00", VA = "0x1807C4100", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool CPEAGHDFIMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x1D5F960", Offset = "0x1D5E760", VA = "0x181D5F960", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x899F00", Offset = "0x898D00", VA = "0x180899F00", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F900", Offset = "0x1D5E700", VA = "0x181D5F900")]
		public GABDGHFEEAF(BODFBMBPPDB DBCGMJGIMKF, NKINIKFPCBD ACNLHBNEANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class EMJDNKLKDKH : DGKLCBKBHJC<NGOONNBKCCF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xFCA440", Offset = "0xFC9240", VA = "0x180FCA440", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x1D5E3B0", Offset = "0x1D5D1B0", VA = "0x181D5E3B0")]
		public EMJDNKLKDKH(BODFBMBPPDB DBCGMJGIMKF, NGOONNBKCCF ACNLHBNEANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class CBPBMKHNCKH : DGKLCBKBHJC<AOHLIEEDKEB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x89B220", Offset = "0x89A020", VA = "0x18089B220", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D300", Offset = "0x1D5C100", VA = "0x181D5D300")]
		public CBPBMKHNCKH(BODFBMBPPDB DBCGMJGIMKF, AOHLIEEDKEB ACNLHBNEANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7C4100", Offset = "0x7C2F00", VA = "0x1807C4100", Slot = "107")]
		protected override bool BIPLJIJLJED(HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class HPKIEOKJBLP : DGKLCBKBHJC<PGDGNMFBEFD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB840", VA = "0x1808ACA40", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override bool FNMKJHDCOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1D61B30", Offset = "0x1D60930", VA = "0x181D61B30", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override bool JNIDGHAKLHE
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x7C4100", Offset = "0x7C2F00", VA = "0x1807C4100", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1D61AC0", Offset = "0x1D608C0", VA = "0x181D61AC0")]
		public HPKIEOKJBLP(BODFBMBPPDB DBCGMJGIMKF, PGDGNMFBEFD ACNLHBNEANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class MEJDBGNJHMJ : DGKLCBKBHJC<ALLNHMLACPO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x898740", Offset = "0x897540", VA = "0x180898740", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override bool FNMKJHDCOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x1D66E20", Offset = "0x1D65C20", VA = "0x181D66E20", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected override bool JNIDGHAKLHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7C4100", Offset = "0x7C2F00", VA = "0x1807C4100", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1D66DB0", Offset = "0x1D65BB0", VA = "0x181D66DB0")]
		public MEJDBGNJHMJ(BODFBMBPPDB DBCGMJGIMKF, ALLNHMLACPO ACNLHBNEANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class FJLDEGDOHFD : GHODGBOFBED<DIELICMFJPC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x8A4D60", Offset = "0x8A3B60", VA = "0x1808A4D60", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F2E0", Offset = "0x1D5E0E0", VA = "0x181D5F2E0")]
		public FJLDEGDOHFD(BODFBMBPPDB DBCGMJGIMKF, DIELICMFJPC ACNLHBNEANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class DGKLCBKBHJC<TNode> : JPABOEDBDKB, IDisposable where TNode : notnull, NNBKMHBHPNK
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class LCKOIHJAJPH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public DGKLCBKBHJC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public BODFBMBPPDB circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public LCKOIHJAJPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x3BA5B30", Offset = "0x3BA4930", VA = "0x183BA5B30")]
			internal NADHMEIBHJN INHKCGMPCLO(NHHCCMICPDM portGroup, int index)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct IHKHJFJAFPA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public DGKLCBKBHJC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public PKJFFDGJKLA? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public EIBKPIOMBIK? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x384EE20", Offset = "0x384DC20", VA = "0x18384EE20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x384F0C0", Offset = "0x384DEC0", VA = "0x18384F0C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct OMNMPDMAHMH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public DGKLCBKBHJC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x3F84BD0", Offset = "0x3F839D0", VA = "0x183F84BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x3F84E30", Offset = "0x3F83C30", VA = "0x183F84E30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private BODFBMBPPDB KFLCPEEFEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly bool POBEDLCOJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private EEMAAMOJFLO<GCNKIDOJOMK, NADHMEIBHJN> PPIAGBKDBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private EEMAAMOJFLO<GCNKIDOJOMK, CIHDDONJMFL> DKHBNNINBFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private List<Action> ELEMHNKHNDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[CompilerGenerated]
		private Action<HIGDJMOGOKB<GCNKIDOJOMK>>? DCBJGJIGCMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[CompilerGenerated]
		private Action<HIGDJMOGOKB<GCNKIDOJOMK>, CIHDDONJMFL>? GNIIPIMKGOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[CompilerGenerated]
		private Action<HIGDJMOGOKB<GCNKIDOJOMK>, HIGDJMOGOKB<GCNKIDOJOMK>>? ODBMJBFAEOM;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected TNode EDEGFHMOIHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ANCACCNALNI<IOKIBFLHGGE> ILMEHHFCKOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x92B410", Offset = "0x92A210", VA = "0x18092B410", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(ANCACCNALNI<IOKIBFLHGGE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public object FELLAFAONPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x324AB70", Offset = "0x3249970", VA = "0x18324AB70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public virtual bool MNHBMOCJLOO
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7C4100", Offset = "0x7C2F00", VA = "0x1807C4100", Slot = "80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int BDGDBNCMBEH
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C260", Offset = "0x4F3B060", VA = "0x184F3C260", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public PAACLPBPANI MMLBHFGIFOG
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C210", Offset = "0x4F3B010", VA = "0x184F3C210", Slot = "9")]
			get
			{
				return default(PAACLPBPANI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string DAAEIEFHDIK
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C630", Offset = "0x4F3B430", VA = "0x184F3C630", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected virtual bool JNIDGHAKLHE
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public virtual NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public HIGDJMOGOKB<CFBOHINFPIG> CCMLGJKLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x8DB220", Offset = "0x8DA020", VA = "0x1808DB220", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(HIGDJMOGOKB<CFBOHINFPIG>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x91EC70", Offset = "0x91DA70", VA = "0x18091EC70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual bool FNMKJHDCOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public virtual bool FFCHKHEOLLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public virtual JDLNPHELEFF AIPILLHKAGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x88CA70", Offset = "0x88B870", VA = "0x18088CA70", Slot = "86")]
			get
			{
				return default(JDLNPHELEFF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool CNGIPNBBMLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C030", Offset = "0x4F3AE30", VA = "0x184F3C030", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public bool DCHOMFCJABC
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C080", Offset = "0x4F3AE80", VA = "0x184F3C080", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool CGBEPFEFGED
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C0D0", Offset = "0x4F3AED0", VA = "0x184F3C0D0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int LPBMFMLOJLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C480", Offset = "0x4F3B280", VA = "0x184F3C480", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool HDILOKCDHKH
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C350", Offset = "0x4F3B150", VA = "0x184F3C350", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool IBMKNHFHMPA
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C170", Offset = "0x4F3AF70", VA = "0x184F3C170", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool PBECPFKFGKD
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xA6F310", Offset = "0xA6E110", VA = "0x180A6F310", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xA6F040", Offset = "0xA6DE40", VA = "0x180A6F040")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public virtual bool MGMOLAGKFDM
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public virtual bool OBKEKLOPDLI
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C120", Offset = "0x4F3AF20", VA = "0x184F3C120", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool KJGKCDJFFAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C2A0", Offset = "0x4F3B0A0", VA = "0x184F3C2A0", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public PKJFFDGJKLA FGMHAIMGDCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C3E0", Offset = "0x4F3B1E0", VA = "0x184F3C3E0", Slot = "26")]
			get
			{
				return default(PKJFFDGJKLA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public EIBKPIOMBIK LMICPFEIIJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C430", Offset = "0x4F3B230", VA = "0x184F3C430", Slot = "28")]
			get
			{
				return default(EIBKPIOMBIK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual bool KENNPHEDEOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public virtual AMDANMNFHOA? HJHPOONCFIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "103")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual KHKHCIFHBHO? HGIBLAFJNEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "104")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual IEnumerable<ANCACCNALNI<HBKIGHMDJGP>>? JEPGOKIIDOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool FOONCHLIHLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C1C0", Offset = "0x4F3AFC0", VA = "0x184F3C1C0", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public ANCACCNALNI<IAFEEIBLHGA> GJGGOHJFJMG
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C390", Offset = "0x4F3B190", VA = "0x184F3C390", Slot = "54")]
			get
			{
				return default(ANCACCNALNI<IAFEEIBLHGA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool MINPDIJGGIA
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual HIGDJMOGOKB<IAFEEIBLHGA>? IKIMANOFNKK
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual bool CPEAGHDFIMC
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool AJFEGGMKLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C2F0", Offset = "0x4F3B0F0", VA = "0x184F3C2F0", Slot = "59")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string GMLPMAJDOJG
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x7B5E20", Offset = "0x7B4C20", VA = "0x1807B5E20", Slot = "61")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x7B5E80", Offset = "0x7B4C80", VA = "0x1807B5E80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public ANCACCNALNI<HBKIGHMDJGP> LFNEIHLFHBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C4C0", Offset = "0x4F3B2C0", VA = "0x184F3C4C0", Slot = "60")]
			get
			{
				return default(ANCACCNALNI<HBKIGHMDJGP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public ANCACCNALNI<HBKIGHMDJGP>? KDDHMCLHBAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C510", Offset = "0x4F3B310", VA = "0x184F3C510", Slot = "113")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public OEFOIDFOPKJ<GCNKIDOJOMK, CIHDDONJMFL> PBNOMBPKJMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C5F0", Offset = "0x4F3B3F0", VA = "0x184F3C5F0", Slot = "62")]
			get
			{
				return default(OEFOIDFOPKJ<GCNKIDOJOMK, CIHDDONJMFL>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual HIGDJMOGOKB<GCNKIDOJOMK>? LKJDINGNCIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action DCLECBOAIOO
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x4F38A10", Offset = "0x4F37810", VA = "0x184F38A10", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x4F3AAF0", Offset = "0x4F398F0", VA = "0x184F3AAF0", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event KMNJBNJKPFM EFINOKKIIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x4F383E0", Offset = "0x4F371E0", VA = "0x184F383E0", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x4F39540", Offset = "0x4F38340", VA = "0x184F39540", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event GIOJCBEAOFK EDELOPFMOFH
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x4F393F0", Offset = "0x4F381F0", VA = "0x184F393F0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x4F38CA0", Offset = "0x4F37AA0", VA = "0x184F38CA0", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action LNODCIDLENL
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x4F39490", Offset = "0x4F38290", VA = "0x184F39490", Slot = "41")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x4F38480", Offset = "0x4F37280", VA = "0x184F38480", Slot = "42")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action KLELIDMNJKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x4F39F80", Offset = "0x4F38D80", VA = "0x184F39F80", Slot = "43")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x4F3AA50", Offset = "0x4F39850", VA = "0x184F3AA50", Slot = "44")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<HIGDJMOGOKB<GCNKIDOJOMK>, CIHDDONJMFL> NIODCECKJGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4F39210", Offset = "0x4F38010", VA = "0x184F39210", Slot = "64")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x4F38BB0", Offset = "0x4F379B0", VA = "0x184F38BB0", Slot = "65")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<HIGDJMOGOKB<GCNKIDOJOMK>, CIHDDONJMFL> IJPOAAOLIBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x4F395E0", Offset = "0x4F383E0", VA = "0x184F395E0", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x4F3B6A0", Offset = "0x4F3A4A0", VA = "0x184F3B6A0", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<HIGDJMOGOKB<GCNKIDOJOMK>> HEMCKKDAAIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4F3A990", Offset = "0x4F39790", VA = "0x184F3A990", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4F39150", Offset = "0x4F37F50", VA = "0x184F39150", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<HIGDJMOGOKB<GCNKIDOJOMK>, HIGDJMOGOKB<GCNKIDOJOMK>> DAJEHHABCIN
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x4F3B890", Offset = "0x4F3A690", VA = "0x184F3B890", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x4F3B420", Offset = "0x4F3A220", VA = "0x184F3B420", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<HIGDJMOGOKB<GCNKIDOJOMK>, CIHDDONJMFL> JICLMOMDHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x4F3BAE0", Offset = "0x4F3A8E0", VA = "0x184F3BAE0", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x4F3B4E0", Offset = "0x4F3A2E0", VA = "0x184F3B4E0", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4F3BCF0", Offset = "0x4F3AAF0", VA = "0x184F3BCF0")]
		[MFKPHBEGHNM("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[MFKPHBEGHNM("Need to handle `Name` better.")]
		public DGKLCBKBHJC(BODFBMBPPDB DBCGMJGIMKF, TNode ACNLHBNEANJ, bool HPEKJEGJNJF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A020", Offset = "0x4F38E20", VA = "0x184F3A020", Slot = "78")]
		protected virtual void FCIFMHNEBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4F396A0", Offset = "0x4F384A0", VA = "0x184F396A0", Slot = "79")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4F3B260", Offset = "0x4F3A060", VA = "0x184F3B260", Slot = "81")]
		public virtual void LAIECIOGDMH(int KDCGHAHMFDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4F390F0", Offset = "0x4F37EF0", VA = "0x184F390F0")]
		public bool CIGDLPADLPF([In] PKJFFDGJKLA NKKIECLCEML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4F3B830", Offset = "0x4F3A630", VA = "0x184F3B830")]
		public bool PGKPNEEBDNJ([In] EIBKPIOMBIK NKKIECLCEML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4F3AC00", Offset = "0x4F39A00", VA = "0x184F3AC00", Slot = "89")]
		public virtual void JENCDOLHNGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A840", Offset = "0x4F39640", VA = "0x184F3A840", Slot = "31")]
		[AsyncStateMachine(typeof(DGKLCBKBHJC<>.IHKHJFJAFPA))]
		public Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> GMAKAOHCOBC(PKJFFDGJKLA? JCHLCJBNBDI, EIBKPIOMBIK? JHGEDFGCAEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "90")]
		public virtual void AOIKHEKNBLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "91")]
		public virtual void IDIHKKELDGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "92")]
		public virtual void DFAILNDHFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1A5B520", Offset = "0x1A5A320", VA = "0x181A5B520")]
		protected void CHIDAONLMIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x42216E0", Offset = "0x42204E0", VA = "0x1842216E0")]
		protected void CLNCNKEBKON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x1F04610", Offset = "0x1F03410", VA = "0x181F04610")]
		private void CMAMNCKHJCH([In] EIBKPIOMBIK GJMDICOFEBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4F3B2B0", Offset = "0x4F3A0B0", VA = "0x184F3B2B0", Slot = "93")]
		public virtual Task<FBEPHKHKLJE<HIGDJMOGOKB<GCNKIDOJOMK>, BEPKJMJJJMM>> MDPDFEBOBMI(string OHHBGJPCFJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4F3B760", Offset = "0x4F3A560", VA = "0x184F3B760", Slot = "94")]
		public virtual Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> OOHHEIMHAGM(HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A710", Offset = "0x4F39510", VA = "0x184F3A710", Slot = "95")]
		public virtual void FNJPHDOGAOD(HIGDJMOGOKB<GCNKIDOJOMK> ENPOKNEMOMH, HIGDJMOGOKB<GCNKIDOJOMK> KAKJJOAALHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4F382D0", Offset = "0x4F370D0", VA = "0x184F382D0", Slot = "96")]
		public virtual IEnumerable<BJFPGMKAPEG> ADPAICMCGKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4F3ACA0", Offset = "0x4F39AA0", VA = "0x184F3ACA0", Slot = "97")]
		public FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM> JKEHOEIMIKI(string LNLOEIOGGHP)
		{
			return default(FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4F3BBA0", Offset = "0x4F3A9A0", VA = "0x184F3BBA0", Slot = "45")]
		public bool PMGBFKDFDIL([Out] Guid AIFNAINAIBK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A7F0", Offset = "0x4F395F0", VA = "0x184F3A7F0", Slot = "98")]
		public virtual bool GBAHAPICDNC([In] Guid MOJJMHEPCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4F3B3D0", Offset = "0x4F3A1D0", VA = "0x184F3B3D0", Slot = "99")]
		public virtual void MNGHADJNDMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "100")]
		public virtual void BDNJFJHKACI(bool LGAAPNNFINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "101")]
		public virtual CDKAFNIEBBI JCIOOIHIBLP([In] MEIAKKNJEJI FKOBBKKFIPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4F3B5A0", Offset = "0x4F3A3A0", VA = "0x184F3B5A0")]
		protected void OJDKLLOCAKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "106")]
		protected virtual void CCPHFJAJGCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4F38C70", Offset = "0x4F37A70", VA = "0x184F38C70", Slot = "107")]
		protected virtual bool BIPLJIJLJED(HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "108")]
		protected virtual bool KNNDKCHOLOD(HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "115")]
		protected virtual void PACOBEPNIAE(JCDKCBMDGID EKOJOCMDBAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "116")]
		protected virtual void BDLOHCEDIMM(JCDKCBMDGID BBMNIEBLIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x4F3B380", Offset = "0x4F3A180", VA = "0x184F3B380", Slot = "74")]
		public void MHPLCDEFMLE(JCDKCBMDGID BBMNIEBLIFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x4F3B150", Offset = "0x4F39F50", VA = "0x184F3B150", Slot = "75")]
		public HOBJMOMMPME KEOJJKJIMKG()
		{
			return default(HOBJMOMMPME);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "117")]
		public virtual bool NHONHHKGEBF(HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x1198F30", Offset = "0x1197D30", VA = "0x181198F30")]
		private void KBAKPHNOEMJ([In] PKJFFDGJKLA JCOIMLJCHFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x4F38AB0", Offset = "0x4F378B0", VA = "0x184F38AB0")]
		private void BBLDAFANOPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x4F384E0", Offset = "0x4F372E0", VA = "0x184F384E0")]
		private void APFBHIPAEBA(int GOCEFPCHNAO, NHHCCMICPDM MJBOFGPCGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x4F3AC50", Offset = "0x4F39A50", VA = "0x184F3AC50")]
		private void JINHOIJICHD(int ENPOKNEMOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x4F3B950", Offset = "0x4F3A750", VA = "0x184F3B950")]
		private void PIDCEFDBIAN(int ENPOKNEMOMH, NHHCCMICPDM LNJIFGGAFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x4F38D40", Offset = "0x4F37B40", VA = "0x184F38D40")]
		private void CDHODKGBDFH(int KDLHHPJLDCM, int HAOJPCCALII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A790", Offset = "0x4F39590", VA = "0x184F3A790")]
		private void GAFFMFGMKLP(int KDLHHPJLDCM, int HAOJPCCALII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x4F3BA90", Offset = "0x4F3A890", VA = "0x184F3BA90")]
		private void PIFGFEJAJNH(int ENPOKNEMOMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x4F3AD20", Offset = "0x4F39B20", VA = "0x184F3AD20")]
		private void JLBNNIJDGHO(int GOCEFPCHNAO, NHHCCMICPDM MJBOFGPCGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4F38360", Offset = "0x4F37160", VA = "0x184F38360")]
		private void AEDIPJICMML(int ENPOKNEMOMH, NHHCCMICPDM LNJIFGGAFLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4F392D0", Offset = "0x4F380D0", VA = "0x184F392D0", Slot = "118")]
		[AsyncStateMachine(typeof(DGKLCBKBHJC<>.OMNMPDMAHMH))]
		public virtual Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> DAMOGGLBCON(string LNLOEIOGGHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x4F39F10", Offset = "0x4F38D10", VA = "0x184F39F10", Slot = "52")]
		private void EAEOEGAIJKO(object MHEPPBGGOLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4F3AB90", Offset = "0x4F39990", VA = "0x184F3AB90", Slot = "53")]
		private void JCJCAPDBNMG(object MHEPPBGGOLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A760", Offset = "0x4F39560", VA = "0x184F3A760", Slot = "27")]
		private bool GACFICCMHLB([In] PKJFFDGJKLA NKKIECLCEML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x4F3B230", Offset = "0x4F3A030", VA = "0x184F3B230", Slot = "29")]
		private bool KODAOILNADG([In] EIBKPIOMBIK NKKIECLCEML)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class MCLJEOGNHIL : GHODGBOFBED<IFGEPNJGJIF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public override NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAB7E30", Offset = "0xAB6C30", VA = "0x180AB7E30", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1D664F0", Offset = "0x1D652F0", VA = "0x181D664F0")]
		public MCLJEOGNHIL(BODFBMBPPDB DBCGMJGIMKF, IFGEPNJGJIF ACNLHBNEANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class AJLFIMKHJIP : DCAPAKNFDIN<PIGCKAILAPF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public override NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x7F52E0", Offset = "0x7F40E0", VA = "0x1807F52E0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x1D54700", Offset = "0x1D53500", VA = "0x181D54700")]
		public AJLFIMKHJIP(BODFBMBPPDB DBCGMJGIMKF, PIGCKAILAPF ACNLHBNEANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private sealed class JJCICGNKJKF : DGKLCBKBHJC<DOAGFODILKG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public override NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864790", VA = "0x180865990", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x1D63400", Offset = "0x1D62200", VA = "0x181D63400")]
		public JJCICGNKJKF(BODFBMBPPDB DBCGMJGIMKF, DOAGFODILKG ACNLHBNEANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class JNCFPKIHBLM : DCAPAKNFDIN<JLJMKIMIAGI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public override NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x7F52E0", Offset = "0x7F40E0", VA = "0x1807F52E0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x1D63470", Offset = "0x1D62270", VA = "0x181D63470")]
		public JNCFPKIHBLM(BODFBMBPPDB DBCGMJGIMKF, JLJMKIMIAGI ACNLHBNEANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private sealed class INDHLNCICOA : DCAPAKNFDIN<GDNKENPBEBK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public override NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x7F52E0", Offset = "0x7F40E0", VA = "0x1807F52E0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1D62E10", Offset = "0x1D61C10", VA = "0x181D62E10")]
		public INDHLNCICOA(BODFBMBPPDB DBCGMJGIMKF, GDNKENPBEBK ACNLHBNEANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private sealed class HBLGFDPPOBF : DGKLCBKBHJC<CJOFCCCEMPN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public override NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xBBDDA0", Offset = "0xBBCBA0", VA = "0x180BBDDA0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x1D60A50", Offset = "0x1D5F850", VA = "0x181D60A50")]
		public HBLGFDPPOBF(BODFBMBPPDB DBCGMJGIMKF, CJOFCCCEMPN ACNLHBNEANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private sealed class APLEFMBGDAD : DGKLCBKBHJC<JMPOGJMEKLI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public override NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected override bool JNIDGHAKLHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x7C4100", Offset = "0x7C2F00", VA = "0x1807C4100", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1D58200", Offset = "0x1D57000", VA = "0x181D58200")]
		public APLEFMBGDAD(BODFBMBPPDB DBCGMJGIMKF, JMPOGJMEKLI ACNLHBNEANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	private sealed class NJDEHKKIFHM : DGKLCBKBHJC<FPJKKIKLHAE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public override NodeVisualizationKey DIJJAKBLGBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x89A860", Offset = "0x899660", VA = "0x18089A860", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1D6DDF0", Offset = "0x1D6CBF0", VA = "0x181D6DDF0")]
		public NJDEHKKIFHM(BODFBMBPPDB DBCGMJGIMKF, FPJKKIKLHAE ACNLHBNEANJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x1D62230", Offset = "0x1D61030", VA = "0x181D62230")]
	internal static JPABOEDBDKB KJKFMOENPNA(BODFBMBPPDB DBCGMJGIMKF, NNBKMHBHPNK ACNLHBNEANJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class NOHIFCCDICB : JPPMOBBDEAK, OKHGDDJOAOK, IFFIKBKCPPD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public HIGDJMOGOKB<PEBEFBLFADC> COGGNMEIFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xD16CC0", Offset = "0xD15AC0", VA = "0x180D16CC0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(HIGDJMOGOKB<PEBEFBLFADC>);
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xD153A0", Offset = "0xD141A0", VA = "0x180D153A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private HIGDJMOGOKB<DNDJFJCMJLC> EDDHKJBHOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x1D6E350", Offset = "0x1D6D150", VA = "0x181D6E350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public override HIGDJMOGOKB<FOJMALNNKMD> MDEKNEHFFDI
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x1D6E690", Offset = "0x1D6D490", VA = "0x181D6E690", Slot = "19")]
		get
		{
			return default(HIGDJMOGOKB<FOJMALNNKMD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1D6E6D0", Offset = "0x1D6D4D0", VA = "0x181D6E6D0")]
	private NOHIFCCDICB(BODFBMBPPDB DBCGMJGIMKF, NNBKMHBHPNK ACNLHBNEANJ, CEBKHPKPJDG BOKMCOMHPGO, HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG, HIGDJMOGOKB<PEBEFBLFADC> DGADLNLIIAJ, HIGDJMOGOKB<DNDJFJCMJLC> CHNHDOJLHBB, bool ONFGLFDNIJE, string OHHBGJPCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x1D6E360", Offset = "0x1D6D160", VA = "0x181D6E360")]
	public static NOHIFCCDICB KJKFMOENPNA(BODFBMBPPDB DBCGMJGIMKF, NNBKMHBHPNK ACNLHBNEANJ, CEBKHPKPJDG ADPLPAEFBEL, HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG, HIGDJMOGOKB<DNDJFJCMJLC> CHNHDOJLHBB, HIGDJMOGOKB<PEBEFBLFADC> DGADLNLIIAJ, bool ONFGLFDNIJE, bool HPEKJEGJNJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0xD153A0", Offset = "0xD141A0", VA = "0x180D153A0")]
	internal void CPECBPCEHBO(HIGDJMOGOKB<PEBEFBLFADC> NKKIECLCEML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public abstract class JPPMOBBDEAK : IFFIKBKCPPD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct KMLMJIPOPKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private HPOMPKLCHAI? DNIFGMCHMLP;

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1D65400", Offset = "0x1D64200", VA = "0x181D65400")]
		public void BBGCGJHDDBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x1D65410", Offset = "0x1D64210", VA = "0x181D65410")]
		public HPOMPKLCHAI ELOINMIFJDK(JPPMOBBDEAK MOFDLEIPNFE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	protected readonly BODFBMBPPDB KFLCPEEFEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected readonly NNBKMHBHPNK EMGNHFMAECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private KMLMJIPOPKD JKKFLLNJDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private readonly BPKAEMLNDGF ELMLJEGBKGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly List<FBKCDIJIELP> AHCGAJHLPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly List<BGKFOCDBAPM> CDAIDLECDGP;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IEnumerable<StaticEdge> LEOOKEDMDMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x1D64090", Offset = "0x1D62E90", VA = "0x181D64090", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public DisplayKind LLNCBCONIGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B91C0", Offset = "0x7B7FC0", VA = "0x1807B91C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public ANCACCNALNI<IAFEEIBLHGA> BMCAEKDFEKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D64540", Offset = "0x1D63340", VA = "0x181D64540", Slot = "6")]
		get
		{
			return default(ANCACCNALNI<IAFEEIBLHGA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public AECOCOKCBMB GANFHJFEMEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x18F85D0", Offset = "0x18F73D0", VA = "0x1818F85D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public HEGBDEBAFPD JLNHAPFFIGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x1D63930", Offset = "0x1D62730", VA = "0x181D63930", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	protected HPOMPKLCHAI IONJLDJAJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x1D63930", Offset = "0x1D62730", VA = "0x181D63930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public PortImage APFOPGFCLPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1D641E0", Offset = "0x1D62FE0", VA = "0x181D641E0", Slot = "12")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public string GMLPMAJDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1F0", Offset = "0x7ABFF0", VA = "0x1807AD1F0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7AD170", Offset = "0x7ABF70", VA = "0x1807AD170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public ANCACCNALNI<HBKIGHMDJGP> LFNEIHLFHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1D63E60", Offset = "0x1D62C60", VA = "0x181D63E60", Slot = "8")]
		get
		{
			return default(ANCACCNALNI<HBKIGHMDJGP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public HIGDJMOGOKB<GCNKIDOJOMK> HBAACOMNGJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x881F60", Offset = "0x880D60", VA = "0x180881F60", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(HIGDJMOGOKB<GCNKIDOJOMK>);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x178C9C0", Offset = "0x178B7C0", VA = "0x18178C9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public abstract HIGDJMOGOKB<FOJMALNNKMD> MDEKNEHFFDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x1D64B60", Offset = "0x1D63960", VA = "0x181D64B60")]
	protected JPPMOBBDEAK(BODFBMBPPDB DBCGMJGIMKF, NNBKMHBHPNK ACNLHBNEANJ, BPKAEMLNDGF FAMNEKFAODD, HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG, bool ONFGLFDNIJE, string OHHBGJPCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x1D63D10", Offset = "0x1D62B10", VA = "0x181D63D10", Slot = "20")]
	protected virtual void FCIFMHNEBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x1D63BC0", Offset = "0x1D629C0", VA = "0x181D63BC0", Slot = "21")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x1D644E0", Offset = "0x1D632E0", VA = "0x181D644E0", Slot = "13")]
	public void OCEHPDBCINE(FBKCDIJIELP HICJEGPANEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x1D64030", Offset = "0x1D62E30", VA = "0x181D64030", Slot = "14")]
	public void GJENFHGCDOB(BGKFOCDBAPM HICJEGPANEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x1D645D0", Offset = "0x1D633D0", VA = "0x181D645D0", Slot = "15")]
	public void PMCMLCEPIAM(FFHMBDJDPHI OJBJEFDFADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x1D638D0", Offset = "0x1D626D0", VA = "0x181D638D0", Slot = "22")]
	protected virtual void AJBOGHNKAEF(FFHMBDJDPHI OJBJEFDFADH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x1D639D0", Offset = "0x1D627D0", VA = "0x181D639D0")]
	private void CLICGCDDBCJ(bool AIFJDDMPMMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1D64310", Offset = "0x1D63110", VA = "0x181D64310")]
	private void MDCAANANNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x1D63E80", Offset = "0x1D62C80", VA = "0x181D63E80")]
	private void GILHKBAJGMC([In] MOFCHEFEMDH FPGJFMMOIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x1D64570", Offset = "0x1D63370", VA = "0x181D64570", Slot = "16")]
	public void PJMPLPFIKDI(FBKCDIJIELP HICJEGPANEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x1D63B60", Offset = "0x1D62960", VA = "0x181D63B60", Slot = "17")]
	public void DNEKFKBIFKM(BGKFOCDBAPM HICJEGPANEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x7AD170", Offset = "0x7ABF70", VA = "0x1807AD170")]
	internal void AANHBENHAHL(string OHHBGJPCFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x1D644C0", Offset = "0x1D632C0", VA = "0x181D644C0")]
	internal void MFOAIGKNBGI(GGGBOAIFIHK DNHMNAAINOD, AECOCOKCBMB HFFNCGFKMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x178C9C0", Offset = "0x178B7C0", VA = "0x18178C9C0")]
	internal void HDPAOCNCJOC(HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class NADHMEIBHJN : CIHDDONJMFL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class CDLANIEOMCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public BODFBMBPPDB circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public NNBKMHBHPNK node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public HIGDJMOGOKB<GCNKIDOJOMK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public CDLANIEOMCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D370", Offset = "0x1D5C170", VA = "0x181D5D370")]
		internal ANAGCIFPPCA JOMHLIAIIOC((int PortDescIndex, int PortIndex, BLCBNJIOAJP InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1D5D400", Offset = "0x1D5C200", VA = "0x181D5D400")]
		internal NOHIFCCDICB LKONCMBBJDB(CEBKHPKPJDG i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct CAGADFPADLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public NADHMEIBHJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private INFNPELKBBP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1D5CB40", Offset = "0x1D5B940", VA = "0x181D5CB40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x1D5CFA0", Offset = "0x1D5BDA0", VA = "0x181D5CFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct PIDOKOAALDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public NADHMEIBHJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public HIGDJMOGOKB<PCHPOCELAEL> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private INFNPELKBBP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x1D6FC40", Offset = "0x1D6EA40", VA = "0x181D6FC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x1D6FF90", Offset = "0x1D6ED90", VA = "0x181D6FF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct LLFMNJFLKFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public NADHMEIBHJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public HIGDJMOGOKB<DNDJFJCMJLC> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private INFNPELKBBP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x1D658D0", Offset = "0x1D646D0", VA = "0x181D658D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x1D65C20", Offset = "0x1D64A20", VA = "0x181D65C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct HDBGKNPKEKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public NADHMEIBHJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public HIGDJMOGOKB<PCHPOCELAEL> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public HIGDJMOGOKB<PCHPOCELAEL> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private INFNPELKBBP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1D60AC0", Offset = "0x1D5F8C0", VA = "0x181D60AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x1D60E10", Offset = "0x1D5FC10", VA = "0x181D60E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct BJPGKNGOAIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public NADHMEIBHJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public HIGDJMOGOKB<DNDJFJCMJLC> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public HIGDJMOGOKB<DNDJFJCMJLC> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private INFNPELKBBP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x1D5A530", Offset = "0x1D59330", VA = "0x181D5A530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x1D5A880", Offset = "0x1D59680", VA = "0x181D5A880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct ANHAKMFPIBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public NADHMEIBHJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private INFNPELKBBP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x1D57D20", Offset = "0x1D56B20", VA = "0x181D57D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1D58190", Offset = "0x1D56F90", VA = "0x181D58190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct GCELIJLOHHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public NADHMEIBHJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private INFNPELKBBP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F9A0", Offset = "0x1D5E7A0", VA = "0x181D5F9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FCF0", Offset = "0x1D5EAF0", VA = "0x181D5FCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct GMHHEPDHDBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public NADHMEIBHJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public HIGDJMOGOKB<PCHPOCELAEL> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private INFNPELKBBP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1D5FFB0", Offset = "0x1D5EDB0", VA = "0x181D5FFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1D60300", Offset = "0x1D5F100", VA = "0x181D60300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private struct BOGIJEIGGPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public NADHMEIBHJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public HIGDJMOGOKB<DNDJFJCMJLC> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private INFNPELKBBP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1D5C780", Offset = "0x1D5B580", VA = "0x181D5C780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1D5CAD0", Offset = "0x1D5B8D0", VA = "0x181D5CAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct NOEIHPJJAOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public NADHMEIBHJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public LCMIKIAAANJ type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public HIGDJMOGOKB<PCHPOCELAEL> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private INFNPELKBBP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1D6DF50", Offset = "0x1D6CD50", VA = "0x181D6DF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1D6E2E0", Offset = "0x1D6D0E0", VA = "0x181D6E2E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private struct JOHHAPKHAAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public NADHMEIBHJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public LCMIKIAAANJ type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public HIGDJMOGOKB<DNDJFJCMJLC> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private INFNPELKBBP <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private TaskAwaiter<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1D634D0", Offset = "0x1D622D0", VA = "0x181D634D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x1D63860", Offset = "0x1D62660", VA = "0x181D63860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly bool DGAOIILHPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly BODFBMBPPDB KFLCPEEFEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly bool MHIHBMBLPKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private OEFOIDFOPKJ<CCHBPKLALHB, ANAGCIFPPCA> DGLPGGCKNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private OEFOIDFOPKJ<CCHBPKLALHB, HPOLKCOMHFH> OFDLIAKHABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly NNBKMHBHPNK EMGNHFMAECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private OEFOIDFOPKJ<PEBEFBLFADC, NOHIFCCDICB> HNLLCEMNANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private OEFOIDFOPKJ<PEBEFBLFADC, OKHGDDJOAOK> KDJCJFLBPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private string? OBFHNGJPJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly NHHCCMICPDM EOMECNLJJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private HIGDJMOGOKB<GCNKIDOJOMK> CKEKMFHALHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly bool POBEDLCOJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	[CompilerGenerated]
	private Action? HJJKGCDCJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[CompilerGenerated]
	private Action? BCCICFMMKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[CompilerGenerated]
	private Action? FNECCPAJJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	[CompilerGenerated]
	private Action<HIGDJMOGOKB<CCHBPKLALHB>>? JLAHAFDJLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	[CompilerGenerated]
	private Action<HIGDJMOGOKB<PEBEFBLFADC>>? JJPNABNAAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	[CompilerGenerated]
	private CIHDDONJMFL.FDOEIBFLPBL? DJDMAFPBHHB;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public bool CLCLBLEDHPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1D6CC60", Offset = "0x1D6BA60", VA = "0x181D6CC60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public bool KHJLFNBFBOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1D6B410", Offset = "0x1D6A210", VA = "0x181D6B410", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public bool HFAKLPHHAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1D69200", Offset = "0x1D68000", VA = "0x181D69200", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public ANCACCNALNI<IAFEEIBLHGA> BMCAEKDFEKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1D6CD20", Offset = "0x1D6BB20", VA = "0x181D6CD20", Slot = "7")]
		get
		{
			return default(ANCACCNALNI<IAFEEIBLHGA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool HNHAPAFLALE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D67B50", Offset = "0x1D66950", VA = "0x181D67B50", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public OEFOIDFOPKJ<CCHBPKLALHB, HPOLKCOMHFH> DFKAJLOBNOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "9")]
		get
		{
			return default(OEFOIDFOPKJ<CCHBPKLALHB, HPOLKCOMHFH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public string GMLPMAJDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x1D674B0", Offset = "0x1D662B0", VA = "0x181D674B0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public ANCACCNALNI<HBKIGHMDJGP> LFNEIHLFHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x1D69F70", Offset = "0x1D68D70", VA = "0x181D69F70", Slot = "11")]
		get
		{
			return default(ANCACCNALNI<HBKIGHMDJGP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public OEFOIDFOPKJ<PEBEFBLFADC, OKHGDDJOAOK> BBDPMGGPADA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1F0", Offset = "0x7ABFF0", VA = "0x1807AD1F0", Slot = "12")]
		get
		{
			return default(OEFOIDFOPKJ<PEBEFBLFADC, OKHGDDJOAOK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public HIGDJMOGOKB<GCNKIDOJOMK> HBAACOMNGJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x9B9F80", Offset = "0x9B8D80", VA = "0x1809B9F80", Slot = "13")]
		get
		{
			return default(HIGDJMOGOKB<GCNKIDOJOMK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action? HAFEHGMLNPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C7D0", Offset = "0x1D6B5D0", VA = "0x181D6C7D0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x1D67410", Offset = "0x1D66210", VA = "0x181D67410", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? NJCICJBCAFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1D6CD50", Offset = "0x1D6BB50", VA = "0x181D6CD50", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x1D69650", Offset = "0x1D68450", VA = "0x181D69650", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<HIGDJMOGOKB<CCHBPKLALHB?>, HIGDJMOGOKB<CCHBPKLALHB?>>? HFKMLMJJHKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x1D6CE00", Offset = "0x1D6BC00", VA = "0x181D6CE00", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x1D68470", Offset = "0x1D67270", VA = "0x181D68470", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<HIGDJMOGOKB<PEBEFBLFADC?>, HIGDJMOGOKB<PEBEFBLFADC?>>? BBMPOEFAFLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1D6BC70", Offset = "0x1D6AA70", VA = "0x181D6BC70", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C370", Offset = "0x1D6B170", VA = "0x181D6C370", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<HIGDJMOGOKB<CCHBPKLALHB?>, HPOLKCOMHFH?>? KPCNMFEDMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x1D683B0", Offset = "0x1D671B0", VA = "0x181D683B0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x1D67CE0", Offset = "0x1D66AE0", VA = "0x181D67CE0", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<HIGDJMOGOKB<CCHBPKLALHB?>>? POBNJMNPPPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C2B0", Offset = "0x1D6B0B0", VA = "0x181D6C2B0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x1D6CEC0", Offset = "0x1D6BCC0", VA = "0x181D6CEC0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<HIGDJMOGOKB<CCHBPKLALHB?>, HPOLKCOMHFH?>? OPDPMKJKEKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x1D69590", Offset = "0x1D68390", VA = "0x181D69590", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x1D6CF80", Offset = "0x1D6BD80", VA = "0x181D6CF80", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<HIGDJMOGOKB<PEBEFBLFADC?>, OKHGDDJOAOK?>? CBPMIJBBCJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x1D69700", Offset = "0x1D68500", VA = "0x181D69700", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x1D6BD30", Offset = "0x1D6AB30", VA = "0x181D6BD30", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<HIGDJMOGOKB<PEBEFBLFADC?>>? JEIKLFPLNMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x1D682F0", Offset = "0x1D670F0", VA = "0x181D682F0", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x1D69140", Offset = "0x1D67F40", VA = "0x181D69140", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<HIGDJMOGOKB<PEBEFBLFADC?>, OKHGDDJOAOK?>? CICBEJGOPJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1D6AE10", Offset = "0x1D69C10", VA = "0x181D6AE10", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x1D6A500", Offset = "0x1D69300", VA = "0x181D6A500", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1D6D040", Offset = "0x1D6BE40", VA = "0x181D6D040")]
	private NADHMEIBHJN(bool ONFGLFDNIJE, BODFBMBPPDB DBCGMJGIMKF, bool EIBGKLGBOOG, OEFOIDFOPKJ<CCHBPKLALHB, ANAGCIFPPCA> LNIGABDEMDD, OEFOIDFOPKJ<CCHBPKLALHB, HPOLKCOMHFH> NDFCCPHEFOL, NNBKMHBHPNK ACNLHBNEANJ, OEFOIDFOPKJ<PEBEFBLFADC, NOHIFCCDICB> MIDLLPANDIG, OEFOIDFOPKJ<PEBEFBLFADC, OKHGDDJOAOK> MGFPCFJPFGF, string? OLNIEADKLEI, NHHCCMICPDM MJBOFGPCGPH, HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG, bool HPEKJEGJNJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x1D6B700", Offset = "0x1D6A500", VA = "0x181D6B700")]
	public static NADHMEIBHJN KJKFMOENPNA(bool ONFGLFDNIJE, BODFBMBPPDB DBCGMJGIMKF, bool EIBGKLGBOOG, NNBKMHBHPNK ACNLHBNEANJ, NHHCCMICPDM MJBOFGPCGPH, HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG, bool HPEKJEGJNJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1D697C0", Offset = "0x1D685C0", VA = "0x181D697C0")]
	private void FCIFMHNEBDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1D68640", Offset = "0x1D67440", VA = "0x181D68640", Slot = "45")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x1D6B0F0", Offset = "0x1D69EF0", VA = "0x181D6B0F0", Slot = "34")]
	[AsyncStateMachine(typeof(CAGADFPADLA))]
	public Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM?>>? JABEMGMFKAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x1D6B1E0", Offset = "0x1D69FE0", VA = "0x181D6B1E0")]
	private (GILIPFJAGFL?, int)? JCOPLMMJPJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x1D6B000", Offset = "0x1D69E00", VA = "0x181D6B000")]
	private void ILAJCGAOGAD(int LHGGOFJBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x11BC3C0", Offset = "0x11BB1C0", VA = "0x1811BC3C0")]
	private void GFLFGGKAAJM(int LHGGOFJBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x1D6BDF0", Offset = "0x1D6ABF0", VA = "0x181D6BDF0")]
	private void LOGABOKHCEN(int MLHCMLJOKNM, int PLDLMABEGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x1D6A080", Offset = "0x1D68E80", VA = "0x181D6A080")]
	private void JHHEIGMOEEO(int LHGGOFJBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x1D67610", Offset = "0x1D66410", VA = "0x181D67610")]
	private void APMPILMALLP(int LHGGOFJBGGA, int ICGCNNPCJCB, BLCBNJIOAJP KADGOLMMJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1D6B540", Offset = "0x1D6A340", VA = "0x181D6B540")]
	private void KENHKPMFENF(int AIFJDDMPMMF, int ICGCNNPCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C870", Offset = "0x1D6B670", VA = "0x181D6C870")]
	private void NMMEAFOPAGN(int AIFJDDMPMMF, int ICGCNNPCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x1D6A0A0", Offset = "0x1D68EA0", VA = "0x181D6A0A0")]
	private void GFHBBCPKEBL(int LHGGOFJBGGA, int ICGCNNPCJCB, BLCBNJIOAJP KADGOLMMJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x1D692C0", Offset = "0x1D680C0", VA = "0x181D692C0")]
	private void EJMPJGDGBKN(int LHGGOFJBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x8CD360", Offset = "0x8CC160", VA = "0x1808CD360")]
	private void DNLNIMEEEKM(int LHGGOFJBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1D6B450", Offset = "0x1D6A250", VA = "0x181D6B450")]
	private void JPPOFACLAAI(int LHGGOFJBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x11BC3C0", Offset = "0x11BB1C0", VA = "0x1811BC3C0")]
	private void ENHFBBHCHPK(int LHGGOFJBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C8C0", Offset = "0x1D6B6C0", VA = "0x181D6C8C0")]
	private void ODAAIIGHHII(int MLHCMLJOKNM, int PLDLMABEGOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x1D6A080", Offset = "0x1D68E80", VA = "0x181D6A080")]
	private void FLJMMDLNGAB(int LHGGOFJBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x1D67DA0", Offset = "0x1D66BA0", VA = "0x181D67DA0")]
	private void CHPINMEPANB(int LHGGOFJBGGA, int ICGCNNPCJCB, CEBKHPKPJDG KADGOLMMJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1D6B6B0", Offset = "0x1D6A4B0", VA = "0x181D6B6B0")]
	private void KJFOMGJFNNJ(int AIFJDDMPMMF, int ICGCNNPCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x1D69410", Offset = "0x1D68210", VA = "0x181D69410")]
	private void EMMNMOGPKEH(int AIFJDDMPMMF, int ICGCNNPCJCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1D6A5C0", Offset = "0x1D693C0", VA = "0x181D6A5C0")]
	private void GOMLFMHPLIG(int LHGGOFJBGGA, int ICGCNNPCJCB, CEBKHPKPJDG KADGOLMMJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C560", Offset = "0x1D6B360", VA = "0x181D6C560")]
	private void NEIGOFGGOFL(int LHGGOFJBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8CD360", Offset = "0x8CC160", VA = "0x1808CD360")]
	private void JMJPJIJHLAL(int LHGGOFJBGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x1D67BD0", Offset = "0x1D669D0", VA = "0x181D67BD0", Slot = "35")]
	[AsyncStateMachine(typeof(PIDOKOAALDL))]
	public Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM?>>? BJABBNDMDFK(HIGDJMOGOKB<PCHPOCELAEL> PIFGCICDBNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x1D68530", Offset = "0x1D67330", VA = "0x181D68530", Slot = "36")]
	[AsyncStateMachine(typeof(LLFMNJFLKFC))]
	public Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM?>>? DGHIKDPEDFB(HIGDJMOGOKB<DNDJFJCMJLC> CHNHDOJLHBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C6B0", Offset = "0x1D6B4B0", VA = "0x181D6C6B0", Slot = "37")]
	[AsyncStateMachine(typeof(HDBGKNPKEKD))]
	public Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM?>>? NHGHBFOGOLJ(HIGDJMOGOKB<PCHPOCELAEL> PIFGCICDBNJ, HIGDJMOGOKB<PCHPOCELAEL> HAOJPCCALII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C190", Offset = "0x1D6AF90", VA = "0x181D6C190", Slot = "38")]
	[AsyncStateMachine(typeof(BJPGKNGOAIJ))]
	public Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM?>>? MCIBMGHDONE(HIGDJMOGOKB<DNDJFJCMJLC> CHNHDOJLHBB, HIGDJMOGOKB<DNDJFJCMJLC> HAOJPCCALII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x1D69F90", Offset = "0x1D68D90", VA = "0x181D69F90", Slot = "39")]
	[AsyncStateMachine(typeof(ANHAKMFPIBN))]
	public Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM?>>? FIBMONAKENP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x1D6B590", Offset = "0x1D6A390", VA = "0x181D6B590", Slot = "40")]
	[AsyncStateMachine(typeof(GCELIJLOHHE))]
	public Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> KEODIIEHCPD(string LNLOEIOGGHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x1D69460", Offset = "0x1D68260", VA = "0x181D69460", Slot = "41")]
	[AsyncStateMachine(typeof(GMHHEPDHDBG))]
	public Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> EMNMMGNCMPJ(HIGDJMOGOKB<PCHPOCELAEL> PIFGCICDBNJ, string OHHBGJPCFJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x1D674E0", Offset = "0x1D662E0", VA = "0x181D674E0", Slot = "42")]
	[AsyncStateMachine(typeof(BOGIJEIGGPC))]
	public Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> APDOIHENOIM(HIGDJMOGOKB<DNDJFJCMJLC> CHNHDOJLHBB, string OHHBGJPCFJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x1D6C430", Offset = "0x1D6B230", VA = "0x181D6C430", Slot = "43")]
	[AsyncStateMachine(typeof(NOEIHPJJAOB))]
	public Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> NCLGFEAABNF(HIGDJMOGOKB<PCHPOCELAEL> PIFGCICDBNJ, LCMIKIAAANJ HFFNCGFKMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x1D6AED0", Offset = "0x1D69CD0", VA = "0x181D6AED0", Slot = "44")]
	[AsyncStateMachine(typeof(JOHHAPKHAAL))]
	public Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> IGIKIPFOGFD(HIGDJMOGOKB<DNDJFJCMJLC> CHNHDOJLHBB, LCMIKIAAANJ HFFNCGFKMBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x1D6AA40", Offset = "0x1D69840", VA = "0x181D6AA40")]
	internal void HDPAOCNCJOC(HIGDJMOGOKB<GCNKIDOJOMK> NKKIECLCEML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public sealed class EMHHJOLCDPN : EJMOLLGHOHJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public interface NFCLJJJDKMJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000085")]
		GGGBOAIFIHK IHNCBLLKBHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<PBEFNMAHMLC> GANAJJIABMD(CancellationToken HHBHDBLGMFA);

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<PGADOMLEMBK> MNCOEOPALLM(CancellationToken HHBHDBLGMFA);

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<OLOGHCFCDMC> BAFGBAFAEPF(CancellationToken HHBHDBLGMFA);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct PAAODIGLAFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder<EMHHJOLCDPN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public BODFBMBPPDB circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public PBEFNMAHMLC roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public PGADOMLEMBK superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private NFCLJJJDKMJ <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private PGADOMLEMBK <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private TaskAwaiter<PBEFNMAHMLC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private TaskAwaiter<PGADOMLEMBK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private TaskAwaiter<OLOGHCFCDMC> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<CDDENKAFMJG> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x1D6EB50", Offset = "0x1D6D950", VA = "0x181D6EB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x1D6F500", Offset = "0x1D6E300", VA = "0x181D6F500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private readonly CDDENKAFMJG EODOJHJDJOL;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public CDDENKAFMJG PLCICDANLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	private EMHHJOLCDPN(CDDENKAFMJG IICMJLBKOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E050", Offset = "0x1D5CE50", VA = "0x181D5E050")]
	[AsyncStateMachine(typeof(PAAODIGLAFD))]
	public static Task<EMHHJOLCDPN> CLKFGJJOIEK(BODFBMBPPDB DBCGMJGIMKF, PBEFNMAHMLC? JJGMEBEMOEB, PGADOMLEMBK? KOLMPBPLBDO, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x1D5E1B0", Offset = "0x1D5CFB0", VA = "0x181D5E1B0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public readonly struct MBPGECPHPPC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	private struct PMECBJOMMEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public MBPGECPHPPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public BJFPGMKAPEG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private TaskAwaiter<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x1D704B0", Offset = "0x1D6F2B0", VA = "0x181D704B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x1D70740", Offset = "0x1D6F540", VA = "0x181D70740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct GONOEJCBIKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<bool, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public KHOGAKDFAOE rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public PBEFNMAHMLC circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public PGADOMLEMBK superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public MBPGECPHPPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private BJFPGMKAPEG[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private TaskAwaiter<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1D60600", Offset = "0x1D5F400", VA = "0x181D60600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x1D609E0", Offset = "0x1D5F7E0", VA = "0x181D609E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct FPBFAGAMDEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public MBPGECPHPPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private TaskAwaiter<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F5B0", Offset = "0x1D5E3B0", VA = "0x181D5F5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x1D5F890", Offset = "0x1D5E690", VA = "0x181D5F890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private readonly DJONIENCBMN JNHEGEKEPLK;

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x8D4A60", Offset = "0x8D3860", VA = "0x1808D4A60")]
	public MBPGECPHPPC(DJONIENCBMN LKEMBNMEKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x1D662D0", Offset = "0x1D650D0", VA = "0x181D662D0")]
	[AsyncStateMachine(typeof(PMECBJOMMEF))]
	private Task<FBEPHKHKLJE<object, BEPKJMJJJMM>> DBCMFELJODP(BJFPGMKAPEG ENHEBPDFNME, bool JEBBEOLHMIA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x1D66170", Offset = "0x1D64F70", VA = "0x181D66170")]
	[AsyncStateMachine(typeof(GONOEJCBIKL))]
	public Task<FBEPHKHKLJE<bool, BEPKJMJJJMM?>>? CCANKKPPIMP(int PMMNCFHMBPD, KHOGAKDFAOE? HHFGPPAPFJC, PBEFNMAHMLC? MBNJMAICHBF, PGADOMLEMBK? KOLMPBPLBDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x1D66400", Offset = "0x1D65200", VA = "0x181D66400")]
	[AsyncStateMachine(typeof(FPBFAGAMDEC))]
	public Task<FBEPHKHKLJE<JEGFFGGMBEH, BEPKJMJJJMM>> ECEAPGIDAKG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public sealed class IIOPMPDCKEG : ADJBEMJLPBC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly AGFOPNMFKCM AAEFJGDCHBP;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public AGFOPNMFKCM MLICMIJBFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	private IIOPMPDCKEG(AGFOPNMFKCM MJNAEIAPHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x1D62A90", Offset = "0x1D61890", VA = "0x181D62A90")]
	public static IIOPMPDCKEG CINNELLPCMC(BODFBMBPPDB DBCGMJGIMKF, KHOGAKDFAOE JNPCHOEAOCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x1D62C60", Offset = "0x1D61A60", VA = "0x181D62C60", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface EFAPLJIBJFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	MPILBLNPGJG MPAGNCPFFBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	EKEPFKCLHFA AJJONCHALDM
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	MKBDDGFNINH GNDLFFFMCKP
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	PHNDNLMAHGD LONMJHNBLFB
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	BAKHJGAMGLO ABOANDBGFGB
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public interface FBDFODNOFNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	EFAPLJIBJFH? IHBNPAKBPMF
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	bool LICKKMNBHJM
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	bool GEDFHPAGPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<EFAPLJIBJFH?>? EKBPDNMAFND();

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task ALKFGMCFLHJ(BODFBMBPPDB DBCGMJGIMKF, KHOGAKDFAOE JNPCHOEAOCL, PBEFNMAHMLC? IMFELFINHNF, PGADOMLEMBK? NENJNDANDMP);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[HLOIEFEINOD("IStaticCV2Instance")]
public interface EJMOLLGHOHJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	CDDENKAFMJG PLCICDANLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[HLOIEFEINOD("IStaticEVInstance")]
public interface ADJBEMJLPBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000090")]
	AGFOPNMFKCM MLICMIJBFFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public sealed class EMILAHPBFLO : GFPHBHPBJGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly BODFBMBPPDB KFLCPEEFEAL;

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public PGLABOAEAFE? AHFNEPHAKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1D5E2A0", Offset = "0x1D5D0A0", VA = "0x181D5E2A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	internal EMILAHPBFLO(BODFBMBPPDB DBCGMJGIMKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public sealed class PHNDNLMAHGD : PGLABOAEAFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly EJMOLLGHOHJ BMCLHGENKOJ;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public LBCGKIHIKGC DBCMFELJODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1D6FAD0", Offset = "0x1D6E8D0", VA = "0x181D6FAD0", Slot = "4")]
		get
		{
			return default(LBCGKIHIKGC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public GKEJEDHFFJG CJINAFDHDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1D6FB30", Offset = "0x1D6E930", VA = "0x181D6FB30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public ANCACCNALNI<IAFEEIBLHGA> HHCPIDCCBCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1D6FB90", Offset = "0x1D6E990", VA = "0x181D6FB90", Slot = "6")]
		get
		{
			return default(ANCACCNALNI<IAFEEIBLHGA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public CDDENKAFMJG PHJHFHNKPFD
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x1D6FBF0", Offset = "0x1D6E9F0", VA = "0x181D6FBF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public PHNDNLMAHGD(EJMOLLGHOHJ FJEKHMPDEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x1D6FA60", Offset = "0x1D6E860", VA = "0x181D6FA60")]
	public bool FIJACKJELFH([In] ANCACCNALNI<IAFEEIBLHGA> MOJJMHEPCMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x1D6FA60", Offset = "0x1D6E860", VA = "0x181D6FA60", Slot = "8")]
	private bool NNODLFHCCDO([In] ANCACCNALNI<IAFEEIBLHGA> MOJJMHEPCMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class PKEFKGLBKAC
{
	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1D70000", Offset = "0x1D6EE00", VA = "0x181D70000")]
	public static BOCBPIMJLDE<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB, LKOCHJGKODG.CNIKFMHFKKB<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB>> PNJAJKKINOI([In] this BOCBPIMJLDE<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB, LKOCHJGKODG.CNIKFMHFKKB<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB>> OJLPACPPCGH)
	{
		return default(BOCBPIMJLDE<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB, LKOCHJGKODG.CNIKFMHFKKB<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public sealed class BCEDGGBFDNC : AMBHOMEMAJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly BODFBMBPPDB KFLCPEEFEAL;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool GEDFHPAGPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1D5A510", Offset = "0x1D59310", VA = "0x181D5A510", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	internal BCEDGGBFDNC(BODFBMBPPDB DBCGMJGIMKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class NBFFMEGJPNK : JEGOOMBHNCI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private struct HHMAGLCLAOM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public AsyncTaskMethodBuilder<BFJFPHMLDHE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public NBFFMEGJPNK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private TaskAwaiter<EFAPLJIBJFH?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x1D60EF0", Offset = "0x1D5FCF0", VA = "0x181D60EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x1D611A0", Offset = "0x1D5FFA0", VA = "0x181D611A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly BODFBMBPPDB KFLCPEEFEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private IReadOnlyList<ANCACCNALNI<IOKIBFLHGGE>>? CBNMBGPMGFJ;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public BFJFPHMLDHE? AHFNEPHAKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1D6DD30", Offset = "0x1D6CB30", VA = "0x181D6DD30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public BAKHJGAMGLO? HEHHBOLEMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1D6D740", Offset = "0x1D6C540", VA = "0x181D6D740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool LEOGHEHGMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1D6D140", Offset = "0x1D6BF40", VA = "0x181D6D140", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool DMAHMGLKIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1D6D490", Offset = "0x1D6C290", VA = "0x181D6D490", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	internal NBFFMEGJPNK(BODFBMBPPDB DBCGMJGIMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x1D6D3A0", Offset = "0x1D6C1A0", VA = "0x181D6D3A0", Slot = "7")]
	[AsyncStateMachine(typeof(HHMAGLCLAOM))]
	public Task<BFJFPHMLDHE> DHHBLGCACEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x1D6D9C0", Offset = "0x1D6C7C0", VA = "0x181D6D9C0")]
	internal Dictionary<ANCACCNALNI<IAFEEIBLHGA>, Guid> NJCLKBNFNOO(IEnumerable<OBGGKDBBBAO> LICAFNDBFNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x1D6D1A0", Offset = "0x1D6BFA0", VA = "0x181D6D1A0")]
	public FBEPHKHKLJE<NOAOFBPLMOE, LNKCFDGMPAP> BHOAIGKMAFH([In] NOAOFBPLMOE AOHKKKCIKOB, IEnumerable<OBGGKDBBBAO> GMHBJMKFBGH, int FIOFNOKLDIP)
	{
		return default(FBEPHKHKLJE<NOAOFBPLMOE, LNKCFDGMPAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x1D6DDB0", Offset = "0x1D6CBB0", VA = "0x181D6DDB0")]
	internal static HOBJMOMMPME OLEBEDJDCDE(NHFKFAOHFOG OFBPHGKLMGO, NNBKMHBHPNK ACNLHBNEANJ)
	{
		return default(HOBJMOMMPME);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x1D6D7C0", Offset = "0x1D6C5C0", VA = "0x181D6D7C0", Slot = "8")]
	private FBEPHKHKLJE<NOAOFBPLMOE, LNKCFDGMPAP> KAENKFHEFMB([In] NOAOFBPLMOE AOHKKKCIKOB, IEnumerable<OBGGKDBBBAO> GMHBJMKFBGH, int FIOFNOKLDIP)
	{
		return default(FBEPHKHKLJE<NOAOFBPLMOE, LNKCFDGMPAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x1D6D4F0", Offset = "0x1D6C2F0", VA = "0x181D6D4F0")]
	[CompilerGenerated]
	internal static HOBJMOMMPME HGNFLNHKLEK(NHFKFAOHFOG JFNLKBBJOLD, NNBKMHBHPNK ADAFGICFLBM)
	{
		return default(HOBJMOMMPME);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public sealed class BAKHJGAMGLO : BFJFPHMLDHE
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	internal static class IJIFMFCFBMN
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private sealed class HHJNOILEBLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public CDDENKAFMJG state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public OKIFPBKFAPF spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public HHJNOILEBLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x1D72880", Offset = "0x1D71680", VA = "0x181D72880")]
			internal bool IKHPDMBGBDJ(OKOIBNGPCCE n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class EKNEIGGCGDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
			public EKNEIGGCGDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x1D72710", Offset = "0x1D71510", VA = "0x181D72710")]
			internal void KPHGLPKMOBF(OKOIBNGPCCE n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x1D75770", Offset = "0x1D74570", VA = "0x181D75770")]
		public static FBEPHKHKLJE<BFJFPHMLDHE.GIBFEOCMJKI, LNKCFDGMPAP> MICHEHPNDIJ(BAKHJGAMGLO CNFBJPGPBBJ, [In] BFJFPHMLDHE.INPPOBPCJGO BBFBHKMAMKC)
		{
			return default(FBEPHKHKLJE<BFJFPHMLDHE.GIBFEOCMJKI, LNKCFDGMPAP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1D74590", Offset = "0x1D73390", VA = "0x181D74590")]
		internal static FBEPHKHKLJE<(EHPANDNONKE, PMCDPOLKPAA), BEPKJMJJJMM> BPJOMJGPNOF(BAKHJGAMGLO CNFBJPGPBBJ, PMCDPOLKPAA PLCLEDJKMOP, bool IIKDFCPKJLA, [In] ANCACCNALNI<IAFEEIBLHGA> CLELGMGCPHB, [In] int? LJHIBKENNCG, [In] HOBJMOMMPME? HJAMOHOLJFN, [In] HOBJMOMMPME? LGOFGGDFNNB)
		{
			return default(FBEPHKHKLJE<(EHPANDNONKE, PMCDPOLKPAA), BEPKJMJJJMM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x1D752E0", Offset = "0x1D740E0", VA = "0x181D752E0")]
		private static void FJHGFIEKFAN(bool IIKDFCPKJLA, OBGGKDBBBAO BKFACKEMDIF, EHPANDNONKE DDNJNCNOFGK, [In] ANCACCNALNI<IAFEEIBLHGA> CLELGMGCPHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x1D74090", Offset = "0x1D72E90", VA = "0x181D74090")]
		public static void AFLFCAFBNMJ(FJIKMMJKKDA KIOGOGEPALG, [In] BFJFPHMLDHE.GFNEHLPCEOF OEMJNCABAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x1D744A0", Offset = "0x1D732A0", VA = "0x181D744A0")]
		[CompilerGenerated]
		internal static bool AKNBHNCHEIE(CDDENKAFMJG JEGCPPIHDOJ, OKIFPBKFAPF ACPEGJCHLEE, OKOIBNGPCCE OJOHKELNAFD)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly BODFBMBPPDB KFLCPEEFEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly EJMOLLGHOHJ BMCLHGENKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly ADJBEMJLPBC INMGKFMBHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly LGPFIMPOBIK IOAAMJFLGOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly NBFFMEGJPNK JLLOANEHNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private Dictionary<ANCACCNALNI<HBKIGHMDJGP>, JPABOEDBDKB> BDPMFLGPAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	[CompilerGenerated]
	private Action<ANCACCNALNI<HBKIGHMDJGP>>? LNODCIDLENL;

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x1D5A190", Offset = "0x1D58F90", VA = "0x181D5A190")]
	public BAKHJGAMGLO(BODFBMBPPDB DBCGMJGIMKF, EJMOLLGHOHJ FJEKHMPDEFG, ADJBEMJLPBC DELKDDPGCEC, NBFFMEGJPNK AHJBDHCAPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x1D59080", Offset = "0x1D57E80", VA = "0x181D59080")]
	public JPABOEDBDKB? JHGFAAKMFHL([In] ANCACCNALNI<HBKIGHMDJGP> IBLKHIACFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x1D59000", Offset = "0x1D57E00", VA = "0x181D59000")]
	private void JEAIPBDFNAM(ANCACCNALNI<HBKIGHMDJGP> IBLKHIACFEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x1D591F0", Offset = "0x1D57FF0", VA = "0x181D591F0")]
	private JPABOEDBDKB? JKGPCCCOEJK([In] ANCACCNALNI<HBKIGHMDJGP> IBLKHIACFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x1D596E0", Offset = "0x1D584E0", VA = "0x181D596E0")]
	public NNBKMHBHPNK? LPKFFDHDFNA([In] ANCACCNALNI<HBKIGHMDJGP> IBLKHIACFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1D596D0", Offset = "0x1D584D0", VA = "0x181D596D0")]
	public MPOMNDOPLNE? NPNBIGBKODP([In] ANCACCNALNI<IAFEEIBLHGA> MOJJMHEPCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1D5A0F0", Offset = "0x1D58EF0", VA = "0x181D5A0F0")]
	private OKIFPBKFAPF? OPMGFMONIHN([In] ANCACCNALNI<IAFEEIBLHGA> MOJJMHEPCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1D592A0", Offset = "0x1D580A0", VA = "0x181D592A0")]
	private MPOMNDOPLNE? KLABDOALGIJ([In] ANCACCNALNI<IAFEEIBLHGA> MOJJMHEPCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x1D5A000", Offset = "0x1D58E00", VA = "0x181D5A000", Slot = "6")]
	public IEnumerable<LCMIKIAAANJ> ODFHIDMLNNH(bool FPCIEEDLLEM, bool MGKHNENDBGE, bool NGEPIBDGOPH, bool CGBNBDMLDDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x1D58910", Offset = "0x1D57710", VA = "0x181D58910")]
	public FBEPHKHKLJE<BFJFPHMLDHE.GIBFEOCMJKI, LNKCFDGMPAP> KDCGBPIACAN([In] BFJFPHMLDHE.INPPOBPCJGO BBFBHKMAMKC)
	{
		return default(FBEPHKHKLJE<BFJFPHMLDHE.GIBFEOCMJKI, LNKCFDGMPAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x1D59C10", Offset = "0x1D58A10", VA = "0x181D59C10", Slot = "8")]
	public FBEPHKHKLJE<OAAEMBPGCAG, LNKCFDGMPAP> OCAIGEBIHKC(ANCACCNALNI<IAFEEIBLHGA> MOJJMHEPCMN, OAAEMBPGCAG AILIMCNKHFB, EIBKPIOMBIK OCOACKBMGKD)
	{
		return default(FBEPHKHKLJE<OAAEMBPGCAG, LNKCFDGMPAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x1D58E10", Offset = "0x1D57C10", VA = "0x181D58E10", Slot = "9")]
	public FOPELEHCDBO HONBBLPFIEK(IEnumerable<OBGGKDBBBAO> GMHBJMKFBGH)
	{
		return default(FOPELEHCDBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1D58760", Offset = "0x1D57560", VA = "0x181D58760", Slot = "10")]
	public FOPELEHCDBO ABINFLGNAMF()
	{
		return default(FOPELEHCDBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1D58270", Offset = "0x1D57070", VA = "0x181D58270")]
	private ADJHAGGBAPE AACLOHFJGHF(IBEALKOKILB JMEHKNKFECL, HIGDJMOGOKB<IAFEEIBLHGA> CIGDLOFJFDP, IEnumerable<ANCACCNALNI<IAFEEIBLHGA>> CEIGPEFAPGA, IEnumerable<ANCACCNALNI<HBKIGHMDJGP>> LIJEKDFJAPF)
	{
		return default(ADJHAGGBAPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1D58420", Offset = "0x1D57220", VA = "0x181D58420", Slot = "11")]
	public ADJHAGGBAPE AACLOHFJGHF(IBEALKOKILB JMEHKNKFECL, HIGDJMOGOKB<IAFEEIBLHGA> CIGDLOFJFDP, IEnumerable<ANCACCNALNI<HBKIGHMDJGP>> LIJEKDFJAPF, IEnumerable<OBGGKDBBBAO> GMHBJMKFBGH)
	{
		return default(ADJHAGGBAPE);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1D58A20", Offset = "0x1D57820", VA = "0x181D58A20")]
	private static IEnumerable<ANCACCNALNI<IAFEEIBLHGA>> FJNMEINPKKH(IEnumerable<OBGGKDBBBAO> GMHBJMKFBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1D59770", Offset = "0x1D58570", VA = "0x181D59770")]
	private IEnumerable<ANCACCNALNI<HBKIGHMDJGP>> NHMKJEKNICM(IEnumerable<OBGGKDBBBAO> GMHBJMKFBGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x1D58880", Offset = "0x1D57680", VA = "0x181D58880", Slot = "12")]
	public List<EEIGCPBDGBM> AHEJNPCKKHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1D59520", Offset = "0x1D58320", VA = "0x181D59520")]
	internal void KPIGJBPAGKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1D58940", Offset = "0x1D57740", VA = "0x181D58940")]
	internal Task BLFOFEPEPLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1D596D0", Offset = "0x1D584D0", VA = "0x181D596D0", Slot = "4")]
	private MPOMNDOPLNE LMAAOJPPNDA([In] ANCACCNALNI<IAFEEIBLHGA> MOJJMHEPCMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1D59580", Offset = "0x1D58380", VA = "0x181D59580", Slot = "5")]
	private JPABOEDBDKB LGBODKJADGK([In] ANCACCNALNI<HBKIGHMDJGP> IBLKHIACFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1D58910", Offset = "0x1D57710", VA = "0x181D58910", Slot = "7")]
	private FBEPHKHKLJE<BFJFPHMLDHE.GIBFEOCMJKI, LNKCFDGMPAP> BHLBECIACKJ([In] BFJFPHMLDHE.INPPOBPCJGO BBFBHKMAMKC)
	{
		return default(FBEPHKHKLJE<BFJFPHMLDHE.GIBFEOCMJKI, LNKCFDGMPAP>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1D589A0", Offset = "0x1D577A0", VA = "0x181D589A0")]
	[CompilerGenerated]
	private ALOFIKPKKAF DPIJBMGAEFB(AECOCOKCBMB PGCIMAABPAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1D58DA0", Offset = "0x1D57BA0", VA = "0x181D58DA0")]
	[CompilerGenerated]
	private NNBKMHBHPNK GDINEHBLLKI(ANCACCNALNI<HBKIGHMDJGP> PGCIMAABPAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x1D594B0", Offset = "0x1D582B0", VA = "0x181D594B0")]
	[CompilerGenerated]
	private OKIFPBKFAPF KMECBHBBIDK(ANCACCNALNI<IAFEEIBLHGA> PGCIMAABPAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public sealed class ALOFIKPKKAF : LCMIKIAAANJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct DDJDLOJLCNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<HIGDJMOGOKB<PCHPOCELAEL>, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public ALOFIKPKKAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public ANCACCNALNI<IAFEEIBLHGA> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public ANCACCNALNI<HBKIGHMDJGP> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public HIGDJMOGOKB<GCNKIDOJOMK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private TaskAwaiter<FBEPHKHKLJE<HIGDJMOGOKB<PCHPOCELAEL>, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1D723C0", Offset = "0x1D711C0", VA = "0x181D723C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1D72640", Offset = "0x1D71440", VA = "0x181D72640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct AEMPDGDMBFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<HIGDJMOGOKB<DNDJFJCMJLC>, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public ALOFIKPKKAF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public ANCACCNALNI<IAFEEIBLHGA> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public ANCACCNALNI<HBKIGHMDJGP> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public HIGDJMOGOKB<GCNKIDOJOMK> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private TaskAwaiter<FBEPHKHKLJE<HIGDJMOGOKB<DNDJFJCMJLC>, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1D71890", Offset = "0x1D70690", VA = "0x181D71890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1D71B10", Offset = "0x1D70910", VA = "0x181D71B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly AECOCOKCBMB FJOGGLODIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly EJMOLLGHOHJ BMCLHGENKOJ;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public TypeKey GLILDCEABFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8CBDA0", Offset = "0x8CABA0", VA = "0x1808CBDA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public string OKBOKIHOIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1D71CF0", Offset = "0x1D70AF0", VA = "0x181D71CF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public AECOCOKCBMB LAHBNEALMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x1D71E90", Offset = "0x1D70C90", VA = "0x181D71E90")]
	public ALOFIKPKKAF(AECOCOKCBMB GNMEHINJMJK, EJMOLLGHOHJ FJEKHMPDEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x1D71B80", Offset = "0x1D70980", VA = "0x181D71B80", Slot = "6")]
	[AsyncStateMachine(typeof(DDJDLOJLCNI))]
	public Task<FBEPHKHKLJE<HIGDJMOGOKB<PCHPOCELAEL>, BEPKJMJJJMM>> JLDKJIOGKNO(ANCACCNALNI<IAFEEIBLHGA> MOJJMHEPCMN, ANCACCNALNI<HBKIGHMDJGP> IBLKHIACFEF, HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG, string OHHBGJPCFJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x1D71D20", Offset = "0x1D70B20", VA = "0x181D71D20", Slot = "7")]
	[AsyncStateMachine(typeof(AEMPDGDMBFF))]
	public Task<FBEPHKHKLJE<HIGDJMOGOKB<DNDJFJCMJLC>, BEPKJMJJJMM>> LKAPJLLJJBP(ANCACCNALNI<IAFEEIBLHGA> MOJJMHEPCMN, ANCACCNALNI<HBKIGHMDJGP> IBLKHIACFEF, HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG, string OHHBGJPCFJD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public sealed class HPOMPKLCHAI : HEGBDEBAFPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private readonly AECOCOKCBMB CKHDHJCLJCM;

	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private static readonly HashSet<AECOCOKCBMB> HGNCFFNAHJH;

	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private static readonly HashSet<AECOCOKCBMB> NOHDDAHFCLI;

	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private static readonly HashSet<AECOCOKCBMB> OKPGAHMCBKC;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public TypeKey DIJJAKBLGBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1D73E10", Offset = "0x1D72C10", VA = "0x181D73E10", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public bool AGMGCOEHIGD
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x1D73E00", Offset = "0x1D72C00", VA = "0x181D73E00", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool NPHKJBPGCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x1D73E60", Offset = "0x1D72C60", VA = "0x181D73E60", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool GHNJKAFHAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x1D73D80", Offset = "0x1D72B80", VA = "0x181D73D80", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x1D72B00", Offset = "0x1D71900", VA = "0x181D72B00")]
	public bool IBBEFPCNIJB(string NKKIECLCEML, [Out] OGFGPHCBDEC NGCCEJPNHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public HPOMPKLCHAI(AECOCOKCBMB HBHLLIKFPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x1D72970", Offset = "0x1D71770", VA = "0x181D72970")]
	internal static TypeKey HACHGJBMICI(AECOCOKCBMB HFFNCGFKMBJ)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x1D71CF0", Offset = "0x1D70AF0", VA = "0x181D71CF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct HALBLKOIHKG : EIHKPAGLLNA.JLPNDCOHBJC<BJFPGMKAPEG, JEGFFGGMBEH>
{
	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x1D72860", Offset = "0x1D71660", VA = "0x181D72860", Slot = "4")]
	public int OFEJEBIOLGL(JEGFFGGMBEH AIFJDDMPMMF, BJFPGMKAPEG ENHEBPDFNME)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x1D72850", Offset = "0x1D71650", VA = "0x181D72850", Slot = "5")]
	public BJFPGMKAPEG JANGOONHHML(JEGFFGGMBEH AIFJDDMPMMF, BJFPGMKAPEG ENHEBPDFNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x1D72760", Offset = "0x1D71560", VA = "0x181D72760", Slot = "6")]
	public BJFPGMKAPEG DOGAAPLKLMF(JEGFFGGMBEH AIFJDDMPMMF, BJFPGMKAPEG ENHEBPDFNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x1D72810", Offset = "0x1D71610", VA = "0x181D72810", Slot = "7")]
	public IReadOnlyList<BJFPGMKAPEG> HLMIPHGIKEB(JEGFFGGMBEH AIFJDDMPMMF, BJFPGMKAPEG ENHEBPDFNME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x1D72730", Offset = "0x1D71530", VA = "0x181D72730", Slot = "8")]
	public BJFPGMKAPEG[] BCMNPIONNHK(JEGFFGGMBEH AIFJDDMPMMF, BJFPGMKAPEG ENHEBPDFNME, int BCEIOMIMEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x1D72740", Offset = "0x1D71540", VA = "0x181D72740", Slot = "9")]
	public bool DKPBGHDBCCE(JEGFFGGMBEH AIFJDDMPMMF, BJFPGMKAPEG ENHEBPDFNME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x1D727F0", Offset = "0x1D715F0", VA = "0x181D727F0", Slot = "10")]
	public bool GOCFJMGOJPP(JEGFFGGMBEH AIFJDDMPMMF, BJFPGMKAPEG ENHEBPDFNME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x1D727B0", Offset = "0x1D715B0", VA = "0x181D727B0", Slot = "11")]
	public bool EGNOCJNJOEK(JEGFFGGMBEH AIFJDDMPMMF, BJFPGMKAPEG ENHEBPDFNME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x1D72830", Offset = "0x1D71630", VA = "0x181D72830", Slot = "12")]
	public bool INDOAAOCEPK(JEGFFGGMBEH AIFJDDMPMMF, BJFPGMKAPEG ENHEBPDFNME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x1D727D0", Offset = "0x1D715D0", VA = "0x181D727D0", Slot = "13")]
	public bool FPOGCOIBPOC(JEGFFGGMBEH OCMODBFFHKK, BJFPGMKAPEG ENHEBPDFNME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x1D72790", Offset = "0x1D71590", VA = "0x181D72790", Slot = "14")]
	public bool EAKBFDNMPOA(JEGFFGGMBEH AIFJDDMPMMF, BJFPGMKAPEG ENHEBPDFNME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public abstract class COADDGLAMBN : IEMHDKADMOP
{
	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public DBFGDHNMHGG.HECNBPNPPBP MKBCNHOGBCK
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1D72370", Offset = "0x1D71170", VA = "0x181D72370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public abstract LOCEGJFBBLM.DPBEEFGICNA NFIJHMPLLIP
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public abstract BODFBMBPPDB.DGDHAKMIEGP CMCBMMHOJEM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public abstract EMHHJOLCDPN.NFCLJJJDKMJ CADIJIAIGJD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public LKOCHJGKODG.CNIKFMHFKKB<KDMILAKAAFH, BJFPGMKAPEG, BODFBMBPPDB> MLOCDHLGJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D72320", Offset = "0x1D71120", VA = "0x181D72320", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public abstract INFNPELKBBP KENDMBKJAAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public abstract GCOCIIGIFEF PNCAFKCNOFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public abstract OJFEDBNCEOP PNCHCBNKJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public abstract BOAAANKCKNK LFLGMNANANG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public abstract IDJFBGHMOGA OLGNNEDBNLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	protected COADDGLAMBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public sealed class LNHJBPJICOP : GKEJEDHFFJG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct MPGOJFEGIFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public LNHJBPJICOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public BJFPGMKAPEG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private TaskAwaiter<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x1D75F10", Offset = "0x1D74D10", VA = "0x181D75F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1D761B0", Offset = "0x1D74FB0", VA = "0x181D761B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct BLKJLHNGGJI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public AsyncTaskMethodBuilder<FBEPHKHKLJE<OBGAFDCEFFC, BEPKJMJJJMM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public LNHJBPJICOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public IReadOnlyList<BJFPGMKAPEG> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private TaskAwaiter<FBEPHKHKLJE<object, BEPKJMJJJMM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x1D71F30", Offset = "0x1D70D30", VA = "0x181D71F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x1D722B0", Offset = "0x1D710B0", VA = "0x181D722B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private readonly DJONIENCBMN JNHEGEKEPLK;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public LNHJBPJICOP(DJONIENCBMN LKEMBNMEKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x1D75CB0", Offset = "0x1D74AB0", VA = "0x181D75CB0")]
	[AsyncStateMachine(typeof(MPGOJFEGIFC))]
	private Task<FBEPHKHKLJE<object, BEPKJMJJJMM>> DBCMFELJODP(BJFPGMKAPEG ENHEBPDFNME, bool JEBBEOLHMIA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x1D75DE0", Offset = "0x1D74BE0", VA = "0x181D75DE0", Slot = "4")]
	[AsyncStateMachine(typeof(BLKJLHNGGJI))]
	public Task<FBEPHKHKLJE<OBGAFDCEFFC, BEPKJMJJJMM>> OPBCDGKGOOC(IReadOnlyList<BJFPGMKAPEG> IDENKDINEDI, bool JEBBEOLHMIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct PKAFDBOAGHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	internal LLIPKPBCPLI<LHMMGAHDLML, BJFPGMKAPEG, OLJPGNJJHKP> CKHDHJCLJCM;

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x1D5DDE0", Offset = "0x1D5CBE0", VA = "0x181D5DDE0")]
	private PKAFDBOAGHK([In] LLIPKPBCPLI<LHMMGAHDLML, BJFPGMKAPEG, OLJPGNJJHKP> LMANBLDMLAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x1D76600", Offset = "0x1D75400", VA = "0x181D76600")]
	public static PKAFDBOAGHK KJKFMOENPNA()
	{
		return default(PKAFDBOAGHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class BEKCLBLFNIF
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
	public static LLIPKPBCPLI<LHMMGAHDLML, BJFPGMKAPEG, OLJPGNJJHKP> LGNMNOJBNDM(this PKAFDBOAGHK CNFBJPGPBBJ)
	{
		return default(LLIPKPBCPLI<LHMMGAHDLML, BJFPGMKAPEG, OLJPGNJJHKP>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct OLJPGNJJHKP : PKAIMHODDCO.HAEGCKHILNE<LHMMGAHDLML, BJFPGMKAPEG>
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x1D76220", Offset = "0x1D75020", VA = "0x181D76220", Slot = "5")]
	public BJFPGMKAPEG EKFLGFEDBDN(LHMMGAHDLML[] ILBNIEAOPFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x132A360", Offset = "0x1329160", VA = "0x18132A360")]
	public int NOPDJDDPBDG([In] LHMMGAHDLML ACOBJJDLFLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x132A360", Offset = "0x1329160", VA = "0x18132A360", Slot = "4")]
	private int FEAAFDJJPPA([In] LHMMGAHDLML EAIOLMFLELM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public struct DECBJPKGHCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	internal EEILBGBOGBI<PGHLBGFMJIE, BJFPGMKAPEG, PFAFOENCONE> CKHDHJCLJCM;

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x1D5DDE0", Offset = "0x1D5CBE0", VA = "0x181D5DDE0")]
	private DECBJPKGHCI([In] EEILBGBOGBI<PGHLBGFMJIE, BJFPGMKAPEG, PFAFOENCONE> ALBPIFCBNCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x1D726B0", Offset = "0x1D714B0", VA = "0x181D726B0")]
	public static DECBJPKGHCI KJKFMOENPNA()
	{
		return default(DECBJPKGHCI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class OOJAMAGDLOH
{
	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x87F3D0", Offset = "0x87E1D0", VA = "0x18087F3D0")]
	public static EEILBGBOGBI<PGHLBGFMJIE, BJFPGMKAPEG, PFAFOENCONE> LGNMNOJBNDM(this DECBJPKGHCI CNFBJPGPBBJ)
	{
		return default(EEILBGBOGBI<PGHLBGFMJIE, BJFPGMKAPEG, PFAFOENCONE>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200008D")]
public struct PFAFOENCONE : JEFICHODDCG.MHIHLOLKPCI<PGHLBGFMJIE, BJFPGMKAPEG>
{
	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x132A360", Offset = "0x1329160", VA = "0x18132A360")]
	public int AMAPEHNFPKI([In] PGHLBGFMJIE ACOBJJDLFLM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x1D76410", Offset = "0x1D75210", VA = "0x181D76410", Slot = "5")]
	public BJFPGMKAPEG FDJJMEFHKLE(PGHLBGFMJIE[] KJBCBNAMOBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x132A360", Offset = "0x1329160", VA = "0x18132A360", Slot = "4")]
	private int FLJAJNIGBIB([In] PGHLBGFMJIE ACOBJJDLFLM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface INFNPELKBBP
{
	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JJFGCEMHIOG([In] FBEPHKHKLJE<JEGFFGGMBEH, LNKCFDGMPAP> BGCCPJGDEGH);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class FKKEBCJDJFF
{
	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x26E6200", Offset = "0x26E5000", VA = "0x1826E6200")]
	public static bool JJFGCEMHIOG<TOk, TErr>(this INFNPELKBBP CNFBJPGPBBJ, [In] FBEPHKHKLJE<TOk, TErr> BGCCPJGDEGH) where TOk : notnull where TErr : notnull, LNKCFDGMPAP
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public interface GCOCIIGIFEF
{
	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	FCAAMDKPFIK NDAHHLFMLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public interface OJFEDBNCEOP
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PAACLPBPANI KOGEHFCAMDP(int EPMAFGOIKLC);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public interface BFPMIIPAAED
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	string GMLPMAJDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public interface CJEIELCKPFN
{
	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FFPFECNMCEH? PCMIOHKLFLE(HIGDJMOGOKB<GCNKIDOJOMK> LCAJLIAHGOG);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public interface MPCHBFDKJGI
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	string GMLPMAJDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public interface FFPFECNMCEH
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	string GMLPMAJDOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MPCHBFDKJGI? BIMMODOHELF(HIGDJMOGOKB<PCHPOCELAEL> PIFGCICDBNJ);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BFPMIIPAAED? ONHPJDEFKOK(HIGDJMOGOKB<DNDJFJCMJLC> CHNHDOJLHBB);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public interface BOAAANKCKNK
{
	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> CJBJGPBCMEB(string NKKIECLCEML, string HOLFPPNPJAH);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public interface IDJFBGHMOGA
{
	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CJEIELCKPFN? PNMEPJHMLHK([In] ANCACCNALNI<IOKIBFLHGGE> DCIIEODLNGG);
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public sealed class PPOKDACEBOP
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct IHDOBEHGKHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public int CCEAOHGDFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public PBEFNMAHMLC? APEEPCPBJLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public PBEFNMAHMLC? BJBIILCNMOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public readonly List<BJFPGMKAPEG> OGMPLPJCIEC;

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1D74040", Offset = "0x1D72E40", VA = "0x181D74040")]
		private IHDOBEHGKHK(int ENPOKNEMOMH, PBEFNMAHMLC? NAMBDECAPPP, PBEFNMAHMLC? KNNBOEJFFHN, List<BJFPGMKAPEG> IDENKDINEDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x1D73F80", Offset = "0x1D72D80", VA = "0x181D73F80")]
		public static IHDOBEHGKHK KJKFMOENPNA()
		{
			return default(IHDOBEHGKHK);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly CODLGIMBNFP<IHDOBEHGKHK> DOHJOKEEDFE;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public static PPOKDACEBOP AHFNEPHAKHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x1D76D60", Offset = "0x1D75B60", VA = "0x181D76D60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool EMBKHCAMABJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F6320", Offset = "0x7F5120", VA = "0x1807F6320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x99B200", Offset = "0x99A000", VA = "0x18099B200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x1D76660", Offset = "0x1D75460", VA = "0x181D76660")]
	public void DMNCNLCAEDK(CDDENKAFMJG KNNBOEJFFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x1D76720", Offset = "0x1D75520", VA = "0x181D76720")]
	public void FGMJMLCHIDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x1D76A20", Offset = "0x1D75820", VA = "0x181D76A20")]
	private static string? JCHCMCBBAAP([In] IHDOBEHGKHK IMAIAHBMBKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x1D76EB0", Offset = "0x1D75CB0", VA = "0x181D76EB0")]
	public PPOKDACEBOP()
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
