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
public struct BPNOBCOILLF : IReadOnlyList<ICMPCFCEMJM>, IEnumerable<ICMPCFCEMJM>, IEnumerable, IReadOnlyCollection<ICMPCFCEMJM>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct NOAMHPMPBJP : IEnumerator<ICMPCFCEMJM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly CBDNIAOJPJI AFFLCFIGDNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator JDNLPJMOHGA;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public ICMPCFCEMJM POOLCAAKLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5ED47C0", Offset = "0x5ED35C0", VA = "0x185ED47C0", Slot = "4")]
			get
			{
				return default(ICMPCFCEMJM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5ED4740", Offset = "0x5ED3540", VA = "0x185ED4740", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3A9E200", Offset = "0x3A9D000", VA = "0x183A9E200")]
		public NOAMHPMPBJP(CBDNIAOJPJI AFFLCFIGDNF, NativeArray<LocalId>.Enumerator JDNLPJMOHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4680", Offset = "0x5ED3480", VA = "0x185ED4680", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5ED46C0", Offset = "0x5ED34C0", VA = "0x185ED46C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4700", Offset = "0x5ED3500", VA = "0x185ED4700", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly CBDNIAOJPJI AFFLCFIGDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> ILEEGIHBOBP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ICMPCFCEMJM LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7700", Offset = "0x5EC6500", VA = "0x185EC7700", Slot = "4")]
		get
		{
			return default(ICMPCFCEMJM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7280", Offset = "0x5EC6080", VA = "0x185EC7280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int NFFKFBIAHON
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x76E180", Offset = "0x76CF80", VA = "0x18076E180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public CBDNIAOJPJI ONHPHNMDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DLGHEHGPEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x76E180", Offset = "0x76CF80", VA = "0x18076E180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KCECFBKKACB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC70C0", Offset = "0x5EC5EC0", VA = "0x185EC70C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> KLPGNGBFBEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3A97C10", Offset = "0x3A96A10", VA = "0x183A97C10")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7670", Offset = "0x5EC6470", VA = "0x185EC7670")]
	public BPNOBCOILLF(int FNJNELBIPIL, CBDNIAOJPJI AFFLCFIGDNF, Allocator DGKNIHLPENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DC80", Offset = "0x3A9CA80", VA = "0x183A9DC80")]
	public BPNOBCOILLF(CBDNIAOJPJI AFFLCFIGDNF, NativeArray<LocalId> ILEEGIHBOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EC74B0", Offset = "0x5EC62B0", VA = "0x185EC74B0")]
	internal BPNOBCOILLF(CBDNIAOJPJI AFFLCFIGDNF, NativeArray<Entity> DGGFIPBLDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EC75D0", Offset = "0x5EC63D0", VA = "0x185EC75D0")]
	public BPNOBCOILLF(CBDNIAOJPJI AFFLCFIGDNF, int ELGJIDFGJJH, Allocator DGKNIHLPENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7520", Offset = "0x5EC6320", VA = "0x185EC7520")]
	public BPNOBCOILLF(BPNOBCOILLF AOKAGBDIDLM, Allocator DGKNIHLPENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7140", Offset = "0x5EC5F40", VA = "0x185EC7140")]
	public BPNOBCOILLF KLIGLKFNLOP(Allocator DGKNIHLPENE = Allocator.Temp)
	{
		return default(BPNOBCOILLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7100", Offset = "0x5EC5F00", VA = "0x185EC7100", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC71F0", Offset = "0x5EC5FF0", VA = "0x185EC71F0")]
	public NOAMHPMPBJP NABGDMMLCNI()
	{
		return default(NOAMHPMPBJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5EC72D0", Offset = "0x5EC60D0", VA = "0x185EC72D0", Slot = "6")]
	private IEnumerator<ICMPCFCEMJM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5EC73C0", Offset = "0x5EC61C0", VA = "0x185EC73C0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct EMMHLPOMAPD : IList<ICMPCFCEMJM>, ICollection<ICMPCFCEMJM>, IEnumerable<ICMPCFCEMJM>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct AIAPCKBDAPD : IEnumerator<ICMPCFCEMJM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly CBDNIAOJPJI AFFLCFIGDNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator JDNLPJMOHGA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ICMPCFCEMJM POOLCAAKLKE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5EC6540", Offset = "0x5EC5340", VA = "0x185EC6540", Slot = "4")]
			get
			{
				return default(ICMPCFCEMJM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5EC64C0", Offset = "0x5EC52C0", VA = "0x185EC64C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3A9E200", Offset = "0x3A9D000", VA = "0x183A9E200")]
		public AIAPCKBDAPD(CBDNIAOJPJI AFFLCFIGDNF, NativeArray<LocalId>.Enumerator JDNLPJMOHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6400", Offset = "0x5EC5200", VA = "0x185EC6400", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6440", Offset = "0x5EC5240", VA = "0x185EC6440", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6480", Offset = "0x5EC5280", VA = "0x185EC6480", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly CBDNIAOJPJI AFFLCFIGDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> ILEEGIHBOBP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public ICMPCFCEMJM LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5ECA680", Offset = "0x5EC9480", VA = "0x185ECA680", Slot = "4")]
		get
		{
			return default(ICMPCFCEMJM);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5ECA700", Offset = "0x5EC9500", VA = "0x185ECA700", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECA220", Offset = "0x5EC9020", VA = "0x185ECA220", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DLGHEHGPEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECA220", Offset = "0x5EC9020", VA = "0x185ECA220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool FDJGALFBLIP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7B92E0", Offset = "0x7B80E0", VA = "0x1807B92E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA5F0", Offset = "0x5EC93F0", VA = "0x185ECA5F0")]
	public EMMHLPOMAPD(CBDNIAOJPJI AFFLCFIGDNF, int ELGJIDFGJJH, Allocator DGKNIHLPENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA020", Offset = "0x5EC8E20", VA = "0x185ECA020")]
	public BPNOBCOILLF DJFOLKBNKHN()
	{
		return default(BPNOBCOILLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9E00", Offset = "0x5EC8C00", VA = "0x185EC9E00", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9E40", Offset = "0x5EC8C40", VA = "0x185EC9E40", Slot = "13")]
	public bool Contains(ICMPCFCEMJM DAPKCDOOBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9ED0", Offset = "0x5EC8CD0", VA = "0x185EC9ED0", Slot = "14")]
	public void CopyTo(ICMPCFCEMJM[] LPMIAHOCPLL, int LKGKKAPFOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9D80", Offset = "0x5EC8B80", VA = "0x185EC9D80", Slot = "11")]
	public void Add(ICMPCFCEMJM DAPKCDOOBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA170", Offset = "0x5EC8F70", VA = "0x185ECA170", Slot = "7")]
	public void Insert(int NGIPPLLBEKC, ICMPCFCEMJM DAPKCDOOBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA340", Offset = "0x5EC9140", VA = "0x185ECA340", Slot = "15")]
	public bool Remove(ICMPCFCEMJM DAPKCDOOBFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA0E0", Offset = "0x5EC8EE0", VA = "0x185ECA0E0", Slot = "6")]
	public int IndexOf(ICMPCFCEMJM DAPKCDOOBFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA2F0", Offset = "0x5EC90F0", VA = "0x185ECA2F0", Slot = "8")]
	public void RemoveAt(int NGIPPLLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA0A0", Offset = "0x5EC8EA0", VA = "0x185ECA0A0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA260", Offset = "0x5EC9060", VA = "0x185ECA260")]
	public AIAPCKBDAPD NABGDMMLCNI()
	{
		return default(AIAPCKBDAPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA410", Offset = "0x5EC9210", VA = "0x185ECA410", Slot = "16")]
	private IEnumerator<ICMPCFCEMJM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA500", Offset = "0x5EC9300", VA = "0x185ECA500", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface IADJKNOBBHN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int BFDGNDJIIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> GEDBFEMCGCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ICMPCFCEMJM DHKLBPJMEMB(ICMPCFCEMJM ILEEGIHBOBP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface EOKCACABFOF : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface HMMIIBAHCMH : FHJJPOPNOAF, BNLOPGCJCAK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool JHCMEJDPEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	LDNEBIJFPKJ KEHBIBLHFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	HDFNKCCPJBH HJBANJAEIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PKELPAFEAOF HHABHEGDIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	KLBOEKHDFKN DIOMABNAAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	MNADOFCIMAE IMCEBJAJKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface BNLOPGCJCAK
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool LPMBBCCNKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface HFCPKNBDKGI
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JIJPPKJEFJF(bool PHPDIJICBJO);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface KLBOEKHDFKN
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool MCHPIIJMCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PMENCLPAECL;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NJABAMKAALL(bool KNJPMDLJCHO);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KFNIKCDEJDP(ByteString BBFMJKBFLAL);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BGHBJAINIEG();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LOHKBCBHFCI();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GPHAJNKJLHP();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface PKELPAFEAOF
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	DFLOIMJPFAA KEHBIBLHFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	HDFNKCCPJBH HJBANJAEIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	LBEDLKIHHGM MIKINHLNGFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	HMMIIBAHCMH HOCHHMEBFMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	CBDNIAOJPJI ONHPHNMDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	NBFOGOBGPBO HDOCJJOIAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	AOGKDDGDLGP BFAENNGKPBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	DMJEPKFGKAD MAPBJIKCIGB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IFAJNEEBKFI NFOCKAOCJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	HIOKBDCCCHJ KDHNMMNIJAH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	EHIMPLCPNJB OHIDBLJBFHG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	HJFPGHLFPJN OEJILEKADBE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	PNEFPPCLIMI LJEBFPEAGFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	HDILPGAKFOP NBNKCJIJGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	AHJMCNBAMOO JLJEMLOKLHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	GKJFKJIDMHC ENKIPBPANKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	MNGIPEMAAHD LCHBLNIIFIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	AKEDKKKIDLP KFMKKIOEFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	LEFOGCJEKPJ KMPNDCIBGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	IJKJEOFEOAI IKPOMMMEAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	CCBLBJONCKG BKPCLAHIIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(KBADHEEANLD))]
public readonly struct ICMPCFCEMJM : IComparable<ICMPCFCEMJM>, IEquatable<ICMPCFCEMJM>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly ICMPCFCEMJM OAICJFILECK;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int MLMCFPEGCNH = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int PNIEHHICBJD = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int FFJOICIJHDE = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int PKHEBGFJGHO = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId APAPEJEHLCD;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public CBDNIAOJPJI ONHPHNMDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7B00", Offset = "0x5EC6900", VA = "0x185EC7B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public HMMIIBAHCMH HOCHHMEBFMN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5ECBC30", Offset = "0x5ECAA30", VA = "0x185ECBC30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public LocalId DGIFDMFLBIO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC1D0", Offset = "0x5ECAFD0", VA = "0x185ECC1D0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	internal MNADOFCIMAE IMCEBJAJKCG
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC260", Offset = "0x5ECB060", VA = "0x185ECC260")]
		get
		{
			return default(MNADOFCIMAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool ELLDGLBOGGN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC0F0", Offset = "0x5ECAEF0", VA = "0x185ECC0F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool MCLPJEFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECBF80", Offset = "0x5ECAD80", VA = "0x185ECBF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool PPDBFFPBFCO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC210", Offset = "0x5ECB010", VA = "0x185ECC210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5ECC3A0", Offset = "0x5ECB1A0", VA = "0x185ECC3A0")]
	public ICMPCFCEMJM(CBDNIAOJPJI CLFLHABIFFN, LocalId APAPEJEHLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
	public NIOIPIDANEB HKKJKNHPIGP()
	{
		return default(NIOIPIDANEB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBD70", Offset = "0x5ECAB70", VA = "0x185ECBD70")]
	public static LocalId DNODACOFDOB(ICMPCFCEMJM DOIBPEFIJCD)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBDB0", Offset = "0x5ECABB0", VA = "0x185ECBDB0")]
	public static Entity DNODACOFDOB(ICMPCFCEMJM DOIBPEFIJCD)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBFD0", Offset = "0x5ECADD0", VA = "0x185ECBFD0")]
	public static bool HIHGGPGGFPN(ICMPCFCEMJM ALNGIEPPLJJ, ICMPCFCEMJM DCODMCLNKEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9440", Offset = "0x5EC8240", VA = "0x185EC9440")]
	public static bool CAOAIKCPFJO(ICMPCFCEMJM ALNGIEPPLJJ, ICMPCFCEMJM DCODMCLNKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5ECC270", Offset = "0x5ECB070", VA = "0x185ECC270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBDF0", Offset = "0x5ECABF0", VA = "0x185ECBDF0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBC90", Offset = "0x5ECAA90", VA = "0x185ECBC90", Slot = "4")]
	public int CompareTo(ICMPCFCEMJM LCIDHBCOPEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "5")]
	public bool Equals(ICMPCFCEMJM LCIDHBCOPEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MGINDAGIMNN
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2650", Offset = "0x5ED1450", VA = "0x185ED2650")]
	public static EABFOFIEHMJ DNHGNGMJIHO(this ICMPCFCEMJM KANAGAAAGHJ)
	{
		return default(EABFOFIEHMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x257F0C0", Offset = "0x257DEC0", VA = "0x18257F0C0")]
	public static T BBNLMJLCFBH<T>(this ICMPCFCEMJM KANAGAAAGHJ) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal sealed class KBADHEEANLD
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct MNADOFCIMAE : IEquatable<MNADOFCIMAE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte JEGLLFDAPLN;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] AAENGGHIELB;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static CBDNIAOJPJI JHNMCIBPCFO;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static HMMIIBAHCMH ACLCCDPJGGN;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static CBDNIAOJPJI[] EMEMNKFACNK;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static HMMIIBAHCMH[] OCLCCEPJGIO;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> EKONFHEBIPG;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public HMMIIBAHCMH HOCHHMEBFMN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2AA0", Offset = "0x5ED18A0", VA = "0x185ED2AA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public CBDNIAOJPJI AOPPLCMADMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3490", Offset = "0x5ED2290", VA = "0x185ED3490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED36D0", Offset = "0x5ED24D0", VA = "0x185ED36D0")]
	static MNADOFCIMAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xBA4570", Offset = "0xBA3370", VA = "0x180BA4570")]
	internal MNADOFCIMAE(byte PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x51940D0", Offset = "0x5192ED0", VA = "0x1851940D0", Slot = "4")]
	public bool Equals(MNADOFCIMAE LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5ED31D0", Offset = "0x5ED1FD0", VA = "0x185ED31D0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x19AB520", Offset = "0x19AA320", VA = "0x1819AB520", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3610", Offset = "0x5ED2410", VA = "0x185ED3610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5ED33E0", Offset = "0x5ED21E0", VA = "0x185ED33E0")]
	private static CBDNIAOJPJI IMAPPICCEOA(byte JEGLLFDAPLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5ED27D0", Offset = "0x5ED15D0", VA = "0x185ED27D0")]
	private static HMMIIBAHCMH BGDAOICCPPH(byte JEGLLFDAPLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3270", Offset = "0x5ED2070", VA = "0x185ED3270")]
	private static object HJALOKIAHIF(byte JEGLLFDAPLN, object[] CMKGLPFECEG, object JDDKNLMJJIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3570", Offset = "0x5ED2370", VA = "0x185ED3570")]
	private static int JLCKPLCKIPC(byte JEGLLFDAPLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3600", Offset = "0x5ED2400", VA = "0x185ED3600")]
	private static int NFPIHBFHJEB(byte JEGLLFDAPLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3580", Offset = "0x5ED2380", VA = "0x185ED3580")]
	private static (int, int) MPENCMGILFC(byte JEGLLFDAPLN)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2880", Offset = "0x5ED1680", VA = "0x185ED2880")]
	private static byte BLPGANLGHBH(int PPBKIGHJOID, int NGIPPLLBEKC)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2F10", Offset = "0x5ED1D10", VA = "0x185ED2F10")]
	internal static MNADOFCIMAE EEHFKNGNNHO(HMMIIBAHCMH JAPABNBPENJ, CBDNIAOJPJI BGMCKBIAABK)
	{
		return default(MNADOFCIMAE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2890", Offset = "0x5ED1690", VA = "0x185ED2890")]
	internal static void CECAHPBMPOM(MNADOFCIMAE JEGLLFDAPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2B80", Offset = "0x5ED1980", VA = "0x185ED2B80")]
	private static void DDJKLIHCMPM(int FNJNELBIPIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface BCJBDGMFKPK
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDFFLIFHPCM();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CAHEMAIMDGJ(bool KNDJAEJFMDJ);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JDKDJEODJDB(GameObject CJHJDJNKIGF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface POGCIFLKBNE
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	Guid BPLKIPHLLJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GOEEFEIKOAK(Guid KEFPILGMJFC, Guid PEOIJIDCKDI);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task LBJHEPBKLAJ(ICMPCFCEMJM ABDBLFGOBHA);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IONMHLNMDCI(ICMPCFCEMJM COBMMEELOCB, ICMPCFCEMJM BMNEKBHDGLJ, [Out] Vector3 PHLIKEKMOFA, [Out] Quaternion GKLJGLEHAOP);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CEKEMJKFOKO(LOIPFAFMBLM CIPMHBDGCOO, Vector3 PHLIKEKMOFA, Quaternion GKLJGLEHAOP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface HMMOPBOFOND
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIHHFAGLFKL(BPNOBCOILLF ILEEGIHBOBP);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface HDFNKCCPJBH
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	BCJBDGMFKPK BNJIEJDCGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	NADCPPIGLFB CFCFMLDCAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	CMEPGGCCOLH FCFPELJBBCE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	DBMNBDECAIP DKANAMGLAOH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	MOKHDBKDLIJ PIFLEBOCPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	KBLLJLDJIFM AIMJEJGFFPB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	NLOKHFBKDEO OMDDJNFEDNA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	MGPLEBLKKKI FBLPALNDCOF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface HBOGDOKIMGM
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHEJIPPIJPF(Action CBNAIFNPGEI, bool NJNNIFMMOEA);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ONHIBBIBAKD(string NDLLBBKGIJD);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface NADCPPIGLFB
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string BAJPIFKKLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] ICDBMNHOKFM(IEnumerable<GEPFADDONPB> HFFECNEPHHC);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ECCKDGOOMJK(GameObject CJHJDJNKIGF, [Out] EABFOFIEHMJ[] JHALHPHCAKG);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GBDKJAKDOAF(GameObject CJHJDJNKIGF, [Out] int OOJPPIODLDE, [Out] POLLAGMGKIL HPJEHGNFPGN);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "4")]
	KMKIDLKFNMD ELAOGJJOLAM(GEPFADDONPB MGDLKMJIAPA);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KMKIDLKFNMD ELAOGJJOLAM(string PHPPAMIKEEH, EABFOFIEHMJ[] MDOHEAFMDAC, Vector3 LMGPBOPOFGA, Quaternion BPBCJFMFECG, Vector3 OINLNNPPPEB);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject OIPGHDBCKEN(string PHPPAMIKEEH);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JLPJEBFBLCF(GameObject HLMKNJKPNHF, bool APOPKKNKJIH);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KEBKFLLIDPG(GameObject CJHJDJNKIGF, bool AFBPBCDNKOJ, bool FPHDOFDPCJO);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class GLJOGNMPNFA
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB5A0", Offset = "0x5ECA3A0", VA = "0x185ECB5A0")]
	public static KMKIDLKFNMD ELAOGJJOLAM(this NADCPPIGLFB GPBKPNHGBGO, Vector3 LMGPBOPOFGA, Quaternion BPBCJFMFECG, Vector3 OINLNNPPPEB, params EABFOFIEHMJ[] JHALHPHCAKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface CMEPGGCCOLH
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJFDAOKADLJ(bool KNJPMDLJCHO);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface DBMNBDECAIP
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	bool EIAMPHGFMHA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	bool DFLHNKBLGHG
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool IPBDBJDLPIG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool CBMGFHKIPCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FNLMAFFJDGF(object IPHMLIFNKFM);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ACJLDEGNCPI(object IPHMLIFNKFM);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EFIAJMFEAFN(object PODCKBKAANA);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KAMDOPHJENE(object PODCKBKAANA);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int COLGHDPOPHA(GameObject OEBPJKHEKGE);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KAPJPEIJLLB(NativeArray<int> JLFJNBFEBLA);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MDEMGJKGLOB(NativeArray<int> OGCGNDABFEN);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IIKKPBPBJHL([Out] byte[] CDFPBGIKFLH, [Out] byte[] MIFDHOIGEIP);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void PFEPHJCDNNL(ReadOnlySpan<byte> IPHMLIFNKFM, ReadOnlySpan<byte> MIFDHOIGEIP);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PGKMEKDBAIF();

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EOFKIOEGKGB(uint FJBOMLDGEMP, ReadOnlySpan<byte> KNAIEKIJLBC);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface MOKHDBKDLIJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIDHDEILPPO(GameObject CJHJDJNKIGF);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface LPGLKIHFMGB
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NEILDGFACNA(string KHIFMDJDLEG);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface IFIHBGICAIH
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CKLDOKMFABJ(GameObject CJHJDJNKIGF);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLAIDNFBMBL(GameObject CJHJDJNKIGF);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object BOILHNCEOBL(ICMPCFCEMJM APAPEJEHLCD, GameObject CJHJDJNKIGF, Action<ICMPCFCEMJM, int> PJJEKPONKPF);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DJCLNMLHCFF(GameObject CJHJDJNKIGF, object CJAGABEBOHG);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface KBLLJLDJIFM
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	int BJFOPIEIOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int HCIMOLIIMLM(GameObject CJHJDJNKIGF);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LBPNFDGKEDC([Out] Vector3 LMGPBOPOFGA);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PFDFGJOKFNE();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface NLOKHFBKDEO
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool MCHPIIJMCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool MJNHOHIPDKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface HNJGENNFDME
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	AKOIDIHMKJM ENKPPMNGNPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	ODCBNJJHALC NBPKMDKGFLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KBLHLBEHGDN(Transform AGLGKAHAKII);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKPNLEOJALF(Transform AGLGKAHAKII, NGMHFBHFBHF JBNFDALHGMH);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KGPDOFPAOHH(Transform AGLGKAHAKII, FDCNBJCCLMM OMGAFDEMCOG);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface MGPLEBLKKKI
{
	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FLBJJNLIJDO();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface OKKLFAFEHCH
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBNCNLLHHNL();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface PLAFLLBOOFN
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	POLLAGMGKIL HEIFMHFNCIK(GameObject OEBPJKHEKGE);

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHOAAFANAOJ(GameObject CJHJDJNKIGF, BHOBLHHNKGA LNIGJGOBOGM, NHBELKMMMFO CDNGJOBMILM);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string GJKIIKIDDPG(int JPODHBJFPKM);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int MJFLIIDKEKH(string PJDDMDCEPLD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HHIGKMIJFEF(ICMPCFCEMJM APAPEJEHLCD, int[] LDABNMIJELK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EMPKMOCDFGP(GameObject MKLHGMPEOEO, GameObject PEFADLAHDJJ, int DLMKMBMNBLO);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct LEFOLGJFEDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly JMKNGCDFCBJ EIJIJLGPLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly JMKNGCDFCBJ GNLJFNAGDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint LPBKLKOLGIA;

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5ED13E0", Offset = "0x5ED01E0", VA = "0x185ED13E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct DNENBAIJKCC
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly BOGDNAKJHCL BNIILMIMBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly LEFOLGJFEDB CBNAIFNPGEI;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5EC83E0", Offset = "0x5EC71E0", VA = "0x185EC83E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct NNDDNOEBOEI
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly BOGDNAKJHCL BNIILMIMBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly LEFOLGJFEDB CBNAIFNPGEI;

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5EC83E0", Offset = "0x5EC71E0", VA = "0x185EC83E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct OMBAKOPPAOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint LPBKLKOLGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool MAABEEIEAIN;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6520", Offset = "0x5ED5320", VA = "0x185ED6520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct JMKNGCDFCBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int PLIILJHILHI;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1210", Offset = "0x5ED0010", VA = "0x185ED1210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface CHNAHPGBMAM
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	FAPHJANGOFJ GPFMDIGGDBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum GLNAJPOMAKM
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
public interface KMKIDLKFNMD : OMDHNDMEGFM
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	GLNAJPOMAKM HBJMCIHLGCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	bool FKFNFKDMEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	GameObject CJHJDJNKIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KMKIDLKFNMD> LGPFNEJOHNE;

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(LBEDLKIHHGM FKPOHGDAOOH, ICMPCFCEMJM DGNCHIIONJA);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool AKHMDADEGHC);

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class NKHOLAPHHKO
{
	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5ED45A0", Offset = "0x5ED33A0", VA = "0x185ED45A0")]
	public static bool LMAMNNDPCGP(this KMKIDLKFNMD PLHJDKMHELE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4470", Offset = "0x5ED3270", VA = "0x185ED4470")]
	public static bool EIKOLGDPCGM(this KMKIDLKFNMD PLHJDKMHELE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5ED44C0", Offset = "0x5ED32C0", VA = "0x185ED44C0")]
	public static bool HDFMFPFAJGJ(this KMKIDLKFNMD PLHJDKMHELE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4510", Offset = "0x5ED3310", VA = "0x185ED4510")]
	public static bool JHCMEJDPEKI(this KMKIDLKFNMD PLHJDKMHELE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OMDHNDMEGFM
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool LNODLGKLEOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	ICMPCFCEMJM DMKPCFEDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
internal interface KNNLLMNLFIF
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<HAOHLIHBEBG> PNILMGEOCNG;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface AMPOPAEHFMG : MJKCPOHAALI<EABFOFIEHMJ>, NKHIPPPEKLG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface MOJKOPAJGMK<T> : PEPIOFAEGBI<EABFOFIEHMJ, T>, MJKCPOHAALI<EABFOFIEHMJ>, NKHIPPPEKLG, IDisposable, AMPOPAEHFMG where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FNPLGBEOKAL
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x24C3250", Offset = "0x24C2050", VA = "0x1824C3250")]
	public static bool PGALEGIIEOF<T>(this MJKCPOHAALI<EABFOFIEHMJ> NEBGFGPEMHL, EABFOFIEHMJ MDOHEAFMDAC, [Out] T PHPDIJICBJO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x232E000", Offset = "0x232CE00", VA = "0x18232E000")]
	public static bool CCOBHHAAMMF<T>(this MJKCPOHAALI<EABFOFIEHMJ> NEBGFGPEMHL, EABFOFIEHMJ MDOHEAFMDAC, [In] T IBLOAPAOIFJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface JHBILBHMEEM : MJKCPOHAALI<ICMPCFCEMJM>, NKHIPPPEKLG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface AEFBBMCIMAF<T> : PEPIOFAEGBI<ICMPCFCEMJM, T>, MJKCPOHAALI<ICMPCFCEMJM>, NKHIPPPEKLG, IDisposable, JHBILBHMEEM where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class PODFAPJFDFO
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x232DCA0", Offset = "0x232CAA0", VA = "0x18232DCA0")]
	public static T HFNEOIKDHBA<T>(this MJKCPOHAALI<ICMPCFCEMJM> NEBGFGPEMHL, ICMPCFCEMJM APAPEJEHLCD) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x232E0F0", Offset = "0x232CEF0", VA = "0x18232E0F0")]
	public static bool CCOBHHAAMMF<T>(this MJKCPOHAALI<ICMPCFCEMJM> NEBGFGPEMHL, ICMPCFCEMJM APAPEJEHLCD, [In] T IBLOAPAOIFJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct AAMPPPNKBPN : IComparable<AAMPPPNKBPN>, IEquatable<AAMPPPNKBPN>
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly AAMPPPNKBPN OAICJFILECK;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly AAMPPPNKBPN GIEGNOOLKDK;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly AAMPPPNKBPN OOEKCDLEAGB;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly AAMPPPNKBPN KLBDBJFFILI;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly AAMPPPNKBPN JIGJFDKFBPC;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly AAMPPPNKBPN EDNHHMOICDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int FNPAHLCJLFK;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool LNBOCDNIFNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5EC60C0", Offset = "0x5EC4EC0", VA = "0x185EC60C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int BAIFKBLJFIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5EC60D0", Offset = "0x5EC4ED0", VA = "0x185EC60D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x8324C0", Offset = "0x8312C0", VA = "0x1808324C0")]
	public AAMPPPNKBPN(int NGIPPLLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6160", Offset = "0x5EC4F60", VA = "0x185EC6160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5EC60E0", Offset = "0x5EC4EE0", VA = "0x185EC60E0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x16C9C30", Offset = "0x16C8A30", VA = "0x1816C9C30", Slot = "5")]
	public bool Equals(AAMPPPNKBPN LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x16D9D10", Offset = "0x16D8B10", VA = "0x1816D9D10", Slot = "4")]
	public int CompareTo(AAMPPPNKBPN LCIDHBCOPEO)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0xD518E0", Offset = "0xD506E0", VA = "0x180D518E0")]
	public static AAMPPPNKBPN DNODACOFDOB(int NGIPPLLBEKC)
	{
		return default(AAMPPPNKBPN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0xD518E0", Offset = "0xD506E0", VA = "0x180D518E0")]
	public static int DNODACOFDOB(AAMPPPNKBPN PNCLPGLPBGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5EC61C0", Offset = "0x5EC4FC0", VA = "0x185EC61C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct NIOIPIDANEB : IEquatable<NIOIPIDANEB>, OMDHNDMEGFM
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly NIOIPIDANEB LADPMFENNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public ICMPCFCEMJM DMKPCFEDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900", Slot = "6")]
		get
		{
			return default(ICMPCFCEMJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public JLJIBPEMPFO EHAGGAFELKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(JLJIBPEMPFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public FHDPJEAPCAP HDOCJJOIAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(FHDPJEAPCAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private CBDNIAOJPJI ONHPHNMDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7B00", Offset = "0x5EC6900", VA = "0x185EC7B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public GameObject CJHJDJNKIGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4190", Offset = "0x5ED2F90", VA = "0x185ED4190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public EABFOFIEHMJ ECIKFCGOACG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5ED40D0", Offset = "0x5ED2ED0", VA = "0x185ED40D0")]
		get
		{
			return default(EABFOFIEHMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public KHGCHFOOBOE KFFFPNNDEFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5ED38E0", Offset = "0x5ED26E0", VA = "0x185ED38E0")]
		get
		{
			return default(KHGCHFOOBOE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public POLLAGMGKIL CGCAKFJLPPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3E50", Offset = "0x5ED2C50", VA = "0x185ED3E50")]
		get
		{
			return default(POLLAGMGKIL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool HJABFBIMJLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3A90", Offset = "0x5ED2890", VA = "0x185ED3A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool IIEPBJJGJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4080", Offset = "0x5ED2E80", VA = "0x185ED4080")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool ILBOBGEOBMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4320", Offset = "0x5ED3120", VA = "0x185ED4320")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool CLNDBMBICLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4170", Offset = "0x5ED2F70", VA = "0x185ED4170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool KDJBKJBKAFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3F70", Offset = "0x5ED2D70", VA = "0x185ED3F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool MJJJFKHJDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3AB0", Offset = "0x5ED28B0", VA = "0x185ED3AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool ACBBEOFGDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3CD0", Offset = "0x5ED2AD0", VA = "0x185ED3CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool EGELGMLGAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3980", Offset = "0x5ED2780", VA = "0x185ED3980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public EIOFGMOIFKP PAIICDDLHKP
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(EIOFGMOIFKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public ELAJHABGFPM APBACGDJGKN
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(ELAJHABGFPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public AKFNBGHHHPJ LJEBFPEAGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(AKFNBGHHHPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public OHNPHJEIDHO BLECOEJLNGI
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(OHNPHJEIDHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public IODNFCGIJHP OEJILEKADBE
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(IODNFCGIJHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public MCCNOOOACLH IMOMFAIHBBC
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(MCCNOOOACLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public LOIPFAFMBLM FMBAKKMAEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(LOIPFAFMBLM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public BPKAHJJAJAK KPNENHKHMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(BPKAHJJAJAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool LMAMNNDPCGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3D60", Offset = "0x5ED2B60", VA = "0x185ED3D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool ODMMLGPAOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3D20", Offset = "0x5ED2B20", VA = "0x185ED3D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool EMPGDJMHIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3B80", Offset = "0x5ED2980", VA = "0x185ED3B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private bool DFIMKBAONGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x78A100", Offset = "0x788F00", VA = "0x18078A100", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public NIOIPIDANEB(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5EC77A0", Offset = "0x5EC65A0", VA = "0x185EC77A0")]
	public static bool DNODACOFDOB(NIOIPIDANEB PHPDIJICBJO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
	public static ICMPCFCEMJM DNODACOFDOB(NIOIPIDANEB PHPDIJICBJO)
	{
		return default(ICMPCFCEMJM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3D10", Offset = "0x5ED2B10", VA = "0x185ED3D10")]
	public static bool HIHGGPGGFPN(NIOIPIDANEB ALNGIEPPLJJ, NIOIPIDANEB DCODMCLNKEM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9440", Offset = "0x5EC8240", VA = "0x185EC9440")]
	public static bool CAOAIKCPFJO(NIOIPIDANEB ALNGIEPPLJJ, NIOIPIDANEB DCODMCLNKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3AF0", Offset = "0x5ED28F0", VA = "0x185ED3AF0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(NIOIPIDANEB LCIDHBCOPEO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
	public static NIOIPIDANEB DNODACOFDOB(ICMPCFCEMJM EMALEGKCAJH)
	{
		return default(NIOIPIDANEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3EF0", Offset = "0x5ED2CF0", VA = "0x185ED3EF0")]
	public INFGEEBPAJI LOOLNEGGDOP()
	{
		return default(INFGEEBPAJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5ED40A0", Offset = "0x5ED2EA0", VA = "0x185ED40A0")]
	public EKPPIEJGELG PCHPNEEGMLI()
	{
		return default(EKPPIEJGELG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4340", Offset = "0x5ED3140", VA = "0x185ED4340")]
	public CDPAGEHKKED PMGOOCBOHNM()
	{
		return default(CDPAGEHKKED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3BC0", Offset = "0x5ED29C0", VA = "0x185ED3BC0")]
	public void GHENEIFAEAI([Optional] object HOBAPMCPFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5ED39A0", Offset = "0x5ED27A0", VA = "0x185ED39A0")]
	public bool BKLIKKBBENM(object HOBAPMCPFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3F90", Offset = "0x5ED2D90", VA = "0x185ED3F90")]
	public bool NHGFHLIJNMG(object HOBAPMCPFML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4390", Offset = "0x5ED3190", VA = "0x185ED4390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct LOIPFAFMBLM : IEquatable<LOIPFAFMBLM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public ICMPCFCEMJM DMKPCFEDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(ICMPCFCEMJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	private CBDNIAOJPJI ONHPHNMDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7B00", Offset = "0x5EC6900", VA = "0x185EC7B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private PKELPAFEAOF HHABHEGDIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5ED18C0", Offset = "0x5ED06C0", VA = "0x185ED18C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private GKJFKJIDMHC IFNGNFAAPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1F90", Offset = "0x5ED0D90", VA = "0x185ED1F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool ICGDPBIHPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1A80", Offset = "0x5ED0880", VA = "0x185ED1A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public Guid CLAECJANOFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1C30", Offset = "0x5ED0A30", VA = "0x185ED1C30")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public bool ABNLCNGDMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1BA0", Offset = "0x5ED09A0", VA = "0x185ED1BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Guid KLIBDGJKFAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5ED2090", Offset = "0x5ED0E90", VA = "0x185ED2090")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public LOIPFAFMBLM(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC77A0", Offset = "0x5EC65A0", VA = "0x185EC77A0")]
	public static bool DNODACOFDOB(LOIPFAFMBLM PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1B10", Offset = "0x5ED0910", VA = "0x185ED1B10", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(LOIPFAFMBLM LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1FF0", Offset = "0x5ED0DF0", VA = "0x185ED1FF0")]
	public bool JEGBFIEBBMK([Out] Guid MOFFGNIDNJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1E70", Offset = "0x5ED0C70", VA = "0x185ED1E70")]
	public void HKDIHHENDFN(Guid DEEINHGIBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED19E0", Offset = "0x5ED07E0", VA = "0x185ED19E0")]
	public bool CMIMHJEJCPJ([Out] Guid CNNNLFIFOJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1D50", Offset = "0x5ED0B50", VA = "0x185ED1D50")]
	public void GHBAGIJIMFA(Guid DEEINHGIBAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1950", Offset = "0x5ED0750", VA = "0x185ED1950")]
	public void CLLJHBIANGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct CDPAGEHKKED : IEquatable<CDPAGEHKKED>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public ICMPCFCEMJM DMKPCFEDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(ICMPCFCEMJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private CBDNIAOJPJI ONHPHNMDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7B00", Offset = "0x5EC6900", VA = "0x185EC7B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private PKELPAFEAOF HHABHEGDIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5EC78B0", Offset = "0x5EC66B0", VA = "0x185EC78B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private MNGIPEMAAHD EHCOAMCNPJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7D10", Offset = "0x5EC6B10", VA = "0x185EC7D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public float3 GDBAANKDFGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5EC79D0", Offset = "0x5EC67D0", VA = "0x185EC79D0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public quaternion BPHABCGBPCD
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7BF0", Offset = "0x5EC69F0", VA = "0x185EC7BF0")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public NIOIPIDANEB BGLLKAMIPMF
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7B60", Offset = "0x5EC6960", VA = "0x185EC7B60")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public CDPAGEHKKED(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
	public static ICMPCFCEMJM DNODACOFDOB(CDPAGEHKKED PHPDIJICBJO)
	{
		return default(ICMPCFCEMJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7940", Offset = "0x5EC6740", VA = "0x185EC7940", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(CDPAGEHKKED LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct INFGEEBPAJI : IEquatable<INFGEEBPAJI>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class IJIKADOFMFN : IEnumerable<NIOIPIDANEB>, IEnumerable, IEnumerator<NIOIPIDANEB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private NIOIPIDANEB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public INFGEEBPAJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public INFGEEBPAJI <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IEnumerator<NIOIPIDANEB> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IEnumerator<ICMPCFCEMJM> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		private NIOIPIDANEB System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.RRObject>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x3156A70", Offset = "0x3155870", VA = "0x183156A70", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(NIOIPIDANEB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x5ECCBE0", Offset = "0x5ECB9E0", VA = "0x185ECCBE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x33B84B0", Offset = "0x33B72B0", VA = "0x1833B84B0")]
		[DebuggerHidden]
		public IJIKADOFMFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCC30", Offset = "0x5ECBA30", VA = "0x185ECCC30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC5D0", Offset = "0x5ECB3D0", VA = "0x185ECC5D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC530", Offset = "0x5ECB330", VA = "0x185ECC530")]
		private void FKICEAEIDMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC4E0", Offset = "0x5ECB2E0", VA = "0x185ECC4E0")]
		private void CEJKOOJCMDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x5ECC580", Offset = "0x5ECB380", VA = "0x185ECC580")]
		private void HLMOOGDKGMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCB90", Offset = "0x5ECB990", VA = "0x185ECCB90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCAF0", Offset = "0x5ECB8F0", VA = "0x185ECCAF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<NIOIPIDANEB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.RRObject>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCAF0", Offset = "0x5ECB8F0", VA = "0x185ECCAF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly INFGEEBPAJI LADPMFENNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public ICMPCFCEMJM DMKPCFEDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(ICMPCFCEMJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public JLJIBPEMPFO EHAGGAFELKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(JLJIBPEMPFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public FHDPJEAPCAP HDOCJJOIAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(FHDPJEAPCAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private CBDNIAOJPJI ONHPHNMDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7B00", Offset = "0x5EC6900", VA = "0x185EC7B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private PKELPAFEAOF HHABHEGDIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCEE0", Offset = "0x5ECBCE0", VA = "0x185ECCEE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private NBFOGOBGPBO IOAMDDDKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDA80", Offset = "0x5ECC880", VA = "0x185ECDA80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public BPNOBCOILLF EOGIFNLJEFO
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD290", Offset = "0x5ECC090", VA = "0x185ECD290")]
		get
		{
			return default(BPNOBCOILLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public IEnumerable<NIOIPIDANEB> KEEMEJDOOCP
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD120", Offset = "0x5ECBF20", VA = "0x185ECD120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IEnumerable<NIOIPIDANEB> DEBHKJFFKFL
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD950", Offset = "0x5ECC750", VA = "0x185ECD950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int MENAMAOCLME
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD3D0", Offset = "0x5ECC1D0", VA = "0x185ECD3D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int ONEFFNPLMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCF70", Offset = "0x5ECBD70", VA = "0x185ECCF70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public string NKCKPGIEOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE000", Offset = "0x5ECCE00", VA = "0x185ECE000")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCE30", Offset = "0x5ECBC30", VA = "0x185ECCE30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public BPGIMFEDAKL JIAOODDCAPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD460", Offset = "0x5ECC260", VA = "0x185ECD460")]
		get
		{
			return default(BPGIMFEDAKL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDEC0", Offset = "0x5ECCCC0", VA = "0x185ECDEC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public BJLCIIICICE CIMBMAINOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE180", Offset = "0x5ECCF80", VA = "0x185ECE180")]
		get
		{
			return default(BJLCIIICICE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE0B0", Offset = "0x5ECCEB0", VA = "0x185ECE0B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public OLCEPKJGCNA MANIHHBLOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDF30", Offset = "0x5ECCD30", VA = "0x185ECDF30")]
		get
		{
			return default(OLCEPKJGCNA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDB50", Offset = "0x5ECC950", VA = "0x185ECDB50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public float FOCIGBMMLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD800", Offset = "0x5ECC600", VA = "0x185ECD800")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDE50", Offset = "0x5ECCC50", VA = "0x185ECDE50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool AGOJOKJCJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5ECCFC0", Offset = "0x5ECBDC0", VA = "0x185ECCFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool PIJPLKLDMBE
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDBC0", Offset = "0x5ECC9C0", VA = "0x185ECDBC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool HNPHECJMOEE
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDC30", Offset = "0x5ECCA30", VA = "0x185ECDC30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool BNKOOBNAFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD030", Offset = "0x5ECBE30", VA = "0x185ECD030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool KPBCHNMGHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE120", Offset = "0x5ECCF20", VA = "0x185ECE120")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDF90", Offset = "0x5ECCD90", VA = "0x185ECDF90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool CGPBBLKLMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5ECD8D0", Offset = "0x5ECC6D0", VA = "0x185ECD8D0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5ECDAE0", Offset = "0x5ECC8E0", VA = "0x185ECDAE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public INFGEEBPAJI(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC77A0", Offset = "0x5EC65A0", VA = "0x185EC77A0")]
	public static bool DNODACOFDOB(INFGEEBPAJI PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD770", Offset = "0x5ECC570", VA = "0x185ECD770", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(INFGEEBPAJI LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0")]
	public static NIOIPIDANEB DNODACOFDOB(INFGEEBPAJI FEKKHCCBLJM)
	{
		return default(NIOIPIDANEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD930", Offset = "0x5ECC730", VA = "0x185ECD930")]
	public bool IOEJMOOHEPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD860", Offset = "0x5ECC660", VA = "0x185ECD860")]
	public bool FLBJMELLADG(BHJEJOPMAHL GPCGJFGFKBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD350", Offset = "0x5ECC150", VA = "0x185ECD350")]
	public void DOJBFLCABAN(BHJEJOPMAHL GPCGJFGFKBG, bool PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5ECDCA0", Offset = "0x5ECCAA0", VA = "0x185ECDCA0")]
	public BPNOBCOILLF LLPGABJEIAC(Allocator DGKNIHLPENE)
	{
		return default(BPNOBCOILLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD4C0", Offset = "0x5ECC2C0", VA = "0x185ECD4C0")]
	public void ENGFKOILENF(INFGEEBPAJI LCIDHBCOPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5ECD0A0", Offset = "0x5ECBEA0", VA = "0x185ECD0A0")]
	[IteratorStateMachine(typeof(IJIKADOFMFN))]
	public IEnumerable<NIOIPIDANEB> CGCJFOPMFPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct FOEBIEKPGKB : IEquatable<FOEBIEKPGKB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAF80", Offset = "0x5EC9D80", VA = "0x185ECAF80", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(FOEBIEKPGKB LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct ELAJHABGFPM : IEquatable<ELAJHABGFPM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private CBDNIAOJPJI ONHPHNMDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7B00", Offset = "0x5EC6900", VA = "0x185EC7B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public ELAJHABGFPM(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9BB0", Offset = "0x5EC89B0", VA = "0x185EC9BB0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(ELAJHABGFPM LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9C40", Offset = "0x5EC8A40", VA = "0x185EC9C40")]
	public void IFMJALEKMOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9CE0", Offset = "0x5EC8AE0", VA = "0x185EC9CE0")]
	public void PILBKDKBGIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct MJPMKCCFJIJ : IEquatable<MJPMKCCFJIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2740", Offset = "0x5ED1540", VA = "0x185ED2740", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(MJPMKCCFJIJ LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct DJGPMCDKGPP : IEquatable<DJGPMCDKGPP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8350", Offset = "0x5EC7150", VA = "0x185EC8350", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(DJGPMCDKGPP LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct HHENMILHHBM : IEquatable<HHENMILHHBM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBBA0", Offset = "0x5ECA9A0", VA = "0x185ECBBA0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(HHENMILHHBM LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct HFKDJPNNCPE : IEquatable<HFKDJPNNCPE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBB10", Offset = "0x5ECA910", VA = "0x185ECBB10", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(HFKDJPNNCPE LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct FHDPJEAPCAP : IEquatable<FHDPJEAPCAP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public ICMPCFCEMJM DMKPCFEDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(ICMPCFCEMJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private CBDNIAOJPJI ONHPHNMDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7B00", Offset = "0x5EC6900", VA = "0x185EC7B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private PKELPAFEAOF HHABHEGDIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x5ECAA20", Offset = "0x5EC9820", VA = "0x185ECAA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private NBFOGOBGPBO IOAMDDDKDLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5ECAE30", Offset = "0x5EC9C30", VA = "0x185ECAE30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public ICMPCFCEMJM MOOCBODBMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5ECAAB0", Offset = "0x5EC98B0", VA = "0x185ECAAB0")]
		get
		{
			return default(ICMPCFCEMJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public NIOIPIDANEB ELFFPEGDBAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5ECAC70", Offset = "0x5EC9A70", VA = "0x185ECAC70")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public NIOIPIDANEB CGOPDPOJACK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x5ECAE90", Offset = "0x5EC9C90", VA = "0x185ECAE90")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public FHDPJEAPCAP(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECABE0", Offset = "0x5EC99E0", VA = "0x185ECABE0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(FHDPJEAPCAP LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAD00", Offset = "0x5EC9B00", VA = "0x185ECAD00")]
	public bool IFKFCKDOJJB(NIOIPIDANEB BMNEKBHDGLJ, bool DOEPOHBJCHA = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAB40", Offset = "0x5EC9940", VA = "0x185ECAB40")]
	public bool ANBCBCCPPNK(NIOIPIDANEB LOMNBAMLPAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5ECA790", Offset = "0x5EC9590", VA = "0x185ECA790")]
	private void AACLLIIECPJ(NIOIPIDANEB PIPCJNBDLEG, List<NIOIPIDANEB> BDHLGGGMBFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5ECAF20", Offset = "0x5EC9D20", VA = "0x185ECAF20")]
	public void LHJIMFACLLH(List<NIOIPIDANEB> CHNEDGDALEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct EIOFGMOIFKP : IEquatable<EIOFGMOIFKP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public string AMLIJCHMEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5EC92E0", Offset = "0x5EC80E0", VA = "0x185EC92E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public string APIEKBLCAHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8C40", Offset = "0x5EC7A40", VA = "0x185EC8C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	private bool POKPFNLNHCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8730", Offset = "0x5EC7530", VA = "0x185EC8730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public string AEPEBDABOBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8870", Offset = "0x5EC7670", VA = "0x185EC8870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public string DBAKLOBHHEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5EC89F0", Offset = "0x5EC77F0", VA = "0x185EC89F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string ANEKCMLBGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8680", Offset = "0x5EC7480", VA = "0x185EC8680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public EIOFGMOIFKP(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8960", Offset = "0x5EC7760", VA = "0x185EC8960", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(EIOFGMOIFKP LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8D10", Offset = "0x5EC7B10", VA = "0x185EC8D10")]
	private static string OMNFLGFHEEA(POLLAGMGKIL HBNLOOLDMNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct AGHKCHNPGKI : IEquatable<AGHKCHNPGKI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6310", Offset = "0x5EC5110", VA = "0x185EC6310", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(AGHKCHNPGKI LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct AKFNBGHHHPJ : IEquatable<AKFNBGHHHPJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public AKFNBGHHHPJ(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6590", Offset = "0x5EC5390", VA = "0x185EC6590", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(AKFNBGHHHPJ LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6620", Offset = "0x5EC5420", VA = "0x185EC6620")]
	public bool MNJIBGEAMAL([Out] Collider OPLJGLOKEDF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct OHNPHJEIDHO : IEquatable<OHNPHJEIDHO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public ICMPCFCEMJM DMKPCFEDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(ICMPCFCEMJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private CBDNIAOJPJI ONHPHNMDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7B00", Offset = "0x5EC6900", VA = "0x185EC7B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private PKELPAFEAOF HHABHEGDIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5500", Offset = "0x5ED4300", VA = "0x185ED5500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private GEOLGCDACDP IPAABFLOLKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6120", Offset = "0x5ED4F20", VA = "0x185ED6120")]
		get
		{
			return default(GEOLGCDACDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool BMGAPEJLIJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5C60", Offset = "0x5ED4A60", VA = "0x185ED5C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool IJICCCFJJBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5B80", Offset = "0x5ED4980", VA = "0x185ED5B80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool LKKHOFLKCBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5F60", Offset = "0x5ED4D60", VA = "0x185ED5F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool EGKBPIDDAND
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6260", Offset = "0x5ED5060", VA = "0x185ED6260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool KOKPDLIIFOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5ED60B0", Offset = "0x5ED4EB0", VA = "0x185ED60B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool AEMNNNFHODB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5FD0", Offset = "0x5ED4DD0", VA = "0x185ED5FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool EEFHGJLCIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5770", Offset = "0x5ED4570", VA = "0x185ED5770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool GHBELEIKFMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5BF0", Offset = "0x5ED49F0", VA = "0x185ED5BF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool LOMKHHGKJKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5ED58B0", Offset = "0x5ED46B0", VA = "0x185ED58B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool KJJIBFCNHAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5ED61F0", Offset = "0x5ED4FF0", VA = "0x185ED61F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool FPCHPPGGJKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5CA0", Offset = "0x5ED4AA0", VA = "0x185ED5CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool AIIMNNNFNPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5EF0", Offset = "0x5ED4CF0", VA = "0x185ED5EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool DKMMGGFLCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5ED62D0", Offset = "0x5ED50D0", VA = "0x185ED62D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool AIODLGAHJBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5690", Offset = "0x5ED4490", VA = "0x185ED5690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool FHPDMFJPNJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6040", Offset = "0x5ED4E40", VA = "0x185ED6040")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5ED6180", Offset = "0x5ED4F80", VA = "0x185ED6180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool ONPNAKBPFKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5920", Offset = "0x5ED4720", VA = "0x185ED5920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public NHBELKMMMFO JJJCECHHFAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5DE0", Offset = "0x5ED4BE0", VA = "0x185ED5DE0")]
		get
		{
			return default(NHBELKMMMFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool HJOPKCIOFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5D10", Offset = "0x5ED4B10", VA = "0x185ED5D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public Vector3 MFJIIDFACKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5ED57E0", Offset = "0x5ED45E0", VA = "0x185ED57E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public Vector3 FPPMGJNEILB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5E40", Offset = "0x5ED4C40", VA = "0x185ED5E40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool FHAEHDEJAIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5ED5590", Offset = "0x5ED4390", VA = "0x185ED5590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public OHNPHJEIDHO(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5ED5AF0", Offset = "0x5ED48F0", VA = "0x185ED5AF0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(OHNPHJEIDHO LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5ED5700", Offset = "0x5ED4500", VA = "0x185ED5700")]
	public bool CEOBDEMJOLP(MEDNKPNOEGC GPCGJFGFKBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5ED5D70", Offset = "0x5ED4B70", VA = "0x185ED5D70")]
	public bool IEHDMHEJJBG(BHOBLHHNKGA GPCGJFGFKBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6340", Offset = "0x5ED5140", VA = "0x185ED6340")]
	public void PNHNAOILFMM(BHOBLHHNKGA GPCGJFGFKBG, bool HKCMOBAFKGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct MCCNOOOACLH : IEquatable<MCCNOOOACLH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public ICMPCFCEMJM DMKPCFEDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(ICMPCFCEMJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	private CBDNIAOJPJI ONHPHNMDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7B00", Offset = "0x5EC6900", VA = "0x185EC7B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private PKELPAFEAOF HHABHEGDIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5ED21B0", Offset = "0x5ED0FB0", VA = "0x185ED21B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public MCCNOOOACLH(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2360", Offset = "0x5ED1160", VA = "0x185ED2360", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(MCCNOOOACLH LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2240", Offset = "0x5ED1040", VA = "0x185ED2240")]
	public void BIDGOMMKFGN(bool PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x5ED22D0", Offset = "0x5ED10D0", VA = "0x185ED22D0")]
	public void BMOKMLOOGGF(bool PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x2577C10", Offset = "0x2576A10", VA = "0x182577C10")]
	public T IBMIGJBMGFM<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct IODNFCGIJHP : IEquatable<IODNFCGIJHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public ICMPCFCEMJM DMKPCFEDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(ICMPCFCEMJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private CBDNIAOJPJI ONHPHNMDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7B00", Offset = "0x5EC6900", VA = "0x185EC7B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	private PKELPAFEAOF HHABHEGDIGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE1E0", Offset = "0x5ECCFE0", VA = "0x185ECE1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	private HJFPGHLFPJN CDECNLANOHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE9E0", Offset = "0x5ECD7E0", VA = "0x185ECE9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	private CCBLBJONCKG BKPCLAHIIEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEC80", Offset = "0x5ECDA80", VA = "0x185ECEC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool LIGCEDCLKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE580", Offset = "0x5ECD380", VA = "0x185ECE580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool BMHPOBDDNKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE780", Offset = "0x5ECD580", VA = "0x185ECE780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool HNEHABHAFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEE00", Offset = "0x5ECDC00", VA = "0x185ECEE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool LJFIIPBMAAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE270", Offset = "0x5ECD070", VA = "0x185ECE270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool PANDPLFPGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEA40", Offset = "0x5ECD840", VA = "0x185ECEA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool OADGCAMEAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE450", Offset = "0x5ECD250", VA = "0x185ECE450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool PDKDFODLOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5ECEA70", Offset = "0x5ECD870", VA = "0x185ECEA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool EHJJELOPGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE610", Offset = "0x5ECD410", VA = "0x185ECE610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public IODNFCGIJHP(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5EC77A0", Offset = "0x5EC65A0", VA = "0x185EC77A0")]
	public static bool DNODACOFDOB(IODNFCGIJHP PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE820", Offset = "0x5ECD620", VA = "0x185ECE820", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(IODNFCGIJHP LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5ECECE0", Offset = "0x5ECDAE0", VA = "0x185ECECE0")]
	public bool LBJMEENBNCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE4E0", Offset = "0x5ECD2E0", VA = "0x185ECE4E0")]
	public NIOIPIDANEB CJDNPAEIBGK(NIOIPIDANEB PODCKBKAANA)
	{
		return default(NIOIPIDANEB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE340", Offset = "0x5ECD140", VA = "0x185ECE340")]
	public ICMPCFCEMJM BKDMKLGMFBL()
	{
		return default(ICMPCFCEMJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE8B0", Offset = "0x5ECD6B0", VA = "0x185ECE8B0")]
	public void GKGFPDPGJPI(ICMPCFCEMJM PODCKBKAANA, ICMPCFCEMJM BGPBFNEFDCK, ICMPCFCEMJM GLJAEALHCKI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct EKPPIEJGELG : IEquatable<EKPPIEJGELG>
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly EKPPIEJGELG LADPMFENNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public ICMPCFCEMJM DMKPCFEDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(ICMPCFCEMJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public JLJIBPEMPFO EHAGGAFELKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(JLJIBPEMPFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	private LEEBDOHLOMC EAAJKABHOIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9790", Offset = "0x5EC8590", VA = "0x185EC9790")]
		get
		{
			return default(LEEBDOHLOMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public IKECNMDGAGK DMKGKDBIFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x5EC99F0", Offset = "0x5EC87F0", VA = "0x185EC99F0")]
		get
		{
			return default(IKECNMDGAGK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public ONAHHCADDNJ JBKAHFEFBMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9990", Offset = "0x5EC8790", VA = "0x185EC9990")]
		get
		{
			return default(ONAHHCADDNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public PGLLIKFCNDF FLOGHOFJGHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x5EC94C0", Offset = "0x5EC82C0", VA = "0x185EC94C0")]
		get
		{
			return default(PGLLIKFCNDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public FICHLEILIGP LAGIICIDFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9AD0", Offset = "0x5EC88D0", VA = "0x185EC9AD0")]
		get
		{
			return default(FICHLEILIGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public PPHADPBLFFA PLFNHDOOCAE
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9930", Offset = "0x5EC8730", VA = "0x185EC9930")]
		get
		{
			return default(PPHADPBLFFA);
		}
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9360", Offset = "0x5EC8160", VA = "0x185EC9360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public GJNEHLGHKPA MEMOPEABICF
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9850", Offset = "0x5EC8650", VA = "0x185EC9850")]
		get
		{
			return default(GJNEHLGHKPA);
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9B40", Offset = "0x5EC8940", VA = "0x185EC9B40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public float KBLPBJDGOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC97F0", Offset = "0x5EC85F0", VA = "0x185EC97F0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC93D0", Offset = "0x5EC81D0", VA = "0x185EC93D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public Vector3 DJNHEOEGKKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9630", Offset = "0x5EC8430", VA = "0x185EC9630")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9A50", Offset = "0x5EC8850", VA = "0x185EC9A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public float EINIBFAMOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5EC96B0", Offset = "0x5EC84B0", VA = "0x185EC96B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public FPJPOCMCOOL.DMNKHALEADM NLCOEJEHAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9460", Offset = "0x5EC8260", VA = "0x185EC9460")]
		get
		{
			return default(FPJPOCMCOOL.DMNKHALEADM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5EC9720", Offset = "0x5EC8520", VA = "0x185EC9720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public EKPPIEJGELG(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC77A0", Offset = "0x5EC65A0", VA = "0x185EC77A0")]
	public static bool DNODACOFDOB(EKPPIEJGELG PHPDIJICBJO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9440", Offset = "0x5EC8240", VA = "0x185EC9440")]
	public static bool CAOAIKCPFJO(EKPPIEJGELG ALNGIEPPLJJ, EKPPIEJGELG DCODMCLNKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC95A0", Offset = "0x5EC83A0", VA = "0x185EC95A0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(EKPPIEJGELG LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5EC98B0", Offset = "0x5EC86B0", VA = "0x185EC98B0")]
	public CAOAHJPHBDG LOMMFNMPHPP()
	{
		return default(CAOAHJPHBDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5EC9520", Offset = "0x5EC8320", VA = "0x185EC9520")]
	public OHCIMPNNGNA EIHJCOGBBBM()
	{
		return default(OHCIMPNNGNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct CAOAHJPHBDG : IEquatable<CAOAHJPHBDG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public ICMPCFCEMJM DMKPCFEDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(ICMPCFCEMJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public EKPPIEJGELG NOJOKINHPJH
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(EKPPIEJGELG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private IMCEEEAJIAP AMIGANKOGMC
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7850", Offset = "0x5EC6650", VA = "0x185EC7850")]
		get
		{
			return default(IMCEEEAJIAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public DCKPNNMCENH FIPGGABOGJP
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7740", Offset = "0x5EC6540", VA = "0x185EC7740")]
		get
		{
			return default(DCKPNNMCENH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public CAOAHJPHBDG(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5EC77A0", Offset = "0x5EC65A0", VA = "0x185EC77A0")]
	public static bool DNODACOFDOB(CAOAHJPHBDG PHPDIJICBJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5EC77C0", Offset = "0x5EC65C0", VA = "0x185EC77C0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(CAOAHJPHBDG LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public readonly struct OHCIMPNNGNA : IEquatable<OHCIMPNNGNA>
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly OHCIMPNNGNA LADPMFENNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public ICMPCFCEMJM DMKPCFEDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(ICMPCFCEMJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public JLJIBPEMPFO EHAGGAFELKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(JLJIBPEMPFO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private CBDNIAOJPJI ONHPHNMDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7B00", Offset = "0x5EC6900", VA = "0x185EC7B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private PKELPAFEAOF HHABHEGDIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4810", Offset = "0x5ED3610", VA = "0x185ED4810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	private HIOKBDCCCHJ KDHNMMNIJAH
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED50B0", Offset = "0x5ED3EB0", VA = "0x185ED50B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public EKPPIEJGELG NOJOKINHPJH
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(EKPPIEJGELG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public OKEDGBDEDCB BLPDNOPLDBA
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED51A0", Offset = "0x5ED3FA0", VA = "0x185ED51A0")]
		get
		{
			return default(OKEDGBDEDCB);
		}
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED52D0", Offset = "0x5ED40D0", VA = "0x185ED52D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public IEnumerable<ANONAOHFHDC> MHPBJELKDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5ED4A40", Offset = "0x5ED3840", VA = "0x185ED4A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public ANONAOHFHDC LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5ED53F0", Offset = "0x5ED41F0", VA = "0x185ED53F0")]
		get
		{
			return default(ANONAOHFHDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5ED48A0", Offset = "0x5ED36A0", VA = "0x185ED48A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public OHCIMPNNGNA(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x5EC77A0", Offset = "0x5EC65A0", VA = "0x185EC77A0")]
	public static bool DNODACOFDOB(OHCIMPNNGNA PHPDIJICBJO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x5ED3D10", Offset = "0x5ED2B10", VA = "0x185ED3D10")]
	public static bool HIHGGPGGFPN(OHCIMPNNGNA ALNGIEPPLJJ, OHCIMPNNGNA DCODMCLNKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4BD0", Offset = "0x5ED39D0", VA = "0x185ED4BD0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(OHCIMPNNGNA LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4E90", Offset = "0x5ED3C90", VA = "0x185ED4E90")]
	public ANONAOHFHDC JDKMACKLFHN(float3? LMGPBOPOFGA, [Optional] quaternion? BPBCJFMFECG, [Optional] Vector3? OINLNNPPPEB)
	{
		return default(ANONAOHFHDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4C60", Offset = "0x5ED3A60", VA = "0x185ED4C60")]
	public ANONAOHFHDC IIEGJBPLMJK(int NGIPPLLBEKC, float3? LMGPBOPOFGA, [Optional] quaternion? BPBCJFMFECG, [Optional] Vector3? OINLNNPPPEB)
	{
		return default(ANONAOHFHDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x5ED4930", Offset = "0x5ED3730", VA = "0x185ED4930")]
	public void DHGGGNDMMCI(int NGIPPLLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x5ED5110", Offset = "0x5ED3F10", VA = "0x185ED5110")]
	public void LPNBJONBLDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct ANONAOHFHDC : IEquatable<ANONAOHFHDC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public ICMPCFCEMJM DMKPCFEDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(ICMPCFCEMJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public OHCIMPNNGNA JJEAPGHCCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5EC67F0", Offset = "0x5EC55F0", VA = "0x185EC67F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public float3 BEDPIAEOKCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6CF0", Offset = "0x5EC5AF0", VA = "0x185EC6CF0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6AE0", Offset = "0x5EC58E0", VA = "0x185EC6AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public quaternion FGBNJMGCCIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6D70", Offset = "0x5EC5B70", VA = "0x185EC6D70")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6B60", Offset = "0x5EC5960", VA = "0x185EC6B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public float3 MMKIDHDBEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6A60", Offset = "0x5EC5860", VA = "0x185EC6A60")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x5EC69E0", Offset = "0x5EC57E0", VA = "0x185EC69E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public NBINOAPKAEH EEHHDGOIIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6880", Offset = "0x5EC5680", VA = "0x185EC6880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	private CHGCNBJEOEI AKADKANHOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6980", Offset = "0x5EC5780", VA = "0x185EC6980")]
		get
		{
			return default(CHGCNBJEOEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	private OOCADHJEFIM MJJHDPAMJAM
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6C90", Offset = "0x5EC5A90", VA = "0x185EC6C90")]
		get
		{
			return default(OOCADHJEFIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	private FNLKECPEOFM CEEAGAHBGPH
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6BD0", Offset = "0x5EC59D0", VA = "0x185EC6BD0")]
		get
		{
			return default(FNLKECPEOFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private LNHKAFCLNNH AINAPNONHNN
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6790", Offset = "0x5EC5590", VA = "0x185EC6790")]
		get
		{
			return default(LNHKAFCLNNH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private FIPOEFMEDFJ CKCKGKKECGM
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6C30", Offset = "0x5EC5A30", VA = "0x185EC6C30")]
		get
		{
			return default(FIPOEFMEDFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public ANONAOHFHDC(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC68F0", Offset = "0x5EC56F0", VA = "0x185EC68F0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(ANONAOHFHDC LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x5EC67F0", Offset = "0x5EC55F0", VA = "0x185EC67F0")]
	public void DMLCOAELANK(OHCIMPNNGNA PHPDIJICBJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct JLJIBPEMPFO : IEquatable<JLJIBPEMPFO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public FHDPJEAPCAP HDOCJJOIAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(FHDPJEAPCAP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	private CBDNIAOJPJI ONHPHNMDDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7B00", Offset = "0x5EC6900", VA = "0x185EC7B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	private AOGKDDGDLGP FLJAPMBDBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0E80", Offset = "0x5ECFC80", VA = "0x185ED0E80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool CKBFPJOFAMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF630", Offset = "0x5ECE430", VA = "0x185ECF630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 BEDPIAEOKCN
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0B50", Offset = "0x5ECF950", VA = "0x185ED0B50")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5ED03C0", Offset = "0x5ECF1C0", VA = "0x185ED03C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Quaternion FGBNJMGCCIG
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x5ED0C40", Offset = "0x5ECFA40", VA = "0x185ED0C40")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED06D0", Offset = "0x5ECF4D0", VA = "0x185ED06D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public Vector3 LEDDGOIJNHP
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1030", Offset = "0x5ECFE30", VA = "0x185ED1030")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5ED02F0", Offset = "0x5ECF0F0", VA = "0x185ED02F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Quaternion OMBICKMAMDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x5ED01A0", Offset = "0x5ECEFA0", VA = "0x185ED01A0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF190", Offset = "0x5ECDF90", VA = "0x185ECF190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float MHBNHKHGICB
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF0F0", Offset = "0x5ECDEF0", VA = "0x185ECF0F0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5ED07A0", Offset = "0x5ECF5A0", VA = "0x185ED07A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float FBKAFJDIFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF260", Offset = "0x5ECE060", VA = "0x185ECF260")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Vector3 MMKIDHDBEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x5ED00B0", Offset = "0x5ECEEB0", VA = "0x185ED00B0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF8C0", Offset = "0x5ECE6C0", VA = "0x185ECF8C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public Vector3 IBFKFLKLNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x5ED1120", Offset = "0x5ECFF20", VA = "0x185ED1120")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public Matrix4x4 KPMLLJBOGPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x5ECF3D0", Offset = "0x5ECE1D0", VA = "0x185ECF3D0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public JLJIBPEMPFO(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF6C0", Offset = "0x5ECE4C0", VA = "0x185ECF6C0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(JLJIBPEMPFO LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF670", Offset = "0x5ECE470", VA = "0x185ECF670")]
	public JPIMMKIMANG EOIJPNOIHOB()
	{
		return default(JPIMMKIMANG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEFD0", Offset = "0x5ECDDD0", VA = "0x185ECEFD0")]
	public void BMPLHLHNDCE([Out] Matrix4x4 JNOKJGIKDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0850", Offset = "0x5ECF650", VA = "0x185ED0850")]
	public void NEIDKGOFOGF([Out] Vector3 IGONAHOIHDO, [Out] Quaternion JNNHGJJOADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF4E0", Offset = "0x5ECE2E0", VA = "0x185ECF4E0")]
	public void CNOGOLCGOOO([Out] RigidTransform PPJHLPMGHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0F40", Offset = "0x5ECFD40", VA = "0x185ED0F40")]
	public FCGNMDMHCJG PGCEIBGFLNA()
	{
		return default(FCGNMDMHCJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0F70", Offset = "0x5ECFD70", VA = "0x185ED0F70")]
	public void PGCEIBGFLNA([Out] FCGNMDMHCJG CFCAADHPKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0B20", Offset = "0x5ECF920", VA = "0x185ED0B20")]
	public FCGNMDMHCJG NNPHHAPIBOH()
	{
		return default(FCGNMDMHCJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0A60", Offset = "0x5ECF860", VA = "0x185ED0A60")]
	public void NNPHHAPIBOH([Out] FCGNMDMHCJG PPJHLPMGHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFFC0", Offset = "0x5ECEDC0", VA = "0x185ECFFC0")]
	public Vector3 JOIPHJOCPCH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0990", Offset = "0x5ECF790", VA = "0x185ED0990")]
	public void NEIODKDNKEF([In] Vector3 PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEE30", Offset = "0x5ECDC30", VA = "0x185ECEE30")]
	public Vector3 AKALIAIBKCO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFA60", Offset = "0x5ECE860", VA = "0x185ECFA60")]
	public void HMFAMIDNCAN([In] Vector3 PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0580", Offset = "0x5ECF380", VA = "0x185ED0580")]
	public Quaternion MJLLFNNJPBL()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF990", Offset = "0x5ECE790", VA = "0x185ECF990")]
	public void HLHPOEMONOG([In] Quaternion PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFE70", Offset = "0x5ECEC70", VA = "0x185ECFE70")]
	public Quaternion JOCGPMDLJNE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF300", Offset = "0x5ECE100", VA = "0x185ECF300")]
	public void CKPCPMLPOOJ([In] Quaternion PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF820", Offset = "0x5ECE620", VA = "0x185ECF820")]
	public float HAHCLAAKKII()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x5ECEF20", Offset = "0x5ECDD20", VA = "0x185ECEF20")]
	public void BJEEKHLCDFN(float PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF590", Offset = "0x5ECE390", VA = "0x185ECF590")]
	public float DOMCLEMDGKH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFB30", Offset = "0x5ECE930", VA = "0x185ECFB30")]
	public void HMGHPOOODNN(float PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFCB0", Offset = "0x5ECEAB0", VA = "0x185ECFCB0")]
	public void IJGAKNOKIGI([In] Vector3 PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0D90", Offset = "0x5ECFB90", VA = "0x185ED0D90")]
	public Vector3 OHMEINPOBMD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFBE0", Offset = "0x5ECE9E0", VA = "0x185ECFBE0")]
	public void HPNLNNLGMJA([In] Vector3 PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x5ECFD80", Offset = "0x5ECEB80", VA = "0x185ECFD80")]
	public Vector3 JAGKDBFFDJH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF750", Offset = "0x5ECE550", VA = "0x185ECF750")]
	public void GALCJFOCOJJ([In] Vector3 PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x5ED0490", Offset = "0x5ECF290", VA = "0x185ED0490")]
	public Vector3 MEENHMDJENH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5ECF410", Offset = "0x5ECE210", VA = "0x185ECF410")]
	public void CMEMBGDAJBL([In] Vector3 PHPDIJICBJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct BPKAHJJAJAK : IEquatable<BPKAHJJAJAK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly ICMPCFCEMJM EMALEGKCAJH;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public ICMPCFCEMJM DMKPCFEDEAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(ICMPCFCEMJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public NIOIPIDANEB JHCPJMDHLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7DA900", Offset = "0x7D9700", VA = "0x1807DA900")]
		get
		{
			return default(NIOIPIDANEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public int[] DGDJMNDDFPA
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6FD0", Offset = "0x5EC5DD0", VA = "0x185EC6FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x16CF560", Offset = "0x16CE360", VA = "0x1816CF560")]
	public BPKAHJJAJAK(ICMPCFCEMJM APAPEJEHLCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63B0", Offset = "0x5EC51B0", VA = "0x185EC63B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6F40", Offset = "0x5EC5D40", VA = "0x185EC6F40", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63A0", Offset = "0x5EC51A0", VA = "0x185EC63A0", Slot = "4")]
	public bool Equals(BPKAHJJAJAK LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x5EC63E0", Offset = "0x5EC51E0", VA = "0x185EC63E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class KBKINCINHCL
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct DHEBHLOGDIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Guid CHLMGBPAGHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public NDALEMDLHNK ALNLNDJKJEI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct NDALEMDLHNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int PHPDIJICBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int DKIDPHEDLGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int FJBOMLDGEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int DIENKEMHMOC;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x5ED3840", Offset = "0x5ED2640", VA = "0x185ED3840")]
		public bool APMGHNNDFFA([Out] EABFOFIEHMJ MDOHEAFMDAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x5ED38C0", Offset = "0x5ED26C0", VA = "0x185ED38C0")]
		public NDALEMDLHNK(EABFOFIEHMJ MDOHEAFMDAC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1290", Offset = "0x5ED0090", VA = "0x185ED1290")]
	public static Guid LDLCKAGDNJB(this EABFOFIEHMJ MDOHEAFMDAC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1270", Offset = "0x5ED0070", VA = "0x185ED1270")]
	public static bool GDHMHCFIDHH(this Guid CHLMGBPAGHG, [Out] EABFOFIEHMJ MDOHEAFMDAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class MGDMLAJFAEM
{
	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5ED23F0", Offset = "0x5ED11F0", VA = "0x185ED23F0")]
	public static PKELPAFEAOF HHABHEGDIGL(this ICMPCFCEMJM JPODHBJFPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2480", Offset = "0x5ED1280", VA = "0x185ED2480")]
	public static LBEDLKIHHGM MIKINHLNGFF(this ICMPCFCEMJM JPODHBJFPKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5ED2550", Offset = "0x5ED1350", VA = "0x185ED2550")]
	public static EntityManager NEGBPICGGKC(this ICMPCFCEMJM JPODHBJFPKM)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x257E010", Offset = "0x257CE10", VA = "0x18257E010")]
	public static T KIOKCEMFMIA<T>(this ICMPCFCEMJM JPODHBJFPKM) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x257DD50", Offset = "0x257CB50", VA = "0x18257DD50")]
	public static bool HKLPLCJGJNJ<T>(this ICMPCFCEMJM JPODHBJFPKM) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x257EEB0", Offset = "0x257DCB0", VA = "0x18257EEB0")]
	public static bool MLEPKBFDNAN<T>(this ICMPCFCEMJM JPODHBJFPKM) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface GKJFKJIDMHC
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ABNLCNGDMOL(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ICGDPBIHPFN(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JEGBFIEBBMK(ICMPCFCEMJM APAPEJEHLCD, [Out] Guid MOFFGNIDNJM);

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid PMCCHFBPGAK(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HKDIHHENDFN(ICMPCFCEMJM APAPEJEHLCD, Guid MOFFGNIDNJM);

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CMIMHJEJCPJ(ICMPCFCEMJM APAPEJEHLCD, [Out] Guid CNNNLFIFOJC);

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid OPMKMHKMOIB(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GHBAGIJIMFA(ICMPCFCEMJM APAPEJEHLCD, Guid CNNNLFIFOJC);

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CLLJHBIANGD(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IAAOAFMMMMM(ICMPCFCEMJM COBMMEELOCB, ICMPCFCEMJM BMNEKBHDGLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface NCHIENBNNGI
{
	[Cpp2IlInjected.Token(Token = "0x17000118")]
	Guid BPLKIPHLLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JDGJNHBMKFM(Guid MOFFGNIDNJM, Guid CNNNLFIFOJC, string NDLLBBKGIJD);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface IJKJEOFEOAI
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	IReadOnlyCollection<DIKIFGCIEMG> HOCNMENCMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IPDELIGNIMI(int LOEGAOKGNFD, [Out] DIKIFGCIEMG JPNJGPDCOMG);

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DIKIFGCIEMG ILFNNLIIDMH(Type AOPDMLJGEMB);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class MKCELHMOAOO
{
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x2580820", Offset = "0x257F620", VA = "0x182580820")]
	public static T GEKJNFELLBC<T>(this IJKJEOFEOAI GPDCONCMEMK, Entity OEEKGABNFEP) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x25808C0", Offset = "0x257F6C0", VA = "0x1825808C0")]
	public static DIKIFGCIEMG ILFNNLIIDMH<T>(this IJKJEOFEOAI GPDCONCMEMK) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface HEBCALEGIKP
{
	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EABFOFIEHMJ[] DDJEJJAJIJO(string NDLLBBKGIJD, NIOIPIDANEB MIPDGJHFDLL, bool FLPAJBLGEPO = false);

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OELOBNKAMKB(string PHPPAMIKEEH, EABFOFIEHMJ[] JHALHPHCAKG);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface MNGIPEMAAHD
{
	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<ICMPCFCEMJM, ICMPCFCEMJM> INMFJLONGNA;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<ICMPCFCEMJM, ICMPCFCEMJM> INLLDLMPDHN;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<ICMPCFCEMJM, ICMPCFCEMJM, ICMPCFCEMJM> IAKIJPKKGIN;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<ICMPCFCEMJM> JAEANKLIILC;

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CIALKMNAOBN(ICMPCFCEMJM APAPEJEHLCD, ICMPCFCEMJM MDNADACNBIH);

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ICMPCFCEMJM EDFJABGIIDN(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<ICMPCFCEMJM> FHDLHEPMEHC(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ICMPCFCEMJM OEHDDINMMDG(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GCKEIPPNIIC(ICMPCFCEMJM APAPEJEHLCD, Vector3 ALFMPPAIDMI, Quaternion KLOEJMMJFGO);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void HEIAIOMMPOB(ICMPCFCEMJM APAPEJEHLCD, float FHDPCEHPCDA);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool LGLOFPAFEPD(ICMPCFCEMJM APAPEJEHLCD, [Out] RigidTransform CIHFPBLOKEK);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool DFKLPCGJAAH(ICMPCFCEMJM APAPEJEHLCD, [Out] float MEGGOHHKMDH);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 CKLOGHIFGGO(CDPAGEHKKED GBGECLNJJKC);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion DDHPIHDCGIG(CDPAGEHKKED GBGECLNJJKC);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class FHGHPKMJFAN
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface FOJBDEMHELA
{
	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	object JDCGEBDENGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIHHFAGLFKL(BPNOBCOILLF ILEEGIHBOBP);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum EAAPPMODDCP
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class JINNCINALPF
{
	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0xAFA1F0", Offset = "0xAF8FF0", VA = "0x180AFA1F0")]
	public static bool DAPBJNEBDAN(this EAAPPMODDCP BHDPLHMNJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xAFA200", Offset = "0xAF9000", VA = "0x180AFA200")]
	public static bool GPMEIAFJCJL(this EAAPPMODDCP BHDPLHMNJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x20737A0", Offset = "0x20725A0", VA = "0x1820737A0")]
	public static bool FAFCNEKPJFG(this EAAPPMODDCP BHDPLHMNJLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum GOGCJBDIAOP
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
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class IDJLOALBKIK
{
	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xD518E0", Offset = "0xD506E0", VA = "0x180D518E0")]
	public static int ODJEFLHODPD(this GOGCJBDIAOP PHPDIJICBJO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface IEGGHFHKGHK
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface LEFOGCJEKPJ
{
	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	EAAPPMODDCP JEJOOLNCHFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	EAAPPMODDCP HMNLDFKBFMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	EAAPPMODDCP FOIBINFCENC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	EAAPPMODDCP KLIGLKFNLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	EAAPPMODDCP MGHGCIFILJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	EAAPPMODDCP PHKMEMEBADA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	EAAPPMODDCP LJEBFPEAGFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	EAAPPMODDCP GBCNMAHMJLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	EAAPPMODDCP CCFBJDLALGG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	EAAPPMODDCP DDLOMJHDNPL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	EAAPPMODDCP CLKKIDFOBMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	EAAPPMODDCP NBANLHBJFLL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	EAAPPMODDCP LLGDIINDLBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface NBFOGOBGPBO
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<HAOHLIHBEBG> PNILMGEOCNG;

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ICMPCFCEMJM DPPGCKCMPFA(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ALCMHPFEJPF(List<ICMPCFCEMJM> PKJDMDOEEGO);

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ICMPCFCEMJM DOGIJGBLGNI(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IFKFCKDOJJB(ICMPCFCEMJM APAPEJEHLCD, ICMPCFCEMJM BMNEKBHDGLJ, bool DOEPOHBJCHA);

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GIBIPAJFFBK(ICMPCFCEMJM APAPEJEHLCD, ICMPCFCEMJM BMNEKBHDGLJ);

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int MALEIGKNLHB(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	BPNOBCOILLF CKMKGLJPLME(ICMPCFCEMJM EMALEGKCAJH);

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<ICMPCFCEMJM> AJKEDBNJJMM(ICMPCFCEMJM EMALEGKCAJH);

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool EIHDGKKIFKL(ICMPCFCEMJM APAPEJEHLCD, ICMPCFCEMJM ABHAKMHMKPE);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ANBCBCCPPNK(ICMPCFCEMJM APAPEJEHLCD, ICMPCFCEMJM LOMNBAMLPAF);

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	ICMPCFCEMJM JHKLHKJHOAH(ICMPCFCEMJM PODCKBKAANA, ICMPCFCEMJM DOGICNIPKEH);

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool HOPEJEMHCDH(ICMPCFCEMJM PODCKBKAANA, ICMPCFCEMJM DOGICNIPKEH, [Out] ICMPCFCEMJM FENOEGKBEBK);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class DFCLBOMABCM
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5EC81D0", Offset = "0x5EC6FD0", VA = "0x185EC81D0")]
	public static List<ICMPCFCEMJM> ALCMHPFEJPF(this NBFOGOBGPBO CDCNCPAONNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x5EC82E0", Offset = "0x5EC70E0", VA = "0x185EC82E0")]
	public static bool JFHDEHHGHLL(this NBFOGOBGPBO CDCNCPAONNN, ICMPCFCEMJM APAPEJEHLCD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface DLPHJNEGDDF
{
	[Cpp2IlInjected.Token(Token = "0x17000128")]
	bool KGEBEPECHGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	bool KFDINOHLCOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface HKFEMBBJHMP : PMIPLJIHOJP
{
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EOMLPENNOPK(Entity OEEKGABNFEP, [Out] GMAPPKKAOPD JEGLLFDAPLN);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJPBCJIJJPC(NativeArray<GMAPPKKAOPD> AAENGGHIELB, NativeArray<LJHFPCKKDJB> NONIACDAIJD);

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void INKCDHKKBGM(GMAPPKKAOPD JEGLLFDAPLN);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CKNJGNGLCFA(GMAPPKKAOPD JEGLLFDAPLN, [Out] Collider OPLJGLOKEDF);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface PMIPLJIHOJP
{
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGENPOBEGDL([In] float3 CEBNDLLNOFI, [In] float3 NJLPJDHGIMB, float PABLLIHNBKD, Allocator DGKNIHLPENE, [Out] NativeArray<Entity> DGGFIPBLDCO);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface EHIMPLCPNJB
{
	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGENPOBEGDL([In] float3 CEBNDLLNOFI, [In] float3 NJLPJDHGIMB, float PABLLIHNBKD, [Out] HJBJCEFMDKC KHKPGJPGCJK, [Out] ICMPCFCEMJM MDBEDLJAMNE);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface LOHGCGIOAMD
{
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGENPOBEGDL([In] NativeArray<Entity> DGGFIPBLDCO, [In] float3 CEBNDLLNOFI, [In] float3 NJLPJDHGIMB, [In] NativeArray<HJBJCEFMDKC> HELIEHMOOCF);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct GMAPPKKAOPD : EACNBBAKFGC, IEquatable<GMAPPKKAOPD>
{
	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public int FNPAHLCJLFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x832500", Offset = "0x831300", VA = "0x180832500", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8324C0", Offset = "0x8312C0", VA = "0x1808324C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public int AJIPJCGCHJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x208FBA0", Offset = "0x208E9A0", VA = "0x18208FBA0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x52E5350", Offset = "0x52E4150", VA = "0x1852E5350", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB780", Offset = "0x5ECA580", VA = "0x185ECB780", Slot = "8")]
	public bool Equals(GMAPPKKAOPD LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB7D0", Offset = "0x5ECA5D0", VA = "0x185ECB7D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct HJBJCEFMDKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float GBKICGAEGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 PPEOGMAIJEH;
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface GMACIDALAOF
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface CBDNIAOJPJI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	PKELPAFEAOF HHABHEGDIGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	MNADOFCIMAE IMCEBJAJKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<BPNOBCOILLF, NativeArray<POLLAGMGKIL>> AFAAJBMJLND;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<BPNOBCOILLF> GNJMFBHEHPD;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KHGCHFOOBOE KKOJFONDHEC(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "7")]
	POLLAGMGKIL NGDENABCBLP(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EEHFKNGNNHO(EABFOFIEHMJ MDOHEAFMDAC, KMKIDLKFNMD PLHJDKMHELE);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AEILJMKNBPA(EABFOFIEHMJ[] JHALHPHCAKG, GameObject CJHJDJNKIGF);

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NIOIPIDANEB GHENEIFAEAI(ICMPCFCEMJM APAPEJEHLCD, [Optional] object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MHLMMCMBJJA(ICMPCFCEMJM APAPEJEHLCD, [Out] KMKIDLKFNMD PLHJDKMHELE);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool DNLBNHGHMIE(ICMPCFCEMJM APAPEJEHLCD, [Out] Transform AGLGKAHAKII);

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool LMAMNNDPCGP(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void GOEPBJJBAFE(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool BKLIKKBBENM(LocalId APAPEJEHLCD, object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool NHGFHLIJNMG(LocalId APAPEJEHLCD, object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	ICMPCFCEMJM AOKBNIMNKCE(EABFOFIEHMJ MDOHEAFMDAC);

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool AAKECFCAMIA(EABFOFIEHMJ MDOHEAFMDAC, [Out] ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	EABFOFIEHMJ DNHGNGMJIHO(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "20")]
	BPNOBCOILLF AOKBNIMNKCE(NativeArray<EABFOFIEHMJ> MDOHEAFMDAC, Allocator DGKNIHLPENE);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "21")]
	BPNOBCOILLF GGONKAPLKKF(NativeArray<EABFOFIEHMJ> MDOHEAFMDAC, NativeArray<OOPDIEJAFFC> CAKHPPJDHJI, Allocator DGKNIHLPENE);

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "22")]
	EABFOFIEHMJ[] DDJEJJAJIJO(string PHPPAMIKEEH, NIOIPIDANEB MIPDGJHFDLL, bool FLPAJBLGEPO);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void OELOBNKAMKB(string PHPPAMIKEEH, EABFOFIEHMJ[] JHALHPHCAKG);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "24")]
	NIOIPIDANEB GIEGNOOLKDK(POLLAGMGKIL HPJEHGNFPGN, bool JJINPGEBJFC);

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "25")]
	NIOIPIDANEB GIEGNOOLKDK(POLLAGMGKIL HPJEHGNFPGN);

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(Slot = "26")]
	NIOIPIDANEB HMCJOGOKCCJ(POLLAGMGKIL HPJEHGNFPGN);

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(Slot = "27")]
	NIOIPIDANEB KJCOBBHFONG(POLLAGMGKIL HPJEHGNFPGN);

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(Slot = "28")]
	NIOIPIDANEB GGONKAPLKKF(EABFOFIEHMJ MDOHEAFMDAC, POLLAGMGKIL HPJEHGNFPGN);

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(Slot = "29")]
	INFGEEBPAJI NBFMCFMBHFE();

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	OHCIMPNNGNA LAAMJOILEGM();

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	CAOAHJPHBDG IMHGCOAAJCO(DCKPNNMCENH KHEPHHLDMOB);

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void PILBKDKBGIN(BPNOBCOILLF ILEEGIHBOBP);

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void IFMJALEKMOK(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void NFOKLKLPCHJ(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void PILBKDKBGIN(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "36")]
	BPNOBCOILLF LMJGJOHPKFG(BPNOBCOILLF BMNLIMMIKEB, Allocator DGKNIHLPENE);

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool ELLDGLBOGGN(ICMPCFCEMJM APAPEJEHLCD);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class PNHFFHPCOFP
{
	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6A80", Offset = "0x5ED5880", VA = "0x185ED6A80")]
	public static void GOEPBJJBAFE(this CBDNIAOJPJI AFFLCFIGDNF, KMKIDLKFNMD PLHJDKMHELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6700", Offset = "0x5ED5500", VA = "0x185ED6700")]
	public static NIOIPIDANEB GAFBGLLALCH(this CBDNIAOJPJI AFFLCFIGDNF, LocalId APAPEJEHLCD)
	{
		return default(NIOIPIDANEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6700", Offset = "0x5ED5500", VA = "0x185ED6700")]
	public static ICMPCFCEMJM AOKBNIMNKCE(this CBDNIAOJPJI AFFLCFIGDNF, LocalId APAPEJEHLCD)
	{
		return default(ICMPCFCEMJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6830", Offset = "0x5ED5630", VA = "0x185ED6830")]
	public static EABFOFIEHMJ DNHGNGMJIHO(this CBDNIAOJPJI AFFLCFIGDNF, LocalId APAPEJEHLCD)
	{
		return default(EABFOFIEHMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x5ED69B0", Offset = "0x5ED57B0", VA = "0x185ED69B0")]
	public static bool ELLDGLBOGGN(this CBDNIAOJPJI AFFLCFIGDNF, EABFOFIEHMJ MDOHEAFMDAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x264B080", Offset = "0x2649E80", VA = "0x18264B080")]
	public static T BBNLMJLCFBH<T>(this CBDNIAOJPJI AFFLCFIGDNF, LocalId APAPEJEHLCD) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6730", Offset = "0x5ED5530", VA = "0x185ED6730")]
	public static INFGEEBPAJI CEKBGGNGECE(this CBDNIAOJPJI AFFLCFIGDNF, RigidTransform CFCAADHPKDN, [Optional] object HOBAPMCPFML)
	{
		return default(INFGEEBPAJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6B00", Offset = "0x5ED5900", VA = "0x185ED6B00")]
	public static CAOAHJPHBDG NFFGOEOJHDI(this CBDNIAOJPJI AFFLCFIGDNF, DCKPNNMCENH GODBFHKFKFN, RigidTransform CFCAADHPKDN, [Optional] object HOBAPMCPFML)
	{
		return default(CAOAHJPHBDG);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED68B0", Offset = "0x5ED56B0", VA = "0x185ED68B0")]
	public static OHCIMPNNGNA EKKHAKMKKOG(this CBDNIAOJPJI AFFLCFIGDNF, RigidTransform CFCAADHPKDN, [Optional] object HOBAPMCPFML)
	{
		return default(OHCIMPNNGNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6C10", Offset = "0x5ED5A10", VA = "0x185ED6C10")]
	private static void PDDCDPNFFBC(NIOIPIDANEB DOKNCODMBFI, RigidTransform CFCAADHPKDN, [Optional] object HOBAPMCPFML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface HJFPGHLFPJN
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	bool INHPHNCHCAG
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	ICMPCFCEMJM LLNGDDADCGH
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	NIOIPIDANEB DPNKDOFMGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event DBFACDHHKPE EDBKCIGIKNN;

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ICMPCFCEMJM JHKLHKJHOAH(ICMPCFCEMJM PODCKBKAANA, ICMPCFCEMJM DOGICNIPKEH);

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool HOPEJEMHCDH(ICMPCFCEMJM PODCKBKAANA, ICMPCFCEMJM DOGICNIPKEH, [Out] ICMPCFCEMJM FENOEGKBEBK);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BILMNMHDICF();

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CDBNOKOCJAA();

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool LIGCEDCLKPP(ICMPCFCEMJM PODCKBKAANA);

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OADGCAMEAOL(ICMPCFCEMJM PODCKBKAANA);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public delegate void DBFACDHHKPE(NIOIPIDANEB POIENLMMLPF, NIOIPIDANEB BMFABBGDHKP);
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class OJIPJOJFMBN
{
	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6440", Offset = "0x5ED5240", VA = "0x185ED6440")]
	public static bool LOLNEFLPNKL(this HJFPGHLFPJN OMEBCCMDAKD, ICMPCFCEMJM PODCKBKAANA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5ED63C0", Offset = "0x5ED51C0", VA = "0x185ED63C0")]
	public static bool LJFIIPBMAAC(this HJFPGHLFPJN OMEBCCMDAKD, ICMPCFCEMJM PODCKBKAANA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface NFMELDKJOBO
{
	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHOLAOMOGEH(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HHPLGCBDOAL(ICMPCFCEMJM APAPEJEHLCD, Transform AGLGKAHAKII);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface CCBLBJONCKG
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKGFPDPGJPI(ICMPCFCEMJM PODCKBKAANA, ICMPCFCEMJM BGPBFNEFDCK, ICMPCFCEMJM GLJAEALHCKI);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ICMPCFCEMJM GKFDIELGFPL(ICMPCFCEMJM PODCKBKAANA);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface AHJMCNBAMOO
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIDGOMMKFGN(ICMPCFCEMJM EMALEGKCAJH, bool PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMOKMLOOGGF(ICMPCFCEMJM EMALEGKCAJH, bool PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AEIFJEDPPJJ(ICMPCFCEMJM EMALEGKCAJH, int PHPDIJICBJO);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface HIOKBDCCCHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ICMPCFCEMJM> MLGCFMOONBN(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ICMPCFCEMJM KEJIDJOBBHP(ICMPCFCEMJM APAPEJEHLCD, int NGIPPLLBEKC);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GIBCADEOBEM(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OKEDGBDEDCB HNHLINMIJNG(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HCEPHFFOJBH(ICMPCFCEMJM APAPEJEHLCD, OKEDGBDEDCB CNCKHACNADC);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ICMPCFCEMJM BPPDCOPCMID(ICMPCFCEMJM APAPEJEHLCD, [Optional] float3? LMGPBOPOFGA, [Optional] quaternion? BPBCJFMFECG, [Optional] float3? OINLNNPPPEB);

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ICMPCFCEMJM DJEFNMEMAFO(ICMPCFCEMJM APAPEJEHLCD, int NGIPPLLBEKC, [Optional] float3? LMGPBOPOFGA, [Optional] quaternion? BPBCJFMFECG, [Optional] float3? OINLNNPPPEB);

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EOPJEMJDFJD(ICMPCFCEMJM APAPEJEHLCD, int NGIPPLLBEKC);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MKDGDHLFELJ(ICMPCFCEMJM APAPEJEHLCD);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface AIHHLIKCPNF
{
	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIPNOHHHKPH();

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBPBMDFKGJF();

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FANKBFLPPCL();

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DLMOIGNAOEL();

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FIFJJMMCEAK();

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GMOPFMGDHDC();

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DCMLCGIJDPK();

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FHBPFDPPLJO();

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LJMMILAIOJB();

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CBCIGEEFGJL();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void POBKDNIOFND();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface AOGKDDGDLGP
{
	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KPNLAKPGOJE(Entity OEEKGABNFEP);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NEIODKDNKEF(Entity OEEKGABNFEP, [In] float3 PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 JOIPHJOCPCH(Entity OEEKGABNFEP);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HLHPOEMONOG(Entity OEEKGABNFEP, [In] quaternion PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion MJLLFNNJPBL(Entity OEEKGABNFEP);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NEIDKGOFOGF(Entity OEEKGABNFEP, [Out] float3 LMGPBOPOFGA, [Out] quaternion BPBCJFMFECG);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NEIDKGOFOGF(Entity OEEKGABNFEP, [Out] RigidTransform HIJNJBFPHFM);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CNOGOLCGOOO(Entity OEEKGABNFEP, [Out] RigidTransform HIJNJBFPHFM);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 IAFJDCPHNEH(Entity OEEKGABNFEP);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IJGAKNOKIGI(Entity OEEKGABNFEP, [In] float3 PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BJEEKHLCDFN(Entity OEEKGABNFEP, float PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float HAHCLAAKKII(Entity OEEKGABNFEP);

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GALCJFOCOJJ(Entity OEEKGABNFEP, [In] float3 PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 JAGKDBFFDJH(Entity OEEKGABNFEP);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HMFAMIDNCAN(Entity OEEKGABNFEP, [In] float3 PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 AKALIAIBKCO(Entity OEEKGABNFEP);

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CKPCPMLPOOJ(Entity OEEKGABNFEP, [In] quaternion PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion JOCGPMDLJNE(Entity OEEKGABNFEP);

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 OHMEINPOBMD(Entity OEEKGABNFEP);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HPNLNNLGMJA(Entity OEEKGABNFEP, [In] float3 PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void HMGHPOOODNN(Entity OEEKGABNFEP, float PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float DOMCLEMDGKH(Entity OEEKGABNFEP);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void CMEMBGDAJBL(Entity OEEKGABNFEP, [In] float3 PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 MEENHMDJENH(Entity OEEKGABNFEP);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void CEIEIKLNMFP(Entity OEEKGABNFEP, [Out] float4x4 JNOKJGIKDHC);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void IGEHNPGAEOE(Entity OEEKGABNFEP, [In] float4x4 JNOKJGIKDHC);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DKDFDPEDPLK(Entity OEEKGABNFEP, [Out] float4x4 JNOKJGIKDHC);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool DNLBNHGHMIE(Entity OEEKGABNFEP, [Out] Transform AGLGKAHAKII);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void AOBEEDCAKNE(Entity OEEKGABNFEP);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void DJDJAMNFHGD(Entity OEEKGABNFEP, Entity OFCOJHOKJMI, Entity BNOFKPJBDLH);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class OAFNGOKMGCP
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface PJJGEIFLHBL
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World MHLBEACFLBM(string NBLOHHKIIEE = "Main");

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World GHGMCBOBLIN(string NBLOHHKIIEE = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World IHBEBCAPHHM(string NBLOHHKIIEE = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World BAMKAJEDJIE(string NBLOHHKIIEE = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface LBEDLKIHHGM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	World FDCBLJDCOFP
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	World KKDGLEPBEOK
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	EntityManager NEGBPICGGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	bool JHCMEJDPEKI
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase JJMNJOLNLPB(Type AOPDMLJGEMB);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class AAJCMEGKJIO
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6030", Offset = "0x5EC4E30", VA = "0x185EC6030")]
	public static ComponentSystemBase BBLNIKLIKBG(this World FKPOHGDAOOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2AF38D0", Offset = "0x2AF26D0", VA = "0x182AF38D0")]
	public static T JJMNJOLNLPB<T>(this LBEDLKIHHGM IHNKFAPKJHC) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface GIKLDDBLPHK
{
	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DGPOOKMKDOK(NativeListAsync<Entity> CBDHABLENJN);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCILGFLGMCG(MEOKPCFKIJD NHGHFCAPBFL);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LPHFJPDGPBH(NativeListAsync<Entity> EBIDAELMJCL, bool BLNEKCEKCBB);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KMKICJJLCIN();
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface PNEFPPCLIMI
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DFCFBJAJJDO(ICMPCFCEMJM APAPEJEHLCD, [Out] Collider OPLJGLOKEDF);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject OAAMPJAALGP(ICMPCFCEMJM CPDJGLBFDDN, GameObject NPFEMNDPOFF, Vector3 EHFMGFPLNPD, Quaternion GBLLLKBIFDK);

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KCNEACHHMGM(GameObject OPLJGLOKEDF);

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider BMMEFCCDLIF<TCollider>(GameObject DAIJBLBOJAJ) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECGOFOOJMBP(Collider OPLJGLOKEDF);

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject GGIAHIDJFOH<TCollider>(string NDLLBBKGIJD) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface LBECLFECNLE
{
	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NEHGGLEDHDJ(ICMPCFCEMJM APAPEJEHLCD, BPGIMFEDAKL HPJNPDCBCAI, bool NGFLOPMDGLA, BHJEJOPMAHL PJDBCOIJDJB);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCBBJEFEOJK(ICMPCFCEMJM APAPEJEHLCD, BPGIMFEDAKL HPJNPDCBCAI, bool NGFLOPMDGLA, bool PHFMOHCBFNP, bool OKCEOCNILJP);

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BJGGLAEGEGL MAEJKJEDMIJ(ICMPCFCEMJM NANDDCHCAEB, List<ICMPCFCEMJM> PNDNPJMONJL);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HDCLPJCIEJH(GameObject FBHGLPMLBFN, GameObject IJLPFBPIKEJ);

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OCCGGCKJJJO(GameObject IJLPFBPIKEJ);

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T BMMEFCCDLIF<T>(GameObject DAIJBLBOJAJ) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ECGOFOOJMBP(Collider OPLJGLOKEDF);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject PIMHNJHHHFF<T>(string NDLLBBKGIJD) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface AKEDKKKIDLP
{
	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOEIMKJBBLM(ICMPCFCEMJM APAPEJEHLCD, IMPMKPGDGFD PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IMPMKPGDGFD FGFOBIKLKBK(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MKPCBGMLOBB(ICMPCFCEMJM APAPEJEHLCD, ICMPCFCEMJM PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EEJHGNEHILF(ICMPCFCEMJM APAPEJEHLCD, ICMPCFCEMJM PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int MALEIGKNLHB(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ICMPCFCEMJM HOFLAFBELNA(ICMPCFCEMJM APAPEJEHLCD, int NGIPPLLBEKC);

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DLLOGMJMNPI(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JGEMMPDHJGP(ICMPCFCEMJM APAPEJEHLCD, object HOBAPMCPFML, ICMPCFCEMJM PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JFPPHGJAKEH(ICMPCFCEMJM APAPEJEHLCD, object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PNCAFKIMDIO(ICMPCFCEMJM APAPEJEHLCD, [Out] ICMPCFCEMJM PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IPHDKNGGBEG(ICMPCFCEMJM APAPEJEHLCD, float3 PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EEDHNDDBBGG(ICMPCFCEMJM APAPEJEHLCD, [Out] float3 PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ABPFCKCMGHB(ICMPCFCEMJM APAPEJEHLCD, float3 PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool NILAAIBHAGA(ICMPCFCEMJM APAPEJEHLCD, [Out] float3 PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MIONNCNEBGA(ICMPCFCEMJM APAPEJEHLCD, (Quaternion rot, Vector3 moments) ABHEAGLOLDA);

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool CEGECANOAOH(ICMPCFCEMJM APAPEJEHLCD, [Out] quaternion GKLJGLEHAOP, [Out] float3 FGCCHCCBLDJ);

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void KPOINAJGHNM(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HJDGLCLEMIC(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 MHCEOGNDOCP(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 MKFJAMFPCPP(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void GEPEENCCBJN(ICMPCFCEMJM APAPEJEHLCD, float3 PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LDKPEMELDCF(ICMPCFCEMJM APAPEJEHLCD, float3 PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float EDAFDPKDODC(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float KFAKACDJIJB(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GPEKAHHEJHN(ICMPCFCEMJM APAPEJEHLCD, float PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void MMDDCOMHJNJ(ICMPCFCEMJM APAPEJEHLCD, float PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode KHGIHBBAMCB(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void NMOIAAGOMOH(ICMPCFCEMJM APAPEJEHLCD, CollisionDetectionMode PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "28")]
	MDGAADFLMAK NDMNJKHEENG(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void OCHDBLKFGNI(ICMPCFCEMJM APAPEJEHLCD, MDGAADFLMAK PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool OMLADCBDDHL(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void OPKMMKBNOGM(ICMPCFCEMJM APAPEJEHLCD, bool PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "32")]
	ICMPCFCEMJM DPPGCKCMPFA(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void KNAJIBPEOIG(ICMPCFCEMJM APAPEJEHLCD, ICMPCFCEMJM PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "34")]
	ICMPCFCEMJM DOGIJGBLGNI(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void IFKFCKDOJJB(ICMPCFCEMJM APAPEJEHLCD, ICMPCFCEMJM PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "36")]
	FBMIFKFEGDK CMHFMEELJBP(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void KJGIHDJGAJB(ICMPCFCEMJM APAPEJEHLCD, FBMIFKFEGDK GPNGHPLKPGM);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool CIIPIABFLGC(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void PEHDLAIFNOE(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool ABHIKFNCCIE(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void NBDJEJODLJA(ICMPCFCEMJM APAPEJEHLCD, bool PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool HIGIFMIGJGG(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void CDNNJFMHFAG(ICMPCFCEMJM APAPEJEHLCD, bool PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints FNKANEEAOKK(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void AFEEPOAEENI(ICMPCFCEMJM APAPEJEHLCD, RigidbodyConstraints PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float EBJFFOOBEGA(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void FGPJPCBDHPO(ICMPCFCEMJM APAPEJEHLCD, float PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float APBANEOCGCA(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void INPIDANAMCB(ICMPCFCEMJM APAPEJEHLCD, float PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool CELPLDJBEIH(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void EAOFFKONJEI(ICMPCFCEMJM APAPEJEHLCD, bool PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool BEFOPLHOMND(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void DDDAOMHCPBA(ICMPCFCEMJM APAPEJEHLCD, bool PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void AFCLKAECHFN(ICMPCFCEMJM APAPEJEHLCD, int PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object GAFKLGMLILH(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void BOPLHEHEBCN(ICMPCFCEMJM APAPEJEHLCD, object PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object LDDEICGMGAM(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void LBGBCJFCLGC(ICMPCFCEMJM APAPEJEHLCD, object PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float GBDIELDHJND(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void EDKNCGIBMPL(ICMPCFCEMJM APAPEJEHLCD, float PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void MFBFCCDEBJP(ICMPCFCEMJM APAPEJEHLCD, object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void LNEDIKDBGGD(ICMPCFCEMJM APAPEJEHLCD, object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool KBJBCECJDKI(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void AENCANAECIP(ICMPCFCEMJM APAPEJEHLCD, object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void IIOAIMDGKGI(ICMPCFCEMJM APAPEJEHLCD, object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool JKLBIEKFJNF(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool NLADJFKAKIN(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody GEDBEMNFIIO(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void PHONCANIGPM(ICMPCFCEMJM APAPEJEHLCD, Rigidbody EIODOLNINOL);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void LLKDAJOCJHI(ICMPCFCEMJM APAPEJEHLCD, object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void FMPBJANDFLE(ICMPCFCEMJM APAPEJEHLCD, object HOBAPMCPFML);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool FJNKCLMMMPA(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void GHHLKEJBIHN(ICMPCFCEMJM APAPEJEHLCD, float3 MAEAAOMNFME);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void NAEOKOOADJF(ICMPCFCEMJM APAPEJEHLCD, float3 GEOFLKGAFKA);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool CANPBHPODMM(ICMPCFCEMJM APAPEJEHLCD, [Out] float3 MAEAAOMNFME);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool DAEBIDFFGOL(ICMPCFCEMJM APAPEJEHLCD, [Out] float3 GEOFLKGAFKA);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool PIPIJMFJFLK(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void FGEACIMMPOH(ICMPCFCEMJM APAPEJEHLCD, object HOBAPMCPFML, bool MOOGEOGEGKF);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void OGIHFPOKFPM(ICMPCFCEMJM APAPEJEHLCD, bool FCFGLKEEOOF);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void OJEJAPPAMKP(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool BEKMEKFLNBD(ICMPCFCEMJM APAPEJEHLCD);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface IGGNMJBENLC
{
	[Cpp2IlInjected.Token(Token = "0x17000135")]
	bool JHCMEJDPEKI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KKMLIHEALJN(ICMPCFCEMJM APAPEJEHLCD);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JOFGALJKENJ(ICMPCFCEMJM APAPEJEHLCD, bool NGFLOPMDGLA, bool PHFMOHCBFNP, bool EJPKMLIJMOJ);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNOMPKIHFPH(ICMPCFCEMJM APAPEJEHLCD, float3 OIMALFIAIDE);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKAEGAKENIM(ICMPCFCEMJM APAPEJEHLCD, float3 OIMALFIAIDE);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface DJEKOCLGGIE
{
	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NHJGLLDBEJM(Entity HPJCBGAILMG);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DBMPKJGCKFL(Entity HPJCBGAILMG);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public delegate void NLEICCKKLDG(LEAHAJBMPKK NMFNJPODKGB);
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct LEAHAJBMPKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly BPNOBCOILLF CCEDANLDKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly NativeArray<byte> JOEPHIIALLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NativeArray<byte> FKKBLEKOJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly AAMPPPNKBPN PNCLPGLPBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly int JLFDOJKDDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Type MJELFNJNADC;

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public BPNOBCOILLF PNEMCIFLBBE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x345B560", Offset = "0x345A360", VA = "0x18345B560")]
		get
		{
			return default(BPNOBCOILLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1370", Offset = "0x5ED0170", VA = "0x185ED1370")]
	public LEAHAJBMPKK(BPNOBCOILLF CCEDANLDKLA, NativeArray<byte> JOEPHIIALLP, NativeArray<byte> FKKBLEKOJJG, AAMPPPNKBPN PNCLPGLPBGN, int JLFDOJKDDIK, Type MJELFNJNADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x2559470", Offset = "0x2558270", VA = "0x182559470")]
	public NativeArray<T> OBMANDGFGJF<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x2559430", Offset = "0x2558230", VA = "0x182559430")]
	public NativeArray<T> JICHELHICDA<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x2559340", Offset = "0x2558140", VA = "0x182559340")]
	public (BPNOBCOILLF, NativeArray<T>, NativeArray<T>) HFNEOIKDHBA<T>() where T : struct
	{
		return default((BPNOBCOILLF, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1320", Offset = "0x5ED0120", VA = "0x185ED1320")]
	public HAOHLIHBEBG LBHDHBFNEOO()
	{
		return default(HAOHLIHBEBG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface KHCMCMDPBKP
{
	[Cpp2IlInjected.Token(Token = "0x17000137")]
	string EIFEFLALOGO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	KHCMCMDPBKP CMBFDMLAJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	IEnumerable<KHCMCMDPBKP> NCIODPAOPJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface KHGPMJJEAAO
{
	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	KHCMCMDPBKP KCGLMHKLGFB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	List<JHBILBHMEEM> JCKMBAPDLLM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DGNBEELMFAF(JHBILBHMEEM NEBGFGPEMHL, [Out] KHCMCMDPBKP IJLGAFJDHOF);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EEHFKNGNNHO(JHBILBHMEEM NEBGFGPEMHL, NLEICCKKLDG KPLJJOPIFMJ);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CECAHPBMPOM(JHBILBHMEEM NEBGFGPEMHL, NLEICCKKLDG KPLJJOPIFMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct HAOHLIHBEBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly LEAHAJBMPKK KNAIEKIJLBC;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public BPNOBCOILLF PNEMCIFLBBE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x345B560", Offset = "0x345A360", VA = "0x18345B560")]
		get
		{
			return default(BPNOBCOILLF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBAE0", Offset = "0x5ECA8E0", VA = "0x185ECBAE0")]
	public HAOHLIHBEBG(LEAHAJBMPKK KNAIEKIJLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x5ECBA10", Offset = "0x5ECA810", VA = "0x185ECBA10")]
	public BPNOBCOILLF OBMANDGFGJF()
	{
		return default(BPNOBCOILLF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB940", Offset = "0x5ECA740", VA = "0x185ECB940")]
	public BPNOBCOILLF JICHELHICDA()
	{
		return default(BPNOBCOILLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB820", Offset = "0x5ECA620", VA = "0x185ECB820")]
	public (BPNOBCOILLF, BPNOBCOILLF, BPNOBCOILLF) HFNEOIKDHBA()
	{
		return default((BPNOBCOILLF, BPNOBCOILLF, BPNOBCOILLF));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DefaultMember("Item")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface NIGEKJKELIF : IEnumerable<GBBBMNOIKNN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	NativeBitArray MHJODOFJJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	NativeArray<int> GGELHBMLBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	GBBBMNOIKNN LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	GBBBMNOIKNN LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GBBBMNOIKNN NMIKMONPALM(CAPPPJFDLDK DLDPMNCLOEO);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "6")]
	AAMPPPNKBPN KPIMLGMCMOD(CAPPPJFDLDK DLDPMNCLOEO);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class DJBNOHGKJFA
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
[DefaultMember("Item")]
public interface NFOIOFNPONO : IEnumerable<AMPOPAEHFMG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000142")]
	int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	AMPOPAEHFMG LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AMPOPAEHFMG NMIKMONPALM(CAPPPJFDLDK DLDPMNCLOEO);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AAMPPPNKBPN KPIMLGMCMOD(CAPPPJFDLDK DLDPMNCLOEO);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class ACCMDPODGEK
{
	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF5790", Offset = "0x2AF4590", VA = "0x182AF5790")]
	public static AAMPPPNKBPN KPIMLGMCMOD<T>(this NFOIOFNPONO GLPHNLMJMNF, GGPDIJBEDJF<T> NDLLBBKGIJD) where T : struct
	{
		return default(AAMPPPNKBPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface FBGCGFLCOFH : IEnumerable<JHBILBHMEEM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000144")]
	int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	JHBILBHMEEM LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JHBILBHMEEM NMIKMONPALM(CAPPPJFDLDK DLDPMNCLOEO);

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AAMPPPNKBPN KPIMLGMCMOD(CAPPPJFDLDK DLDPMNCLOEO);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class FBKCEOIOMDK
{
	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x24C2F50", Offset = "0x24C1D50", VA = "0x1824C2F50")]
	public static AEFBBMCIMAF<T> NMIKMONPALM<T>(this FBGCGFLCOFH GLPHNLMJMNF, CAPPPJFDLDK NDLLBBKGIJD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x24C2E50", Offset = "0x24C1C50", VA = "0x1824C2E50")]
	public static AAMPPPNKBPN KPIMLGMCMOD<T>(this FBGCGFLCOFH GLPHNLMJMNF, GGPDIJBEDJF<T> NDLLBBKGIJD) where T : struct
	{
		return default(AAMPPPNKBPN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface IFAJNEEBKFI
{
	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEHFKNGNNHO(CAPPPJFDLDK NEBGFGPEMHL, NLEICCKKLDG KPLJJOPIFMJ);

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CECAHPBMPOM(CAPPPJFDLDK NEBGFGPEMHL, NLEICCKKLDG KPLJJOPIFMJ);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class IAGLOFIHFBG
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface EPJJKDMOMGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000146")]
	BABKBAAHDGJ FEHMOPBKKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGNPHFPJMLM(EABFOFIEHMJ MDOHEAFMDAC, AAMPPPNKBPN NEBGFGPEMHL);

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DDCKILLPLGL(EABFOFIEHMJ MDOHEAFMDAC, Span<AAMPPPNKBPN> GLPHNLMJMNF, bool KMHHKPMGHEH);

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LCDGMNDHNJC(NativeArray<EABFOFIEHMJ> JHALHPHCAKG);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class MPMONNGHCFH
{
	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x5ED36E0", Offset = "0x5ED24E0", VA = "0x185ED36E0")]
	public static void DDCKILLPLGL(this EPJJKDMOMGJ GELINFNCHIG, EABFOFIEHMJ MDOHEAFMDAC, AAMPPPNKBPN NEBGFGPEMHL, bool KMHHKPMGHEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct BABKBAAHDGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly NativeBitArray NMKMBJCENGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly NativeParallelHashMap<EABFOFIEHMJ, int> EDEDOGPKODE;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	public bool LPMBBCCNKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x5EC6DF0", Offset = "0x5EC5BF0", VA = "0x185EC6DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0xAFA220", Offset = "0xAF9020", VA = "0x180AFA220")]
	public BABKBAAHDGJ(NativeBitArray NMKMBJCENGJ, NativeParallelHashMap<EABFOFIEHMJ, int> EDEDOGPKODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC6E10", Offset = "0x5EC5C10", VA = "0x185EC6E10")]
	public bool PGNPHFPJMLM(EABFOFIEHMJ MDOHEAFMDAC, AAMPPPNKBPN NEBGFGPEMHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface EENBIBCOFOO
{
	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BEDPIAEOGMI(ICMPCFCEMJM APAPEJEHLCD, BBGHDLICAGJ PHPDIJICBJO);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface IFKFPCIAIFN
{
	[Cpp2IlInjected.Token(Token = "0x17000148")]
	FDCNBJCCLMM OMKNFOIHFPG
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface BACGNGFCCFH
{
	[Cpp2IlInjected.Token(Token = "0x17000149")]
	Type CIGDDKIEJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[HGMCCEJNKJD(EKCJLNMKMJO.LoadInstance)]
public interface HDILPGAKFOP
{
	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MEDOBCMAFDI(ICMPCFCEMJM EMALEGKCAJH, bool PHPDIJICBJO);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public readonly struct DBBLPKHFFLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly IEnumerable<GEPFADDONPB> HFFECNEPHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly IReadOnlyList<GameObject> FOLHHKEKLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly IReadOnlyList<int> HHBLJMJPGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly IReadOnlyList<(EABFOFIEHMJ, EABFOFIEHMJ)> LJBGCINFKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int IDIFIAHONDD;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool ACDJDJBKPCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x5EC7D70", Offset = "0x5EC6B70", VA = "0x185EC7D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public int BIJLGDKCJKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x863AD0", Offset = "0x8628D0", VA = "0x180863AD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public IEnumerable<GameObject> EANKFLFDEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7FF8E0", Offset = "0x7FE6E0", VA = "0x1807FF8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public IEnumerable<(EABFOFIEHMJ src, EABFOFIEHMJ dst)> LGDOOHOJEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8160", Offset = "0x5EC6F60", VA = "0x185EC8160")]
	public DBBLPKHFFLG(IEnumerable<GEPFADDONPB> HFFECNEPHHC, IReadOnlyList<GameObject> FOLHHKEKLIN, IReadOnlyList<int> HHBLJMJPGLC, IReadOnlyList<(EABFOFIEHMJ src, EABFOFIEHMJ dst)> LJBGCINFKGH, int IDIFIAHONDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x5EC7DD0", Offset = "0x5EC6BD0", VA = "0x185EC7DD0")]
	public (GameObject, int)[] FJMFGFPGAGA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface DMJEPKFGKAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	bool EEHGOFGPNGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	bool JMJMKHOLLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	PFJFLDBHLKB EPIHEJBNEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	BKDGPKEMLDO KMMPJEDHNLH();

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BKDGPKEMLDO FLECDOOFCLK(IEnumerable<ICMPCFCEMJM> ILEEGIHBOBP, [In] FCGNMDMHCJG NIJGHDDKHBM);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NIKJKPDJEEE ANDOELMHNKB(ByteString MGAOBCBGPOC);

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GGJALLALLHK BDOFMALCOFL(ByteString BBFMJKBFLAL, ICMPCFCEMJM BMNEKBHDGLJ, [In] FCGNMDMHCJG GHIMBNAKINC, ECLEIHBCHEN EEIGADCODED, bool FKFJEMPNPHC = true);

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AEPFNFDHGMI();

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DBBLPKHFFLG IFMAJAEIACA(IEnumerable<GEPFADDONPB> HFFECNEPHHC);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class ACPIILKLLFA
{
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface HADNGKBPPGP
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action LOHKBCBHFCI;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action KLNOIPOJHHN;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct OOPDIEJAFFC : FEEIINJHFHI, IEquatable<OOPDIEJAFFC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public POLLAGMGKIL HPJEHGNFPGN;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6640", Offset = "0x5ED5440", VA = "0x185ED6640", Slot = "5")]
	public void LKNPCKIALBL(FLDIJJAECJM EIFCDBMOGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5ED6670", Offset = "0x5ED5470", VA = "0x185ED6670", Slot = "4")]
	public void OJBJHHLKILJ(ILFEGODGKII NEGHIHACAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5ED66A0", Offset = "0x5ED54A0", VA = "0x185ED66A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x16C9C30", Offset = "0x16C8A30", VA = "0x1816C9C30", Slot = "6")]
	public bool Equals(OOPDIEJAFFC LCIDHBCOPEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED65C0", Offset = "0x5ED53C0", VA = "0x185ED65C0", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x832500", Offset = "0x831300", VA = "0x180832500", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct EABFOFIEHMJ : IComparable<EABFOFIEHMJ>, IEquatable<EABFOFIEHMJ>, FEEIINJHFHI
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public const uint FFHICBDENGD = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const uint IOGEEIEMPAB = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly EABFOFIEHMJ OAICJFILECK;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private const int APEIHPPLHOJ = 24;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private const uint PLIMDIAEBEL = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private const int MCBNAALKHGC = 8;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private const uint PLLLJBMMDEP = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly uint EHLPPEEOBND;

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public uint FEGAGCAJDDA
	{
		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x7C9920", Offset = "0x7C8720", VA = "0x1807C9920")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public uint DHGNDNJJJIH
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x5EC8510", Offset = "0x5EC7310", VA = "0x185EC8510")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public uint NGEBBFABDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x832500", Offset = "0x831300", VA = "0x180832500")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public bool ACDJDJBKPCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x5E2AD40", Offset = "0x5E29B40", VA = "0x185E2AD40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xD518E0", Offset = "0xD506E0", VA = "0x180D518E0")]
	public static EABFOFIEHMJ JAGOMCJLGPF(uint EHLPPEEOBND)
	{
		return default(EABFOFIEHMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8670", Offset = "0x5EC7470", VA = "0x185EC8670")]
	public EABFOFIEHMJ(int LLPAAOLCJKC, int IHLANMNOBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8670", Offset = "0x5EC7470", VA = "0x185EC8670")]
	public EABFOFIEHMJ(uint LLPAAOLCJKC, int IHLANMNOBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8670", Offset = "0x5EC7470", VA = "0x185EC8670")]
	public EABFOFIEHMJ(uint LLPAAOLCJKC, uint IHLANMNOBAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x8324C0", Offset = "0x8312C0", VA = "0x1808324C0")]
	private EABFOFIEHMJ(uint EHLPPEEOBND)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x16C9C50", Offset = "0x16C8A50", VA = "0x1816C9C50")]
	public static bool HIHGGPGGFPN(EABFOFIEHMJ ALNGIEPPLJJ, EABFOFIEHMJ DCODMCLNKEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x16C9C30", Offset = "0x16C8A30", VA = "0x1816C9C30", Slot = "5")]
	public bool Equals(EABFOFIEHMJ JPODHBJFPKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8490", Offset = "0x5EC7290", VA = "0x185EC8490", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x20736B0", Offset = "0x20724B0", VA = "0x1820736B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5EC85E0", Offset = "0x5EC73E0", VA = "0x185EC85E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8580", Offset = "0x5EC7380", VA = "0x185EC8580", Slot = "6")]
	public void OJBJHHLKILJ(ILFEGODGKII NEGHIHACAHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8520", Offset = "0x5EC7320", VA = "0x185EC8520", Slot = "7")]
	public void LKNPCKIALBL(FLDIJJAECJM EIFCDBMOGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC8480", Offset = "0x5EC7280", VA = "0x185EC8480", Slot = "4")]
	public int CompareTo(EABFOFIEHMJ LCIDHBCOPEO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct GEPFADDONPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Guid CHLMGBPAGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public string PHPPAMIKEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Vector3 LMGPBOPOFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Quaternion BPBCJFMFECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Vector3 OINLNNPPPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public int JPKJAHAECPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Dictionary<string, object> CNCKHACNADC;

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB2B0", Offset = "0x5ECA0B0", VA = "0x185ECB2B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB120", Offset = "0x5EC9F20", VA = "0x185ECB120")]
	private static string NGJJBNFOFFE(Dictionary<string, object> LLNOCJICDNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public enum GAGNOBANKIE
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class BHHFMFOPLGN
{
	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x54118C0", Offset = "0x54106C0", VA = "0x1854118C0")]
	public static bool IMCKHKOPCMI(this GAGNOBANKIE AOPDMLJGEMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Flags]
public enum NHHGEJKJJLG
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
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface GGJALLALLHK : PFJFLDBHLKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000155")]
	ECLEIHBCHEN MNNKNJLCDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJNJBINOIEF();

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FDEIMMOKINI();
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface PFJFLDBHLKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000156")]
	IEnumerable<GEPFADDONPB> IHNOJHACLBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	DBBLPKHFFLG FPKLLANOEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	LocalId IGEIJMLDOMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	IADJKNOBBHN AAHCNIFPFIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	Task KODGGICJMJP
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CJPLMBELNJP(NHHGEJKJJLG BGFMPCMEONL);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface ECLEIHBCHEN
{
	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NLACMHFELHJ(Guid JPKEGLEDKEC, [Out] Guid LLIDMGAMJNA);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public interface NIKJKPDJEEE : PFJFLDBHLKB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[Flags]
public enum OKNLJKECPMB
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
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public interface BKDGPKEMLDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	IADJKNOBBHN KKFFBJAIJGB
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString IPPNCJBKMGD();
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public enum ADFFDKPEMAD
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public delegate bool HGKDPIIKKDH(PMLNFKIOPDH KJFMGBEMKFH, [In] PJHPAJAPHOI PHPDIJICBJO);
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public delegate bool BLKPFBDDCNC<T>(PMLNFKIOPDH KJFMGBEMKFH, [In] T PHPDIJICBJO);
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface OFPIDHKNOEC
{
	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEHFKNGNNHO(AAMPPPNKBPN PNCLPGLPBGN, Type MCMJCHHEBAH, HGKDPIIKKDH OHPEHBLJAEF);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NBEDCLIHODM(AAMPPPNKBPN PNCLPGLPBGN, [Out] HGKDPIIKKDH OHPEHBLJAEF);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class GAABBCPHCAD
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class PLJBKPIIAAM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public BLKPFBDDCNC<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public PLJBKPIIAAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x3F06B40", Offset = "0x3F05940", VA = "0x183F06B40")]
		internal bool PHEDMHGNKHL(PMLNFKIOPDH pendingList, [In] PJHPAJAPHOI value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x24ED3B0", Offset = "0x24EC1B0", VA = "0x1824ED3B0")]
	public static void EEHFKNGNNHO<T>(this OFPIDHKNOEC ELOPFOKALOB, AAMPPPNKBPN PNCLPGLPBGN, BLKPFBDDCNC<T> OHPEHBLJAEF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x5ECB010", Offset = "0x5EC9E10", VA = "0x185ECB010")]
	public static bool KKMJLIHPNII(this OFPIDHKNOEC ELOPFOKALOB, PMLNFKIOPDH KJFMGBEMKFH, AAMPPPNKBPN PNCLPGLPBGN, [In] PJHPAJAPHOI PHPDIJICBJO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface DELBJBAKDGC
{
	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	uint CMEOAFDEOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface PMLNFKIOPDH
{
	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBLNNBBDMPI(EABFOFIEHMJ GLOFLBLOBHJ, AAMPPPNKBPN PNCLPGLPBGN, ReadOnlySpan<byte> MNGDNBPEOBD, ReadOnlySpan<byte> DJBJBIGNDGM);

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KIONAHOKALE(EABFOFIEHMJ GLOFLBLOBHJ, AAMPPPNKBPN PNCLPGLPBGN);

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ABEHLJAGEDC(EABFOFIEHMJ GLOFLBLOBHJ, AAMPPPNKBPN PNCLPGLPBGN, ReadOnlySpan<byte> DJBJBIGNDGM);

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PECCKPAANLN(EABFOFIEHMJ GLOFLBLOBHJ, AAMPPPNKBPN PNCLPGLPBGN, Span<byte> MNGDNBPEOBD, Span<byte> DJBJBIGNDGM);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class CKKCAMEFCHE
{
	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x232DAF0", Offset = "0x232C8F0", VA = "0x18232DAF0")]
	public static bool PECCKPAANLN<T>(this PMLNFKIOPDH LNEJMJLBEED, EABFOFIEHMJ GLOFLBLOBHJ, AAMPPPNKBPN PNCLPGLPBGN, [Out] T MNGDNBPEOBD, [Out] T DJBJBIGNDGM) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x232D9C0", Offset = "0x232C7C0", VA = "0x18232D9C0")]
	public static bool ABEHLJAGEDC<T>(this PMLNFKIOPDH LNEJMJLBEED, EABFOFIEHMJ GLOFLBLOBHJ, AAMPPPNKBPN PNCLPGLPBGN, T DJBJBIGNDGM) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public enum GKBFFJGPIGB
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
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface AGJJJOLKBLC
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NIMFPGBCFEL(LIEEBGEKNHM KFIJLJLHGLL, ReadOnlySpan<byte> IPHMLIFNKFM);

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JEKLGFJHJAG(uint FJBOMLDGEMP, ReadOnlySpan<byte> IPHMLIFNKFM);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface OCLPEOLCHFN
{
	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LIEEBGEKNHM BNJENOEJGAL(ReadOnlySpan<byte> IPHMLIFNKFM);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface BFBMCHMKONH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNLMAFFJDGF(LIEEBGEKNHM GAMCILOFBAF, ReadOnlySpan<byte> IPHMLIFNKFM);

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MHGFONLMFAI(ReadOnlySpan<LIEEBGEKNHM> BPNEOHIDACE);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct LBEKDGACCKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public LIEEBGEKNHM KFIJLJLHGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public ReadOnlyMemory<byte> IPHMLIFNKFM;
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct LIEEBGEKNHM
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static LIEEBGEKNHM JEKPBDCFLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public uint LLPAAOLCJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public int JOJKAPMOKIL;

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x9D7BB0", Offset = "0x9D69B0", VA = "0x1809D7BB0")]
	public LIEEBGEKNHM(uint LLPAAOLCJKC, int JOJKAPMOKIL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1730", Offset = "0x5ED0530", VA = "0x185ED1730")]
	public static bool HIHGGPGGFPN([In] LIEEBGEKNHM KADNMONNONH, [In] LIEEBGEKNHM DCAFNABOJJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1650", Offset = "0x5ED0450", VA = "0x185ED1650", Slot = "0")]
	public override bool Equals(object KANAGAAAGHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1700", Offset = "0x5ED0500", VA = "0x185ED1700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1750", Offset = "0x5ED0550", VA = "0x185ED1750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1640", Offset = "0x5ED0440", VA = "0x185ED1640")]
	public void CEKAEOJBACK([Out] uint LLPAAOLCJKC, [Out] int JOJKAPMOKIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[HGMCCEJNKJD(EKCJLNMKMJO.OMRoom)]
public interface POHCEKICLEL : GOCDKKJFMKP<POHCEKICLEL>
{
	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PGALEGIIEOF(AAMPPPNKBPN JPODHBJFPKM, [Out] BFGDCLJJEMP JPNJGPDCOMG);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public static class PPJPAHLOEAG
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface BFGDCLJJEMP
{
	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	Type IKMLJFDBLED
	{
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKNPCKIALBL(FLDIJJAECJM EIFCDBMOGEN, Span<byte> PODCKBKAANA);

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJBJHHLKILJ(ILFEGODGKII NEGHIHACAHG, ReadOnlySpan<byte> KFIJLJLHGLL);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class OGNICNOJPFP
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public struct LJHFPCKKDJB : ISystemStateComponentData, IComponentData, IEquatable<LJHFPCKKDJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public float3 HKECILCMCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 LIHJLHGFCJB;

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5ED1840", Offset = "0x5ED0640", VA = "0x185ED1840", Slot = "4")]
	public bool Equals(LJHFPCKKDJB LCIDHBCOPEO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface PEDCIFEOJLL
{
	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DBKEPFKOJMM OJFKGPFNDMP(int LOEGAOKGNFD);

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int LMJCHNJHKDE(DBKEPFKOJMM FBIJACGCHBB);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface DKCINPFDGAK
{
	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	IEnumerable<BJLJODNDBML> HDEEFEMDKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EPOBKHHDMPJ(int LOEGAOKGNFD, [Out] BJLJODNDBML JPNJGPDCOMG);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface NDGMHEODOKA
{
	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JLCKPLCKIPC(int LOEGAOKGNFD);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[HGMCCEJNKJD(EKCJLNMKMJO.Application)]
public interface DOOOELNOHNM
{
	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	List<(DBKEPFKOJMM nameHash, JKADALDJLPG stableTypeHash, Type type)> KKHAJFCGLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public class DBFEEPAPMKO
{
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public DBFEEPAPMKO()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
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
