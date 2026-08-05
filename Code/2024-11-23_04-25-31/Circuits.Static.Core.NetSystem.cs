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
public struct CAOCOACDOCE<TPartialAction, TFullAction, TDeps> where TDeps : IGBHOHLCEFB.EFPOICDAAPL<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] NJBEFHJOAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int OPBPANIPHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps HMOBFPGDOND;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4185460", Offset = "0x4183E60", VA = "0x184185460")]
	internal CAOCOACDOCE(TPartialAction[] JDHKHNPNHAK, int GLDFGIICLNA, TDeps JOIGIEDFOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4185340", Offset = "0x4183D40", VA = "0x184185340")]
	public static CAOCOACDOCE<TPartialAction, TFullAction, TDeps> AELHPDENENI(TDeps JOIGIEDFOGO)
	{
		return default(CAOCOACDOCE<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IGBHOHLCEFB
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface EFPOICDAAPL<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KEEDGKPCJJC([In] TPartialAction KNEGDIEEEBM);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction BLDFKHJBDBG(TPartialAction[] CIEHGJNKMFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2F25970", Offset = "0x2F24370", VA = "0x182F25970")]
	public static BHEDPLGAJGK<TFullAction> KCDANMPEOPE<TFullAction, TPartialAction, TDeps>(this CAOCOACDOCE<TPartialAction, TFullAction, TDeps> PCBICLOONMH, TPartialAction KNEGDIEEEBM) where TDeps : EFPOICDAAPL<TPartialAction, TFullAction>
	{
		return default(BHEDPLGAJGK<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct HJPHNMABFPO<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : HGJAPPNPLCE.ADMKBKPHNBE<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] EJHBDJMMFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int FLIFGBNODON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps HMOBFPGDOND;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4185460", Offset = "0x4183E60", VA = "0x184185460")]
	internal HJPHNMABFPO(TPartialSnapshot[] KAJHIAAIHEJ, int MIBCHMOBCJP, TDeps JOIGIEDFOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4185340", Offset = "0x4183D40", VA = "0x184185340")]
	public static HJPHNMABFPO<TPartialSnapshot, TFullSnapshot, TDeps> AELHPDENENI(TDeps JOIGIEDFOGO)
	{
		return default(HJPHNMABFPO<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HGJAPPNPLCE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface ADMKBKPHNBE<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KBNMNKCMJOK([In] TPartialSnapshot DLBDEDPPGKH);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot JLNKJMIAHED(TPartialSnapshot[] PALKOHEJHLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2EFEB70", Offset = "0x2EFD570", VA = "0x182EFEB70")]
	public static BHEDPLGAJGK<TFullSnapshot> KCDANMPEOPE<TFullSnapshot, TPartialSnapshot, TDeps>(this HJPHNMABFPO<TPartialSnapshot, TFullSnapshot, TDeps> PCBICLOONMH, TPartialSnapshot DLBDEDPPGKH) where TDeps : ADMKBKPHNBE<TPartialSnapshot, TFullSnapshot>
	{
		return default(BHEDPLGAJGK<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2EFEA20", Offset = "0x2EFD420", VA = "0x182EFEA20")]
	public static bool ANOMKMALBOB<TPartialSnapshot, TFullSnapshot, TDeps>(this HJPHNMABFPO<TPartialSnapshot, TFullSnapshot, TDeps> PCBICLOONMH, TPartialSnapshot DLBDEDPPGKH) where TDeps : ADMKBKPHNBE<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class HHHOLCJOFKD : GEKPLBFPNLN
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x22AE510", Offset = "0x22ACF10", VA = "0x1822AE510", Slot = "7")]
	public override string BGELNEMCJAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x22AE540", Offset = "0x22ACF40", VA = "0x1822AE540")]
	public HHHOLCJOFKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class GJLKIONCEKK<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : GEJCEKPHLGB.MBHIKBPALJO<TAction, TNetSys> where TReceiverDeps : GEJCEKPHLGB.PKJJHHPEFDD<TAction, TReceiver> where TRootDeps : GEJCEKPHLGB.DNLBPKAFFOA<TMRequest, TAction, TRoot> where TDeps : GEJCEKPHLGB.MFHNBODEFDG<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface NLLCHNPLLLD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LAGLFNGHBNG([In] OKPKCEBGDLD<object, NJDGKLFLKEH> KIBAOEBFCJF);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LFKEKMPHNEP();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		OKPKCEBGDLD<object, NJDGKLFLKEH> APCCJEJMNGN();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LAKMNFADHND(Exception AENFONOHPNM);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class HCICGEKBOLF : NLLCHNPLLLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly TaskCompletionSource<OKPKCEBGDLD<object, NJDGKLFLKEH>> DOBNNOANJJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly List<OKPKCEBGDLD<object, FMGMBNHPFJE>> LBKDIAJHCFL;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4174280", Offset = "0x4172C80", VA = "0x184174280")]
		private HCICGEKBOLF(TaskCompletionSource<OKPKCEBGDLD<object, NJDGKLFLKEH>> DDBCLGDDBCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4173AE0", Offset = "0x41724E0", VA = "0x184173AE0")]
		public static HCICGEKBOLF AELHPDENENI(TaskCompletionSource<OKPKCEBGDLD<object, NJDGKLFLKEH>> DDBCLGDDBCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4173D20", Offset = "0x4172720", VA = "0x184173D20")]
		public void LAGLFNGHBNG([In] OKPKCEBGDLD<object, NJDGKLFLKEH> KIBAOEBFCJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4174020", Offset = "0x4172A20", VA = "0x184174020", Slot = "5")]
		public void LFKEKMPHNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4173C70", Offset = "0x4172670", VA = "0x184173C70", Slot = "6")]
		public OKPKCEBGDLD<object, NJDGKLFLKEH> APCCJEJMNGN()
		{
			return default(OKPKCEBGDLD<object, NJDGKLFLKEH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x4173FC0", Offset = "0x41729C0", VA = "0x184173FC0", Slot = "7")]
		public void LAKMNFADHND(Exception AENFONOHPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4144B10", Offset = "0x4143510", VA = "0x184144B10", Slot = "4")]
		private void MMPDFENFBNC([In] OKPKCEBGDLD<object, NJDGKLFLKEH> KIBAOEBFCJF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class BNENHKBHLIA : NLLCHNPLLLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly TaskCompletionSource<OKPKCEBGDLD<object, NJDGKLFLKEH>> DOBNNOANJJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private OKPKCEBGDLD<object, NJDGKLFLKEH> FBIPLLPKCMC;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8B23B0", Offset = "0x8B0DB0", VA = "0x1808B23B0")]
		private BNENHKBHLIA(TaskCompletionSource<OKPKCEBGDLD<object, NJDGKLFLKEH>> DDBCLGDDBCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4173AE0", Offset = "0x41724E0", VA = "0x184173AE0")]
		public static BNENHKBHLIA AELHPDENENI(TaskCompletionSource<OKPKCEBGDLD<object, NJDGKLFLKEH>> DDBCLGDDBCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x529F020", Offset = "0x529DA20", VA = "0x18529F020")]
		public void LAGLFNGHBNG([In] OKPKCEBGDLD<object, NJDGKLFLKEH> KIBAOEBFCJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x529F160", Offset = "0x529DB60", VA = "0x18529F160", Slot = "5")]
		public void LFKEKMPHNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x97E910", Offset = "0x97D310", VA = "0x18097E910", Slot = "6")]
		public OKPKCEBGDLD<object, NJDGKLFLKEH> APCCJEJMNGN()
		{
			return default(OKPKCEBGDLD<object, NJDGKLFLKEH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x529F040", Offset = "0x529DA40", VA = "0x18529F040", Slot = "7")]
		public void LAKMNFADHND(Exception AENFONOHPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4144B10", Offset = "0x4143510", VA = "0x184144B10", Slot = "4")]
		private void MMPDFENFBNC([In] OKPKCEBGDLD<object, NJDGKLFLKEH> KIBAOEBFCJF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class AIJFNKMDBFK : NLLCHNPLLLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<OKPKCEBGDLD<object, NJDGKLFLKEH>> LBKDIAJHCFL;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4144BE0", Offset = "0x41435E0", VA = "0x184144BE0")]
		private AIJFNKMDBFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4144720", Offset = "0x4143120", VA = "0x184144720")]
		public static AIJFNKMDBFK AELHPDENENI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x41448B0", Offset = "0x41432B0", VA = "0x1841448B0")]
		public void LAGLFNGHBNG([In] OKPKCEBGDLD<object, NJDGKLFLKEH> KIBAOEBFCJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		public void LFKEKMPHNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4144850", Offset = "0x4143250", VA = "0x184144850", Slot = "6")]
		public OKPKCEBGDLD<object, NJDGKLFLKEH> APCCJEJMNGN()
		{
			return default(OKPKCEBGDLD<object, NJDGKLFLKEH>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4144A70", Offset = "0x4143470", VA = "0x184144A70", Slot = "7")]
		[IEODDIDMNFH("This may be terminal and should probably do more than discarding the exception.")]
		public void LAKMNFADHND(Exception AENFONOHPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4144B10", Offset = "0x4143510", VA = "0x184144B10", Slot = "4")]
		private void MMPDFENFBNC([In] OKPKCEBGDLD<object, NJDGKLFLKEH> KIBAOEBFCJF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class CLMADKDDGMN : NLLCHNPLLLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private OKPKCEBGDLD<object, NJDGKLFLKEH> FBIPLLPKCMC;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8B4380", Offset = "0x8B2D80", VA = "0x1808B4380")]
		private CLMADKDDGMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4144720", Offset = "0x4143120", VA = "0x184144720")]
		public static CLMADKDDGMN AELHPDENENI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1BBF780", Offset = "0x1BBE180", VA = "0x181BBF780")]
		public void LAGLFNGHBNG([In] OKPKCEBGDLD<object, NJDGKLFLKEH> KIBAOEBFCJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA50", Offset = "0x8AB450", VA = "0x1808ACA50", Slot = "5")]
		public void LFKEKMPHNEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAEA840", Offset = "0xAE9240", VA = "0x180AEA840", Slot = "6")]
		public OKPKCEBGDLD<object, NJDGKLFLKEH> APCCJEJMNGN()
		{
			return default(OKPKCEBGDLD<object, NJDGKLFLKEH>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x56EF5F0", Offset = "0x56EDFF0", VA = "0x1856EF5F0", Slot = "7")]
		[IEODDIDMNFH("This may be terminal and should probably do more than discarding the exception.")]
		public void LAKMNFADHND(Exception AENFONOHPNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4144B10", Offset = "0x4143510", VA = "0x184144B10", Slot = "4")]
		private void MMPDFENFBNC([In] OKPKCEBGDLD<object, NJDGKLFLKEH> KIBAOEBFCJF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HABFKNMNJKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public GJLKIONCEKK<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public NOPFJADADBI<KALLOEFFFCG> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskCompletionSource<OKPKCEBGDLD<object, NJDGKLFLKEH>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4165E30", Offset = "0x4164830", VA = "0x184165E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x41663A0", Offset = "0x4164DA0", VA = "0x1841663A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct AOFEECEHKFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public GJLKIONCEKK<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public NOPFJADADBI<KALLOEFFFCG> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4163640", Offset = "0x4162040", VA = "0x184163640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4163FB0", Offset = "0x41629B0", VA = "0x184163FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct NBBPPJLODEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public GJLKIONCEKK<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public NOPFJADADBI<KALLOEFFFCG> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public NOPFJADADBI<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x490D790", Offset = "0x490C190", VA = "0x18490D790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x490DED0", Offset = "0x490C8D0", VA = "0x18490DED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct OFJNADPGFEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AsyncTaskMethodBuilder<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public GJLKIONCEKK<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public NOPFJADADBI<KALLOEFFFCG> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NOPFJADADBI<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private NLLCHNPLLLD <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4A552F0", Offset = "0x4A53CF0", VA = "0x184A552F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4A56000", Offset = "0x4A54A00", VA = "0x184A56000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct IBLBABBCJIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public GJLKIONCEKK<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NLLCHNPLLLD completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private NLLCHNPLLLD <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<OKPKCEBGDLD<object, NJDGKLFLKEH>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x423E800", Offset = "0x423D200", VA = "0x18423E800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4240790", Offset = "0x423F190", VA = "0x184240790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct LJNFILNCLKH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public TAction[] snapshotActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public GJLKIONCEKK<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public NOPFJADADBI<KALLOEFFFCG> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4675330", Offset = "0x4673D30", VA = "0x184675330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4675A10", Offset = "0x4674410", VA = "0x184675A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps HMOBFPGDOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<NOPFJADADBI<TMRequest>, TaskCompletionSource<OKPKCEBGDLD<object, NJDGKLFLKEH>>> DGJNIDBDICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private GBOEEFGKINE<TMRequest> IHPPOIEMOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private bool HAMNLCMPLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int FNAIGAAICOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Task OLLBJPJBADK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps PMGFLPBDJNP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x410F2D0", Offset = "0x410DCD0", VA = "0x18410F2D0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps PDGAGPHKMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x410F3A0", Offset = "0x410DDA0", VA = "0x18410F3A0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps HAIKFCLOACC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x410FBD0", Offset = "0x410E5D0", VA = "0x18410FBD0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NOOEKBJNMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xC6F980", Offset = "0xC6E380", VA = "0x180C6F980")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x180FE70", Offset = "0x180E870", VA = "0x18180FE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool NKMCDKAJJGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1295220", Offset = "0x1293C20", VA = "0x181295220")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x410E290", Offset = "0x410CC90", VA = "0x18410E290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NHKMJGJGKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8AF7D0", Offset = "0x8AE1D0", VA = "0x1808AF7D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4110360", Offset = "0x410ED60", VA = "0x184110360")]
	public GJLKIONCEKK(TDeps JOIGIEDFOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x410E2A0", Offset = "0x410CCA0", VA = "0x18410E2A0")]
	public Task<OKPKCEBGDLD<object, NJDGKLFLKEH>> FCPDEOGBJHN(TRoot ELFANOAFHKM, TNetSys LNKCMCGILIJ, NOPFJADADBI<KALLOEFFFCG> NLOAIMAADNO, TAction EFFBNJEBEKP, bool MLOMCFLMJNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x410EEC0", Offset = "0x410D8C0", VA = "0x18410EEC0")]
	[AsyncStateMachine(typeof(GJLKIONCEKK<, , , , , , , , >.HABFKNMNJKD))]
	private Task<OKPKCEBGDLD<object, NJDGKLFLKEH>> FCPDEOGBJHN(TRoot ELFANOAFHKM, NOPFJADADBI<KALLOEFFFCG> NLOAIMAADNO, TAction EFFBNJEBEKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x410FD60", Offset = "0x410E760", VA = "0x18410FD60")]
	[AsyncStateMachine(typeof(GJLKIONCEKK<, , , , , , , , >.AOFEECEHKFN))]
	private Task<OKPKCEBGDLD<object, NJDGKLFLKEH>> OHFPDMGLOKA(TRoot ELFANOAFHKM, NOPFJADADBI<KALLOEFFFCG> NLOAIMAADNO, TAction[] OHBFICNMFIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x410DE90", Offset = "0x410C890", VA = "0x18410DE90")]
	[AsyncStateMachine(typeof(GJLKIONCEKK<, , , , , , , , >.NBBPPJLODEB))]
	public Task<OKPKCEBGDLD<object, NJDGKLFLKEH>> ANLMDFNDFNK(TRoot ELFANOAFHKM, TNetSys ECHGGBOBEGG, TReceiver PHIEHPFGCDC, NOPFJADADBI<KALLOEFFFCG> NLOAIMAADNO, NOPFJADADBI<TMRequest> GBCHABBLBPK, TAction EFFBNJEBEKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4110050", Offset = "0x410EA50", VA = "0x184110050")]
	[AsyncStateMachine(typeof(GJLKIONCEKK<, , , , , , , , >.OFJNADPGFEE))]
	private Task<OKPKCEBGDLD<object, NJDGKLFLKEH>> PCJMKBBIDGP(TRoot ELFANOAFHKM, TNetSys ECHGGBOBEGG, TReceiver PHIEHPFGCDC, NOPFJADADBI<KALLOEFFFCG> NLOAIMAADNO, NOPFJADADBI<TMRequest> GBCHABBLBPK, TAction EFFBNJEBEKP, Task PMMAFEDMGDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x410F180", Offset = "0x410DB80", VA = "0x18410F180")]
	[AsyncStateMachine(typeof(GJLKIONCEKK<, , , , , , , , >.IBLBABBCJIP))]
	private Task KJIJJJKFNIC(TRoot ELFANOAFHKM, TNetSys ECHGGBOBEGG, TReceiver PHIEHPFGCDC, TAction EFFBNJEBEKP, NLLCHNPLLLD NPMHFONAPCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x410F850", Offset = "0x410E250", VA = "0x18410F850")]
	private void NDGIONAIJEC(TRoot ELFANOAFHKM, TNetSys ECHGGBOBEGG, TReceiver PHIEHPFGCDC, NOPFJADADBI<KALLOEFFFCG> NLOAIMAADNO, TAction EFFBNJEBEKP, bool FMLCFDMKEHB, bool EPFNLMFIODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x410E000", Offset = "0x410CA00", VA = "0x18410E000")]
	[AsyncStateMachine(typeof(GJLKIONCEKK<, , , , , , , , >.LJNFILNCLKH))]
	public Task DLIIDJBGNDF(TRoot ELFANOAFHKM, TNetSys ECHGGBOBEGG, NOPFJADADBI<KALLOEFFFCG> NLOAIMAADNO, TAction[] GNEKJFLDGPO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class GEJCEKPHLGB
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface MBHIKBPALJO<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AABIPLCLFCA(TNetSys GCCMFNNKNLE, TAction EFFBNJEBEKP);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction OOABALMJBKE(TNetSys GCCMFNNKNLE, TAction EFFBNJEBEKP);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction DJKIHMHAEOO(TNetSys GCCMFNNKNLE, TAction EFFBNJEBEKP);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> HACPCNOODII(TNetSys GCCMFNNKNLE, TAction EFFBNJEBEKP);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] JMLPOPBHPMF(TNetSys GCCMFNNKNLE, TAction EFFBNJEBEKP, int IAPIAMAIINP);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool LPHOHDMCMFL(TNetSys GCCMFNNKNLE, TAction EFFBNJEBEKP);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool FLOLKKNJPKI(TNetSys GCCMFNNKNLE, TAction EFFBNJEBEKP);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool NIFOGNGIMAO(TNetSys GCCMFNNKNLE, TAction EFFBNJEBEKP);

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool CNJENCKIEMJ(TNetSys GCCMFNNKNLE, TAction EFFBNJEBEKP);

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool OICHHPEPKJE(TNetSys GCCMFNNKNLE, TAction EFFBNJEBEKP);

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool IIAOJKOKHMJ(TNetSys GCCMFNNKNLE, TAction EFFBNJEBEKP);
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface MFHNBODEFDG<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps PMGFLPBDJNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps HAIKFCLOACC
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps PDGAGPHKMEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface PKJJHHPEFDD<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NOPFJADADBI<KALLOEFFFCG> COFFCNLEALA(TReceiver PHIEHPFGCDC);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<OKPKCEBGDLD<object, NJDGKLFLKEH>> ANLMDFNDFNK(TReceiver PHIEHPFGCDC, TAction EFFBNJEBEKP);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] HAIGEOJHPLK(TReceiver PHIEHPFGCDC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface DNLBPKAFFOA<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KFMIMBBKDJF(TRoot ELFANOAFHKM);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int AGEBNMOMJFF(TRoot ELFANOAFHKM);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int EOOLNGLOLEF(TRoot ELFANOAFHKM);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int PDEADGLMFAG(TRoot ELFANOAFHKM);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GDILBLOIFLO(TRoot ELFANOAFHKM);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool ACOHNKNHMLK(TRoot ELFANOAFHKM, NOPFJADADBI<KALLOEFFFCG> NLOAIMAADNO, TAction[] OHBFICNMFIF);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "6")]
		Task FCPDEOGBJHN(TRoot ELFANOAFHKM, NOPFJADADBI<KALLOEFFFCG> NLOAIMAADNO, NOPFJADADBI<TMRequest> GBCHABBLBPK, TAction EFFBNJEBEKP, bool AJOJEGJPCGL = true);
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
