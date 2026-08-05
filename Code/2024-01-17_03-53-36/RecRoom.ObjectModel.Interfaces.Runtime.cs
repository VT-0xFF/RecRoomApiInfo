using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DefaultMember("Item")]
public struct BCCMFHAIFFI : IReadOnlyList<IHEBGBCJDGF>, IEnumerable<IHEBGBCJDGF>, IEnumerable, IReadOnlyCollection<IHEBGBCJDGF>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct BGLEANINNCJ : IEnumerator<IHEBGBCJDGF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly ICKCBOOCNIF GDFLKAAAPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator APCJIPBDNML;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IHEBGBCJDGF GCDIDLPMHMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x60B9770", Offset = "0x60B8570", VA = "0x1860B9770", Slot = "4")]
			get
			{
				return default(IHEBGBCJDGF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x60B96F0", Offset = "0x60B84F0", VA = "0x1860B96F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3B23AD0", Offset = "0x3B228D0", VA = "0x183B23AD0")]
		public BGLEANINNCJ(ICKCBOOCNIF GDFLKAAAPPM, NativeArray<LocalId>.Enumerator APCJIPBDNML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x60B9630", Offset = "0x60B8430", VA = "0x1860B9630", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x60B9670", Offset = "0x60B8470", VA = "0x1860B9670", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60B96B0", Offset = "0x60B84B0", VA = "0x1860B96B0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ICKCBOOCNIF GDFLKAAAPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> LIGOAKHBHBD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IHEBGBCJDGF CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x60B83B0", Offset = "0x60B71B0", VA = "0x1860B83B0", Slot = "4")]
		get
		{
			return default(IHEBGBCJDGF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x60B7E00", Offset = "0x60B6C00", VA = "0x1860B7E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int PLAHOAGKPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x78D180", Offset = "0x78BF80", VA = "0x18078D180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ICKCBOOCNIF LIPHLOLPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PIOKOHDJLOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x78D180", Offset = "0x78BF80", VA = "0x18078D180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HOCHOFNDPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60B7F40", Offset = "0x60B6D40", VA = "0x1860B7F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> FPJOFMPHCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B790", Offset = "0x3B1A590", VA = "0x183B1B790")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60B81D0", Offset = "0x60B6FD0", VA = "0x1860B81D0")]
	public BCCMFHAIFFI(int IBODGIFCPFK, ICKCBOOCNIF GDFLKAAAPPM, Allocator MAJIAODMLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3B231A0", Offset = "0x3B21FA0", VA = "0x183B231A0")]
	public BCCMFHAIFFI(ICKCBOOCNIF GDFLKAAAPPM, NativeArray<LocalId> LIGOAKHBHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60B8160", Offset = "0x60B6F60", VA = "0x1860B8160")]
	internal BCCMFHAIFFI(ICKCBOOCNIF GDFLKAAAPPM, NativeArray<Entity> HGFIGDEFGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60B8310", Offset = "0x60B7110", VA = "0x1860B8310")]
	public BCCMFHAIFFI(ICKCBOOCNIF GDFLKAAAPPM, int GENFKPIGLNJ, Allocator MAJIAODMLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60B8260", Offset = "0x60B7060", VA = "0x1860B8260")]
	public BCCMFHAIFFI(BCCMFHAIFFI GPKNDHGEDAI, Allocator MAJIAODMLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60B7E90", Offset = "0x60B6C90", VA = "0x1860B7E90")]
	public BCCMFHAIFFI MAACLPMGJID(Allocator MAJIAODMLCM = Allocator.Temp)
	{
		return default(BCCMFHAIFFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60B7E50", Offset = "0x60B6C50", VA = "0x1860B7E50", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60B7D70", Offset = "0x60B6B70", VA = "0x1860B7D70")]
	public BGLEANINNCJ BCGCEOCJJAB()
	{
		return default(BGLEANINNCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x60B7F80", Offset = "0x60B6D80", VA = "0x1860B7F80", Slot = "6")]
	private IEnumerator<IHEBGBCJDGF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60B8070", Offset = "0x60B6E70", VA = "0x1860B8070", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct KFHNDMPNGCP : IList<IHEBGBCJDGF>, ICollection<IHEBGBCJDGF>, IEnumerable<IHEBGBCJDGF>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct NMOJJNFJOKM : IEnumerator<IHEBGBCJDGF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly ICKCBOOCNIF GDFLKAAAPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator APCJIPBDNML;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public IHEBGBCJDGF GCDIDLPMHMC
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x60C5B10", Offset = "0x60C4910", VA = "0x1860C5B10", Slot = "4")]
			get
			{
				return default(IHEBGBCJDGF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x60C5A90", Offset = "0x60C4890", VA = "0x1860C5A90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3B23AD0", Offset = "0x3B228D0", VA = "0x183B23AD0")]
		public NMOJJNFJOKM(ICKCBOOCNIF GDFLKAAAPPM, NativeArray<LocalId>.Enumerator APCJIPBDNML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60C59D0", Offset = "0x60C47D0", VA = "0x1860C59D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x60C5A10", Offset = "0x60C4810", VA = "0x1860C5A10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x60C5A50", Offset = "0x60C4850", VA = "0x1860C5A50", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly ICKCBOOCNIF GDFLKAAAPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> LIGOAKHBHBD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IHEBGBCJDGF CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60BFAB0", Offset = "0x60BE8B0", VA = "0x1860BFAB0", Slot = "4")]
		get
		{
			return default(IHEBGBCJDGF);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60BFB30", Offset = "0x60BE930", VA = "0x1860BFB30", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x60BF5A0", Offset = "0x60BE3A0", VA = "0x1860BF5A0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int PIOKOHDJLOG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x60BF5A0", Offset = "0x60BE3A0", VA = "0x1860BF5A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool CEHPCHNOICL
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60BFA20", Offset = "0x60BE820", VA = "0x1860BFA20")]
	public KFHNDMPNGCP(ICKCBOOCNIF GDFLKAAAPPM, int GENFKPIGLNJ, Allocator MAJIAODMLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60BF520", Offset = "0x60BE320", VA = "0x1860BF520")]
	public BCCMFHAIFFI GPDNGCHEHDE()
	{
		return default(BCCMFHAIFFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60BF2C0", Offset = "0x60BE0C0", VA = "0x1860BF2C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60BF300", Offset = "0x60BE100", VA = "0x1860BF300", Slot = "13")]
	public bool Contains(IHEBGBCJDGF KMBHPJEIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60BF390", Offset = "0x60BE190", VA = "0x1860BF390", Slot = "14")]
	public void CopyTo(IHEBGBCJDGF[] IPODKPLEDFE, int BKFPMJOKOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60BF1B0", Offset = "0x60BDFB0", VA = "0x1860BF1B0", Slot = "11")]
	public void Add(IHEBGBCJDGF KMBHPJEIFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60BF670", Offset = "0x60BE470", VA = "0x1860BF670", Slot = "7")]
	public void Insert(int HPLKFBKKIBG, IHEBGBCJDGF KMBHPJEIFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60BF770", Offset = "0x60BE570", VA = "0x1860BF770", Slot = "15")]
	public bool Remove(IHEBGBCJDGF KMBHPJEIFIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60BF5E0", Offset = "0x60BE3E0", VA = "0x1860BF5E0", Slot = "6")]
	public int IndexOf(IHEBGBCJDGF KMBHPJEIFIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60BF720", Offset = "0x60BE520", VA = "0x1860BF720", Slot = "8")]
	public void RemoveAt(int HPLKFBKKIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60BF4E0", Offset = "0x60BE2E0", VA = "0x1860BF4E0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x60BF230", Offset = "0x60BE030", VA = "0x1860BF230")]
	public NMOJJNFJOKM BCGCEOCJJAB()
	{
		return default(NMOJJNFJOKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60BF840", Offset = "0x60BE640", VA = "0x1860BF840", Slot = "16")]
	private IEnumerator<IHEBGBCJDGF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60BF930", Offset = "0x60BE730", VA = "0x1860BF930", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DLNLKLKBBFK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int CEBMEKPBOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> LHFNIALBJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IHEBGBCJDGF PMDALGPDDII(IHEBGBCJDGF LIGOAKHBHBD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PKCGKLFECPN : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface JOOAFODBCIN : ANHEHFBOJAC, HFNEOJBFIDL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool AIJOHIMAHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	KLEGGPGCAED FCAFDAPOJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	AGFEFMLKFJJ JBCPILIKONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	JIKJCKCOCBA BKDGFELOGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	GIGJHJHFDLG GCCFHGKKFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	ODNIELDDIHO AKPMCBPBFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface HFNEOJBFIDL
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool CPKLFKPMELH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface FGKGFAELOMA
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IGKLLMLLAGE(bool MBDKMNBCLGF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface GIGJHJHFDLG
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool KDKNBKANKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action HJDNMDNBJIH;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KIFMNKCNJMF(bool PDBPIJFLAJM);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HBPACJGGMGL(ByteString MEFCHKNPKLC);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DAABPJIJBLN();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CCOGMFAKGGC();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void INNLODPPGEG();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface JIKJCKCOCBA
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	ELAIGJGMPAC FCAFDAPOJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	AGFEFMLKFJJ JBCPILIKONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	IGPDJMNGHDK DLPFDLNPJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	JOOAFODBCIN PKCHMMBPPCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	ICKCBOOCNIF LIPHLOLPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	OIPFNEFPEDF BOFFHIIBNLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	GFNOMMODGBJ GOGHIEONHEG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	HHMMCFFFPIL MFCKJCNNBBC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	NKGDIBCAODA MGLJJCACFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	LHAKHNMAHHJ CONAAFGGMEA
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	JMGLOOHAOPN EOFHOFNIIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	OLCIBEFEBGD GPMAIOOCOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	KJNFHJLKBMK NPJDELPKILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	NDDLPPBKFHA DJJFHKFHBEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	DNLHPACJINF GGECMNEBBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	BNPDDCGLDFB KCGMDMNFBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	KEDPOJGIAJH KNIBPFMEKNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	MNAODNLKFNG HIJNDMPNCCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	PHLJAGFIPEN IAKJBJKLJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	MEFPFCLNCEC JEDAGOPGMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	LMPBBDALKBN JAHNEMMKPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	HDPHOELHGAM JJIJJHJHMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(JNAFHCNCNPD))]
public readonly struct IHEBGBCJDGF : IComparable<IHEBGBCJDGF>, IEquatable<IHEBGBCJDGF>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly IHEBGBCJDGF GLJJGFPGJLG;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int CCKGAMADGGC = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int NEHAGPEIAOB = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int FHKCBEHIDNI = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int DHPBGGJPCNE = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId ELLEDDADJFH;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public ICKCBOOCNIF LIPHLOLPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x60B7000", Offset = "0x60B5E00", VA = "0x1860B7000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public JOOAFODBCIN PKCHMMBPPCD
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x60BD970", Offset = "0x60BC770", VA = "0x1860BD970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public LocalId JNEDJMBNEDF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x60BDA50", Offset = "0x60BC850", VA = "0x1860BDA50")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	internal ODNIELDDIHO AKPMCBPBFJK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x60BDB70", Offset = "0x60BC970", VA = "0x1860BDB70")]
		get
		{
			return default(ODNIELDDIHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool EHIDDDLCNJK
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x60BDA90", Offset = "0x60BC890", VA = "0x1860BDA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool DDDPEEBFBBI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x60BDCA0", Offset = "0x60BCAA0", VA = "0x1860BDCA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool PEJLEBKEHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x60BD920", Offset = "0x60BC720", VA = "0x1860BD920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x60BDE20", Offset = "0x60BCC20", VA = "0x1860BDE20")]
	public IHEBGBCJDGF(ICKCBOOCNIF ANJCAIAOJBC, LocalId ELLEDDADJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
	public BCGOCDLJMLD OHCPMJHAECH()
	{
		return default(BCGOCDLJMLD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x60BDA10", Offset = "0x60BC810", VA = "0x1860BDA10")]
	public static LocalId GMMJAEFOFKB(IHEBGBCJDGF GIAACIPHPDF)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x60BD9D0", Offset = "0x60BC7D0", VA = "0x1860BD9D0")]
	public static Entity GMMJAEFOFKB(IHEBGBCJDGF GIAACIPHPDF)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x60BDB80", Offset = "0x60BC980", VA = "0x1860BDB80")]
	public static bool KFENMBPPCHH(IHEBGBCJDGF OIPELOMOKGO, IHEBGBCJDGF BJNEJGMGENI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x60B8710", Offset = "0x60B7510", VA = "0x1860B8710")]
	public static bool HABFPBKFOGJ(IHEBGBCJDGF OIPELOMOKGO, IHEBGBCJDGF BJNEJGMGENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x60BDCF0", Offset = "0x60BCAF0", VA = "0x1860BDCF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x60BD790", Offset = "0x60BC590", VA = "0x1860BD790", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x60BD6B0", Offset = "0x60BC4B0", VA = "0x1860BD6B0", Slot = "4")]
	public int CompareTo(IHEBGBCJDGF GDMGBCDFBAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "5")]
	public bool Equals(IHEBGBCJDGF GDMGBCDFBAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MHILMEPJGDL
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x60C18C0", Offset = "0x60C06C0", VA = "0x1860C18C0")]
	public static LDLBNGKKOFF ACNKNNNEMBF(this IHEBGBCJDGF FGANJEAKCMA)
	{
		return default(LDLBNGKKOFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x60C19B0", Offset = "0x60C07B0", VA = "0x1860C19B0")]
	public static BCGOCDLJMLD IMCIAKIHJKB(this IHEBGBCJDGF FGANJEAKCMA, [Optional] object CGFEMNMBCOK)
	{
		return default(BCGOCDLJMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x269E630", Offset = "0x269D430", VA = "0x18269E630")]
	public static T CNEAFPKMFON<T>(this IHEBGBCJDGF FGANJEAKCMA) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal sealed class JNAFHCNCNPD
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct ODNIELDDIHO : IEquatable<ODNIELDDIHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte MMNFNIFHOJK;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] KLMBMCOCHMJ;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static ICKCBOOCNIF OOGEGOBCBBH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static JOOAFODBCIN ELGHFBCFKNI;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static ICKCBOOCNIF[] CAOHFJAGKAB;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static JOOAFODBCIN[] AANJJIDOLFG;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> FNJDEPJKCOJ;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public JOOAFODBCIN PKCHMMBPPCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x60C5D50", Offset = "0x60C4B50", VA = "0x1860C5D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ICKCBOOCNIF OKEDEHMBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x60C66B0", Offset = "0x60C54B0", VA = "0x1860C66B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x60C6A60", Offset = "0x60C5860", VA = "0x1860C6A60")]
	static ODNIELDDIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xC0EF90", Offset = "0xC0DD90", VA = "0x180C0EF90")]
	internal ODNIELDDIHO(byte MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x530D3C0", Offset = "0x530C1C0", VA = "0x18530D3C0", Slot = "4")]
	public bool Equals(ODNIELDDIHO GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x60C5CA0", Offset = "0x60C4AA0", VA = "0x1860C5CA0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1A3FF90", Offset = "0x1A3ED90", VA = "0x181A3FF90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x60C69A0", Offset = "0x60C57A0", VA = "0x1860C69A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x60C5B60", Offset = "0x60C4960", VA = "0x1860C5B60")]
	private static ICKCBOOCNIF BAALBDLGHJO(byte MMNFNIFHOJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x60C6600", Offset = "0x60C5400", VA = "0x1860C6600")]
	private static JOOAFODBCIN KDKHBHGLGCF(byte MMNFNIFHOJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x60C5E30", Offset = "0x60C4C30", VA = "0x1860C5E30")]
	private static object GOMHKFDKGFB(byte MMNFNIFHOJK, object[] GPKFACOMFHJ, object NNIKDBJKMOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x60C5FA0", Offset = "0x60C4DA0", VA = "0x1860C5FA0")]
	private static int HLEFJOHMEAI(byte MMNFNIFHOJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x60C5C90", Offset = "0x60C4A90", VA = "0x1860C5C90")]
	private static int DFPMHFBGDPA(byte MMNFNIFHOJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x60C5C10", Offset = "0x60C4A10", VA = "0x1860C5C10")]
	private static (int, int) BAMHACLNGKI(byte MMNFNIFHOJK)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x60C5D40", Offset = "0x60C4B40", VA = "0x1860C5D40")]
	private static byte FNIPIBMJPFP(int ECDEHLGBDJN, int HPLKFBKKIBG)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x60C6340", Offset = "0x60C5140", VA = "0x1860C6340")]
	internal static ODNIELDDIHO JOJFLFCPNKF(JOOAFODBCIN KMIADGADFCK, ICKCBOOCNIF PBOCMKFJKOE)
	{
		return default(ODNIELDDIHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60C6790", Offset = "0x60C5590", VA = "0x1860C6790")]
	internal static void PMECDMAPGIG(ODNIELDDIHO MMNFNIFHOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x60C5FB0", Offset = "0x60C4DB0", VA = "0x1860C5FB0")]
	private static void JCDKJAFIIJE(int IBODGIFCPFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface OPOFBGGHFFD
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BOILBLKABGP();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIHLNNJGAKB(bool DHPOKOPNAKA);

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EOJHOFNJFPA(GameObject FAIKIGMIEFB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface HAIOIGIEAMF
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	Guid DBICKCGEPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DLCEFDAHJBO(Guid CLHIAPDOFOL, Guid CKGDLPHKOMF);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task BPOCEFONEIL(IHEBGBCJDGF LJOCAFMAMHJ);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BIHFOJOJNPG(IHEBGBCJDGF FGPIOJPMPGE, IHEBGBCJDGF GEFCENNBDFI, [Out] Vector3 CPKBHHGCLEC, [Out] Quaternion HPGENMAJHAF);

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BFLFGOBPGIK(LHCAJMLBAFA LKPMEHBOMLJ, Vector3 CPKBHHGCLEC, Quaternion HPGENMAJHAF);

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KEEPGHDFLBJ(IHEBGBCJDGF JDBPDIEIGJG, [Out] Vector3 GDPKFDJKPFP, [Out] Quaternion JDBKOHFCDND);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface PNFOGLLOIAI
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AJEDHNIFICE(BCCMFHAIFFI LIGOAKHBHBD);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface AGFEFMLKFJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	OPOFBGGHFFD JBLHOAKJHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	OIGCIFGLHNA BANOMHDEMFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	HLHNHNGAFNJ FKKIGIGEEGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	CHPBJKILKEP LNIGGPGJBIG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	LBFPGEBBNEG FEOHIEIINLL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	CBHBBHKILOL ILPCFFODIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	BOOFEPGGIKN FFNGJDGEJNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	PMICGELOFNM GBBIMMOFEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface GMEMHCGCBBD
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DIJJPADBEGM(Action APDAGBKMGMB, bool NCFPJLBPJFF);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DIAGEFMPBLJ(string AOAIBMOPKPE);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface OIGCIFGLHNA
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	string BFMHHJMDCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] HFOJDEDAGJD(IEnumerable<IFDIHJBJNNJ> FLECHEOJOID);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DKMOOKDPPCG(GameObject FAIKIGMIEFB, [Out] LDLBNGKKOFF[] CKILKCDGNDO);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NPJJLMHJPJH(GameObject FAIKIGMIEFB, [Out] int NJFFMHCCJKA, [Out] AILCPGEEFDG GHLJMGMIJJK);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "4")]
	EMAGLMHJAIC KIPOPHMMPOO(IFDIHJBJNNJ NNOFNOIFPML);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EMAGLMHJAIC KIPOPHMMPOO(string JAONEADONBI, LDLBNGKKOFF[] IKHMMIIBNHF, Vector3 MHFADBEELBD, Quaternion NJBEEEBFFMP, Vector3 OPIINMIIKCC);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject JHLJMHBDBDI(string JAONEADONBI);

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GEEADCFNBIN(GameObject DPEINMNKDKJ, bool ICFPGIIEFOD);

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HEIODDKOEBM(GameObject FAIKIGMIEFB, bool GKECAACHEMJ, bool GLHMFNHACGG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class CJLHDAJACIG
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x60BA530", Offset = "0x60B9330", VA = "0x1860BA530")]
	public static EMAGLMHJAIC KIPOPHMMPOO(this OIGCIFGLHNA KJKENJAPKJH, Vector3 MHFADBEELBD, Quaternion NJBEEEBFFMP, Vector3 OPIINMIIKCC, params LDLBNGKKOFF[] CKILKCDGNDO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface HLHNHNGAFNJ
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAFLFOPNGFL(bool PDBPIJFLAJM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface CHPBJKILKEP
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	bool BAFPKDNBEFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool EEFGBOFLJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool LILNONMDHMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	int JMCIEOPJADM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool PEBFBNCPEKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FHBKNBDCJKI(object PLFMLOLFNID);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HDLKHGEBPBI(object PLFMLOLFNID);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MIFNHCOGONF(object KEENMLGJEKM);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IEDLCLELHDH(object KEENMLGJEKM);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int ALDPKHDHMPI(GameObject AAGFGONDEFO);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GGPPMAIOHFP(NativeArray<int> GNOMLHPLOFJ);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void LDEMKNANEEK(NativeArray<int> EHNAHAPDENM);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OOKBPEPIHCA();

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BLJMPLGJBFB(uint GMBLNMLMNDF, ReadOnlySpan<byte> DOMAHANKHMP, bool FHAFCNBOCHH = false);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BLJMPLGJBFB(uint GMBLNMLMNDF, ReadOnlySpan<byte> DOMAHANKHMP, ReadOnlySpan<byte> OPIHKFKCFGH, bool FHAFCNBOCHH = false);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface LBFPGEBBNEG
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKEABENCLPD(GameObject FAIKIGMIEFB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface FBEMHHPFFIM
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ILCOEMJGGHP(string EKPMNNKLPFJ);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface CCKCHOKHIMP
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int KCPCCCFOBBG(GameObject FAIKIGMIEFB);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLGMKEFCHCP(GameObject FAIKIGMIEFB);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object HPLIGGHJNPD(IHEBGBCJDGF ELLEDDADJFH, GameObject FAIKIGMIEFB, Action<IHEBGBCJDGF, int> EAGOMMNFHFH);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NDEPFGMHJMN(GameObject FAIKIGMIEFB, object BJDBBMHMNFJ);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface CBHBBHKILOL
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	int CEIBBKDEGHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int CNMJBIJJDBO(GameObject FAIKIGMIEFB);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BEKELKDIJHB([Out] Vector3 MHFADBEELBD);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KNALCPBGDHD();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface BOOFEPGGIKN
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool KDKNBKANKAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool CELNAMEFBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface ENJHEFBMKCN
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	CFHHJHJMGCM NLHBBEIINPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	FJADIBNCHHM EBELBLCPPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BDOLBHLBFLJ(Transform OKMCACLMLOF);

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CJBOFBJALFA(Transform OKMCACLMLOF, CBPANCIPNDD NGPBCAKPICC);

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KMOIGLLILHG(Transform OKMCACLMLOF, KNHELCDDNIE HEFDDONEHGO);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface PMICGELOFNM
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AAKBHNEMPCI();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface DFLHJEGNDFK
{
	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDLNEDOOHPG();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface MFNBHCNCMPI
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AILCPGEEFDG PMGNNLLLDDK(GameObject AAGFGONDEFO);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMLEIGBNDEI(GameObject FAIKIGMIEFB, MKFBFFODLEF POIBHKFHEAM, NGIFBLAIGLA BBACOMICNOO);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string EPNDFKJFJEE(int JDEPDKNELPP);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int FCPDAFEFCKE(string NFDAMLOEIEA);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MJHFFFGFINM(IHEBGBCJDGF ELLEDDADJFH, int[] EGBBFBHNHDM);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FILOPGCFPMN(GameObject FCCFLKEEJDM, GameObject BFPBPFAIMFP, int DIOKINNJLKH);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct JCHPHBPNDHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly FEMODDKFGFC GMKGLLAPKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly FEMODDKFGFC KKCAHMFFJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint KEBJLGDNLCK;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x60BEDF0", Offset = "0x60BDBF0", VA = "0x1860BEDF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct OEPCPBCFFHC
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly IBJKCJFAAOH LHKCFFJGAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly JCHPHBPNDHO APDAGBKMGMB;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x60C1820", Offset = "0x60C0620", VA = "0x1860C1820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct LPJIMGPHION
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly IBJKCJFAAOH LHKCFFJGAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly JCHPHBPNDHO APDAGBKMGMB;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x60C1820", Offset = "0x60C0620", VA = "0x1860C1820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct GFDFNNLJNIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint KEBJLGDNLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool OOKCHPOECNB;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x60BAAA0", Offset = "0x60B98A0", VA = "0x1860BAAA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct FEMODDKFGFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int PNNJJHFFONP;

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x60BAA40", Offset = "0x60B9840", VA = "0x1860BAA40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface MJOAOODOEHD
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	POBJJPMOMBO FOAEKLAOBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum DKMODDOEKMO
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	Legacy,
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Embodied,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Disembodying,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Disembodied
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface EMAGLMHJAIC : GMBIMFCLJFL
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	DKMODDOEKMO CEFMLBLDHAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool AKFJLHICPLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	GameObject FAIKIGMIEFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<EMAGLMHJAIC> IGALLPOMHCN;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(IGPDJMNGHDK MGHGJOGOECM, IHEBGBCJDGF FGOOOPIGNGL);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool DEELJILCILN);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class KMLJCMNPLNA
{
	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x60C0A70", Offset = "0x60BF870", VA = "0x1860C0A70")]
	public static bool OJFDAHDDAEC(this EMAGLMHJAIC HGJIAJILHJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x60C09D0", Offset = "0x60BF7D0", VA = "0x1860C09D0")]
	public static bool CLCKEKCMCKP(this EMAGLMHJAIC HGJIAJILHJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x60C0A20", Offset = "0x60BF820", VA = "0x1860C0A20")]
	public static bool HNBKNMGHFIE(this EMAGLMHJAIC HGJIAJILHJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x60C0940", Offset = "0x60BF740", VA = "0x1860C0940")]
	public static bool AIJOHIMAHPK(this EMAGLMHJAIC HGJIAJILHJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface GMBIMFCLJFL
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool GFKJDIILPIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	IHEBGBCJDGF KJIINNOPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
internal interface GMBMPFKLBEM
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<BNJHBIHDBLE> CFGONIKOLHE;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CGJCCFLDFHE : KMNHFBFKODJ<LDLBNGKKOFF>, NLIPCPILFOO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface BFEFEFIBOEP<T> : DLLMDGFADLD<LDLBNGKKOFF, T>, KMNHFBFKODJ<LDLBNGKKOFF>, NLIPCPILFOO, IDisposable, CGJCCFLDFHE where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class BHFMIEOEBHI
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x239A300", Offset = "0x2399100", VA = "0x18239A300")]
	public static bool GDDNGOCDKHE<T>(this KMNHFBFKODJ<LDLBNGKKOFF> LEDLMNEPNJE, LDLBNGKKOFF IKHMMIIBNHF, [Out] T MBDKMNBCLGF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x239A2E0", Offset = "0x23990E0", VA = "0x18239A2E0")]
	public static bool COLNBMOOCNM<T>(this KMNHFBFKODJ<LDLBNGKKOFF> LEDLMNEPNJE, LDLBNGKKOFF IKHMMIIBNHF, [In] T JKNLOGKCBLL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface AJDGAHFDIFA : KMNHFBFKODJ<IHEBGBCJDGF>, NLIPCPILFOO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface MHHHGLOHBDK<T> : DLLMDGFADLD<IHEBGBCJDGF, T>, KMNHFBFKODJ<IHEBGBCJDGF>, NLIPCPILFOO, IDisposable, AJDGAHFDIFA where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class APFEAJLAKDK
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x240E2A0", Offset = "0x240D0A0", VA = "0x18240E2A0")]
	public static T NAKCAFGMIJA<T>(this KMNHFBFKODJ<IHEBGBCJDGF> LEDLMNEPNJE, IHEBGBCJDGF ELLEDDADJFH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x25B9440", Offset = "0x25B8240", VA = "0x1825B9440")]
	public static bool COLNBMOOCNM<T>(this KMNHFBFKODJ<IHEBGBCJDGF> LEDLMNEPNJE, IHEBGBCJDGF ELLEDDADJFH, [In] T JKNLOGKCBLL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct GLMEIHGMLPL : IComparable<GLMEIHGMLPL>, IEquatable<GLMEIHGMLPL>
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly GLMEIHGMLPL GLJJGFPGJLG;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly GLMEIHGMLPL MDGDMDCAGNE;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly GLMEIHGMLPL CJJCMBBDOEN;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly GLMEIHGMLPL JLOBMCNIHKM;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly GLMEIHGMLPL AAMEDCIJNML;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly GLMEIHGMLPL LIFFFJNMBHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int IMILALJBIFL;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool HBHJHMDNOKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x60BAC90", Offset = "0x60B9A90", VA = "0x1860BAC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int DINPMJAJHGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x60BAD80", Offset = "0x60B9B80", VA = "0x1860BAD80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x885850", Offset = "0x884650", VA = "0x180885850")]
	public GLMEIHGMLPL(int HPLKFBKKIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x60BAD20", Offset = "0x60B9B20", VA = "0x1860BAD20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x60BACA0", Offset = "0x60B9AA0", VA = "0x1860BACA0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x80F5F0", Offset = "0x80E3F0", VA = "0x18080F5F0", Slot = "5")]
	public bool Equals(GLMEIHGMLPL GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x1769CE0", Offset = "0x1768AE0", VA = "0x181769CE0", Slot = "4")]
	public int CompareTo(GLMEIHGMLPL GDMGBCDFBAL)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0xD816E0", Offset = "0xD804E0", VA = "0x180D816E0")]
	public static GLMEIHGMLPL GMMJAEFOFKB(int HPLKFBKKIBG)
	{
		return default(GLMEIHGMLPL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0xD816E0", Offset = "0xD804E0", VA = "0x180D816E0")]
	public static int GMMJAEFOFKB(GLMEIHGMLPL DECHDHLGAML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x60BAD90", Offset = "0x60B9B90", VA = "0x1860BAD90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct BCGOCDLJMLD : IEquatable<BCGOCDLJMLD>, GMBIMFCLJFL
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly BCGOCDLJMLD LNJMOJHIJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public IHEBGBCJDGF KJIINNOPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350", Slot = "6")]
		get
		{
			return default(IHEBGBCJDGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public NJMNFGAKDDC NFGCKFGOPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(NJMNFGAKDDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public BPNHCEAEKGD BOFFHIIBNLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BPNHCEAEKGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	private ICKCBOOCNIF LIPHLOLPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x60B7000", Offset = "0x60B5E00", VA = "0x1860B7000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public GameObject FAIKIGMIEFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x60B8B10", Offset = "0x60B7910", VA = "0x1860B8B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public LDLBNGKKOFF JOKEKGBJEDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x60B8760", Offset = "0x60B7560", VA = "0x1860B8760")]
		get
		{
			return default(LDLBNGKKOFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public LEONPEKFPMG GIBBAKOMOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x60B8CA0", Offset = "0x60B7AA0", VA = "0x1860B8CA0")]
		get
		{
			return default(LEONPEKFPMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public AILCPGEEFDG BICNKOIPHME
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x60B8D80", Offset = "0x60B7B80", VA = "0x1860B8D80")]
		get
		{
			return default(AILCPGEEFDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool EMEHDJGHCHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x60B86F0", Offset = "0x60B74F0", VA = "0x1860B86F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool AGOANOGAJHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x60B88A0", Offset = "0x60B76A0", VA = "0x1860B88A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool OGHLGGCBOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x60B8520", Offset = "0x60B7320", VA = "0x1860B8520")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool BGCILCLIMAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x60B89E0", Offset = "0x60B77E0", VA = "0x1860B89E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool DKILDMIEDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x60B8AF0", Offset = "0x60B78F0", VA = "0x1860B8AF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool HGLEIDIMIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x60B83F0", Offset = "0x60B71F0", VA = "0x1860B83F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool OOGFMPIMEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x60B8580", Offset = "0x60B7380", VA = "0x1860B8580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public bool EGPMAMGAKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x60B89C0", Offset = "0x60B77C0", VA = "0x1860B89C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public HEPNKCBOPLD NCFABPBAKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(HEPNKCBOPLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public KOGMJOKIAAF LBHDMJCNPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(KOGMJOKIAAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public DDMOOPFCHLH NPJDELPKILN
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(DDMOOPFCHLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public ALMOKDFBHNF BCEFJGJBMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(ALMOKDFBHNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public PIJICFEONJF GPMAIOOCOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(PIJICFEONJF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public IDBOHIBPBHH NNOAEGGNAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(IDBOHIBPBHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public LHCAJMLBAFA AFIIJEFBNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(LHCAJMLBAFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public CAKJCIENKPJ ODBGPBDNBHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(CAKJCIENKPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool OJFDAHDDAEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x60B8430", Offset = "0x60B7230", VA = "0x1860B8430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool BAELKBFDDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x60B8D40", Offset = "0x60B7B40", VA = "0x1860B8D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool LPDFMJDNJLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x60B8540", Offset = "0x60B7340", VA = "0x1860B8540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private bool LBOJAOELIIK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7A9270", Offset = "0x7A8070", VA = "0x1807A9270", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public BCGOCDLJMLD(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x60B86D0", Offset = "0x60B74D0", VA = "0x1860B86D0")]
	public static bool GMMJAEFOFKB(BCGOCDLJMLD MBDKMNBCLGF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
	public static IHEBGBCJDGF GMMJAEFOFKB(BCGOCDLJMLD MBDKMNBCLGF)
	{
		return default(IHEBGBCJDGF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x60B88C0", Offset = "0x60B76C0", VA = "0x1860B88C0")]
	public static bool KFENMBPPCHH(BCGOCDLJMLD OIPELOMOKGO, BCGOCDLJMLD BJNEJGMGENI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x60B8710", Offset = "0x60B7510", VA = "0x1860B8710")]
	public static bool HABFPBKFOGJ(BCGOCDLJMLD OIPELOMOKGO, BCGOCDLJMLD BJNEJGMGENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x60B85C0", Offset = "0x60B73C0", VA = "0x1860B85C0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(BCGOCDLJMLD GDMGBCDFBAL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
	public static BCGOCDLJMLD GMMJAEFOFKB(IHEBGBCJDGF PGGKKHAPCMA)
	{
		return default(BCGOCDLJMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x60B8650", Offset = "0x60B7450", VA = "0x1860B8650")]
	public NIOOLMFPGFB FDDFEGPLBLJ()
	{
		return default(NIOOLMFPGFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x60B8730", Offset = "0x60B7530", VA = "0x1860B8730")]
	public JBLGGMPGGKI HDNPIDHEIAO()
	{
		return default(JBLGGMPGGKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x60B8E20", Offset = "0x60B7C20", VA = "0x1860B8E20")]
	public JCDDJALGHGM PCEJJJENEJO()
	{
		return default(JCDDJALGHGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x60B8800", Offset = "0x60B7600", VA = "0x1860B8800")]
	public void IMCIAKIHJKB([Optional] object CGFEMNMBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x60B8A00", Offset = "0x60B7800", VA = "0x1860B8A00")]
	public bool MNPHPHABHPJ(object CGFEMNMBCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x60B88D0", Offset = "0x60B76D0", VA = "0x1860B88D0")]
	public bool LGHNBDJFADN(object CGFEMNMBCOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x60B8E70", Offset = "0x60B7C70", VA = "0x1860B8E70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct LHCAJMLBAFA : IEquatable<LHCAJMLBAFA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public IHEBGBCJDGF KJIINNOPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(IHEBGBCJDGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private ICKCBOOCNIF LIPHLOLPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x60B7000", Offset = "0x60B5E00", VA = "0x1860B7000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private JIKJCKCOCBA BKDGFELOGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x60C1430", Offset = "0x60C0230", VA = "0x1860C1430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private BNPDDCGLDFB HEMDBKONNMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x60C0F30", Offset = "0x60BFD30", VA = "0x1860C0F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool BEMEGKEAMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x60C1300", Offset = "0x60C0100", VA = "0x1860C1300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Guid JBMJIKLMOJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x60C11E0", Offset = "0x60BFFE0", VA = "0x1860C11E0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public bool HHMLFEOJALF
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x60C10C0", Offset = "0x60BFEC0", VA = "0x1860C10C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public Guid IEMCGOMBFJA
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x60C1700", Offset = "0x60C0500", VA = "0x1860C1700")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public LHCAJMLBAFA(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x60B86D0", Offset = "0x60B74D0", VA = "0x1860B86D0")]
	public static bool GMMJAEFOFKB(LHCAJMLBAFA MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x60C1030", Offset = "0x60BFE30", VA = "0x1860C1030", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(LHCAJMLBAFA GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x60C1390", Offset = "0x60C0190", VA = "0x1860C1390")]
	public bool GLKOECMADLK([Out] Guid PNHDNAFHEFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x60C15E0", Offset = "0x60C03E0", VA = "0x1860C15E0")]
	public void MPICNBAAHHO(Guid AJHKDPJBHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x60C0F90", Offset = "0x60BFD90", VA = "0x1860C0F90")]
	public bool EIBFGOMFEKG([Out] Guid BLDAGMAKLNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x60C14C0", Offset = "0x60C02C0", VA = "0x1860C14C0")]
	public void MFEPIHDGCNH(Guid AJHKDPJBHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x60C1150", Offset = "0x60BFF50", VA = "0x1860C1150")]
	public void GEKJECJPCBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct JCDDJALGHGM : IEquatable<JCDDJALGHGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public IHEBGBCJDGF KJIINNOPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(IHEBGBCJDGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private ICKCBOOCNIF LIPHLOLPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x60B7000", Offset = "0x60B5E00", VA = "0x1860B7000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private JIKJCKCOCBA BKDGFELOGJP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x60BECD0", Offset = "0x60BDAD0", VA = "0x1860BECD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private KEDPOJGIAJH FNOBKCEDAHK
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x60BEB50", Offset = "0x60BD950", VA = "0x1860BEB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public float3 FFLMHLLPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x60BE990", Offset = "0x60BD790", VA = "0x1860BE990")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public quaternion OIIHINNCGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x60BEBB0", Offset = "0x60BD9B0", VA = "0x1860BEBB0")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public BCGOCDLJMLD KHOALDDFPJF
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x60BED60", Offset = "0x60BDB60", VA = "0x1860BED60")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public JCDDJALGHGM(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
	public static IHEBGBCJDGF GMMJAEFOFKB(JCDDJALGHGM MBDKMNBCLGF)
	{
		return default(IHEBGBCJDGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x60BEAC0", Offset = "0x60BD8C0", VA = "0x1860BEAC0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(JCDDJALGHGM GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct NIOOLMFPGFB : IEquatable<NIOOLMFPGFB>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class HABPBPHBLEP : IEnumerable<BCGOCDLJMLD>, IEnumerable, IEnumerator<BCGOCDLJMLD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private BCGOCDLJMLD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NIOOLMFPGFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NIOOLMFPGFB <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IEnumerator<BCGOCDLJMLD> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IEnumerator<IHEBGBCJDGF> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		private BCGOCDLJMLD System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.RRObject>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x32F8300", Offset = "0x32F7100", VA = "0x1832F8300", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(BCGOCDLJMLD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x60BB5E0", Offset = "0x60BA3E0", VA = "0x1860BB5E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x34B9AC0", Offset = "0x34B88C0", VA = "0x1834B9AC0")]
		[DebuggerHidden]
		public HABPBPHBLEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x60BB630", Offset = "0x60BA430", VA = "0x1860BB630", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x60BAF80", Offset = "0x60B9D80", VA = "0x1860BAF80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x60BAEE0", Offset = "0x60B9CE0", VA = "0x1860BAEE0")]
		private void BFEOCPBHPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x60BB4A0", Offset = "0x60BA2A0", VA = "0x1860BB4A0")]
		private void PDOLPCEBNKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x60BAF30", Offset = "0x60B9D30", VA = "0x1860BAF30")]
		private void LHJLGOJCGMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x60BB590", Offset = "0x60BA390", VA = "0x1860BB590", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x60BB4F0", Offset = "0x60BA2F0", VA = "0x1860BB4F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BCGOCDLJMLD> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.RRObject>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x60BB4F0", Offset = "0x60BA2F0", VA = "0x1860BB4F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly NIOOLMFPGFB LNJMOJHIJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public IHEBGBCJDGF KJIINNOPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(IHEBGBCJDGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public NJMNFGAKDDC NFGCKFGOPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(NJMNFGAKDDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public BPNHCEAEKGD BOFFHIIBNLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BPNHCEAEKGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private ICKCBOOCNIF LIPHLOLPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x60B7000", Offset = "0x60B5E00", VA = "0x1860B7000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private JIKJCKCOCBA BKDGFELOGJP
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x60C2CA0", Offset = "0x60C1AA0", VA = "0x1860C2CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private OIPFNEFPEDF OGIJCCKFPPI
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x60C2720", Offset = "0x60C1520", VA = "0x1860C2720")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public BCCMFHAIFFI CMFFDGJPJHD
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x60C25F0", Offset = "0x60C13F0", VA = "0x1860C25F0")]
		get
		{
			return default(BCCMFHAIFFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public IEnumerable<BCGOCDLJMLD> OECJPKDDEBM
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x60C28E0", Offset = "0x60C16E0", VA = "0x1860C28E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public IEnumerable<BCGOCDLJMLD> GOIBINDAEIE
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x60C2260", Offset = "0x60C1060", VA = "0x1860C2260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int BJOLEIBKANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x60C23F0", Offset = "0x60C11F0", VA = "0x1860C23F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public int ADKILOEIFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x60C2F00", Offset = "0x60C1D00", VA = "0x1860C2F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public string BAAGNNPAEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x60C2BF0", Offset = "0x60C19F0", VA = "0x1860C2BF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x60C2480", Offset = "0x60C1280", VA = "0x1860C2480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public POMJLFNCLHB GAODCKOJMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x60C2810", Offset = "0x60C1610", VA = "0x1860C2810")]
		get
		{
			return default(POMJLFNCLHB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x60C2FC0", Offset = "0x60C1DC0", VA = "0x1860C2FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public NJGFIAALGBM FKBFOAAMIIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x60C2590", Offset = "0x60C1390", VA = "0x1860C2590")]
		get
		{
			return default(NJGFIAALGBM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x60C2DB0", Offset = "0x60C1BB0", VA = "0x1860C2DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public BLIIFIOFLGE GAHLEKBGMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x60C2AC0", Offset = "0x60C18C0", VA = "0x1860C2AC0")]
		get
		{
			return default(BLIIFIOFLGE);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x60C2A50", Offset = "0x60C1850", VA = "0x1860C2A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public float HOMCGMBDPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x60C2390", Offset = "0x60C1190", VA = "0x1860C2390")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x60C2F50", Offset = "0x60C1D50", VA = "0x1860C2F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool AOBEAMFLFMO
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x60C32D0", Offset = "0x60C20D0", VA = "0x1860C32D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool LICBHKNHLIK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x60C26B0", Offset = "0x60C14B0", VA = "0x1860C26B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool CNPFEGFCJJO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x60C2B20", Offset = "0x60C1920", VA = "0x1860C2B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool BCMHOIDNNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x60C2E20", Offset = "0x60C1C20", VA = "0x1860C2E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool OMGPOBJKJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x60C2530", Offset = "0x60C1330", VA = "0x1860C2530")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x60C30B0", Offset = "0x60C1EB0", VA = "0x1860C30B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool ENGNENBLEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x60C2B90", Offset = "0x60C1990", VA = "0x1860C2B90")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x60C2870", Offset = "0x60C1670", VA = "0x1860C2870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public NIOOLMFPGFB(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x60B86D0", Offset = "0x60B74D0", VA = "0x1860B86D0")]
	public static bool GMMJAEFOFKB(NIOOLMFPGFB MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x60C2780", Offset = "0x60C1580", VA = "0x1860C2780", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(NIOOLMFPGFB GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x871C80", Offset = "0x870A80", VA = "0x180871C80")]
	public static BCGOCDLJMLD GMMJAEFOFKB(NIOOLMFPGFB KDNLDLIFDLH)
	{
		return default(BCGOCDLJMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x60C2240", Offset = "0x60C1040", VA = "0x1860C2240")]
	public bool ABKBMPGIPNO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x60C2E90", Offset = "0x60C1C90", VA = "0x1860C2E90")]
	public bool MIKEGOGDEIJ(FCMJAOPMBPK GONLMBEAEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x60C2D30", Offset = "0x60C1B30", VA = "0x1860C2D30")]
	public void LNKOBFIEGIL(FCMJAOPMBPK GONLMBEAEJC, bool MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x60C3120", Offset = "0x60C1F20", VA = "0x1860C3120")]
	public BCCMFHAIFFI PIKFPHGOGLJ(Allocator MAJIAODMLCM)
	{
		return default(BCCMFHAIFFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x60C3340", Offset = "0x60C2140", VA = "0x1860C3340")]
	public void PNCACPGIBJB(NIOOLMFPGFB GDMGBCDFBAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x60C3030", Offset = "0x60C1E30", VA = "0x1860C3030")]
	[IteratorStateMachine(typeof(HABPBPHBLEP))]
	public IEnumerable<BCGOCDLJMLD> OPBBJCKGLMD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct LCGDMHKBLBB : IEquatable<LCGDMHKBLBB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x60C0C90", Offset = "0x60BFA90", VA = "0x1860C0C90", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(LCGDMHKBLBB GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct KOGMJOKIAAF : IEquatable<KOGMJOKIAAF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private ICKCBOOCNIF LIPHLOLPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x60B7000", Offset = "0x60B5E00", VA = "0x1860B7000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public KOGMJOKIAAF(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x60C0AC0", Offset = "0x60BF8C0", VA = "0x1860C0AC0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(KOGMJOKIAAF GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x60C0B50", Offset = "0x60BF950", VA = "0x1860C0B50")]
	public void HLIABIFOACE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x60C0BF0", Offset = "0x60BF9F0", VA = "0x1860C0BF0")]
	public void JJGOHMHHKOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct ANKNACCABGA : IEquatable<ANKNACCABGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CE0", Offset = "0x60B6AE0", VA = "0x1860B7CE0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(ANKNACCABGA GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct IHCNKHICIFK : IEquatable<IHCNKHICIFK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x60BD620", Offset = "0x60BC420", VA = "0x1860BD620", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(IHCNKHICIFK GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct IEBGPBJBBNE : IEquatable<IEBGPBJBBNE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x60BCFD0", Offset = "0x60BBDD0", VA = "0x1860BCFD0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(IEBGPBJBBNE GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct EHKJCMLPCDF : IEquatable<EHKJCMLPCDF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x60BA9B0", Offset = "0x60B97B0", VA = "0x1860BA9B0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(EHKJCMLPCDF GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct BPNHCEAEKGD : IEquatable<BPNHCEAEKGD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public IHEBGBCJDGF KJIINNOPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(IHEBGBCJDGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private ICKCBOOCNIF LIPHLOLPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x60B7000", Offset = "0x60B5E00", VA = "0x1860B7000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private JIKJCKCOCBA BKDGFELOGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x60BA1A0", Offset = "0x60B8FA0", VA = "0x1860BA1A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private OIPFNEFPEDF OGIJCCKFPPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x60B9EE0", Offset = "0x60B8CE0", VA = "0x1860B9EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public IHEBGBCJDGF PJKDBJAMCKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x60B9E50", Offset = "0x60B8C50", VA = "0x1860B9E50")]
		get
		{
			return default(IHEBGBCJDGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public BCGOCDLJMLD KKHLELLCELL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x60BA290", Offset = "0x60B9090", VA = "0x1860BA290")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public BCGOCDLJMLD AFMCAHCKNML
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x60BA320", Offset = "0x60B9120", VA = "0x1860BA320")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public BPNHCEAEKGD(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x60B9F40", Offset = "0x60B8D40", VA = "0x1860B9F40", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(BPNHCEAEKGD GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x60B9FD0", Offset = "0x60B8DD0", VA = "0x1860B9FD0")]
	public bool FAJLKEPAOJL(BCGOCDLJMLD GEFCENNBDFI, bool KKJDGGGPPCF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x60BA100", Offset = "0x60B8F00", VA = "0x1860BA100")]
	public bool FGLNGIAOKJP(BCGOCDLJMLD EJDCOKLMKOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x60B9BC0", Offset = "0x60B89C0", VA = "0x1860B9BC0")]
	private void AFKOHOGKCDE(BCGOCDLJMLD FFJFEGNGBGM, List<BCGOCDLJMLD> IBKHOOJPNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x60BA230", Offset = "0x60B9030", VA = "0x1860BA230")]
	public void JOFPFEKOFGD(List<BCGOCDLJMLD> PKNBFHOLDFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct HEPNKCBOPLD : IEquatable<HEPNKCBOPLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public string LOGCOHNAJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x60BBBB0", Offset = "0x60BA9B0", VA = "0x1860BBBB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public string BLDOJGENPNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x60BBD70", Offset = "0x60BAB70", VA = "0x1860BBD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private bool NNHHAAMELOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x60BB980", Offset = "0x60BA780", VA = "0x1860BB980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string DMOIAJAKHIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x60BBAC0", Offset = "0x60BA8C0", VA = "0x1860BBAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public string OBEKJPCPOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x60BC410", Offset = "0x60BB210", VA = "0x1860BC410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public string JLOKEONLCHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x60BBCC0", Offset = "0x60BAAC0", VA = "0x1860BBCC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public HEPNKCBOPLD(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x60BBC30", Offset = "0x60BAA30", VA = "0x1860BBC30", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(HEPNKCBOPLD GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x60BBE40", Offset = "0x60BAC40", VA = "0x1860BBE40")]
	private static string OGPMBFJOJLB(AILCPGEEFDG ONHOMFKDKNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct KJCDKJDEOHD : IEquatable<KJCDKJDEOHD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x60C08B0", Offset = "0x60BF6B0", VA = "0x1860C08B0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(KJCDKJDEOHD GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct DDMOOPFCHLH : IEquatable<DDMOOPFCHLH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public DDMOOPFCHLH(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x60BA7B0", Offset = "0x60B95B0", VA = "0x1860BA7B0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(DDMOOPFCHLH GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x60BA840", Offset = "0x60B9640", VA = "0x1860BA840")]
	public bool NCAECOEFLHG([Out] Collider AJPMBIIODOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct ALMOKDFBHNF : IEquatable<ALMOKDFBHNF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public IHEBGBCJDGF KJIINNOPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(IHEBGBCJDGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private ICKCBOOCNIF LIPHLOLPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x60B7000", Offset = "0x60B5E00", VA = "0x1860B7000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private JIKJCKCOCBA BKDGFELOGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x60B7780", Offset = "0x60B6580", VA = "0x1860B7780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private IHKNIOJCBIH BNEGBFCAHLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x60B7060", Offset = "0x60B5E60", VA = "0x1860B7060")]
		get
		{
			return default(IHKNIOJCBIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private KAPJIKDCDIM EOGBAAHEKFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x60B7C60", Offset = "0x60B6A60", VA = "0x1860B7C60")]
		get
		{
			return default(KAPJIKDCDIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool EIJPFDCOPHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x60B6FC0", Offset = "0x60B5DC0", VA = "0x1860B6FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool HIIAPHMNIDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x60B7A00", Offset = "0x60B6800", VA = "0x1860B7A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool MOGBOMHHOAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x60B7380", Offset = "0x60B6180", VA = "0x1860B7380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool DJOLCEDMAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x60B7530", Offset = "0x60B6330", VA = "0x1860B7530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool JHIACHHINHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x60B75D0", Offset = "0x60B63D0", VA = "0x1860B75D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool FBELHDFNOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x60B78E0", Offset = "0x60B66E0", VA = "0x1860B78E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool HEJOMKMIGGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x60B6C30", Offset = "0x60B5A30", VA = "0x1860B6C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool NOPCFGCHEPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x60B6CA0", Offset = "0x60B5AA0", VA = "0x1860B6CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool OBALBMJPPCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x60B6F50", Offset = "0x60B5D50", VA = "0x1860B6F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool CHBDDBFKKIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x60B7A70", Offset = "0x60B6870", VA = "0x1860B7A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool BFCEJOEMCAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x60B7450", Offset = "0x60B6250", VA = "0x1860B7450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool NKHNGOJFKJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x60B76B0", Offset = "0x60B64B0", VA = "0x1860B76B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool IKFCNGBKKDL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x60B7640", Offset = "0x60B6440", VA = "0x1860B7640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool NILFKMGHFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x60B7270", Offset = "0x60B6070", VA = "0x1860B7270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool DJAFMGDLEIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x60B6EE0", Offset = "0x60B5CE0", VA = "0x1860B6EE0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x60B7810", Offset = "0x60B6610", VA = "0x1860B7810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public OPIIAAKNDFD GOIHELEOIGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x60B7880", Offset = "0x60B6680", VA = "0x1860B7880")]
		get
		{
			return default(OPIIAAKNDFD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x60B7200", Offset = "0x60B6000", VA = "0x1860B7200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool FGICICOHJAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x60B6D10", Offset = "0x60B5B10", VA = "0x1860B6D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public NGIFBLAIGLA FBFDJHPGFMF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x60B73F0", Offset = "0x60B61F0", VA = "0x1860B73F0")]
		get
		{
			return default(NGIFBLAIGLA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool NANPKGEBBIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x60B7720", Offset = "0x60B6520", VA = "0x1860B7720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 EKKMACGPHKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x60B70C0", Offset = "0x60B5EC0", VA = "0x1860B70C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public Vector3 DHNBLLLDFCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x60B7950", Offset = "0x60B6750", VA = "0x1860B7950")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public bool JGLDLDMEOFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x60B7AE0", Offset = "0x60B68E0", VA = "0x1860B7AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public ALMOKDFBHNF(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x60B72E0", Offset = "0x60B60E0", VA = "0x1860B72E0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(ALMOKDFBHNF GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x60B74C0", Offset = "0x60B62C0", VA = "0x1860B74C0")]
	public bool GKNBGMFGEFE(IOIAFJHJDBG GONLMBEAEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x60B7190", Offset = "0x60B5F90", VA = "0x1860B7190")]
	public bool DDHMEBAEPMK(MKFBFFODLEF GONLMBEAEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x60B7BE0", Offset = "0x60B69E0", VA = "0x1860B7BE0")]
	public void OEFHMJOONGL(MKFBFFODLEF GONLMBEAEJC, bool PIDMEIKGKKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct IDBOHIBPBHH : IEquatable<IDBOHIBPBHH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public IHEBGBCJDGF KJIINNOPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(IHEBGBCJDGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private ICKCBOOCNIF LIPHLOLPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x60B7000", Offset = "0x60B5E00", VA = "0x1860B7000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private JIKJCKCOCBA BKDGFELOGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x60BCE20", Offset = "0x60BBC20", VA = "0x1860BCE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public IDBOHIBPBHH(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x60BCD90", Offset = "0x60BBB90", VA = "0x1860BCD90", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(IDBOHIBPBHH GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x60BCEB0", Offset = "0x60BBCB0", VA = "0x1860BCEB0")]
	public void LHDFHFCIPIH(bool MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x60BCF40", Offset = "0x60BBD40", VA = "0x1860BCF40")]
	public void NELLILLJEJB(bool MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x25DBC30", Offset = "0x25DAA30", VA = "0x1825DBC30")]
	public T JOKMPEAGEOK<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct PIJICFEONJF : IEquatable<PIJICFEONJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public IHEBGBCJDGF KJIINNOPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(IHEBGBCJDGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private ICKCBOOCNIF LIPHLOLPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x60B7000", Offset = "0x60B5E00", VA = "0x1860B7000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private JIKJCKCOCBA BKDGFELOGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x60C7640", Offset = "0x60C6440", VA = "0x1860C7640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private OLCIBEFEBGD JFDBKJADOMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x60C75B0", Offset = "0x60C63B0", VA = "0x1860C75B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private LMPBBDALKBN JAHNEMMKPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x60C7010", Offset = "0x60C5E10", VA = "0x1860C7010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool LEKOOIFGGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x60C7070", Offset = "0x60C5E70", VA = "0x1860C7070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool PBLGPNJFLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x60C7510", Offset = "0x60C6310", VA = "0x1860C7510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool ACNDFEEPLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x60C7610", Offset = "0x60C6410", VA = "0x1860C7610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool HHBJGHEFGDD
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x60C7990", Offset = "0x60C6790", VA = "0x1860C7990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool MBCAPMDMDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x60C6EB0", Offset = "0x60C5CB0", VA = "0x1860C6EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public bool ABNCGLCIKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x60C7900", Offset = "0x60C6700", VA = "0x1860C7900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool GEBEBLDGOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x60C7300", Offset = "0x60C6100", VA = "0x1860C7300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public bool CGGHFDFPEBF
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x60C7100", Offset = "0x60C5F00", VA = "0x1860C7100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public PIJICFEONJF(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x60B86D0", Offset = "0x60B74D0", VA = "0x1860B86D0")]
	public static bool GMMJAEFOFKB(PIJICFEONJF MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x60C7270", Offset = "0x60C6070", VA = "0x1860C7270", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(PIJICFEONJF GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x60C77E0", Offset = "0x60C65E0", VA = "0x1860C77E0")]
	public bool NHHBFNKCABI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x60C6E10", Offset = "0x60C5C10", VA = "0x1860C6E10")]
	public BCGOCDLJMLD AFHMAELPLNH(BCGOCDLJMLD KEENMLGJEKM)
	{
		return default(BCGOCDLJMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x60C76D0", Offset = "0x60C64D0", VA = "0x1860C76D0")]
	public IHEBGBCJDGF NDLNKDPHOJP()
	{
		return default(IHEBGBCJDGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x60C6EE0", Offset = "0x60C5CE0", VA = "0x1860C6EE0")]
	public void ANBJDDNDHIP(IHEBGBCJDGF KEENMLGJEKM, IHEBGBCJDGF IAAHCJANBIC, IHEBGBCJDGF PNFJDLJJGNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct JBLGGMPGGKI : IEquatable<JBLGGMPGGKI>
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly JBLGGMPGGKI LNJMOJHIJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public IHEBGBCJDGF KJIINNOPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(IHEBGBCJDGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public NJMNFGAKDDC NFGCKFGOPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(NJMNFGAKDDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private AJICMNHCLHC JEKGLIIEFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x60BE760", Offset = "0x60BD560", VA = "0x1860BE760")]
		get
		{
			return default(AJICMNHCLHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public PJALFOPGNNB LPEMHHNANLM
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x60BE160", Offset = "0x60BCF60", VA = "0x1860BE160")]
		get
		{
			return default(PJALFOPGNNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public KBPBJNFEKDO EDJGNCLOOFD
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x60BE620", Offset = "0x60BD420", VA = "0x1860BE620")]
		get
		{
			return default(KBPBJNFEKDO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public ICOFBKBKMHJ BEFCODLFHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x60BE3B0", Offset = "0x60BD1B0", VA = "0x1860BE3B0")]
		get
		{
			return default(ICOFBKBKMHJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public EAGODDLBLHI LKMMNCHOMDO
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x60BE680", Offset = "0x60BD480", VA = "0x1860BE680")]
		get
		{
			return default(EAGODDLBLHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public HLKLKCCAAHD KCAFBEKNJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x60BE470", Offset = "0x60BD270", VA = "0x1860BE470")]
		get
		{
			return default(HLKLKCCAAHD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x60BE8A0", Offset = "0x60BD6A0", VA = "0x1860BE8A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public LCLGFCCFGKM GMHLOAKCMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x60BE410", Offset = "0x60BD210", VA = "0x1860BE410")]
		get
		{
			return default(LCLGFCCFGKM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x60BE6F0", Offset = "0x60BD4F0", VA = "0x1860BE6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public float DAPPNNCIPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x60BE1C0", Offset = "0x60BCFC0", VA = "0x1860BE1C0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x60BE530", Offset = "0x60BD330", VA = "0x1860BE530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 MIDBOEIAHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x60BE910", Offset = "0x60BD710", VA = "0x1860BE910")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x60BE5A0", Offset = "0x60BD3A0", VA = "0x1860BE5A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public float BCPMDGBELNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x60BE7C0", Offset = "0x60BD5C0", VA = "0x1860BE7C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public ELPFFKDFFHL.OGCMGEAPNHJ OEHLCHCAPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x60BE4D0", Offset = "0x60BD2D0", VA = "0x1860BE4D0")]
		get
		{
			return default(ELPFFKDFFHL.OGCMGEAPNHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x60BE830", Offset = "0x60BD630", VA = "0x1860BE830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public JBLGGMPGGKI(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x60B86D0", Offset = "0x60B74D0", VA = "0x1860B86D0")]
	public static bool GMMJAEFOFKB(JBLGGMPGGKI MBDKMNBCLGF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x60B8710", Offset = "0x60B7510", VA = "0x1860B8710")]
	public static bool HABFPBKFOGJ(JBLGGMPGGKI OIPELOMOKGO, JBLGGMPGGKI BJNEJGMGENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x60BE320", Offset = "0x60BD120", VA = "0x1860BE320", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(JBLGGMPGGKI GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x60BE2A0", Offset = "0x60BD0A0", VA = "0x1860BE2A0")]
	public HDJJMBOCJPG EHOGAPGDJGF()
	{
		return default(HDJJMBOCJPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x60BE220", Offset = "0x60BD020", VA = "0x1860BE220")]
	public KGFJIJDIOIO DAAMHFCGBAK()
	{
		return default(KGFJIJDIOIO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct HDJJMBOCJPG : IEquatable<HDJJMBOCJPG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public IHEBGBCJDGF KJIINNOPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(IHEBGBCJDGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public JBLGGMPGGKI LDDBNELOMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(JBLGGMPGGKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private BPPHGDBCCJC EOGEKDACLJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x60BB920", Offset = "0x60BA720", VA = "0x1860BB920")]
		get
		{
			return default(BPPHGDBCCJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public HEGAFJHKMAG CFBNFLPCJDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x60BB8C0", Offset = "0x60BA6C0", VA = "0x1860BB8C0")]
		get
		{
			return default(HEGAFJHKMAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public HDJJMBOCJPG(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x60B86D0", Offset = "0x60B74D0", VA = "0x1860B86D0")]
	public static bool GMMJAEFOFKB(HDJJMBOCJPG MBDKMNBCLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x60BB830", Offset = "0x60BA630", VA = "0x1860BB830", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(HDJJMBOCJPG GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public readonly struct KGFJIJDIOIO : IEquatable<KGFJIJDIOIO>
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly KGFJIJDIOIO LNJMOJHIJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public IHEBGBCJDGF KJIINNOPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(IHEBGBCJDGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public NJMNFGAKDDC NFGCKFGOPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(NJMNFGAKDDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private ICKCBOOCNIF LIPHLOLPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x60B7000", Offset = "0x60B5E00", VA = "0x1860B7000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private JIKJCKCOCBA BKDGFELOGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x60C0030", Offset = "0x60BEE30", VA = "0x1860C0030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private LHAKHNMAHHJ CONAAFGGMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x60C0850", Offset = "0x60BF650", VA = "0x1860C0850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public JBLGGMPGGKI LDDBNELOMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(JBLGGMPGGKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public MBKDCMJGJAM IMCIDIEONPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x60BFF00", Offset = "0x60BED00", VA = "0x1860BFF00")]
		get
		{
			return default(MBKDCMJGJAM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x60C0370", Offset = "0x60BF170", VA = "0x1860C0370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public IEnumerable<BDJMFAAIMDP> KKNLILBNEEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x60C0490", Offset = "0x60BF290", VA = "0x1860C0490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public BDJMFAAIMDP CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x60C0260", Offset = "0x60BF060", VA = "0x1860C0260")]
		get
		{
			return default(BDJMFAAIMDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x60BFBC0", Offset = "0x60BE9C0", VA = "0x1860BFBC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public KGFJIJDIOIO(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x60B86D0", Offset = "0x60B74D0", VA = "0x1860B86D0")]
	public static bool GMMJAEFOFKB(KGFJIJDIOIO MBDKMNBCLGF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x60B88C0", Offset = "0x60B76C0", VA = "0x1860B88C0")]
	public static bool KFENMBPPCHH(KGFJIJDIOIO OIPELOMOKGO, KGFJIJDIOIO BJNEJGMGENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x60BFE70", Offset = "0x60BEC70", VA = "0x1860BFE70", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(KGFJIJDIOIO GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x60BFC50", Offset = "0x60BEA50", VA = "0x1860BFC50")]
	public BDJMFAAIMDP DEIAFMCPDCO(float3? MHFADBEELBD, [Optional] quaternion? NJBEEEBFFMP, [Optional] Vector3? OPIINMIIKCC)
	{
		return default(BDJMFAAIMDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x60C0620", Offset = "0x60BF420", VA = "0x1860C0620")]
	public BDJMFAAIMDP OGELPCMCEOG(int HPLKFBKKIBG, float3? MHFADBEELBD, [Optional] quaternion? NJBEEEBFFMP, [Optional] Vector3? OPIINMIIKCC)
	{
		return default(BDJMFAAIMDP);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x60C0150", Offset = "0x60BEF50", VA = "0x1860C0150")]
	public void MLHCIMDJFLC(int HPLKFBKKIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x60C00C0", Offset = "0x60BEEC0", VA = "0x1860C00C0")]
	public void LJNFEICKFHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct BDJMFAAIMDP : IEquatable<BDJMFAAIMDP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public IHEBGBCJDGF KJIINNOPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(IHEBGBCJDGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public KGFJIJDIOIO GOMOIMDIEMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x60B9290", Offset = "0x60B8090", VA = "0x1860B9290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public float3 NPLKDHGJDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x60B9550", Offset = "0x60B8350", VA = "0x1860B9550")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x60B8FD0", Offset = "0x60B7DD0", VA = "0x1860B8FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public quaternion GJJMADPKFKP
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x60B90B0", Offset = "0x60B7EB0", VA = "0x1860B90B0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x60B91C0", Offset = "0x60B7FC0", VA = "0x1860B91C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float3 FGCKFGIILFH
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x60B9320", Offset = "0x60B8120", VA = "0x1860B9320")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x60B94D0", Offset = "0x60B82D0", VA = "0x1860B94D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public IHHDCPGDMMB AJAAJEHMACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x60B9400", Offset = "0x60B8200", VA = "0x1860B9400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private AHKHNIMICIG NACFDIOLOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x60B95D0", Offset = "0x60B83D0", VA = "0x1860B95D0")]
		get
		{
			return default(AHKHNIMICIG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private KKGLHDGKMMK DPLHPMANLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x60B9470", Offset = "0x60B8270", VA = "0x1860B9470")]
		get
		{
			return default(KKGLHDGKMMK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	private BOFDKJHPHMM KNHHKKAPJFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x60B9230", Offset = "0x60B8030", VA = "0x1860B9230")]
		get
		{
			return default(BOFDKJHPHMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	private DCPGDCFFJBG NPEMMBHONHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x60B9050", Offset = "0x60B7E50", VA = "0x1860B9050")]
		get
		{
			return default(DCPGDCFFJBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	private AHKCCHBECKH GNJACODOMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x60B93A0", Offset = "0x60B81A0", VA = "0x1860B93A0")]
		get
		{
			return default(AHKCCHBECKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public BDJMFAAIMDP(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x60B9130", Offset = "0x60B7F30", VA = "0x1860B9130", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(BDJMFAAIMDP GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x60B9290", Offset = "0x60B8090", VA = "0x1860B9290")]
	public void HGAGMKIEKPJ(KGFJIJDIOIO MBDKMNBCLGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct NJMNFGAKDDC : IEquatable<NJMNFGAKDDC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public BPNHCEAEKGD BOFFHIIBNLO
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BPNHCEAEKGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private ICKCBOOCNIF LIPHLOLPKOL
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x60B7000", Offset = "0x60B5E00", VA = "0x1860B7000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private GFNOMMODGBJ ICIFDIKKLNB
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x60C5750", Offset = "0x60C4550", VA = "0x1860C5750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public bool LCOAMEADAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x60C54A0", Offset = "0x60C42A0", VA = "0x1860C54A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Vector3 NPLKDHGJDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x60C53B0", Offset = "0x60C41B0", VA = "0x1860C53B0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x60C3810", Offset = "0x60C2610", VA = "0x1860C3810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Quaternion GJJMADPKFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x60C40D0", Offset = "0x60C2ED0", VA = "0x1860C40D0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x60C49A0", Offset = "0x60C37A0", VA = "0x1860C49A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 NGCGAKJOFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x60C5100", Offset = "0x60C3F00", VA = "0x1860C5100")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x60C3F60", Offset = "0x60C2D60", VA = "0x1860C3F60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Quaternion CLLHHFCJJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x60C47B0", Offset = "0x60C35B0", VA = "0x1860C47B0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x60C46E0", Offset = "0x60C34E0", VA = "0x1860C46E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float JNOEGBPPEPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x60C4A70", Offset = "0x60C3870", VA = "0x1860C4A70")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x60C3B70", Offset = "0x60C2970", VA = "0x1860C3B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public float CDHGIFNIMEO
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x60C3A00", Offset = "0x60C2800", VA = "0x1860C3A00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 FGCKFGIILFH
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x60C5010", Offset = "0x60C3E10", VA = "0x1860C5010")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x60C51F0", Offset = "0x60C3FF0", VA = "0x1860C51F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Vector3 KMPODACOBNG
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x60C4E50", Offset = "0x60C3C50", VA = "0x1860C4E50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public Matrix4x4 DBFHAPPLHDM
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x60C37D0", Offset = "0x60C25D0", VA = "0x1860C37D0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public NJMNFGAKDDC(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x60C4360", Offset = "0x60C3160", VA = "0x1860C4360", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(NJMNFGAKDDC GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x60C4310", Offset = "0x60C3110", VA = "0x1860C4310")]
	public LACBPJHOPPP EMHOMAECIOG()
	{
		return default(LACBPJHOPPP);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x60C38E0", Offset = "0x60C26E0", VA = "0x1860C38E0")]
	public void BAMIPBGIBMK([Out] Matrix4x4 BKMDPFLEGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x60C4C60", Offset = "0x60C3A60", VA = "0x1860C4C60")]
	public void HKMIGODAEAA([Out] Vector3 AGEOIAEOPIG, [Out] Quaternion GCEOKJJDJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x60C4DA0", Offset = "0x60C3BA0", VA = "0x1860C4DA0")]
	public void HKPBHADPPGE([Out] RigidTransform DNJBJCGPGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x60C37A0", Offset = "0x60C25A0", VA = "0x1860C37A0")]
	public CKJMKKGECDL AENPJBOEIPK()
	{
		return default(CKJMKKGECDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x60C36E0", Offset = "0x60C24E0", VA = "0x1860C36E0")]
	public void AENPJBOEIPK([Out] CKJMKKGECDL MJMHGAJJKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x60C5720", Offset = "0x60C4520", VA = "0x1860C5720")]
	public CKJMKKGECDL OAAOOGFMMGC()
	{
		return default(CKJMKKGECDL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x60C5660", Offset = "0x60C4460", VA = "0x1860C5660")]
	public void OAAOOGFMMGC([Out] CKJMKKGECDL DNJBJCGPGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x60C4220", Offset = "0x60C3020", VA = "0x1860C4220")]
	public Vector3 ELNCDKEJHPG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x60C3DE0", Offset = "0x60C2BE0", VA = "0x1860C3DE0")]
	public void DDCNNLECJMO([In] Vector3 MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x60C35F0", Offset = "0x60C23F0", VA = "0x1860C35F0")]
	public Vector3 AEECOMJELAG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x60C54E0", Offset = "0x60C42E0", VA = "0x1860C54E0")]
	public void MOPCIEGDBGK([In] Vector3 MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x60C4B10", Offset = "0x60C3910", VA = "0x1860C4B10")]
	public Quaternion HELLODKEFMJ()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x60C5900", Offset = "0x60C4700", VA = "0x1860C5900")]
	public void PJJECHBGHDJ([In] Quaternion MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x60C4590", Offset = "0x60C3390", VA = "0x1860C4590")]
	public Quaternion FIABNIGIPJF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x60C3AA0", Offset = "0x60C28A0", VA = "0x1860C3AA0")]
	public void BMMLNBOCKJM([In] Quaternion MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x60C4900", Offset = "0x60C3700", VA = "0x1860C4900")]
	public float GHEDJODKNLE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x60C55B0", Offset = "0x60C43B0", VA = "0x1860C55B0")]
	public void NOEBCDGHBDM(float MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x60C4030", Offset = "0x60C2E30", VA = "0x1860C4030")]
	public float DMNPJOMAICM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x60C3EB0", Offset = "0x60C2CB0", VA = "0x1860C3EB0")]
	public void DEIDFOGLECF(float MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x60C4F40", Offset = "0x60C3D40", VA = "0x1860C4F40")]
	public void ILLFAILKKLO([In] Vector3 MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x60C3C20", Offset = "0x60C2A20", VA = "0x1860C3C20")]
	public Vector3 CBIEBMEOGPM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x60C44C0", Offset = "0x60C32C0", VA = "0x1860C44C0")]
	public void FFHPLOJMEFP([In] Vector3 MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x60C5810", Offset = "0x60C4610", VA = "0x1860C5810")]
	public Vector3 PGDAPEAMHMB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x60C43F0", Offset = "0x60C31F0", VA = "0x1860C43F0")]
	public void FCEOLAGCNNB([In] Vector3 MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x60C52C0", Offset = "0x60C40C0", VA = "0x1860C52C0")]
	public Vector3 MBGOPGDIDJP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x60C3D10", Offset = "0x60C2B10", VA = "0x1860C3D10")]
	public void CMMNPKCKACE([In] Vector3 MBDKMNBCLGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct CAKJCIENKPJ : IEquatable<CAKJCIENKPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly IHEBGBCJDGF PGGKKHAPCMA;

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public IHEBGBCJDGF KJIINNOPLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(IHEBGBCJDGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public BCGOCDLJMLD GNHBMIBMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7F8350", Offset = "0x7F7150", VA = "0x1807F8350")]
		get
		{
			return default(BCGOCDLJMLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public int[] HHECGPIEFIH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x60BA440", Offset = "0x60B9240", VA = "0x1860BA440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x1765480", Offset = "0x1764280", VA = "0x181765480")]
	public CAKJCIENKPJ(IHEBGBCJDGF ELLEDDADJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x60B75A0", Offset = "0x60B63A0", VA = "0x1860B75A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x60BA3B0", Offset = "0x60B91B0", VA = "0x1860BA3B0", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x60B7370", Offset = "0x60B6170", VA = "0x1860B7370", Slot = "4")]
	public bool Equals(CAKJCIENKPJ GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x60B7CC0", Offset = "0x60B6AC0", VA = "0x1860B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class IFGELECHDKO
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct JIDGMCNEOKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Guid FILMEIPENDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public OPDHCNCJAPE BHHCMJDCAKD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct OPDHCNCJAPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int MBDKMNBCLGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int HAHOJPDKDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int GMBLNMLMNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int CBEFFDAKJDP;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x60C6D70", Offset = "0x60C5B70", VA = "0x1860C6D70")]
		public bool BGIIEKMJHJA([Out] LDLBNGKKOFF IKHMMIIBNHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x60C6DF0", Offset = "0x60C5BF0", VA = "0x1860C6DF0")]
		public OPDHCNCJAPE(LDLBNGKKOFF IKHMMIIBNHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x60BD500", Offset = "0x60BC300", VA = "0x1860BD500")]
	public static Guid OBIOMOJAFPC(this LDLBNGKKOFF IKHMMIIBNHF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x60BD4E0", Offset = "0x60BC2E0", VA = "0x1860BD4E0")]
	public static bool JIADGLGLNGH(this Guid FILMEIPENDI, [Out] LDLBNGKKOFF IKHMMIIBNHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class NDMJMIJIJLJ
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x60C1F20", Offset = "0x60C0D20", VA = "0x1860C1F20")]
	public static JIKJCKCOCBA BKDGFELOGJP(this IHEBGBCJDGF JDEPDKNELPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x60C1FB0", Offset = "0x60C0DB0", VA = "0x1860C1FB0")]
	public static IGPDJMNGHDK DLPFDLNPJPI(this IHEBGBCJDGF JDEPDKNELPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x60C2080", Offset = "0x60C0E80", VA = "0x1860C2080")]
	public static EntityManager GKADDEKPDKH(this IHEBGBCJDGF JDEPDKNELPP)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x26FFBC0", Offset = "0x26FE9C0", VA = "0x1826FFBC0")]
	public static T OOPNMGCJAAO<T>(this IHEBGBCJDGF JDEPDKNELPP) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x26FF850", Offset = "0x26FE650", VA = "0x1826FF850")]
	public static bool MDHPEECJBGK<T>(this IHEBGBCJDGF JDEPDKNELPP) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x26FFB10", Offset = "0x26FE910", VA = "0x1826FFB10")]
	public static bool OOCGFGBMBJO<T>(this IHEBGBCJDGF JDEPDKNELPP) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface BNPDDCGLDFB
{
	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HHMLFEOJALF(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BEMEGKEAMDB(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GLKOECMADLK(IHEBGBCJDGF ELLEDDADJFH, [Out] Guid PNHDNAFHEFC);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid HEDHEELPOLO(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MPICNBAAHHO(IHEBGBCJDGF ELLEDDADJFH, Guid PNHDNAFHEFC);

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EIBFGOMFEKG(IHEBGBCJDGF ELLEDDADJFH, [Out] Guid BLDAGMAKLNM);

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid LCMEHMPOAGM(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MFEPIHDGCNH(IHEBGBCJDGF ELLEDDADJFH, Guid BLDAGMAKLNM);

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GEKJECJPCBP(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FABOKEDNGAL(IHEBGBCJDGF FGPIOJPMPGE, IHEBGBCJDGF GEFCENNBDFI);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface AFEHDMEBKDB
{
	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	Guid DBICKCGEPAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CDNFLGCDIFL(NativeList<Guid> FPLNBOEBJEG, NativeList<Guid> PBHLMICFKBP, NativeList<FixedString64Bytes> MOPKIPCEJPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface HDPHOELHGAM
{
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BAJCBPEIAGF(List<IHEBGBCJDGF> NEFHAKFKCKA);

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DIEMDOELNKF(IHEBGBCJDGF FGOOOPIGNGL);

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CNCIGFDMCJP(IHEBGBCJDGF FGOOOPIGNGL);

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IHEBGBCJDGF PNKGMJJMOPN(IHEBGBCJDGF ONDBHEEIBKL);

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGEGFMNFCPL(IHEBGBCJDGF ONDBHEEIBKL, IHEBGBCJDGF APFHAIHFCOH);

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MMDNBIAAEEC(IHEBGBCJDGF ONDBHEEIBKL);

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HOGJPNKHJHG(IHEBGBCJDGF PGGKKHAPCMA);

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NMIKPNIFMIE(IHEBGBCJDGF FGOOOPIGNGL);

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DINGHOBMMBH(IHEBGBCJDGF ELLEDDADJFH, bool CJPCNNJOLCO);

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GNHNFFKHNHD(IHEBGBCJDGF[] LIGOAKHBHBD, bool CJPCNNJOLCO);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface MEFPFCLNCEC
{
	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	IReadOnlyCollection<JKEAFBAHBNF> FIHONKOGBCL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ADOGAGADAHA(int KIGJOKGNLCM, [Out] JKEAFBAHBNF PCKDJCBLDKI);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JKEAFBAHBNF FGIEGOMLBPA(Type HJCFEPLFGPG);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class IGELEKBDINF
{
	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x25DC520", Offset = "0x25DB320", VA = "0x1825DC520")]
	public static T BOKOMHJCOHJ<T>(this MEFPFCLNCEC OMJJBIFHDCP, Entity NIELJJHKFLG) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x25DC5C0", Offset = "0x25DB3C0", VA = "0x1825DC5C0")]
	public static JKEAFBAHBNF FGIEGOMLBPA<T>(this MEFPFCLNCEC OMJJBIFHDCP) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface BKEAFMHNDDD
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LDLBNGKKOFF[] PKAFCNHEGFB(string AOAIBMOPKPE, BCGOCDLJMLD HIAJGDEFCKG, bool AKOOGMFLJME = false);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JMMFNNPGKMD(string JAONEADONBI, LDLBNGKKOFF[] CKILKCDGNDO);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface KEDPOJGIAJH
{
	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<IHEBGBCJDGF, IHEBGBCJDGF> JKEIKOEOING;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<IHEBGBCJDGF, IHEBGBCJDGF> LDDLINDMFCM;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<IHEBGBCJDGF, IHEBGBCJDGF, IHEBGBCJDGF> NJCNJCGPIKD;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<IHEBGBCJDGF> JEAENJAAJJC;

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HDDEHCFCGIA(IHEBGBCJDGF ELLEDDADJFH, IHEBGBCJDGF ONPLODOMJOC);

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IHEBGBCJDGF JFKMKGOGFDA(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<IHEBGBCJDGF> KILMBGJMGJH(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IHEBGBCJDGF IJADJDMNMDL(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MGBBDGHANPJ(IHEBGBCJDGF ELLEDDADJFH, Vector3 EHPDDDFODGL, Quaternion KOBJBMPJGDI);

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HKBJFCHJOGM(IHEBGBCJDGF ELLEDDADJFH, float MBKOAAMAHKF);

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool MNDIDNILBHG(IHEBGBCJDGF ELLEDDADJFH, [Out] RigidTransform ICGOPIGNKJN);

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool CCIFNCNHPMC(IHEBGBCJDGF ELLEDDADJFH, [Out] float GJALOONBKDJ);

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 GNCMDPEFFBG(JCDDJALGHGM NOBGHCOAIJA);

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion PMGBBIPCFFE(JCDDJALGHGM NOBGHCOAIJA);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class BIBAOILAKPP
{
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface BKFIOKDEFIM
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	object EFBJEACNKFN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJEDHNIFICE(BCCMFHAIFFI LIGOAKHBHBD);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public enum DBKMJKHBMAA
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class NLBDHKGIPHC
{
	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0xB53BD0", Offset = "0xB529D0", VA = "0x180B53BD0")]
	public static bool HOBLNAPJKBP(this DBKMJKHBMAA AEMBMKHDECA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0xB53BC0", Offset = "0xB529C0", VA = "0x180B53BC0")]
	public static bool KKDKMNDMFBH(this DBKMJKHBMAA AEMBMKHDECA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x213C5F0", Offset = "0x213B3F0", VA = "0x18213C5F0")]
	public static bool PFHCNMEDLFJ(this DBKMJKHBMAA AEMBMKHDECA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public enum ACAPBDECPGA
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Neck,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Shoulders,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Stomach,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Hips,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	UpperArmR,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	LowerArmR,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	HandR,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	UpperArmL,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	LowerArmL,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	HandL,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	UpperLegR,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	LowerLegR,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	FootR,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	UpperLegL,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	LowerLegL,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	FootL,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Count
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class GKHFCBPCPPM
{
	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0xD816E0", Offset = "0xD804E0", VA = "0x180D816E0")]
	public static int HODFMGKFKKB(this ACAPBDECPGA MBDKMNBCLGF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface IFBOFHDEMFF
{
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface PHLJAGFIPEN
{
	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	DBKMJKHBMAA FDKEMLGLHJF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	DBKMJKHBMAA OOIEHKKDJCN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	DBKMJKHBMAA OOCHANHCIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	DBKMJKHBMAA MAACLPMGJID
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	DBKMJKHBMAA OIELOGKNIFE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	DBKMJKHBMAA HCIFGJPOMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	DBKMJKHBMAA NPJDELPKILN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	DBKMJKHBMAA APFDFMBKHMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	DBKMJKHBMAA DNMIFEJBOMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	DBKMJKHBMAA EIGPOHAACCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	DBKMJKHBMAA EDFKDPAHKHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	DBKMJKHBMAA INMCKPLCHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	DBKMJKHBMAA DJDHCMAHDIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface OIPFNEFPEDF
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<BNJHBIHDBLE> CFGONIKOLHE;

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IHEBGBCJDGF FCHNOLIEBFP(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GFKIHHGAOFH(List<IHEBGBCJDGF> NEFHAKFKCKA);

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IHEBGBCJDGF KPPKAFNEKLH(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FAJLKEPAOJL(IHEBGBCJDGF ELLEDDADJFH, IHEBGBCJDGF GEFCENNBDFI, bool KKJDGGGPPCF);

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool JKJHDOLKBIG(IHEBGBCJDGF ELLEDDADJFH, IHEBGBCJDGF GEFCENNBDFI);

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int KAOKHJIEJKJ(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BCCMFHAIFFI CNDIOIJCENB(IHEBGBCJDGF PGGKKHAPCMA);

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<IHEBGBCJDGF> BHNMMGHFHFP(IHEBGBCJDGF PGGKKHAPCMA);

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool JMBGILKBMLK(IHEBGBCJDGF ELLEDDADJFH, IHEBGBCJDGF KJDKDMKFNCJ);

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FGLNGIAOKJP(IHEBGBCJDGF ELLEDDADJFH, IHEBGBCJDGF EJDCOKLMKOL);

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IHEBGBCJDGF HABGACJMOIL(IHEBGBCJDGF KEENMLGJEKM, IHEBGBCJDGF HOHFHCBGMHL);

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool IPLFFPOFGAJ(IHEBGBCJDGF KEENMLGJEKM, IHEBGBCJDGF HOHFHCBGMHL, [Out] IHEBGBCJDGF DPLOODBHGPB);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public static class OMFJMODHOCJ
{
	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x60C6C60", Offset = "0x60C5A60", VA = "0x1860C6C60")]
	public static List<IHEBGBCJDGF> GFKIHHGAOFH(this OIPFNEFPEDF JAPBHKJEKNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface BHMBONLBHML
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	bool NDCKCACAFOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	bool GOLNJPABDLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface KOOGDAGFMOD : CJHNKKKAGJD
{
	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ILJLHHEECOL(Entity NIELJJHKFLG, [Out] CLPCHCECLFG MMNFNIFHOJK);

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LOMNCDFDEKJ(NativeArray<CLPCHCECLFG> KLMBMCOCHMJ, NativeArray<BCINDGLGCJA> KFHKDKLJEHO);

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FLPMKFPIFID(CLPCHCECLFG MMNFNIFHOJK);

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FMLCCBFFJGP(CLPCHCECLFG MMNFNIFHOJK, [Out] Collider AJPMBIIODOF);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface CJHNKKKAGJD
{
	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHDEACHFKJA([In] float3 NFOKGMLFMMM, [In] float3 MIEHBOELEKH, float HABIICFCBMI, Allocator MAJIAODMLCM, [Out] NativeArray<Entity> HGFIGDEFGDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface JMGLOOHAOPN
{
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KHDEACHFKJA([In] float3 NFOKGMLFMMM, [In] float3 MIEHBOELEKH, float HABIICFCBMI, [Out] KGNLIJAHAFG GCACHMJCLII, [Out] IHEBGBCJDGF AMEOMAMAPGA);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface PKMCHCCFCJN
{
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHDEACHFKJA([In] NativeArray<Entity> HGFIGDEFGDJ, [In] float3 NFOKGMLFMMM, [In] float3 MIEHBOELEKH, [In] NativeArray<KGNLIJAHAFG> MNKKMAAKCAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct CLPCHCECLFG : ONJJIHMMNEI, IEquatable<CLPCHCECLFG>
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public int IMILALJBIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x885810", Offset = "0x884610", VA = "0x180885810", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x885850", Offset = "0x884650", VA = "0x180885850", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public int ECKMEMMKJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x2152A80", Offset = "0x2151880", VA = "0x182152A80", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x545E620", Offset = "0x545D420", VA = "0x18545E620", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x60BA710", Offset = "0x60B9510", VA = "0x1860BA710", Slot = "8")]
	public bool Equals(CLPCHCECLFG GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x60BA760", Offset = "0x60B9560", VA = "0x1860BA760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public struct KGNLIJAHAFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float LIHOPHECHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 ONELACJMJNO;
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface PGBDNFCMDAL
{
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface ICKCBOOCNIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	JIKJCKCOCBA BKDGFELOGJP
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	ODNIELDDIHO AKPMCBPBFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<BCCMFHAIFFI, NativeArray<AILCPGEEFDG>> NOLPOGDDHOC;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<BCCMFHAIFFI> HDFGJIKNKJA;

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LEONPEKFPMG FGJHGECCOLG(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "7")]
	AILCPGEEFDG CDJBDBFCFHN(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JOJFLFCPNKF(LDLBNGKKOFF IKHMMIIBNHF, EMAGLMHJAIC HGJIAJILHJP);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OCMMMCFBDLI(LDLBNGKKOFF[] CKILKCDGNDO, GameObject FAIKIGMIEFB);

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "10")]
	BCGOCDLJMLD IMCIAKIHJKB(IHEBGBCJDGF ELLEDDADJFH, [Optional] object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OGOALFNLMIH(IHEBGBCJDGF ELLEDDADJFH, [Out] EMAGLMHJAIC HGJIAJILHJP);

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KPMKIMPOBHO(IHEBGBCJDGF ELLEDDADJFH, [Out] Transform OKMCACLMLOF);

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool OJFDAHDDAEC(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LGGPLMDKLFK(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MNPHPHABHPJ(LocalId ELLEDDADJFH, object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool LGHNBDJFADN(LocalId ELLEDDADJFH, object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IHEBGBCJDGF FOGFLKOJIGC(LDLBNGKKOFF IKHMMIIBNHF);

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool CBDCNOAIFMG(LDLBNGKKOFF IKHMMIIBNHF, [Out] IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	LDLBNGKKOFF ACNKNNNEMBF(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	BCCMFHAIFFI FOGFLKOJIGC(NativeArray<LDLBNGKKOFF> IKHMMIIBNHF, Allocator MAJIAODMLCM);

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "21")]
	BCCMFHAIFFI KBKEGNEBHKB(AILCPGEEFDG GHLJMGMIJJK, int KGLOPMIHJGF, Allocator MAJIAODMLCM);

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "22")]
	BCCMFHAIFFI IJKONEIMDND(NativeArray<LDLBNGKKOFF> IKHMMIIBNHF, NativeArray<POPENJONMJG> MCDPBALAJBA, Allocator MAJIAODMLCM);

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "23")]
	LDLBNGKKOFF[] PKAFCNHEGFB(string JAONEADONBI, BCGOCDLJMLD HIAJGDEFCKG, bool AKOOGMFLJME);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JMMFNNPGKMD(string JAONEADONBI, LDLBNGKKOFF[] CKILKCDGNDO);

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "25")]
	BCGOCDLJMLD MDGDMDCAGNE(AILCPGEEFDG GHLJMGMIJJK, bool LINPDKONILN);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "26")]
	BCGOCDLJMLD MDGDMDCAGNE(AILCPGEEFDG GHLJMGMIJJK);

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "27")]
	BCGOCDLJMLD PMAIJHIMBMC(AILCPGEEFDG GHLJMGMIJJK);

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "28")]
	BCGOCDLJMLD KEPDNMDOBFJ(AILCPGEEFDG GHLJMGMIJJK);

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "29")]
	BCGOCDLJMLD IJKONEIMDND(LDLBNGKKOFF IKHMMIIBNHF, AILCPGEEFDG GHLJMGMIJJK);

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "30")]
	NIOOLMFPGFB LDKJHEHINKB();

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	KGFJIJDIOIO FJDLGDFNFOF();

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	HDJJMBOCJPG NBENGFNJELB(HEGAFJHKMAG MAKCKMMHNAI);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void JJGOHMHHKOG(BCCMFHAIFFI LIGOAKHBHBD);

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void HLIABIFOACE(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void BDPNHBOEEGJ(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void JJGOHMHHKOG(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "37")]
	BCCMFHAIFFI INFECBJBPJB(BCCMFHAIFFI HIALJCKMKDC, Allocator MAJIAODMLCM);

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool EHIDDDLCNJK(IHEBGBCJDGF ELLEDDADJFH);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public static class HLEALOLKGEG
{
	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x60BCC10", Offset = "0x60BBA10", VA = "0x1860BCC10")]
	public static void LGGPLMDKLFK(this ICKCBOOCNIF GDFLKAAAPPM, EMAGLMHJAIC HGJIAJILHJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x60BC960", Offset = "0x60BB760", VA = "0x1860BC960")]
	public static BCGOCDLJMLD HIGFGLBECCL(this ICKCBOOCNIF GDFLKAAAPPM, LocalId ELLEDDADJFH)
	{
		return default(BCGOCDLJMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x60BC990", Offset = "0x60BB790", VA = "0x1860BC990")]
	public static BCGOCDLJMLD HIGFGLBECCL(this ICKCBOOCNIF GDFLKAAAPPM, LDLBNGKKOFF IKHMMIIBNHF)
	{
		return default(BCGOCDLJMLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x60BC960", Offset = "0x60BB760", VA = "0x1860BC960")]
	public static IHEBGBCJDGF FOGFLKOJIGC(this ICKCBOOCNIF GDFLKAAAPPM, LocalId ELLEDDADJFH)
	{
		return default(IHEBGBCJDGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x60BC660", Offset = "0x60BB460", VA = "0x1860BC660")]
	public static LDLBNGKKOFF ACNKNNNEMBF(this ICKCBOOCNIF GDFLKAAAPPM, LocalId ELLEDDADJFH)
	{
		return default(LDLBNGKKOFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x60BC8F0", Offset = "0x60BB6F0", VA = "0x1860BC8F0")]
	public static bool EHIDDDLCNJK(this ICKCBOOCNIF GDFLKAAAPPM, LDLBNGKKOFF IKHMMIIBNHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x25D2940", Offset = "0x25D1740", VA = "0x1825D2940")]
	public static T CNEAFPKMFON<T>(this ICKCBOOCNIF GDFLKAAAPPM, LocalId ELLEDDADJFH) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x60BCC90", Offset = "0x60BBA90", VA = "0x1860BCC90")]
	public static NIOOLMFPGFB NOKOIDOILJG(this ICKCBOOCNIF GDFLKAAAPPM, RigidTransform MJMHGAJJKAP, [Optional] object CGFEMNMBCOK)
	{
		return default(NIOOLMFPGFB);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x60BC7E0", Offset = "0x60BB5E0", VA = "0x1860BC7E0")]
	public static HDJJMBOCJPG EACNLEILMHD(this ICKCBOOCNIF GDFLKAAAPPM, HEGAFJHKMAG NLDJHAJNOLK, RigidTransform MJMHGAJJKAP, [Optional] object CGFEMNMBCOK)
	{
		return default(HDJJMBOCJPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x60BC6E0", Offset = "0x60BB4E0", VA = "0x1860BC6E0")]
	public static KGFJIJDIOIO AKDGEIHCLJD(this ICKCBOOCNIF GDFLKAAAPPM, RigidTransform MJMHGAJJKAP, [Optional] object CGFEMNMBCOK)
	{
		return default(KGFJIJDIOIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x60BC9F0", Offset = "0x60BB7F0", VA = "0x1860BC9F0")]
	private static void JOFONGANHJA(BCGOCDLJMLD APOHDGMBEOP, RigidTransform MJMHGAJJKAP, [Optional] object CGFEMNMBCOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface OLCIBEFEBGD
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	bool DPBMDHGHJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	IHEBGBCJDGF CJMCBBNPKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	BCGOCDLJMLD CIMICFEMODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event GDBDFILHNHA DPJEJECNCLA;

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IHEBGBCJDGF HABGACJMOIL(IHEBGBCJDGF KEENMLGJEKM, IHEBGBCJDGF HOHFHCBGMHL);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IPLFFPOFGAJ(IHEBGBCJDGF KEENMLGJEKM, IHEBGBCJDGF HOHFHCBGMHL, [Out] IHEBGBCJDGF DPLOODBHGPB);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EKGEJLIAMFO();

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CBLECPAHJFC();

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LEKOOIFGGNE(IHEBGBCJDGF KEENMLGJEKM);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ABNCGLCIKKI(IHEBGBCJDGF KEENMLGJEKM);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public delegate void GDBDFILHNHA(BCGOCDLJMLD BLKNNOCJEPB, BCGOCDLJMLD NNOGFLGPNMD);
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class KEOBJFIEIAK
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x60BF050", Offset = "0x60BDE50", VA = "0x1860BF050")]
	public static bool GMEIDDDKHHC(this OLCIBEFEBGD LJCBPLMHCFA, IHEBGBCJDGF KEENMLGJEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x60BF130", Offset = "0x60BDF30", VA = "0x1860BF130")]
	public static bool HHBJGHEFGDD(this OLCIBEFEBGD LJCBPLMHCFA, IHEBGBCJDGF KEENMLGJEKM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface LLMMDKLCLON
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HJPMAOPDCJP(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DNCBNEHCLNO(IHEBGBCJDGF ELLEDDADJFH, Transform OKMCACLMLOF);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface LMPBBDALKBN
{
	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANBJDDNDHIP(IHEBGBCJDGF KEENMLGJEKM, IHEBGBCJDGF IAAHCJANBIC, IHEBGBCJDGF PNFJDLJJGNI);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IHEBGBCJDGF FEMMDGCIJKK(IHEBGBCJDGF KEENMLGJEKM);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface DNLHPACJINF
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHDFHFCIPIH(IHEBGBCJDGF PGGKKHAPCMA, bool MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NELLILLJEJB(IHEBGBCJDGF PGGKKHAPCMA, bool MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEHLEHMOKKH(IHEBGBCJDGF PGGKKHAPCMA, int MBDKMNBCLGF);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface LHAKHNMAHHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<IHEBGBCJDGF> BNPIKPAKIBO(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IHEBGBCJDGF FDKOENHOBIG(IHEBGBCJDGF ELLEDDADJFH, int HPLKFBKKIBG);

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int NLFCPNHBANB(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MBKDCMJGJAM BOLHIGLMEKG(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OCLCFMDIHEC(IHEBGBCJDGF ELLEDDADJFH, MBKDCMJGJAM JMFMJMCAPBJ);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IHEBGBCJDGF KLBHDOPMGOI(IHEBGBCJDGF ELLEDDADJFH, [Optional] float3? MHFADBEELBD, [Optional] quaternion? NJBEEEBFFMP, [Optional] float3? OPIINMIIKCC);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IHEBGBCJDGF OCACANFHPPB(IHEBGBCJDGF ELLEDDADJFH, int HPLKFBKKIBG, [Optional] float3? MHFADBEELBD, [Optional] quaternion? NJBEEEBFFMP, [Optional] float3? OPIINMIIKCC);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PMPDJCKHCLG(IHEBGBCJDGF ELLEDDADJFH, int HPLKFBKKIBG);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LCBEFOPHCPM(IHEBGBCJDGF ELLEDDADJFH);
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface CLJLEGCFDMG
{
	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHDACEAEEIM();

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFNMBPHBJLJ();

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HOBOENLOCEC();

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKNMJAOLMIL();

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FLIIKFMPDOP();

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HBLOCCBJFDD();

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HLDBFADIJGH();

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JNAKMNADNCJ();

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OGIFNAGIJPG();

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void POCOPHMEPAG();

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NPDDFANHFFB();
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface GFNOMMODGBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLEDFGMPPJG(Entity NIELJJHKFLG);

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDCNNLECJMO(Entity NIELJJHKFLG, [In] float3 MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 ELNCDKEJHPG(Entity NIELJJHKFLG);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PJJECHBGHDJ(Entity NIELJJHKFLG, [In] quaternion MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion HELLODKEFMJ(Entity NIELJJHKFLG);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HKMIGODAEAA(Entity NIELJJHKFLG, [Out] float3 MHFADBEELBD, [Out] quaternion NJBEEEBFFMP);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HKMIGODAEAA(Entity NIELJJHKFLG, [Out] RigidTransform FNPBNOAIEIP);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HKPBHADPPGE(Entity NIELJJHKFLG, [Out] RigidTransform FNPBNOAIEIP);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 GNFCJKFKOKH(Entity NIELJJHKFLG);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void ILLFAILKKLO(Entity NIELJJHKFLG, [In] float3 MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NOEBCDGHBDM(Entity NIELJJHKFLG, float MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float GHEDJODKNLE(Entity NIELJJHKFLG);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FCEOLAGCNNB(Entity NIELJJHKFLG, [In] float3 MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 PGDAPEAMHMB(Entity NIELJJHKFLG);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MOPCIEGDBGK(Entity NIELJJHKFLG, [In] float3 MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 AEECOMJELAG(Entity NIELJJHKFLG);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BMMLNBOCKJM(Entity NIELJJHKFLG, [In] quaternion MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion FIABNIGIPJF(Entity NIELJJHKFLG);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 CBIEBMEOGPM(Entity NIELJJHKFLG);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void FFHPLOJMEFP(Entity NIELJJHKFLG, [In] float3 MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DEIDFOGLECF(Entity NIELJJHKFLG, float MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float DMNPJOMAICM(Entity NIELJJHKFLG);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CMMNPKCKACE(Entity NIELJJHKFLG, [In] float3 MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 MBGOPGDIDJP(Entity NIELJJHKFLG);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PKAJOGBACBK(Entity NIELJJHKFLG, [Out] float4x4 BKMDPFLEGLL);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void PKFIFJJJMHO(Entity NIELJJHKFLG, [In] float4x4 BKMDPFLEGLL);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MDMNFJKNHKL(Entity NIELJJHKFLG, [Out] float4x4 BKMDPFLEGLL);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool KPMKIMPOBHO(Entity NIELJJHKFLG, [Out] Transform OKMCACLMLOF);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void ILAOKDKLJDK(Entity NIELJJHKFLG);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void HJKBKNOLLIF(Entity NIELJJHKFLG, Entity FFJOIADIDNI, Entity BLKPHAHLOKB);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class DIPJJIEHKKH
{
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface PFLLPGANNNL
{
	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World IDLBBBEOMJC(string LPBBJFEAKHO = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World MMDOOGOIOLG(string LPBBJFEAKHO = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World DIGKMMFGPLE(string LPBBJFEAKHO = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World MGIAEBNGCDB(string LPBBJFEAKHO = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface IGPDJMNGHDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000135")]
	World DNDFKAFNLGC
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	World KIEFDNNBKCC
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	EntityManager GKADDEKPDKH
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	bool AIJOHIMAHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase KILJGJDLBEE(Type HJCFEPLFGPG);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class IFLKCFMABGI
{
	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x60BD590", Offset = "0x60BC390", VA = "0x1860BD590")]
	public static ComponentSystemBase JJOIPIHCEDP(this World MGHGJOGOECM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x25DC140", Offset = "0x25DAF40", VA = "0x1825DC140")]
	public static T KILJGJDLBEE<T>(this IGPDJMNGHDK DLHBDKKCONA) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface OHEKCGCCGCB
{
	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BJKBANHJAGK(NativeListAsync<Entity> AIFEFANDCBF);

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFPBPBMLOAN(DHDHOCFIGIL OHJLNPLFPHP);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EMDIMPABFAI(NativeListAsync<Entity> ILFAEBNALKK, bool FICAGPJCNGL);

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HLPECOIPDMF();
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface KJNFHJLKBMK
{
	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GBNMJBNABCJ(IHEBGBCJDGF ELLEDDADJFH, [Out] Collider AJPMBIIODOF);

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject NIFPGEDKKPD(IHEBGBCJDGF HFPCGECFPMD, GameObject CDFGDNNFDBC, Vector3 DDAFDAEAOPI, Quaternion JNABFDAOKDD);

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KIJLAADGAGI(GameObject AJPMBIIODOF);

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider HKFGHAONNJO<TCollider>(GameObject FJLMIGMAFNF) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HDCMEOJNBMO(Collider AJPMBIIODOF);

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject JIHKJACOBHK<TCollider>(string AOAIBMOPKPE) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface JFIJBJDLIAJ
{
	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPFPFILNKGM(IHEBGBCJDGF ELLEDDADJFH, POMJLFNCLHB INCHFIDCBDJ, bool PBECGCGDAFI, FCMJAOPMBPK LODDDGMCKID);

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPILNPBGBBL(IHEBGBCJDGF ELLEDDADJFH, POMJLFNCLHB INCHFIDCBDJ, bool PBECGCGDAFI, bool DBKHGCDGHOG, bool DMOADAPDEAI);

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EEDDEBDHHAJ KNKCFDHHAOB(IHEBGBCJDGF BPBPHOELENB, List<IHEBGBCJDGF> NAMDFGDIDFI);

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CGBINGOAMKE(GameObject NIMJDMFHBIJ, GameObject KBCEPDBOIKD);

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LJHIKJNCNNI(GameObject KBCEPDBOIKD);

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T HKFGHAONNJO<T>(GameObject FJLMIGMAFNF) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HDCMEOJNBMO(Collider AJPMBIIODOF);

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject HOJBOMDDBKJ<T>(string AOAIBMOPKPE) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface MNAODNLKFNG
{
	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HIKEMNNCMOC(IHEBGBCJDGF ELLEDDADJFH, FHGIILMILDH MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FHGIILMILDH OIGIJHLLOEL(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFNLJBABIEO(IHEBGBCJDGF ELLEDDADJFH, IHEBGBCJDGF MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NOFDGEJFFEB(IHEBGBCJDGF ELLEDDADJFH, IHEBGBCJDGF MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int KAOKHJIEJKJ(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IHEBGBCJDGF PHHBLAMKFBJ(IHEBGBCJDGF ELLEDDADJFH, int HPLKFBKKIBG);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LCPCAAGDJLD(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BFBAGKELGNH(IHEBGBCJDGF ELLEDDADJFH, object CGFEMNMBCOK, IHEBGBCJDGF MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CMFFJECCJIA(IHEBGBCJDGF ELLEDDADJFH, object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GHNMPEPJPKM(IHEBGBCJDGF ELLEDDADJFH, [Out] IHEBGBCJDGF MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PCKJHAFDION(IHEBGBCJDGF ELLEDDADJFH, float3 MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IHCNAKCDBOA(IHEBGBCJDGF ELLEDDADJFH, [Out] float3 MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DGHDCIMCCOC(IHEBGBCJDGF ELLEDDADJFH, float3 MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool DGBJFNFMGCD(IHEBGBCJDGF ELLEDDADJFH, [Out] float3 MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void LNGPBPCGMMG(IHEBGBCJDGF ELLEDDADJFH, (Quaternion rot, Vector3 moments) FBAOFMDOKLD);

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool HGLEFFMBONH(IHEBGBCJDGF ELLEDDADJFH, [Out] quaternion HPGENMAJHAF, [Out] float3 FPEKDLDGMED);

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DBFPKABCMKH(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void MFDOBLADKGJ(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 JLGFEFDFAPD(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 LMAMAMONLOH(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ACMHLJPKNDK(IHEBGBCJDGF ELLEDDADJFH, float3 MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void KFKFEODMGCL(IHEBGBCJDGF ELLEDDADJFH, float3 MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float NAPAFPKJEEL(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float PPHOAKADCGL(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void AFHIHHCCAHF(IHEBGBCJDGF ELLEDDADJFH, float MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void LNJODAFNAAG(IHEBGBCJDGF ELLEDDADJFH, float MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode AKOHBNLLGJI(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void OJEDICPFNJN(IHEBGBCJDGF ELLEDDADJFH, CollisionDetectionMode MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "28")]
	PAFONDGDNMK FHEGAGNJDFA(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DGLGAFNOPAE(IHEBGBCJDGF ELLEDDADJFH, PAFONDGDNMK MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool KFKEIPGKLCM(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void FIIGKECDNOB(IHEBGBCJDGF ELLEDDADJFH, bool MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(Slot = "32")]
	IHEBGBCJDGF FCHNOLIEBFP(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void BGLLEJONCHN(IHEBGBCJDGF ELLEDDADJFH, IHEBGBCJDGF MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "34")]
	IHEBGBCJDGF KPPKAFNEKLH(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void FAJLKEPAOJL(IHEBGBCJDGF ELLEDDADJFH, IHEBGBCJDGF MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "36")]
	GDIMELFCBCC EMAFINGCEPD(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void LAAPIGKINCA(IHEBGBCJDGF ELLEDDADJFH, GDIMELFCBCC OFDNEFJDBAK);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool FBIPOKDOOHD(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void KIBEEIPFIBD(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool POMLKGGFONJ(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void LBAIIEGNCCO(IHEBGBCJDGF ELLEDDADJFH, bool MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool JIGAKIHFMJK(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void ECLDGBJAMHK(IHEBGBCJDGF ELLEDDADJFH, bool MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints ACAOBOJNNMH(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void JADJGLDHAKE(IHEBGBCJDGF ELLEDDADJFH, RigidbodyConstraints MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float MGIPHECOBOL(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void HJAMLKEHNOE(IHEBGBCJDGF ELLEDDADJFH, float MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float LDODLFPLNGG(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void AOOHHEBENBE(IHEBGBCJDGF ELLEDDADJFH, float MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool GNAKPKDPHLE(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void CPDKKDPHFPA(IHEBGBCJDGF ELLEDDADJFH, bool MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool PCJNJBLIDDN(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void JNIJGANBJCC(IHEBGBCJDGF ELLEDDADJFH, bool MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void GBDGFJJDPNE(IHEBGBCJDGF ELLEDDADJFH, int MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object NJLPJMONFGA(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void EICIAFMPCMJ(IHEBGBCJDGF ELLEDDADJFH, object MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object OBIBGHAECPM(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void CBPHAIGKAEE(IHEBGBCJDGF ELLEDDADJFH, object MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float CMEABLNMAMA(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void HNFMHNDFKDF(IHEBGBCJDGF ELLEDDADJFH, float MBDKMNBCLGF);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void CADIEHBPFOM(IHEBGBCJDGF ELLEDDADJFH, object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void PJPOJKDFAGE(IHEBGBCJDGF ELLEDDADJFH, object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool OHFIOHMDGFM(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void BGHCECMCHKD(IHEBGBCJDGF ELLEDDADJFH, object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void JINIDAMMGBO(IHEBGBCJDGF ELLEDDADJFH, object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool IFODCFAENLN(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool FNIHKOHIPNM(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody OBLMCNLNEFG(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void HDPKFDIDHGA(IHEBGBCJDGF ELLEDDADJFH, Rigidbody BPHKIOCOHDN);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void NHKMCHHACHL(IHEBGBCJDGF ELLEDDADJFH, object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void CBGIICEIMPH(IHEBGBCJDGF ELLEDDADJFH, object CGFEMNMBCOK);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool OOMKMJMOGJG(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void IKICLFKCIGL(IHEBGBCJDGF ELLEDDADJFH, float3 IBOAKNMBPHJ);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void DELPDNFGPMK(IHEBGBCJDGF ELLEDDADJFH, float3 LAKKBNDDMCC);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool JKOAHPLGHJN(IHEBGBCJDGF ELLEDDADJFH, [Out] float3 IBOAKNMBPHJ);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool LHMFLDOCHDH(IHEBGBCJDGF ELLEDDADJFH, [Out] float3 LAKKBNDDMCC);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool OEPGKIKIHMG(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void ICNBLGBGAGC(IHEBGBCJDGF ELLEDDADJFH, object CGFEMNMBCOK, bool CBBINBGOOHO);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void NKADJMLALCI(IHEBGBCJDGF ELLEDDADJFH, bool LNBFHECBAIE);

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void NEICLBAJLGA(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool HNJHPLKPFED(IHEBGBCJDGF ELLEDDADJFH);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface JJPMMEDFJKI
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	bool AIJOHIMAHPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEELNNDPECH(IHEBGBCJDGF ELLEDDADJFH);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIMKOIOJAFE(IHEBGBCJDGF ELLEDDADJFH, bool PBECGCGDAFI, bool DBKHGCDGHOG, bool BODGCKGJLLG);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OGFEDLIPHKP(IHEBGBCJDGF ELLEDDADJFH, float3 ELAAHADLBAJ);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JENGFPDNEPG(IHEBGBCJDGF ELLEDDADJFH, float3 ELAAHADLBAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface HFDHHNNIFGB
{
	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHDACPDLLFH(Entity GFGAJLLMMKL);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GBJHDGOBAPL(Entity GFGAJLLMMKL);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public delegate void DHODNKAJNIL(NGIIACBDOIC GOCFDGHANLI);
[Cpp2IlInjected.Token(Token = "0x2000082")]
public readonly struct NGIIACBDOIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly BCCMFHAIFFI KABHLPGLJKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly NativeArray<byte> IFLOCMFOCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NativeArray<byte> DGAGGGGMJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly GLMEIHGMLPL DECHDHLGAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly int NPEOHLLCCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Type PLOAHKLGKAJ;

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public BCCMFHAIFFI MPNELBKKGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B760", Offset = "0x3B1A560", VA = "0x183B1B760")]
		get
		{
			return default(BCCMFHAIFFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x60C21D0", Offset = "0x60C0FD0", VA = "0x1860C21D0")]
	public NGIIACBDOIC(BCCMFHAIFFI KABHLPGLJKA, NativeArray<byte> IFLOCMFOCNC, NativeArray<byte> DGAGGGGMJJA, GLMEIHGMLPL DECHDHLGAML, int NPEOHLLCCLI, Type PLOAHKLGKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x27013C0", Offset = "0x27001C0", VA = "0x1827013C0")]
	public NativeArray<T> HAEGAEPAOLF<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x27014F0", Offset = "0x27002F0", VA = "0x1827014F0")]
	public NativeArray<T> OKCKABGMDAH<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x2701400", Offset = "0x2700200", VA = "0x182701400")]
	public (BCCMFHAIFFI, NativeArray<T>, NativeArray<T>) NAKCAFGMIJA<T>() where T : struct
	{
		return default((BCCMFHAIFFI, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x60C2180", Offset = "0x60C0F80", VA = "0x1860C2180")]
	public BNJHBIHDBLE OOLGGPNJBCF()
	{
		return default(BNJHBIHDBLE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface AJPEIIFHNCG
{
	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	string CKHHJIIOKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	AJPEIIFHNCG CFGFKBBFNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	IEnumerable<AJPEIIFHNCG> MEGPGDEDPOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface MKBJHBDPIPD
{
	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	AJPEIIFHNCG FOGEBFIFLHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	List<AJDGAHFDIFA> DFFJJGCBIMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LFONBAHEPIA(AJDGAHFDIFA LEDLMNEPNJE, [Out] AJPEIIFHNCG NDAFMGHMIHA);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JOJFLFCPNKF(AJDGAHFDIFA LEDLMNEPNJE, DHODNKAJNIL GKBIHLEINGL);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PMECDMAPGIG(AJDGAHFDIFA LEDLMNEPNJE, DHODNKAJNIL GKBIHLEINGL);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct BNJHBIHDBLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly NGIIACBDOIC HKPHNGEBIED;

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public BCCMFHAIFFI MPNELBKKGAP
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B760", Offset = "0x3B1A560", VA = "0x183B1B760")]
		get
		{
			return default(BCCMFHAIFFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x60B9B90", Offset = "0x60B8990", VA = "0x1860B9B90")]
	public BNJHBIHDBLE(NGIIACBDOIC HKPHNGEBIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x60B98D0", Offset = "0x60B86D0", VA = "0x1860B98D0")]
	public BCCMFHAIFFI HAEGAEPAOLF()
	{
		return default(BCCMFHAIFFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x60B9AC0", Offset = "0x60B88C0", VA = "0x1860B9AC0")]
	public BCCMFHAIFFI OKCKABGMDAH()
	{
		return default(BCCMFHAIFFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x60B99A0", Offset = "0x60B87A0", VA = "0x1860B99A0")]
	public (BCCMFHAIFFI, BCCMFHAIFFI, BCCMFHAIFFI) NAKCAFGMIJA()
	{
		return default((BCCMFHAIFFI, BCCMFHAIFFI, BCCMFHAIFFI));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[DefaultMember("Item")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface OOEGFNCADID : IEnumerable<GEFBJHFMKHE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000141")]
	NativeBitArray POOAPNNMAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	NativeArray<int> JMBLOMBJGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	GEFBJHFMKHE CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	GEFBJHFMKHE CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GEFBJHFMKHE CELCAJDGAPC(AHDJNPBHHGB JBACKDCMGLH);

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GLMEIHGMLPL BGFLDJIIPHD(AHDJNPBHHGB JBACKDCMGLH);
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class DLANEPDOEJA
{
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
[DefaultMember("Item")]
public interface EHNLBLFBGKJ : IEnumerable<CGJCCFLDFHE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000146")]
	int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	CGJCCFLDFHE CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CGJCCFLDFHE CELCAJDGAPC(AHDJNPBHHGB JBACKDCMGLH);

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GLMEIHGMLPL BGFLDJIIPHD(AHDJNPBHHGB JBACKDCMGLH);
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public static class EOEEJBAFDKF
{
	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x2492270", Offset = "0x2491070", VA = "0x182492270")]
	public static GLMEIHGMLPL BGFLDJIIPHD<T>(this EHNLBLFBGKJ PBCLPGDIOCN, MEBHGJLELIG<T> AOAIBMOPKPE) where T : struct
	{
		return default(GLMEIHGMLPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[DefaultMember("Item")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface PCAJIKBGIOK : IEnumerable<AJDGAHFDIFA>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000148")]
	int OBAHNCBLFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	AJDGAHFDIFA CBJGLMIMNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AJDGAHFDIFA CELCAJDGAPC(AHDJNPBHHGB JBACKDCMGLH);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GLMEIHGMLPL BGFLDJIIPHD(AHDJNPBHHGB JBACKDCMGLH);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class LPEPJDCNOND
{
	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x2654BD0", Offset = "0x26539D0", VA = "0x182654BD0")]
	public static MHHHGLOHBDK<T> CELCAJDGAPC<T>(this PCAJIKBGIOK PBCLPGDIOCN, AHDJNPBHHGB AOAIBMOPKPE) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x2654AD0", Offset = "0x26538D0", VA = "0x182654AD0")]
	public static GLMEIHGMLPL BGFLDJIIPHD<T>(this PCAJIKBGIOK PBCLPGDIOCN, MEBHGJLELIG<T> AOAIBMOPKPE) where T : struct
	{
		return default(GLMEIHGMLPL);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface NKGDIBCAODA
{
	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOJFLFCPNKF(AHDJNPBHHGB LEDLMNEPNJE, DHODNKAJNIL GKBIHLEINGL);

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMECDMAPGIG(AHDJNPBHHGB LEDLMNEPNJE, DHODNKAJNIL GKBIHLEINGL);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class JLALKGOBEIP
{
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface GDALPLPNDHI
{
	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	GKHHPHPCIGN NMPAIGPGOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IAOFOHHALOO(LDLBNGKKOFF IKHMMIIBNHF, GLMEIHGMLPL LEDLMNEPNJE);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CODAINJCGDK(LDLBNGKKOFF IKHMMIIBNHF, Span<GLMEIHGMLPL> PBCLPGDIOCN, bool OPBJCJJOMCB);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPHPBBGNKNN(NativeArray<LDLBNGKKOFF> CKILKCDGNDO);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public static class OFOMPEAIJCD
{
	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x60C6B00", Offset = "0x60C5900", VA = "0x1860C6B00")]
	public static void CODAINJCGDK(this GDALPLPNDHI LFBHOIIFLBP, LDLBNGKKOFF IKHMMIIBNHF, GLMEIHGMLPL LEDLMNEPNJE, bool OPBJCJJOMCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public readonly struct GKHHPHPCIGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly NativeBitArray OIOKOCMNONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly NativeParallelHashMap<LDLBNGKKOFF, int> MJIFCLHDHEN;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public bool CPKLFKPMELH
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x60BAC70", Offset = "0x60B9A70", VA = "0x1860BAC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0xB5EDF0", Offset = "0xB5DBF0", VA = "0x180B5EDF0")]
	public GKHHPHPCIGN(NativeBitArray OIOKOCMNONP, NativeParallelHashMap<LDLBNGKKOFF, int> MJIFCLHDHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x60BAB40", Offset = "0x60B9940", VA = "0x1860BAB40")]
	public bool IAOFOHHALOO(LDLBNGKKOFF IKHMMIIBNHF, GLMEIHGMLPL LEDLMNEPNJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface LMGGLBCKOCD
{
	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KBBDAANABAC(IHEBGBCJDGF ELLEDDADJFH, ADIKHIBCJPP MBDKMNBCLGF);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface FOPCKCFHDLO
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	KNHELCDDNIE PJFDHPAAEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface OMIJACIFAIG
{
	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	Type OLHGAIEGFAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[DGNIABIEAHA(JFFDDDMNLAI.LoadInstance)]
public interface NDDLPPBKFHA
{
	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOGLHJCNCPG(IHEBGBCJDGF PGGKKHAPCMA, bool MBDKMNBCLGF);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public readonly struct NAHOKFEEECL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly IEnumerable<IFDIHJBJNNJ> FLECHEOJOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly IReadOnlyList<GameObject> MHNEOCBIEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly IReadOnlyList<int> JFCDFPHJFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly IReadOnlyList<(LDLBNGKKOFF, LDLBNGKKOFF)> LOLFMJLCKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int LKAICNAOEDC;

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public bool NKGKIMMPNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x60C1AC0", Offset = "0x60C08C0", VA = "0x1860C1AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public int MPNFIFPIDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x8BEFC0", Offset = "0x8BDDC0", VA = "0x1808BEFC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public IEnumerable<GameObject> JKCCMBAIJAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x885000", Offset = "0x883E00", VA = "0x180885000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public IEnumerable<(LDLBNGKKOFF src, LDLBNGKKOFF dst)> DKGJMCCEIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x60C1EB0", Offset = "0x60C0CB0", VA = "0x1860C1EB0")]
	public NAHOKFEEECL(IEnumerable<IFDIHJBJNNJ> FLECHEOJOID, IReadOnlyList<GameObject> MHNEOCBIEGC, IReadOnlyList<int> JFCDFPHJFDG, IReadOnlyList<(LDLBNGKKOFF src, LDLBNGKKOFF dst)> LOLFMJLCKOC, int LKAICNAOEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x60C1B20", Offset = "0x60C0920", VA = "0x1860C1B20")]
	public (GameObject, int)[] LPLBPEFMBLH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface HHMMCFFFPIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000152")]
	bool MKDGLNOOONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	bool CILPEDBADIH
	{
		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	HCNPIDONJGH EODOHEHPBKF
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JJJLDCJFCGI EKMBMDEMBNL();

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JJJLDCJFCGI LJDLHHFOIPB(IEnumerable<IHEBGBCJDGF> LIGOAKHBHBD, [In] CKJMKKGECDL JEBHJPFNNIC);

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CEGDBDMNEFE DBACNBJOECN(ByteString PIBEKCNINBF);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PLBOPKNEHEN INPAHOHOFPP(ByteString MEFCHKNPKLC, IHEBGBCJDGF GEFCENNBDFI, [In] CKJMKKGECDL BINCFHJLLCJ, OPGLAPJGJMG HGGBOECLJBH, bool OHNKJBJOAAO = true);

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NKCANCKOMEF();

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NAHOKFEEECL KJNAPDDMDGO(IEnumerable<IFDIHJBJNNJ> FLECHEOJOID);
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class AMBEODAJDGP
{
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface KCEPJBIPAFG
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action CCOGMFAKGGC;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action EEOBODMFCAF;
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct POPENJONMJG : BCHCDDNCGIN, IEquatable<POPENJONMJG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public AILCPGEEFDG GHLJMGMIJJK;

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x60C7AE0", Offset = "0x60C68E0", VA = "0x1860C7AE0", Slot = "5")]
	public void HONCKFFEJNK(OPCPDGDHEBJ NCEKPOKKHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x60C7B10", Offset = "0x60C6910", VA = "0x1860C7B10", Slot = "4")]
	public void OKNECDBNGHE(MJHKGNGCFFI KALGFOLCEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x60C7B40", Offset = "0x60C6940", VA = "0x1860C7B40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x80F5F0", Offset = "0x80E3F0", VA = "0x18080F5F0", Slot = "6")]
	public bool Equals(POPENJONMJG GDMGBCDFBAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x60C7A60", Offset = "0x60C6860", VA = "0x1860C7A60", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x885810", Offset = "0x884610", VA = "0x180885810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct LDLBNGKKOFF : IComparable<LDLBNGKKOFF>, IEquatable<LDLBNGKKOFF>, BCHCDDNCGIN
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public const uint GAABDLHGMKN = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const uint HDFAAMFFNJE = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly LDLBNGKKOFF GLJJGFPGJLG;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private const int FABGPAPLGPP = 24;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private const uint MJIEAPJHBLE = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private const int NFMOPHACENA = 8;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private const uint KPOEDGPDPPL = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly uint IJBHMPFLJAK;

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public uint BOPAJCMBNKG
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x7E7320", Offset = "0x7E6120", VA = "0x1807E7320")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public uint AOJPLLHPPML
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x60C0E80", Offset = "0x60BFC80", VA = "0x1860C0E80")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public uint CLMPJBAAMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x885810", Offset = "0x884610", VA = "0x180885810")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	public bool NKGKIMMPNMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x6016720", Offset = "0x6015520", VA = "0x186016720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xD816E0", Offset = "0xD804E0", VA = "0x180D816E0")]
	public static LDLBNGKKOFF IAHFIDLBBFK(uint IJBHMPFLJAK)
	{
		return default(LDLBNGKKOFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x60C0F20", Offset = "0x60BFD20", VA = "0x1860C0F20")]
	public LDLBNGKKOFF(int NOGNFBAHHGM, int AMPANCHOGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x60C0F20", Offset = "0x60BFD20", VA = "0x1860C0F20")]
	public LDLBNGKKOFF(uint NOGNFBAHHGM, int AMPANCHOGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x60C0F20", Offset = "0x60BFD20", VA = "0x1860C0F20")]
	public LDLBNGKKOFF(uint NOGNFBAHHGM, uint AMPANCHOGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x885850", Offset = "0x884650", VA = "0x180885850")]
	private LDLBNGKKOFF(uint IJBHMPFLJAK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x175A3A0", Offset = "0x17591A0", VA = "0x18175A3A0")]
	public static bool KFENMBPPCHH(LDLBNGKKOFF OIPELOMOKGO, LDLBNGKKOFF BJNEJGMGENI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x60C0DB0", Offset = "0x60BFBB0", VA = "0x1860C0DB0")]
	public static bool HABFPBKFOGJ(LDLBNGKKOFF OIPELOMOKGO, LDLBNGKKOFF BJNEJGMGENI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x80F5F0", Offset = "0x80E3F0", VA = "0x18080F5F0", Slot = "5")]
	public bool Equals(LDLBNGKKOFF JDEPDKNELPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x60C0D30", Offset = "0x60BFB30", VA = "0x1860C0D30", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x213C500", Offset = "0x213B300", VA = "0x18213C500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x60C0E90", Offset = "0x60BFC90", VA = "0x1860C0E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x60C0E20", Offset = "0x60BFC20", VA = "0x1860C0E20", Slot = "6")]
	public void OKNECDBNGHE(MJHKGNGCFFI KALGFOLCEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x60C0DC0", Offset = "0x60BFBC0", VA = "0x1860C0DC0", Slot = "7")]
	public void HONCKFFEJNK(OPCPDGDHEBJ NCEKPOKKHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x60C0D20", Offset = "0x60BFB20", VA = "0x1860C0D20", Slot = "4")]
	public int CompareTo(LDLBNGKKOFF GDMGBCDFBAL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public struct IFDIHJBJNNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Guid FILMEIPENDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public string JAONEADONBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Vector3 MHFADBEELBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Quaternion NJBEEEBFFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Vector3 OPIINMIIKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public int NGDMNJALCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Dictionary<string, object> JMFMJMCAPBJ;

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x60BD1F0", Offset = "0x60BBFF0", VA = "0x1860BD1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x60BD060", Offset = "0x60BBE60", VA = "0x1860BD060")]
	private static string HPIPGAHIEFB(Dictionary<string, object> IFKEGMKJEFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public enum KEGIOCNABPH
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public static class IMDLBNOHGGD
{
	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x5585160", Offset = "0x5583F60", VA = "0x185585160")]
	public static bool GPBPJAHBCGP(this KEGIOCNABPH HJCFEPLFGPG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[Flags]
public enum NGEKJLEHNMD
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	AdditivePhases = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface PLBOPKNEHEN : HCNPIDONJGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000159")]
	OPGLAPJGJMG JOGKPPLEDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFFCJICJDBP();

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NIDDLLNGCEP();
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface HCNPIDONJGH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	IEnumerable<IFDIHJBJNNJ> IPKADBPBDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	NAHOKFEEECL DAJDEPCFNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	LocalId LKLBFDCCEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	DLNLKLKBBFK DPNGHGMLEEH
	{
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool NHHKCLMLLGE(NGEKJLEHNMD KHHPDHMMCHO);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public interface OPGLAPJGJMG
{
	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KGFGKENFMJH(Guid MBOILCLDJDM, [Out] Guid ABBDLLBKBLE);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface CEGDBDMNEFE : HCNPIDONJGH, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[Flags]
public enum BODDHPIOMKC
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public interface JJJLDCJFCGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	DLNLKLKBBFK LNHINGAJKHL
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString DHDGMMHHBCN();
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public enum MPEGMEIGFHI
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public delegate bool HAKGNAJJLGN(HPLNEDHOCPD IHLIJIIIHBG, [In] ONJOEGBHAOJ MBDKMNBCLGF);
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public delegate bool CDIFFNILLDG<T>(HPLNEDHOCPD IHLIJIIIHBG, [In] T MBDKMNBCLGF);
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface CBEKHIOHKCF
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JOJFLFCPNKF(GLMEIHGMLPL DECHDHLGAML, Type AILPBODGJLN, HAKGNAJJLGN GILKGONFFDJ);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HEDFGIHCMAF(GLMEIHGMLPL DECHDHLGAML, [Out] HAKGNAJJLGN GILKGONFFDJ);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class BJBCFPKBLAE
{
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class MAJJCNJPMIF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CDIFFNILLDG<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public MAJJCNJPMIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x3D39790", Offset = "0x3D38590", VA = "0x183D39790")]
		internal bool KIDOMONGHEE(HPLNEDHOCPD pendingList, [In] ONJOEGBHAOJ value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x239AC70", Offset = "0x2399A70", VA = "0x18239AC70")]
	public static void JOJFLFCPNKF<T>(this CBEKHIOHKCF FPJDEMDEKEI, GLMEIHGMLPL DECHDHLGAML, CDIFFNILLDG<T> GILKGONFFDJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x60B97C0", Offset = "0x60B85C0", VA = "0x1860B97C0")]
	public static bool CPJCMJAGKIL(this CBEKHIOHKCF FPJDEMDEKEI, HPLNEDHOCPD IHLIJIIIHBG, GLMEIHGMLPL DECHDHLGAML, [In] ONJOEGBHAOJ MBDKMNBCLGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface CIEIFCOJPHE
{
	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	uint HJOLKDEHHFN
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface HPLNEDHOCPD
{
	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JONJJKGKECA(LDLBNGKKOFF IDAJGFIIGKJ, GLMEIHGMLPL DECHDHLGAML, ReadOnlySpan<byte> MPIHGONKGAL, ReadOnlySpan<byte> DEMAPJABBIC);

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PHMFPNNMPDM(LDLBNGKKOFF IDAJGFIIGKJ, GLMEIHGMLPL DECHDHLGAML);

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MNLGGHHOIEE(LDLBNGKKOFF IDAJGFIIGKJ, GLMEIHGMLPL DECHDHLGAML, ReadOnlySpan<byte> DEMAPJABBIC);

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BHDNONGPFAP(LDLBNGKKOFF IDAJGFIIGKJ, GLMEIHGMLPL DECHDHLGAML, Span<byte> MPIHGONKGAL, Span<byte> DEMAPJABBIC);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public static class DHGLLIOOMNM
{
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x2471480", Offset = "0x2470280", VA = "0x182471480")]
	public static bool BHDNONGPFAP<T>(this HPLNEDHOCPD JBLNKAPKGAJ, LDLBNGKKOFF IDAJGFIIGKJ, GLMEIHGMLPL DECHDHLGAML, [Out] T MPIHGONKGAL, [Out] T DEMAPJABBIC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x2471630", Offset = "0x2470430", VA = "0x182471630")]
	public static bool MNLGGHHOIEE<T>(this HPLNEDHOCPD JBLNKAPKGAJ, LDLBNGKKOFF IDAJGFIIGKJ, GLMEIHGMLPL DECHDHLGAML, T DEMAPJABBIC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public enum NNPDGFFGCGM
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface AOAABEOBEOD
{
	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDEPGNJFPDG(ILFENCCNBML LGDFGELLOEL, ReadOnlySpan<byte> PLFMLOLFNID);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOMPGIKKHFL(uint GMBLNMLMNDF, ReadOnlySpan<byte> PLFMLOLFNID);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface PELHLMAKLLN
{
	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ILFENCCNBML HFGAIPKFBAF(ReadOnlySpan<byte> PLFMLOLFNID);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface EELEJMCKELO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHBKNBDCJKI(ILFENCCNBML IDGIKKEFDCG, ReadOnlySpan<byte> PLFMLOLFNID);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOOFINOCMOJ(ReadOnlySpan<ILFENCCNBML> PAHOKPBLMDC);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct POFAJKJFLKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public ILFENCCNBML LGDFGELLOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public ReadOnlyMemory<byte> PLFMLOLFNID;
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct ILFENCCNBML
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static ILFENCCNBML HGBEIKAKNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public uint NOGNFBAHHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public int IGDLEGADCOM;

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0xA34EB0", Offset = "0xA33CB0", VA = "0x180A34EB0")]
	public ILFENCCNBML(uint NOGNFBAHHGM, int IGDLEGADCOM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x60BE050", Offset = "0x60BCE50", VA = "0x1860BE050")]
	public static bool KFENMBPPCHH([In] ILFENCCNBML LBKCGMCBJAD, [In] ILFENCCNBML LEFACNCEBHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x60BDF60", Offset = "0x60BCD60", VA = "0x1860BDF60", Slot = "0")]
	public override bool Equals(object FGANJEAKCMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x60BE020", Offset = "0x60BCE20", VA = "0x1860BE020", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x60BE070", Offset = "0x60BCE70", VA = "0x1860BE070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x60BE010", Offset = "0x60BCE10", VA = "0x1860BE010")]
	public void GEEAEGHINBD([Out] uint NOGNFBAHHGM, [Out] int IGDLEGADCOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[DGNIABIEAHA(JFFDDDMNLAI.OMRoom)]
public interface KNKCEDCBCIM : LILCCGEMCGC<KNKCEDCBCIM>
{
	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GDDNGOCDKHE(GLMEIHGMLPL JDEPDKNELPP, [Out] FBCBPLNCLLE PCKDJCBLDKI);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public static class DCBGNJCHDPF
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public interface FBCBPLNCLLE
{
	[Cpp2IlInjected.Token(Token = "0x17000160")]
	Type OHOJCPIMBCN
	{
		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HONCKFFEJNK(OPCPDGDHEBJ NCEKPOKKHOM, Span<byte> KEENMLGJEKM);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OKNECDBNGHE(MJHKGNGCFFI KALGFOLCEKF, ReadOnlySpan<byte> LGDFGELLOEL);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public static class FAJFHAINIGD
{
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public struct BCINDGLGCJA : ISystemStateComponentData, IComponentData, IEquatable<BCINDGLGCJA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public float3 EDJBKNLBPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 NOJADMBHCOK;

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x60B8F50", Offset = "0x60B7D50", VA = "0x1860B8F50", Slot = "4")]
	public bool Equals(BCINDGLGCJA GDMGBCDFBAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface APDDKFDEFFH
{
	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ELHGKOIMEJD EENLBINKJFM(int KIGJOKGNLCM);

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int OLHDAGOHDLK(ELHGKOIMEJD MBIEOIFJNHC);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface DLNHALCFPLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000161")]
	IEnumerable<EJMFCDCFPPN> ALEADJJMIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MDCEHLEKDEH(int KIGJOKGNLCM, [Out] EJMFCDCFPPN PCKDJCBLDKI);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface DEIGLACOEDK
{
	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HLEFJOHMEAI(int KIGJOKGNLCM);
}
[Cpp2IlInjected.Token(Token = "0x20000BD")]
[DGNIABIEAHA(JFFDDDMNLAI.Application)]
public interface FDJICHNOKJA
{
	[Cpp2IlInjected.Token(Token = "0x17000162")]
	List<(ELHGKOIMEJD nameHash, BMDKPLCDMOG stableTypeHash, Type type)> FAAELGPKJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public class LBMBDANPICH
{
	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	public LBMBDANPICH()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
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
