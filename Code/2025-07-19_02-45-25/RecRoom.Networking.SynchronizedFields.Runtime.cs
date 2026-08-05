using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Foundation;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DDPBHBGFIOJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HPEPDMLFMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool IBEENHMGAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	IALDHONKEJC INMPOPAHEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int CKKFHHDAODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool AONAFMGPAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KCOCJEJJKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action LIDHFCPDGAC;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BJPCKNNNOKG();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HPKILBGEPLL(object GFDDDAIMFOH, bool FLGLPLFICNP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HPCILDHOCPD();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OPJNCONOPGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string OKAFGBBEFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GEBHMKDGFBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface PAJNHNCEDMN<T> : OPJNCONOPGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T JPFMPEGNOGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LOCELEGBLPA(T MNBECLGJOEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class MALJCCBOCPH<T> : PAJNHNCEDMN<T>, OPJNCONOPGA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly OKFOPPCJIHK<T> HBKLPCKANPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly OKFOPPCJIHK<T> OKJHPHIMIAG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string OKAFGBBEFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xF27FA0", Offset = "0xF26FA0", VA = "0x180F27FA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EODMMNMDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x568CCA0", Offset = "0x568BCA0", VA = "0x18568CCA0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T EEKPKAADHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x568CFC0", Offset = "0x568BFC0", VA = "0x18568CFC0", Slot = "11")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x568D430", Offset = "0x568C430", VA = "0x18568D430", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T JPFMPEGNOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x568D840", Offset = "0x568C840", VA = "0x18568D840", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x568DB60", Offset = "0x568CB60", VA = "0x18568DB60", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T BDJLGAHJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x568D840", Offset = "0x568C840", VA = "0x18568D840")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x568DAB0", Offset = "0x568CAB0", VA = "0x18568DAB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool GEBHMKDGFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x501E9F0", Offset = "0x501D9F0", VA = "0x18501E9F0", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x501D4E0", Offset = "0x501C4E0", VA = "0x18501D4E0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool OAFDKAKOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x568CC80", Offset = "0x568BC80", VA = "0x18568CC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x568CBB0", Offset = "0x568BBB0", VA = "0x18568CBB0", Slot = "10")]
	public void AEEGGHAFLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x568DC50", Offset = "0x568CC50", VA = "0x18568DC50")]
	public MALJCCBOCPH([In] MKAEDBJKBLC INCJDDLACNP, T PKLGAEIGNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x568D0B0", Offset = "0x568C0B0", VA = "0x18568D0B0")]
	private void IHCPMDDGCNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x568D980", Offset = "0x568C980", VA = "0x18568D980", Slot = "5")]
	public void LOCELEGBLPA(T MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x568D9A0", Offset = "0x568C9A0", VA = "0x18568D9A0")]
	public void LOCELEGBLPA(T MNBECLGJOEJ, bool JBNLIGPDJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x501D0A0", Offset = "0x501C0A0", VA = "0x18501D0A0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class ANLDFALLAEE<T1, T2> : PAJNHNCEDMN<(T1, T2)>, OPJNCONOPGA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly IKACJHGGAOI<T1, T2> HBKLPCKANPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IKACJHGGAOI<T1, T2> OKJHPHIMIAG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string OKAFGBBEFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xF27FA0", Offset = "0xF26FA0", VA = "0x180F27FA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool EODMMNMDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x527E5E0", Offset = "0x527D5E0", VA = "0x18527E5E0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool GBAJMMGIJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x501F3F0", Offset = "0x501E3F0", VA = "0x18501F3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool EHHDFCEMHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5280560", Offset = "0x527F560", VA = "0x185280560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public (T1, T2) EEKPKAADHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x527EB50", Offset = "0x527DB50", VA = "0x18527EB50", Slot = "11")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x527F870", Offset = "0x527E870", VA = "0x18527F870", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public (T1, T2) JPFMPEGNOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x527FD80", Offset = "0x527ED80", VA = "0x18527FD80", Slot = "4")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x52807F0", Offset = "0x527F7F0", VA = "0x1852807F0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public (T1, T2) BDJLGAHJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x527FAE0", Offset = "0x527EAE0", VA = "0x18527FAE0")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5280420", Offset = "0x527F420", VA = "0x185280420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T1 AIFCDLOBIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x52808E0", Offset = "0x527F8E0", VA = "0x1852808E0")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x527E320", Offset = "0x527D320", VA = "0x18527E320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T1 OLBHOCIANBI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x527E240", Offset = "0x527D240", VA = "0x18527E240")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T1 PGIMPKOEFBM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x527E240", Offset = "0x527D240", VA = "0x18527E240")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x527F470", Offset = "0x527E470", VA = "0x18527F470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T2 POPCKNBHOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x527FA90", Offset = "0x527EA90", VA = "0x18527FA90")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x52802A0", Offset = "0x527F2A0", VA = "0x1852802A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T2 IFMGELDEPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x527E8D0", Offset = "0x527D8D0", VA = "0x18527E8D0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public T2 KEHDCBFBAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x527E8D0", Offset = "0x527D8D0", VA = "0x18527E8D0")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x527F4F0", Offset = "0x527E4F0", VA = "0x18527F4F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool GEBHMKDGFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x501E9F0", Offset = "0x501D9F0", VA = "0x18501E9F0", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x501D4E0", Offset = "0x501C4E0", VA = "0x18501D4E0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x527E180", Offset = "0x527D180", VA = "0x18527E180", Slot = "10")]
	public void AEEGGHAFLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5281380", Offset = "0x5280380", VA = "0x185281380")]
	public ANLDFALLAEE([In] MKAEDBJKBLC INCJDDLACNP, T1 DAMBFELDCKB, T2 DNNEFMMGNDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x527F310", Offset = "0x527E310", VA = "0x18527F310")]
	private void IHCPMDDGCNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x527EE00", Offset = "0x527DE00", VA = "0x18527EE00")]
	public void IDLHDNNLNMG(T1 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5280050", Offset = "0x527F050", VA = "0x185280050")]
	public void LOCELEGBLPA(T1 HMKBHMACMAM, T2 INAHLDJFCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x527E7A0", Offset = "0x527D7A0", VA = "0x18527E7A0", Slot = "5")]
	private void FBLIDGHDOBN((T1, T2) LJALOPCLDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x501D0A0", Offset = "0x501C0A0", VA = "0x18501D0A0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class IIKMAKBPFNP<T1, T2, T3> : PAJNHNCEDMN<(T1, T2, T3)>, OPJNCONOPGA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IKEAHAENECO<T1, T2, T3> HBKLPCKANPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly IKEAHAENECO<T1, T2, T3> OKJHPHIMIAG;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string OKAFGBBEFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xF27FA0", Offset = "0xF26FA0", VA = "0x180F27FA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool EODMMNMDCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x501CFA0", Offset = "0x501BFA0", VA = "0x18501CFA0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool GBAJMMGIJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x501F3F0", Offset = "0x501E3F0", VA = "0x18501F3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool EHHDFCEMHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x501F710", Offset = "0x501E710", VA = "0x18501F710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool EFJKOBENDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x501F630", Offset = "0x501E630", VA = "0x18501F630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public (T1, T2, T3) EEKPKAADHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x501D600", Offset = "0x501C600", VA = "0x18501D600", Slot = "11")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x501E300", Offset = "0x501D300", VA = "0x18501E300", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public (T1, T2, T3) JPFMPEGNOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x501E640", Offset = "0x501D640", VA = "0x18501E640", Slot = "4")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x501F930", Offset = "0x501E930", VA = "0x18501F930", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T1 AIFCDLOBIHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x501F980", Offset = "0x501E980", VA = "0x18501F980")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x501CD20", Offset = "0x501BD20", VA = "0x18501CD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T1 OLBHOCIANBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x501CB10", Offset = "0x501BB10", VA = "0x18501CB10")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T1 PGIMPKOEFBM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x501CB10", Offset = "0x501BB10", VA = "0x18501CB10")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x501E060", Offset = "0x501D060", VA = "0x18501E060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T2 POPCKNBHOIP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x501E500", Offset = "0x501D500", VA = "0x18501E500")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x501EFE0", Offset = "0x501DFE0", VA = "0x18501EFE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T2 IFMGELDEPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x501D460", Offset = "0x501C460", VA = "0x18501D460")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T2 KEHDCBFBAFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x501D460", Offset = "0x501C460", VA = "0x18501D460")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x501E080", Offset = "0x501D080", VA = "0x18501E080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public T3 CLGHKLCCAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x501E0A0", Offset = "0x501D0A0", VA = "0x18501E0A0")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x501EBD0", Offset = "0x501DBD0", VA = "0x18501EBD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public T3 MHGDDFABIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x501D4A0", Offset = "0x501C4A0", VA = "0x18501D4A0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public T3 EBLNLHBJIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x501D4A0", Offset = "0x501C4A0", VA = "0x18501D4A0")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x501E100", Offset = "0x501D100", VA = "0x18501E100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool GEBHMKDGFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x501E9F0", Offset = "0x501D9F0", VA = "0x18501E9F0", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x501D4E0", Offset = "0x501C4E0", VA = "0x18501D4E0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x501C970", Offset = "0x501B970", VA = "0x18501C970", Slot = "10")]
	public void AEEGGHAFLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x501FBE0", Offset = "0x501EBE0", VA = "0x18501FBE0")]
	public IIKMAKBPFNP([In] MKAEDBJKBLC INCJDDLACNP, T1 DAMBFELDCKB, T2 DNNEFMMGNDE, T3 CDOCELIHMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x501DCA0", Offset = "0x501CCA0", VA = "0x18501DCA0")]
	private void IHCPMDDGCNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x501D920", Offset = "0x501C920", VA = "0x18501D920")]
	public void IDLHDNNLNMG(T1 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x501D1C0", Offset = "0x501C1C0", VA = "0x18501D1C0")]
	public void EIENEBACMEN(T2 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x501EF00", Offset = "0x501DF00", VA = "0x18501EF00")]
	public void NGNCBLIDBNO(T3 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x501E960", Offset = "0x501D960", VA = "0x18501E960")]
	public void LOCELEGBLPA(T1 HMKBHMACMAM, T2 INAHLDJFCJA, T3 LMHAJIKMLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x501CA80", Offset = "0x501BA80", VA = "0x18501CA80", Slot = "5")]
	private void BEPFMDDBGKF((T1, T2, T3) LJALOPCLDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x501D0A0", Offset = "0x501C0A0", VA = "0x18501D0A0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class MLOMBGOCPMC<T1, T2, T3, T4> : PAJNHNCEDMN<(T1, T2, T3, T4)>, OPJNCONOPGA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly EEMMHFKPIIC<T1, T2, T3, T4> HBKLPCKANPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly EEMMHFKPIIC<T1, T2, T3, T4> OKJHPHIMIAG;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string OKAFGBBEFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xF27FA0", Offset = "0xF26FA0", VA = "0x180F27FA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public (T1, T2, T3, T4) JPFMPEGNOGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x56E6BC0", Offset = "0x56E5BC0", VA = "0x1856E6BC0", Slot = "4")]
		get
		{
			return default((T1, T2, T3, T4));
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x56E6F10", Offset = "0x56E5F10", VA = "0x1856E6F10", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public T2 IFMGELDEPIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4EE86D0", Offset = "0x4EE76D0", VA = "0x184EE86D0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T3 MHGDDFABIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x56E6730", Offset = "0x56E5730", VA = "0x1856E6730")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public T4 JKPJCOFLNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x56E6ED0", Offset = "0x56E5ED0", VA = "0x1856E6ED0")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool GEBHMKDGFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x501E9F0", Offset = "0x501D9F0", VA = "0x18501E9F0", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x501D4E0", Offset = "0x501C4E0", VA = "0x18501D4E0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x56E71E0", Offset = "0x56E61E0", VA = "0x1856E71E0")]
	public MLOMBGOCPMC([In] MKAEDBJKBLC INCJDDLACNP, T1 DAMBFELDCKB, T2 DNNEFMMGNDE, T3 CDOCELIHMGL, T4 DBHCCGIDNFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x56E6980", Offset = "0x56E5980", VA = "0x1856E6980")]
	private void IHCPMDDGCNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x56E6870", Offset = "0x56E5870", VA = "0x1856E6870")]
	public void IDLHDNNLNMG(T1 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x56E6E80", Offset = "0x56E5E80", VA = "0x1856E6E80")]
	public void LOCELEGBLPA(T1 HMKBHMACMAM, T2 INAHLDJFCJA, T3 LMHAJIKMLIM, T4 HOFHIENFIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x56E66B0", Offset = "0x56E56B0", VA = "0x1856E66B0", Slot = "5")]
	private void GGJDOAOGEGB((T1, T2, T3, T4) LJALOPCLDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x501D0A0", Offset = "0x501C0A0", VA = "0x18501D0A0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KJOOJIEONJF
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x82C6E30", Offset = "0x82C5E30", VA = "0x1882C6E30")]
	public static string IDAOPGAEOOE(this MKAEDBJKBLC INCJDDLACNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xCE95F0", Offset = "0xCE85F0", VA = "0x180CE95F0")]
	public static PDOEAIKKMOC MAFDIGGPDKO(this MKAEDBJKBLC INCJDDLACNP)
	{
		return default(PDOEAIKKMOC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OKFOPPCJIHK<T> : AMGAILPBNNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4D96EA0", Offset = "0x4D95EA0", VA = "0x184D96EA0")]
	public OKFOPPCJIHK([In] MKAEDBJKBLC INCJDDLACNP, T CAILINJCNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5946760", Offset = "0x5945760", VA = "0x185946760")]
	public OKFOPPCJIHK(NFAMKCPLNMM IEGLIFIOOBM, IALDHONKEJC MFOAOKBDIIM, string DAKIIEIEKNI, T CAILINJCNIJ, PDOEAIKKMOC JLDAJBAEIJG, [Optional] Action HCEFPMMOBCM, [Optional] IPMKAMOPMID CDGAKHGNCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5947F70", Offset = "0x5946F70", VA = "0x185947F70")]
	public OKFOPPCJIHK(NFAMKCPLNMM IEGLIFIOOBM, string DAKIIEIEKNI, T CAILINJCNIJ, PDOEAIKKMOC JLDAJBAEIJG, [Optional] Action HCEFPMMOBCM, [Optional] IPMKAMOPMID CDGAKHGNCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5949780", Offset = "0x5948780", VA = "0x185949780")]
	public OKFOPPCJIHK(NFAMKCPLNMM IEGLIFIOOBM, string DAKIIEIEKNI, T CAILINJCNIJ, PDOEAIKKMOC JLDAJBAEIJG, bool EEJHCFLALLD, [Optional] Action HCEFPMMOBCM, [Optional] IPMKAMOPMID CDGAKHGNCPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IKACJHGGAOI<T1, T2> : GPPHDLMNLCI<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x50249A0", Offset = "0x50239A0", VA = "0x1850249A0")]
	public IKACJHGGAOI([In] MKAEDBJKBLC INCJDDLACNP, T1 ODOIPIPCIJB, T2 HEMOJMOPOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5027060", Offset = "0x5026060", VA = "0x185027060")]
	public IKACJHGGAOI(NFAMKCPLNMM IEGLIFIOOBM, IALDHONKEJC MFOAOKBDIIM, string DAKIIEIEKNI, T1 ODOIPIPCIJB, T2 HEMOJMOPOPK, PDOEAIKKMOC JLDAJBAEIJG, [Optional] Action HCEFPMMOBCM, [Optional] IPMKAMOPMID CDGAKHGNCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5024C60", Offset = "0x5023C60", VA = "0x185024C60")]
	public IKACJHGGAOI(NFAMKCPLNMM IEGLIFIOOBM, string DAKIIEIEKNI, T1 ODOIPIPCIJB, T2 HEMOJMOPOPK, PDOEAIKKMOC JLDAJBAEIJG, [Optional] Action HCEFPMMOBCM, [Optional] IPMKAMOPMID CDGAKHGNCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x50276D0", Offset = "0x50266D0", VA = "0x1850276D0")]
	public IKACJHGGAOI(NFAMKCPLNMM IEGLIFIOOBM, string DAKIIEIEKNI, T1 ODOIPIPCIJB, T2 HEMOJMOPOPK, PDOEAIKKMOC JLDAJBAEIJG, bool EEJHCFLALLD, [Optional] Action HCEFPMMOBCM, [Optional] IPMKAMOPMID CDGAKHGNCPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IKEAHAENECO<T1, T2, T3> : FEKOALPFHGO<T1, T2, T3>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4D80630", Offset = "0x4D7F630", VA = "0x184D80630")]
	public IKEAHAENECO([In] MKAEDBJKBLC INCJDDLACNP, T1 ODOIPIPCIJB, T2 HEMOJMOPOPK, T3 IIEMFBDGALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5028990", Offset = "0x5027990", VA = "0x185028990")]
	public IKEAHAENECO(NFAMKCPLNMM IEGLIFIOOBM, string DAKIIEIEKNI, T1 ODOIPIPCIJB, T2 HEMOJMOPOPK, T3 IIEMFBDGALD, PDOEAIKKMOC JLDAJBAEIJG, [Optional] Action HCEFPMMOBCM, [Optional] IPMKAMOPMID CDGAKHGNCPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EEMMHFKPIIC<T1, T2, T3, T4> : GGPHPIJJBJN<T1, T2, T3, T4>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x48F7190", Offset = "0x48F6190", VA = "0x1848F7190")]
	public EEMMHFKPIIC([In] MKAEDBJKBLC INCJDDLACNP, T1 ODOIPIPCIJB, T2 HEMOJMOPOPK, T3 IIEMFBDGALD, T4 JMBGKJELEKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x48F8450", Offset = "0x48F7450", VA = "0x1848F8450")]
	public EEMMHFKPIIC(NFAMKCPLNMM IEGLIFIOOBM, IALDHONKEJC MFOAOKBDIIM, string DAKIIEIEKNI, T1 ODOIPIPCIJB, T2 HEMOJMOPOPK, T3 IIEMFBDGALD, T4 JMBGKJELEKA, PDOEAIKKMOC JLDAJBAEIJG, [Optional] Action HCEFPMMOBCM, [Optional] IPMKAMOPMID CDGAKHGNCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x48F7060", Offset = "0x48F6060", VA = "0x1848F7060")]
	public EEMMHFKPIIC(NFAMKCPLNMM IEGLIFIOOBM, string DAKIIEIEKNI, T1 ODOIPIPCIJB, T2 HEMOJMOPOPK, T3 IIEMFBDGALD, T4 JMBGKJELEKA, PDOEAIKKMOC JLDAJBAEIJG, [Optional] Action HCEFPMMOBCM, [Optional] IPMKAMOPMID CDGAKHGNCPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BKOOEPMLCCJ<T1, T2, T3, T4, T5> : MDODPBGGNJI<T1, T2, T3, T4, T5>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6515960", Offset = "0x6514960", VA = "0x186515960")]
	public BKOOEPMLCCJ(NFAMKCPLNMM IEGLIFIOOBM, IALDHONKEJC MFOAOKBDIIM, string DAKIIEIEKNI, T1 ODOIPIPCIJB, T2 HEMOJMOPOPK, T3 IIEMFBDGALD, T4 JMBGKJELEKA, T5 LJJBFCGNIPE, PDOEAIKKMOC JLDAJBAEIJG, [Optional] Action HCEFPMMOBCM, [Optional] IPMKAMOPMID CDGAKHGNCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6515850", Offset = "0x6514850", VA = "0x186515850")]
	public BKOOEPMLCCJ(NFAMKCPLNMM IEGLIFIOOBM, string DAKIIEIEKNI, T1 ODOIPIPCIJB, T2 HEMOJMOPOPK, T3 IIEMFBDGALD, T4 JMBGKJELEKA, T5 LJJBFCGNIPE, PDOEAIKKMOC JLDAJBAEIJG, [Optional] Action HCEFPMMOBCM, [Optional] IPMKAMOPMID CDGAKHGNCPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class HJAABBPDKOC<T> : AMGAILPBNNM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4F49D40", Offset = "0x4F48D40", VA = "0x184F49D40")]
	public HJAABBPDKOC(IALDHONKEJC MFOAOKBDIIM, string DAKIIEIEKNI, T CAILINJCNIJ, [Optional] Action HCEFPMMOBCM, [Optional] IPMKAMOPMID CDGAKHGNCPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EMDCOCBPDEK<T1, T2> : GPPHDLMNLCI<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x491A650", Offset = "0x4919650", VA = "0x18491A650")]
	public EMDCOCBPDEK(IALDHONKEJC MFOAOKBDIIM, string DAKIIEIEKNI, T1 IFKBIHEEEOE, T2 OGLFOKBGGFB, [Optional] Action HCEFPMMOBCM, [Optional] IPMKAMOPMID CDGAKHGNCPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KFCOEOFJNAD
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OKFOPPCJIHK<T1> JOBCFPPJPIL<T1>(string DAKIIEIEKNI, T1 IFKBIHEEEOE, PDOEAIKKMOC JLDAJBAEIJG, [Optional] Action HCEFPMMOBCM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ACOPPNOJHLC : KFCOEOFJNAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly IPMKAMOPMID CDGAKHGNCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly NFAMKCPLNMM IEGLIFIOOBM;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xA653E0", Offset = "0xA643E0", VA = "0x180A653E0")]
	public ACOPPNOJHLC(IPMKAMOPMID CDGAKHGNCPM, NFAMKCPLNMM IOJEDJOGIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x318FBF0", Offset = "0x318EBF0", VA = "0x18318FBF0", Slot = "4")]
	public OKFOPPCJIHK<T1> JOBCFPPJPIL<T1>(string DAKIIEIEKNI, T1 IFKBIHEEEOE, PDOEAIKKMOC JLDAJBAEIJG, [Optional] Action HCEFPMMOBCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EJEAGEEEHNF : NFAMKCPLNMM
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ViewId MGADKAAPMEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NFAMKCPLNMM
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool ABFKKPMLEEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool AIFLLPDOOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string EHJDKNHEDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool PJPHCJGPLCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RegisterDestroyHandler(BONJPBBBMJP NCAIPIHIMAM);

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UnregisterDestroyHandler(BONJPBBBMJP NCAIPIHIMAM);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DBPKMGFBAIB
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x82C4530", Offset = "0x82C3530", VA = "0x1882C4530")]
	public static bool DLFKMLHLLDN(this NFAMKCPLNMM IEGLIFIOOBM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface IPMKAMOPMID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	IALDHONKEJC JLABICKAIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool OAFDKAKOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool BCOECANAFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OCOPJMCPGIB();

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object KMMENCPIPMN(string DAKIIEIEKNI);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "5")]
	object BOKKGHNNAOB(IALDHONKEJC FMGAAJMDEJP, string DAKIIEIEKNI);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CAHKGMMIIFC(string DAKIIEIEKNI, object MNBECLGJOEJ);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NNKPGLONKDA(IALDHONKEJC FMGAAJMDEJP, string DAKIIEIEKNI, object MNBECLGJOEJ);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JCJKGBGCOHN<T>(string DAKIIEIEKNI, T IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DNCKIKDGLHN([CanBeNull] IALDHONKEJC FMGAAJMDEJP, string DAKIIEIEKNI, CCFPFBGNCOP EIHKLMPDFNN);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LGIJBCLKGOP([CanBeNull] IALDHONKEJC FMGAAJMDEJP, string DAKIIEIEKNI, CCFPFBGNCOP EIHKLMPDFNN);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "11")]
	T PFOLCMBAAHK<T>(object IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "12")]
	object HFOBFHLIABC<T>(T CAILINJCNIJ);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DPDLCDJDPKC();

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ECLHGMADAAG();

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MHLAKEENIBA(string DGMLMPAOEHN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MKAEDBJKBLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IALDHONKEJC MFOAOKBDIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NFAMKCPLNMM IEGLIFIOOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public string DAKIIEIEKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public PDOEAIKKMOC JLDAJBAEIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool EEJHCFLALLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action HCEFPMMOBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public IPMKAMOPMID CDGAKHGNCPM;

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x82C6EC0", Offset = "0x82C5EC0", VA = "0x1882C6EC0")]
	public MKAEDBJKBLC(MKAEDBJKBLC EDJHHGMLKFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x82C6F40", Offset = "0x82C5F40", VA = "0x1882C6F40")]
	public MKAEDBJKBLC(NFAMKCPLNMM IEGLIFIOOBM, string DAKIIEIEKNI, PDOEAIKKMOC JLDAJBAEIJG, [Optional] Action HCEFPMMOBCM, [Optional] IPMKAMOPMID CDGAKHGNCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x82C6E70", Offset = "0x82C5E70", VA = "0x1882C6E70")]
	public static MKAEDBJKBLC PGHEBAMGCKG(NFAMKCPLNMM IEGLIFIOOBM, string DAKIIEIEKNI, PDOEAIKKMOC JLDAJBAEIJG, [Optional] Action HCEFPMMOBCM, [Optional] IPMKAMOPMID CDGAKHGNCPM)
	{
		return default(MKAEDBJKBLC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class IIOLPMIDHIF
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3CC73E0", Offset = "0x3CC63E0", VA = "0x183CC73E0")]
	public static OKFOPPCJIHK<T> KCDKILFEEIA<T>(this MKAEDBJKBLC INCJDDLACNP, T CAILINJCNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7290", Offset = "0x3CC6290", VA = "0x183CC7290")]
	public static IKACJHGGAOI<T1, T2> KCDKILFEEIA<T1, T2>(this MKAEDBJKBLC INCJDDLACNP, T1 EJJHJDCDAED, T2 MABIFADLEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7330", Offset = "0x3CC6330", VA = "0x183CC7330")]
	public static IKEAHAENECO<T1, T2, T3> KCDKILFEEIA<T1, T2, T3>(this MKAEDBJKBLC INCJDDLACNP, T1 EJJHJDCDAED, T2 MABIFADLEFI, T3 LBBJFGMEHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3CC76A0", Offset = "0x3CC66A0", VA = "0x183CC76A0")]
	public static EEMMHFKPIIC<T1, T2, T3, T4> KCDKILFEEIA<T1, T2, T3, T4>(this MKAEDBJKBLC INCJDDLACNP, T1 EJJHJDCDAED, T2 MABIFADLEFI, T3 LBBJFGMEHGP, T4 BDPPPNMMCPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3CC73E0", Offset = "0x3CC63E0", VA = "0x183CC73E0")]
	public static MALJCCBOCPH<T> JDEBDEJHDDE<T>(this MKAEDBJKBLC INCJDDLACNP, T CAILINJCNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7290", Offset = "0x3CC6290", VA = "0x183CC7290")]
	public static ANLDFALLAEE<T1, T2> JDEBDEJHDDE<T1, T2>(this MKAEDBJKBLC INCJDDLACNP, T1 EJJHJDCDAED, T2 MABIFADLEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3CC7330", Offset = "0x3CC6330", VA = "0x183CC7330")]
	public static IIKMAKBPFNP<T1, T2, T3> JDEBDEJHDDE<T1, T2, T3>(this MKAEDBJKBLC INCJDDLACNP, T1 EJJHJDCDAED, T2 MABIFADLEFI, T3 LBBJFGMEHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3CC76A0", Offset = "0x3CC66A0", VA = "0x183CC76A0")]
	public static MLOMBGOCPMC<T1, T2, T3, T4> JDEBDEJHDDE<T1, T2, T3, T4>(this MKAEDBJKBLC INCJDDLACNP, T1 EJJHJDCDAED, T2 MABIFADLEFI, T3 LBBJFGMEHGP, T4 BDPPPNMMCPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class CCFPFBGNCOP : BONJPBBBMJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[Flags]
	private enum IMNDPLECDJF
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Disposed = 1,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		LastSetLocally = 2,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Synchronizing = 4,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		ModifiedOffline = 8,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		Default = 4
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static Stack<IPMKAMOPMID> PIFAEOKDMBF;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static bool GFPPJBEFNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly IALDHONKEJC MFOAOKBDIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly NFAMKCPLNMM IEGLIFIOOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly string DAKIIEIEKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly PDOEAIKKMOC JLDAJBAEIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly Action HCEFPMMOBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected IPMKAMOPMID HBPLEPCNHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private IMNDPLECDJF OMENDEGIBIL;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static IPMKAMOPMID DADIJDJPMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x82C30B0", Offset = "0x82C20B0", VA = "0x1882C30B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool NIHOPNOFPNA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x82C2F40", Offset = "0x82C1F40", VA = "0x1882C2F40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x82C3090", Offset = "0x82C2090", VA = "0x1882C3090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private bool IBJPEHCCJIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x82C2D60", Offset = "0x82C1D60", VA = "0x1882C2D60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x82C3B10", Offset = "0x82C2B10", VA = "0x1882C3B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private bool COLBEEIDFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x82C2CB0", Offset = "0x82C1CB0", VA = "0x1882C2CB0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x82C2D40", Offset = "0x82C1D40", VA = "0x1882C2D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool GEBHMKDGFBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x82C39B0", Offset = "0x82C29B0", VA = "0x1882C39B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x82C3520", Offset = "0x82C2520", VA = "0x1882C3520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected virtual object LEJOFEIMONO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA683E0", Offset = "0xA673E0", VA = "0x180A683E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA68520", Offset = "0xA67520", VA = "0x180A68520", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool OFCNJONLJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x82C3280", Offset = "0x82C2280", VA = "0x1882C3280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int NHHLFEMJBFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xE55690", Offset = "0xE54690", VA = "0x180E55690")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xFA3790", Offset = "0xFA2790", VA = "0x180FA3790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string OKAFGBBEFIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool OAFDKAKOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x82C2C40", Offset = "0x82C1C40", VA = "0x1882C2C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x82C3690", Offset = "0x82C2690", VA = "0x1882C3690")]
	public static void JCGPIBDMPGN(IPMKAMOPMID AKPMHCBEJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool HJBGBEBAEAI();

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x82C4310", Offset = "0x82C3310", VA = "0x1882C4310")]
	protected CCFPFBGNCOP(IALDHONKEJC MFOAOKBDIIM, NFAMKCPLNMM IEGLIFIOOBM, string DAKIIEIEKNI, PDOEAIKKMOC JLDAJBAEIJG, Action HCEFPMMOBCM, IPMKAMOPMID CDGAKHGNCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x82C2F50", Offset = "0x82C1F50", VA = "0x1882C2F50", Slot = "1")]
	~CCFPFBGNCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x82C2D70", Offset = "0x82C1D70", VA = "0x1882C2D70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x82C3EC0", Offset = "0x82C2EC0", VA = "0x1882C3EC0")]
	private void POHGPINOADH(bool GPPEJBKAAGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x82C3D50", Offset = "0x82C2D50", VA = "0x1882C3D50")]
	private object PLEDJALEGKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x82C3B30", Offset = "0x82C2B30", VA = "0x1882C3B30")]
	protected void OCOPJMCPGIB(bool EEJHCFLALLD, object PKLGAEIGNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x82C3CF0", Offset = "0x82C2CF0", VA = "0x1882C3CF0")]
	protected void ODADMGGOEJG(object MNBECLGJOEJ, bool PCKPMEIAJNK = true, bool GDCKPMCKPLK = false, bool JBNLIGPDJGM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x82C32D0", Offset = "0x82C22D0", VA = "0x1882C32D0")]
	protected void HMJOGFCOJFJ(object MNBECLGJOEJ, bool GGMLDADBINL, bool PCKPMEIAJNK, bool GDCKPMCKPLK = false, bool JBNLIGPDJGM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x82C2CC0", Offset = "0x82C1CC0", VA = "0x1882C2CC0")]
	internal void CIINNEMCPEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x82C2EE0", Offset = "0x82C1EE0", VA = "0x1882C2EE0")]
	private void EKNHBGIBCHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x82C3730", Offset = "0x82C2730", VA = "0x1882C3730")]
	private void JGJOOHABFHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x82C3790", Offset = "0x82C2790", VA = "0x1882C3790", Slot = "4")]
	private void JJGJKOOIGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x82C3D30", Offset = "0x82C2D30", VA = "0x1882C3D30", Slot = "5")]
	private void ODHCKPIEODD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x82C4120", Offset = "0x82C3120", VA = "0x1882C4120")]
	public bool PPCOJCGDDEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x82C3F60", Offset = "0x82C2F60", VA = "0x1882C3F60")]
	public bool PPAJBMAJNOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x82C39C0", Offset = "0x82C29C0", VA = "0x1882C39C0")]
	private bool NNJHBPDJENP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x82C35E0", Offset = "0x82C25E0", VA = "0x1882C35E0")]
	internal void HPACFGPCMOL(object MNBECLGJOEJ, int OFAANALHPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x82C38A0", Offset = "0x82C28A0", VA = "0x1882C38A0")]
	private void LEMCIOMDJMD(object MNBECLGJOEJ, bool GDCKPMCKPLK, bool JBNLIGPDJGM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x82C3D40", Offset = "0x82C2D40", VA = "0x1882C3D40")]
	private bool ONDPMPJPIFB(IMNDPLECDJF HOJOECLHBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x82C2C90", Offset = "0x82C1C90", VA = "0x1882C2C90")]
	private void AOHHHNLJJHJ(IMNDPLECDJF HOJOECLHBEJ, bool IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x82C3800", Offset = "0x82C2800", VA = "0x1882C3800")]
	public static string LAMINEMJIOA(IALDHONKEJC MFOAOKBDIIM, string DAKIIEIEKNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x82C2FB0", Offset = "0x82C1FB0", VA = "0x1882C2FB0")]
	public static string GAFILFIJJII(NFAMKCPLNMM IEGLIFIOOBM, string DAKIIEIEKNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x82C3120", Offset = "0x82C2120", VA = "0x1882C3120")]
	public static bool HIHMGOOENJB(object JDINPJIAKOC, object LDPKBPICKKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class GJLFFIADDJC : IPMKAMOPMID, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly Dictionary<object, object> JEHFFIGJGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly List<string> FMJLAOLGBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly Dictionary<object, object> DHGBDPJJDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<string> JOMDJAMMLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool BFHCDNIGCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	protected readonly Dictionary<string, object> MKOECBNIMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	protected readonly Dictionary<IALDHONKEJC, Dictionary<string, object>> CEFKKNOOLJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<string> PKAMLABOLJJ;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public abstract Dictionary<object, object> LMPINIBOCPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public abstract int PAMLCMGGHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public abstract IALDHONKEJC JLABICKAIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public abstract bool OAFDKAKOOOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public abstract bool BCOECANAFJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual bool BJJKBJJCDFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool CEHLMEAICFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8D4F0", VA = "0x180A8E4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F700", Offset = "0x3C5E700", VA = "0x183C5F700", Slot = "12")]
	public void JCJKGBGCOHN<T>(string DAKIIEIEKNI, T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x82C62B0", Offset = "0x82C52B0", VA = "0x1882C62B0", Slot = "11")]
	public void NNKPGLONKDA(IALDHONKEJC MFOAOKBDIIM, string DAKIIEIEKNI, object IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x82C4A70", Offset = "0x82C3A70", VA = "0x1882C4A70", Slot = "9")]
	public object BOKKGHNNAOB(IALDHONKEJC MFOAOKBDIIM, string DAKIIEIEKNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x82C4B70", Offset = "0x82C3B70", VA = "0x1882C4B70", Slot = "10")]
	public void CAHKGMMIIFC(string DAKIIEIEKNI, object IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x82C56A0", Offset = "0x82C46A0", VA = "0x1882C56A0", Slot = "8")]
	public object KMMENCPIPMN(string DAKIIEIEKNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x82C4E40", Offset = "0x82C3E40", VA = "0x1882C4E40", Slot = "13")]
	public void DNCKIKDGLHN(IALDHONKEJC FMGAAJMDEJP, string DAKIIEIEKNI, CCFPFBGNCOP EIHKLMPDFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x82C57F0", Offset = "0x82C47F0", VA = "0x1882C57F0", Slot = "14")]
	public void LGIJBCLKGOP(IALDHONKEJC FMGAAJMDEJP, string DAKIIEIEKNI, CCFPFBGNCOP EIHKLMPDFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x82C5490", Offset = "0x82C4490", VA = "0x1882C5490")]
	private void HMKIHHFCECG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x82C4CF0", Offset = "0x82C3CF0", VA = "0x1882C4CF0")]
	private void CEBEICKPOEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x82C4C90", Offset = "0x82C3C90", VA = "0x1882C4C90")]
	private void CDDHKEILIDG(IALDHONKEJC MFOAOKBDIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x82C5F60", Offset = "0x82C4F60", VA = "0x1882C5F60")]
	protected void NCPPHJGOMGP(IALDHONKEJC MJGDLOJAIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x82C55B0", Offset = "0x82C45B0", VA = "0x1882C55B0")]
	protected void JHODELIDPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x82C57E0", Offset = "0x82C47E0", VA = "0x1882C57E0")]
	protected void LBFOFMPOKBJ(IDictionary<object, object> PIICNFNAPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x82C4DD0", Offset = "0x82C3DD0", VA = "0x1882C4DD0")]
	protected void DCHFHBIKNCL(IALDHONKEJC IFFACPNEAFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x82C49E0", Offset = "0x82C39E0", VA = "0x1882C49E0")]
	protected void BNNDIACDHAF(IALDHONKEJC MFOAOKBDIIM, IDictionary<object, object> PIICNFNAPGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x82C6770", Offset = "0x82C5770", VA = "0x1882C6770")]
	private void PIDDNJGNHMA(IDictionary<object, object> PIICNFNAPGN, Dictionary<string, object> MCOPPFMBOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x82C51B0", Offset = "0x82C41B0", VA = "0x1882C51B0")]
	private static void EBILHDCKJKF(object KPOJLJNCIHI, object EKGLNGMKMKH, int OFAANALHPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x82C6090", Offset = "0x82C5090", VA = "0x1882C6090")]
	private static void NLKLNHPLGKA(Dictionary<string, object> MCOPPFMBOLG, string DAKIIEIEKNI, CCFPFBGNCOP EIHKLMPDFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x82C4580", Offset = "0x82C3580", VA = "0x1882C4580")]
	private static void AENALDHJHNM(Dictionary<string, object> MCOPPFMBOLG, string DAKIIEIEKNI, CCFPFBGNCOP EIHKLMPDFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x82C4F50", Offset = "0x82C3F50", VA = "0x1882C4F50", Slot = "17")]
	public void DPDLCDJDPKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "27")]
	protected abstract void GDFNPCIHEJN(Dictionary<object, object> JEHFFIGJGFM);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x82C53B0", Offset = "0x82C43B0", VA = "0x1882C53B0", Slot = "18")]
	public void ECLHGMADAAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	protected abstract void COAFIMPLMGP(Dictionary<object, object> DHGBDPJJDDB);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x82C5AA0", Offset = "0x82C4AA0", VA = "0x1882C5AA0")]
	private void MAAIHEJAFMG(Dictionary<object, object> LMNHGELIMJA, List<string> PIKBGELGGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x82C4750", Offset = "0x82C3750", VA = "0x1882C4750")]
	private void BBDNIOGGKBC(IDictionary<object, object> PIICNFNAPGN, [Out] int OFAANALHPJJ, [Out] string[] ILAFMJGOMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x82C4D40", Offset = "0x82C3D40", VA = "0x1882C4D40")]
	public void DBHGKOOFCDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x82C54E0", Offset = "0x82C44E0", VA = "0x1882C54E0")]
	public void HPENOCNMIKG(IALDHONKEJC MFOAOKBDIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x82C6400", Offset = "0x82C5400", VA = "0x1882C6400")]
	public void ODPJKBIBIOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "29")]
	protected abstract HashSet<int> IGAGIGMDHKN(bool KEFCGANNEBA, bool IAFBANEBIKE);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x82C5CD0", Offset = "0x82C4CD0", VA = "0x1882C5CD0", Slot = "19")]
	public void MHLAKEENIBA(string DGMLMPAOEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x82C5740", Offset = "0x82C4740", VA = "0x1882C5740")]
	protected string LAMINEMJIOA(IALDHONKEJC MFOAOKBDIIM, string DAKIIEIEKNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract object HFOBFHLIABC<T>(T IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract T PFOLCMBAAHK<T>(object IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "32")]
	public virtual void OCOPJMCPGIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x82C5050", Offset = "0x82C4050", VA = "0x1882C5050", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "33")]
	protected virtual void AFMJKFDMJLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x82C6C00", Offset = "0x82C5C00", VA = "0x1882C6C00")]
	protected GJLFFIADDJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class AMGAILPBNNM<T1> : CCFPFBGNCOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T1 IFKBIHEEEOE;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	protected virtual T1 PKPIGCOLIMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x107BCB0", Offset = "0x107ACB0", VA = "0x18107BCB0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x123AC10", Offset = "0x1239C10", VA = "0x18123AC10", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	protected override object LEJOFEIMONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4D81D80", Offset = "0x4D80D80", VA = "0x184D81D80", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5272460", Offset = "0x5271460", VA = "0x185272460", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5271320", Offset = "0x5270320", VA = "0x185271320", Slot = "9")]
	protected override bool HJBGBEBAEAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5275AC0", Offset = "0x5274AC0", VA = "0x185275AC0")]
	protected AMGAILPBNNM([In] MKAEDBJKBLC INCJDDLACNP, T1 IFKBIHEEEOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5275E30", Offset = "0x5274E30", VA = "0x185275E30")]
	protected AMGAILPBNNM(IALDHONKEJC MFOAOKBDIIM, NFAMKCPLNMM IEGLIFIOOBM, string DAKIIEIEKNI, T1 IFKBIHEEEOE, PDOEAIKKMOC JLDAJBAEIJG, bool EEJHCFLALLD, Action HCEFPMMOBCM, IPMKAMOPMID CDGAKHGNCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4D81CC0", Offset = "0x4D80CC0", VA = "0x184D81CC0")]
	public T1 LMKONLJOAEP()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x52738D0", Offset = "0x52728D0", VA = "0x1852738D0")]
	public void ODADMGGOEJG(T1 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5274960", Offset = "0x5273960", VA = "0x185274960")]
	public void ODADMGGOEJG(T1 MNBECLGJOEJ, bool PCKPMEIAJNK, bool GDCKPMCKPLK = false, bool JBNLIGPDJGM = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class GPPHDLMNLCI<T1, T2> : CCFPFBGNCOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private T1 IFKBIHEEEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T2 OGLFOKBGGFB;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	protected virtual T1 PKPIGCOLIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xFF2FD0", Offset = "0xFF1FD0", VA = "0x180FF2FD0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x123AC00", Offset = "0x1239C00", VA = "0x18123AC00", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	protected virtual T2 MBJIHNBOEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xFECFB0", Offset = "0xFEBFB0", VA = "0x180FECFB0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xFF2E00", Offset = "0xFF1E00", VA = "0x180FF2E00", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public T2 BBGBJHIEDMO
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4D81E70", Offset = "0x4D80E70", VA = "0x184D81E70")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	protected override object LEJOFEIMONO
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4D81D80", Offset = "0x4D80D80", VA = "0x184D81D80", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4EF6150", Offset = "0x4EF5150", VA = "0x184EF6150", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4EF5630", Offset = "0x4EF4630", VA = "0x184EF5630", Slot = "9")]
	protected override bool HJBGBEBAEAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x4EFD120", Offset = "0x4EFC120", VA = "0x184EFD120")]
	protected GPPHDLMNLCI([In] MKAEDBJKBLC INCJDDLACNP, T1 IFKBIHEEEOE, T2 OGLFOKBGGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4EFCED0", Offset = "0x4EFBED0", VA = "0x184EFCED0")]
	protected GPPHDLMNLCI(IALDHONKEJC MFOAOKBDIIM, NFAMKCPLNMM IEGLIFIOOBM, string DAKIIEIEKNI, T1 IFKBIHEEEOE, T2 OGLFOKBGGFB, PDOEAIKKMOC JLDAJBAEIJG, bool EEJHCFLALLD, Action HCEFPMMOBCM, IPMKAMOPMID CDGAKHGNCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x4D81CC0", Offset = "0x4D80CC0", VA = "0x184D81CC0")]
	public T1 AFNFBDIJHNC()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4EF7B20", Offset = "0x4EF6B20", VA = "0x184EF7B20")]
	public void MDLDKLMMEEC(T1 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4D81E70", Offset = "0x4D80E70", VA = "0x184D81E70")]
	public T2 JNNDEIPBGCH()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4EF3930", Offset = "0x4EF2930", VA = "0x184EF3930")]
	public void ACBHMIGFDLA(T2 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4EF9BD0", Offset = "0x4EF8BD0", VA = "0x184EF9BD0")]
	public void ODADMGGOEJG(T1 HMKBHMACMAM, T2 INAHLDJFCJA, bool PCKPMEIAJNK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class FEKOALPFHGO<T1, T2, T3> : CCFPFBGNCOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private T1 IFKBIHEEEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T2 OGLFOKBGGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private T3 LHCAHPLPCKE;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	protected virtual T1 PKPIGCOLIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA68470", Offset = "0xA67470", VA = "0x180A68470", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA685D0", Offset = "0xA675D0", VA = "0x180A685D0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	protected virtual T2 MBJIHNBOEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1041860", Offset = "0x1040860", VA = "0x181041860", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x1041410", Offset = "0x1040410", VA = "0x181041410", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	protected virtual T3 ODNMBNCJBKA
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3B0", Offset = "0xA7A3B0", VA = "0x180A7B3B0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xDB1050", Offset = "0xDB0050", VA = "0x180DB1050", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T1 JOGCGBBBADB
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4D81CC0", Offset = "0x4D80CC0", VA = "0x184D81CC0")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T2 BBGBJHIEDMO
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4D81E70", Offset = "0x4D80E70", VA = "0x184D81E70")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T3 KOAPFOAANBO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4D81DE0", Offset = "0x4D80DE0", VA = "0x184D81DE0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected override object LEJOFEIMONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4D81D80", Offset = "0x4D80D80", VA = "0x184D81D80", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4D83C60", Offset = "0x4D82C60", VA = "0x184D83C60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4D82E60", Offset = "0x4D81E60", VA = "0x184D82E60", Slot = "9")]
	protected override bool HJBGBEBAEAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4D888C0", Offset = "0x4D878C0", VA = "0x184D888C0")]
	protected FEKOALPFHGO([In] MKAEDBJKBLC INCJDDLACNP, T1 IFKBIHEEEOE, T2 OGLFOKBGGFB, T3 LHCAHPLPCKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4D88310", Offset = "0x4D87310", VA = "0x184D88310")]
	protected FEKOALPFHGO(IALDHONKEJC MFOAOKBDIIM, NFAMKCPLNMM IEGLIFIOOBM, string DAKIIEIEKNI, T1 IFKBIHEEEOE, T2 OGLFOKBGGFB, T3 LHCAHPLPCKE, PDOEAIKKMOC JLDAJBAEIJG, bool EEJHCFLALLD, Action HCEFPMMOBCM, IPMKAMOPMID CDGAKHGNCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4D81CC0", Offset = "0x4D80CC0", VA = "0x184D81CC0")]
	public T1 AFNFBDIJHNC()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4D84900", Offset = "0x4D83900", VA = "0x184D84900")]
	public void MDLDKLMMEEC(T1 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4D81E70", Offset = "0x4D80E70", VA = "0x184D81E70")]
	public T2 JNNDEIPBGCH()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4D81600", Offset = "0x4D80600", VA = "0x184D81600")]
	public void ACBHMIGFDLA(T2 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4D81DE0", Offset = "0x4D80DE0", VA = "0x184D81DE0")]
	public T3 LDGJMPHONFN()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4D818E0", Offset = "0x4D808E0", VA = "0x184D818E0")]
	public void ADFOAMGHEPJ(T3 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4D84EA0", Offset = "0x4D83EA0", VA = "0x184D84EA0")]
	public void ODADMGGOEJG(T1 HMKBHMACMAM, T2 INAHLDJFCJA, T3 LMHAJIKMLIM, bool PCKPMEIAJNK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class GGPHPIJJBJN<T1, T2, T3, T4> : CCFPFBGNCOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T1 IFKBIHEEEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private T2 OGLFOKBGGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private T3 LHCAHPLPCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private T4 EFECIKPEDEG;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	protected virtual T1 PKPIGCOLIMF
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xEEB630", Offset = "0xEEA630", VA = "0x180EEB630", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xFFBD70", Offset = "0xFFAD70", VA = "0x180FFBD70", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	protected virtual T2 MBJIHNBOEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1ED07E0", Offset = "0x1ECF7E0", VA = "0x181ED07E0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x4EAB620", Offset = "0x4EAA620", VA = "0x184EAB620", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	protected virtual T3 ODNMBNCJBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4EAB5B0", Offset = "0x4EAA5B0", VA = "0x184EAB5B0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x4EB23D0", Offset = "0x4EB13D0", VA = "0x184EB23D0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	protected virtual T4 FPEDPOAAKNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1602140", Offset = "0x1601140", VA = "0x181602140", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x158A810", Offset = "0x1589810", VA = "0x18158A810", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public T2 BBGBJHIEDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4D81E90", Offset = "0x4D80E90", VA = "0x184D81E90")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T3 KOAPFOAANBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4D81E00", Offset = "0x4D80E00", VA = "0x184D81E00")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T4 JPCNFGBPAIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x2031400", Offset = "0x2030400", VA = "0x182031400")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	protected override object LEJOFEIMONO
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4D81D80", Offset = "0x4D80D80", VA = "0x184D81D80", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4EAE3A0", Offset = "0x4EAD3A0", VA = "0x184EAE3A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4EAD140", Offset = "0x4EAC140", VA = "0x184EAD140", Slot = "9")]
	protected override bool HJBGBEBAEAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x4EB45E0", Offset = "0x4EB35E0", VA = "0x184EB45E0")]
	protected GGPHPIJJBJN([In] MKAEDBJKBLC INCJDDLACNP, T1 IFKBIHEEEOE, T2 OGLFOKBGGFB, T3 LHCAHPLPCKE, T4 EFECIKPEDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x4EB2410", Offset = "0x4EB1410", VA = "0x184EB2410")]
	protected GGPHPIJJBJN(IALDHONKEJC MFOAOKBDIIM, NFAMKCPLNMM IEGLIFIOOBM, string DAKIIEIEKNI, T1 IFKBIHEEEOE, T2 OGLFOKBGGFB, T3 LHCAHPLPCKE, T4 EFECIKPEDEG, PDOEAIKKMOC JLDAJBAEIJG, bool EEJHCFLALLD, Action HCEFPMMOBCM, IPMKAMOPMID CDGAKHGNCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4D81CC0", Offset = "0x4D80CC0", VA = "0x184D81CC0")]
	public T1 AFNFBDIJHNC()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF160", Offset = "0x4EAE160", VA = "0x184EAF160")]
	public void MDLDKLMMEEC(T1 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x4D81E90", Offset = "0x4D80E90", VA = "0x184D81E90")]
	public T2 JNNDEIPBGCH()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4EAACC0", Offset = "0x4EA9CC0", VA = "0x184EAACC0")]
	public void ACBHMIGFDLA(T2 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x4D81E00", Offset = "0x4D80E00", VA = "0x184D81E00")]
	public T3 LDGJMPHONFN()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x4EAB090", Offset = "0x4EAA090", VA = "0x184EAB090")]
	public void ADFOAMGHEPJ(T3 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x2031400", Offset = "0x2030400", VA = "0x182031400")]
	public T4 NOELAAFLDFP()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x4EAB9C0", Offset = "0x4EAA9C0", VA = "0x184EAB9C0")]
	public void EMKJDIOEJBK(T4 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x4EB09E0", Offset = "0x4EAF9E0", VA = "0x184EB09E0")]
	public void ODADMGGOEJG(T1 HMKBHMACMAM, T2 INAHLDJFCJA, T3 LMHAJIKMLIM, T4 HOFHIENFIEB, bool PCKPMEIAJNK = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class MDODPBGGNJI<T1, T2, T3, T4, T5> : CCFPFBGNCOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private T1 IFKBIHEEEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T2 OGLFOKBGGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private T3 LHCAHPLPCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private T4 EFECIKPEDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private T5 CCHNMLBHJNM;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	protected virtual T1 PKPIGCOLIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xAD3250", Offset = "0xAD2250", VA = "0x180AD3250", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xAD32D0", Offset = "0xAD22D0", VA = "0x180AD32D0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	protected virtual T2 MBJIHNBOEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x153E630", Offset = "0x153D630", VA = "0x18153E630", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x153CEA0", Offset = "0x153BEA0", VA = "0x18153CEA0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	protected virtual T3 ODNMBNCJBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA7B3B0", Offset = "0xA7A3B0", VA = "0x180A7B3B0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xDB1050", Offset = "0xDB0050", VA = "0x180DB1050", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	protected virtual T4 FPEDPOAAKNG
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA97230", Offset = "0xA96230", VA = "0x180A97230", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA97290", Offset = "0xA96290", VA = "0x180A97290", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	protected virtual T5 EKAOLCOKEJC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x1745840", Offset = "0x1744840", VA = "0x181745840", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return (T5)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x1746210", Offset = "0x1745210", VA = "0x181746210", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	protected override object LEJOFEIMONO
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x4D81D80", Offset = "0x4D80D80", VA = "0x184D81D80", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x56A2260", Offset = "0x56A1260", VA = "0x1856A2260", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x56A0F00", Offset = "0x569FF00", VA = "0x1856A0F00", Slot = "9")]
	protected override bool HJBGBEBAEAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x56A5A40", Offset = "0x56A4A40", VA = "0x1856A5A40")]
	protected MDODPBGGNJI(IALDHONKEJC MFOAOKBDIIM, NFAMKCPLNMM IEGLIFIOOBM, string DAKIIEIEKNI, T1 IFKBIHEEEOE, T2 OGLFOKBGGFB, T3 LHCAHPLPCKE, T4 EFECIKPEDEG, T5 CCHNMLBHJNM, PDOEAIKKMOC JLDAJBAEIJG, bool EEJHCFLALLD, Action HCEFPMMOBCM, IPMKAMOPMID CDGAKHGNCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x4D81CC0", Offset = "0x4D80CC0", VA = "0x184D81CC0")]
	public T1 AFNFBDIJHNC()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x56A2BC0", Offset = "0x56A1BC0", VA = "0x1856A2BC0")]
	public void MDLDKLMMEEC(T1 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x4D81E70", Offset = "0x4D80E70", VA = "0x184D81E70")]
	public T2 JNNDEIPBGCH()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x569FF50", Offset = "0x569EF50", VA = "0x18569FF50")]
	public void ACBHMIGFDLA(T2 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4D81DE0", Offset = "0x4D80DE0", VA = "0x184D81DE0")]
	public T3 LDGJMPHONFN()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x56A0210", Offset = "0x569F210", VA = "0x1856A0210")]
	public void ADFOAMGHEPJ(T3 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x2031400", Offset = "0x2030400", VA = "0x182031400")]
	public T4 NOELAAFLDFP()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x56A05F0", Offset = "0x569F5F0", VA = "0x1856A05F0")]
	public void EMKJDIOEJBK(T4 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x56A05D0", Offset = "0x569F5D0", VA = "0x1856A05D0")]
	public T5 EMCEDJGKKPE()
	{
		return (T5)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x56A2800", Offset = "0x56A1800", VA = "0x1856A2800")]
	public void KHOBLGMBJIL(T5 MNBECLGJOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x56A3300", Offset = "0x56A2300", VA = "0x1856A3300")]
	public void ODADMGGOEJG(T1 HMKBHMACMAM, T2 INAHLDJFCJA, T3 LMHAJIKMLIM, T4 HOFHIENFIEB, T5 EDDBBIIJCFO)
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
