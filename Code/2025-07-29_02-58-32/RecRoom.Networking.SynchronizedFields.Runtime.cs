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
public interface IBNABOPDMNN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IDJAHCGALKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool ANFJAMBNGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	POIAKMBAMML GOCONONFNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int CCEFPLPFIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool NGIIDGJBCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OOBPNJJMAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action FKPGLDBBNEI;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LDILPCEINEE();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NBNHIDKFNIG(object DHNMCOFINFM, bool MBNAGILKAHA);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OIFIFGGIKHH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FNDNEJFLGIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string OFFMBGPIJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool LHNPNDMHJNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OKOCAAGGEKC<T> : FNDNEJFLGIA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T DPCJNIIOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLKGCHIDPGG(T OIKPBCOOHJG);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class BCLDMDNFGDP<T> : OKOCAAGGEKC<T>, FNDNEJFLGIA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PBKHPGOKKHK<T> JDBMLCGLJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly PBKHPGOKKHK<T> AKLMNBDKKKJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string OFFMBGPIJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xF4BEC0", Offset = "0xF4A8C0", VA = "0x180F4BEC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool ODLCBFMPKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x58BB3A0", Offset = "0x58B9DA0", VA = "0x1858BB3A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T HKNGDHDHFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x64B0B00", Offset = "0x64AF500", VA = "0x1864B0B00", Slot = "11")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x64B06A0", Offset = "0x64AF0A0", VA = "0x1864B06A0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T DPCJNIIOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x64B02E0", Offset = "0x64AECE0", VA = "0x1864B02E0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x64B09C0", Offset = "0x64AF3C0", VA = "0x1864B09C0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x64B02E0", Offset = "0x64AECE0", VA = "0x1864B02E0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x64B0C80", Offset = "0x64AF680", VA = "0x1864B0C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool LHNPNDMHJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4F54760", Offset = "0x4F53160", VA = "0x184F54760", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4F54660", Offset = "0x4F53060", VA = "0x184F54660", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool APCPMJALFFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x64B1070", Offset = "0x64AFA70", VA = "0x1864B1070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x64B01D0", Offset = "0x64AEBD0", VA = "0x1864B01D0", Slot = "10")]
	public void AAJENMMCLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x64B2840", Offset = "0x64B1240", VA = "0x1864B2840")]
	public BCLDMDNFGDP([In] IMHIIJLELOB GPCDCFCPGFK, T OCCFCECHCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x64B0F10", Offset = "0x64AF910", VA = "0x1864B0F10")]
	private void KKJBOGPAGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x64B1580", Offset = "0x64AFF80", VA = "0x1864B1580", Slot = "5")]
	public void NLKGCHIDPGG(T OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x64B1510", Offset = "0x64AFF10", VA = "0x1864B1510")]
	public void NLKGCHIDPGG(T OIKPBCOOHJG, bool MBGLDHPALEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4F54680", Offset = "0x4F53080", VA = "0x184F54680", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class NIDGMBCKMBG<T1, T2> : OKOCAAGGEKC<(T1, T2)>, FNDNEJFLGIA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly LBJAIIHEFIE<T1, T2> JDBMLCGLJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly LBJAIIHEFIE<T1, T2> AKLMNBDKKKJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string OFFMBGPIJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xF4BEC0", Offset = "0xF4A8C0", VA = "0x180F4BEC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool ODLCBFMPKGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x58BB590", Offset = "0x58B9F90", VA = "0x1858BB590", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BMLPIMOADIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4F59E40", Offset = "0x4F58840", VA = "0x184F59E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool KGOMHMFCNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x58BA460", Offset = "0x58B8E60", VA = "0x1858BA460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public (T1, T2) HKNGDHDHFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x58BA650", Offset = "0x58B9050", VA = "0x1858BA650", Slot = "11")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x58B9A10", Offset = "0x58B8410", VA = "0x1858B9A10", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public (T1, T2) DPCJNIIOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x58B8F40", Offset = "0x58B7940", VA = "0x1858B8F40", Slot = "4")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x58B9D30", Offset = "0x58B8730", VA = "0x1858B9D30", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public (T1, T2) BHKLFFIKDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x58B9330", Offset = "0x58B7D30", VA = "0x1858B9330")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x58BAB40", Offset = "0x58B9540", VA = "0x1858BAB40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T1 EEDDCMKGJAO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x58B9C00", Offset = "0x58B8600", VA = "0x1858B9C00")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x58B94F0", Offset = "0x58B7EF0", VA = "0x1858B94F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T1 HOFLLMKOPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x58BAB80", Offset = "0x58B9580", VA = "0x1858BAB80")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T1 KMJLCIGMIGF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x58BAB80", Offset = "0x58B9580", VA = "0x1858BAB80")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x58BB360", Offset = "0x58B9D60", VA = "0x1858BB360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T2 FPAFGCBPGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x58BB8C0", Offset = "0x58BA2C0", VA = "0x1858BB8C0")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x58B9FA0", Offset = "0x58B89A0", VA = "0x1858B9FA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T2 JNGONJEGBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x58B9C80", Offset = "0x58B8680", VA = "0x1858B9C80")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public T2 FINKLHABBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x58B9C80", Offset = "0x58B8680", VA = "0x1858B9C80")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x58BB920", Offset = "0x58BA320", VA = "0x1858BB920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool LHNPNDMHJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4F54760", Offset = "0x4F53160", VA = "0x184F54760", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4F54660", Offset = "0x4F53060", VA = "0x184F54660", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x58B8CC0", Offset = "0x58B76C0", VA = "0x1858B8CC0", Slot = "10")]
	public void AAJENMMCLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x58BC000", Offset = "0x58BAA00", VA = "0x1858BC000")]
	public NIDGMBCKMBG([In] IMHIIJLELOB GPCDCFCPGFK, T1 OGKOLJMDGMN, T2 IFBDLCMAIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x58BADD0", Offset = "0x58B97D0", VA = "0x1858BADD0")]
	private void KKJBOGPAGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x58BB1A0", Offset = "0x58B9BA0", VA = "0x1858BB1A0")]
	public void KPOBOCIJHIO(T1 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x58BB770", Offset = "0x58BA170", VA = "0x1858BB770")]
	public void NLKGCHIDPGG(T1 IAMLOMGHONH, T2 IPHFBMBPNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x58BA240", Offset = "0x58B8C40", VA = "0x1858BA240", Slot = "5")]
	private void GHPLNBNBNCF((T1, T2) ELPCBPJLJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4F54680", Offset = "0x4F53080", VA = "0x184F54680", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class GGIIOILMDJO<T1, T2, T3> : OKOCAAGGEKC<(T1, T2, T3)>, FNDNEJFLGIA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MKIGBDOENFM<T1, T2, T3> JDBMLCGLJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly MKIGBDOENFM<T1, T2, T3> AKLMNBDKKKJ;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string OFFMBGPIJFM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xF4BEC0", Offset = "0xF4A8C0", VA = "0x180F4BEC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool ODLCBFMPKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4F5B0A0", Offset = "0x4F59AA0", VA = "0x184F5B0A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool BMLPIMOADIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4F59E40", Offset = "0x4F58840", VA = "0x184F59E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool KGOMHMFCNHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4F59BD0", Offset = "0x4F585D0", VA = "0x184F59BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool BCPCJKCBLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4F5A330", Offset = "0x4F58D30", VA = "0x184F5A330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public (T1, T2, T3) HKNGDHDHFIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4F59F30", Offset = "0x4F58930", VA = "0x184F59F30", Slot = "11")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4F595C0", Offset = "0x4F57FC0", VA = "0x184F595C0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public (T1, T2, T3) DPCJNIIOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4F58CA0", Offset = "0x4F576A0", VA = "0x184F58CA0", Slot = "4")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4F598B0", Offset = "0x4F582B0", VA = "0x184F598B0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T1 EEDDCMKGJAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4F597E0", Offset = "0x4F581E0", VA = "0x184F597E0")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4F592D0", Offset = "0x4F57CD0", VA = "0x184F592D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T1 HOFLLMKOPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4F5A5A0", Offset = "0x4F58FA0", VA = "0x184F5A5A0")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T1 KMJLCIGMIGF
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x4F5A5A0", Offset = "0x4F58FA0", VA = "0x184F5A5A0")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4F5AE70", Offset = "0x4F59870", VA = "0x184F5AE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T2 FPAFGCBPGOL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4F5B360", Offset = "0x4F59D60", VA = "0x184F5B360")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4F59950", Offset = "0x4F58350", VA = "0x184F59950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T2 JNGONJEGBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4F59820", Offset = "0x4F58220", VA = "0x184F59820")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T2 FINKLHABBNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4F59820", Offset = "0x4F58220", VA = "0x184F59820")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4F5B3A0", Offset = "0x4F59DA0", VA = "0x184F5B3A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public T3 HKLAMEPBDGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4F5A290", Offset = "0x4F58C90", VA = "0x184F5A290")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4F5AF60", Offset = "0x4F59960", VA = "0x184F5AF60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public T3 CEKMIFDPGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4F5A2E0", Offset = "0x4F58CE0", VA = "0x184F5A2E0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public T3 NEIFEKKMLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4F5A2E0", Offset = "0x4F58CE0", VA = "0x184F5A2E0")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4F5AE90", Offset = "0x4F59890", VA = "0x184F5AE90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool LHNPNDMHJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4F54760", Offset = "0x4F53160", VA = "0x184F54760", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4F58BA0", Offset = "0x4F575A0", VA = "0x184F58BA0", Slot = "10")]
	public void AAJENMMCLHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4F5B5F0", Offset = "0x4F59FF0", VA = "0x184F5B5F0")]
	public GGIIOILMDJO([In] IMHIIJLELOB GPCDCFCPGFK, T1 OGKOLJMDGMN, T2 IFBDLCMAIKM, T3 CANJBGOOJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4F5A5E0", Offset = "0x4F58FE0", VA = "0x184F5A5E0")]
	private void KKJBOGPAGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4F5A9C0", Offset = "0x4F593C0", VA = "0x184F5A9C0")]
	public void KPOBOCIJHIO(T1 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4F590F0", Offset = "0x4F57AF0", VA = "0x184F590F0")]
	public void AEDEGHLAFOH(T2 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4F5ABA0", Offset = "0x4F595A0", VA = "0x184F5ABA0")]
	public void LELDMFKLKHN(T3 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4F5B320", Offset = "0x4F59D20", VA = "0x184F5B320")]
	public void NLKGCHIDPGG(T1 IAMLOMGHONH, T2 IPHFBMBPNBK, T3 GANGDPJOPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4F59AE0", Offset = "0x4F584E0", VA = "0x184F59AE0", Slot = "5")]
	private void FMOIAKOJLDO((T1, T2, T3) ELPCBPJLJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4F54680", Offset = "0x4F53080", VA = "0x184F54680", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class GEOLFDNAEHG<T1, T2, T3, T4> : OKOCAAGGEKC<(T1, T2, T3, T4)>, FNDNEJFLGIA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly AKIOLJPEMIL<T1, T2, T3, T4> JDBMLCGLJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly AKIOLJPEMIL<T1, T2, T3, T4> AKLMNBDKKKJ;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string OFFMBGPIJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xF4BEC0", Offset = "0xF4A8C0", VA = "0x180F4BEC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public (T1, T2, T3, T4) DPCJNIIOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4F54330", Offset = "0x4F52D30", VA = "0x184F54330", Slot = "4")]
		get
		{
			return default((T1, T2, T3, T4));
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4F54710", Offset = "0x4F53110", VA = "0x184F54710", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public T2 JNGONJEGBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4F547C0", Offset = "0x4F531C0", VA = "0x184F547C0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T3 CEKMIFDPGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4F54780", Offset = "0x4F53180", VA = "0x184F54780")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public T4 IDEIFCOFCDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4DE8E20", Offset = "0x4DE7820", VA = "0x184DE8E20")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool LHNPNDMHJNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4F54760", Offset = "0x4F53160", VA = "0x184F54760", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4F54660", Offset = "0x4F53060", VA = "0x184F54660", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4F54F90", Offset = "0x4F53990", VA = "0x184F54F90")]
	public GEOLFDNAEHG([In] IMHIIJLELOB GPCDCFCPGFK, T1 OGKOLJMDGMN, T2 IFBDLCMAIKM, T3 CANJBGOOJMN, T4 OJHGHIMEACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4F54800", Offset = "0x4F53200", VA = "0x184F54800")]
	private void KKJBOGPAGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4F54B90", Offset = "0x4F53590", VA = "0x184F54B90")]
	public void KPOBOCIJHIO(T1 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4F54CB0", Offset = "0x4F536B0", VA = "0x184F54CB0")]
	public void NLKGCHIDPGG(T1 IAMLOMGHONH, T2 IPHFBMBPNBK, T3 GANGDPJOPPI, T4 NILBNHGABFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4F54620", Offset = "0x4F53020", VA = "0x184F54620", Slot = "5")]
	private void DDFPJIGGGEG((T1, T2, T3, T4) ELPCBPJLJEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4F54680", Offset = "0x4F53080", VA = "0x184F54680", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LHIMICPDIOL
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8457E90", Offset = "0x8456890", VA = "0x188457E90")]
	public static string BFKJHPDCANJ(this IMHIIJLELOB GPCDCFCPGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xD0FF90", Offset = "0xD0E990", VA = "0x180D0FF90")]
	public static BKEOBCFPEMG IAKNHIBOCJG(this IMHIIJLELOB GPCDCFCPGFK)
	{
		return default(BKEOBCFPEMG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PBKHPGOKKHK<T> : DCNJOJJGKCK<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3BF0", Offset = "0x5AF25F0", VA = "0x185AF3BF0")]
	public PBKHPGOKKHK([In] IMHIIJLELOB GPCDCFCPGFK, T KKCMINIPIBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3A00", Offset = "0x5AF2400", VA = "0x185AF3A00")]
	public PBKHPGOKKHK(AENFEPMOKIA HCLPHJDKMCA, POIAKMBAMML JGGGINODJOB, string LNBCHJPEENA, T KKCMINIPIBD, BKEOBCFPEMG PLJPJNMHNGP, [Optional] Action EMBEDGKMMHB, [Optional] NOINHKGEMFM DFBAEDAKHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5AF4840", Offset = "0x5AF3240", VA = "0x185AF4840")]
	public PBKHPGOKKHK(AENFEPMOKIA HCLPHJDKMCA, string LNBCHJPEENA, T KKCMINIPIBD, BKEOBCFPEMG PLJPJNMHNGP, [Optional] Action EMBEDGKMMHB, [Optional] NOINHKGEMFM DFBAEDAKHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5AF3430", Offset = "0x5AF1E30", VA = "0x185AF3430")]
	public PBKHPGOKKHK(AENFEPMOKIA HCLPHJDKMCA, string LNBCHJPEENA, T KKCMINIPIBD, BKEOBCFPEMG PLJPJNMHNGP, bool BEFAOPLFOOA, [Optional] Action EMBEDGKMMHB, [Optional] NOINHKGEMFM DFBAEDAKHHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class LBJAIIHEFIE<T1, T2> : APPPECLELIB<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5584050", Offset = "0x5582A50", VA = "0x185584050")]
	public LBJAIIHEFIE([In] IMHIIJLELOB GPCDCFCPGFK, T1 JLIOJOLCFOA, T2 LFCNJEDHHPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x55866F0", Offset = "0x55850F0", VA = "0x1855866F0")]
	public LBJAIIHEFIE(AENFEPMOKIA HCLPHJDKMCA, POIAKMBAMML JGGGINODJOB, string LNBCHJPEENA, T1 JLIOJOLCFOA, T2 LFCNJEDHHPM, BKEOBCFPEMG PLJPJNMHNGP, [Optional] Action EMBEDGKMMHB, [Optional] NOINHKGEMFM DFBAEDAKHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x55852A0", Offset = "0x5583CA0", VA = "0x1855852A0")]
	public LBJAIIHEFIE(AENFEPMOKIA HCLPHJDKMCA, string LNBCHJPEENA, T1 JLIOJOLCFOA, T2 LFCNJEDHHPM, BKEOBCFPEMG PLJPJNMHNGP, [Optional] Action EMBEDGKMMHB, [Optional] NOINHKGEMFM DFBAEDAKHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5582E70", Offset = "0x5581870", VA = "0x185582E70")]
	public LBJAIIHEFIE(AENFEPMOKIA HCLPHJDKMCA, string LNBCHJPEENA, T1 JLIOJOLCFOA, T2 LFCNJEDHHPM, BKEOBCFPEMG PLJPJNMHNGP, bool BEFAOPLFOOA, [Optional] Action EMBEDGKMMHB, [Optional] NOINHKGEMFM DFBAEDAKHHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MKIGBDOENFM<T1, T2, T3> : KFCHCOAMFNE<T1, T2, T3>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5838980", Offset = "0x5837380", VA = "0x185838980")]
	public MKIGBDOENFM([In] IMHIIJLELOB GPCDCFCPGFK, T1 JLIOJOLCFOA, T2 LFCNJEDHHPM, T3 PJHFMHKNLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x58385A0", Offset = "0x5836FA0", VA = "0x1858385A0")]
	public MKIGBDOENFM(AENFEPMOKIA HCLPHJDKMCA, string LNBCHJPEENA, T1 JLIOJOLCFOA, T2 LFCNJEDHHPM, T3 PJHFMHKNLKP, BKEOBCFPEMG PLJPJNMHNGP, [Optional] Action EMBEDGKMMHB, [Optional] NOINHKGEMFM DFBAEDAKHHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AKIOLJPEMIL<T1, T2, T3, T4> : MNKHIFCMCJA<T1, T2, T3, T4>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5310F40", Offset = "0x530F940", VA = "0x185310F40")]
	public AKIOLJPEMIL([In] IMHIIJLELOB GPCDCFCPGFK, T1 JLIOJOLCFOA, T2 LFCNJEDHHPM, T3 PJHFMHKNLKP, T4 KEGDMDAMLCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5310FB0", Offset = "0x530F9B0", VA = "0x185310FB0")]
	public AKIOLJPEMIL(AENFEPMOKIA HCLPHJDKMCA, POIAKMBAMML JGGGINODJOB, string LNBCHJPEENA, T1 JLIOJOLCFOA, T2 LFCNJEDHHPM, T3 PJHFMHKNLKP, T4 KEGDMDAMLCF, BKEOBCFPEMG PLJPJNMHNGP, [Optional] Action EMBEDGKMMHB, [Optional] NOINHKGEMFM DFBAEDAKHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x53102D0", Offset = "0x530ECD0", VA = "0x1853102D0")]
	public AKIOLJPEMIL(AENFEPMOKIA HCLPHJDKMCA, string LNBCHJPEENA, T1 JLIOJOLCFOA, T2 LFCNJEDHHPM, T3 PJHFMHKNLKP, T4 KEGDMDAMLCF, BKEOBCFPEMG PLJPJNMHNGP, [Optional] Action EMBEDGKMMHB, [Optional] NOINHKGEMFM DFBAEDAKHHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MHHKCBHKCLB<T1, T2, T3, T4, T5> : OBGAEIIOGBO<T1, T2, T3, T4, T5>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5828D60", Offset = "0x5827760", VA = "0x185828D60")]
	public MHHKCBHKCLB(AENFEPMOKIA HCLPHJDKMCA, POIAKMBAMML JGGGINODJOB, string LNBCHJPEENA, T1 JLIOJOLCFOA, T2 LFCNJEDHHPM, T3 PJHFMHKNLKP, T4 KEGDMDAMLCF, T5 KOMLCHOJPJE, BKEOBCFPEMG PLJPJNMHNGP, [Optional] Action EMBEDGKMMHB, [Optional] NOINHKGEMFM DFBAEDAKHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5828B30", Offset = "0x5827530", VA = "0x185828B30")]
	public MHHKCBHKCLB(AENFEPMOKIA HCLPHJDKMCA, string LNBCHJPEENA, T1 JLIOJOLCFOA, T2 LFCNJEDHHPM, T3 PJHFMHKNLKP, T4 KEGDMDAMLCF, T5 KOMLCHOJPJE, BKEOBCFPEMG PLJPJNMHNGP, [Optional] Action EMBEDGKMMHB, [Optional] NOINHKGEMFM DFBAEDAKHHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BDEDEBDJLHD<T> : DCNJOJJGKCK<T>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x64B4D50", Offset = "0x64B3750", VA = "0x1864B4D50")]
	public BDEDEBDJLHD(POIAKMBAMML JGGGINODJOB, string LNBCHJPEENA, T KKCMINIPIBD, [Optional] Action EMBEDGKMMHB, [Optional] NOINHKGEMFM DFBAEDAKHHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LDDIPBHGDHA<T1, T2> : APPPECLELIB<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x558EBA0", Offset = "0x558D5A0", VA = "0x18558EBA0")]
	public LDDIPBHGDHA(POIAKMBAMML JGGGINODJOB, string LNBCHJPEENA, T1 GGLAKAOFGCJ, T2 GOFBNPBAAMH, [Optional] Action EMBEDGKMMHB, [Optional] NOINHKGEMFM DFBAEDAKHHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface IAMOONNPLNC
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PBKHPGOKKHK<T1> ENBFAHNNKAN<T1>(string LNBCHJPEENA, T1 GGLAKAOFGCJ, BKEOBCFPEMG PLJPJNMHNGP, [Optional] Action EMBEDGKMMHB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GFDKOGHHIOL : IAMOONNPLNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly NOINHKGEMFM DFBAEDAKHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly AENFEPMOKIA HCLPHJDKMCA;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xA93780", Offset = "0xA92180", VA = "0x180A93780")]
	public GFDKOGHHIOL(NOINHKGEMFM DFBAEDAKHHL, AENFEPMOKIA KOOFLDLHIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3C68480", Offset = "0x3C66E80", VA = "0x183C68480", Slot = "4")]
	public PBKHPGOKKHK<T1> ENBFAHNNKAN<T1>(string LNBCHJPEENA, T1 GGLAKAOFGCJ, BKEOBCFPEMG PLJPJNMHNGP, [Optional] Action EMBEDGKMMHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface DKKGOBNBOFA : AENFEPMOKIA
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ViewId FCFEJFPMJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface AENFEPMOKIA
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JEGMNJHGAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool GGINOGKOBFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string NHNEBHGCOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool MLCDCBFMEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RegisterDestroyHandler(GIHNKJKBONE LCJFNEJNIDM);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UnregisterDestroyHandler(GIHNKJKBONE LCJFNEJNIDM);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class PFNHNAEIHBP
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x84597C0", Offset = "0x84581C0", VA = "0x1884597C0")]
	public static bool DMKBOEMHDGA(this AENFEPMOKIA HCLPHJDKMCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface NOINHKGEMFM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	POIAKMBAMML PFBPJPFKPFK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool APCPMJALFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool PKMBIMMCECE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ICNIAFDKEKI();

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object DBKFENJJGFO(string LNBCHJPEENA);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	object AMEHCLCABLK(POIAKMBAMML PFEPHHMCGMM, string LNBCHJPEENA);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BGGILEABMLB(string LNBCHJPEENA, object OIKPBCOOHJG);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GKELAHDNNKF(POIAKMBAMML PFEPHHMCGMM, string LNBCHJPEENA, object OIKPBCOOHJG);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IIEDDIJONAJ<T>(string LNBCHJPEENA, T PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GHGNCNBCFHM([CanBeNull] POIAKMBAMML PFEPHHMCGMM, string LNBCHJPEENA, NKLLFPAHDMO AJABJLDPIPB);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NNFDDEAHIEN([CanBeNull] POIAKMBAMML PFEPHHMCGMM, string LNBCHJPEENA, NKLLFPAHDMO AJABJLDPIPB);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "11")]
	T JAOKJBHKOLJ<T>(object PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "12")]
	object HOAJCEGMDEN<T>(T KKCMINIPIBD);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void IOGDGNIKIHA();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IOMPCPJIJMB();

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void BCDEJPKOLMJ(string OLLJNINDADG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct IMHIIJLELOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public POIAKMBAMML JGGGINODJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public AENFEPMOKIA HCLPHJDKMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public string LNBCHJPEENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public BKEOBCFPEMG PLJPJNMHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool BEFAOPLFOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action EMBEDGKMMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NOINHKGEMFM DFBAEDAKHHL;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x8457E10", Offset = "0x8456810", VA = "0x188457E10")]
	public IMHIIJLELOB(IMHIIJLELOB EFNHKCDKOGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8457C70", Offset = "0x8456670", VA = "0x188457C70")]
	public IMHIIJLELOB(AENFEPMOKIA HCLPHJDKMCA, string LNBCHJPEENA, BKEOBCFPEMG PLJPJNMHNGP, [Optional] Action EMBEDGKMMHB, [Optional] NOINHKGEMFM DFBAEDAKHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x8457C20", Offset = "0x8456620", VA = "0x188457C20")]
	public static IMHIIJLELOB DIKKIOCKMLC(AENFEPMOKIA HCLPHJDKMCA, string LNBCHJPEENA, BKEOBCFPEMG PLJPJNMHNGP, [Optional] Action EMBEDGKMMHB, [Optional] NOINHKGEMFM DFBAEDAKHHL)
	{
		return default(IMHIIJLELOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FDNOCLICOHC
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3C51420", Offset = "0x3C4FE20", VA = "0x183C51420")]
	public static PBKHPGOKKHK<T> BJEEEBNIOAB<T>(this IMHIIJLELOB GPCDCFCPGFK, T KKCMINIPIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3C511C0", Offset = "0x3C4FBC0", VA = "0x183C511C0")]
	public static LBJAIIHEFIE<T1, T2> BJEEEBNIOAB<T1, T2>(this IMHIIJLELOB GPCDCFCPGFK, T1 FDFANNPLFDD, T2 GHBAKGAABFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3C51260", Offset = "0x3C4FC60", VA = "0x183C51260")]
	public static MKIGBDOENFM<T1, T2, T3> BJEEEBNIOAB<T1, T2, T3>(this IMHIIJLELOB GPCDCFCPGFK, T1 FDFANNPLFDD, T2 GHBAKGAABFL, T3 BKGGPCCNCPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3C51660", Offset = "0x3C50060", VA = "0x183C51660")]
	public static AKIOLJPEMIL<T1, T2, T3, T4> BJEEEBNIOAB<T1, T2, T3, T4>(this IMHIIJLELOB GPCDCFCPGFK, T1 FDFANNPLFDD, T2 GHBAKGAABFL, T3 BKGGPCCNCPG, T4 MOLGHHHACBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3C51310", Offset = "0x3C4FD10", VA = "0x183C51310")]
	public static BCLDMDNFGDP<T> MGKFGKHDMEP<T>(this IMHIIJLELOB GPCDCFCPGFK, T KKCMINIPIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3C511C0", Offset = "0x3C4FBC0", VA = "0x183C511C0")]
	public static NIDGMBCKMBG<T1, T2> MGKFGKHDMEP<T1, T2>(this IMHIIJLELOB GPCDCFCPGFK, T1 FDFANNPLFDD, T2 GHBAKGAABFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3C51260", Offset = "0x3C4FC60", VA = "0x183C51260")]
	public static GGIIOILMDJO<T1, T2, T3> MGKFGKHDMEP<T1, T2, T3>(this IMHIIJLELOB GPCDCFCPGFK, T1 FDFANNPLFDD, T2 GHBAKGAABFL, T3 BKGGPCCNCPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3C51660", Offset = "0x3C50060", VA = "0x183C51660")]
	public static GEOLFDNAEHG<T1, T2, T3, T4> MGKFGKHDMEP<T1, T2, T3, T4>(this IMHIIJLELOB GPCDCFCPGFK, T1 FDFANNPLFDD, T2 GHBAKGAABFL, T3 BKGGPCCNCPG, T4 MOLGHHHACBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class NKLLFPAHDMO : GIHNKJKBONE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[Flags]
	private enum FGAMFFACBMF
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
	private static Stack<NOINHKGEMFM> LGMKHGNADAH;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static bool PGJEAKPEOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly POIAKMBAMML JGGGINODJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly AENFEPMOKIA HCLPHJDKMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly string LNBCHJPEENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly BKEOBCFPEMG PLJPJNMHNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly Action EMBEDGKMMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected NOINHKGEMFM CHHNLKNKDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private FGAMFFACBMF DHGLMDLACKG;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static NOINHKGEMFM LONCOOCDFPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x84584F0", Offset = "0x8456EF0", VA = "0x1884584F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool GLBGLAOJPBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8458750", Offset = "0x8457150", VA = "0x188458750")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8458760", Offset = "0x8457160", VA = "0x188458760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private bool BMJHJNIIDAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8458ED0", Offset = "0x84578D0", VA = "0x188458ED0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8458A10", Offset = "0x8457410", VA = "0x188458A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private bool NDDBAKBKALK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8457F00", Offset = "0x8456900", VA = "0x188457F00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8457ED0", Offset = "0x84568D0", VA = "0x188457ED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool LHNPNDMHJNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x84582A0", Offset = "0x8456CA0", VA = "0x1884582A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8458070", Offset = "0x8456A70", VA = "0x188458070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected virtual object IDJLFIHEALI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA88320", Offset = "0xA86D20", VA = "0x180A88320", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA88300", Offset = "0xA86D00", VA = "0x180A88300", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool DKDFBIFGPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x84592A0", Offset = "0x8457CA0", VA = "0x1884592A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int OHLMFNIBCFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xE86AA0", Offset = "0xE854A0", VA = "0x180E86AA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xFCA860", Offset = "0xFC9260", VA = "0x180FCA860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string OFFMBGPIJFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA864B0", Offset = "0xA84EB0", VA = "0x180A864B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool APCPMJALFFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8458B40", Offset = "0x8457540", VA = "0x188458B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x84583F0", Offset = "0x8456DF0", VA = "0x1884583F0")]
	public static void FGOKAEJFOIL(NOINHKGEMFM MKGLIKLALDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool KGHKOLDLAIB();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x84595A0", Offset = "0x8457FA0", VA = "0x1884595A0")]
	protected NKLLFPAHDMO(POIAKMBAMML JGGGINODJOB, AENFEPMOKIA HCLPHJDKMCA, string LNBCHJPEENA, BKEOBCFPEMG PLJPJNMHNGP, Action EMBEDGKMMHB, NOINHKGEMFM DFBAEDAKHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8458560", Offset = "0x8456F60", VA = "0x188458560", Slot = "1")]
	~NKLLFPAHDMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8458130", Offset = "0x8456B30", VA = "0x188458130", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x8458FC0", Offset = "0x84579C0", VA = "0x188458FC0")]
	private void NLCAMNBMPNC(bool DFOEPEOOPHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x84585C0", Offset = "0x8456FC0", VA = "0x1884585C0")]
	private object GGKOONNPBAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8458780", Offset = "0x8457180", VA = "0x188458780")]
	protected void ICNIAFDKEKI(bool BEFAOPLFOOA, object OCCFCECHCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8458B90", Offset = "0x8457590", VA = "0x188458B90")]
	protected void MAAIKGLMNNO(object OIKPBCOOHJG, bool DKCCEMLBNLC = true, bool OCOLHDAIBMP = false, bool MBGLDHPALEF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x8458C70", Offset = "0x8457670", VA = "0x188458C70")]
	protected void MKNBLHEHNGM(object OIKPBCOOHJG, bool GPEPFEGAFHP, bool DKCCEMLBNLC, bool OCOLHDAIBMP = false, bool MBGLDHPALEF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x8459060", Offset = "0x8457A60", VA = "0x188459060")]
	internal void OFIFLADBEBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8458940", Offset = "0x8457340", VA = "0x188458940")]
	private void IJCBBPLKFMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x8458490", Offset = "0x8456E90", VA = "0x188458490")]
	private void FMKFGOINBLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x84589A0", Offset = "0x84573A0", VA = "0x1884589A0", Slot = "4")]
	private void JABALEODFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x8458EC0", Offset = "0x84578C0", VA = "0x188458EC0", Slot = "5")]
	private void NBKOHEFDGHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x84582B0", Offset = "0x8456CB0", VA = "0x1884582B0")]
	public bool EHEANAFIKGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x84590E0", Offset = "0x8457AE0", VA = "0x1884590E0")]
	public bool OKNMBEDNNOG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x84592F0", Offset = "0x8457CF0", VA = "0x1884592F0")]
	private bool PFCNHGNFEOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x8459440", Offset = "0x8457E40", VA = "0x188459440")]
	internal void PGFDEPAOIJG(object OIKPBCOOHJG, int JBIJCLOFELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x8458A30", Offset = "0x8457430", VA = "0x188458A30")]
	private void KIKPCIMHJKH(object OIKPBCOOHJG, bool OCOLHDAIBMP, bool MBGLDHPALEF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8457EF0", Offset = "0x84568F0", VA = "0x188457EF0")]
	private bool DEKPGCAJKFB(FGAMFFACBMF BILOCDLBGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8458730", Offset = "0x8457130", VA = "0x188458730")]
	private void GKGBDBPJHIB(FGAMFFACBMF BILOCDLBGBK, bool PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8458BD0", Offset = "0x84575D0", VA = "0x188458BD0")]
	public static string MHGGAMJCBKD(POIAKMBAMML JGGGINODJOB, string LNBCHJPEENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8458EE0", Offset = "0x84578E0", VA = "0x188458EE0")]
	public static string NJHBKKFDJJD(AENFEPMOKIA HCLPHJDKMCA, string LNBCHJPEENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8457F10", Offset = "0x8456910", VA = "0x188457F10")]
	public static bool DHNNCHIBMLJ(object MLLJGIHINDJ, object ABNAHAKPDNC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class ANHKEMDMIKC : NOINHKGEMFM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly Dictionary<object, object> JIFLEJNODGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly List<string> DNDJJCFGPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly Dictionary<object, object> FBBDPCCBPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<string> JIMJGFJLGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool JNAAJFKIBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	protected readonly Dictionary<string, object> BDNCEJLGBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	protected readonly Dictionary<POIAKMBAMML, Dictionary<string, object>> GFALEDIOBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<string> OBOHFLGFNEC;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public abstract Dictionary<object, object> HFJDOPNGJKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public abstract int HCNLBLMLFLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public abstract POIAKMBAMML PFBPJPFKPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public abstract bool APCPMJALFFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public abstract bool PKMBIMMCECE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual bool GIEIPOBAMNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xAA0980", Offset = "0xA9F380", VA = "0x180AA0980", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool HCIBKCBAOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xAB3420", Offset = "0xAB1E20", VA = "0x180AB3420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x31CD980", Offset = "0x31CC380", VA = "0x1831CD980", Slot = "12")]
	public void IIEDDIJONAJ<T>(string LNBCHJPEENA, T PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8456300", Offset = "0x8454D00", VA = "0x188456300", Slot = "11")]
	public void GKELAHDNNKF(POIAKMBAMML JGGGINODJOB, string LNBCHJPEENA, object PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x84553C0", Offset = "0x8453DC0", VA = "0x1884553C0", Slot = "9")]
	public object AMEHCLCABLK(POIAKMBAMML JGGGINODJOB, string LNBCHJPEENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x84557E0", Offset = "0x84541E0", VA = "0x1884557E0", Slot = "10")]
	public void BGGILEABMLB(string LNBCHJPEENA, object PDKJBMPOMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8455B40", Offset = "0x8454540", VA = "0x188455B40", Slot = "8")]
	public object DBKFENJJGFO(string LNBCHJPEENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x84561F0", Offset = "0x8454BF0", VA = "0x1884561F0", Slot = "13")]
	public void GHGNCNBCFHM(POIAKMBAMML PFEPHHMCGMM, string LNBCHJPEENA, NKLLFPAHDMO AJABJLDPIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x8457430", Offset = "0x8455E30", VA = "0x188457430", Slot = "14")]
	public void NNFDDEAHIEN(POIAKMBAMML PFEPHHMCGMM, string LNBCHJPEENA, NKLLFPAHDMO AJABJLDPIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8457010", Offset = "0x8455A10", VA = "0x188457010")]
	private void KALDNPFBMDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8457770", Offset = "0x8456170", VA = "0x188457770")]
	private void PCAOAOJMPCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8455AE0", Offset = "0x84544E0", VA = "0x188455AE0")]
	private void CLPNBKFDNBJ(POIAKMBAMML JGGGINODJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8456A80", Offset = "0x8455480", VA = "0x188456A80")]
	protected void IHEAEEMBKFI(POIAKMBAMML IMKEHGKDPCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8457330", Offset = "0x8455D30", VA = "0x188457330")]
	protected void NCHCMGBOOGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8457420", Offset = "0x8455E20", VA = "0x188457420")]
	protected void NMNECCJJCFK(IDictionary<object, object> NAEHMKBIGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x84560B0", Offset = "0x8454AB0", VA = "0x1884560B0")]
	protected void FIEGOCIKMJK(POIAKMBAMML GHEODBLCLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x84554C0", Offset = "0x8453EC0", VA = "0x1884554C0")]
	protected void AMNFAEBHOEL(POIAKMBAMML JGGGINODJOB, IDictionary<object, object> NAEHMKBIGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x84563E0", Offset = "0x8454DE0", VA = "0x1884563E0")]
	private void GMPJLPHCDBL(IDictionary<object, object> NAEHMKBIGCF, Dictionary<string, object> ODHLENMLALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8456870", Offset = "0x8455270", VA = "0x188456870")]
	private static void HDOMGBKNCEI(object IMHPDIIACHG, object OGFGMDINCKP, int JBIJCLOFELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x8457060", Offset = "0x8455A60", VA = "0x188457060")]
	private static void MEONBGPDIAN(Dictionary<string, object> ODHLENMLALD, string LNBCHJPEENA, NKLLFPAHDMO AJABJLDPIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8455900", Offset = "0x8454300", VA = "0x188455900")]
	private static void BGIINPFBHKC(Dictionary<string, object> ODHLENMLALD, string LNBCHJPEENA, NKLLFPAHDMO AJABJLDPIPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8456BB0", Offset = "0x84555B0", VA = "0x188456BB0", Slot = "17")]
	public void IOGDGNIKIHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	protected abstract void KKHONHPCHPG(Dictionary<object, object> JIFLEJNODGO);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8456CB0", Offset = "0x84556B0", VA = "0x188456CB0", Slot = "18")]
	public void IOMPCPJIJMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "28")]
	protected abstract void OAJIGJLIEGP(Dictionary<object, object> FBBDPCCBPIG);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x84577C0", Offset = "0x84561C0", VA = "0x1884577C0")]
	private void POCOBOKHHME(Dictionary<object, object> EHDIDFHLMNL, List<string> IDPKFCCNPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8456D90", Offset = "0x8455790", VA = "0x188456D90")]
	private void JCIOOGHAPLG(IDictionary<object, object> NAEHMKBIGCF, [Out] int JBIJCLOFELB, [Out] string[] JCGLKACACOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x84576E0", Offset = "0x84560E0", VA = "0x1884576E0")]
	public void OONKADGOLEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8456120", Offset = "0x8454B20", VA = "0x188456120")]
	public void FNPHEEJBMIL(POIAKMBAMML JGGGINODJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x8455BE0", Offset = "0x84545E0", VA = "0x188455BE0")]
	public void DMFLJIEEICA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "29")]
	protected abstract HashSet<int> PJDKKNMABKD(bool NLODNFFAODH, bool MJLKKJKGEIE);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x8455550", Offset = "0x8453F50", VA = "0x188455550", Slot = "19")]
	public void BCDEJPKOLMJ(string OLLJNINDADG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x8457290", Offset = "0x8455C90", VA = "0x188457290")]
	protected string MHGGAMJCBKD(POIAKMBAMML JGGGINODJOB, string LNBCHJPEENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract object HOAJCEGMDEN<T>(T PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract T JAOKJBHKOLJ<T>(object PDKJBMPOMNC);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "32")]
	public virtual void ICNIAFDKEKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x8455F50", Offset = "0x8454950", VA = "0x188455F50", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "33")]
	protected virtual void BELMKDGLCFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x84579F0", Offset = "0x84563F0", VA = "0x1884579F0")]
	protected ANHKEMDMIKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class DCNJOJJGKCK<T1> : NKLLFPAHDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T1 GGLAKAOFGCJ;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	protected virtual T1 AFINGNIELAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x140DF40", Offset = "0x140C940", VA = "0x18140DF40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x54B3710", Offset = "0x54B2110", VA = "0x1854B3710", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	protected override object IDJLFIHEALI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5322750", Offset = "0x5321150", VA = "0x185322750", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6FEE060", Offset = "0x6FECA60", VA = "0x186FEE060", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6FEF490", Offset = "0x6FEDE90", VA = "0x186FEF490", Slot = "9")]
	protected override bool KGHKOLDLAIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6FF2EE0", Offset = "0x6FF18E0", VA = "0x186FF2EE0")]
	protected DCNJOJJGKCK([In] IMHIIJLELOB GPCDCFCPGFK, T1 GGLAKAOFGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6FF3F20", Offset = "0x6FF2920", VA = "0x186FF3F20")]
	protected DCNJOJJGKCK(POIAKMBAMML JGGGINODJOB, AENFEPMOKIA HCLPHJDKMCA, string LNBCHJPEENA, T1 GGLAKAOFGCJ, BKEOBCFPEMG PLJPJNMHNGP, bool BEFAOPLFOOA, Action EMBEDGKMMHB, NOINHKGEMFM DFBAEDAKHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x583FEC0", Offset = "0x583E8C0", VA = "0x18583FEC0")]
	public T1 DHBICMHDGKM()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6FF08D0", Offset = "0x6FEF2D0", VA = "0x186FF08D0")]
	public void MAAIKGLMNNO(T1 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6FF26A0", Offset = "0x6FF10A0", VA = "0x186FF26A0")]
	public void MAAIKGLMNNO(T1 OIKPBCOOHJG, bool DKCCEMLBNLC, bool OCOLHDAIBMP = false, bool MBGLDHPALEF = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class APPPECLELIB<T1, T2> : NKLLFPAHDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private T1 GGLAKAOFGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T2 GOFBNPBAAMH;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	protected virtual T1 AFINGNIELAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1052880", Offset = "0x1051280", VA = "0x181052880", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1265140", Offset = "0x1263B40", VA = "0x181265140", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	protected virtual T2 OOJAEPMMEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x104A310", Offset = "0x1048D10", VA = "0x18104A310", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x10529C0", Offset = "0x10513C0", VA = "0x1810529C0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public T2 KMADLKPOEAO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x53213D0", Offset = "0x531FDD0", VA = "0x1853213D0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	protected override object IDJLFIHEALI
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5322750", Offset = "0x5321150", VA = "0x185322750", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5321AE0", Offset = "0x53204E0", VA = "0x185321AE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5322930", Offset = "0x5321330", VA = "0x185322930", Slot = "9")]
	protected override bool KGHKOLDLAIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5325860", Offset = "0x5324260", VA = "0x185325860")]
	protected APPPECLELIB([In] IMHIIJLELOB GPCDCFCPGFK, T1 GGLAKAOFGCJ, T2 GOFBNPBAAMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x53258D0", Offset = "0x53242D0", VA = "0x1853258D0")]
	protected APPPECLELIB(POIAKMBAMML JGGGINODJOB, AENFEPMOKIA HCLPHJDKMCA, string LNBCHJPEENA, T1 GGLAKAOFGCJ, T2 GOFBNPBAAMH, BKEOBCFPEMG PLJPJNMHNGP, bool BEFAOPLFOOA, Action EMBEDGKMMHB, NOINHKGEMFM DFBAEDAKHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5322770", Offset = "0x5321170", VA = "0x185322770")]
	public T1 INBBHAKPJFM()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5321790", Offset = "0x5320190", VA = "0x185321790")]
	public void BOKDBLNJANE(T1 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x53213D0", Offset = "0x531FDD0", VA = "0x1853213D0")]
	public T2 KCHDNCPEBGJ()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x53214C0", Offset = "0x531FEC0", VA = "0x1853214C0")]
	public void BNBCMKLCDLM(T2 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5324280", Offset = "0x5322C80", VA = "0x185324280")]
	public void MAAIKGLMNNO(T1 IAMLOMGHONH, T2 IPHFBMBPNBK, bool DKCCEMLBNLC = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class KFCHCOAMFNE<T1, T2, T3> : NKLLFPAHDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private T1 GGLAKAOFGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T2 GOFBNPBAAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private T3 GPDMHFAJHIP;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	protected virtual T1 AFINGNIELAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA91AC0", Offset = "0xA904C0", VA = "0x180A91AC0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA91C30", Offset = "0xA90630", VA = "0x180A91C30", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	protected virtual T2 OOJAEPMMEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x108BC20", Offset = "0x108A620", VA = "0x18108BC20", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x108C9C0", Offset = "0x108B3C0", VA = "0x18108C9C0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	protected virtual T3 NIGAPDGJCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xAA0990", Offset = "0xA9F390", VA = "0x180AA0990", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xDD12B0", Offset = "0xDCFCB0", VA = "0x180DD12B0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T1 HAMOFINJINM
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5322770", Offset = "0x5321170", VA = "0x185322770")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T2 KMADLKPOEAO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x53213D0", Offset = "0x531FDD0", VA = "0x1853213D0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T3 EAIJDGDJELG
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x54E8D50", Offset = "0x54E7750", VA = "0x1854E8D50")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected override object IDJLFIHEALI
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5322750", Offset = "0x5321150", VA = "0x185322750", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x54E9400", Offset = "0x54E7E00", VA = "0x1854E9400", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x54EB420", Offset = "0x54E9E20", VA = "0x1854EB420", Slot = "9")]
	protected override bool KGHKOLDLAIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x54EE2C0", Offset = "0x54ECCC0", VA = "0x1854EE2C0")]
	protected KFCHCOAMFNE([In] IMHIIJLELOB GPCDCFCPGFK, T1 GGLAKAOFGCJ, T2 GOFBNPBAAMH, T3 GPDMHFAJHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x54EEF80", Offset = "0x54ED980", VA = "0x1854EEF80")]
	protected KFCHCOAMFNE(POIAKMBAMML JGGGINODJOB, AENFEPMOKIA HCLPHJDKMCA, string LNBCHJPEENA, T1 GGLAKAOFGCJ, T2 GOFBNPBAAMH, T3 GPDMHFAJHIP, BKEOBCFPEMG PLJPJNMHNGP, bool BEFAOPLFOOA, Action EMBEDGKMMHB, NOINHKGEMFM DFBAEDAKHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5322770", Offset = "0x5321170", VA = "0x185322770")]
	public T1 INBBHAKPJFM()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x54E8800", Offset = "0x54E7200", VA = "0x1854E8800")]
	public void BOKDBLNJANE(T1 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x53213D0", Offset = "0x531FDD0", VA = "0x1853213D0")]
	public T2 KCHDNCPEBGJ()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x54E8270", Offset = "0x54E6C70", VA = "0x1854E8270")]
	public void BNBCMKLCDLM(T2 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x54E8D50", Offset = "0x54E7750", VA = "0x1854E8D50")]
	public T3 CCBGGJBGNLF()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x54E9370", Offset = "0x54E7D70", VA = "0x1854E9370")]
	public void FABOKHAPHKO(T3 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x54EC040", Offset = "0x54EAA40", VA = "0x1854EC040")]
	public void MAAIKGLMNNO(T1 IAMLOMGHONH, T2 IPHFBMBPNBK, T3 GANGDPJOPPI, bool DKCCEMLBNLC = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class MNKHIFCMCJA<T1, T2, T3, T4> : NKLLFPAHDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T1 GGLAKAOFGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private T2 GOFBNPBAAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private T3 GPDMHFAJHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private T4 AFBDMLIHAHF;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	protected virtual T1 AFINGNIELAH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xF0BC70", Offset = "0xF0A670", VA = "0x180F0BC70", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1038A00", Offset = "0x1037400", VA = "0x181038A00", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	protected virtual T2 OOJAEPMMEIM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1F086C0", Offset = "0x1F070C0", VA = "0x181F086C0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x583C9D0", Offset = "0x583B3D0", VA = "0x18583C9D0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	protected virtual T3 NIGAPDGJCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x583FF30", Offset = "0x583E930", VA = "0x18583FF30", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x583DB90", Offset = "0x583C590", VA = "0x18583DB90", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	protected virtual T4 LKJKEJKLPLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x16521E0", Offset = "0x1650BE0", VA = "0x1816521E0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x15C25F0", Offset = "0x15C0FF0", VA = "0x1815C25F0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public T2 KMADLKPOEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x53213F0", Offset = "0x531FDF0", VA = "0x1853213F0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T3 EAIJDGDJELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x54E8D20", Offset = "0x54E7720", VA = "0x1854E8D20")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T4 GENBLIEGFHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x2062690", Offset = "0x2061090", VA = "0x182062690")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	protected override object IDJLFIHEALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5322750", Offset = "0x5321150", VA = "0x185322750", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x583F9E0", Offset = "0x583E3E0", VA = "0x18583F9E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x58400B0", Offset = "0x583EAB0", VA = "0x1858400B0", Slot = "9")]
	protected override bool KGHKOLDLAIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x5845A70", Offset = "0x5844470", VA = "0x185845A70")]
	protected MNKHIFCMCJA([In] IMHIIJLELOB GPCDCFCPGFK, T1 GGLAKAOFGCJ, T2 GOFBNPBAAMH, T3 GPDMHFAJHIP, T4 AFBDMLIHAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x5844F70", Offset = "0x5843970", VA = "0x185844F70")]
	protected MNKHIFCMCJA(POIAKMBAMML JGGGINODJOB, AENFEPMOKIA HCLPHJDKMCA, string LNBCHJPEENA, T1 GGLAKAOFGCJ, T2 GOFBNPBAAMH, T3 GPDMHFAJHIP, T4 AFBDMLIHAHF, BKEOBCFPEMG PLJPJNMHNGP, bool BEFAOPLFOOA, Action EMBEDGKMMHB, NOINHKGEMFM DFBAEDAKHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5322770", Offset = "0x5321170", VA = "0x185322770")]
	public T1 INBBHAKPJFM()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x583D9A0", Offset = "0x583C3A0", VA = "0x18583D9A0")]
	public void BOKDBLNJANE(T1 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x53213F0", Offset = "0x531FDF0", VA = "0x1853213F0")]
	public T2 KCHDNCPEBGJ()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x583D190", Offset = "0x583BB90", VA = "0x18583D190")]
	public void BNBCMKLCDLM(T2 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x54E8D20", Offset = "0x54E7720", VA = "0x1854E8D20")]
	public T3 CCBGGJBGNLF()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x583E7B0", Offset = "0x583D1B0", VA = "0x18583E7B0")]
	public void FABOKHAPHKO(T3 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x2062690", Offset = "0x2061090", VA = "0x182062690")]
	public T4 DDLBONHPDPO()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x583E180", Offset = "0x583CB80", VA = "0x18583E180")]
	public void EHDDPHDHCPJ(T4 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5842DF0", Offset = "0x58417F0", VA = "0x185842DF0")]
	public void MAAIKGLMNNO(T1 IAMLOMGHONH, T2 IPHFBMBPNBK, T3 GANGDPJOPPI, T4 NILBNHGABFE, bool DKCCEMLBNLC = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class OBGAEIIOGBO<T1, T2, T3, T4, T5> : NKLLFPAHDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private T1 GGLAKAOFGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T2 GOFBNPBAAMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private T3 GPDMHFAJHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private T4 AFBDMLIHAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private T5 MBIGEFLJNAJ;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	protected virtual T1 AFINGNIELAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xAF41D0", Offset = "0xAF2BD0", VA = "0x180AF41D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xAF41C0", Offset = "0xAF2BC0", VA = "0x180AF41C0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	protected virtual T2 OOJAEPMMEIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x1579480", Offset = "0x1577E80", VA = "0x181579480", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x1577EB0", Offset = "0x15768B0", VA = "0x181577EB0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	protected virtual T3 NIGAPDGJCCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xAA0990", Offset = "0xA9F390", VA = "0x180AA0990", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xDD12B0", Offset = "0xDCFCB0", VA = "0x180DD12B0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	protected virtual T4 LKJKEJKLPLM
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xABCD10", Offset = "0xABB710", VA = "0x180ABCD10", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xABCD70", Offset = "0xABB770", VA = "0x180ABCD70", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	protected virtual T5 AJIEMCDFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x17A0CC0", Offset = "0x179F6C0", VA = "0x1817A0CC0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return (T5)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x179FE70", Offset = "0x179E870", VA = "0x18179FE70", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	protected override object IDJLFIHEALI
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5322750", Offset = "0x5321150", VA = "0x185322750", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x59F1160", Offset = "0x59EFB60", VA = "0x1859F1160", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x59F1980", Offset = "0x59F0380", VA = "0x1859F1980", Slot = "9")]
	protected override bool KGHKOLDLAIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x59F48B0", Offset = "0x59F32B0", VA = "0x1859F48B0")]
	protected OBGAEIIOGBO(POIAKMBAMML JGGGINODJOB, AENFEPMOKIA HCLPHJDKMCA, string LNBCHJPEENA, T1 GGLAKAOFGCJ, T2 GOFBNPBAAMH, T3 GPDMHFAJHIP, T4 AFBDMLIHAHF, T5 MBIGEFLJNAJ, BKEOBCFPEMG PLJPJNMHNGP, bool BEFAOPLFOOA, Action EMBEDGKMMHB, NOINHKGEMFM DFBAEDAKHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x5322770", Offset = "0x5321170", VA = "0x185322770")]
	public T1 INBBHAKPJFM()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x59EFE20", Offset = "0x59EE820", VA = "0x1859EFE20")]
	public void BOKDBLNJANE(T1 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x53213D0", Offset = "0x531FDD0", VA = "0x1853213D0")]
	public T2 KCHDNCPEBGJ()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x59EF8A0", Offset = "0x59EE2A0", VA = "0x1859EF8A0")]
	public void BNBCMKLCDLM(T2 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x54E8D50", Offset = "0x54E7750", VA = "0x1854E8D50")]
	public T3 CCBGGJBGNLF()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x59F0750", Offset = "0x59EF150", VA = "0x1859F0750")]
	public void FABOKHAPHKO(T3 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x2062690", Offset = "0x2061090", VA = "0x182062690")]
	public T4 DDLBONHPDPO()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x59F0290", Offset = "0x59EEC90", VA = "0x1859F0290")]
	public void EHDDPHDHCPJ(T4 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x59F1570", Offset = "0x59EFF70", VA = "0x1859F1570")]
	public T5 HFIEDGEBMDC()
	{
		return (T5)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x59F44F0", Offset = "0x59F2EF0", VA = "0x1859F44F0")]
	public void NHKNOAJONPP(T5 OIKPBCOOHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x59F3D50", Offset = "0x59F2750", VA = "0x1859F3D50")]
	public void MAAIKGLMNNO(T1 IAMLOMGHONH, T2 IPHFBMBPNBK, T3 GANGDPJOPPI, T4 NILBNHGABFE, T5 DMBHKDINGOM)
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
