using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LHBLNIGHBHH : ODCGMHLDGHK
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface LOEIMDHOAMH
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		IEnumerable<KEFFMEPODBM> PPHHHDLPGPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		IReadOnlyList<KLHMCJLDEOK> CEKDLBFBFPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		int NLPPKNPHEGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface BFDDEIMLANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<LOEIMDHOAMH> FKIFBCABHAM();
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class NKMGIKPFNEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public Predicate<KEFFMEPODBM> predicate;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NKMGIKPFNEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72D7960", Offset = "0x72D6960", VA = "0x1872D7960")]
		internal bool BIBLLKOPAOH(KEFFMEPODBM challenge)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class LDBCKADOBPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public LHBLNIGHBHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private LOEIMDHOAMH <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private IEnumerator<KEFFMEPODBM> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private KEFFMEPODBM <challenge>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<LOEIMDHOAMH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LDBCKADOBPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72D6060", Offset = "0x72D5060", VA = "0x1872D6060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly BGMHPPFBIJK AHJILHBBFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly BFDDEIMLANF CGFCGNJAAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LOEIMDHOAMH JNIPOMHJOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private IReadOnlyList<KLHMCJLDEOK> FAODGAMNAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private IEnumerable<KEFFMEPODBM> CCJOFKNFFJK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FCGKKJHOFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72D7060", Offset = "0x72D6060", VA = "0x1872D7060", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LGFFIPBEBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72D6A50", Offset = "0x72D5A50", VA = "0x1872D6A50", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NEKEJBOEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72D70B0", Offset = "0x72D60B0", VA = "0x1872D70B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool LGECCFGNHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72D71E0", Offset = "0x72D61E0", VA = "0x1872D71E0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KDDCJKDFMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72D6F30", Offset = "0x72D5F30", VA = "0x1872D6F30", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyList<KLHMCJLDEOK> CEKDLBFBFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9132D0", Offset = "0x9122D0", VA = "0x1809132D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<KEFFMEPODBM> EEDIBEOECJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72D7310", Offset = "0x72D6310", VA = "0x1872D7310", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72D6E90", Offset = "0x72D5E90", VA = "0x1872D6E90", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x72D77A0", Offset = "0x72D67A0", VA = "0x1872D77A0")]
	[Preserve]
	public LHBLNIGHBHH([NotNull][JFLEHDEIONF(null)] BGMHPPFBIJK AHJILHBBFDM, [NotNull][JFLEHDEIONF(null)] BFDDEIMLANF CGFCGNJAAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72D73B0", Offset = "0x72D63B0", VA = "0x1872D73B0", Slot = "14")]
	public IEnumerable<KEFFMEPODBM> NBALIPCPDPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x72D6600", Offset = "0x72D5600", VA = "0x1872D6600", Slot = "12")]
	public IEnumerable<KEFFMEPODBM> DAGAAKHFIPE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72D75C0", Offset = "0x72D65C0", VA = "0x1872D75C0", Slot = "11")]
	public KEFFMEPODBM NJEIEAFDHCH(Predicate<KEFFMEPODBM> MMKCMBDLNID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72D76C0", Offset = "0x72D66C0", VA = "0x1872D76C0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LDBCKADOBPJ))]
	private void OEDKBGKKJPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x72D6790", Offset = "0x72D5790", VA = "0x1872D6790")]
	private void DBNKKFFIMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x72D6C50", Offset = "0x72D5C50", VA = "0x1872D6C50")]
	private void EHMACBMBEEG(KEFFMEPODBM OEHJBKCLLBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KEFFMEPODBM
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface NOEKLMOIPHP
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		Sprite JDHNIJEHCMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int JJDGMCAOBJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool FLKOANCNBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string OJKJGKGCCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	KPBIEKLMEHK NCAGHIGBNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	string EIDIFJHHOCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Texture2D LHEEBFILHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Sprite JAPNDHGCOIG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	BICDCONMJBN NOECBOKGNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool HDEDHIDIPHF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool OLALHFPGCFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KEFFMEPODBM> AJKBAIDOHBC;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "13")]
	GAEMIFNLIHB MMNJEBKKEEL();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IBHBGBJGJHP<bool> CDOJKHEOKGN();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ODCGMHLDGHK
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool FCGKKJHOFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool LGFFIPBEBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool NEKEJBOEOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LGECCFGNHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int KDDCJKDFMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<KEFFMEPODBM> EEDIBEOECJJ;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	KEFFMEPODBM NJEIEAFDHCH(Predicate<KEFFMEPODBM> MMKCMBDLNID);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<KEFFMEPODBM> DAGAAKHFIPE();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class KPBIEKLMEHK : ReadOnlyCollection<KEFFMEPODBM>, KLHMCJLDEOK, IReadOnlyCollection<KEFFMEPODBM>, IEnumerable<KEFFMEPODBM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public string CJABCEFOIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Sprite JAPNDHGCOIG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9132D0", Offset = "0x9122D0", VA = "0x1809132D0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x72D5F80", Offset = "0x72D4F80", VA = "0x1872D5F80")]
	public KPBIEKLMEHK([NotNull] string OALFIBFPPAC, [NotNull] IList<KEFFMEPODBM> BHINNEMAJAD, [NotNull] Sprite JHKBMDBPFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x72D5E40", Offset = "0x72D4E40", VA = "0x1872D5E40", Slot = "37")]
	public bool LOOMLENBENA(KEFFMEPODBM OEHJBKCLLBM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KLHMCJLDEOK : IReadOnlyCollection<KEFFMEPODBM>, IEnumerable<KEFFMEPODBM>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CPPPFMFHHNO
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool KOGMAEANIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action NJEMFNMLNPN;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action DBMKMMAPDMD;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFAGKMHEMDB();

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONFJMOBMBBC();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum FBLIMPFIDPD
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Screens,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	VR
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KIDPGOEJAJI : CPPPFMFHHNO
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface LHBNMKNJPHD
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		int LDDAIFKJHHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface FIFHGPKDDCN
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int KAIKLEKOJAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly FIFHGPKDDCN DIPFOGGMMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly ODCGMHLDGHK IEDIAFGJKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly int NDAFBACNHDE;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private int OGIBPDEEMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x72D59F0", Offset = "0x72D49F0", VA = "0x1872D59F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KOGMAEANIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x72D5C60", Offset = "0x72D4C60", VA = "0x1872D5C60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action NJEMFNMLNPN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x72D58B0", Offset = "0x72D48B0", VA = "0x1872D58B0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x72D5A40", Offset = "0x72D4A40", VA = "0x1872D5A40", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action DBMKMMAPDMD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x72D5AE0", Offset = "0x72D4AE0", VA = "0x1872D5AE0", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x72D5950", Offset = "0x72D4950", VA = "0x1872D5950", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72D5CF0", Offset = "0x72D4CF0", VA = "0x1872D5CF0")]
	[Preserve]
	public KIDPGOEJAJI([NotNull][JFLEHDEIONF(null)] LHBNMKNJPHD HMEPKFBBFMH, [NotNull][JFLEHDEIONF(null)] FIFHGPKDDCN DIPFOGGMMIM, [NotNull][JFLEHDEIONF(null)] ODCGMHLDGHK IEDIAFGJKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x72D57E0", Offset = "0x72D47E0", VA = "0x1872D57E0", Slot = "5")]
	public void FFAGKMHEMDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x72D5B80", Offset = "0x72D4B80", VA = "0x1872D5B80", Slot = "6")]
	public void ONFJMOBMBBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CGNFLBANCIO
{
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FBLIMPFIDPD AJOAHMBEBOH();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BGMHPPFBIJK
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool JJALIKFDNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool PDCJOLAOGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	TimeSpan AKPHMDMFOLB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action BLBGMCICIMA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action EMKAKJNFEGN;
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
