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
public interface LHIPKNAMCNO<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CPFCPIOCACM(TAction KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction EODKIHHJGLC(TAction KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction LMHAEMEAMMG(TAction KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> CNALDHCNDBH(TAction KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KGJLDECJNEM(TAction KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BJIJNPANJLJ(TAction KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DHFEGBEJAHD(TAction KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool HMCGNLBJKGM(TAction KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DFIDGPBMJGM(TAction KKJDJCJOLIF);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PEDNGMELDGP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::BLDAKPIDCBI<GBIKIDEDKIO> PMHKJGEBDAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int BCMJNEKHGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MALODJEKLIP();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DCBHIJKLFMM(global::BLDAKPIDCBI<NBANKALLDNA> GAOCBNNBJAD, TAction KKJDJCJOLIF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EMANAODLFFM<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GKNPKBJNDFK(in TPartialSnapshot PBNGIJOBDED);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot KNLEDBNKNBC(TPartialSnapshot[] HJLDAICBMDD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MFKJEENFGIJ<TAction, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult DKPOOGFEAEI(TAction KKJDJCJOLIF);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction[] AHCCEJEAKAO();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class GBIKIDEDKIO
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NBANKALLDNA
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JGMKODNCHBN<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::EMANAODLFFM<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialSnapshot[] JAOPABKBJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int IEOODHANOLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps GHBOMGLKHCJ;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2F4A220", Offset = "0x2F49020", VA = "0x182F4A220")]
	internal JGMKODNCHBN(TPartialSnapshot[] OBCJELBBBOJ, int HKHCFFHHIJH, TDeps NAFCODPKCHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2F4A150", Offset = "0x2F48F50", VA = "0x182F4A150")]
	public static global::JGMKODNCHBN<TPartialSnapshot, TFullSnapshot, TDeps> LBKFKMLCCNN(TDeps NAFCODPKCHO)
	{
		return default(global::JGMKODNCHBN<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PDJAJLMFFDM
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x24AE430", Offset = "0x24AD230", VA = "0x1824AE430")]
	public static global::FDDFPEAKAOA<TFullSnapshot> GJCMNBOIHGH<TFullSnapshot, TPartialSnapshot, TDeps>(this ref global::JGMKODNCHBN<TPartialSnapshot, TFullSnapshot, TDeps> CNBAEMLJEBG, TPartialSnapshot PBNGIJOBDED) where TDeps : global::EMANAODLFFM<TPartialSnapshot, TFullSnapshot>
	{
		return default(global::FDDFPEAKAOA<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x24AE780", Offset = "0x24AD580", VA = "0x1824AE780")]
	public static bool IEPCEKGNJMB<TPartialSnapshot, TFullSnapshot, TDeps>(this ref global::JGMKODNCHBN<TPartialSnapshot, TFullSnapshot, TDeps> CNBAEMLJEBG, TPartialSnapshot PBNGIJOBDED) where TDeps : global::EMANAODLFFM<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class PDGFJDFGJBM : ILGFEOBJLPI
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6644A60", Offset = "0x6643860", VA = "0x186644A60", Slot = "5")]
	public override string NKEBKNLNMDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3AA5BE0", Offset = "0x3AA49E0", VA = "0x183AA5BE0")]
	public PDGFJDFGJBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KDEGCEKFIOL<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> where TActionReceiver : global::MFKJEENFGIJ<TAction, Task<global::MLGLHJLHANB<object, ILGFEOBJLPI>>> where TActionDeps : global::LHIPKNAMCNO<TAction> where TStaticNetSysDeps : global::PEDNGMELDGP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private interface IAALMMMDAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HBOJNCMJLHL(in global::MLGLHJLHANB<object, ILGFEOBJLPI> DGEANHLCFIF);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void GPFPKBPNHEL();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::MLGLHJLHANB<object, ILGFEOBJLPI> DMPEKJNEJFK();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NPOAOCBPACI(Exception PBJEPEIMLPD);
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class CHHKCFDFGLA : IAALMMMDAOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<global::MLGLHJLHANB<object, ILGFEOBJLPI>> KNNCGCFODOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::MLGLHJLHANB<object, CKKOAAAACEJ>> OLGCJBMNLBF;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x357D3D0", Offset = "0x357C1D0", VA = "0x18357D3D0")]
		private CHHKCFDFGLA(TaskCompletionSource<global::MLGLHJLHANB<object, ILGFEOBJLPI>> JOEEKFNBNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2C3A740", Offset = "0x2C39540", VA = "0x182C3A740")]
		public static CHHKCFDFGLA LBKFKMLCCNN(TaskCompletionSource<global::MLGLHJLHANB<object, ILGFEOBJLPI>> JOEEKFNBNOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x357D2D0", Offset = "0x357C0D0", VA = "0x18357D2D0")]
		public void HBOJNCMJLHL(in global::MLGLHJLHANB<object, ILGFEOBJLPI> DGEANHLCFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x357D1F0", Offset = "0x357BFF0", VA = "0x18357D1F0", Slot = "5")]
		public void GPFPKBPNHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x357D140", Offset = "0x357BF40", VA = "0x18357D140", Slot = "6")]
		public global::MLGLHJLHANB<object, ILGFEOBJLPI> DMPEKJNEJFK()
		{
			return default(global::MLGLHJLHANB<object, ILGFEOBJLPI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x357D370", Offset = "0x357C170", VA = "0x18357D370", Slot = "7")]
		public void NPOAOCBPACI(Exception PBJEPEIMLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x296A3A0", Offset = "0x29691A0", VA = "0x18296A3A0", Slot = "4")]
		private void LBABGGMEACD(in global::MLGLHJLHANB<object, ILGFEOBJLPI> DGEANHLCFIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class CHLKICGJGID : IAALMMMDAOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<global::MLGLHJLHANB<object, ILGFEOBJLPI>> KNNCGCFODOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private global::MLGLHJLHANB<object, ILGFEOBJLPI> PMBPENFIGMM;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x28D63A0", Offset = "0x28D51A0", VA = "0x1828D63A0")]
		private CHLKICGJGID(TaskCompletionSource<global::MLGLHJLHANB<object, ILGFEOBJLPI>> JOEEKFNBNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2C3A740", Offset = "0x2C39540", VA = "0x182C3A740")]
		public static CHLKICGJGID LBKFKMLCCNN(TaskCompletionSource<global::MLGLHJLHANB<object, ILGFEOBJLPI>> JOEEKFNBNOB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x779C00", Offset = "0x778A00", VA = "0x180779C00")]
		public void HBOJNCMJLHL(in global::MLGLHJLHANB<object, ILGFEOBJLPI> DGEANHLCFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x357D470", Offset = "0x357C270", VA = "0x18357D470", Slot = "5")]
		public void GPFPKBPNHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x779B20", Offset = "0x778920", VA = "0x180779B20", Slot = "6")]
		public global::MLGLHJLHANB<object, ILGFEOBJLPI> DMPEKJNEJFK()
		{
			return default(global::MLGLHJLHANB<object, ILGFEOBJLPI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x357D4D0", Offset = "0x357C2D0", VA = "0x18357D4D0", Slot = "7")]
		public void NPOAOCBPACI(Exception PBJEPEIMLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x296A3A0", Offset = "0x29691A0", VA = "0x18296A3A0", Slot = "4")]
		private void LBABGGMEACD(in global::MLGLHJLHANB<object, ILGFEOBJLPI> DGEANHLCFIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class JNPELFIPFHF : IAALMMMDAOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<global::MLGLHJLHANB<object, ILGFEOBJLPI>> OLGCJBMNLBF;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6FF0", Offset = "0x2BA5DF0", VA = "0x182BA6FF0")]
		private JNPELFIPFHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x296A3D0", Offset = "0x29691D0", VA = "0x18296A3D0")]
		public static JNPELFIPFHF LBKFKMLCCNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6F90", Offset = "0x2BA5D90", VA = "0x182BA6F90")]
		public void HBOJNCMJLHL(in global::MLGLHJLHANB<object, ILGFEOBJLPI> DGEANHLCFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		public void GPFPKBPNHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2BA6F30", Offset = "0x2BA5D30", VA = "0x182BA6F30", Slot = "6")]
		public global::MLGLHJLHANB<object, ILGFEOBJLPI> DMPEKJNEJFK()
		{
			return default(global::MLGLHJLHANB<object, ILGFEOBJLPI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "7")]
		public void NPOAOCBPACI(Exception PBJEPEIMLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x296A3A0", Offset = "0x29691A0", VA = "0x18296A3A0", Slot = "4")]
		private void LBABGGMEACD(in global::MLGLHJLHANB<object, ILGFEOBJLPI> DGEANHLCFIF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class BBNLMMABKKL : IAALMMMDAOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private global::MLGLHJLHANB<object, ILGFEOBJLPI> PMBPENFIGMM;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		private BBNLMMABKKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x296A3D0", Offset = "0x29691D0", VA = "0x18296A3D0")]
		public static BBNLMMABKKL LBKFKMLCCNN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7876B0", Offset = "0x7864B0", VA = "0x1807876B0")]
		public void HBOJNCMJLHL(in global::MLGLHJLHANB<object, ILGFEOBJLPI> DGEANHLCFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "5")]
		public void GPFPKBPNHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x73BC90", Offset = "0x73AA90", VA = "0x18073BC90", Slot = "6")]
		public global::MLGLHJLHANB<object, ILGFEOBJLPI> DMPEKJNEJFK()
		{
			return default(global::MLGLHJLHANB<object, ILGFEOBJLPI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "7")]
		public void NPOAOCBPACI(Exception PBJEPEIMLPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x296A3A0", Offset = "0x29691A0", VA = "0x18296A3A0", Slot = "4")]
		private void LBABGGMEACD(in global::MLGLHJLHANB<object, ILGFEOBJLPI> DGEANHLCFIF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IAJBCDLFHCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<global::MLGLHJLHANB<object, ILGFEOBJLPI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::KDEGCEKFIOL<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::BLDAKPIDCBI<GBIKIDEDKIO> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public global::BLDAKPIDCBI<NBANKALLDNA> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<global::MLGLHJLHANB<object, ILGFEOBJLPI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2AA71B0", Offset = "0x2AA5FB0", VA = "0x182AA71B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2AA7460", Offset = "0x2AA6260", VA = "0x182AA7460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct FLJLGCDGKPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<global::MLGLHJLHANB<object, ILGFEOBJLPI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public global::KDEGCEKFIOL<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public global::BLDAKPIDCBI<GBIKIDEDKIO> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public global::BLDAKPIDCBI<NBANKALLDNA> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private IAALMMMDAOI <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x36DBE00", Offset = "0x36DAC00", VA = "0x1836DBE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x36DC7C0", Offset = "0x36DB5C0", VA = "0x1836DC7C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct KKEDMPLIDCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public global::KDEGCEKFIOL<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public IAALMMMDAOI completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private IAALMMMDAOI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<global::MLGLHJLHANB<object, ILGFEOBJLPI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x272D160", Offset = "0x272BF60", VA = "0x18272D160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x14868C0", Offset = "0x14856C0", VA = "0x1814868C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TActionReceiver CIHHMGNDEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TActionDeps OFDGBMDIKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TStaticNetSysDeps JPOBAMIKJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int KLIGIGHFJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int CLMBIJALIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Dictionary<global::BLDAKPIDCBI<NBANKALLDNA>, TaskCompletionSource<global::MLGLHJLHANB<object, ILGFEOBJLPI>>> DKNIACFFDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private global::MPOOBNGBODE<NBANKALLDNA> BMHAOHBPICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int NGBGIJHOIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task DHNPPOAAGHL;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NODAILDCOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x925EB0", Offset = "0x924CB0", VA = "0x180925EB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x926640", Offset = "0x925440", VA = "0x180926640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1790", Offset = "0x2BC0590", VA = "0x182BC1790")]
	protected KDEGCEKFIOL(TActionDeps IHHACMFACFM, TStaticNetSysDeps BHDHJJFAPCI, int HMEFEEFNBPA, int FABELFPKAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1640", Offset = "0x2BC0440", VA = "0x182BC1640")]
	public static global::KDEGCEKFIOL<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> LBKFKMLCCNN(TActionDeps IHHACMFACFM, TStaticNetSysDeps BHDHJJFAPCI, [Optional] int? HMEFEEFNBPA, [Optional] int? FABELFPKAFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0DD0", Offset = "0x2BBFBD0", VA = "0x182BC0DD0")]
	public Task<global::MLGLHJLHANB<object, ILGFEOBJLPI>> DCBHIJKLFMM(in TAction KKJDJCJOLIF, bool CDBMCJIDAEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1780", Offset = "0x2BC0580", VA = "0x182BC1780")]
	public void MKNJCOAFPGF(in TActionReceiver CFCLEAHENJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1020", Offset = "0x2BBFE20", VA = "0x182BC1020")]
	[AsyncStateMachine(typeof(global::KDEGCEKFIOL<, , , >.IAJBCDLFHCO))]
	public Task<global::MLGLHJLHANB<object, ILGFEOBJLPI>> DKPOOGFEAEI(global::BLDAKPIDCBI<GBIKIDEDKIO> BAOCCOKLHIB, global::BLDAKPIDCBI<NBANKALLDNA> GAOCBNNBJAD, TAction KKJDJCJOLIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2BC12C0", Offset = "0x2BC00C0", VA = "0x182BC12C0")]
	[AsyncStateMachine(typeof(global::KDEGCEKFIOL<, , , >.FLJLGCDGKPE))]
	private Task<global::MLGLHJLHANB<object, ILGFEOBJLPI>> FNLLLKAHHMO(global::BLDAKPIDCBI<GBIKIDEDKIO> BAOCCOKLHIB, global::BLDAKPIDCBI<NBANKALLDNA> GAOCBNNBJAD, TAction KKJDJCJOLIF, Task DBDCHANDAMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1180", Offset = "0x2BBFF80", VA = "0x182BC1180")]
	[AsyncStateMachine(typeof(global::KDEGCEKFIOL<, , , >.KKEDMPLIDCL))]
	private Task FKKACKNEDOG(TAction KKJDJCJOLIF, IAALMMMDAOI PBNFEDOAJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x2BC1430", Offset = "0x2BC0230", VA = "0x182BC1430")]
	private void GONOGGILFAG(TAction KKJDJCJOLIF, bool JPJMANCMJEH, bool GCBNMPPKJEH)
	{
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
