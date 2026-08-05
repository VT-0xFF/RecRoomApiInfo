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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x1C585F0", Offset = "0x1C573F0", VA = "0x181C585F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x789560", Offset = "0x788360", VA = "0x180789560")]
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
		[Cpp2IlInjected.Address(RVA = "0x7895A0", Offset = "0x7883A0", VA = "0x1807895A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class BEKPLBAAMIF : IDisposable, MNJKPKDPCHF, IALKENNMABK, CIEGLHAOFDH, JMPDKJMEOGJ, JOOIFOACNBB
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class MODNFGCGIDC : HMKCCNECEKB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int FOECIIABHDE
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1C57B00", Offset = "0x1C56900", VA = "0x181C57B00", Slot = "5")]
		public HPBOOPFHOFI NNGDGNEMFPJ(OEKEKDONHKE.FMBENLFBOGE BLNNMOCCDKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void GHGICLLGKNH();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void EKPHGACDIFC();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		protected MODNFGCGIDC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface HMKCCNECEKB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int FOECIIABHDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		HPBOOPFHOFI NNGDGNEMFPJ(OEKEKDONHKE.FMBENLFBOGE BLNNMOCCDKN);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GHGICLLGKNH();

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EKPHGACDIFC();
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct AEKJDJPKGEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly KMBBPAJDPHN<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF, MECJKIKFFAN.GOPDODKANIL<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF>> EJNKDKOJGBP;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E190", Offset = "0x1C3CF90", VA = "0x181C3E190")]
		internal AEKJDJPKGEO(KMBBPAJDPHN<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF, MECJKIKFFAN.GOPDODKANIL<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF>> IIJDENGNPJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class BGIGILDNNCH : MECJKIKFFAN.GOPDODKANIL<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF>
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static readonly BGIGILDNNCH IFFGEIGBEEG;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		private BGIGILDNNCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x95B7C0", Offset = "0x95A5C0", VA = "0x18095B7C0", Slot = "4")]
		public MEMMHFPOBMJ FJHHNELMMKI(IIHJOGGFNLJ PECKHAMCEFO)
		{
			return default(MEMMHFPOBMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
		public void IKEFFCJMEHF(BEKPLBAAMIF PHNFANHCONA, IIHJOGGFNLJ IPGJPNDBCJD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct AMHKMEAICOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public GFGKKIBGJKJ<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF, MECJKIKFFAN.GOPDODKANIL<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF>> EJNKDKOJGBP;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1C44450", Offset = "0x1C43250", VA = "0x181C44450")]
		internal AMHKMEAICOP(GFGKKIBGJKJ<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF, MECJKIKFFAN.GOPDODKANIL<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF>> IIJDENGNPJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1C44400", Offset = "0x1C43200", VA = "0x181C44400")]
		public static AMHKMEAICOP IGHHFGMBDIH()
		{
			return default(AMHKMEAICOP);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct FLDMPGLJLMH : HMGKHEHIGFD.LFCOLNFHGMI<OIDHCJGBIBM, IIHJOGGFNLJ, BEKPLBAAMIF>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct EGHPODFBIHA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public AsyncTaskMethodBuilder<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public BEKPLBAAMIF receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public IIHJOGGFNLJ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public FLDMPGLJLMH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x1C4B090", Offset = "0x1C49E90", VA = "0x181C4B090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x1C4B270", Offset = "0x1C4A070", VA = "0x181C4B270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x95B7C0", Offset = "0x95A5C0", VA = "0x18095B7C0", Slot = "4")]
		public GDGHOPABCBJ<OIDHCJGBIBM> KFCHLNGGHEL(BEKPLBAAMIF ELGGIPNHKGA)
		{
			return default(GDGHOPABCBJ<OIDHCJGBIBM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1C4BDF0", Offset = "0x1C4ABF0", VA = "0x181C4BDF0", Slot = "5")]
		[AsyncStateMachine(typeof(EGHPODFBIHA))]
		public Task<FEBPNEDDNDE<object, KBBJHNEEOGJ>> LFLAAMHHBDH(BEKPLBAAMIF ELGGIPNHKGA, IIHJOGGFNLJ IPGJPNDBCJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1C4BDD0", Offset = "0x1C4ABD0", VA = "0x181C4BDD0", Slot = "6")]
		public IIHJOGGFNLJ[] GGIEGLPJIFN(BEKPLBAAMIF ELGGIPNHKGA)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OEFGPAPPOJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<bool, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public BEKPLBAAMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NDHDEECGNKK rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public OIDNONMAINB circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HIAIHBIEMAC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<FEBPNEDDNDE<bool, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1C58A20", Offset = "0x1C57820", VA = "0x181C58A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1C58CA0", Offset = "0x1C57AA0", VA = "0x181C58CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct OJBFGBBJBLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<bool, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public BEKPLBAAMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<FEBPNEDDNDE<bool, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1C5A0F0", Offset = "0x1C58EF0", VA = "0x181C5A0F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1C5A370", Offset = "0x1C59170", VA = "0x181C5A370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct ABMAIBLBPNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public BEKPLBAAMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1C3DEE0", Offset = "0x1C3CCE0", VA = "0x181C3DEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E0C0", Offset = "0x1C3CEC0", VA = "0x181C3E0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct OIEKPGNLFDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public BEKPLBAAMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public IIHJOGGFNLJ action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1C59AD0", Offset = "0x1C588D0", VA = "0x181C59AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1C59CC0", Offset = "0x1C58AC0", VA = "0x181C59CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct COAMAJAHIHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public BEKPLBAAMIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private TaskAwaiter<FEBPNEDDNDE<bool, KBBJHNEEOGJ>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1C490E0", Offset = "0x1C47EE0", VA = "0x181C490E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1C498D0", Offset = "0x1C486D0", VA = "0x181C498D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly GDGHOPABCBJ<OIDHCJGBIBM> IDIPJNBFNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly AEKJDJPKGEO NHKBBBJIHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly JIDFAPIONNI CDFHAPANJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly AILLCOEEANE JHALPIJCAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly LPGMDLNPHFE.LIGENMAAOCP JDKEIAOJFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly AAAPNEHBPCM JEHPOMLLKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly HHFMCPOFJAM KGFGNEMIJMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly KBFKDLAAFEH MAAODKLKNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly CIDGLKHJCFK KIOINGNCAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private AIMIDANIFCF GCDKJAOOGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private JALBACJKKOK JODBOBBAOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	internal readonly JIDFAPIONNI.HCHEMGHEMIN CKNGIGHFHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly HABFOJIEAJH INALJKNCCBN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JIDFAPIONNI FMFCFLGKIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1C47850", Offset = "0x1C46650", VA = "0x181C47850")]
		get
		{
			return default(JIDFAPIONNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal HMKCCNECEKB BNJGFKJPIDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1C47600", Offset = "0x1C46400", VA = "0x181C47600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal HPBOOPFHOFI JGPGKIAMDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x762AC0", Offset = "0x7618C0", VA = "0x180762AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x762AF0", Offset = "0x7618F0", VA = "0x180762AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool ICGPGJAHLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x941CB0", Offset = "0x940AB0", VA = "0x180941CB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9419A0", Offset = "0x9407A0", VA = "0x1809419A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LEADBLIHIOJ HKAKBCAEFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x767990", Offset = "0x766790", VA = "0x180767990", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DFPBHJOOMDE ELBHHOLACMB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x89EB10", Offset = "0x89D910", VA = "0x18089EB10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CDALLICPBFB PLCPDIEBOCC
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x762AB0", Offset = "0x7618B0", VA = "0x180762AB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HMEJNOEADEK HKKKKPDLIDE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8B90D0", Offset = "0x8B7ED0", VA = "0x1808B90D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private KMJOFBBLDDM? FFENIAJFNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1C465C0", Offset = "0x1C453C0", VA = "0x181C465C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private JAAKEDJHDMJ? BCBENCNKIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1C46420", Offset = "0x1C45220", VA = "0x181C46420", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1C47860", Offset = "0x1C46660", VA = "0x181C47860")]
	private BEKPLBAAMIF(AILLCOEEANE IFKIGJDABJA, GDGHOPABCBJ<OIDHCJGBIBM> MOOEDMEIHIK, AEKJDJPKGEO PKNFEOICJAK, JIDFAPIONNI EJMCGJIGPMG, HPBOOPFHOFI NAMNFILNEBJ, [In] LPGMDLNPHFE.LIGENMAAOCP IGMFNJCIAEC, JIDFAPIONNI.HCHEMGHEMIN LGBELCPEPNG, HABFOJIEAJH CGKLBBAHDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1C47340", Offset = "0x1C46140", VA = "0x181C47340")]
	public static BEKPLBAAMIF IGHHFGMBDIH(AILLCOEEANE BLNNMOCCDKN, JIDFAPIONNI.NNGKBIPJDNL PFENCPCJHLI, GDGHOPABCBJ<OIDHCJGBIBM> MOOEDMEIHIK, GDGHOPABCBJ<EGNJBHOPCOJ> BHEBFPJKIFA, INHEHICFMNA EBKGMNDAOEJ, DEHANPEOHDP DLLGDMNILFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1C46FD0", Offset = "0x1C45DD0", VA = "0x181C46FD0")]
	public static BEKPLBAAMIF IGHHFGMBDIH(AILLCOEEANE IFKIGJDABJA, [In] JIDFAPIONNI EJMCGJIGPMG, GDGHOPABCBJ<OIDHCJGBIBM> MOOEDMEIHIK, GDGHOPABCBJ<EGNJBHOPCOJ> BHEBFPJKIFA, INHEHICFMNA EBKGMNDAOEJ, DEHANPEOHDP DLLGDMNILFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1C466F0", Offset = "0x1C454F0", VA = "0x181C466F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1C46A60", Offset = "0x1C45860", VA = "0x181C46A60")]
	[AsyncStateMachine(typeof(OEFGPAPPOJB))]
	internal Task<FEBPNEDDNDE<bool, KBBJHNEEOGJ>> FHELNBOJGLD(NDHDEECGNKK LNKBALKOEEA, OIDNONMAINB NDKLPFDNHOF, HIAIHBIEMAC DBBBPLGPHMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1C473F0", Offset = "0x1C461F0", VA = "0x181C473F0")]
	[AsyncStateMachine(typeof(OJBFGBBJBLP))]
	public Task<FEBPNEDDNDE<bool, KBBJHNEEOGJ>> IKJMLALIDPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1C46330", Offset = "0x1C45130", VA = "0x181C46330")]
	[AsyncStateMachine(typeof(ABMAIBLBPNP))]
	public Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> AGKMFFDFKJE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1C47650", Offset = "0x1C46450", VA = "0x181C47650")]
	internal void OPNFJFMBKEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1C468D0", Offset = "0x1C456D0", VA = "0x181C468D0")]
	internal KBGKJDMAFMA<IIHJOGGFNLJ> ENGONDJLOHN([In] ICDDEFONLAH DCNNKGOKEOC)
	{
		return default(KBGKJDMAFMA<IIHJOGGFNLJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1C46550", Offset = "0x1C45350", VA = "0x181C46550")]
	internal bool CFLFKBLOCNI([In] ICDDEFONLAH DCNNKGOKEOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1C46F50", Offset = "0x1C45D50", VA = "0x181C46F50")]
	internal KBGKJDMAFMA<IIHJOGGFNLJ> HLNHHHHIGGL([In] PBBAJGAMFFK EOMCKKCDCMC)
	{
		return default(KBGKJDMAFMA<IIHJOGGFNLJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1C46950", Offset = "0x1C45750", VA = "0x181C46950")]
	[AsyncStateMachine(typeof(OIEKPGNLFDN))]
	internal Task<FEBPNEDDNDE<object, KBBJHNEEOGJ>> FDCNPLHPHPP(IIHJOGGFNLJ IPGJPNDBCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1C46BC0", Offset = "0x1C459C0", VA = "0x181C46BC0")]
	private IIHJOGGFNLJ[] GGIEGLPJIFN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1C474E0", Offset = "0x1C462E0", VA = "0x181C474E0")]
	[AsyncStateMachine(typeof(COAMAJAHIHN))]
	public Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> IKPLBAGADJE(Guid IEHADOACBLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class ANLDNPCMGMH
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x29C3CE0", Offset = "0x29C2AE0", VA = "0x1829C3CE0")]
	public static BFPAEIAALCB<(TPrev?, BEKPLBAAMIF?), JAAKEDJHDMJ> CKCIKMBHDOF<TPrev>([In] this BFPAEIAALCB<TPrev, BEKPLBAAMIF> PECKHAMCEFO)
	{
		return default(BFPAEIAALCB<(TPrev, BEKPLBAAMIF), JAAKEDJHDMJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x29C3F80", Offset = "0x29C2D80", VA = "0x1829C3F80")]
	public static BFPAEIAALCB<TPrev?, BEKPLBAAMIF?> LKOKKAKKDIF<TPrev>([In] this BFPAEIAALCB<TPrev, BEKPLBAAMIF> PECKHAMCEFO)
	{
		return default(BFPAEIAALCB<TPrev, BEKPLBAAMIF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class CPNOFFHJBAP<TData> : DBMNCLOBEEI, HIEPMFBAOLI, NEBNMHPBDBO where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly CEEPFMHPMMJ<CIENEMDJNND>? OIOEGHIPPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly string LPKINLJAGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly TData NCHGGNHAEAG;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public CEEPFMHPMMJ<CIENEMDJNND>? HIFNICKLNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1F730D0", Offset = "0x1F71ED0", VA = "0x181F730D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x769880", Offset = "0x768680", VA = "0x180769880", Slot = "7")]
	public override string KJDIEKJIOOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4A42320", Offset = "0x4A41120", VA = "0x184A42320")]
	internal CPNOFFHJBAP([In] CEEPFMHPMMJ<CIENEMDJNND>? GPEGHFJKNBO, GDGHOPABCBJ<GLEJILFHHIL>? ICHDOCMLBCE, IOKind? OOJKOHKEAED, string BLAOEBOMGGP, [In] TData LMCJHCIOIIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GFOHPIHCBCK
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1C4CE30", Offset = "0x1C4BC30", VA = "0x181C4CE30")]
	public static FEBPNEDDNDE<EHEMILBDMEL, HIEPMFBAOLI> DFDJOAMNHMG([In] this BOBEMEAAKBB<ADFPPPIEKKE> KDOPLBLACIA)
	{
		return default(FEBPNEDDNDE<EHEMILBDMEL, HIEPMFBAOLI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x239AE70", Offset = "0x2399C70", VA = "0x18239AE70")]
	public static FEBPNEDDNDE<TOk, HIEPMFBAOLI> DCDMOFBMMBF<TOk>([In] this FEBPNEDDNDE<TOk, HIEPMFBAOLI> PECKHAMCEFO, [In] CEEPFMHPMMJ<CIENEMDJNND>? GPEGHFJKNBO, GDGHOPABCBJ<GLEJILFHHIL>? ICHDOCMLBCE, IOKind? OOJKOHKEAED, string BLAOEBOMGGP) where TOk : notnull
	{
		return default(FEBPNEDDNDE<TOk, HIEPMFBAOLI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface AILLCOEEANE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	JDODLCFGFCL.CIOFKMBGNHJ DDKKJFOJFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	OEKEKDONHKE.FMBENLFBOGE BINAMLGJMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	BEKPLBAAMIF.HMKCCNECEKB JEKHJAKCHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	DONEBFLFLKL.LLDIIJFLGBL HLFFLGLCPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	MECJKIKFFAN.GOPDODKANIL<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF> AGFLDFKMGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	AKNKONAODAN NEFAAGENNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PDIGLJJPCCK JNFFHBPGEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	MGNJNDFILAF NKCHDIDLOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	DIMGJEAHNBO OMNBGEGFIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	OBBBHJLFCAF CEIOKAAIMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class MDJCENLFNJC
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1C57990", Offset = "0x1C56790", VA = "0x181C57990")]
	public static IIHJOGGFNLJ MFBOPKKMMAH(this IIHJOGGFNLJ PECKHAMCEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1C578C0", Offset = "0x1C566C0", VA = "0x181C578C0")]
	public static IIHJOGGFNLJ JANFIMGLLMC(this JFOJBEKDIEG PECKHAMCEFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct JFOJBEKDIEG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct NMBIJMELPHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public BEKPLBAAMIF root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public JFOJBEKDIEG self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private TaskAwaiter<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1C582C0", Offset = "0x1C570C0", VA = "0x181C582C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1C58580", Offset = "0x1C57380", VA = "0x181C58580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly ByteString CAGIMKNDHKH;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7EB650", Offset = "0x7EA450", VA = "0x1807EB650")]
	private JFOJBEKDIEG(ByteString POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1C4FD10", Offset = "0x1C4EB10", VA = "0x181C4FD10")]
	public static IIHJOGGFNLJ JMFKKNGLPAH(ByteString POACLGOFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1C4FDD0", Offset = "0x1C4EBD0", VA = "0x181C4FDD0")]
	public static KECCHLFNHMB<MEMMHFPOBMJ, JFOJBEKDIEG> MEEABEMDOFH(IIHJOGGFNLJ GDEPJDDILFJ)
	{
		return default(KECCHLFNHMB<MEMMHFPOBMJ, JFOJBEKDIEG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1C4FC00", Offset = "0x1C4EA00", VA = "0x181C4FC00")]
	[AsyncStateMachine(typeof(NMBIJMELPHO))]
	public static Task<FEBPNEDDNDE<object, KBBJHNEEOGJ>> FDCNPLHPHPP(BEKPLBAAMIF PHNFANHCONA, JFOJBEKDIEG PECKHAMCEFO)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct PPHJMLDOKAC
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1C5AF90", Offset = "0x1C59D90", VA = "0x181C5AF90")]
	public static IIHJOGGFNLJ JMFKKNGLPAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1C5B030", Offset = "0x1C59E30", VA = "0x181C5B030")]
	public static KECCHLFNHMB<MEMMHFPOBMJ, PPHJMLDOKAC> MEEABEMDOFH(IIHJOGGFNLJ GDEPJDDILFJ)
	{
		return default(KECCHLFNHMB<MEMMHFPOBMJ, PPHJMLDOKAC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1C5AF10", Offset = "0x1C59D10", VA = "0x181C5AF10")]
	public static FEBPNEDDNDE<NENNLMOAGAP, BKLKNEGKHFP> BBHHOKIKMIE(BEKPLBAAMIF PHNFANHCONA, [In] PPHJMLDOKAC PECKHAMCEFO)
	{
		return default(FEBPNEDDNDE<NENNLMOAGAP, BKLKNEGKHFP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct FPICCNCLGNN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct GGCKBOIEGPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, BKLKNEGKHFP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public BEKPLBAAMIF root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public FPICCNCLGNN self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private FEBPNEDDNDE<NENNLMOAGAP, BKLKNEGKHFP> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1C4D210", Offset = "0x1C4C010", VA = "0x181C4D210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1C4D580", Offset = "0x1C4C380", VA = "0x181C4D580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly NDHDEECGNKK? JAOKEBGKGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly OIDNONMAINB? ICEKPHOLFED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly HIAIHBIEMAC? OADAGDFPJKG;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x18E5E20", Offset = "0x18E4C20", VA = "0x1818E5E20")]
	private FPICCNCLGNN(NDHDEECGNKK? LNKBALKOEEA, OIDNONMAINB? NDKLPFDNHOF, HIAIHBIEMAC? DBBBPLGPHMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1C4C860", Offset = "0x1C4B660", VA = "0x181C4C860")]
	public static IIHJOGGFNLJ? JMFKKNGLPAH(NDHDEECGNKK? LNKBALKOEEA, OIDNONMAINB? NDKLPFDNHOF, HIAIHBIEMAC? DBBBPLGPHMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1C4C960", Offset = "0x1C4B760", VA = "0x181C4C960")]
	public static KECCHLFNHMB<MEMMHFPOBMJ, FPICCNCLGNN> MEEABEMDOFH(IIHJOGGFNLJ GDEPJDDILFJ)
	{
		return default(KECCHLFNHMB<MEMMHFPOBMJ, FPICCNCLGNN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1C4C720", Offset = "0x1C4B520", VA = "0x181C4C720")]
	[AsyncStateMachine(typeof(GGCKBOIEGPM))]
	public static Task<FEBPNEDDNDE<NENNLMOAGAP, BKLKNEGKHFP>> FDCNPLHPHPP(BEKPLBAAMIF PHNFANHCONA, FPICCNCLGNN PECKHAMCEFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct ICNEJGJAGBG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct FCDNIHLEFKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<FEAGKJMBIAE, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public ICNEJGJAGBG self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public BEKPLBAAMIF root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private FEBPNEDDNDE<FEAGKJMBIAE, KBBJHNEEOGJ> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private FEBPNEDDNDE<object, NEBNMHPBDBO>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private FEBPNEDDNDE<object, NEBNMHPBDBO> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private FEBPNEDDNDE<object, NEBNMHPBDBO>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1C4B590", Offset = "0x1C4A390", VA = "0x181C4B590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1C4BA00", Offset = "0x1C4A800", VA = "0x181C4BA00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IReadOnlyList<IIHJOGGFNLJ> LHEIEHJGKMF;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7EB650", Offset = "0x7EA450", VA = "0x1807EB650")]
	private ICNEJGJAGBG(IReadOnlyList<IIHJOGGFNLJ> JHODOBKGEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1C4F300", Offset = "0x1C4E100", VA = "0x181C4F300")]
	public static IIHJOGGFNLJ JMFKKNGLPAH(IReadOnlyList<IIHJOGGFNLJ> JHODOBKGEMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1C4F3C0", Offset = "0x1C4E1C0", VA = "0x181C4F3C0")]
	public static KECCHLFNHMB<MEMMHFPOBMJ, ICNEJGJAGBG> MEEABEMDOFH(IIHJOGGFNLJ GDEPJDDILFJ)
	{
		return default(KECCHLFNHMB<MEMMHFPOBMJ, ICNEJGJAGBG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1C4F1C0", Offset = "0x1C4DFC0", VA = "0x181C4F1C0")]
	[AsyncStateMachine(typeof(FCDNIHLEFKO))]
	public static Task<FEBPNEDDNDE<FEAGKJMBIAE, KBBJHNEEOGJ>> FDCNPLHPHPP(BEKPLBAAMIF PHNFANHCONA, ICNEJGJAGBG PECKHAMCEFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct PBBAJGAMFFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly int GJPDNICHPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly int FCFMLMDMJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly byte[] NCHGGNHAEAG;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x168C000", Offset = "0x168AE00", VA = "0x18168C000")]
	private PBBAJGAMFFK(int NENAAIFMEME, int OCMJNDDMDAL, byte[] LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1C5A640", Offset = "0x1C59440", VA = "0x181C5A640")]
	public static IIHJOGGFNLJ JMFKKNGLPAH(int NENAAIFMEME, int OCMJNDDMDAL, ByteString LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1C5A500", Offset = "0x1C59300", VA = "0x181C5A500")]
	public static IIHJOGGFNLJ[] HHEHNLCMOPL(IIHJOGGFNLJ IPGJPNDBCJD, int ONHBFKDBEKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1C5A720", Offset = "0x1C59520", VA = "0x181C5A720")]
	public static KECCHLFNHMB<MEMMHFPOBMJ, PBBAJGAMFFK> MEEABEMDOFH(IIHJOGGFNLJ GDEPJDDILFJ)
	{
		return default(KECCHLFNHMB<MEMMHFPOBMJ, PBBAJGAMFFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1C5A3E0", Offset = "0x1C591E0", VA = "0x181C5A3E0")]
	public static FEBPNEDDNDE<IIHJOGGFNLJ, BKLKNEGKHFP> BBHHOKIKMIE(BEKPLBAAMIF PHNFANHCONA, [In] PBBAJGAMFFK PECKHAMCEFO)
	{
		return default(FEBPNEDDNDE<IIHJOGGFNLJ, BKLKNEGKHFP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct ICDDEFONLAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct CJMGKPJFDHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<bool, BKLKNEGKHFP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public BEKPLBAAMIF root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public ICDDEFONLAH self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private FEBPNEDDNDE<bool, BKLKNEGKHFP> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, BKLKNEGKHFP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1C48A30", Offset = "0x1C47830", VA = "0x181C48A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1C49070", Offset = "0x1C47E70", VA = "0x181C49070", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly int GJPDNICHPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly int FCFMLMDMJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly byte[] NCHGGNHAEAG;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x168C000", Offset = "0x168AE00", VA = "0x18168C000")]
	private ICDDEFONLAH(int NENAAIFMEME, int OCMJNDDMDAL, byte[] LMCJHCIOIIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1C4EE00", Offset = "0x1C4DC00", VA = "0x181C4EE00")]
	public static IIHJOGGFNLJ JMFKKNGLPAH(int NENAAIFMEME, int OCMJNDDMDAL, ByteString LMCJHCIOIIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1C4EEE0", Offset = "0x1C4DCE0", VA = "0x181C4EEE0")]
	public static IIHJOGGFNLJ?[]? LJCPMJFGKPN(int ONHBFKDBEKG, NDHDEECGNKK? LNKBALKOEEA, OIDNONMAINB? NDKLPFDNHOF, HIAIHBIEMAC? DBBBPLGPHMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1C4F0E0", Offset = "0x1C4DEE0", VA = "0x181C4F0E0")]
	public static KECCHLFNHMB<MEMMHFPOBMJ, ICDDEFONLAH> MEEABEMDOFH(IIHJOGGFNLJ GDEPJDDILFJ)
	{
		return default(KECCHLFNHMB<MEMMHFPOBMJ, ICDDEFONLAH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x1C4ECD0", Offset = "0x1C4DAD0", VA = "0x181C4ECD0")]
	[AsyncStateMachine(typeof(CJMGKPJFDHG))]
	public static Task<FEBPNEDDNDE<bool, BKLKNEGKHFP>> FDCNPLHPHPP(BEKPLBAAMIF PHNFANHCONA, ICDDEFONLAH PECKHAMCEFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class AAAPNEHBPCM : LEADBLIHIOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly BEKPLBAAMIF PKBEEFOHNFN;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public NPEABPMOKDO? IFFGEIGBEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1C3DDD0", Offset = "0x1C3CBD0", VA = "0x181C3DDD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	internal AAAPNEHBPCM(BEKPLBAAMIF NHBGKNCEKHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JGEGGLMADOD : NPEABPMOKDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly BEKPLBAAMIF PKBEEFOHNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly GDLNPPCABLH NGNCHJAJDBG;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7604C0", Offset = "0x75F2C0", VA = "0x1807604C0")]
	public JGEGGLMADOD(BEKPLBAAMIF NHBGKNCEKHK, GDLNPPCABLH DHNAONHHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1C4FE80", Offset = "0x1C4EC80", VA = "0x181C4FE80", Slot = "4")]
	public FEBPNEDDNDE<EHEMILBDMEL, HIEPMFBAOLI> CDIGEGCPNLF(CEEPFMHPMMJ<CIENEMDJNND> CIANJEHDGID, GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN, GDGHOPABCBJ<PJMKAHCGNJA> BOLANHMFLAL)
	{
		return default(FEBPNEDDNDE<EHEMILBDMEL, HIEPMFBAOLI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x1C50150", Offset = "0x1C4EF50", VA = "0x181C50150", Slot = "5")]
	public FEBPNEDDNDE<EHEMILBDMEL, HIEPMFBAOLI> OHGOJJGECAK(CEEPFMHPMMJ<CIENEMDJNND> CIANJEHDGID, GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN, GDGHOPABCBJ<PEIGABEPHFN> MAGFIFIOEFK)
	{
		return default(FEBPNEDDNDE<EHEMILBDMEL, HIEPMFBAOLI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class JDODLCFGFCL : MCNJIALKEOH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface CIOFKMBGNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<GDLNPPCABLH> HKGGHLBBIJH(BEKPLBAAMIF NHBGKNCEKHK, OIDNONMAINB? ALKMPIFMDLA, HIAIHBIEMAC? LGDCGDEAKLG, CancellationToken BCCDJHNACKO);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DEOMJIDNGIL OKNIPKKEAJO(BEKPLBAAMIF NHBGKNCEKHK, NDHDEECGNKK CABHNFJIOGA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class MPAJBNMPEED : CIOFKMBGNHJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct NDBNGNIKGCO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncTaskMethodBuilder<GDLNPPCABLH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public BEKPLBAAMIF circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public OIDNONMAINB cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public HIAIHBIEMAC cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private TaskAwaiter<DONEBFLFLKL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x1C57EC0", Offset = "0x1C56CC0", VA = "0x181C57EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x1C581F0", Offset = "0x1C56FF0", VA = "0x181C581F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly MPAJBNMPEED IFFGEIGBEEG;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		private MPAJBNMPEED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1C57C50", Offset = "0x1C56A50", VA = "0x181C57C50", Slot = "4")]
		[AsyncStateMachine(typeof(NDBNGNIKGCO))]
		public Task<GDLNPPCABLH> HKGGHLBBIJH(BEKPLBAAMIF NHBGKNCEKHK, OIDNONMAINB? ALKMPIFMDLA, HIAIHBIEMAC? LGDCGDEAKLG, CancellationToken BCCDJHNACKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1C57DB0", Offset = "0x1C56BB0", VA = "0x181C57DB0", Slot = "5")]
		public DEOMJIDNGIL OKNIPKKEAJO(BEKPLBAAMIF NHBGKNCEKHK, NDHDEECGNKK CABHNFJIOGA)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct DFEKLACIEII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public AsyncTaskMethodBuilder<JDODLCFGFCL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public BEKPLBAAMIF circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public OIDNONMAINB cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public HIAIHBIEMAC cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public NDHDEECGNKK evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private CIOFKMBGNHJ <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private TaskAwaiter<GDLNPPCABLH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1C4A4C0", Offset = "0x1C492C0", VA = "0x181C4A4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1C4AA20", Offset = "0x1C49820", VA = "0x181C4AA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly GDLNPPCABLH NGNCHJAJDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly DEOMJIDNGIL JLICEEKJLHF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public KMJOFBBLDDM ENNIHFADDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1C4F940", Offset = "0x1C4E740", VA = "0x181C4F940", Slot = "4")]
		get
		{
			return default(KMJOFBBLDDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public JAAKEDJHDMJ LNPLECEDLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1C4F9A0", Offset = "0x1C4E7A0", VA = "0x181C4F9A0", Slot = "5")]
		get
		{
			return default(JAAKEDJHDMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public JGEGGLMADOD MPJNFMALDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public BDBELACLBMC JKOAPPMOPKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public AKOGAGIDCME LEJALGOAKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x1C4FB70", Offset = "0x1C4E970", VA = "0x181C4FB70")]
	private JDODLCFGFCL(GDLNPPCABLH DHNAONHHBJC, DEOMJIDNGIL IKGEDGPPAAF, JGEGGLMADOD LLPPOOMLEIJ, BDBELACLBMC JGEGNGEMHMB, AKOGAGIDCME LKIKOJBGBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1C4FA00", Offset = "0x1C4E800", VA = "0x181C4FA00")]
	[AsyncStateMachine(typeof(DFEKLACIEII))]
	public static Task<JDODLCFGFCL> PGCOIJKBKDO(BEKPLBAAMIF NHBGKNCEKHK, NDHDEECGNKK CABHNFJIOGA, OIDNONMAINB? ALKMPIFMDLA, HIAIHBIEMAC? LGDCGDEAKLG, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1C4F8E0", Offset = "0x1C4E6E0", VA = "0x181C4F8E0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class OEKEKDONHKE : HPBOOPFHOFI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface FMBENLFBOGE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<MCNJIALKEOH> FMGPJDDABAK(BEKPLBAAMIF NHBGKNCEKHK, NDHDEECGNKK CABHNFJIOGA, OIDNONMAINB? ALKMPIFMDLA, HIAIHBIEMAC? LGDCGDEAKLG, CancellationToken BCCDJHNACKO);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JFMFIMLKOOH();

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EJEBDMEAHCO();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class KMJEPPHLJMG : FMBENLFBOGE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct CBDFAOIIGIJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder<MCNJIALKEOH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public BEKPLBAAMIF circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public NDHDEECGNKK evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public OIDNONMAINB cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public HIAIHBIEMAC cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private TaskAwaiter<JDODLCFGFCL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x1C47CA0", Offset = "0x1C46AA0", VA = "0x181C47CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x1C47FE0", Offset = "0x1C46DE0", VA = "0x181C47FE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1C55390", Offset = "0x1C54190", VA = "0x181C55390", Slot = "4")]
		[AsyncStateMachine(typeof(CBDFAOIIGIJ))]
		public Task<MCNJIALKEOH> FMGPJDDABAK(BEKPLBAAMIF NHBGKNCEKHK, NDHDEECGNKK CABHNFJIOGA, OIDNONMAINB? ALKMPIFMDLA, HIAIHBIEMAC? LGDCGDEAKLG, CancellationToken BCCDJHNACKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void JFMFIMLKOOH();

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void EJEBDMEAHCO();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		protected KMJEPPHLJMG()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct MCHFHCHKLNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<MCNJIALKEOH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public OEKEKDONHKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<NENNLMOAGAP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1C57650", Offset = "0x1C56450", VA = "0x181C57650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1C57850", Offset = "0x1C56650", VA = "0x181C57850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct PFBCMMLAECA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public OEKEKDONHKE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public BEKPLBAAMIF circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public NDHDEECGNKK evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public OIDNONMAINB cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public HIAIHBIEMAC cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private TaskAwaiter<MCNJIALKEOH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1C5A800", Offset = "0x1C59600", VA = "0x181C5A800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1C5AD30", Offset = "0x1C59B30", VA = "0x181C5AD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly FMBENLFBOGE JFMOPJMOHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly TaskCompletionSource<NENNLMOAGAP> KPHJLDMIGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly TaskCompletionSource<NENNLMOAGAP> PHLMJHPFFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly CancellationTokenSource MMMCLOMIOCJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool ICGPGJAHLDH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7B2CF0", Offset = "0x7B1AF0", VA = "0x1807B2CF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D00", Offset = "0x7B1B00", VA = "0x1807B2D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NCHMLMBHEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x806B20", Offset = "0x805920", VA = "0x180806B20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x806B10", Offset = "0x805910", VA = "0x180806B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool ODAEKCMMBNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xDD8000", Offset = "0xDD6E00", VA = "0x180DD8000")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1C58FE0", Offset = "0x1C57DE0", VA = "0x181C58FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public MCNJIALKEOH? EFDFOAECDND
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7654A0", Offset = "0x7642A0", VA = "0x1807654A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x765480", Offset = "0x764280", VA = "0x180765480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1C58FF0", Offset = "0x1C57DF0", VA = "0x181C58FF0", Slot = "7")]
	[AsyncStateMachine(typeof(MCHFHCHKLNK))]
	public Task<MCNJIALKEOH> NJKHNNHIOII()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x1C590E0", Offset = "0x1C57EE0", VA = "0x181C590E0")]
	public OEKEKDONHKE(FMBENLFBOGE BLNNMOCCDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x1C58D10", Offset = "0x1C57B10", VA = "0x181C58D10", Slot = "8")]
	[AsyncStateMachine(typeof(PFBCMMLAECA))]
	public Task AHAFNIAAENF(BEKPLBAAMIF NHBGKNCEKHK, NDHDEECGNKK CABHNFJIOGA, OIDNONMAINB? ALKMPIFMDLA, HIAIHBIEMAC? LGDCGDEAKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1C58E70", Offset = "0x1C57C70", VA = "0x181C58E70", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class CGINHCFKBBI : BJDFGMFIMDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly BDBELACLBMC OJIMDAHDJAP;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	public CGINHCFKBBI(BDBELACLBMC JGEGNGEMHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class EOOMFHKAEBE
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class HMNCMNHOOPM<TGraph> : CLNNMEPDLCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected readonly TGraph GPJGFOLBPJO;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual KHDBCMGANMC? ELDAJPEAGKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xC61360", Offset = "0xC60160", VA = "0x180C61360", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
		public HMNCMNHOOPM(TGraph GECCAOAFAMN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class JGGCJNMMAFH : HMNCMNHOOPM<JHFAGGFJHOG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override KHDBCMGANMC? ELDAJPEAGKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x1C50420", Offset = "0x1C4F220", VA = "0x181C50420", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1C50440", Offset = "0x1C4F240", VA = "0x181C50440")]
		public JGGCJNMMAFH(JHFAGGFJHOG EJLBANBKBOB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1C4B3A0", Offset = "0x1C4A1A0", VA = "0x181C4B3A0")]
	public static CLNNMEPDLCP IGHHFGMBDIH(BDJEMKJIEBD GECCAOAFAMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class JMCKKPEJFBA : JMIHONBKECL, EJFDBCHBLEF, CDIMJKAMKAN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class BPPILBAOFAK
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
			public BPPILBAOFAK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public AKNKONAODAN errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x1C5B0A0", Offset = "0x1C59EA0", VA = "0x181C5B0A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x1C5B310", Offset = "0x1C5A110", VA = "0x181C5B310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public JMCKKPEJFBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public BPPILBAOFAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x1C47BB0", Offset = "0x1C469B0", VA = "0x181C47BB0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task HIKPKJBKOJH(AKNKONAODAN errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct GIDJFCNMMNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public JMCKKPEJFBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1C4D5F0", Offset = "0x1C4C3F0", VA = "0x181C4D5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1C4DAD0", Offset = "0x1C4C8D0", VA = "0x181C4DAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class PKIBLMNPGJO
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
			public PKIBLMNPGJO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1C5B370", Offset = "0x1C5A170", VA = "0x181C5B370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1C5B650", Offset = "0x1C5A450", VA = "0x181C5B650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public JMCKKPEJFBA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public PKIBLMNPGJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1C5AD90", Offset = "0x1C59B90", VA = "0x181C5AD90")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task PJCKMANFODD(AKNKONAODAN errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly MAMGCGNFCBK NFHCIIMKJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly ICollection<ICPJBLPLNFC> CEKAGDDMGPO;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private AILLCOEEANE CHEHMPGDLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1C51B30", Offset = "0x1C50930", VA = "0x181C51B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public GDGHOPABCBJ<PJMKAHCGNJA> LLCKPHGPOGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x95F270", Offset = "0x95E070", VA = "0x18095F270", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(GDGHOPABCBJ<PJMKAHCGNJA>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9A8020", Offset = "0x9A6E20", VA = "0x1809A8020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public override GDGHOPABCBJ<GLEJILFHHIL> LPFIFLALGND
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1C52E70", Offset = "0x1C51C70", VA = "0x181C52E70", Slot = "19")]
		get
		{
			return default(GDGHOPABCBJ<GLEJILFHHIL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool MCAJNEEODKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1C514D0", Offset = "0x1C502D0", VA = "0x181C514D0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x1C53240", Offset = "0x1C52040", VA = "0x181C53240")]
	private JMCKKPEJFBA(BEKPLBAAMIF NHBGKNCEKHK, OHNNOPMBFDB AHGGOPDAOCA, MAMGCGNFCBK ENDIJKHCDLN, GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN, GDGHOPABCBJ<PJMKAHCGNJA> BOLANHMFLAL, bool APGKJAMGFKO, string MEBBBIMBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1C51F60", Offset = "0x1C50D60", VA = "0x181C51F60")]
	public static JMCKKPEJFBA IGHHFGMBDIH(BEKPLBAAMIF NHBGKNCEKHK, OHNNOPMBFDB AHGGOPDAOCA, MAMGCGNFCBK KHNEEJJPNNH, GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN, GDGHOPABCBJ<FGMAEDLBFGN> JPGOKKGFOMD, GDGHOPABCBJ<PJMKAHCGNJA> BOLANHMFLAL, bool APGKJAMGFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1C51B50", Offset = "0x1C50950", VA = "0x181C51B50", Slot = "20")]
	protected override void HCKCHEHGBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x1C51800", Offset = "0x1C50600", VA = "0x181C51800", Slot = "21")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1C52BD0", Offset = "0x1C519D0", VA = "0x181C52BD0", Slot = "28")]
	public void LHCBCMCGODL(ICPJBLPLNFC LAHIGOIMPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1C52490", Offset = "0x1C51290", VA = "0x181C52490", Slot = "25")]
	public void JNPGIOIHBBN(GEEJDBEIAJK MNNJJLACAIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1C50B30", Offset = "0x1C4F930", VA = "0x181C50B30", Slot = "26")]
	public void BPEGIODDPKF(GIKNAFODLAH JHEALGCPBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x1C516D0", Offset = "0x1C504D0", VA = "0x181C516D0", Slot = "22")]
	protected override void DAIEMKPBBEK(CHCOPPIJLPP GFDDFAFDPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1C519C0", Offset = "0x1C507C0", VA = "0x181C519C0", Slot = "30")]
	public string FHPPEILDLHB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1C52F30", Offset = "0x1C51D30", VA = "0x181C52F30", Slot = "27")]
	public string PKPENOMDHPE(int MMGMGPHHDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1C50510", Offset = "0x1C4F310", VA = "0x181C50510")]
	private void ADGOBCHNGCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1C51D10", Offset = "0x1C50B10", VA = "0x181C51D10", Slot = "29")]
	public void HLFJMEBGCAC(ICPJBLPLNFC LAHIGOIMPEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1C50740", Offset = "0x1C4F540", VA = "0x181C50740")]
	private void AJGKLPGODMI(bool POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1C508E0", Offset = "0x1C4F6E0", VA = "0x181C508E0", Slot = "31")]
	[AsyncStateMachine(typeof(GIDJFCNMMNN))]
	public Task BCKKMMNKPLF(string POACLGOFKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1C52D70", Offset = "0x1C51B70", VA = "0x181C52D70")]
	public void NKGCPKIDHIO(string POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1C51DE0", Offset = "0x1C50BE0", VA = "0x181C51DE0")]
	private void HNKHLHKMNGO(int POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x9A8020", Offset = "0x9A6E20", VA = "0x1809A8020")]
	internal void DHEKJPJOJNE(GDGHOPABCBJ<PJMKAHCGNJA> POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1C52340", Offset = "0x1C51140", VA = "0x181C52340")]
	[CompilerGenerated]
	private bool JIBPBKGNNNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1C509E0", Offset = "0x1C4F7E0", VA = "0x181C509E0")]
	[CompilerGenerated]
	private bool BODFHHDPEDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1C52A20", Offset = "0x1C51820", VA = "0x181C52A20")]
	[CompilerGenerated]
	private int LACBNPOEECD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1C52990", Offset = "0x1C51790", VA = "0x181C52990")]
	[CompilerGenerated]
	private bool KKDAHEJALJL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1C52840", Offset = "0x1C51640", VA = "0x181C52840")]
	[CompilerGenerated]
	private bool KIIKOMCCIOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1C522F0", Offset = "0x1C510F0", VA = "0x181C522F0")]
	[CompilerGenerated]
	private bool JAFFPLNFCLB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1C52B40", Offset = "0x1C51940", VA = "0x181C52B40")]
	[CompilerGenerated]
	private bool LFIKKCOHKBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1C52A20", Offset = "0x1C51820", VA = "0x181C52A20")]
	[CompilerGenerated]
	private int MINHOPBLPLC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x1C52CA0", Offset = "0x1C51AA0", VA = "0x181C52CA0")]
	[CompilerGenerated]
	private bool NCNEGHLGDGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1C517B0", Offset = "0x1C505B0", VA = "0x181C517B0")]
	[CompilerGenerated]
	private int DJEKHIMMMOI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1C52EB0", Offset = "0x1C51CB0", VA = "0x181C52EB0")]
	[CompilerGenerated]
	private void OOJBELAAFIJ(object POACLGOFKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1C52A70", Offset = "0x1C51870", VA = "0x181C52A70")]
	[CompilerGenerated]
	private bool LDEHLCPHPJG()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class HMHAFLIHMMD
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private abstract class BJLPMHHFCDM<TNode> : FCBMPHLMGPL<TNode> where TNode : notnull, JIBKOJKGICH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct DMFGJKGLJAL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public AsyncTaskMethodBuilder<FEBPNEDDNDE<GDGHOPABCBJ<HBDEADMFFFA>, KBBJHNEEOGJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public BJLPMHHFCDM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private TaskAwaiter<FEBPNEDDNDE<GDGHOPABCBJ<HBDEADMFFFA>, KBBJHNEEOGJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x4C90F40", Offset = "0x4C8FD40", VA = "0x184C90F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x4C91310", Offset = "0x4C90110", VA = "0x184C91310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct HGPEPDBMNOL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public BJLPMHHFCDM<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public GDGHOPABCBJ<HBDEADMFFFA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x35DC300", Offset = "0x35DB100", VA = "0x1835DC300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x35DC6D0", Offset = "0x35DB4D0", VA = "0x1835DC6D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public sealed override bool FJNEJFIMJKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public sealed override GDGHOPABCBJ<HBDEADMFFFA>? NDGPABNJEBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x44956E0", Offset = "0x44944E0", VA = "0x1844956E0", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x343BE60", Offset = "0x343AC60", VA = "0x18343BE60")]
		public BJLPMHHFCDM(BEKPLBAAMIF NHBGKNCEKHK, TNode AHGGOPDAOCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x44955C0", Offset = "0x44943C0", VA = "0x1844955C0", Slot = "93")]
		[AsyncStateMachine(typeof(BJLPMHHFCDM<>.DMFGJKGLJAL))]
		public override Task<FEBPNEDDNDE<GDGHOPABCBJ<HBDEADMFFFA>, KBBJHNEEOGJ>> JHJPHPBLPAC(string MEBBBIMBIJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4495480", Offset = "0x4494280", VA = "0x184495480", Slot = "118")]
		public sealed override bool CJNPFFBOIJC(GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4495520", Offset = "0x4494320", VA = "0x184495520", Slot = "107")]
		protected sealed override bool CKPIEPJBEEH(GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x44953E0", Offset = "0x44941E0", VA = "0x1844953E0", Slot = "108")]
		protected override bool CEEGEFKEDAJ(GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x44952D0", Offset = "0x44940D0", VA = "0x1844952D0", Slot = "94")]
		[AsyncStateMachine(typeof(BJLPMHHFCDM<>.HGPEPDBMNOL))]
		public override Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> AMAFLHPIENG(GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private sealed class EHFIPBFCNMA : AAGIOLBMKNE<BLGDINFLNOI>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override NodeVisualizationKey OBPJFFDCAMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7DD200", Offset = "0x7DC000", VA = "0x1807DD200", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool FEIBHAEDMMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310", Slot = "86")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1C4B2E0", Offset = "0x1C4A0E0", VA = "0x181C4B2E0")]
		public EHFIPBFCNMA(BEKPLBAAMIF NHBGKNCEKHK, BLGDINFLNOI AHGGOPDAOCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private abstract class AAGIOLBMKNE<TNode> : FCBMPHLMGPL<TNode> where TNode : notnull, KEHPFOPEGPD
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private struct GMCKGBAFDHG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public AsyncTaskMethodBuilder<FEBPNEDDNDE<GDGHOPABCBJ<HBDEADMFFFA>, KBBJHNEEOGJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AAGIOLBMKNE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter<FEBPNEDDNDE<GDGHOPABCBJ<HBDEADMFFFA>, KBBJHNEEOGJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x35375D0", Offset = "0x35363D0", VA = "0x1835375D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x3537940", Offset = "0x3536740", VA = "0x183537940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct NPPMNLABKJN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public AAGIOLBMKNE<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public GDGHOPABCBJ<HBDEADMFFFA> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x3C13CD0", Offset = "0x3C12AD0", VA = "0x183C13CD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x3C14020", Offset = "0x3C12E20", VA = "0x183C14020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override CEEPFMHPMMJ<DEIDFGDEEMG>? BEELDJDCMLN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x33CAA00", Offset = "0x33C9800", VA = "0x1833CAA00", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override GDGHOPABCBJ<HBDEADMFFFA>? NDGPABNJEBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x343BE80", Offset = "0x343AC80", VA = "0x18343BE80", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x343BE60", Offset = "0x343AC60", VA = "0x18343BE60")]
		public AAGIOLBMKNE(BEKPLBAAMIF NHBGKNCEKHK, TNode AHGGOPDAOCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x343BD40", Offset = "0x343AB40", VA = "0x18343BD40", Slot = "93")]
		[AsyncStateMachine(typeof(AAGIOLBMKNE<>.GMCKGBAFDHG))]
		public override Task<FEBPNEDDNDE<GDGHOPABCBJ<HBDEADMFFFA>, KBBJHNEEOGJ>> JHJPHPBLPAC(string MEBBBIMBIJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x343BC00", Offset = "0x343AA00", VA = "0x18343BC00", Slot = "118")]
		public sealed override bool CJNPFFBOIJC(GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x343BCA0", Offset = "0x343AAA0", VA = "0x18343BCA0", Slot = "107")]
		protected sealed override bool CKPIEPJBEEH(GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x343BB60", Offset = "0x343A960", VA = "0x18343BB60", Slot = "108")]
		protected override bool CEEGEFKEDAJ(GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x343BA50", Offset = "0x343A850", VA = "0x18343BA50", Slot = "94")]
		[AsyncStateMachine(typeof(AAGIOLBMKNE<>.NPPMNLABKJN))]
		public override Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> AMAFLHPIENG(GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class FCGKILKLEGO : FCBMPHLMGPL<IBIKHMAPJON>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override NodeVisualizationKey OBPJFFDCAMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8DCFA0", Offset = "0x8DBDA0", VA = "0x1808DCFA0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1C4BA70", Offset = "0x1C4A870", VA = "0x181C4BA70")]
		public FCGKILKLEGO(BEKPLBAAMIF NHBGKNCEKHK, IBIKHMAPJON AHGGOPDAOCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class DPEGCNAGNPL : AAGIOLBMKNE<OCHIMANEGIG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool FLNAOEHALNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override NodeVisualizationKey OBPJFFDCAMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x7D0A40", Offset = "0x7CF840", VA = "0x1807D0A40", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1C4AFD0", Offset = "0x1C49DD0", VA = "0x181C4AFD0")]
		public DPEGCNAGNPL(BEKPLBAAMIF NHBGKNCEKHK, OCHIMANEGIG AHGGOPDAOCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class IFFMCDCHPLP : FCBMPHLMGPL<DLDMIGMPPKN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey OBPJFFDCAMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xEFFDE0", Offset = "0xEFEBE0", VA = "0x180EFFDE0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1C4F460", Offset = "0x1C4E260", VA = "0x181C4F460")]
		public IFFMCDCHPLP(BEKPLBAAMIF NHBGKNCEKHK, DLDMIGMPPKN AHGGOPDAOCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class NHPBKBNBMLE : FCBMPHLMGPL<PENEAGKDOFA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override NodeVisualizationKey OBPJFFDCAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x7D1D60", Offset = "0x7D0B60", VA = "0x1807D1D60", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1C58260", Offset = "0x1C57060", VA = "0x181C58260")]
		public NHPBKBNBMLE(BEKPLBAAMIF NHBGKNCEKHK, PENEAGKDOFA AHGGOPDAOCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310", Slot = "107")]
		protected override bool CKPIEPJBEEH(GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class MNKCJGGIBNB : FCBMPHLMGPL<DJDBJBAGNLI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override NodeVisualizationKey OBPJFFDCAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7E7730", Offset = "0x7E6530", VA = "0x1807E7730", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1C57AA0", Offset = "0x1C568A0", VA = "0x181C57AA0")]
		public MNKCJGGIBNB(BEKPLBAAMIF NHBGKNCEKHK, DJDBJBAGNLI AHGGOPDAOCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class EBGNLMKHLHJ : FCBMPHLMGPL<JLEPEGNFBME>
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override NodeVisualizationKey OBPJFFDCAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x7CF820", Offset = "0x7CE620", VA = "0x1807CF820", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1C4B030", Offset = "0x1C49E30", VA = "0x181C4B030")]
		public EBGNLMKHLHJ(BEKPLBAAMIF NHBGKNCEKHK, JLEPEGNFBME AHGGOPDAOCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class ELLMCBBNLAC : BJLPMHHFCDM<EKNJNDGEIOP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override NodeVisualizationKey OBPJFFDCAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x7DCCC0", Offset = "0x7DBAC0", VA = "0x1807DCCC0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1C4B340", Offset = "0x1C4A140", VA = "0x181C4B340")]
		public ELLMCBBNLAC(BEKPLBAAMIF NHBGKNCEKHK, EKNJNDGEIOP AHGGOPDAOCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class FCBMPHLMGPL<TNode> : LJOAMDGCCKK, IDisposable where TNode : notnull, OHNNOPMBFDB
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private sealed class APELFLIHPHE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public FCBMPHLMGPL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public BEKPLBAAMIF circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public APELFLIHPHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x36F1340", Offset = "0x36F0140", VA = "0x1836F1340")]
			internal ALDGABCPPFL GCJJFEOMBOJ(FLNICCHAMPN portGroup, int index)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct CPLMNHDCILD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public FCBMPHLMGPL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public PKNLFCCHKGJ? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public GHOEKLLNHGD? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x4A42010", Offset = "0x4A40E10", VA = "0x184A42010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4A422B0", Offset = "0x4A410B0", VA = "0x184A422B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct KPCJIAKDEGG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public FCBMPHLMGPL<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x38D2230", Offset = "0x38D1030", VA = "0x1838D2230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x38D2490", Offset = "0x38D1290", VA = "0x1838D2490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private BEKPLBAAMIF PKBEEFOHNFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private DDDCNHEPMAG<HBDEADMFFFA, ALDGABCPPFL> OLIMHDGNFAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private DDDCNHEPMAG<HBDEADMFFFA, ADCKDHCCEFE> PCLMJKHAIAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[CompilerGenerated]
		private Action<GDGHOPABCBJ<HBDEADMFFFA>>? FPJCMGABHIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[CompilerGenerated]
		private Action<GDGHOPABCBJ<HBDEADMFFFA>, ADCKDHCCEFE>? LPFLLBKNJOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[CompilerGenerated]
		private Action<GDGHOPABCBJ<HBDEADMFFFA>, GDGHOPABCBJ<HBDEADMFFFA>>? JKEAKJEGHCF;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected TNode OOHMLFPINMO
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public CEEPFMHPMMJ<FBKECGKLFLN> ELIGKFBBMAM
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0xD77A70", Offset = "0xD76870", VA = "0x180D77A70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(CEEPFMHPMMJ<FBKECGKLFLN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public object KPDACFOBKOG
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x30956E0", Offset = "0x30944E0", VA = "0x1830956E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public virtual bool FMCBMBDLICP
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x779310", Offset = "0x778110", VA = "0x180779310", Slot = "80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public int OJAODFKIAIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x338BD70", Offset = "0x338AB70", VA = "0x18338BD70", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public ADJIGLMOICK PJNGPLNEPBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x338BD20", Offset = "0x338AB20", VA = "0x18338BD20", Slot = "9")]
			get
			{
				return default(ADJIGLMOICK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string IABDAFPIFKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x338C1B0", Offset = "0x338AFB0", VA = "0x18338C1B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		protected virtual bool ELPFOJPFAIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "82")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public virtual NodeVisualizationKey OBPJFFDCAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public GDGHOPABCBJ<JKPCOGCCCPA> ENIIFDIDECI
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x76E110", Offset = "0x76CF10", VA = "0x18076E110", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(GDGHOPABCBJ<JKPCOGCCCPA>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x7ACAD0", Offset = "0x7AB8D0", VA = "0x1807ACAD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public virtual bool JFOALFKALPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "84")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public virtual bool FLNAOEHALNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "85")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public virtual bool FEIBHAEDMMH
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "86")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public virtual JPMNPDGKAHH CNKFGKCOJPL
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x7CD230", Offset = "0x7CC030", VA = "0x1807CD230", Slot = "87")]
			get
			{
				return default(JPMNPDGKAHH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool CACKOAOGNHP
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x338BB40", Offset = "0x338A940", VA = "0x18338BB40", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool FNCHNNJFBCK
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x338BB90", Offset = "0x338A990", VA = "0x18338BB90", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool HEEGOAEEFAC
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x338BBE0", Offset = "0x338A9E0", VA = "0x18338BBE0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public int OJMOINAJBCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x338C000", Offset = "0x338AE00", VA = "0x18338C000", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool MMKIFHMABHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x338BF20", Offset = "0x338AD20", VA = "0x18338BF20", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string DCAFMNKENBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x338BE30", Offset = "0x338AC30", VA = "0x18338BE30", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool JFNIPCKJIBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x338BC80", Offset = "0x338AA80", VA = "0x18338BC80", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool OPLBHBDPBAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xAEA470", Offset = "0xAE9270", VA = "0x180AEA470", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xB00840", Offset = "0xAFF640", VA = "0x180B00840")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public virtual bool NLMGLGDPNPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool CNIOMDLBLJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x338BC30", Offset = "0x338AA30", VA = "0x18338BC30", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool IPDPAIIOFAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x338BE70", Offset = "0x338AC70", VA = "0x18338BE70", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public PKNLFCCHKGJ LCPDOLOFPFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x338BF60", Offset = "0x338AD60", VA = "0x18338BF60", Slot = "27")]
			get
			{
				return default(PKNLFCCHKGJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public GHOEKLLNHGD AEJINJPKNKB
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x338BFB0", Offset = "0x338ADB0", VA = "0x18338BFB0", Slot = "29")]
			get
			{
				return default(GHOEKLLNHGD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public virtual bool OBCNFJCGAIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "102")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public virtual KOEBOFHOCGJ? MAHDEFJJLFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "103")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public virtual FCABALDDDCC? PFEBEAJBJHC
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "104")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual IEnumerable<CEEPFMHPMMJ<CIENEMDJNND>>? PPPHDOCIEIG
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "105")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool DGDHPMJAGIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x338BCD0", Offset = "0x338AAD0", VA = "0x18338BCD0", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public CEEPFMHPMMJ<DEIDFGDEEMG> JBLGPPKAOEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x338BDB0", Offset = "0x338ABB0", VA = "0x18338BDB0", Slot = "54")]
			get
			{
				return default(CEEPFMHPMMJ<DEIDFGDEEMG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool FJNEJFIMJKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual CEEPFMHPMMJ<DEIDFGDEEMG>? BEELDJDCMLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x338BE00", Offset = "0x338AC00", VA = "0x18338BE00", Slot = "111")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool DECPKPEMAEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x338BEC0", Offset = "0x338ACC0", VA = "0x18338BEC0", Slot = "59")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual string FJPKIFMMAAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x768A70", Offset = "0x767870", VA = "0x180768A70", Slot = "112")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x768A80", Offset = "0x767880", VA = "0x180768A80", Slot = "113")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public CEEPFMHPMMJ<CIENEMDJNND> NCIHHIJCGOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x338C040", Offset = "0x338AE40", VA = "0x18338C040", Slot = "60")]
			get
			{
				return default(CEEPFMHPMMJ<CIENEMDJNND>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public CEEPFMHPMMJ<CIENEMDJNND>? IKIEENLKDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x338C090", Offset = "0x338AE90", VA = "0x18338C090", Slot = "114")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public GEPDKPKOLAO<HBDEADMFFFA, ADCKDHCCEFE> HOJIEBCEBHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x338C170", Offset = "0x338AF70", VA = "0x18338C170", Slot = "62")]
			get
			{
				return default(GEPDKPKOLAO<HBDEADMFFFA, ADCKDHCCEFE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public virtual GDGHOPABCBJ<HBDEADMFFFA>? NDGPABNJEBM
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EFMOPMPAFFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x3389490", Offset = "0x3388290", VA = "0x183389490", Slot = "35")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x338AAC0", Offset = "0x33898C0", VA = "0x18338AAC0", Slot = "36")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event APJGEEPFCIN CJGIIJPHLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x338AEC0", Offset = "0x3389CC0", VA = "0x18338AEC0", Slot = "37")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x3388FC0", Offset = "0x3387DC0", VA = "0x183388FC0", Slot = "38")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HIJFFJAKHOD EMOJMFLJMAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x338A2D0", Offset = "0x33890D0", VA = "0x18338A2D0", Slot = "39")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x3388000", Offset = "0x3386E00", VA = "0x183388000", Slot = "40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action DIFLCOMJMAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x338A170", Offset = "0x3388F70", VA = "0x18338A170", Slot = "41")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x338B6F0", Offset = "0x338A4F0", VA = "0x18338B6F0", Slot = "42")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action EINIGPEADGA
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x33896D0", Offset = "0x33884D0", VA = "0x1833896D0", Slot = "43")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x338AFB0", Offset = "0x3389DB0", VA = "0x18338AFB0", Slot = "44")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<GDGHOPABCBJ<HBDEADMFFFA>, ADCKDHCCEFE> CBLBFAOEECM
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x338B640", Offset = "0x338A440", VA = "0x18338B640", Slot = "64")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x338B110", Offset = "0x3389F10", VA = "0x18338B110", Slot = "65")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<GDGHOPABCBJ<HBDEADMFFFA>, ADCKDHCCEFE> IKKCPPPDMAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x338B2A0", Offset = "0x338A0A0", VA = "0x18338B2A0", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x338A0B0", Offset = "0x3388EB0", VA = "0x18338A0B0", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<GDGHOPABCBJ<HBDEADMFFFA>> CGDDFLBJLOM
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x338B790", Offset = "0x338A590", VA = "0x18338B790", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x33880A0", Offset = "0x3386EA0", VA = "0x1833880A0", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<GDGHOPABCBJ<HBDEADMFFFA>, GDGHOPABCBJ<HBDEADMFFFA>> MMDFAMDAEPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x338AD70", Offset = "0x3389B70", VA = "0x18338AD70", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x338A210", Offset = "0x3389010", VA = "0x18338A210", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<GDGHOPABCBJ<HBDEADMFFFA>, ADCKDHCCEFE> OBMNIAFMPKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x3388160", Offset = "0x3386F60", VA = "0x183388160", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x338AB60", Offset = "0x3389960", VA = "0x18338AB60", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x338B850", Offset = "0x338A650", VA = "0x18338B850")]
		[NAFHHGBIDNI("Need to handle `Name` better.")]
		[NAFHHGBIDNI("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		public FCBMPHLMGPL(BEKPLBAAMIF NHBGKNCEKHK, TNode AHGGOPDAOCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3389790", Offset = "0x3388590", VA = "0x183389790", Slot = "78")]
		protected virtual void HCKCHEHGBKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3388220", Offset = "0x3387020", VA = "0x183388220", Slot = "79")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3387E10", Offset = "0x3386C10", VA = "0x183387E10", Slot = "81")]
		public virtual void AFLHIDGAEAM(int HGFJPJDAFOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x338B1F0", Offset = "0x3389FF0", VA = "0x18338B1F0")]
		public bool NAGCDNBCJMP([In] PKNLFCCHKGJ POACLGOFKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x3389530", Offset = "0x3388330", VA = "0x183389530")]
		public bool FMMPDOCDAJC([In] GHOEKLLNHGD POACLGOFKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x338A060", Offset = "0x3388E60", VA = "0x18338A060", Slot = "90")]
		public virtual void IHCHKLHICOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x338AC20", Offset = "0x3389A20", VA = "0x18338AC20", Slot = "32")]
		[AsyncStateMachine(typeof(FCBMPHLMGPL<>.CPLMNHDCILD))]
		public Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> JPAKIKJHCFM(PKNLFCCHKGJ? BBEJKAIJGPI, GHOEKLLNHGD? IOMLNAOLLNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "91")]
		public virtual void KDAILABOAOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "92")]
		public virtual void KGAPGCNIPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1386690", Offset = "0x1385490", VA = "0x181386690")]
		protected void IHBFCNIOPNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E740", Offset = "0x1C3D540", VA = "0x181C3E740")]
		protected void JCOCEKELLEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x104C1A0", Offset = "0x104AFA0", VA = "0x18104C1A0")]
		private void BECHEGMOAGI([In] GHOEKLLNHGD ALADLBOMNEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x338A990", Offset = "0x3389790", VA = "0x18338A990", Slot = "93")]
		public virtual Task<FEBPNEDDNDE<GDGHOPABCBJ<HBDEADMFFFA>, KBBJHNEEOGJ>> JHJPHPBLPAC(string MEBBBIMBIJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3387E60", Offset = "0x3386C60", VA = "0x183387E60", Slot = "94")]
		public virtual Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> AMAFLHPIENG(GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x338AF60", Offset = "0x3389D60", VA = "0x18338AF60", Slot = "95")]
		public virtual void KKOICHEDBPG(GDGHOPABCBJ<HBDEADMFFFA> OCMJNDDMDAL, GDGHOPABCBJ<HBDEADMFFFA> PABBJIBBIGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x338AE30", Offset = "0x3389C30", VA = "0x18338AE30", Slot = "96")]
		public virtual IEnumerable<IIHJOGGFNLJ> KDKKGACIPPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x338B440", Offset = "0x338A240", VA = "0x18338B440", Slot = "97")]
		public FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ> OIMAGEOHBBI(string EHNEHNFFBDJ)
		{
			return default(FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x338B4C0", Offset = "0x338A2C0", VA = "0x18338B4C0", Slot = "45")]
		public bool ONAJKBNEFDF([Out] Guid KGBHCEEKCPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3387F80", Offset = "0x3386D80", VA = "0x183387F80", Slot = "98")]
		public virtual bool CACAABJINNP([In] Guid BELINILLNPN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x338B0C0", Offset = "0x3389EC0", VA = "0x18338B0C0", Slot = "99")]
		public virtual void LJDFGIJMKMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "100")]
		public virtual void FHPHCPANAOD(bool MOEBLGKHMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x75DC40", Offset = "0x75CA40", VA = "0x18075DC40", Slot = "101")]
		public virtual HDJMLOGMIJB DNDBPHNENNL([In] PLAFLOCJCPB IHINEJBOFMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3388E40", Offset = "0x3387C40", VA = "0x183388E40")]
		protected void EIIPDLFPMII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "106")]
		protected virtual void ADNBHEMEJDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3387FD0", Offset = "0x3386DD0", VA = "0x183387FD0", Slot = "107")]
		protected virtual bool CKPIEPJBEEH(GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "108")]
		protected virtual bool CEEGEFKEDAJ(GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "116")]
		protected virtual void JCBDLANJPJB(GALNOJJOJAI GLNIFNKBCPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "117")]
		protected virtual void GCLIDJLKMNF(GALNOJJOJAI NAOOHEOICKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x3387F30", Offset = "0x3386D30", VA = "0x183387F30", Slot = "74")]
		public void BPEGIODDPKF(GALNOJJOJAI NAOOHEOICKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x338B360", Offset = "0x338A160", VA = "0x18338B360", Slot = "75")]
		public OMELFBJJJNK OIKLKNKECKN()
		{
			return default(OMELFBJJJNK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7A8300", Offset = "0x7A7100", VA = "0x1807A8300", Slot = "118")]
		public virtual bool CJNPFFBOIJC(GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x3389770", Offset = "0x3388570", VA = "0x183389770")]
		private void GIIHPDGNKHA([In] PKNLFCCHKGJ CMKBDFOJBFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x338A370", Offset = "0x3389170", VA = "0x18338A370")]
		private void JBPDLKJIMDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x338A470", Offset = "0x3389270", VA = "0x18338A470")]
		private void JGMAAAMLJFC(int LMAJHNEBCLD, FLNICCHAMPN DMNPLPLLFFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x3389E80", Offset = "0x3388C80", VA = "0x183389E80")]
		private void HDFKPEHGGNB(int OCMJNDDMDAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3389590", Offset = "0x3388390", VA = "0x183389590")]
		private void GFDOOIIKCAF(int OCMJNDDMDAL, FLNICCHAMPN KOJDDJMPCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x3388A90", Offset = "0x3387890", VA = "0x183388A90")]
		private void EGDLBFEEFDA(int LMMLCGAMMEE, int KGACLNPHPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x338AA60", Offset = "0x3389860", VA = "0x18338AA60")]
		private void JIFBPKNJKHN(int LMMLCGAMMEE, int KGACLNPHPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x338B250", Offset = "0x338A050", VA = "0x18338B250")]
		private void NGJPJLEJNAN(int OCMJNDDMDAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3389060", Offset = "0x3387E60", VA = "0x183389060")]
		private void FEEBDHIILKD(int LMAJHNEBCLD, FLNICCHAMPN DMNPLPLLFFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3388F40", Offset = "0x3387D40", VA = "0x183388F40")]
		private void EOJLAABHCLN(int OCMJNDDMDAL, FLNICCHAMPN KOJDDJMPCDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3389ED0", Offset = "0x3388CD0", VA = "0x183389ED0", Slot = "119")]
		[AsyncStateMachine(typeof(FCBMPHLMGPL<>.KPCJIAKDEGG))]
		public virtual Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> HOGKMAHGHNH(string EHNEHNFFBDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x338B050", Offset = "0x3389E50", VA = "0x18338B050", Slot = "52")]
		private void LAEINFABPJM(object ADPCADGHCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3389FF0", Offset = "0x3388DF0", VA = "0x183389FF0", Slot = "53")]
		private void IDFAAJJLNAJ(object ADPCADGHCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x338B1C0", Offset = "0x3389FC0", VA = "0x18338B1C0", Slot = "28")]
		private bool MIFPOJIIFHG([In] PKNLFCCHKGJ POACLGOFKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x338B610", Offset = "0x338A410", VA = "0x18338B610", Slot = "30")]
		private bool OOBBBKLBKGC([In] GHOEKLLNHGD POACLGOFKAJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class ADAAKJCNBAI : BJLPMHHFCDM<AAIMNBNIMEE>
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override NodeVisualizationKey OBPJFFDCAMB
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xA663C0", Offset = "0xA651C0", VA = "0x180A663C0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E130", Offset = "0x1C3CF30", VA = "0x181C3E130")]
		public ADAAKJCNBAI(BEKPLBAAMIF NHBGKNCEKHK, AAIMNBNIMEE AHGGOPDAOCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class EOPPMJKLOEP : FCBMPHLMGPL<OJHDKHCJGEI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override NodeVisualizationKey OBPJFFDCAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x17D43E0", Offset = "0x17D31E0", VA = "0x1817D43E0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x1C4B530", Offset = "0x1C4A330", VA = "0x181C4B530")]
		public EOPPMJKLOEP(BEKPLBAAMIF NHBGKNCEKHK, OJHDKHCJGEI AHGGOPDAOCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private sealed class LEHFCBLHLOB : FCBMPHLMGPL<KAECHCPNCOJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public override NodeVisualizationKey OBPJFFDCAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x852230", Offset = "0x851030", VA = "0x180852230", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x1C554F0", Offset = "0x1C542F0", VA = "0x181C554F0")]
		public LEHFCBLHLOB(BEKPLBAAMIF NHBGKNCEKHK, KAECHCPNCOJ AHGGOPDAOCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class IGAMHOPMIEM : FCBMPHLMGPL<PMGEBKCJLEC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public override NodeVisualizationKey OBPJFFDCAMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7D13A0", Offset = "0x7D01A0", VA = "0x1807D13A0", Slot = "83")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x1C4F4C0", Offset = "0x1C4E2C0", VA = "0x181C4F4C0")]
		public IGAMHOPMIEM(BEKPLBAAMIF NHBGKNCEKHK, PMGEBKCJLEC AHGGOPDAOCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x1C4DED0", Offset = "0x1C4CCD0", VA = "0x181C4DED0")]
	internal static LJOAMDGCCKK IGHHFGMBDIH(BEKPLBAAMIF NHBGKNCEKHK, OHNNOPMBFDB AHGGOPDAOCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class OBLNJKFANMM : JMIHONBKECL, EFCINJCGCFO, CDIMJKAMKAN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public GDGHOPABCBJ<PEIGABEPHFN> NIPICKOAEHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xEC5440", Offset = "0xEC4240", VA = "0x180EC5440", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(GDGHOPABCBJ<PEIGABEPHFN>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x1094E50", Offset = "0x1093C50", VA = "0x181094E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public override GDGHOPABCBJ<GLEJILFHHIL> LPFIFLALGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x1C58990", Offset = "0x1C57790", VA = "0x181C58990", Slot = "19")]
		get
		{
			return default(GDGHOPABCBJ<GLEJILFHHIL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x1C589D0", Offset = "0x1C577D0", VA = "0x181C589D0")]
	private OBLNJKFANMM(BEKPLBAAMIF NHBGKNCEKHK, OHNNOPMBFDB AHGGOPDAOCA, BMPKOBDDONF LFJPHNPINAE, GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN, GDGHOPABCBJ<PEIGABEPHFN> MAGFIFIOEFK, bool APGKJAMGFKO, string MEBBBIMBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x1C58670", Offset = "0x1C57470", VA = "0x181C58670")]
	public static OBLNJKFANMM IGHHFGMBDIH(BEKPLBAAMIF NHBGKNCEKHK, OHNNOPMBFDB AHGGOPDAOCA, BMPKOBDDONF BDDEOEOKOJN, GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN, GDGHOPABCBJ<PEMFHECBMBH> JBFMMBHBONH, GDGHOPABCBJ<PEIGABEPHFN> MAGFIFIOEFK, bool APGKJAMGFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x1094E50", Offset = "0x1093C50", VA = "0x181094E50")]
	internal void CPCNLPKGPAB(GDGHOPABCBJ<PEIGABEPHFN> POACLGOFKAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public abstract class JMIHONBKECL : CDIMJKAMKAN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private struct PPAMCKKNEKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private DPFLFDCKAEK? DLMABPFEGKL;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x1C5AF00", Offset = "0x1C59D00", VA = "0x181C5AF00")]
		public void LHLJEDFLAKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x1C5AE60", Offset = "0x1C59C60", VA = "0x181C5AE60")]
		public DPFLFDCKAEK JOMGPGOLHOA(JMIHONBKECL HJFOBIOHMFM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	protected readonly BEKPLBAAMIF PKBEEFOHNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	protected readonly OHNNOPMBFDB MKHCEJCPCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private PPAMCKKNEKC FHIBKEFHDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly DLEHJAEOLPH DMJEKPBGPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly List<LAELPBAPDDB> JPPCOPEGCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<DNBDNMAJAGO> CLIPPNBODAB;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public IEnumerable<StaticEdge> IKPNIJJDIPO
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x1C537C0", Offset = "0x1C525C0", VA = "0x181C537C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public DisplayKind OJDEGPOOIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x76E110", Offset = "0x76CF10", VA = "0x18076E110", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public CEEPFMHPMMJ<DEIDFGDEEMG> JBLGPPKAOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x1C53FF0", Offset = "0x1C52DF0", VA = "0x181C53FF0", Slot = "6")]
		get
		{
			return default(CEEPFMHPMMJ<DEIDFGDEEMG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public CAGLBKEPFAA DMMNGGDNJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8B2300", Offset = "0x8B1100", VA = "0x1808B2300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public DHCEGNNAANE LAFEKDAGJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x1C534F0", Offset = "0x1C522F0", VA = "0x181C534F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	protected DPFLFDCKAEK MNJDJFCEJPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x1C534F0", Offset = "0x1C522F0", VA = "0x181C534F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public PortImage BJLCKIOBLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x1C53E00", Offset = "0x1C52C00", VA = "0x181C53E00", Slot = "12")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public string FJPKIFMMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x7656B0", Offset = "0x7644B0", VA = "0x1807656B0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x765450", Offset = "0x764250", VA = "0x180765450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public CEEPFMHPMMJ<CIENEMDJNND> NCIHHIJCGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1C53DE0", Offset = "0x1C52BE0", VA = "0x181C53DE0", Slot = "8")]
		get
		{
			return default(CEEPFMHPMMJ<CIENEMDJNND>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public GDGHOPABCBJ<HBDEADMFFFA> OGKBIBADMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xC63670", Offset = "0xC62470", VA = "0x180C63670", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(GDGHOPABCBJ<HBDEADMFFFA>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xC61FE0", Offset = "0xC60DE0", VA = "0x180C61FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public abstract GDGHOPABCBJ<GLEJILFHHIL> LPFIFLALGND
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1C54610", Offset = "0x1C53410", VA = "0x181C54610")]
	protected JMIHONBKECL(BEKPLBAAMIF NHBGKNCEKHK, OHNNOPMBFDB AHGGOPDAOCA, DLEHJAEOLPH EJAJDNOKKJL, GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN, bool APGKJAMGFKO, string MEBBBIMBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1C53950", Offset = "0x1C52750", VA = "0x181C53950", Slot = "20")]
	protected virtual void HCKCHEHGBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x1C53610", Offset = "0x1C52410", VA = "0x181C53610", Slot = "21")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x1C53760", Offset = "0x1C52560", VA = "0x181C53760", Slot = "13")]
	public void FOABHMMCINI(LAELPBAPDDB AIMEBJCOCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1C53F90", Offset = "0x1C52D90", VA = "0x181C53F90", Slot = "14")]
	public void NJJOIIMEEPJ(DNBDNMAJAGO AIMEBJCOCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x1C54020", Offset = "0x1C52E20", VA = "0x181C54020", Slot = "15")]
	public void PCMCNPOHJEF(CHCOPPIJLPP GFDDFAFDPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x1C53590", Offset = "0x1C52390", VA = "0x181C53590", Slot = "22")]
	protected virtual void DAIEMKPBBEK(CHCOPPIJLPP GFDDFAFDPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x1C53AA0", Offset = "0x1C528A0", VA = "0x181C53AA0")]
	private void HGNEEHAHANN(bool KNIBDNLMNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x1C53C30", Offset = "0x1C52A30", VA = "0x181C53C30")]
	private void ICMKMBICCHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x1C53340", Offset = "0x1C52140", VA = "0x181C53340")]
	private void AIABJAKMLDL([In] DEHDEDGDMBL ODHOKJJCFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x1C545B0", Offset = "0x1C533B0", VA = "0x181C545B0", Slot = "16")]
	public void PJJBJFDKMOL(LAELPBAPDDB AIMEBJCOCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x1C53F30", Offset = "0x1C52D30", VA = "0x181C53F30", Slot = "17")]
	public void LPJKACLOLNH(DNBDNMAJAGO AIMEBJCOCBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x765450", Offset = "0x764250", VA = "0x180765450")]
	internal void FEIGMCPACKK(string MEBBBIMBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x1C535F0", Offset = "0x1C523F0", VA = "0x181C535F0")]
	internal void DDCFBKOKIAH(OPNEEPLBHNF BLNNMOCCDKN, CAGLBKEPFAA FLHOFPAHPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0xC61FE0", Offset = "0xC60DE0", VA = "0x180C61FE0")]
	internal void ECCIGJPPDIH(GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public sealed class ALDGABCPPFL : ADCKDHCCEFE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class LIEJHBEAOFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public BEKPLBAAMIF circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public OHNNOPMBFDB node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public GDGHOPABCBJ<HBDEADMFFFA> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool canInteract;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public LIEJHBEAOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1C55550", Offset = "0x1C54350", VA = "0x181C55550")]
		internal JMCKKPEJFBA HDEIBEKIGNN((int PortDescIndex, int PortIndex, MAMGCGNFCBK InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1C555D0", Offset = "0x1C543D0", VA = "0x181C555D0")]
		internal OBLNJKFANMM IFJLIBFHELB(BMPKOBDDONF i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct CENABHDFHEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public ALDGABCPPFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private AKNKONAODAN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x1C48050", Offset = "0x1C46E50", VA = "0x181C48050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x1C484B0", Offset = "0x1C472B0", VA = "0x181C484B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct DNKOGLNMGAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public ALDGABCPPFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public GDGHOPABCBJ<FGMAEDLBFGN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private AKNKONAODAN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1C4AA90", Offset = "0x1C49890", VA = "0x181C4AA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x1C4ADE0", Offset = "0x1C49BE0", VA = "0x181C4ADE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct OINOAPBOMKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public ALDGABCPPFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public GDGHOPABCBJ<PEMFHECBMBH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private AKNKONAODAN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x1C59D30", Offset = "0x1C58B30", VA = "0x181C59D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x1C5A080", Offset = "0x1C58E80", VA = "0x181C5A080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private struct GCAABJMNDIA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public ALDGABCPPFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public GDGHOPABCBJ<FGMAEDLBFGN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public GDGHOPABCBJ<FGMAEDLBFGN> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private AKNKONAODAN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1C4CA70", Offset = "0x1C4B870", VA = "0x181C4CA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x1C4CDC0", Offset = "0x1C4BBC0", VA = "0x181C4CDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private struct IKACNMHMNDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public ALDGABCPPFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public GDGHOPABCBJ<PEMFHECBMBH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public GDGHOPABCBJ<PEMFHECBMBH> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private AKNKONAODAN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x1C4F520", Offset = "0x1C4E320", VA = "0x181C4F520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1C4F870", Offset = "0x1C4E670", VA = "0x181C4F870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private struct MCDCLOBEMMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public ALDGABCPPFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private AKNKONAODAN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x1C57170", Offset = "0x1C55F70", VA = "0x181C57170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x1C575E0", Offset = "0x1C563E0", VA = "0x181C575E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private struct CPPFPJBCDLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public ALDGABCPPFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private AKNKONAODAN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x1C49940", Offset = "0x1C48740", VA = "0x181C49940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1C49C90", Offset = "0x1C48A90", VA = "0x181C49C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct AMBMLBBFJMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public ALDGABCPPFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public GDGHOPABCBJ<FGMAEDLBFGN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private AKNKONAODAN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1C44040", Offset = "0x1C42E40", VA = "0x181C44040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1C44390", Offset = "0x1C43190", VA = "0x181C44390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct DEBCBECMODK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public ALDGABCPPFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public GDGHOPABCBJ<PEMFHECBMBH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private AKNKONAODAN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1C4A100", Offset = "0x1C48F00", VA = "0x181C4A100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1C4A450", Offset = "0x1C49250", VA = "0x181C4A450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	private struct DCDJBLDECBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public ALDGABCPPFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public OPDOFKFGDCP type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public GDGHOPABCBJ<FGMAEDLBFGN> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private AKNKONAODAN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x1C49D00", Offset = "0x1C48B00", VA = "0x181C49D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x1C4A090", Offset = "0x1C48E90", VA = "0x181C4A090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct CJBHMHIJPDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public ALDGABCPPFL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public OPDOFKFGDCP type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public GDGHOPABCBJ<PEMFHECBMBH> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private AKNKONAODAN <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private TaskAwaiter<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x1C48630", Offset = "0x1C47430", VA = "0x181C48630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x1C489C0", Offset = "0x1C477C0", VA = "0x181C489C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly bool ILBDMPPGOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly BEKPLBAAMIF PKBEEFOHNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly bool CCEHGNJPOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private GEPDKPKOLAO<PJMKAHCGNJA, JMCKKPEJFBA> AFKAGMLNEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private GEPDKPKOLAO<PJMKAHCGNJA, EJFDBCHBLEF> BFEEKDNDFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly OHNNOPMBFDB MKHCEJCPCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private GEPDKPKOLAO<PEIGABEPHFN, OBLNJKFANMM> JNKCJCBCCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private GEPDKPKOLAO<PEIGABEPHFN, EFCINJCGCFO> FGHLOMFNOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private string? DANHMJGKCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly FLNICCHAMPN OCJHHKOFBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private GDGHOPABCBJ<HBDEADMFFFA> LDIDHBDGJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	[CompilerGenerated]
	private Action? CNAHGPIBJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[CompilerGenerated]
	private Action? JFLHDELKPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	[CompilerGenerated]
	private Action? PFLPHAKBHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[CompilerGenerated]
	private Action<GDGHOPABCBJ<PJMKAHCGNJA>>? PJBLHDJIMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	[CompilerGenerated]
	private Action<GDGHOPABCBJ<PEIGABEPHFN>>? MKPGHELKCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	[CompilerGenerated]
	private ADCKDHCCEFE.JLGDLBFPOLA? PPDAHEKCFDD;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool KJCOOBBMCFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x1C43B40", Offset = "0x1C42940", VA = "0x181C43B40", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool KCCDBKIKGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x1C43F10", Offset = "0x1C42D10", VA = "0x181C43F10", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool LJJNCFICELG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E380", Offset = "0x1C3D180", VA = "0x181C3E380", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public CEEPFMHPMMJ<DEIDFGDEEMG> JBLGPPKAOEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x1C43C30", Offset = "0x1C42A30", VA = "0x181C43C30", Slot = "7")]
		get
		{
			return default(CEEPFMHPMMJ<DEIDFGDEEMG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool BDMLBDICHLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x1C408C0", Offset = "0x1C3F6C0", VA = "0x181C408C0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public GEPDKPKOLAO<PJMKAHCGNJA, EJFDBCHBLEF> POPNNEHKEAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870", Slot = "9")]
		get
		{
			return default(GEPDKPKOLAO<PJMKAHCGNJA, EJFDBCHBLEF>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public string FJPKIFMMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x1C43C00", Offset = "0x1C42A00", VA = "0x181C43C00", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public CEEPFMHPMMJ<CIENEMDJNND> NCIHHIJCGOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x1C41DC0", Offset = "0x1C40BC0", VA = "0x181C41DC0", Slot = "11")]
		get
		{
			return default(CEEPFMHPMMJ<CIENEMDJNND>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public GEPDKPKOLAO<PEIGABEPHFN, EFCINJCGCFO> ACCFDCPCOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7656B0", Offset = "0x7644B0", VA = "0x1807656B0", Slot = "12")]
		get
		{
			return default(GEPDKPKOLAO<PEIGABEPHFN, EFCINJCGCFO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public GDGHOPABCBJ<HBDEADMFFFA> OGKBIBADMBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8C3CE0", Offset = "0x8C2AE0", VA = "0x1808C3CE0", Slot = "13")]
		get
		{
			return default(GDGHOPABCBJ<HBDEADMFFFA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action? KGLJLAELGBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x1C40CE0", Offset = "0x1C3FAE0", VA = "0x181C40CE0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E6A0", Offset = "0x1C3D4A0", VA = "0x181C3E6A0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action? KGGHBBLMGDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E440", Offset = "0x1C3D240", VA = "0x181C3E440", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1C43300", Offset = "0x1C42100", VA = "0x181C43300", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action<GDGHOPABCBJ<PJMKAHCGNJA?>, GDGHOPABCBJ<PJMKAHCGNJA?>>? GLPOOGIKCDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1C435E0", Offset = "0x1C423E0", VA = "0x181C435E0", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x1C41250", Offset = "0x1C40050", VA = "0x181C41250", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<GDGHOPABCBJ<PEIGABEPHFN?>, GDGHOPABCBJ<PEIGABEPHFN?>>? PLNOBCNALNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x1C427E0", Offset = "0x1C415E0", VA = "0x181C427E0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x1C40800", Offset = "0x1C3F600", VA = "0x181C40800", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<GDGHOPABCBJ<PJMKAHCGNJA?>, EJFDBCHBLEF?>? EGMFIALEPKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x1C42960", Offset = "0x1C41760", VA = "0x181C42960", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1C42330", Offset = "0x1C41130", VA = "0x181C42330", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<GDGHOPABCBJ<PJMKAHCGNJA?>>? JNBHHJKAFJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E4F0", Offset = "0x1C3D2F0", VA = "0x181C3E4F0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1C40EB0", Offset = "0x1C3FCB0", VA = "0x181C40EB0", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<GDGHOPABCBJ<PJMKAHCGNJA?>, EJFDBCHBLEF?>? CEBAKPCJJIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x1C428A0", Offset = "0x1C416A0", VA = "0x181C428A0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1C40F70", Offset = "0x1C3FD70", VA = "0x181C40F70", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<GDGHOPABCBJ<PEIGABEPHFN?>, EFCINJCGCFO?>? BBDEGLCJHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1C3F350", Offset = "0x1C3E150", VA = "0x181C3F350", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x1C43C60", Offset = "0x1C42A60", VA = "0x181C43C60", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<GDGHOPABCBJ<PEIGABEPHFN?>>? JIDJPMKOCFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x1C43910", Offset = "0x1C42710", VA = "0x181C43910", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x1C43E50", Offset = "0x1C42C50", VA = "0x181C43E50", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<GDGHOPABCBJ<PEIGABEPHFN?>, EFCINJCGCFO?>? HADELPKPKFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x1C41310", Offset = "0x1C40110", VA = "0x181C41310", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x1C3F290", Offset = "0x1C3E090", VA = "0x181C3F290", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x1C43F50", Offset = "0x1C42D50", VA = "0x181C43F50")]
	private ALDGABCPPFL(bool APGKJAMGFKO, BEKPLBAAMIF NHBGKNCEKHK, bool KCPCDCFDIEO, GEPDKPKOLAO<PJMKAHCGNJA, JMCKKPEJFBA> CAHCABLECLP, GEPDKPKOLAO<PJMKAHCGNJA, EJFDBCHBLEF> CNFNBMHENDE, OHNNOPMBFDB AHGGOPDAOCA, GEPDKPKOLAO<PEIGABEPHFN, OBLNJKFANMM> CEOEANDCMGK, GEPDKPKOLAO<PEIGABEPHFN, EFCINJCGCFO> JJIKJKIMFJE, string? GOHDOBHIPFL, FLNICCHAMPN DMNPLPLLFFF, GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x1C41DE0", Offset = "0x1C40BE0", VA = "0x181C41DE0")]
	public static ALDGABCPPFL IGHHFGMBDIH(bool APGKJAMGFKO, BEKPLBAAMIF NHBGKNCEKHK, bool KCPCDCFDIEO, OHNNOPMBFDB AHGGOPDAOCA, FLNICCHAMPN DMNPLPLLFFF, GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1C413D0", Offset = "0x1C401D0", VA = "0x181C413D0")]
	private void HCKCHEHGBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x1C3F930", Offset = "0x1C3E730", VA = "0x181C3F930", Slot = "45")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x1C430F0", Offset = "0x1C41EF0", VA = "0x181C430F0", Slot = "34")]
	[AsyncStateMachine(typeof(CENABHDFHEI))]
	public Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ?>>? MHAPOCPPBLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1C433B0", Offset = "0x1C421B0", VA = "0x181C433B0")]
	private (AOHFCFOKDFG?, int)? MKJPKJDANDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x1C41160", Offset = "0x1C3FF60", VA = "0x181C41160")]
	private void GGHOAJEIIJE(int ENEGCMDCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x1C3E740", Offset = "0x1C3D540", VA = "0x181C3E740")]
	private void GGOICIPMLCJ(int ENEGCMDCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x1C40940", Offset = "0x1C3F740", VA = "0x181C40940")]
	private void EKHGHLFOEJA(int MCPLGDBNFDA, int AHOAEMBBDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x174B780", Offset = "0x174A580", VA = "0x18174B780")]
	private void BFHHFMFMGGN(int ENEGCMDCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x1C3ED60", Offset = "0x1C3DB60", VA = "0x181C3ED60")]
	private void DDJOJOJPOAF(int ENEGCMDCBBB, int DCJACHLJLNP, MAMGCGNFCBK ADKJANDCMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x1C43AF0", Offset = "0x1C428F0", VA = "0x181C43AF0")]
	private void NONAGDABCDL(int KNIBDNLMNEE, int DCJACHLJLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x1C42C20", Offset = "0x1C41A20", VA = "0x181C42C20")]
	private void LOKHMMDOKIG(int KNIBDNLMNEE, int DCJACHLJLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x1C3E760", Offset = "0x1C3D560", VA = "0x181C3E760")]
	private void BOCEDHECPED(int ENEGCMDCBBB, int DCJACHLJLNP, MAMGCGNFCBK ADKJANDCMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x1C436A0", Offset = "0x1C424A0", VA = "0x181C436A0")]
	private void MOEJGCFNOGC(int ENEGCMDCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x80B770", Offset = "0x80A570", VA = "0x18080B770")]
	private void NFBDGIPNPFE(int ENEGCMDCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x1C42A20", Offset = "0x1C41820", VA = "0x181C42A20")]
	private void LAINBAPMJIA(int ENEGCMDCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x1C3E740", Offset = "0x1C3D540", VA = "0x181C3E740")]
	private void BAHEMJIMEIA(int ENEGCMDCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x1C423F0", Offset = "0x1C411F0", VA = "0x181C423F0")]
	private void KBBMHCOBBPM(int MCPLGDBNFDA, int AHOAEMBBDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x174B780", Offset = "0x174A580", VA = "0x18174B780")]
	private void PBJLHJADKEO(int ENEGCMDCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1C3F410", Offset = "0x1C3E210", VA = "0x181C3F410")]
	private void DMKEECEPOPJ(int ENEGCMDCBBB, int DCJACHLJLNP, BMPKOBDDONF ADKJANDCMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x1C3ED10", Offset = "0x1C3DB10", VA = "0x181C3ED10")]
	private void CHBLOCDOJOK(int KNIBDNLMNEE, int DCJACHLJLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x1C42790", Offset = "0x1C41590", VA = "0x181C42790")]
	private void KDCBDFPBALI(int KNIBDNLMNEE, int DCJACHLJLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1C42C70", Offset = "0x1C41A70", VA = "0x181C42C70")]
	private void MBOHAIKLAKP(int ENEGCMDCBBB, int DCJACHLJLNP, BMPKOBDDONF ADKJANDCMME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x1C3EBC0", Offset = "0x1C3D9C0", VA = "0x181C3EBC0")]
	private void CGKONKPCEIG(int ENEGCMDCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x80B770", Offset = "0x80A570", VA = "0x18080B770")]
	private void EBMMMOHGLIM(int ENEGCMDCBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x1C42B10", Offset = "0x1C41910", VA = "0x181C42B10", Slot = "35")]
	[AsyncStateMachine(typeof(DNKOGLNMGAM))]
	public Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ?>>? LFCNBBFDONA(GDGHOPABCBJ<FGMAEDLBFGN> JPGOKKGFOMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x1C41CB0", Offset = "0x1C40AB0", VA = "0x181C41CB0", Slot = "36")]
	[AsyncStateMachine(typeof(OINOAPBOMKO))]
	public Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ?>>? HMEJEIOAKNO(GDGHOPABCBJ<PEMFHECBMBH> JBFMMBHBONH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x1C439D0", Offset = "0x1C427D0", VA = "0x181C439D0", Slot = "37")]
	[AsyncStateMachine(typeof(GCAABJMNDIA))]
	public Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ?>>? NMEMDLBCPOA(GDGHOPABCBJ<FGMAEDLBFGN> JPGOKKGFOMD, GDGHOPABCBJ<FGMAEDLBFGN> KGACLNPHPAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x1C431E0", Offset = "0x1C41FE0", VA = "0x181C431E0", Slot = "38")]
	[AsyncStateMachine(typeof(IKACNMHMNDO))]
	public Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ?>>? MHGEEAOIKNF(GDGHOPABCBJ<PEMFHECBMBH> JBFMMBHBONH, GDGHOPABCBJ<PEMFHECBMBH> KGACLNPHPAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x1C3E5B0", Offset = "0x1C3D3B0", VA = "0x181C3E5B0", Slot = "39")]
	[AsyncStateMachine(typeof(MCDCLOBEMMJ))]
	public Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ?>>? ANEOINCAMGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1C437F0", Offset = "0x1C425F0", VA = "0x181C437F0", Slot = "40")]
	[AsyncStateMachine(typeof(CPPFPJBCDLM))]
	public Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> MPKKEOOEEBD(string EHNEHNFFBDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x1C43D20", Offset = "0x1C42B20", VA = "0x181C43D20", Slot = "41")]
	[AsyncStateMachine(typeof(AMBMLBBFJMH))]
	public Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> PHKEIFODIDP(GDGHOPABCBJ<FGMAEDLBFGN> JPGOKKGFOMD, string MEBBBIMBIJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x1C41B80", Offset = "0x1C40980", VA = "0x181C41B80", Slot = "42")]
	[AsyncStateMachine(typeof(DEBCBECMODK))]
	public Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> HJDCLMDEBKJ(GDGHOPABCBJ<PEMFHECBMBH> JBFMMBHBONH, string MEBBBIMBIJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x1C40D80", Offset = "0x1C3FB80", VA = "0x181C40D80", Slot = "43")]
	[AsyncStateMachine(typeof(DCDJBLDECBC))]
	public Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> FFFDDHHEGEA(GDGHOPABCBJ<FGMAEDLBFGN> JPGOKKGFOMD, OPDOFKFGDCP FLHOFPAHPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x1C41030", Offset = "0x1C3FE30", VA = "0x181C41030", Slot = "44")]
	[AsyncStateMachine(typeof(CJBHMHIJPDH))]
	public Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> GFLNJENGLBJ(GDGHOPABCBJ<PEMFHECBMBH> JBFMMBHBONH, OPDOFKFGDCP FLHOFPAHPKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x1C40430", Offset = "0x1C3F230", VA = "0x181C40430")]
	internal void ECCIGJPPDIH(GDGHOPABCBJ<HBDEADMFFFA> POACLGOFKAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public sealed class DONEBFLFLKL : GDLNPPCABLH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public interface LLDIIJFLGBL
	{
		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		OPNEEPLBHNF MEDDGNJEFMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<OIDNONMAINB> HINMCJJCGKM(CancellationToken BCCDJHNACKO);

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<HIAIHBIEMAC> LPHMBPBAIPL(CancellationToken BCCDJHNACKO);

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<PHPDBENOAKI> DGGDFECHPLA(CancellationToken BCCDJHNACKO);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct OFNNNMJLPJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public AsyncTaskMethodBuilder<DONEBFLFLKL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public BEKPLBAAMIF circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public OIDNONMAINB roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public HIAIHBIEMAC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private LLDIIJFLGBL <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private HIAIHBIEMAC <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private TaskAwaiter<OIDNONMAINB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private TaskAwaiter<HIAIHBIEMAC> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private TaskAwaiter<PHPDBENOAKI> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x1C591F0", Offset = "0x1C57FF0", VA = "0x181C591F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x1C59A60", Offset = "0x1C58860", VA = "0x181C59A60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly LPGMDLNPHFE FPLNGNNLGEA;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public LPGMDLNPHFE GGAMDEEMJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	private DONEBFLFLKL(LPGMDLNPHFE HIJIOGOBCAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x1C4AE70", Offset = "0x1C49C70", VA = "0x181C4AE70")]
	[AsyncStateMachine(typeof(OFNNNMJLPJO))]
	public static Task<DONEBFLFLKL> PGCOIJKBKDO(BEKPLBAAMIF NHBGKNCEKHK, OIDNONMAINB? EDDLBMGEMFE, HIAIHBIEMAC? DBBBPLGPHMP, CancellationToken BCCDJHNACKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x1C4AE50", Offset = "0x1C49C50", VA = "0x181C4AE50", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public readonly struct HABFOJIEAJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private struct FFDAGJIOJEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public HABFOJIEAJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public IIHJOGGFNLJ action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private TaskAwaiter<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1C4BAD0", Offset = "0x1C4A8D0", VA = "0x181C4BAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1C4BD60", Offset = "0x1C4AB60", VA = "0x181C4BD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct HNAFKFCCFNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<bool, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public NDHDEECGNKK rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public OIDNONMAINB circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public HIAIHBIEMAC superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public HABFOJIEAJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private IIHJOGGFNLJ[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private TaskAwaiter<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1C4E560", Offset = "0x1C4D360", VA = "0x181C4E560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1C4E940", Offset = "0x1C4D740", VA = "0x181C4E940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct FNCDOKADCNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public HABFOJIEAJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private TaskAwaiter<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1C4BF20", Offset = "0x1C4AD20", VA = "0x181C4BF20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x1C4C200", Offset = "0x1C4B000", VA = "0x181C4C200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private readonly INHEHICFMNA MKINEGPLDIN;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7EB650", Offset = "0x7EA450", VA = "0x1807EB650")]
	public HABFOJIEAJH(INHEHICFMNA EBKGMNDAOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x1C4DB30", Offset = "0x1C4C930", VA = "0x181C4DB30")]
	[AsyncStateMachine(typeof(FFDAGJIOJEO))]
	private Task<FEBPNEDDNDE<object, KBBJHNEEOGJ>> CAHADJIDPLB(IIHJOGGFNLJ IPGJPNDBCJD, bool FJENGJGFNLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x1C4DC60", Offset = "0x1C4CA60", VA = "0x181C4DC60")]
	[AsyncStateMachine(typeof(HNAFKFCCFNB))]
	public Task<FEBPNEDDNDE<bool, KBBJHNEEOGJ?>>? CKBNONHDONG(int ONHBFKDBEKG, NDHDEECGNKK? LNKBALKOEEA, OIDNONMAINB? NDKLPFDNHOF, HIAIHBIEMAC? DBBBPLGPHMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x1C4DDC0", Offset = "0x1C4CBC0", VA = "0x181C4DDC0")]
	[AsyncStateMachine(typeof(FNCDOKADCNL))]
	public Task<FEBPNEDDNDE<NENNLMOAGAP, KBBJHNEEOGJ>> GJFIGHFIJPA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public sealed class AOKEOHLMCEA : DEOMJIDNGIL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private readonly HCNJILAFKNP FGBMGFEHLJF;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public HCNJILAFKNP MPFEEIBJNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	private AOKEOHLMCEA(HCNJILAFKNP KKDHKOEMDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x1C44480", Offset = "0x1C43280", VA = "0x181C44480")]
	public static AOKEOHLMCEA NLOFGFEMKNI(BEKPLBAAMIF NHBGKNCEKHK, NDHDEECGNKK CABHNFJIOGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x1C44460", Offset = "0x1C43260", VA = "0x181C44460", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public interface MCNJIALKEOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	KMJOFBBLDDM ENNIHFADDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	JAAKEDJHDMJ LNPLECEDLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	JGEGGLMADOD MPJNFMALDHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	AKOGAGIDCME LEJALGOAKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	BDBELACLBMC JKOAPPMOPKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface HPBOOPFHOFI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000082")]
	MCNJIALKEOH? EFDFOAECDND
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	bool NCHMLMBHEAA
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	bool ICGPGJAHLDH
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<MCNJIALKEOH?>? NJKHNNHIOII();

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task AHAFNIAAENF(BEKPLBAAMIF NHBGKNCEKHK, NDHDEECGNKK CABHNFJIOGA, OIDNONMAINB? ALKMPIFMDLA, HIAIHBIEMAC? LGDCGDEAKLG);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[IFHOCEFKBAP("IStaticCV2Instance")]
public interface GDLNPPCABLH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	LPGMDLNPHFE GGAMDEEMJEN
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[IFHOCEFKBAP("IStaticEVInstance")]
public interface DEOMJIDNGIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000086")]
	HCNJILAFKNP MPFEEIBJNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public sealed class CIDGLKHJCFK : HMEJNOEADEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly BEKPLBAAMIF PKBEEFOHNFN;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public KMMKOCFEIHH? IFFGEIGBEEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x1C48520", Offset = "0x1C47320", VA = "0x181C48520", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	internal CIDGLKHJCFK(BEKPLBAAMIF NHBGKNCEKHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public sealed class AKOGAGIDCME : KMMKOCFEIHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private readonly GDLNPPCABLH NGNCHJAJDBG;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public FLHKDCMOKDM CAHADJIDPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E1A0", Offset = "0x1C3CFA0", VA = "0x181C3E1A0", Slot = "4")]
		get
		{
			return default(FLHKDCMOKDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public LNAJMLLOCIH FMCHHHNKBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E2D0", Offset = "0x1C3D0D0", VA = "0x181C3E2D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public CEEPFMHPMMJ<DEIDFGDEEMG> MBKAEJKPLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E200", Offset = "0x1C3D000", VA = "0x181C3E200", Slot = "6")]
		get
		{
			return default(CEEPFMHPMMJ<DEIDFGDEEMG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public LPGMDLNPHFE JIODAKODOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x1C3E330", Offset = "0x1C3D130", VA = "0x181C3E330", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	public AKOGAGIDCME(GDLNPPCABLH DHNAONHHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x1C3E260", Offset = "0x1C3D060", VA = "0x181C3E260")]
	public bool LBHOJONKIED([In] CEEPFMHPMMJ<DEIDFGDEEMG> BELINILLNPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x1C3E260", Offset = "0x1C3D060", VA = "0x181C3E260", Slot = "8")]
	private bool DHPFPNIJFEJ([In] CEEPFMHPMMJ<DEIDFGDEEMG> BELINILLNPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public static class FOAHOLEJLCA
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x1C4C270", Offset = "0x1C4B070", VA = "0x181C4C270")]
	public static GFGKKIBGJKJ<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF, MECJKIKFFAN.GOPDODKANIL<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF>> EDANECKEDCO([In] this GFGKKIBGJKJ<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF, MECJKIKFFAN.GOPDODKANIL<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF>> CDEDIFOLOAJ)
	{
		return default(GFGKKIBGJKJ<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF, MECJKIKFFAN.GOPDODKANIL<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public sealed class HHFMCPOFJAM : DFPBHJOOMDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private readonly BEKPLBAAMIF PKBEEFOHNFN;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool ICGPGJAHLDH
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x1C4DEB0", Offset = "0x1C4CCB0", VA = "0x181C4DEB0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	internal HHFMCPOFJAM(BEKPLBAAMIF NHBGKNCEKHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public sealed class KBFKDLAAFEH : CDALLICPBFB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct HOJDLAJLBCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public AsyncTaskMethodBuilder<NIAAFIGKDBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public KBFKDLAAFEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private TaskAwaiter<MCNJIALKEOH?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1C4E9B0", Offset = "0x1C4D7B0", VA = "0x181C4E9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1C4EC60", Offset = "0x1C4DA60", VA = "0x181C4EC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly BEKPLBAAMIF PKBEEFOHNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private IReadOnlyList<CEEPFMHPMMJ<FBKECGKLFLN>>? KKADKEIDOOF;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public NIAAFIGKDBC? IFFGEIGBEEG
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x1C54770", Offset = "0x1C53570", VA = "0x181C54770", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool IFCKJFHKJIO
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x1C54B30", Offset = "0x1C53930", VA = "0x181C54B30", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool MDFPODEIBGI
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x1C548E0", Offset = "0x1C536E0", VA = "0x181C548E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	internal KBFKDLAAFEH(BEKPLBAAMIF NHBGKNCEKHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x1C547F0", Offset = "0x1C535F0", VA = "0x181C547F0", Slot = "7")]
	[AsyncStateMachine(typeof(HOJDLAJLBCM))]
	public Task<NIAAFIGKDBC> FOFKOIKBMJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x1C54B90", Offset = "0x1C53990", VA = "0x181C54B90")]
	internal Dictionary<CEEPFMHPMMJ<DEIDFGDEEMG>, Guid> KEIMJAPJKPA(IEnumerable<JBHCDHCPMCM> GEDPAILHBIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x1C54940", Offset = "0x1C53740", VA = "0x181C54940")]
	public FEBPNEDDNDE<HGAGJEPFDAM, NEBNMHPBDBO> HOODJBACBPC([In] HGAGJEPFDAM KPBBDJFBACJ, IEnumerable<JBHCDHCPMCM> DLDLENALPEH, int OEJDJMNJFAC)
	{
		return default(FEBPNEDDNDE<HGAGJEPFDAM, NEBNMHPBDBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x1C55100", Offset = "0x1C53F00", VA = "0x181C55100")]
	internal static OMELFBJJJNK NIEPOJCICBN(JNFCKCIIBFG KBMJKGFEKNF, OHNNOPMBFDB AHGGOPDAOCA)
	{
		return default(OMELFBJJJNK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x1C54F00", Offset = "0x1C53D00", VA = "0x181C54F00", Slot = "8")]
	private FEBPNEDDNDE<HGAGJEPFDAM, NEBNMHPBDBO> LBOGHDAJAEA([In] HGAGJEPFDAM KPBBDJFBACJ, IEnumerable<JBHCDHCPMCM> DLDLENALPEH, int OEJDJMNJFAC)
	{
		return default(FEBPNEDDNDE<HGAGJEPFDAM, NEBNMHPBDBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x1C55140", Offset = "0x1C53F40", VA = "0x181C55140")]
	[CompilerGenerated]
	internal static OMELFBJJJNK PMENCAIAOJL(JNFCKCIIBFG NABMHAGJNKM, OHNNOPMBFDB EJGLNGGPLPJ)
	{
		return default(OMELFBJJJNK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public sealed class BDBELACLBMC : NIAAFIGKDBC
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	internal static class LMINDGKCGAK
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class DJKBPPICFGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public BDJEMKJIEBD spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public DJKBPPICFGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x1C5C530", Offset = "0x1C5B330", VA = "0x181C5C530")]
			internal bool DKMALJJNHHC(COMJBPFPLEL n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class MBHNMJMBNKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
			public MBHNMJMBNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x1C5F270", Offset = "0x1C5E070", VA = "0x181C5F270")]
			internal void ILONIPBDPIF(COMJBPFPLEL n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1C55EF0", Offset = "0x1C54CF0", VA = "0x181C55EF0")]
		public static FEBPNEDDNDE<NIAAFIGKDBC.GNDAKJHPPMN, NEBNMHPBDBO> INEHGKEHGLC(BDBELACLBMC PECKHAMCEFO, [In] NIAAFIGKDBC.BALKDEIPBDH MEALCFKPKME)
		{
			return default(FEBPNEDDNDE<NIAAFIGKDBC.GNDAKJHPPMN, NEBNMHPBDBO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x1C56420", Offset = "0x1C55220", VA = "0x181C56420")]
		internal static FEBPNEDDNDE<(NFCKKKCBCBD, NMEKIKGCCEB), KBBJHNEEOGJ> LOPCMHNNANH(BDBELACLBMC PECKHAMCEFO, NMEKIKGCCEB AEDLBLEKMCA, bool PIDGNEFGGFJ, [In] CEEPFMHPMMJ<DEIDFGDEEMG> FBKPFJHJELB, [In] int? MFGOIAKDMBJ, [In] OMELFBJJJNK? EJECNPLDHFF, [In] OMELFBJJJNK? DPNHNIPPHOE)
		{
			return default(FEBPNEDDNDE<(NFCKKKCBCBD, NMEKIKGCCEB), KBBJHNEEOGJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1C55A60", Offset = "0x1C54860", VA = "0x181C55A60")]
		private static void DFLHNGAGPOO(bool PIDGNEFGGFJ, JBHCDHCPMCM AGJJPHKFJFF, NFCKKKCBCBD IPCGPGDGDFG, [In] CEEPFMHPMMJ<DEIDFGDEEMG> FBKPFJHJELB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x1C55650", Offset = "0x1C54450", VA = "0x181C55650")]
		public static void DBGPDJOFGGD(NIMEIIJJHHK HACKCLBNJJM, [In] NIAAFIGKDBC.CGMHDBFNMCF IDCCLELCOHG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly BEKPLBAAMIF PKBEEFOHNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly GDLNPPCABLH NGNCHJAJDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly DEOMJIDNGIL JLICEEKJLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly OFOIGDJMHPA FLGCBNNCJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private readonly KBFKDLAAFEH BIOMGEFHACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private Dictionary<CEEPFMHPMMJ<CIENEMDJNND>, LJOAMDGCCKK> OIFOOIOOHHF;

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x1C45FB0", Offset = "0x1C44DB0", VA = "0x181C45FB0")]
	public BDBELACLBMC(BEKPLBAAMIF NHBGKNCEKHK, GDLNPPCABLH DHNAONHHBJC, DEOMJIDNGIL IKGEDGPPAAF, KBFKDLAAFEH PNDFGHPHMMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x1C44880", Offset = "0x1C43680", VA = "0x181C44880")]
	public LJOAMDGCCKK? BKFLNHCABAE([In] CEEPFMHPMMJ<CIENEMDJNND> CIANJEHDGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x1C44C80", Offset = "0x1C43A80", VA = "0x181C44C80")]
	private void FDNIMKMCBBL(CEEPFMHPMMJ<CIENEMDJNND> CIANJEHDGID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x1C44BD0", Offset = "0x1C439D0", VA = "0x181C44BD0")]
	private LJOAMDGCCKK? EFDLEPLLFPB([In] CEEPFMHPMMJ<CIENEMDJNND> CIANJEHDGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x1C44DD0", Offset = "0x1C43BD0", VA = "0x181C44DD0")]
	public OHNNOPMBFDB? GJCCPCFFIEN([In] CEEPFMHPMMJ<CIENEMDJNND> CIANJEHDGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1C44580", Offset = "0x1C43380", VA = "0x181C44580")]
	public CLNNMEPDLCP? BANIMLLLEOD([In] CEEPFMHPMMJ<DEIDFGDEEMG> BELINILLNPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x1C45EA0", Offset = "0x1C44CA0", VA = "0x181C45EA0")]
	private BDJEMKJIEBD? NKKAHFFPLHC([In] CEEPFMHPMMJ<DEIDFGDEEMG> BELINILLNPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x1C45910", Offset = "0x1C44710", VA = "0x181C45910")]
	private CLNNMEPDLCP? MLOMPOLCFGD([In] CEEPFMHPMMJ<DEIDFGDEEMG> BELINILLNPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x1C44CE0", Offset = "0x1C43AE0", VA = "0x181C44CE0", Slot = "6")]
	public IEnumerable<OPDOFKFGDCP> FJFEMNHIHFL(bool BJOLHMKMEKF, bool DKEFHKLAGEJ, bool BKEBLHHJCAN, bool HALEADDKBGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x1C44730", Offset = "0x1C43530", VA = "0x181C44730")]
	public FEBPNEDDNDE<NIAAFIGKDBC.GNDAKJHPPMN, NEBNMHPBDBO> CGLKAEHKAIL([In] NIAAFIGKDBC.BALKDEIPBDH MEALCFKPKME)
	{
		return default(FEBPNEDDNDE<NIAAFIGKDBC.GNDAKJHPPMN, NEBNMHPBDBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x1C449E0", Offset = "0x1C437E0", VA = "0x181C449E0", Slot = "8")]
	public JMKEAENMGNA CJFHEDDNENH(IEnumerable<JBHCDHCPMCM> DLDLENALPEH)
	{
		return default(JMKEAENMGNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x1C44760", Offset = "0x1C43560", VA = "0x181C44760", Slot = "9")]
	public JMKEAENMGNA BJBEGFIMDNI()
	{
		return default(JMKEAENMGNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x1C452C0", Offset = "0x1C440C0", VA = "0x181C452C0")]
	private IEILMEHPBDI JGGODHFBLMJ(IHKHICLICLB JBJPFHJAFGK, IEnumerable<CEEPFMHPMMJ<DEIDFGDEEMG>> BAMEKPCGMPN, IEnumerable<CEEPFMHPMMJ<CIENEMDJNND>> PAPDNIFMGMG)
	{
		return default(IEILMEHPBDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x1C44FA0", Offset = "0x1C43DA0", VA = "0x181C44FA0", Slot = "10")]
	public IEILMEHPBDI JGGODHFBLMJ(IHKHICLICLB JBJPFHJAFGK, IEnumerable<CEEPFMHPMMJ<CIENEMDJNND>> PAPDNIFMGMG, IEnumerable<JBHCDHCPMCM> DLDLENALPEH)
	{
		return default(IEILMEHPBDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x1C45B20", Offset = "0x1C44920", VA = "0x181C45B20")]
	private static IEnumerable<CEEPFMHPMMJ<DEIDFGDEEMG>> NFLGJCBADPD(IEnumerable<JBHCDHCPMCM> DLDLENALPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x1C45470", Offset = "0x1C44270", VA = "0x181C45470")]
	private IEnumerable<CEEPFMHPMMJ<CIENEMDJNND>> MLIINGDGNJC(IEnumerable<JBHCDHCPMCM> DLDLENALPEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x1C45460", Offset = "0x1C44260", VA = "0x181C45460", Slot = "4")]
	private CLNNMEPDLCP LGGEBGHEDGG([In] CEEPFMHPMMJ<DEIDFGDEEMG> BELINILLNPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x1C44E50", Offset = "0x1C43C50", VA = "0x181C44E50", Slot = "5")]
	private LJOAMDGCCKK IFCDFHBMHMC([In] CEEPFMHPMMJ<CIENEMDJNND> CIANJEHDGID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x1C44730", Offset = "0x1C43530", VA = "0x181C44730", Slot = "7")]
	private FEBPNEDDNDE<NIAAFIGKDBC.GNDAKJHPPMN, NEBNMHPBDBO> BGLHBEDCMDN([In] NIAAFIGKDBC.BALKDEIPBDH MEALCFKPKME)
	{
		return default(FEBPNEDDNDE<NIAAFIGKDBC.GNDAKJHPPMN, NEBNMHPBDBO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x1C45F30", Offset = "0x1C44D30", VA = "0x181C45F30")]
	[CompilerGenerated]
	private NCJCDOFHNIB OOHBDPPPNIA(CAGLBKEPFAA NAKKFLBPDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x1C45AB0", Offset = "0x1C448B0", VA = "0x181C45AB0")]
	[CompilerGenerated]
	private OHNNOPMBFDB MMFGHOKHBBM(CEEPFMHPMMJ<CIENEMDJNND> NAKKFLBPDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x1C44510", Offset = "0x1C43310", VA = "0x181C44510")]
	[CompilerGenerated]
	private BDJEMKJIEBD ALMFEDCOJPF(CEEPFMHPMMJ<DEIDFGDEEMG> NAKKFLBPDCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public sealed class NCJCDOFHNIB : OPDOFKFGDCP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct PAPHHJKGOPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<GDGHOPABCBJ<FGMAEDLBFGN>, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public NCJCDOFHNIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public CEEPFMHPMMJ<DEIDFGDEEMG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public CEEPFMHPMMJ<CIENEMDJNND> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public GDGHOPABCBJ<HBDEADMFFFA> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter<FEBPNEDDNDE<GDGHOPABCBJ<FGMAEDLBFGN>, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x1C5F950", Offset = "0x1C5E750", VA = "0x181C5F950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x1C5FBD0", Offset = "0x1C5E9D0", VA = "0x181C5FBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct DAMDHGGDEME : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<GDGHOPABCBJ<PEMFHECBMBH>, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public NCJCDOFHNIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public CEEPFMHPMMJ<DEIDFGDEEMG> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public CEEPFMHPMMJ<CIENEMDJNND> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public GDGHOPABCBJ<HBDEADMFFFA> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private TaskAwaiter<FEBPNEDDNDE<GDGHOPABCBJ<PEMFHECBMBH>, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x1C5C240", Offset = "0x1C5B040", VA = "0x181C5C240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x1C5C4C0", Offset = "0x1C5B2C0", VA = "0x181C5C4C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly CAGLBKEPFAA CDIAMKFDIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly GDLNPPCABLH NGNCHJAJDBG;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public TypeKey KAONFAHGDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x806B40", Offset = "0x805940", VA = "0x180806B40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public string PEIDDFNMJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x1C5C9D0", Offset = "0x1C5B7D0", VA = "0x181C5C9D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public CAGLBKEPFAA JFBCDMNKBPL
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7619B0", Offset = "0x7607B0", VA = "0x1807619B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F570", Offset = "0x1C5E370", VA = "0x181C5F570")]
	public NCJCDOFHNIB(CAGLBKEPFAA ABLGHJMDBPG, GDLNPPCABLH DHNAONHHBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F290", Offset = "0x1C5E090", VA = "0x181C5F290", Slot = "6")]
	[AsyncStateMachine(typeof(PAPHHJKGOPL))]
	public Task<FEBPNEDDNDE<GDGHOPABCBJ<FGMAEDLBFGN>, KBBJHNEEOGJ>> GPMHPPLKPBI(CEEPFMHPMMJ<DEIDFGDEEMG> BELINILLNPN, CEEPFMHPMMJ<CIENEMDJNND> CIANJEHDGID, GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN, string MEBBBIMBIJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F400", Offset = "0x1C5E200", VA = "0x181C5F400", Slot = "7")]
	[AsyncStateMachine(typeof(DAMDHGGDEME))]
	public Task<FEBPNEDDNDE<GDGHOPABCBJ<PEMFHECBMBH>, KBBJHNEEOGJ>> NFHLHJOOOML(CEEPFMHPMMJ<DEIDFGDEEMG> BELINILLNPN, CEEPFMHPMMJ<CIENEMDJNND> CIANJEHDGID, GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN, string MEBBBIMBIJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public sealed class DPFLFDCKAEK : DHCEGNNAANE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly CAGLBKEPFAA MAOOJAIJJDE;

	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private static readonly HashSet<CAGLBKEPFAA> JILONEOOONL;

	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private static readonly HashSet<CAGLBKEPFAA> NGCBNEFIMLN;

	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private static readonly HashSet<CAGLBKEPFAA> DHAKLOBOOOH;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public TypeKey OBPJFFDCAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x1C5DAA0", Offset = "0x1C5C8A0", VA = "0x181C5DAA0", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool DPIJNDBBOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x1C5DA90", Offset = "0x1C5C890", VA = "0x181C5DA90", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool AABEFKABOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x1C5DAF0", Offset = "0x1C5C8F0", VA = "0x181C5DAF0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool HLMKIDJFFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x1C5DA10", Offset = "0x1C5C810", VA = "0x181C5DA10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C760", Offset = "0x1C5B560", VA = "0x181C5C760")]
	public bool HEFPJJEMHGN(string POACLGOFKAJ, [Out] PPHEPPOMPDP LEIBIGNPNHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	public DPFLFDCKAEK(CAGLBKEPFAA IIJDENGNPJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C5D0", Offset = "0x1C5B3D0", VA = "0x181C5C5D0")]
	internal static TypeKey ACOLIOIGPPL(CAGLBKEPFAA FLHOFPAHPKL)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C9D0", Offset = "0x1C5B7D0", VA = "0x181C5C9D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200007E")]
public readonly struct OINLDACEOPA : HMGKHEHIGFD.PHKBAOLPJNP<IIHJOGGFNLJ, NENNLMOAGAP>
{
	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F850", Offset = "0x1C5E650", VA = "0x181C5F850", Slot = "4")]
	public int HBLGMPAIBLF(NENNLMOAGAP KNIBDNLMNEE, IIHJOGGFNLJ IPGJPNDBCJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F8A0", Offset = "0x1C5E6A0", VA = "0x181C5F8A0", Slot = "5")]
	public IIHJOGGFNLJ MCKCMOGGBAM(NENNLMOAGAP KNIBDNLMNEE, IIHJOGGFNLJ IPGJPNDBCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F870", Offset = "0x1C5E670", VA = "0x181C5F870", Slot = "6")]
	public IIHJOGGFNLJ HNDCCDOICNC(NENNLMOAGAP KNIBDNLMNEE, IIHJOGGFNLJ IPGJPNDBCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F930", Offset = "0x1C5E730", VA = "0x181C5F930", Slot = "7")]
	public IReadOnlyList<IIHJOGGFNLJ> PPMKNGJPNNH(NENNLMOAGAP KNIBDNLMNEE, IIHJOGGFNLJ IPGJPNDBCJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F840", Offset = "0x1C5E640", VA = "0x181C5F840", Slot = "8")]
	public IIHJOGGFNLJ[] FKNKGMNPEJH(NENNLMOAGAP KNIBDNLMNEE, IIHJOGGFNLJ IPGJPNDBCJD, int FBDOBGDGKFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F8F0", Offset = "0x1C5E6F0", VA = "0x181C5F8F0", Slot = "9")]
	public bool PHOGBPHMCPH(NENNLMOAGAP KNIBDNLMNEE, IIHJOGGFNLJ IPGJPNDBCJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F8B0", Offset = "0x1C5E6B0", VA = "0x181C5F8B0", Slot = "10")]
	public bool OJHCLJFBOKL(NENNLMOAGAP KNIBDNLMNEE, IIHJOGGFNLJ IPGJPNDBCJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F800", Offset = "0x1C5E600", VA = "0x181C5F800", Slot = "11")]
	public bool AGCJDMFFHIF(NENNLMOAGAP KNIBDNLMNEE, IIHJOGGFNLJ IPGJPNDBCJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F910", Offset = "0x1C5E710", VA = "0x181C5F910", Slot = "12")]
	public bool PLKJEIKICLF(NENNLMOAGAP KNIBDNLMNEE, IIHJOGGFNLJ IPGJPNDBCJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F820", Offset = "0x1C5E620", VA = "0x181C5F820", Slot = "13")]
	public bool FALFFMMHGDH(NENNLMOAGAP BAJKCAFEDPA, IIHJOGGFNLJ IPGJPNDBCJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F8D0", Offset = "0x1C5E6D0", VA = "0x181C5F8D0", Slot = "14")]
	public bool PBCGNGHJMJJ(NENNLMOAGAP KNIBDNLMNEE, IIHJOGGFNLJ IPGJPNDBCJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public abstract class GCMFMEIALDE : AILLCOEEANE
{
	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public JDODLCFGFCL.CIOFKMBGNHJ DDKKJFOJFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1C5E050", Offset = "0x1C5CE50", VA = "0x181C5E050", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public abstract OEKEKDONHKE.FMBENLFBOGE BINAMLGJMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public abstract BEKPLBAAMIF.HMKCCNECEKB JEKHJAKCHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public abstract DONEBFLFLKL.LLDIIJFLGBL HLFFLGLCPHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public MECJKIKFFAN.GOPDODKANIL<MEMMHFPOBMJ, IIHJOGGFNLJ, BEKPLBAAMIF> AGFLDFKMGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1C5E000", Offset = "0x1C5CE00", VA = "0x181C5E000", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public abstract AKNKONAODAN NEFAAGENNGF
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public abstract PDIGLJJPCCK JNFFHBPGEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public abstract MGNJNDFILAF NKCHDIDLOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public abstract DIMGJEAHNBO OMNBGEGFIKA
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public abstract OBBBHJLFCAF CEIOKAAIMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	protected GCMFMEIALDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public sealed class GJBMCOKAIBF : LNAJMLLOCIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct HPGEPGKFLBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public GJBMCOKAIBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public IIHJOGGFNLJ action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private TaskAwaiter<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x1C5E300", Offset = "0x1C5D100", VA = "0x181C5E300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x1C5E5A0", Offset = "0x1C5D3A0", VA = "0x181C5E5A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct FJFLPGPGADG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public AsyncTaskMethodBuilder<FEBPNEDDNDE<FEAGKJMBIAE, KBBJHNEEOGJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public GJBMCOKAIBF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public IReadOnlyList<IIHJOGGFNLJ> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private TaskAwaiter<FEBPNEDDNDE<object, KBBJHNEEOGJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1C5DC10", Offset = "0x1C5CA10", VA = "0x181C5DC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1C5DF90", Offset = "0x1C5CD90", VA = "0x181C5DF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private readonly INHEHICFMNA MKINEGPLDIN;

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x761AA0", Offset = "0x7608A0", VA = "0x180761AA0")]
	public GJBMCOKAIBF(INHEHICFMNA EBKGMNDAOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x1C5E0A0", Offset = "0x1C5CEA0", VA = "0x181C5E0A0")]
	[AsyncStateMachine(typeof(HPGEPGKFLBC))]
	private Task<FEBPNEDDNDE<object, KBBJHNEEOGJ>> CAHADJIDPLB(IIHJOGGFNLJ IPGJPNDBCJD, bool FJENGJGFNLL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x1C5E1D0", Offset = "0x1C5CFD0", VA = "0x181C5E1D0", Slot = "4")]
	[AsyncStateMachine(typeof(FJFLPGPGADG))]
	public Task<FEBPNEDDNDE<FEAGKJMBIAE, KBBJHNEEOGJ>> LIGBJIDIAOH(IReadOnlyList<IIHJOGGFNLJ> JHODOBKGEMP, bool FJENGJGFNLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public struct JALBACJKKOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	internal DDLAMCIHJCE<PBBAJGAMFFK, IIHJOGGFNLJ, NEGEOHGFLJB> MAOOJAIJJDE;

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x1C3E190", Offset = "0x1C3CF90", VA = "0x181C3E190")]
	private JALBACJKKOK([In] DDLAMCIHJCE<PBBAJGAMFFK, IIHJOGGFNLJ, NEGEOHGFLJB> EKIOKNPFOME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x1C5E720", Offset = "0x1C5D520", VA = "0x181C5E720")]
	public static JALBACJKKOK IGHHFGMBDIH()
	{
		return default(JALBACJKKOK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public static class CLCEHECNHCH
{
	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0")]
	public static DDLAMCIHJCE<PBBAJGAMFFK, IIHJOGGFNLJ, NEGEOHGFLJB> LGGEKEKDNJO(this JALBACJKKOK PECKHAMCEFO)
	{
		return default(DDLAMCIHJCE<PBBAJGAMFFK, IIHJOGGFNLJ, NEGEOHGFLJB>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000085")]
public struct NEGEOHGFLJB : OADKENHJMLB.FFEGHELEAAA<PBBAJGAMFFK, IIHJOGGFNLJ>
{
	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F610", Offset = "0x1C5E410", VA = "0x181C5F610", Slot = "5")]
	public IIHJOGGFNLJ AEHACJHLLHL(PBBAJGAMFFK[] DIDGBLGHBKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x1220F20", Offset = "0x121FD20", VA = "0x181220F20")]
	public int JGDNPMOJPCD([In] PBBAJGAMFFK DGANMHKCJDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x1220F20", Offset = "0x121FD20", VA = "0x181220F20", Slot = "4")]
	private int JMLMGNCFBKE([In] PBBAJGAMFFK LNFGBLILICO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public struct AIMIDANIFCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	internal JDNLCFDCDAO<ICDDEFONLAH, IIHJOGGFNLJ, KPMMCBOMJLE> MAOOJAIJJDE;

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x1C3E190", Offset = "0x1C3CF90", VA = "0x181C3E190")]
	private AIMIDANIFCF([In] JDNLCFDCDAO<ICDDEFONLAH, IIHJOGGFNLJ, KPMMCBOMJLE> AGNDJHCHPPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x1C5C1E0", Offset = "0x1C5AFE0", VA = "0x181C5C1E0")]
	public static AIMIDANIFCF IGHHFGMBDIH()
	{
		return default(AIMIDANIFCF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class DIAGKIFJKMK
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0xA2B7C0", Offset = "0xA2A5C0", VA = "0x180A2B7C0")]
	public static JDNLCFDCDAO<ICDDEFONLAH, IIHJOGGFNLJ, KPMMCBOMJLE> LGGEKEKDNJO(this AIMIDANIFCF PECKHAMCEFO)
	{
		return default(JDNLCFDCDAO<ICDDEFONLAH, IIHJOGGFNLJ, KPMMCBOMJLE>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct KPMMCBOMJLE : CDMNJBBHEAO.CFEDBJHDNCN<ICDDEFONLAH, IIHJOGGFNLJ>
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x1220F20", Offset = "0x121FD20", VA = "0x181220F20")]
	public int KNNGIGDIMPF([In] ICDDEFONLAH DGANMHKCJDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x1C5E780", Offset = "0x1C5D580", VA = "0x181C5E780", Slot = "5")]
	public IIHJOGGFNLJ HFOKPDFLFJO(ICDDEFONLAH[] INPENLJHBIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x1220F20", Offset = "0x121FD20", VA = "0x181220F20", Slot = "4")]
	private int LJFCGICHHFC([In] ICDDEFONLAH DGANMHKCJDP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface AKNKONAODAN
{
	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IPLMKLNMFCK([In] FEBPNEDDNDE<NENNLMOAGAP, NEBNMHPBDBO> CGIMAKAECOA);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class GFJOMIAGDIP
{
	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x239ABD0", Offset = "0x23999D0", VA = "0x18239ABD0")]
	public static bool IPLMKLNMFCK<TOk, TErr>(this AKNKONAODAN PECKHAMCEFO, [In] FEBPNEDDNDE<TOk, TErr> CGIMAKAECOA) where TOk : notnull where TErr : notnull, NEBNMHPBDBO
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public interface PDIGLJJPCCK
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	LEKPBONDIHN LELHOMNCLKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface MGNJNDFILAF
{
	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ADJIGLMOICK OANEIJCNNJN(int MABPPJCMDHJ);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface IBOBEJNNMOM
{
	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	string FJPKIFMMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public interface JKLDEGDGIND
{
	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OCOBDFFOABP? LABIMNHCEDJ(GDGHOPABCBJ<HBDEADMFFFA> NMFIPICOBJN);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public interface HLLNPOFBMFJ
{
	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	string FJPKIFMMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public interface OCOBDFFOABP
{
	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	string FJPKIFMMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HLLNPOFBMFJ? OABKJCDDPGJ(GDGHOPABCBJ<FGMAEDLBFGN> JPGOKKGFOMD);

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IBOBEJNNMOM? PKGIKBJFGLF(GDGHOPABCBJ<PEMFHECBMBH> JBFMMBHBONH);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public interface DIMGJEAHNBO
{
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> NPNEKCHBLMM(string POACLGOFKAJ, string DDMHMHFODEB);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public interface OBBBHJLFCAF
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JKLDEGDGIND? BHMDIGLDMLG([In] CEEPFMHPMMJ<FBKECGKLFLN> ELNAJADMKOI);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public sealed class LMOBEPMHIJO
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	private struct IEFMEFONAOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public int FCFMLMDMJIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public OIDNONMAINB? MJMHOALGPAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public OIDNONMAINB? DGCPOIDLIBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public readonly List<IIHJOGGFNLJ> LHEIEHJGKMF;

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x1C5E6D0", Offset = "0x1C5D4D0", VA = "0x181C5E6D0")]
		private IEFMEFONAOF(int OCMJNDDMDAL, OIDNONMAINB? DIPGLOPMDKN, OIDNONMAINB? HIBDJLHPMPI, List<IIHJOGGFNLJ> JHODOBKGEMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x1C5E610", Offset = "0x1C5D410", VA = "0x181C5E610")]
		public static IEFMEFONAOF IGHHFGMBDIH()
		{
			return default(IEFMEFONAOF);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly LPNFINBBFNM<IEFMEFONAOF> EOCHJNFAMJI;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public static LMOBEPMHIJO IFFGEIGBEEG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1C5E970", Offset = "0x1C5D770", VA = "0x181C5E970")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool FNOBDLDHOIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B03C0", Offset = "0x7AF1C0", VA = "0x1807B03C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x8A83F0", Offset = "0x8A71F0", VA = "0x1808A83F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x1C5ED00", Offset = "0x1C5DB00", VA = "0x181C5ED00")]
	public void PDHAHCCCHLB(LPGMDLNPHFE HIBDJLHPMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x1C5EDC0", Offset = "0x1C5DBC0", VA = "0x181C5EDC0")]
	public void PIDPJCFBDBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x1C5E9C0", Offset = "0x1C5D7C0", VA = "0x181C5E9C0")]
	private static string? NABLJPCDNHC([In] IEFMEFONAOF BEGKIOENBID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x1C5F1C0", Offset = "0x1C5DFC0", VA = "0x181C5F1C0")]
	public LMOBEPMHIJO()
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
