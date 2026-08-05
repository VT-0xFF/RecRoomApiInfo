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
public interface NFNGOFGGLEH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LIBMLFAGEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool BJNHHAHPFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NGPBJJLAELK BPMKJOHEDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	int OOLHNBINKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool CCALGEKHJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool IOFOEGOLCOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action JFLEOFLAKNL;

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CACNNPFBALK();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void APLKCOLPJNI(object HNGIMMGBLII, bool JICJBOHKJMM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CBCNHHODIKB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PIEGDPOODEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string PMMIAHCCEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool APBPGAEHLMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BAGDLCHKMFD<T> : PIEGDPOODEJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	T NMPIFGHCOKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NOAONDDLDKO(T BDPHCAGFJCP);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class LINJNJKBIDG<T> : BAGDLCHKMFD<T>, PIEGDPOODEJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly MNDJHGGFBIF<T> MCEHKCKJOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MNDJHGGFBIF<T> LBGOJDBJFGC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public string PMMIAHCCEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xF7B290", Offset = "0xF79890", VA = "0x180F7B290", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool BFACJPJLOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x571C4A0", Offset = "0x571AAA0", VA = "0x18571C4A0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public T ODILADDBCPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x571C350", Offset = "0x571A950", VA = "0x18571C350", Slot = "11")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x571C6D0", Offset = "0x571ACD0", VA = "0x18571C6D0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public T NMPIFGHCOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x571C110", Offset = "0x571A710", VA = "0x18571C110", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x571C5A0", Offset = "0x571ABA0", VA = "0x18571C5A0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public T FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x571C110", Offset = "0x571A710", VA = "0x18571C110")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x571C0A0", Offset = "0x571A6A0", VA = "0x18571C0A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool APBPGAEHLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4FE08D0", Offset = "0x4FDEED0", VA = "0x184FE08D0", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4FE0200", Offset = "0x4FDE800", VA = "0x184FE0200", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool DOGCGDIFJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x571C170", Offset = "0x571A770", VA = "0x18571C170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x571C1F0", Offset = "0x571A7F0", VA = "0x18571C1F0", Slot = "10")]
	public void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x571CB40", Offset = "0x571B140", VA = "0x18571CB40")]
	public LINJNJKBIDG([In] IGEMJKBHKGN DAJAOHIJHHL, T MOELPNNFBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x571C2D0", Offset = "0x571A8D0", VA = "0x18571C2D0")]
	private void JCKMONMGJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x571C800", Offset = "0x571AE00", VA = "0x18571C800", Slot = "5")]
	public void NOAONDDLDKO(T BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x571C7B0", Offset = "0x571ADB0", VA = "0x18571C7B0")]
	public void NOAONDDLDKO(T BDPHCAGFJCP, bool PDDEMMBHLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0220", Offset = "0x4FDE820", VA = "0x184FE0220", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class PCHHPAOGMPM<T1, T2> : BAGDLCHKMFD<(T1, T2)>, PIEGDPOODEJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly AHCJDJHLDOO<T1, T2> MCEHKCKJOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly AHCJDJHLDOO<T1, T2> LBGOJDBJFGC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string PMMIAHCCEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xF7B290", Offset = "0xF79890", VA = "0x180F7B290", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BFACJPJLOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5C59420", Offset = "0x5C57A20", VA = "0x185C59420", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BCCDCOGMCMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5500710", Offset = "0x54FED10", VA = "0x185500710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool FNDDAGNBDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5C58870", Offset = "0x5C56E70", VA = "0x185C58870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public (T1, T2) ODILADDBCPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5C59190", Offset = "0x5C57790", VA = "0x185C59190", Slot = "11")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5C59950", Offset = "0x5C57F50", VA = "0x185C59950", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public (T1, T2) NMPIFGHCOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5C58550", Offset = "0x5C56B50", VA = "0x185C58550", Slot = "4")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5C596E0", Offset = "0x5C57CE0", VA = "0x185C596E0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public (T1, T2) FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5C58820", Offset = "0x5C56E20", VA = "0x185C58820")]
		get
		{
			return default((T1, T2));
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5C57E50", Offset = "0x5C56450", VA = "0x185C57E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T1 MHDLDCCMLND
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5C57F70", Offset = "0x5C56570", VA = "0x185C57F70")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5C59E70", Offset = "0x5C58470", VA = "0x185C59E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T1 JEHKGCCHDOB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5C57E90", Offset = "0x5C56490", VA = "0x185C57E90")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T1 CKFBBJDKFAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5C57E90", Offset = "0x5C56490", VA = "0x185C57E90")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5C582B0", Offset = "0x5C568B0", VA = "0x185C582B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T2 AOPGGAEMGCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5C58250", Offset = "0x5C56850", VA = "0x185C58250")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5C57FB0", Offset = "0x5C565B0", VA = "0x185C57FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T2 NMONFIJPGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5C57F10", Offset = "0x5C56510", VA = "0x185C57F10")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public T2 JCHLBGKKOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5C57F10", Offset = "0x5C56510", VA = "0x185C57F10")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5C59C40", Offset = "0x5C58240", VA = "0x185C59C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool APBPGAEHLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4FE08D0", Offset = "0x4FDEED0", VA = "0x184FE08D0", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4FE0200", Offset = "0x4FDE800", VA = "0x184FE0200", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5C58B30", Offset = "0x5C57130", VA = "0x185C58B30", Slot = "10")]
	public void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5C5A810", Offset = "0x5C58E10", VA = "0x185C5A810")]
	public PCHHPAOGMPM([In] IGEMJKBHKGN DAJAOHIJHHL, T1 DBHKGMLJKJH, T2 EHLEOFMOAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5C58D10", Offset = "0x5C57310", VA = "0x185C58D10")]
	private void JCKMONMGJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5C57C90", Offset = "0x5C56290", VA = "0x185C57C90")]
	public void ABGNLMGOAFE(T1 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5C59CF0", Offset = "0x5C582F0", VA = "0x185C59CF0")]
	public void NOAONDDLDKO(T1 MJOJDDHMFKN, T2 KKLBBHIFHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5C58710", Offset = "0x5C56D10", VA = "0x185C58710", Slot = "5")]
	private void HLNIEFNBCEB((T1, T2) EFGJHINBPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0220", Offset = "0x4FDE820", VA = "0x184FE0220", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class JPKFCHLCCPB<T1, T2, T3> : BAGDLCHKMFD<(T1, T2, T3)>, PIEGDPOODEJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EIBEEMBABDA<T1, T2, T3> MCEHKCKJOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly EIBEEMBABDA<T1, T2, T3> LBGOJDBJFGC;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string PMMIAHCCEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xF7B290", Offset = "0xF79890", VA = "0x180F7B290", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool BFACJPJLOCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5500360", Offset = "0x54FE960", VA = "0x185500360", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool BCCDCOGMCMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5500710", Offset = "0x54FED10", VA = "0x185500710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool FNDDAGNBDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x54FFAD0", Offset = "0x54FE0D0", VA = "0x1854FFAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public bool ANGCIGNGGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x54FF1A0", Offset = "0x54FD7A0", VA = "0x1854FF1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public (T1, T2, T3) ODILADDBCPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5500120", Offset = "0x54FE720", VA = "0x185500120", Slot = "11")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5500B00", Offset = "0x54FF100", VA = "0x185500B00", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public (T1, T2, T3) NMPIFGHCOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x54FF4A0", Offset = "0x54FDAA0", VA = "0x1854FF4A0", Slot = "4")]
		get
		{
			return default((T1, T2, T3));
		}
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x55008A0", Offset = "0x54FEEA0", VA = "0x1855008A0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T1 MHDLDCCMLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x54FECF0", Offset = "0x54FD2F0", VA = "0x1854FECF0")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5500D70", Offset = "0x54FF370", VA = "0x185500D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public T1 JEHKGCCHDOB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x54FEC20", Offset = "0x54FD220", VA = "0x1854FEC20")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T1 CKFBBJDKFAH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x54FEC20", Offset = "0x54FD220", VA = "0x1854FEC20")]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x54FF0A0", Offset = "0x54FD6A0", VA = "0x1854FF0A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public T2 AOPGGAEMGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x54FF060", Offset = "0x54FD660", VA = "0x1854FF060")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x54FEFC0", Offset = "0x54FD5C0", VA = "0x1854FEFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public T2 NMONFIJPGOE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x54FECB0", Offset = "0x54FD2B0", VA = "0x1854FECB0")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T2 JCHLBGKKOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x54FECB0", Offset = "0x54FD2B0", VA = "0x1854FECB0")]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5500C00", Offset = "0x54FF200", VA = "0x185500C00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public T3 JNLCNGIMILO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x54FEC60", Offset = "0x54FD260", VA = "0x1854FEC60")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x54FEE70", Offset = "0x54FD470", VA = "0x1854FEE70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public T3 OFJFBLCIEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x54FF0C0", Offset = "0x54FD6C0", VA = "0x1854FF0C0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public T3 HONKLPDNJBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x54FF0C0", Offset = "0x54FD6C0", VA = "0x1854FF0C0")]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x54FFFC0", Offset = "0x54FE5C0", VA = "0x1854FFFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool APBPGAEHLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4FE08D0", Offset = "0x4FDEED0", VA = "0x184FE08D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x54FFC40", Offset = "0x54FE240", VA = "0x1854FFC40", Slot = "10")]
	public void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x55015E0", Offset = "0x54FFBE0", VA = "0x1855015E0")]
	public JPKFCHLCCPB([In] IGEMJKBHKGN DAJAOHIJHHL, T1 DBHKGMLJKJH, T2 EHLEOFMOAJM, T3 NHMHEKOBBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x54FFEC0", Offset = "0x54FE4C0", VA = "0x1854FFEC0")]
	private void JCKMONMGJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x54FEB30", Offset = "0x54FD130", VA = "0x1854FEB30")]
	public void ABGNLMGOAFE(T1 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x54FF950", Offset = "0x54FDF50", VA = "0x1854FF950")]
	public void HECPKOAPHPP(T2 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5501090", Offset = "0x54FF690", VA = "0x185501090")]
	public void PGAGNEOHHNE(T3 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5500C20", Offset = "0x54FF220", VA = "0x185500C20")]
	public void NOAONDDLDKO(T1 MJOJDDHMFKN, T2 KKLBBHIFHIP, T3 KJKKGKIPHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x54FF740", Offset = "0x54FDD40", VA = "0x1854FF740", Slot = "5")]
	private void HDCGAFKOJLA((T1, T2, T3) EFGJHINBPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0220", Offset = "0x4FDE820", VA = "0x184FE0220", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class GFJGMNIDGHP<T1, T2, T3, T4> : BAGDLCHKMFD<(T1, T2, T3, T4)>, PIEGDPOODEJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly KKANMIGCHPO<T1, T2, T3, T4> MCEHKCKJOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly KKANMIGCHPO<T1, T2, T3, T4> LBGOJDBJFGC;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string PMMIAHCCEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xF7B290", Offset = "0xF79890", VA = "0x180F7B290", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public (T1, T2, T3, T4) NMPIFGHCOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4FE03B0", Offset = "0x4FDE9B0", VA = "0x184FE03B0", Slot = "4")]
		get
		{
			return default((T1, T2, T3, T4));
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4FE07E0", Offset = "0x4FDEDE0", VA = "0x184FE07E0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public T2 NMONFIJPGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4F49A70", Offset = "0x4F48070", VA = "0x184F49A70")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T3 OFJFBLCIEOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4F49D80", Offset = "0x4F48380", VA = "0x184F49D80")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public T4 JNENDBNLIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x45BE620", Offset = "0x45BCC20", VA = "0x1845BE620")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool APBPGAEHLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4FE08D0", Offset = "0x4FDEED0", VA = "0x184FE08D0", Slot = "7")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4FE0200", Offset = "0x4FDE800", VA = "0x184FE0200", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4FE08F0", Offset = "0x4FDEEF0", VA = "0x184FE08F0")]
	public GFJGMNIDGHP([In] IGEMJKBHKGN DAJAOHIJHHL, T1 DBHKGMLJKJH, T2 EHLEOFMOAJM, T3 NHMHEKOBBJD, T4 LHCNLFJLGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0650", Offset = "0x4FDEC50", VA = "0x184FE0650")]
	private void JCKMONMGJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4FDFF50", Offset = "0x4FDE550", VA = "0x184FDFF50")]
	public void ABGNLMGOAFE(T1 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0880", Offset = "0x4FDEE80", VA = "0x184FE0880")]
	public void NOAONDDLDKO(T1 MJOJDDHMFKN, T2 KKLBBHIFHIP, T3 KJKKGKIPHBG, T4 EOFLBDENJGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0180", Offset = "0x4FDE780", VA = "0x184FE0180", Slot = "5")]
	private void BPIGDDCMDDO((T1, T2, T3, T4) EFGJHINBPCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0220", Offset = "0x4FDE820", VA = "0x184FE0220", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class KMJFPBKAGDM
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x85B3ED0", Offset = "0x85B24D0", VA = "0x1885B3ED0")]
	public static string PGDBBFFFCBK(this IGEMJKBHKGN DAJAOHIJHHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xAF6010", Offset = "0xAF4610", VA = "0x180AF6010")]
	public static HHLNNNGBPHH EJHDHODAPDC(this IGEMJKBHKGN DAJAOHIJHHL)
	{
		return default(HHLNNNGBPHH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MNDJHGGFBIF<T> : OMDIIEGHHDL<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x597AE80", Offset = "0x5979480", VA = "0x18597AE80")]
	public MNDJHGGFBIF([In] IGEMJKBHKGN DAJAOHIJHHL, T DAKPJNHJLJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x597D340", Offset = "0x597B940", VA = "0x18597D340")]
	public MNDJHGGFBIF(FLBLBACKMJL HHPFOCCGJIF, NGPBJJLAELK LIOICDJHFAF, string HFLDIIIPBCG, T DAKPJNHJLJO, HHLNNNGBPHH FJNIBCMDBGB, [Optional] Action GDMDDGECOJI, [Optional] HEDLNDJLAEM KEINHBFFLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x597DBA0", Offset = "0x597C1A0", VA = "0x18597DBA0")]
	public MNDJHGGFBIF(FLBLBACKMJL HHPFOCCGJIF, string HFLDIIIPBCG, T DAKPJNHJLJO, HHLNNNGBPHH FJNIBCMDBGB, [Optional] Action GDMDDGECOJI, [Optional] HEDLNDJLAEM KEINHBFFLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x597BD90", Offset = "0x597A390", VA = "0x18597BD90")]
	public MNDJHGGFBIF(FLBLBACKMJL HHPFOCCGJIF, string HFLDIIIPBCG, T DAKPJNHJLJO, HHLNNNGBPHH FJNIBCMDBGB, bool HGABBJFBLNA, [Optional] Action GDMDDGECOJI, [Optional] HEDLNDJLAEM KEINHBFFLJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class AHCJDJHLDOO<T1, T2> : PMFPOHHIGON<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x53E7760", Offset = "0x53E5D60", VA = "0x1853E7760")]
	public AHCJDJHLDOO([In] IGEMJKBHKGN DAJAOHIJHHL, T1 CGGBLKGNBMG, T2 AFCFHBFMDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x53EB000", Offset = "0x53E9600", VA = "0x1853EB000")]
	public AHCJDJHLDOO(FLBLBACKMJL HHPFOCCGJIF, NGPBJJLAELK LIOICDJHFAF, string HFLDIIIPBCG, T1 CGGBLKGNBMG, T2 AFCFHBFMDNL, HHLNNNGBPHH FJNIBCMDBGB, [Optional] Action GDMDDGECOJI, [Optional] HEDLNDJLAEM KEINHBFFLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x53EA3A0", Offset = "0x53E89A0", VA = "0x1853EA3A0")]
	public AHCJDJHLDOO(FLBLBACKMJL HHPFOCCGJIF, string HFLDIIIPBCG, T1 CGGBLKGNBMG, T2 AFCFHBFMDNL, HHLNNNGBPHH FJNIBCMDBGB, [Optional] Action GDMDDGECOJI, [Optional] HEDLNDJLAEM KEINHBFFLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x53EB0F0", Offset = "0x53E96F0", VA = "0x1853EB0F0")]
	public AHCJDJHLDOO(FLBLBACKMJL HHPFOCCGJIF, string HFLDIIIPBCG, T1 CGGBLKGNBMG, T2 AFCFHBFMDNL, HHLNNNGBPHH FJNIBCMDBGB, bool HGABBJFBLNA, [Optional] Action GDMDDGECOJI, [Optional] HEDLNDJLAEM KEINHBFFLJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class EIBEEMBABDA<T1, T2, T3> : GEGBFOCGMFG<T1, T2, T3>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4A7FE60", Offset = "0x4A7E460", VA = "0x184A7FE60")]
	public EIBEEMBABDA([In] IGEMJKBHKGN DAJAOHIJHHL, T1 CGGBLKGNBMG, T2 AFCFHBFMDNL, T3 FBMFLKJPDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4A805A0", Offset = "0x4A7EBA0", VA = "0x184A805A0")]
	public EIBEEMBABDA(FLBLBACKMJL HHPFOCCGJIF, string HFLDIIIPBCG, T1 CGGBLKGNBMG, T2 AFCFHBFMDNL, T3 FBMFLKJPDHL, HHLNNNGBPHH FJNIBCMDBGB, [Optional] Action GDMDDGECOJI, [Optional] HEDLNDJLAEM KEINHBFFLJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KKANMIGCHPO<T1, T2, T3, T4> : DJHJLCOBJFA<T1, T2, T3, T4>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x55D4E70", Offset = "0x55D3470", VA = "0x1855D4E70")]
	public KKANMIGCHPO([In] IGEMJKBHKGN DAJAOHIJHHL, T1 CGGBLKGNBMG, T2 AFCFHBFMDNL, T3 FBMFLKJPDHL, T4 CLPHINPIBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x55D57A0", Offset = "0x55D3DA0", VA = "0x1855D57A0")]
	public KKANMIGCHPO(FLBLBACKMJL HHPFOCCGJIF, NGPBJJLAELK LIOICDJHFAF, string HFLDIIIPBCG, T1 CGGBLKGNBMG, T2 AFCFHBFMDNL, T3 FBMFLKJPDHL, T4 CLPHINPIBGC, HHLNNNGBPHH FJNIBCMDBGB, [Optional] Action GDMDDGECOJI, [Optional] HEDLNDJLAEM KEINHBFFLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x55D58D0", Offset = "0x55D3ED0", VA = "0x1855D58D0")]
	public KKANMIGCHPO(FLBLBACKMJL HHPFOCCGJIF, string HFLDIIIPBCG, T1 CGGBLKGNBMG, T2 AFCFHBFMDNL, T3 FBMFLKJPDHL, T4 CLPHINPIBGC, HHLNNNGBPHH FJNIBCMDBGB, [Optional] Action GDMDDGECOJI, [Optional] HEDLNDJLAEM KEINHBFFLJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NENIAMAFAJE<T1, T2, T3, T4, T5> : GMMNJEPNMLK<T1, T2, T3, T4, T5>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x59D4C80", Offset = "0x59D3280", VA = "0x1859D4C80")]
	public NENIAMAFAJE(FLBLBACKMJL HHPFOCCGJIF, NGPBJJLAELK LIOICDJHFAF, string HFLDIIIPBCG, T1 CGGBLKGNBMG, T2 AFCFHBFMDNL, T3 FBMFLKJPDHL, T4 CLPHINPIBGC, T5 PEFNGICNJDL, HHLNNNGBPHH FJNIBCMDBGB, [Optional] Action GDMDDGECOJI, [Optional] HEDLNDJLAEM KEINHBFFLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x59D4D90", Offset = "0x59D3390", VA = "0x1859D4D90")]
	public NENIAMAFAJE(FLBLBACKMJL HHPFOCCGJIF, string HFLDIIIPBCG, T1 CGGBLKGNBMG, T2 AFCFHBFMDNL, T3 FBMFLKJPDHL, T4 CLPHINPIBGC, T5 PEFNGICNJDL, HHLNNNGBPHH FJNIBCMDBGB, [Optional] Action GDMDDGECOJI, [Optional] HEDLNDJLAEM KEINHBFFLJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BANDDEGKFFI<T> : OMDIIEGHHDL<T>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6787570", Offset = "0x6785B70", VA = "0x186787570")]
	public BANDDEGKFFI(NGPBJJLAELK LIOICDJHFAF, string HFLDIIIPBCG, T DAKPJNHJLJO, [Optional] Action GDMDDGECOJI, [Optional] HEDLNDJLAEM KEINHBFFLJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IDFNJHINLAO<T1, T2> : PMFPOHHIGON<T1, T2>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5225FC0", Offset = "0x52245C0", VA = "0x185225FC0")]
	public IDFNJHINLAO(NGPBJJLAELK LIOICDJHFAF, string HFLDIIIPBCG, T1 MJJKPFNLPHO, T2 BBNPEJJONED, [Optional] Action GDMDDGECOJI, [Optional] HEDLNDJLAEM KEINHBFFLJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CHHODDCIJCK
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MNDJHGGFBIF<T1> AONBCAPPAGB<T1>(string HFLDIIIPBCG, T1 MJJKPFNLPHO, HHLNNNGBPHH FJNIBCMDBGB, [Optional] Action GDMDDGECOJI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DGIKGDLJKPO : CHHODDCIJCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HEDLNDJLAEM KEINHBFFLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly FLBLBACKMJL HHPFOCCGJIF;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xA94D60", Offset = "0xA93360", VA = "0x180A94D60")]
	public DGIKGDLJKPO(HEDLNDJLAEM KEINHBFFLJA, FLBLBACKMJL OCCNJBFDPMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3BD2050", Offset = "0x3BD0650", VA = "0x183BD2050", Slot = "4")]
	public MNDJHGGFBIF<T1> AONBCAPPAGB<T1>(string HFLDIIIPBCG, T1 MJJKPFNLPHO, HHLNNNGBPHH FJNIBCMDBGB, [Optional] Action GDMDDGECOJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface EDCAAAFBPIH : FLBLBACKMJL
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ViewId JOGMBHAAFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FLBLBACKMJL
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool COEELAHHOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool FHAAPHDOBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	string IDMHMGADINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool NPDBKCPJHJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RegisterDestroyHandler(KFGKOJJMBIF CACEFGPINFP);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void UnregisterDestroyHandler(KFGKOJJMBIF CACEFGPINFP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LCAADCOAGDP
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x85B3F10", Offset = "0x85B2510", VA = "0x1885B3F10")]
	public static bool CKBMMMEDPBO(this FLBLBACKMJL HHPFOCCGJIF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HEDLNDJLAEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	NGPBJJLAELK OAPPNOICBCG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool DOGCGDIFJIL
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool KKFDDIOIMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LJDCNOCKLGC();

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "4")]
	object EFFIGFPFKHE(string HFLDIIIPBCG);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "5")]
	object EEEMGNDGLPJ(NGPBJJLAELK APPCGLLKPPM, string HFLDIIIPBCG);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FCCAIKBEFGD(string HFLDIIIPBCG, object BDPHCAGFJCP);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MNDECAIDOLG(NGPBJJLAELK APPCGLLKPPM, string HFLDIIIPBCG, object BDPHCAGFJCP);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PMHDPGHNMKA<T>(string HFLDIIIPBCG, T FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OCDFAJHJLOE([CanBeNull] NGPBJJLAELK APPCGLLKPPM, string HFLDIIIPBCG, BFKECNDHKCM PBHCNIDLNEB);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PHFCLEEJIAG([CanBeNull] NGPBJJLAELK APPCGLLKPPM, string HFLDIIIPBCG, BFKECNDHKCM PBHCNIDLNEB);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "11")]
	T IGKIIHKFLLA<T>(object FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "12")]
	object KILEMOEADGF<T>(T DAKPJNHJLJO);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void NGJGNHNOAHC();

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MENBGMHHPGG();

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ECFDADLJADL(string KOHOAAFOHKL);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct IGEMJKBHKGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NGPBJJLAELK LIOICDJHFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public FLBLBACKMJL HHPFOCCGJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public string HFLDIIIPBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public HHLNNNGBPHH FJNIBCMDBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool HGABBJFBLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action GDMDDGECOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public HEDLNDJLAEM KEINHBFFLJA;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x85B3E50", Offset = "0x85B2450", VA = "0x1885B3E50")]
	public IGEMJKBHKGN(IGEMJKBHKGN IBCMCOKAJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x85B3CC0", Offset = "0x85B22C0", VA = "0x1885B3CC0")]
	public IGEMJKBHKGN(FLBLBACKMJL HHPFOCCGJIF, string HFLDIIIPBCG, HHLNNNGBPHH FJNIBCMDBGB, [Optional] Action GDMDDGECOJI, [Optional] HEDLNDJLAEM KEINHBFFLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x85B3C70", Offset = "0x85B2270", VA = "0x1885B3C70")]
	public static IGEMJKBHKGN IEJLJBDKGKG(FLBLBACKMJL HHPFOCCGJIF, string HFLDIIIPBCG, HHLNNNGBPHH FJNIBCMDBGB, [Optional] Action GDMDDGECOJI, [Optional] HEDLNDJLAEM KEINHBFFLJA)
	{
		return default(IGEMJKBHKGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class IPADFCEEDCO
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3E17D20", Offset = "0x3E16320", VA = "0x183E17D20")]
	public static MNDJHGGFBIF<T> JLELNAHHJEJ<T>(this IGEMJKBHKGN DAJAOHIJHHL, T DAKPJNHJLJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3E17AC0", Offset = "0x3E160C0", VA = "0x183E17AC0")]
	public static AHCJDJHLDOO<T1, T2> JLELNAHHJEJ<T1, T2>(this IGEMJKBHKGN DAJAOHIJHHL, T1 KJNHIHBJEMH, T2 CPCLHJOBHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3E17B60", Offset = "0x3E16160", VA = "0x183E17B60")]
	public static EIBEEMBABDA<T1, T2, T3> JLELNAHHJEJ<T1, T2, T3>(this IGEMJKBHKGN DAJAOHIJHHL, T1 KJNHIHBJEMH, T2 CPCLHJOBHDJ, T3 BIADOFKNCNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3E17F60", Offset = "0x3E16560", VA = "0x183E17F60")]
	public static KKANMIGCHPO<T1, T2, T3, T4> JLELNAHHJEJ<T1, T2, T3, T4>(this IGEMJKBHKGN DAJAOHIJHHL, T1 KJNHIHBJEMH, T2 CPCLHJOBHDJ, T3 BIADOFKNCNP, T4 KOLBFPAAJMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3E17C10", Offset = "0x3E16210", VA = "0x183E17C10")]
	public static LINJNJKBIDG<T> OMIPEAHBFCD<T>(this IGEMJKBHKGN DAJAOHIJHHL, T DAKPJNHJLJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3E17AC0", Offset = "0x3E160C0", VA = "0x183E17AC0")]
	public static PCHHPAOGMPM<T1, T2> OMIPEAHBFCD<T1, T2>(this IGEMJKBHKGN DAJAOHIJHHL, T1 KJNHIHBJEMH, T2 CPCLHJOBHDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3E17B60", Offset = "0x3E16160", VA = "0x183E17B60")]
	public static JPKFCHLCCPB<T1, T2, T3> OMIPEAHBFCD<T1, T2, T3>(this IGEMJKBHKGN DAJAOHIJHHL, T1 KJNHIHBJEMH, T2 CPCLHJOBHDJ, T3 BIADOFKNCNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3E17F60", Offset = "0x3E16560", VA = "0x183E17F60")]
	public static GFJGMNIDGHP<T1, T2, T3, T4> OMIPEAHBFCD<T1, T2, T3, T4>(this IGEMJKBHKGN DAJAOHIJHHL, T1 KJNHIHBJEMH, T2 CPCLHJOBHDJ, T3 BIADOFKNCNP, T4 KOLBFPAAJMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class BFKECNDHKCM : KFGKOJJMBIF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[Flags]
	private enum OCIDMABEGAI
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
	private static Stack<HEDLNDJLAEM> DNBGENEEGEI;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static bool EOMFMPAKDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected readonly NGPBJJLAELK LIOICDJHFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected readonly FLBLBACKMJL HHPFOCCGJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected readonly string HFLDIIIPBCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected readonly HHLNNNGBPHH FJNIBCMDBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	protected readonly Action GDMDDGECOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	protected HEDLNDJLAEM GDIECPFCBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private OCIDMABEGAI OAKCIAMNOIJ;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public static HEDLNDJLAEM FOKEKONOPFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x85B32D0", Offset = "0x85B18D0", VA = "0x1885B32D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private bool HHBPABLBBFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x85B2490", Offset = "0x85B0A90", VA = "0x1885B2490")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x85B3940", Offset = "0x85B1F40", VA = "0x1885B3940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private bool NPAMNEHCOGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x85B3960", Offset = "0x85B1F60", VA = "0x1885B3960")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85B2BF0", Offset = "0x85B11F0", VA = "0x1885B2BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private bool PBFOICGNHME
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x85B3710", Offset = "0x85B1D10", VA = "0x1885B3710")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x85B23C0", Offset = "0x85B09C0", VA = "0x1885B23C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool APBPGAEHLMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x85B3970", Offset = "0x85B1F70", VA = "0x1885B3970")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x85B2910", Offset = "0x85B0F10", VA = "0x1885B2910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	protected virtual object GDHICCHEJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA95000", Offset = "0xA93600", VA = "0x180A95000", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA95050", Offset = "0xA93650", VA = "0x180A95050", Slot = "8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool ODFOOOFJDLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x85B33A0", Offset = "0x85B19A0", VA = "0x1885B33A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int EDMABCGKHKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xEA1DD0", Offset = "0xEA03D0", VA = "0x180EA1DD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xFF7A80", Offset = "0xFF6080", VA = "0x180FF7A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public string PMMIAHCCEKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool DOGCGDIFJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85B3190", Offset = "0x85B1790", VA = "0x1885B3190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x85B29D0", Offset = "0x85B0FD0", VA = "0x1885B29D0")]
	public static void DNPPCAOAOHP(HEDLNDJLAEM FEOPDAHJGHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool KFBFANMCNDM();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x85B3A50", Offset = "0x85B2050", VA = "0x1885B3A50")]
	protected BFKECNDHKCM(NGPBJJLAELK LIOICDJHFAF, FLBLBACKMJL HHPFOCCGJIF, string HFLDIIIPBCG, HHLNNNGBPHH FJNIBCMDBGB, Action GDMDDGECOJI, HEDLNDJLAEM KEINHBFFLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x85B2C10", Offset = "0x85B1210", VA = "0x1885B2C10", Slot = "1")]
	~BFKECNDHKCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x85B2A70", Offset = "0x85B1070", VA = "0x1885B2A70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x85B23F0", Offset = "0x85B09F0", VA = "0x1885B23F0")]
	private void BMCILMNIDPK(bool CHCMAFEELPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x85B3720", Offset = "0x85B1D20", VA = "0x1885B3720")]
	private object MCKIFMJEJBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x85B3550", Offset = "0x85B1B50", VA = "0x1885B3550")]
	protected void LJDCNOCKLGC(bool HGABBJFBLNA, object MOELPNNFBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x85B2380", Offset = "0x85B0980", VA = "0x1885B2380")]
	protected void ADPGIIFDGLO(object BDPHCAGFJCP, bool CGLHINPANBA = true, bool GMLNFIMAEBE = false, bool PDDEMMBHLJO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x85B2EA0", Offset = "0x85B14A0", VA = "0x1885B2EA0")]
	protected void GNECLLINEHE(object BDPHCAGFJCP, bool EMMFAEBMFIA, bool CGLHINPANBA, bool GMLNFIMAEBE = false, bool PDDEMMBHLJO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x85B31E0", Offset = "0x85B17E0", VA = "0x1885B31E0")]
	internal void JDFHFKEGAEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x85B25E0", Offset = "0x85B0BE0", VA = "0x1885B25E0")]
	private void CCLEINBCPAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x85B3340", Offset = "0x85B1940", VA = "0x1885B3340")]
	private void LACJMGDMPEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x85B3260", Offset = "0x85B1860", VA = "0x1885B3260", Slot = "4")]
	private void KIACBGBEADG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x85B2BE0", Offset = "0x85B11E0", VA = "0x1885B2BE0", Slot = "5")]
	private void FIBFJOHNFKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x85B24A0", Offset = "0x85B0AA0", VA = "0x1885B24A0")]
	public bool CANHNMNMEJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x85B2640", Offset = "0x85B0C40", VA = "0x1885B2640")]
	public bool CIBKANJDOAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x85B2C70", Offset = "0x85B1270", VA = "0x1885B2C70")]
	private bool GAJOFFKONKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x85B3890", Offset = "0x85B1E90", VA = "0x1885B3890")]
	internal void MFPEDJEEIEC(object BDPHCAGFJCP, int IMCNCIKIKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x85B2800", Offset = "0x85B0E00", VA = "0x1885B2800")]
	private void CIFFHEPHBEA(object BDPHCAGFJCP, bool GMLNFIMAEBE, bool PDDEMMBHLJO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x85B23E0", Offset = "0x85B09E0", VA = "0x1885B23E0")]
	private bool BGIDMDGANHB(OCIDMABEGAI KNIHNMIOGJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x85B3980", Offset = "0x85B1F80", VA = "0x1885B3980")]
	private void PHPKHPPBAPM(OCIDMABEGAI KNIHNMIOGJJ, bool FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x85B30F0", Offset = "0x85B16F0", VA = "0x1885B30F0")]
	public static string HPFJACBEAPD(NGPBJJLAELK LIOICDJHFAF, string HFLDIIIPBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x85B2DC0", Offset = "0x85B13C0", VA = "0x1885B2DC0")]
	public static string GGIKEBAJNLM(FLBLBACKMJL HHPFOCCGJIF, string HFLDIIIPBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x85B33F0", Offset = "0x85B19F0", VA = "0x1885B33F0")]
	public static bool LHEEGKABMKN(object IAFDMJDNHDH, object DFKKOPOBCBA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class MEEOBLGJGLB : HEDLNDJLAEM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly Dictionary<object, object> CDBLFIFJFFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly List<string> PPNBKDLFJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly Dictionary<object, object> MKDLNGGKBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly List<string> HHNMMLONJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool JBOBNJDEDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	protected readonly Dictionary<string, object> KEFMBFNKGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	protected readonly Dictionary<NGPBJJLAELK, Dictionary<string, object>> JLOGKHCALKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<string> FOOOBDIHGLP;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public abstract Dictionary<object, object> EONICPDDNNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public abstract int GOMKIBJGALM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public abstract NGPBJJLAELK OAPPNOICBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public abstract bool DOGCGDIFJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public abstract bool KKFDDIOIMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual bool KFPOHBHFNLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool AFNNFFJLAHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xAC3630", Offset = "0xAC1C30", VA = "0x180AC3630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3E9D490", Offset = "0x3E9BA90", VA = "0x183E9D490", Slot = "12")]
	public void PMHDPGHNMKA<T>(string HFLDIIIPBCG, T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x85B5D20", Offset = "0x85B4320", VA = "0x1885B5D20", Slot = "11")]
	public void MNDECAIDOLG(NGPBJJLAELK LIOICDJHFAF, string HFLDIIIPBCG, object FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x85B4B60", Offset = "0x85B3160", VA = "0x1885B4B60", Slot = "9")]
	public object EEEMGNDGLPJ(NGPBJJLAELK LIOICDJHFAF, string HFLDIIIPBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x85B4CF0", Offset = "0x85B32F0", VA = "0x1885B4CF0", Slot = "10")]
	public void FCCAIKBEFGD(string HFLDIIIPBCG, object FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x85B4C50", Offset = "0x85B3250", VA = "0x1885B4C50", Slot = "8")]
	public object EFFIGFPFKHE(string HFLDIIIPBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x85B5F00", Offset = "0x85B4500", VA = "0x1885B5F00", Slot = "13")]
	public void OCDFAJHJLOE(NGPBJJLAELK APPCGLLKPPM, string HFLDIIIPBCG, BFKECNDHKCM PBHCNIDLNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x85B62D0", Offset = "0x85B48D0", VA = "0x1885B62D0", Slot = "14")]
	public void PHFCLEEJIAG(NGPBJJLAELK APPCGLLKPPM, string HFLDIIIPBCG, BFKECNDHKCM PBHCNIDLNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x85B5790", Offset = "0x85B3D90", VA = "0x1885B5790")]
	private void MCMPHPKPLFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x85B5440", Offset = "0x85B3A40", VA = "0x1885B5440")]
	private void JEHNNPAFFMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x85B57E0", Offset = "0x85B3DE0", VA = "0x1885B57E0")]
	private void MDBOBDAAEEH(NGPBJJLAELK LIOICDJHFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x85B5270", Offset = "0x85B3870", VA = "0x1885B5270")]
	protected void HMJDAKABGKG(NGPBJJLAELK HELPKNNPDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x85B3F60", Offset = "0x85B2560", VA = "0x1885B3F60")]
	protected void CPBOMEMFHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x85B48C0", Offset = "0x85B2EC0", VA = "0x1885B48C0")]
	protected void ECEDNLHBMHD(IDictionary<object, object> MDKOAJOJBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x85B4FF0", Offset = "0x85B35F0", VA = "0x1885B4FF0")]
	protected void GGCNPCGHDPM(NGPBJJLAELK IDACCMFAENP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x85B6010", Offset = "0x85B4610", VA = "0x1885B6010")]
	protected void PDIGCAGCJPG(NGPBJJLAELK LIOICDJHFAF, IDictionary<object, object> MDKOAJOJBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x85B42E0", Offset = "0x85B28E0", VA = "0x1885B42E0")]
	private void DONBPPJDJKL(IDictionary<object, object> MDKOAJOJBNL, Dictionary<string, object> GLMLAKFCCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x85B5060", Offset = "0x85B3660", VA = "0x1885B5060")]
	private static void HLBCGBALBCH(object JHLFFDEHJFL, object BJBANDBIGLN, int IMCNCIKIKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x85B5490", Offset = "0x85B3A90", VA = "0x1885B5490")]
	private static void KBABKOLIIFE(Dictionary<string, object> GLMLAKFCCJO, string HFLDIIIPBCG, BFKECNDHKCM PBHCNIDLNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x85B4E10", Offset = "0x85B3410", VA = "0x1885B4E10")]
	private static void FDFINDANMLL(Dictionary<string, object> GLMLAKFCCJO, string HFLDIIIPBCG, BFKECNDHKCM PBHCNIDLNEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x85B5E00", Offset = "0x85B4400", VA = "0x1885B5E00", Slot = "17")]
	public void NGJGNHNOAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	protected abstract void BNDCMOGHEFJ(Dictionary<object, object> CDBLFIFJFFI);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x85B5840", Offset = "0x85B3E40", VA = "0x1885B5840", Slot = "18")]
	public void MENBGMHHPGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "28")]
	protected abstract void OMPKPFHHGLJ(Dictionary<object, object> MKDLNGGKBMM);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x85B60A0", Offset = "0x85B46A0", VA = "0x1885B60A0")]
	private void PFEAEEDJCEM(Dictionary<object, object> HLDBKKKHHOG, List<string> JCNEIPCACFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x85B4050", Offset = "0x85B2650", VA = "0x1885B4050")]
	private void CPCIBOMGCAE(IDictionary<object, object> MDKOAJOJBNL, [Out] int IMCNCIKIKKE, [Out] string[] KPMALKMEKCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x85B5920", Offset = "0x85B3F20", VA = "0x1885B5920")]
	public void MGMAAOEHNIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x85B56C0", Offset = "0x85B3CC0", VA = "0x1885B56C0")]
	public void KLCOONKOICH(NGPBJJLAELK LIOICDJHFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x85B59B0", Offset = "0x85B3FB0", VA = "0x1885B59B0")]
	public void MILGGKJEMAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "29")]
	protected abstract HashSet<int> OFOPFCAOBEG(bool HBHJJFBOODE, bool LLIFKDOOCJK);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x85B48D0", Offset = "0x85B2ED0", VA = "0x1885B48D0", Slot = "19")]
	public void ECFDADLJADL(string KOHOAAFOHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x85B53A0", Offset = "0x85B39A0", VA = "0x1885B53A0")]
	protected string HPFJACBEAPD(NGPBJJLAELK LIOICDJHFAF, string HFLDIIIPBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract object KILEMOEADGF<T>(T FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract T IGKIIHKFLLA<T>(object FKMNCAKIOFK);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "32")]
	public virtual void LJDCNOCKLGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x85B4760", Offset = "0x85B2D60", VA = "0x1885B4760", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "33")]
	protected virtual void HIKINCJDCAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x85B6580", Offset = "0x85B4B80", VA = "0x1885B6580")]
	protected MEEOBLGJGLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class OMDIIEGHHDL<T1> : BFKECNDHKCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private T1 MJJKPFNLPHO;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	protected virtual T1 NOOFJBBCDNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x1442610", Offset = "0x1440C10", VA = "0x181442610", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x557DDA0", Offset = "0x557C3A0", VA = "0x18557DDA0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	protected override object GDHICCHEJEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x45AF160", Offset = "0x45AD760", VA = "0x1845AF160", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5B8F930", Offset = "0x5B8DF30", VA = "0x185B8F930", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5B8E320", Offset = "0x5B8C920", VA = "0x185B8E320", Slot = "9")]
	protected override bool KFBFANMCNDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x5B90760", Offset = "0x5B8ED60", VA = "0x185B90760")]
	protected OMDIIEGHHDL([In] IGEMJKBHKGN DAJAOHIJHHL, T1 MJJKPFNLPHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5B904F0", Offset = "0x5B8EAF0", VA = "0x185B904F0")]
	protected OMDIIEGHHDL(NGPBJJLAELK LIOICDJHFAF, FLBLBACKMJL HHPFOCCGJIF, string HFLDIIIPBCG, T1 MJJKPFNLPHO, HHLNNNGBPHH FJNIBCMDBGB, bool HGABBJFBLNA, Action GDMDDGECOJI, HEDLNDJLAEM KEINHBFFLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x45B38F0", Offset = "0x45B1EF0", VA = "0x1845B38F0")]
	public T1 JLOHDPKHFGN()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5B8C010", Offset = "0x5B8A610", VA = "0x185B8C010")]
	public void ADPGIIFDGLO(T1 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5B8B0C0", Offset = "0x5B896C0", VA = "0x185B8B0C0")]
	public void ADPGIIFDGLO(T1 BDPHCAGFJCP, bool CGLHINPANBA, bool GMLNFIMAEBE = false, bool PDDEMMBHLJO = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public abstract class PMFPOHHIGON<T1, T2> : BFKECNDHKCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private T1 MJJKPFNLPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T2 BBNPEJJONED;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	protected virtual T1 NOOFJBBCDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1081920", Offset = "0x107FF20", VA = "0x181081920", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x128F040", Offset = "0x128D640", VA = "0x18128F040", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	protected virtual T2 CIPJCDKCAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1078BA0", Offset = "0x10771A0", VA = "0x181078BA0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x10821B0", Offset = "0x10807B0", VA = "0x1810821B0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public T2 PAHLBAJLEPA
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x16E4630", Offset = "0x16E2C30", VA = "0x1816E4630")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	protected override object GDHICCHEJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x45AF160", Offset = "0x45AD760", VA = "0x1845AF160", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5C8B740", Offset = "0x5C89D40", VA = "0x185C8B740", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5C8AC90", Offset = "0x5C89290", VA = "0x185C8AC90", Slot = "9")]
	protected override bool KFBFANMCNDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5C8D990", Offset = "0x5C8BF90", VA = "0x185C8D990")]
	protected PMFPOHHIGON([In] IGEMJKBHKGN DAJAOHIJHHL, T1 MJJKPFNLPHO, T2 BBNPEJJONED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5C8CBC0", Offset = "0x5C8B1C0", VA = "0x185C8CBC0")]
	protected PMFPOHHIGON(NGPBJJLAELK LIOICDJHFAF, FLBLBACKMJL HHPFOCCGJIF, string HFLDIIIPBCG, T1 MJJKPFNLPHO, T2 BBNPEJJONED, HHLNNNGBPHH FJNIBCMDBGB, bool HGABBJFBLNA, Action GDMDDGECOJI, HEDLNDJLAEM KEINHBFFLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x45B38D0", Offset = "0x45B1ED0", VA = "0x1845B38D0")]
	public T1 NKBHKFJBBJM()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5C8AFD0", Offset = "0x5C895D0", VA = "0x185C8AFD0")]
	public void KFGNNNPPMPP(T1 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x16E4630", Offset = "0x16E2C30", VA = "0x1816E4630")]
	public T2 CIPCMIBJHAH()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5C89600", Offset = "0x5C87C00", VA = "0x185C89600")]
	public void EMFBHHCEHDA(T2 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5C87C90", Offset = "0x5C86290", VA = "0x185C87C90")]
	public void ADPGIIFDGLO(T1 MJOJDDHMFKN, T2 KKLBBHIFHIP, bool CGLHINPANBA = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public abstract class GEGBFOCGMFG<T1, T2, T3> : BFKECNDHKCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private T1 MJJKPFNLPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private T2 BBNPEJJONED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private T3 NINNJKLKNIK;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	protected virtual T1 NOOFJBBCDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA99440", Offset = "0xA97A40", VA = "0x180A99440", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA99460", Offset = "0xA97A60", VA = "0x180A99460", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	protected virtual T2 CIPJCDKCAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x10B8870", Offset = "0x10B6E70", VA = "0x1810B8870", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x10B7DD0", Offset = "0x10B63D0", VA = "0x1810B7DD0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	protected virtual T3 LKOKGFDCMDG
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xAB05D0", Offset = "0xAAEBD0", VA = "0x180AB05D0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xE15350", Offset = "0xE13950", VA = "0x180E15350", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public T1 NOHJGCKJOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x45B38D0", Offset = "0x45B1ED0", VA = "0x1845B38D0")]
		get
		{
			return (T1)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public T2 PAHLBAJLEPA
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x16E4630", Offset = "0x16E2C30", VA = "0x1816E4630")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public T3 ENCJOBGFJCE
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x45B01D0", Offset = "0x45AE7D0", VA = "0x1845B01D0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected override object GDHICCHEJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x45AF160", Offset = "0x45AD760", VA = "0x1845AF160", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4FDD320", Offset = "0x4FDB920", VA = "0x184FDD320", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4FDBCB0", Offset = "0x4FDA2B0", VA = "0x184FDBCB0", Slot = "9")]
	protected override bool KFBFANMCNDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4FDEC90", Offset = "0x4FDD290", VA = "0x184FDEC90")]
	protected GEGBFOCGMFG([In] IGEMJKBHKGN DAJAOHIJHHL, T1 MJJKPFNLPHO, T2 BBNPEJJONED, T3 NINNJKLKNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4FDED00", Offset = "0x4FDD300", VA = "0x184FDED00")]
	protected GEGBFOCGMFG(NGPBJJLAELK LIOICDJHFAF, FLBLBACKMJL HHPFOCCGJIF, string HFLDIIIPBCG, T1 MJJKPFNLPHO, T2 BBNPEJJONED, T3 NINNJKLKNIK, HHLNNNGBPHH FJNIBCMDBGB, bool HGABBJFBLNA, Action GDMDDGECOJI, HEDLNDJLAEM KEINHBFFLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x45B38D0", Offset = "0x45B1ED0", VA = "0x1845B38D0")]
	public T1 NKBHKFJBBJM()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4FDCD40", Offset = "0x4FDB340", VA = "0x184FDCD40")]
	public void KFGNNNPPMPP(T1 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x16E4630", Offset = "0x16E2C30", VA = "0x1816E4630")]
	public T2 CIPCMIBJHAH()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4FDAE00", Offset = "0x4FD9400", VA = "0x184FDAE00")]
	public void EMFBHHCEHDA(T2 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x45B01D0", Offset = "0x45AE7D0", VA = "0x1845B01D0")]
	public T3 IBBHEDPLDFB()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4FDB340", Offset = "0x4FD9940", VA = "0x184FDB340")]
	public void HDCHJBEIAMF(T3 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4FDA5D0", Offset = "0x4FD8BD0", VA = "0x184FDA5D0")]
	public void ADPGIIFDGLO(T1 MJOJDDHMFKN, T2 KKLBBHIFHIP, T3 KJKKGKIPHBG, bool CGLHINPANBA = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public abstract class DJHJLCOBJFA<T1, T2, T3, T4> : BFKECNDHKCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T1 MJJKPFNLPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private T2 BBNPEJJONED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private T3 NINNJKLKNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private T4 LPIBADPNPDF;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	protected virtual T1 NOOFJBBCDNK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xF642E0", Offset = "0xF628E0", VA = "0x180F642E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x45AF080", Offset = "0x45AD680", VA = "0x1845AF080", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	protected virtual T2 CIPJCDKCAGP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1F6A5B0", Offset = "0x1F68BB0", VA = "0x181F6A5B0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x45B39B0", Offset = "0x45B1FB0", VA = "0x1845B39B0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	protected virtual T3 LKOKGFDCMDG
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x45B02A0", Offset = "0x45AE8A0", VA = "0x1845B02A0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x45B3980", Offset = "0x45B1F80", VA = "0x1845B3980", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	protected virtual T4 LOJNOJPIPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x16A3560", Offset = "0x16A1B60", VA = "0x1816A3560", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1629BC0", Offset = "0x16281C0", VA = "0x181629BC0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public T2 PAHLBAJLEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x45AF120", Offset = "0x45AD720", VA = "0x1845AF120")]
		get
		{
			return (T2)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T3 ENCJOBGFJCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x45B01F0", Offset = "0x45AE7F0", VA = "0x1845B01F0")]
		get
		{
			return (T3)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T4 BMEDBLNABHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x20C0BF0", Offset = "0x20BF1F0", VA = "0x1820C0BF0")]
		get
		{
			return (T4)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	protected override object GDHICCHEJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x45AF160", Offset = "0x45AD760", VA = "0x1845AF160", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x45B3410", Offset = "0x45B1A10", VA = "0x1845B3410", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x45B0670", Offset = "0x45AEC70", VA = "0x1845B0670", Slot = "9")]
	protected override bool KFBFANMCNDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x45B4690", Offset = "0x45B2C90", VA = "0x1845B4690")]
	protected DJHJLCOBJFA([In] IGEMJKBHKGN DAJAOHIJHHL, T1 MJJKPFNLPHO, T2 BBNPEJJONED, T3 NINNJKLKNIK, T4 LPIBADPNPDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x45B5690", Offset = "0x45B3C90", VA = "0x1845B5690")]
	protected DJHJLCOBJFA(NGPBJJLAELK LIOICDJHFAF, FLBLBACKMJL HHPFOCCGJIF, string HFLDIIIPBCG, T1 MJJKPFNLPHO, T2 BBNPEJJONED, T3 NINNJKLKNIK, T4 LPIBADPNPDF, HHLNNNGBPHH FJNIBCMDBGB, bool HGABBJFBLNA, Action GDMDDGECOJI, HEDLNDJLAEM KEINHBFFLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x45B38D0", Offset = "0x45B1ED0", VA = "0x1845B38D0")]
	public T1 NKBHKFJBBJM()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x45B2130", Offset = "0x45B0730", VA = "0x1845B2130")]
	public void KFGNNNPPMPP(T1 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x45AF120", Offset = "0x45AD720", VA = "0x1845AF120")]
	public T2 CIPCMIBJHAH()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x45AF4E0", Offset = "0x45ADAE0", VA = "0x1845AF4E0")]
	public void EMFBHHCEHDA(T2 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x45B01F0", Offset = "0x45AE7F0", VA = "0x1845B01F0")]
	public T3 IBBHEDPLDFB()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x45AFBF0", Offset = "0x45AE1F0", VA = "0x1845AFBF0")]
	public void HDCHJBEIAMF(T3 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x20C0BF0", Offset = "0x20BF1F0", VA = "0x1820C0BF0")]
	public T4 DOEPEIMNMMF()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x45AEF80", Offset = "0x45AD580", VA = "0x1845AEF80")]
	public void AJDDIJEOHHH(T4 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x45AD480", Offset = "0x45ABA80", VA = "0x1845AD480")]
	public void ADPGIIFDGLO(T1 MJOJDDHMFKN, T2 KKLBBHIFHIP, T3 KJKKGKIPHBG, T4 EOFLBDENJGH, bool CGLHINPANBA = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public abstract class GMMNJEPNMLK<T1, T2, T3, T4, T5> : BFKECNDHKCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private T1 MJJKPFNLPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private T2 BBNPEJJONED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private T3 NINNJKLKNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private T4 LPIBADPNPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private T5 DCDOOACLFAD;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	protected virtual T1 NOOFJBBCDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xB19E40", Offset = "0xB18440", VA = "0x180B19E40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return (T1)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xB19E50", Offset = "0xB18450", VA = "0x180B19E50", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	protected virtual T2 CIPJCDKCAGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x15C78E0", Offset = "0x15C5EE0", VA = "0x1815C78E0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return (T2)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x15C69C0", Offset = "0x15C4FC0", VA = "0x1815C69C0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	protected virtual T3 LKOKGFDCMDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xAB05D0", Offset = "0xAAEBD0", VA = "0x180AB05D0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return (T3)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xE15350", Offset = "0xE13950", VA = "0x180E15350", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	protected virtual T4 LOJNOJPIPBI
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xACC810", Offset = "0xACAE10", VA = "0x180ACC810", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return (T4)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xACC870", Offset = "0xACAE70", VA = "0x180ACC870", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	protected virtual T5 HEKBBBNMBPE
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x17F5410", Offset = "0x17F3A10", VA = "0x1817F5410", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return (T5)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x17F5480", Offset = "0x17F3A80", VA = "0x1817F5480", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	protected override object GDHICCHEJEO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x45AF160", Offset = "0x45AD760", VA = "0x1845AF160", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5012B80", Offset = "0x5011180", VA = "0x185012B80", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5011E60", Offset = "0x5010460", VA = "0x185011E60", Slot = "9")]
	protected override bool KFBFANMCNDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x5014510", Offset = "0x5012B10", VA = "0x185014510")]
	protected GMMNJEPNMLK(NGPBJJLAELK LIOICDJHFAF, FLBLBACKMJL HHPFOCCGJIF, string HFLDIIIPBCG, T1 MJJKPFNLPHO, T2 BBNPEJJONED, T3 NINNJKLKNIK, T4 LPIBADPNPDF, T5 DCDOOACLFAD, HHLNNNGBPHH FJNIBCMDBGB, bool HGABBJFBLNA, Action GDMDDGECOJI, HEDLNDJLAEM KEINHBFFLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x45B38D0", Offset = "0x45B1ED0", VA = "0x1845B38D0")]
	public T1 NKBHKFJBBJM()
	{
		return (T1)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x50126D0", Offset = "0x5010CD0", VA = "0x1850126D0")]
	public void KFGNNNPPMPP(T1 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x16E4630", Offset = "0x16E2C30", VA = "0x1816E4630")]
	public T2 CIPCMIBJHAH()
	{
		return (T2)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5011030", Offset = "0x500F630", VA = "0x185011030")]
	public void EMFBHHCEHDA(T2 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x45B01D0", Offset = "0x45AE7D0", VA = "0x1845B01D0")]
	public T3 IBBHEDPLDFB()
	{
		return (T3)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5011320", Offset = "0x500F920", VA = "0x185011320")]
	public void HDCHJBEIAMF(T3 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x20C0BF0", Offset = "0x20BF1F0", VA = "0x1820C0BF0")]
	public T4 DOEPEIMNMMF()
	{
		return (T4)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x50107F0", Offset = "0x500EDF0", VA = "0x1850107F0")]
	public void AJDDIJEOHHH(T4 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5012B60", Offset = "0x5011160", VA = "0x185012B60")]
	public T5 MLAFEGHMKOF()
	{
		return (T5)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x50108E0", Offset = "0x500EEE0", VA = "0x1850108E0")]
	public void AMGINMDLAFO(T5 BDPHCAGFJCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x500F680", Offset = "0x500DC80", VA = "0x18500F680")]
	public void ADPGIIFDGLO(T1 MJOJDDHMFKN, T2 KKLBBHIFHIP, T3 KJKKGKIPHBG, T4 EOFLBDENJGH, T5 BMNHGEJFMBN)
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
