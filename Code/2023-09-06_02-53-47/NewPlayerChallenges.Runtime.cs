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
public class COFDJHFACBE : CCLKMMHBCGE
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface PNEDOBGGIAN
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		IEnumerable<DEJEHLKAHCH> OKMKJMGGBAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		IReadOnlyList<LPFNAJDGNAJ> EMAPMCOAKOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		int JPAKFCFCGNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface KKHCDLGILGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<PNEDOBGGIAN> EHIIGNAMDJC(CCLKMMHBCGE EJEMIPPHGOE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class PLJCMMOCDEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public Predicate<DEJEHLKAHCH> predicate;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public PLJCMMOCDEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0D00", Offset = "0x6FBF300", VA = "0x186FC0D00")]
		internal bool IAEOHIPIENN(DEJEHLKAHCH challenge)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MGPDHOGKGJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public COFDJHFACBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private PNEDOBGGIAN <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private IEnumerator<DEJEHLKAHCH> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private DEJEHLKAHCH <challenge>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<PNEDOBGGIAN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
		public MGPDHOGKGJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0740", Offset = "0x6FBED40", VA = "0x186FC0740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly FEHGNHCBKOB KGAKPMEECEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly KKHCDLGILGL OKGFFLMAONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private PNEDOBGGIAN KGPGMEDOEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private IReadOnlyList<LPFNAJDGNAJ> CJHKJNNJDMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private IEnumerable<DEJEHLKAHCH> FDDAMAPEHGB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KPDMHFOJBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFAC0", Offset = "0x6FBE0C0", VA = "0x186FBFAC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool PNFEPHOMAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF600", Offset = "0x6FBDC00", VA = "0x186FBF600", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool MEOKGCMEGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FBFD80", Offset = "0x6FBE380", VA = "0x186FBFD80", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BEIHBKMNKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF990", Offset = "0x6FBDF90", VA = "0x186FBF990", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OGCBBAIFCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF690", Offset = "0x6FBDC90", VA = "0x186FBF690", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DCGKHFBKCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF860", Offset = "0x6FBDE60", VA = "0x186FBF860", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<LPFNAJDGNAJ> EMAPMCOAKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x913730", Offset = "0x911D30", VA = "0x180913730", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<DEJEHLKAHCH> IBCLKJGBFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FC0390", Offset = "0x6FBE990", VA = "0x186FC0390", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF7C0", Offset = "0x6FBDDC0", VA = "0x186FBF7C0", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0580", Offset = "0x6FBEB80", VA = "0x186FC0580")]
	[Preserve]
	public COFDJHFACBE([NotNull][BBBJPGKHPHG(null)] FEHGNHCBKOB KGAKPMEECEC, [NotNull][BBBJPGKHPHG(null)] KKHCDLGILGL OKGFFLMAONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFB10", Offset = "0x6FBE110", VA = "0x186FBFB10", Slot = "14")]
	public IEnumerable<DEJEHLKAHCH> KOOEEDNDFMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF420", Offset = "0x6FBDA20", VA = "0x186FBF420", Slot = "12")]
	public IEnumerable<DEJEHLKAHCH> AECEEEIOCEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0430", Offset = "0x6FBEA30", VA = "0x186FC0430", Slot = "11")]
	public DEJEHLKAHCH PNAKBIKAMHC(Predicate<DEJEHLKAHCH> OIILKNGKCEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6FC02B0", Offset = "0x6FBE8B0", VA = "0x186FC02B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MGPDHOGKGJG))]
	private void PBBOJBEGKLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6FBFDE0", Offset = "0x6FBE3E0", VA = "0x186FBFDE0")]
	private void LILFCACJFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6FC0070", Offset = "0x6FBE670", VA = "0x186FC0070")]
	private void NJFDELGBNFB(DEJEHLKAHCH BHOCFFAHJKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DEJEHLKAHCH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface EHFGPDKPCPK
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Sprite DBLJCBGEJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	int JAOJDFGCLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool CCPGFHBJHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string FMJCBEDBABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	AANBPLLPFDD HIGBAKKFHDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string HOGOCFHNAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Texture2D DDFHKOFCELI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Sprite ICAPNHCBDDI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	BPMIFNAAOOA BJLPAOHFEOL
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool HBMDILCOJHE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool PDNJDHBDFON
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<DEJEHLKAHCH> PLEGMMFBKFB;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HHGLIBCDIDA DIGFIEJMCMO();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "14")]
	MFBKDKPGMNP<bool> KNFMJCPFOEB();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CCLKMMHBCGE
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool PNFEPHOMAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool MEOKGCMEGJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool BEIHBKMNKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool OGCBBAIFCNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	int DCGKHFBKCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<DEJEHLKAHCH> IBCLKJGBFPF;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DEJEHLKAHCH PNAKBIKAMHC(Predicate<DEJEHLKAHCH> OIILKNGKCEE);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<DEJEHLKAHCH> AECEEEIOCEC();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AANBPLLPFDD : ReadOnlyCollection<DEJEHLKAHCH>, LPFNAJDGNAJ, IReadOnlyCollection<DEJEHLKAHCH>, IEnumerable<DEJEHLKAHCH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string OMBLKOFJABM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Sprite ICAPNHCBDDI
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x913730", Offset = "0x911D30", VA = "0x180913730", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6FBECE0", Offset = "0x6FBD2E0", VA = "0x186FBECE0")]
	public AANBPLLPFDD([NotNull] string ECMAPGHKHFB, [NotNull] IList<DEJEHLKAHCH> CKIKFMIOAHP, [NotNull] Sprite BHJCFMIMAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6FBEBA0", Offset = "0x6FBD1A0", VA = "0x186FBEBA0", Slot = "37")]
	public bool KAOBCGAABHJ(DEJEHLKAHCH BHOCFFAHJKM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LPFNAJDGNAJ : IReadOnlyCollection<DEJEHLKAHCH>, IEnumerable<DEJEHLKAHCH>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CKCEIBGFKFI
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool KJKNOLBIHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action EEHGOGEHGCK;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action MLMICDCJMCB;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKEPCMIBFAK();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AMJHKMEHMAM();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum OKMKJPLLINB
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Screens,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	VR
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AINGKJKBLCF : CKCEIBGFKFI
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface BJGKEJJPHEE
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int MANFHDILCBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface FKPOJDDMGGN
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int EAKBDKNGCHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly FKPOJDDMGGN MADGHJEJGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly CCLKMMHBCGE EJEMIPPHGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly int NFFKIAMIGLD;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int PBKOAFBBNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF1B0", Offset = "0x6FBD7B0", VA = "0x186FBF1B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KJKNOLBIHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEEA0", Offset = "0x6FBD4A0", VA = "0x186FBEEA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action EEHGOGEHGCK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEFD0", Offset = "0x6FBD5D0", VA = "0x186FBEFD0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF070", Offset = "0x6FBD670", VA = "0x186FBF070", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action MLMICDCJMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6FBEF30", Offset = "0x6FBD530", VA = "0x186FBEF30", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6FBF110", Offset = "0x6FBD710", VA = "0x186FBF110", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF2D0", Offset = "0x6FBD8D0", VA = "0x186FBF2D0")]
	[Preserve]
	public AINGKJKBLCF([NotNull][BBBJPGKHPHG(null)] BJGKEJJPHEE JHGANFJOHJE, [NotNull][BBBJPGKHPHG(null)] FKPOJDDMGGN MADGHJEJGAB, [NotNull][BBBJPGKHPHG(null)] CCLKMMHBCGE EJEMIPPHGOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6FBF200", Offset = "0x6FBD800", VA = "0x186FBF200", Slot = "5")]
	public void NKEPCMIBFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6FBEDC0", Offset = "0x6FBD3C0", VA = "0x186FBEDC0", Slot = "6")]
	public void AMJHKMEHMAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CBOOFMFOJCM
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OKMKJPLLINB CMCGDGHAAFC();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FEHGNHCBKOB
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool GCAEGNBFBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool HIGCKMCDHOC
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool KPDMHFOJBMB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	TimeSpan HFBFHEEKHKC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action LGOJHJPPOKN;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action IFFENEIGAGE;
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
