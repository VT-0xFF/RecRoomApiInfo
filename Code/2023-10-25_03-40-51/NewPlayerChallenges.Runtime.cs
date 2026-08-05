using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BCCBGMLIAPD : ReadOnlyCollection<CENCANDHONG>, CPBEDGIPGLJ, IReadOnlyCollection<CENCANDHONG>, IEnumerable<CENCANDHONG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string FJPKIFMMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Sprite OFPMPGGHDCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x51CB250", Offset = "0x51CA050", VA = "0x1851CB250")]
	public BCCBGMLIAPD([NotNull] string MEBBBIMBIJO, [NotNull] IList<CENCANDHONG> MJLHCFFNENL, [NotNull] Sprite DJGBJPAGEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x51CB120", Offset = "0x51C9F20", VA = "0x1851CB120", Slot = "37")]
	public bool HHNPPCOAHMO(CENCANDHONG ACEBJEABOAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum JNIIOIAHIEB
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Screens,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	VR
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CPBEDGIPGLJ : IReadOnlyCollection<CENCANDHONG>, IEnumerable<CENCANDHONG>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IJHOHIAHCAE
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JNIIOIAHIEB JKCAHKOCBCK();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface ANAELEICKLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MEAEBHMKFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FPBLCGKCPBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool KEOMHMHMGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TimeSpan DMOPPHPEDDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action OOAJNGAGIPG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action CPONOFNOBPH;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CENCANDHONG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface FJAFNPALGEN
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		Sprite PCKBANHNCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int EPLCNKHINFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KEFLGJOEKGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string PCFBCHGDHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	BCCBGMLIAPD FFLCFOAOFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string BBJEIEHPCKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Texture2D OLKOGABDLON
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Sprite OFPMPGGHDCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	JMEHFDGFONM DJGLLLFDKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool HEIACECHCMK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool LEICACPBEDD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<CENCANDHONG> NGLIPGBBALE;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	MMMPEMHFGNJ IPPDBPLBENB();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MIDEJKJPMAF<bool> PNIEDNBBENG();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IGABPNEKDFG
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool MBBOJGODHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool BMNAPOPOPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool ENKDCJGJPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool ENCGEOJLCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int HIGNHLPLMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<CENCANDHONG> DNKJJCIMIFC;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CENCANDHONG HHFFHMFAGCG(Predicate<CENCANDHONG> PBJIJLDACJM);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<CENCANDHONG> KMLKGCDIOEG();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OLBFOFOEHBK
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool NLJAAEGOAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action ILFEJABEGIL;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action JHIIPJKJACA;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DCAJJPEGJPE();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GFILDKPDABM();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JHIBIMMNCGK : IGABPNEKDFG
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface HBDDMCKOBHE
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		IEnumerable<CENCANDHONG> BBBEPGEOGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		IReadOnlyList<CPBEDGIPGLJ> MDMODCBHDEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int KGLMAFLECBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface BDLILNNAAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HBDDMCKOBHE> OKNHPBNKKAM(IGABPNEKDFG DKAJFKJEHGO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class KDCPKIMIONI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public Predicate<CENCANDHONG> predicate;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public KDCPKIMIONI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x34B7B40", Offset = "0x34B6940", VA = "0x1834B7B40")]
		internal bool LHDLNINOAKG(CENCANDHONG challenge)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct OIGPMHDDNCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JHIBIMMNCGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<HBDDMCKOBHE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x51CCEF0", Offset = "0x51CBCF0", VA = "0x1851CCEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x865C40", Offset = "0x864A40", VA = "0x180865C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly ANAELEICKLJ CCAPIFJFLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly BDLILNNAAIO DCEHOEMJGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private HBDDMCKOBHE IONBHILEGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private IReadOnlyList<CPBEDGIPGLJ> HACGEHDOIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private IEnumerable<CENCANDHONG> OFHEBCALAKI;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool KEOMHMHMGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x51CB9C0", Offset = "0x51CA7C0", VA = "0x1851CB9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool MBBOJGODHHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x51CC950", Offset = "0x51CB750", VA = "0x1851CC950", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool BMNAPOPOPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x51CC450", Offset = "0x51CB250", VA = "0x1851CC450", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool ENKDCJGJPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x51CC660", Offset = "0x51CB460", VA = "0x1851CC660", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool ENCGEOJLCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x51CBA10", Offset = "0x51CA810", VA = "0x1851CBA10", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int HIGNHLPLMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x51CC280", Offset = "0x51CB080", VA = "0x1851CC280", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IReadOnlyList<CPBEDGIPGLJ> MDMODCBHDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<CENCANDHONG> DNKJJCIMIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x51CC1D0", Offset = "0x51CAFD0", VA = "0x1851CC1D0", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x51CC3A0", Offset = "0x51CB1A0", VA = "0x1851CC3A0", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x51CCD10", Offset = "0x51CBB10", VA = "0x1851CCD10")]
	[Preserve]
	public JHIBIMMNCGK([FGPOJKOJBFM(null)][NotNull] ANAELEICKLJ CCAPIFJFLHD, [FGPOJKOJBFM(null)][NotNull] BDLILNNAAIO DCEHOEMJGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x51CBD70", Offset = "0x51CAB70", VA = "0x1851CBD70", Slot = "14")]
	public IEnumerable<CENCANDHONG> FONPPONJBLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x51CC780", Offset = "0x51CB580", VA = "0x1851CC780", Slot = "12")]
	public IEnumerable<CENCANDHONG> KMLKGCDIOEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x51CC080", Offset = "0x51CAE80", VA = "0x1851CC080", Slot = "11")]
	public CENCANDHONG HHFFHMFAGCG(Predicate<CENCANDHONG> PBJIJLDACJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x51CBFD0", Offset = "0x51CADD0", VA = "0x1851CBFD0")]
	[AsyncStateMachine(typeof(OIGPMHDDNCD))]
	private void GJNIPHIANNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x51CC9E0", Offset = "0x51CB7E0", VA = "0x1851CC9E0")]
	private void NOAMECOGMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x51CBB30", Offset = "0x51CA930", VA = "0x1851CBB30")]
	private void FAEONEFPKGP(CENCANDHONG ACEBJEABOAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BOFFOIHJAGB : OLBFOFOEHBK
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface FPHEAAHJPHO
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int KNGBLHDDJMP
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface EHIFNNGGLNL
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		int HKAPEABGKHC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private readonly EHIFNNGGLNL PLMIDIDEAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly IGABPNEKDFG DKAJFKJEHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly int HNFPPFHAPHF;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private int OPIDHLLLHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x51CB340", Offset = "0x51CA140", VA = "0x1851CB340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool NLJAAEGOAPL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x51CB500", Offset = "0x51CA300", VA = "0x1851CB500", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action ILFEJABEGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x51CB460", Offset = "0x51CA260", VA = "0x1851CB460", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x51CB7C0", Offset = "0x51CA5C0", VA = "0x1851CB7C0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action JHIIPJKJACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x51CB590", Offset = "0x51CA390", VA = "0x1851CB590", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x51CB720", Offset = "0x51CA520", VA = "0x1851CB720", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x51CB860", Offset = "0x51CA660", VA = "0x1851CB860")]
	[Preserve]
	public BOFFOIHJAGB([FGPOJKOJBFM(null)][NotNull] FPHEAAHJPHO CJKPPELFMLC, [FGPOJKOJBFM(null)][NotNull] EHIFNNGGLNL PLMIDIDEAKE, [FGPOJKOJBFM(null)][NotNull] IGABPNEKDFG DKAJFKJEHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x51CB390", Offset = "0x51CA190", VA = "0x1851CB390", Slot = "5")]
	public void DCAJJPEGJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x51CB630", Offset = "0x51CA430", VA = "0x1851CB630", Slot = "6")]
	public void GFILDKPDABM()
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
