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
public interface KFKKAONGEGD<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BNBHAGINKMN(TAction CIAILAMJPDB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction HPEHMNNOFNF(TAction CIAILAMJPDB);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction DGFADGIADLP(TAction CIAILAMJPDB);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> BBKCDGJCPFC(TAction CIAILAMJPDB);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NFMBBMBCPOB(TAction CIAILAMJPDB);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DOMFONOEEFB(TAction CIAILAMJPDB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JCBJKBBLHFF(TAction CIAILAMJPDB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LIKGEEIJFLK(TAction CIAILAMJPDB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DMJPCNGJKKI(TAction CIAILAMJPDB);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GNOOIKFIBHK<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::FGACGKAHALI<AGLHAAEPCAC> OIPHLGDFNBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int CHLODFKOMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JMIPGHKGGEF();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHJMCJLADFA(global::FGACGKAHALI<NEBBOHMCCLE> HPIKIBFKIMD, TAction CIAILAMJPDB);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LEAOHGKCIPB<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JJMDBGDDCAG(in TPartialSnapshot LPPJEIDPNJB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot BNJFBGDPDOM(TPartialSnapshot[] DLJGMCIMCMM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JLDHDAPDKIO<TAction, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult FJEHDMONNKF(TAction CIAILAMJPDB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction[] AOGDAMJOJCF();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class AGLHAAEPCAC
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class NEBBOHMCCLE
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct CKADFJFFLIK<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::LEAOHGKCIPB<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialSnapshot[] IDDLGEPIONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int HMOEOKKLACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps PDHCOEFNNFH;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x38C05A0", Offset = "0x38BF3A0", VA = "0x1838C05A0")]
	internal CKADFJFFLIK(TPartialSnapshot[] DIJBHICDCLG, int KBIFKOIHIBO, TDeps OKLHHFIFADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x38C0540", Offset = "0x38BF340", VA = "0x1838C0540")]
	public static global::CKADFJFFLIK<TPartialSnapshot, TFullSnapshot, TDeps> PKGIDMHJGMJ(TDeps OKLHHFIFADA)
	{
		return default(global::CKADFJFFLIK<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EGKIHCHEAFM
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3486860", Offset = "0x3485660", VA = "0x183486860")]
	public static global::FLKGDOLJLDJ<TFullSnapshot> DIBIOBAHDLK<TFullSnapshot, TPartialSnapshot, TDeps>(this ref global::CKADFJFFLIK<TPartialSnapshot, TFullSnapshot, TDeps> BIKHFKCJEPO, TPartialSnapshot LPPJEIDPNJB) where TDeps : global::LEAOHGKCIPB<TPartialSnapshot, TFullSnapshot>
	{
		return default(global::FLKGDOLJLDJ<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3486780", Offset = "0x3485580", VA = "0x183486780")]
	public static bool DBPIEEFMAMG<TPartialSnapshot, TFullSnapshot, TDeps>(this ref global::CKADFJFFLIK<TPartialSnapshot, TFullSnapshot, TDeps> BIKHFKCJEPO, TPartialSnapshot LPPJEIDPNJB) where TDeps : global::LEAOHGKCIPB<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public sealed class HCELJJHELGH : PEOIGJADBLL
{
	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x21E7690", Offset = "0x21E6490", VA = "0x1821E7690", Slot = "5")]
	public override string CFFNHDCOJGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x21E76C0", Offset = "0x21E64C0", VA = "0x1821E76C0")]
	public HCELJJHELGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LOALLONCDKK<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> where TActionReceiver : global::JLDHDAPDKIO<TAction, Task<global::NCCJCEGIOLD<object, PEOIGJADBLL>>> where TActionDeps : global::KFKKAONGEGD<TAction> where TStaticNetSysDeps : global::GNOOIKFIBHK<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private interface AGPBMEHLGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GPGOCDCFHLF(in global::NCCJCEGIOLD<object, PEOIGJADBLL> LILKGIPDCFO);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NIDFMOKIABD();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::NCCJCEGIOLD<object, PEOIGJADBLL> HDPJMBAIIBC();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void NLPLKCGEGFJ(Exception IHBJIAPIGNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class FCFODFMNADE : AGPBMEHLGOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<global::NCCJCEGIOLD<object, PEOIGJADBLL>> CNIBMKLDILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::NCCJCEGIOLD<object, GCOFNEOKNEG>> EHEBKNIJJPI;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3FA82C0", Offset = "0x3FA70C0", VA = "0x183FA82C0")]
		private FCFODFMNADE(TaskCompletionSource<global::NCCJCEGIOLD<object, PEOIGJADBLL>> CDFPEKDNKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x39604A0", Offset = "0x395F2A0", VA = "0x1839604A0")]
		public static FCFODFMNADE PKGIDMHJGMJ(TaskCompletionSource<global::NCCJCEGIOLD<object, PEOIGJADBLL>> CDFPEKDNKAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3FA8030", Offset = "0x3FA6E30", VA = "0x183FA8030")]
		public void GPGOCDCFHLF(in global::NCCJCEGIOLD<object, PEOIGJADBLL> LILKGIPDCFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3FA8180", Offset = "0x3FA6F80", VA = "0x183FA8180", Slot = "5")]
		public void NIDFMOKIABD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3FA80D0", Offset = "0x3FA6ED0", VA = "0x183FA80D0", Slot = "6")]
		public global::NCCJCEGIOLD<object, PEOIGJADBLL> HDPJMBAIIBC()
		{
			return default(global::NCCJCEGIOLD<object, PEOIGJADBLL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3FA8260", Offset = "0x3FA7060", VA = "0x183FA8260", Slot = "7")]
		public void NLPLKCGEGFJ(Exception IHBJIAPIGNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x22E6460", Offset = "0x22E5260", VA = "0x1822E6460", Slot = "4")]
		private void DPHCIJDJPIG(in global::NCCJCEGIOLD<object, PEOIGJADBLL> LILKGIPDCFO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class DCFMKJFCFOM : AGPBMEHLGOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<global::NCCJCEGIOLD<object, PEOIGJADBLL>> CNIBMKLDILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private global::NCCJCEGIOLD<object, PEOIGJADBLL> MLOPHJOBCJD;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2C161E0", Offset = "0x2C14FE0", VA = "0x182C161E0")]
		private DCFMKJFCFOM(TaskCompletionSource<global::NCCJCEGIOLD<object, PEOIGJADBLL>> CDFPEKDNKAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x39604A0", Offset = "0x395F2A0", VA = "0x1839604A0")]
		public static DCFMKJFCFOM PKGIDMHJGMJ(TaskCompletionSource<global::NCCJCEGIOLD<object, PEOIGJADBLL>> CDFPEKDNKAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x90CDC0", Offset = "0x90BBC0", VA = "0x18090CDC0")]
		public void GPGOCDCFHLF(in global::NCCJCEGIOLD<object, PEOIGJADBLL> LILKGIPDCFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3FEBFA0", Offset = "0x3FEADA0", VA = "0x183FEBFA0", Slot = "5")]
		public void NIDFMOKIABD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82A0B0", Offset = "0x828EB0", VA = "0x18082A0B0", Slot = "6")]
		public global::NCCJCEGIOLD<object, PEOIGJADBLL> HDPJMBAIIBC()
		{
			return default(global::NCCJCEGIOLD<object, PEOIGJADBLL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3FEC000", Offset = "0x3FEAE00", VA = "0x183FEC000", Slot = "7")]
		public void NLPLKCGEGFJ(Exception IHBJIAPIGNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x22E6460", Offset = "0x22E5260", VA = "0x1822E6460", Slot = "4")]
		private void DPHCIJDJPIG(in global::NCCJCEGIOLD<object, PEOIGJADBLL> LILKGIPDCFO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class EPGPEAGGHLA : AGPBMEHLGOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<global::NCCJCEGIOLD<object, PEOIGJADBLL>> EHEBKNIJJPI;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x22E6610", Offset = "0x22E5410", VA = "0x1822E6610")]
		private EPGPEAGGHLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x22E6550", Offset = "0x22E5350", VA = "0x1822E6550")]
		public static EPGPEAGGHLA PKGIDMHJGMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x22E6490", Offset = "0x22E5290", VA = "0x1822E6490")]
		public void GPGOCDCFHLF(in global::NCCJCEGIOLD<object, PEOIGJADBLL> LILKGIPDCFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		public void NIDFMOKIABD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x22E64F0", Offset = "0x22E52F0", VA = "0x1822E64F0", Slot = "6")]
		public global::NCCJCEGIOLD<object, PEOIGJADBLL> HDPJMBAIIBC()
		{
			return default(global::NCCJCEGIOLD<object, PEOIGJADBLL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "7")]
		public void NLPLKCGEGFJ(Exception IHBJIAPIGNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x22E6460", Offset = "0x22E5260", VA = "0x1822E6460", Slot = "4")]
		private void DPHCIJDJPIG(in global::NCCJCEGIOLD<object, PEOIGJADBLL> LILKGIPDCFO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class ILGLHDHNOFA : AGPBMEHLGOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private global::NCCJCEGIOLD<object, PEOIGJADBLL> MLOPHJOBCJD;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		private ILGLHDHNOFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x22E6550", Offset = "0x22E5350", VA = "0x1822E6550")]
		public static ILGLHDHNOFA PKGIDMHJGMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA3F870", Offset = "0xA3E670", VA = "0x180A3F870")]
		public void GPGOCDCFHLF(in global::NCCJCEGIOLD<object, PEOIGJADBLL> LILKGIPDCFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "5")]
		public void NIDFMOKIABD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x909CA0", Offset = "0x908AA0", VA = "0x180909CA0", Slot = "6")]
		public global::NCCJCEGIOLD<object, PEOIGJADBLL> HDPJMBAIIBC()
		{
			return default(global::NCCJCEGIOLD<object, PEOIGJADBLL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "7")]
		public void NLPLKCGEGFJ(Exception IHBJIAPIGNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x22E6460", Offset = "0x22E5260", VA = "0x1822E6460", Slot = "4")]
		private void DPHCIJDJPIG(in global::NCCJCEGIOLD<object, PEOIGJADBLL> LILKGIPDCFO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct HBAMCDBNLPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<global::NCCJCEGIOLD<object, PEOIGJADBLL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::LOALLONCDKK<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::FGACGKAHALI<AGLHAAEPCAC> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public global::FGACGKAHALI<NEBBOHMCCLE> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<global::NCCJCEGIOLD<object, PEOIGJADBLL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x40CFC50", Offset = "0x40CEA50", VA = "0x1840CFC50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x40CFF00", Offset = "0x40CED00", VA = "0x1840CFF00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct IFEPGGDOIOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder<global::NCCJCEGIOLD<object, PEOIGJADBLL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public global::LOALLONCDKK<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public global::FGACGKAHALI<AGLHAAEPCAC> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public global::FGACGKAHALI<NEBBOHMCCLE> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private AGPBMEHLGOF <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2C126D0", Offset = "0x2C114D0", VA = "0x182C126D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2C13090", Offset = "0x2C11E90", VA = "0x182C13090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct FBMHIPADLFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public global::LOALLONCDKK<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AGPBMEHLGOF completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private AGPBMEHLGOF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<global::NCCJCEGIOLD<object, PEOIGJADBLL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3FA5810", Offset = "0x3FA4610", VA = "0x183FA5810", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA73C20", Offset = "0xA72A20", VA = "0x180A73C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TActionReceiver EJAJIDLHKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TActionDeps JJKEEMBEGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly TStaticNetSysDeps KBHLGJGLMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int GDNKOEEFLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int AHPGDAFFFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Dictionary<global::FGACGKAHALI<NEBBOHMCCLE>, TaskCompletionSource<global::NCCJCEGIOLD<object, PEOIGJADBLL>>> KPKHNHJDEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private global::PJFOJBLEPCM<NEBBOHMCCLE> MAHEPPPMCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int DEGLHLMGIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task OBHKFHBIMLJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool PPAIAIKAMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F7020", Offset = "0x6F5E20", VA = "0x1806F7020")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x986320", Offset = "0x985120", VA = "0x180986320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x39048C0", Offset = "0x39036C0", VA = "0x1839048C0")]
	protected LOALLONCDKK(TActionDeps FNAGNMEPBDH, TStaticNetSysDeps IBBADOLLDNJ, int PCJJBLKMCIG, int DADCENNNJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3904780", Offset = "0x3903580", VA = "0x183904780")]
	public static global::LOALLONCDKK<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> PKGIDMHJGMJ(TActionDeps FNAGNMEPBDH, TStaticNetSysDeps IBBADOLLDNJ, [Optional] int? PCJJBLKMCIG, [Optional] int? DADCENNNJPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3903E90", Offset = "0x3902C90", VA = "0x183903E90")]
	public Task<global::NCCJCEGIOLD<object, PEOIGJADBLL>> BHJMCJLADFA(in TAction CIAILAMJPDB, bool LHKDMIGNNHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3904600", Offset = "0x3903400", VA = "0x183904600")]
	public void NPOPHIGEGAC(in TActionReceiver HNFGNPPLOKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3904290", Offset = "0x3903090", VA = "0x183904290")]
	[AsyncStateMachine(typeof(global::LOALLONCDKK<, , , >.HBAMCDBNLPP))]
	public Task<global::NCCJCEGIOLD<object, PEOIGJADBLL>> FJEHDMONNKF(global::FGACGKAHALI<AGLHAAEPCAC> BKKGIODOEGK, global::FGACGKAHALI<NEBBOHMCCLE> HPIKIBFKIMD, TAction CIAILAMJPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3904610", Offset = "0x3903410", VA = "0x183904610")]
	[AsyncStateMachine(typeof(global::LOALLONCDKK<, , , >.IFEPGGDOIOL))]
	private Task<global::NCCJCEGIOLD<object, PEOIGJADBLL>> PBGCEHAHBNF(global::FGACGKAHALI<AGLHAAEPCAC> BKKGIODOEGK, global::FGACGKAHALI<NEBBOHMCCLE> HPIKIBFKIMD, TAction CIAILAMJPDB, Task NNKIFLFHJIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3904150", Offset = "0x3902F50", VA = "0x183904150")]
	[AsyncStateMachine(typeof(global::LOALLONCDKK<, , , >.FBMHIPADLFG))]
	private Task EHAAPBFBDLH(TAction CIAILAMJPDB, AGPBMEHLGOF MIMCCBNDNCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x39043F0", Offset = "0x39031F0", VA = "0x1839043F0")]
	private void KPCKIDENCHN(TAction CIAILAMJPDB, bool FCPFLFJJIDJ, bool BHLIHFLBHLI)
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
