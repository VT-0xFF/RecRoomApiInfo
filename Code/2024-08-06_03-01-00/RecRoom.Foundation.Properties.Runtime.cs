using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class DBNKJBBIGDJ<TContainer, TField> : NJGBBNIDEFJ<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x37E9EC0", Offset = "0x37E84C0", VA = "0x1837E9EC0")]
	public DBNKJBBIGDJ(string LGJDNDBECCI, GAKLDGFGGCA NHEAJDGKBEF, FieldInfo LLEFLPCIOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x58609F0", Offset = "0x585EFF0", VA = "0x1858609F0", Slot = "25")]
	public override bool FNIGGHLNDBN(Entity PEMPNCNIDJF, EMHJONJGKLA GNGOIGDLMDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class EEOFACKHPBM<T> : NJGBBNIDEFJ<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x37E9EC0", Offset = "0x37E84C0", VA = "0x1837E9EC0")]
	public EEOFACKHPBM(string LGJDNDBECCI, GAKLDGFGGCA NHEAJDGKBEF, FieldInfo LLEFLPCIOFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class NJGBBNIDEFJ<T> : FPCCBPLHIDP, MFOCFLFOEIP<T>, FHDCPNDHNLJ<Entity, T>, MHHIBAKNJLE<Entity>, CBKLKKDKPFF, IDisposable, HMLDKFIAGBN, KDLKENBHEPB where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool FDCLLJGLMGO(Entity PEMPNCNIDJF, [In] T GNGOIGDLMDJ);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void HHCBMODHILA(Entity PEMPNCNIDJF, [In] T NEOBIHGDPAM, [In] T GNGOIGDLMDJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly GAKLDGFGGCA NHEAJDGKBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly FieldInfo LLEFLPCIOFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected readonly int GFMLMIBOOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	protected readonly int LHOLHMCKPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int PPOFLGDKIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private FDCLLJGLMGO OAMIBAIFPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private HHCBMODHILA JGAMHMKLJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private HHCBMODHILA BGPDNGFOEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World EBMDMJNFPCB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type FJKMPMDCIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4585BF0", Offset = "0x45841F0", VA = "0x184585BF0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override GAKLDGFGGCA IMLPEKLLFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x860D20", Offset = "0x85F320", VA = "0x180860D20", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override KDLKENBHEPB MACAEFIDOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x98BFE0", Offset = "0x98A5E0", VA = "0x18098BFE0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo MIDEPOFDNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int GEOOHHCNEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x87B840", Offset = "0x879E40", VA = "0x18087B840", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int EBFKBIAHOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86D300", Offset = "0x86B900", VA = "0x18086D300", Slot = "34")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager FIMLMIMMNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4580090", Offset = "0x457E690", VA = "0x184580090")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4586FE0", Offset = "0x45855E0", VA = "0x184586FE0")]
	internal NJGBBNIDEFJ(string LGJDNDBECCI, GAKLDGFGGCA NHEAJDGKBEF, FieldInfo LLEFLPCIOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4584DB0", Offset = "0x45833B0", VA = "0x184584DB0", Slot = "29")]
	public override void HGDANEHJCNG(EntityManager ELCBIAGEOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4584140", Offset = "0x4582740", VA = "0x184584140")]
	public NJGBBNIDEFJ<T> GBMFEOHBCOH(FDCLLJGLMGO OAMIBAIFPPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4584120", Offset = "0x4582720", VA = "0x184584120")]
	public NJGBBNIDEFJ<T> FPOCJLEOFEK(HHCBMODHILA JGAMHMKLJKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4580070", Offset = "0x457E670", VA = "0x184580070")]
	public NJGBBNIDEFJ<T> CBBHKIHNODD(HHCBMODHILA BGPDNGFOEIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x457FA80", Offset = "0x457E080", VA = "0x18457FA80", Slot = "31")]
	public T BJJBEHDKBAF(Entity PEMPNCNIDJF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4582D50", Offset = "0x4581350", VA = "0x184582D50")]
	public bool FNIGGHLNDBN(Entity PEMPNCNIDJF, [In] T GNGOIGDLMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4584BE0", Offset = "0x45831E0", VA = "0x184584BE0")]
	public bool HANBLNPMPIK(Entity PEMPNCNIDJF, [In] T GNGOIGDLMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4586320", Offset = "0x4584920", VA = "0x184586320", Slot = "23")]
	public override bool PIFOANKJMPH(Entity PEMPNCNIDJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x457EBD0", Offset = "0x457D1D0", VA = "0x18457EBD0", Slot = "24")]
	public override void BJJBEHDKBAF(Entity PEMPNCNIDJF, IIJMDPEFOIG FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x4580130", Offset = "0x457E730", VA = "0x184580130", Slot = "25")]
	public override bool FNIGGHLNDBN(Entity PEMPNCNIDJF, EMHJONJGKLA GNGOIGDLMDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4584160", Offset = "0x4582760", VA = "0x184584160", Slot = "26")]
	public override void GKDHMFHFLJI(DAICDOIOFAB OJOCLHBGLPK, [Optional] object MGIHCPMKPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4584610", Offset = "0x4582C10", VA = "0x184584610", Slot = "27")]
	public override bool GOBEFKIIDAP(Entity CKPLDDAHIDF, Entity BOIMHPNGCKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "28")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4585270", Offset = "0x4583870", VA = "0x184585270", Slot = "30")]
	public override string JEPFIBHCMPH([In] EMHJONJGKLA FEDHMABHDCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4585E90", Offset = "0x4584490", VA = "0x184585E90")]
	private bool KCHLLHEKAJE(T NEOBIHGDPAM, T GNGOIGDLMDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class FPCCBPLHIDP : FIOLPDLNDPM, HMLDKFIAGBN, MHHIBAKNJLE<Entity>, CBKLKKDKPFF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type FJKMPMDCIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract GAKLDGFGGCA IMLPEKLLFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract KDLKENBHEPB MACAEFIDOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string IKOGEGKCJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85F4B0", Offset = "0x85DAB0", VA = "0x18085F4B0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LNHMMOOEMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x998B00", Offset = "0x997100", VA = "0x180998B00", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x998B10", Offset = "0x997110", VA = "0x180998B10", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event PAPBHNCDODI<Entity> ICHDGECEPIF
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x69B90F0", Offset = "0x69B76F0", VA = "0x1869B90F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69B9040", Offset = "0x69B7640", VA = "0x1869B9040", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract bool PIFOANKJMPH(Entity PEMPNCNIDJF);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract void BJJBEHDKBAF(Entity PEMPNCNIDJF, IIJMDPEFOIG FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract bool FNIGGHLNDBN(Entity PEMPNCNIDJF, EMHJONJGKLA GNGOIGDLMDJ);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void GKDHMFHFLJI(DAICDOIOFAB OJOCLHBGLPK, [Optional] object MGIHCPMKPNG);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract bool GOBEFKIIDAP(Entity CKPLDDAHIDF, Entity BOIMHPNGCKI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void HGDANEHJCNG(EntityManager ELCBIAGEOKB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2B5DBD0", Offset = "0x2B5C1D0", VA = "0x182B5DBD0")]
	protected void MLOABAKHMNH<T>(Entity PEMPNCNIDJF, [In] T NEOBIHGDPAM, [In] T GNGOIGDLMDJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract string JEPFIBHCMPH([In] EMHJONJGKLA FEDHMABHDCC);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	protected FPCCBPLHIDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HMLDKFIAGBN : MHHIBAKNJLE<Entity>, CBKLKKDKPFF, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MFOCFLFOEIP<T> : FHDCPNDHNLJ<Entity, T>, MHHIBAKNJLE<Entity>, CBKLKKDKPFF, IDisposable, HMLDKFIAGBN where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface FIOLPDLNDPM : HMLDKFIAGBN, MHHIBAKNJLE<Entity>, CBKLKKDKPFF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int LNHMMOOEMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class BMKANMIHLHN
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x28FEAB0", Offset = "0x28FD0B0", VA = "0x1828FEAB0")]
	public static T NEDAFLJJPOM<T>(this MFOCFLFOEIP<T> MLBHCALGJAO, Entity PEMPNCNIDJF, [Optional] T PBAONJMDGEK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x28FE960", Offset = "0x28FCF60", VA = "0x1828FE960")]
	public static T BKBHIMDHMLK<T>(this MHHIBAKNJLE<Entity> MLBHCALGJAO, Entity PEMPNCNIDJF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x28FED50", Offset = "0x28FD350", VA = "0x1828FED50")]
	public static bool PGBPILIJKHH<T>(this MHHIBAKNJLE<Entity> MLBHCALGJAO, Entity PEMPNCNIDJF, [In] T GNGOIGDLMDJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x28FEC30", Offset = "0x28FD230", VA = "0x1828FEC30")]
	public static bool PGBPILIJKHH<T>(this MHHIBAKNJLE<Entity> MLBHCALGJAO, Entity PEMPNCNIDJF, NativeArray<T> GNGOIGDLMDJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void PAPBHNCDODI<TKey>(TKey CDBNFNMIHPK, [In] EMHJONJGKLA NEOBIHGDPAM, [In] EMHJONJGKLA GNGOIGDLMDJ);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JJCGHEKNIOC
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2BBE130", Offset = "0x2BBC730", VA = "0x182BBE130")]
	public static void DFDLGJKGLOI<TKey, T>(this PAPBHNCDODI<TKey> CFHMBPIJFPA, TKey CDBNFNMIHPK, T NEOBIHGDPAM, T GNGOIGDLMDJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DAICDOIOFAB
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIHLAIDBJKG<TKey, T>(FHDCPNDHNLJ<TKey, T> MLBHCALGJAO, [Optional] object MGIHCPMKPNG) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PIIEBNKPFPA
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KDLKENBHEPB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo AMABIHKJAFP
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int AMCGEKKJOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int BONHNBEOKPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CBKLKKDKPFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string IKOGEGKCJIK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type FJKMPMDCIGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	KDLKENBHEPB MACAEFIDOMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GAKLDGFGGCA IMLPEKLLFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int LNHMMOOEMBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GKDHMFHFLJI(DAICDOIOFAB OJOCLHBGLPK, [Optional] object MGIHCPMKPNG);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface MHHIBAKNJLE<TKey> : CBKLKKDKPFF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event PAPBHNCDODI<TKey> ICHDGECEPIF;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PIFOANKJMPH(TKey MNBFPOFIDHA);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BJJBEHDKBAF(TKey MNBFPOFIDHA, IIJMDPEFOIG FEBGGALLBNN);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FNIGGHLNDBN(TKey MNBFPOFIDHA, EMHJONJGKLA GNGOIGDLMDJ);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GOBEFKIIDAP(TKey CKPLDDAHIDF, TKey BOIMHPNGCKI);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string JEPFIBHCMPH([In] EMHJONJGKLA FEBGGALLBNN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface FHDCPNDHNLJ<TKey, T> : MHHIBAKNJLE<TKey>, CBKLKKDKPFF, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T BJJBEHDKBAF(TKey MNBFPOFIDHA);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ILDIDJOCGGJ
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7B70", Offset = "0x2BA6170", VA = "0x182BA7B70")]
	public static bool CBPJGMGJFOI<TKey, T>(this MHHIBAKNJLE<TKey> MLBHCALGJAO, TKey MNBFPOFIDHA, [Out] T FEBGGALLBNN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7570", Offset = "0x2BA5B70", VA = "0x182BA7570")]
	public static T BJJBEHDKBAF<T, TKey>(this MHHIBAKNJLE<TKey> MLBHCALGJAO, TKey MNBFPOFIDHA) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7D30", Offset = "0x2BA6330", VA = "0x182BA7D30")]
	public static bool FNIGGHLNDBN<TKey, T>(this MHHIBAKNJLE<TKey> MLBHCALGJAO, TKey MNBFPOFIDHA, T GNGOIGDLMDJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2BA7F90", Offset = "0x2BA6590", VA = "0x182BA7F90")]
	public static bool FNIGGHLNDBN<TKey, T>(this MHHIBAKNJLE<TKey> MLBHCALGJAO, TKey MNBFPOFIDHA, NativeArray<T> GNGOIGDLMDJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface DIDOLFGAMNM : IEnumerable<HMLDKFIAGBN>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GAKLDGFGGCA
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int HNFELNEOCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int HAFEJMAGFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type AAILGGCKDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	HMLDKFIAGBN[] HMGBHNGLOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool PKCIHMLCEIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) IGHOHFGLDGH(Entity PEMPNCNIDJF);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LDALMEBPNGI(Entity PEMPNCNIDJF, (uint order, uint change) PKICDAADPKG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class MNGOKFOEKMF : DIDOLFGAMNM, IEnumerable<HMLDKFIAGBN>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<HMLDKFIAGBN> FFAKECNNNHM;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x69B9620", Offset = "0x69B7C20", VA = "0x1869B9620", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public HMLDKFIAGBN ECHCHHAAKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x69B96E0", Offset = "0x69B7CE0", VA = "0x1869B96E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69B9740", Offset = "0x69B7D40", VA = "0x1869B9740")]
	public MNGOKFOEKMF(IEnumerable<GAKLDGFGGCA> IHNBAKNPCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69B91A0", Offset = "0x69B77A0", VA = "0x1869B91A0")]
	private List<HMLDKFIAGBN> BKBOGJBHDCN(IEnumerable<GAKLDGFGGCA> IHNBAKNPCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69B9660", Offset = "0x69B7C60", VA = "0x1869B9660", Slot = "4")]
	public IEnumerator<HMLDKFIAGBN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69B9660", Offset = "0x69B7C60", VA = "0x1869B9660", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct IAOFGLHDBEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type DAPLPFBCBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string LGJDNDBECCI;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xB912D0", Offset = "0xB8F8D0", VA = "0x180B912D0")]
	public IAOFGLHDBEE(Type DAPLPFBCBCP, string LGJDNDBECCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct NNHKJGLKIOG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type DAPLPFBCBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string LGJDNDBECCI;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xB912D0", Offset = "0xB8F8D0", VA = "0x180B912D0")]
	public NNHKJGLKIOG(Type DAPLPFBCBCP, string LGJDNDBECCI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x45FD100", Offset = "0x45FB700", VA = "0x1845FD100")]
	public static IAOFGLHDBEE IKOCKAJCOIN(NNHKJGLKIOG<T> HPJONBNOMIP)
	{
		return default(IAOFGLHDBEE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum NCGPHIEIGDO
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	CreateObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DestroyObject = -3,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	BeginTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	EndTransaction = -5,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	External = -6
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class MIABPGLKCNF
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public MIABPGLKCNF()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
	{
	}
}
namespace Cpp2IlInjected
{
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
}
