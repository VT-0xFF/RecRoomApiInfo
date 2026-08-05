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
public class LJDKKCOPNKB : ReadOnlyCollection<GIMCALDOFFN>, HGEDFJODIEC, IReadOnlyCollection<GIMCALDOFFN>, IEnumerable<GIMCALDOFFN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public string MFBMONNEDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Sprite EJABCKADJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x773860", Offset = "0x772C60", VA = "0x180773860", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x534CEF0", Offset = "0x534C2F0", VA = "0x18534CEF0")]
	public LJDKKCOPNKB([NotNull] string MDFAJJKMBAI, [NotNull] IList<GIMCALDOFFN> HAPGAOAPCEH, [NotNull] Sprite JKKNNDMOMKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x534CDC0", Offset = "0x534C1C0", VA = "0x18534CDC0", Slot = "37")]
	public bool BDBJICOKIFA(GIMCALDOFFN ADDLEEAFKPB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum CPEPIMANOBO
{
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Mobile,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Screens,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	VR
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HGEDFJODIEC : IReadOnlyCollection<GIMCALDOFFN>, IEnumerable<GIMCALDOFFN>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MBGJNHDCJHG
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CPEPIMANOBO ACFDDFCBOKL();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EIIMPFOMCIP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JDNABDKBBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KLINFGCJCNG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool IOBMOAKOPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	TimeSpan LOEIBCPIEHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NMHFMMNBEBG;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PCIDGNLHOKK;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GIMCALDOFFN
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface GFDLKDIGOMB
	{
		[Cpp2IlInjected.Token(Token = "0x17000011")]
		Sprite KMKOBEHHEMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	int LLMJCJNKLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool HDDLAONJBDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string DHHAABGOONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	LJDKKCOPNKB KHOGLBLCHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string NJFMNLEKONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Texture2D LDLOEPLJLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Sprite EJABCKADJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GHJEOPLLBGB NCHDILKOPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool DIJAIIGHNEG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool EGFKDANLCGA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<GIMCALDOFFN> BBGFAEHOEGF;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AIDJGFFPANM MBLMHJMDEPE();

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CJNEKNCGBDK<bool> FFBFLOGOHNC();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FKIIAAAIMKK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool KGHPBNIAHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	bool PNGJPGJFNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool NAADIPPBILF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool JNKKJBALCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int MFFEALAODKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<GIMCALDOFFN> FGPLIOEONDC;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GIMCALDOFFN IHBMMDCFPNK(Predicate<GIMCALDOFFN> IDDHPAIOADM);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IEnumerable<GIMCALDOFFN> ADLFDFOCFBA();
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FBKHNCNHCIA
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool NPLIKGAHNHH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action LJLLPKLALJD;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action ABCHIIDHJPO;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFMALAPNIGP();

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DECPKCLMEND();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class FDHKGHKADEC : FKIIAAAIMKK
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface GGDHEKFPFEA
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		IEnumerable<GIMCALDOFFN> OOOAOMIMFOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		IReadOnlyList<HGEDFJODIEC> PLOJFAFKCCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int MMKBGOGNABJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface OLGFANLEIHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<GGDHEKFPFEA> BKHJIGJGHJO(FKIIAAAIMKK LKGDDGKCKEA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class NGIFGLOICPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public Predicate<GIMCALDOFFN> predicate;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public NGIFGLOICPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4DBA580", Offset = "0x4DB9980", VA = "0x184DBA580")]
		internal bool MHBNNKEDBIO(GIMCALDOFFN challenge)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct HJMNCCDOMFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public FDHKGHKADEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private TaskAwaiter<GGDHEKFPFEA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x534C1D0", Offset = "0x534B5D0", VA = "0x18534C1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7F66B0", Offset = "0x7F5AB0", VA = "0x1807F66B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly EIIMPFOMCIP ALBDOCLPPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly OLGFANLEIHG JJDBMHGJELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private GGDHEKFPFEA PCOPMEKJEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private IReadOnlyList<HGEDFJODIEC> AMFDDIJLGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private IEnumerable<GIMCALDOFFN> LMFFHEMGOPL;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool IOBMOAKOPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x534BB50", Offset = "0x534AF50", VA = "0x18534BB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool KGHPBNIAHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x534B5C0", Offset = "0x534A9C0", VA = "0x18534B5C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool PNGJPGJFNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x534BDE0", Offset = "0x534B1E0", VA = "0x18534BDE0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool NAADIPPBILF
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x534B2A0", Offset = "0x534A6A0", VA = "0x18534B2A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool JNKKJBALCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x534B180", Offset = "0x534A580", VA = "0x18534B180", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int MFFEALAODKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x534BA30", Offset = "0x534AE30", VA = "0x18534BA30", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public IReadOnlyList<HGEDFJODIEC> PLOJFAFKCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x773860", Offset = "0x772C60", VA = "0x180773860", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<GIMCALDOFFN> FGPLIOEONDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x534B0D0", Offset = "0x534A4D0", VA = "0x18534B0D0", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x534B650", Offset = "0x534AA50", VA = "0x18534B650", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x534BFF0", Offset = "0x534B3F0", VA = "0x18534BFF0")]
	[Preserve]
	public FDHKGHKADEC([MJHHGJKKIMK(null)][NotNull] EIIMPFOMCIP ALBDOCLPPIC, [MJHHGJKKIMK(null)][NotNull] OLGFANLEIHG JJDBMHGJELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x534AE70", Offset = "0x534A270", VA = "0x18534AE70", Slot = "14")]
	public IEnumerable<GIMCALDOFFN> AICLIMBKBOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x534ACA0", Offset = "0x534A0A0", VA = "0x18534ACA0", Slot = "12")]
	public IEnumerable<GIMCALDOFFN> ADLFDFOCFBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x534B470", Offset = "0x534A870", VA = "0x18534B470", Slot = "11")]
	public GIMCALDOFFN IHBMMDCFPNK(Predicate<GIMCALDOFFN> IDDHPAIOADM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x534B3C0", Offset = "0x534A7C0", VA = "0x18534B3C0")]
	[AsyncStateMachine(typeof(HJMNCCDOMFG))]
	private void GONODAJDAEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x534B700", Offset = "0x534AB00", VA = "0x18534B700")]
	private void NGDEOJJOLDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x534BBA0", Offset = "0x534AFA0", VA = "0x18534BBA0")]
	private void OFHDMGNCKHE(GIMCALDOFFN ADDLEEAFKPB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KODIMIHJAJI : FBKHNCNHCIA
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface ODGNOMAJLOB
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		int PKIGEPCKOGI
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface EDMLMCEKBDE
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		int GEPOABHFDEG
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
	private readonly EDMLMCEKBDE OKIPCJHJBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly FKIIAAAIMKK LKGDDGKCKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly int LANKOKPMCAP;

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private int IOAACOCJPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x534CB70", Offset = "0x534BF70", VA = "0x18534CB70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool NPLIKGAHNHH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x534CA40", Offset = "0x534BE40", VA = "0x18534CA40", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action LJLLPKLALJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x534C8B0", Offset = "0x534BCB0", VA = "0x18534C8B0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x534C810", Offset = "0x534BC10", VA = "0x18534C810", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	public event Action ABCHIIDHJPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x534CBC0", Offset = "0x534BFC0", VA = "0x18534CBC0", Slot = "9")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x534CAD0", Offset = "0x534BED0", VA = "0x18534CAD0", Slot = "10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x534CC60", Offset = "0x534C060", VA = "0x18534CC60")]
	[Preserve]
	public KODIMIHJAJI([MJHHGJKKIMK(null)][NotNull] ODGNOMAJLOB LNEOHFFIMJD, [MJHHGJKKIMK(null)][NotNull] EDMLMCEKBDE OKIPCJHJBDH, [MJHHGJKKIMK(null)][NotNull] FKIIAAAIMKK LKGDDGKCKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x534C740", Offset = "0x534BB40", VA = "0x18534C740", Slot = "5")]
	public void AFMALAPNIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x534C950", Offset = "0x534BD50", VA = "0x18534C950", Slot = "6")]
	public void DECPKCLMEND()
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
