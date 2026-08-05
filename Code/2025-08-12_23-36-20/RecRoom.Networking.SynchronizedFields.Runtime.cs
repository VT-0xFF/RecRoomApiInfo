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
public interface ONGHKFMCKDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PMPBNPIOMJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool FIFFMGFDMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	AFLCFHLHEHB EOMNJAPIGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int IGIKNGGCLPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool IEEHEPPJCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PNHGGLJPHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action CIICNGEJCON;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NFFHBADABFC();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GPIAEJEBFBA(object OBGCPOCPFIJ, bool CLNMPNKCNEE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NKIBBOJGDID();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LJKDOHMMALD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string DIHMBOJAPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool PDOFBJKABOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LOEONFFJJNM<T> : LJKDOHMMALD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T CCIDMELHNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAGMNKNGLFA(T GNOMIJMEGAG);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class NMNGNBCKNAM<T> : LOEONFFJJNM<T>, LJKDOHMMALD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PCPGENHLMHE<T> FPLGCLCJBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly PCPGENHLMHE<T> OFJOPACHNMI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string DIHMBOJAPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xF710E0", Offset = "0xF6FEE0", VA = "0x180F710E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool PGDMOPFJNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x45B5B10", Offset = "0x45B4910", VA = "0x1845B5B10", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T IIFPDPNGJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x59A9BC0", Offset = "0x59A89C0", VA = "0x1859A9BC0", Slot = "11")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x59A9500", Offset = "0x59A8300", VA = "0x1859A9500", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T CCIDMELHNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x59A8DE0", Offset = "0x59A7BE0", VA = "0x1859A8DE0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x59AA020", Offset = "0x59A8E20", VA = "0x1859AA020", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x59A8DE0", Offset = "0x59A7BE0", VA = "0x1859A8DE0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x59A8CB0", Offset = "0x59A7AB0", VA = "0x1859A8CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool PDOFBJKABOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x45B4F90", Offset = "0x45B3D90", VA = "0x1845B4F90", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x45B8070", Offset = "0x45B6E70", VA = "0x1845B8070", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool OEAHHMAJDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x59AA110", Offset = "0x59A8F10", VA = "0x1859AA110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x59A9DA0", Offset = "0x59A8BA0", VA = "0x1859A9DA0", Slot = "10")]
	public void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x59AA740", Offset = "0x59A9540", VA = "0x1859AA740")]
	public NMNGNBCKNAM([In] GCLKFJDCION KANAIIDGHCH, T EGEPJFCEHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x59AA380", Offset = "0x59A9180", VA = "0x1859AA380")]
	private void OJCMHBGPEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x59A9B30", Offset = "0x59A8930", VA = "0x1859A9B30", Slot = "5")]
	public void GAGMNKNGLFA(T GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x59A9A40", Offset = "0x59A8840", VA = "0x1859A9A40")]
	public void GAGMNKNGLFA(T GNOMIJMEGAG, bool EDIHIINPLPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x45B6680", Offset = "0x45B5480", VA = "0x1845B6680", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class DOONDAPEFGP<T1, T2> : LOEONFFJJNM<(T1, T2)>, LJKDOHMMALD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly GAJIJGILLGP<T1, T2> FPLGCLCJBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly GAJIJGILLGP<T1, T2> OFJOPACHNMI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string DIHMBOJAPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xF710E0", Offset = "0xF6FEE0", VA = "0x180F710E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool PGDMOPFJNNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x45B5910", Offset = "0x45B4710", VA = "0x1845B5910", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool EFNGNPOALJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x45B7B50", Offset = "0x45B6950", VA = "0x1845B7B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool BOMIMCBFOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x45B56E0", Offset = "0x45B44E0", VA = "0x1845B56E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public (T1, T2) IIFPDPNGJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x45B6F70", Offset = "0x45B5D70", VA = "0x1845B6F70", Slot = "11")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x45B6000", Offset = "0x45B4E00", VA = "0x1845B6000", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public (T1, T2) CCIDMELHNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x45B5140", Offset = "0x45B3F40", VA = "0x1845B5140", Slot = "4")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x45B7670", Offset = "0x45B6470", VA = "0x1845B7670", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public (T1, T2) DDHBFJGPDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x45B7890", Offset = "0x45B6690", VA = "0x1845B7890")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x45B4ED0", Offset = "0x45B3CD0", VA = "0x1845B4ED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T1 PJDJMFILJFA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x45B5CE0", Offset = "0x45B4AE0", VA = "0x1845B5CE0")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x45B6560", Offset = "0x45B5360", VA = "0x1845B6560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T1 OJGPGNIDNPP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x45B58D0", Offset = "0x45B46D0", VA = "0x1845B58D0")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T1 GAMPCAKMHKK
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x45B58D0", Offset = "0x45B46D0", VA = "0x1845B58D0")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x45B77E0", Offset = "0x45B65E0", VA = "0x1845B77E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T2 LMPGPJPPPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x45B6840", Offset = "0x45B5640", VA = "0x1845B6840")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x45B6B00", Offset = "0x45B5900", VA = "0x1845B6B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T2 HPPBIKKJBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x45B6920", Offset = "0x45B5720", VA = "0x1845B6920")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public T2 GBNAFILHKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x45B6920", Offset = "0x45B5720", VA = "0x1845B6920")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x45B6810", Offset = "0x45B5610", VA = "0x1845B6810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PDOFBJKABOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x45B4F90", Offset = "0x45B3D90", VA = "0x1845B4F90", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x45B8070", Offset = "0x45B6E70", VA = "0x1845B8070", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x45B71E0", Offset = "0x45B5FE0", VA = "0x1845B71E0", Slot = "10")]
	public void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x45B82C0", Offset = "0x45B70C0", VA = "0x1845B82C0")]
	public DOONDAPEFGP([In] GCLKFJDCION KANAIIDGHCH, T1 CLDOCEAMGAD, T2 ENDKEBGNCIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x45B7FB0", Offset = "0x45B6DB0", VA = "0x1845B7FB0")]
	private void OJCMHBGPEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x45B72C0", Offset = "0x45B60C0", VA = "0x1845B72C0")]
	public void LDAMMDGPFHL(T1 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x45B6700", Offset = "0x45B5500", VA = "0x1845B6700")]
	public void GAGMNKNGLFA(T1 MEJCAAFMMCA, T2 GPIDJKIIENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x45B5D50", Offset = "0x45B4B50", VA = "0x1845B5D50", Slot = "5")]
	private void DAELLKCCMOD((T1, T2) MHBJBKNNPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x45B6680", Offset = "0x45B5480", VA = "0x1845B6680", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class JNOLDCCPIPH<T1, T2, T3> : LOEONFFJJNM<(T1, T2, T3)>, LJKDOHMMALD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DEMKKGCLFPA<T1, T2, T3> FPLGCLCJBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly DEMKKGCLFPA<T1, T2, T3> OFJOPACHNMI;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string DIHMBOJAPGN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xF710E0", Offset = "0xF6FEE0", VA = "0x180F710E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool PGDMOPFJNNF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x54B9EA0", Offset = "0x54B8CA0", VA = "0x1854B9EA0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool EFNGNPOALJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x45B7B50", Offset = "0x45B6950", VA = "0x1845B7B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool BOMIMCBFOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x45B5560", Offset = "0x45B4360", VA = "0x1845B5560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool GMPEFHGFJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x54BB7E0", Offset = "0x54BA5E0", VA = "0x1854BB7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public (T1, T2, T3) IIFPDPNGJPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x54BADA0", Offset = "0x54B9BA0", VA = "0x1854BADA0", Slot = "11")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x54BA4F0", Offset = "0x54B92F0", VA = "0x1854BA4F0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public (T1, T2, T3) CCIDMELHNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x54B9C20", Offset = "0x54B8A20", VA = "0x1854B9C20", Slot = "4")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x54BB680", Offset = "0x54BA480", VA = "0x1854BB680", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T1 PJDJMFILJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x54BA2A0", Offset = "0x54B90A0", VA = "0x1854BA2A0")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x54BA6B0", Offset = "0x54B94B0", VA = "0x1854BA6B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T1 OJGPGNIDNPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x54B9E60", Offset = "0x54B8C60", VA = "0x1854B9E60")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T1 GAMPCAKMHKK
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x54B9E60", Offset = "0x54B8C60", VA = "0x1854B9E60")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x54BB6D0", Offset = "0x54BA4D0", VA = "0x1854BB6D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T2 LMPGPJPPPDF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x54BA930", Offset = "0x54B9730", VA = "0x1854BA930")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x54BAA70", Offset = "0x54B9870", VA = "0x1854BAA70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T2 HPPBIKKJBDL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x54BA970", Offset = "0x54B9770", VA = "0x1854BA970")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T2 GBNAFILHKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x54BA970", Offset = "0x54B9770", VA = "0x1854BA970")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x54BA910", Offset = "0x54B9710", VA = "0x1854BA910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public T3 OHNGCELDBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x54BA8C0", Offset = "0x54B96C0", VA = "0x1854BA8C0")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x54BA210", Offset = "0x54B9010", VA = "0x1854BA210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public T3 EIKFLHLBCCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x54BAB10", Offset = "0x54B9910", VA = "0x1854BAB10")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public T3 FLIEIBABNMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x54BAB10", Offset = "0x54B9910", VA = "0x1854BAB10")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x54BA810", Offset = "0x54B9610", VA = "0x1854BA810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool PDOFBJKABOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x45B4F90", Offset = "0x45B3D90", VA = "0x1845B4F90", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x54BB220", Offset = "0x54BA020", VA = "0x1854BB220", Slot = "10")]
	public void KNFHOLHMALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x54BC390", Offset = "0x54BB190", VA = "0x1854BC390")]
	public JNOLDCCPIPH([In] GCLKFJDCION KANAIIDGHCH, T1 CLDOCEAMGAD, T2 ENDKEBGNCIB, T3 JEAJJPIEBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x54BBB60", Offset = "0x54BA960", VA = "0x1854BBB60")]
	private void OJCMHBGPEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x54BB4F0", Offset = "0x54BA2F0", VA = "0x1854BB4F0")]
	public void LDAMMDGPFHL(T1 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x54BAFB0", Offset = "0x54B9DB0", VA = "0x1854BAFB0")]
	public void JJOEDOKIMDA(T2 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x54BBE40", Offset = "0x54BAC40", VA = "0x1854BBE40")]
	public void OODIGMLEEPE(T3 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x54BA880", Offset = "0x54B9680", VA = "0x1854BA880")]
	public void GAGMNKNGLFA(T1 MEJCAAFMMCA, T2 GPIDJKIIENA, T3 CIAHLFIACHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x54BB1C0", Offset = "0x54B9FC0", VA = "0x1854BB1C0", Slot = "5")]
	private void KBJAMECCLIF((T1, T2, T3) MHBJBKNNPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x45B6680", Offset = "0x45B5480", VA = "0x1845B6680", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class GPCNHHOEAFC<T1, T2, T3, T4> : LOEONFFJJNM<(T1, T2, T3, T4)>, LJKDOHMMALD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly MFEECHAENIA<T1, T2, T3, T4> FPLGCLCJBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly MFEECHAENIA<T1, T2, T3, T4> OFJOPACHNMI;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string DIHMBOJAPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xF710E0", Offset = "0xF6FEE0", VA = "0x180F710E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public (T1, T2, T3, T4) CCIDMELHNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5010780", Offset = "0x500F580", VA = "0x185010780", Slot = "4")]
		get
		{
			return default((T1, T2, T3, T4));
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5010C30", Offset = "0x500FA30", VA = "0x185010C30", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public T2 HPPBIKKJBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5010980", Offset = "0x500F780", VA = "0x185010980")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T3 EIKFLHLBCCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x50109C0", Offset = "0x500F7C0", VA = "0x1850109C0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public T4 PLGNDHOEIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5010D50", Offset = "0x500FB50", VA = "0x185010D50")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool PDOFBJKABOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x45B4F90", Offset = "0x45B3D90", VA = "0x1845B4F90", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x45B8070", Offset = "0x45B6E70", VA = "0x1845B8070", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5011010", Offset = "0x500FE10", VA = "0x185011010")]
	public GPCNHHOEAFC([In] GCLKFJDCION KANAIIDGHCH, T1 CLDOCEAMGAD, T2 ENDKEBGNCIB, T3 JEAJJPIEBHL, T4 DOOOMKLMPHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5010ED0", Offset = "0x500FCD0", VA = "0x185010ED0")]
	private void OJCMHBGPEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5010A00", Offset = "0x500F800", VA = "0x185010A00")]
	public void LDAMMDGPFHL(T1 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x50108E0", Offset = "0x500F6E0", VA = "0x1850108E0")]
	public void GAGMNKNGLFA(T1 MEJCAAFMMCA, T2 GPIDJKIIENA, T3 CIAHLFIACHM, T4 CMOJPPMEONO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5010D10", Offset = "0x500FB10", VA = "0x185010D10", Slot = "5")]
	private void LLJNMOOHMKF((T1, T2, T3, T4) MHBJBKNNPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x45B6680", Offset = "0x45B5480", VA = "0x1845B6680", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class PGGMBJPNJJF
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x84D9AC0", Offset = "0x84D88C0", VA = "0x1884D9AC0")]
	public static string GBLLMJLNLIA(this GCLKFJDCION KANAIIDGHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xAEE190", Offset = "0xAECF90", VA = "0x180AEE190")]
	public static BBLDJICHBLK GNGBOOPFBGD(this GCLKFJDCION KANAIIDGHCH)
	{
		return default(BBLDJICHBLK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PCPGENHLMHE<T> : KHPFKCGBLPF<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5BF1380", Offset = "0x5BF0180", VA = "0x185BF1380")]
	public PCPGENHLMHE([In] GCLKFJDCION KANAIIDGHCH, T PGFMONBPOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5BF4A50", Offset = "0x5BF3850", VA = "0x185BF4A50")]
	public PCPGENHLMHE(NKDNONFKBGJ KKBNGKDBMPF, AFLCFHLHEHB GLMBLPAKFLM, string OPGJHIOADCK, T PGFMONBPOJI, BBLDJICHBLK DJJPDBJHFCJ, [Optional] Action LBJMJKFNAPH, [Optional] AOAKJIFAKPA GFMKPLBLELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5BF2D50", Offset = "0x5BF1B50", VA = "0x185BF2D50")]
	public PCPGENHLMHE(NKDNONFKBGJ KKBNGKDBMPF, string OPGJHIOADCK, T PGFMONBPOJI, BBLDJICHBLK DJJPDBJHFCJ, [Optional] Action LBJMJKFNAPH, [Optional] AOAKJIFAKPA GFMKPLBLELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5BF36C0", Offset = "0x5BF24C0", VA = "0x185BF36C0")]
	public PCPGENHLMHE(NKDNONFKBGJ KKBNGKDBMPF, string OPGJHIOADCK, T PGFMONBPOJI, BBLDJICHBLK DJJPDBJHFCJ, bool JLPHGMHPMJN, [Optional] Action LBJMJKFNAPH, [Optional] AOAKJIFAKPA GFMKPLBLELO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GAJIJGILLGP<T1, T2> : EFAGFPMALEI<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4FC5140", Offset = "0x4FC3F40", VA = "0x184FC5140")]
	public GAJIJGILLGP([In] GCLKFJDCION KANAIIDGHCH, T1 CGJOFBKBCMF, T2 EFEOIIGNANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4FC4E80", Offset = "0x4FC3C80", VA = "0x184FC4E80")]
	public GAJIJGILLGP(NKDNONFKBGJ KKBNGKDBMPF, AFLCFHLHEHB GLMBLPAKFLM, string OPGJHIOADCK, T1 CGJOFBKBCMF, T2 EFEOIIGNANM, BBLDJICHBLK DJJPDBJHFCJ, [Optional] Action LBJMJKFNAPH, [Optional] AOAKJIFAKPA GFMKPLBLELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4FC5170", Offset = "0x4FC3F70", VA = "0x184FC5170")]
	public GAJIJGILLGP(NKDNONFKBGJ KKBNGKDBMPF, string OPGJHIOADCK, T1 CGJOFBKBCMF, T2 EFEOIIGNANM, BBLDJICHBLK DJJPDBJHFCJ, [Optional] Action LBJMJKFNAPH, [Optional] AOAKJIFAKPA GFMKPLBLELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4FC4F70", Offset = "0x4FC3D70", VA = "0x184FC4F70")]
	public GAJIJGILLGP(NKDNONFKBGJ KKBNGKDBMPF, string OPGJHIOADCK, T1 CGJOFBKBCMF, T2 EFEOIIGNANM, BBLDJICHBLK DJJPDBJHFCJ, bool JLPHGMHPMJN, [Optional] Action LBJMJKFNAPH, [Optional] AOAKJIFAKPA GFMKPLBLELO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class DEMKKGCLFPA<T1, T2, T3> : GHPLFNHHABJ<T1, T2, T3>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4537170", Offset = "0x4535F70", VA = "0x184537170")]
	public DEMKKGCLFPA([In] GCLKFJDCION KANAIIDGHCH, T1 CGJOFBKBCMF, T2 EFEOIIGNANM, T3 KKADELLKFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4537460", Offset = "0x4536260", VA = "0x184537460")]
	public DEMKKGCLFPA(NKDNONFKBGJ KKBNGKDBMPF, string OPGJHIOADCK, T1 CGJOFBKBCMF, T2 EFEOIIGNANM, T3 KKADELLKFIF, BBLDJICHBLK DJJPDBJHFCJ, [Optional] Action LBJMJKFNAPH, [Optional] AOAKJIFAKPA GFMKPLBLELO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MFEECHAENIA<T1, T2, T3, T4> : DPEBCJPEPBI<T1, T2, T3, T4>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x58A6740", Offset = "0x58A5540", VA = "0x1858A6740")]
	public MFEECHAENIA([In] GCLKFJDCION KANAIIDGHCH, T1 CGJOFBKBCMF, T2 EFEOIIGNANM, T3 KKADELLKFIF, T4 ILJDDBLOAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x58A5C60", Offset = "0x58A4A60", VA = "0x1858A5C60")]
	public MFEECHAENIA(NKDNONFKBGJ KKBNGKDBMPF, AFLCFHLHEHB GLMBLPAKFLM, string OPGJHIOADCK, T1 CGJOFBKBCMF, T2 EFEOIIGNANM, T3 KKADELLKFIF, T4 ILJDDBLOAMH, BBLDJICHBLK DJJPDBJHFCJ, [Optional] Action LBJMJKFNAPH, [Optional] AOAKJIFAKPA GFMKPLBLELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x58A65F0", Offset = "0x58A53F0", VA = "0x1858A65F0")]
	public MFEECHAENIA(NKDNONFKBGJ KKBNGKDBMPF, string OPGJHIOADCK, T1 CGJOFBKBCMF, T2 EFEOIIGNANM, T3 KKADELLKFIF, T4 ILJDDBLOAMH, BBLDJICHBLK DJJPDBJHFCJ, [Optional] Action LBJMJKFNAPH, [Optional] AOAKJIFAKPA GFMKPLBLELO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IKKNAJBODFD<T1, T2, T3, T4, T5> : EEBMKLJKGBF<T1, T2, T3, T4, T5>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5224EC0", Offset = "0x5223CC0", VA = "0x185224EC0")]
	public IKKNAJBODFD(NKDNONFKBGJ KKBNGKDBMPF, AFLCFHLHEHB GLMBLPAKFLM, string OPGJHIOADCK, T1 CGJOFBKBCMF, T2 EFEOIIGNANM, T3 KKADELLKFIF, T4 ILJDDBLOAMH, T5 IKGCLIAHDJL, BBLDJICHBLK DJJPDBJHFCJ, [Optional] Action LBJMJKFNAPH, [Optional] AOAKJIFAKPA GFMKPLBLELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5224C60", Offset = "0x5223A60", VA = "0x185224C60")]
	public IKKNAJBODFD(NKDNONFKBGJ KKBNGKDBMPF, string OPGJHIOADCK, T1 CGJOFBKBCMF, T2 EFEOIIGNANM, T3 KKADELLKFIF, T4 ILJDDBLOAMH, T5 IKGCLIAHDJL, BBLDJICHBLK DJJPDBJHFCJ, [Optional] Action LBJMJKFNAPH, [Optional] AOAKJIFAKPA GFMKPLBLELO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ECIKHKHJOJH<T> : KHPFKCGBLPF<T>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C240", Offset = "0x4A3B040", VA = "0x184A3C240")]
	public ECIKHKHJOJH(AFLCFHLHEHB GLMBLPAKFLM, string OPGJHIOADCK, T PGFMONBPOJI, [Optional] Action LBJMJKFNAPH, [Optional] AOAKJIFAKPA GFMKPLBLELO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ANBHGOGILMG<T1, T2> : EFAGFPMALEI<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x547EFB0", Offset = "0x547DDB0", VA = "0x18547EFB0")]
	public ANBHGOGILMG(AFLCFHLHEHB GLMBLPAKFLM, string OPGJHIOADCK, T1 GHAPGPFICHB, T2 BEHBDGJDJNE, [Optional] Action LBJMJKFNAPH, [Optional] AOAKJIFAKPA GFMKPLBLELO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EAJCDEEFHJP
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PCPGENHLMHE<T1> CGGPGKKNHNN<T1>(string OPGJHIOADCK, T1 GHAPGPFICHB, BBLDJICHBLK DJJPDBJHFCJ, [Optional] Action LBJMJKFNAPH);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DIKCDJOODML : EAJCDEEFHJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly AOAKJIFAKPA GFMKPLBLELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly NKDNONFKBGJ KKBNGKDBMPF;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xA9BCE0", Offset = "0xA9AAE0", VA = "0x180A9BCE0")]
	public DIKCDJOODML(AOAKJIFAKPA GFMKPLBLELO, NKDNONFKBGJ ODPAPCIPBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3B58E90", Offset = "0x3B57C90", VA = "0x183B58E90", Slot = "4")]
	public PCPGENHLMHE<T1> CGGPGKKNHNN<T1>(string OPGJHIOADCK, T1 GHAPGPFICHB, BBLDJICHBLK DJJPDBJHFCJ, [Optional] Action LBJMJKFNAPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ODPDCNAIMOG : NKDNONFKBGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ViewId BDMDIAKJPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface NKDNONFKBGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JDDLFMMGINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool ODDLEODHFFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string LOGPJIIDGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool HEEEAKKFLDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RegisterDestroyHandler(LLGLLKLFDPG PMJKNCNKPFJ);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UnregisterDestroyHandler(LLGLLKLFDPG PMJKNCNKPFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class DHHLBNHFLJK
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x84D7F20", Offset = "0x84D6D20", VA = "0x1884D7F20")]
	public static bool BAANJFKGODL(this NKDNONFKBGJ KKBNGKDBMPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface AOAKJIFAKPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	AFLCFHLHEHB LLFFNMNNLCO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool OEAHHMAJDPA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool BNGCLJLCEIG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IEHCJBEIMLK();

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object BHEGGAHPOBK(string OPGJHIOADCK);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	object OEGPDLJLABA(AFLCFHLHEHB MBABEJBFODJ, string OPGJHIOADCK);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OPAIIJJOOBG(string OPGJHIOADCK, object GNOMIJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JKOKDIEEFEB(AFLCFHLHEHB MBABEJBFODJ, string OPGJHIOADCK, object GNOMIJMEGAG);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HDMHKPDCLKP<T>(string OPGJHIOADCK, T HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KCPKCHKEHKB([CanBeNull] AFLCFHLHEHB MBABEJBFODJ, string OPGJHIOADCK, KDGADAEGNHD AABFNCPGEMO);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FEDNANBLNIF([CanBeNull] AFLCFHLHEHB MBABEJBFODJ, string OPGJHIOADCK, KDGADAEGNHD AABFNCPGEMO);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "11")]
	T KEIIHIHINKK<T>(object HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "12")]
	object OIDFELLIFNJ<T>(T PGFMONBPOJI);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EGHLFFCLPGI();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void INLOMLCBNEN();

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OPDNDBCBNOG(string FNEAAIJJGGG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct GCLKFJDCION
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public AFLCFHLHEHB GLMBLPAKFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NKDNONFKBGJ KKBNGKDBMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public string OPGJHIOADCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public BBLDJICHBLK DJJPDBJHFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool JLPHGMHPMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action LBJMJKFNAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public AOAKJIFAKPA GFMKPLBLELO;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x84D7FC0", Offset = "0x84D6DC0", VA = "0x1884D7FC0")]
	public GCLKFJDCION(GCLKFJDCION FGAEAFBDBPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x84D8040", Offset = "0x84D6E40", VA = "0x1884D8040")]
	public GCLKFJDCION(NKDNONFKBGJ KKBNGKDBMPF, string OPGJHIOADCK, BBLDJICHBLK DJJPDBJHFCJ, [Optional] Action LBJMJKFNAPH, [Optional] AOAKJIFAKPA GFMKPLBLELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x84D7F70", Offset = "0x84D6D70", VA = "0x1884D7F70")]
	public static GCLKFJDCION BADAHKFBFDJ(NKDNONFKBGJ KKBNGKDBMPF, string OPGJHIOADCK, BBLDJICHBLK DJJPDBJHFCJ, [Optional] Action LBJMJKFNAPH, [Optional] AOAKJIFAKPA GFMKPLBLELO)
	{
		return default(GCLKFJDCION);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class LMBNNAOIFED
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3DDBAD0", Offset = "0x3DDA8D0", VA = "0x183DDBAD0")]
	public static PCPGENHLMHE<T> IEOBENHABNE<T>(this GCLKFJDCION KANAIIDGHCH, T PGFMONBPOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3DDB870", Offset = "0x3DDA670", VA = "0x183DDB870")]
	public static GAJIJGILLGP<T1, T2> IEOBENHABNE<T1, T2>(this GCLKFJDCION KANAIIDGHCH, T1 MCOLLBCENGL, T2 IFNNGEDHIHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3DDB910", Offset = "0x3DDA710", VA = "0x183DDB910")]
	public static DEMKKGCLFPA<T1, T2, T3> IEOBENHABNE<T1, T2, T3>(this GCLKFJDCION KANAIIDGHCH, T1 MCOLLBCENGL, T2 IFNNGEDHIHK, T3 PHKJIJDDAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3DDBD10", Offset = "0x3DDAB10", VA = "0x183DDBD10")]
	public static MFEECHAENIA<T1, T2, T3, T4> IEOBENHABNE<T1, T2, T3, T4>(this GCLKFJDCION KANAIIDGHCH, T1 MCOLLBCENGL, T2 IFNNGEDHIHK, T3 PHKJIJDDAEF, T4 FHAPIDENPEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3DDB9C0", Offset = "0x3DDA7C0", VA = "0x183DDB9C0")]
	public static NMNGNBCKNAM<T> JJKLAAKIBMD<T>(this GCLKFJDCION KANAIIDGHCH, T PGFMONBPOJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3DDB870", Offset = "0x3DDA670", VA = "0x183DDB870")]
	public static DOONDAPEFGP<T1, T2> JJKLAAKIBMD<T1, T2>(this GCLKFJDCION KANAIIDGHCH, T1 MCOLLBCENGL, T2 IFNNGEDHIHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3DDB910", Offset = "0x3DDA710", VA = "0x183DDB910")]
	public static JNOLDCCPIPH<T1, T2, T3> JJKLAAKIBMD<T1, T2, T3>(this GCLKFJDCION KANAIIDGHCH, T1 MCOLLBCENGL, T2 IFNNGEDHIHK, T3 PHKJIJDDAEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3DDBD10", Offset = "0x3DDAB10", VA = "0x183DDBD10")]
	public static GPCNHHOEAFC<T1, T2, T3, T4> JJKLAAKIBMD<T1, T2, T3, T4>(this GCLKFJDCION KANAIIDGHCH, T1 MCOLLBCENGL, T2 IFNNGEDHIHK, T3 PHKJIJDDAEF, T4 FHAPIDENPEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class KDGADAEGNHD : LLGLLKLFDPG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[Flags]
	private enum KBFHOFOEKML
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
	private static Stack<AOAKJIFAKPA> FLNFNDPBKAB;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static bool NFLGGHLODNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly AFLCFHLHEHB GLMBLPAKFLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly NKDNONFKBGJ KKBNGKDBMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly string OPGJHIOADCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly BBLDJICHBLK DJJPDBJHFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly Action LBJMJKFNAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected AOAKJIFAKPA IDJNPMEGENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private KBFHOFOEKML AEDIGFLCOAJ;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static AOAKJIFAKPA GIMJDFJOBBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x84D8370", Offset = "0x84D7170", VA = "0x1884D8370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool DOHIJLIBBLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x84D8D60", Offset = "0x84D7B60", VA = "0x1884D8D60")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x84D8460", Offset = "0x84D7260", VA = "0x1884D8460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private bool FABNIPMOHOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x84D8760", Offset = "0x84D7560", VA = "0x1884D8760")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x84D93E0", Offset = "0x84D81E0", VA = "0x1884D93E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private bool ODHAPOKGHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x84D8770", Offset = "0x84D7570", VA = "0x1884D8770")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x84D8270", Offset = "0x84D7070", VA = "0x1884D8270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool PDOFBJKABOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x84D81E0", Offset = "0x84D6FE0", VA = "0x1884D81E0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x84D95E0", Offset = "0x84D83E0", VA = "0x1884D95E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected virtual object FIBPLJJCBHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA98CF0", Offset = "0xA97AF0", VA = "0x180A98CF0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA98AD0", Offset = "0xA978D0", VA = "0x180A98AD0", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool ABMIFIEAOCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x84D87E0", Offset = "0x84D75E0", VA = "0x1884D87E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int FMJNDGDGEKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xEA1460", Offset = "0xEA0260", VA = "0x180EA1460")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xFF01B0", Offset = "0xFEEFB0", VA = "0x180FF01B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string DIHMBOJAPGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA94B40", Offset = "0xA93940", VA = "0x180A94B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool OEAHHMAJDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x84D9590", Offset = "0x84D8390", VA = "0x1884D9590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x84D88A0", Offset = "0x84D76A0", VA = "0x1884D88A0")]
	public static void HKOFKFPFMEA(AOAKJIFAKPA NLMPNEAGLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool NNIFLFFNFMA();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x84D98A0", Offset = "0x84D86A0", VA = "0x1884D98A0")]
	protected KDGADAEGNHD(AFLCFHLHEHB GLMBLPAKFLM, NKDNONFKBGJ KKBNGKDBMPF, string OPGJHIOADCK, BBLDJICHBLK DJJPDBJHFCJ, Action LBJMJKFNAPH, AOAKJIFAKPA GFMKPLBLELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x84D8830", Offset = "0x84D7630", VA = "0x1884D8830", Slot = "1")]
	~KDGADAEGNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x84D85F0", Offset = "0x84D73F0", VA = "0x1884D85F0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x84D8B00", Offset = "0x84D7900", VA = "0x1884D8B00")]
	private void IGFCKFFNFFK(bool AAAJEAGBNGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x84D8480", Offset = "0x84D7280", VA = "0x1884D8480")]
	private object DOMECHPIMON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x84D8940", Offset = "0x84D7740", VA = "0x1884D8940")]
	protected void IEHCJBEIMLK(bool JLPHGMHPMJN, object EGEPJFCEHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x84D8330", Offset = "0x84D7130", VA = "0x1884D8330")]
	protected void BNFJAIPBEBA(object GNOMIJMEGAG, bool NKKMAJFPJFL = true, bool GMDNODKAGID = false, bool EDIHIINPLPA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x84D8D70", Offset = "0x84D7B70", VA = "0x1884D8D70")]
	protected void JNNNHHAPGIM(object GNOMIJMEGAG, bool MMGCMKKIKMI, bool NKKMAJFPJFL, bool GMDNODKAGID = false, bool EDIHIINPLPA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x84D81F0", Offset = "0x84D6FF0", VA = "0x1884D81F0")]
	internal void ANMHOMAPMKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x84D8780", Offset = "0x84D7580", VA = "0x1884D8780")]
	private void FCLKCABANPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x84D9530", Offset = "0x84D8330", VA = "0x1884D9530")]
	private void MMLBGKENBHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x84D83E0", Offset = "0x84D71E0", VA = "0x1884D83E0", Slot = "4")]
	private void CBCMGDGDEHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x84D8450", Offset = "0x84D7250", VA = "0x1884D8450", Slot = "5")]
	private void CFOFELFDHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x84D92A0", Offset = "0x84D80A0", VA = "0x1884D92A0")]
	public bool LECBECELCIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x84D8BA0", Offset = "0x84D79A0", VA = "0x1884D8BA0")]
	public bool JKGPMDCNBMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x84D9150", Offset = "0x84D7F50", VA = "0x1884D9150")]
	private bool LDLNBICEKNF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x84D90A0", Offset = "0x84D7EA0", VA = "0x1884D90A0")]
	internal void KPJODLFFIEP(object GNOMIJMEGAG, int IBFKCANEFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x84D9420", Offset = "0x84D8220", VA = "0x1884D9420")]
	private void MKDCOEOBBFB(object GNOMIJMEGAG, bool GMDNODKAGID, bool EDIHIINPLPA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x84D8890", Offset = "0x84D7690", VA = "0x1884D8890")]
	private bool GEMFAKPELNB(KBFHOFOEKML FFAHAEGEIFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x84D9400", Offset = "0x84D8200", VA = "0x1884D9400")]
	private void LPPCIHPEHDG(KBFHOFOEKML FFAHAEGEIFG, bool HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x84D8290", Offset = "0x84D7090", VA = "0x1884D8290")]
	public static string BCMAJOJPPDJ(AFLCFHLHEHB GLMBLPAKFLM, string OPGJHIOADCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x84D8FC0", Offset = "0x84D7DC0", VA = "0x1884D8FC0")]
	public static string KOOFFKGDNJD(NKDNONFKBGJ KKBNGKDBMPF, string OPGJHIOADCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x84D96A0", Offset = "0x84D84A0", VA = "0x1884D96A0")]
	public static bool PONNICBKKDM(object GENJGFGGINA, object KMNEIBIPMKI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class PPLLCKHPOFL : AOAKJIFAKPA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly Dictionary<object, object> GNPAPNCFCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly List<string> JFCIBIMMCAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly Dictionary<object, object> NEAFOBOEOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<string> CINHNPGGECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool PJLPIIDDCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	protected readonly Dictionary<string, object> LJOPFKHIGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	protected readonly Dictionary<AFLCFHLHEHB, Dictionary<string, object>> LLNBBLHAJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<string> DJLIJPJBMKN;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public abstract Dictionary<object, object> OFIIFHDKLEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public abstract int MGBJJLMHNFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public abstract AFLCFHLHEHB LLFFNMNNLCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public abstract bool OEAHHMAJDPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public abstract bool BNGCLJLCEIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual bool FIGGOFABJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAAE460", VA = "0x180AAF660", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool KFLGDPOEGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xAC2580", Offset = "0xAC1380", VA = "0x180AC2580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3F07530", Offset = "0x3F06330", VA = "0x183F07530", Slot = "12")]
	public void HDMHKPDCLKP<T>(string OPGJHIOADCK, T HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x84DB290", Offset = "0x84DA090", VA = "0x1884DB290", Slot = "11")]
	public void JKOKDIEEFEB(AFLCFHLHEHB GLMBLPAKFLM, string OPGJHIOADCK, object HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x84DBA30", Offset = "0x84DA830", VA = "0x1884DBA30", Slot = "9")]
	public object OEGPDLJLABA(AFLCFHLHEHB GLMBLPAKFLM, string OPGJHIOADCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x84DBB30", Offset = "0x84DA930", VA = "0x1884DBB30", Slot = "10")]
	public void OPAIIJJOOBG(string OPGJHIOADCK, object HGMAIPELJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x84DA260", Offset = "0x84D9060", VA = "0x1884DA260", Slot = "8")]
	public object BHEGGAHPOBK(string OPGJHIOADCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x84DB380", Offset = "0x84DA180", VA = "0x1884DB380", Slot = "13")]
	public void KCPKCHKEHKB(AFLCFHLHEHB MBABEJBFODJ, string OPGJHIOADCK, KDGADAEGNHD AABFNCPGEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x84DA690", Offset = "0x84D9490", VA = "0x1884DA690", Slot = "14")]
	public void FEDNANBLNIF(AFLCFHLHEHB MBABEJBFODJ, string OPGJHIOADCK, KDGADAEGNHD AABFNCPGEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x84DA350", Offset = "0x84D9150", VA = "0x1884DA350")]
	private void DIEJJKOFPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x84DA300", Offset = "0x84D9100", VA = "0x1884DA300")]
	private void BIEINMFKOPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x84DB660", Offset = "0x84DA460", VA = "0x1884DB660")]
	private void LOOCKLMGHIJ(AFLCFHLHEHB GLMBLPAKFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x84D9DD0", Offset = "0x84D8BD0", VA = "0x1884D9DD0")]
	protected void AMBGFKNEGDN(AFLCFHLHEHB FLAEMMEHDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x84DABC0", Offset = "0x84D99C0", VA = "0x1884DABC0")]
	protected void GPKKNFBGJON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x84DB370", Offset = "0x84DA170", VA = "0x1884DB370")]
	protected void JPJOAELEGNI(IDictionary<object, object> JAHBMEKHEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x84DB220", Offset = "0x84DA020", VA = "0x1884DB220")]
	protected void IPKJELAKAEJ(AFLCFHLHEHB HJOAMDGBOKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x84DA3A0", Offset = "0x84D91A0", VA = "0x1884DA3A0")]
	protected void DKMIJPFLPHF(AFLCFHLHEHB GLMBLPAKFLM, IDictionary<object, object> JAHBMEKHEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x84DACB0", Offset = "0x84D9AB0", VA = "0x1884DACB0")]
	private void IMJPBDJPIKP(IDictionary<object, object> JAHBMEKHEDD, Dictionary<string, object> IONMHPDHMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x84D9B00", Offset = "0x84D8900", VA = "0x1884D9B00")]
	private static void ACINNLKBEPG(object MGLMMLLAANO, object HIGEDKBAGHN, int IBFKCANEFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x84DBEE0", Offset = "0x84DACE0", VA = "0x1884DBEE0")]
	private static void PCJIHPCDCDB(Dictionary<string, object> IONMHPDHMLF, string OPGJHIOADCK, KDGADAEGNHD AABFNCPGEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x84DB490", Offset = "0x84DA290", VA = "0x1884DB490")]
	private static void LHDMMDNHKEN(Dictionary<string, object> IONMHPDHMLF, string OPGJHIOADCK, KDGADAEGNHD AABFNCPGEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x84DA590", Offset = "0x84D9390", VA = "0x1884DA590", Slot = "17")]
	public void EGHLFFCLPGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	protected abstract void ODJAKHNHHEG(Dictionary<object, object> GNPAPNCFCAP);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x84DB140", Offset = "0x84D9F40", VA = "0x1884DB140", Slot = "18")]
	public void INLOMLCBNEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "28")]
	protected abstract void EEBCGMGEEIA(Dictionary<object, object> NEAFOBOEOGP);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x84D9F00", Offset = "0x84D8D00", VA = "0x1884D9F00")]
	private void ANPNIANIFIK(Dictionary<object, object> NBEAGBGLAAL, List<string> HBPCKJEDNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x84DA940", Offset = "0x84D9740", VA = "0x1884DA940")]
	private void GOLKAMNKNNK(IDictionary<object, object> JAHBMEKHEDD, [Out] int IBFKCANEFKM, [Out] string[] BHDMHGIPGKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x84DA1D0", Offset = "0x84D8FD0", VA = "0x1884DA1D0")]
	public void BEDBHOBACLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x84D9D00", Offset = "0x84D8B00", VA = "0x1884D9D00")]
	public void ALPELHLGDED(AFLCFHLHEHB GLMBLPAKFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x84DB6C0", Offset = "0x84DA4C0", VA = "0x1884DB6C0")]
	public void MDCIPCMGOFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "29")]
	protected abstract HashSet<int> HFOGBAFKNON(bool ICOAEFOCFJI, bool GCEPDDKCFMC);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x84DBC50", Offset = "0x84DAA50", VA = "0x1884DBC50", Slot = "19")]
	public void OPDNDBCBNOG(string FNEAAIJJGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x84DA130", Offset = "0x84D8F30", VA = "0x1884DA130")]
	protected string BCMAJOJPPDJ(AFLCFHLHEHB GLMBLPAKFLM, string OPGJHIOADCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract object OIDFELLIFNJ<T>(T HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract T KEIIHIHINKK<T>(object HGMAIPELJHM);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "32")]
	public virtual void IEHCJBEIMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x84DA430", Offset = "0x84D9230", VA = "0x1884DA430", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "33")]
	protected virtual void KMIEIDLCLEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x84DC100", Offset = "0x84DAF00", VA = "0x1884DC100")]
	protected PPLLCKHPOFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class KHPFKCGBLPF<T1> : KDGADAEGNHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T1 GHAPGPFICHB;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	protected virtual T1 IAFIHOGABFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1438BE0", Offset = "0x14379E0", VA = "0x181438BE0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5539260", Offset = "0x5538060", VA = "0x185539260", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	protected override object FIBPLJJCBHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x45C3820", Offset = "0x45C2620", VA = "0x1845C3820", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x55DF730", Offset = "0x55DE530", VA = "0x1855DF730", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x55E17D0", Offset = "0x55E05D0", VA = "0x1855E17D0", Slot = "9")]
	protected override bool NNIFLFFNFMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x55E2740", Offset = "0x55E1540", VA = "0x1855E2740")]
	protected KHPFKCGBLPF([In] GCLKFJDCION KANAIIDGHCH, T1 GHAPGPFICHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x55E32B0", Offset = "0x55E20B0", VA = "0x1855E32B0")]
	protected KHPFKCGBLPF(AFLCFHLHEHB GLMBLPAKFLM, NKDNONFKBGJ KKBNGKDBMPF, string OPGJHIOADCK, T1 GHAPGPFICHB, BBLDJICHBLK DJJPDBJHFCJ, bool JLPHGMHPMJN, Action LBJMJKFNAPH, AOAKJIFAKPA GFMKPLBLELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x45BF780", Offset = "0x45BE580", VA = "0x1845BF780")]
	public T1 DPMBHNJHJDJ()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x55DD390", Offset = "0x55DC190", VA = "0x1855DD390")]
	public void BNFJAIPBEBA(T1 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x55DD150", Offset = "0x55DBF50", VA = "0x1855DD150")]
	public void BNFJAIPBEBA(T1 GNOMIJMEGAG, bool NKKMAJFPJFL, bool GMDNODKAGID = false, bool EDIHIINPLPA = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class EFAGFPMALEI<T1, T2> : KDGADAEGNHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private T1 GHAPGPFICHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T2 BEHBDGJDJNE;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	protected virtual T1 IAFIHOGABFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1078F90", Offset = "0x1077D90", VA = "0x181078F90", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x128A930", Offset = "0x1289730", VA = "0x18128A930", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	protected virtual T2 DCLCFCEMJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1071870", Offset = "0x1070670", VA = "0x181071870", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x107AB00", Offset = "0x1079900", VA = "0x18107AB00", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public T2 KBNJMIEGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x16D6240", Offset = "0x16D5040", VA = "0x1816D6240")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	protected override object FIBPLJJCBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x45C3820", Offset = "0x45C2620", VA = "0x1845C3820", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4A4AC20", Offset = "0x4A49A20", VA = "0x184A4AC20", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4A4B0A0", Offset = "0x4A49EA0", VA = "0x184A4B0A0", Slot = "9")]
	protected override bool NNIFLFFNFMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4A4E810", Offset = "0x4A4D610", VA = "0x184A4E810")]
	protected EFAGFPMALEI([In] GCLKFJDCION KANAIIDGHCH, T1 GHAPGPFICHB, T2 BEHBDGJDJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x4A4E270", Offset = "0x4A4D070", VA = "0x184A4E270")]
	protected EFAGFPMALEI(AFLCFHLHEHB GLMBLPAKFLM, NKDNONFKBGJ KKBNGKDBMPF, string OPGJHIOADCK, T1 GHAPGPFICHB, T2 BEHBDGJDJNE, BBLDJICHBLK DJJPDBJHFCJ, bool JLPHGMHPMJN, Action LBJMJKFNAPH, AOAKJIFAKPA GFMKPLBLELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x45BF720", Offset = "0x45BE520", VA = "0x1845BF720")]
	public T1 BHMFHBCONLB()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x4A49350", Offset = "0x4A48150", VA = "0x184A49350")]
	public void FEDOPMGMBAF(T1 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x16D6240", Offset = "0x16D5040", VA = "0x1816D6240")]
	public T2 BBEACMADCLP()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4A4D750", Offset = "0x4A4C550", VA = "0x184A4D750")]
	public void PDIHHOGDCIH(T2 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4A48A90", Offset = "0x4A47890", VA = "0x184A48A90")]
	public void BNFJAIPBEBA(T1 MEJCAAFMMCA, T2 GPIDJKIIENA, bool NKKMAJFPJFL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class GHPLFNHHABJ<T1, T2, T3> : KDGADAEGNHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private T1 GHAPGPFICHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T2 BEHBDGJDJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private T3 HHAMEFABIPF;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	protected virtual T1 IAFIHOGABFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA98D30", Offset = "0xA97B30", VA = "0x180A98D30", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA98B50", Offset = "0xA97950", VA = "0x180A98B50", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	protected virtual T2 DCLCFCEMJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x10B1A30", Offset = "0x10B0830", VA = "0x1810B1A30", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x10B0D00", Offset = "0x10AFB00", VA = "0x1810B0D00", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	protected virtual T3 KDGHMNDFPBN
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xAAF670", Offset = "0xAAE470", VA = "0x180AAF670", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xE13760", Offset = "0xE12560", VA = "0x180E13760", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T1 OHAHFPDDNLP
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x45BF720", Offset = "0x45BE520", VA = "0x1845BF720")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T2 KBNJMIEGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x16D6240", Offset = "0x16D5040", VA = "0x1816D6240")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T3 GCGKPBDLHPD
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x45BF530", Offset = "0x45BE330", VA = "0x1845BF530")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected override object FIBPLJJCBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x45C3820", Offset = "0x45C2620", VA = "0x1845C3820", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF6E0", Offset = "0x4FEE4E0", VA = "0x184FEF6E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4FF0E10", Offset = "0x4FEFC10", VA = "0x184FF0E10", Slot = "9")]
	protected override bool NNIFLFFNFMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3B50", Offset = "0x4FF2950", VA = "0x184FF3B50")]
	protected GHPLFNHHABJ([In] GCLKFJDCION KANAIIDGHCH, T1 GHAPGPFICHB, T2 BEHBDGJDJNE, T3 HHAMEFABIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4FF3520", Offset = "0x4FF2320", VA = "0x184FF3520")]
	protected GHPLFNHHABJ(AFLCFHLHEHB GLMBLPAKFLM, NKDNONFKBGJ KKBNGKDBMPF, string OPGJHIOADCK, T1 GHAPGPFICHB, T2 BEHBDGJDJNE, T3 HHAMEFABIPF, BBLDJICHBLK DJJPDBJHFCJ, bool JLPHGMHPMJN, Action LBJMJKFNAPH, AOAKJIFAKPA GFMKPLBLELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x45BF720", Offset = "0x45BE520", VA = "0x1845BF720")]
	public T1 BHMFHBCONLB()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4FEEF70", Offset = "0x4FEDD70", VA = "0x184FEEF70")]
	public void FEDOPMGMBAF(T1 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x16D6240", Offset = "0x16D5040", VA = "0x1816D6240")]
	public T2 BBEACMADCLP()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4FF1A60", Offset = "0x4FF0860", VA = "0x184FF1A60")]
	public void PDIHHOGDCIH(T2 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x45BF530", Offset = "0x45BE330", VA = "0x1845BF530")]
	public T3 AGOJECBOMOO()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4FEF470", Offset = "0x4FEE270", VA = "0x184FEF470")]
	public void HEIHAJPDAOJ(T3 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4FED390", Offset = "0x4FEC190", VA = "0x184FED390")]
	public void BNFJAIPBEBA(T1 MEJCAAFMMCA, T2 GPIDJKIIENA, T3 CIAHLFIACHM, bool NKKMAJFPJFL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class DPEBCJPEPBI<T1, T2, T3, T4> : KDGADAEGNHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T1 GHAPGPFICHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private T2 BEHBDGJDJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private T3 HHAMEFABIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private T4 OPLMEHNGGEG;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	protected virtual T1 IAFIHOGABFM
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xF5DFF0", Offset = "0xF5CDF0", VA = "0x180F5DFF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x45C4030", Offset = "0x45C2E30", VA = "0x1845C4030", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	protected virtual T2 DCLCFCEMJMP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1F55960", Offset = "0x1F54760", VA = "0x181F55960", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x45C27F0", Offset = "0x45C15F0", VA = "0x1845C27F0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	protected virtual T3 KDGHMNDFPBN
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x45C4120", Offset = "0x45C2F20", VA = "0x1845C4120", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x45BF620", Offset = "0x45BE420", VA = "0x1845BF620", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	protected virtual T4 IALFIMENHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x1697480", Offset = "0x1696280", VA = "0x181697480", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x160B2C0", Offset = "0x160A0C0", VA = "0x18160B2C0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public T2 KBNJMIEGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x45BF650", Offset = "0x45BE450", VA = "0x1845BF650")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T3 GCGKPBDLHPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x45BF550", Offset = "0x45BE350", VA = "0x1845BF550")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T4 JCONIGNNGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x20AB7C0", Offset = "0x20AA5C0", VA = "0x1820AB7C0")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	protected override object FIBPLJJCBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x45C3820", Offset = "0x45C2620", VA = "0x1845C3820", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x45C4DE0", Offset = "0x45C3BE0", VA = "0x1845C4DE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x45C68C0", Offset = "0x45C56C0", VA = "0x1845C68C0", Slot = "9")]
	protected override bool NNIFLFFNFMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x45C8630", Offset = "0x45C7430", VA = "0x1845C8630")]
	protected DPEBCJPEPBI([In] GCLKFJDCION KANAIIDGHCH, T1 GHAPGPFICHB, T2 BEHBDGJDJNE, T3 HHAMEFABIPF, T4 OPLMEHNGGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x45C8D40", Offset = "0x45C7B40", VA = "0x1845C8D40")]
	protected DPEBCJPEPBI(AFLCFHLHEHB GLMBLPAKFLM, NKDNONFKBGJ KKBNGKDBMPF, string OPGJHIOADCK, T1 GHAPGPFICHB, T2 BEHBDGJDJNE, T3 HHAMEFABIPF, T4 OPLMEHNGGEG, BBLDJICHBLK DJJPDBJHFCJ, bool JLPHGMHPMJN, Action LBJMJKFNAPH, AOAKJIFAKPA GFMKPLBLELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x45BF720", Offset = "0x45BE520", VA = "0x1845BF720")]
	public T1 BHMFHBCONLB()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x45C3730", Offset = "0x45C2530", VA = "0x1845C3730")]
	public void FEDOPMGMBAF(T1 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x45BF650", Offset = "0x45BE450", VA = "0x1845BF650")]
	public T2 BBEACMADCLP()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x45C71D0", Offset = "0x45C5FD0", VA = "0x1845C71D0")]
	public void PDIHHOGDCIH(T2 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x45BF550", Offset = "0x45BE350", VA = "0x1845BF550")]
	public T3 AGOJECBOMOO()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x45C39C0", Offset = "0x45C27C0", VA = "0x1845C39C0")]
	public void HEIHAJPDAOJ(T3 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x20AB7C0", Offset = "0x20AA5C0", VA = "0x1820AB7C0")]
	public T4 OCGIIOKNHFM()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x45C2F10", Offset = "0x45C1D10", VA = "0x1845C2F10")]
	public void FCILFILKPDK(T4 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x45C00A0", Offset = "0x45BEEA0", VA = "0x1845C00A0")]
	public void BNFJAIPBEBA(T1 MEJCAAFMMCA, T2 GPIDJKIIENA, T3 CIAHLFIACHM, T4 CMOJPPMEONO, bool NKKMAJFPJFL = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class EEBMKLJKGBF<T1, T2, T3, T4, T5> : KDGADAEGNHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private T1 GHAPGPFICHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T2 BEHBDGJDJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private T3 HHAMEFABIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private T4 OPLMEHNGGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private T5 IPJPKODAGDI;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	protected virtual T1 IAFIHOGABFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xB1E570", Offset = "0xB1D370", VA = "0x180B1E570", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xB1E580", Offset = "0xB1D380", VA = "0x180B1E580", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	protected virtual T2 DCLCFCEMJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x15BCAF0", Offset = "0x15BB8F0", VA = "0x1815BCAF0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x15BB390", Offset = "0x15BA190", VA = "0x1815BB390", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	protected virtual T3 KDGHMNDFPBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xAAF670", Offset = "0xAAE470", VA = "0x180AAF670", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xE13760", Offset = "0xE12560", VA = "0x180E13760", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	protected virtual T4 IALFIMENHKA
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xACBD40", Offset = "0xACAB40", VA = "0x180ACBD40", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xACBDA0", Offset = "0xACABA0", VA = "0x180ACBDA0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	protected virtual T5 LHCNEPNLDFF
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x17E47F0", Offset = "0x17E35F0", VA = "0x1817E47F0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return (T5)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x17E78F0", Offset = "0x17E66F0", VA = "0x1817E78F0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	protected override object FIBPLJJCBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x45C3820", Offset = "0x45C2620", VA = "0x1845C3820", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x4A3FC60", Offset = "0x4A3EA60", VA = "0x184A3FC60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x4A40290", Offset = "0x4A3F090", VA = "0x184A40290", Slot = "9")]
	protected override bool NNIFLFFNFMA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x4A41EA0", Offset = "0x4A40CA0", VA = "0x184A41EA0")]
	protected EEBMKLJKGBF(AFLCFHLHEHB GLMBLPAKFLM, NKDNONFKBGJ KKBNGKDBMPF, string OPGJHIOADCK, T1 GHAPGPFICHB, T2 BEHBDGJDJNE, T3 HHAMEFABIPF, T4 OPLMEHNGGEG, T5 IPJPKODAGDI, BBLDJICHBLK DJJPDBJHFCJ, bool JLPHGMHPMJN, Action LBJMJKFNAPH, AOAKJIFAKPA GFMKPLBLELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x45BF720", Offset = "0x45BE520", VA = "0x1845BF720")]
	public T1 BHMFHBCONLB()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x4A3F280", Offset = "0x4A3E080", VA = "0x184A3F280")]
	public void FEDOPMGMBAF(T1 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x16D6240", Offset = "0x16D5040", VA = "0x1816D6240")]
	public T2 BBEACMADCLP()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x4A412C0", Offset = "0x4A400C0", VA = "0x184A412C0")]
	public void PDIHHOGDCIH(T2 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x45BF530", Offset = "0x45BE330", VA = "0x1845BF530")]
	public T3 AGOJECBOMOO()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4A3F710", Offset = "0x4A3E510", VA = "0x184A3F710")]
	public void HEIHAJPDAOJ(T3 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x20AB7C0", Offset = "0x20AA5C0", VA = "0x1820AB7C0")]
	public T4 OCGIIOKNHFM()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4A3EA30", Offset = "0x4A3D830", VA = "0x184A3EA30")]
	public void FCILFILKPDK(T4 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4A3F800", Offset = "0x4A3E600", VA = "0x184A3F800")]
	public T5 MDECAJFDKHI()
	{
		return (T5)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4A3C820", Offset = "0x4A3B620", VA = "0x184A3C820")]
	public void ADILIEPJKEJ(T5 GNOMIJMEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4A3D6F0", Offset = "0x4A3C4F0", VA = "0x184A3D6F0")]
	public void BNFJAIPBEBA(T1 MEJCAAFMMCA, T2 GPIDJKIIENA, T3 CIAHLFIACHM, T4 CMOJPPMEONO, T5 PKIJCOAFHBE)
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
