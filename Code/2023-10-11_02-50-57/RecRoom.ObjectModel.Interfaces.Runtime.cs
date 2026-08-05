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
public struct EOLLFEKBMDA : IReadOnlyList<JBMJEBCFLLB>, IEnumerable<JBMJEBCFLLB>, IEnumerable, IReadOnlyCollection<JBMJEBCFLLB>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct EOJLCMMMGNF : IEnumerator<JBMJEBCFLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly IKBNJJBMJGF CFIPHHIMOMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator LOJCJECHJKH;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public JBMJEBCFLLB MNPEEGLNGOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5DAD460", Offset = "0x5DAC260", VA = "0x185DAD460", Slot = "4")]
			get
			{
				return default(JBMJEBCFLLB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5DAD3E0", Offset = "0x5DAC1E0", VA = "0x185DAD3E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x391C500", Offset = "0x391B300", VA = "0x18391C500")]
		public EOJLCMMMGNF(IKBNJJBMJGF CFIPHHIMOMK, NativeArray<LocalId>.Enumerator LOJCJECHJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD320", Offset = "0x5DAC120", VA = "0x185DAD320", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD360", Offset = "0x5DAC160", VA = "0x185DAD360", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD3A0", Offset = "0x5DAC1A0", VA = "0x185DAD3A0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> DJIDJBJMOLC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public JBMJEBCFLLB BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5DADAF0", Offset = "0x5DAC8F0", VA = "0x185DADAF0", Slot = "4")]
		get
		{
			return default(JBMJEBCFLLB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD4B0", Offset = "0x5DAC2B0", VA = "0x185DAD4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int FINJOJGBPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75FF80", VA = "0x180761180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IKBNJJBMJGF OJBGOKBDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DCLHHJJDFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x761180", Offset = "0x75FF80", VA = "0x180761180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HDOIMIGPILP
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DAD500", Offset = "0x5DAC300", VA = "0x185DAD500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> GBHPADONFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3915B00", Offset = "0x3914900", VA = "0x183915B00")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5DADA60", Offset = "0x5DAC860", VA = "0x185DADA60")]
	public EOLLFEKBMDA(int DECKGNHFLHF, IKBNJJBMJGF CFIPHHIMOMK, Allocator JFLEKJGGDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x391B990", Offset = "0x391A790", VA = "0x18391B990")]
	public EOLLFEKBMDA(IKBNJJBMJGF CFIPHHIMOMK, NativeArray<LocalId> DJIDJBJMOLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD9F0", Offset = "0x5DAC7F0", VA = "0x185DAD9F0")]
	internal EOLLFEKBMDA(IKBNJJBMJGF CFIPHHIMOMK, NativeArray<Entity> PFOPLIKJCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD950", Offset = "0x5DAC750", VA = "0x185DAD950")]
	public EOLLFEKBMDA(IKBNJJBMJGF CFIPHHIMOMK, int JMNJMKJAMOL, Allocator JFLEKJGGDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD8A0", Offset = "0x5DAC6A0", VA = "0x185DAD8A0")]
	public EOLLFEKBMDA(EOLLFEKBMDA DLKAPBOOKLJ, Allocator JFLEKJGGDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD580", Offset = "0x5DAC380", VA = "0x185DAD580")]
	public EOLLFEKBMDA KBCPIACFDGK(Allocator JFLEKJGGDHL = Allocator.Temp)
	{
		return default(EOLLFEKBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD540", Offset = "0x5DAC340", VA = "0x185DAD540", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD630", Offset = "0x5DAC430", VA = "0x185DAD630")]
	public EOJLCMMMGNF MIBGMGJFDKE()
	{
		return default(EOJLCMMMGNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD6C0", Offset = "0x5DAC4C0", VA = "0x185DAD6C0", Slot = "6")]
	private IEnumerator<JBMJEBCFLLB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD7B0", Offset = "0x5DAC5B0", VA = "0x185DAD7B0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct KBEMMLPPEPC : IList<JBMJEBCFLLB>, ICollection<JBMJEBCFLLB>, IEnumerable<JBMJEBCFLLB>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct PGBKLOHIBPG : IEnumerator<JBMJEBCFLLB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly IKBNJJBMJGF CFIPHHIMOMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator LOJCJECHJKH;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public JBMJEBCFLLB MNPEEGLNGOK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5DB8A60", Offset = "0x5DB7860", VA = "0x185DB8A60", Slot = "4")]
			get
			{
				return default(JBMJEBCFLLB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5DB89E0", Offset = "0x5DB77E0", VA = "0x185DB89E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x391C500", Offset = "0x391B300", VA = "0x18391C500")]
		public PGBKLOHIBPG(IKBNJJBMJGF CFIPHHIMOMK, NativeArray<LocalId>.Enumerator LOJCJECHJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8920", Offset = "0x5DB7720", VA = "0x185DB8920", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8960", Offset = "0x5DB7760", VA = "0x185DB8960", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5DB89A0", Offset = "0x5DB77A0", VA = "0x185DB89A0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IKBNJJBMJGF CFIPHHIMOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> DJIDJBJMOLC;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JBMJEBCFLLB BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5DB11D0", Offset = "0x5DAFFD0", VA = "0x185DB11D0", Slot = "4")]
		get
		{
			return default(JBMJEBCFLLB);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1250", Offset = "0x5DB0050", VA = "0x185DB1250", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0BF0", Offset = "0x5DAF9F0", VA = "0x185DB0BF0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DCLHHJJDFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0BF0", Offset = "0x5DAF9F0", VA = "0x185DB0BF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool MGKAFOIHMEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1140", Offset = "0x5DAFF40", VA = "0x185DB1140")]
	public KBEMMLPPEPC(IKBNJJBMJGF CFIPHHIMOMK, int JMNJMKJAMOL, Allocator JFLEKJGGDHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0950", Offset = "0x5DAF750", VA = "0x185DB0950")]
	public EOLLFEKBMDA BPEJIPNKAHO()
	{
		return default(EOLLFEKBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB09D0", Offset = "0x5DAF7D0", VA = "0x185DB09D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0A10", Offset = "0x5DAF810", VA = "0x185DB0A10", Slot = "13")]
	public bool Contains(JBMJEBCFLLB PEGAJFMFKFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0AA0", Offset = "0x5DAF8A0", VA = "0x185DB0AA0", Slot = "14")]
	public void CopyTo(JBMJEBCFLLB[] FNIMPMJDPGM, int KOPIDODGMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5DB08D0", Offset = "0x5DAF6D0", VA = "0x185DB08D0", Slot = "11")]
	public void Add(JBMJEBCFLLB PEGAJFMFKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0D00", Offset = "0x5DAFB00", VA = "0x185DB0D00", Slot = "7")]
	public void Insert(int DOJILIOCHKM, JBMJEBCFLLB PEGAJFMFKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0E90", Offset = "0x5DAFC90", VA = "0x185DB0E90", Slot = "15")]
	public bool Remove(JBMJEBCFLLB PEGAJFMFKFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0C70", Offset = "0x5DAFA70", VA = "0x185DB0C70", Slot = "6")]
	public int IndexOf(JBMJEBCFLLB PEGAJFMFKFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0E40", Offset = "0x5DAFC40", VA = "0x185DB0E40", Slot = "8")]
	public void RemoveAt(int DOJILIOCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0C30", Offset = "0x5DAFA30", VA = "0x185DB0C30", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0DB0", Offset = "0x5DAFBB0", VA = "0x185DB0DB0")]
	public PGBKLOHIBPG MIBGMGJFDKE()
	{
		return default(PGBKLOHIBPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0F60", Offset = "0x5DAFD60", VA = "0x185DB0F60", Slot = "16")]
	private IEnumerator<JBMJEBCFLLB> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1050", Offset = "0x5DAFE50", VA = "0x185DB1050", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NLKOBNHNFLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int LFJJMGJIKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> EFEHHOALPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JBMJEBCFLLB IDPAAEDNDJP(JBMJEBCFLLB DJIDJBJMOLC);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JPNPIDPEEGC : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface MGCBGGNJMBI : APDPPALGJBL, KMLKLGKDBAC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool LPLEMOIFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	NBKCLNBDKKE CBMBNJJFGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	JHHOBBMGMJL IHLJFAGFAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NMOMJJDHINP FJFGPNMBHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	JADOFDKKJHN GNGFFADINGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	KHMPNKBJMCM GDNMHGNJJKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface KMLKLGKDBAC
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool NBMNKGOJOAB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface GDDGGLIBMDG
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FIDNIABEBBF(bool GNLEHBFFNFG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface JADOFDKKJHN
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool APBCJOLHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PPIJPAJCPIG;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ICBCKMIIPHK(bool HNEIOJHCMIL);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BHJIAGHHOJI(ByteString GHHJLCMBOHI);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GLIMDIIGBDG();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LPFNIAPEIOJ();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IBBGFGDFFFH();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface NMOMJJDHINP
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	LHNHCAPHDGO CBMBNJJFGJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	JHHOBBMGMJL IHLJFAGFAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	HBMBNCJMDAI ALGMCKADIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	MGCBGGNJMBI GHANKDLFFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	IKBNJJBMJGF OJBGOKBDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	FOLLILJKCFG CBJKAFKIJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	JNPLIBJDOGK GNCACLGHEHI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	DEHDJDPODCF FFCPIKAPOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	MAEKAKNNECM CDIIFGPPIKD
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	MOMEIDDAEBF NPGJMKHHHPO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	FAMDMBCKPIO HCGCMNNEFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	PHJHPLJJLBK BCJGEGDAKEC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	HKANIBGKHCE EPOOLGOBFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	POCKFOBPLKI OMCBFGLHPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	JLJJHKEDFND DGEOMMEHEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	PNFCPLLCHJK LMKOPFMPBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	ILHIPOGALPJ CKKFLLLGKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	BGJEPDMMNIC MMIHJMDBJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	BCDPLEGKDHC COHPGONCHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	IHJBEAAMNEB ODLBANJHKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DebuggerTypeProxy(typeof(JACHBILPENJ))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct JBMJEBCFLLB : IComparable<JBMJEBCFLLB>, IEquatable<JBMJEBCFLLB>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly JBMJEBCFLLB LKJBFPNKADE;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int EOGPLFMCDBC = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int BDMDNNJEGOB = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int LELKKKNLGJP = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int AOBIEJDKMBC = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId OGPPAJOCABK;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IKBNJJBMJGF OJBGOKBDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA300", Offset = "0x5DA9100", VA = "0x185DAA300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LocalId ADBILOOMPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5DB00C0", Offset = "0x5DAEEC0", VA = "0x185DB00C0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	internal KHMPNKBJMCM GDNMHGNJJKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB00B0", Offset = "0x5DAEEB0", VA = "0x185DB00B0")]
		get
		{
			return default(KHMPNKBJMCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HCAMIAJDHEM
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0100", Offset = "0x5DAEF00", VA = "0x185DB0100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool LKAKBECIGCK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFE00", Offset = "0x5DAEC00", VA = "0x185DAFE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool JHMEDMFNFLK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0060", Offset = "0x5DAEE60", VA = "0x185DB0060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0430", Offset = "0x5DAF230", VA = "0x185DB0430")]
	public JBMJEBCFLLB(IKBNJJBMJGF EFIMCPNLNJC, LocalId OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
	public ECLMNCPCDJH NPPCJFNDGKG()
	{
		return default(ECLMNCPCDJH);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0020", Offset = "0x5DAEE20", VA = "0x185DB0020")]
	public static LocalId FMKGPFEKDFI(JBMJEBCFLLB ABIPFIFBKIP)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5DAFFE0", Offset = "0x5DAEDE0", VA = "0x185DAFFE0")]
	public static Entity FMKGPFEKDFI(JBMJEBCFLLB ABIPFIFBKIP)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5DB01E0", Offset = "0x5DAEFE0", VA = "0x185DB01E0")]
	public static bool NOLBLOCHCOA(JBMJEBCFLLB MACGGKMNKNM, JBMJEBCFLLB JHKDDIMPPGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC580", Offset = "0x5DAB380", VA = "0x185DAC580")]
	public static bool BPHGJPBDHAH(JBMJEBCFLLB MACGGKMNKNM, JBMJEBCFLLB JHKDDIMPPGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0300", Offset = "0x5DAF100", VA = "0x185DB0300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5DAFE50", Offset = "0x5DAEC50", VA = "0x185DAFE50", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5DAFD20", Offset = "0x5DAEB20", VA = "0x185DAFD20", Slot = "4")]
	public int CompareTo(JBMJEBCFLLB MFMJJEFODHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "5")]
	public bool Equals(JBMJEBCFLLB MFMJJEFODHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class IGPONBMBKCF
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5DAFBA0", Offset = "0x5DAE9A0", VA = "0x185DAFBA0")]
	public static DJMPNJEFEHC FKGNNMHAONN(this JBMJEBCFLLB HBDENJGMDDF)
	{
		return default(DJMPNJEFEHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x2399D50", Offset = "0x2398B50", VA = "0x182399D50")]
	public static T LKLFMILIDDD<T>(this JBMJEBCFLLB HBDENJGMDDF) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal sealed class JACHBILPENJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct KHMPNKBJMCM : IEquatable<KHMPNKBJMCM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte KMOBDGPHBOK;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] OBGOLLJIMAP;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static IKBNJJBMJGF FAMMDDAMFLM;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static MGCBGGNJMBI HBNKOBKBABG;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static IKBNJJBMJGF[] JPPPNABBDEL;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static MGCBGGNJMBI[] HDLGIJMNOFK;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static int BLNECCPPFJA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IKBNJJBMJGF MKJPIMEACBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5DB1660", Offset = "0x5DB0460", VA = "0x185DB1660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB20C0", Offset = "0x5DB0EC0", VA = "0x185DB20C0")]
	static KHMPNKBJMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xB2E170", Offset = "0xB2CF70", VA = "0x180B2E170")]
	internal KHMPNKBJMCM(byte GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x50AD960", Offset = "0x50AC760", VA = "0x1850AD960", Slot = "4")]
	public bool Equals(KHMPNKBJMCM MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB15C0", Offset = "0x5DB03C0", VA = "0x185DB15C0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x18F63F0", Offset = "0x18F51F0", VA = "0x1818F63F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2000", Offset = "0x5DB0E00", VA = "0x185DB2000", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1C60", Offset = "0x5DB0A60", VA = "0x185DB1C60")]
	private static IKBNJJBMJGF ONCEMMIFCIG(byte KMOBDGPHBOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1440", Offset = "0x5DB0240", VA = "0x185DB1440")]
	private static object AIGJJEMGIJL(byte KMOBDGPHBOK, object[] HJOJMOBKMOL, object HEDIGKLLBHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1D10", Offset = "0x5DB0B10", VA = "0x185DB1D10")]
	private static int PCGHMBNENOA(byte KMOBDGPHBOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1740", Offset = "0x5DB0540", VA = "0x185DB1740")]
	private static int ILLBNGMBDLH(byte KMOBDGPHBOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1930", Offset = "0x5DB0730", VA = "0x185DB1930")]
	private static (int, int) KMLBOKOMJAG(byte KMOBDGPHBOK)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5DB15B0", Offset = "0x5DB03B0", VA = "0x185DB15B0")]
	private static byte EFHNEKFNFGJ(int KCPGKFKLEJL, int DOJILIOCHKM)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5DB19B0", Offset = "0x5DB07B0", VA = "0x185DB19B0")]
	internal static KHMPNKBJMCM MCJJKKHGDCC(MGCBGGNJMBI CLGGHKJADNB, IKBNJJBMJGF OHBJBALPNDM)
	{
		return default(KHMPNKBJMCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1750", Offset = "0x5DB0550", VA = "0x185DB1750")]
	internal static void JKGGMKNLLFM(KHMPNKBJMCM KMOBDGPHBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1D20", Offset = "0x5DB0B20", VA = "0x185DB1D20")]
	private static void PPPHPBEDMMJ(int DECKGNHFLHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface LJMLIKCJBGD
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ECJKDKGMAIP();

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LNGCMNODMKD(bool KOCFLNADIAJ);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GLNKGFLEIJD(GameObject DEGGPBGPMDB);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface HEBAFELDAAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	Guid IEFJDIHCPEP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task OKNJLFHOBIG(Guid BFNBIEDGJOG, Guid ONKJMHJONKH);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task MDHLHAIDDED(JBMJEBCFLLB NBIONNEGCEN);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EHBIEAJGHEE(JBMJEBCFLLB FKKAOLHJCBE, JBMJEBCFLLB LBLLNFOEKNE, [Out] Vector3 AIEJDLEEMCB, [Out] Quaternion KAHMHDLHHJI);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ABHJIAONIDC(KJEDHMGGDOO MFCEOOPNPCD, Vector3 AIEJDLEEMCB, Quaternion KAHMHDLHHJI);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface IBOMJCPFPBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EOPGOBOBHFC(EOLLFEKBMDA DJIDJBJMOLC);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 JDAOKOPJKII(GameObject DEGGPBGPMDB, int HBFEFKLBKOE);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface JHHOBBMGMJL
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	LJMLIKCJBGD CFEHPIOIMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	ELICKPPOGGA AKGBOHJKIOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	MFEFBFNBPNO FHEMMGCLFHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	CENEGDPHJKH JAIDGMBANJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	GHMFBCIFKGP MNPKDMPOKIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	HLMBCPKELME BOIJLKCOKOB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	PEAALCEGOHC AJIDOCBGJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	KPIPKBHPNOA NGKBECMKJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface EGFIAOKIMAI
{
	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MOKEFCIJAEH(Action HMHDIIODGFG, bool AAAMOCNCFFL);

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CABCOBBMIKJ(string ONIBECKLJDD);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface ELICKPPOGGA
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	string MOMNKENPBFB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] BCAHHBKHCOE(IEnumerable<ELKMOGAHBJM> JLIAKEMOOFF);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DJMPNJEFEHC FHFEJCIMBEN(Guid JOJENOEEIEC);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NMBDOKELFKK(GameObject DEGGPBGPMDB, [Out] DJMPNJEFEHC IELEJBMANDO);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool GDMBDOLIMMK(GameObject DEGGPBGPMDB, [Out] int MHAOEJNOPIG, [Out] FMJMJJHCMAN CMNEDOHOKIA);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KMILLOLJKJL CBBNCFBBBGB(ELKMOGAHBJM GDHOLDPNHCL);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KMILLOLJKJL CBBNCFBBBGB(string KNKKDNJPFFO, DJMPNJEFEHC IELEJBMANDO, Vector3 AILFIIEAPKM, Quaternion GIBIBDOGOLL, Vector3 GBJGBGCFEKM);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BNLNCFEGHFC(GameObject MMBPPGGFKDD, bool JHIOODBNMMI);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PKKIOAPKGAL(GameObject DEGGPBGPMDB, bool JGBDIEFNNFB, bool FILCELEFOOB);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class DAPMLHLHMAE
{
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5DABFC0", Offset = "0x5DAADC0", VA = "0x185DABFC0")]
	public static KMILLOLJKJL CBBNCFBBBGB(this ELICKPPOGGA EILPDJCOMNG, DJMPNJEFEHC IELEJBMANDO, Vector3 AILFIIEAPKM, Quaternion GIBIBDOGOLL, Vector3 GBJGBGCFEKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface MFEFBFNBPNO
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGAIHOIFEGI(bool HNEIOJHCMIL);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface CENEGDPHJKH
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool LKLFFJGHAOG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool NKIKMACLCBG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool AGCHICFABOA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	bool MDBMNBBIMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HDKJAJHAOOM(object JPGMJABDIAJ);

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ACBBHNPFCMH(object CJKEIGLKDDB);

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IMPMHGJHKAA(object CJKEIGLKDDB);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int BJLJIFDLDMM(GameObject FJNLKHDMLBO);

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JKBBIFNPGJN(NativeArray<int> AJNNPPHEICK);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface GHMFBCIFKGP
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PGAACGFDGCJ(GameObject DEGGPBGPMDB);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface DPKMGAFCFKE
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEPPDOMDELG(string JIGBFCEILIK);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface FPJFHPMDDGC
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CLHIILAKEMM(GameObject DEGGPBGPMDB);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BAEJKBCOLGF(GameObject DEGGPBGPMDB);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object DKHLELLIHNI(JBMJEBCFLLB OGPPAJOCABK, GameObject DEGGPBGPMDB, Action<JBMJEBCFLLB, int> MEKLMIFMFCO);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MLHEIOPOLLK(GameObject DEGGPBGPMDB, object LHJDMBLMHGD);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface HLMBCPKELME
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	int CFACCLHHPHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int GNGNFICPCFI(GameObject DEGGPBGPMDB);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KBCCPGIAIMH([Out] Vector3 AILFIIEAPKM);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JMMBOCGEFCF();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface PEAALCEGOHC
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool APBCJOLHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool ABBBICBMKAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface LCDCAHKPFOP
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	JFNOFFPCHGI KNNPHHPCGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	FFKIOFMMKBN DACMGJMBADA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHNOGOJELCL(Transform GNLAIPIBJPM);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IIIPPMBJCJI(Transform GNLAIPIBJPM, OGFNAEOOEJF INKFJIBFDAL);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AGAGMLMMCBC(Transform GNLAIPIBJPM, NBDHLNCBJFN ABJDJAMBLGG);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface KPIPKBHPNOA
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHBECPMCDMM();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface MBCPGIKDGBD
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JJGBHGOFNMP();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface CDNOLOGJCIN
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FMJMJJHCMAN PIEIOOAMGLM(GameObject FJNLKHDMLBO);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KGMFBFMNAFD(GameObject DEGGPBGPMDB, LDPKFFBAGIL FLDNNGDLMMF, PCNANKKHLJH MCGACFHJKFA);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct APGJDELAIAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly BHJLBLMAAPD KMFMMHANJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly BHJLBLMAAPD MCKBHHHCKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint FEJFFJKAFKJ;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB2F0", Offset = "0x5DAA0F0", VA = "0x185DAB2F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct CPBECABNIFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly APGJDELAIAO HMHDIIODGFG;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5DABF20", Offset = "0x5DAAD20", VA = "0x185DABF20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct JNBOKHHHIGD
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly APGJDELAIAO HMHDIIODGFG;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DABF20", Offset = "0x5DAAD20", VA = "0x185DABF20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct BDBMLOABHLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint FEJFFJKAFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool OGGBJBJBOKE;

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB5E0", Offset = "0x5DAA3E0", VA = "0x185DAB5E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct BHJLBLMAAPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int HLAIJKBFIJH;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB680", Offset = "0x5DAA480", VA = "0x185DAB680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface FBOBNFEAFHM
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	CJCPHFLMKPA PLMOLKMJCHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum CCPMDEBLILB
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
public interface KMILLOLJKJL : NMECIDJANKG
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	CCPMDEBLILB IIKNEOJFJGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool FHPHKMHFNDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	GameObject DEGGPBGPMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KMILLOLJKJL> CKIMNNAAMBM;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(HBMBNCJMDAI GICLKIIJBDC, JBMJEBCFLLB CMCJHNENJPD);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool KKAOOHAOFJN);

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class KNPMNKBDPKJ
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3330", Offset = "0x5DB2130", VA = "0x185DB3330")]
	public static bool PIACKBAOBEI(this KMILLOLJKJL MENCLGMKPHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DB32E0", Offset = "0x5DB20E0", VA = "0x185DB32E0")]
	public static bool PGKHDDCKPIP(this KMILLOLJKJL MENCLGMKPHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3200", Offset = "0x5DB2000", VA = "0x185DB3200")]
	public static bool ELIJJLNCBKA(this KMILLOLJKJL MENCLGMKPHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3250", Offset = "0x5DB2050", VA = "0x185DB3250")]
	public static bool LPLEMOIFKPC(this KMILLOLJKJL MENCLGMKPHE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface NMECIDJANKG
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	bool KADIPLBDHPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	JBMJEBCFLLB OBEGLAOMPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
internal interface GCDKFGEHHBL
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<POEBJJFCPOJ> DCJMCAACAJG;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface LPNKEHLCEHF : IPPDBGPKNLI<DJMPNJEFEHC>, GKFLMNEBMJA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface LPOILOOPBIK<T> : BMNAKPOHAKD<DJMPNJEFEHC, T>, IPPDBGPKNLI<DJMPNJEFEHC>, GKFLMNEBMJA, IDisposable, LPNKEHLCEHF where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class OHFPCPFEDDN
{
	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x24F17C0", Offset = "0x24F05C0", VA = "0x1824F17C0")]
	public static bool COFEFJFFGMK<T>(this IPPDBGPKNLI<DJMPNJEFEHC> GGCGADADFCH, DJMPNJEFEHC IELEJBMANDO, [Out] T GNLEHBFFNFG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x24F17E0", Offset = "0x24F05E0", VA = "0x1824F17E0")]
	public static bool KLJMIKDFPBF<T>(this IPPDBGPKNLI<DJMPNJEFEHC> GGCGADADFCH, DJMPNJEFEHC IELEJBMANDO, [In] T LEDLLMJPAFI) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface OEEJKPJCCOP : IPPDBGPKNLI<JBMJEBCFLLB>, GKFLMNEBMJA, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface HLOLALCBGEB<T> : BMNAKPOHAKD<JBMJEBCFLLB, T>, IPPDBGPKNLI<JBMJEBCFLLB>, GKFLMNEBMJA, IDisposable, OEEJKPJCCOP where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DNAHDBELOID
{
	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x21F0080", Offset = "0x21EEE80", VA = "0x1821F0080")]
	public static T OMJIHOMPBMI<T>(this IPPDBGPKNLI<JBMJEBCFLLB> GGCGADADFCH, JBMJEBCFLLB OGPPAJOCABK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x21FA940", Offset = "0x21F9740", VA = "0x1821FA940")]
	public static bool KLJMIKDFPBF<T>(this IPPDBGPKNLI<JBMJEBCFLLB> GGCGADADFCH, JBMJEBCFLLB OGPPAJOCABK, [In] T LEDLLMJPAFI) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct KIBKAPDMHFC : IComparable<KIBKAPDMHFC>, IEquatable<KIBKAPDMHFC>
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly KIBKAPDMHFC LKJBFPNKADE;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly KIBKAPDMHFC LOLHPIIPICI;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly KIBKAPDMHFC HADBDBONJIH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly KIBKAPDMHFC HDFNMEPEMGF;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly KIBKAPDMHFC HDPCNNLNCKI;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly KIBKAPDMHFC HLLOJMHJOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int CPCFHDJMLHI;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool HAHEOHNCNCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5DB21C0", Offset = "0x5DB0FC0", VA = "0x185DB21C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public int OAKAFPEBABP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5DB20D0", Offset = "0x5DB0ED0", VA = "0x185DB20D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7F1B50", Offset = "0x7F0950", VA = "0x1807F1B50")]
	public KIBKAPDMHFC(int DOJILIOCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2160", Offset = "0x5DB0F60", VA = "0x185DB2160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5DB20E0", Offset = "0x5DB0EE0", VA = "0x185DB20E0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x161D6C0", Offset = "0x161C4C0", VA = "0x18161D6C0", Slot = "5")]
	public bool Equals(KIBKAPDMHFC MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x162C040", Offset = "0x162AE40", VA = "0x18162C040", Slot = "4")]
	public int CompareTo(KIBKAPDMHFC MFMJJEFODHB)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0xBBA660", Offset = "0xBB9460", VA = "0x180BBA660")]
	public static KIBKAPDMHFC FMKGPFEKDFI(int DOJILIOCHKM)
	{
		return default(KIBKAPDMHFC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0xBBA660", Offset = "0xBB9460", VA = "0x180BBA660")]
	public static int FMKGPFEKDFI(KIBKAPDMHFC NLJCIKGMHGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5DB21D0", Offset = "0x5DB0FD0", VA = "0x185DB21D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct ECLMNCPCDJH : IEquatable<ECLMNCPCDJH>, NMECIDJANKG
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly ECLMNCPCDJH PIBEOMIKLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JBMJEBCFLLB OBEGLAOMPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0", Slot = "6")]
		get
		{
			return default(JBMJEBCFLLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public LBMEFDDHLNC HFGEDEDEGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(LBMEFDDHLNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public MOKBLCNOPOO CBJKAFKIJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(MOKBLCNOPOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private IKBNJJBMJGF OJBGOKBDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA300", Offset = "0x5DA9100", VA = "0x185DAA300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public GameObject DEGGPBGPMDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC660", Offset = "0x5DAB460", VA = "0x185DAC660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public DJMPNJEFEHC PLIKOGILGOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5DACAB0", Offset = "0x5DAB8B0", VA = "0x185DACAB0")]
		get
		{
			return default(DJMPNJEFEHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public IBDEBMIBBIB MNBAMOAIIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC3A0", Offset = "0x5DAB1A0", VA = "0x185DAC3A0")]
		get
		{
			return default(IBDEBMIBBIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public FMJMJJHCMAN JGOHNLFDHPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC5C0", Offset = "0x5DAB3C0", VA = "0x185DAC5C0")]
		get
		{
			return default(FMJMJJHCMAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool AAKIIEIODKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5DACA20", Offset = "0x5DAB820", VA = "0x185DACA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool ILCHFLAFDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5DACDA0", Offset = "0x5DABBA0", VA = "0x185DACDA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool BIFFBPKCPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC8C0", Offset = "0x5DAB6C0", VA = "0x185DAC8C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool LPAPCEPBICM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5DACA90", Offset = "0x5DAB890", VA = "0x185DACA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool NDDPLEHKFGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC5A0", Offset = "0x5DAB3A0", VA = "0x185DAC5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool OKLDDJOIJCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC880", Offset = "0x5DAB680", VA = "0x185DAC880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool CFBNFFJDLMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC8E0", Offset = "0x5DAB6E0", VA = "0x185DAC8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public AFIFACGNBIN NPGFEJPIHEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(AFIFACGNBIN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public PEEKNEMMFJB JDHBILBCLNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(PEEKNEMMFJB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public AHHGGHKABCL EPOOLGOBFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(AHHGGHKABCL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public PBFFBOKMKBL FMPPAABJDEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(PBFFBOKMKBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public ACJJIMKJFDA BCJGEGDAKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ACJJIMKJFDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public KACDBGJGHKC JMBJIHCJHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(KACDBGJGHKC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public KJEDHMGGDOO FNDKKJJCFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(KJEDHMGGDOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool PIACKBAOBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC490", Offset = "0x5DAB290", VA = "0x185DAC490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool HAJHAAPADFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5DACC40", Offset = "0x5DABA40", VA = "0x185DACC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private bool GEOBKFPIOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public ECLMNCPCDJH(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA360", Offset = "0x5DA9160", VA = "0x185DAA360")]
	public static bool FMKGPFEKDFI(ECLMNCPCDJH GNLEHBFFNFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
	public static JBMJEBCFLLB FMKGPFEKDFI(ECLMNCPCDJH GNLEHBFFNFG)
	{
		return default(JBMJEBCFLLB);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5DACD90", Offset = "0x5DABB90", VA = "0x185DACD90")]
	public static bool NOLBLOCHCOA(ECLMNCPCDJH MACGGKMNKNM, ECLMNCPCDJH JHKDDIMPPGN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC580", Offset = "0x5DAB380", VA = "0x185DAC580")]
	public static bool BPHGJPBDHAH(ECLMNCPCDJH MACGGKMNKNM, ECLMNCPCDJH JHKDDIMPPGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC7F0", Offset = "0x5DAB5F0", VA = "0x185DAC7F0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(ECLMNCPCDJH MFMJJEFODHB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
	public static ECLMNCPCDJH FMKGPFEKDFI(JBMJEBCFLLB HAIBOLAMIBL)
	{
		return default(ECLMNCPCDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC440", Offset = "0x5DAB240", VA = "0x185DAC440")]
	public GMKHMIPPILJ ALJFGGGPMKN()
	{
		return default(GMKHMIPPILJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC9F0", Offset = "0x5DAB7F0", VA = "0x185DAC9F0")]
	public HODPBNEOBHC IFDDFCLDEIF()
	{
		return default(HODPBNEOBHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DACA40", Offset = "0x5DAB840", VA = "0x185DACA40")]
	public KMGAICBJFML IIEEMIIPFBA()
	{
		return default(KMGAICBJFML);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5DACC80", Offset = "0x5DABA80", VA = "0x185DACC80")]
	public void MEMNMGJANNO([Optional] object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC900", Offset = "0x5DAB700", VA = "0x185DAC900")]
	public bool HKNOPCPJEPF(object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5DACB50", Offset = "0x5DAB950", VA = "0x185DACB50")]
	public bool LDOHKGPKLNJ(object PFKLELGAJPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5DACDC0", Offset = "0x5DABBC0", VA = "0x185DACDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct KJEDHMGGDOO : IEquatable<KJEDHMGGDOO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public JBMJEBCFLLB OBEGLAOMPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(JBMJEBCFLLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private IKBNJJBMJGF OJBGOKBDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA300", Offset = "0x5DA9100", VA = "0x185DAA300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	private NMOMJJDHINP FJFGPNMBHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5DB24C0", Offset = "0x5DB12C0", VA = "0x185DB24C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private PNFCPLLCHJK EDGOHAEOCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2790", Offset = "0x5DB1590", VA = "0x185DB2790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool HNCCOEIJFOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2430", Offset = "0x5DB1230", VA = "0x185DB2430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public Guid GEHHCNKONMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2B70", Offset = "0x5DB1970", VA = "0x185DB2B70")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool IHKKIGALKIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2550", Offset = "0x5DB1350", VA = "0x185DB2550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Guid JHAMFEJEHPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2910", Offset = "0x5DB1710", VA = "0x185DB2910")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public KJEDHMGGDOO(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA360", Offset = "0x5DA9160", VA = "0x185DAA360")]
	public static bool FMKGPFEKDFI(KJEDHMGGDOO GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB25E0", Offset = "0x5DB13E0", VA = "0x185DB25E0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(KJEDHMGGDOO MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2AD0", Offset = "0x5DB18D0", VA = "0x185DB2AD0")]
	public bool NHIBNJLLPFN([Out] Guid JLBBMGLDMCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2670", Offset = "0x5DB1470", VA = "0x185DB2670")]
	public void FGAMPHDBOOH(Guid AACJDNHHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2A30", Offset = "0x5DB1830", VA = "0x185DB2A30")]
	public bool KKIKEPLPJBP([Out] Guid HPBOKIMIODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB27F0", Offset = "0x5DB15F0", VA = "0x185DB27F0")]
	public void JLFJOPFBMPN(Guid AACJDNHHIME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB23A0", Offset = "0x5DB11A0", VA = "0x185DB23A0")]
	public void AAIKOHIJOHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct KMGAICBJFML : IEquatable<KMGAICBJFML>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public JBMJEBCFLLB OBEGLAOMPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(JBMJEBCFLLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private IKBNJJBMJGF OJBGOKBDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA300", Offset = "0x5DA9100", VA = "0x185DAA300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private NMOMJJDHINP FJFGPNMBHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2DA0", Offset = "0x5DB1BA0", VA = "0x185DB2DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private ILHIPOGALPJ HEKJJGGLPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3070", Offset = "0x5DB1E70", VA = "0x185DB3070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public float3 MDCKPBJECAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5DB30D0", Offset = "0x5DB1ED0", VA = "0x185DB30D0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public quaternion DLBFMGCGPHF
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2EC0", Offset = "0x5DB1CC0", VA = "0x185DB2EC0")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public ECLMNCPCDJH LIALGAHBDBF
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB2FE0", Offset = "0x5DB1DE0", VA = "0x185DB2FE0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public KMGAICBJFML(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
	public static JBMJEBCFLLB FMKGPFEKDFI(KMGAICBJFML GNLEHBFFNFG)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2E30", Offset = "0x5DB1C30", VA = "0x185DB2E30", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(KMGAICBJFML MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct GMKHMIPPILJ : IEquatable<GMKHMIPPILJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly GMKHMIPPILJ PIBEOMIKLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public JBMJEBCFLLB OBEGLAOMPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(JBMJEBCFLLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public LBMEFDDHLNC HFGEDEDEGAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(LBMEFDDHLNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public MOKBLCNOPOO CBJKAFKIJMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(MOKBLCNOPOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private IKBNJJBMJGF OJBGOKBDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA300", Offset = "0x5DA9100", VA = "0x185DAA300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private NMOMJJDHINP FJFGPNMBHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE490", Offset = "0x5DAD290", VA = "0x185DAE490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private FOLLILJKCFG EPNGNACDELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF1E0", Offset = "0x5DADFE0", VA = "0x185DAF1E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public EOLLFEKBMDA FNKGAEAEPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE750", Offset = "0x5DAD550", VA = "0x185DAE750")]
		get
		{
			return default(EOLLFEKBMDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public IEnumerable<ECLMNCPCDJH> CAINKDIPLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE190", Offset = "0x5DACF90", VA = "0x185DAE190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public IEnumerable<ECLMNCPCDJH> AOCPDODKONJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEE70", Offset = "0x5DADC70", VA = "0x185DAEE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int HJKPNMLOCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEFA0", Offset = "0x5DADDA0", VA = "0x185DAEFA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int PIDAAEAPIGB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE370", Offset = "0x5DAD170", VA = "0x185DAE370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public string KKCKMDALLNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEC60", Offset = "0x5DADA60", VA = "0x185DAEC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public KJMNOPEJLKJ NEGIJLPOFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5DAED10", Offset = "0x5DADB10", VA = "0x185DAED10")]
		get
		{
			return default(KJMNOPEJLKJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5DAED70", Offset = "0x5DADB70", VA = "0x185DAED70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public LCBPDIKJNPN EEIINGLGJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE600", Offset = "0x5DAD400", VA = "0x185DAE600")]
		get
		{
			return default(LCBPDIKJNPN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE590", Offset = "0x5DAD390", VA = "0x185DAE590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool KPDOGFCANDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE3C0", Offset = "0x5DAD1C0", VA = "0x185DAE3C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public bool POAFIFBCFMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEBF0", Offset = "0x5DAD9F0", VA = "0x185DAEBF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public bool KBMKDPNJAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE880", Offset = "0x5DAD680", VA = "0x185DAE880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool CBPDHDCBPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE300", Offset = "0x5DAD100", VA = "0x185DAE300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool DAEIOPFJGHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE430", Offset = "0x5DAD230", VA = "0x185DAE430")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE520", Offset = "0x5DAD320", VA = "0x185DAE520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool LCOMIIOCFGH
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5DAE660", Offset = "0x5DAD460", VA = "0x185DAE660")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5DAEDE0", Offset = "0x5DADBE0", VA = "0x185DAEDE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public GMKHMIPPILJ(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA360", Offset = "0x5DA9160", VA = "0x185DAA360")]
	public static bool FMKGPFEKDFI(GMKHMIPPILJ GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE6C0", Offset = "0x5DAD4C0", VA = "0x185DAE6C0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(GMKHMIPPILJ MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0xA21CF0", Offset = "0xA20AF0", VA = "0x180A21CF0")]
	public static ECLMNCPCDJH FMKGPFEKDFI(GMKHMIPPILJ NFDHIFFHPGD)
	{
		return default(ECLMNCPCDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEE50", Offset = "0x5DADC50", VA = "0x185DAEE50")]
	public bool NCNOPIJJNLJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE810", Offset = "0x5DAD610", VA = "0x185DAE810")]
	public bool HGMMPNFCIAL(DNCLPBDFMLC CBPCLKCPMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAEB70", Offset = "0x5DAD970", VA = "0x185DAEB70")]
	public void IACONOGFDMP(DNCLPBDFMLC CBPCLKCPMML, bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF030", Offset = "0x5DADE30", VA = "0x185DAF030")]
	public EOLLFEKBMDA PKFFHJBAJBE(Allocator JFLEKJGGDHL)
	{
		return default(EOLLFEKBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE8F0", Offset = "0x5DAD6F0", VA = "0x185DAE8F0")]
	public void HPDPOFHCCOD(GMKHMIPPILJ MFMJJEFODHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct GNBELMPCJEC : IEquatable<GNBELMPCJEC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF240", Offset = "0x5DAE040", VA = "0x185DAF240", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(GNBELMPCJEC MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct PEEKNEMMFJB : IEquatable<PEEKNEMMFJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private IKBNJJBMJGF OJBGOKBDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA300", Offset = "0x5DA9100", VA = "0x185DAA300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public PEEKNEMMFJB(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB87F0", Offset = "0x5DB75F0", VA = "0x185DB87F0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(PEEKNEMMFJB MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8880", Offset = "0x5DB7680", VA = "0x185DB8880")]
	public void OKHJEEBGOJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8750", Offset = "0x5DB7550", VA = "0x185DB8750")]
	public void CGMMBIMCGNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct CBEEMJBKCNA : IEquatable<CBEEMJBKCNA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB830", Offset = "0x5DAA630", VA = "0x185DAB830", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(CBEEMJBKCNA MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct IMHABEFOHID : IEquatable<IMHABEFOHID>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5DAFC90", Offset = "0x5DAEA90", VA = "0x185DAFC90", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(IMHABEFOHID MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct JBNCECBGANL : IEquatable<JBNCECBGANL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0570", Offset = "0x5DAF370", VA = "0x185DB0570", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(JBNCECBGANL MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct AFILJFFEEMP : IEquatable<AFILJFFEEMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB060", Offset = "0x5DA9E60", VA = "0x185DAB060", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(AFILJFFEEMP MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct MOKBLCNOPOO : IEquatable<MOKBLCNOPOO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public JBMJEBCFLLB OBEGLAOMPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(JBMJEBCFLLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	private IKBNJJBMJGF OJBGOKBDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA300", Offset = "0x5DA9100", VA = "0x185DAA300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private NMOMJJDHINP FJFGPNMBHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6200", Offset = "0x5DB5000", VA = "0x185DB6200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private FOLLILJKCFG EPNGNACDELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5DB66A0", Offset = "0x5DB54A0", VA = "0x185DB66A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public JBMJEBCFLLB LJJEINDDDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6580", Offset = "0x5DB5380", VA = "0x185DB6580")]
		get
		{
			return default(JBMJEBCFLLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public ECLMNCPCDJH ADEHKCCOJGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6290", Offset = "0x5DB5090", VA = "0x185DB6290")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public ECLMNCPCDJH DKBLNPELKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6610", Offset = "0x5DB5410", VA = "0x185DB6610")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public MOKBLCNOPOO(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6320", Offset = "0x5DB5120", VA = "0x185DB6320", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(MOKBLCNOPOO MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6450", Offset = "0x5DB5250", VA = "0x185DB6450")]
	public bool HDGBCFAMPCN(ECLMNCPCDJH LBLLNFOEKNE, bool CANHJIIKAKN = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5DB63B0", Offset = "0x5DB51B0", VA = "0x185DB63B0")]
	public bool FOIIPDKECAK(ECLMNCPCDJH IKGHEPBMABE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct AFIFACGNBIN : IEquatable<AFIFACGNBIN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public string JDBNGHCMKPA
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x5DAAB80", Offset = "0x5DA9980", VA = "0x185DAAB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public string NIFMGFCEKCK
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x5DAAF80", Offset = "0x5DA9D80", VA = "0x185DAAF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public AFIFACGNBIN(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAF0", Offset = "0x5DA98F0", VA = "0x185DAAAF0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(AFIFACGNBIN MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct FODELGMGCNF : IEquatable<FODELGMGCNF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5DADBF0", Offset = "0x5DAC9F0", VA = "0x185DADBF0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(FODELGMGCNF MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct AHHGGHKABCL : IEquatable<AHHGGHKABCL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public AHHGGHKABCL(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB260", Offset = "0x5DAA060", VA = "0x185DAB260", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(AHHGGHKABCL MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB0F0", Offset = "0x5DA9EF0", VA = "0x185DAB0F0")]
	public bool DONJPEPHIPP([Out] Collider BHBBEPIOBCA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct PBFFBOKMKBL : IEquatable<PBFFBOKMKBL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public JBMJEBCFLLB OBEGLAOMPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(JBMJEBCFLLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private IKBNJJBMJGF OJBGOKBDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA300", Offset = "0x5DA9100", VA = "0x185DAA300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	private NMOMJJDHINP FJFGPNMBHDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7970", Offset = "0x5DB6770", VA = "0x185DB7970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private EEMEJDNEGLD GLAEGAGILOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7D60", Offset = "0x5DB6B60", VA = "0x185DB7D60")]
		get
		{
			return default(EEMEJDNEGLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool INMKABOHIOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8210", Offset = "0x5DB7010", VA = "0x185DB8210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool BCAJFBECIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8670", Offset = "0x5DB7470", VA = "0x185DB8670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool IPMEHAMPIGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x5DB81A0", Offset = "0x5DB6FA0", VA = "0x185DB81A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool PEBIOLDBNIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8500", Offset = "0x5DB7300", VA = "0x185DB8500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool DIDIACFGMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7F10", Offset = "0x5DB6D10", VA = "0x185DB7F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool AOJKDCIKIOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7E30", Offset = "0x5DB6C30", VA = "0x185DB7E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool JEKDAJLCJPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5DB86E0", Offset = "0x5DB74E0", VA = "0x185DB86E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool DIFGINNEDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7890", Offset = "0x5DB6690", VA = "0x185DB7890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool OEMOCHAAJML
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7EA0", Offset = "0x5DB6CA0", VA = "0x185DB7EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool BKMGGGAJCOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7FE0", Offset = "0x5DB6DE0", VA = "0x185DB7FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool DELKHOLBDFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x5DB80C0", Offset = "0x5DB6EC0", VA = "0x185DB80C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool LMENPEGLBND
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7B40", Offset = "0x5DB6940", VA = "0x185DB7B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool LIJFFBIMDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7CF0", Offset = "0x5DB6AF0", VA = "0x185DB7CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool IOKEGNKCKHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7DC0", Offset = "0x5DB6BC0", VA = "0x185DB7DC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool ANMLONKNDHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7A00", Offset = "0x5DB6800", VA = "0x185DB7A00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8050", Offset = "0x5DB6E50", VA = "0x185DB8050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool GPFGCGCFKNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8330", Offset = "0x5DB7130", VA = "0x185DB8330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public PCNANKKHLJH NMPHNLIPHJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7F80", Offset = "0x5DB6D80", VA = "0x185DB7F80")]
		get
		{
			return default(PCNANKKHLJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool EKMDPPFGJPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8250", Offset = "0x5DB7050", VA = "0x185DB8250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public Vector3 AJOCEPDHKBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7A70", Offset = "0x5DB6870", VA = "0x185DB7A70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public Vector3 LAPPGJOCEBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7C40", Offset = "0x5DB6A40", VA = "0x185DB7C40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool GJPOHFEHAGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x5DB8570", Offset = "0x5DB7370", VA = "0x185DB8570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public PBFFBOKMKBL(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7BB0", Offset = "0x5DB69B0", VA = "0x185DB7BB0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(PBFFBOKMKBL MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7900", Offset = "0x5DB6700", VA = "0x185DB7900")]
	public bool BLICLMKHBIL(GLALILOLCDJ CBPCLKCPMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8130", Offset = "0x5DB6F30", VA = "0x185DB8130")]
	public bool JJKDDPFLJAA(LDPKFFBAGIL CBPCLKCPMML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5DB82B0", Offset = "0x5DB70B0", VA = "0x185DB82B0")]
	public void MKKNJEACHPJ(LDPKFFBAGIL CBPCLKCPMML, bool CLDLJEEKFBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct KACDBGJGHKC : IEquatable<KACDBGJGHKC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public JBMJEBCFLLB OBEGLAOMPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(JBMJEBCFLLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	private IKBNJJBMJGF OJBGOKBDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA300", Offset = "0x5DA9100", VA = "0x185DAA300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private NMOMJJDHINP FJFGPNMBHDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5DB0690", Offset = "0x5DAF490", VA = "0x185DB0690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public KACDBGJGHKC(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DB07B0", Offset = "0x5DAF5B0", VA = "0x185DB07B0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(KACDBGJGHKC MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0720", Offset = "0x5DAF520", VA = "0x185DB0720")]
	public void EDPGOEDGMCL(bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5DB0840", Offset = "0x5DAF640", VA = "0x185DB0840")]
	public void GCOHMEAEJFA(bool GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x23F1AE0", Offset = "0x23F08E0", VA = "0x1823F1AE0")]
	public T LANCPCHFCFB<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct ACJJIMKJFDA : IEquatable<ACJJIMKJFDA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public JBMJEBCFLLB OBEGLAOMPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(JBMJEBCFLLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private IKBNJJBMJGF OJBGOKBDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA300", Offset = "0x5DA9100", VA = "0x185DAA300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private NMOMJJDHINP FJFGPNMBHDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA030", Offset = "0x5DA8E30", VA = "0x185DAA030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	private PHJHPLJJLBK BJAAGJBCOKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA7A0", Offset = "0x5DA95A0", VA = "0x185DAA7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool AALPPKOGDBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5DA9FA0", Offset = "0x5DA8DA0", VA = "0x185DA9FA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool ICOICENKJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA920", Offset = "0x5DA9720", VA = "0x185DAA920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool GCHPKONAIBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA0C0", Offset = "0x5DA8EC0", VA = "0x185DAA0C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool DAILIGBFOOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA630", Offset = "0x5DA9430", VA = "0x185DAA630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool CJCBPKALELG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5DA9F10", Offset = "0x5DA8D10", VA = "0x185DA9F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public bool BBNABIBNFHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA380", Offset = "0x5DA9180", VA = "0x185DAA380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public bool MMMJBBMPMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA190", Offset = "0x5DA8F90", VA = "0x185DAA190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public ACJJIMKJFDA(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA360", Offset = "0x5DA9160", VA = "0x185DAA360")]
	public static bool FMKGPFEKDFI(ACJJIMKJFDA GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA0F0", Offset = "0x5DA8EF0", VA = "0x185DAA0F0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(ACJJIMKJFDA MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA800", Offset = "0x5DA9600", VA = "0x185DAA800")]
	public bool NKAAFBGOPPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA700", Offset = "0x5DA9500", VA = "0x185DAA700")]
	public ECLMNCPCDJH KEKENHACKLF(ECLMNCPCDJH CJKEIGLKDDB)
	{
		return default(ECLMNCPCDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA9C0", Offset = "0x5DA97C0", VA = "0x185DAA9C0")]
	public JBMJEBCFLLB OOBPCGDLHJB()
	{
		return default(JBMJEBCFLLB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct HODPBNEOBHC : IEquatable<HODPBNEOBHC>
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly HODPBNEOBHC PIBEOMIKLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public JBMJEBCFLLB OBEGLAOMPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(JBMJEBCFLLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public LBMEFDDHLNC HFGEDEDEGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(LBMEFDDHLNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private FHAHHFIJPJO DCAOAJDGONP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF750", Offset = "0x5DAE550", VA = "0x185DAF750")]
		get
		{
			return default(FHAHHFIJPJO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public JAKIGHGFBIO FMAOIOJBFCN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFAA0", Offset = "0x5DAE8A0", VA = "0x185DAFAA0")]
		get
		{
			return default(JAKIGHGFBIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public IGLKMNHABOP GOKNOOKGHJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF890", Offset = "0x5DAE690", VA = "0x185DAF890")]
		get
		{
			return default(IGLKMNHABOP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public FAODBGBPACL OHPMPCNHIHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF8F0", Offset = "0x5DAE6F0", VA = "0x185DAF8F0")]
		get
		{
			return default(FAODBGBPACL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public PPAIKDMJOOF DHEGAMMJBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF820", Offset = "0x5DAE620", VA = "0x185DAF820")]
		get
		{
			return default(PPAIKDMJOOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public NLNFEJBMKIC MKICFNHIEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF3A0", Offset = "0x5DAE1A0", VA = "0x185DAF3A0")]
		get
		{
			return default(NLNFEJBMKIC);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF580", Offset = "0x5DAE380", VA = "0x185DAF580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public ECODBCHBEFD CCNKODIFEIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF340", Offset = "0x5DAE140", VA = "0x185DAF340")]
		get
		{
			return default(ECODBCHBEFD);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF9B0", Offset = "0x5DAE7B0", VA = "0x185DAF9B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public float OPPIAHPHADJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF670", Offset = "0x5DAE470", VA = "0x185DAF670")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF480", Offset = "0x5DAE280", VA = "0x185DAF480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public Vector3 COAHGNFIEML
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF6D0", Offset = "0x5DAE4D0", VA = "0x185DAF6D0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF400", Offset = "0x5DAE200", VA = "0x185DAF400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public float ODPFIODOFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF7B0", Offset = "0x5DAE5B0", VA = "0x185DAF7B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public KFAMMCNDFDG.EPHEGHNINDM ANHEFJFAJBM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF950", Offset = "0x5DAE750", VA = "0x185DAF950")]
		get
		{
			return default(KFAMMCNDFDG.EPHEGHNINDM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x5DAF2D0", Offset = "0x5DAE0D0", VA = "0x185DAF2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public HODPBNEOBHC(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA360", Offset = "0x5DA9160", VA = "0x185DAA360")]
	public static bool FMKGPFEKDFI(HODPBNEOBHC GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF4F0", Offset = "0x5DAE2F0", VA = "0x185DAF4F0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(HODPBNEOBHC MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5DAFA20", Offset = "0x5DAE820", VA = "0x185DAFA20")]
	public LPBJFDJKJEF OMLFAAECHHI()
	{
		return default(LPBJFDJKJEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5DAF5F0", Offset = "0x5DAE3F0", VA = "0x185DAF5F0")]
	public PAEMMLCLHJM GOLNBDGODEK()
	{
		return default(PAEMMLCLHJM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct LPBJFDJKJEF : IEquatable<LPBJFDJKJEF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public JBMJEBCFLLB OBEGLAOMPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(JBMJEBCFLLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public HODPBNEOBHC IHNCDNMCADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(HODPBNEOBHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	private FEAAFHKBMHG KMPMBFKGMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5DB58F0", Offset = "0x5DB46F0", VA = "0x185DB58F0")]
		get
		{
			return default(FEAAFHKBMHG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public NJGEKDIELMJ DDPFIIIMPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5890", Offset = "0x5DB4690", VA = "0x185DB5890")]
		get
		{
			return default(NJGEKDIELMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public LPBJFDJKJEF(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA360", Offset = "0x5DA9160", VA = "0x185DAA360")]
	public static bool FMKGPFEKDFI(LPBJFDJKJEF GNLEHBFFNFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5800", Offset = "0x5DB4600", VA = "0x185DB5800", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(LPBJFDJKJEF MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[DefaultMember("Item")]
public readonly struct PAEMMLCLHJM : IEquatable<PAEMMLCLHJM>
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly PAEMMLCLHJM PIBEOMIKLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public JBMJEBCFLLB OBEGLAOMPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(JBMJEBCFLLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public LBMEFDDHLNC HFGEDEDEGAG
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(LBMEFDDHLNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private IKBNJJBMJGF OJBGOKBDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA300", Offset = "0x5DA9100", VA = "0x185DAA300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private NMOMJJDHINP FJFGPNMBHDB
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7180", Offset = "0x5DB5F80", VA = "0x185DB7180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private MOMEIDDAEBF NPGJMKHHHPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7330", Offset = "0x5DB6130", VA = "0x185DB7330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public HODPBNEOBHC IHNCDNMCADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(HODPBNEOBHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public HGKFIBGMEHG DNFBIJGJBNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7540", Offset = "0x5DB6340", VA = "0x185DB7540")]
		get
		{
			return default(HGKFIBGMEHG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7420", Offset = "0x5DB6220", VA = "0x185DB7420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public IEnumerable<CODDIAIKCDE> AHFAKDFCENN
	{
		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6B20", Offset = "0x5DB5920", VA = "0x185DB6B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public CODDIAIKCDE BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x5DB6D30", Offset = "0x5DB5B30", VA = "0x185DB6D30")]
		get
		{
			return default(CODDIAIKCDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x5DB7390", Offset = "0x5DB6190", VA = "0x185DB7390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public PAEMMLCLHJM(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA360", Offset = "0x5DA9160", VA = "0x185DAA360")]
	public static bool FMKGPFEKDFI(PAEMMLCLHJM GNLEHBFFNFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x5DACD90", Offset = "0x5DABB90", VA = "0x185DACD90")]
	public static bool NOLBLOCHCOA(PAEMMLCLHJM MACGGKMNKNM, PAEMMLCLHJM JHKDDIMPPGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5DB72A0", Offset = "0x5DB60A0", VA = "0x185DB72A0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(PAEMMLCLHJM MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7670", Offset = "0x5DB6470", VA = "0x185DB7670")]
	public CODDIAIKCDE NDHEFBHKNAB(float3? AILFIIEAPKM, [Optional] quaternion? GIBIBDOGOLL, [Optional] Vector3? GBJGBGCFEKM)
	{
		return default(CODDIAIKCDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6F50", Offset = "0x5DB5D50", VA = "0x185DB6F50")]
	public CODDIAIKCDE CHMNCEOJBNE(int DOJILIOCHKM, float3? AILFIIEAPKM, [Optional] quaternion? GIBIBDOGOLL, [Optional] Vector3? GBJGBGCFEKM)
	{
		return default(CODDIAIKCDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6E40", Offset = "0x5DB5C40", VA = "0x185DB6E40")]
	public void CBABDOGJLDM(int DOJILIOCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB7210", Offset = "0x5DB6010", VA = "0x185DB7210")]
	public void EOCKAINKMIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct CODDIAIKCDE : IEquatable<CODDIAIKCDE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public JBMJEBCFLLB OBEGLAOMPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(JBMJEBCFLLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public PAEMMLCLHJM NGNJJMGKFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB920", Offset = "0x5DAA720", VA = "0x185DAB920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public float3 IINMIFPFDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5DABC30", Offset = "0x5DAAA30", VA = "0x185DABC30")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5DABB40", Offset = "0x5DAA940", VA = "0x185DABB40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public quaternion KEJKODFGKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5DABA30", Offset = "0x5DAA830", VA = "0x185DABA30")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x5DABBC0", Offset = "0x5DAA9C0", VA = "0x185DABBC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public float3 PLCCELPLHCF
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB9B0", Offset = "0x5DAA7B0", VA = "0x185DAB9B0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x5DABE40", Offset = "0x5DAAC40", VA = "0x185DABE40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public OODAAJNAONI EIHMNPFNGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x5DABDD0", Offset = "0x5DAABD0", VA = "0x185DABDD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	private CFPBCHNMHBK HMDJGOEFIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB8C0", Offset = "0x5DAA6C0", VA = "0x185DAB8C0")]
		get
		{
			return default(CFPBCHNMHBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	private HJMLPLBIACO LDKEKDCPMFC
	{
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5DABD10", Offset = "0x5DAAB10", VA = "0x185DABD10")]
		get
		{
			return default(HJMLPLBIACO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	private DHIMEENOEJM NLAPNLFPMGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x5DABCB0", Offset = "0x5DAAAB0", VA = "0x185DABCB0")]
		get
		{
			return default(DHIMEENOEJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	private BADOIHAINHN MGMILNJBOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x5DABD70", Offset = "0x5DAAB70", VA = "0x185DABD70")]
		get
		{
			return default(BADOIHAINHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	private LBKJOBPGHGG DKGNDBOHFMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5DABEC0", Offset = "0x5DAACC0", VA = "0x185DABEC0")]
		get
		{
			return default(LBKJOBPGHGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public CODDIAIKCDE(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5DABAB0", Offset = "0x5DAA8B0", VA = "0x185DABAB0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(CODDIAIKCDE MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB920", Offset = "0x5DAA720", VA = "0x185DAB920")]
	public void MLLGNLEBAKN(PAEMMLCLHJM GNLEHBFFNFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct LBMEFDDHLNC : IEquatable<LBMEFDDHLNC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly JBMJEBCFLLB HAIBOLAMIBL;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public ECLMNCPCDJH AFJJMLHIBKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xAA78A0", Offset = "0xAA66A0", VA = "0x180AA78A0")]
		get
		{
			return default(ECLMNCPCDJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private IKBNJJBMJGF OJBGOKBDOJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x5DAA300", Offset = "0x5DA9100", VA = "0x185DAA300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	private JNPLIBJDOGK NDGPFHOHLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5500", Offset = "0x5DB4300", VA = "0x185DB5500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool GNEFHHDMJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4900", Offset = "0x5DB3700", VA = "0x185DB4900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public Vector3 IINMIFPFDIC
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4C50", Offset = "0x5DB3A50", VA = "0x185DB4C50")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4370", Offset = "0x5DB3170", VA = "0x185DB4370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public Quaternion KEJKODFGKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3C00", Offset = "0x5DB2A00", VA = "0x185DB3C00")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5DB44E0", Offset = "0x5DB32E0", VA = "0x185DB44E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public Vector3 COKHGDLHIBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4810", Offset = "0x5DB3610", VA = "0x185DB4810")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5DB50B0", Offset = "0x5DB3EB0", VA = "0x185DB50B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public Quaternion DHOHNGCOPAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4A10", Offset = "0x5DB3810", VA = "0x185DB4A10")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5DB38B0", Offset = "0x5DB26B0", VA = "0x185DB38B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public float OFMEOPGKNHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5460", Offset = "0x5DB4260", VA = "0x185DB5460")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5DB34A0", Offset = "0x5DB22A0", VA = "0x185DB34A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public float ODAENDJNKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x5DB4770", Offset = "0x5DB3570", VA = "0x185DB4770")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Vector3 PLCCELPLHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3A20", Offset = "0x5DB2820", VA = "0x185DB3A20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x5DB5180", Offset = "0x5DB3F80", VA = "0x185DB5180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public Vector3 PMAKIOKCLKA
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3550", Offset = "0x5DB2350", VA = "0x185DB3550")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Matrix4x4 GNBPFGLAKPN
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5DB3D50", Offset = "0x5DB2B50", VA = "0x185DB3D50")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x1628CC0", Offset = "0x1627AC0", VA = "0x181628CC0")]
	public LBMEFDDHLNC(JBMJEBCFLLB OGPPAJOCABK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA600", Offset = "0x5DA9400", VA = "0x185DAA600", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3D90", Offset = "0x5DB2B90", VA = "0x185DB3D90", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5DAA180", Offset = "0x5DA8F80", VA = "0x185DAA180", Slot = "4")]
	public bool Equals(LBMEFDDHLNC MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x5DAAAD0", Offset = "0x5DA98D0", VA = "0x185DAAAD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4EA0", Offset = "0x5DB3CA0", VA = "0x185DB4EA0")]
	public MFILIHGHHEN LKOBMPFDMHK()
	{
		return default(MFILIHGHHEN);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3380", Offset = "0x5DB2180", VA = "0x185DB3380")]
	public void AAEIDOAMDBG([Out] Matrix4x4 AIPDOMPIDDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5250", Offset = "0x5DB4050", VA = "0x185DB5250")]
	public void OGIDGNKLIHP([Out] Vector3 GBGACFKNFKN, [Out] Quaternion AMFOIHEDFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4DF0", Offset = "0x5DB3BF0", VA = "0x185DB4DF0")]
	public void LFDNCAOIMOF([Out] RigidTransform JKEHCMLOGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4B60", Offset = "0x5DB3960", VA = "0x185DB4B60")]
	public GNMGEBAMPGE KKPLKOFBHLF()
	{
		return default(GNMGEBAMPGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4B90", Offset = "0x5DB3990", VA = "0x185DB4B90")]
	public void KKPLKOFBHLF([Out] GNMGEBAMPGE HOBNMCCMKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x5DB45B0", Offset = "0x5DB33B0", VA = "0x185DB45B0")]
	public GNMGEBAMPGE IBBHODFFNIG()
	{
		return default(GNMGEBAMPGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5DB45E0", Offset = "0x5DB33E0", VA = "0x185DB45E0")]
	public void IBBHODFFNIG([Out] GNMGEBAMPGE JKEHCMLOGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4EF0", Offset = "0x5DB3CF0", VA = "0x185DB4EF0")]
	public Vector3 MJOKFPDKCOJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5DB37E0", Offset = "0x5DB25E0", VA = "0x185DB37E0")]
	public void BLGAAIADLPP([In] Vector3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4280", Offset = "0x5DB3080", VA = "0x185DB4280")]
	public Vector3 GHFJBMOEKHB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3710", Offset = "0x5DB2510", VA = "0x185DB3710")]
	public void BIHKONFJOAH([In] Vector3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3E20", Offset = "0x5DB2C20", VA = "0x185DB3E20")]
	public Quaternion FBBALPCBFHP()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x5DB40C0", Offset = "0x5DB2EC0", VA = "0x185DB40C0")]
	public void FHKHLABDHDC([In] Quaternion GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3F70", Offset = "0x5DB2D70", VA = "0x185DB3F70")]
	public Quaternion FFJKEAMMJOE()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3640", Offset = "0x5DB2440", VA = "0x185DB3640")]
	public void BHLMGHAOHAL([In] Quaternion GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3980", Offset = "0x5DB2780", VA = "0x185DB3980")]
	public float CICGGLJGLCK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4D40", Offset = "0x5DB3B40", VA = "0x185DB4D40")]
	public void KOABEJLMHIM(float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4440", Offset = "0x5DB3240", VA = "0x185DB4440")]
	public float GLPDGGNCDBF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x5DB55C0", Offset = "0x5DB43C0", VA = "0x185DB55C0")]
	public void PIMAAAFBADI(float GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5390", Offset = "0x5DB4190", VA = "0x185DB5390")]
	public void OHAGLNPDEOK([In] Vector3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5670", Offset = "0x5DB4470", VA = "0x185DB5670")]
	public Vector3 PLDOPHAIMOM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4FE0", Offset = "0x5DB3DE0", VA = "0x185DB4FE0")]
	public void NHGMNEMKFHL([In] Vector3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x5DB3B10", Offset = "0x5DB2910", VA = "0x185DB3B10")]
	public Vector3 DEJHDPELPNE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4940", Offset = "0x5DB3740", VA = "0x185DB4940")]
	public void JPIPCOGLIKJ([In] Vector3 GNLEHBFFNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x5DB4190", Offset = "0x5DB2F90", VA = "0x185DB4190")]
	public Vector3 GCAIJLDGBMF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x5DB46A0", Offset = "0x5DB34A0", VA = "0x185DB46A0")]
	public void IINELJDOJLE([In] Vector3 GNLEHBFFNFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public static class GCPEEHCPBIO
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private struct FLAFJFLMDEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Guid FGCEIIELPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public IFIGFHACLNC NNDHIADJDIM;
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private struct IFIGFHACLNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int GNLEHBFFNFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int MFKJHGGBAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int IJDAGBFFGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int LAKIPGEOPFI;

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFB00", Offset = "0x5DAE900", VA = "0x185DAFB00")]
		public bool NBPGNOJMLIJ([Out] DJMPNJEFEHC IELEJBMANDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x5DAFB80", Offset = "0x5DAE980", VA = "0x185DAFB80")]
		public IFIGFHACLNC(DJMPNJEFEHC IELEJBMANDO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x5DADC80", Offset = "0x5DACA80", VA = "0x185DADC80")]
	public static Guid ABMECCNDKJA(this DJMPNJEFEHC IELEJBMANDO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x5DADD10", Offset = "0x5DACB10", VA = "0x185DADD10")]
	public static bool PCLOAHFMIPB(this Guid FGCEIIELPBP, [Out] DJMPNJEFEHC IELEJBMANDO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal static class ABEHLHJOHOP
{
	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9E80", Offset = "0x5DA8C80", VA = "0x185DA9E80")]
	public static NMOMJJDHINP FJFGPNMBHDB(this JBMJEBCFLLB NBHCOBHPFBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9CB0", Offset = "0x5DA8AB0", VA = "0x185DA9CB0")]
	public static HBMBNCJMDAI ALGMCKADIHI(this JBMJEBCFLLB NBHCOBHPFBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x5DA9D80", Offset = "0x5DA8B80", VA = "0x185DA9D80")]
	public static EntityManager BGGGLDNEABM(this JBMJEBCFLLB NBHCOBHPFBM)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x29AB770", Offset = "0x29AA570", VA = "0x1829AB770")]
	public static T HPOGMIFKJMC<T>(this JBMJEBCFLLB NBHCOBHPFBM) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x29AC3A0", Offset = "0x29AB1A0", VA = "0x1829AC3A0")]
	public static bool ICNJICENMIF<T>(this JBMJEBCFLLB NBHCOBHPFBM) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface PNFCPLLCHJK
{
	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IHKKIGALKIE(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HNCCOEIJFOE(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NHIBNJLLPFN(JBMJEBCFLLB OGPPAJOCABK, [Out] Guid JLBBMGLDMCI);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid MOOIMHLEIJE(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FGAMPHDBOOH(JBMJEBCFLLB OGPPAJOCABK, Guid JLBBMGLDMCI);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KKIKEPLPJBP(JBMJEBCFLLB OGPPAJOCABK, [Out] Guid HPBOKIMIODG);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid LOJCBFMKOCH(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JLFJOPFBMPN(JBMJEBCFLLB OGPPAJOCABK, Guid HPBOKIMIODG);

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AAIKOHIJOHH(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EIHGJKNDEFI(JBMJEBCFLLB FKKAOLHJCBE, JBMJEBCFLLB LBLLNFOEKNE);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface BCHNGJMGJNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000104")]
	Guid IEFJDIHCPEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JJFPKCKFLGM(Guid JLBBMGLDMCI, Guid HPBOKIMIODG, string ONIBECKLJDD);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface IHJBEAAMNEB
{
	[Cpp2IlInjected.Token(Token = "0x17000105")]
	IReadOnlyCollection<MFGAIFFIFKP> OOKPONCCHOI
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MHHFINHOFOD(int IDDPEMOGPEO, [Out] MFGAIFFIFKP KPBDFPNEODJ);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MFGAIFFIFKP ELJBJJLNHJK(Type PEMNIEMPPLO);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class LLJIHPCAHFO
{
	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x241BB20", Offset = "0x241A920", VA = "0x18241BB20")]
	public static T GBIMJKBBLAM<T>(this IHJBEAAMNEB MGEIMBMEALC, Entity CCHOHIEEHEH) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x241B190", Offset = "0x2419F90", VA = "0x18241B190")]
	public static MFGAIFFIFKP ELJBJJLNHJK<T>(this IHJBEAAMNEB MGEIMBMEALC) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface ILHIPOGALPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000106")]
	Func<EAKFNHOGHCF> APGEJDHLHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<JBMJEBCFLLB, JBMJEBCFLLB> PLLINGFOKOG;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<JBMJEBCFLLB, JBMJEBCFLLB> ONMNDDBKNNP;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<JBMJEBCFLLB, JBMJEBCFLLB, JBMJEBCFLLB> IKEAJOBMJPG;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<JBMJEBCFLLB> FNGAHBMKAJF;

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color DNKKBPJAFMF(JBMJEBCFLLB OGPPAJOCABK, int OAOCMPKBOKO);

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 JDAOKOPJKII(JBMJEBCFLLB OGPPAJOCABK, int OAOCMPKBOKO);

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool GEMMKEJCCOB(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB GGLMLEJEMJP);

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	JBMJEBCFLLB DACEGHKKBLJ(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<JBMJEBCFLLB> JBPIIBOGFGP(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JBMJEBCFLLB EMIGMBAKIEI(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void CAPAFOKKIKK(JBMJEBCFLLB OGPPAJOCABK, Vector3 EHGGAOCNEOE, Quaternion DPFBIDMPMKP);

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ILJFFCKCHLA(JBMJEBCFLLB OGPPAJOCABK, float JDLJFLJJFBP);

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool HCGMEBHPIEC(JBMJEBCFLLB OGPPAJOCABK, [Out] RigidTransform HNBGPOGFKLI);

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool CCOMIKHACLK(JBMJEBCFLLB OGPPAJOCABK, [Out] float JFGFJJBLBAM);

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 CMAIIDJGBPI(KMGAICBJFML DNEJIMMAEIK);

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(Slot = "21")]
	quaternion HKNCBJCLIOC(KMGAICBJFML DNEJIMMAEIK);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class HMBGANOCIGF
{
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface KPJDKLLIHBP
{
	[Cpp2IlInjected.Token(Token = "0x17000107")]
	object PHCPBPFMDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOPGOBOBHFC(EOLLFEKBMDA DJIDJBJMOLC);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface EAKFNHOGHCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000108")]
	LocalId BLCHLBGAFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	LocalId FDBAJIHCKOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HEFBACLBLHB(float3 AIEJDLEEMCB);

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JOACGDIDGIL(float3 AIEJDLEEMCB);

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JGJCMAPCGOJ([Out] float3 KMFMMHANJHK, [Out] float3 MCKBHHHCKCE);

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AMOFDNOPFAB(float3 KMFMMHANJHK, float3 MCKBHHHCKCE);

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NGGAMPACDMC(Color KMFMMHANJHK, Color MCKBHHHCKCE);

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EAKFNHOGHCF Instantiate(Transform GNLAIPIBJPM);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface KNMGONNMFGN
{
	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOCIGOIJKNJ(Transform GNLAIPIBJPM, EAKFNHOGHCF KNDNBKEGEFK);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EAKFNHOGHCF APGEJDHLHFD();
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public enum DLNOBHFFECA
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class AIFHCMJLOGN
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0xA8D0C0", Offset = "0xA8BEC0", VA = "0x180A8D0C0")]
	public static bool MAFOMOBJEEE(this DLNOBHFFECA EPLFCMFNFIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0xA8CE80", Offset = "0xA8BC80", VA = "0x180A8CE80")]
	public static bool FCPDLGCIAOK(this DLNOBHFFECA EPLFCMFNFIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x1FAB200", Offset = "0x1FAA000", VA = "0x181FAB200")]
	public static bool IKDIGLMJJKO(this DLNOBHFFECA EPLFCMFNFIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface BCDPLEGKDHC
{
	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	DLNOBHFFECA GCFENELGNED
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	DLNOBHFFECA EOJCPPODADG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	DLNOBHFFECA OCBHPPKFFKB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	DLNOBHFFECA KBCPIACFDGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	DLNOBHFFECA BCHGGOGNMGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	DLNOBHFFECA KGMDLKOHDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	DLNOBHFFECA EPOOLGOBFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	DLNOBHFFECA DGBGLCLBOOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	DLNOBHFFECA NFNMNEEFDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	DLNOBHFFECA HFKGMMPIDKG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	DLNOBHFFECA ONBILIDELIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	DLNOBHFFECA JHKCKMLFLBN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface FOLLILJKCFG
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<POEBJJFCPOJ> DCJMCAACAJG;

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JBMJEBCFLLB DLNLOPFGNBL(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EIMAADJFFBG(List<JBMJEBCFLLB> HACNEBJEDOA);

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JBMJEBCFLLB DGLCEEOLIGB(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HDGBCFAMPCN(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB LBLLNFOEKNE, bool CANHJIIKAKN);

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DOEKFLCEILH(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB LBLLNFOEKNE);

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int IHHGAJPDPHK(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EOLLFEKBMDA DPHGBCBMJIH(JBMJEBCFLLB HAIBOLAMIBL);

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PCKJBELCCCI(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB EMABGINODJE);

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FOIIPDKECAK(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB IKGHEPBMABE);

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	JBMJEBCFLLB ICGNFBGHFEG(JBMJEBCFLLB CJKEIGLKDDB, JBMJEBCFLLB FPDPCPLHJFJ);

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FBILGEPLNJE(JBMJEBCFLLB CJKEIGLKDDB, JBMJEBCFLLB FPDPCPLHJFJ, [Out] JBMJEBCFLLB KAAGEJFEMGN);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public static class MMIGCODJKCP
{
	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x5DB60F0", Offset = "0x5DB4EF0", VA = "0x185DB60F0")]
	public static List<JBMJEBCFLLB> EIMAADJFFBG(this FOLLILJKCFG IAMHOIOBMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6080", Offset = "0x5DB4E80", VA = "0x185DB6080")]
	public static bool EAILHMIAFFL(this FOLLILJKCFG IAMHOIOBMOB, JBMJEBCFLLB OGPPAJOCABK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface FKKFPKNDNMB
{
	[Cpp2IlInjected.Token(Token = "0x17000116")]
	bool CEGJONOLCEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	bool NOIKOLFGHMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface EPMCOHFCLHA : BODAMAGMDOF
{
	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LGJKCIBNPJM MLPIPIIKNNF(Entity CCHOHIEEHEH);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void POCAKCKGKCJ(NativeArray<LGJKCIBNPJM> OBGOLLJIMAP, NativeArray<KIFLAPEGCAF> PBNGHKJFNGK);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OJAIKMBNFHA(LGJKCIBNPJM KMOBDGPHBOK);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HNIFBNKHJIE(LGJKCIBNPJM KMOBDGPHBOK, [Out] Collider BHBBEPIOBCA);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface BODAMAGMDOF
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLAGLDDIBEG([In] float3 JLBMPBJBLDH, [In] float3 IELHLOGPMDL, float NGLNDDJFMFL, Allocator JFLEKJGGDHL, [Out] NativeArray<Entity> PFOPLIKJCHB);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface FAMDMBCKPIO
{
	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLAGLDDIBEG([In] float3 JLBMPBJBLDH, [In] float3 IELHLOGPMDL, float NGLNDDJFMFL, [Out] GFODINBMJOG EADAPKBIBFH, [Out] JBMJEBCFLLB PPEPGBPKJPK);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface KFABHNDEFJP
{
	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CLAGLDDIBEG([In] NativeArray<Entity> PFOPLIKJCHB, [In] float3 JLBMPBJBLDH, [In] float3 IELHLOGPMDL, [In] NativeArray<GFODINBMJOG> CGBDKDNCGFE);
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public struct LGJKCIBNPJM : BLILJFBNCDH, IEquatable<LGJKCIBNPJM>
{
	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public int CPCFHDJMLHI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x9906E0", Offset = "0x98F4E0", VA = "0x1809906E0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B50", Offset = "0x7F0950", VA = "0x1807F1B50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public int MMJFKHJNAML
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1FBBF30", Offset = "0x1FBAD30", VA = "0x181FBBF30", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x51FC460", Offset = "0x51FB260", VA = "0x1851FC460", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5760", Offset = "0x5DB4560", VA = "0x185DB5760", Slot = "8")]
	public bool Equals(LGJKCIBNPJM MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x5DB57B0", Offset = "0x5DB45B0", VA = "0x185DB57B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public struct GFODINBMJOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public float MONKAHBIBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public float3 LNAACFFHHMA;
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface AMKGIEBJCLD
{
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface IKBNJJBMJGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	NMOMJJDHINP FJFGPNMBHDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	KHMPNKBJMCM GDNMHGNJJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<EOLLFEKBMDA, NativeArray<FMJMJJHCMAN>> MDBAKLKDBCL;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<EOLLFEKBMDA> EPJAIFJBMJM;

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IBDEBMIBBIB ALCOCMIFPNC(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FMJMJJHCMAN JEDJPNAIPIE(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MCJJKKHGDCC(DJMPNJEFEHC IELEJBMANDO, KMILLOLJKJL MENCLGMKPHE);

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ECLMNCPCDJH MEMNMGJANNO(JBMJEBCFLLB OGPPAJOCABK, [Optional] object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NNMNOGEKHAN(JBMJEBCFLLB OGPPAJOCABK, [Out] KMILLOLJKJL MENCLGMKPHE);

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AMDJHMKKENI(JBMJEBCFLLB OGPPAJOCABK, [Out] Transform GNLAIPIBJPM);

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool PIACKBAOBEI(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DFKCBNKAFIM(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool HKNOPCPJEPF(LocalId OGPPAJOCABK, object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LDOHKGPKLNJ(LocalId OGPPAJOCABK, object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(Slot = "16")]
	JBMJEBCFLLB IAMCBICJENG(DJMPNJEFEHC IELEJBMANDO);

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool JIAOCCHKBED(DJMPNJEFEHC IELEJBMANDO, [Out] JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(Slot = "18")]
	DJMPNJEFEHC FKGNNMHAONN(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "19")]
	EOLLFEKBMDA IAMCBICJENG(NativeArray<DJMPNJEFEHC> IELEJBMANDO, Allocator JFLEKJGGDHL);

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "20")]
	EOLLFEKBMDA PDJBMEBOODM(NativeArray<DJMPNJEFEHC> IELEJBMANDO, NativeArray<NOGPJKFKBEI> EIBIAHGBKEB, Allocator JFLEKJGGDHL);

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "21")]
	ECLMNCPCDJH LOLHPIIPICI(FMJMJJHCMAN CMNEDOHOKIA, bool EFMKMAPHEAG);

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(Slot = "22")]
	ECLMNCPCDJH LOLHPIIPICI(FMJMJJHCMAN CMNEDOHOKIA);

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "23")]
	ECLMNCPCDJH GBGNNNGDFPA(FMJMJJHCMAN CMNEDOHOKIA);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "24")]
	ECLMNCPCDJH BJIPHNHAEML(FMJMJJHCMAN CMNEDOHOKIA);

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "25")]
	ECLMNCPCDJH PDJBMEBOODM(DJMPNJEFEHC IELEJBMANDO, FMJMJJHCMAN CMNEDOHOKIA);

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(Slot = "26")]
	GMKHMIPPILJ OGKAMDNAFHE();

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(Slot = "27")]
	PAEMMLCLHJM LLPIPGIIHHE();

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(Slot = "28")]
	LPBJFDJKJEF AHMFCFGLLII(NJGEKDIELMJ AFEKIDDGEGD);

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void CGMMBIMCGNC(EOLLFEKBMDA DJIDJBJMOLC);

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void OKHJEEBGOJC(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void GAOMNJBAIKD(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void CGMMBIMCGNC(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "33")]
	EOLLFEKBMDA NKCHKCJIHIJ(EOLLFEKBMDA GCHHFEIHBEL, Allocator JFLEKJGGDHL);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool HCAMIAJDHEM(JBMJEBCFLLB OGPPAJOCABK);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class LPNLKEMKEOL
{
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5950", Offset = "0x5DB4750", VA = "0x185DB5950")]
	public static void DFKCBNKAFIM(this IKBNJJBMJGF CFIPHHIMOMK, KMILLOLJKJL MENCLGMKPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DB59D0", Offset = "0x5DB47D0", VA = "0x185DB59D0")]
	public static ECLMNCPCDJH DJDEJILIIIN(this IKBNJJBMJGF CFIPHHIMOMK, LocalId OGPPAJOCABK)
	{
		return default(ECLMNCPCDJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5DB59D0", Offset = "0x5DB47D0", VA = "0x185DB59D0")]
	public static JBMJEBCFLLB IAMCBICJENG(this IKBNJJBMJGF CFIPHHIMOMK, LocalId OGPPAJOCABK)
	{
		return default(JBMJEBCFLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5B00", Offset = "0x5DB4900", VA = "0x185DB5B00")]
	public static DJMPNJEFEHC FKGNNMHAONN(this IKBNJJBMJGF CFIPHHIMOMK, LocalId OGPPAJOCABK)
	{
		return default(DJMPNJEFEHC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5D90", Offset = "0x5DB4B90", VA = "0x185DB5D90")]
	public static bool HCAMIAJDHEM(this IKBNJJBMJGF CFIPHHIMOMK, DJMPNJEFEHC IELEJBMANDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x24420E0", Offset = "0x2440EE0", VA = "0x1824420E0")]
	public static T LKLFMILIDDD<T>(this IKBNJJBMJGF CFIPHHIMOMK, LocalId OGPPAJOCABK) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5C90", Offset = "0x5DB4A90", VA = "0x185DB5C90")]
	public static GMKHMIPPILJ GFAKLHMBELP(this IKBNJJBMJGF CFIPHHIMOMK, RigidTransform HOBNMCCMKAD, [Optional] object PFKLELGAJPH)
	{
		return default(GMKHMIPPILJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5B80", Offset = "0x5DB4980", VA = "0x185DB5B80")]
	public static LPBJFDJKJEF GBOKIEMKBIB(this IKBNJJBMJGF CFIPHHIMOMK, NJGEKDIELMJ NECBPDIDDFE, RigidTransform HOBNMCCMKAD, [Optional] object PFKLELGAJPH)
	{
		return default(LPBJFDJKJEF);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5A00", Offset = "0x5DB4800", VA = "0x185DB5A00")]
	public static PAEMMLCLHJM EHHGDIHAOMG(this IKBNJJBMJGF CFIPHHIMOMK, RigidTransform HOBNMCCMKAD, [Optional] object PFKLELGAJPH)
	{
		return default(PAEMMLCLHJM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x5DB5E60", Offset = "0x5DB4C60", VA = "0x185DB5E60")]
	private static void NAIOMBKGHFP(ECLMNCPCDJH BNDKDPKHJEK, RigidTransform HOBNMCCMKAD, [Optional] object PFKLELGAJPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface PHJHPLJJLBK
{
	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	bool KMIOKONLJDB
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	JBMJEBCFLLB GINMDPAEHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	ECLMNCPCDJH MMJEJEDAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event DLIEKIDHGAE HCNPFHEKKOM;

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JBMJEBCFLLB ICGNFBGHFEG(JBMJEBCFLLB CJKEIGLKDDB, JBMJEBCFLLB FPDPCPLHJFJ);

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool FBILGEPLNJE(JBMJEBCFLLB CJKEIGLKDDB, JBMJEBCFLLB FPDPCPLHJFJ, [Out] JBMJEBCFLLB KAAGEJFEMGN);

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DLALNIEGMCP();

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PAKDCNBAHOC();

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AALPPKOGDBB(JBMJEBCFLLB CJKEIGLKDDB);

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CJCBPKALELG(JBMJEBCFLLB CJKEIGLKDDB);
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public delegate void DLIEKIDHGAE(ECLMNCPCDJH KBGOADGEIFO, ECLMNCPCDJH KPLOGBDCHCP);
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class KDBBHOEPMCC
{
	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x5DB1360", Offset = "0x5DB0160", VA = "0x185DB1360")]
	public static bool KEEFIJCEBLH(this PHJHPLJJLBK AOKGLFIDFCH, JBMJEBCFLLB CJKEIGLKDDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5DB12E0", Offset = "0x5DB00E0", VA = "0x185DB12E0")]
	public static bool DAILIGBFOOG(this PHJHPLJJLBK AOKGLFIDFCH, JBMJEBCFLLB CJKEIGLKDDB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface OHEAJDCELJE
{
	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLLCPDLJJPB(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HIKELNOMGDD(JBMJEBCFLLB OGPPAJOCABK, Transform GNLAIPIBJPM);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface JLJJHKEDFND
{
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDPGOEDGMCL(JBMJEBCFLLB HAIBOLAMIBL, bool GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCOHMEAEJFA(JBMJEBCFLLB HAIBOLAMIBL, bool GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FJFGKMHJMOC(JBMJEBCFLLB HAIBOLAMIBL, int GNLEHBFFNFG);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface MOMEIDDAEBF
{
	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<JBMJEBCFLLB> BLIEALJGNCD(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JBMJEBCFLLB IFJKGBNBGHN(JBMJEBCFLLB OGPPAJOCABK, int DOJILIOCHKM);

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int AFABCEOCJBO(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HGKFIBGMEHG AKELGLKFEEI(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GIMKLHNKJIC(JBMJEBCFLLB OGPPAJOCABK, HGKFIBGMEHG FJDDANGEILG);

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JBMJEBCFLLB ABCLIHPBHBP(JBMJEBCFLLB OGPPAJOCABK, [Optional] float3? AILFIIEAPKM, [Optional] quaternion? GIBIBDOGOLL, [Optional] float3? GBJGBGCFEKM);

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JBMJEBCFLLB APKPDMDHFCB(JBMJEBCFLLB OGPPAJOCABK, int DOJILIOCHKM, [Optional] float3? AILFIIEAPKM, [Optional] quaternion? GIBIBDOGOLL, [Optional] float3? GBJGBGCFEKM);

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GIGJHEJMLOJ(JBMJEBCFLLB OGPPAJOCABK, int DOJILIOCHKM);

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MNKMCCHACLH(JBMJEBCFLLB OGPPAJOCABK);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface ODLGBANKCLJ
{
	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COIEFNNLDLF();

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IAHDPFNBOKI();

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DJENHNKCJPM();

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KHMKHIOJJAC();

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GFEAFEOKKFC();

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BBKOGNMKOEM();

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NIGOMGLPENK();

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HKFFMDJBNFH();

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GDEEGPBGDEH();

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KPJPIMLJGCJ();

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void AFMHCKBDBMA();
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface JNPLIBJDOGK
{
	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCOHGCIOGNE(Entity CCHOHIEEHEH);

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BLGAAIADLPP(Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 MJOKFPDKCOJ(Entity CCHOHIEEHEH);

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FHKHLABDHDC(Entity CCHOHIEEHEH, [In] quaternion GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion FBBALPCBFHP(Entity CCHOHIEEHEH);

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OGIDGNKLIHP(Entity CCHOHIEEHEH, [Out] float3 AILFIIEAPKM, [Out] quaternion GIBIBDOGOLL);

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OGIDGNKLIHP(Entity CCHOHIEEHEH, [Out] RigidTransform HKMBHMECFMJ);

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LFDNCAOIMOF(Entity CCHOHIEEHEH, [Out] RigidTransform HKMBHMECFMJ);

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 PODHOBKEHKG(Entity CCHOHIEEHEH);

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OHAGLNPDEOK(Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KOABEJLMHIM(Entity CCHOHIEEHEH, float GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float CICGGLJGLCK(Entity CCHOHIEEHEH);

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JPIPCOGLIKJ(Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 DEJHDPELPNE(Entity CCHOHIEEHEH);

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BIHKONFJOAH(Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 GHFJBMOEKHB(Entity CCHOHIEEHEH);

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BHLMGHAOHAL(Entity CCHOHIEEHEH, [In] quaternion GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion FFJKEAMMJOE(Entity CCHOHIEEHEH);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 PLDOPHAIMOM(Entity CCHOHIEEHEH);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void NHGMNEMKFHL(Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void PIMAAAFBADI(Entity CCHOHIEEHEH, float GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float GLPDGGNCDBF(Entity CCHOHIEEHEH);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IINELJDOJLE(Entity CCHOHIEEHEH, [In] float3 GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 GCAIJLDGBMF(Entity CCHOHIEEHEH);

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void AJMIJDIDCFO(Entity CCHOHIEEHEH, [Out] float4x4 AIPDOMPIDDN);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void IOOBAHDFEOG(Entity CCHOHIEEHEH, [In] float4x4 AIPDOMPIDDN);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void POBFHNNFDCL(Entity CCHOHIEEHEH, [Out] float4x4 AIPDOMPIDDN);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool AMDJHMKKENI(Entity CCHOHIEEHEH, [Out] Transform GNLAIPIBJPM);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void KCPBCAHHHIJ(Entity CCHOHIEEHEH);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void NPGLBEMPLFL(Entity CCHOHIEEHEH, Entity AOAOIAHJGFI, Entity KBFMMMPNLKE);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class DJJLCDAGOJD
{
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface FBHFKMFDFBO
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World IAIGAEKPMDM();

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World EDBLOGHGOMA();

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World JGIBLONFDHN();

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World AEFNDMAOHAL();
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface HBMBNCJMDAI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	World IIPPIBCPIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	World LLDCDMOFHKM
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	EntityManager BGGGLDNEABM
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	bool LPLEMOIFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase GNOJFHCBDAA(Type PEMNIEMPPLO);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class BBOKONJLCBH
{
	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB550", Offset = "0x5DAA350", VA = "0x185DAB550")]
	public static ComponentSystemBase ELOLLDDBIJJ(this World GICLKIIJBDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x2169DB0", Offset = "0x2168BB0", VA = "0x182169DB0")]
	public static T GNOJFHCBDAA<T>(this HBMBNCJMDAI CFIOKNDAAND) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface KHOPPHCEAEP
{
	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOJBEJCIBEJ(NativeListAsync<Entity> DLHJLCIPGDO);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KGPPCNDIJJH(ECDFNMEFCMB IGCLMELEMPD);

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKJCGIACOLB(NativeListAsync<Entity> AFFCFBMJLIC, bool EEGCEDGCFFJ);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BFAHPPJFBDH();
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface HKANIBGKHCE
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NCIKCPMABBB(JBMJEBCFLLB OGPPAJOCABK, [Out] Collider BHBBEPIOBCA);

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject KNHDBGFOBBD(JBMJEBCFLLB IFFLCEPDBGA, GameObject MCMNAIINBFO, Vector3 ELHIODNHAHA, Quaternion FIIPDOPILCE);

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IKCIMMEEIKI(GameObject BHBBEPIOBCA);

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider HFEDKOEAPCG<TCollider>(GameObject HLPGFBKAPLH) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BINICBPEPPD(Collider BHBBEPIOBCA);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject PMOPNLJDGAA<TCollider>(string ONIBECKLJDD) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface AEONNHMKDNI
{
	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CHNHGFPEIPN(JBMJEBCFLLB OGPPAJOCABK, KJMNOPEJLKJ OHBNMFIHJMC, bool CIIGNNMMLIB, DNCLPBDFMLC OGGEOHBNGIH);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFNCOCDHKMF(JBMJEBCFLLB OGPPAJOCABK, KJMNOPEJLKJ OHBNMFIHJMC, bool CIIGNNMMLIB, bool HAMHFKMJOCN, bool GMBKEKHGPFF);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HIPJNBHFBBL FIBOCJJFHHD(JBMJEBCFLLB JKEBPOPHOPF, List<JBMJEBCFLLB> EGNMLEJHECI);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PJNLCDDHDJJ(GameObject KPHMIBCOIFC, GameObject HCAABGCIBAP);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PJEGEELGIHK(GameObject HCAABGCIBAP);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T HFEDKOEAPCG<T>(GameObject HLPGFBKAPLH) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BINICBPEPPD(Collider BHBBEPIOBCA);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject DGIKFIHKBFO<T>(string ONIBECKLJDD) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface BGJEPDMMNIC
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MFILNGPPBFG(JBMJEBCFLLB OGPPAJOCABK, HDDDKCEGLNC GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HDDDKCEGLNC FFBBHAGPCMO(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HHIIPGJELHJ(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OHPPCLKLOPE(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int IHHGAJPDPHK(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JBMJEBCFLLB KNHMBBGLEOH(JBMJEBCFLLB OGPPAJOCABK, int DOJILIOCHKM);

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EOGBCPCBPOK(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CHDCKKAABMF(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH, JBMJEBCFLLB GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DBDEMJAPOPA(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool NIICEMMGANB(JBMJEBCFLLB OGPPAJOCABK, [Out] JBMJEBCFLLB GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HDBFHOEDAPD(JBMJEBCFLLB OGPPAJOCABK, float3 GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IFDDAHGKLGG(JBMJEBCFLLB OGPPAJOCABK, [Out] float3 GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MCKINOAFOEM(JBMJEBCFLLB OGPPAJOCABK, float3 GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool MCKFBGDGNMI(JBMJEBCFLLB OGPPAJOCABK, [Out] float3 GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void CBOJPAHDILH(JBMJEBCFLLB OGPPAJOCABK, (Quaternion rot, Vector3 moments) IGICCOJIDDA);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MNFEAKNJFHC(JBMJEBCFLLB OGPPAJOCABK, [Out] quaternion KAHMHDLHHJI, [Out] float3 KAGPJIKKGFO);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JHCFJLKEMGJ(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KNKCNKEADAA(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 MFGLGFDGIJH(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 ACLMLIIAFGO(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FBJBEDNFGNF(JBMJEBCFLLB OGPPAJOCABK, float3 GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DAHLMAOKMDD(JBMJEBCFLLB OGPPAJOCABK, float3 GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float OCHPILIKBCO(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float EJENFJGAEBA(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ICLAJDHLMGP(JBMJEBCFLLB OGPPAJOCABK, float GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void LPLKODMKIHI(JBMJEBCFLLB OGPPAJOCABK, float GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode LCCENIFADAO(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IIEAFLGOFCN(JBMJEBCFLLB OGPPAJOCABK, CollisionDetectionMode GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	EPMFMHNHMEG JLJFAEGNKHM(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void HBMMNFDPAIH(JBMJEBCFLLB OGPPAJOCABK, EPMFMHNHMEG GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool EDNFLGOKNHC(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void DLHKNJKHKLB(JBMJEBCFLLB OGPPAJOCABK, bool GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "32")]
	JBMJEBCFLLB DLNLOPFGNBL(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void EPBCEIHCGLA(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "34")]
	JBMJEBCFLLB DGLCEEOLIGB(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void HDGBCFAMPCN(JBMJEBCFLLB OGPPAJOCABK, JBMJEBCFLLB GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "36")]
	GOIKPLFAGFM NKEAAKLJPDG(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void KHODBMHLJAC(JBMJEBCFLLB OGPPAJOCABK, GOIKPLFAGFM AFMPEOCEABJ);

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool IDKCKGIDLIN(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void PJNJLGILILP(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool IPJPBJEDKGG(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void HBEGPADBLCH(JBMJEBCFLLB OGPPAJOCABK, bool GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool BGCJGOFELNA(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void HLBHNEKDGMC(JBMJEBCFLLB OGPPAJOCABK, bool GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints KOPNCGOHOFJ(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void NPCAPKJGFCJ(JBMJEBCFLLB OGPPAJOCABK, RigidbodyConstraints GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float ODPHGDNALHH(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void GJPAFEMHBDN(JBMJEBCFLLB OGPPAJOCABK, float GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float PANAOACOLNK(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void LGOCOEBFKFF(JBMJEBCFLLB OGPPAJOCABK, float GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool GEGFMJAIJPE(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void ILOOOMLDBEO(JBMJEBCFLLB OGPPAJOCABK, bool GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool BBMOMJNHBHH(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void DNPPNLAIBNC(JBMJEBCFLLB OGPPAJOCABK, bool GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void GEDCBIHGDPP(JBMJEBCFLLB OGPPAJOCABK, int GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object EHHMEDBDPLI(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void ABBODHLOGKM(JBMJEBCFLLB OGPPAJOCABK, object GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object NBMOFDBLGLI(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void BPJKJNFMDJM(JBMJEBCFLLB OGPPAJOCABK, object GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float ONABKFMFIBK(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void OFGOENDFDNK(JBMJEBCFLLB OGPPAJOCABK, float GNLEHBFFNFG);

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void JOGDLGNCAEP(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void GFBLKJEIEFM(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool ACKBBILJDDB(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void KFPPLJOFDCN(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void FPKHDIIMCPG(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool IJANIGIKMNH(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool BIMHFMBDNAG(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody NLPINAOPGDP(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void ABIAFIMBDJA(JBMJEBCFLLB OGPPAJOCABK, Rigidbody MAAIGBPPBFP);

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void OJJAOMJIFMM(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void IIIGLEPLPKA(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool PJILPBKDMPC(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void APFKKFNNHGI(JBMJEBCFLLB OGPPAJOCABK, float3 HPJBBHHJIEL);

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void KJACOMCANHP(JBMJEBCFLLB OGPPAJOCABK, float3 LMHADGEOOGN);

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool CHLCDOHAEFA(JBMJEBCFLLB OGPPAJOCABK, [Out] float3 HPJBBHHJIEL);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool NCJFEGIOHHB(JBMJEBCFLLB OGPPAJOCABK, [Out] float3 LMHADGEOOGN);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool EAAEJMCMHOM(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void MJKFFEJNBJC(JBMJEBCFLLB OGPPAJOCABK, object PFKLELGAJPH, bool JJIMCKPIKFL);

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void LIKNGICEEOK(JBMJEBCFLLB OGPPAJOCABK, bool FMIANILELJB);

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void GEFOBJBPKGJ(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool KFOAKOCCFBA(JBMJEBCFLLB OGPPAJOCABK);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface AOFEKDJFLMC
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	bool LPLEMOIFKPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PNBEMPHMPJN(JBMJEBCFLLB OGPPAJOCABK);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PIDNBNMCMMB(JBMJEBCFLLB OGPPAJOCABK, bool CIIGNNMMLIB, bool HAMHFKMJOCN, bool GANBKGMDIOJ);
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface GKJLLKLKGFO
{
	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DADOKLAAMEJ(Entity INDGKNGOKKL);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJKIMAFKFIK(Entity INDGKNGOKKL);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public delegate void CBFDMKOCAMK(FKIAGMFJAHK PPMFEKANMCP);
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct FKIAGMFJAHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly EOLLFEKBMDA BCFDFNJIOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly NativeArray<byte> BOAPNJKEFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly NativeArray<byte> INJCFLAHPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly KIBKAPDMHFC NLJCIKGMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly int APHNPJDNMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Type GBDOICBKCHL;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public EOLLFEKBMDA GCHMCJHOBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x39159C0", Offset = "0x39147C0", VA = "0x1839159C0")]
		get
		{
			return default(EOLLFEKBMDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5DADB80", Offset = "0x5DAC980", VA = "0x185DADB80")]
	public FKIAGMFJAHK(EOLLFEKBMDA BCFDFNJIOHD, NativeArray<byte> BOAPNJKEFEG, NativeArray<byte> INJCFLAHPML, KIBKAPDMHFC NLJCIKGMHGO, int APHNPJDNMGM, Type GBDOICBKCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x2343070", Offset = "0x2341E70", VA = "0x182343070")]
	public NativeArray<T> ADLJNDMGKOA<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x2343030", Offset = "0x2341E30", VA = "0x182343030")]
	public NativeArray<T> ABOGMKEGJFD<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x23430B0", Offset = "0x2341EB0", VA = "0x1823430B0")]
	public (EOLLFEKBMDA, NativeArray<T>, NativeArray<T>) OMJIHOMPBMI<T>() where T : struct
	{
		return default((EOLLFEKBMDA, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5DADB30", Offset = "0x5DAC930", VA = "0x185DADB30")]
	public POEBJJFCPOJ MIHJABHONNJ()
	{
		return default(POEBJJFCPOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public interface AABJKBCCJJP
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	string CPAAHMIJEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	AABJKBCCJJP GLPBCJEELBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	IEnumerable<AABJKBCCJJP> JAPDKOPAOPF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface JDAEBEPDJOB
{
	[Cpp2IlInjected.Token(Token = "0x17000128")]
	AABJKBCCJJP CDHOKCCMLEK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	List<OEEJKPJCCOP> BNHHNNINPMO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IJLNDIHIHKI(OEEJKPJCCOP GGCGADADFCH, [Out] AABJKBCCJJP EODEKLAMAOD);

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCJJKKHGDCC(OEEJKPJCCOP GGCGADADFCH, CBFDMKOCAMK JGGDOEKFOFA);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JKGGMKNLLFM(OEEJKPJCCOP GGCGADADFCH, CBFDMKOCAMK JGGDOEKFOFA);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public readonly struct POEBJJFCPOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly FKIAGMFJAHK PFDMLBFKIAP;

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public EOLLFEKBMDA GCHMCJHOBPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x39159C0", Offset = "0x39147C0", VA = "0x1839159C0")]
		get
		{
			return default(EOLLFEKBMDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8D70", Offset = "0x5DB7B70", VA = "0x185DB8D70")]
	public POEBJJFCPOJ(FKIAGMFJAHK PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8B80", Offset = "0x5DB7980", VA = "0x185DB8B80")]
	public EOLLFEKBMDA ADLJNDMGKOA()
	{
		return default(EOLLFEKBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8AB0", Offset = "0x5DB78B0", VA = "0x185DB8AB0")]
	public EOLLFEKBMDA ABOGMKEGJFD()
	{
		return default(EOLLFEKBMDA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5DB8C50", Offset = "0x5DB7A50", VA = "0x185DB8C50")]
	public (EOLLFEKBMDA, EOLLFEKBMDA, EOLLFEKBMDA) OMJIHOMPBMI()
	{
		return default((EOLLFEKBMDA, EOLLFEKBMDA, EOLLFEKBMDA));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
[DefaultMember("Item")]
public interface FCEELEODMDI : IEnumerable<MDMHNBKGCGM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	NativeBitArray DGOLIHEDBAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	NativeArray<int> NEEBFOINBFP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	MDMHNBKGCGM BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	MDMHNBKGCGM BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MDMHNBKGCGM LIEBIFDEGDP(FIAJLECAKMM COPMFEAGFCB);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KIBKAPDMHFC KOKNIMMMGEC(FIAJLECAKMM COPMFEAGFCB);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class ALMEFFPDFBD
{
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[DefaultMember("Item")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface KCJDDJBIGAA : IEnumerable<LPNKEHLCEHF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	LPNKEHLCEHF BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LPNKEHLCEHF LIEBIFDEGDP(FIAJLECAKMM COPMFEAGFCB);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KIBKAPDMHFC KOKNIMMMGEC(FIAJLECAKMM COPMFEAGFCB);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public static class PLBGNLFLFCF
{
	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x250BD50", Offset = "0x250AB50", VA = "0x18250BD50")]
	public static KIBKAPDMHFC KOKNIMMMGEC<T>(this KCJDDJBIGAA EKODFEEOAPM, DKCNFDOHIPC<T> ONIBECKLJDD) where T : struct
	{
		return default(KIBKAPDMHFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
[DefaultMember("Item")]
public interface GALOHLLCPLH : IEnumerable<OEEJKPJCCOP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000132")]
	int CBILAPKHPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	OEEJKPJCCOP BCEJDLMHPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OEEJKPJCCOP LIEBIFDEGDP(FIAJLECAKMM COPMFEAGFCB);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KIBKAPDMHFC KOKNIMMMGEC(FIAJLECAKMM COPMFEAGFCB);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class CJAANIKNGCF
{
	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x21CD4B0", Offset = "0x21CC2B0", VA = "0x1821CD4B0")]
	public static HLOLALCBGEB<T> LIEBIFDEGDP<T>(this GALOHLLCPLH EKODFEEOAPM, FIAJLECAKMM ONIBECKLJDD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x21CD3B0", Offset = "0x21CC1B0", VA = "0x1821CD3B0")]
	public static KIBKAPDMHFC KOKNIMMMGEC<T>(this GALOHLLCPLH EKODFEEOAPM, DKCNFDOHIPC<T> ONIBECKLJDD) where T : struct
	{
		return default(KIBKAPDMHFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface MAEKAKNNECM
{
	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCJJKKHGDCC(FIAJLECAKMM GGCGADADFCH, CBFDMKOCAMK JGGDOEKFOFA);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKGGMKNLLFM(FIAJLECAKMM GGCGADADFCH, CBFDMKOCAMK JGGDOEKFOFA);
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface HDEKOHKCIPA
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	CANNBGFMJBJ HAINDCGDEHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PPOEKCLKIDK(DJMPNJEFEHC IELEJBMANDO, KIBKAPDMHFC GGCGADADFCH);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKPMHHNBHBM(DJMPNJEFEHC IELEJBMANDO, Span<KIBKAPDMHFC> EKODFEEOAPM, bool BAICLDMINPH);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJKOPGBNDCE(NativeArray<DJMPNJEFEHC> OEHBGDNEBEK);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class NLJIOLMHHMC
{
	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6700", Offset = "0x5DB5500", VA = "0x185DB6700")]
	public static void JKPMHHNBHBM(this HDEKOHKCIPA JPFJLMHLIEK, DJMPNJEFEHC IELEJBMANDO, KIBKAPDMHFC GGCGADADFCH, bool BAICLDMINPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public readonly struct CANNBGFMJBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NativeBitArray BKFLAMEBGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly NativeParallelHashMap<DJMPNJEFEHC, int> NPIMNPJFOBH;

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool NBMNKGOJOAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x5DAB6E0", Offset = "0x5DAA4E0", VA = "0x185DAB6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0xA8D870", Offset = "0xA8C670", VA = "0x180A8D870")]
	public CANNBGFMJBJ(NativeBitArray BKFLAMEBGDP, NativeParallelHashMap<DJMPNJEFEHC, int> NPIMNPJFOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5DAB700", Offset = "0x5DAA500", VA = "0x185DAB700")]
	public bool PPOEKCLKIDK(DJMPNJEFEHC IELEJBMANDO, KIBKAPDMHFC GGCGADADFCH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface BFKEBIEJMGI
{
	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JJFADMOOEIO(JBMJEBCFLLB OGPPAJOCABK, GANBGEIPGLD GNLEHBFFNFG);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface NGGPICGBBIC
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	NBDHLNCBJFN HFPCOEAEHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface INAOLEEONGL
{
	[Cpp2IlInjected.Token(Token = "0x17000137")]
	Type JMLGINBEFPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[FEFNBKCFPJG(DAEAEJBLHHK.LoadInstance)]
public interface POCKFOBPLKI
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BAKLNMGDAIJ(JBMJEBCFLLB HAIBOLAMIBL, bool GNLEHBFFNFG);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public readonly struct GJLEGMBHFIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly IEnumerable<ELKMOGAHBJM> JLIAKEMOOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly IReadOnlyList<GameObject> EJDFNLGEMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly IReadOnlyList<int> IJJGFGJFKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly IReadOnlyList<(DJMPNJEFEHC, DJMPNJEFEHC)> CLELJPNDNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly int LHIOIBBMFNL;

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public bool EHIDAKAHKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5DADD30", Offset = "0x5DACB30", VA = "0x185DADD30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public int PDAKCDADNJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x80C540", Offset = "0x80B340", VA = "0x18080C540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public IEnumerable<GameObject> LGDPAKOFLIO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x990730", Offset = "0x98F530", VA = "0x180990730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public IEnumerable<(DJMPNJEFEHC src, DJMPNJEFEHC dst)> GFCFHFMIGPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5DAE120", Offset = "0x5DACF20", VA = "0x185DAE120")]
	public GJLEGMBHFIE(IEnumerable<ELKMOGAHBJM> JLIAKEMOOFF, IReadOnlyList<GameObject> EJDFNLGEMBF, IReadOnlyList<int> IJJGFGJFKPE, IReadOnlyList<(DJMPNJEFEHC src, DJMPNJEFEHC dst)> CLELJPNDNGO, int LHIOIBBMFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5DADD90", Offset = "0x5DACB90", VA = "0x185DADD90")]
	public (GameObject, int)[] IGCMEPJJAPF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface DEHDJDPODCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	bool EFKMKMMJGIA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	bool JCAIDEPELCK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	JLHKELLMEON LIFDLEADJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JMHOHCKHKHG FHPJAFEEALF();

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JMHOHCKHKHG EMPHFDOKFGP(IEnumerable<JBMJEBCFLLB> DJIDJBJMOLC, [In] GNMGEBAMPGE ANIJGCJFDNC);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EMJHMNIPEIP BMOHCMFPPLK(ByteString PPNCPMFJCEJ);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LOHFJLILNBF NEEIJFLOIKI(ByteString GHHJLCMBOHI, JBMJEBCFLLB LBLLNFOEKNE, [In] GNMGEBAMPGE PLFGJOHLOMF, BJAAPCICCEH NOIKMIGAMKD, bool APKAALJJFLC = true);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LIGPOGPCAOH();

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	GJLEGMBHFIE KHMPCLGKMPM(IEnumerable<ELKMOGAHBJM> JLIAKEMOOFF);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class ECHCBJAEIDP
{
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface EPCLCPFGOIL
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action LPFNIAPEIOJ;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action OFPADFALJIN;
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public struct NOGPJKFKBEI : MGELDCPHNEL, IEquatable<NOGPJKFKBEI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public FMJMJJHCMAN CMNEDOHOKIA;

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6860", Offset = "0x5DB5660", VA = "0x185DB6860", Slot = "5")]
	public void EFHLMHLMFOG(KEBCPOHPOJM POOKDLGIHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6910", Offset = "0x5DB5710", VA = "0x185DB6910", Slot = "4")]
	public void GKMCGBDALGF(HOFPAEMDILJ LCMOFCIALJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6940", Offset = "0x5DB5740", VA = "0x185DB6940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x161D6C0", Offset = "0x161C4C0", VA = "0x18161D6C0", Slot = "6")]
	public bool Equals(NOGPJKFKBEI MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6890", Offset = "0x5DB5690", VA = "0x185DB6890", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x9906E0", Offset = "0x98F4E0", VA = "0x1809906E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct DJMPNJEFEHC : IComparable<DJMPNJEFEHC>, IEquatable<DJMPNJEFEHC>, MGELDCPHNEL
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public const uint GAHPDHEMLEF = 0u;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public const uint EGIPNLOKMLK = 255u;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly DJMPNJEFEHC LKJBFPNKADE;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private const int DAOKEDMIONC = 24;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private const uint GACELGGJHJC = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private const int JHJFGGHMMCI = 8;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private const uint OEAPDGMEAKM = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly uint AFIEJCAINEM;

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public uint NCHAELJPKHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x7B6A10", Offset = "0x7B5810", VA = "0x1807B6A10")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public uint GMPOHOAMMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5DAC1A0", Offset = "0x5DAAFA0", VA = "0x185DAC1A0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public uint LOJGEKPFMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x9906E0", Offset = "0x98F4E0", VA = "0x1809906E0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	public bool EHIDAKAHKBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x5D17430", Offset = "0x5D16230", VA = "0x185D17430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0xBBA660", Offset = "0xBB9460", VA = "0x180BBA660")]
	public static DJMPNJEFEHC IDIPFBIJAGH(uint AFIEJCAINEM)
	{
		return default(DJMPNJEFEHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC390", Offset = "0x5DAB190", VA = "0x185DAC390")]
	public DJMPNJEFEHC(int PNGBIGHMBHF, int GMNLPEACCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC390", Offset = "0x5DAB190", VA = "0x185DAC390")]
	public DJMPNJEFEHC(uint PNGBIGHMBHF, int GMNLPEACCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC390", Offset = "0x5DAB190", VA = "0x185DAC390")]
	public DJMPNJEFEHC(uint PNGBIGHMBHF, uint GMNLPEACCMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x7F1B50", Offset = "0x7F0950", VA = "0x1807F1B50")]
	private DJMPNJEFEHC(uint AFIEJCAINEM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x161D6E0", Offset = "0x161C4E0", VA = "0x18161D6E0")]
	public static bool NOLBLOCHCOA(DJMPNJEFEHC MACGGKMNKNM, DJMPNJEFEHC JHKDDIMPPGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x161D6C0", Offset = "0x161C4C0", VA = "0x18161D6C0", Slot = "5")]
	public bool Equals(DJMPNJEFEHC NBHCOBHPFBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC220", Offset = "0x5DAB020", VA = "0x185DAC220", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x1FAB110", Offset = "0x1FA9F10", VA = "0x181FAB110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC300", Offset = "0x5DAB100", VA = "0x185DAC300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC2A0", Offset = "0x5DAB0A0", VA = "0x185DAC2A0", Slot = "6")]
	public void GKMCGBDALGF(HOFPAEMDILJ LCMOFCIALJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC1C0", Offset = "0x5DAAFC0", VA = "0x185DAC1C0", Slot = "7")]
	public void EFHLMHLMFOG(KEBCPOHPOJM POOKDLGIHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x5DAC1B0", Offset = "0x5DAAFB0", VA = "0x185DAC1B0", Slot = "4")]
	public int CompareTo(DJMPNJEFEHC MFMJJEFODHB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct ELKMOGAHBJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Guid FGCEIIELPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public string KNKKDNJPFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public Vector3 AILFIIEAPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public Quaternion GIBIBDOGOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Vector3 GBJGBGCFEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public int DJINIKMOOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Dictionary<string, object> FJDDANGEILG;

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x5DAD030", Offset = "0x5DABE30", VA = "0x185DAD030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x5DACEA0", Offset = "0x5DABCA0", VA = "0x185DACEA0")]
	private static string GOLLAELALAC(Dictionary<string, object> IAJACANMJMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public enum FNBJPBCJEMD
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public static class NCJGPNGJLCI
{
	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x530AD70", Offset = "0x5309B70", VA = "0x18530AD70")]
	public static bool IHACNAIAMIA(this FNBJPBCJEMD PEMNIEMPPLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
[Flags]
public enum JCIHCELLDEO
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	AdditivePhases = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public interface LOHFJLILNBF : JLHKELLMEON, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000143")]
	BJAAPCICCEH NMABGCAJHOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODBEBJNFCLL();

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNOEJDFOBOO();
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public interface JLHKELLMEON : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000144")]
	IEnumerable<ELKMOGAHBJM> LEJCHMHOCHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	GJLEGMBHFIE IAOEEJIBPDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	LocalId JFHIGDLHEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	NLKOBNHNFLA GCPCKNINGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	Task LALLLIAJMHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FEFPMOEDJPP(JCIHCELLDEO FAKOLMHKKAI);
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public interface BJAAPCICCEH
{
	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LBJINKMHEPG(Guid PKELBKGJAFM, [Out] Guid GCGBNKINDOP);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public interface EMJHMNIPEIP : JLHKELLMEON, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[Flags]
public enum DEDGMJBHAEJ
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface JMHOHCKHKHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000149")]
	NLKOBNHNFLA EKFPKHCMDCO
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString AAKHFJHDIIL();
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public enum KMHHHJLNOEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public delegate bool FCKPHFHKGNB(FENEGJKBICD GMMGPPEKOEC, [In] ONLJEFNJJKA GNLEHBFFNFG);
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public delegate bool IEFBKNGDIGK<T>(FENEGJKBICD GMMGPPEKOEC, [In] T GNLEHBFFNFG);
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface JIFHFMEONHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCJJKKHGDCC(KIBKAPDMHFC NLJCIKGMHGO, Type HLIBKIJEOFP, FCKPHFHKGNB KMCININDODP);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JEJBDNAMOGD(KIBKAPDMHFC NLJCIKGMHGO, [Out] FCKPHFHKGNB KMCININDODP);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public static class KLJODJBNPFO
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class PLNEMDABHPB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public IEFBKNGDIGK<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public PLNEMDABHPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x3E0BB90", Offset = "0x3E0A990", VA = "0x183E0BB90")]
		internal bool MENLDBAGLFJ(FENEGJKBICD pendingList, [In] ONLJEFNJJKA value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x24014B0", Offset = "0x24002B0", VA = "0x1824014B0")]
	public static void MCJJKKHGDCC<T>(this JIFHFMEONHJ KCDMGGDCPJH, KIBKAPDMHFC NLJCIKGMHGO, IEFBKNGDIGK<T> KMCININDODP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2C90", Offset = "0x5DB1A90", VA = "0x185DB2C90")]
	public static bool EJLABGAPBDK(this JIFHFMEONHJ KCDMGGDCPJH, FENEGJKBICD GMMGPPEKOEC, KIBKAPDMHFC NLJCIKGMHGO, [In] ONLJEFNJJKA GNLEHBFFNFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface IHNPEEDGEBA
{
	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	uint BKDIKDKJGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface FENEGJKBICD
{
	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NAEBAPOGBLA(DJMPNJEFEHC GKJIOGGMBPG, KIBKAPDMHFC NLJCIKGMHGO, ReadOnlySpan<byte> FPCLKFNNOEC, ReadOnlySpan<byte> LEKCIABMLHF);

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PABCKECIPAF(DJMPNJEFEHC GKJIOGGMBPG, KIBKAPDMHFC NLJCIKGMHGO);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EGHCFEPEBCC(DJMPNJEFEHC GKJIOGGMBPG, KIBKAPDMHFC NLJCIKGMHGO, ReadOnlySpan<byte> LEKCIABMLHF);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KFLAGNHDOGP(DJMPNJEFEHC GKJIOGGMBPG, KIBKAPDMHFC NLJCIKGMHGO, Span<byte> FPCLKFNNOEC, Span<byte> LEKCIABMLHF);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class OPHBHIJDEEI
{
	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x24FD980", Offset = "0x24FC780", VA = "0x1824FD980")]
	public static bool KFLAGNHDOGP<T>(this FENEGJKBICD FIOLCFIOCDL, DJMPNJEFEHC GKJIOGGMBPG, KIBKAPDMHFC NLJCIKGMHGO, [Out] T FPCLKFNNOEC, [Out] T LEKCIABMLHF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x24FD850", Offset = "0x24FC650", VA = "0x1824FD850")]
	public static bool EGHCFEPEBCC<T>(this FENEGJKBICD FIOLCFIOCDL, DJMPNJEFEHC GKJIOGGMBPG, KIBKAPDMHFC NLJCIKGMHGO, T LEKCIABMLHF) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public enum IEHCDHJKKHE
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	End,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface HMLNPAANDIJ
{
	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DKGPDAHFCBE(OMJBIJKANJG JIHPAFENIMM, ReadOnlySpan<byte> JPGMJABDIAJ);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface JEOFEPALLKF
{
	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMJBIJKANJG DJDNJHJMAMO(ReadOnlySpan<byte> JPGMJABDIAJ);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface INNOGIJFPDG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HDKJAJHAOOM(OMJBIJKANJG JLDFGFPAIIN, ReadOnlySpan<byte> JPGMJABDIAJ);
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public struct DBGAKFCOIJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public OMJBIJKANJG JIHPAFENIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public ReadOnlyMemory<byte> JPGMJABDIAJ;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct OMJBIJKANJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public uint PNGBIGHMBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public int HKCFGAOHGMD;

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x9712C0", Offset = "0x9700C0", VA = "0x1809712C0")]
	public OMJBIJKANJG(uint PNGBIGHMBHF, int HKCFGAOHGMD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6A60", Offset = "0x5DB5860", VA = "0x185DB6A60")]
	public static bool NOLBLOCHCOA([In] OMJBIJKANJG KNEDKAAPLCI, [In] OMJBIJKANJG FPBOJHIIPAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5DB69A0", Offset = "0x5DB57A0", VA = "0x185DB69A0", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6A30", Offset = "0x5DB5830", VA = "0x185DB6A30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5DB6A80", Offset = "0x5DB5880", VA = "0x185DB6A80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[FEFNBKCFPJG(DAEAEJBLHHK.OMRoom)]
public interface EGIJLNKKPDN : BNDOPICGFOA<EGIJLNKKPDN>
{
	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool COFEFJFFGMK(KIBKAPDMHFC NBHCOBHPFBM, [Out] EAMGFLAKCOJ KPBDFPNEODJ);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class ECOAEADHCFB
{
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public interface EAMGFLAKCOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	Type MAFMPFOLJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFHLMHLMFOG(KEBCPOHPOJM POOKDLGIHHA, Span<byte> CJKEIGLKDDB);

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GKMCGBDALGF(HOFPAEMDILJ LCMOFCIALJC, ReadOnlySpan<byte> JIHPAFENIMM);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class IMMFJAIOCID
{
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct KIFLAPEGCAF : ISystemStateComponentData, IComponentData, IEquatable<KIFLAPEGCAF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public float3 AMCBJOPMJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public float3 GGEGHEGOBPB;

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5DB2320", Offset = "0x5DB1120", VA = "0x185DB2320", Slot = "4")]
	public bool Equals(KIFLAPEGCAF MFMJJEFODHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface CNMKNCKCMAL
{
	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FPKCPFBLOPG JLJAHFLHHBJ(int IDDPEMOGPEO);

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int HPGAGKLDLFN(FPKCPFBLOPG IHPNAJENOLJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface ECLOMGLPHEH
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	IEnumerable<NKGJKGDJEJL> PABBENILDLP
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BBKKGHFJJOA(int IDDPEMOGPEO, [Out] NKGJKGDJEJL KPBDFPNEODJ);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface AMENGEAIDBL
{
	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PCGHMBNENOA(int IDDPEMOGPEO);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[FEFNBKCFPJG(DAEAEJBLHHK.Application)]
public interface BAPCPOJCLDO
{
	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	List<(FPKCPFBLOPG nameHash, KEDJJAGCMFO stableTypeHash, Type type)> BBDJJJJPLLM
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public class IKMPJPADFGH
{
	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public IKMPJPADFGH()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
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
