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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27E03E0", Offset = "0x27DF1E0", VA = "0x1827E03E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class HBDCLDOGDAK : IDisposable, GIPDEJFOLIM, PCHLKNCDDAL, GELACPOPCPN, PJPGKOCEPOA
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class AHFKAGMJKBI : PBNOGBMLKJF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract int KDGFICIOAPA
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x27C5F90", Offset = "0x27C4D90", VA = "0x1827C5F90", Slot = "5")]
		public HLIFGONAOOA BEEBNIKJJBG(DIFGANNFPID.OEKIHGBCEEC JCFBNAHPHAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void HHLBIDHHEHB();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void LEMPAEGCONJ();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x27BBDE0", Offset = "0x27BABE0", VA = "0x1827BBDE0", Slot = "13")]
		public virtual void AFCGINBNKJC(HBDCLDOGDAK PINKMLPHMFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x27C5F10", Offset = "0x27C4D10", VA = "0x1827C5F10", Slot = "14")]
		public virtual void BBNJCFLNKHE(HBDCLDOGDAK PINKMLPHMFP, CMGFJHDBEGO CFDGGKIIHOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		protected AHFKAGMJKBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface PBNOGBMLKJF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		int KDGFICIOAPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		HLIFGONAOOA BEEBNIKJJBG(DIFGANNFPID.OEKIHGBCEEC JCFBNAHPHAO);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void HHLBIDHHEHB();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LEMPAEGCONJ();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void AFCGINBNKJC(HBDCLDOGDAK PINKMLPHMFP);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void BBNJCFLNKHE(HBDCLDOGDAK PINKMLPHMFP, CMGFJHDBEGO CFDGGKIIHOI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct MAOMEDCCGGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly LIFNMMADNGB<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK, GGBCFBLMLAI.HLFJKDAONLJ<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK>> COAOHHEADPC;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x111ADE0", Offset = "0x1119BE0", VA = "0x18111ADE0")]
		internal MAOMEDCCGGF(LIFNMMADNGB<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK, GGBCFBLMLAI.HLFJKDAONLJ<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK>> OMKBHAHHOCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class EOKLJNBBAJE : GGBCFBLMLAI.HLFJKDAONLJ<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static readonly EOKLJNBBAJE ICOFMPPJNFC;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		private EOKLJNBBAJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xB02A20", Offset = "0xB01820", VA = "0x180B02A20", Slot = "4")]
		public MHHBOGMHBCP EPJEAABIPHE(CMGFJHDBEGO FPFHIDBMBMI)
		{
			return default(MHHBOGMHBCP);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x27CCC00", Offset = "0x27CBA00", VA = "0x1827CCC00", Slot = "5")]
		public void AFCGINBNKJC(HBDCLDOGDAK IPCOMOHMNHK, CMGFJHDBEGO CFDGGKIIHOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x27CCD10", Offset = "0x27CBB10", VA = "0x1827CCD10", Slot = "6")]
		public void BBNJCFLNKHE(HBDCLDOGDAK IPCOMOHMNHK, CMGFJHDBEGO CFDGGKIIHOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct IIPEMPHMDHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public KGGHGOBAEGL<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK, GGBCFBLMLAI.HLFJKDAONLJ<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK>> COAOHHEADPC;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x27D0190", Offset = "0x27CEF90", VA = "0x1827D0190")]
		internal IIPEMPHMDHK(KGGHGOBAEGL<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK, GGBCFBLMLAI.HLFJKDAONLJ<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK>> OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x27D0140", Offset = "0x27CEF40", VA = "0x1827D0140")]
		public static IIPEMPHMDHK NBEICDCLFEE()
		{
			return default(IIPEMPHMDHK);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct MDCBNLABDFL : PPAIEIINDHH.KKMHHFMHCJB<CMGFJHDBEGO, HBDCLDOGDAK>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct HBIFNCIKKGL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AsyncTaskMethodBuilder<JKEBLLKKBOM<object?, CHEIGOJMDOJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public HBDCLDOGDAK receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public CMGFJHDBEGO action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public MDCBNLABDFL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private TaskAwaiter<JKEBLLKKBOM<object?, CHEIGOJMDOJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x27CF990", Offset = "0x27CE790", VA = "0x1827CF990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x27CFB70", Offset = "0x27CE970", VA = "0x1827CFB70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA88D70", Offset = "0xA87B70", VA = "0x180A88D70", Slot = "4")]
		public BIHBDMOHDCK<FMJOCPEIHPL> IDNMGEILEMB(HBDCLDOGDAK HAAEOKEMPKE)
		{
			return default(BIHBDMOHDCK<FMJOCPEIHPL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x27D3DD0", Offset = "0x27D2BD0", VA = "0x1827D3DD0", Slot = "5")]
		public void CBALIEDBHCF(HBDCLDOGDAK HAAEOKEMPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x27D3E30", Offset = "0x27D2C30", VA = "0x1827D3E30", Slot = "6")]
		[AsyncStateMachine(typeof(HBIFNCIKKGL))]
		public Task<JKEBLLKKBOM<object, CHEIGOJMDOJ>> GIECFKBDPJB(HBDCLDOGDAK HAAEOKEMPKE, CMGFJHDBEGO CFDGGKIIHOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x27D3F60", Offset = "0x27D2D60", VA = "0x1827D3F60", Slot = "7")]
		public CMGFJHDBEGO[] OKOAALKFHFK(HBDCLDOGDAK HAAEOKEMPKE)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct PGFPHMCLLCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<bool, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public HBDCLDOGDAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TaskAwaiter<JKEBLLKKBOM<bool, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x27E3770", Offset = "0x27E2570", VA = "0x1827E3770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x27E3A00", Offset = "0x27E2800", VA = "0x1827E3A00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct ECBMHCLFFNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public HBDCLDOGDAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x27CC330", Offset = "0x27CB130", VA = "0x1827CC330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x27CC510", Offset = "0x27CB310", VA = "0x1827CC510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LHBPGABNCFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<object?, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public HBDCLDOGDAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public CMGFJHDBEGO action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<JKEBLLKKBOM<object?, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x27D2FC0", Offset = "0x27D1DC0", VA = "0x1827D2FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x27D31B0", Offset = "0x27D1FB0", VA = "0x1827D31B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly BIHBDMOHDCK<FMJOCPEIHPL> HGGFPEGDCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MAOMEDCCGGF BIIINOGMDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FJFOJKNNALJ HHPDLNHHGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly LCBOCOCABKH AACLOAGANLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BA8")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly IKMAMAHLHMO JKEDAJOCAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BB0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly NNLJIKPEIHP.HFIHNNFBMKG ACINMAOIODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BD8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly ADBNNIKLEMM BACHOEJKLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BE0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly ACKMFBFDNNH BKPJGMGKEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BE8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly LGGENGCNAGA ABNMOIMGMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BF0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly MMIMODOBHAE EEECPCHGADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BF8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private MCDHLBPPKMD LMNIPBCPPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C08")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private MKAEFBADJHL CICMGPMBPCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	internal readonly FJFOJKNNALJ.AGOCBHCPFJO GGGLAOALBEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly OEFHJHHKKGG JEBEHDJLDNO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FJFOJKNNALJ MLPAPKKKMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x27CEB00", Offset = "0x27CD900", VA = "0x1827CEB00")]
		get
		{
			return default(FJFOJKNNALJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal PBNOGBMLKJF ECJNCHOFEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27CE8D0", Offset = "0x27CD6D0", VA = "0x1827CE8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal HLIFGONAOOA JNOIHODKNIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7B0", Offset = "0x27CD5B0", VA = "0x1827CE7B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x27CF1F0", Offset = "0x27CDFF0", VA = "0x1827CF1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool OGDILPAMAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x27CF640", Offset = "0x27CE440", VA = "0x1827CF640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x27CE1B0", Offset = "0x27CCFB0", VA = "0x1827CE1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BMAEHBGOEKD DBHCANEBKMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x27CF950", Offset = "0x27CE750", VA = "0x1827CF950", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public EDCOKJFEDKH MHJBMIIFKJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x27CF960", Offset = "0x27CE760", VA = "0x1827CF960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ADNEPEAHMPF MNAJJBABDOM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x27CF980", Offset = "0x27CE780", VA = "0x1827CF980", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MEOOBHEAGCC LOMCHDDGNPA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x27CF970", Offset = "0x27CE770", VA = "0x1827CF970", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NNLJIKPEIHP? FNADCFKDMED
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x27CE730", Offset = "0x27CD530", VA = "0x1827CE730", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private BABKPDALFJM? FJMDPEJIPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x27CE280", Offset = "0x27CD080", VA = "0x1827CE280", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27CF650", Offset = "0x27CE450", VA = "0x1827CF650")]
	private HBDCLDOGDAK(IKMAMAHLHMO NMFFKEACGFO, BIHBDMOHDCK<FMJOCPEIHPL> FAPLIEIFOHC, [In] MAOMEDCCGGF IMHBFGBBKID, [In] FJFOJKNNALJ ENALCCBHCIF, [In] LCBOCOCABKH GPFGJHBJKPA, HLIFGONAOOA JFICJDHDKNF, [In] NNLJIKPEIHP.HFIHNNFBMKG HIOEMCKHGFM, FJFOJKNNALJ.AGOCBHCPFJO HCIMAHJCADB, OEFHJHHKKGG ONGEHGKNOJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x27CEEA0", Offset = "0x27CDCA0", VA = "0x1827CEEA0")]
	public static HBDCLDOGDAK NBEICDCLFEE(IKMAMAHLHMO JCFBNAHPHAO, [In] CJEBIFMAOMH KNOFHAIIONK, MJGLOKLKDPM GOPHMIDMGLI, [In] CDHGLHIHFJF AFINPNEOCEN, FBDGPOAGLJJ LJPGHFIKPJJ, BIHBDMOHDCK<FMJOCPEIHPL> FAPLIEIFOHC, BIHBDMOHDCK<KBIOCKDGHCK> INFMCBJIOPL, OEINHBKKCEG GOMEADMMGKL, KNAAHAGIAHE IGHLPKOLOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x27CEB90", Offset = "0x27CD990", VA = "0x1827CEB90")]
	public static HBDCLDOGDAK NBEICDCLFEE(IKMAMAHLHMO NMFFKEACGFO, [In] FJFOJKNNALJ ENALCCBHCIF, [In] LCBOCOCABKH GPFGJHBJKPA, BIHBDMOHDCK<FMJOCPEIHPL> FAPLIEIFOHC, BIHBDMOHDCK<KBIOCKDGHCK> INFMCBJIOPL, OEINHBKKCEG GOMEADMMGKL, KNAAHAGIAHE IGHLPKOLOCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27CE3B0", Offset = "0x27CD1B0", VA = "0x1827CE3B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x27CEA10", Offset = "0x27CD810", VA = "0x1827CEA10")]
	[AsyncStateMachine(typeof(PGFPHMCLLCI))]
	public Task<JKEBLLKKBOM<bool, CHEIGOJMDOJ>> KDDIPDNDBHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x27CE920", Offset = "0x27CD720", VA = "0x1827CE920")]
	[AsyncStateMachine(typeof(ECBMHCLFFNL))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> GBLJBBGPEFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x27CEFE0", Offset = "0x27CDDE0", VA = "0x1827CEFE0")]
	internal void NFEGAMFCFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x27CEB10", Offset = "0x27CD910", VA = "0x1827CEB10")]
	internal KKBEDCJNPPD<CMGFJHDBEGO> LLKCJNBGEGC([In] FPGCPCELCAJ DEPBOPOCLED)
	{
		return default(KKBEDCJNPPD<CMGFJHDBEGO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x27CE1C0", Offset = "0x27CCFC0", VA = "0x1827CE1C0")]
	internal bool BOGGJKDDADM([In] FPGCPCELCAJ DEPBOPOCLED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x27CE5A0", Offset = "0x27CD3A0", VA = "0x1827CE5A0")]
	internal JKEBLLKKBOM<CMGFJHDBEGO, CHEIGOJMDOJ> EBCOHGBNMJL([In] NDIACELDEDD MMNMFOIBPCA)
	{
		return default(JKEBLLKKBOM<CMGFJHDBEGO, CHEIGOJMDOJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x27CE230", Offset = "0x27CD030", VA = "0x1827CE230")]
	private void CBALIEDBHCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x27CE7C0", Offset = "0x27CD5C0", VA = "0x1827CE7C0")]
	[AsyncStateMachine(typeof(LHBPGABNCFM))]
	internal Task<JKEBLLKKBOM<object, CHEIGOJMDOJ>> EPONFIGMKKM(CMGFJHDBEGO CFDGGKIIHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x27CF210", Offset = "0x27CE010", VA = "0x1827CF210")]
	private CMGFJHDBEGO[] OKOAALKFHFK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class PJGEIHIKALM<TData> : DDPPOHMMKFK, BEHBKCGJGJH, LPPJEHMJDEA where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly KOIDEEJEAKA<KCAEAGPDLDO>? EBNCHCHBDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public readonly string BGIMHHCKDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly TData NOKLNLDMACL;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public KOIDEEJEAKA<KCAEAGPDLDO>? BLKIEKCBCAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2A6A150", Offset = "0x2A68F50", VA = "0x182A6A150", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0", Slot = "7")]
	public override string EEHOEKHGKPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5780BB0", Offset = "0x577F9B0", VA = "0x185780BB0")]
	internal PJGEIHIKALM([In] KOIDEEJEAKA<KCAEAGPDLDO>? IPEOHEOHOKN, BIHBDMOHDCK<DJIGOHNJMMM>? HPGNEILCHFG, IOKind? LPFPOLHOHEM, string NJJDPBHNDPA, [In] TData FFEMKICJPKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class LHKJJBAKONF
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x27D3220", Offset = "0x27D2020", VA = "0x1827D3220")]
	public static JKEBLLKKBOM<JJGJGPGIKBH, BEHBKCGJGJH> NLOBHJNPMJO([In] this JIAPBKEBGKJ<IECJFCJKCMK> OMHJCLHFFIK)
	{
		return default(JKEBLLKKBOM<JJGJGPGIKBH, BEHBKCGJGJH>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x39F0E20", Offset = "0x39EFC20", VA = "0x1839F0E20")]
	public static JKEBLLKKBOM<TOk, BEHBKCGJGJH> CCKELEHBDHI<TOk>([In] this JKEBLLKKBOM<TOk, BEHBKCGJGJH> FPFHIDBMBMI, [In] KOIDEEJEAKA<KCAEAGPDLDO>? IPEOHEOHOKN, BIHBDMOHDCK<DJIGOHNJMMM>? HPGNEILCHFG, IOKind? LPFPOLHOHEM, string NJJDPBHNDPA) where TOk : notnull
	{
		return default(JKEBLLKKBOM<TOk, BEHBKCGJGJH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IKMAMAHLHMO
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	NIBMFBMFLGC.AKJNGJKLMAC FCELHOAPNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	DIFGANNFPID.OEKIHGBCEEC CAAKLLMPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	HBDCLDOGDAK.PBNOGBMLKJF PLLANNGBADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	HNLPMDFGNGL.LECFMDNGEBF MEGEGLFOGNI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	GGBCFBLMLAI.HLFJKDAONLJ<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK> PLJNKBNICJG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	OALFCEOMBCC.PHHLMNPFINA MAJALBDIOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JEAFHHJHNHG GMMJNAHCMDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	EOMAFEHEGOI GHPKLPMKACO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	CPNBFAFEOAK BLDEGIPKNPD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	ECGAGLEJEGA JFEMFFELPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	LILPBIECJKB NLIPKEJHANA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IBACDMBJMLI
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x27CFE40", Offset = "0x27CEC40", VA = "0x1827CFE40")]
	public static CMGFJHDBEGO HCEICAODLOC(this CMGFJHDBEGO FPFHIDBMBMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x27CFD70", Offset = "0x27CEB70", VA = "0x1827CFD70")]
	public static CMGFJHDBEGO GOPDMGNOMIH(this ELPOKFBFNEF FPFHIDBMBMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct ELPOKFBFNEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct MNBNMINOEKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<object?, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public HBDCLDOGDAK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public ELPOKFBFNEF self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<JKEBLLKKBOM<object?, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x27D3F80", Offset = "0x27D2D80", VA = "0x1827D3F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x27D4240", Offset = "0x27D3040", VA = "0x1827D4240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly ByteString COJGBJGNJFM;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0xD5BCB0", Offset = "0xD5AAB0", VA = "0x180D5BCB0")]
	private ELPOKFBFNEF(ByteString OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x27CCAE0", Offset = "0x27CB8E0", VA = "0x1827CCAE0")]
	public static CMGFJHDBEGO PBHEBGPAPIG(ByteString OAIIHELJHLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x27CC920", Offset = "0x27CB720", VA = "0x1827CC920")]
	public static HHJJMLJIOEH<MHHBOGMHBCP, ELPOKFBFNEF> ADNOMJIKBDA(CMGFJHDBEGO PMCGLCFCJLK)
	{
		return default(HHJJMLJIOEH<MHHBOGMHBCP, ELPOKFBFNEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x27CC9D0", Offset = "0x27CB7D0", VA = "0x1827CC9D0")]
	[AsyncStateMachine(typeof(MNBNMINOEKN))]
	public static Task<JKEBLLKKBOM<object, CHEIGOJMDOJ>> EPONFIGMKKM(HBDCLDOGDAK IPCOMOHMNHK, ELPOKFBFNEF FPFHIDBMBMI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct AJHKMGNAFOK
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27C6540", Offset = "0x27C5340", VA = "0x1827C6540")]
	public static CMGFJHDBEGO PBHEBGPAPIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x27C6450", Offset = "0x27C5250", VA = "0x1827C6450")]
	public static HHJJMLJIOEH<MHHBOGMHBCP, AJHKMGNAFOK> ADNOMJIKBDA(CMGFJHDBEGO PMCGLCFCJLK)
	{
		return default(HHJJMLJIOEH<MHHBOGMHBCP, AJHKMGNAFOK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x27C64C0", Offset = "0x27C52C0", VA = "0x1827C64C0")]
	public static JKEBLLKKBOM<NICNPLCGCEF, MCNPHLHCLED> MOAAHFNEEOI(HBDCLDOGDAK IPCOMOHMNHK, [In] AJHKMGNAFOK FPFHIDBMBMI)
	{
		return default(JKEBLLKKBOM<NICNPLCGCEF, MCNPHLHCLED>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct EEBCKAOALCL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct NKBMACHBCJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, MCNPHLHCLED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public HBDCLDOGDAK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public EEBCKAOALCL self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private JKEBLLKKBOM<NICNPLCGCEF, MCNPHLHCLED> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x27DF840", Offset = "0x27DE640", VA = "0x1827DF840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x27DFE00", Offset = "0x27DEC00", VA = "0x1827DFE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly BINGFOABLIG? JLDLIAJGPJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly HHNNLOLDABE? BJCJMLGNCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly MMIHAIKLLOA? PALGLIOEANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly DIBJGGBNCIF? JAHCKOKLKIC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2211420", Offset = "0x2210220", VA = "0x182211420")]
	private EEBCKAOALCL(BINGFOABLIG? IHBAHMJHKEL, HHNNLOLDABE? HHLFMJDNKBO, MMIHAIKLLOA? JINFFCDMHMF, DIBJGGBNCIF? NBOAKCAKJAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x27CC810", Offset = "0x27CB610", VA = "0x1827CC810")]
	public static CMGFJHDBEGO? PBHEBGPAPIG(BINGFOABLIG? IHBAHMJHKEL, HHNNLOLDABE? HHLFMJDNKBO, MMIHAIKLLOA? JINFFCDMHMF, DIBJGGBNCIF? NBOAKCAKJAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x27CC580", Offset = "0x27CB380", VA = "0x1827CC580")]
	public static HHJJMLJIOEH<MHHBOGMHBCP, EEBCKAOALCL> ADNOMJIKBDA(CMGFJHDBEGO PMCGLCFCJLK)
	{
		return default(HHJJMLJIOEH<MHHBOGMHBCP, EEBCKAOALCL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x27CC6D0", Offset = "0x27CB4D0", VA = "0x1827CC6D0")]
	[AsyncStateMachine(typeof(NKBMACHBCJO))]
	public static Task<JKEBLLKKBOM<NICNPLCGCEF, MCNPHLHCLED>> EPONFIGMKKM(HBDCLDOGDAK IPCOMOHMNHK, EEBCKAOALCL FPFHIDBMBMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct ABLLGOEPECD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct PDILALHEAIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public ABLLGOEPECD self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public HBDCLDOGDAK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private JKEBLLKKBOM<object?, LPPJEHMJDEA>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private JKEBLLKKBOM<object?, LPPJEHMJDEA> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private JKEBLLKKBOM<object?, LPPJEHMJDEA>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter<JKEBLLKKBOM<object?, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x27E3290", Offset = "0x27E2090", VA = "0x1827E3290", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x27E3700", Offset = "0x27E2500", VA = "0x1827E3700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly IReadOnlyList<CMGFJHDBEGO> OFNCINFAONF;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xD5BCB0", Offset = "0xD5AAB0", VA = "0x180D5BCB0")]
	private ABLLGOEPECD(IReadOnlyList<CMGFJHDBEGO> GONMDJMHKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x27C5D40", Offset = "0x27C4B40", VA = "0x1827C5D40")]
	public static CMGFJHDBEGO PBHEBGPAPIG(IReadOnlyList<CMGFJHDBEGO> GONMDJMHKJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x27C5B60", Offset = "0x27C4960", VA = "0x1827C5B60")]
	public static HHJJMLJIOEH<MHHBOGMHBCP, ABLLGOEPECD> ADNOMJIKBDA(CMGFJHDBEGO PMCGLCFCJLK)
	{
		return default(HHJJMLJIOEH<MHHBOGMHBCP, ABLLGOEPECD>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x27C5C00", Offset = "0x27C4A00", VA = "0x1827C5C00")]
	[AsyncStateMachine(typeof(PDILALHEAIH))]
	public static Task<JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ>> EPONFIGMKKM(HBDCLDOGDAK IPCOMOHMNHK, ABLLGOEPECD FPFHIDBMBMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct NDIACELDEDD
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public sealed class NIKPOJHLKNB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class LKGHOPIEBDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public KOIDEEJEAKA<NIKPOJHLKNB> actionId;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LKGHOPIEBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x27D36C0", Offset = "0x27D24C0", VA = "0x1827D36C0")]
		internal CMGFJHDBEGO IAKFILFFHLP(int count, int index, [In] ReadOnlySpan<byte> span)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly KOIDEEJEAKA<NIKPOJHLKNB> FGNHCGNMOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly int GFOKFGGJOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly int KBDABDGGLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly byte[] NOKLNLDMACL;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x27D47C0", Offset = "0x27D35C0", VA = "0x1827D47C0")]
	private NDIACELDEDD(KOIDEEJEAKA<NIKPOJHLKNB> EENNBFLGEIP, int ALFGNAHPKIG, int GLAOLHCPLLG, byte[] FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x27D46B0", Offset = "0x27D34B0", VA = "0x1827D46B0")]
	public static CMGFJHDBEGO PBHEBGPAPIG(KOIDEEJEAKA<NIKPOJHLKNB> EENNBFLGEIP, int ALFGNAHPKIG, int GLAOLHCPLLG, ByteString FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x27D4400", Offset = "0x27D3200", VA = "0x1827D4400")]
	public static CMGFJHDBEGO[] DPCHFBHNFEB(CMGFJHDBEGO CFDGGKIIHOI, int CMHDHFEOCBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x27D42B0", Offset = "0x27D30B0", VA = "0x1827D42B0")]
	public static HHJJMLJIOEH<MHHBOGMHBCP, NDIACELDEDD> ADNOMJIKBDA(CMGFJHDBEGO PMCGLCFCJLK)
	{
		return default(HHJJMLJIOEH<MHHBOGMHBCP, NDIACELDEDD>);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x27D4510", Offset = "0x27D3310", VA = "0x1827D4510")]
	public static JKEBLLKKBOM<CMGFJHDBEGO, CHEIGOJMDOJ> MOAAHFNEEOI(HBDCLDOGDAK IPCOMOHMNHK, [In] NDIACELDEDD FPFHIDBMBMI)
	{
		return default(JKEBLLKKBOM<CMGFJHDBEGO, CHEIGOJMDOJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct FPGCPCELCAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct LGIAAEGIOKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<bool, MCNPHLHCLED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public HBDCLDOGDAK root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public FPGCPCELCAJ self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private JKEBLLKKBOM<bool, MCNPHLHCLED> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, MCNPHLHCLED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x27D2910", Offset = "0x27D1710", VA = "0x1827D2910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x27D2F50", Offset = "0x27D1D50", VA = "0x1827D2F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly int GFOKFGGJOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly int KBDABDGGLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly byte[] NOKLNLDMACL;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xC3BD10", Offset = "0xC3AB10", VA = "0x180C3BD10")]
	private FPGCPCELCAJ(int ALFGNAHPKIG, int GLAOLHCPLLG, byte[] FFEMKICJPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x27CD8E0", Offset = "0x27CC6E0", VA = "0x1827CD8E0")]
	public static CMGFJHDBEGO PBHEBGPAPIG(int ALFGNAHPKIG, int GLAOLHCPLLG, ByteString FFEMKICJPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x27CD6D0", Offset = "0x27CC4D0", VA = "0x1827CD6D0")]
	public static CMGFJHDBEGO?[]? MNEAMEABKCG(int CMHDHFEOCBM, BINGFOABLIG? IHBAHMJHKEL, HHNNLOLDABE? HHLFMJDNKBO, MMIHAIKLLOA? JINFFCDMHMF, DIBJGGBNCIF? NBOAKCAKJAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x27CD4C0", Offset = "0x27CC2C0", VA = "0x1827CD4C0")]
	public static HHJJMLJIOEH<MHHBOGMHBCP, FPGCPCELCAJ> ADNOMJIKBDA(CMGFJHDBEGO PMCGLCFCJLK)
	{
		return default(HHJJMLJIOEH<MHHBOGMHBCP, FPGCPCELCAJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x27CD5A0", Offset = "0x27CC3A0", VA = "0x1827CD5A0")]
	[AsyncStateMachine(typeof(LGIAAEGIOKD))]
	public static Task<JKEBLLKKBOM<bool, MCNPHLHCLED>> EPONFIGMKKM(HBDCLDOGDAK IPCOMOHMNHK, FPGCPCELCAJ FPFHIDBMBMI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class ADBNNIKLEMM : BMAEHBGOEKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly HBDCLDOGDAK BPKGJHGJDKJ;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public DDPMMGDCMEF? ICOFMPPJNFC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x27C5E00", Offset = "0x27C4C00", VA = "0x1827C5E00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	internal ADBNNIKLEMM(HBDCLDOGDAK PINKMLPHMFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class KEDILPDKIHJ : DDPMMGDCMEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly HBDCLDOGDAK BPKGJHGJDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly ONOMLABGPBN BHAIPHKEDGJ;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA17110", Offset = "0xA15F10", VA = "0x180A17110")]
	public KEDILPDKIHJ(HBDCLDOGDAK PINKMLPHMFP, ONOMLABGPBN EHBLPMCHLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x27D0ED0", Offset = "0x27CFCD0", VA = "0x1827D0ED0", Slot = "4")]
	public JKEBLLKKBOM<JJGJGPGIKBH, BEHBKCGJGJH> BLEJCCMJLKJ(KOIDEEJEAKA<KCAEAGPDLDO> HLGNHFCFAMG, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, BIHBDMOHDCK<LBJKHBPAKKD> OIEAMJCBCEP)
	{
		return default(JKEBLLKKBOM<JJGJGPGIKBH, BEHBKCGJGJH>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x27D1490", Offset = "0x27D0290", VA = "0x1827D1490", Slot = "5")]
	public JKEBLLKKBOM<JJGJGPGIKBH, BEHBKCGJGJH> DPLCHLIDNGB(KOIDEEJEAKA<KCAEAGPDLDO> HLGNHFCFAMG, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, BIHBDMOHDCK<FMHKAEJFBFI> ILNOKIIEBEH)
	{
		return default(JKEBLLKKBOM<JJGJGPGIKBH, BEHBKCGJGJH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class NIBMFBMFLGC : CKGJLKOHNOP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public interface AKJNGJKLMAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<ONOMLABGPBN> OIGJLMONBPB(HBDCLDOGDAK PINKMLPHMFP, HHNNLOLDABE? KJJLJHGIIKB, MMIHAIKLLOA? NIAGKFELLGP, CancellationToken GHKBKDKNIOM);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		LLDOMGLFOED LBENMNGFNNG(HBDCLDOGDAK PINKMLPHMFP, BINGFOABLIG BGPKDMDEGME);
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class GMHBENNGPCG : AKJNGJKLMAC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct GNIEAFBKNHL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AsyncTaskMethodBuilder<ONOMLABGPBN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public HBDCLDOGDAK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public HHNNLOLDABE cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public MMIHAIKLLOA cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private TaskAwaiter<HNLPMDFGNGL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x27CDF70", Offset = "0x27CCD70", VA = "0x1827CDF70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x27CE140", Offset = "0x27CCF40", VA = "0x1827CE140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly GMHBENNGPCG ICOFMPPJNFC;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		private GMHBENNGPCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x27CDD90", Offset = "0x27CCB90", VA = "0x1827CDD90", Slot = "4")]
		[AsyncStateMachine(typeof(GNIEAFBKNHL))]
		public Task<ONOMLABGPBN> OIGJLMONBPB(HBDCLDOGDAK PINKMLPHMFP, HHNNLOLDABE? KJJLJHGIIKB, MMIHAIKLLOA? NIAGKFELLGP, CancellationToken GHKBKDKNIOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x27CDD70", Offset = "0x27CCB70", VA = "0x1827CDD70", Slot = "5")]
		public LLDOMGLFOED LBENMNGFNNG(HBDCLDOGDAK PINKMLPHMFP, BINGFOABLIG BGPKDMDEGME)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct NMPHAMKCCNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public AsyncTaskMethodBuilder<NIBMFBMFLGC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public HBDCLDOGDAK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public HHNNLOLDABE cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public MMIHAIKLLOA cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public BINGFOABLIG evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private AKJNGJKLMAC <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter<ONOMLABGPBN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x27DFE70", Offset = "0x27DEC70", VA = "0x1827DFE70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x27E0370", Offset = "0x27DF170", VA = "0x1827E0370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly ONOMLABGPBN BHAIPHKEDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly LLDOMGLFOED IMKCCNDLIBD;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public NNLJIKPEIHP FNADCFKDMED
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x27DF730", Offset = "0x27DE530", VA = "0x1827DF730", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BABKPDALFJM ILHEJKHAMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x27DF780", Offset = "0x27DE580", VA = "0x1827DF780", Slot = "5")]
		get
		{
			return default(BABKPDALFJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public KEDILPDKIHJ OIBBDOJLKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public BAAJLNNPNBM JKKPMIOOIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xEE1B10", Offset = "0xEE0910", VA = "0x180EE1B10")]
	private NIBMFBMFLGC(ONOMLABGPBN EHBLPMCHLFI, LLDOMGLFOED GDGPIDCODJB, KEDILPDKIHJ HEMDCILKEGN, BAAJLNNPNBM ALENHMDBIBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x27DF560", Offset = "0x27DE360", VA = "0x1827DF560")]
	[AsyncStateMachine(typeof(NMPHAMKCCNI))]
	public static Task<NIBMFBMFLGC> CPHJLFEDOHD(HBDCLDOGDAK PINKMLPHMFP, BINGFOABLIG BGPKDMDEGME, HHNNLOLDABE? KJJLJHGIIKB, MMIHAIKLLOA? NIAGKFELLGP, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x27DF6D0", Offset = "0x27DE4D0", VA = "0x1827DF6D0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public sealed class DIFGANNFPID : HLIFGONAOOA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface OEKIHGBCEEC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CKGJLKOHNOP> JJGBLHMLIGM(HBDCLDOGDAK PINKMLPHMFP, BINGFOABLIG BGPKDMDEGME, HHNNLOLDABE? KJJLJHGIIKB, MMIHAIKLLOA? NIAGKFELLGP, CancellationToken GHKBKDKNIOM);

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MBOMEGGJCAM();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OFAJLBGEKJN();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class DCNIEPFANGM : OEKIHGBCEEC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		[CompilerGenerated]
		private struct GAEDFJEPKBD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public AsyncTaskMethodBuilder<CKGJLKOHNOP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public HBDCLDOGDAK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public BINGFOABLIG evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public HHNNLOLDABE cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public MMIHAIKLLOA cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private TaskAwaiter<NIBMFBMFLGC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x27CD9C0", Offset = "0x27CC7C0", VA = "0x1827CD9C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x27CDD00", Offset = "0x27CCB00", VA = "0x1827CDD00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x27CA620", Offset = "0x27C9420", VA = "0x1827CA620", Slot = "4")]
		[AsyncStateMachine(typeof(GAEDFJEPKBD))]
		public Task<CKGJLKOHNOP> JJGBLHMLIGM(HBDCLDOGDAK PINKMLPHMFP, BINGFOABLIG BGPKDMDEGME, HHNNLOLDABE? KJJLJHGIIKB, MMIHAIKLLOA? NIAGKFELLGP, CancellationToken GHKBKDKNIOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void MBOMEGGJCAM();

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void OFAJLBGEKJN();

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		protected DCNIEPFANGM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private struct JCOICAAOOJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public AsyncTaskMethodBuilder<CKGJLKOHNOP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public DIFGANNFPID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter<NICNPLCGCEF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x27D0200", Offset = "0x27CF000", VA = "0x1827D0200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x27D0400", Offset = "0x27CF200", VA = "0x1827D0400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct LCGHLDBAPIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public DIFGANNFPID <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public HBDCLDOGDAK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public BINGFOABLIG evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public HHNNLOLDABE cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public MMIHAIKLLOA cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter<CKGJLKOHNOP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x27D2140", Offset = "0x27D0F40", VA = "0x1827D2140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x27D2680", Offset = "0x27D1480", VA = "0x1827D2680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly OEKIHGBCEEC JLPOGPHFPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly TaskCompletionSource<NICNPLCGCEF> HHEPCIDNFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly TaskCompletionSource<NICNPLCGCEF> HMCIDDFCOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly CancellationTokenSource GIADDKNEJHM;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool OGDILPAMAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA36F20", Offset = "0xA35D20", VA = "0x180A36F20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA36E80", Offset = "0xA35C80", VA = "0x180A36E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KNAODMGEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xDD4380", Offset = "0xDD3180", VA = "0x180DD4380", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1357120", Offset = "0x1355F20", VA = "0x181357120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool JCBGLPBPANL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xF9C060", Offset = "0xF9AE60", VA = "0x180F9C060")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x27CBFC0", Offset = "0x27CADC0", VA = "0x1827CBFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public CKGJLKOHNOP? EDBFLFFEMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED00", Offset = "0xA0DB00", VA = "0x180A0ED00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x27CBFD0", Offset = "0x27CADD0", VA = "0x1827CBFD0", Slot = "7")]
	[AsyncStateMachine(typeof(JCOICAAOOJM))]
	public Task<CKGJLKOHNOP> NKHOCDOIGCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x27CC220", Offset = "0x27CB020", VA = "0x1827CC220")]
	public DIFGANNFPID(OEKIHGBCEEC JCFBNAHPHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x27CC0C0", Offset = "0x27CAEC0", VA = "0x1827CC0C0", Slot = "8")]
	[AsyncStateMachine(typeof(LCGHLDBAPIP))]
	public Task PLAMPKFEGPM(HBDCLDOGDAK PINKMLPHMFP, BINGFOABLIG BGPKDMDEGME, HHNNLOLDABE? KJJLJHGIIKB, MMIHAIKLLOA? NIAGKFELLGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x27CBE40", Offset = "0x27CAC40", VA = "0x1827CBE40", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal sealed class DEELDAEINLK : ODGAKONFHJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly BAAJLNNPNBM CCOMBLJPIPM;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public DEELDAEINLK(BAAJLNNPNBM ALENHMDBIBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal static class HGFPMDNPMAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class NPDPICEHBDL<TGraph> : MJGAJOPCPPN where TGraph : HIDGDEMJMAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		protected readonly TGraph CODJAGEJJHE;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public virtual ADEMCNEJKDH? FMNGCBNEFKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x1884150", Offset = "0x1882F50", VA = "0x181884150", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual KOIDEEJEAKA<KCAEAGPDLDO>? FGMCGAEPBOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x1884150", Offset = "0x1882F50", VA = "0x181884150", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public BIHBDMOHDCK<HJIDLNADIFB> IIFNBDFMHFC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x2A5EE50", Offset = "0x2A5DC50", VA = "0x182A5EE50", Slot = "5")]
			get
			{
				return default(BIHBDMOHDCK<HJIDLNADIFB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public BIHBDMOHDCK<HJIDLNADIFB>? GFBJGAFBEAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x55085F0", Offset = "0x55073F0", VA = "0x1855085F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
		public NPDPICEHBDL(TGraph DJNJGENDJMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private sealed class LBCHMKGAOHM : NPDPICEHBDL<OENENDPFIKH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public override ADEMCNEJKDH? FMNGCBNEFKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x193F710", Offset = "0x193E510", VA = "0x18193F710", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public override KOIDEEJEAKA<KCAEAGPDLDO>? FGMCGAEPBOL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x27D1FE0", Offset = "0x27D0DE0", VA = "0x1827D1FE0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x27D2070", Offset = "0x27D0E70", VA = "0x1827D2070")]
		public LBCHMKGAOHM(OENENDPFIKH IGPNHLLMKAA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x27CFBE0", Offset = "0x27CE9E0", VA = "0x1827CFBE0")]
	public static MJGAJOPCPPN NBEICDCLFEE(HIDGDEMJMAO DJNJGENDJMJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class CDNLFFIPPJK : KOICPKOEOHP, BPPIKLNCLPG, GFPDJMBDKEG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class OLJDCAEGADO
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
			public OLJDCAEGADO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public JEAFHHJHNHG errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x27E3D60", Offset = "0x27E2B60", VA = "0x1827E3D60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x27E3FD0", Offset = "0x27E2DD0", VA = "0x1827E3FD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public CDNLFFIPPJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public OLJDCAEGADO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x27E3060", Offset = "0x27E1E60", VA = "0x1827E3060")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task JPELDDOJHCP(JEAFHHJHNHG errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct ODMAGGLAAKM : IAsyncStateMachine
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
		public CDNLFFIPPJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x27E0460", Offset = "0x27DF260", VA = "0x1827E0460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x27E0970", Offset = "0x27DF770", VA = "0x1827E0970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class IDFIJAJACMP
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
			public IDFIJAJACMP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x27E4030", Offset = "0x27E2E30", VA = "0x1827E4030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x27E4310", Offset = "0x27E3110", VA = "0x1827E4310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public CDNLFFIPPJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public IDFIJAJACMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x27D0070", Offset = "0x27CEE70", VA = "0x1827D0070")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task KJBBAPNAJNM(JEAFHHJHNHG errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class AHMNOLJCOPO
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
			public AHMNOLJCOPO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x27E4890", Offset = "0x27E3690", VA = "0x1827E4890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x27E4D40", Offset = "0x27E3B40", VA = "0x1827E4D40", Slot = "5")]
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
		public CDNLFFIPPJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public int valueIndex;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public AHMNOLJCOPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x27C6380", Offset = "0x27C5180", VA = "0x1827C6380")]
		[AsyncStateMachine(typeof(<<RequestSetVectorComponentValue>g__requestSetVectorComponentValueInternal|0>d))]
		internal Task EAFPJMLFJNM(JEAFHHJHNHG errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class PHGGANBAMPM
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
			public PHGGANBAMPM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x27E4370", Offset = "0x27E3170", VA = "0x1827E4370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x27E4830", Offset = "0x27E3630", VA = "0x1827E4830", Slot = "5")]
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
		public CDNLFFIPPJK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public int valueIndex;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public PHGGANBAMPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x27E3A70", Offset = "0x27E2870", VA = "0x1827E3A70")]
		[AsyncStateMachine(typeof(<<RequestSetQuaternionComponentValue>g__requestSetQuaternionComponentValueInternal|0>d))]
		internal Task JGKALHHPHJE(JEAFHHJHNHG errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly OEECNBOMALI ENGKGOLGOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly ICollection<ECNFPPDPOOG> GCBONJFDJIJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private IKMAMAHLHMO GGHJMAENJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x27C7BB0", Offset = "0x27C69B0", VA = "0x1827C7BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public BIHBDMOHDCK<LBJKHBPAKKD> FGPEHBMELOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xF873E0", Offset = "0xF861E0", VA = "0x180F873E0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(BIHBDMOHDCK<LBJKHBPAKKD>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xF85AA0", Offset = "0xF848A0", VA = "0x180F85AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private BIHBDMOHDCK<JAIKLOFJOLF> NHMBHHFJCMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1355A90", Offset = "0x1354890", VA = "0x181355A90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public BIHBDMOHDCK<KAJIMMHBMBI> GKFCFLKFKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA30D50", Offset = "0xA2FB50", VA = "0x180A30D50", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(BIHBDMOHDCK<KAJIMMHBMBI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public override BIHBDMOHDCK<DJIGOHNJMMM> CLDGHLHCMKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x27C7AB0", Offset = "0x27C68B0", VA = "0x1827C7AB0", Slot = "21")]
		get
		{
			return default(BIHBDMOHDCK<DJIGOHNJMMM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool IJBPCOMGGMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x27C6DB0", Offset = "0x27C5BB0", VA = "0x1827C6DB0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x27CA400", Offset = "0x27C9200", VA = "0x1827CA400")]
	private CDNLFFIPPJK(HBDCLDOGDAK PINKMLPHMFP, ANKFKDANALM BINEDJHADMC, OEECNBOMALI FJKMKLPNOMB, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, BIHBDMOHDCK<LBJKHBPAKKD> OIEAMJCBCEP, BIHBDMOHDCK<JAIKLOFJOLF> AEIPGBEAKCM, bool JGODIJPOFBP, string IHGFMOMOADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x27C8CB0", Offset = "0x27C7AB0", VA = "0x1827C8CB0")]
	public static CDNLFFIPPJK NBEICDCLFEE(HBDCLDOGDAK PINKMLPHMFP, ANKFKDANALM BINEDJHADMC, OEECNBOMALI DGDLKJDMLAD, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, BIHBDMOHDCK<JAIKLOFJOLF> AEIPGBEAKCM, BIHBDMOHDCK<LBJKHBPAKKD> OIEAMJCBCEP, bool JGODIJPOFBP, bool FNAGLHJGOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x27C7B10", Offset = "0x27C6910", VA = "0x1827C7B10", Slot = "22")]
	protected override void IANLJFINMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x27C6F00", Offset = "0x27C5D00", VA = "0x1827C6F00", Slot = "23")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x27C9060", Offset = "0x27C7E60", VA = "0x1827C9060", Slot = "31")]
	public void NHNGKEPDBCP(ECNFPPDPOOG JFFJPGFEHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x27C87A0", Offset = "0x27C75A0", VA = "0x1827C87A0", Slot = "28")]
	public void LDONPALOBLF(DKMBBDJHBLO AKHMHNJEGAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x27C9190", Offset = "0x27C7F90", VA = "0x1827C9190", Slot = "29")]
	public void NNHDHMCGICM(LAGMKILPEDH IKENLJOCBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x27C78A0", Offset = "0x27C66A0", VA = "0x1827C78A0", Slot = "24")]
	protected override void FLNEDCNAHBJ(PANBIENFJEA EIAANAEFNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x27C72F0", Offset = "0x27C60F0", VA = "0x1827C72F0", Slot = "33")]
	public string EIPKFBCNGKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x27C6740", Offset = "0x27C5540", VA = "0x1827C6740", Slot = "30")]
	public string BEBMOFOPOAD(int JLMEKGPDJJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x27C84F0", Offset = "0x27C72F0", VA = "0x1827C84F0")]
	private void KOLDOFLCFML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x27C6C70", Offset = "0x27C5A70", VA = "0x1827C6C70", Slot = "32")]
	public void BPIGIMHKOAI(ECNFPPDPOOG JFFJPGFEHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x27C81B0", Offset = "0x27C6FB0", VA = "0x1827C81B0")]
	private void JNGFEELHGHJ(bool OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x27C80A0", Offset = "0x27C6EA0", VA = "0x1827C80A0", Slot = "34")]
	[AsyncStateMachine(typeof(ODMAGGLAAKM))]
	public Task JKJPHDACIOJ(string OAIIHELJHLG, bool HFIIHNPDMOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x27C8370", Offset = "0x27C7170", VA = "0x1827C8370")]
	public void JPAINKBPDNO(string OAIIHELJHLG, bool HFIIHNPDMOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x27C6FA0", Offset = "0x27C5DA0", VA = "0x1827C6FA0")]
	private void EBBPLDIIAMN(int OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x27C7CB0", Offset = "0x27C6AB0", VA = "0x1827C7CB0")]
	private void JAJOHBNENGN(int OIAENMIPOHE, string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x27C7EE0", Offset = "0x27C6CE0", VA = "0x1827C7EE0")]
	private void JJAKFLNDEJC(int OIAENMIPOHE, string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x27C7470", Offset = "0x27C6270", VA = "0x1827C7470")]
	private string ENKOOAHOLAL(int OIAENMIPOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x27C6AE0", Offset = "0x27C58E0", VA = "0x1827C6AE0")]
	private string BMEDBFIADMJ(int OIAENMIPOHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0xF85AA0", Offset = "0xF848A0", VA = "0x180F85AA0")]
	internal void FEFJONBCJEF(BIHBDMOHDCK<LBJKHBPAKKD> OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x27C7B00", Offset = "0x27C6900", VA = "0x1827C7B00")]
	[CompilerGenerated]
	private void HMNIBGAFBCK(string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x27C7630", Offset = "0x27C6430", VA = "0x1827C7630")]
	[CompilerGenerated]
	private bool FBPIGPGHGPJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x27C79F0", Offset = "0x27C67F0", VA = "0x1827C79F0")]
	[CompilerGenerated]
	private bool HEKCCMNCCNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x27CA2E0", Offset = "0x27C90E0", VA = "0x1827CA2E0")]
	[CompilerGenerated]
	private int OCOMCPLFOPL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x27C8B10", Offset = "0x27C7910", VA = "0x1827C8B10")]
	[CompilerGenerated]
	private bool MCAPLLDOOMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x27C84E0", Offset = "0x27C72E0", VA = "0x1827C84E0")]
	[CompilerGenerated]
	private void KNGHPBNIEIK(string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x27CA220", Offset = "0x27C9020", VA = "0x1827CA220")]
	[CompilerGenerated]
	private bool OCLPDKIMCIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x27C6650", Offset = "0x27C5450", VA = "0x1827C6650")]
	[CompilerGenerated]
	private bool AMPJMPJPJBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x27C66A0", Offset = "0x27C54A0", VA = "0x1827C66A0")]
	[CompilerGenerated]
	private bool ANGDEICJHOJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x27CA2E0", Offset = "0x27C90E0", VA = "0x1827CA2E0")]
	[CompilerGenerated]
	private int PBJBJJDBOIE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x27C7150", Offset = "0x27C5F50", VA = "0x1827C7150")]
	[CompilerGenerated]
	private bool EFEEMMBLMFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x27C8720", Offset = "0x27C7520", VA = "0x1827C8720")]
	[CompilerGenerated]
	private object LCJIOCOENFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x27C8BA0", Offset = "0x27C79A0", VA = "0x1827C8BA0")]
	[CompilerGenerated]
	private void MHFODACGJJF(object OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x27CA330", Offset = "0x27C9130", VA = "0x1827CA330")]
	[CompilerGenerated]
	private bool PGBHGIDAKBC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x27C7C40", Offset = "0x27C6A40", VA = "0x1827C7C40")]
	[CompilerGenerated]
	private string INFNMPFONJI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x27C8C90", Offset = "0x27C7A90", VA = "0x1827C8C90")]
	[CompilerGenerated]
	private void MLCJIBBJPNJ(string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x27C6E30", Offset = "0x27C5C30", VA = "0x1827C6E30")]
	[CompilerGenerated]
	private bool DLLPCEJGFKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x27C75C0", Offset = "0x27C63C0", VA = "0x1827C75C0")]
	[CompilerGenerated]
	private string EPIKFLEHAOA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x27C8CA0", Offset = "0x27C7AA0", VA = "0x1827C8CA0")]
	[CompilerGenerated]
	private void MOCAPEDNOGJ(string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x27C77D0", Offset = "0x27C65D0", VA = "0x1827C77D0")]
	[CompilerGenerated]
	private bool FJMLECGLEHB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x27C7E70", Offset = "0x27C6C70", VA = "0x1827C7E70")]
	[CompilerGenerated]
	private string JGLJAJHBHLP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x27C77C0", Offset = "0x27C65C0", VA = "0x1827C77C0")]
	[CompilerGenerated]
	private void FHMPLEFFLIP(string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x27C7220", Offset = "0x27C6020", VA = "0x1827C7220")]
	[CompilerGenerated]
	private bool EIOKBABDDKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x27C8C20", Offset = "0x27C7A20", VA = "0x1827C8C20")]
	[CompilerGenerated]
	private string MJHGBOBJCGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x27C84D0", Offset = "0x27C72D0", VA = "0x1827C84D0")]
	[CompilerGenerated]
	private void KLMMPFJBBGI(string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x27C6A10", Offset = "0x27C5810", VA = "0x1827C6A10")]
	[CompilerGenerated]
	private bool BJOKGDGBJKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x27C6D40", Offset = "0x27C5B40", VA = "0x1827C6D40")]
	[CompilerGenerated]
	private string BPNPHMHOJCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x27C7140", Offset = "0x27C5F40", VA = "0x1827C7140")]
	[CompilerGenerated]
	private void EDPFIABBHLA(string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x27C76F0", Offset = "0x27C64F0", VA = "0x1827C76F0")]
	[CompilerGenerated]
	private bool FHHHEELHCCA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x27C7BD0", Offset = "0x27C69D0", VA = "0x1827C7BD0")]
	[CompilerGenerated]
	private string IMOAOFJHENH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x27C84C0", Offset = "0x27C72C0", VA = "0x1827C84C0")]
	[CompilerGenerated]
	private void KJMLFICCALE(string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x27CA150", Offset = "0x27C8F50", VA = "0x1827CA150")]
	[CompilerGenerated]
	private bool OBNNMPFMCMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x27C65E0", Offset = "0x27C53E0", VA = "0x1827C65E0")]
	[CompilerGenerated]
	private string AEPLNHINGAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x27C6730", Offset = "0x27C5530", VA = "0x1827C6730")]
	[CompilerGenerated]
	private void BAFLKGFKNGF(string OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x27C90C0", Offset = "0x27C7EC0", VA = "0x1827C90C0")]
	[CompilerGenerated]
	private bool NKEKIJNGECJ()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class DIFECPPNDHE
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private sealed class LNFMEKFLJGI : JGGDCGDPDJF<HCKKCMMMGKL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class PMCJJLNMOPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public LNFMEKFLJGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public PMCJJLNMOPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x27E3C20", Offset = "0x27E2A20", VA = "0x1827E3C20")]
			internal object EFLKMKJKNFL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x27E3C90", Offset = "0x27E2A90", VA = "0x1827E3C90")]
			internal void FIPGNDKIHPC(object value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x27D3D60", Offset = "0x27D2B60", VA = "0x1827D3D60")]
		public LNFMEKFLJGI(HBDCLDOGDAK PINKMLPHMFP, HCKKCMMMGKL OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x27D3AD0", Offset = "0x27D28D0", VA = "0x1827D3AD0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public sealed class IPNCJJHIMOF : JDGCPHOOIED<AAKNEBMFOII>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override PPGGIKABFII NCLIDJPHIOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xBFC230", Offset = "0xBFB030", VA = "0x180BFC230", Slot = "145")]
			get
			{
				return default(PPGGIKABFII);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x27D01A0", Offset = "0x27CEFA0", VA = "0x1827D01A0")]
		public IPNCJJHIMOF(HBDCLDOGDAK PINKMLPHMFP, AAKNEBMFOII OMKBHAHHOCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class FCPOIDCADLI : JGGDCGDPDJF<ENLJJAPPEFO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x27CD1A0", Offset = "0x27CBFA0", VA = "0x1827CD1A0")]
		public FCPOIDCADLI(HBDCLDOGDAK PINKMLPHMFP, ENLJJAPPEFO BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x27CCEF0", Offset = "0x27CBCF0", VA = "0x1827CCEF0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x27CCEA0", Offset = "0x27CBCA0", VA = "0x1827CCEA0")]
		[CompilerGenerated]
		private bool EDJPJIMNMNM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x27CD070", Offset = "0x27CBE70", VA = "0x1827CD070")]
		[CompilerGenerated]
		private void PKIEBLKDFDF(bool OAIIHELJHLG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class KHJNHGNPBJG : JGGDCGDPDJF<PCDBPIFINLJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class JIDEJBOGEEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public KHJNHGNPBJG <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public JIDEJBOGEEH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x27D0530", Offset = "0x27CF330", VA = "0x1827D0530")]
			internal void EFLKMKJKNFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x27D0580", Offset = "0x27CF380", VA = "0x1827D0580")]
			internal bool FIPGNDKIHPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x27D04E0", Offset = "0x27CF2E0", VA = "0x1827D04E0")]
			internal bool AFGCMBEJMPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x27D0620", Offset = "0x27CF420", VA = "0x1827D0620")]
			internal void PFIBKFEAIBF(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x27D05D0", Offset = "0x27CF3D0", VA = "0x1827D05D0")]
			internal bool LFNJACLOFOJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x27D1DA0", Offset = "0x27D0BA0", VA = "0x1827D1DA0")]
		public KHJNHGNPBJG(HBDCLDOGDAK PINKMLPHMFP, PCDBPIFINLJ BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x27D1A60", Offset = "0x27D0860", VA = "0x1827D1A60", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class OEEPOGGBEHD : JGGDCGDPDJF<EJAFAKAHKHO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private sealed class KAHKLJABPFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public OEEPOGGBEHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public KAHKLJABPFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x27D0900", Offset = "0x27CF700", VA = "0x1827D0900")]
			internal object? EFLKMKJKNFL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x27D0E00", Offset = "0x27CFC00", VA = "0x1827D0E00")]
			internal bool NAJEIOOLNDO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x27D0A00", Offset = "0x27CF800", VA = "0x1827D0A00")]
			internal void FIPGNDKIHPC(object? value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x27D0750", Offset = "0x27CF550", VA = "0x1827D0750")]
			internal string AFGCMBEJMPG(object? key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x27D0E80", Offset = "0x27CFC80", VA = "0x1827D0E80")]
			internal IReadOnlyList<object> PFIBKFEAIBF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x27D0D90", Offset = "0x27CFB90", VA = "0x1827D0D90")]
			internal bool LFNJACLOFOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x27D08B0", Offset = "0x27CF6B0", VA = "0x1827D08B0")]
			internal bool EALAMANBNEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x27D0C60", Offset = "0x27CFA60", VA = "0x1827D0C60")]
			internal void FJHLHGPGNHI(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x27E1140", Offset = "0x27DFF40", VA = "0x1827E1140")]
		public OEEPOGGBEHD(HBDCLDOGDAK PINKMLPHMFP, EJAFAKAHKHO BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x27E09D0", Offset = "0x27DF7D0", VA = "0x1827E09D0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class AHJHFODFCBB : JGGDCGDPDJF<PCGMGFEAAGN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class LAGFDALCBGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public AHJHFODFCBB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public LAGFDALCBGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x27D1E60", Offset = "0x27D0C60", VA = "0x1827D1E60")]
			internal bool EFLKMKJKNFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x27D1EB0", Offset = "0x27D0CB0", VA = "0x1827D1EB0")]
			internal void FIPGNDKIHPC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x27D1E10", Offset = "0x27D0C10", VA = "0x1827D1E10")]
			internal bool AFGCMBEJMPG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x27C6310", Offset = "0x27C5110", VA = "0x1827C6310")]
		public AHJHFODFCBB(HBDCLDOGDAK PINKMLPHMFP, PCGMGFEAAGN BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x27C60E0", Offset = "0x27C4EE0", VA = "0x1827C60E0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public abstract class IGEOBHIJPME<TNode> : JGGDCGDPDJF<TNode> where TNode : notnull, ONMOMEKNGIJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct HEHLPPPDHJC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public AsyncTaskMethodBuilder<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public IGEOBHIJPME<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private TaskAwaiter<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x4C1C9D0", Offset = "0x4C1B7D0", VA = "0x184C1C9D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x4C1CDE0", Offset = "0x4C1BBE0", VA = "0x184C1CDE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct PFHPLADNEJD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public IGEOBHIJPME<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public BIHBDMOHDCK<NGIHDDPPPGJ> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x5775860", Offset = "0x5774660", VA = "0x185775860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x5775C70", Offset = "0x5774A70", VA = "0x185775C70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public sealed override bool LPOIOKLMCNH
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "134")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public sealed override BIHBDMOHDCK<NGIHDDPPPGJ>? HJDMGJFMKDB
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x4D34320", Offset = "0x4D33120", VA = "0x184D34320", Slot = "138")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x4D342D0", Offset = "0x4D330D0", VA = "0x184D342D0")]
		protected IGEOBHIJPME(HBDCLDOGDAK PINKMLPHMFP, TNode BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4D34000", Offset = "0x4D32E00", VA = "0x184D34000", Slot = "119")]
		[AsyncStateMachine(typeof(IGEOBHIJPME<>.HEHLPPPDHJC))]
		public override Task<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> MDAOIMHMFGD(string IHGFMOMOADA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x4D33F60", Offset = "0x4D32D60", VA = "0x184D33F60", Slot = "143")]
		public sealed override bool INCDOMMKFLD(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4D34120", Offset = "0x4D32F20", VA = "0x184D34120", Slot = "131")]
		protected sealed override bool MEJLPKNKKMI(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x4D33EC0", Offset = "0x4D32CC0", VA = "0x184D33EC0", Slot = "132")]
		protected override bool FBIDPNPKCBO(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4D341C0", Offset = "0x4D32FC0", VA = "0x184D341C0", Slot = "120")]
		[AsyncStateMachine(typeof(IGEOBHIJPME<>.PFHPLADNEJD))]
		public override Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> PHBNFECMAIJ(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class FDJAEGMFNOO : NLMHFLCMFOO<LDFAABCOMKP>
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private sealed class PBGAOHHEJNM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public FDJAEGMFNOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public PBGAOHHEJNM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x27E3150", Offset = "0x27E1F50", VA = "0x1827E3150")]
			internal bool FJHHLNJDEMC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x27E31D0", Offset = "0x27E1FD0", VA = "0x1827E31D0")]
			internal void HEMECHNNCID(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x27CD460", Offset = "0x27CC260", VA = "0x1827CD460")]
		public FDJAEGMFNOO(HBDCLDOGDAK PINKMLPHMFP, LDFAABCOMKP OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x27CD210", Offset = "0x27CC010", VA = "0x1827CD210", Slot = "145")]
		protected override void LCCIBEHDPDA(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class ENPMJNHHBCJ : JNPIGLGCIPN<NDMBGAJCNJG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xBFF4C0", Offset = "0xBFE2C0", VA = "0x180BFF4C0", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x27CCBA0", Offset = "0x27CB9A0", VA = "0x1827CCBA0")]
		public ENPMJNHHBCJ(HBDCLDOGDAK PINKMLPHMFP, NDMBGAJCNJG BINEDJHADMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public abstract class JNPIGLGCIPN<TNode> : JGGDCGDPDJF<TNode> where TNode : notnull, AILDKPJAILE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct PCOCAMLAKID : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public AsyncTaskMethodBuilder<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public JNPIGLGCIPN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private TaskAwaiter<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x576EE70", Offset = "0x576DC70", VA = "0x18576EE70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x576F320", Offset = "0x576E120", VA = "0x18576F320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct ABOLADJEINF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public JNPIGLGCIPN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public BIHBDMOHDCK<NGIHDDPPPGJ> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x4B9A120", Offset = "0x4B98F20", VA = "0x184B9A120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x4B9A5A0", Offset = "0x4B993A0", VA = "0x184B9A5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private struct GAMPHBNBPAE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public AsyncTaskMethodBuilder<JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public JNPIGLGCIPN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			private TaskAwaiter<JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x4B7CD80", Offset = "0x4B7BB80", VA = "0x184B7CD80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x4B7D430", Offset = "0x4B7C230", VA = "0x184B7D430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class NDAJABDKAKB
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
				public NDAJABDKAKB <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000174")]
				[Cpp2IlInjected.Address(RVA = "0x41924C0", Offset = "0x41912C0", VA = "0x1841924C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000175")]
				[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public GAICGLBGHPP configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public JNPIGLGCIPN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public Func<string, bool> <>9__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public Action <>9__7;

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public NDAJABDKAKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x547A9C0", Offset = "0x54797C0", VA = "0x18547A9C0")]
			internal bool FJHLHGPGNHI(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x547A2F0", Offset = "0x54790F0", VA = "0x18547A2F0")]
			internal void EFLKMKJKNFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x547AAA0", Offset = "0x54798A0", VA = "0x18547AAA0")]
			[AsyncStateMachine(typeof(JNPIGLGCIPN<>.NDAJABDKAKB.<<BuildConfigMenuInternal>b__7>d))]
			internal void NAJEIOOLNDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x547A5D0", Offset = "0x54793D0", VA = "0x18547A5D0")]
			internal bool FIPGNDKIHPC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private sealed class CLLABMJPDMG
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
				public CLLABMJPDMG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				private TaskAwaiter<TaskStatus> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600017B")]
				[Cpp2IlInjected.Address(RVA = "0x4192150", Offset = "0x4190F50", VA = "0x184192150", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600017C")]
				[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
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
			public NDAJABDKAKB CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public CLLABMJPDMG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x6713FE0", Offset = "0x6712DE0", VA = "0x186713FE0")]
			internal void AFGCMBEJMPG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			internal string PFIBKFEAIBF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
			internal void LFNJACLOFOJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x6714400", Offset = "0x6713200", VA = "0x186714400")]
			[AsyncStateMachine(typeof(JNPIGLGCIPN<>.CLLABMJPDMG.<<BuildConfigMenuInternal>b__5>d))]
			internal void EALAMANBNEJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class JFFCCKBHBOI
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
				public JFFCCKBHBOI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				private TaskAwaiter<TaskStatus> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000190")]
				[Cpp2IlInjected.Address(RVA = "0x4191050", Offset = "0x418FE50", VA = "0x184191050", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
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
				public JFFCCKBHBOI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				private TaskAwaiter<JKEBLLKKBOM<BIHBDMOHDCK<JAIKLOFJOLF>, CHEIGOJMDOJ>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000192")]
				[Cpp2IlInjected.Address(RVA = "0x4191230", Offset = "0x4190030", VA = "0x184191230", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000193")]
				[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
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
				public JFFCCKBHBOI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				private TaskAwaiter<JKEBLLKKBOM<BIHBDMOHDCK<OHFDADNMMNM>, CHEIGOJMDOJ>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000194")]
				[Cpp2IlInjected.Address(RVA = "0x4190990", Offset = "0x418F790", VA = "0x184190990", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000195")]
				[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public JNPIGLGCIPN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public BIHBDMOHDCK<NGIHDDPPPGJ> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public GAICGLBGHPP configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public FMANJMOJBNB nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public int minGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public int maxGroupIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public EDIKHIAMCFO selectedInputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public string newInputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public List<FLAPIMNJADP> inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public EDIKHIAMCFO selectedOutputType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public string newOutputFieldLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public List<FLAPIMNJADP> outputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public Func<string, bool> <>9__17;

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public JFFCCKBHBOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4FA48E0", Offset = "0x4FA36E0", VA = "0x184FA48E0")]
			internal bool EGLFKFHMLMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x4FA46D0", Offset = "0x4FA34D0", VA = "0x184FA46D0")]
			internal void BCICEABFAKP(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4A00", Offset = "0x4FA3800", VA = "0x184FA4A00")]
			internal bool HHKLMCMCHIO(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4690", Offset = "0x4FA3490", VA = "0x184FA4690")]
			internal bool BCBOAIHLCPB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4D70", Offset = "0x4FA3B70", VA = "0x184FA4D70")]
			[AsyncStateMachine(typeof(JNPIGLGCIPN<>.JFFCCKBHBOI.<<AddDynamicNodeGroupSettingV2>b__2>d))]
			internal void NPAJDHKOFIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4E80", Offset = "0x4FA3C80", VA = "0x184FA4E80")]
			internal bool PFEOMKHHNNC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4BB0", Offset = "0x4FA39B0", VA = "0x184FA4BB0")]
			internal void KJKCKEGCINN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4F60", Offset = "0x4FA3D60", VA = "0x184FA4F60")]
			internal bool POAPLJFGBCE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4740", Offset = "0x4FA3540", VA = "0x184FA4740")]
			internal void BIKDNKHMBPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4950", Offset = "0x4FA3750", VA = "0x184FA4950")]
			internal bool EMPBABKCPBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4B40", Offset = "0x4FA3940", VA = "0x184FA4B40")]
			internal bool JMMJPEGIOMP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4800", Offset = "0x4FA3600", VA = "0x184FA4800")]
			internal void CMPNDFBEKMA(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4EC0", Offset = "0x4FA3CC0", VA = "0x184FA4EC0")]
			[AsyncStateMachine(typeof(JNPIGLGCIPN<>.JFFCCKBHBOI.<<AddDynamicNodeGroupSettingV2>b__6>d))]
			internal void PJOJICACACG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4C70", Offset = "0x4FA3A70", VA = "0x184FA4C70")]
			internal bool LLOCJOOLMDD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4870", Offset = "0x4FA3670", VA = "0x184FA4870")]
			internal bool DLCCIHBKGPH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4E10", Offset = "0x4FA3C10", VA = "0x184FA4E10")]
			internal void OMMPALDAEND(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4CD0", Offset = "0x4FA3AD0", VA = "0x184FA4CD0")]
			[AsyncStateMachine(typeof(JNPIGLGCIPN<>.JFFCCKBHBOI.<<AddDynamicNodeGroupSettingV2>b__10>d))]
			internal void LNNHBBOHGLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x4FA4AE0", Offset = "0x4FA38E0", VA = "0x184FA4AE0")]
			internal bool HPNALIJGLLL()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class HIPDEOHDPKD
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
				public HIPDEOHDPKD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x4190C80", Offset = "0x418FA80", VA = "0x184190C80", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
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
			public JFFCCKBHBOI CS$<>8__locals1;

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
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public HIPDEOHDPKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x4C30ED0", Offset = "0x4C2FCD0", VA = "0x184C30ED0")]
			internal void ICOOAPHACKH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			internal string PPADJGDGCCL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
			internal void NMDMMACDGDF(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x4C30E30", Offset = "0x4C2FC30", VA = "0x184C30E30")]
			[AsyncStateMachine(typeof(JNPIGLGCIPN<>.HIPDEOHDPKD.<<AddDynamicNodeGroupSettingV2>b__16>d))]
			internal void COFFEAIBCFK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class NLOECIMMGKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public FMANJMOJBNB nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public List<FLAPIMNJADP> portMenu;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public JNPIGLGCIPN<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public BIHBDMOHDCK<NGIHDDPPPGJ> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public int portCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public Func<bool> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public NLOECIMMGKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x54DFF90", Offset = "0x54DED90", VA = "0x1854DFF90")]
			internal bool LOCCPBMBLBG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class DHAIOOMCJNA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public GFPDJMBDKEG port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public NLOECIMMGKA CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public DHAIOOMCJNA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x6B11AE0", Offset = "0x6B108E0", VA = "0x186B11AE0")]
			internal void PEHGFGDPMNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x6B11970", Offset = "0x6B10770", VA = "0x186B11970")]
			internal bool CELIPCJPMBA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x6B119C0", Offset = "0x6B107C0", VA = "0x186B119C0")]
			internal void EBPPFHDEFHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x6B11BF0", Offset = "0x6B109F0", VA = "0x186B11BF0")]
			internal bool PMBKEGBODNJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private sealed class MCDIBKLIOJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public FLAPIMNJADP portControls;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public DHAIOOMCJNA CS$<>8__locals2;

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public MCDIBKLIOJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x539A620", Offset = "0x5399420", VA = "0x18539A620")]
			internal void EADIFPPMILO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class CJKPKJCPDEG
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
				public CJKPKJCPDEG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x4193900", Offset = "0x4192700", VA = "0x184193900", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
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
			public EDIKHIAMCFO selectedType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public bool inputs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public FMANJMOJBNB nodeGroupAdapter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public GFPDJMBDKEG port;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public CJKPKJCPDEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x6639490", Offset = "0x6638290", VA = "0x186639490")]
			internal int GBLMGDKBJPO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x66395B0", Offset = "0x66383B0", VA = "0x1866395B0")]
			internal void JJELOIMBPOA(int val)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0")]
			internal string KIFAECCNDKL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x66397F0", Offset = "0x66385F0", VA = "0x1866397F0")]
			[AsyncStateMachine(typeof(JNPIGLGCIPN<>.CJKPKJCPDEG.<<CreatePortItemV2>b__3>d))]
			internal void OCPNCEGJHKJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x66394D0", Offset = "0x66382D0", VA = "0x1866394D0")]
			internal bool ICHKJDPIPOJ(string text)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly Dictionary<BIHBDMOHDCK<NGIHDDPPPGJ>, bool> NJJPMJOMOJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<BIHBDMOHDCK<NGIHDDPPPGJ>, bool> FCNOPEDBPGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly Dictionary<BIHBDMOHDCK<NGIHDDPPPGJ>, bool> LJPDNKDACJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private Dictionary<BIHBDMOHDCK<NGIHDDPPPGJ>, bool> LLLEIBOFAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private Dictionary<BIHBDMOHDCK<NGIHDDPPPGJ>, bool> BJINJNMCNGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private Dictionary<BIHBDMOHDCK<NGIHDDPPPGJ>, bool> OGAFLKJMOLI;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override bool NJNLOMGBJNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected virtual bool COELOEOKBMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "145")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected virtual bool KHELKLDMBII
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "146")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected virtual bool EODFOOEGLDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "147")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override BIHBDMOHDCK<HJIDLNADIFB>? ODKJPMNDPID
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x4FDBA90", Offset = "0x4FDA890", VA = "0x184FDBA90", Slot = "135")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override BIHBDMOHDCK<NGIHDDPPPGJ>? HJDMGJFMKDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x4FDBD40", Offset = "0x4FDAB40", VA = "0x184FDBD40", Slot = "138")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override IEnumerable<KOIDEEJEAKA<KCAEAGPDLDO>>? KAAAGJLLLHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x4FDBB40", Offset = "0x4FDA940", VA = "0x184FDBB40", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4FDB870", Offset = "0x4FDA670", VA = "0x184FDB870")]
		public JNPIGLGCIPN(HBDCLDOGDAK PINKMLPHMFP, TNode BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "148")]
		protected virtual bool FIKFOALGIAF(int IPKEIAADHLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "149")]
		protected virtual bool BCICEIMCHGJ(int IPKEIAADHLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "150")]
		protected virtual bool MFGNCMCEKPG(int IPKEIAADHLB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "151")]
		protected virtual void ACLCAJJMCNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4FD8380", Offset = "0x4FD7180", VA = "0x184FD8380", Slot = "143")]
		public override bool INCDOMMKFLD(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4FDA4D0", Offset = "0x4FD92D0", VA = "0x184FDA4D0", Slot = "119")]
		[AsyncStateMachine(typeof(JNPIGLGCIPN<>.PCOCAMLAKID))]
		public override Task<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> MDAOIMHMFGD(string IHGFMOMOADA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x4FDB4C0", Offset = "0x4FDA2C0", VA = "0x184FDB4C0", Slot = "120")]
		[AsyncStateMachine(typeof(JNPIGLGCIPN<>.ABOLADJEINF))]
		public override Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> PHBNFECMAIJ(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4FD8140", Offset = "0x4FD6F40", VA = "0x184FD8140", Slot = "121")]
		public override void FANCJHAHEBG(BIHBDMOHDCK<NGIHDDPPPGJ> GLAOLHCPLLG, BIHBDMOHDCK<NGIHDDPPPGJ> GDCDKMJLKDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x4FDB060", Offset = "0x4FD9E60", VA = "0x184FDB060", Slot = "122")]
		public override IEnumerable<CMGFJHDBEGO> OJPHANJHCOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x4FD6F10", Offset = "0x4FD5D10", VA = "0x184FD6F10")]
		[AsyncStateMachine(typeof(JNPIGLGCIPN<>.GAMPHBNBPAE))]
		private Task<JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ>> AOAMFNPCIMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "152")]
		protected virtual bool FGAAHLICEAI(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "153")]
		protected virtual bool NELOKPMLMGN(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "154")]
		protected virtual bool PHAMGPBIGNO(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "155")]
		protected virtual bool GPKOIOJNCEI(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "156")]
		protected virtual bool CCNPAMPDKMF(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, int KHOAILLNFIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "157")]
		protected virtual bool HDJHCMFAEFK(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, int KHOAILLNFIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "158")]
		protected virtual bool DOEGCFIDFJG(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, int HFHDMONAHIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "159")]
		protected virtual bool ALANLBLMNKC(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, int HFHDMONAHIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "160")]
		protected virtual bool OFGFHCAOGHJ(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, int NDLHLMPDBHK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "161")]
		protected virtual bool GEFLKPBPHDK(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, int DLHBKKAFANL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4FDB5D0", Offset = "0x4FDA3D0", VA = "0x184FDB5D0", Slot = "162")]
		protected virtual List<EDIKHIAMCFO> PLLPPJEAKLF(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "163")]
		protected virtual void EGHHHOEAMAE(GAICGLBGHPP KOIAEEPOACG, OJLEADLAKJA AOBDHGHCMEH, FMANJMOJBNB GDDAFNLPAKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4FDA5F0", Offset = "0x4FD93F0", VA = "0x184FDA5F0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4FD8420", Offset = "0x4FD7220", VA = "0x184FD8420")]
		private OJLEADLAKJA KFMDJGBONOJ(GAICGLBGHPP KOIAEEPOACG, FMANJMOJBNB GDDAFNLPAKL, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4FD7010", Offset = "0x4FD5E10", VA = "0x184FD7010")]
		private List<FLAPIMNJADP> CNEGEJAMDKG(GAICGLBGHPP KOIAEEPOACG, FMANJMOJBNB GDDAFNLPAKL, OJLEADLAKJA CGJIAPBDFDP, bool GILAMIHEIIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x4FD9B80", Offset = "0x4FD8980", VA = "0x184FD9B80")]
		private List<FLAPIMNJADP> MAJAJKNFPJM(GAICGLBGHPP KOIAEEPOACG, FMANJMOJBNB GDDAFNLPAKL, GFPDJMBDKEG MEEODCLEJBF, bool GILAMIHEIIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x4FDB2D0", Offset = "0x4FDA0D0", VA = "0x184FDB2D0")]
		private EDIKHIAMCFO OODCCCKDEEL(List<EDIKHIAMCFO> NHFHGLDLECD, GFPDJMBDKEG MEEODCLEJBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4FD82F0", Offset = "0x4FD70F0", VA = "0x184FD82F0")]
		[CompilerGenerated]
		private CMGFJHDBEGO IFCHNKJKKKF(ANKFKDANALM CPKBMDHHFLH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class LECDGIOICGE : JGGDCGDPDJF<LONIMONDJNA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class PHOKMOPJKHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public LECDGIOICGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public PHOKMOPJKHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x27E3B40", Offset = "0x27E2940", VA = "0x1827E3B40")]
			internal int EFLKMKJKNFL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x27E3B90", Offset = "0x27E2990", VA = "0x1827E3B90")]
			internal void FIPGNDKIHPC(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x1112120", Offset = "0x1110F20", VA = "0x181112120", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x27D28A0", Offset = "0x27D16A0", VA = "0x1827D28A0")]
		public LECDGIOICGE(HBDCLDOGDAK PINKMLPHMFP, LONIMONDJNA BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x27D26E0", Offset = "0x27D14E0", VA = "0x1827D26E0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public sealed class LKGNPMDNOEE : NLMHFLCMFOO<BHCLJICBNMP>
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class IBLNPJDFPKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public LKGNPMDNOEE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public IBLNPJDFPKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x27CFF50", Offset = "0x27CED50", VA = "0x1827CFF50")]
			internal int FJHHLNJDEMC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x27CFFD0", Offset = "0x27CEDD0", VA = "0x1827CFFD0")]
			internal void HEMECHNNCID(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x27D3A70", Offset = "0x27D2870", VA = "0x1827D3A70")]
		public LKGNPMDNOEE(HBDCLDOGDAK PINKMLPHMFP, BHCLJICBNMP OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x27D3830", Offset = "0x27D2630", VA = "0x1827D3830", Slot = "145")]
		protected override void LCCIBEHDPDA(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private sealed class JEKKJNHNPJC : JGGDCGDPDJF<IDPFMJPIAHJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0xDC9EC0", Offset = "0xDC8CC0", VA = "0x180DC9EC0", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x27D0470", Offset = "0x27CF270", VA = "0x1827D0470")]
		public JEKKJNHNPJC(HBDCLDOGDAK PINKMLPHMFP, IDPFMJPIAHJ BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class OGNLPDLNBBM : JGGDCGDPDJF<OKANLBKPGIK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class NFJHOMIDDKF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			public OGNLPDLNBBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public GAICGLBGHPP configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public Func<string> <>9__221;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			public Action<string> <>9__222;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public Func<int> <>9__225;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public Action<int> <>9__226;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public Func<bool> <>9__227;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public Func<bool> <>9__228;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			public Func<bool> <>9__229;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public Func<float> <>9__230;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public Action<float> <>9__231;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public Func<bool> <>9__232;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public Func<bool> <>9__233;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			public Func<bool> <>9__234;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			public Func<string> <>9__235;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public Action<string> <>9__236;

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public NFJHOMIDDKF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x27DBDE0", Offset = "0x27DABE0", VA = "0x1827DBDE0")]
			internal bool EFLKMKJKNFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x27DC400", Offset = "0x27DB200", VA = "0x1827DC400")]
			internal void FIPGNDKIHPC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x27DDE80", Offset = "0x27DCC80", VA = "0x1827DDE80")]
			internal bool LFNJACLOFOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x27D5BB0", Offset = "0x27D49B0", VA = "0x1827D5BB0")]
			internal bool EALAMANBNEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x27DC460", Offset = "0x27DB260", VA = "0x1827DC460")]
			internal void FJHLHGPGNHI(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x27DF340", Offset = "0x27DE140", VA = "0x1827DF340")]
			internal bool PGAMBGNPPKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x27DC4C0", Offset = "0x27DB2C0", VA = "0x1827DC4C0")]
			internal bool FKBEOICIIDP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x27DE2A0", Offset = "0x27DD0A0", VA = "0x1827DE2A0")]
			internal void MEOIMAMNIEO(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x27DEDC0", Offset = "0x27DDBC0", VA = "0x1827DEDC0")]
			internal bool ODGJCALBGBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x27DEBC0", Offset = "0x27DD9C0", VA = "0x1827DEBC0")]
			internal bool NKCBDCAEDNF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x27DE9D0", Offset = "0x27DD7D0", VA = "0x1827DE9D0")]
			internal void NANNDMKINFL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x27D4920", Offset = "0x27D3720", VA = "0x1827D4920")]
			internal bool AEKPLKFGPKI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x27DECB0", Offset = "0x27DDAB0", VA = "0x1827DECB0")]
			internal bool OAAOMCLFJHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x27DEC10", Offset = "0x27DDA10", VA = "0x1827DEC10")]
			internal bool NLIGELNFCEC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x27DEC60", Offset = "0x27DDA60", VA = "0x1827DEC60")]
			internal bool NLJNECAOEFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x27DD330", Offset = "0x27DC130", VA = "0x1827DD330")]
			internal bool IDCLBPJPFAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x27DDED0", Offset = "0x27DCCD0", VA = "0x1827DDED0")]
			internal bool LGAOPHIFCPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x27DD4E0", Offset = "0x27DC2E0", VA = "0x1827DD4E0")]
			internal bool ILOJKJCIEDM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x27DE250", Offset = "0x27DD050", VA = "0x1827DE250")]
			internal bool MDOBKMDGCPC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x27D4B00", Offset = "0x27D3900", VA = "0x1827D4B00")]
			internal void AJJCCJCIAGB(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x27D4970", Offset = "0x27D3770", VA = "0x1827D4970")]
			internal bool AEMCBEBHOCP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x27D54D0", Offset = "0x27D42D0", VA = "0x1827D54D0")]
			internal bool BNOJHAIFBAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x27D5290", Offset = "0x27D4090", VA = "0x1827D5290")]
			internal bool BGIKDGMMNKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x27D51F0", Offset = "0x27D3FF0", VA = "0x1827D51F0")]
			internal bool BGCPGDGBGLD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x27DBE30", Offset = "0x27DAC30", VA = "0x1827DBE30")]
			internal bool EJJNBMFODOO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x27DC560", Offset = "0x27DB360", VA = "0x1827DC560")]
			internal bool FKDAFNIGOAP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x27D5430", Offset = "0x27D4230", VA = "0x1827D5430")]
			internal bool BJCALIMHEFF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x27DD750", Offset = "0x27DC550", VA = "0x1827DD750")]
			internal void JODACLAANHC(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x27DEF00", Offset = "0x27DDD00", VA = "0x1827DEF00")]
			internal bool OJGMIIIEKNK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x27DCCB0", Offset = "0x27DBAB0", VA = "0x1827DCCB0")]
			internal bool HAPKJBDMEIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x27DD190", Offset = "0x27DBF90", VA = "0x1827DD190")]
			internal void HPFBJNBDBAF(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x27DF190", Offset = "0x27DDF90", VA = "0x1827DF190")]
			internal bool PCFMECFINLC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x27D59D0", Offset = "0x27D47D0", VA = "0x1827D59D0")]
			internal bool DKFMOPPEFFG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x27DCDA0", Offset = "0x27DBBA0", VA = "0x1827DCDA0")]
			internal void HEBJLHDHJIL(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x27D5C00", Offset = "0x27D4A00", VA = "0x1827D5C00")]
			internal List<FLAPIMNJADP> EBBHOOIECKP(string secondaryLabel)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x27D5AC0", Offset = "0x27D48C0", VA = "0x1827D5AC0")]
			internal bool DNFPNBLPMOC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x27DF4C0", Offset = "0x27DE2C0", VA = "0x1827DF4C0")]
			internal int PMMPGHACFPB()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x27DCFF0", Offset = "0x27DBDF0", VA = "0x1827DCFF0")]
			internal void HMBDCLKFNFN(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x27D5330", Offset = "0x27D4130", VA = "0x1827D5330")]
			internal bool BHMFOHMIHKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x27D5570", Offset = "0x27D4370", VA = "0x1827D5570")]
			internal bool BPIEGCFJIHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x27DCF00", Offset = "0x27DBD00", VA = "0x1827DCF00")]
			internal bool HHOKHCFINFB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x27DDF90", Offset = "0x27DCD90", VA = "0x1827DDF90")]
			internal int LIFBMGGNDGH()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x27DE370", Offset = "0x27DD170", VA = "0x1827DE370")]
			internal void MHEDDDMAJFL(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x27DEB20", Offset = "0x27DD920", VA = "0x1827DEB20")]
			internal bool NDNPNILCFGM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x27DD850", Offset = "0x27DC650", VA = "0x1827DD850")]
			internal bool KIBLENMELFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x27DDCA0", Offset = "0x27DCAA0", VA = "0x1827DDCA0")]
			internal bool KOKPONIGMDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x27DC830", Offset = "0x27DB630", VA = "0x1827DC830")]
			internal bool GBCFGGCJJKO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x27DC070", Offset = "0x27DAE70", VA = "0x1827DC070")]
			internal bool FBJMOMBJPJK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x27D5840", Offset = "0x27D4640", VA = "0x1827D5840")]
			internal string CMPBMAHLNKF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x27DD8A0", Offset = "0x27DC6A0", VA = "0x1827DD8A0")]
			internal void KIIFOABGMFD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0x27DCFA0", Offset = "0x27DBDA0", VA = "0x1827DCFA0")]
			internal int HJGBBOFDELK()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x27DDC40", Offset = "0x27DCA40", VA = "0x1827DDC40")]
			internal void KOGFBNFOELM(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x27DE6B0", Offset = "0x27DD4B0", VA = "0x1827DE6B0")]
			internal bool MOFMBMPIEMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x27DEA80", Offset = "0x27DD880", VA = "0x1827DEA80")]
			internal bool NBPIPGBGEBK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x27DD2E0", Offset = "0x27DC0E0", VA = "0x1827DD2E0")]
			internal bool IDCBAJHJLMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x27DC310", Offset = "0x27DB110", VA = "0x1827DC310")]
			internal float FFCAHBCBJNG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x27DDFE0", Offset = "0x27DCDE0", VA = "0x1827DDFE0")]
			internal void LIKJGDGNAAO(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x27DCA90", Offset = "0x27DB890", VA = "0x1827DCA90")]
			internal bool GNEHFPAENMH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x27D4AB0", Offset = "0x27D38B0", VA = "0x1827D4AB0")]
			internal bool AJJAKDMNPEB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x27DD910", Offset = "0x27DC710", VA = "0x1827DD910")]
			internal bool KJNHHGLPHOF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x27D52E0", Offset = "0x27D40E0", VA = "0x1827D52E0")]
			internal bool BHDKOGEPOIC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x27DCA40", Offset = "0x27DB840", VA = "0x1827DCA40")]
			internal bool GMPJBCPCAOA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x27DF1E0", Offset = "0x27DDFE0", VA = "0x1827DF1E0")]
			internal bool PCJPLDALMCJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x27D4BB0", Offset = "0x27D39B0", VA = "0x1827D4BB0")]
			internal void AMEBMFFJMHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x27DCD50", Offset = "0x27DBB50", VA = "0x1827DCD50")]
			internal string HDDINNHOJJL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x27DC880", Offset = "0x27DB680", VA = "0x1827DC880")]
			internal void GCKPAFOBILH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x27DD240", Offset = "0x27DC040", VA = "0x1827DD240")]
			internal bool IBCODLLBKCK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x27D5380", Offset = "0x27D4180", VA = "0x1827D5380")]
			internal bool BICPABBGCBH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x27DF000", Offset = "0x27DDE00", VA = "0x1827DF000")]
			internal bool OKJKOHDKBCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x27DE700", Offset = "0x27DD500", VA = "0x1827DE700")]
			internal void NACBAGPDENM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x27DF050", Offset = "0x27DDE50", VA = "0x1827DF050")]
			internal bool OKODOEDHBNL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x27DEA30", Offset = "0x27DD830", VA = "0x1827DEA30")]
			internal bool NBDAOOALEIE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x27DD7B0", Offset = "0x27DC5B0", VA = "0x1827DD7B0")]
			internal bool KADDKIDEFLB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x27DC980", Offset = "0x27DB780", VA = "0x1827DC980")]
			internal bool GHGDJJOPPDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x27DBED0", Offset = "0x27DACD0", VA = "0x1827DBED0")]
			internal void EMGDMEHHOAK(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x27DBF30", Offset = "0x27DAD30", VA = "0x1827DBF30")]
			internal bool EMLAOMABBPI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x27D5520", Offset = "0x27D4320", VA = "0x1827D5520")]
			internal bool BOCACKGAPHC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x27DC270", Offset = "0x27DB070", VA = "0x1827DC270")]
			internal bool FDLNNMALCOL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x27DE4C0", Offset = "0x27DD2C0", VA = "0x1827DE4C0")]
			internal bool MJNCAJMIDGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x27D53D0", Offset = "0x27D41D0", VA = "0x1827D53D0")]
			internal void BJAPFBDJOIA(bool x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x27D5930", Offset = "0x27D4730", VA = "0x1827D5930")]
			internal bool DHHHPNHECAK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x27DEAD0", Offset = "0x27DD8D0", VA = "0x1827DEAD0")]
			internal bool NDFIMADBJLD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x27DC130", Offset = "0x27DAF30", VA = "0x1827DC130")]
			internal bool FCANANPFOMK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x27DC640", Offset = "0x27DB440", VA = "0x1827DC640")]
			internal bool FMKDPDCAGLG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x27DC9D0", Offset = "0x27DB7D0", VA = "0x1827DC9D0")]
			internal object GJNPELHHPGG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x27DC750", Offset = "0x27DB550", VA = "0x1827DC750")]
			internal void FOKEMHNPLGM(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x27DCB50", Offset = "0x27DB950", VA = "0x1827DCB50")]
			internal bool GPHIGICCOMJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x27DD140", Offset = "0x27DBF40", VA = "0x1827DD140")]
			internal bool HPDDHKKOLAD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x27DC020", Offset = "0x27DAE20", VA = "0x1827DC020")]
			internal int FBGBLCEINIF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x27DCC00", Offset = "0x27DBA00", VA = "0x1827DCC00")]
			internal void HAGEGBGCFJE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x27D57A0", Offset = "0x27D45A0", VA = "0x1827D57A0")]
			internal bool CIKFPJHFPGO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x27DC180", Offset = "0x27DAF80", VA = "0x1827DC180")]
			internal bool FCLEKCAMNEP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x27DE040", Offset = "0x27DCE40", VA = "0x1827DE040")]
			internal int LINFHJAEAAF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x27DDB90", Offset = "0x27DC990", VA = "0x1827DDB90")]
			internal void KMIJFOHDMKF(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x27DD380", Offset = "0x27DC180", VA = "0x1827DD380")]
			internal bool IDNGNGLJMEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x27DF0F0", Offset = "0x27DDEF0", VA = "0x1827DF0F0")]
			internal bool ONPMOKCMHPE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x27DC220", Offset = "0x27DB020", VA = "0x1827DC220")]
			internal bool FDIFBGIPHAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x27D4B60", Offset = "0x27D3960", VA = "0x1827D4B60")]
			internal int AKNJPAJGMGD()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x27DBCE0", Offset = "0x27DAAE0", VA = "0x1827DBCE0")]
			internal void EBBMBMDPABG(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x27D48D0", Offset = "0x27D36D0", VA = "0x1827D48D0")]
			internal bool AEKCGNPECIG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x27DCEB0", Offset = "0x27DBCB0", VA = "0x1827DCEB0")]
			internal bool HFJJHOAJKLA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x27DC2C0", Offset = "0x27DB0C0", VA = "0x1827DC2C0")]
			internal bool FDPBJAOGDBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x27DE300", Offset = "0x27DD100", VA = "0x1827DE300")]
			internal object MFADMJEKFPC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x27DC5B0", Offset = "0x27DB3B0", VA = "0x1827DC5B0")]
			internal void FKGEGPIAMEL(object x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x27DE560", Offset = "0x27DD360", VA = "0x1827DE560")]
			internal bool MLEDKNJBFCD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x27D49C0", Offset = "0x27D37C0", VA = "0x1827D49C0")]
			internal bool AFCOPJKIMEL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x27DD960", Offset = "0x27DC760", VA = "0x1827DD960")]
			internal object? KLBHKJDICOK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x27DC8F0", Offset = "0x27DB6F0", VA = "0x1827DC8F0")]
			internal void GGMNKAILCLO(object? x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x27DE420", Offset = "0x27DD220", VA = "0x1827DE420")]
			internal bool MHKFGFPODFH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x27D5480", Offset = "0x27D4280", VA = "0x1827D5480")]
			internal int BJEAEMGPFDI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x27DE600", Offset = "0x27DD400", VA = "0x1827DE600")]
			internal void MMJHJFNDADH(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x27D5750", Offset = "0x27D4550", VA = "0x1827D5750")]
			internal bool CHCKHEGNLEE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x27DBD90", Offset = "0x27DAB90", VA = "0x1827DBD90")]
			internal bool EFDHHCHECBI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x27D5060", Offset = "0x27D3E60", VA = "0x1827D5060")]
			internal bool BACEEJNFFHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x27DBF80", Offset = "0x27DAD80", VA = "0x1827DBF80")]
			internal int ENENABIPEGF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x27DDA90", Offset = "0x27DC890", VA = "0x1827DDA90")]
			internal void KLPMMFMHMDP(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x27D58E0", Offset = "0x27D46E0", VA = "0x1827D58E0")]
			internal bool DEJAGGPHLJH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x27DED70", Offset = "0x27DDB70", VA = "0x1827DED70")]
			internal bool ODAHAMLIBJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x27DD0A0", Offset = "0x27DBEA0", VA = "0x1827DD0A0")]
			internal bool HOPMKNLKNBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x27D5B60", Offset = "0x27D4960", VA = "0x1827D5B60")]
			internal float DOHMJFAIJFP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x27DCBA0", Offset = "0x27DB9A0", VA = "0x1827DCBA0")]
			internal void GPNPGLMLGDC(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x27DF2F0", Offset = "0x27DE0F0", VA = "0x1827DF2F0")]
			internal bool PEPLAINFKKN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x27DF510", Offset = "0x27DE310", VA = "0x1827DF510")]
			internal bool PODFMPOMKMG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x27DC690", Offset = "0x27DB490", VA = "0x1827DC690")]
			internal bool FMNMPHNLGLJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x27D5890", Offset = "0x27D4690", VA = "0x1827D5890")]
			internal float CNIKGEEMALG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x27DCE50", Offset = "0x27DBC50", VA = "0x1827DCE50")]
			internal void HFENJDOMNFA(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x27D4830", Offset = "0x27D3630", VA = "0x1827D4830")]
			internal bool ABBFMAMIMAH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x27D5700", Offset = "0x27D4500", VA = "0x1827D5700")]
			internal bool CGPMMMMLCOK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x27D51A0", Offset = "0x27D3FA0", VA = "0x1827D51A0")]
			internal string BDJJKELNHHJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x27DF280", Offset = "0x27DE080", VA = "0x1827DF280")]
			internal void PDBNEJLKKEG(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x27DBFD0", Offset = "0x27DADD0", VA = "0x1827DBFD0")]
			internal bool FAKGBMPKPJL(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x27D50B0", Offset = "0x27D3EB0", VA = "0x1827D50B0")]
			internal bool BBJLGKBMNII()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x27D5A70", Offset = "0x27D4870", VA = "0x1827D5A70")]
			internal bool DMHLCHPDHAJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x27D5610", Offset = "0x27D4410", VA = "0x1827D5610")]
			internal bool CAEGGEANBJF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x27D57F0", Offset = "0x27D45F0", VA = "0x1827D57F0")]
			internal string CJOKCHLHJMP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x27DC0C0", Offset = "0x27DAEC0", VA = "0x1827DC0C0")]
			internal void FBPIKABJJGD(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x27DE510", Offset = "0x27DD310", VA = "0x1827DE510")]
			internal bool MLCBPEFIKCJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x27DF140", Offset = "0x27DDF40", VA = "0x1827DF140")]
			internal bool PBOOGFCKEFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x27DC510", Offset = "0x27DB310", VA = "0x1827DC510")]
			internal bool FKBIAMBBHJI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x27D4A10", Offset = "0x27D3810", VA = "0x1827D4A10")]
			internal bool AFGPNADJBKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x27DD440", Offset = "0x27DC240", VA = "0x1827DD440")]
			internal string IJACPLGOKFE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x27DD3D0", Offset = "0x27DC1D0", VA = "0x1827DD3D0")]
			internal void IGPACMKDJEL(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x27DE200", Offset = "0x27DD000", VA = "0x1827DE200")]
			internal bool MDLCPHGOLNC(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x27DC3B0", Offset = "0x27DB1B0", VA = "0x1827DC3B0")]
			internal bool FHLHKFNEDOC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x27DD530", Offset = "0x27DC330", VA = "0x1827DD530")]
			internal bool IMAKLFKIABF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x27D55C0", Offset = "0x27D43C0", VA = "0x1827D55C0")]
			internal bool BPJAFNOFLPK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x27DE100", Offset = "0x27DCF00", VA = "0x1827DE100")]
			internal string LMACLFHHMII()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x27DED00", Offset = "0x27DDB00", VA = "0x1827DED00")]
			internal void OAHLBALOMII(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x27DDAF0", Offset = "0x27DC8F0", VA = "0x1827DDAF0")]
			internal bool KMAJOEMOLEJ(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x27DEE10", Offset = "0x27DDC10", VA = "0x1827DEE10")]
			internal bool OENCCADNMGH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x27DDD40", Offset = "0x27DCB40", VA = "0x1827DDD40")]
			internal bool LCBCBCEBGIP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x27DEEB0", Offset = "0x27DDCB0", VA = "0x1827DEEB0")]
			internal bool OIHFCFMKGEG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x27D5B10", Offset = "0x27D4910", VA = "0x1827D5B10")]
			internal string DODIHNHHAIA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x27DCAE0", Offset = "0x27DB8E0", VA = "0x1827DCAE0")]
			internal void GOAFJPMNPGH(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x27DEB70", Offset = "0x27DD970", VA = "0x1827DEB70")]
			internal bool NJMPHOJEGAI(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x27D56B0", Offset = "0x27D44B0", VA = "0x1827D56B0")]
			internal bool CBPLKFPEPCA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x27DDB40", Offset = "0x27DC940", VA = "0x1827DDB40")]
			internal bool KMEEJKFCLGA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x27DF0A0", Offset = "0x27DDEA0", VA = "0x1827DF0A0")]
			internal bool ONAMPACCBDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x27D5660", Offset = "0x27D4460", VA = "0x1827D5660")]
			internal string CBKHNPNCBPM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x27DDF20", Offset = "0x27DCD20", VA = "0x1827DDF20")]
			internal void LGDFIJCEEEE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x27DD1F0", Offset = "0x27DBFF0", VA = "0x1827DD1F0")]
			internal bool IADNNNPNJHG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x27DDDE0", Offset = "0x27DCBE0", VA = "0x1827DDDE0")]
			internal bool LEGLEDCEIHD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x27DE470", Offset = "0x27DD270", VA = "0x1827DE470")]
			internal bool MHPMLAABEAO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x27DD800", Offset = "0x27DC600", VA = "0x1827DD800")]
			internal bool KGKEICFCDND()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x27D5100", Offset = "0x27D3F00", VA = "0x1827D5100")]
			internal string BCCGNDBIOLD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x27DF390", Offset = "0x27DE190", VA = "0x1827DF390")]
			internal void PHEENJNKAHJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x27D4A60", Offset = "0x27D3860", VA = "0x1827D4A60")]
			internal bool AHBEIHLHEMM(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x27DC1D0", Offset = "0x27DAFD0", VA = "0x1827DC1D0")]
			internal bool FDHIODBLGFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x27DDE30", Offset = "0x27DCC30", VA = "0x1827DDE30")]
			internal bool LELJNOMEPFA()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x27DDBF0", Offset = "0x27DC9F0", VA = "0x1827DDBF0")]
			internal bool KNOOMILIMDF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x27DD5D0", Offset = "0x27DC3D0", VA = "0x1827DD5D0")]
			internal string JCKEMIFBHIL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x27DDA20", Offset = "0x27DC820", VA = "0x1827DDA20")]
			internal void KLNJLIKLCEP(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x27DDD90", Offset = "0x27DCB90", VA = "0x1827DDD90")]
			internal bool LDKOCJHHJNB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x27DEFB0", Offset = "0x27DDDB0", VA = "0x1827DEFB0")]
			internal bool OKICEEDCLKF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x27DD580", Offset = "0x27DC380", VA = "0x1827DD580")]
			internal bool JCBCGACGMHB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x27DD0F0", Offset = "0x27DBEF0", VA = "0x1827DD0F0")]
			internal bool HPAEBOPILFD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x27DEE60", Offset = "0x27DDC60", VA = "0x1827DEE60")]
			internal string OGKBGNFMCNG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x27DC6E0", Offset = "0x27DB4E0", VA = "0x1827DC6E0")]
			internal void FNMJCOFICPO(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x27DBE80", Offset = "0x27DAC80", VA = "0x1827DBE80")]
			internal bool EKFADLOADJB(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x27DCE00", Offset = "0x27DBC00", VA = "0x1827DCE00")]
			internal bool HEGMKELDHDI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x27DDCF0", Offset = "0x27DCAF0", VA = "0x1827DDCF0")]
			internal bool LAJOKCCAHFK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x27DE5B0", Offset = "0x27DD3B0", VA = "0x1827DE5B0")]
			internal bool MLOAIOEKDEK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x27DCC60", Offset = "0x27DBA60", VA = "0x1827DCC60")]
			internal string HAMCLLGLALK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x27DD620", Offset = "0x27DC420", VA = "0x1827DD620")]
			internal void JKMGHDPOLIC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x27DCF50", Offset = "0x27DBD50", VA = "0x1827DCF50")]
			internal bool HJFBFPJNAHF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x27DE3D0", Offset = "0x27DD1D0", VA = "0x1827DE3D0")]
			internal bool MHHBCPJHANO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x27D5980", Offset = "0x27D4780", VA = "0x1827D5980")]
			internal bool DHOBPPOOGPO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x27D5150", Offset = "0x27D3F50", VA = "0x1827D5150")]
			internal string BDCMEFGOINO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x27DD690", Offset = "0x27DC490", VA = "0x1827DD690")]
			internal void JKPMDGAAKPJ(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x27DF470", Offset = "0x27DE270", VA = "0x1827DF470")]
			internal bool PKFCKOEMHFC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x27DE660", Offset = "0x27DD460", VA = "0x1827DE660")]
			internal bool MNNLNPLCJGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x27D4880", Offset = "0x27D3680", VA = "0x1827D4880")]
			internal bool ADCLEKIALBC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x27D5010", Offset = "0x27D3E10", VA = "0x1827D5010")]
			internal string AOPNPIMGCGJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x27DE090", Offset = "0x27DCE90", VA = "0x1827DE090")]
			internal void LKKEJENILJE(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x27DBD40", Offset = "0x27DAB40", VA = "0x1827DBD40")]
			internal bool ECBCAPGDODK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x27D5A20", Offset = "0x27D4820", VA = "0x1827D5A20")]
			internal bool DLILCAHPCMB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x27D47E0", Offset = "0x27D35E0", VA = "0x1827D47E0")]
			internal bool ABAGLLFPPIK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x27DD700", Offset = "0x27DC500", VA = "0x1827DD700")]
			internal string JOALLOKFDDA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x27DF400", Offset = "0x27DE200", VA = "0x1827DF400")]
			internal void PJCBNIBCDKC(string x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x27DD490", Offset = "0x27DC290", VA = "0x1827DD490")]
			internal bool IJJNBCBHCHO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x27DD050", Offset = "0x27DBE50", VA = "0x1827DD050")]
			internal bool HNBBLPKPIJG(string x)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x27DD9D0", Offset = "0x27DC7D0", VA = "0x1827DD9D0")]
			internal float KLMJOFBLOPE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x27DE150", Offset = "0x27DCF50", VA = "0x1827DE150")]
			internal void LPGKEPNDPJP(float x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x27D5240", Offset = "0x27D4040", VA = "0x1827D5240")]
			internal bool BGFHFAKBDEM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x27DE1B0", Offset = "0x27DCFB0", VA = "0x1827DE1B0")]
			internal bool MBCPAFGHKJE()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x27DF230", Offset = "0x27DE030", VA = "0x1827DF230")]
			internal bool PCMEHHCBMBG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x27DC360", Offset = "0x27DB160", VA = "0x1827DC360")]
			internal int FGHKOHMNFHM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x27DEF50", Offset = "0x27DDD50", VA = "0x1827DEF50")]
			internal void OJHMFGABEGE(int x)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x27DCD00", Offset = "0x27DBB00", VA = "0x1827DCD00")]
			internal bool HBKAAIJDPHH()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x27DC7E0", Offset = "0x27DB5E0", VA = "0x1827DC7E0")]
			internal bool GBBGGDFNAIO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x27DD290", Offset = "0x27DC090", VA = "0x1827DD290")]
			internal bool IBDGNCCAJOG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class BMDFOMHMCOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public string secondaryLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public NFJHOMIDDKF CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public BMDFOMHMCOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x27F0700", Offset = "0x27EF500", VA = "0x1827F0700")]
			internal void DPFJAMIFMFJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class MIDJLDOKLBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public char[] swizzleChars;

			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public MIDJLDOKLBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x27FF660", Offset = "0x27FE460", VA = "0x1827FF660")]
			internal bool NKJADBGEMKE(char c)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private readonly LMIKCCALENK FCNIHKJGPOF;

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x27E2F00", Offset = "0x27E1D00", VA = "0x1827E2F00")]
		public OGNLPDLNBBM(HBDCLDOGDAK PINKMLPHMFP, OKANLBKPGIK BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x27E11B0", Offset = "0x27DFFB0", VA = "0x1827E11B0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public sealed class OBANJPJLJNB : JGGDCGDPDJF<AAGKJENNBHI>
	{
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class DICEKMFJPFH
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
				public DICEKMFJPFH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0x2804610", Offset = "0x2803410", VA = "0x182804610", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C8")]
				[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			public OBANJPJLJNB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public DICEKMFJPFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x27F20F0", Offset = "0x27F0EF0", VA = "0x1827F20F0")]
			internal string EFLKMKJKNFL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x27F2140", Offset = "0x27F0F40", VA = "0x1827F2140")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void FIPGNDKIHPC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x27F20A0", Offset = "0x27F0EA0", VA = "0x1827F20A0")]
			internal int AFGCMBEJMPG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x27F2210", Offset = "0x27F1010", VA = "0x1827F2210")]
			internal void PFIBKFEAIBF(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x1112120", Offset = "0x1110F20", VA = "0x181112120", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x2802920", Offset = "0x2801720", VA = "0x182802920")]
		public OBANJPJLJNB(HBDCLDOGDAK PINKMLPHMFP, AAGKJENNBHI OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x28025C0", Offset = "0x28013C0", VA = "0x1828025C0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class PJDOKLFKHJK : JGGDCGDPDJF<NGOCHLDIBKO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class NPJPKNIFCFN
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
				public NPJPKNIFCFN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x2804920", Offset = "0x2803720", VA = "0x182804920", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
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
				public NPJPKNIFCFN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400018C")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400018D")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x400018E")]
				private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x2804C60", Offset = "0x2803A60", VA = "0x182804C60", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public PJDOKLFKHJK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public NPJPKNIFCFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x2801B70", Offset = "0x2800970", VA = "0x182801B70")]
			internal string EFLKMKJKNFL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x2801CB0", Offset = "0x2800AB0", VA = "0x182801CB0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__1>d))]
			internal void FIPGNDKIHPC(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x2801A50", Offset = "0x2800850", VA = "0x182801A50")]
			internal int AFGCMBEJMPG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x2802000", Offset = "0x2800E00", VA = "0x182802000")]
			internal void PFIBKFEAIBF(int colorIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x2801E20", Offset = "0x2800C20", VA = "0x182801E20")]
			internal string LFNJACLOFOJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x2801AA0", Offset = "0x28008A0", VA = "0x182801AA0")]
			[AsyncStateMachine(typeof(<<BuildConfigMenuInternal>b__5>d))]
			internal void EALAMANBNEJ(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x2801D80", Offset = "0x2800B80", VA = "0x182801D80")]
			internal bool FJHLHGPGNHI()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x2801F00", Offset = "0x2800D00", VA = "0x182801F00")]
			internal void NAJEIOOLNDO(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x2801C60", Offset = "0x2800A60", VA = "0x182801C60")]
			internal bool FFNCFKPMOJD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x2802090", Offset = "0x2800E90", VA = "0x182802090")]
			internal void PGAMBGNPPKC(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x2801DD0", Offset = "0x2800BD0", VA = "0x182801DD0")]
			internal float FKBEOICIIDP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x2801E70", Offset = "0x2800C70", VA = "0x182801E70")]
			internal void MEOIMAMNIEO(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x2802120", Offset = "0x2800F20", VA = "0x182802120")]
			internal int PNLDOBKIKFM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x2801BC0", Offset = "0x28009C0", VA = "0x182801BC0")]
			internal void EOPACFFPHPF(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x2801F90", Offset = "0x2800D90", VA = "0x182801F90")]
			internal bool ODGJCALBGBG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x1112120", Offset = "0x1110F20", VA = "0x181112120", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x28041B0", Offset = "0x2802FB0", VA = "0x1828041B0")]
		public PJDOKLFKHJK(HBDCLDOGDAK PINKMLPHMFP, NGOCHLDIBKO BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x28037D0", Offset = "0x28025D0", VA = "0x1828037D0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public sealed class FAMDCDBGGHA : JGGDCGDPDJF<IDLLKGHNPFJ>
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class FPJKJPAOEFI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public FAMDCDBGGHA <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public FPJKJPAOEFI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x27F4580", Offset = "0x27F3380", VA = "0x1827F4580")]
			internal Dictionary<string, FIBJHCAOCDK> EFLKMKJKNFL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x27F4620", Offset = "0x27F3420", VA = "0x1827F4620")]
			internal int FIPGNDKIHPC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x27F4450", Offset = "0x27F3250", VA = "0x1827F4450")]
			internal void AFGCMBEJMPG(int value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x27F4670", Offset = "0x27F3470", VA = "0x1827F4670")]
			internal bool PFIBKFEAIBF()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x1112120", Offset = "0x1110F20", VA = "0x181112120", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x27F3A20", Offset = "0x27F2820", VA = "0x1827F3A20")]
		public FAMDCDBGGHA(HBDCLDOGDAK PINKMLPHMFP, IDLLKGHNPFJ OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x27F3750", Offset = "0x27F2550", VA = "0x1827F3750", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public sealed class KFGELMPIBIC : JGGDCGDPDJF<LEELOGIDKNK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class KIBMNDDJMHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public KFGELMPIBIC <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public KIBMNDDJMHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x27F7D70", Offset = "0x27F6B70", VA = "0x1827F7D70")]
			internal void EFLKMKJKNFL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x1112120", Offset = "0x1110F20", VA = "0x181112120", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x27F79F0", Offset = "0x27F67F0", VA = "0x1827F79F0")]
		public KFGELMPIBIC(HBDCLDOGDAK PINKMLPHMFP, LEELOGIDKNK OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x27F7870", Offset = "0x27F6670", VA = "0x1827F7870", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class HMPMLMAJDEJ<TNode> : JNPIGLGCIPN<TNode> where TNode : notnull, OAMPBMOAHKC
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override bool NMOALDDPBLE
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override LAELNBABHGN? DJBIBPOJMFL
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x4C54C20", Offset = "0x4C53A20", VA = "0x184C54C20", Slot = "129")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override bool OKDNFHJFMCO
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x4C54CD0", Offset = "0x4C53AD0", VA = "0x184C54CD0", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0xDBA2B0", Offset = "0xDB90B0", VA = "0x180DBA2B0", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x4C54C90", Offset = "0x4C53A90", VA = "0x184C54C90")]
		public HMPMLMAJDEJ(HBDCLDOGDAK PINKMLPHMFP, TNode BINEDJHADMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class GCIIIKFIBNC : HMPMLMAJDEJ<IOFPHBLLHJB>
	{
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class HOEGFGGIMOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public GCIIIKFIBNC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public HOEGFGGIMOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x27F5940", Offset = "0x27F4740", VA = "0x1827F5940")]
			internal object EFLKMKJKNFL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x27F59B0", Offset = "0x27F47B0", VA = "0x1827F59B0")]
			internal void FIPGNDKIHPC(object v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x27F5850", Offset = "0x27F4650", VA = "0x1827F5850")]
			internal void AFGCMBEJMPG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private static object[]? NKEHNGGCDNJ;

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x27F4CA0", Offset = "0x27F3AA0", VA = "0x1827F4CA0")]
		public GCIIIKFIBNC(HBDCLDOGDAK PINKMLPHMFP, IOFPHBLLHJB BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x27F46F0", Offset = "0x27F34F0", VA = "0x1827F46F0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private sealed class KMPLJMDJNEJ : JGGDCGDPDJF<MHOGFLAFIHK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0xCAB860", Offset = "0xCAA660", VA = "0x180CAB860", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x27F7E80", Offset = "0x27F6C80", VA = "0x1827F7E80")]
		public KMPLJMDJNEJ(HBDCLDOGDAK PINKMLPHMFP, MHOGFLAFIHK BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private sealed class CAKPONCCJIK : JGGDCGDPDJF<AOOCHBMHBOF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xBF5C80", Offset = "0xBF4A80", VA = "0x180BF5C80", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x27F17C0", Offset = "0x27F05C0", VA = "0x1827F17C0")]
		public CAKPONCCJIK(HBDCLDOGDAK PINKMLPHMFP, AOOCHBMHBOF BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "131")]
		protected override bool MEJLPKNKKMI(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007D")]
	private sealed class ENMGMBHPEIG : JGGDCGDPDJF<NMFPJCNLBOD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xBE3EC0", Offset = "0xBE2CC0", VA = "0x180BE3EC0", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override bool CAPPICCJHOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x27F3700", Offset = "0x27F2500", VA = "0x1827F3700", Slot = "111")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		protected override bool HPHIBJONKMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x27F3690", Offset = "0x27F2490", VA = "0x1827F3690")]
		public ENMGMBHPEIG(HBDCLDOGDAK PINKMLPHMFP, NMFPJCNLBOD BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private sealed class LHOPLCIBAII : JGGDCGDPDJF<IMPHKIECBFK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0xBFC230", Offset = "0xBFB030", VA = "0x180BFC230", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override bool CAPPICCJHOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x27F9B00", Offset = "0x27F8900", VA = "0x1827F9B00", Slot = "111")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		protected override bool HPHIBJONKMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x27F9A90", Offset = "0x27F8890", VA = "0x1827F9A90")]
		public LHOPLCIBAII(HBDCLDOGDAK PINKMLPHMFP, IMPHKIECBFK BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public sealed class FHFMJABBAEP : NLMHFLCMFOO<LPFKCBMMEDN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class BMFAINDDHFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public FHFMJABBAEP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public BMFAINDDHFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x27F12D0", Offset = "0x27F00D0", VA = "0x1827F12D0")]
			internal float FJHHLNJDEMC()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x27F1350", Offset = "0x27F0150", VA = "0x1827F1350")]
			internal void HEMECHNNCID(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x27F40F0", Offset = "0x27F2EF0", VA = "0x1827F40F0")]
		public FHFMJABBAEP(HBDCLDOGDAK PINKMLPHMFP, LPFKCBMMEDN OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x27F3E70", Offset = "0x27F2C70", VA = "0x1827F3E70", Slot = "145")]
		protected override void LCCIBEHDPDA(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public sealed class CBGADBCDMDN : JGGDCGDPDJF<CFIMJCIAELL>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private sealed class FIFNLPHNIJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public CBGADBCDMDN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public FIFNLPHNIJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x27F4150", Offset = "0x27F2F50", VA = "0x1827F4150")]
			internal bool EFLKMKJKNFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x27F41A0", Offset = "0x27F2FA0", VA = "0x1827F41A0")]
			internal void FIPGNDKIHPC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x27F1AE0", Offset = "0x27F08E0", VA = "0x1827F1AE0")]
		public CBGADBCDMDN(HBDCLDOGDAK PINKMLPHMFP, CFIMJCIAELL OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x27F1830", Offset = "0x27F0630", VA = "0x1827F1830", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public sealed class IJJEMEBPNMH : JGGDCGDPDJF<OIBMIMMPIMB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		[CompilerGenerated]
		private sealed class BEHLMIPDFJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public IJJEMEBPNMH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public Predicate<Guid> <>9__7;

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public BEHLMIPDFJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x27EE860", Offset = "0x27ED660", VA = "0x1827EE860")]
			internal object? EFLKMKJKNFL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x27EED90", Offset = "0x27EDB90", VA = "0x1827EED90")]
			internal bool NAJEIOOLNDO(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x27EE990", Offset = "0x27ED790", VA = "0x1827EE990")]
			internal void FIPGNDKIHPC(object? value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x27EE6B0", Offset = "0x27ED4B0", VA = "0x1827EE6B0")]
			internal string AFGCMBEJMPG(object? key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x27EEE10", Offset = "0x27EDC10", VA = "0x1827EEE10")]
			internal IReadOnlyList<object> PFIBKFEAIBF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x27EED20", Offset = "0x27EDB20", VA = "0x1827EED20")]
			internal bool LFNJACLOFOJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x27EE810", Offset = "0x27ED610", VA = "0x1827EE810")]
			internal bool EALAMANBNEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x27EEBF0", Offset = "0x27ED9F0", VA = "0x1827EEBF0")]
			internal void FJHLHGPGNHI(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x27F6680", Offset = "0x27F5480", VA = "0x1827F6680")]
		public IJJEMEBPNMH(HBDCLDOGDAK PINKMLPHMFP, OIBMIMMPIMB OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x27F5EA0", Offset = "0x27F4CA0", VA = "0x1827F5EA0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class IFECPMPACOO : IGEOBHIJPME<KBIFMIJDPGM>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0xDB9860", Offset = "0xDB8660", VA = "0x180DB9860", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x27F5E40", Offset = "0x27F4C40", VA = "0x1827F5E40")]
		public IFECPMPACOO(HBDCLDOGDAK PINKMLPHMFP, KBIFMIJDPGM BINEDJHADMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public sealed class NPIEELJJJEH : NLMHFLCMFOO<GDMOMEGANMB>
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class EKDFLAGPMDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public NPIEELJJJEH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public EKDFLAGPMDD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x27F3570", Offset = "0x27F2370", VA = "0x1827F3570")]
			internal int FJHHLNJDEMC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x27F35F0", Offset = "0x27F23F0", VA = "0x1827F35F0")]
			internal void HEMECHNNCID(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x28019F0", Offset = "0x28007F0", VA = "0x1828019F0")]
		public NPIEELJJJEH(HBDCLDOGDAK PINKMLPHMFP, GDMOMEGANMB OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x2801760", Offset = "0x2800560", VA = "0x182801760", Slot = "145")]
		protected override void LCCIBEHDPDA(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public sealed class OAHNAOAHPLH : JGGDCGDPDJF<EMJDJNGBNCD>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class AMLLMEIICGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public OAHNAOAHPLH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public List<BIHBDMOHDCK<DLEFBPKFGNN>> types;

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public AMLLMEIICGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x27E5BC0", Offset = "0x27E49C0", VA = "0x1827E5BC0")]
			internal int FIPGNDKIHPC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x27E5A60", Offset = "0x27E4860", VA = "0x1827E5A60")]
			internal void AFGCMBEJMPG(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class MNCNEDGFIOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public BIHBDMOHDCK<DLEFBPKFGNN> circuitType;

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public MNCNEDGFIOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x28005D0", Offset = "0x27FF3D0", VA = "0x1828005D0")]
			internal bool PFIBKFEAIBF(BIHBDMOHDCK<DLEFBPKFGNN> curr)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2802550", Offset = "0x2801350", VA = "0x182802550")]
		public OAHNAOAHPLH(HBDCLDOGDAK PINKMLPHMFP, EMJDJNGBNCD BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2802180", Offset = "0x2800F80", VA = "0x182802180", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public sealed class LKKPPKAAPMG : JGGDCGDPDJF<GKPIJLPANME>
	{
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		[CompilerGenerated]
		private sealed class DOHOIMKBCFE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public LKKPPKAAPMG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public DOHOIMKBCFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x27F3430", Offset = "0x27F2230", VA = "0x1827F3430")]
			internal bool EFLKMKJKNFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x27F3480", Offset = "0x27F2280", VA = "0x1827F3480")]
			internal void FIPGNDKIHPC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x27FA140", Offset = "0x27F8F40", VA = "0x1827FA140")]
		public LKKPPKAAPMG(HBDCLDOGDAK PINKMLPHMFP, GKPIJLPANME OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x27F9F60", Offset = "0x27F8D60", VA = "0x1827F9F60", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public sealed class APIECJJOPBH : JGGDCGDPDJF<GCDNMAPOFJF>
	{
		[Cpp2IlInjected.Token(Token = "0x200008F")]
		[CompilerGenerated]
		private sealed class PKADMPMHHCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public APIECJJOPBH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public PKADMPMHHCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x2804220", Offset = "0x2803020", VA = "0x182804220")]
			internal bool EFLKMKJKNFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x2804270", Offset = "0x2803070", VA = "0x182804270")]
			internal void FIPGNDKIHPC(bool value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x27E5EF0", Offset = "0x27E4CF0", VA = "0x1827E5EF0")]
		public APIECJJOPBH(HBDCLDOGDAK PINKMLPHMFP, GCDNMAPOFJF OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x27E5D10", Offset = "0x27E4B10", VA = "0x1827E5D10", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public sealed class MCMNDMPKGAO : JGGDCGDPDJF<DECAINNGNMK>
	{
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private sealed class HBKOIAIEBMM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public MCMNDMPKGAO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public HBKOIAIEBMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x27F5520", Offset = "0x27F4320", VA = "0x1827F5520")]
			internal int EFLKMKJKNFL()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x27F5570", Offset = "0x27F4370", VA = "0x1827F5570")]
			internal void FIPGNDKIHPC(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x27FA480", Offset = "0x27F9280", VA = "0x1827FA480")]
		public MCMNDMPKGAO(HBDCLDOGDAK PINKMLPHMFP, DECAINNGNMK OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x27FA210", Offset = "0x27F9010", VA = "0x1827FA210", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public sealed class FKCOHJIEECO : JDGCPHOOIED<EGBDALHEGLD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public override PPGGIKABFII NCLIDJPHIOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0xBFF4C0", Offset = "0xBFE2C0", VA = "0x180BFF4C0", Slot = "145")]
			get
			{
				return default(PPGGIKABFII);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x27F42D0", Offset = "0x27F30D0", VA = "0x1827F42D0")]
		public FKCOHJIEECO(HBDCLDOGDAK PINKMLPHMFP, EGBDALHEGLD OMKBHAHHOCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class HOLEJAELFEC : JGGDCGDPDJF<ANKFKDANALM>
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x27F43E0", Offset = "0x27F31E0", VA = "0x1827F43E0")]
		public HOLEJAELFEC(HBDCLDOGDAK PINKMLPHMFP, ANKFKDANALM BINEDJHADMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public abstract class JGGDCGDPDJF<TNode> : IMKHFLEBFGP, IDisposable where TNode : notnull, ANKFKDANALM
	{
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class JPEAKNMFBGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			public JGGDCGDPDJF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public HBDCLDOGDAK circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public JPEAKNMFBGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x4FE2A00", Offset = "0x4FE1800", VA = "0x184FE2A00")]
			internal MENGHKPIFIA JNCEMGPKAHK(INBLLBMMACP portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private struct GKIPPPAFFMK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			public JGGDCGDPDJF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x4BD0320", Offset = "0x4BCF120", VA = "0x184BD0320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private struct LDDDAFDCPNE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			public JGGDCGDPDJF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			public NPKPAEPCCIF? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			public OFJEKJFLDPF? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x51557C0", Offset = "0x51545C0", VA = "0x1851557C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x5155A60", Offset = "0x5154860", VA = "0x185155A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private sealed class IPNLMPEPJJD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000099")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001D9")]
				public IPNLMPEPJJD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001DA")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60003D3")]
				[Cpp2IlInjected.Address(RVA = "0x41926C0", Offset = "0x41914C0", VA = "0x1841926C0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60003D4")]
				[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public JGGDCGDPDJF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			public GAICGLBGHPP configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public IPNLMPEPJJD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			internal string CPKFIFBCKJA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0xA0B670", Offset = "0xA0A470", VA = "0x180A0B670")]
			internal void HKMCJGMMFBD(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x4D735C0", Offset = "0x4D723C0", VA = "0x184D735C0")]
			[AsyncStateMachine(typeof(JGGDCGDPDJF<>.IPNLMPEPJJD.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void GGEMELPBHCB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private sealed class BNFNHDEOINO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public BNFNHDEOINO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x6176D90", Offset = "0x6175B90", VA = "0x186176D90")]
			internal bool EGMNAIDJOEF(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003D7")]
			[Cpp2IlInjected.Address(RVA = "0x6176D80", Offset = "0x6175B80", VA = "0x186176D80")]
			internal bool CMGPECHPBFM(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[CompilerGenerated]
		private struct IMCOIEMGHPI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			public JGGDCGDPDJF<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003D8")]
			[Cpp2IlInjected.Address(RVA = "0x4D4E7F0", Offset = "0x4D4D5F0", VA = "0x184D4E7F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D9")]
			[Cpp2IlInjected.Address(RVA = "0x4D4EB80", Offset = "0x4D4D980", VA = "0x184D4EB80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private readonly HBDCLDOGDAK BPKGJHGJDKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private readonly bool ELNNBNGEEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private APKPAJBCPHM<NGIHDDPPPGJ, MENGHKPIFIA> DCLHAMBPMAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private APKPAJBCPHM<NGIHDDPPPGJ, FMANJMOJBNB> NCLCMFLEGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private List<Action> NEGHBHIJFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[CompilerGenerated]
		private Action<BIHBDMOHDCK<NGIHDDPPPGJ>>? FBEMNJLGHNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[CompilerGenerated]
		private Action<BIHBDMOHDCK<NGIHDDPPPGJ>, FMANJMOJBNB>? LDPNEAJNOEB;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		protected CNOGAFAGIEK JKKPMIOOIOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x4FA8260", Offset = "0x4FA7060", VA = "0x184FA8260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		protected OIOBLJKDDDM BHJKLLEIMLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x4FA7E60", Offset = "0x4FA6C60", VA = "0x184FA7E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected PKJBGIACFMC INFIBOKKILD
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x4FAA290", Offset = "0x4FA9090", VA = "0x184FAA290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected TNode DGHNHHDHOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public KOIDEEJEAKA<JLGBKHFBOKK> ECGJJHCKKHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x13BBD50", Offset = "0x13BAB50", VA = "0x1813BBD50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(KOIDEEJEAKA<JLGBKHFBOKK>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public BIHBDMOHDCK<JBGDHIBENNA> EODIODJGCCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC560", Offset = "0x4FAB360", VA = "0x184FAC560", Slot = "6")]
			get
			{
				return default(BIHBDMOHDCK<JBGDHIBENNA>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public object EKMIHGEOGNM
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x46DFB40", Offset = "0x46DE940", VA = "0x1846DFB40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public virtual bool GPNCDKBCLHG
		{
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public int KEMFIGNEAMM
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC170", Offset = "0x4FAAF70", VA = "0x184FAC170", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public FJNIAMGOABG DPEDBKMCJJI
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC110", Offset = "0x4FAAF10", VA = "0x184FAC110", Slot = "10")]
			get
			{
				return default(FJNIAMGOABG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string NCPCOONJMOM
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC760", Offset = "0x4FAB560", VA = "0x184FAC760", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		protected virtual bool HPHIBJONKMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public BIHBDMOHDCK<LMDGPOLMACN> CBHCLNOMBBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xE8BBB0", Offset = "0xE8A9B0", VA = "0x180E8BBB0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(BIHBDMOHDCK<LMDGPOLMACN>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xE95C10", Offset = "0xE94A10", VA = "0x180E95C10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool DDOHIACGJFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual bool CAPPICCJHOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "111")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual bool NMOALDDPBLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "112")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public virtual CBCEAHOKODH PJFIDILBPKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xFCC180", Offset = "0xFCAF80", VA = "0x180FCC180", Slot = "113")]
			get
			{
				return default(CBCEAHOKODH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool PKCMMIFDAON
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x4FABE80", Offset = "0x4FAAC80", VA = "0x184FABE80", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool MPFBFHICPFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x4FABEE0", Offset = "0x4FAACE0", VA = "0x184FABEE0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool HDJEFJNCKLL
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x4FABF40", Offset = "0x4FAAD40", VA = "0x184FABF40", Slot = "20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public int OEAPMOLHHAI
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC510", Offset = "0x4FAB310", VA = "0x184FAC510", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool NBJBGMHMNOL
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC340", Offset = "0x4FAB140", VA = "0x184FAC340", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public NFBNLJJMNLE KOADLMDIDKH
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC050", Offset = "0x4FAAE50", VA = "0x184FAC050", Slot = "23")]
			get
			{
				return default(NFBNLJJMNLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool PKGLCJPKDPP
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x4FABFF0", Offset = "0x4FAADF0", VA = "0x184FABFF0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool IDJDECCBLKA
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0xF808E0", Offset = "0xF7F6E0", VA = "0x180F808E0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x13891D0", Offset = "0x1387FD0", VA = "0x1813891D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool JLCOLPKDLHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual bool CKGPLACJAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x4FABFA0", Offset = "0x4FAADA0", VA = "0x184FABFA0", Slot = "115")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public bool MCMIGJLPLMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC220", Offset = "0x4FAB020", VA = "0x184FAC220", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public NPKPAEPCCIF EGIJBOFOPNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC450", Offset = "0x4FAB250", VA = "0x184FAC450", Slot = "29")]
			get
			{
				return default(NPKPAEPCCIF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public OFJEKJFLDPF DGDGJCDLDBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC4B0", Offset = "0x4FAB2B0", VA = "0x184FAC4B0", Slot = "31")]
			get
			{
				return default(OFJEKJFLDPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool LHHLNHOCHFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC280", Offset = "0x4FAB080", VA = "0x184FAC280", Slot = "33")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual bool DHPMOKAEHOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "127")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual AOCPHEFBFGP? LHPDEGBKDIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "128")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual LAELNBABHGN? DJBIBPOJMFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "129")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public virtual IEnumerable<KOIDEEJEAKA<KCAEAGPDLDO>>? KAAAGJLLLHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool ADENHLFLDDB
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC0B0", Offset = "0x4FAAEB0", VA = "0x184FAC0B0", Slot = "133")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public KOIDEEJEAKA<HJIDLNADIFB> LNJCEJNAFLB
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC390", Offset = "0x4FAB190", VA = "0x184FAC390", Slot = "65")]
			get
			{
				return default(KOIDEEJEAKA<HJIDLNADIFB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public BIHBDMOHDCK<HJIDLNADIFB> IIFNBDFMHFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC1C0", Offset = "0x4FAAFC0", VA = "0x184FAC1C0", Slot = "59")]
			get
			{
				return default(BIHBDMOHDCK<HJIDLNADIFB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public virtual bool LPOIOKLMCNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "134")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public virtual BIHBDMOHDCK<HJIDLNADIFB>? ODKJPMNDPID
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "135")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public virtual bool OKDNFHJFMCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "136")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool LJMIBMDJCAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC2D0", Offset = "0x4FAB0D0", VA = "0x184FAC2D0", Slot = "64")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public string KHKODDKNOBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xA0D8A0", Offset = "0xA0C6A0", VA = "0x180A0D8A0", Slot = "68")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xA0D8E0", Offset = "0xA0C6E0", VA = "0x180A0D8E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public string MABKDBAHBEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xA0D9C0", Offset = "0xA0C7C0", VA = "0x180A0D9C0", Slot = "69")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xA0D960", Offset = "0xA0C760", VA = "0x180A0D960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public BIHBDMOHDCK<KCAEAGPDLDO> ACBABJDGAOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC5E0", Offset = "0x4FAB3E0", VA = "0x184FAC5E0", Slot = "66")]
			get
			{
				return default(BIHBDMOHDCK<KCAEAGPDLDO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public KOIDEEJEAKA<KCAEAGPDLDO> BIIDDLLCBEA
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC3F0", Offset = "0x4FAB1F0", VA = "0x184FAC3F0", Slot = "67")]
			get
			{
				return default(KOIDEEJEAKA<KCAEAGPDLDO>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public KOIDEEJEAKA<KCAEAGPDLDO>? KPMEECHOFOM
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC640", Offset = "0x4FAB440", VA = "0x184FAC640", Slot = "137")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public JIAMCAFPHLG<NGIHDDPPPGJ, FMANJMOJBNB> FOFMOHMCCHP
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC720", Offset = "0x4FAB520", VA = "0x184FAC720", Slot = "70")]
			get
			{
				return default(JIAMCAFPHLG<NGIHDDPPPGJ, FMANJMOJBNB>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public virtual BIHBDMOHDCK<NGIHDDPPPGJ>? HJDMGJFMKDB
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "138")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public virtual bool NJNLOMGBJNP
		{
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "141")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public virtual bool FKHFDPIJHAG
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "142")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PMDFMFIMBCG
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x4FAAE00", Offset = "0x4FA9C00", VA = "0x184FAAE00", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x4FA7620", Offset = "0x4FA6420", VA = "0x184FA7620", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CLGNJPFIHLM LPGPHJNGDCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x4FA9D80", Offset = "0x4FA8B80", VA = "0x184FA9D80", Slot = "42")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x4FA7DC0", Offset = "0x4FA6BC0", VA = "0x184FA7DC0", Slot = "43")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event EKGFLMAEHOL IIBFOEMMBEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x4FAA150", Offset = "0x4FA8F50", VA = "0x184FAA150", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x4FAB800", Offset = "0x4FAA600", VA = "0x184FAB800", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action LFOMJBCCFOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x4FAACE0", Offset = "0x4FA9AE0", VA = "0x184FAACE0", Slot = "46")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x4FA9CA0", Offset = "0x4FA8AA0", VA = "0x184FA9CA0", Slot = "47")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action LMKGPGNHGOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0x4FA7BF0", Offset = "0x4FA69F0", VA = "0x184FA7BF0", Slot = "48")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x4FA9340", Offset = "0x4FA8140", VA = "0x184FA9340", Slot = "49")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<BIHBDMOHDCK<NGIHDDPPPGJ>, FMANJMOJBNB> APDEIOEECPB
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x4FA7C90", Offset = "0x4FA6A90", VA = "0x184FA7C90", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x4FA99B0", Offset = "0x4FA87B0", VA = "0x184FA99B0", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<BIHBDMOHDCK<NGIHDDPPPGJ>, FMANJMOJBNB> NNAFDLDNCBN
		{
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x4FAB140", Offset = "0x4FA9F40", VA = "0x184FAB140", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x4FA7560", Offset = "0x4FA6360", VA = "0x184FA7560", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<BIHBDMOHDCK<NGIHDDPPPGJ>> GLOLJJMKNBH
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x4FA8F30", Offset = "0x4FA7D30", VA = "0x184FA8F30", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x4FA7A70", Offset = "0x4FA6870", VA = "0x184FA7A70", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<BIHBDMOHDCK<NGIHDDPPPGJ>, BIHBDMOHDCK<NGIHDDPPPGJ>> POPFMLNHOHH
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x4FA8E50", Offset = "0x4FA7C50", VA = "0x184FA8E50", Slot = "78")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x4FA9E20", Offset = "0x4FA8C20", VA = "0x184FA9E20", Slot = "79")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<BIHBDMOHDCK<NGIHDDPPPGJ>, FMANJMOJBNB> OFNDJGGFEAP
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x4FAAFF0", Offset = "0x4FA9DF0", VA = "0x184FAAFF0", Slot = "80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x4FAAF30", Offset = "0x4FA9D30", VA = "0x184FAAF30", Slot = "81")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<BIHBDMOHDCK<NGIHDDPPPGJ>, BIHBDMOHDCK<NGIHDDPPPGJ>> OBONJNJOLHP
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x4FA8FF0", Offset = "0x4FA7DF0", VA = "0x184FA8FF0", Slot = "82")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x4FAA090", Offset = "0x4FA8E90", VA = "0x184FAA090", Slot = "83")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action<bool> OCCEIGJMBJC
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x4FA7B30", Offset = "0x4FA6930", VA = "0x184FA7B30", Slot = "84")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x4FA9160", Offset = "0x4FA7F60", VA = "0x184FA9160", Slot = "85")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x4FAB8A0", Offset = "0x4FAA6A0", VA = "0x184FAB8A0")]
		[CIJGJFAEBAA("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[CIJGJFAEBAA("Need to handle `Name` better.")]
		protected JGGDCGDPDJF(HBDCLDOGDAK PINKMLPHMFP, TNode BINEDJHADMC, bool FNAGLHJGOPM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x4FA9710", Offset = "0x4FA8510", VA = "0x184FA9710", Slot = "105")]
		protected virtual void IANLJFINMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x4FA82C0", Offset = "0x4FA70C0", VA = "0x184FA82C0", Slot = "106")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x4FA90B0", Offset = "0x4FA7EB0", VA = "0x184FA90B0", Slot = "9")]
		[AsyncStateMachine(typeof(JGGDCGDPDJF<>.GKIPPPAFFMK))]
		public void GFOMKEEJDEM(int IBMOLKOBAJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x4FA7D50", Offset = "0x4FA6B50", VA = "0x184FA7D50")]
		public bool BEPJNGAKAPA([In] NPKPAEPCCIF OAIIHELJHLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x4FA9B60", Offset = "0x4FA8960", VA = "0x184FA9B60")]
		public bool IKOFJMLILPD([In] OFJEKJFLDPF OAIIHELJHLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x4FA9220", Offset = "0x4FA8020", VA = "0x184FA9220", Slot = "34")]
		public void GHPIOACDCIB(bool HKKIKPAAAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x4FA86D0", Offset = "0x4FA74D0", VA = "0x184FA86D0", Slot = "35")]
		public void EDBMBMCDKAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x4FA7FF0", Offset = "0x4FA6DF0", VA = "0x184FA7FF0", Slot = "36")]
		[AsyncStateMachine(typeof(JGGDCGDPDJF<>.LDDDAFDCPNE))]
		public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> COCCFNNKMAB(NPKPAEPCCIF? IMPLDPKOJAO, OFJEKJFLDPF? MEPKHADFMCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "116")]
		public virtual void FPDHMPOAEFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "117")]
		public virtual void GIIILJKKGLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "118")]
		public virtual void NINGHAIDAEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xF3A290", Offset = "0xF39090", VA = "0x180F3A290")]
		protected void GOAOEALBHHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0xFC6040", Offset = "0xFC4E40", VA = "0x180FC6040")]
		protected void LPOCMEHFDFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x4FA7F60", Offset = "0x4FA6D60", VA = "0x184FA7F60")]
		private void BOHKJPBAGON([In] OFJEKJFLDPF LJIHJJKHDDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x4FAA320", Offset = "0x4FA9120", VA = "0x184FAA320", Slot = "119")]
		public virtual Task<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> MDAOIMHMFGD(string IHGFMOMOADA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x4FAB730", Offset = "0x4FAA530", VA = "0x184FAB730", Slot = "120")]
		public virtual Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> PHBNFECMAIJ(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "121")]
		public virtual void FANCJHAHEBG(BIHBDMOHDCK<NGIHDDPPPGJ> GGOKJFGPDPK, BIHBDMOHDCK<NGIHDDPPPGJ> EKBDAHJIELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x4FAB0B0", Offset = "0x4FA9EB0", VA = "0x184FAB0B0", Slot = "122")]
		public virtual IEnumerable<CMGFJHDBEGO> OJPHANJHCOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x4FA9680", Offset = "0x4FA8480", VA = "0x184FA9680", Slot = "123")]
		public JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ> HLGKFMKAFIF(string GMIBAKEIIGH)
		{
			return default(JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x4FA93E0", Offset = "0x4FA81E0", VA = "0x184FA93E0", Slot = "50")]
		public bool HKABLEHLOGJ([Out] Guid EDHDEKEEFBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x4FAA430", Offset = "0x4FA9230", VA = "0x184FAA430")]
		public bool MHCJFBGPFIO([In] Guid AEHJOFBOANC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "124")]
		public virtual void ANBMJCFGCOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "125")]
		public virtual void HEMEOKDKMNO(bool PHFMCEHAMEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "126")]
		public virtual PINGOINFKOG AIOGIKODMNH([In] MNFCMHOLHFC CICNHGBNDOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x4FAA6F0", Offset = "0x4FA94F0", VA = "0x184FAA6F0")]
		protected void MHMCEHEMBCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x4FAA3F0", Offset = "0x4FA91F0", VA = "0x184FAA3F0", Slot = "131")]
		protected virtual bool MEJLPKNKKMI(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x4FA9310", Offset = "0x4FA8110", VA = "0x184FA9310", Slot = "93")]
		public bool GOJKLCHKGGE(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "132")]
		protected virtual bool FBIDPNPKCBO(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "139")]
		protected virtual void NDOLDDAEKJE(GAICGLBGHPP AEDBICMPOPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x4FAA8E0", Offset = "0x4FA96E0", VA = "0x184FAA8E0")]
		protected void NBBLHAHMOMN(GAICGLBGHPP KOIAEEPOACG, Func<string> PJOJBACCNGL, Action<string> AEMKHFKOOPP, string LPGAKANGBEC, string JDKOLHNPCEB, string OLKLGJGGFKH, PMAGJOBFAFH HHCHNFCAJJI, BDKNMLNBIAM CBLKBINOHFI, Func<string, bool> FNJJAIMMBLK, string LPBEMMGIEED, Func<string, bool> KNPGPFJBDLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x4FAB200", Offset = "0x4FAA000", VA = "0x184FAB200")]
		protected void PCAJOIFMJNP(GAICGLBGHPP KOIAEEPOACG, Func<string> PJOJBACCNGL, Action<string> AEMKHFKOOPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x4FAB510", Offset = "0x4FAA310", VA = "0x184FAB510", Slot = "140")]
		protected virtual void PFKGNKGKDGL(GAICGLBGHPP KOIAEEPOACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x4FAADB0", Offset = "0x4FA9BB0", VA = "0x184FAADB0", Slot = "87")]
		public void NNHDHMCGICM(GAICGLBGHPP KOIAEEPOACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x4FA9A70", Offset = "0x4FA8870", VA = "0x184FA9A70", Slot = "88")]
		public BHMLNBEKKIC IHJHKENEGOI()
		{
			return default(BHMLNBEKKIC);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "143")]
		public virtual bool INCDOMMKFLD(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x1FB8330", Offset = "0x1FB7130", VA = "0x181FB8330")]
		private void OOOELNOJFEO([In] NPKPAEPCCIF NPJPCFKLMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x4FA9530", Offset = "0x4FA8330", VA = "0x184FA9530")]
		private void HKPMECDFFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x4FA9D40", Offset = "0x4FA8B40", VA = "0x184FA9D40", Slot = "94")]
		private void JOAGAONAMBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x4FA8890", Offset = "0x4FA7690", VA = "0x184FA8890", Slot = "96")]
		private void EJNMJPMDHCB(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x10FC320", Offset = "0x10FB120", VA = "0x1810FC320", Slot = "98")]
		private void EANMOBJKDIK(BIHBDMOHDCK<NGIHDDPPPGJ> FONJFDCCINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x4FA9EE0", Offset = "0x4FA8CE0", VA = "0x184FA9EE0", Slot = "100")]
		private void KFCEJLAEOBH(BIHBDMOHDCK<NGIHDDPPPGJ> FONJFDCCINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x4FA76C0", Offset = "0x4FA64C0", VA = "0x184FA76C0", Slot = "101")]
		private void AHKABLGJBGF(BIHBDMOHDCK<NGIHDDPPPGJ> GGOKJFGPDPK, BIHBDMOHDCK<NGIHDDPPPGJ> EKBDAHJIELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x10FAEC0", Offset = "0x10F9CC0", VA = "0x1810FAEC0", Slot = "102")]
		private void AMGPHPIJOBE(BIHBDMOHDCK<NGIHDDPPPGJ> GGOKJFGPDPK, BIHBDMOHDCK<NGIHDDPPPGJ> EKBDAHJIELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x4FAB4F0", Offset = "0x4FAA2F0", VA = "0x184FAB4F0", Slot = "95")]
		private void PDBKKHEKEGC(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x4FA7140", Offset = "0x4FA5F40", VA = "0x184FA7140", Slot = "97")]
		private void ABPNCPBLOKC(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x4FA7F80", Offset = "0x4FA6D80", VA = "0x184FA7F80", Slot = "99")]
		private void CJIEPEBMLKH(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x4FA8F10", Offset = "0x4FA7D10", VA = "0x184FA8F10", Slot = "103")]
		private void EODJLJFKBLH(bool HKKIKPAAAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x4FA8140", Offset = "0x4FA6F40", VA = "0x184FA8140", Slot = "144")]
		[AsyncStateMachine(typeof(JGGDCGDPDJF<>.IMCOIEMGHPI))]
		public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> DBKGGICKCKA(string GMIBAKEIIGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x4FAAEA0", Offset = "0x4FA9CA0", VA = "0x184FAAEA0", Slot = "57")]
		private void OFFJLIJLNEE(object OJBMJOMADMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x4FA9C10", Offset = "0x4FA8A10", VA = "0x184FA9C10", Slot = "58")]
		private void JFMFIDNJMBH(object OJBMJOMADMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x4FAA2E0", Offset = "0x4FA90E0", VA = "0x184FAA2E0", Slot = "30")]
		private bool LLJJNHJGOGF([In] NPKPAEPCCIF OAIIHELJHLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x4FA9D00", Offset = "0x4FA8B00", VA = "0x184FA9D00", Slot = "32")]
		private bool JJPJJDMNFCN([In] OFJEKJFLDPF OAIIHELJHLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x4FA9BD0", Offset = "0x4FA89D0", VA = "0x184FA9BD0", Slot = "51")]
		private bool JBHNKJOLFHK([In] Guid AEHJOFBOANC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x41CC1A0", Offset = "0x41CAFA0", VA = "0x1841CC1A0")]
		[CompilerGenerated]
		private string CPFCMDPEGPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x4FAA1F0", Offset = "0x4FA8FF0", VA = "0x184FAA1F0")]
		[CompilerGenerated]
		private void KKHNMPLKBME(string IHGFMOMOADA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public sealed class DFLPOHBDBKG : IGEOBHIJPME<LIGJCBAGOEA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60003DA")]
			[Cpp2IlInjected.Address(RVA = "0xDBFF20", Offset = "0xDBED20", VA = "0x180DBFF20", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x27F1F70", Offset = "0x27F0D70", VA = "0x1827F1F70")]
		public DFLPOHBDBKG(HBDCLDOGDAK PINKMLPHMFP, LIGJCBAGOEA BINEDJHADMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private sealed class HGFBCONCFPE : JNPIGLGCIPN<KOEKCBHEICH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0xBFF4C0", Offset = "0xBFE2C0", VA = "0x180BFF4C0", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x27F5600", Offset = "0x27F4400", VA = "0x1827F5600")]
		public HGFBCONCFPE(HBDCLDOGDAK PINKMLPHMFP, KOEKCBHEICH BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public sealed class DLMLFANHGKN : JGGDCGDPDJF<HGJCPCCJPPK>
	{
		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private sealed class BHGBKKKBJHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			public IReadOnlyList<KeyValuePair<string, FIBJHCAOCDK>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public DLMLFANHGKN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001E3")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001E4")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001E5")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public BHGBKKKBJHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			internal IReadOnlyList<KeyValuePair<string, FIBJHCAOCDK>> EFLKMKJKNFL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x27EF330", Offset = "0x27EE130", VA = "0x1827EF330")]
			internal int FIPGNDKIHPC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x27EEEB0", Offset = "0x27EDCB0", VA = "0x1827EEEB0")]
			internal void AFGCMBEJMPG(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x27EFA30", Offset = "0x27EE830", VA = "0x1827EFA30")]
			internal int PFIBKFEAIBF()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x27EF6B0", Offset = "0x27EE4B0", VA = "0x1827EF6B0")]
			internal void LFNJACLOFOJ(int v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x27EEE60", Offset = "0x27EDC60", VA = "0x1827EEE60")]
			internal int AEKPLKFGPKI()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x27EF5D0", Offset = "0x27EE3D0", VA = "0x1827EF5D0")]
			internal void ILOJKJCIEDM(int v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x27EF740", Offset = "0x27EE540", VA = "0x1827EF740")]
			internal int MDOBKMDGCPC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x27EF000", Offset = "0x27EDE00", VA = "0x1827EF000")]
			internal void AJJCCJCIAGB(int v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x27EF580", Offset = "0x27EE380", VA = "0x1827EF580")]
			internal int FKDAFNIGOAP()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x27EF090", Offset = "0x27EDE90", VA = "0x1827EF090")]
			internal void BJCALIMHEFF(int v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x27EF660", Offset = "0x27EE460", VA = "0x1827EF660")]
			internal int JODACLAANHC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x27EF9A0", Offset = "0x27EE7A0", VA = "0x1827EF9A0")]
			internal void OJGMIIIEKNK(int v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x27EF120", Offset = "0x27EDF20", VA = "0x1827EF120")]
			internal float EALAMANBNEJ()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x27EF460", Offset = "0x27EE260", VA = "0x1827EF460")]
			internal void FJHLHGPGNHI(float v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x27EF7E0", Offset = "0x27EE5E0", VA = "0x1827EF7E0")]
			internal float NAJEIOOLNDO()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x27EF2A0", Offset = "0x27EE0A0", VA = "0x1827EF2A0")]
			internal void FFNCFKPMOJD(float v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x27EFA80", Offset = "0x27EE880", VA = "0x1827EFA80")]
			internal bool PGAMBGNPPKC()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x27EF4F0", Offset = "0x27EE2F0", VA = "0x1827EF4F0")]
			internal void FKBEOICIIDP(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x27EF790", Offset = "0x27EE590", VA = "0x1827EF790")]
			internal int MEOIMAMNIEO()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x27EFAD0", Offset = "0x27EE8D0", VA = "0x1827EFAD0")]
			internal void PNLDOBKIKFM(int v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x27EF1C0", Offset = "0x27EDFC0", VA = "0x1827EF1C0")]
			internal float EOPACFFPHPF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x27EF910", Offset = "0x27EE710", VA = "0x1827EF910")]
			internal void ODGJCALBGBG(float v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x27EF8C0", Offset = "0x27EE6C0", VA = "0x1827EF8C0")]
			internal float NKCBDCAEDNF()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x27EF830", Offset = "0x27EE630", VA = "0x1827EF830")]
			internal void NANNDMKINFL(float v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x27EF170", Offset = "0x27EDF70", VA = "0x1827EF170")]
			internal bool EJNCOOMMPID()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x27EF210", Offset = "0x27EE010", VA = "0x1827EF210")]
			internal void EOPPFOKEICN(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x1112120", Offset = "0x1110F20", VA = "0x181112120", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x27F33C0", Offset = "0x27F21C0", VA = "0x1827F33C0")]
		public DLMLFANHGKN(HBDCLDOGDAK PINKMLPHMFP, HGJCPCCJPPK OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x27F22A0", Offset = "0x27F10A0", VA = "0x1827F22A0", Slot = "139")]
		protected sealed override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class JDGCPHOOIED<T> : JGGDCGDPDJF<T> where T : notnull, BHKDFPEJGGM
	{
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private sealed class FKDNOCAKAIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E6")]
			public IReadOnlyList<KeyValuePair<string, FIBJHCAOCDK>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E7")]
			public JDGCPHOOIED<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E8")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001E9")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EA")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EB")]
			public PPGGIKABFII clipType;

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public FKDNOCAKAIH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
			internal IReadOnlyList<KeyValuePair<string, FIBJHCAOCDK>> EFLKMKJKNFL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1820", Offset = "0x4AD0620", VA = "0x184AD1820")]
			internal int FIPGNDKIHPC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1460", Offset = "0x4AD0260", VA = "0x184AD1460")]
			internal void AFGCMBEJMPG(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1C30", Offset = "0x4AD0A30", VA = "0x184AD1C30")]
			internal void PFIBKFEAIBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1A20", Offset = "0x4AD0820", VA = "0x184AD1A20")]
			internal void LFNJACLOFOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1680", Offset = "0x4AD0480", VA = "0x184AD1680")]
			internal bool EALAMANBNEJ()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1980", Offset = "0x4AD0780", VA = "0x184AD1980")]
			internal void FJHLHGPGNHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1680", Offset = "0x4AD0480", VA = "0x184AD1680")]
			internal bool NAJEIOOLNDO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x4AD17D0", Offset = "0x4AD05D0", VA = "0x184AD17D0")]
			internal float FFNCFKPMOJD()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1C80", Offset = "0x4AD0A80", VA = "0x184AD1C80")]
			internal void PGAMBGNPPKC(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040D")]
			[Cpp2IlInjected.Address(RVA = "0x4AD19D0", Offset = "0x4AD07D0", VA = "0x184AD19D0")]
			internal float FKBEOICIIDP()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1B70", Offset = "0x4AD0970", VA = "0x184AD1B70")]
			internal void MEOIMAMNIEO(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1D40", Offset = "0x4AD0B40", VA = "0x184AD1D40")]
			internal float PNLDOBKIKFM()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x4AD1710", Offset = "0x4AD0510", VA = "0x184AD1710")]
			internal void EOPACFFPHPF(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x1112120", Offset = "0x1110F20", VA = "0x181112120", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public abstract PPGGIKABFII NCLIDJPHIOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(Slot = "145")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x4F7B4B0", Offset = "0x4F7A2B0", VA = "0x184F7B4B0")]
		public JDGCPHOOIED(HBDCLDOGDAK PINKMLPHMFP, T BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x4F7A9E0", Offset = "0x4F797E0", VA = "0x184F7A9E0", Slot = "139")]
		protected sealed override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	private sealed class JEKMBKNOIAD : JGGDCGDPDJF<KJANGJHHPPK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0xDBE440", Offset = "0xDBD240", VA = "0x180DBE440", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x27F66F0", Offset = "0x27F54F0", VA = "0x1827F66F0")]
		public JEKMBKNOIAD(HBDCLDOGDAK PINKMLPHMFP, KJANGJHHPPK BINEDJHADMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public sealed class BJKLHDCPBIA : JGGDCGDPDJF<PPINPGDHKDE>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A4")]
		[CompilerGenerated]
		private sealed class CMOIGINFFHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			public BJKLHDCPBIA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public CMOIGINFFHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x27F1BE0", Offset = "0x27F09E0", VA = "0x1827F1BE0")]
			internal int FIPGNDKIHPC()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x27F1B50", Offset = "0x27F0950", VA = "0x1827F1B50")]
			internal void AFGCMBEJMPG(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private static Dictionary<string, FIBJHCAOCDK>? LNEOBNMCEIK;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x27F0690", Offset = "0x27EF490", VA = "0x1827F0690")]
		public BJKLHDCPBIA(HBDCLDOGDAK PINKMLPHMFP, PPINPGDHKDE BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x27F0300", Offset = "0x27EF100", VA = "0x1827F0300", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public sealed class HOBDGENIIOD : JDGCPHOOIED<IOFNDDOBPMK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override PPGGIKABFII NCLIDJPHIOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "145")]
			get
			{
				return default(PPGGIKABFII);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x27F57F0", Offset = "0x27F45F0", VA = "0x1827F57F0")]
		public HOBDGENIIOD(HBDCLDOGDAK PINKMLPHMFP, IOFNDDOBPMK OMKBHAHHOCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	private sealed class KHMKOMKKCKO : JNPIGLGCIPN<KEABLEJHAHH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0xBFF4C0", Offset = "0xBFE2C0", VA = "0x180BFF4C0", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x27F7D10", Offset = "0x27F6B10", VA = "0x1827F7D10")]
		public KHMKOMKKCKO(HBDCLDOGDAK PINKMLPHMFP, KEABLEJHAHH BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	private sealed class LMMEAMHACII : JNPIGLGCIPN<FCIGBEAHNHO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0xBFF4C0", Offset = "0xBFE2C0", VA = "0x180BFF4C0", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x27FA1B0", Offset = "0x27F8FB0", VA = "0x1827FA1B0")]
		public LMMEAMHACII(HBDCLDOGDAK PINKMLPHMFP, FCIGBEAHNHO BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public sealed class DCNNDCDANHA : NLMHFLCMFOO<MLMHIIKGMOI>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		[CompilerGenerated]
		private sealed class DGIEONMHAHJ
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x20000AB")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40001F4")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40001F5")]
				public DGIEONMHAHJ <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40001F6")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40001F7")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000427")]
				[Cpp2IlInjected.Address(RVA = "0x2804300", Offset = "0x2803100", VA = "0x182804300", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000428")]
				[Cpp2IlInjected.Address(RVA = "0xA5B8B0", Offset = "0xA5A6B0", VA = "0x180A5B8B0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public DCNNDCDANHA <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public DGIEONMHAHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x27F1FD0", Offset = "0x27F0DD0", VA = "0x1827F1FD0")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void FJHHLNJDEMC(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x27F1F10", Offset = "0x27F0D10", VA = "0x1827F1F10")]
		public DCNNDCDANHA(HBDCLDOGDAK PINKMLPHMFP, MLMHIIKGMOI OMKBHAHHOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x27F1C30", Offset = "0x27F0A30", VA = "0x1827F1C30", Slot = "145")]
		protected override void LCCIBEHDPDA(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public sealed class AMBDHCODIPD : JDGCPHOOIED<JPAPIEJMBBD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public override PPGGIKABFII NCLIDJPHIOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0xBE3EC0", Offset = "0xBE2CC0", VA = "0x180BE3EC0", Slot = "145")]
			get
			{
				return default(PPGGIKABFII);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x27E5A00", Offset = "0x27E4800", VA = "0x1827E5A00")]
		public AMBDHCODIPD(HBDCLDOGDAK PINKMLPHMFP, JPAPIEJMBBD OMKBHAHHOCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	private sealed class GPLNHDCAHPI : JGGDCGDPDJF<NBHKEINBMCD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0xD906E0", Offset = "0xD8F4E0", VA = "0x180D906E0", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x27F54B0", Offset = "0x27F42B0", VA = "0x1827F54B0")]
		public GPLNHDCAHPI(HBDCLDOGDAK PINKMLPHMFP, NBHKEINBMCD BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public sealed class FGLDIGEBHNA : JGGDCGDPDJF<LNPJJJPMLID>
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public sealed override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public sealed override bool CAPPICCJHOI
		{
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "111")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		protected sealed override bool HPHIBJONKMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x27F3E00", Offset = "0x27F2C00", VA = "0x1827F3E00")]
		public FGLDIGEBHNA(HBDCLDOGDAK PINKMLPHMFP, LNPJJJPMLID BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x27F3B30", Offset = "0x27F2930", VA = "0x1827F3B30", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x27F3AF0", Offset = "0x27F28F0", VA = "0x1827F3AF0")]
		private int MKPONENPPJK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x27F3A90", Offset = "0x27F2890", VA = "0x1827F3A90")]
		private void FGBMGIFJHOM(int JMDMECFGMML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class FOMJKIMDGCI : HOLEJAELFEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x27F43E0", Offset = "0x27F31E0", VA = "0x1827F43E0")]
		public FOMJKIMDGCI(HBDCLDOGDAK PINKMLPHMFP, ANKFKDANALM BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public sealed class EIHNLAGANKL : NLMHFLCMFOO<AAFOEIDFFJC>
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x27F3510", Offset = "0x27F2310", VA = "0x1827F3510")]
		public EIHNLAGANKL(HBDCLDOGDAK PINKMLPHMFP, AAFOEIDFFJC BINEDJHADMC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public abstract class NLMHFLCMFOO<TVariableNode> : JGGDCGDPDJF<TVariableNode> where TVariableNode : notnull, AAFOEIDFFJC
	{
		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class HJBOOFODFAI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public NLMHFLCMFOO<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public HJBOOFODFAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0x4C31350", Offset = "0x4C30150", VA = "0x184C31350")]
			internal bool EFLKMKJKNFL()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x4C313B0", Offset = "0x4C301B0", VA = "0x184C313B0")]
			internal void FIPGNDKIHPC(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0x4C312F0", Offset = "0x4C300F0", VA = "0x184C312F0")]
			internal bool AFGCMBEJMPG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000443")]
			[Cpp2IlInjected.Address(RVA = "0x4C31520", Offset = "0x4C30320", VA = "0x184C31520")]
			internal void PFIBKFEAIBF(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000444")]
			[Cpp2IlInjected.Address(RVA = "0x4C31470", Offset = "0x4C30270", VA = "0x184C31470")]
			internal bool LFNJACLOFOJ()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class JMIDCBMGIBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			public PKJBGIACFMC nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public NLMHFLCMFOO<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000445")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public JMIDCBMGIBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000446")]
			[Cpp2IlInjected.Address(RVA = "0x4FD3EA0", Offset = "0x4FD2CA0", VA = "0x184FD3EA0")]
			internal void FJHHLNJDEMC(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public override NodeVisualizationKey IKLJNBNIMEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0xC00250", Offset = "0xBFF050", VA = "0x180C00250", Slot = "109")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public override CBCEAHOKODH PJFIDILBPKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x54D39D0", Offset = "0x54D27D0", VA = "0x1854D39D0", Slot = "113")]
			get
			{
				return default(CBCEAHOKODH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x54D3830", Offset = "0x54D2630", VA = "0x1854D3830")]
		protected NLMHFLCMFOO(HBDCLDOGDAK PINKMLPHMFP, TVariableNode BINEDJHADMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x54D2E80", Offset = "0x54D1C80", VA = "0x1854D2E80", Slot = "106")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x54D33A0", Offset = "0x54D21A0", VA = "0x1854D33A0", Slot = "139")]
		protected override void NDOLDDAEKJE(GAICGLBGHPP KOIAEEPOACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x54D3000", Offset = "0x54D1E00", VA = "0x1854D3000", Slot = "145")]
		protected virtual void LCCIBEHDPDA(GAICGLBGHPP KOIAEEPOACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x54D2DD0", Offset = "0x54D1BD0", VA = "0x1854D2DD0", Slot = "124")]
		public override void ANBMJCFGCOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x27CA780", Offset = "0x27C9580", VA = "0x1827CA780")]
	public static IMKHFLEBFGP NBEICDCLFEE(HBDCLDOGDAK PINKMLPHMFP, ANKFKDANALM BINEDJHADMC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class OFLFLDDOJIA : KOICPKOEOHP, PKHOAGDLONP, GFPDJMBDKEG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public BIHBDMOHDCK<IEDJJDGMFHP> KOBEOABMHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xD99670", Offset = "0xD98470", VA = "0x180D99670", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(BIHBDMOHDCK<IEDJJDGMFHP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public BIHBDMOHDCK<FMHKAEJFBFI> MJCOJCCJMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xEA6FC0", Offset = "0xEA5DC0", VA = "0x180EA6FC0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(BIHBDMOHDCK<FMHKAEJFBFI>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x2802D10", Offset = "0x2801B10", VA = "0x182802D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private BIHBDMOHDCK<OHFDADNMMNM> FDANIBOIPKI
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0xD9CDF0", Offset = "0xD9BBF0", VA = "0x180D9CDF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public override BIHBDMOHDCK<DJIGOHNJMMM> CLDGHLHCMKN
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x2802D20", Offset = "0x2801B20", VA = "0x182802D20", Slot = "21")]
		get
		{
			return default(BIHBDMOHDCK<DJIGOHNJMMM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x28030C0", Offset = "0x2801EC0", VA = "0x1828030C0")]
	private OFLFLDDOJIA(HBDCLDOGDAK PINKMLPHMFP, ANKFKDANALM BINEDJHADMC, COFBKBIMAPH HLJBAAGHJHI, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, BIHBDMOHDCK<FMHKAEJFBFI> ILNOKIIEBEH, BIHBDMOHDCK<OHFDADNMMNM> LIGOFENJLEO, bool JGODIJPOFBP, string IHGFMOMOADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x2802D70", Offset = "0x2801B70", VA = "0x182802D70")]
	public static OFLFLDDOJIA NBEICDCLFEE(HBDCLDOGDAK PINKMLPHMFP, ANKFKDANALM BINEDJHADMC, COFBKBIMAPH HDPPHEBDPDN, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, BIHBDMOHDCK<OHFDADNMMNM> LIGOFENJLEO, BIHBDMOHDCK<FMHKAEJFBFI> ILNOKIIEBEH, bool JGODIJPOFBP, bool FNAGLHJGOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x2802D10", Offset = "0x2801B10", VA = "0x182802D10")]
	internal void DKDODHBGPMH(BIHBDMOHDCK<FMHKAEJFBFI> OAIIHELJHLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public abstract class KOICPKOEOHP : GFPDJMBDKEG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	private struct FKJMGHDHNHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private DFGIEBJPDIO? BBJNEDACGIL;

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x27F4330", Offset = "0x27F3130", VA = "0x1827F4330")]
		public void CCLJDABAPHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x27F4340", Offset = "0x27F3140", VA = "0x1827F4340")]
		public DFGIEBJPDIO CGJODGMBNDJ(KOICPKOEOHP EIBBFJKELIB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	protected readonly HBDCLDOGDAK BPKGJHGJDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	protected readonly ANKFKDANALM APFILEAHCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private FKJMGHDHNHJ HDHJCGPBOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private readonly IMNBOBJKMPO FAMNBEDBMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	private readonly List<IFINHPGEBLC> OIFBLJMEMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	private readonly List<NEEJCOJEFEB> NMMPBHGPKAH;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	[CIJGJFAEBAA("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> JIDHFHBDAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x27F91F0", Offset = "0x27F7FF0", VA = "0x1827F91F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public DisplayKind LJHDBPEIHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0xC15DC0", Offset = "0xC14BC0", VA = "0x180C15DC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public BIHBDMOHDCK<HJIDLNADIFB> IIFNBDFMHFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x27F9340", Offset = "0x27F8140", VA = "0x1827F9340", Slot = "6")]
		get
		{
			return default(BIHBDMOHDCK<HJIDLNADIFB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public KOIDEEJEAKA<HJIDLNADIFB> LNJCEJNAFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x27F8170", Offset = "0x27F6F70", VA = "0x1827F8170", Slot = "7")]
		get
		{
			return default(KOIDEEJEAKA<HJIDLNADIFB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IAGGNMMOHFK CPGFDCLDDLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xD78170", Offset = "0xD76F70", VA = "0x180D78170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public AMCEMHPCNJN CIGMLNHMGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x27F9370", Offset = "0x27F8170", VA = "0x1827F9370", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	protected DFGIEBJPDIO DDLPLNEDIAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x27F9370", Offset = "0x27F8170", VA = "0x1827F9370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public PortImage FKAFIHAKHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x27F90A0", Offset = "0x27F7EA0", VA = "0x1827F90A0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0xA0DA00", Offset = "0xA0C800", VA = "0x180A0DA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public KOIDEEJEAKA<KCAEAGPDLDO> BIIDDLLCBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x27F91D0", Offset = "0x27F7FD0", VA = "0x1827F91D0", Slot = "9")]
		get
		{
			return default(KOIDEEJEAKA<KCAEAGPDLDO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public BIHBDMOHDCK<NGIHDDPPPGJ> AMDPJDKJANI
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0xD5AFA0", Offset = "0xD59DA0", VA = "0x180D5AFA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(BIHBDMOHDCK<NGIHDDPPPGJ>);
		}
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0xEA6460", Offset = "0xEA5260", VA = "0x180EA6460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public abstract BIHBDMOHDCK<DJIGOHNJMMM> CLDGHLHCMKN
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x27F9410", Offset = "0x27F8210", VA = "0x1827F9410")]
	protected KOICPKOEOHP(HBDCLDOGDAK PINKMLPHMFP, ANKFKDANALM BINEDJHADMC, IMNBOBJKMPO MEEODCLEJBF, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, bool JGODIJPOFBP, string IHGFMOMOADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x27F8D40", Offset = "0x27F7B40", VA = "0x1827F8D40", Slot = "22")]
	protected virtual void IANLJFINMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x27F8080", Offset = "0x27F6E80", VA = "0x1827F8080", Slot = "23")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x27F8E30", Offset = "0x27F7C30", VA = "0x1827F8E30", Slot = "14")]
	public void IHGACONJDLJ(IFINHPGEBLC FACIPJMCLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x27F8CE0", Offset = "0x27F7AE0", VA = "0x1827F8CE0", Slot = "15")]
	public void HLGEMKLELAH(NEEJCOJEFEB FACIPJMCLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0x27F8430", Offset = "0x27F7230", VA = "0x1827F8430", Slot = "16")]
	public void HDKOHIKGJPO(PANBIENFJEA EIAANAEFNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x27F8200", Offset = "0x27F7000", VA = "0x1827F8200", Slot = "24")]
	protected virtual void FLNEDCNAHBJ(PANBIENFJEA EIAANAEFNFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x27F7EF0", Offset = "0x27F6CF0", VA = "0x1827F7EF0", Slot = "19")]
	private void BCHLLFHHPAO(bool AOJFFKDCAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x27F8E90", Offset = "0x27F7C90", VA = "0x1827F8E90")]
	private void JNGAMJCMKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x27F8260", Offset = "0x27F7060", VA = "0x1827F8260")]
	private void GACOOEOOHEJ([In] ICJCKEPGHBJ HLOCIBAGDEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x27F81A0", Offset = "0x27F6FA0", VA = "0x1827F81A0", Slot = "17")]
	public void FBDOGDFDDFN(IFINHPGEBLC FACIPJMCLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x27F9040", Offset = "0x27F7E40", VA = "0x1827F9040", Slot = "18")]
	public void JONCJPFPOMD(NEEJCOJEFEB FACIPJMCLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0xA0DA00", Offset = "0xA0C800", VA = "0x180A0DA00")]
	internal void BBGCDDMKMOA(string IHGFMOMOADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x27F8410", Offset = "0x27F7210", VA = "0x1827F8410")]
	internal void GKMDIPAGCOF(OIOBLJKDDDM JCFBNAHPHAO, IAGGNMMOHFK AAFMBEEMJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0xEA6460", Offset = "0xEA5260", VA = "0x180EA6460")]
	internal void MOJFCEDFBJF(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public sealed class MENGHKPIFIA : FMANJMOJBNB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class OMBMNBGCJAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public HBDCLDOGDAK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public ANKFKDANALM node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public BIHBDMOHDCK<NGIHDDPPPGJ> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public OMBMNBGCJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x28036B0", Offset = "0x28024B0", VA = "0x1828036B0")]
		internal CDNLFFIPPJK GENAOILBEBE((int PortDescIndex, int PortIndex, OEECNBOMALI InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x2803740", Offset = "0x2802540", VA = "0x182803740")]
		internal OFLFLDDOJIA PKKHBFBLLCG(COFBKBIMAPH i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct AHDGJAJOHKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public MENGHKPIFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private JEAFHHJHNHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x27E5520", Offset = "0x27E4320", VA = "0x1827E5520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x27E5990", Offset = "0x27E4790", VA = "0x1827E5990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct LGGKFJGMKPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public MENGHKPIFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public BIHBDMOHDCK<JAIKLOFJOLF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private JEAFHHJHNHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004BF")]
		[Cpp2IlInjected.Address(RVA = "0x27F96D0", Offset = "0x27F84D0", VA = "0x1827F96D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C0")]
		[Cpp2IlInjected.Address(RVA = "0x27F9A20", Offset = "0x27F8820", VA = "0x1827F9A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct BIEMKDKDAFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public MENGHKPIFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public BIHBDMOHDCK<OHFDADNMMNM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private JEAFHHJHNHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x27EFF40", Offset = "0x27EED40", VA = "0x1827EFF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x27F0290", Offset = "0x27EF090", VA = "0x1827F0290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct CAAKNDBKPEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public MENGHKPIFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public BIHBDMOHDCK<JAIKLOFJOLF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public BIHBDMOHDCK<JAIKLOFJOLF> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private JEAFHHJHNHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x27F13F0", Offset = "0x27F01F0", VA = "0x1827F13F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x27F1750", Offset = "0x27F0550", VA = "0x1827F1750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct GKKBHKJPICP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public MENGHKPIFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public BIHBDMOHDCK<OHFDADNMMNM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public BIHBDMOHDCK<OHFDADNMMNM> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private JEAFHHJHNHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0x27F4D00", Offset = "0x27F3B00", VA = "0x1827F4D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x27F5060", Offset = "0x27F3E60", VA = "0x1827F5060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct JMNKBBOPADI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		public MENGHKPIFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private JEAFHHJHNHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x27F7060", Offset = "0x27F5E60", VA = "0x1827F7060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x27F74E0", Offset = "0x27F62E0", VA = "0x1827F74E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct IBGICBFAEMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public MENGHKPIFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private JEAFHHJHNHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x27F5A80", Offset = "0x27F4880", VA = "0x1827F5A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x27F5DD0", Offset = "0x27F4BD0", VA = "0x1827F5DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct GPEHEHHGEOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public MENGHKPIFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public BIHBDMOHDCK<JAIKLOFJOLF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private JEAFHHJHNHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x27F50D0", Offset = "0x27F3ED0", VA = "0x1827F50D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x27F5440", Offset = "0x27F4240", VA = "0x1827F5440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private struct BHMMAMKIMHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public MENGHKPIFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public BIHBDMOHDCK<OHFDADNMMNM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private JEAFHHJHNHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x27EFB60", Offset = "0x27EE960", VA = "0x1827EFB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x27EFED0", Offset = "0x27EECD0", VA = "0x1827EFED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct AEBMMDPOCMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public MENGHKPIFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public EDIKHIAMCFO type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public BIHBDMOHDCK<JAIKLOFJOLF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private JEAFHHJHNHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x27E5110", Offset = "0x27E3F10", VA = "0x1827E5110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x27E54B0", Offset = "0x27E42B0", VA = "0x1827E54B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct LIPBLILOPFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public MENGHKPIFIA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public EDIKHIAMCFO type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public BIHBDMOHDCK<OHFDADNMMNM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private JEAFHHJHNHG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x27F9B50", Offset = "0x27F8950", VA = "0x1827F9B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x27F9EF0", Offset = "0x27F8CF0", VA = "0x1827F9EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	private readonly bool IMOHNOLGAKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	private readonly HBDCLDOGDAK BPKGJHGJDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private readonly bool GMPCOBIMJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	private JIAMCAFPHLG<LBJKHBPAKKD, CDNLFFIPPJK> MOMPLFDOHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	private JIAMCAFPHLG<LBJKHBPAKKD, BPPIKLNCLPG> MKBBIPIHKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	private readonly ANKFKDANALM APFILEAHCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private JIAMCAFPHLG<FMHKAEJFBFI, OFLFLDDOJIA> EBPHOGFHEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	private JIAMCAFPHLG<FMHKAEJFBFI, PKHOAGDLONP> BHILKDMPOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	private string? PKHKMBEHOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	private readonly INBLLBMMACP NJGPOJKEPHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	private BIHBDMOHDCK<NGIHDDPPPGJ> AMHKAPHHPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	private readonly bool ELNNBNGEEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	[CompilerGenerated]
	private Action? AAIGECKHILG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	[CompilerGenerated]
	private Action? BDMNGFFJFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	[CompilerGenerated]
	private Action<BIHBDMOHDCK<LBJKHBPAKKD>>? BIPDJHLFJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	[CompilerGenerated]
	private Action<BIHBDMOHDCK<FMHKAEJFBFI>>? IKJPDOLENIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	[CompilerGenerated]
	private FMANJMOJBNB.CCPJMJKLPJA? LIFBKJFBEJB;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public bool PHNEGOBNPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x27FB440", Offset = "0x27FA240", VA = "0x1827FB440", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool CJDOGFOFGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x27FF3D0", Offset = "0x27FE1D0", VA = "0x1827FF3D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool DADHBCGMHDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x27FD670", Offset = "0x27FC470", VA = "0x1827FD670", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public KOIDEEJEAKA<HJIDLNADIFB> LNJCEJNAFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x27FBCE0", Offset = "0x27FAAE0", VA = "0x1827FBCE0", Slot = "7")]
		get
		{
			return default(KOIDEEJEAKA<HJIDLNADIFB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool IPAOCLJKHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x27FA610", Offset = "0x27F9410", VA = "0x1827FA610", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public JIAMCAFPHLG<LBJKHBPAKKD, BPPIKLNCLPG> NABCFIGMFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30", Slot = "9")]
		get
		{
			return default(JIAMCAFPHLG<LBJKHBPAKKD, BPPIKLNCLPG>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x27FC420", Offset = "0x27FB220", VA = "0x1827FC420", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public KOIDEEJEAKA<KCAEAGPDLDO> BIIDDLLCBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x27FD730", Offset = "0x27FC530", VA = "0x1827FD730", Slot = "11")]
		get
		{
			return default(KOIDEEJEAKA<KCAEAGPDLDO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public JIAMCAFPHLG<FMHKAEJFBFI, PKHOAGDLONP> LFNKJJIJNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0", Slot = "12")]
		get
		{
			return default(JIAMCAFPHLG<FMHKAEJFBFI, PKHOAGDLONP>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public BIHBDMOHDCK<NGIHDDPPPGJ> AMDPJDKJANI
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0xBF5C70", Offset = "0xBF4A70", VA = "0x180BF5C70", Slot = "13")]
		get
		{
			return default(BIHBDMOHDCK<NGIHDDPPPGJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action? DFPIIGFDMLM
	{
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x27FF100", Offset = "0x27FDF00", VA = "0x1827FF100", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x27FF410", Offset = "0x27FE210", VA = "0x1827FF410", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action? IMLCLPLFJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x27FF260", Offset = "0x27FE060", VA = "0x1827FF260", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x27FF4B0", Offset = "0x27FE2B0", VA = "0x1827FF4B0", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<BIHBDMOHDCK<LBJKHBPAKKD?>, BIHBDMOHDCK<LBJKHBPAKKD?>>? JIPMOMPBOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x27FED90", Offset = "0x27FDB90", VA = "0x1827FED90", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x27FF310", Offset = "0x27FE110", VA = "0x1827FF310", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<BIHBDMOHDCK<LBJKHBPAKKD?>, BIHBDMOHDCK<LBJKHBPAKKD?>>? AGDNJKELCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x27FC2A0", Offset = "0x27FB0A0", VA = "0x1827FC2A0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x27FEE50", Offset = "0x27FDC50", VA = "0x1827FEE50", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<BIHBDMOHDCK<FMHKAEJFBFI?>, BIHBDMOHDCK<FMHKAEJFBFI?>>? GLGBHJEBMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x27FB380", Offset = "0x27FA180", VA = "0x1827FB380", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x27FB880", Offset = "0x27FA680", VA = "0x1827FB880", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<BIHBDMOHDCK<FMHKAEJFBFI?>, BIHBDMOHDCK<FMHKAEJFBFI?>>? KOAJPEIHKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x27FAD40", Offset = "0x27F9B40", VA = "0x1827FAD40", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x27FD930", Offset = "0x27FC730", VA = "0x1827FD930", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<BIHBDMOHDCK<LBJKHBPAKKD?>, BPPIKLNCLPG?>? MKOBGGJLEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x27FB5C0", Offset = "0x27FA3C0", VA = "0x1827FB5C0", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x27FC0B0", Offset = "0x27FAEB0", VA = "0x1827FC0B0", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<BIHBDMOHDCK<LBJKHBPAKKD?>>? BONLCKLONEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x27FDD40", Offset = "0x27FCB40", VA = "0x1827FDD40", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x27FA7B0", Offset = "0x27F95B0", VA = "0x1827FA7B0", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<BIHBDMOHDCK<LBJKHBPAKKD?>, BPPIKLNCLPG?>? AHKHMBCNAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x27FC360", Offset = "0x27FB160", VA = "0x1827FC360", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x27FEF10", Offset = "0x27FDD10", VA = "0x1827FEF10", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<BIHBDMOHDCK<FMHKAEJFBFI?>, PKHOAGDLONP?>? LMBDKEMGGCF
	{
		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x27FE390", Offset = "0x27FD190", VA = "0x1827FE390", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x27FB500", Offset = "0x27FA300", VA = "0x1827FB500", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<BIHBDMOHDCK<FMHKAEJFBFI?>>? AEKJOKMOBGI
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x27FC5C0", Offset = "0x27FB3C0", VA = "0x1827FC5C0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x27FF1A0", Offset = "0x27FDFA0", VA = "0x1827FF1A0", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<BIHBDMOHDCK<FMHKAEJFBFI?>, PKHOAGDLONP?>? EDNJNKDFBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x27FCC70", Offset = "0x27FBA70", VA = "0x1827FCC70", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x27FD750", Offset = "0x27FC550", VA = "0x1827FD750", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x27FF560", Offset = "0x27FE360", VA = "0x1827FF560")]
	private MENGHKPIFIA(bool JGODIJPOFBP, HBDCLDOGDAK PINKMLPHMFP, bool MGABOPJKGJN, JIAMCAFPHLG<LBJKHBPAKKD, CDNLFFIPPJK> GILAMIHEIIG, JIAMCAFPHLG<LBJKHBPAKKD, BPPIKLNCLPG> FBEPKOCLFAN, ANKFKDANALM BINEDJHADMC, JIAMCAFPHLG<FMHKAEJFBFI, OFLFLDDOJIA> DIONPMMKAIP, JIAMCAFPHLG<FMHKAEJFBFI, PKHOAGDLONP> ENCFGKCHJMF, string? OFPCLEEBEKO, INBLLBMMACP GFJAONADGHC, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, bool FNAGLHJGOPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x27FE820", Offset = "0x27FD620", VA = "0x1827FE820")]
	public static MENGHKPIFIA NBEICDCLFEE(bool JGODIJPOFBP, HBDCLDOGDAK PINKMLPHMFP, bool MGABOPJKGJN, ANKFKDANALM BINEDJHADMC, INBLLBMMACP GFJAONADGHC, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, bool FNAGLHJGOPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x27FB940", Offset = "0x27FA740", VA = "0x1827FB940", Slot = "69")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x27FDB00", Offset = "0x27FC900", VA = "0x1827FDB00", Slot = "38")]
	[AsyncStateMachine(typeof(AHDGJAJOHKJ))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ?>>? LKKKFEHDICH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x27FD310", Offset = "0x27FC110", VA = "0x1827FD310")]
	private (DMJLBHOEDIA?, int)? JALPFJHKJOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x27FCD50", Offset = "0x27FBB50", VA = "0x1827FCD50", Slot = "58")]
	private void ILMFNMFICCM(int PHFPKNINMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x1FD52C0", Offset = "0x1FD40C0", VA = "0x181FD52C0", Slot = "57")]
	private void JDDGOGNOENB(int PHFPKNINMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x27FA9A0", Offset = "0x27F97A0", VA = "0x1827FA9A0", Slot = "61")]
	private void BHANPNHEHHC(int OGBGCKFIHOA, int NDOCJPAAOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x27FCE40", Offset = "0x27FBC40", VA = "0x1827FCE40", Slot = "63")]
	private void IMJHDJAPDBA(int OGBGCKFIHOA, int NDOCJPAAOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0x27FDE00", Offset = "0x27FCC00", VA = "0x1827FDE00", Slot = "50")]
	private void MGIICHLFBKH(int PHFPKNINMKC, BIHBDMOHDCK<LBJKHBPAKKD> GLMBMDLJLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x27FEFD0", Offset = "0x27FDDD0", VA = "0x1827FEFD0", Slot = "54")]
	private void NPOLOHJIKJN(int AOJFFKDCAKJ, BIHBDMOHDCK<LBJKHBPAKKD> GLMBMDLJLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x27FCD30", Offset = "0x27FBB30", VA = "0x1827FCD30", Slot = "49")]
	private void IJKNMGLOKIN(int AOJFFKDCAKJ, BIHBDMOHDCK<LBJKHBPAKKD> GLMBMDLJLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x27FAF30", Offset = "0x27F9D30", VA = "0x1827FAF30", Slot = "53")]
	private void CBEIHADHDKP(int PHFPKNINMKC, BIHBDMOHDCK<LBJKHBPAKKD> GLMBMDLJLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x27FC450", Offset = "0x27FB250", VA = "0x1827FC450", Slot = "66")]
	private void HMBJLCOCFLM(int PHFPKNINMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x1355A60", Offset = "0x1354860", VA = "0x181355A60", Slot = "65")]
	private void KEOENBCOODL(int PHFPKNINMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x27FB790", Offset = "0x27FA590", VA = "0x1827FB790", Slot = "60")]
	private void COMNHAKFFMO(int PHFPKNINMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x1FD52C0", Offset = "0x1FD40C0", VA = "0x181FD52C0", Slot = "59")]
	private void GHNBEJMJDAB(int PHFPKNINMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0x27FBD10", Offset = "0x27FAB10", VA = "0x1827FBD10", Slot = "62")]
	private void EDKCJDCDMFB(int OGBGCKFIHOA, int NDOCJPAAOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0x27FC680", Offset = "0x27FB480", VA = "0x1827FC680", Slot = "64")]
	private void IEECGCAABJP(int OGBGCKFIHOA, int NDOCJPAAOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x27FC6E0", Offset = "0x27FB4E0", VA = "0x1827FC6E0", Slot = "52")]
	private void IGCFBCMIBLF(int PHFPKNINMKC, BIHBDMOHDCK<FMHKAEJFBFI> GLMBMDLJLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x27FC5A0", Offset = "0x27FB3A0", VA = "0x1827FC5A0", Slot = "56")]
	private void HNLCBOMMINH(int AOJFFKDCAKJ, BIHBDMOHDCK<FMHKAEJFBFI> GLMBMDLJLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x27FF0E0", Offset = "0x27FDEE0", VA = "0x1827FF0E0", Slot = "51")]
	private void OFFPIFLHBID(int AOJFFKDCAKJ, BIHBDMOHDCK<FMHKAEJFBFI> GLMBMDLJLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x27FCEA0", Offset = "0x27FBCA0", VA = "0x1827FCEA0", Slot = "55")]
	private void IMMJEPLOKFN(int PHFPKNINMKC, BIHBDMOHDCK<FMHKAEJFBFI> GLMBMDLJLGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x27FDBF0", Offset = "0x27FC9F0", VA = "0x1827FDBF0", Slot = "68")]
	private void LPJGGDFCLFC(int PHFPKNINMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x1355A60", Offset = "0x1354860", VA = "0x181355A60", Slot = "67")]
	private void OJAGNBCINGP(int PHFPKNINMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x27FB680", Offset = "0x27FA480", VA = "0x1827FB680", Slot = "39")]
	[AsyncStateMachine(typeof(LGGKFJGMKPL))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ?>>? CLJENGHAAOF(BIHBDMOHDCK<JAIKLOFJOLF> AEIPGBEAKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x27FD9F0", Offset = "0x27FC7F0", VA = "0x1827FD9F0", Slot = "40")]
	[AsyncStateMachine(typeof(BIEMKDKDAFM))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ?>>? LHBFCDLBGKO(BIHBDMOHDCK<OHFDADNMMNM> LIGOFENJLEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x27FD810", Offset = "0x27FC610", VA = "0x1827FD810", Slot = "41")]
	[AsyncStateMachine(typeof(CAAKNDBKPEH))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ?>>? KMJELJIHDIF(BIHBDMOHDCK<JAIKLOFJOLF> AEIPGBEAKCM, BIHBDMOHDCK<JAIKLOFJOLF> MKJNKGBJPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0x27FA690", Offset = "0x27F9490", VA = "0x1827FA690", Slot = "42")]
	[AsyncStateMachine(typeof(GKKBHKJPICP))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ?>>? AOFDIADMGCD(BIHBDMOHDCK<OHFDADNMMNM> LIGOFENJLEO, BIHBDMOHDCK<OHFDADNMMNM> MKJNKGBJPCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0x27FEFF0", Offset = "0x27FDDF0", VA = "0x1827FEFF0", Slot = "43")]
	[AsyncStateMachine(typeof(JMNKBBOPADI))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ?>>? OEABFADKDGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0x27FA4F0", Offset = "0x27F92F0", VA = "0x1827FA4F0", Slot = "44")]
	[AsyncStateMachine(typeof(IBGICBFAEMF))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> AHNGHKDOEJI(string GMIBAKEIIGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x27FC170", Offset = "0x27FAF70", VA = "0x1827FC170", Slot = "45")]
	[AsyncStateMachine(typeof(GPEHEHHGEOP))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> FKCJPOBMMPH(BIHBDMOHDCK<JAIKLOFJOLF> AEIPGBEAKCM, string IHGFMOMOADA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x27FAE00", Offset = "0x27F9C00", VA = "0x1827FAE00", Slot = "46")]
	[AsyncStateMachine(typeof(BHMMAMKIMHL))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> BNNHONPNHKL(BIHBDMOHDCK<OHFDADNMMNM> LIGOFENJLEO, string IHGFMOMOADA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x27FD540", Offset = "0x27FC340", VA = "0x1827FD540", Slot = "47")]
	[AsyncStateMachine(typeof(AEBMMDPOCMK))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> JDAFIOEILAF(BIHBDMOHDCK<JAIKLOFJOLF> AEIPGBEAKCM, EDIKHIAMCFO AAFMBEEMJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x27FA870", Offset = "0x27F9670", VA = "0x1827FA870", Slot = "48")]
	[AsyncStateMachine(typeof(LIPBLILOPFA))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> BDIGBHNICOI(BIHBDMOHDCK<OHFDADNMMNM> LIGOFENJLEO, EDIKHIAMCFO AAFMBEEMJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x27FE450", Offset = "0x27FD250", VA = "0x1827FE450")]
	internal void MOJFCEDFBJF(BIHBDMOHDCK<NGIHDDPPPGJ> OAIIHELJHLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public sealed class HNLPMDFGNGL : ONOMLABGPBN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public interface LECFMDNGEBF
	{
		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		public readonly struct JMKLHDAGPGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000277")]
			public readonly IReadOnlyDictionary<KOIDEEJEAKA<HJIDLNADIFB>, Guid>? OEJOFGKNMJI;

			[Cpp2IlInjected.Token(Token = "0x60004DE")]
			[Cpp2IlInjected.Address(RVA = "0xD5BCB0", Offset = "0xD5AAB0", VA = "0x180D5BCB0")]
			public JMKLHDAGPGG(IReadOnlyDictionary<KOIDEEJEAKA<HJIDLNADIFB>, Guid>? OEJOFGKNMJI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		OIOBLJKDDDM BHJKLLEIMLP
		{
			[Cpp2IlInjected.Token(Token = "0x60004D7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<HHNNLOLDABE> BOAHDKMEPPF(CancellationToken GHKBKDKNIOM);

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<MMIHAIKLLOA> MOELEBNEGMB(CancellationToken GHKBKDKNIOM);

		[Cpp2IlInjected.Token(Token = "0x60004DA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<MKHACDHEGGK> NGJHMHEGOFA(CancellationToken GHKBKDKNIOM);

		[Cpp2IlInjected.Token(Token = "0x60004DB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<PPPBEPLDMBL> AKCMDEDDGNL(CancellationToken GHKBKDKNIOM);

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<JMKLHDAGPGG> ECFOCJABPIG(CancellationToken GHKBKDKNIOM);

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task<GABCMIEAAIL> JICHOLDGFOE(CancellationToken GHKBKDKNIOM);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct MPMBEDJKGNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public AsyncTaskMethodBuilder<HNLPMDFGNGL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public HBDCLDOGDAK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public HHNNLOLDABE roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public MMIHAIKLLOA superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private LECFMDNGEBF <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private HHNNLOLDABE <downloadedRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private HHNNLOLDABE <actualRoomData>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private GABCMIEAAIL <actualStaticConfig>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private MMIHAIKLLOA <finalSuperRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private MKHACDHEGGK <roomAssetData>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private PPPBEPLDMBL <playerSaveData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private TaskAwaiter<HHNNLOLDABE> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private HHNNLOLDABE <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private TaskAwaiter<GABCMIEAAIL> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<MMIHAIKLLOA> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private TaskAwaiter<MKHACDHEGGK> <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private TaskAwaiter<PPPBEPLDMBL> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private TaskAwaiter<LECFMDNGEBF.JMKLHDAGPGG> <>u__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private TaskAwaiter<NNLJIKPEIHP> <>u__7;

		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x2800620", Offset = "0x27FF420", VA = "0x182800620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x28016F0", Offset = "0x28004F0", VA = "0x1828016F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private readonly NNLJIKPEIHP FBOCDAEIFKO;

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public NNLJIKPEIHP FNADCFKDMED
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	private HNLPMDFGNGL(NNLJIKPEIHP GFHIDJFJMHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x27F5660", Offset = "0x27F4460", VA = "0x1827F5660")]
	[AsyncStateMachine(typeof(MPMBEDJKGNE))]
	public static Task<HNLPMDFGNGL> CPHJLFEDOHD(HBDCLDOGDAK PINKMLPHMFP, HHNNLOLDABE? MLFFBNNKHKH, MMIHAIKLLOA? JINFFCDMHMF, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x27F57D0", Offset = "0x27F45D0", VA = "0x1827F57D0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public readonly struct OEFHJHHKKGG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private struct OHLKDMJBBEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<object, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public OEFHJHHKKGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public CMGFJHDBEGO action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private TaskAwaiter<JKEBLLKKBOM<object, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x28033B0", Offset = "0x28021B0", VA = "0x1828033B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x2803640", Offset = "0x2802440", VA = "0x182803640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private struct JKEPFFBIHGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<bool, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public BINGFOABLIG rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public HHNNLOLDABE circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public MMIHAIKLLOA superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public OEFHJHHKKGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private CMGFJHDBEGO[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private TaskAwaiter<JKEBLLKKBOM<object, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x27F6760", Offset = "0x27F5560", VA = "0x1827F6760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x27F6B40", Offset = "0x27F5940", VA = "0x1827F6B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct KGHNDOBFMMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public OEFHJHHKKGG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter<JKEBLLKKBOM<object, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x27F7A60", Offset = "0x27F6860", VA = "0x1827F7A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x27F7CA0", Offset = "0x27F6AA0", VA = "0x1827F7CA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly OEINHBKKCEG MEGMMBGGBGD;

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0xD5BCB0", Offset = "0xD5AAB0", VA = "0x180D5BCB0")]
	public OEFHJHHKKGG(OEINHBKKCEG GOMEADMMGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x2802AF0", Offset = "0x28018F0", VA = "0x182802AF0")]
	[AsyncStateMachine(typeof(OHLKDMJBBEK))]
	private Task<JKEBLLKKBOM<object, CHEIGOJMDOJ>> GLABPHHLEHF(CMGFJHDBEGO CFDGGKIIHOI, bool DPAGNCPIBHD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x2802990", Offset = "0x2801790", VA = "0x182802990")]
	[AsyncStateMachine(typeof(JKEPFFBIHGN))]
	public Task<JKEBLLKKBOM<bool, CHEIGOJMDOJ?>>? EIMJGCIBHBD(int CMHDHFEOCBM, BINGFOABLIG? IHBAHMJHKEL, HHNNLOLDABE? HHLFMJDNKBO, MMIHAIKLLOA? JINFFCDMHMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x2802C20", Offset = "0x2801A20", VA = "0x182802C20")]
	[AsyncStateMachine(typeof(KGHNDOBFMMN))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> KCGBACPBOON()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
public sealed class MIPDEPOFPOI : LLDOMGLFOED, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private readonly PHMNDGGBBBB DNKPJMLDMMG;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public PHMNDGGBBBB FAKFBOCLCCF
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	private MIPDEPOFPOI(PHMNDGGBBBB EJOMGGFIDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x27FF700", Offset = "0x27FE500", VA = "0x1827FF700")]
	public static MIPDEPOFPOI LGDBIGPAFJK(HBDCLDOGDAK PINKMLPHMFP, BINGFOABLIG BGPKDMDEGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x27FF6E0", Offset = "0x27FE4E0", VA = "0x1827FF6E0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CF")]
public interface CKGJLKOHNOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	NNLJIKPEIHP FNADCFKDMED
	{
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	BABKPDALFJM ILHEJKHAMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	KEDILPDKIHJ OIBBDOJLKCI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	BAAJLNNPNBM JKKPMIOOIOL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
public interface HLIFGONAOOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	CKGJLKOHNOP? EDBFLFFEMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool KNAODMGEKMM
	{
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool OGDILPAMAKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<CKGJLKOHNOP?>? NKHOCDOIGCC();

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PLAMPKFEGPM(HBDCLDOGDAK PINKMLPHMFP, BINGFOABLIG BGPKDMDEGME, HHNNLOLDABE? KJJLJHGIIKB, MMIHAIKLLOA? NIAGKFELLGP);
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[IICOIOJKHLE("IStaticCV2Instance")]
public interface ONOMLABGPBN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	NNLJIKPEIHP FNADCFKDMED
	{
		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[IICOIOJKHLE("IStaticEVInstance")]
public interface LLDOMGLFOED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	PHMNDGGBBBB FAKFBOCLCCF
	{
		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public static class JKNOOJOOOMM
{
	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x27F6BB0", Offset = "0x27F59B0", VA = "0x1827F6BB0")]
	public static KGGHGOBAEGL<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK, GGBCFBLMLAI.HLFJKDAONLJ<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK>> KCGMLGMFPKP([In] this KGGHGOBAEGL<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK, GGBCFBLMLAI.HLFJKDAONLJ<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK>> LNDCAHDCEJB)
	{
		return default(KGGHGOBAEGL<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK, GGBCFBLMLAI.HLFJKDAONLJ<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
public sealed class ACKMFBFDNNH : EDCOKJFEDKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private readonly HBDCLDOGDAK BPKGJHGJDKJ;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool OGDILPAMAKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x27E50F0", Offset = "0x27E3EF0", VA = "0x1827E50F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	internal ACKMFBFDNNH(HBDCLDOGDAK PINKMLPHMFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D5")]
internal sealed class LGGENGCNAGA : MEOOBHEAGCC
{
	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x27F9570", Offset = "0x27F8370", VA = "0x1827F9570", Slot = "4")]
	public NECCEAEEPHP? OBCLBFHAGCF(string? JFGPGPDLOBN, string? ENBOLPMBBAO, string? PNBFOBGHELE, FBHKOFFEDEF.EOEMMJJFOHE.HPNOJHJGINL PMNDMICCHKG, bool LALFAJEDGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x27F9610", Offset = "0x27F8410", VA = "0x1827F9610", Slot = "5")]
	public ONHBONJJJJD PKCFNDJEFGH(string JFGPGPDLOBN, string BHAGKFFMNKL, List<string> OPCNAJFMHBK, int IAHFFOMFMBF, int EPEOIPLGNKB, int FJPLMKKBNAO, int LCPBGJBEECF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public LGGENGCNAGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public sealed class MMIMODOBHAE : ADNEPEAHMPF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct KBEEBMIKAPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public AsyncTaskMethodBuilder<CNOGAFAGIEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public MMIMODOBHAE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private TaskAwaiter<CKGJLKOHNOP?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x27F7550", Offset = "0x27F6350", VA = "0x1827F7550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x27F7800", Offset = "0x27F6600", VA = "0x1827F7800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private readonly HBDCLDOGDAK BPKGJHGJDKJ;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public CNOGAFAGIEK? ICOFMPPJNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x27FF8F0", Offset = "0x27FE6F0", VA = "0x1827FF8F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public BAAJLNNPNBM? EFAPGKPKCLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x27FFD90", Offset = "0x27FEB90", VA = "0x1827FFD90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool MOMCIENABIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x28001E0", Offset = "0x27FEFE0", VA = "0x1828001E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool KIIPAECMFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x2800180", Offset = "0x27FEF80", VA = "0x182800180", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x28003E0", Offset = "0x27FF1E0", VA = "0x1828003E0")]
	internal MMIMODOBHAE(HBDCLDOGDAK PINKMLPHMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x27FF970", Offset = "0x27FE770", VA = "0x1827FF970", Slot = "7")]
	[AsyncStateMachine(typeof(KBEEBMIKAPD))]
	public Task<CNOGAFAGIEK> AKAIAIMKLEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x27FFE10", Offset = "0x27FEC10", VA = "0x1827FFE10", Slot = "9")]
	public IReadOnlyDictionary<KOIDEEJEAKA<HJIDLNADIFB>, Guid> FFPKEEGFKKG(IEnumerable<HDCAPCJGFLN> HNFEMMDHPOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x27FFC00", Offset = "0x27FEA00", VA = "0x1827FFC00", Slot = "10")]
	public AIGHBFPBADH ECMLEKMPJHA(IEnumerable<HDCAPCJGFLN> HNFEMMDHPOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x2800240", Offset = "0x27FF040", VA = "0x182800240")]
	public JKEBLLKKBOM<MBBONKEBFJB, LPPJEHMJDEA> PPNIBCIIDAG([In] MBBONKEBFJB IHGJEJKGGFD)
	{
		return default(JKEBLLKKBOM<MBBONKEBFJB, LPPJEHMJDEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x27FFA60", Offset = "0x27FE860", VA = "0x1827FFA60", Slot = "8")]
	private JKEBLLKKBOM<MBBONKEBFJB, LPPJEHMJDEA> CGLNGBMPGFC([In] MBBONKEBFJB IHGJEJKGGFD)
	{
		return default(JKEBLLKKBOM<MBBONKEBFJB, LPPJEHMJDEA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public sealed class BAAJLNNPNBM : CNOGAFAGIEK
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	internal static class PFOBIKJMAFB
	{
		[Cpp2IlInjected.Token(Token = "0x20000DB")]
		[CompilerGenerated]
		private sealed class AIKEPBPENDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			public NNLJIKPEIHP state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			public HIDGDEMJMAO spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public AIKEPBPENDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0x2806770", Offset = "0x2805570", VA = "0x182806770")]
			internal bool FBCGPKNLEMI(EIPFIANKEMH n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		[CompilerGenerated]
		private sealed class PAEPCJFKFMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
			public PAEPCJFKFMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0x280ED50", Offset = "0x280DB50", VA = "0x18280ED50")]
			internal void DFGMFFODPCB(EIPFIANKEMH n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x280FFD0", Offset = "0x280EDD0", VA = "0x18280FFD0")]
		public static JKEBLLKKBOM<CNOGAFAGIEK.MLCLAFLCHLN, CACBPFJIIIM> LECHDFIDIED(BAAJLNNPNBM FPFHIDBMBMI, [In] CNOGAFAGIEK.NJDCBKGCBAN AOGFOJGFMAN)
		{
			return default(JKEBLLKKBOM<CNOGAFAGIEK.MLCLAFLCHLN, CACBPFJIIIM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x280EDA0", Offset = "0x280DBA0", VA = "0x18280EDA0")]
		internal static JKEBLLKKBOM<(GPEEMOKJHIB, PKMOOKCLFLL), CACBPFJIIIM> HCGIIMJNDIN(BAAJLNNPNBM FPFHIDBMBMI, PKMOOKCLFLL GGCAJOENMAJ, bool HHFLHHPIIKB, [In] KOIDEEJEAKA<HJIDLNADIFB> NEPLJEOFELM, [In] int? NHAJFHEDLOG, [In] BHMLNBEKKIC? MIKDNIHKCHM, [In] BHMLNBEKKIC? CLKHHKBOFHC)
		{
			return default(JKEBLLKKBOM<(GPEEMOKJHIB, PKMOOKCLFLL), CACBPFJIIIM>);
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x2810600", Offset = "0x280F400", VA = "0x182810600")]
		private static void NCEOCPGJKHN(bool HHFLHHPIIKB, HDCAPCJGFLN KBPNMENODAC, GPEEMOKJHIB PACDIJPDCJO, [In] KOIDEEJEAKA<HJIDLNADIFB> NEPLJEOFELM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x280FBC0", Offset = "0x280E9C0", VA = "0x18280FBC0")]
		public static void JEAGGLBFKAH(DKCBLOOENML PLFEHNEBLOC, [In] CNOGAFAGIEK.FGHFEEELBFG BLBLHOCNPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057F")]
		[Cpp2IlInjected.Address(RVA = "0x2810510", Offset = "0x280F310", VA = "0x182810510")]
		[CompilerGenerated]
		internal static bool MKIELOFNINO(NNLJIKPEIHP FJJDOHOFNDK, HIDGDEMJMAO ENNNOJCNJCI, EIPFIANKEMH FHMMNLCGMDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x280ED70", Offset = "0x280DB70", VA = "0x18280ED70")]
		[CompilerGenerated]
		internal static bool ECJJBALLOKO(EIPFIANKEMH DCBFDJKHMOJ)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct LFFCDLPMAOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public BIHBDMOHDCK<HJIDLNADIFB> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public BIHBDMOHDCK<KCAEAGPDLDO> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public NPKPAEPCCIF offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public bool deleteBoard;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x280BD50", Offset = "0x280AB50", VA = "0x18280BD50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x280BFA0", Offset = "0x280ADA0", VA = "0x18280BFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private struct LNKGBHBJMLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public BIHBDMOHDCK<HJIDLNADIFB> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public KOIDEEJEAKA<KCAEAGPDLDO> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public List<BIHBDMOHDCK<KCAEAGPDLDO>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public NPKPAEPCCIF localBoardPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public OFJEKJFLDPF localBoardRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public NPKPAEPCCIF offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x280C620", Offset = "0x280B420", VA = "0x18280C620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x280C8E0", Offset = "0x280B6E0", VA = "0x18280C8E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private struct DJFKGDDBJBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public BIHBDMOHDCK<HJIDLNADIFB> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public KOIDEEJEAKA<KCAEAGPDLDO> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public List<BIHBDMOHDCK<KCAEAGPDLDO>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x28091F0", Offset = "0x2807FF0", VA = "0x1828091F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x2809430", Offset = "0x2808230", VA = "0x182809430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private struct ELGBBLCJDNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public BIHBDMOHDCK<HJIDLNADIFB> parentGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public KOIDEEJEAKA<KCAEAGPDLDO> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public BIHBDMOHDCK<HJIDLNADIFB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public List<BIHBDMOHDCK<KCAEAGPDLDO>> nodeIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x2809890", Offset = "0x2808690", VA = "0x182809890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x2809AD0", Offset = "0x28088D0", VA = "0x182809AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private struct LHONHBLDBKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public KOIDEEJEAKA<HJIDLNADIFB> legacyGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public KOIDEEJEAKA<KCAEAGPDLDO> boardNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public IReadOnlyList<KOIDEEJEAKA<KCAEAGPDLDO>> nodeLegacyIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public IReadOnlyDictionary<GCCOGDDGCAJ, (BIHBDMOHDCK<NGIHDDPPPGJ>, BIHBDMOHDCK<LBJKHBPAKKD>)> inputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public IReadOnlyDictionary<BHJJIGPBIBE, (BIHBDMOHDCK<NGIHDDPPPGJ>, BIHBDMOHDCK<FMHKAEJFBFI>)> outputMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x280C010", Offset = "0x280AE10", VA = "0x18280C010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x280C5C0", Offset = "0x280B3C0", VA = "0x18280C5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private struct IJECBPOHMEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public BIHBDMOHDCK<HJIDLNADIFB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public BIHBDMOHDCK<IEDJJDGMFHP> srcId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public BIHBDMOHDCK<KAJIMMHBMBI> dstId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x280A1B0", Offset = "0x2808FB0", VA = "0x18280A1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x280A800", Offset = "0x2809600", VA = "0x18280A800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private struct MGELCCEMCFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<BIHBDMOHDCK<KCAEAGPDLDO>, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public BIHBDMOHDCK<HJIDLNADIFB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public BIHBDMOHDCK<JBGDHIBENNA> nodeDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public NPKPAEPCCIF localSpacePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public OFJEKJFLDPF localSpaceRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private NNLJIKPEIHP <state>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<JKEBLLKKBOM<Guid, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x280CEA0", Offset = "0x280BCA0", VA = "0x18280CEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x280D320", Offset = "0x280C120", VA = "0x18280D320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private struct KFHNPDIENCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public BIHBDMOHDCK<HJIDLNADIFB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public BIHBDMOHDCK<KCAEAGPDLDO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private TaskAwaiter<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x280AD40", Offset = "0x2809B40", VA = "0x18280AD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059A")]
		[Cpp2IlInjected.Address(RVA = "0x280AFE0", Offset = "0x2809DE0", VA = "0x18280AFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private struct BIOLANJJIAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public KOIDEEJEAKA<KCAEAGPDLDO> inputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public KOIDEEJEAKA<HJIDLNADIFB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public BIHBDMOHDCK<NGIHDDPPPGJ> inputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public BIHBDMOHDCK<LBJKHBPAKKD> inputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059B")]
		[Cpp2IlInjected.Address(RVA = "0x2806B70", Offset = "0x2805970", VA = "0x182806B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x2806EB0", Offset = "0x2805CB0", VA = "0x182806EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private struct PPICNANDNFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public KOIDEEJEAKA<KCAEAGPDLDO> outputNodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public KOIDEEJEAKA<HJIDLNADIFB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public BIHBDMOHDCK<NGIHDDPPPGJ> outputPortGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public BIHBDMOHDCK<FMHKAEJFBFI> outputId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x2810A90", Offset = "0x280F890", VA = "0x182810A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x2810DD0", Offset = "0x280FBD0", VA = "0x182810DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private struct KMCMBKMHHON : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public BIHBDMOHDCK<HJIDLNADIFB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public BIHBDMOHDCK<KCAEAGPDLDO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x280B050", Offset = "0x2809E50", VA = "0x18280B050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x280B340", Offset = "0x280A140", VA = "0x18280B340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private struct NACCLJMFBBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<IEnumerable<KOIDEEJEAKA<KCAEAGPDLDO>>, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public KOIDEEJEAKA<HJIDLNADIFB> intoGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public IEnumerable<HDCAPCJGFLN> persistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public PKMOOKCLFLL templateData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private TaskAwaiter<JKEBLLKKBOM<IEnumerable<ANKFKDANALM>, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x280DCC0", Offset = "0x280CAC0", VA = "0x18280DCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x280E350", Offset = "0x280D150", VA = "0x18280E350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class JMJNDCHNJOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public BIHBDMOHDCK<HJIDLNADIFB> sourceGraphId;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public JMJNDCHNJOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x280ACB0", Offset = "0x2809AB0", VA = "0x18280ACB0")]
		internal KOIDEEJEAKA<KCAEAGPDLDO> JODLMNGOJBO(BIHBDMOHDCK<KCAEAGPDLDO> i)
		{
			return default(KOIDEEJEAKA<KCAEAGPDLDO>);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct MELGAGDNOLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x280CC10", Offset = "0x280BA10", VA = "0x18280CC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x280CE30", Offset = "0x280BC30", VA = "0x18280CE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private struct CJIBGLDAMBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public BIHBDMOHDCK<HJIDLNADIFB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public BIHBDMOHDCK<KCAEAGPDLDO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x2807400", Offset = "0x2806200", VA = "0x182807400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x28076A0", Offset = "0x28064A0", VA = "0x1828076A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private struct MMNLFNHPMNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public BIHBDMOHDCK<HJIDLNADIFB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public BIHBDMOHDCK<KCAEAGPDLDO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public BIHBDMOHDCK<NGIHDDPPPGJ> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public BIHBDMOHDCK<JAIKLOFJOLF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x280D6E0", Offset = "0x280C4E0", VA = "0x18280D6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x280DA50", Offset = "0x280C850", VA = "0x18280DA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct CFEKHAFMPLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public BIHBDMOHDCK<HJIDLNADIFB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public BIHBDMOHDCK<KCAEAGPDLDO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public BIHBDMOHDCK<NGIHDDPPPGJ> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public BIHBDMOHDCK<JAIKLOFJOLF> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x2806F20", Offset = "0x2805D20", VA = "0x182806F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x2807390", Offset = "0x2806190", VA = "0x182807390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct OGMIOJBHPFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public BIHBDMOHDCK<HJIDLNADIFB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public BIHBDMOHDCK<KCAEAGPDLDO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x280E850", Offset = "0x280D650", VA = "0x18280E850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x280EAF0", Offset = "0x280D8F0", VA = "0x18280EAF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct HNAABMGNJAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public BAAJLNNPNBM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public BIHBDMOHDCK<HJIDLNADIFB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public BIHBDMOHDCK<KCAEAGPDLDO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public NPKPAEPCCIF localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public OFJEKJFLDPF localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x2809B40", Offset = "0x2808940", VA = "0x182809B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x2809E90", Offset = "0x2808C90", VA = "0x182809E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	private readonly HBDCLDOGDAK BPKGJHGJDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private readonly ONOMLABGPBN BHAIPHKEDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private readonly LLDOMGLFOED IMKCCNDLIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	private readonly LMIKCCALENK FCNIHKJGPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002B1")]
	private readonly MMIMODOBHAE ALBPEMIJBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002B2")]
	private Dictionary<KOIDEEJEAKA<KCAEAGPDLDO>, IMKHFLEBFGP> ILDJKJHCDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	[CompilerGenerated]
	private Action<KOIDEEJEAKA<KCAEAGPDLDO>>? LFOMJBCCFOC;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public KOIDEEJEAKA<HJIDLNADIFB> NMKHOHDDLLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x27EADF0", Offset = "0x27E9BF0", VA = "0x1827EADF0", Slot = "4")]
		get
		{
			return default(KOIDEEJEAKA<HJIDLNADIFB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public LMIKCCALENK JHNBJIIODNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x27CEB00", Offset = "0x27CD900", VA = "0x1827CEB00", Slot = "5")]
		get
		{
			return default(LMIKCCALENK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x27EE190", Offset = "0x27ECF90", VA = "0x1827EE190")]
	public BAAJLNNPNBM(HBDCLDOGDAK PINKMLPHMFP, ONOMLABGPBN EHBLPMCHLFI, LLDOMGLFOED GDGPIDCODJB, MMIMODOBHAE NEGDHBDOMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x27EA350", Offset = "0x27E9150", VA = "0x1827EA350", Slot = "83")]
	public BIHBDMOHDCK<LCEAEOCLKEM> HDMJPFBPGFC(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP)
	{
		return default(BIHBDMOHDCK<LCEAEOCLKEM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0x27E9F80", Offset = "0x27E8D80", VA = "0x1827E9F80", Slot = "84")]
	public BIHBDMOHDCK<LNKAGJADDHE> GLOIDOAIDEE(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<IEDJJDGMFHP> ILNOKIIEBEH)
	{
		return default(BIHBDMOHDCK<LNKAGJADDHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x27EA3D0", Offset = "0x27E91D0", VA = "0x1827EA3D0", Slot = "6")]
	public (bool, bool) HFADMEKCHLE(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<IEDJJDGMFHP> IMLPHIHCCPJ, BIHBDMOHDCK<KAJIMMHBMBI> AGDBGFMOJFI)
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x27ECE70", Offset = "0x27EBC70", VA = "0x1827ECE70")]
	public bool OBPCCEEAFEJ(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, [In] NNKGEJKBJNA CJBKPGCKOCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x27E6E60", Offset = "0x27E5C60", VA = "0x1827E6E60", Slot = "8")]
	public bool CAPABMPDAMP(BPPIKLNCLPG OMGNBPDEBDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x27E5F90", Offset = "0x27E4D90", VA = "0x1827E5F90", Slot = "9")]
	public bool AFBMPPPDLBO(PKHOAGDLONP LDGHODOBIHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x27E6580", Offset = "0x27E5380", VA = "0x1827E6580", Slot = "10")]
	public FOHBHHDIGOI? AMJHEFMICHD(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x27EC5B0", Offset = "0x27EB3B0", VA = "0x1827EC5B0", Slot = "11")]
	public NOHOKKCGFBM? MPNAJEHCBHK(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<IEDJJDGMFHP> ILNOKIIEBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x27EB2F0", Offset = "0x27EA0F0", VA = "0x1827EB2F0", Slot = "12")]
	public BIHBDMOHDCK<IEDJJDGMFHP>? JGPEIAIANDK(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, BIHBDMOHDCK<FMHKAEJFBFI> DLHBKKAFANL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x27E68A0", Offset = "0x27E56A0", VA = "0x1827E68A0", Slot = "13")]
	public BIHBDMOHDCK<KAJIMMHBMBI>? BCKOPABAFBG(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, BIHBDMOHDCK<LBJKHBPAKKD> NDLHLMPDBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x27EAE50", Offset = "0x27E9C50", VA = "0x1827EAE50", Slot = "14")]
	public IEnumerable<BIHBDMOHDCK<HJIDLNADIFB>> IJEJELKJEMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x27EA000", Offset = "0x27E8E00", VA = "0x1827EA000", Slot = "15")]
	public IEnumerable<BIHBDMOHDCK<JOLDHKLOFKH>> GMJILEFKJFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x27E8960", Offset = "0x27E7760", VA = "0x1827E8960", Slot = "16")]
	public string ENBDMGEJCGP(BIHBDMOHDCK<JOLDHKLOFKH> OKIEIJEHFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x27EBD60", Offset = "0x27EAB60", VA = "0x1827EBD60", Slot = "17")]
	public string LCCFEAMFCAH(BIHBDMOHDCK<JOLDHKLOFKH> OKIEIJEHFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x27EA0B0", Offset = "0x27E8EB0", VA = "0x1827EA0B0")]
	public IMKHFLEBFGP? GMOGHCBLHCH([In] KOIDEEJEAKA<KCAEAGPDLDO> HLGNHFCFAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x27ECC40", Offset = "0x27EBA40", VA = "0x1827ECC40", Slot = "23")]
	public BIHBDMOHDCK<JBGDHIBENNA> NJGAKFNOJAB(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG)
	{
		return default(BIHBDMOHDCK<JBGDHIBENNA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x27E7620", Offset = "0x27E6420", VA = "0x1827E7620")]
	public BIHBDMOHDCK<KCAEAGPDLDO> CLGGMINLAIE(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, [In] KOIDEEJEAKA<KCAEAGPDLDO> IKELPABILGL)
	{
		return default(BIHBDMOHDCK<KCAEAGPDLDO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x27EAEE0", Offset = "0x27E9CE0", VA = "0x1827EAEE0", Slot = "33")]
	public BIHBDMOHDCK<KCAEAGPDLDO> IOBPEIOPFII(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP)
	{
		return default(BIHBDMOHDCK<KCAEAGPDLDO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x27EDDC0", Offset = "0x27ECBC0", VA = "0x1827EDDC0", Slot = "34")]
	public BIHBDMOHDCK<KCAEAGPDLDO> PDIIMLGIBLC(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<IEDJJDGMFHP> ILNOKIIEBEH)
	{
		return default(BIHBDMOHDCK<KCAEAGPDLDO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x27EC390", Offset = "0x27EB190", VA = "0x1827EC390")]
	public BIHBDMOHDCK<KCAEAGPDLDO>? MKEEIKPONHA(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, [In] KOIDEEJEAKA<KCAEAGPDLDO> IKELPABILGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x27E9E50", Offset = "0x27E8C50", VA = "0x1827E9E50", Slot = "25")]
	public JBOBNOAKEIH? GJBDDLKEKCH(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x27E8FA0", Offset = "0x27E7DA0", VA = "0x1827E8FA0", Slot = "26")]
	public long FMFKMILPGEH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x27E9830", Offset = "0x27E8630", VA = "0x1827E9830")]
	private void GCLKCBFDDCB(KOIDEEJEAKA<KCAEAGPDLDO> HLGNHFCFAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x27EACC0", Offset = "0x27E9AC0", VA = "0x1827EACC0", Slot = "31")]
	public IEnumerable<(BIHBDMOHDCK<HJIDLNADIFB>, BIHBDMOHDCK<KCAEAGPDLDO>)> HMEMPDIBBHM(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0x27E6810", Offset = "0x27E5610", VA = "0x1827E6810", Slot = "32")]
	public BIHBDMOHDCK<KAJIMMHBMBI> BCKOPABAFBG(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, BIHBDMOHDCK<LCEAEOCLKEM> NDLHLMPDBHK)
	{
		return default(BIHBDMOHDCK<KAJIMMHBMBI>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x27EB260", Offset = "0x27EA060", VA = "0x1827EB260", Slot = "35")]
	public BIHBDMOHDCK<IEDJJDGMFHP> JGPEIAIANDK(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, BIHBDMOHDCK<LNKAGJADDHE> DLHBKKAFANL)
	{
		return default(BIHBDMOHDCK<IEDJJDGMFHP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x27E6DB0", Offset = "0x27E5BB0", VA = "0x1827E6DB0")]
	private IMKHFLEBFGP? BOKLLIMIGPC([In] KOIDEEJEAKA<KCAEAGPDLDO> HLGNHFCFAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x27ED410", Offset = "0x27EC210", VA = "0x1827ED410")]
	public ANKFKDANALM? OMEODEIHEJG([In] KOIDEEJEAKA<KCAEAGPDLDO> HLGNHFCFAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x27E6F60", Offset = "0x27E5D60", VA = "0x1827E6F60")]
	public MJGAJOPCPPN? CEANPBNFNKA([In] KOIDEEJEAKA<HJIDLNADIFB> AEHJOFBOANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x27E91C0", Offset = "0x27E7FC0", VA = "0x1827E91C0", Slot = "27")]
	public IEnumerable<GEIOKELFMKH> FPNPNNMDAHK(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x27EDB70", Offset = "0x27EC970", VA = "0x1827EDB70", Slot = "28")]
	public bool PAPFADOJBJG(BIHBDMOHDCK<JOLDHKLOFKH> OKIEIJEHFDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x27EAF60", Offset = "0x27E9D60", VA = "0x1827EAF60", Slot = "29")]
	public IEnumerable<NNKGEJKBJNA> IPMKELDAHMK(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<IEDJJDGMFHP> IMLPHIHCCPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x27E6F90", Offset = "0x27E5D90", VA = "0x1827E6F90", Slot = "30")]
	public IEnumerable<NNKGEJKBJNA> CECHOHBHONA(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KAJIMMHBMBI> AGDBGFMOJFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x27EAD70", Offset = "0x27E9B70", VA = "0x1827EAD70")]
	public BIHBDMOHDCK<HJIDLNADIFB> IFPFADMIEEC([In] KOIDEEJEAKA<HJIDLNADIFB> AEHJOFBOANC)
	{
		return default(BIHBDMOHDCK<HJIDLNADIFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0x27EB1E0", Offset = "0x27E9FE0", VA = "0x1827EB1E0")]
	public BIHBDMOHDCK<HJIDLNADIFB>? JBLGFOBFBDB([In] KOIDEEJEAKA<HJIDLNADIFB> AEHJOFBOANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x27ED350", Offset = "0x27EC150", VA = "0x1827ED350")]
	private HIDGDEMJMAO? OKFGENMJBOD([In] KOIDEEJEAKA<HJIDLNADIFB> AEHJOFBOANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x27E6F60", Offset = "0x27E5D60", VA = "0x1827E6F60")]
	private MJGAJOPCPPN? MKIMLDNCJEG([In] KOIDEEJEAKA<HJIDLNADIFB> AEHJOFBOANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x27EE060", Offset = "0x27ECE60", VA = "0x1827EE060", Slot = "21")]
	public BIHBDMOHDCK<HJIDLNADIFB>? PPHCHEGBBKG(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x27E9640", Offset = "0x27E8440", VA = "0x1827E9640", Slot = "39")]
	public KOIDEEJEAKA<HJIDLNADIFB> GBCKGPCLCIA(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC)
	{
		return default(KOIDEEJEAKA<HJIDLNADIFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x27E7210", Offset = "0x27E6010", VA = "0x1827E7210", Slot = "40")]
	public KOIDEEJEAKA<KCAEAGPDLDO> CFCPFFLBFDO(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG)
	{
		return default(KOIDEEJEAKA<KCAEAGPDLDO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x27EDF60", Offset = "0x27ECD60", VA = "0x1827EDF60", Slot = "36")]
	public IEnumerable<EDIKHIAMCFO> POFBKNCEOFG(FFGKNPMOFPG BKAPNCNIAOM, bool CNODPBMNODF, bool EBGCJLBMHNO, bool JBNNGNJNPOM, bool HBMJOJAOLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x27E8C90", Offset = "0x27E7A90", VA = "0x1827E8C90", Slot = "37")]
	public EDIKHIAMCFO FJEPFDDLCLH(FFGKNPMOFPG BKAPNCNIAOM, GFPDJMBDKEG NMGPJGBBONP, bool CNODPBMNODF, bool EBGCJLBMHNO, bool JBNNGNJNPOM, bool HBMJOJAOLIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x27E77B0", Offset = "0x27E65B0", VA = "0x1827E77B0")]
	public GEIOKELFMKH MKHGCBJBGLI(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, [In] NNKGEJKBJNA CJBKPGCKOCO)
	{
		return default(GEIOKELFMKH);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x27EC750", Offset = "0x27EB550", VA = "0x1827EC750", Slot = "41")]
	public NNKGEJKBJNA NEAJJOOPKJK(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<IEDJJDGMFHP> IMLPHIHCCPJ, BIHBDMOHDCK<KAJIMMHBMBI> AGDBGFMOJFI)
	{
		return default(NNKGEJKBJNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x27E7920", Offset = "0x27E6720", VA = "0x1827E7920", Slot = "42")]
	[AsyncStateMachine(typeof(LFFCDLPMAOG))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> DCGCNBMCOED(BIHBDMOHDCK<HJIDLNADIFB> DNGCHPAKFHP, BIHBDMOHDCK<KCAEAGPDLDO> OPHMFHNEDON, NPKPAEPCCIF PPPFIBNDOMK, bool DJFNLAPCHFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x27E96B0", Offset = "0x27E84B0", VA = "0x1827E96B0", Slot = "43")]
	[AsyncStateMachine(typeof(LNKGBHBJMLD))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> GBNCFEICOJL(BIHBDMOHDCK<HJIDLNADIFB> DNGCHPAKFHP, KOIDEEJEAKA<KCAEAGPDLDO> OPHMFHNEDON, List<BIHBDMOHDCK<KCAEAGPDLDO>> MMKAKKPJHEB, NPKPAEPCCIF AIECJLIHALA, OFJEKJFLDPF ICLJKFENKGA, NPKPAEPCCIF PPPFIBNDOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x27ECAF0", Offset = "0x27EB8F0", VA = "0x1827ECAF0", Slot = "46")]
	[AsyncStateMachine(typeof(DJFKGDDBJBO))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> NIMMOENKHEL(BIHBDMOHDCK<HJIDLNADIFB> DNGCHPAKFHP, KOIDEEJEAKA<KCAEAGPDLDO> OPHMFHNEDON, List<BIHBDMOHDCK<KCAEAGPDLDO>> MMKAKKPJHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x27EBF80", Offset = "0x27EAD80", VA = "0x1827EBF80", Slot = "47")]
	[AsyncStateMachine(typeof(ELGBBLCJDNN))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> MCPIBDMDKGL(BIHBDMOHDCK<HJIDLNADIFB> DNGCHPAKFHP, KOIDEEJEAKA<KCAEAGPDLDO> OPHMFHNEDON, BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, List<BIHBDMOHDCK<KCAEAGPDLDO>> MMKAKKPJHEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x27EC980", Offset = "0x27EB780", VA = "0x1827EC980", Slot = "44")]
	public (IReadOnlyDictionary<GCCOGDDGCAJ, (BIHBDMOHDCK<NGIHDDPPPGJ>, BIHBDMOHDCK<LBJKHBPAKKD>)>, IReadOnlyDictionary<BHJJIGPBIBE, (BIHBDMOHDCK<NGIHDDPPPGJ>, BIHBDMOHDCK<FMHKAEJFBFI>)>) NEFEPJOIEEI(KOIDEEJEAKA<HJIDLNADIFB> ABDLIBPECLP, BIHBDMOHDCK<KCAEAGPDLDO> OPHMFHNEDON)
	{
		return default((IReadOnlyDictionary<GCCOGDDGCAJ, (BIHBDMOHDCK<NGIHDDPPPGJ>, BIHBDMOHDCK<LBJKHBPAKKD>)>, IReadOnlyDictionary<BHJJIGPBIBE, (BIHBDMOHDCK<NGIHDDPPPGJ>, BIHBDMOHDCK<FMHKAEJFBFI>)>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x27EAA10", Offset = "0x27E9810", VA = "0x1827EAA10", Slot = "45")]
	[AsyncStateMachine(typeof(LHONHBLDBKI))]
	public Task HJPGBMAGAOB(KOIDEEJEAKA<HJIDLNADIFB> ABDLIBPECLP, KOIDEEJEAKA<KCAEAGPDLDO> OPHMFHNEDON, IReadOnlyList<KOIDEEJEAKA<KCAEAGPDLDO>> BKJLBPEJGAO, IReadOnlyDictionary<GCCOGDDGCAJ, (BIHBDMOHDCK<NGIHDDPPPGJ>, BIHBDMOHDCK<LBJKHBPAKKD>)> AOAFMOGOGMK, IReadOnlyDictionary<BHJJIGPBIBE, (BIHBDMOHDCK<NGIHDDPPPGJ>, BIHBDMOHDCK<FMHKAEJFBFI>)> PBMOJBOKIGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x27E89D0", Offset = "0x27E77D0", VA = "0x1827E89D0", Slot = "48")]
	public bool EOABDEEEHIE(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0x27E9140", Offset = "0x27E7F40", VA = "0x1827E9140", Slot = "49")]
	public bool FMIDKEJKLPI(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x27E6EE0", Offset = "0x27E5CE0", VA = "0x1827E6EE0", Slot = "50")]
	public bool CDMBELEGLNN(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<IEDJJDGMFHP> ILNOKIIEBEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x27E5F60", Offset = "0x27E4D60", VA = "0x1827E5F60")]
	public JKEBLLKKBOM<CNOGAFAGIEK.MLCLAFLCHLN, CACBPFJIIIM> JOHHJGKNHFK([In] CNOGAFAGIEK.NJDCBKGCBAN AOGFOJGFMAN)
	{
		return default(JKEBLLKKBOM<CNOGAFAGIEK.MLCLAFLCHLN, CACBPFJIIIM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x27EC480", Offset = "0x27EB280", VA = "0x1827EC480", Slot = "52")]
	[AsyncStateMachine(typeof(IJECBPOHMEH))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> MOKNBCFGFAO(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<IEDJJDGMFHP> IMLPHIHCCPJ, BIHBDMOHDCK<KAJIMMHBMBI> AGDBGFMOJFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x27E6250", Offset = "0x27E5050", VA = "0x1827E6250", Slot = "53")]
	[AsyncStateMachine(typeof(MGELCCEMCFG))]
	public Task<JKEBLLKKBOM<BIHBDMOHDCK<KCAEAGPDLDO>, CHEIGOJMDOJ>> AHGIGJAJEAF(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<JBGDHIBENNA> JONFANGPPNH, NPKPAEPCCIF HMPPOAHJGEJ, OFJEKJFLDPF JDIEDMPOKHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x27EA8D0", Offset = "0x27E96D0", VA = "0x1827EA8D0", Slot = "54")]
	[AsyncStateMachine(typeof(KFHNPDIENCA))]
	public Task<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> HJNOCAJMBDB(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, string IHGFMOMOADA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x27E9280", Offset = "0x27E8080", VA = "0x1827E9280", Slot = "55")]
	public JKEBLLKKBOM<IHDOMNEMEBB, LPPJEHMJDEA> GAFLAPPAOCC(KOIDEEJEAKA<HJIDLNADIFB> AEHJOFBOANC, IHDOMNEMEBB DMNEDJCCCJI, OFJEKJFLDPF CGGPMKNOANN)
	{
		return default(JKEBLLKKBOM<IHDOMNEMEBB, LPPJEHMJDEA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x27EAB60", Offset = "0x27E9960", VA = "0x1827EAB60", Slot = "56")]
	[AsyncStateMachine(typeof(BIOLANJJIAL))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> HLAIJGLDDLP(KOIDEEJEAKA<HJIDLNADIFB> AEHJOFBOANC, KOIDEEJEAKA<KCAEAGPDLDO> LBGFLIFJNJO, BIHBDMOHDCK<NGIHDDPPPGJ> EOMJGDMDOEC, BIHBDMOHDCK<LBJKHBPAKKD> OIEAMJCBCEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x27E7BD0", Offset = "0x27E69D0", VA = "0x1827E7BD0", Slot = "57")]
	[AsyncStateMachine(typeof(PPICNANDNFO))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> DFJCDGBNIIO(KOIDEEJEAKA<HJIDLNADIFB> AEHJOFBOANC, KOIDEEJEAKA<KCAEAGPDLDO> KDACPKIBFAE, BIHBDMOHDCK<NGIHDDPPPGJ> LPEMFNFHOBC, BIHBDMOHDCK<FMHKAEJFBFI> ILNOKIIEBEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x27E7D30", Offset = "0x27E6B30", VA = "0x1827E7D30", Slot = "58")]
	[AsyncStateMachine(typeof(KMCMBKMHHON))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> DJHFPOPHLOJ(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x27E7A70", Offset = "0x27E6870", VA = "0x1827E7A70", Slot = "59")]
	[AsyncStateMachine(typeof(NACCLJMFBBJ))]
	public Task<JKEBLLKKBOM<IEnumerable<KOIDEEJEAKA<KCAEAGPDLDO>>, CHEIGOJMDOJ>> DDDLKMHKLAO(KOIDEEJEAKA<HJIDLNADIFB> ENFDOCEMLPH, PKMOOKCLFLL HFPIFEMGIJK, IEnumerable<HDCAPCJGFLN> OAGFADOJLLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x27E6640", Offset = "0x27E5440", VA = "0x1827E6640", Slot = "60")]
	public CMOJNAJMKPK AODKCBHBEGB()
	{
		return default(CMOJNAJMKPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x27EDE40", Offset = "0x27ECC40", VA = "0x1827EDE40", Slot = "61")]
	public CMOJNAJMKPK PMOBPKABOLD()
	{
		return default(CMOJNAJMKPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x27E6070", Offset = "0x27E4E70", VA = "0x1827E6070", Slot = "64")]
	public BDLGFJNJDCC AGNEDLFEIOE(IJJFOFKKKJK PFAHPNGOBCL, BIHBDMOHDCK<HJIDLNADIFB> GBMPLCJAMFH, IEnumerable<KOIDEEJEAKA<HJIDLNADIFB>> OKPMAFMPEBO, IEnumerable<KOIDEEJEAKA<KCAEAGPDLDO>> MMKAKKPJHEB, ISet<KOIDEEJEAKA<NDGLMIGFFOL>>? OEBFGIODOKM)
	{
		return default(BDLGFJNJDCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x27EDC00", Offset = "0x27ECA00", VA = "0x1827EDC00")]
	private BDLGFJNJDCC PCAFNNGJENH(IJJFOFKKKJK PFAHPNGOBCL, BIHBDMOHDCK<HJIDLNADIFB> GBMPLCJAMFH, IEnumerable<KOIDEEJEAKA<HJIDLNADIFB>> OKPMAFMPEBO, IEnumerable<KOIDEEJEAKA<KCAEAGPDLDO>> MMKAKKPJHEB, ISet<KOIDEEJEAKA<NDGLMIGFFOL>>? OEBFGIODOKM)
	{
		return default(BDLGFJNJDCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x27E6930", Offset = "0x27E5730", VA = "0x1827E6930", Slot = "62")]
	public BDLGFJNJDCC BFBJFMDHBID(IJJFOFKKKJK PFAHPNGOBCL, BIHBDMOHDCK<HJIDLNADIFB> GBMPLCJAMFH, IEnumerable<KOIDEEJEAKA<KCAEAGPDLDO>> MMKAKKPJHEB, IEnumerable<HDCAPCJGFLN> OAGFADOJLLC, ISet<KOIDEEJEAKA<NDGLMIGFFOL>>? OEBFGIODOKM)
	{
		return default(BDLGFJNJDCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x27E6BD0", Offset = "0x27E59D0", VA = "0x1827E6BD0", Slot = "63")]
	public BDLGFJNJDCC BFBJFMDHBID(IJJFOFKKKJK PFAHPNGOBCL, BIHBDMOHDCK<HJIDLNADIFB> GBMPLCJAMFH, IEnumerable<BIHBDMOHDCK<KCAEAGPDLDO>> MMKAKKPJHEB, IEnumerable<HDCAPCJGFLN> OAGFADOJLLC, ISet<KOIDEEJEAKA<NDGLMIGFFOL>>? OEBFGIODOKM)
	{
		return default(BDLGFJNJDCC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x27E72A0", Offset = "0x27E60A0", VA = "0x1827E72A0")]
	private static IEnumerable<KOIDEEJEAKA<HJIDLNADIFB>> CLACKPBMLBM(IEnumerable<HDCAPCJGFLN> OAGFADOJLLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x27E99B0", Offset = "0x27E87B0", VA = "0x1827E99B0")]
	private IEnumerable<KOIDEEJEAKA<KCAEAGPDLDO>> GFAOHEBBJLI(IEnumerable<HDCAPCJGFLN> OAGFADOJLLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x27EC0E0", Offset = "0x27EAEE0", VA = "0x1827EC0E0", Slot = "65")]
	public List<FJGHJJMHCEO> MCPLKFHNBIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x27ED4A0", Offset = "0x27EC2A0", VA = "0x1827ED4A0")]
	public (List<FJGHJJMHCEO>, bool) OMGCHOJJNLA([In] BDNCDJIILIC MCBMHCNBMGC, string JAPGNGDBBIF, [In] CGNBGOCAAPG MCFFJIGJFLF, MHCDCFBPCHG LNEEHDMNACK, MFKBGMJPIHI NBIEJECEKIA)
	{
		return default((List<FJGHJJMHCEO>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x27ED1E0", Offset = "0x27EBFE0", VA = "0x1827ED1E0", Slot = "67")]
	public bool OEDJOPKEMKK(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x27E6010", Offset = "0x27E4E10", VA = "0x1827E6010")]
	internal void AGAIIMEKIBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x27ECCC0", Offset = "0x27EBAC0", VA = "0x1827ECCC0")]
	internal Task NLABLEECHCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x27EB380", Offset = "0x27EA180", VA = "0x1827EB380", Slot = "68")]
	public JKEBLLKKBOM<BIHBDMOHDCK<IEDJJDGMFHP>?, CHEIGOJMDOJ> JLDFBPJADLF(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, BIHBDMOHDCK<KAJIMMHBMBI> OIEAMJCBCEP)
	{
		return default(JKEBLLKKBOM<BIHBDMOHDCK<IEDJJDGMFHP>?, CHEIGOJMDOJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x27E7E40", Offset = "0x27E6C40", VA = "0x1827E7E40", Slot = "69")]
	public JKEBLLKKBOM<BIHBDMOHDCK<KAJIMMHBMBI>?, CHEIGOJMDOJ> EAGKFAHHHGB(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, BIHBDMOHDCK<IEDJJDGMFHP> ILNOKIIEBEH)
	{
		return default(JKEBLLKKBOM<BIHBDMOHDCK<KAJIMMHBMBI>?, CHEIGOJMDOJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x27EC170", Offset = "0x27EAF70", VA = "0x1827EC170", Slot = "70")]
	[AsyncStateMachine(typeof(MELGAGDNOLG))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> MIFPKOOGOLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0x27E8A40", Offset = "0x27E7840", VA = "0x1827E8A40", Slot = "71")]
	[AsyncStateMachine(typeof(CJIBGLDAMBB))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> FCFIGBJKIPJ(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, string IHGFMOMOADA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0x27EA220", Offset = "0x27E9020", VA = "0x1827EA220", Slot = "72")]
	public BIHBDMOHDCK<KCAEAGPDLDO>? HCPIBPJADDH(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x27EC260", Offset = "0x27EB060", VA = "0x1827EC260", Slot = "73")]
	public BIHBDMOHDCK<KCAEAGPDLDO>? MJDBNHADNIJ(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x27E6760", Offset = "0x27E5560", VA = "0x1827E6760", Slot = "74")]
	public int BADIFOGBEOP(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0x27E98C0", Offset = "0x27E86C0", VA = "0x1827E98C0", Slot = "75")]
	public int GDCHHCMFLBF(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0x27E8B80", Offset = "0x27E7980", VA = "0x1827E8B80", Slot = "76")]
	public int FDGNFAMNFMP(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, BIHBDMOHDCK<JAIKLOFJOLF> AEIPGBEAKCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x27E76A0", Offset = "0x27E64A0", VA = "0x1827E76A0", Slot = "77")]
	public int COBKGCPDFJC(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, BIHBDMOHDCK<JAIKLOFJOLF> AEIPGBEAKCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x27ECD30", Offset = "0x27EBB30", VA = "0x1827ECD30", Slot = "78")]
	[AsyncStateMachine(typeof(MMNLFNHPMNJ))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> NPEPMJDGAPE(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, BIHBDMOHDCK<JAIKLOFJOLF> AEIPGBEAKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x27EBE40", Offset = "0x27EAC40", VA = "0x1827EBE40", Slot = "79")]
	[AsyncStateMachine(typeof(CFEKHAFMPLL))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> LPNEGHBADGM(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, BIHBDMOHDCK<JAIKLOFJOLF> AEIPGBEAKCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x27EC670", Offset = "0x27EB470", VA = "0x1827EC670", Slot = "80")]
	public int NAKIPBODEKN(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x27E9000", Offset = "0x27E7E00", VA = "0x1827E9000", Slot = "81")]
	[AsyncStateMachine(typeof(OGMIOJBHPFJ))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> FMGCAACJJJA(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, string OAIIHELJHLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0x27E63B0", Offset = "0x27E51B0", VA = "0x1827E63B0", Slot = "82")]
	[AsyncStateMachine(typeof(HNAABMGNJAD))]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> AJANKLFJPON(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG, NPKPAEPCCIF IMPLDPKOJAO, OFJEKJFLDPF MEPKHADFMCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0x27EBD50", Offset = "0x27EAB50", VA = "0x1827EBD50", Slot = "7")]
	private bool KPHHKNCAPEG(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, [In] NNKGEJKBJNA CJBKPGCKOCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0x27E6F60", Offset = "0x27E5D60", VA = "0x1827E6F60", Slot = "18")]
	private MJGAJOPCPPN NHKMNLJIING([In] KOIDEEJEAKA<HJIDLNADIFB> AEHJOFBOANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0x27E7290", Offset = "0x27E6090", VA = "0x1827E7290", Slot = "19")]
	private BIHBDMOHDCK<HJIDLNADIFB> CKJCCEDJIPL([In] KOIDEEJEAKA<HJIDLNADIFB> AEHJOFBOANC)
	{
		return default(BIHBDMOHDCK<HJIDLNADIFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0x27EB1E0", Offset = "0x27E9FE0", VA = "0x1827EB1E0", Slot = "20")]
	private BIHBDMOHDCK<HJIDLNADIFB>? JMCIKJFCMEC([In] KOIDEEJEAKA<HJIDLNADIFB> AEHJOFBOANC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x27E8810", Offset = "0x27E7610", VA = "0x1827E8810", Slot = "22")]
	private IMKHFLEBFGP EJEDMENEODA([In] KOIDEEJEAKA<KCAEAGPDLDO> HLGNHFCFAMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x27ECD20", Offset = "0x27EBB20", VA = "0x1827ECD20", Slot = "24")]
	private BIHBDMOHDCK<KCAEAGPDLDO> NMLJBJDIBGM(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, [In] KOIDEEJEAKA<KCAEAGPDLDO> IKELPABILGL)
	{
		return default(BIHBDMOHDCK<KCAEAGPDLDO>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x27E77B0", Offset = "0x27E65B0", VA = "0x1827E77B0", Slot = "38")]
	private GEIOKELFMKH COIAIDOICEB(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, [In] NNKGEJKBJNA CJBKPGCKOCO)
	{
		return default(GEIOKELFMKH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x27E5F60", Offset = "0x27E4D60", VA = "0x1827E5F60", Slot = "51")]
	private JKEBLLKKBOM<CNOGAFAGIEK.MLCLAFLCHLN, CACBPFJIIIM> ADKBICIIGED([In] CNOGAFAGIEK.NJDCBKGCBAN AOGFOJGFMAN)
	{
		return default(JKEBLLKKBOM<CNOGAFAGIEK.MLCLAFLCHLN, CACBPFJIIIM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x27E6D50", Offset = "0x27E5B50", VA = "0x1827E6D50", Slot = "66")]
	private (List<FJGHJJMHCEO>, bool) BKINHFAPBAM([In] BDNCDJIILIC MCBMHCNBMGC, string JAPGNGDBBIF, [In] CGNBGOCAAPG MCFFJIGJFLF, MHCDCFBPCHG LNEEHDMNACK, MFKBGMJPIHI NBIEJECEKIA)
	{
		return default((List<FJGHJJMHCEO>, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x27ED2D0", Offset = "0x27EC0D0", VA = "0x1827ED2D0")]
	[CompilerGenerated]
	private OFCHKIHICAL OGECKBGDAJK(IAGGNMMOHFK CPKBMDHHFLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x27E6510", Offset = "0x27E5310", VA = "0x1827E6510")]
	[CompilerGenerated]
	private ANKFKDANALM AJKMLFDJKEB(KOIDEEJEAKA<KCAEAGPDLDO> CPKBMDHHFLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x27EC410", Offset = "0x27EB210", VA = "0x1827EC410")]
	[CompilerGenerated]
	private HIDGDEMJMAO MNFEHAANPCP(KOIDEEJEAKA<HJIDLNADIFB> CPKBMDHHFLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0x27E6CE0", Offset = "0x27E5AE0", VA = "0x1827E6CE0")]
	[CompilerGenerated]
	private ANKFKDANALM BKDFMCIINDF(KOIDEEJEAKA<KCAEAGPDLDO> CPKBMDHHFLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x27EBDD0", Offset = "0x27EABD0", VA = "0x1827EBDD0")]
	[CompilerGenerated]
	private HIDGDEMJMAO LIGPJFJOKAA(KOIDEEJEAKA<HJIDLNADIFB> CPKBMDHHFLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
public sealed class OFCHKIHICAL : EDIKHIAMCFO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private struct IPDOLAMHEMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<BIHBDMOHDCK<JAIKLOFJOLF>, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public OFCHKIHICAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public KOIDEEJEAKA<HJIDLNADIFB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public KOIDEEJEAKA<KCAEAGPDLDO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public BIHBDMOHDCK<NGIHDDPPPGJ> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private TaskAwaiter<JKEBLLKKBOM<BIHBDMOHDCK<JAIKLOFJOLF>, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x280A9C0", Offset = "0x28097C0", VA = "0x18280A9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x280AC40", Offset = "0x2809A40", VA = "0x18280AC40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private struct MILJANIDJGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<BIHBDMOHDCK<OHFDADNMMNM>, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public OFCHKIHICAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public KOIDEEJEAKA<HJIDLNADIFB> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public KOIDEEJEAKA<KCAEAGPDLDO> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public BIHBDMOHDCK<NGIHDDPPPGJ> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private TaskAwaiter<JKEBLLKKBOM<BIHBDMOHDCK<OHFDADNMMNM>, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x280D390", Offset = "0x280C190", VA = "0x18280D390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x280D610", Offset = "0x280C410", VA = "0x18280D610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private readonly IAGGNMMOHFK FGJMNGHHPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private readonly ONOMLABGPBN BHAIPHKEDGJ;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public TypeKey FEGMCLPCCKF
	{
		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public string HHJKIMEPIBM
	{
		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x2807B10", Offset = "0x2806910", VA = "0x182807B10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public IAGGNMMOHFK DPKFIIMJGMA
	{
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x280E7B0", Offset = "0x280D5B0", VA = "0x18280E7B0")]
	public OFCHKIHICAL(IAGGNMMOHFK PAIJICBBKGI, ONOMLABGPBN EHBLPMCHLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x280E640", Offset = "0x280D440", VA = "0x18280E640", Slot = "6")]
	[AsyncStateMachine(typeof(IPDOLAMHEMK))]
	public Task<JKEBLLKKBOM<BIHBDMOHDCK<JAIKLOFJOLF>, CHEIGOJMDOJ>> LKNLFCLKEAH(KOIDEEJEAKA<HJIDLNADIFB> AEHJOFBOANC, KOIDEEJEAKA<KCAEAGPDLDO> HLGNHFCFAMG, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, string IHGFMOMOADA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x280E4D0", Offset = "0x280D2D0", VA = "0x18280E4D0", Slot = "7")]
	[AsyncStateMachine(typeof(MILJANIDJGJ))]
	public Task<JKEBLLKKBOM<BIHBDMOHDCK<OHFDADNMMNM>, CHEIGOJMDOJ>> JDJAHLCDHPO(KOIDEEJEAKA<HJIDLNADIFB> AEHJOFBOANC, KOIDEEJEAKA<KCAEAGPDLDO> HLGNHFCFAMG, BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC, string IHGFMOMOADA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F5")]
public sealed class DFGIEBJPDIO : AMCEMHPCNJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000359")]
	private readonly IAGGNMMOHFK CKAKNAJCEKE;

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private static readonly HashSet<IAGGNMMOHFK> MBOJHKALHDL;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private static readonly HashSet<IAGGNMMOHFK> HBAADCKBNPN;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private static readonly HashSet<IAGGNMMOHFK> OHDKCKGACJD;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public TypeKey IKLJNBNIMEB
	{
		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x2809080", Offset = "0x2807E80", VA = "0x182809080", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool JJJJKFAGNAB
	{
		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x2809070", Offset = "0x2807E70", VA = "0x182809070", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool PEDKLADNHIN
	{
		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x28090D0", Offset = "0x2807ED0", VA = "0x1828090D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool OFEEBFEBFMB
	{
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x2808FF0", Offset = "0x2807DF0", VA = "0x182808FF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0x2807710", Offset = "0x2806510", VA = "0x182807710")]
	public bool KFANGKAFJMA(string OAIIHELJHLG, [Out] GEDHHGFCHLC BAKILLOIKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public DFGIEBJPDIO(IAGGNMMOHFK OMKBHAHHOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0x2807980", Offset = "0x2806780", VA = "0x182807980")]
	internal static TypeKey LEJIIPKHFGM(IAGGNMMOHFK AAFMBEEMJAC)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0x2807B10", Offset = "0x2806910", VA = "0x182807B10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public readonly struct IPDKADPDBAD : PPAIEIINDHH.BBMLNAGAEIP<CMGFJHDBEGO, NICNPLCGCEF>
{
	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x280A9A0", Offset = "0x28097A0", VA = "0x18280A9A0", Slot = "4")]
	public int PNIHKHLDPNG(NICNPLCGCEF AOJFFKDCAKJ, CMGFJHDBEGO CFDGGKIIHOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x280A8D0", Offset = "0x28096D0", VA = "0x18280A8D0", Slot = "5")]
	public CMGFJHDBEGO DPBADPKFEEG(NICNPLCGCEF AOJFFKDCAKJ, CMGFJHDBEGO CFDGGKIIHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x280A880", Offset = "0x2809680", VA = "0x18280A880", Slot = "6")]
	public CMGFJHDBEGO DDAPPACCODO(NICNPLCGCEF AOJFFKDCAKJ, CMGFJHDBEGO CFDGGKIIHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x280A920", Offset = "0x2809720", VA = "0x18280A920", Slot = "7")]
	public IReadOnlyList<CMGFJHDBEGO> GFABBOELCHD(NICNPLCGCEF AOJFFKDCAKJ, CMGFJHDBEGO CFDGGKIIHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x280A870", Offset = "0x2809670", VA = "0x18280A870", Slot = "8")]
	public CMGFJHDBEGO[] BPDAEPJMPDA(NICNPLCGCEF AOJFFKDCAKJ, CMGFJHDBEGO CFDGGKIIHOI, int CFODOPAGHMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x280A940", Offset = "0x2809740", VA = "0x18280A940", Slot = "9")]
	public bool IKAEKBOLCHI(NICNPLCGCEF AOJFFKDCAKJ, CMGFJHDBEGO CFDGGKIIHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x280A8B0", Offset = "0x28096B0", VA = "0x18280A8B0", Slot = "10")]
	public bool DEOOJIILGII(NICNPLCGCEF AOJFFKDCAKJ, CMGFJHDBEGO CFDGGKIIHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0x280A980", Offset = "0x2809780", VA = "0x18280A980", Slot = "11")]
	public bool NPPJBDMGFED(NICNPLCGCEF AOJFFKDCAKJ, CMGFJHDBEGO CFDGGKIIHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0x280A960", Offset = "0x2809760", VA = "0x18280A960", Slot = "12")]
	public bool MJINGBOELCB(NICNPLCGCEF AOJFFKDCAKJ, CMGFJHDBEGO CFDGGKIIHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0x280A900", Offset = "0x2809700", VA = "0x18280A900", Slot = "13")]
	public bool FPOIIKHHJJG(NICNPLCGCEF GMKLNKGAFCK, CMGFJHDBEGO CFDGGKIIHOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0x280A8E0", Offset = "0x28096E0", VA = "0x18280A8E0", Slot = "14")]
	public bool ELEJAEKGEDK(NICNPLCGCEF AOJFFKDCAKJ, CMGFJHDBEGO CFDGGKIIHOI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F7")]
public abstract class KMDAOAHHIFL : IKMAMAHLHMO
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public NIBMFBMFLGC.AKJNGJKLMAC FCELHOAPNGD
	{
		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x280B3B0", Offset = "0x280A1B0", VA = "0x18280B3B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public abstract DIFGANNFPID.OEKIHGBCEEC CAAKLLMPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public abstract HBDCLDOGDAK.PBNOGBMLKJF PLLANNGBADD
	{
		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public abstract HNLPMDFGNGL.LECFMDNGEBF MEGEGLFOGNI
	{
		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public GGBCFBLMLAI.HLFJKDAONLJ<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK> PLJNKBNICJG
	{
		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x280B400", Offset = "0x280A200", VA = "0x18280B400", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public abstract OALFCEOMBCC.PHHLMNPFINA MAJALBDIOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public abstract JEAFHHJHNHG GMMJNAHCMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public abstract EOMAFEHEGOI GHPKLPMKACO
	{
		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public abstract CPNBFAFEOAK BLDEGIPKNPD
	{
		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public abstract ECGAGLEJEGA JFEMFFELPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public abstract LILPBIECJKB NLIPKEJHANA
	{
		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	protected KMDAOAHHIFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public sealed class MDNOCCLAMGB : KFICELEAKOK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private struct BFIPHDDKKBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<object, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public MDNOCCLAMGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public CMGFJHDBEGO action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private TaskAwaiter<JKEBLLKKBOM<object, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x2806860", Offset = "0x2805660", VA = "0x182806860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x2806B00", Offset = "0x2805900", VA = "0x182806B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private struct EIBNKFEEMNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public MDNOCCLAMGB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public IReadOnlyList<CMGFJHDBEGO> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private TaskAwaiter<JKEBLLKKBOM<object, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x28094A0", Offset = "0x28082A0", VA = "0x1828094A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x2809820", Offset = "0x2808620", VA = "0x182809820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly OEINHBKKCEG MEGMMBGGBGD;

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public MDNOCCLAMGB(OEINHBKKCEG GOMEADMMGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0x280C9B0", Offset = "0x280B7B0", VA = "0x18280C9B0")]
	[AsyncStateMachine(typeof(BFIPHDDKKBG))]
	private Task<JKEBLLKKBOM<object, CHEIGOJMDOJ>> GLABPHHLEHF(CMGFJHDBEGO CFDGGKIIHOI, bool DPAGNCPIBHD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x280CAE0", Offset = "0x280B8E0", VA = "0x18280CAE0", Slot = "4")]
	[AsyncStateMachine(typeof(EIBNKFEEMNF))]
	public Task<JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ>> HEHNAFGEKAK(IReadOnlyList<CMGFJHDBEGO> GONMDJMHKJC, bool DPAGNCPIBHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public struct MKAEFBADJHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036A")]
	internal PIEIHNNDLKH<NDIACELDEDD, KOIDEEJEAKA<NDIACELDEDD.NIKPOJHLKNB>, CMGFJHDBEGO, MPOECCJKEEJ> CKAKNAJCEKE;

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x111ADE0", Offset = "0x1119BE0", VA = "0x18111ADE0")]
	private MKAEFBADJHL([In] PIEIHNNDLKH<NDIACELDEDD, KOIDEEJEAKA<NDIACELDEDD.NIKPOJHLKNB>, CMGFJHDBEGO, MPOECCJKEEJ> DKEBHBLHNAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x280D680", Offset = "0x280C480", VA = "0x18280D680")]
	public static MKAEFBADJHL NBEICDCLFEE()
	{
		return default(MKAEFBADJHL);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public static class IGNPGDBIHBO
{
	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static PIEIHNNDLKH<NDIACELDEDD, KOIDEEJEAKA<NDIACELDEDD.NIKPOJHLKNB>, CMGFJHDBEGO, MPOECCJKEEJ> ECBMIFAGFAB(this MKAEFBADJHL FPFHIDBMBMI)
	{
		return default(PIEIHNNDLKH<NDIACELDEDD, KOIDEEJEAKA<NDIACELDEDD.NIKPOJHLKNB>, CMGFJHDBEGO, MPOECCJKEEJ>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public struct MPOECCJKEEJ : HDGNHPEACAC.FCGIDFIMLPK<NDIACELDEDD, KOIDEEJEAKA<NDIACELDEDD.NIKPOJHLKNB>, CMGFJHDBEGO>
{
	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0x280DAD0", Offset = "0x280C8D0", VA = "0x18280DAD0", Slot = "7")]
	public CMGFJHDBEGO HJJOMLGHNOE(NDIACELDEDD[] IDOAHEBMBDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0x110E410", Offset = "0x110D210", VA = "0x18110E410")]
	public KOIDEEJEAKA<NDIACELDEDD.NIKPOJHLKNB> GJHBIOCJDGI([In] NDIACELDEDD JFLHIPLDHAD)
	{
		return default(KOIDEEJEAKA<NDIACELDEDD.NIKPOJHLKNB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0x112A610", Offset = "0x1129410", VA = "0x18112A610")]
	public int POADKCFNPAF([In] NDIACELDEDD HGHIJJFGAHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0x280DAC0", Offset = "0x280C8C0", VA = "0x18280DAC0")]
	public int HMHIHPICFDJ([In] NDIACELDEDD JFLHIPLDHAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x112A610", Offset = "0x1129410", VA = "0x18112A610", Slot = "4")]
	private int GNPGDIOPICO([In] NDIACELDEDD JFLHIPLDHAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0x280DAC0", Offset = "0x280C8C0", VA = "0x18280DAC0", Slot = "5")]
	private int GFNFMAEOAFI([In] NDIACELDEDD JFLHIPLDHAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0x110E410", Offset = "0x110D210", VA = "0x18110E410", Slot = "6")]
	private KOIDEEJEAKA<NDIACELDEDD.NIKPOJHLKNB> FPPFOAOPEHF([In] NDIACELDEDD JFLHIPLDHAD)
	{
		return default(KOIDEEJEAKA<NDIACELDEDD.NIKPOJHLKNB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public struct MCDHLBPPKMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400036D")]
	internal NCPFNLGHDEG<FPGCPCELCAJ, CMGFJHDBEGO, OKJEONGLFEH> CKAKNAJCEKE;

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x111ADE0", Offset = "0x1119BE0", VA = "0x18111ADE0")]
	private MCDHLBPPKMD([In] NCPFNLGHDEG<FPGCPCELCAJ, CMGFJHDBEGO, OKJEONGLFEH> MBIKAOFOCHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x280C950", Offset = "0x280B750", VA = "0x18280C950")]
	public static MCDHLBPPKMD NBEICDCLFEE()
	{
		return default(MCDHLBPPKMD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
public static class OOJIJILDDGL
{
	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030")]
	public static NCPFNLGHDEG<FPGCPCELCAJ, CMGFJHDBEGO, OKJEONGLFEH> ECBMIFAGFAB(this MCDHLBPPKMD FPFHIDBMBMI)
	{
		return default(NCPFNLGHDEG<FPGCPCELCAJ, CMGFJHDBEGO, OKJEONGLFEH>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000101")]
public struct OKJEONGLFEH : NDLJMBHHPGD.EABEAPHDOKE<FPGCPCELCAJ, CMGFJHDBEGO>
{
	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0x21E85F0", Offset = "0x21E73F0", VA = "0x1821E85F0")]
	public int FNGDIAIKAOK([In] FPGCPCELCAJ HGHIJJFGAHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x280EB60", Offset = "0x280D960", VA = "0x18280EB60", Slot = "5")]
	public CMGFJHDBEGO ODMEJJMDKHB(FPGCPCELCAJ[] GICMDFDMNAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x21E85F0", Offset = "0x21E73F0", VA = "0x1821E85F0", Slot = "4")]
	private int PILJCDBJNPG([In] FPGCPCELCAJ HGHIJJFGAHO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000103")]
public class HNLFPGALCDO : DDPPOHMMKFK, CACBPFJIIIM, CHEIGOJMDOJ, LPPJEHMJDEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000371")]
	private readonly LPPJEHMJDEA? MABLKLIKAGE;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public DDEKFMILEFN OAKEFDPCEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0xA0D990", Offset = "0xA0C790", VA = "0x180A0D990", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(DDEKFMILEFN);
		}
		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0xA148C0", Offset = "0xA136C0", VA = "0x180A148C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public override LPPJEHMJDEA? DKBLDDPPINA
	{
		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x2809F70", Offset = "0x2808D70", VA = "0x182809F70", Slot = "7")]
	public override string EEHOEKHGKPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x280A170", Offset = "0x2808F70", VA = "0x18280A170")]
	private HNLFPGALCDO(DDEKFMILEFN OEFNLALAAAN, LPPJEHMJDEA? DEFMDPDEKLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x280A080", Offset = "0x2808E80", VA = "0x18280A080")]
	public static HNLFPGALCDO MCEICAHIDDL(LPPJEHMJDEA DEFMDPDEKLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x280A100", Offset = "0x2808F00", VA = "0x18280A100")]
	public static HNLFPGALCDO MLGIEJCEBHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x2809F00", Offset = "0x2808D00", VA = "0x182809F00")]
	public static HNLFPGALCDO BKEFPGEPBKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
public static class BIAKFOMMMCE
{
	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x369F8D0", Offset = "0x369E6D0", VA = "0x18369F8D0")]
	public static JKEBLLKKBOM<TOk, CACBPFJIIIM> NLPJOGOCAJJ<TOk>([In] this JKEBLLKKBOM<TOk, CACBPFJIIIM> FPFHIDBMBMI, LPPJEHMJDEA DEFMDPDEKLM) where TOk : notnull
	{
		return default(JKEBLLKKBOM<TOk, CACBPFJIIIM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x369F7D0", Offset = "0x369E5D0", VA = "0x18369F7D0")]
	public static JKEBLLKKBOM<TOk?, CACBPFJIIIM?> JOJHJLAMEKH<TOk>([In] this JKEBLLKKBOM<TOk, CACBPFJIIIM> FPFHIDBMBMI)
	{
		return default(JKEBLLKKBOM<TOk, CACBPFJIIIM>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x369F6E0", Offset = "0x369E4E0", VA = "0x18369F6E0")]
	public static JKEBLLKKBOM<TOk?, CACBPFJIIIM?> DEGBHJMLIAH<TOk>([In] this JKEBLLKKBOM<TOk, CACBPFJIIIM> FPFHIDBMBMI)
	{
		return default(JKEBLLKKBOM<TOk, CACBPFJIIIM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public interface JEAFHHJHNHG
{
	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NDIEIKCIHPO([In] JKEBLLKKBOM<NICNPLCGCEF, LPPJEHMJDEA> BPINCJLADGC);
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public static class HMBIJHDFBJG
{
	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0x3927050", Offset = "0x3925E50", VA = "0x183927050")]
	public static bool NDIEIKCIHPO<TOk, TErr>(this JEAFHHJHNHG FPFHIDBMBMI, [In] JKEBLLKKBOM<TOk, TErr> BPINCJLADGC) where TOk : notnull where TErr : notnull, LPPJEHMJDEA
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000107")]
public interface EOMAFEHEGOI
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	EHDOPHDIBFE OHPKMNNNOCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public interface CPNBFAFEOAK
{
	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FJNIAMGOABG GGOHHEDPFPD(int CKEOIJBAIFI);
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public interface ODMNCGDGNNH
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
public interface NBNDKMMHANJ
{
	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GLCIGOHCPNG? KFMOMMKBCOA(BIHBDMOHDCK<NGIHDDPPPGJ> OFEMJHIHINC);
}
[Cpp2IlInjected.Token(Token = "0x200010B")]
public interface KPNKNAOEGIA
{
	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
public interface GLCIGOHCPNG
{
	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	string KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KPNKNAOEGIA? KMEEFIIDMJG(BIHBDMOHDCK<JAIKLOFJOLF> AEIPGBEAKCM);

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ODMNCGDGNNH? NOKOGKBMAIA(BIHBDMOHDCK<OHFDADNMMNM> LIGOFENJLEO);
}
[Cpp2IlInjected.Token(Token = "0x200010D")]
public interface ECGAGLEJEGA
{
	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> OBAAGIICIEN(string OAIIHELJHLG, string JAPGNGDBBIF);
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
public interface LILPBIECJKB
{
	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NBNDKMMHANJ? JEGGAJFDPAB([In] KOIDEEJEAKA<JLGBKHFBOKK> JONFANGPPNH);
}
[Cpp2IlInjected.Token(Token = "0x200010F")]
public sealed class KMODMDGDDCL
{
	[Cpp2IlInjected.Token(Token = "0x2000110")]
	private struct NBOPBOEEDLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public int KBDABDGGLJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		public HHNNLOLDABE? GOJJJHKGBJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public HHNNLOLDABE? HMMPJMKMHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public readonly List<CMGFJHDBEGO> OFNCINFAONF;

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x280E480", Offset = "0x280D280", VA = "0x18280E480")]
		private NBOPBOEEDLD(int GLAOLHCPLLG, HHNNLOLDABE? HGIKCCENEPP, HHNNLOLDABE? MDAIAMJPPBA, List<CMGFJHDBEGO> GONMDJMHKJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000618")]
		[Cpp2IlInjected.Address(RVA = "0x280E3C0", Offset = "0x280D1C0", VA = "0x18280E3C0")]
		public static NBOPBOEEDLD NBEICDCLFEE()
		{
			return default(NBOPBOEEDLD);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000374")]
	private readonly FIABOCPOCPL<NBOPBOEEDLD> KODFCMEJCJO;

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public static KMODMDGDDCL ICOFMPPJNFC
	{
		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x280B450", Offset = "0x280A250", VA = "0x18280B450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool FOPAGHBGCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0xCA8320", Offset = "0xCA7120", VA = "0x180CA8320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xCA7770", Offset = "0xCA6570", VA = "0x180CA7770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0x280B4A0", Offset = "0x280A2A0", VA = "0x18280B4A0")]
	public void BCIABILKDAK(NNLJIKPEIHP MDAIAMJPPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0x280B560", Offset = "0x280A360", VA = "0x18280B560")]
	public void CGBDBGHIBDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0x280B860", Offset = "0x280A660", VA = "0x18280B860")]
	private static string? FDKGNEEPAOJ([In] NBOPBOEEDLD DLAEJOPHLAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0x280BCA0", Offset = "0x280AAA0", VA = "0x18280BCA0")]
	public KMODMDGDDCL()
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
