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
public interface HFPEHOFOLDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool ECNOEKBDEFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool MCHFGECMJJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	KNOJHPOMDED HGFDDBIJDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int IBEABMNEFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MLBJFMCLINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool GJKHCBPAOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action FCGDNKLHKIJ;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JPNLCNHKGFM();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FNIEPOINEFA(object DKFMAIJGPFL, bool MIFFHCNGJJN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PLDHHKDPDKE();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GHKEJBEBCML : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string MBLBFBKCCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KNHBKMLJACB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CGCFLKDJHJD<T> : GHKEJBEBCML, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T IOCMOENJJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ANMBIEBBHNN(T FHKIBFJAKOF);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class NDPGCICHFBP<T> : CGCFLKDJHJD<T>, GHKEJBEBCML, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PCAJFFHOLPJ<T> ODGENDEEDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly PCAJFFHOLPJ<T> JCPPFIBJKAL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string MBLBFBKCCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xE9BFF0", Offset = "0xE9A5F0", VA = "0x180E9BFF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool AAFPACIGJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5685490", Offset = "0x5683A90", VA = "0x185685490", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T KAKPIICKODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B4A0", Offset = "0x4F69AA0", VA = "0x184F6B4A0", Slot = "11")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5684E70", Offset = "0x5683470", VA = "0x185684E70", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T IOCMOENJJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x56851E0", Offset = "0x56837E0", VA = "0x1856851E0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5684810", Offset = "0x5682E10", VA = "0x185684810", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x56851E0", Offset = "0x56837E0", VA = "0x1856851E0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5685970", Offset = "0x5683F70", VA = "0x185685970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool KNHBKMLJACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4D23430", Offset = "0x4D21A30", VA = "0x184D23430", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x51A0AD0", Offset = "0x519F0D0", VA = "0x1851A0AD0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool PHFOHDOOMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x56851C0", Offset = "0x56837C0", VA = "0x1856851C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5685700", Offset = "0x5683D00", VA = "0x185685700", Slot = "10")]
	public void MGCNIAHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x56862E0", Offset = "0x56848E0", VA = "0x1856862E0")]
	public NDPGCICHFBP([In] JAAHDJDPHDD ACJFHCNBBBO, T ALPLAIPHAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5684B10", Offset = "0x5683110", VA = "0x185684B10")]
	private void BELDMCKIGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5684840", Offset = "0x5682E40", VA = "0x185684840", Slot = "5")]
	public void ANMBIEBBHNN(T FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x56848E0", Offset = "0x5682EE0", VA = "0x1856848E0")]
	public void ANMBIEBBHNN(T FHKIBFJAKOF, bool NONBBMCKGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4D236F0", Offset = "0x4D21CF0", VA = "0x184D236F0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class LNNMKIHBLCP<T1, T2> : CGCFLKDJHJD<(T1, T2)>, GHKEJBEBCML, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly DHDJAHBANDN<T1, T2> ODGENDEEDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly DHDJAHBANDN<T1, T2> JCPPFIBJKAL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string MBLBFBKCCDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xE9BFF0", Offset = "0xE9A5F0", VA = "0x180E9BFF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool AAFPACIGJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5434AC0", Offset = "0x54330C0", VA = "0x185434AC0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool PKBPPOIJBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4D246B0", Offset = "0x4D22CB0", VA = "0x184D246B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool IJKPHNBIEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5434D80", Offset = "0x5433380", VA = "0x185434D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public (T1, T2) KAKPIICKODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5434400", Offset = "0x5432A00", VA = "0x185434400", Slot = "11")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5433880", Offset = "0x5431E80", VA = "0x185433880", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public (T1, T2) IOCMOENJJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5433BE0", Offset = "0x54321E0", VA = "0x185433BE0", Slot = "4")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5432F30", Offset = "0x5431530", VA = "0x185432F30", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public (T1, T2) IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x54345E0", Offset = "0x5432BE0", VA = "0x1854345E0")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5435060", Offset = "0x5433660", VA = "0x185435060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T1 FIIDBBKBJAK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x54347C0", Offset = "0x5432DC0", VA = "0x1854347C0")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5434080", Offset = "0x5432680", VA = "0x185434080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T1 PMPIPFKEPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5433AE0", Offset = "0x54320E0", VA = "0x185433AE0")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T1 PCGLKOMCHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5433AE0", Offset = "0x54320E0", VA = "0x185433AE0")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5434080", Offset = "0x5432680", VA = "0x185434080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T2 DFAGJFBKAIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5434020", Offset = "0x5432620", VA = "0x185434020")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x54335D0", Offset = "0x5431BD0", VA = "0x1854335D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T2 NOLGPJDIMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5434670", Offset = "0x5432C70", VA = "0x185434670")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public T2 GOIANJIJLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5434670", Offset = "0x5432C70", VA = "0x185434670")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x54335D0", Offset = "0x5431BD0", VA = "0x1854335D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KNHBKMLJACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4D23430", Offset = "0x4D21A30", VA = "0x184D23430", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x51A0AD0", Offset = "0x519F0D0", VA = "0x1851A0AD0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5434C30", Offset = "0x5433230", VA = "0x185434C30", Slot = "10")]
	public void MGCNIAHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5435560", Offset = "0x5433B60", VA = "0x185435560")]
	public LNNMKIHBLCP([In] JAAHDJDPHDD ACJFHCNBBBO, T1 PIJKLJHFAPF, T2 DAKEJFEDPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x54334E0", Offset = "0x5431AE0", VA = "0x1854334E0")]
	private void BELDMCKIGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x54351F0", Offset = "0x54337F0", VA = "0x1854351F0")]
	public void PDIDLFIJKBI(T1 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x54330A0", Offset = "0x54316A0", VA = "0x1854330A0")]
	public void ANMBIEBBHNN(T1 BDCANBKHLCN, T2 BAHEFLJIMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x54354B0", Offset = "0x5433AB0", VA = "0x1854354B0", Slot = "5")]
	private void POAHNDOFCCF((T1, T2) JIJNMCDLDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4D236F0", Offset = "0x4D21CF0", VA = "0x184D236F0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class GAJBHFCBCHP<T1, T2, T3> : CGCFLKDJHJD<(T1, T2, T3)>, GHKEJBEBCML, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly ILAABNBKNBE<T1, T2, T3> ODGENDEEDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly ILAABNBKNBE<T1, T2, T3> JCPPFIBJKAL;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string MBLBFBKCCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xE9BFF0", Offset = "0xE9A5F0", VA = "0x180E9BFF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool AAFPACIGJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4D24830", Offset = "0x4D22E30", VA = "0x184D24830", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool PKBPPOIJBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4D246B0", Offset = "0x4D22CB0", VA = "0x184D246B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool IJKPHNBIEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4D24BF0", Offset = "0x4D231F0", VA = "0x184D24BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool AHHMIJOHOKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4D24D70", Offset = "0x4D23370", VA = "0x184D24D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public (T1, T2, T3) KAKPIICKODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4D23D50", Offset = "0x4D22350", VA = "0x184D23D50", Slot = "11")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4D23550", Offset = "0x4D21B50", VA = "0x184D23550", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public (T1, T2, T3) IOCMOENJJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4D23890", Offset = "0x4D21E90", VA = "0x184D23890", Slot = "4")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4D23020", Offset = "0x4D21620", VA = "0x184D23020", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T1 FIIDBBKBJAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4D247A0", Offset = "0x4D22DA0", VA = "0x184D247A0")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T1 PMPIPFKEPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4D23730", Offset = "0x4D21D30", VA = "0x184D23730")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T1 PCGLKOMCHJC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4D23730", Offset = "0x4D21D30", VA = "0x184D23730")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4D23E70", Offset = "0x4D22470", VA = "0x184D23E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T2 DFAGJFBKAIC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4D23AD0", Offset = "0x4D220D0", VA = "0x184D23AD0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T2 NOLGPJDIMDB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4D244F0", Offset = "0x4D22AF0", VA = "0x184D244F0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T2 GOIANJIJLAO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4D244F0", Offset = "0x4D22AF0", VA = "0x184D244F0")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4D23400", Offset = "0x4D21A00", VA = "0x184D23400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public T3 OGOEMGDOMJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4D23EA0", Offset = "0x4D224A0", VA = "0x184D23EA0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public T3 BFHKHOKEJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4D247E0", Offset = "0x4D22DE0", VA = "0x184D247E0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public T3 JJNDGNJFCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4D247E0", Offset = "0x4D22DE0", VA = "0x184D247E0")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4D241F0", Offset = "0x4D227F0", VA = "0x184D241F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool KNHBKMLJACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4D23430", Offset = "0x4D21A30", VA = "0x184D23430", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4D24B70", Offset = "0x4D23170", VA = "0x184D24B70", Slot = "10")]
	public void MGCNIAHBIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x4D25700", Offset = "0x4D23D00", VA = "0x184D25700")]
	public GAJBHFCBCHP([In] JAAHDJDPHDD ACJFHCNBBBO, T1 PIJKLJHFAPF, T2 DAKEJFEDPNL, T3 EOMFMCFGEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4D23100", Offset = "0x4D21700", VA = "0x184D23100")]
	private void BELDMCKIGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x4D24FE0", Offset = "0x4D235E0", VA = "0x184D24FE0")]
	public void PDIDLFIJKBI(T1 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4D23EF0", Offset = "0x4D224F0", VA = "0x184D23EF0")]
	public void IDFCNAJJLOO(T2 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4D24220", Offset = "0x4D22820", VA = "0x184D24220")]
	public void JEDCEEGDNLK(T3 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4D230C0", Offset = "0x4D216C0", VA = "0x184D230C0")]
	public void ANMBIEBBHNN(T1 BDCANBKHLCN, T2 BAHEFLJIMEE, T3 ILJLFJGHHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4D24AC0", Offset = "0x4D230C0", VA = "0x184D24AC0", Slot = "5")]
	private void MBLMFCLOOEE((T1, T2, T3) JIJNMCDLDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4D236F0", Offset = "0x4D21CF0", VA = "0x184D236F0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class JHCDEGDACCB<T1, T2, T3, T4> : CGCFLKDJHJD<(T1, T2, T3, T4)>, GHKEJBEBCML, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly BKPGBFJDCMG<T1, T2, T3, T4> ODGENDEEDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly BKPGBFJDCMG<T1, T2, T3, T4> JCPPFIBJKAL;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string MBLBFBKCCDA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xE9BFF0", Offset = "0xE9A5F0", VA = "0x180E9BFF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public (T1, T2, T3, T4) IOCMOENJJEI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x51A0820", Offset = "0x519EE20", VA = "0x1851A0820", Slot = "4")]
		get
		{
			return default((T1, T2, T3, T4));
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x51A03E0", Offset = "0x519E9E0", VA = "0x1851A03E0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public T2 NOLGPJDIMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x51A0AF0", Offset = "0x519F0F0", VA = "0x1851A0AF0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T3 BFHKHOKEJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x51A0B30", Offset = "0x519F130", VA = "0x1851A0B30")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public T4 DKMBEBDCLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4F8CCA0", Offset = "0x4F8B2A0", VA = "0x184F8CCA0")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool KNHBKMLJACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4D23430", Offset = "0x4D21A30", VA = "0x184D23430", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x51A0AD0", Offset = "0x519F0D0", VA = "0x1851A0AD0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x51A0DA0", Offset = "0x519F3A0", VA = "0x1851A0DA0")]
	public JHCDEGDACCB([In] JAAHDJDPHDD ACJFHCNBBBO, T1 PIJKLJHFAPF, T2 DAKEJFEDPNL, T3 EOMFMCFGEMA, T4 HBOHMLAJMCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x51A0520", Offset = "0x519EB20", VA = "0x1851A0520")]
	private void BELDMCKIGIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x51A0B70", Offset = "0x519F170", VA = "0x1851A0B70")]
	public void PDIDLFIJKBI(T1 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x51A04D0", Offset = "0x519EAD0", VA = "0x1851A04D0")]
	public void ANMBIEBBHNN(T1 BDCANBKHLCN, T2 BAHEFLJIMEE, T3 ILJLFJGHHGE, T4 GIHDEHAHILA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x51A07E0", Offset = "0x519EDE0", VA = "0x1851A07E0", Slot = "5")]
	private void FGFCBHNPGLF((T1, T2, T3, T4) JIJNMCDLDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4D236F0", Offset = "0x4D21CF0", VA = "0x184D236F0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OMBHMCNJLMM
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x80FB6A0", Offset = "0x80F9CA0", VA = "0x1880FB6A0")]
	public static string FJCMFMKIHNA(this JAAHDJDPHDD ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xC8CD50", Offset = "0xC8B350", VA = "0x180C8CD50")]
	public static ANAOEMGACFC IGHIHJKLLFH(this JAAHDJDPHDD ACJFHCNBBBO)
	{
		return default(ANAOEMGACFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PCAJFFHOLPJ<T> : DNJIFFPHIJN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x479B090", Offset = "0x4799690", VA = "0x18479B090")]
	public PCAJFFHOLPJ([In] JAAHDJDPHDD ACJFHCNBBBO, T COMAGLLDBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x58ABA00", Offset = "0x58AA000", VA = "0x1858ABA00")]
	public PCAJFFHOLPJ(AKKKLPFJHDO HILCMKALFIH, KNOJHPOMDED OPOGJMFOAFI, string BLIBAMJKLIA, T COMAGLLDBOM, ANAOEMGACFC BCHDIMAAIFO, [Optional] Action BNOBGIHHJGL, [Optional] PGACPMGFNLA HEIMECNKEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x58ADB20", Offset = "0x58AC120", VA = "0x1858ADB20")]
	public PCAJFFHOLPJ(AKKKLPFJHDO HILCMKALFIH, string BLIBAMJKLIA, T COMAGLLDBOM, ANAOEMGACFC BCHDIMAAIFO, [Optional] Action BNOBGIHHJGL, [Optional] PGACPMGFNLA HEIMECNKEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x58AD390", Offset = "0x58AB990", VA = "0x1858AD390")]
	public PCAJFFHOLPJ(AKKKLPFJHDO HILCMKALFIH, string BLIBAMJKLIA, T COMAGLLDBOM, ANAOEMGACFC BCHDIMAAIFO, bool KPBHAILFOEH, [Optional] Action BNOBGIHHJGL, [Optional] PGACPMGFNLA HEIMECNKEFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DHDJAHBANDN<T1, T2> : AJJCCDANMLA<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8B10", Offset = "0x6CD7110", VA = "0x186CD8B10")]
	public DHDJAHBANDN([In] JAAHDJDPHDD ACJFHCNBBBO, T1 CLGOGHFJOAG, T2 KEBLJFEHFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6CD9590", Offset = "0x6CD7B90", VA = "0x186CD9590")]
	public DHDJAHBANDN(AKKKLPFJHDO HILCMKALFIH, KNOJHPOMDED OPOGJMFOAFI, string BLIBAMJKLIA, T1 CLGOGHFJOAG, T2 KEBLJFEHFFE, ANAOEMGACFC BCHDIMAAIFO, [Optional] Action BNOBGIHHJGL, [Optional] PGACPMGFNLA HEIMECNKEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6CDBF00", Offset = "0x6CDA500", VA = "0x186CDBF00")]
	public DHDJAHBANDN(AKKKLPFJHDO HILCMKALFIH, string BLIBAMJKLIA, T1 CLGOGHFJOAG, T2 KEBLJFEHFFE, ANAOEMGACFC BCHDIMAAIFO, [Optional] Action BNOBGIHHJGL, [Optional] PGACPMGFNLA HEIMECNKEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8930", Offset = "0x6CD6F30", VA = "0x186CD8930")]
	public DHDJAHBANDN(AKKKLPFJHDO HILCMKALFIH, string BLIBAMJKLIA, T1 CLGOGHFJOAG, T2 KEBLJFEHFFE, ANAOEMGACFC BCHDIMAAIFO, bool KPBHAILFOEH, [Optional] Action BNOBGIHHJGL, [Optional] PGACPMGFNLA HEIMECNKEFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ILAABNBKNBE<T1, T2, T3> : CCCDMHDAPBO<T1, T2, T3>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4C51A00", Offset = "0x4C50000", VA = "0x184C51A00")]
	public ILAABNBKNBE([In] JAAHDJDPHDD ACJFHCNBBBO, T1 CLGOGHFJOAG, T2 KEBLJFEHFFE, T3 LDBHNKBAOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4F722E0", Offset = "0x4F708E0", VA = "0x184F722E0")]
	public ILAABNBKNBE(AKKKLPFJHDO HILCMKALFIH, string BLIBAMJKLIA, T1 CLGOGHFJOAG, T2 KEBLJFEHFFE, T3 LDBHNKBAOLC, ANAOEMGACFC BCHDIMAAIFO, [Optional] Action BNOBGIHHJGL, [Optional] PGACPMGFNLA HEIMECNKEFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BKPGBFJDCMG<T1, T2, T3, T4> : EFLMLHGABHL<T1, T2, T3, T4>
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x620C200", Offset = "0x620A800", VA = "0x18620C200")]
	public BKPGBFJDCMG([In] JAAHDJDPHDD ACJFHCNBBBO, T1 CLGOGHFJOAG, T2 KEBLJFEHFFE, T3 LDBHNKBAOLC, T4 DFHLLNPIBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x620C0D0", Offset = "0x620A6D0", VA = "0x18620C0D0")]
	public BKPGBFJDCMG(AKKKLPFJHDO HILCMKALFIH, KNOJHPOMDED OPOGJMFOAFI, string BLIBAMJKLIA, T1 CLGOGHFJOAG, T2 KEBLJFEHFFE, T3 LDBHNKBAOLC, T4 DFHLLNPIBJG, ANAOEMGACFC BCHDIMAAIFO, [Optional] Action BNOBGIHHJGL, [Optional] PGACPMGFNLA HEIMECNKEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x620C470", Offset = "0x620AA70", VA = "0x18620C470")]
	public BKPGBFJDCMG(AKKKLPFJHDO HILCMKALFIH, string BLIBAMJKLIA, T1 CLGOGHFJOAG, T2 KEBLJFEHFFE, T3 LDBHNKBAOLC, T4 DFHLLNPIBJG, ANAOEMGACFC BCHDIMAAIFO, [Optional] Action BNOBGIHHJGL, [Optional] PGACPMGFNLA HEIMECNKEFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class ELDEKMFJPEF<T1, T2, T3, T4, T5> : HJOOCANBAFJ<T1, T2, T3, T4, T5>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4791660", Offset = "0x478FC60", VA = "0x184791660")]
	public ELDEKMFJPEF(AKKKLPFJHDO HILCMKALFIH, KNOJHPOMDED OPOGJMFOAFI, string BLIBAMJKLIA, T1 CLGOGHFJOAG, T2 KEBLJFEHFFE, T3 LDBHNKBAOLC, T4 DFHLLNPIBJG, T5 AODBAPDMBCI, ANAOEMGACFC BCHDIMAAIFO, [Optional] Action BNOBGIHHJGL, [Optional] PGACPMGFNLA HEIMECNKEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4791AE0", Offset = "0x47900E0", VA = "0x184791AE0")]
	public ELDEKMFJPEF(AKKKLPFJHDO HILCMKALFIH, string BLIBAMJKLIA, T1 CLGOGHFJOAG, T2 KEBLJFEHFFE, T3 LDBHNKBAOLC, T4 DFHLLNPIBJG, T5 AODBAPDMBCI, ANAOEMGACFC BCHDIMAAIFO, [Optional] Action BNOBGIHHJGL, [Optional] PGACPMGFNLA HEIMECNKEFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BHKIBKFHBJG<T> : DNJIFFPHIJN<T>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x61F9570", Offset = "0x61F7B70", VA = "0x1861F9570")]
	public BHKIBKFHBJG(KNOJHPOMDED OPOGJMFOAFI, string BLIBAMJKLIA, T COMAGLLDBOM, [Optional] Action BNOBGIHHJGL, [Optional] PGACPMGFNLA HEIMECNKEFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class POMIGODLEFF<T1, T2> : AJJCCDANMLA<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5902260", Offset = "0x5900860", VA = "0x185902260")]
	public POMIGODLEFF(KNOJHPOMDED OPOGJMFOAFI, string BLIBAMJKLIA, T1 GCPFDHKMDNO, T2 OKIHLJNCMKP, [Optional] Action BNOBGIHHJGL, [Optional] PGACPMGFNLA HEIMECNKEFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface LNIIPDFDGCM
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PCAJFFHOLPJ<T1> NCFCJMANFMF<T1>(string BLIBAMJKLIA, T1 GCPFDHKMDNO, ANAOEMGACFC BCHDIMAAIFO, [Optional] Action BNOBGIHHJGL);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ALKAGDHECKL : LNIIPDFDGCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly PGACPMGFNLA HEIMECNKEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly AKKKLPFJHDO HILCMKALFIH;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xA4BEA0", Offset = "0xA4A4A0", VA = "0x180A4BEA0")]
	public ALKAGDHECKL(PGACPMGFNLA HEIMECNKEFI, AKKKLPFJHDO FAFBOAAFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x30BBF80", Offset = "0x30BA580", VA = "0x1830BBF80", Slot = "4")]
	public PCAJFFHOLPJ<T1> NCFCJMANFMF<T1>(string BLIBAMJKLIA, T1 GCPFDHKMDNO, ANAOEMGACFC BCHDIMAAIFO, [Optional] Action BNOBGIHHJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HGKLMBMDGIA : AKKKLPFJHDO
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ViewId DALNOMNLOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AKKKLPFJHDO
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool HOEAJNHFPBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool HMAKFNKAJGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string JNDIDGCJFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool AHPAHHDPEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RegisterDestroyHandler(HHDDIJLLDKI NKIIOMEEMNC);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UnregisterDestroyHandler(HHDDIJLLDKI NKIIOMEEMNC);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class ANJIFEFPALO
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x80F72C0", Offset = "0x80F58C0", VA = "0x1880F72C0")]
	public static bool IBMCNFKNOGJ(this AKKKLPFJHDO HILCMKALFIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PGACPMGFNLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	KNOJHPOMDED BINJEDHCNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool PHFOHDOOMGA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool HPIFIPBBDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FLMOPKJJIJF();

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object AEGJGOCDNMF(string BLIBAMJKLIA);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	object MKKGKIONJGG(KNOJHPOMDED DKKOHDCAINF, string BLIBAMJKLIA);

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void POKGIEHGABK(string BLIBAMJKLIA, object FHKIBFJAKOF);

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MFKKAFLKIPH(KNOJHPOMDED DKKOHDCAINF, string BLIBAMJKLIA, object FHKIBFJAKOF);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DEMDENIAEFA<T>(string BLIBAMJKLIA, T KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GBICALECOGB([CanBeNull] KNOJHPOMDED DKKOHDCAINF, string BLIBAMJKLIA, NDHHNCBIOLC MCOEHGFIIFM);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OBOKPHFEFHH([CanBeNull] KNOJHPOMDED DKKOHDCAINF, string BLIBAMJKLIA, NDHHNCBIOLC MCOEHGFIIFM);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "11")]
	T ILKGHMDNLAK<T>(object KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "12")]
	object PNGIMPPEKFO<T>(T COMAGLLDBOM);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KOEDDEKICGG();

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IFNJIJLOBGJ();

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NHFNEBAIHBC(string GDFBBGHAAKG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JAAHDJDPHDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public KNOJHPOMDED OPOGJMFOAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public AKKKLPFJHDO HILCMKALFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public string BLIBAMJKLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public ANAOEMGACFC BCHDIMAAIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool KPBHAILFOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action BNOBGIHHJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public PGACPMGFNLA HEIMECNKEFI;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x80F7360", Offset = "0x80F5960", VA = "0x1880F7360")]
	public JAAHDJDPHDD(JAAHDJDPHDD HOPHFOOKMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x80F73E0", Offset = "0x80F59E0", VA = "0x1880F73E0")]
	public JAAHDJDPHDD(AKKKLPFJHDO HILCMKALFIH, string BLIBAMJKLIA, ANAOEMGACFC BCHDIMAAIFO, [Optional] Action BNOBGIHHJGL, [Optional] PGACPMGFNLA HEIMECNKEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x80F7310", Offset = "0x80F5910", VA = "0x1880F7310")]
	public static JAAHDJDPHDD APGCMCCAODE(AKKKLPFJHDO HILCMKALFIH, string BLIBAMJKLIA, ANAOEMGACFC BCHDIMAAIFO, [Optional] Action BNOBGIHHJGL, [Optional] PGACPMGFNLA HEIMECNKEFI)
	{
		return default(JAAHDJDPHDD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MJOKODAEOIG
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D7C0", Offset = "0x3C1BDC0", VA = "0x183C1D7C0")]
	public static PCAJFFHOLPJ<T> LPINAPHCKBL<T>(this JAAHDJDPHDD ACJFHCNBBBO, T COMAGLLDBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D670", Offset = "0x3C1BC70", VA = "0x183C1D670")]
	public static DHDJAHBANDN<T1, T2> LPINAPHCKBL<T1, T2>(this JAAHDJDPHDD ACJFHCNBBBO, T1 NDDDEBGGIIG, T2 BPOPIONNANE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D710", Offset = "0x3C1BD10", VA = "0x183C1D710")]
	public static ILAABNBKNBE<T1, T2, T3> LPINAPHCKBL<T1, T2, T3>(this JAAHDJDPHDD ACJFHCNBBBO, T1 NDDDEBGGIIG, T2 BPOPIONNANE, T3 NGNBGGFBOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3C1DA80", Offset = "0x3C1C080", VA = "0x183C1DA80")]
	public static BKPGBFJDCMG<T1, T2, T3, T4> LPINAPHCKBL<T1, T2, T3, T4>(this JAAHDJDPHDD ACJFHCNBBBO, T1 NDDDEBGGIIG, T2 BPOPIONNANE, T3 NGNBGGFBOJN, T4 EDFJLLFAKMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D7C0", Offset = "0x3C1BDC0", VA = "0x183C1D7C0")]
	public static NDPGCICHFBP<T> BAEPNNDLLDA<T>(this JAAHDJDPHDD ACJFHCNBBBO, T COMAGLLDBOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D670", Offset = "0x3C1BC70", VA = "0x183C1D670")]
	public static LNNMKIHBLCP<T1, T2> BAEPNNDLLDA<T1, T2>(this JAAHDJDPHDD ACJFHCNBBBO, T1 NDDDEBGGIIG, T2 BPOPIONNANE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D710", Offset = "0x3C1BD10", VA = "0x183C1D710")]
	public static GAJBHFCBCHP<T1, T2, T3> BAEPNNDLLDA<T1, T2, T3>(this JAAHDJDPHDD ACJFHCNBBBO, T1 NDDDEBGGIIG, T2 BPOPIONNANE, T3 NGNBGGFBOJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3C1DA80", Offset = "0x3C1C080", VA = "0x183C1DA80")]
	public static JHCDEGDACCB<T1, T2, T3, T4> BAEPNNDLLDA<T1, T2, T3, T4>(this JAAHDJDPHDD ACJFHCNBBBO, T1 NDDDEBGGIIG, T2 BPOPIONNANE, T3 NGNBGGFBOJN, T4 EDFJLLFAKMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class NDHHNCBIOLC : HHDDIJLLDKI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[Flags]
	private enum AJJNCODAEDH
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
	private static Stack<PGACPMGFNLA> OFNFKNJHHHI;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static bool NIBDLHBEFDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly KNOJHPOMDED OPOGJMFOAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly AKKKLPFJHDO HILCMKALFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly string BLIBAMJKLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly ANAOEMGACFC BCHDIMAAIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly Action BNOBGIHHJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected PGACPMGFNLA HGGEKJIKMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private AJJNCODAEDH ENCLHPAOMCM;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static PGACPMGFNLA MHAKHPNDKMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x80FB080", Offset = "0x80F9680", VA = "0x1880FB080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool NJKJFECKHOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x80FAD70", Offset = "0x80F9370", VA = "0x1880FAD70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x80FAD10", Offset = "0x80F9310", VA = "0x1880FAD10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private bool PJGFAJDJBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x80FAD00", Offset = "0x80F9300", VA = "0x1880FAD00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x80FAD80", Offset = "0x80F9380", VA = "0x1880FAD80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private bool LEIOONPDGMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x80FADA0", Offset = "0x80F93A0", VA = "0x1880FADA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x80FAD30", Offset = "0x80F9330", VA = "0x1880FAD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool KNHBKMLJACB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x80FA490", Offset = "0x80F8A90", VA = "0x1880FA490")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x80FAE60", Offset = "0x80F9460", VA = "0x1880FAE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected virtual object LCIJJPPIHFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA4C4B0", Offset = "0xA4AAB0", VA = "0x180A4C4B0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool LLBMPJCMJNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x80F9F20", Offset = "0x80F8520", VA = "0x1880F9F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int KKHIIPNPKOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xDF43F0", Offset = "0xDF29F0", VA = "0x180DF43F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xF3AC20", Offset = "0xF39220", VA = "0x180F3AC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string MBLBFBKCCDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool PHFOHDOOMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x80FA7C0", Offset = "0x80F8DC0", VA = "0x1880FA7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x80FA4A0", Offset = "0x80F8AA0", VA = "0x1880FA4A0")]
	public static void DMCGLGBHBFN(PGACPMGFNLA CDMMBEDGJLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool EAIGADGKPAD();

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x80FB480", Offset = "0x80F9A80", VA = "0x1880FB480")]
	protected NDHHNCBIOLC(KNOJHPOMDED OPOGJMFOAFI, AKKKLPFJHDO HILCMKALFIH, string BLIBAMJKLIA, ANAOEMGACFC BCHDIMAAIFO, Action BNOBGIHHJGL, PGACPMGFNLA HEIMECNKEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x80FAAB0", Offset = "0x80F90B0", VA = "0x1880FAAB0", Slot = "1")]
	~NDHHNCBIOLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x80FA5A0", Offset = "0x80F8BA0", VA = "0x1880FA5A0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x80FADB0", Offset = "0x80F93B0", VA = "0x1880FADB0")]
	private void LGACCCKPPOD(bool GGACBKHEIEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x80F9DB0", Offset = "0x80F83B0", VA = "0x1880F9DB0")]
	private object ALFGAPIFLPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x80FA8F0", Offset = "0x80F8EF0", VA = "0x1880FA8F0")]
	protected void FLMOPKJJIJF(bool KPBHAILFOEH, object ALPLAIPHAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x80FA130", Offset = "0x80F8730", VA = "0x1880FA130")]
	protected void BNAKHNGOEHD(object FHKIBFJAKOF, bool HACAHKDJNGL = true, bool PBILMPLDEOP = false, bool NONBBMCKGBM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x80FA240", Offset = "0x80F8840", VA = "0x1880FA240")]
	protected void CNEOCJHNEMO(object FHKIBFJAKOF, bool EDBINLPEOFD, bool HACAHKDJNGL, bool PBILMPLDEOP = false, bool NONBBMCKGBM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x80FB240", Offset = "0x80F9840", VA = "0x1880FB240")]
	internal void OPEPCFEDANA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x80FA540", Offset = "0x80F8B40", VA = "0x1880FA540")]
	private void DMLNOOEOLCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x80FA170", Offset = "0x80F8770", VA = "0x1880FA170")]
	private void BPFPELFHCLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x80FA1D0", Offset = "0x80F87D0", VA = "0x1880FA1D0", Slot = "4")]
	private void CEJCCDDFFIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x80FACF0", Offset = "0x80F92F0", VA = "0x1880FACF0", Slot = "5")]
	private void GOPNLEJPDOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x80FABB0", Offset = "0x80F91B0", VA = "0x1880FABB0")]
	public bool GFGLGIECJNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x80F9F70", Offset = "0x80F8570", VA = "0x1880F9F70")]
	public bool BDKDLNBPGNI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x80FB0F0", Offset = "0x80F96F0", VA = "0x1880FB0F0")]
	private bool ODNPAPCOKHL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x80FA710", Offset = "0x80F8D10", VA = "0x1880FA710")]
	internal void EAKOEIELIKA(object FHKIBFJAKOF, int MLFDCAHLDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x80FB2C0", Offset = "0x80F98C0", VA = "0x1880FB2C0")]
	private void PLBDFLELFKP(object FHKIBFJAKOF, bool PBILMPLDEOP, bool NONBBMCKGBM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x80FAE50", Offset = "0x80F9450", VA = "0x1880FAE50")]
	private bool LMKPFDLBMGB(AJJNCODAEDH MGNCINIDNEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x80FAD50", Offset = "0x80F9350", VA = "0x1880FAD50")]
	private void IKEKIEEAOEG(AJJNCODAEDH MGNCINIDNEO, bool KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x80FAB10", Offset = "0x80F9110", VA = "0x1880FAB10")]
	public static string GCOOPKOPCDA(KNOJHPOMDED OPOGJMFOAFI, string BLIBAMJKLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x80FA810", Offset = "0x80F8E10", VA = "0x1880FA810")]
	public static string FIGFJELOIFB(AKKKLPFJHDO HILCMKALFIH, string BLIBAMJKLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x80FAF20", Offset = "0x80F9520", VA = "0x1880FAF20")]
	public static bool MFJMFOBGNNO(object DLGEPLKGJOC, object OKKFDNDPGLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class LIADNKHBFAD : PGACPMGFNLA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly Dictionary<object, object> ELMOEGLKFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly List<string> EMFEPNDJMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly Dictionary<object, object> ONFCAJJDLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<string> GFAGIGCMJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool IPJFEJDAGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	protected readonly Dictionary<string, object> DMAOPMMBGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	protected readonly Dictionary<KNOJHPOMDED, Dictionary<string, object>> CCOKKPJECCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<string> OPJPMNNAPJB;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public abstract Dictionary<object, object> HBMLMJFHOAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public abstract int ELCDPFPIFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public abstract KNOJHPOMDED BINJEDHCNNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public abstract bool PHFOHDOOMGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public abstract bool HPIFIPBBDGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual bool IJPEEHAOFMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA603F0", Offset = "0xA5E9F0", VA = "0x180A603F0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool FLBBOPEIKLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA73440", Offset = "0xA71A40", VA = "0x180A73440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3BF8AD0", Offset = "0x3BF70D0", VA = "0x183BF8AD0", Slot = "12")]
	public void DEMDENIAEFA<T>(string BLIBAMJKLIA, T KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x80F90D0", Offset = "0x80F76D0", VA = "0x1880F90D0", Slot = "11")]
	public void MFKKAFLKIPH(KNOJHPOMDED OPOGJMFOAFI, string BLIBAMJKLIA, object KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x80F91B0", Offset = "0x80F77B0", VA = "0x1880F91B0", Slot = "9")]
	public object MKKGKIONJGG(KNOJHPOMDED OPOGJMFOAFI, string BLIBAMJKLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x80F9A60", Offset = "0x80F8060", VA = "0x1880F9A60", Slot = "10")]
	public void POKGIEHGABK(string BLIBAMJKLIA, object KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x80F7570", Offset = "0x80F5B70", VA = "0x1880F7570", Slot = "8")]
	public object AEGJGOCDNMF(string BLIBAMJKLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x80F8390", Offset = "0x80F6990", VA = "0x1880F8390", Slot = "13")]
	public void GBICALECOGB(KNOJHPOMDED DKKOHDCAINF, string BLIBAMJKLIA, NDHHNCBIOLC MCOEHGFIIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x80F9530", Offset = "0x80F7B30", VA = "0x1880F9530", Slot = "14")]
	public void OBOKPHFEFHH(KNOJHPOMDED DKKOHDCAINF, string BLIBAMJKLIA, NDHHNCBIOLC MCOEHGFIIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x80F8C50", Offset = "0x80F7250", VA = "0x1880F8C50")]
	private void JKIBCCDBGPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x80F8C00", Offset = "0x80F7200", VA = "0x1880F8C00")]
	private void JAHMKHCGHLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x80F8640", Offset = "0x80F6C40", VA = "0x1880F8640")]
	private void ICPGJCEEGLN(KNOJHPOMDED OPOGJMFOAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x80F7A00", Offset = "0x80F6000", VA = "0x1880F7A00")]
	protected void BNPHHDIAGDP(KNOJHPOMDED KCLMDJCLHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x80F8550", Offset = "0x80F6B50", VA = "0x1880F8550")]
	protected void HFEPLOKBHLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x80F8540", Offset = "0x80F6B40", VA = "0x1880F8540")]
	protected void GPCOGLKAHDI(IDictionary<object, object> MLFGAKLFDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x80F8ED0", Offset = "0x80F74D0", VA = "0x1880F8ED0")]
	protected void KFGAPLEDIJL(KNOJHPOMDED BIMDGEMNEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x80F8300", Offset = "0x80F6900", VA = "0x1880F8300")]
	protected void FHMBMMADOHN(KNOJHPOMDED OPOGJMFOAFI, IDictionary<object, object> MLFGAKLFDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x80F8780", Offset = "0x80F6D80", VA = "0x1880F8780")]
	private void IGCGJDOPDPC(IDictionary<object, object> MLFGAKLFDHK, Dictionary<string, object> KLADPFANOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x80F77F0", Offset = "0x80F5DF0", VA = "0x1880F77F0")]
	private static void BKJMJGENMPP(object PEANKNNKPHC, object PJAMOIBNMIO, int MLFDCAHLDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x80F7B30", Offset = "0x80F6130", VA = "0x1880F7B30")]
	private static void DADAKHOAOPF(Dictionary<string, object> KLADPFANOLM, string BLIBAMJKLIA, NDHHNCBIOLC MCOEHGFIIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x80F7610", Offset = "0x80F5C10", VA = "0x1880F7610")]
	private static void BFNHAECEBKK(Dictionary<string, object> KLADPFANOLM, string BLIBAMJKLIA, NDHHNCBIOLC MCOEHGFIIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x80F8F40", Offset = "0x80F7540", VA = "0x1880F8F40", Slot = "17")]
	public void KOEDDEKICGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "27")]
	protected abstract void KLPCGKBCEMK(Dictionary<object, object> ELMOEGLKFLM);

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x80F86A0", Offset = "0x80F6CA0", VA = "0x1880F86A0", Slot = "18")]
	public void IFNJIJLOBGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	protected abstract void ONBLDPPNFKI(Dictionary<object, object> ONFCAJJDLFI);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x80F8CA0", Offset = "0x80F72A0", VA = "0x1880F8CA0")]
	private void JPGLFEFJCEB(Dictionary<object, object> EEECIHBJBBL, List<string> GFACEPCMFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x80F97E0", Offset = "0x80F7DE0", VA = "0x1880F97E0")]
	private void OCFBEEEJFEM(IDictionary<object, object> MLFGAKLFDHK, [Out] int MLFDCAHLDHP, [Out] string[] PCLJDMJKBMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x80F9040", Offset = "0x80F7640", VA = "0x1880F9040")]
	public void LCGOKOFEABP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x80F7EC0", Offset = "0x80F64C0", VA = "0x1880F7EC0")]
	public void EDILFIEGHIL(KNOJHPOMDED OPOGJMFOAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x80F7F90", Offset = "0x80F6590", VA = "0x1880F7F90")]
	public void EFEBKFOGKKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "29")]
	protected abstract HashSet<int> EGNFMPKCDMJ(bool CIOOLJDDDEB, bool NNDGMEBEDKK);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x80F92A0", Offset = "0x80F78A0", VA = "0x1880F92A0", Slot = "19")]
	public void NHFNEBAIHBC(string GDFBBGHAAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x80F84A0", Offset = "0x80F6AA0", VA = "0x1880F84A0")]
	protected string GCOOPKOPCDA(KNOJHPOMDED OPOGJMFOAFI, string BLIBAMJKLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract object PNGIMPPEKFO<T>(T KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract T ILKGHMDNLAK<T>(object KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "32")]
	public virtual void FLMOPKJJIJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x80F7D60", Offset = "0x80F6360", VA = "0x1880F7D60", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "33")]
	protected virtual void OAFCFLGCIFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x80F9B80", Offset = "0x80F8180", VA = "0x1880F9B80")]
	protected LIADNKHBFAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class DNJIFFPHIJN<T1> : NDHHNCBIOLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T1 GCPFDHKMDNO;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	protected virtual T1 HPFJBKJPLLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x118DBF0", Offset = "0x118C1F0", VA = "0x18118DBF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x118DC10", Offset = "0x118C210", VA = "0x18118DC10", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	protected override object LCIJJPPIHFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4777E40", Offset = "0x4776440", VA = "0x184777E40", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6D363C0", Offset = "0x6D349C0", VA = "0x186D363C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D34B10", Offset = "0x6D33110", VA = "0x186D34B10", Slot = "9")]
	protected override bool EAIGADGKPAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D36CB0", Offset = "0x6D352B0", VA = "0x186D36CB0")]
	protected DNJIFFPHIJN([In] JAAHDJDPHDD ACJFHCNBBBO, T1 GCPFDHKMDNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6D381C0", Offset = "0x6D367C0", VA = "0x186D381C0")]
	protected DNJIFFPHIJN(KNOJHPOMDED OPOGJMFOAFI, AKKKLPFJHDO HILCMKALFIH, string BLIBAMJKLIA, T1 GCPFDHKMDNO, ANAOEMGACFC BCHDIMAAIFO, bool KPBHAILFOEH, Action BNOBGIHHJGL, PGACPMGFNLA HEIMECNKEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x477E5D0", Offset = "0x477CBD0", VA = "0x18477E5D0")]
	public T1 KBGIPADPFGF()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6D31FB0", Offset = "0x6D305B0", VA = "0x186D31FB0")]
	public void BNAKHNGOEHD(T1 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6D33260", Offset = "0x6D31860", VA = "0x186D33260")]
	public void BNAKHNGOEHD(T1 FHKIBFJAKOF, bool HACAHKDJNGL, bool PBILMPLDEOP = false, bool NONBBMCKGBM = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class AJJCCDANMLA<T1, T2> : NDHHNCBIOLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private T1 GCPFDHKMDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T2 OKIHLJNCMKP;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	protected virtual T1 HPFJBKJPLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xF959D0", Offset = "0xF93FD0", VA = "0x180F959D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x118DC00", Offset = "0x118C200", VA = "0x18118DC00", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	protected virtual T2 INMGDHGCMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xF8C6B0", Offset = "0xF8ACB0", VA = "0x180F8C6B0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xF95170", Offset = "0xF93770", VA = "0x180F95170", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public T2 GEOGKGFCCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x477E680", Offset = "0x477CC80", VA = "0x18477E680")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	protected override object LCIJJPPIHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4777E40", Offset = "0x4776440", VA = "0x184777E40", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4E76440", Offset = "0x4E74A40", VA = "0x184E76440", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4E75500", Offset = "0x4E73B00", VA = "0x184E75500", Slot = "9")]
	protected override bool EAIGADGKPAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4E79A00", Offset = "0x4E78000", VA = "0x184E79A00")]
	protected AJJCCDANMLA([In] JAAHDJDPHDD ACJFHCNBBBO, T1 GCPFDHKMDNO, T2 OKIHLJNCMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4E79D50", Offset = "0x4E78350", VA = "0x184E79D50")]
	protected AJJCCDANMLA(KNOJHPOMDED OPOGJMFOAFI, AKKKLPFJHDO HILCMKALFIH, string BLIBAMJKLIA, T1 GCPFDHKMDNO, T2 OKIHLJNCMKP, ANAOEMGACFC BCHDIMAAIFO, bool KPBHAILFOEH, Action BNOBGIHHJGL, PGACPMGFNLA HEIMECNKEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x477E5D0", Offset = "0x477CBD0", VA = "0x18477E5D0")]
	public T1 GBOKDFJNAPN()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4E77450", Offset = "0x4E75A50", VA = "0x184E77450")]
	public void LGHDDJDIPJE(T1 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x477E680", Offset = "0x477CC80", VA = "0x18477E680")]
	public T2 KDDNMBEJKGN()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4E77330", Offset = "0x4E75930", VA = "0x184E77330")]
	public void LACBPCPDIPK(T2 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x4E73190", Offset = "0x4E71790", VA = "0x184E73190")]
	public void BNAKHNGOEHD(T1 BDCANBKHLCN, T2 BAHEFLJIMEE, bool HACAHKDJNGL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class CCCDMHDAPBO<T1, T2, T3> : NDHHNCBIOLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private T1 GCPFDHKMDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T2 OKIHLJNCMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private T3 OLHEMOIFAOP;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	protected virtual T1 HPFJBKJPLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA50E70", Offset = "0xA4F470", VA = "0x180A50E70", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA50E20", Offset = "0xA4F420", VA = "0x180A50E20", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	protected virtual T2 INMGDHGCMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xFCE110", Offset = "0xFCC710", VA = "0x180FCE110", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xFCF350", Offset = "0xFCD950", VA = "0x180FCF350", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	protected virtual T3 CGICGLALGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA60400", Offset = "0xA5EA00", VA = "0x180A60400", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xD36FA0", Offset = "0xD355A0", VA = "0x180D36FA0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T1 NNLNKLEEIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x477E5D0", Offset = "0x477CBD0", VA = "0x18477E5D0")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T2 GEOGKGFCCHB
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x477E680", Offset = "0x477CC80", VA = "0x18477E680")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T3 PFILOGJIGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x477B700", Offset = "0x4779D00", VA = "0x18477B700")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected override object LCIJJPPIHFF
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4777E40", Offset = "0x4776440", VA = "0x184777E40", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x66C5110", Offset = "0x66C3710", VA = "0x1866C5110", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x66C4460", Offset = "0x66C2A60", VA = "0x1866C4460", Slot = "9")]
	protected override bool EAIGADGKPAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x66C6D10", Offset = "0x66C5310", VA = "0x1866C6D10")]
	protected CCCDMHDAPBO([In] JAAHDJDPHDD ACJFHCNBBBO, T1 GCPFDHKMDNO, T2 OKIHLJNCMKP, T3 OLHEMOIFAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x66C7C90", Offset = "0x66C6290", VA = "0x1866C7C90")]
	protected CCCDMHDAPBO(KNOJHPOMDED OPOGJMFOAFI, AKKKLPFJHDO HILCMKALFIH, string BLIBAMJKLIA, T1 GCPFDHKMDNO, T2 OKIHLJNCMKP, T3 OLHEMOIFAOP, ANAOEMGACFC BCHDIMAAIFO, bool KPBHAILFOEH, Action BNOBGIHHJGL, PGACPMGFNLA HEIMECNKEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x477E5D0", Offset = "0x477CBD0", VA = "0x18477E5D0")]
	public T1 GBOKDFJNAPN()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x66C68A0", Offset = "0x66C4EA0", VA = "0x1866C68A0")]
	public void LGHDDJDIPJE(T1 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x477E680", Offset = "0x477CC80", VA = "0x18477E680")]
	public T2 KDDNMBEJKGN()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x66C6420", Offset = "0x66C4A20", VA = "0x1866C6420")]
	public void LACBPCPDIPK(T2 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x477B700", Offset = "0x4779D00", VA = "0x18477B700")]
	public T3 CHMMILBCGNN()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x66C13F0", Offset = "0x66BF9F0", VA = "0x1866C13F0")]
	public void BBGDBHLKBHC(T3 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x66C23C0", Offset = "0x66C09C0", VA = "0x1866C23C0")]
	public void BNAKHNGOEHD(T1 BDCANBKHLCN, T2 BAHEFLJIMEE, T3 ILJLFJGHHGE, bool HACAHKDJNGL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class EFLMLHGABHL<T1, T2, T3, T4> : NDHHNCBIOLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T1 GCPFDHKMDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private T2 OKIHLJNCMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private T3 OLHEMOIFAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private T4 KIGKIMEEDLC;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	protected virtual T1 HPFJBKJPLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xE6E140", Offset = "0xE6C740", VA = "0x180E6E140", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xF7DDB0", Offset = "0xF7C3B0", VA = "0x180F7DDB0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	protected virtual T2 INMGDHGCMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x1E01870", Offset = "0x1DFFE70", VA = "0x181E01870", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x477FFC0", Offset = "0x477E5C0", VA = "0x18477FFC0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	protected virtual T3 CGICGLALGPI
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x477E670", Offset = "0x477CC70", VA = "0x18477E670", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x477FF50", Offset = "0x477E550", VA = "0x18477FF50", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	protected virtual T4 CDOEBLMCHLL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x156FB50", Offset = "0x156E150", VA = "0x18156FB50", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x14FC3D0", Offset = "0x14FA9D0", VA = "0x1814FC3D0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public T2 GEOGKGFCCHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x477E6A0", Offset = "0x477CCA0", VA = "0x18477E6A0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T3 PFILOGJIGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x477B760", Offset = "0x4779D60", VA = "0x18477B760")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T4 NNLNKFCFOOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1F5E420", Offset = "0x1F5CA20", VA = "0x181F5E420")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	protected override object LCIJJPPIHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x4777E40", Offset = "0x4776440", VA = "0x184777E40", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x477E290", Offset = "0x477C890", VA = "0x18477E290", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x477C430", Offset = "0x477AA30", VA = "0x18477C430", Slot = "9")]
	protected override bool EAIGADGKPAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4780970", Offset = "0x477EF70", VA = "0x184780970")]
	protected EFLMLHGABHL([In] JAAHDJDPHDD ACJFHCNBBBO, T1 GCPFDHKMDNO, T2 OKIHLJNCMKP, T3 OLHEMOIFAOP, T4 KIGKIMEEDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4781BD0", Offset = "0x47801D0", VA = "0x184781BD0")]
	protected EFLMLHGABHL(KNOJHPOMDED OPOGJMFOAFI, AKKKLPFJHDO HILCMKALFIH, string BLIBAMJKLIA, T1 GCPFDHKMDNO, T2 OKIHLJNCMKP, T3 OLHEMOIFAOP, T4 KIGKIMEEDLC, ANAOEMGACFC BCHDIMAAIFO, bool KPBHAILFOEH, Action BNOBGIHHJGL, PGACPMGFNLA HEIMECNKEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x477E5D0", Offset = "0x477CBD0", VA = "0x18477E5D0")]
	public T1 GBOKDFJNAPN()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x477F2D0", Offset = "0x477D8D0", VA = "0x18477F2D0")]
	public void LGHDDJDIPJE(T1 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x477E6A0", Offset = "0x477CCA0", VA = "0x18477E6A0")]
	public T2 KDDNMBEJKGN()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x477E9B0", Offset = "0x477CFB0", VA = "0x18477E9B0")]
	public void LACBPCPDIPK(T2 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x477B760", Offset = "0x4779D60", VA = "0x18477B760")]
	public T3 CHMMILBCGNN()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4778260", Offset = "0x4776860", VA = "0x184778260")]
	public void BBGDBHLKBHC(T3 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1F5E420", Offset = "0x1F5CA20", VA = "0x181F5E420")]
	public T4 BMKCGEMLBCB()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x477FCE0", Offset = "0x477E2E0", VA = "0x18477FCE0")]
	public void MCCHOFGBKHM(T4 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x4778CC0", Offset = "0x47772C0", VA = "0x184778CC0")]
	public void BNAKHNGOEHD(T1 BDCANBKHLCN, T2 BAHEFLJIMEE, T3 ILJLFJGHHGE, T4 GIHDEHAHILA, bool HACAHKDJNGL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class HJOOCANBAFJ<T1, T2, T3, T4, T5> : NDHHNCBIOLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private T1 GCPFDHKMDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T2 OKIHLJNCMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private T3 OLHEMOIFAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private T4 KIGKIMEEDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private T5 JEOMLAEOAMD;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	protected virtual T1 HPFJBKJPLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xAB5400", Offset = "0xAB3A00", VA = "0x180AB5400", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x13B0F40", Offset = "0x13AF540", VA = "0x1813B0F40", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	protected virtual T2 INMGDHGCMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x1497430", Offset = "0x1495A30", VA = "0x181497430", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1495D30", Offset = "0x1494330", VA = "0x181495D30", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	protected virtual T3 CGICGLALGPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xA60400", Offset = "0xA5EA00", VA = "0x180A60400", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xD36FA0", Offset = "0xD355A0", VA = "0x180D36FA0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	protected virtual T4 CDOEBLMCHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA7C640", Offset = "0xA7AC40", VA = "0x180A7C640", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA7C6A0", Offset = "0xA7ACA0", VA = "0x180A7C6A0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	protected virtual T5 MFOFOLEJMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x16BE470", Offset = "0x16BCA70", VA = "0x1816BE470", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return (T5)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x16C14F0", Offset = "0x16BFAF0", VA = "0x1816C14F0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	protected override object LCIJJPPIHFF
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x4777E40", Offset = "0x4776440", VA = "0x184777E40", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4E16720", Offset = "0x4E14D20", VA = "0x184E16720", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4E15240", Offset = "0x4E13840", VA = "0x184E15240", Slot = "9")]
	protected override bool EAIGADGKPAD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4E17DA0", Offset = "0x4E163A0", VA = "0x184E17DA0")]
	protected HJOOCANBAFJ(KNOJHPOMDED OPOGJMFOAFI, AKKKLPFJHDO HILCMKALFIH, string BLIBAMJKLIA, T1 GCPFDHKMDNO, T2 OKIHLJNCMKP, T3 OLHEMOIFAOP, T4 KIGKIMEEDLC, T5 JEOMLAEOAMD, ANAOEMGACFC BCHDIMAAIFO, bool KPBHAILFOEH, Action BNOBGIHHJGL, PGACPMGFNLA HEIMECNKEFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x477E5D0", Offset = "0x477CBD0", VA = "0x18477E5D0")]
	public T1 GBOKDFJNAPN()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x4E17280", Offset = "0x4E15880", VA = "0x184E17280")]
	public void LGHDDJDIPJE(T1 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x477E680", Offset = "0x477CC80", VA = "0x18477E680")]
	public T2 KDDNMBEJKGN()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x4E16E10", Offset = "0x4E15410", VA = "0x184E16E10")]
	public void LACBPCPDIPK(T2 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x477B700", Offset = "0x4779D00", VA = "0x18477B700")]
	public T3 CHMMILBCGNN()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x4E12F50", Offset = "0x4E11550", VA = "0x184E12F50")]
	public void BBGDBHLKBHC(T3 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x1F5E420", Offset = "0x1F5CA20", VA = "0x181F5E420")]
	public T4 BMKCGEMLBCB()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4E17800", Offset = "0x4E15E00", VA = "0x184E17800")]
	public void MCCHOFGBKHM(T4 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4E178F0", Offset = "0x4E15EF0", VA = "0x184E178F0")]
	public T5 NDJNILIBCPH()
	{
		return (T5)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x4E17CB0", Offset = "0x4E162B0", VA = "0x184E17CB0")]
	public void NPLEKEFFDMD(T5 FHKIBFJAKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4E149C0", Offset = "0x4E12FC0", VA = "0x184E149C0")]
	public void BNAKHNGOEHD(T1 BDCANBKHLCN, T2 BAHEFLJIMEE, T3 ILJLFJGHHGE, T4 GIHDEHAHILA, T5 DCINFMPOIKO)
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
