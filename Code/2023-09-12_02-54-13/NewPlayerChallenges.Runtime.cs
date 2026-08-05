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
public class HBPBKPECPBI : KDMDDBDDBFM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface AEBJGBCNFIA
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		IEnumerable<CIJLMBCBDFG> CEDABLGIBNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		IReadOnlyList<LDICDCDMJHN> FPDPHOMPNCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		int JNODHKDLJGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface GGCEKJOCALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<AEBJGBCNFIA> ONNKKNOIBIM(KDMDDBDDBFM FJPLKEMDMHE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class OCJNFJJBNAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public Predicate<CIJLMBCBDFG> predicate;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public OCJNFJJBNAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71F9530", Offset = "0x71F8930", VA = "0x1871F9530")]
		internal bool FGBOKODMEOM(CIJLMBCBDFG challenge)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GOELFBLOLGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public HBPBKPECPBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private AEBJGBCNFIA <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private IEnumerator<CIJLMBCBDFG> <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private CIJLMBCBDFG <challenge>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<AEBJGBCNFIA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public GOELFBLOLGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x71F7A30", Offset = "0x71F6E30", VA = "0x1871F7A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly DIDCGJCEJCO HJLFLKIDLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly GGCEKJOCALK IDDEMKNCNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private AEBJGBCNFIA JJMMOOHLHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private IReadOnlyList<LDICDCDMJHN> JLJLNDJCNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private IEnumerable<CIJLMBCBDFG> JFCOEMHOIEE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GNAKBJMBFGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71F8FD0", Offset = "0x71F83D0", VA = "0x1871F8FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool CHIAGDDNHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x71F8940", Offset = "0x71F7D40", VA = "0x1871F8940", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JDLJCOHJOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x71F8C50", Offset = "0x71F8050", VA = "0x1871F8C50", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool AAMNDPDJGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71F9020", Offset = "0x71F8420", VA = "0x1871F9020", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HOIFMIFKKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71F8620", Offset = "0x71F7A20", VA = "0x1871F8620", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FKGNKNFBJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71F84F0", Offset = "0x71F78F0", VA = "0x1871F84F0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IReadOnlyList<LDICDCDMJHN> FPDPHOMPNCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x823B70", Offset = "0x822F70", VA = "0x180823B70", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<CIJLMBCBDFG> PLFCJNBMKOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71F8750", Offset = "0x71F7B50", VA = "0x1871F8750", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x71F89D0", Offset = "0x71F7DD0", VA = "0x1871F89D0", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x71F9150", Offset = "0x71F8550", VA = "0x1871F9150")]
	[Preserve]
	public HBPBKPECPBI([NotNull][JLJFOFICIEA(null)] DIDCGJCEJCO HJLFLKIDLOG, [NotNull][JLJFOFICIEA(null)] GGCEKJOCALK IDDEMKNCNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x71F7FF0", Offset = "0x71F73F0", VA = "0x1871F7FF0", Slot = "14")]
	public IEnumerable<CIJLMBCBDFG> AGABDBJNCAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x71F8A70", Offset = "0x71F7E70", VA = "0x1871F8A70", Slot = "12")]
	public IEnumerable<CIJLMBCBDFG> LCKGDGIKFJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x71F87F0", Offset = "0x71F7BF0", VA = "0x1871F87F0", Slot = "11")]
	public CIJLMBCBDFG JNDOIEBBNHF(Predicate<CIJLMBCBDFG> BHNAOANJFML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x71F8EF0", Offset = "0x71F82F0", VA = "0x1871F8EF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GOELFBLOLGO))]
	private void LPOMHOOCPHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x71F8260", Offset = "0x71F7660", VA = "0x1871F8260")]
	private void EFPMLLMMIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x71F8CB0", Offset = "0x71F80B0", VA = "0x1871F8CB0")]
	private void LOMELKIAOHK(CIJLMBCBDFG KFIIAAIHCFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CIJLMBCBDFG
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface CNDEBKFJHDO
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		Sprite MILFDCAPEDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	int PBGCFEJFPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool JMNLODKOKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	string JCNOHAELOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	HOCBDKJHIIM CCGLCKLBLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	string IEMEPHNLCLP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Texture2D FPMJNMHBCPA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	Sprite BEFKPLDEDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	ODNOBHIAPAM FBMIDOAPAJF
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool COIBMKOPPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool CEFOKEMJINA
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<CIJLMBCBDFG> NFMAKAHBPOD;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LMHNGLGIJDH CIKEGJEPFLM();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "14")]
	KDCMFGDLEKL<bool> CAMEJFGJHEF();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KDMDDBDDBFM
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool CHIAGDDNHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool JDLJCOHJOHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool AAMNDPDJGIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HOIFMIFKKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	int FKGNKNFBJON
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<CIJLMBCBDFG> PLFCJNBMKOH;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CIJLMBCBDFG JNDOIEBBNHF(Predicate<CIJLMBCBDFG> BHNAOANJFML);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<CIJLMBCBDFG> LCKGDGIKFJG();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HOCBDKJHIIM : ReadOnlyCollection<CIJLMBCBDFG>, LDICDCDMJHN, IReadOnlyCollection<CIJLMBCBDFG>, IEnumerable<CIJLMBCBDFG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public string ANHHJLAHIFL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public Sprite BEFKPLDEDFA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x823B70", Offset = "0x822F70", VA = "0x180823B70", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x71F9450", Offset = "0x71F8850", VA = "0x1871F9450")]
	public HOCBDKJHIIM([NotNull] string GDKOBCHHFLB, [NotNull] IList<CIJLMBCBDFG> FIONHDMDJNK, [NotNull] Sprite IHJJOAFGMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x71F9310", Offset = "0x71F8710", VA = "0x1871F9310", Slot = "37")]
	public bool INNLJKMIFJK(CIJLMBCBDFG KFIIAAIHCFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LDICDCDMJHN : IReadOnlyCollection<CIJLMBCBDFG>, IEnumerable<CIJLMBCBDFG>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MDEIGJLEFMK
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool EMAFDBNIJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action OCHEOFACDJJ;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action JBGDOPCGFEM;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CIMBDJKKIGF();

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBECBCJFGCB();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum BMANGDDAECH
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	Screens,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	VR
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AJIKCLNPELM : MDEIGJLEFMK
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface JLKBCDEJGFE
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		int KJPKLGMDPIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface DOPKGCGEPOF
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int CNOAMGDFBIP
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
	private readonly DOPKGCGEPOF PMNNOGLDMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly KDMDDBDDBFM FJPLKEMDMHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly int PEIHLDBJFJP;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private int ENDDDGCELKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x71F73D0", Offset = "0x71F67D0", VA = "0x1871F73D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool EMAFDBNIJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x71F77B0", Offset = "0x71F6BB0", VA = "0x1871F77B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action OCHEOFACDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x71F74F0", Offset = "0x71F68F0", VA = "0x1871F74F0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x71F7840", Offset = "0x71F6C40", VA = "0x1871F7840", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action JBGDOPCGFEM
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x71F7630", Offset = "0x71F6A30", VA = "0x1871F7630", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x71F7590", Offset = "0x71F6990", VA = "0x1871F7590", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x71F78E0", Offset = "0x71F6CE0", VA = "0x1871F78E0")]
	[Preserve]
	public AJIKCLNPELM([NotNull][JLJFOFICIEA(null)] JLKBCDEJGFE JHLBNODJNIM, [NotNull][JLJFOFICIEA(null)] DOPKGCGEPOF PMNNOGLDMND, [NotNull][JLJFOFICIEA(null)] KDMDDBDDBFM FJPLKEMDMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x71F7420", Offset = "0x71F6820", VA = "0x1871F7420", Slot = "5")]
	public void CIMBDJKKIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x71F76D0", Offset = "0x71F6AD0", VA = "0x1871F76D0", Slot = "6")]
	public void LBECBCJFGCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface GPEMJOCBOBB
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BMANGDDAECH HDCDOCBBMMC();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DIDCGJCEJCO
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool GOJPPHLOFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool IGGDJAPHKOI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool GNAKBJMBFGL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	TimeSpan MALFGJCKDAA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action BAJHFPJBJCC;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action DAJLANMDAKN;
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
