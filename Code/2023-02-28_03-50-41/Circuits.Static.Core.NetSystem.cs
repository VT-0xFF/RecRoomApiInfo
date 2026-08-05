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
public interface OJBKFDLMNBG<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int EBDFPOLGDKL(TAction CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction LIMNILNCAHN(TAction CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction MAHABOLLEGH(TAction CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> DLOMGEMHEPJ(TAction CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FODFBJMLNND(TAction CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HMMLPJNCINN(TAction CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DCDHLNGNHCO(TAction CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool NDBANKPNOFG(TAction CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HAOLLBGJONA(TAction CKAPOBIDCEI);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PIOEPOHJIDI<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::GJECEMGANGF<FNHIAGNKANJ> LIFLBJEFAMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int JIFLPHGNHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FENGNIGFECC();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OOEIPFJIMKK(global::GJECEMGANGF<LLBJOCLOEDC> PLPPGBBMDBN, TAction CKAPOBIDCEI);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CBAAEBHNOCA<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BMPAPDPFGMD(in TPartialSnapshot EBJIKAFHKGC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot OAECJGCNIGL(TPartialSnapshot[] CJMAPODIGKE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IBHDFOELJIL<TAction, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult NOAJGABDMBK(TAction CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction[] OMEGDBLOHHA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class FNHIAGNKANJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class LLBJOCLOEDC
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct HIACBJGGKFM<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::CBAAEBHNOCA<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialSnapshot[] EKONMEBPAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int JKECDKANLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps KCLACGDGMEA;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3FC0", Offset = "0x3BA29C0", VA = "0x183BA3FC0")]
	internal HIACBJGGKFM(TPartialSnapshot[] DJHJKKJLIFK, int JMLLFIEJFGP, TDeps CFFEHCJNLHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3BA3EF0", Offset = "0x3BA28F0", VA = "0x183BA3EF0")]
	public static global::HIACBJGGKFM<TPartialSnapshot, TFullSnapshot, TDeps> EEKKKHPKBPD(TDeps CFFEHCJNLHI)
	{
		return default(global::HIACBJGGKFM<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class AIPFGOHMPAB
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x23EAC70", Offset = "0x23E9670", VA = "0x1823EAC70")]
	public static global::POPCPOCKAPJ<TFullSnapshot> MMKLCNABFPK<TFullSnapshot, TPartialSnapshot, TDeps>(this ref global::HIACBJGGKFM<TPartialSnapshot, TFullSnapshot, TDeps> DCIIOIKIJFP, TPartialSnapshot EBJIKAFHKGC) where TDeps : global::CBAAEBHNOCA<TPartialSnapshot, TFullSnapshot>
	{
		return default(global::POPCPOCKAPJ<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x23EAB90", Offset = "0x23E9590", VA = "0x1823EAB90")]
	public static bool IICHBOJGBCC<TPartialSnapshot, TFullSnapshot, TDeps>(this ref global::HIACBJGGKFM<TPartialSnapshot, TFullSnapshot, TDeps> DCIIOIKIJFP, TPartialSnapshot EBJIKAFHKGC) where TDeps : global::CBAAEBHNOCA<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class IGMIBBDMDJH : EKKNDELMKBB
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xEB0320", Offset = "0xEAED20", VA = "0x180EB0320", Slot = "5")]
	public override string GCAMGOIPAJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xEB0350", Offset = "0xEAED50", VA = "0x180EB0350")]
	public IGMIBBDMDJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IIGJAEKBBOB<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> where TActionReceiver : global::IBHDFOELJIL<TAction, Task<global::HJJOMCAHDKC<object, EKKNDELMKBB>>> where TActionDeps : global::OJBKFDLMNBG<TAction> where TStaticNetSysDeps : global::PIOEPOHJIDI<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private interface NBEJMDNIMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KJENODAANMC(in global::HJJOMCAHDKC<object, EKKNDELMKBB> OAFMFLFMLNI);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BHNBDHBIOIJ();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::HJJOMCAHDKC<object, EKKNDELMKBB> BGHBLBJJAKE();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OEFJGJIJDCN(Exception IJOOFLECOBD);
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class PNGGJPGFDDE : NBEJMDNIMMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<global::HJJOMCAHDKC<object, EKKNDELMKBB>> DNNJOGGINFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::HJJOMCAHDKC<object, PJMBHANDPHF>> HDMGHOPMMKB;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2A63350", Offset = "0x2A61D50", VA = "0x182A63350")]
		private PNGGJPGFDDE(TaskCompletionSource<global::HJJOMCAHDKC<object, EKKNDELMKBB>> OLFIOJFAFJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x259D400", Offset = "0x259BE00", VA = "0x18259D400")]
		public static PNGGJPGFDDE EEKKKHPKBPD(TaskCompletionSource<global::HJJOMCAHDKC<object, EKKNDELMKBB>> OLFIOJFAFJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2A63250", Offset = "0x2A61C50", VA = "0x182A63250")]
		public void KJENODAANMC(in global::HJJOMCAHDKC<object, EKKNDELMKBB> OAFMFLFMLNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2A63170", Offset = "0x2A61B70", VA = "0x182A63170", Slot = "5")]
		public void BHNBDHBIOIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2A630C0", Offset = "0x2A61AC0", VA = "0x182A630C0", Slot = "6")]
		public global::HJJOMCAHDKC<object, EKKNDELMKBB> BGHBLBJJAKE()
		{
			return default(global::HJJOMCAHDKC<object, EKKNDELMKBB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2A632F0", Offset = "0x2A61CF0", VA = "0x182A632F0", Slot = "7")]
		public void OEFJGJIJDCN(Exception IJOOFLECOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2220340", Offset = "0x221ED40", VA = "0x182220340", Slot = "4")]
		private void ABBLHHBDNNM(in global::HJJOMCAHDKC<object, EKKNDELMKBB> OAFMFLFMLNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class DKBMMEALGGL : NBEJMDNIMMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<global::HJJOMCAHDKC<object, EKKNDELMKBB>> DNNJOGGINFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private global::HJJOMCAHDKC<object, EKKNDELMKBB> IBEHLAMBILI;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1FDE890", Offset = "0x1FDD290", VA = "0x181FDE890")]
		private DKBMMEALGGL(TaskCompletionSource<global::HJJOMCAHDKC<object, EKKNDELMKBB>> OLFIOJFAFJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x259D400", Offset = "0x259BE00", VA = "0x18259D400")]
		public static DKBMMEALGGL EEKKKHPKBPD(TaskCompletionSource<global::HJJOMCAHDKC<object, EKKNDELMKBB>> OLFIOJFAFJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x259D4D0", Offset = "0x259BED0", VA = "0x18259D4D0")]
		public void KJENODAANMC(in global::HJJOMCAHDKC<object, EKKNDELMKBB> OAFMFLFMLNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x259D3A0", Offset = "0x259BDA0", VA = "0x18259D3A0", Slot = "5")]
		public void BHNBDHBIOIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6E2040", Offset = "0x6E0A40", VA = "0x1806E2040", Slot = "6")]
		public global::HJJOMCAHDKC<object, EKKNDELMKBB> BGHBLBJJAKE()
		{
			return default(global::HJJOMCAHDKC<object, EKKNDELMKBB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x259D4F0", Offset = "0x259BEF0", VA = "0x18259D4F0", Slot = "7")]
		public void OEFJGJIJDCN(Exception IJOOFLECOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2220340", Offset = "0x221ED40", VA = "0x182220340", Slot = "4")]
		private void ABBLHHBDNNM(in global::HJJOMCAHDKC<object, EKKNDELMKBB> OAFMFLFMLNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class IJINHLJMCHA : NBEJMDNIMMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<global::HJJOMCAHDKC<object, EKKNDELMKBB>> HDMGHOPMMKB;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x22204F0", Offset = "0x221EEF0", VA = "0x1822204F0")]
		private IJINHLJMCHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x22203D0", Offset = "0x221EDD0", VA = "0x1822203D0")]
		public static IJINHLJMCHA EEKKKHPKBPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2220490", Offset = "0x221EE90", VA = "0x182220490")]
		public void KJENODAANMC(in global::HJJOMCAHDKC<object, EKKNDELMKBB> OAFMFLFMLNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		public void BHNBDHBIOIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2220370", Offset = "0x221ED70", VA = "0x182220370", Slot = "6")]
		public global::HJJOMCAHDKC<object, EKKNDELMKBB> BGHBLBJJAKE()
		{
			return default(global::HJJOMCAHDKC<object, EKKNDELMKBB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
		public void OEFJGJIJDCN(Exception IJOOFLECOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2220340", Offset = "0x221ED40", VA = "0x182220340", Slot = "4")]
		private void ABBLHHBDNNM(in global::HJJOMCAHDKC<object, EKKNDELMKBB> OAFMFLFMLNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class PPOGNOCDNHE : NBEJMDNIMMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private global::HJJOMCAHDKC<object, EKKNDELMKBB> IBEHLAMBILI;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		private PPOGNOCDNHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x22203D0", Offset = "0x221EDD0", VA = "0x1822203D0")]
		public static PPOGNOCDNHE EEKKKHPKBPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x12F8210", Offset = "0x12F6C10", VA = "0x1812F8210")]
		public void KJENODAANMC(in global::HJJOMCAHDKC<object, EKKNDELMKBB> OAFMFLFMLNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		public void BHNBDHBIOIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xCC7400", Offset = "0xCC5E00", VA = "0x180CC7400", Slot = "6")]
		public global::HJJOMCAHDKC<object, EKKNDELMKBB> BGHBLBJJAKE()
		{
			return default(global::HJJOMCAHDKC<object, EKKNDELMKBB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "7")]
		public void OEFJGJIJDCN(Exception IJOOFLECOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2220340", Offset = "0x221ED40", VA = "0x182220340", Slot = "4")]
		private void ABBLHHBDNNM(in global::HJJOMCAHDKC<object, EKKNDELMKBB> OAFMFLFMLNI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IMBKGKHNDCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<global::HJJOMCAHDKC<object, EKKNDELMKBB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::IIGJAEKBBOB<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::GJECEMGANGF<FNHIAGNKANJ> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public global::GJECEMGANGF<LLBJOCLOEDC> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<global::HJJOMCAHDKC<object, EKKNDELMKBB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x23A7850", Offset = "0x23A6250", VA = "0x1823A7850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x23A7B00", Offset = "0x23A6500", VA = "0x1823A7B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct JHHBGICDGHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<global::HJJOMCAHDKC<object, EKKNDELMKBB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public global::IIGJAEKBBOB<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public global::GJECEMGANGF<FNHIAGNKANJ> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public global::GJECEMGANGF<LLBJOCLOEDC> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private NBEJMDNIMMB <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x31638C0", Offset = "0x31622C0", VA = "0x1831638C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3164280", Offset = "0x3162C80", VA = "0x183164280", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct ADHILJHDJEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public global::IIGJAEKBBOB<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public NBEJMDNIMMB completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NBEJMDNIMMB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<global::HJJOMCAHDKC<object, EKKNDELMKBB>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x35A6060", Offset = "0x35A4A60", VA = "0x1835A6060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TActionReceiver GCEPJAKBBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TActionDeps NLJICMJMNOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TStaticNetSysDeps BPMEBNDHGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int NMMICJLGAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int FFKKELJJDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Dictionary<global::GJECEMGANGF<LLBJOCLOEDC>, TaskCompletionSource<global::HJJOMCAHDKC<object, EKKNDELMKBB>>> AMOGKKLKOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private global::NMLAAPJGMLL<LLBJOCLOEDC> JHPONNHONNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int GNNOOGBBEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task LLHDKECFOIK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IDIBJHPOPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x764CE0", Offset = "0x7636E0", VA = "0x180764CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x765490", Offset = "0x763E90", VA = "0x180765490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x221D010", Offset = "0x221BA10", VA = "0x18221D010")]
	protected IIGJAEKBBOB(TActionDeps HNEGEPPAGIG, TStaticNetSysDeps KPDDGDPKFNG, int APIGBHKMPPO, int JAIBHPKGDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x221C650", Offset = "0x221B050", VA = "0x18221C650")]
	public static global::IIGJAEKBBOB<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> EEKKKHPKBPD(TActionDeps HNEGEPPAGIG, TStaticNetSysDeps KPDDGDPKFNG, [Optional] int? APIGBHKMPPO, [Optional] int? JAIBHPKGDCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x221CDC0", Offset = "0x221B7C0", VA = "0x18221CDC0")]
	public Task<global::HJJOMCAHDKC<object, EKKNDELMKBB>> OOEIPFJIMKK(in TAction CKAPOBIDCEI, bool MCDDLIGDOFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x221CAE0", Offset = "0x221B4E0", VA = "0x18221CAE0")]
	public void MADLFOKGKNJ(in TActionReceiver IOHPPIFBIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x221CC60", Offset = "0x221B660", VA = "0x18221CC60")]
	[AsyncStateMachine(typeof(global::IIGJAEKBBOB<, , , >.IMBKGKHNDCP))]
	public Task<global::HJJOMCAHDKC<object, EKKNDELMKBB>> NOAJGABDMBK(global::GJECEMGANGF<FNHIAGNKANJ> NHIJJLFOFCH, global::GJECEMGANGF<LLBJOCLOEDC> PLPPGBBMDBN, TAction CKAPOBIDCEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x221CAF0", Offset = "0x221B4F0", VA = "0x18221CAF0")]
	[AsyncStateMachine(typeof(global::IIGJAEKBBOB<, , , >.JHHBGICDGHP))]
	private Task<global::HJJOMCAHDKC<object, EKKNDELMKBB>> MLBBACLKOGF(global::GJECEMGANGF<FNHIAGNKANJ> NHIJJLFOFCH, global::GJECEMGANGF<LLBJOCLOEDC> PLPPGBBMDBN, TAction CKAPOBIDCEI, Task NOABJGAHDPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x221C790", Offset = "0x221B190", VA = "0x18221C790")]
	[AsyncStateMachine(typeof(global::IIGJAEKBBOB<, , , >.ADHILJHDJEN))]
	private Task EPPECJALODO(TAction CKAPOBIDCEI, NBEJMDNIMMB MGODMBILJJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x221C8D0", Offset = "0x221B2D0", VA = "0x18221C8D0")]
	private void KLOJKIBNDPM(TAction CKAPOBIDCEI, bool PHEMPKJKHID, bool KMONNHBOEDE)
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
