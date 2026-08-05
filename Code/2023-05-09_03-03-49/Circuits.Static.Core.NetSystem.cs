using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct BBNIPIDIKGP<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : LIHNGDCEADE.MALEKKJJGHG<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialSnapshot[] CAHEDIGNGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int JLMJEMPHFEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps FHGLBJEIIAF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x469BBA0", Offset = "0x469A5A0", VA = "0x18469BBA0")]
	internal BBNIPIDIKGP(TPartialSnapshot[] EGKCEFFCJOH, int CCMHGAMINCK, TDeps KIMLKGPEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x469BB40", Offset = "0x469A540", VA = "0x18469BB40")]
	public static global::BBNIPIDIKGP<TPartialSnapshot, TFullSnapshot, TDeps> IDLIIDOEAFG(TDeps KIMLKGPEIDL)
	{
		return default(global::BBNIPIDIKGP<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LIHNGDCEADE
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface MALEKKJJGHG<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MJIFHOHKHPO(in TPartialSnapshot DCMKKLOFFPA);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot ADAJAKDKCKG(TPartialSnapshot[] HCGHCPHPODJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x36FF8F0", Offset = "0x36FE2F0", VA = "0x1836FF8F0")]
	public static global::DOMIPLFCMFE<TFullSnapshot> KMLBDICLAEC<TFullSnapshot, TPartialSnapshot, TDeps>(this ref global::BBNIPIDIKGP<TPartialSnapshot, TFullSnapshot, TDeps> IKHBPJOEIEB, TPartialSnapshot DCMKKLOFFPA) where TDeps : MALEKKJJGHG<TPartialSnapshot, TFullSnapshot>
	{
		return default(global::DOMIPLFCMFE<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x36FFC40", Offset = "0x36FE640", VA = "0x1836FFC40")]
	public static bool MMNBAOLOMCI<TPartialSnapshot, TFullSnapshot, TDeps>(this ref global::BBNIPIDIKGP<TPartialSnapshot, TFullSnapshot, TDeps> IKHBPJOEIEB, TPartialSnapshot DCMKKLOFFPA) where TDeps : MALEKKJJGHG<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class BLPDHEHAIJM : NNOGOJMPBNO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1E7CA00", Offset = "0x1E7B400", VA = "0x181E7CA00", Slot = "7")]
	public override string ODHCPOFFIEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D80FD0", Offset = "0x1D7F9D0", VA = "0x181D80FD0")]
	public BLPDHEHAIJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CHGAHKFBHBM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface MGEHCCLGOOE<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HGFHNMIJBOH(TNetSys PNHFHFEKKEI, TAction DJJNLDOINEG);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction LKMMMKHLJHG(TNetSys PNHFHFEKKEI, TAction DJJNLDOINEG);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction NMEALMNEDOH(TNetSys PNHFHFEKKEI, TAction DJJNLDOINEG);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> PJKODJINCLC(TNetSys PNHFHFEKKEI, TAction DJJNLDOINEG);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool MHBILDAHLGM(TNetSys PNHFHFEKKEI, TAction DJJNLDOINEG);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool MHNFFAFAAEK(TNetSys PNHFHFEKKEI, TAction DJJNLDOINEG);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool EKJEEEIDACP(TNetSys PNHFHFEKKEI, TAction DJJNLDOINEG);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool HDCHDMHBEPN(TNetSys PNHFHFEKKEI, TAction DJJNLDOINEG);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool CHDGOKOLEDG(TNetSys PNHFHFEKKEI, TAction DJJNLDOINEG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface GIJHBFPPOPE<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TActionDeps LDDPIBCIDAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		TReceiverDeps JIJCFCNMACB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		TRootDeps JAONEDDMKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface HNKPLKBHMMN<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		global::JKMOEKGCPOM<TMActor> AEABDFEANCH(TReceiver LFFLKCJEJDN);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> FONJCDBDFLB(TReceiver LFFLKCJEJDN, TAction DJJNLDOINEG);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] EGPMPHFMILK(TReceiver LFFLKCJEJDN);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface ENEHOKFFEJN<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FNOIGIDDANM(TRoot MNGLAEJHIMG);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int FDAMHGKBHLN(TRoot MNGLAEJHIMG);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int LEDOANDKJLF(TRoot MNGLAEJHIMG);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PNEPCBMEHBK(TRoot MNGLAEJHIMG);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task GGFEJPIIKEB(TRoot MNGLAEJHIMG, global::JKMOEKGCPOM<TMActor> EHNJPBPFDKD, global::JKMOEKGCPOM<TMRequest> KILPMMGIGPO, TAction DJJNLDOINEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class KFCAMNEILDO<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : CHGAHKFBHBM.MGEHCCLGOOE<TAction, TNetSys> where TReceiverDeps : CHGAHKFBHBM.HNKPLKBHMMN<TMActor, TAction, TReceiver> where TRootDeps : CHGAHKFBHBM.ENEHOKFFEJN<TMRequest, TMActor, TAction, TRoot> where TDeps : CHGAHKFBHBM.GIJHBFPPOPE<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private interface JKBMLBBEPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JJEOHPJLKKL(in global::DAOEJNFJJPJ<object, PCIJMHLMKIF> MIMDGHHHHPD);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void POJABPCJKOB();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::DAOEJNFJJPJ<object, PCIJMHLMKIF> HLDFMOMGMKH();

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void EDJJFMOKLBE(Exception HELJFFINGAN);
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class KCFOJKJKAFA : JKBMLBBEPBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly TaskCompletionSource<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> IIKGDPFELHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly List<global::DAOEJNFJJPJ<object, GEPHFINPONA>> AMFBIIJAPDF;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3777B20", Offset = "0x3776520", VA = "0x183777B20")]
		private KCFOJKJKAFA(TaskCompletionSource<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> FHPPEOCPIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37776B0", Offset = "0x37760B0", VA = "0x1837776B0")]
		public static KCFOJKJKAFA IDLIIDOEAFG(TaskCompletionSource<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> FHPPEOCPIGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3777820", Offset = "0x3776220", VA = "0x183777820")]
		public void JJEOHPJLKKL(in global::DAOEJNFJJPJ<object, PCIJMHLMKIF> MIMDGHHHHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x37778C0", Offset = "0x37762C0", VA = "0x1837778C0", Slot = "5")]
		public void POJABPCJKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3777550", Offset = "0x3775F50", VA = "0x183777550", Slot = "6")]
		public global::DAOEJNFJJPJ<object, PCIJMHLMKIF> HLDFMOMGMKH()
		{
			return default(global::DAOEJNFJJPJ<object, PCIJMHLMKIF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x37774F0", Offset = "0x3775EF0", VA = "0x1837774F0", Slot = "7")]
		public void EDJJFMOKLBE(Exception HELJFFINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x361D430", Offset = "0x361BE30", VA = "0x18361D430", Slot = "4")]
		private void LNADBACAOGG(in global::DAOEJNFJJPJ<object, PCIJMHLMKIF> MIMDGHHHHPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class MDDGIKOFOIE : JKBMLBBEPBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly TaskCompletionSource<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> IIKGDPFELHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private global::DAOEJNFJJPJ<object, PCIJMHLMKIF> JMHPPFDNAAL;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x34E7CA0", Offset = "0x34E66A0", VA = "0x1834E7CA0")]
		private MDDGIKOFOIE(TaskCompletionSource<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> FHPPEOCPIGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x37776B0", Offset = "0x37760B0", VA = "0x1837776B0")]
		public static MDDGIKOFOIE IDLIIDOEAFG(TaskCompletionSource<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> FHPPEOCPIGL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x927480", Offset = "0x925E80", VA = "0x180927480")]
		public void JJEOHPJLKKL(in global::DAOEJNFJJPJ<object, PCIJMHLMKIF> MIMDGHHHHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x467CF90", Offset = "0x467B990", VA = "0x18467CF90", Slot = "5")]
		public void POJABPCJKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9273A0", Offset = "0x925DA0", VA = "0x1809273A0", Slot = "6")]
		public global::DAOEJNFJJPJ<object, PCIJMHLMKIF> HLDFMOMGMKH()
		{
			return default(global::DAOEJNFJJPJ<object, PCIJMHLMKIF>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x467CF30", Offset = "0x467B930", VA = "0x18467CF30", Slot = "7")]
		public void EDJJFMOKLBE(Exception HELJFFINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x361D430", Offset = "0x361BE30", VA = "0x18361D430", Slot = "4")]
		private void LNADBACAOGG(in global::DAOEJNFJJPJ<object, PCIJMHLMKIF> MIMDGHHHHPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class FMJLPIONEKD : JKBMLBBEPBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly List<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> AMFBIIJAPDF;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x361D4E0", Offset = "0x361BEE0", VA = "0x18361D4E0")]
		private FMJLPIONEKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x361D2B0", Offset = "0x361BCB0", VA = "0x18361D2B0")]
		public static FMJLPIONEKD IDLIIDOEAFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x361D370", Offset = "0x361BD70", VA = "0x18361D370")]
		public void JJEOHPJLKKL(in global::DAOEJNFJJPJ<object, PCIJMHLMKIF> MIMDGHHHHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
		public void POJABPCJKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x361D1F0", Offset = "0x361BBF0", VA = "0x18361D1F0", Slot = "6")]
		public global::DAOEJNFJJPJ<object, PCIJMHLMKIF> HLDFMOMGMKH()
		{
			return default(global::DAOEJNFJJPJ<object, PCIJMHLMKIF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "7")]
		public void EDJJFMOKLBE(Exception HELJFFINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x361D430", Offset = "0x361BE30", VA = "0x18361D430", Slot = "4")]
		private void LNADBACAOGG(in global::DAOEJNFJJPJ<object, PCIJMHLMKIF> MIMDGHHHHPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class EFIFMLNGGKB : JKBMLBBEPBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::DAOEJNFJJPJ<object, PCIJMHLMKIF> JMHPPFDNAAL;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x25118A0", Offset = "0x25102A0", VA = "0x1825118A0")]
		private EFIFMLNGGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x361D2B0", Offset = "0x361BCB0", VA = "0x18361D2B0")]
		public static EFIFMLNGGKB IDLIIDOEAFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x94C450", Offset = "0x94AE50", VA = "0x18094C450")]
		public void JJEOHPJLKKL(in global::DAOEJNFJJPJ<object, PCIJMHLMKIF> MIMDGHHHHPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "5")]
		public void POJABPCJKOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8B9650", Offset = "0x8B8050", VA = "0x1808B9650", Slot = "6")]
		public global::DAOEJNFJJPJ<object, PCIJMHLMKIF> HLDFMOMGMKH()
		{
			return default(global::DAOEJNFJJPJ<object, PCIJMHLMKIF>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "7")]
		public void EDJJFMOKLBE(Exception HELJFFINGAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x361D430", Offset = "0x361BE30", VA = "0x18361D430", Slot = "4")]
		private void LNADBACAOGG(in global::DAOEJNFJJPJ<object, PCIJMHLMKIF> MIMDGHHHHPD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct ADIDIKFIOBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public global::KFCAMNEILDO<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::JKMOEKGCPOM<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::JKMOEKGCPOM<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4507060", Offset = "0x4505A60", VA = "0x184507060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4507680", Offset = "0x4506080", VA = "0x184507680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct KPAKPEDBAFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::KFCAMNEILDO<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public global::JKMOEKGCPOM<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public global::JKMOEKGCPOM<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private JKBMLBBEPBJ <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3BC2500", Offset = "0x3BC0F00", VA = "0x183BC2500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3C30", Offset = "0x3BC2630", VA = "0x183BC3C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct DFADEOKGAHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public global::KFCAMNEILDO<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public JKBMLBBEPBJ completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private JKBMLBBEPBJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x43722B0", Offset = "0x4370CB0", VA = "0x1843722B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9396C0", Offset = "0x9380C0", VA = "0x1809396C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct MHEFOPFLOCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Task sendTask_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> tcsTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x550F7A0", Offset = "0x550E1A0", VA = "0x18550F7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x550FC30", Offset = "0x550E630", VA = "0x18550FC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly TDeps FHGLBJEIIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<global::JKMOEKGCPOM<TMRequest>, TaskCompletionSource<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>>> PFBPCLJGHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private global::CEAEGGKBMNJ<TMRequest> MGFBMGDNODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private int NPLBMPMBCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task EDKBODAOMHK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TActionDeps LDDPIBCIDAN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4647730", Offset = "0x4646130", VA = "0x184647730")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private TRootDeps JAONEDDMKEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4647730", Offset = "0x4646130", VA = "0x184647730")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private TReceiverDeps JIJCFCNMACB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4647730", Offset = "0x4646130", VA = "0x184647730")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool MKMKJDHEJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x884700", Offset = "0x883100", VA = "0x180884700")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8848C0", Offset = "0x8832C0", VA = "0x1808848C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int PAKDPBCNDOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4060", VA = "0x1807E5660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x46487B0", Offset = "0x46471B0", VA = "0x1846487B0")]
	public KFCAMNEILDO(TDeps KIMLKGPEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4647EB0", Offset = "0x46468B0", VA = "0x184647EB0")]
	public Task<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> GGFEJPIIKEB(TRoot MNGLAEJHIMG, TNetSys PDHBIADEOJH, global::JKMOEKGCPOM<TMActor> EHNJPBPFDKD, TAction DJJNLDOINEG, bool HPNIJKGKNLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4647750", Offset = "0x4646150", VA = "0x184647750")]
	[AsyncStateMachine(typeof(global::KFCAMNEILDO<, , , , , , , , , >.ADIDIKFIOBN))]
	public Task<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> FONJCDBDFLB(TRoot MNGLAEJHIMG, TNetSys OHPGCKMNHOK, TReceiver LFFLKCJEJDN, global::JKMOEKGCPOM<TMActor> EHNJPBPFDKD, global::JKMOEKGCPOM<TMRequest> KILPMMGIGPO, TAction DJJNLDOINEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x46485B0", Offset = "0x4646FB0", VA = "0x1846485B0")]
	[AsyncStateMachine(typeof(global::KFCAMNEILDO<, , , , , , , , , >.KPAKPEDBAFF))]
	private Task<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> NOGNHALDDHF(TRoot MNGLAEJHIMG, TNetSys OHPGCKMNHOK, TReceiver LFFLKCJEJDN, global::JKMOEKGCPOM<TMActor> EHNJPBPFDKD, global::JKMOEKGCPOM<TMRequest> KILPMMGIGPO, TAction DJJNLDOINEG, Task MHJKFBIPKKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x4646F80", Offset = "0x4645980", VA = "0x184646F80")]
	[AsyncStateMachine(typeof(global::KFCAMNEILDO<, , , , , , , , , >.DFADEOKGAHO))]
	private Task AHLLGNJBGCL(TRoot MNGLAEJHIMG, TNetSys OHPGCKMNHOK, TReceiver LFFLKCJEJDN, TAction DJJNLDOINEG, JKBMLBBEPBJ MNHACGIJNFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4647270", Offset = "0x4645C70", VA = "0x184647270")]
	private void CBDOIMEKGGC(TRoot MNGLAEJHIMG, TNetSys OHPGCKMNHOK, TReceiver LFFLKCJEJDN, global::JKMOEKGCPOM<TMActor> EHNJPBPFDKD, TAction DJJNLDOINEG, bool AMKELODCMKG, bool DHOMDMNPPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4648240", Offset = "0x4646C40", VA = "0x184648240")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(global::KFCAMNEILDO<, , , , , , , , , >.MHEFOPFLOCA))]
	internal static Task<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> JHHKEIMMMMK(Task CEKPMHHKKAC, Task<global::DAOEJNFJJPJ<object, PCIJMHLMKIF>> LKPGNHINPMM)
	{
		return null;
	}
}
namespace Cpp2IlInjected;

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
