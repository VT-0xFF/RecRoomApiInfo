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
public struct MDCBEIJBKIC : IReadOnlyList<FJLCNCEHANP>, IEnumerable<FJLCNCEHANP>, IEnumerable, IReadOnlyCollection<FJLCNCEHANP>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct POGFBLKAFKO : IEnumerator<FJLCNCEHANP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly EBBHMBBEAPN CGBBLBLFEGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NativeArray<LocalId>.Enumerator MJDEBPJEPIC;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FJLCNCEHANP POHDIFHCONG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5EFA310", Offset = "0x5EF8B10", VA = "0x185EFA310", Slot = "4")]
			get
			{
				return default(FJLCNCEHANP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5EFA290", Offset = "0x5EF8A90", VA = "0x185EFA290", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x39CDA70", Offset = "0x39CC270", VA = "0x1839CDA70")]
		public POGFBLKAFKO(EBBHMBBEAPN CGBBLBLFEGC, NativeArray<LocalId>.Enumerator MJDEBPJEPIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5EFA1D0", Offset = "0x5EF89D0", VA = "0x185EFA1D0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5EFA210", Offset = "0x5EF8A10", VA = "0x185EFA210", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5EFA250", Offset = "0x5EF8A50", VA = "0x185EFA250", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly EBBHMBBEAPN CGBBLBLFEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeArray<LocalId> BMDBFLNMJID;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FJLCNCEHANP OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7D20", Offset = "0x5EF6520", VA = "0x185EF7D20", Slot = "4")]
		get
		{
			return default(FJLCNCEHANP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7790", Offset = "0x5EF5F90", VA = "0x185EF7790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private int NELAJBICIAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x771180", Offset = "0x76F980", VA = "0x180771180", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public EBBHMBBEAPN CFMNMIPNCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int FHJOOIBMPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x771180", Offset = "0x76F980", VA = "0x180771180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CCNAENOMHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7820", Offset = "0x5EF6020", VA = "0x185EF7820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NativeArray<LocalId> LGNGIONCFCP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x39C5D20", Offset = "0x39C4520", VA = "0x1839C5D20")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7B70", Offset = "0x5EF6370", VA = "0x185EF7B70")]
	public MDCBEIJBKIC(int JHAJBCMGPDO, EBBHMBBEAPN CGBBLBLFEGC, Allocator BIOBDEGNFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x39CDA40", Offset = "0x39CC240", VA = "0x1839CDA40")]
	public MDCBEIJBKIC(EBBHMBBEAPN CGBBLBLFEGC, NativeArray<LocalId> BMDBFLNMJID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7CB0", Offset = "0x5EF64B0", VA = "0x185EF7CB0")]
	internal MDCBEIJBKIC(EBBHMBBEAPN CGBBLBLFEGC, NativeArray<Entity> EBDADEJKLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7AD0", Offset = "0x5EF62D0", VA = "0x185EF7AD0")]
	public MDCBEIJBKIC(EBBHMBBEAPN CGBBLBLFEGC, int BONCBNKGOGN, Allocator BIOBDEGNFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7C00", Offset = "0x5EF6400", VA = "0x185EF7C00")]
	public MDCBEIJBKIC(MDCBEIJBKIC GDKMAPJBPKA, Allocator BIOBDEGNFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF76E0", Offset = "0x5EF5EE0", VA = "0x185EF76E0")]
	public MDCBEIJBKIC CCKDHKOCCGB(Allocator BIOBDEGNFFO = Allocator.Temp)
	{
		return default(MDCBEIJBKIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF77E0", Offset = "0x5EF5FE0", VA = "0x185EF77E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7860", Offset = "0x5EF6060", VA = "0x185EF7860")]
	public POGFBLKAFKO LLEMGPCMEFC()
	{
		return default(POGFBLKAFKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5EF78F0", Offset = "0x5EF60F0", VA = "0x185EF78F0", Slot = "6")]
	private IEnumerator<FJLCNCEHANP> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5EF79E0", Offset = "0x5EF61E0", VA = "0x185EF79E0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public struct OIAGCGEHNGP : IList<FJLCNCEHANP>, ICollection<FJLCNCEHANP>, IEnumerable<FJLCNCEHANP>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct ONDHKEANMBD : IEnumerator<FJLCNCEHANP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly EBBHMBBEAPN CGBBLBLFEGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private NativeArray<LocalId>.Enumerator MJDEBPJEPIC;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public FJLCNCEHANP POHDIFHCONG
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5EFA060", Offset = "0x5EF8860", VA = "0x185EFA060", Slot = "4")]
			get
			{
				return default(FJLCNCEHANP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5EF9FE0", Offset = "0x5EF87E0", VA = "0x185EF9FE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x39CDA70", Offset = "0x39CC270", VA = "0x1839CDA70")]
		public ONDHKEANMBD(EBBHMBBEAPN CGBBLBLFEGC, NativeArray<LocalId>.Enumerator MJDEBPJEPIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9F20", Offset = "0x5EF8720", VA = "0x185EF9F20", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9F60", Offset = "0x5EF8760", VA = "0x185EF9F60", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9FA0", Offset = "0x5EF87A0", VA = "0x185EF9FA0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EBBHMBBEAPN CGBBLBLFEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private NativeList<LocalId> BMDBFLNMJID;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FJLCNCEHANP OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9E10", Offset = "0x5EF8610", VA = "0x185EF9E10", Slot = "4")]
		get
		{
			return default(FJLCNCEHANP);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9E90", Offset = "0x5EF8690", VA = "0x185EF9E90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF99C0", Offset = "0x5EF81C0", VA = "0x185EF99C0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FHJOOIBMPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF99C0", Offset = "0x5EF81C0", VA = "0x185EF99C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public bool POGMNPDPLMM
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2E0", Offset = "0x7BAAE0", VA = "0x1807BC2E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9D80", Offset = "0x5EF8580", VA = "0x185EF9D80")]
	public OIAGCGEHNGP(EBBHMBBEAPN CGBBLBLFEGC, int BONCBNKGOGN, Allocator BIOBDEGNFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9A00", Offset = "0x5EF8200", VA = "0x185EF9A00")]
	public MDCBEIJBKIC OAMNKABAGCM()
	{
		return default(MDCBEIJBKIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9590", Offset = "0x5EF7D90", VA = "0x185EF9590", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5EF95D0", Offset = "0x5EF7DD0", VA = "0x185EF95D0", Slot = "13")]
	public bool Contains(FJLCNCEHANP BPGGEPDHIDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9660", Offset = "0x5EF7E60", VA = "0x185EF9660", Slot = "14")]
	public void CopyTo(FJLCNCEHANP[] CMKNCDNHDNA, int FJLHDHNDEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9510", Offset = "0x5EF7D10", VA = "0x185EF9510", Slot = "11")]
	public void Add(FJLCNCEHANP BPGGEPDHIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9880", Offset = "0x5EF8080", VA = "0x185EF9880", Slot = "7")]
	public void Insert(int EAHCFBMNNCF, FJLCNCEHANP BPGGEPDHIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9AD0", Offset = "0x5EF82D0", VA = "0x185EF9AD0", Slot = "15")]
	public bool Remove(FJLCNCEHANP BPGGEPDHIDJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5EF97F0", Offset = "0x5EF7FF0", VA = "0x185EF97F0", Slot = "6")]
	public int IndexOf(FJLCNCEHANP BPGGEPDHIDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9A80", Offset = "0x5EF8280", VA = "0x185EF9A80", Slot = "8")]
	public void RemoveAt(int EAHCFBMNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5EF97B0", Offset = "0x5EF7FB0", VA = "0x185EF97B0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9930", Offset = "0x5EF8130", VA = "0x185EF9930")]
	public ONDHKEANMBD LLEMGPCMEFC()
	{
		return default(ONDHKEANMBD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9BA0", Offset = "0x5EF83A0", VA = "0x185EF9BA0", Slot = "16")]
	private IEnumerator<FJLCNCEHANP> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9C90", Offset = "0x5EF8490", VA = "0x185EF9C90", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HPPNLCPLKCJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int CABENEEBNLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> CKKALEFFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FJLCNCEHANP PMLIOOHDJND(FJLCNCEHANP BMDBFLNMJID);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JNCCPEPLPOL : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface IINGHKCNNJL : KEAPBKBLMIH, JHFKEPJCCJB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool MGKHEKGJIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	LCLOJHNLNIM FNJEOMIGHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	PGHGIAHDICM OKPENFGEPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	GBDIEBGLHGP KIJHILFFKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	PHDDEJCABNI LEOKHDFMDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	IHNNNELFMEH LFGMFKAJLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface JHFKEPJCCJB
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool GMFECAFJFIB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface PIFBNBJICMF
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOKEMEJBJOK(bool DOLICEBFIPF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface PHDDEJCABNI
{
	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool EPAMGOLIHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action AJMJPOAIHBK;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JFINLHFCLGM(bool KAJOKJADDID);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OLHIHDJLIGJ(ByteString KAGAAHEAJHB);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ABFLOIGACPO();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LMFHDGCNBDD();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FBOOLLKMJHC();
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface GBDIEBGLHGP
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	OFKKFGHIPBF FNJEOMIGHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	PGHGIAHDICM OKPENFGEPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	HNNICFOKLNH BKNHFAPGLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	IINGHKCNNJL HOMJFFDDFJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	EBBHMBBEAPN CFMNMIPNCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	MMDEAACPMIP ODEJGIOKIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	GFKKNNEMMJK GOOFFBDEIOD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	ENHFHOKJFEC HALCOAMCPKP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DHADOIAAHCF IEMMELKJPEB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	KHPHMFBMFOA CGHIGHCCMEP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	BAFGKLGLOEL ECLJFNBCLDO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	DFLPBBAHPBA PICIIDPKFEA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	DBBAHGDHKLF KKCNHNNNNJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	POFJJJJDDBG LHLJNBCEDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	NEICAFHEBDO CAHLMNECDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	HKLDLEIBNEI DOCAHNIJOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	BJFACHPCCMO EBDLNNNIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	AILGFLBOLPC MHNBMKJLKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	HHJHCMPNLAC PDIDCKNOBON
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	NBLEMHAJHCC ABDDPNDFACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	BPOBIDOGDCP AKODMPHIBHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(LJFBHDPICMB))]
public readonly struct FJLCNCEHANP : IComparable<FJLCNCEHANP>, IEquatable<FJLCNCEHANP>
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public static readonly FJLCNCEHANP MIOPHGKICKL;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int GKKLOILCCFC = 8;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int JMNOIBIMDPI = 24;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private const int PGKFCECAIHA = -16777216;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private const int BNNBLAAJMHD = 16777215;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LocalId HFMJJPJADMB;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public EBBHMBBEAPN CFMNMIPNCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB520", Offset = "0x5EE9D20", VA = "0x185EEB520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IINGHKCNNJL HOMJFFDDFJE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5EF01B0", Offset = "0x5EEE9B0", VA = "0x185EF01B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public LocalId AJHJICNJOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0710", Offset = "0x5EEEF10", VA = "0x185EF0710")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	internal IHNNNELFMEH LFGMFKAJLPP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0450", Offset = "0x5EEEC50", VA = "0x185EF0450")]
		get
		{
			return default(IHNNNELFMEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool ODPBAOJILCN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0210", Offset = "0x5EEEA10", VA = "0x185EF0210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool HOMAGJGJGIL
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0750", Offset = "0x5EEEF50", VA = "0x185EF0750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool OBMICBKAPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5EF07A0", Offset = "0x5EEEFA0", VA = "0x185EF07A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0920", Offset = "0x5EEF120", VA = "0x185EF0920")]
	public FJLCNCEHANP(EBBHMBBEAPN HPIDOAICBFD, LocalId HFMJJPJADMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
	public JKJMHBEMEOO JCHECFPPECN()
	{
		return default(JKJMHBEMEOO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5EF03D0", Offset = "0x5EEEBD0", VA = "0x185EF03D0")]
	public static LocalId DBFFIFAHFFL(FJLCNCEHANP IDBCMJPKGJN)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0410", Offset = "0x5EEEC10", VA = "0x185EF0410")]
	public static Entity DBFFIFAHFFL(FJLCNCEHANP IDBCMJPKGJN)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5EF05F0", Offset = "0x5EEEDF0", VA = "0x185EF05F0")]
	public static bool FMFPLPMCDAE(FJLCNCEHANP GIFKCLLLICD, FJLCNCEHANP KIOLHHMPBGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF9E0", Offset = "0x5EEE1E0", VA = "0x185EEF9E0")]
	public static bool EODFGAKKOLK(FJLCNCEHANP GIFKCLLLICD, FJLCNCEHANP KIOLHHMPBGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5EF07F0", Offset = "0x5EEEFF0", VA = "0x185EF07F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0460", Offset = "0x5EEEC60", VA = "0x185EF0460", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5EF02F0", Offset = "0x5EEEAF0", VA = "0x185EF02F0", Slot = "4")]
	public int CompareTo(FJLCNCEHANP FPJCFKAMJHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "5")]
	public bool Equals(FJLCNCEHANP FPJCFKAMJHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class BMDINKPFFNM
{
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5EECB60", Offset = "0x5EEB360", VA = "0x185EECB60")]
	public static CLJMLDOJEOF IFKDBDABAPM(this FJLCNCEHANP BEKFGDCEJDH)
	{
		return default(CLJMLDOJEOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x22CBF40", Offset = "0x22CA740", VA = "0x1822CBF40")]
	public static T NHLOKLCLCHP<T>(this FJLCNCEHANP BEKFGDCEJDH) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal sealed class LJFBHDPICMB
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct IHNNNELFMEH : IEquatable<IHNNNELFMEH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	internal readonly byte JDLDAOKCDAP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static byte[] GAGACMBIABE;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static EBBHMBBEAPN JMFABNPCFJH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static IINGHKCNNJL LFHFNCAJFDK;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static EBBHMBBEAPN[] DJLDDOIMOEL;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static IINGHKCNNJL[] CBFBMEDOMJO;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static Stack<byte> EDKGHGKKMJK;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IINGHKCNNJL HOMJFFDDFJE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5EF3520", Offset = "0x5EF1D20", VA = "0x185EF3520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public EBBHMBBEAPN IFGOLIFCBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5EF3DB0", Offset = "0x5EF25B0", VA = "0x185EF3DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4420", Offset = "0x5EF2C20", VA = "0x185EF4420")]
	static IHNNNELFMEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xBD0370", Offset = "0xBCEB70", VA = "0x180BD0370")]
	internal IHNNNELFMEH(byte DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x51B1970", Offset = "0x51B0170", VA = "0x1851B1970", Slot = "4")]
	public bool Equals(IHNNNELFMEH FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3620", Offset = "0x5EF1E20", VA = "0x185EF3620", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x19E7330", Offset = "0x19E5B30", VA = "0x1819E7330", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4360", Offset = "0x5EF2B60", VA = "0x185EF4360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3F20", Offset = "0x5EF2720", VA = "0x185EF3F20")]
	private static EBBHMBBEAPN NINCKFKEFLI(byte JDLDAOKCDAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3D00", Offset = "0x5EF2500", VA = "0x185EF3D00")]
	private static IINGHKCNNJL IIEALBNKLFP(byte JDLDAOKCDAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5EF36C0", Offset = "0x5EF1EC0", VA = "0x185EF36C0")]
	private static object FHBOAJBDAPB(byte JDLDAOKCDAP, object[] JCBAGKALIOD, object OGJIDOCEOED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3F10", Offset = "0x5EF2710", VA = "0x185EF3F10")]
	private static int LOMEFNGJAIP(byte JDLDAOKCDAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3610", Offset = "0x5EF1E10", VA = "0x185EF3610")]
	private static int CFKFJOPBJAA(byte JDLDAOKCDAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3E90", Offset = "0x5EF2690", VA = "0x185EF3E90")]
	private static (int, int) KKIJGFPIBNE(byte JDLDAOKCDAP)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3600", Offset = "0x5EF1E00", VA = "0x185EF3600")]
	private static byte BEPKDKDLEKD(int GLPKPIDPHCF, int EAHCFBMNNCF)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3830", Offset = "0x5EF2030", VA = "0x185EF3830")]
	internal static IHNNNELFMEH FPBPDBBEPKK(IINGHKCNNJL HNBBKFNICEA, EBBHMBBEAPN CGEHOEMIEMC)
	{
		return default(IHNNNELFMEH);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3AF0", Offset = "0x5EF22F0", VA = "0x185EF3AF0")]
	internal static void IEFPFAJOIAA(IHNNNELFMEH JDLDAOKCDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3FD0", Offset = "0x5EF27D0", VA = "0x185EF3FD0")]
	private static void OFFJLBEEFCN(int JHAJBCMGPDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface ENMJONBIFFC
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHLCPAGKDKE();

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LIHGGILHCLH(bool KAMNFNMLNJL);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GGBJKGOFPDB(GameObject AOMHCMIECFG);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface BDFHLGHGJOB
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	Guid KHNKEBHCNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DPIJGDLJGLD(Guid GCNLNJPKIJC, Guid JGKIFCNLLHB);

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task CPNIHBCIKCN(FJLCNCEHANP BOGNDFLHBHD);

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GJNFNMNKLDG(FJLCNCEHANP EAAFIBGEEGL, FJLCNCEHANP DEINPDMGBDC, [Out] Vector3 IELODMIJPLB, [Out] Quaternion JEACNADEOBC);

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AMJMFAOAOEG(LDOCIIAAAIP FBBKNJKBHPH, Vector3 IELODMIJPLB, Quaternion JEACNADEOBC);

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KJKGNMLMADI(FJLCNCEHANP KKGPBCBOCBA, [Out] Vector3 NDLDBHODLDL, [Out] Quaternion NINGHDFHFKF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface CALDMFGNNGH
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JACIEJHNBGO(MDCBEIJBKIC BMDBFLNMJID);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface PGHGIAHDICM
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	ENMJONBIFFC DHPNBNOCJPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	MGLNLMENHND PICBEENLIFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	GJFEPLLEIMI KIPDLFHCMIL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	BFHMLLMLHKN CHNEDOGBFFM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	NEODFHLHOJH DLDHHGNNMED
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	NALPAJNDMBL OOMGFOLPIKM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	NPBOLEJPJHP KNJPPJPLIBE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	GMIGKLCDBIG NKOCJIPANGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface CMDJHBDNNNO
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKEFPBCMDNE(Action KJDOCFCKCJE, bool FLOCGMJCLJC);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NGEGDJBCOHH(string PMDCAPIFBIP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface MGLNLMENHND
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	string GDBMFHNGFJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] OCNGLOPNHGE(IEnumerable<DDDHGAIPBMD> MODPINCOIGB);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LBKFEJEDAPG(GameObject AOMHCMIECFG, [Out] CLJMLDOJEOF[] HHCKJOMDIOJ);

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FKMOMNOKFFF(GameObject AOMHCMIECFG, [Out] int AAANMADLAHC, [Out] GNCNNCODHCF OINDNEFNLBC);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AHKCNJCIJHL LHDDCDIJNDN(DDDHGAIPBMD KOFJNFGLAFK);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AHKCNJCIJHL LHDDCDIJNDN(string HDHEPEBDFIJ, CLJMLDOJEOF[] AMCDBMBKIEK, Vector3 FLFCGPFDCMD, Quaternion JOBDANNFLEE, Vector3 AMKKNHFCFKO);

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GameObject JHOALGBFICJ(string HDHEPEBDFIJ);

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DDKNDLFCOEC(GameObject NOKGEBEEIOF, bool HCLEBKKJGIJ);

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EAHOCHJKDJM(GameObject AOMHCMIECFG, bool CGFCMCCLHKM, bool PGGNNAEJGJB);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class NOMABGLOFEA
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF91E0", Offset = "0x5EF79E0", VA = "0x185EF91E0")]
	public static AHKCNJCIJHL LHDDCDIJNDN(this MGLNLMENHND NFMOFHCEAPK, Vector3 FLFCGPFDCMD, Quaternion JOBDANNFLEE, Vector3 AMKKNHFCFKO, params CLJMLDOJEOF[] HHCKJOMDIOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface GJFEPLLEIMI
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDCOELHJCIM(bool KAJOKJADDID);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface BFHMLLMLHKN
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	bool OKGKKMGGLDC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	bool EMOEEOPMKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	bool OPGIDMDGEMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	int BIKFMNHFLIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool HJKBBICLPIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void IELKDNMCCHO(object IOHCLNMNKCI);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NOCMKFOEJIG(object IOHCLNMNKCI);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OHANKCPMNBM(object MAKBFCPADHF);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CCDHPMMOJAF(object MAKBFCPADHF);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	int JIFDJJGFKMM(GameObject FGGLKICLOCB);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PNFBHFOMPHG(NativeArray<int> DOPCFEGFCFP);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DAGMDCMINDP(NativeArray<int> KHNDMILKGBA);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void NNABFHOGJND();

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void EHAJOHNLGDP(uint JLLJIJMMALN, ReadOnlySpan<byte> AACIHFHDLDH, bool HGDNICEOKCI = false);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void EHAJOHNLGDP(uint JLLJIJMMALN, ReadOnlySpan<byte> AACIHFHDLDH, ReadOnlySpan<byte> MJNDDFOMDNK, bool HGDNICEOKCI = false);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface NEODFHLHOJH
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCOBIDCKFCE(GameObject AOMHCMIECFG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface CPNNGPOKBAI
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DMHLBCGEIIM(string OLDFIJBKFKG);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface LIKHICKNHFH
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OJPCOHLMCOG(GameObject AOMHCMIECFG);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJGLPDKLNOK(GameObject AOMHCMIECFG);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object DPPHFCLHJJI(FJLCNCEHANP HFMJJPJADMB, GameObject AOMHCMIECFG, Action<FJLCNCEHANP, int> CGEKFPDGHCG);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NDPHCJILNDH(GameObject AOMHCMIECFG, object CBDEBONJCEH);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface NALPAJNDMBL
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	int MIJPBPINDPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int EMEJILOPLJK(GameObject AOMHCMIECFG);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FAIHMHPMMDH([Out] Vector3 FLFCGPFDCMD);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DLCMDICLFFN();
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface NPBOLEJPJHP
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	bool EPAMGOLIHNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool AEMPDMFALAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface JIMBLAIILKP
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	IFFDDCGEFNF KMOKIDCBAFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	HNJLFENHCNO DBMHLJMCPBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LAGDADGDKDA(Transform MIODEBPOBDK);

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MALIMDOLBMD(Transform MIODEBPOBDK, JDKCICHPOHA JAPJHHICHLP);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HPIBJNDCPCD(Transform MIODEBPOBDK, OECNPGLBOAO LOFOCAHJJCH);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface GMIGKLCDBIG
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EFFBHILMLEK();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface BOCENMOKNKF
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KHHIFPKFCMN();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface FDOEFBONDNF
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GNCNNCODHCF PAPKJOPECAD(GameObject FGGLKICLOCB);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPLCKLFKDCM(GameObject AOMHCMIECFG, OFPFEMEMKND BDPMIJKKGJD, JKFEKAADPAK ACMIHKLEKKB);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	string HNOIIMPHAFN(int MBMFHFDDILC);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JLICFHMILNG(string OHNMLPMMMKK);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DLLBNGDDLGD(FJLCNCEHANP HFMJJPJADMB, int[] HHHIFIJEMFI);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PCMLEPAONBM(GameObject BKLPGPJDJDG, GameObject OKIONOGLFHK, int GJAKBABJHOH);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct HJABKJHNJMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal readonly KJJJMMAFKGJ IOPBDEDCAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal readonly KJJJMMAFKGJ BEDAKCMDPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal readonly uint BPKDAIFLPPN;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1CB0", Offset = "0x5EF04B0", VA = "0x185EF1CB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct KKDNPELKFHD
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static readonly DNJICJAPBOC KIDCMOJGGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal readonly HJABKJHNJMN KJDOCFCKCJE;

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5EECAC0", Offset = "0x5EEB2C0", VA = "0x185EECAC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct BIDEPAJCCKK
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private static readonly DNJICJAPBOC KIDCMOJGGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly HJABKJHNJMN KJDOCFCKCJE;

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5EECAC0", Offset = "0x5EEB2C0", VA = "0x185EECAC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public readonly struct IGMODNMKFJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	internal readonly uint BPKDAIFLPPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	internal readonly bool FBNBJBHPAJC;

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3480", Offset = "0x5EF1C80", VA = "0x185EF3480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct KJJJMMAFKGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	internal int IJJNAEFKMHG;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5840", Offset = "0x5EF4040", VA = "0x185EF5840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface IIGGHPFCNDF
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	EEDPCBKNGJM KCHHMCDIHIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum DCHHKJKKEMF
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
public interface AHKCNJCIJHL : IKPDMKNLDCP
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	DCHHKJKKEMF MIJDIKPGNGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool MJPPPODMJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	GameObject AOMHCMIECFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<AHKCNJCIJHL> MPFCAFGOGNP;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(HNNICFOKLNH DNLLEGGDMCL, FJLCNCEHANP HDKNFDOCBCK);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool CLLNDHLOPKC);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class DHKOCJAMCAK
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5EEEA80", Offset = "0x5EED280", VA = "0x185EEEA80")]
	public static bool PPKOCLCLIDA(this AHKCNJCIJHL MENCKDCJLGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE950", Offset = "0x5EED150", VA = "0x185EEE950")]
	public static bool HMHKDNMHONA(this AHKCNJCIJHL MENCKDCJLGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE9A0", Offset = "0x5EED1A0", VA = "0x185EEE9A0")]
	public static bool IFLLDEBOJDJ(this AHKCNJCIJHL MENCKDCJLGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE9F0", Offset = "0x5EED1F0", VA = "0x185EEE9F0")]
	public static bool MGKHEKGJIKL(this AHKCNJCIJHL MENCKDCJLGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface IKPDMKNLDCP
{
	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool PCAIHPKKNOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	FJLCNCEHANP PFLGGJNKOHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
internal interface APJDCFLFKBJ
{
	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<NCJGOKIHNBJ> IEHKIDMCJHF;
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface KNCOLNDLDAK : OLPOMALNMAD<CLJMLDOJEOF>, NEIBJPOFLLO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface CCKOFIFAJBG<T> : ACBMECBNHII<CLJMLDOJEOF, T>, OLPOMALNMAD<CLJMLDOJEOF>, NEIBJPOFLLO, IDisposable, KNCOLNDLDAK where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FEKEDBOBFBC
{
	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x24C2F00", Offset = "0x24C1700", VA = "0x1824C2F00")]
	public static bool HBIEMEKDBEG<T>(this OLPOMALNMAD<CLJMLDOJEOF> AHFKMNKCLNN, CLJMLDOJEOF AMCDBMBKIEK, [Out] T DOLICEBFIPF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x24C3070", Offset = "0x24C1870", VA = "0x1824C3070")]
	public static bool INHNMALGLOD<T>(this OLPOMALNMAD<CLJMLDOJEOF> AHFKMNKCLNN, CLJMLDOJEOF AMCDBMBKIEK, [In] T KNHFGCNBJCD) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface MFHPEDEHPLF : OLPOMALNMAD<FJLCNCEHANP>, NEIBJPOFLLO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface CLFFJCJMONN<T> : ACBMECBNHII<FJLCNCEHANP, T>, OLPOMALNMAD<FJLCNCEHANP>, NEIBJPOFLLO, IDisposable, MFHPEDEHPLF where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class PBMMEICKFPD
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x22C93F0", Offset = "0x22C7BF0", VA = "0x1822C93F0")]
	public static T BGCBNLKDELI<T>(this OLPOMALNMAD<FJLCNCEHANP> AHFKMNKCLNN, FJLCNCEHANP HFMJJPJADMB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x264D770", Offset = "0x264BF70", VA = "0x18264D770")]
	public static bool INHNMALGLOD<T>(this OLPOMALNMAD<FJLCNCEHANP> AHFKMNKCLNN, FJLCNCEHANP HFMJJPJADMB, [In] T KNHFGCNBJCD) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public struct JGOKKPNNOBP : IComparable<JGOKKPNNOBP>, IEquatable<JGOKKPNNOBP>
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly JGOKKPNNOBP MIOPHGKICKL;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static readonly JGOKKPNNOBP JFBAJIIPABO;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly JGOKKPNNOBP PADJNGGIEHH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static readonly JGOKKPNNOBP JHJJPPCANOM;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly JGOKKPNNOBP PEHNMPOHFKI;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public static readonly JGOKKPNNOBP AOGKOLFKPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int EGOJHBDPODL;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool AOJHDIBDAFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5EF47B0", Offset = "0x5EF2FB0", VA = "0x185EF47B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int LNCONKHLEFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5EF47A0", Offset = "0x5EF2FA0", VA = "0x185EF47A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x85FF00", Offset = "0x85E700", VA = "0x18085FF00")]
	public JGOKKPNNOBP(int EAHCFBMNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4840", Offset = "0x5EF3040", VA = "0x185EF4840", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5EF47C0", Offset = "0x5EF2FC0", VA = "0x185EF47C0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFC0", Offset = "0x7DC7C0", VA = "0x1807DDFC0", Slot = "5")]
	public bool Equals(JGOKKPNNOBP FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x171C6E0", Offset = "0x171AEE0", VA = "0x18171C6E0", Slot = "4")]
	public int CompareTo(JGOKKPNNOBP FPJCFKAMJHL)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0xD690D0", Offset = "0xD678D0", VA = "0x180D690D0")]
	public static JGOKKPNNOBP DBFFIFAHFFL(int EAHCFBMNNCF)
	{
		return default(JGOKKPNNOBP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0xD690D0", Offset = "0xD678D0", VA = "0x180D690D0")]
	public static int DBFFIFAHFFL(JGOKKPNNOBP GPPBGDKFIDI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5EF48A0", Offset = "0x5EF30A0", VA = "0x185EF48A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct JKJMHBEMEOO : IEquatable<JKJMHBEMEOO>, IKPDMKNLDCP
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly JKJMHBEMEOO PKHKOFMCADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public FJLCNCEHANP PFLGGJNKOHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920", Slot = "6")]
		get
		{
			return default(FJLCNCEHANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public BGGBFOLHJAN MJNMNKLDGHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(BGGBFOLHJAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public HKJJCLCIAHM ODEJGIOKIEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(HKJJCLCIAHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private EBBHMBBEAPN CFMNMIPNCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB520", Offset = "0x5EE9D20", VA = "0x185EEB520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public GameObject AOMHCMIECFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5180", Offset = "0x5EF3980", VA = "0x185EF5180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public CLJMLDOJEOF LKLEJGPLEHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4D10", Offset = "0x5EF3510", VA = "0x185EF4D10")]
		get
		{
			return default(CLJMLDOJEOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public BDLCFCMICHD PBPJDNJHMMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4E40", Offset = "0x5EF3640", VA = "0x185EF4E40")]
		get
		{
			return default(BDLCFCMICHD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public GNCNNCODHCF FLHOLBNNEEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5540", Offset = "0x5EF3D40", VA = "0x185EF5540")]
		get
		{
			return default(GNCNNCODHCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool KOBNILCAMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5070", Offset = "0x5EF3870", VA = "0x185EF5070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool CHGEJFEPODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5EF54E0", Offset = "0x5EF3CE0", VA = "0x185EF54E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool HACDHBOJCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5310", Offset = "0x5EF3B10", VA = "0x185EF5310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool CDFJPIEKAGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5330", Offset = "0x5EF3B30", VA = "0x185EF5330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool IDGGJKKOPCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5350", Offset = "0x5EF3B50", VA = "0x185EF5350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool NBBBLCAALKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5500", Offset = "0x5EF3D00", VA = "0x185EF5500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool AAEJOKIMJGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5090", Offset = "0x5EF3890", VA = "0x185EF5090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool GHIPKOPONCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4EF0", Offset = "0x5EF36F0", VA = "0x185EF4EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public IFPEFMLACEK HCNFIDMGNHH
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(IFPEFMLACEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public FGKHHLOJLMI OMJKANGEMJH
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(FGKHHLOJLMI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public EALOMDDNGJD KKCNHNNNNJC
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(EALOMDDNGJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public NDJEPJHCOHP NOHNPHIFFAI
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(NDJEPJHCOHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public LKDACGCJDDH PICIIDPKFEA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(LKDACGCJDDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public GEIHODHPOCI NPGMLACFKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(GEIHODHPOCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public LDOCIIAAAIP KDEDBIOMKBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(LDOCIIAAAIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public IOOGDDKIOHE HAIDHBAHACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(IOOGDDKIOHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool PPKOCLCLIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5EF4C20", Offset = "0x5EF3420", VA = "0x185EF4C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public bool ALCIBNILMFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5EF53B0", Offset = "0x5EF3BB0", VA = "0x185EF53B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public bool HHKLDLBMPJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5370", Offset = "0x5EF3B70", VA = "0x185EF5370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	private bool GFDCIOBDBHN
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x78D2A0", Offset = "0x78BAA0", VA = "0x18078D2A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public JKJMHBEMEOO(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5EED820", Offset = "0x5EEC020", VA = "0x185EED820")]
	public static bool DBFFIFAHFFL(JKJMHBEMEOO DOLICEBFIPF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
	public static FJLCNCEHANP DBFFIFAHFFL(JKJMHBEMEOO DOLICEBFIPF)
	{
		return default(FJLCNCEHANP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4EE0", Offset = "0x5EF36E0", VA = "0x185EF4EE0")]
	public static bool FMFPLPMCDAE(JKJMHBEMEOO GIFKCLLLICD, JKJMHBEMEOO KIOLHHMPBGL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF9E0", Offset = "0x5EEE1E0", VA = "0x185EEF9E0")]
	public static bool EODFGAKKOLK(JKJMHBEMEOO GIFKCLLLICD, JKJMHBEMEOO KIOLHHMPBGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4DB0", Offset = "0x5EF35B0", VA = "0x185EF4DB0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(JKJMHBEMEOO FPJCFKAMJHL)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
	public static JKJMHBEMEOO DBFFIFAHFFL(FJLCNCEHANP PDNACDIBMJE)
	{
		return default(JKJMHBEMEOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5100", Offset = "0x5EF3900", VA = "0x185EF5100")]
	public DDMJLICBBHL JBLLPLOILKG()
	{
		return default(DDMJLICBBHL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5EF50D0", Offset = "0x5EF38D0", VA = "0x185EF50D0")]
	public EPHNONKEIJO IFGDKGHIOKA()
	{
		return default(EPHNONKEIJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5020", Offset = "0x5EF3820", VA = "0x185EF5020")]
	public FOEOAGIMJGH HHEDKKMMACD()
	{
		return default(FOEOAGIMJGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4F10", Offset = "0x5EF3710", VA = "0x185EF4F10")]
	public void HEAJKAOIFAL([Optional] object JECMOKMEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5EF53F0", Offset = "0x5EF3BF0", VA = "0x185EF53F0")]
	public bool MKEKPLCNBLH(object JECMOKMEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4B30", Offset = "0x5EF3330", VA = "0x185EF4B30")]
	public bool ABMCPOIHLJC(object JECMOKMEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x5EF55E0", Offset = "0x5EF3DE0", VA = "0x185EF55E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct LDOCIIAAAIP : IEquatable<LDOCIIAAAIP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public FJLCNCEHANP PFLGGJNKOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(FJLCNCEHANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private EBBHMBBEAPN CFMNMIPNCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB520", Offset = "0x5EE9D20", VA = "0x185EEB520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	private GBDIEBGLHGP KIJHILFFKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6140", Offset = "0x5EF4940", VA = "0x185EF6140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	private HKLDLEIBNEI KDGOIDPDHHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6270", Offset = "0x5EF4A70", VA = "0x185EF6270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool GLJBFDBCAIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5DE0", Offset = "0x5EF45E0", VA = "0x185EF5DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public Guid LAOKAKDMILI
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5B00", Offset = "0x5EF4300", VA = "0x185EF5B00")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public bool CEEEKGOCAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5EF5F90", Offset = "0x5EF4790", VA = "0x185EF5F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public Guid JGKGMPNPHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6020", Offset = "0x5EF4820", VA = "0x185EF6020")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public LDOCIIAAAIP(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5EED820", Offset = "0x5EEC020", VA = "0x185EED820")]
	public static bool DBFFIFAHFFL(LDOCIIAAAIP DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5E70", Offset = "0x5EF4670", VA = "0x185EF5E70", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(LDOCIIAAAIP FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5D40", Offset = "0x5EF4540", VA = "0x185EF5D40")]
	public bool CCOMLNKJKIH([Out] Guid BDNPJKGJPHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF59E0", Offset = "0x5EF41E0", VA = "0x185EF59E0")]
	public void AFLHHFPJMNN(Guid IDCGMKDPLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF61D0", Offset = "0x5EF49D0", VA = "0x185EF61D0")]
	public bool NKBGNDFAOBN([Out] Guid IEJCDLJALPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5C20", Offset = "0x5EF4420", VA = "0x185EF5C20")]
	public void BOCKKGLLHGC(Guid IDCGMKDPLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5F00", Offset = "0x5EF4700", VA = "0x185EF5F00")]
	public void FBCJFFAHFDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public readonly struct FOEOAGIMJGH : IEquatable<FOEOAGIMJGH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public FJLCNCEHANP PFLGGJNKOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(FJLCNCEHANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private EBBHMBBEAPN CFMNMIPNCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB520", Offset = "0x5EE9D20", VA = "0x185EEB520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private GBDIEBGLHGP KIJHILFFKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0BE0", Offset = "0x5EEF3E0", VA = "0x185EF0BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private BJFACHPCCMO GKMHBFFOKIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0B80", Offset = "0x5EEF380", VA = "0x185EF0B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public float3 BECNNONCFDP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0C70", Offset = "0x5EEF470", VA = "0x185EF0C70")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public quaternion GLLKGPDOLGD
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0DA0", Offset = "0x5EEF5A0", VA = "0x185EF0DA0")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public JKJMHBEMEOO FMJGPKDMKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF0A60", Offset = "0x5EEF260", VA = "0x185EF0A60")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public FOEOAGIMJGH(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
	public static FJLCNCEHANP DBFFIFAHFFL(FOEOAGIMJGH DOLICEBFIPF)
	{
		return default(FJLCNCEHANP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0AF0", Offset = "0x5EEF2F0", VA = "0x185EF0AF0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(FOEOAGIMJGH FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct DDMJLICBBHL : IEquatable<DDMJLICBBHL>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class HCFJOHMDDDP : IEnumerable<JKJMHBEMEOO>, IEnumerable, IEnumerator<JKJMHBEMEOO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private JKJMHBEMEOO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DDMJLICBBHL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public DDMJLICBBHL <>3__<>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private IEnumerator<JKJMHBEMEOO> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IEnumerator<FJLCNCEHANP> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private JKJMHBEMEOO System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.RRObject>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x317C1F0", Offset = "0x317A9F0", VA = "0x18317C1F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(JKJMHBEMEOO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x5EF1A60", Offset = "0x5EF0260", VA = "0x185EF1A60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x33B2940", Offset = "0x33B1140", VA = "0x1833B2940")]
		[DebuggerHidden]
		public HCFJOHMDDDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1AB0", Offset = "0x5EF02B0", VA = "0x185EF1AB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1400", Offset = "0x5EEFC00", VA = "0x185EF1400", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1360", Offset = "0x5EEFB60", VA = "0x185EF1360")]
		private void JLELDKFKKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1920", Offset = "0x5EF0120", VA = "0x185EF1920")]
		private void PHMELMLAGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x5EF13B0", Offset = "0x5EEFBB0", VA = "0x185EF13B0")]
		private void MDIHJEHHKGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1A10", Offset = "0x5EF0210", VA = "0x185EF1A10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1970", Offset = "0x5EF0170", VA = "0x185EF1970", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JKJMHBEMEOO> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.RRObject>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1970", Offset = "0x5EF0170", VA = "0x185EF1970", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly DDMJLICBBHL PKHKOFMCADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public FJLCNCEHANP PFLGGJNKOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(FJLCNCEHANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public BGGBFOLHJAN MJNMNKLDGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(BGGBFOLHJAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public HKJJCLCIAHM ODEJGIOKIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(HKJJCLCIAHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private EBBHMBBEAPN CFMNMIPNCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB520", Offset = "0x5EE9D20", VA = "0x185EEB520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private GBDIEBGLHGP KIJHILFFKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE090", Offset = "0x5EEC890", VA = "0x185EEE090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	private MMDEAACPMIP FIECIINKLAM
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5EED9A0", Offset = "0x5EEC1A0", VA = "0x185EED9A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public MDCBEIJBKIC EMLJANANGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5EED5D0", Offset = "0x5EEBDD0", VA = "0x185EED5D0")]
		get
		{
			return default(MDCBEIJBKIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public IEnumerable<JKJMHBEMEOO> LFEDIAGMCGC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDB40", Offset = "0x5EEC340", VA = "0x185EEDB40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public IEnumerable<JKJMHBEMEOO> JNJCCHMEGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE6C0", Offset = "0x5EECEC0", VA = "0x185EEE6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int GIGGNGPEEOI
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDA00", Offset = "0x5EEC200", VA = "0x185EEDA00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int FFNJCIGOAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5EED560", Offset = "0x5EEBD60", VA = "0x185EED560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public string JOBPEPKBADK
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDA90", Offset = "0x5EEC290", VA = "0x185EEDA90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5EED690", Offset = "0x5EEBE90", VA = "0x185EED690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public EHHNKCGNLDK ENDNCDADPLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE660", Offset = "0x5EECE60", VA = "0x185EEE660")]
		get
		{
			return default(EHHNKCGNLDK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE580", Offset = "0x5EECD80", VA = "0x185EEE580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public KEOFIHPFFDL LPFHAJCIGDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5EED490", Offset = "0x5EEBC90", VA = "0x185EED490")]
		get
		{
			return default(KEOFIHPFFDL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE510", Offset = "0x5EECD10", VA = "0x185EEE510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public PICOLMPIMHA DJOODCLALOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE200", Offset = "0x5EECA00", VA = "0x185EEE200")]
		get
		{
			return default(PICOLMPIMHA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5EED7B0", Offset = "0x5EEBFB0", VA = "0x185EED7B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public float EANOCBINNGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE1A0", Offset = "0x5EEC9A0", VA = "0x185EEE1A0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDFC0", Offset = "0x5EEC7C0", VA = "0x185EEDFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool LHNOGHIBKHB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5EED740", Offset = "0x5EEBF40", VA = "0x185EED740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool KEPJEEPHHOF
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5EED4F0", Offset = "0x5EEBCF0", VA = "0x185EED4F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool NLKEMKGCFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5EED420", Offset = "0x5EEBC20", VA = "0x185EED420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool JKGLPECBBME
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDE60", Offset = "0x5EEC660", VA = "0x185EEDE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool NFANOKGOPEO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE030", Offset = "0x5EEC830", VA = "0x185EEE030")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5EEDED0", Offset = "0x5EEC6D0", VA = "0x185EEDED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool COBCPBKKOCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5EED940", Offset = "0x5EEC140", VA = "0x185EED940")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5EEE5F0", Offset = "0x5EECDF0", VA = "0x185EEE5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public DDMJLICBBHL(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5EED820", Offset = "0x5EEC020", VA = "0x185EED820")]
	public static bool DBFFIFAHFFL(DDMJLICBBHL DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5EED8B0", Offset = "0x5EEC0B0", VA = "0x185EED8B0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(DDMJLICBBHL FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x84A8F0", Offset = "0x8490F0", VA = "0x18084A8F0")]
	public static JKJMHBEMEOO DBFFIFAHFFL(DDMJLICBBHL EFKPBKMFDOG)
	{
		return default(JKJMHBEMEOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x5EED5B0", Offset = "0x5EEBDB0", VA = "0x185EED5B0")]
	public bool AKIBHJGPGLN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5EED840", Offset = "0x5EEC040", VA = "0x185EED840")]
	public bool EOFJLKMHHLL(NJCCEBHKLID FALDCKLPNKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE120", Offset = "0x5EEC920", VA = "0x185EEE120")]
	public void NABGENCMLHO(NJCCEBHKLID FALDCKLPNKF, bool DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5EEDCB0", Offset = "0x5EEC4B0", VA = "0x185EEDCB0")]
	public MDCBEIJBKIC IIJJLEJBJLO(Allocator BIOBDEGNFFO)
	{
		return default(MDCBEIJBKIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE260", Offset = "0x5EECA60", VA = "0x185EEE260")]
	public void NMIDCFNDOIJ(DDMJLICBBHL FPJCFKAMJHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5EEDF40", Offset = "0x5EEC740", VA = "0x185EEDF40")]
	[IteratorStateMachine(typeof(HCFJOHMDDDP))]
	public IEnumerable<JKJMHBEMEOO> LKLJNEEHPEM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct AAMHOKPHIEB : IEquatable<AAMHOKPHIEB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA120", Offset = "0x5EE8920", VA = "0x185EEA120", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(AAMHOKPHIEB FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public readonly struct FGKHHLOJLMI : IEquatable<FGKHHLOJLMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private EBBHMBBEAPN CFMNMIPNCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB520", Offset = "0x5EE9D20", VA = "0x185EEB520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public FGKHHLOJLMI(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0080", Offset = "0x5EEE880", VA = "0x185EF0080", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(FGKHHLOJLMI FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0110", Offset = "0x5EEE910", VA = "0x185EF0110")]
	public void PIODDHMICMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5EEFFE0", Offset = "0x5EEE7E0", VA = "0x185EEFFE0")]
	public void DEALLOBLBNA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct CCKMOALOKIL : IEquatable<CCKMOALOKIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5EECC50", Offset = "0x5EEB450", VA = "0x185EECC50", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(CCKMOALOKIL FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public readonly struct PGLAJFJGEMA : IEquatable<PGLAJFJGEMA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA0B0", Offset = "0x5EF88B0", VA = "0x185EFA0B0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(PGLAJFJGEMA FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct LFHGKCIPOAM : IEquatable<LFHGKCIPOAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5EF62D0", Offset = "0x5EF4AD0", VA = "0x185EF62D0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(LFHGKCIPOAM FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public readonly struct NJEGGBFMFHN : IEquatable<NJEGGBFMFHN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5EF9150", Offset = "0x5EF7950", VA = "0x185EF9150", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(NJEGGBFMFHN FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct HKJJCLCIAHM : IEquatable<HKJJCLCIAHM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public FJLCNCEHANP PFLGGJNKOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(FJLCNCEHANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private EBBHMBBEAPN CFMNMIPNCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB520", Offset = "0x5EE9D20", VA = "0x185EEB520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private GBDIEBGLHGP KIJHILFFKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5EF24B0", Offset = "0x5EF0CB0", VA = "0x185EF24B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	private MMDEAACPMIP FIECIINKLAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2230", Offset = "0x5EF0A30", VA = "0x185EF2230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public FJLCNCEHANP LALPEDNGECK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2540", Offset = "0x5EF0D40", VA = "0x185EF2540")]
		get
		{
			return default(FJLCNCEHANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public JKJMHBEMEOO LLPGCPJGINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2290", Offset = "0x5EF0A90", VA = "0x185EF2290")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public JKJMHBEMEOO NJGNBOOOJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2420", Offset = "0x5EF0C20", VA = "0x185EF2420")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public HKJJCLCIAHM(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF21A0", Offset = "0x5EF09A0", VA = "0x185EF21A0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(HKJJCLCIAHM FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5EF25D0", Offset = "0x5EF0DD0", VA = "0x185EF25D0")]
	public bool PJMHJPJDMME(JKJMHBEMEOO DEINPDMGBDC, bool CEJKGLNNMCM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2320", Offset = "0x5EF0B20", VA = "0x185EF2320")]
	public bool IMJHNADJNCP(JKJMHBEMEOO HNCIFHAHNEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1F10", Offset = "0x5EF0710", VA = "0x185EF1F10")]
	private void EGEHOHLAOEP(JKJMHBEMEOO ALKPCMKCBNE, List<JKJMHBEMEOO> BAPFJMBINPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x5EF23C0", Offset = "0x5EF0BC0", VA = "0x185EF23C0")]
	public void JAEGFJGCMPG(List<JKJMHBEMEOO> GCJGODAIBIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct IFPEFMLACEK : IEquatable<IFPEFMLACEK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public string EMOKHLCDPML
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5EF3360", Offset = "0x5EF1B60", VA = "0x185EF3360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public string KGMOFIGNDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2A70", Offset = "0x5EF1270", VA = "0x185EF2A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	private bool BKEEHODJEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2700", Offset = "0x5EF0F00", VA = "0x185EF2700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public string ODLIMEJFFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2980", Offset = "0x5EF1180", VA = "0x185EF2980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string KAPCPJEPHGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5EF3110", Offset = "0x5EF1910", VA = "0x185EF3110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public string IPADOCGJDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x5EF2840", Offset = "0x5EF1040", VA = "0x185EF2840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public IFPEFMLACEK(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EF28F0", Offset = "0x5EF10F0", VA = "0x185EF28F0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(IFPEFMLACEK FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EF2B40", Offset = "0x5EF1340", VA = "0x185EF2B40")]
	private static string NDKEEIEJBDL(GNCNNCODHCF FLLGEPOBBHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct IMBHHBGJMIB : IEquatable<IMBHHBGJMIB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4590", Offset = "0x5EF2D90", VA = "0x185EF4590", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(IMBHHBGJMIB FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct EALOMDDNGJD : IEquatable<EALOMDDNGJD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public EALOMDDNGJD(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5EEEAD0", Offset = "0x5EED2D0", VA = "0x185EEEAD0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(EALOMDDNGJD FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5EEEB60", Offset = "0x5EED360", VA = "0x185EEEB60")]
	public bool MNEFEBALPOG([Out] Collider NIHGMHGGAME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct NDJEPJHCOHP : IEquatable<NDJEPJHCOHP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public FJLCNCEHANP PFLGGJNKOHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(FJLCNCEHANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private EBBHMBBEAPN CFMNMIPNCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB520", Offset = "0x5EE9D20", VA = "0x185EEB520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private GBDIEBGLHGP KIJHILFFKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8BA0", Offset = "0x5EF73A0", VA = "0x185EF8BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private HLAOBDEFFDC ICOFPHEKDAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8860", Offset = "0x5EF7060", VA = "0x185EF8860")]
		get
		{
			return default(HLAOBDEFFDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private IBDGFGCOBMH EIHLJDKBMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EF89E0", Offset = "0x5EF71E0", VA = "0x185EF89E0")]
		get
		{
			return default(IBDGFGCOBMH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool BDBJFFFBHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5EF90A0", Offset = "0x5EF78A0", VA = "0x185EF90A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool PPKBJLGGNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5EF90E0", Offset = "0x5EF78E0", VA = "0x185EF90E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool HCAEGDLDOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8390", Offset = "0x5EF6B90", VA = "0x185EF8390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool HFJILJEBGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8240", Offset = "0x5EF6A40", VA = "0x185EF8240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool ACNJFAMOFFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8CA0", Offset = "0x5EF74A0", VA = "0x185EF8CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool MDMIEODCIGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8970", Offset = "0x5EF7170", VA = "0x185EF8970")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool IDEPKHNLNBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8EF0", Offset = "0x5EF76F0", VA = "0x185EF8EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool FIPKAICBMFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8C30", Offset = "0x5EF7430", VA = "0x185EF8C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public bool FAIJPFPGCKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8160", Offset = "0x5EF6960", VA = "0x185EF8160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool JNGFDJMLHKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8D10", Offset = "0x5EF7510", VA = "0x185EF8D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool BIPGFDLBLEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8A40", Offset = "0x5EF7240", VA = "0x185EF8A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool JPLJNDGNDIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8400", Offset = "0x5EF6C00", VA = "0x185EF8400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool NLCOCLFJJEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x5EF87F0", Offset = "0x5EF6FF0", VA = "0x185EF87F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool NGCCBBLLINO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8B30", Offset = "0x5EF7330", VA = "0x185EF8B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool NEFCFFEJLDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8D80", Offset = "0x5EF7580", VA = "0x185EF8D80")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8320", Offset = "0x5EF6B20", VA = "0x185EF8320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public NJOFGMOPKCA LOHGCFCLMAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8790", Offset = "0x5EF6F90", VA = "0x185EF8790")]
		get
		{
			return default(NJOFGMOPKCA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9030", Offset = "0x5EF7830", VA = "0x185EF9030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool BGHJLCKPMAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8560", Offset = "0x5EF6D60", VA = "0x185EF8560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public JKFEKAADPAK PCMFPCGOONA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8470", Offset = "0x5EF6C70", VA = "0x185EF8470")]
		get
		{
			return default(JKFEKAADPAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool CLDGGCIMGLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8730", Offset = "0x5EF6F30", VA = "0x185EF8730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Vector3 JAOBPNMFECN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8F60", Offset = "0x5EF7760", VA = "0x185EF8F60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 JOFIADMLMAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5EF88C0", Offset = "0x5EF70C0", VA = "0x185EF88C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public bool HKKNKKCBHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5EF8DF0", Offset = "0x5EF75F0", VA = "0x185EF8DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public NDJEPJHCOHP(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5EF84D0", Offset = "0x5EF6CD0", VA = "0x185EF84D0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(NDJEPJHCOHP FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5EF82B0", Offset = "0x5EF6AB0", VA = "0x185EF82B0")]
	public bool BKODDFJMJFK(IPOEGHJDMEB FALDCKLPNKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5EF81D0", Offset = "0x5EF69D0", VA = "0x185EF81D0")]
	public bool BBINGCOPLFA(OFPFEMEMKND FALDCKLPNKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8AB0", Offset = "0x5EF72B0", VA = "0x185EF8AB0")]
	public void MDOOGOIHBLI(OFPFEMEMKND FALDCKLPNKF, bool GEIAKGCFOAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public readonly struct GEIHODHPOCI : IEquatable<GEIHODHPOCI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	public FJLCNCEHANP PFLGGJNKOHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(FJLCNCEHANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	private EBBHMBBEAPN CFMNMIPNCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB520", Offset = "0x5EE9D20", VA = "0x185EEB520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	private GBDIEBGLHGP KIJHILFFKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5EF1070", Offset = "0x5EEF870", VA = "0x185EF1070")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public GEIHODHPOCI(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0F50", Offset = "0x5EEF750", VA = "0x185EF0F50", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(GEIHODHPOCI FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0EC0", Offset = "0x5EEF6C0", VA = "0x185EF0EC0")]
	public void ACAOCDDLKOD(bool DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5EF0FE0", Offset = "0x5EEF7E0", VA = "0x185EF0FE0")]
	public void LLHNPFCCBCO(bool DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x24D0FB0", Offset = "0x24CF7B0", VA = "0x1824D0FB0")]
	public T COBLMGKICOC<T>() where T : struct
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct LKDACGCJDDH : IEquatable<LKDACGCJDDH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public FJLCNCEHANP PFLGGJNKOHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(FJLCNCEHANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	private EBBHMBBEAPN CFMNMIPNCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB520", Offset = "0x5EE9D20", VA = "0x185EEB520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	private GBDIEBGLHGP KIJHILFFKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7430", Offset = "0x5EF5C30", VA = "0x185EF7430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	private DFLPBBAHPBA BPLPHCGALNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7260", Offset = "0x5EF5A60", VA = "0x185EF7260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private BPOBIDOGDCP AKODMPHIBHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7170", Offset = "0x5EF5970", VA = "0x185EF7170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public bool ODHBFDCGABJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5EF71D0", Offset = "0x5EF59D0", VA = "0x185EF71D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public bool AECKKMDIIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6D90", Offset = "0x5EF5590", VA = "0x185EF6D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool GPICGJMLGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5EF7590", Offset = "0x5EF5D90", VA = "0x185EF7590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool BNPADBFAKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5EF74C0", Offset = "0x5EF5CC0", VA = "0x185EF74C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool NIPJHLKNGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6A90", Offset = "0x5EF5290", VA = "0x185EF6A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool LMLNPIMBMNL
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6BD0", Offset = "0x5EF53D0", VA = "0x185EF6BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public bool OMLBDCBEBKI
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x5EF6F60", Offset = "0x5EF5760", VA = "0x185EF6F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool BOKHDLOODME
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5EF72C0", Offset = "0x5EF5AC0", VA = "0x185EF72C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public LKDACGCJDDH(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5EED820", Offset = "0x5EEC020", VA = "0x185EED820")]
	public static bool DBFFIFAHFFL(LKDACGCJDDH DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6C60", Offset = "0x5EF5460", VA = "0x185EF6C60", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(LKDACGCJDDH FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5EF75C0", Offset = "0x5EF5DC0", VA = "0x185EF75C0")]
	public bool PKLEPOOALGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6CF0", Offset = "0x5EF54F0", VA = "0x185EF6CF0")]
	public JKJMHBEMEOO FCILBJDPPEG(JKJMHBEMEOO MAKBFCPADHF)
	{
		return default(JKJMHBEMEOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6AC0", Offset = "0x5EF52C0", VA = "0x185EF6AC0")]
	public FJLCNCEHANP EEBMPDLCNJD()
	{
		return default(FJLCNCEHANP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6E30", Offset = "0x5EF5630", VA = "0x185EF6E30")]
	public void HADLHLGDOJF(FJLCNCEHANP MAKBFCPADHF, FJLCNCEHANP BLMAOJAGLDL, FJLCNCEHANP FMHFMMBINPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct EPHNONKEIJO : IEquatable<EPHNONKEIJO>
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly EPHNONKEIJO PKHKOFMCADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public FJLCNCEHANP PFLGGJNKOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(FJLCNCEHANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public BGGBFOLHJAN MJNMNKLDGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(BGGBFOLHJAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private CFLKFPPPBKO AANOJLPCEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF980", Offset = "0x5EEE180", VA = "0x185EEF980")]
		get
		{
			return default(CFLKFPPPBKO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public PMKACACGLKH KKOCDOELMAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF850", Offset = "0x5EEE050", VA = "0x185EEF850")]
		get
		{
			return default(PMKACACGLKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public FJDHPEOANNJ GAEMCEFMKEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF920", Offset = "0x5EEE120", VA = "0x185EEF920")]
		get
		{
			return default(FJDHPEOANNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public HBKPAPBEFDH CHCOECLMBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF7F0", Offset = "0x5EEDFF0", VA = "0x185EEF7F0")]
		get
		{
			return default(HBKPAPBEFDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public GODKMNPHHKF HBKDCGDBPBD
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFF70", Offset = "0x5EEE770", VA = "0x185EEFF70")]
		get
		{
			return default(GODKMNPHHKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public LJGCDAIHJKP MKBLHDKPDIP
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFA90", Offset = "0x5EEE290", VA = "0x185EEFA90")]
		get
		{
			return default(LJGCDAIHJKP);
		}
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF8B0", Offset = "0x5EEE0B0", VA = "0x185EEF8B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public KNFCOAIEJCG BJPJLDLBNBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFB70", Offset = "0x5EEE370", VA = "0x185EEFB70")]
		get
		{
			return default(KNFCOAIEJCG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFDB0", Offset = "0x5EEE5B0", VA = "0x185EEFDB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public float GLMLBHOMJCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFE20", Offset = "0x5EEE620", VA = "0x185EEFE20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFBD0", Offset = "0x5EEE3D0", VA = "0x185EEFBD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Vector3 DBBCMKPDLLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFE80", Offset = "0x5EEE680", VA = "0x185EEFE80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFAF0", Offset = "0x5EEE2F0", VA = "0x185EEFAF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public float GEKIAIMNDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFC40", Offset = "0x5EEE440", VA = "0x185EEFC40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public OFBPOHDPJIN.BCKPDGOHHMA BJDFNIDKEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF790", Offset = "0x5EEDF90", VA = "0x185EEF790")]
		get
		{
			return default(OFBPOHDPJIN.BCKPDGOHHMA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x5EEFF00", Offset = "0x5EEE700", VA = "0x185EEFF00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public EPHNONKEIJO(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5EED820", Offset = "0x5EEC020", VA = "0x185EED820")]
	public static bool DBFFIFAHFFL(EPHNONKEIJO DOLICEBFIPF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF9E0", Offset = "0x5EEE1E0", VA = "0x185EEF9E0")]
	public static bool EODFGAKKOLK(EPHNONKEIJO GIFKCLLLICD, EPHNONKEIJO KIOLHHMPBGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5EEFA00", Offset = "0x5EEE200", VA = "0x185EEFA00", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(EPHNONKEIJO FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEFD30", Offset = "0x5EEE530", VA = "0x185EEFD30")]
	public OEPFPOPEJGA IPGOLIAEPGG()
	{
		return default(OEPFPOPEJGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEFCB0", Offset = "0x5EEE4B0", VA = "0x185EEFCB0")]
	public POMILNCMMFE HMNFDAMJGHC()
	{
		return default(POMILNCMMFE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct OEPFPOPEJGA : IEquatable<OEPFPOPEJGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public FJLCNCEHANP PFLGGJNKOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(FJLCNCEHANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public EPHNONKEIJO BFAALOFNJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(EPHNONKEIJO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private LDAIENPBKIM JDBBENIIBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x5EF94B0", Offset = "0x5EF7CB0", VA = "0x185EF94B0")]
		get
		{
			return default(LDAIENPBKIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public ICDPOAEHPOL MBAAIBEICAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x5EF9450", Offset = "0x5EF7C50", VA = "0x185EF9450")]
		get
		{
			return default(ICDPOAEHPOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public OEPFPOPEJGA(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5EED820", Offset = "0x5EEC020", VA = "0x185EED820")]
	public static bool DBFFIFAHFFL(OEPFPOPEJGA DOLICEBFIPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF93C0", Offset = "0x5EF7BC0", VA = "0x185EF93C0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(OEPFPOPEJGA FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public readonly struct POMILNCMMFE : IEquatable<POMILNCMMFE>
{
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly POMILNCMMFE PKHKOFMCADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public FJLCNCEHANP PFLGGJNKOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(FJLCNCEHANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public BGGBFOLHJAN MJNMNKLDGHB
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(BGGBFOLHJAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	private EBBHMBBEAPN CFMNMIPNCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB520", Offset = "0x5EE9D20", VA = "0x185EEB520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	private GBDIEBGLHGP KIJHILFFKAF
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x5EFAB00", Offset = "0x5EF9300", VA = "0x185EFAB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	private KHPHMFBMFOA CGHIGHCCMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5EFAFF0", Offset = "0x5EF97F0", VA = "0x185EFAFF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public EPHNONKEIJO BFAALOFNJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(EPHNONKEIJO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public OFBDDCMINLP BPJKGGFOCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x5EFADB0", Offset = "0x5EF95B0", VA = "0x185EFADB0")]
		get
		{
			return default(OFBDDCMINLP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x5EFA950", Offset = "0x5EF9150", VA = "0x185EFA950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public IEnumerable<EHDGLMGLAOC> HJIBCJCKDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x5EFAC20", Offset = "0x5EF9420", VA = "0x185EFAC20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public EHDGLMGLAOC OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x5EFAEE0", Offset = "0x5EF96E0", VA = "0x185EFAEE0")]
		get
		{
			return default(EHDGLMGLAOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x5EFAB90", Offset = "0x5EF9390", VA = "0x185EFAB90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public POMILNCMMFE(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x5EED820", Offset = "0x5EEC020", VA = "0x185EED820")]
	public static bool DBFFIFAHFFL(POMILNCMMFE DOLICEBFIPF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4EE0", Offset = "0x5EF36E0", VA = "0x185EF4EE0")]
	public static bool FMFPLPMCDAE(POMILNCMMFE GIFKCLLLICD, POMILNCMMFE KIOLHHMPBGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA8C0", Offset = "0x5EF90C0", VA = "0x185EFA8C0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(POMILNCMMFE FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA360", Offset = "0x5EF8B60", VA = "0x185EFA360")]
	public EHDGLMGLAOC AEJOJCOAGAG(float3? FLFCGPFDCMD, [Optional] quaternion? JOBDANNFLEE, [Optional] Vector3? AMKKNHFCFKO)
	{
		return default(EHDGLMGLAOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA690", Offset = "0x5EF8E90", VA = "0x185EFA690")]
	public EHDGLMGLAOC DOGNCNLECIL(int EAHCFBMNNCF, float3? FLFCGPFDCMD, [Optional] quaternion? JOBDANNFLEE, [Optional] Vector3? AMKKNHFCFKO)
	{
		return default(EHDGLMGLAOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA580", Offset = "0x5EF8D80", VA = "0x185EFA580")]
	public void DIJEFKGDOIH(int EAHCFBMNNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x5EFAA70", Offset = "0x5EF9270", VA = "0x185EFAA70")]
	public void MJBDPJEPBJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct EHDGLMGLAOC : IEquatable<EHDGLMGLAOC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public FJLCNCEHANP PFLGGJNKOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(FJLCNCEHANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public POMILNCMMFE FJOLLOPPLPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5EEED40", Offset = "0x5EED540", VA = "0x185EEED40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public float3 HAONNNBKPIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x5EEEE30", Offset = "0x5EED630", VA = "0x185EEEE30")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x5EEEF40", Offset = "0x5EED740", VA = "0x185EEEF40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public quaternion MGBCJOLDJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF230", Offset = "0x5EEDA30", VA = "0x185EEF230")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF080", Offset = "0x5EED880", VA = "0x185EEF080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public float3 BAMAELJKNNP
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF150", Offset = "0x5EED950", VA = "0x185EEF150")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF2B0", Offset = "0x5EEDAB0", VA = "0x185EEF2B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public JKFHLDMIFKL JONLFPEKILC
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEECD0", Offset = "0x5EED4D0", VA = "0x185EEECD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	private AFEJAEOHIJC IIGENNFCLPK
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF020", Offset = "0x5EED820", VA = "0x185EEF020")]
		get
		{
			return default(AFEJAEOHIJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private EMAOOABBCBI OGFEMBEGIJP
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF1D0", Offset = "0x5EED9D0", VA = "0x185EEF1D0")]
		get
		{
			return default(EMAOOABBCBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private COMENGCLCIM PAKHBNCBANC
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF0F0", Offset = "0x5EED8F0", VA = "0x185EEF0F0")]
		get
		{
			return default(COMENGCLCIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	private POMLIOOENHF LHDEIINNLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x5EEEDD0", Offset = "0x5EED5D0", VA = "0x185EEEDD0")]
		get
		{
			return default(POMLIOOENHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	private EDBBMMEBENP NNLPDNPGJLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x5EEEFC0", Offset = "0x5EED7C0", VA = "0x185EEEFC0")]
		get
		{
			return default(EDBBMMEBENP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public EHDGLMGLAOC(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x5EEEEB0", Offset = "0x5EED6B0", VA = "0x185EEEEB0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(EHDGLMGLAOC FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEED40", Offset = "0x5EED540", VA = "0x185EEED40")]
	public void HBINFLPFEJH(POMILNCMMFE DOLICEBFIPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct BGGBFOLHJAN : IEquatable<BGGBFOLHJAN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public HKJJCLCIAHM ODEJGIOKIEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(HKJJCLCIAHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	private EBBHMBBEAPN CFMNMIPNCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB520", Offset = "0x5EE9D20", VA = "0x185EEB520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	private GFKKNNEMMJK NJJFDFLHGEE
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x5EEA750", Offset = "0x5EE8F50", VA = "0x185EEA750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public bool LNGKPEHIEHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB180", Offset = "0x5EE9980", VA = "0x185EEB180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public Vector3 HAONNNBKPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAE70", Offset = "0x5EE9670", VA = "0x185EEAE70")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB670", Offset = "0x5EE9E70", VA = "0x185EEB670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public Quaternion MGBCJOLDJFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC540", Offset = "0x5EEAD40", VA = "0x185EEC540")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x5EEBF00", Offset = "0x5EEA700", VA = "0x185EEBF00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public Vector3 EMMCDGJCGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB580", Offset = "0x5EE9D80", VA = "0x185EEB580")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC690", Offset = "0x5EEAE90", VA = "0x185EEC690")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public Quaternion NCMEEMHABEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB2B0", Offset = "0x5EE9AB0", VA = "0x185EEB2B0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB450", Offset = "0x5EE9C50", VA = "0x185EEB450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public float GMFFIOIPLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x5EEBCD0", Offset = "0x5EEA4D0", VA = "0x185EEBCD0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB50", Offset = "0x5EE9350", VA = "0x185EEAB50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public float MIMEPHPGCNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x5EEBFD0", Offset = "0x5EEA7D0", VA = "0x185EEBFD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public Vector3 BAMAELJKNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC140", Offset = "0x5EEA940", VA = "0x185EEC140")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC760", Offset = "0x5EEAF60", VA = "0x185EEC760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public Vector3 GMODLLOACIE
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x5EEB9B0", Offset = "0x5EEA1B0", VA = "0x185EEB9B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Matrix4x4 HJEEJBPOOLP
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x5EEC430", Offset = "0x5EEAC30", VA = "0x185EEC430")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public BGGBFOLHJAN(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB000", Offset = "0x5EE9800", VA = "0x185EEB000", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(BGGBFOLHJAN FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB400", Offset = "0x5EE9C00", VA = "0x185EEB400")]
	public BNGKBJDCOCA HIEGPNABLBE()
	{
		return default(BNGKBJDCOCA);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAA30", Offset = "0x5EE9230", VA = "0x185EEAA30")]
	public void BOGNIFBALLG([Out] Matrix4x4 JHMJPNGIPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBAA0", Offset = "0x5EEA2A0", VA = "0x185EEBAA0")]
	public void JGBEMBJBLEO([Out] Vector3 KPEABKLIFBC, [Out] Quaternion IHBPECFFDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEADC0", Offset = "0x5EE95C0", VA = "0x185EEADC0")]
	public void DHKKHHNPLFG([Out] RigidTransform KNHPIKDIKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBBE0", Offset = "0x5EEA3E0", VA = "0x185EEBBE0")]
	public JBHJMHDPGEH JKCJGANFBMK()
	{
		return default(JBHJMHDPGEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBC10", Offset = "0x5EEA410", VA = "0x185EEBC10")]
	public void JKCJGANFBMK([Out] JBHJMHDPGEH PLOFNCAPJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB1C0", Offset = "0x5EE99C0", VA = "0x185EEB1C0")]
	public JBHJMHDPGEH GJDCJIOHGBE()
	{
		return default(JBHJMHDPGEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB1F0", Offset = "0x5EE99F0", VA = "0x185EEB1F0")]
	public void GJDCJIOHGBE([Out] JBHJMHDPGEH KNHPIKDIKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB810", Offset = "0x5EEA010", VA = "0x185EEB810")]
	public Vector3 IIJFBMGDLBK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC830", Offset = "0x5EEB030", VA = "0x185EEC830")]
	public void PDILPDBJCBL([In] Vector3 DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB090", Offset = "0x5EE9890", VA = "0x185EEB090")]
	public Vector3 FDEPCAEJEJM()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA960", Offset = "0x5EE9160", VA = "0x185EEA960")]
	public void BFJKCNHEPNO([In] Vector3 DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC230", Offset = "0x5EEAA30", VA = "0x185EEC230")]
	public Quaternion NILMPCFCFKA()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA680", Offset = "0x5EE8E80", VA = "0x185EEA680")]
	public void AEIJNDLJMDG([In] Quaternion DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA810", Offset = "0x5EE9010", VA = "0x185EEA810")]
	public Quaternion BELFBLEIHGC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB740", Offset = "0x5EE9F40", VA = "0x185EEB740")]
	public void IHEDBHADJFM([In] Quaternion DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBE60", Offset = "0x5EEA660", VA = "0x185EEBE60")]
	public float LGFDGLDDEMG()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEB900", Offset = "0x5EEA100", VA = "0x185EEB900")]
	public void JBOMGLEMOII(float DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAF60", Offset = "0x5EE9760", VA = "0x185EEAF60")]
	public float EPPPLEPNPEA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC380", Offset = "0x5EEAB80", VA = "0x185EEC380")]
	public void NJEBKELABFA(float DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC070", Offset = "0x5EEA870", VA = "0x185EEC070")]
	public void NCJDCNPMOGC([In] Vector3 DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x5EEBD70", Offset = "0x5EEA570", VA = "0x185EEBD70")]
	public Vector3 LBMMKCBBEGO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5EEACF0", Offset = "0x5EE94F0", VA = "0x185EEACF0")]
	public void CNIDKOPEPMJ([In] Vector3 DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC9D0", Offset = "0x5EEB1D0", VA = "0x185EEC9D0")]
	public Vector3 PHKPNPKNNAJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC470", Offset = "0x5EEAC70", VA = "0x185EEC470")]
	public void ODABIIJGMAJ([In] Vector3 DOLICEBFIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAC00", Offset = "0x5EE9400", VA = "0x185EEAC00")]
	public Vector3 CLIHFJKEMIF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x5EEC900", Offset = "0x5EEB100", VA = "0x185EEC900")]
	public void PFNGMALHDIP([In] Vector3 DOLICEBFIPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct IOOGDDKIOHE : IEquatable<IOOGDDKIOHE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly FJLCNCEHANP PDNACDIBMJE;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public FJLCNCEHANP PFLGGJNKOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(FJLCNCEHANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public JKJMHBEMEOO CDMLGHFIAIH
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7DD920", Offset = "0x7DC120", VA = "0x1807DD920")]
		get
		{
			return default(JKJMHBEMEOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public int[] DDFAHKMEOGB
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x5EF46B0", Offset = "0x5EF2EB0", VA = "0x185EF46B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x1716150", Offset = "0x1714950", VA = "0x181716150")]
	public IOOGDDKIOHE(FJLCNCEHANP HFMJJPJADMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1C0", Offset = "0x5EE89C0", VA = "0x185EEA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4620", Offset = "0x5EF2E20", VA = "0x185EF4620", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1B0", Offset = "0x5EE89B0", VA = "0x185EEA1B0", Slot = "4")]
	public bool Equals(IOOGDDKIOHE FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA1F0", Offset = "0x5EE89F0", VA = "0x185EEA1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class KNJLNHOJLCB
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private struct KBPHKPMHDPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Guid CLGOKAHLILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public BDFDEAHBPED KLOBFJEPFLL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private struct BDFDEAHBPED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int DOLICEBFIPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int NODFCJEIABK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int JLLJIJMMALN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int PGBFCAPKACN;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x5EEA5E0", Offset = "0x5EE8DE0", VA = "0x185EEA5E0")]
		public bool FNNGMFNGOKA([Out] CLJMLDOJEOF AMCDBMBKIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EEA660", Offset = "0x5EE8E60", VA = "0x185EEA660")]
		public BDFDEAHBPED(CLJMLDOJEOF AMCDBMBKIEK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF5930", Offset = "0x5EF4130", VA = "0x185EF5930")]
	public static Guid CGLPMMDLMHD(this CLJMLDOJEOF AMCDBMBKIEK)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5EF59C0", Offset = "0x5EF41C0", VA = "0x185EF59C0")]
	public static bool GFBCCMJOODO(this Guid CLGOKAHLILM, [Out] CLJMLDOJEOF AMCDBMBKIEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal static class GGPNOIJLMNI
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5EF11D0", Offset = "0x5EEF9D0", VA = "0x185EF11D0")]
	public static GBDIEBGLHGP KIJHILFFKAF(this FJLCNCEHANP MBMFHFDDILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1100", Offset = "0x5EEF900", VA = "0x185EF1100")]
	public static HNNICFOKLNH BKNHFAPGLDB(this FJLCNCEHANP MBMFHFDDILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x5EF1260", Offset = "0x5EEFA60", VA = "0x185EF1260")]
	public static EntityManager POPOHHMPIDK(this FJLCNCEHANP MBMFHFDDILC)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x24D19B0", Offset = "0x24D01B0", VA = "0x1824D19B0")]
	public static T BKAPLMACONF<T>(this FJLCNCEHANP MBMFHFDDILC) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x24D2920", Offset = "0x24D1120", VA = "0x1824D2920")]
	public static bool GIPELKAEPHA<T>(this FJLCNCEHANP MBMFHFDDILC) where T : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x24D2BE0", Offset = "0x24D13E0", VA = "0x1824D2BE0")]
	public static bool LGOAPCMOEHM<T>(this FJLCNCEHANP MBMFHFDDILC) where T : struct, IBufferElementData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface HKLDLEIBNEI
{
	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CEEEKGOCAOJ(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GLJBFDBCAIG(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CCOMLNKJKIH(FJLCNCEHANP HFMJJPJADMB, [Out] Guid BDNPJKGJPHN);

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid KOMABJGMEGO(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AFLHHFPJMNN(FJLCNCEHANP HFMJJPJADMB, Guid BDNPJKGJPHN);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NKBGNDFAOBN(FJLCNCEHANP HFMJJPJADMB, [Out] Guid IEJCDLJALPH);

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid ANJKHMCMMIN(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BOCKKGLLHGC(FJLCNCEHANP HFMJJPJADMB, Guid IEJCDLJALPH);

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FBCJFFAHFDE(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AIPHALALPJK(FJLCNCEHANP EAAFIBGEEGL, FJLCNCEHANP DEINPDMGBDC);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface CMACAIIAAAK
{
	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	Guid KHNKEBHCNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IJMBADBMGFN(Guid BDNPJKGJPHN, Guid IEJCDLJALPH, string PMDCAPIFBIP);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface NBLEMHAJHCC
{
	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	IReadOnlyCollection<HEHMGDGCBDN> DEEPPFGKDIO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LKGCNDNBLBK(int IBDHJFPOKKL, [Out] HEHMGDGCBDN MFFFLDEOBCN);

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HEHMGDGCBDN FKFMGAGFIGJ(Type HJNJPNKDEFH);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class JMJJHNGCDOB
{
	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x2543E80", Offset = "0x2542680", VA = "0x182543E80")]
	public static T HNGGHMCNMAC<T>(this NBLEMHAJHCC MBJJDLLMFMH, Entity EIJPPJGEAJM) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x25432B0", Offset = "0x2541AB0", VA = "0x1825432B0")]
	public static HEHMGDGCBDN FKFMGAGFIGJ<T>(this NBLEMHAJHCC MBJJDLLMFMH) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface ELABLDEMCBL
{
	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CLJMLDOJEOF[] EFDAJOLKNMG(string PMDCAPIFBIP, JKJMHBEMEOO HDELNBPMPCL, bool IMAHPODDLIN = false);

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KHMODEJFLCI(string HDHEPEBDFIJ, CLJMLDOJEOF[] HHCKJOMDIOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface BJFACHPCCMO
{
	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<FJLCNCEHANP, FJLCNCEHANP> PPOOBAJLACE;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<FJLCNCEHANP, FJLCNCEHANP> GABKMHHCIHK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<FJLCNCEHANP, FJLCNCEHANP, FJLCNCEHANP> DMCGCDFOJHO;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<FJLCNCEHANP> CCNDPNDGHDG;

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DGINEONNKEJ(FJLCNCEHANP HFMJJPJADMB, FJLCNCEHANP KNDLKDNDEBC);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "9")]
	FJLCNCEHANP PGAOKBKBKLL(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IEnumerable<FJLCNCEHANP> BNEDGGDOODJ(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "11")]
	FJLCNCEHANP GNHPLLDHFIK(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FILPBEOLEAB(FJLCNCEHANP HFMJJPJADMB, Vector3 ILMBNEMBJNJ, Quaternion FMCBAIMBDBH);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BBGNFPFFMND(FJLCNCEHANP HFMJJPJADMB, float PCHJELNHBAN);

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool DLCEKNAOBGK(FJLCNCEHANP HFMJJPJADMB, [Out] RigidTransform CLPMHNHLOJI);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool OKIFCBOEJEO(FJLCNCEHANP HFMJJPJADMB, [Out] float DIANBEGECFP);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 MLPCABCDDMJ(FOEOAGIMJGH FDHKAPDFJBI);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion NPKMDMDEAAG(FOEOAGIMJGH FDHKAPDFJBI);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class FEOGOINAMCG
{
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface IICMFAOPAKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	object AAGDFDJOIAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JACIEJHNBGO(MDCBEIJBKIC BMDBFLNMJID);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public enum NDPOCCADJPO
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class FBFGKDAOAOJ
{
	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0xB3FA00", Offset = "0xB3E200", VA = "0x180B3FA00")]
	public static bool BOIPNNOHAKI(this NDPOCCADJPO KPFMIIFGAKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0xB3FA10", Offset = "0xB3E210", VA = "0x180B3FA10")]
	public static bool HDIMKLFGINF(this NDPOCCADJPO KPFMIIFGAKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2087390", Offset = "0x2085B90", VA = "0x182087390")]
	public static bool HKGCCFCHKPF(this NDPOCCADJPO KPFMIIFGAKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public enum HFMCKLHHLEA
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
public static class NMMCFCBINHC
{
	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0xD690D0", Offset = "0xD678D0", VA = "0x180D690D0")]
	public static int NGIIMEHHDJM(this HFMCKLHHLEA DOLICEBFIPF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface ANKPHGKIHGK
{
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface HHJHCMPNLAC
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	NDPOCCADJPO FKLHCPKPMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	NDPOCCADJPO EOIGGMACIMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	NDPOCCADJPO FGFKDLCBIDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	NDPOCCADJPO CCKDHKOCCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	NDPOCCADJPO NKBNMOPJEFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	NDPOCCADJPO GALIEIBPFIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	NDPOCCADJPO KKCNHNNNNJC
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	NDPOCCADJPO OEFFFABBMNP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	NDPOCCADJPO PKCDIHAFIAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	NDPOCCADJPO CAJMBDKKGIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	NDPOCCADJPO HOLIEKEJMOG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	NDPOCCADJPO PABHCOBNNBH
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	NDPOCCADJPO GKMHLEBAICC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface MMDEAACPMIP
{
	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action<NCJGOKIHNBJ> IEHKIDMCJHF;

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FJLCNCEHANP IKKBCFHHAKG(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AOIJHCNHONF(List<FJLCNCEHANP> GHHEFBMOBID);

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FJLCNCEHANP EKMIKGPLLFI(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PJMHJPJDMME(FJLCNCEHANP HFMJJPJADMB, FJLCNCEHANP DEINPDMGBDC, bool CEJKGLNNMCM);

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LBLDHOEHKON(FJLCNCEHANP HFMJJPJADMB, FJLCNCEHANP DEINPDMGBDC);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int BLKBODIPOFL(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MDCBEIJBKIC NICNPPEDOJK(FJLCNCEHANP PDNACDIBMJE);

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IEnumerable<FJLCNCEHANP> ICNHBHPNBDN(FJLCNCEHANP PDNACDIBMJE);

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool IABJOAGINOL(FJLCNCEHANP HFMJJPJADMB, FJLCNCEHANP LGJBFILLGLD);

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IMJHNADJNCP(FJLCNCEHANP HFMJJPJADMB, FJLCNCEHANP HNCIFHAHNEJ);

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FJLCNCEHANP LBCINNONLMD(FJLCNCEHANP MAKBFCPADHF, FJLCNCEHANP KONKFDHDLAA);

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool DHKPKLNNBCF(FJLCNCEHANP MAKBFCPADHF, FJLCNCEHANP KONKFDHDLAA, [Out] FJLCNCEHANP HBPLHDGAEGB);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public static class KCAIECACHPP
{
	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5EF56C0", Offset = "0x5EF3EC0", VA = "0x185EF56C0")]
	public static List<FJLCNCEHANP> AOIJHCNHONF(this MMDEAACPMIP FBPPNMFJDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x5EF57D0", Offset = "0x5EF3FD0", VA = "0x185EF57D0")]
	public static bool NPECNPKKINB(this MMDEAACPMIP FBPPNMFJDMG, FJLCNCEHANP HFMJJPJADMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface BBFGKGPKMKP
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	bool OBMHDKDDNOE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	bool OFBKOKCBMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface OCBMMPPHJLA : PBFKCKHIMCE
{
	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FCJKOLOHMGE(Entity EIJPPJGEAJM, [Out] IFPMDDJLALE JDLDAOKCDAP);

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCEIIHLOOBN(NativeArray<IFPMDDJLALE> GAGACMBIABE, NativeArray<AEBIPFLLKMA> GBPNIILDPBD);

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PEKMPCOMIKG(IFPMDDJLALE JDLDAOKCDAP);

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KOHIFAGLDJH(IFPMDDJLALE JDLDAOKCDAP, [Out] Collider NIHGMHGGAME);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface PBFKCKHIMCE
{
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGNDPCJKCHL([In] float3 LNINLMPACDM, [In] float3 HDJKLLNHJHP, float EMBKCPDDBCB, Allocator BIOBDEGNFFO, [Out] NativeArray<Entity> EBDADEJKLEM);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface BAFGKLGLOEL
{
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GGNDPCJKCHL([In] float3 LNINLMPACDM, [In] float3 HDJKLLNHJHP, float EMBKCPDDBCB, [Out] ELJBEJCHOAH NNDGMAALBFA, [Out] FJLCNCEHANP GOKMMBCCHCF);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface OCGCPAJJDKI
{
	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGNDPCJKCHL([In] NativeArray<Entity> EBDADEJKLEM, [In] float3 LNINLMPACDM, [In] float3 HDJKLLNHJHP, [In] NativeArray<ELJBEJCHOAH> IGFDLEEMLBH);
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public struct IFPMDDJLALE : DHALIGBDNKA, IEquatable<IFPMDDJLALE>
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public int EGOJHBDPODL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x85FEF0", Offset = "0x85E6F0", VA = "0x18085FEF0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x85FF00", Offset = "0x85E700", VA = "0x18085FF00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public int DJCMCJGIECP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x209E4E0", Offset = "0x209CCE0", VA = "0x18209E4E0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x5302BF0", Offset = "0x53013F0", VA = "0x185302BF0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5EF33E0", Offset = "0x5EF1BE0", VA = "0x185EF33E0", Slot = "8")]
	public bool Equals(IFPMDDJLALE FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5EF3430", Offset = "0x5EF1C30", VA = "0x185EF3430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public struct ELJBEJCHOAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float NHGEKKCODNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 HMKNLJLLNBH;
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface GDMJOBOEOBP
{
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface EBBHMBBEAPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	GBDIEBGLHGP KIJHILFFKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	IHNNNELFMEH LFGMFKAJLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<MDCBEIJBKIC, NativeArray<GNCNNCODHCF>> IELALEJEDFF;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<MDCBEIJBKIC> KAPCNPGOOGF;

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BDLCFCMICHD NKEEDENDHBA(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GNCNNCODHCF BGGCNMLFBCA(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FPBPDBBEPKK(CLJMLDOJEOF AMCDBMBKIEK, AHKCNJCIJHL MENCKDCJLGO);

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void IFOANMCBFMB(CLJMLDOJEOF[] HHCKJOMDIOJ, GameObject AOMHCMIECFG);

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JKJMHBEMEOO HEAJKAOIFAL(FJLCNCEHANP HFMJJPJADMB, [Optional] object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DIMCHLOJIHL(FJLCNCEHANP HFMJJPJADMB, [Out] AHKCNJCIJHL MENCKDCJLGO);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool OHDKPDNBOJL(FJLCNCEHANP HFMJJPJADMB, [Out] Transform MIODEBPOBDK);

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool PPKOCLCLIDA(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DMAKIOHNDBF(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MKEKPLCNBLH(LocalId HFMJJPJADMB, object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool ABMCPOIHLJC(LocalId HFMJJPJADMB, object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "17")]
	FJLCNCEHANP GBNDIHOPDHG(CLJMLDOJEOF AMCDBMBKIEK);

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool GPPDBLMNJJH(CLJMLDOJEOF AMCDBMBKIEK, [Out] FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(Slot = "19")]
	CLJMLDOJEOF IFKDBDABAPM(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(Slot = "20")]
	MDCBEIJBKIC GBNDIHOPDHG(NativeArray<CLJMLDOJEOF> AMCDBMBKIEK, Allocator BIOBDEGNFFO);

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "21")]
	MDCBEIJBKIC MPJLFHDKDFP(NativeArray<CLJMLDOJEOF> AMCDBMBKIEK, NativeArray<JHMMPBEDAMP> LBKPDHJHKDC, Allocator BIOBDEGNFFO);

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(Slot = "22")]
	CLJMLDOJEOF[] EFDAJOLKNMG(string HDHEPEBDFIJ, JKJMHBEMEOO HDELNBPMPCL, bool IMAHPODDLIN);

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KHMODEJFLCI(string HDHEPEBDFIJ, CLJMLDOJEOF[] HHCKJOMDIOJ);

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(Slot = "24")]
	JKJMHBEMEOO JFBAJIIPABO(GNCNNCODHCF OINDNEFNLBC, bool AAAMFLHHBHA);

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(Slot = "25")]
	JKJMHBEMEOO JFBAJIIPABO(GNCNNCODHCF OINDNEFNLBC);

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(Slot = "26")]
	JKJMHBEMEOO NLFKDIACLKC(GNCNNCODHCF OINDNEFNLBC);

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(Slot = "27")]
	JKJMHBEMEOO KBPKCHHFGGD(GNCNNCODHCF OINDNEFNLBC);

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "28")]
	JKJMHBEMEOO MPJLFHDKDFP(CLJMLDOJEOF AMCDBMBKIEK, GNCNNCODHCF OINDNEFNLBC);

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	DDMJLICBBHL MFMBEEMNPGH();

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	POMILNCMMFE BLIPJAMKGEN();

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	OEPFPOPEJGA IIAGGGPFILD(ICDPOAEHPOL NNCOIGOGBFH);

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void DEALLOBLBNA(MDCBEIJBKIC BMDBFLNMJID);

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void PIODDHMICMM(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void BJFKJIDOLLN(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void DEALLOBLBNA(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(Slot = "36")]
	MDCBEIJBKIC AEBMBCKHMFG(MDCBEIJBKIC OLNPHGMIIPH, Allocator BIOBDEGNFFO);

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(Slot = "37")]
	bool ODPBAOJILCN(FJLCNCEHANP HFMJJPJADMB);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public static class LIGANMGPGOO
{
	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x5EF65B0", Offset = "0x5EF4DB0", VA = "0x185EF65B0")]
	public static void DMAKIOHNDBF(this EBBHMBBEAPN CGBBLBLFEGC, AHKCNJCIJHL MENCKDCJLGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6360", Offset = "0x5EF4B60", VA = "0x185EF6360")]
	public static JKJMHBEMEOO BEJICKKOJHN(this EBBHMBBEAPN CGBBLBLFEGC, LocalId HFMJJPJADMB)
	{
		return default(JKJMHBEMEOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6360", Offset = "0x5EF4B60", VA = "0x185EF6360")]
	public static FJLCNCEHANP GBNDIHOPDHG(this EBBHMBBEAPN CGBBLBLFEGC, LocalId HFMJJPJADMB)
	{
		return default(FJLCNCEHANP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6940", Offset = "0x5EF5140", VA = "0x185EF6940")]
	public static CLJMLDOJEOF IFKDBDABAPM(this EBBHMBBEAPN CGBBLBLFEGC, LocalId HFMJJPJADMB)
	{
		return default(CLJMLDOJEOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF69C0", Offset = "0x5EF51C0", VA = "0x185EF69C0")]
	public static bool ODPBAOJILCN(this EBBHMBBEAPN CGBBLBLFEGC, CLJMLDOJEOF AMCDBMBKIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2575540", Offset = "0x2573D40", VA = "0x182575540")]
	public static T NHLOKLCLCHP<T>(this EBBHMBBEAPN CGBBLBLFEGC, LocalId HFMJJPJADMB) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6740", Offset = "0x5EF4F40", VA = "0x185EF6740")]
	public static DDMJLICBBHL FPFANJCNAKJ(this EBBHMBBEAPN CGBBLBLFEGC, RigidTransform PLOFNCAPJIB, [Optional] object JECMOKMEJED)
	{
		return default(DDMJLICBBHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6630", Offset = "0x5EF4E30", VA = "0x185EF6630")]
	public static OEPFPOPEJGA FMDLHIDHIEH(this EBBHMBBEAPN CGBBLBLFEGC, ICDPOAEHPOL PNLNDKLDCJM, RigidTransform PLOFNCAPJIB, [Optional] object JECMOKMEJED)
	{
		return default(OEPFPOPEJGA);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6840", Offset = "0x5EF5040", VA = "0x185EF6840")]
	public static POMILNCMMFE GOFIGHFFNNP(this EBBHMBBEAPN CGBBLBLFEGC, RigidTransform PLOFNCAPJIB, [Optional] object JECMOKMEJED)
	{
		return default(POMILNCMMFE);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x5EF6390", Offset = "0x5EF4B90", VA = "0x185EF6390")]
	private static void DLCLGDIPLJG(JKJMHBEMEOO NJGGAOBGGOC, RigidTransform PLOFNCAPJIB, [Optional] object JECMOKMEJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface DFLPBBAHPBA
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	bool EGCMCOGPFOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	FJLCNCEHANP FAFAAALJJJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	JKJMHBEMEOO HOGAOEPACKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event INPLAJJPLAP HGAGMDCBIHA;

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FJLCNCEHANP LBCINNONLMD(FJLCNCEHANP MAKBFCPADHF, FJLCNCEHANP KONKFDHDLAA);

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DHKPKLNNBCF(FJLCNCEHANP MAKBFCPADHF, FJLCNCEHANP KONKFDHDLAA, [Out] FJLCNCEHANP HBPLHDGAEGB);

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void AJEKDPJFEDP();

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CODIEHCMGCN();

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool ODHBFDCGABJ(FJLCNCEHANP MAKBFCPADHF);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LMLNPIMBMNL(FJLCNCEHANP MAKBFCPADHF);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public delegate void INPLAJJPLAP(JKJMHBEMEOO KDOOOBJDKND, JKJMHBEMEOO IHCNEOIAGJH);
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class DGFEOAFAIHE
{
	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE870", Offset = "0x5EED070", VA = "0x185EEE870")]
	public static bool FNMLLHFABBH(this DFLPBBAHPBA AFNKIIPOANB, FJLCNCEHANP MAKBFCPADHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x5EEE7F0", Offset = "0x5EECFF0", VA = "0x185EEE7F0")]
	public static bool BNPADBFAKPH(this DFLPBBAHPBA AFNKIIPOANB, FJLCNCEHANP MAKBFCPADHF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface OGGGLCKNIHE
{
	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPENGKHPFGE(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GPPOMINACKD(FJLCNCEHANP HFMJJPJADMB, Transform MIODEBPOBDK);
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface BPOBIDOGDCP
{
	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HADLHLGDOJF(FJLCNCEHANP MAKBFCPADHF, FJLCNCEHANP BLMAOJAGLDL, FJLCNCEHANP FMHFMMBINPI);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FJLCNCEHANP JOGKKFFEPLB(FJLCNCEHANP MAKBFCPADHF);
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface NEICAFHEBDO
{
	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACAOCDDLKOD(FJLCNCEHANP PDNACDIBMJE, bool DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLHNPFCCBCO(FJLCNCEHANP PDNACDIBMJE, bool DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AEOHOIFFAIH(FJLCNCEHANP PDNACDIBMJE, int DOLICEBFIPF);
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface KHPHMFBMFOA
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<FJLCNCEHANP> HJKCGGGKCOP(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FJLCNCEHANP DCPBNBICKOJ(FJLCNCEHANP HFMJJPJADMB, int EAHCFBMNNCF);

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int GEBDEMNKIBK(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OFBDDCMINLP LELOJFDJOHJ(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LGODIOJFMEM(FJLCNCEHANP HFMJJPJADMB, OFBDDCMINLP ICGNFMFDOBD);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FJLCNCEHANP ANAIMAFBPDF(FJLCNCEHANP HFMJJPJADMB, [Optional] float3? FLFCGPFDCMD, [Optional] quaternion? JOBDANNFLEE, [Optional] float3? AMKKNHFCFKO);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FJLCNCEHANP AICCMOKBIKP(FJLCNCEHANP HFMJJPJADMB, int EAHCFBMNNCF, [Optional] float3? FLFCGPFDCMD, [Optional] quaternion? JOBDANNFLEE, [Optional] float3? AMKKNHFCFKO);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CCBFLDJNNII(FJLCNCEHANP HFMJJPJADMB, int EAHCFBMNNCF);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HNJKAPOOPJI(FJLCNCEHANP HFMJJPJADMB);
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface MNBGKNGJIGD
{
	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFECHHLKOFA();

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ABNKCDGFHLC();

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FDOANNABGGE();

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GJMKFEBOMHO();

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MAPHDDDBMMK();

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JHHHFMPMLKN();

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FGLEOHPGMOP();

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LGJBJAHBFKO();

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void POMAJDMDIPK();

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JCCOPHCPPPA();

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EEHAEBEJHOF();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface GFKKNNEMMJK
{
	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBPEEMEAAGI(Entity EIJPPJGEAJM);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDILPDBJCBL(Entity EIJPPJGEAJM, [In] float3 DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 IIJFBMGDLBK(Entity EIJPPJGEAJM);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AEIJNDLJMDG(Entity EIJPPJGEAJM, [In] quaternion DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion NILMPCFCFKA(Entity EIJPPJGEAJM);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JGBEMBJBLEO(Entity EIJPPJGEAJM, [Out] float3 FLFCGPFDCMD, [Out] quaternion JOBDANNFLEE);

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JGBEMBJBLEO(Entity EIJPPJGEAJM, [Out] RigidTransform EHPMOHOPBBK);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DHKKHHNPLFG(Entity EIJPPJGEAJM, [Out] RigidTransform EHPMOHOPBBK);

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 MFGEHEBIAMJ(Entity EIJPPJGEAJM);

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NCJDCNPMOGC(Entity EIJPPJGEAJM, [In] float3 DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JBOMGLEMOII(Entity EIJPPJGEAJM, float DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float LGFDGLDDEMG(Entity EIJPPJGEAJM);

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ODABIIJGMAJ(Entity EIJPPJGEAJM, [In] float3 DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 PHKPNPKNNAJ(Entity EIJPPJGEAJM);

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BFJKCNHEPNO(Entity EIJPPJGEAJM, [In] float3 DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 FDEPCAEJEJM(Entity EIJPPJGEAJM);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void IHEDBHADJFM(Entity EIJPPJGEAJM, [In] quaternion DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion BELFBLEIHGC(Entity EIJPPJGEAJM);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 LBMMKCBBEGO(Entity EIJPPJGEAJM);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void CNIDKOPEPMJ(Entity EIJPPJGEAJM, [In] float3 DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void NJEBKELABFA(Entity EIJPPJGEAJM, float DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float EPPPLEPNPEA(Entity EIJPPJGEAJM);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PFNGMALHDIP(Entity EIJPPJGEAJM, [In] float3 DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 CLIHFJKEMIF(Entity EIJPPJGEAJM);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JDIKIIJDCCM(Entity EIJPPJGEAJM, [Out] float4x4 JHMJPNGIPCF);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void EJECELGGKBC(Entity EIJPPJGEAJM, [In] float4x4 JHMJPNGIPCF);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void KMMOAKBEAJC(Entity EIJPPJGEAJM, [Out] float4x4 JHMJPNGIPCF);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool OHDKPDNBOJL(Entity EIJPPJGEAJM, [Out] Transform MIODEBPOBDK);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CFBCNGIPEMP(Entity EIJPPJGEAJM);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void GAEDPJNIBHC(Entity EIJPPJGEAJM, Entity ACEPEIHNGGC, Entity AKJKKHGAFEH);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class PCBCJANKBEH
{
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface CBCJLLIGGMH
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World NIOKDCBEHAM(string FADBLBAKNFB = "Main");

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World FHBOMMOEENB(string FADBLBAKNFB = "Shadow");

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World KPGPGIBPBGC(string FADBLBAKNFB = "Deserialization");

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World OBJMNFMIBOI(string FADBLBAKNFB = "Serialization");
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface HNNICFOKLNH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	World NDDDABCMCNG
	{
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	World FICDANAGDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	EntityManager POPOHHMPIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	bool MGKHEKGJIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase PLECBOKBDNF(Type HJNJPNKDEFH);
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public static class PJKGJHELPBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x5EFA140", Offset = "0x5EF8940", VA = "0x185EFA140")]
	public static ComponentSystemBase NOCGCEKMEFM(this World DNLLEGGDMCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x26589E0", Offset = "0x26571E0", VA = "0x1826589E0")]
	public static T PLECBOKBDNF<T>(this HNNICFOKLNH LOGGBDOCMIL) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface GKJGKMEHOBF
{
	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IJEIDBBIPCK(NativeListAsync<Entity> JLLMAMMPAEA);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KNINHKKGPMD(PCLEHDDGJMO EIAJHNMKAPB);

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNPCEJHKBNK(NativeListAsync<Entity> CGJLMPBCIEK, bool FNGMGPKOOFC);

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFKFBPJHHDH();
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface DBBAHGDHKLF
{
	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OIJIGELGEJH(FJLCNCEHANP HFMJJPJADMB, [Out] Collider NIHGMHGGAME);

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject HFBCEFIOFCC(FJLCNCEHANP NFOHKGCKCGI, GameObject NAGIIHEFDNK, Vector3 ENHKIKKDBOC, Quaternion AOABADNNGMN);

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KLKBLEFGAKF(GameObject NIHGMHGGAME);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider MNPJACJDAAG<TCollider>(GameObject IGDDCHFJBMC) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MJCPLFPDJAI(Collider NIHGMHGGAME);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject LKCLHOADEGP<TCollider>(string PMDCAPIFBIP) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface GBKPLOEDPJB
{
	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJLIIHBJKMH(FJLCNCEHANP HFMJJPJADMB, EHHNKCGNLDK CMIEPKAPOJP, bool IHMEODGLHBA, NJCCEBHKLID FMLHOPLFLEP);

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKDBNDDGPBC(FJLCNCEHANP HFMJJPJADMB, EHHNKCGNLDK CMIEPKAPOJP, bool IHMEODGLHBA, bool IABJGKHPMFB, bool IBJHBLOHPGH);

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ILDFPLGPFLI GNJHIOOAOKF(FJLCNCEHANP PHEKGOFMNOB, List<FJLCNCEHANP> DLIHOOBLJII);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ABPOICOMKND(GameObject AKIJDDGCNAE, GameObject JMFJDKLAAHL);

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OLDHDNEAFEA(GameObject JMFJDKLAAHL);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T MNPJACJDAAG<T>(GameObject IGDDCHFJBMC) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MJCPLFPDJAI(Collider NIHGMHGGAME);

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject DMHHMKIKCFI<T>(string PMDCAPIFBIP) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface AILGFLBOLPC
{
	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMJEABAPJOP(FJLCNCEHANP HFMJJPJADMB, BKONHFHHNPH DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BKONHFHHNPH IDAPGELJDIE(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void INCJAOOAMKN(FJLCNCEHANP HFMJJPJADMB, FJLCNCEHANP DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BFNAGAOKBLP(FJLCNCEHANP HFMJJPJADMB, FJLCNCEHANP DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BLKBODIPOFL(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FJLCNCEHANP BKEDDCOCJKJ(FJLCNCEHANP HFMJJPJADMB, int EAHCFBMNNCF);

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NEELIDCOLGG(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LFCOFKFFNLL(FJLCNCEHANP HFMJJPJADMB, object JECMOKMEJED, FJLCNCEHANP DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HENKNJNKJCP(FJLCNCEHANP HFMJJPJADMB, object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MPIOPDBKLPD(FJLCNCEHANP HFMJJPJADMB, [Out] FJLCNCEHANP DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LIHNKGENKMP(FJLCNCEHANP HFMJJPJADMB, float3 DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OHFFMELLPBJ(FJLCNCEHANP HFMJJPJADMB, [Out] float3 DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IKFMPICLEGF(FJLCNCEHANP HFMJJPJADMB, float3 DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool BMEGDLPDJBP(FJLCNCEHANP HFMJJPJADMB, [Out] float3 DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void AMNMHIELMGL(FJLCNCEHANP HFMJJPJADMB, (Quaternion rot, Vector3 moments) BGCIDCLPDOE);

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool LIOFJFCLEFD(FJLCNCEHANP HFMJJPJADMB, [Out] quaternion JEACNADEOBC, [Out] float3 BJOOOJEBFBF);

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ENNGLGCJDEO(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void IMCOEGLOLLL(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete("Use GetLocalCenterOfMassOfSelf or TryGetLocalCenterOfMassOfHierarchy")]
	float3 BNIGODHIPJK(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 GCDEMDKGMDO(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void COEFADGIDCC(FJLCNCEHANP HFMJJPJADMB, float3 DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OKMHHBAMCOP(FJLCNCEHANP HFMJJPJADMB, float3 DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float IACPHHPFPDM(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float PGIBFDDPNBM(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GGHIGAFKEBK(FJLCNCEHANP HFMJJPJADMB, float DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void LHHLLAGJCPA(FJLCNCEHANP HFMJJPJADMB, float DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode MBJHCOMHPIG(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IEDGAOIKELI(FJLCNCEHANP HFMJJPJADMB, CollisionDetectionMode DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(Slot = "28")]
	BPHGBOIEMNK DNPKFKEAGBG(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void LANEIAABMOL(FJLCNCEHANP HFMJJPJADMB, BPHGBOIEMNK DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool CINJMGNDCLF(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void PJBDHMDFJOC(FJLCNCEHANP HFMJJPJADMB, bool DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(Slot = "32")]
	FJLCNCEHANP IKKBCFHHAKG(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void BPLOKDGNOFE(FJLCNCEHANP HFMJJPJADMB, FJLCNCEHANP DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(Slot = "34")]
	FJLCNCEHANP EKMIKGPLLFI(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void PJMHJPJDMME(FJLCNCEHANP HFMJJPJADMB, FJLCNCEHANP DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(Slot = "36")]
	GGAPDDJFBMN MKLAJANKAGN(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void IEELAGCGLHK(FJLCNCEHANP HFMJJPJADMB, GGAPDDJFBMN GABMNKCDOJF);

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool DMFGJPGHOOF(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void IOOHDCDMMDP(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool LLGOMLANKBL(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void JGGBJKMLJAP(FJLCNCEHANP HFMJJPJADMB, bool DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool OPCHOHIEOEE(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void AIFPAEDOHEA(FJLCNCEHANP HFMJJPJADMB, bool DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints ACENLGFGCCF(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void IDPBPPLCAMA(FJLCNCEHANP HFMJJPJADMB, RigidbodyConstraints DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float OCDJFKJFOMK(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void KOLEGCIHPEP(FJLCNCEHANP HFMJJPJADMB, float DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float IHBGOJHLNLP(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void PJJBKIAFCDD(FJLCNCEHANP HFMJJPJADMB, float DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool FMIPPOEOHGM(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void EDGIDJNBMAI(FJLCNCEHANP HFMJJPJADMB, bool DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool FGODLDPFDAI(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void CIJDHDFAIOH(FJLCNCEHANP HFMJJPJADMB, bool DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void JMHMFINFCCO(FJLCNCEHANP HFMJJPJADMB, int DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object FEEGKHKNPEL(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void GDHDGONJPII(FJLCNCEHANP HFMJJPJADMB, object DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object MDKHBFKCMMG(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void OMFPFELKNLF(FJLCNCEHANP HFMJJPJADMB, object DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float HJJKOHDLIEB(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void LONAIFJHJGN(FJLCNCEHANP HFMJJPJADMB, float DOLICEBFIPF);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void INNKCCKCMBD(FJLCNCEHANP HFMJJPJADMB, object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void CDIMHNJEKPD(FJLCNCEHANP HFMJJPJADMB, object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool AKNAHPPFKFF(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void GLENLBIOPPI(FJLCNCEHANP HFMJJPJADMB, object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void OHOMOBONHLM(FJLCNCEHANP HFMJJPJADMB, object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool DHENGJBABFD(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool HADCKABADPF(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody KGJHACDEBJM(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void DCPDGDNMAGB(FJLCNCEHANP HFMJJPJADMB, Rigidbody EKEIFPIAPLM);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void LJJAOAMDCMC(FJLCNCEHANP HFMJJPJADMB, object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void HIJLGBEGIJI(FJLCNCEHANP HFMJJPJADMB, object JECMOKMEJED);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool EFGBGBDKEDI(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void EBLIFHMGOBF(FJLCNCEHANP HFMJJPJADMB, float3 GNMILCCIALP);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void ECKKFFLKGHN(FJLCNCEHANP HFMJJPJADMB, float3 FGDMIAMGAFN);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool JIIDDAHPFCB(FJLCNCEHANP HFMJJPJADMB, [Out] float3 GNMILCCIALP);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool EGGDEFDBBGP(FJLCNCEHANP HFMJJPJADMB, [Out] float3 FGDMIAMGAFN);

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool HFPCJNNENJE(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void GGHCODBFAHJ(FJLCNCEHANP HFMJJPJADMB, object JECMOKMEJED, bool EHOKAKODAMF);

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void KDEJCDNCIEJ(FJLCNCEHANP HFMJJPJADMB, bool DJDMLKABCAA);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void AKOFBJMFPEK(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool KAGCDJJMDLP(FJLCNCEHANP HFMJJPJADMB);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface HIENMCCIMBD
{
	[Cpp2IlInjected.Token(Token = "0x17000138")]
	bool MGKHEKGJIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NPGOJDGPLGD(FJLCNCEHANP HFMJJPJADMB);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIGBLHFHECP(FJLCNCEHANP HFMJJPJADMB, bool IHMEODGLHBA, bool IABJGKHPMFB, bool CJMCAMMPCCE);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNMDEEDDHHB(FJLCNCEHANP HFMJJPJADMB, float3 APODGKHBFFA);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJKLAAHPNFO(FJLCNCEHANP HFMJJPJADMB, float3 APODGKHBFFA);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface PGOMIDFEFOI
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBLJLDBFBDK(Entity NHLCNBMHKGP);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNDJNAPEAJE(Entity NHLCNBMHKGP);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public delegate void LBMHIPMEKKA(DBECFDFCEJG HBPNKAEKMON);
[Cpp2IlInjected.Token(Token = "0x2000081")]
public readonly struct DBECFDFCEJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly MDCBEIJBKIC GICCLDHOFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly NativeArray<byte> OBEMFNIFBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly NativeArray<byte> JJFAODAJEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly JGOKKPNNOBP GPPBGDKFIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly int JPPJOEFHGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Type DEMINAGMHOC;

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public MDCBEIJBKIC KHLGGJCHEFM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x39C5CD0", Offset = "0x39C44D0", VA = "0x1839C5CD0")]
		get
		{
			return default(MDCBEIJBKIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5EECF30", Offset = "0x5EEB730", VA = "0x185EECF30")]
	public DBECFDFCEJG(MDCBEIJBKIC GICCLDHOFBA, NativeArray<byte> OBEMFNIFBAB, NativeArray<byte> JJFAODAJEPD, JGOKKPNNOBP GPPBGDKFIDI, int JPPJOEFHGFP, Type DEMINAGMHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x2355420", Offset = "0x2353C20", VA = "0x182355420")]
	public NativeArray<T> JKEHDEAKPOM<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x23553E0", Offset = "0x2353BE0", VA = "0x1823553E0")]
	public NativeArray<T> GKKMLOGBOCH<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x23552F0", Offset = "0x2353AF0", VA = "0x1823552F0")]
	public (MDCBEIJBKIC, NativeArray<T>, NativeArray<T>) BGCBNLKDELI<T>() where T : struct
	{
		return default((MDCBEIJBKIC, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x5EECEE0", Offset = "0x5EEB6E0", VA = "0x185EECEE0")]
	public NCJGOKIHNBJ BFIMOAMBCKD()
	{
		return default(NCJGOKIHNBJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public interface EALEKJFDGKO
{
	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	string PDMFKHKIFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	EALEKJFDGKO FEELBMLFLDL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	IEnumerable<EALEKJFDGKO> LDOGMHKBFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface FJCDOENGDNO
{
	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	EALEKJFDGKO JIPAIKCDAJK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	List<MFHPEDEHPLF> PBBFPJOGODK
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IGLMNFKFDNI(MFHPEDEHPLF AHFKMNKCLNN, [Out] EALEKJFDGKO NPFFKLCGLOA);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FPBPDBBEPKK(MFHPEDEHPLF AHFKMNKCLNN, LBMHIPMEKKA KMADMIJEPKI);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IEFPFAJOIAA(MFHPEDEHPLF AHFKMNKCLNN, LBMHIPMEKKA KMADMIJEPKI);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public readonly struct NCJGOKIHNBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly DBECFDFCEJG FCHBDAMJEHN;

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public MDCBEIJBKIC KHLGGJCHEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x39C5CD0", Offset = "0x39C44D0", VA = "0x1839C5CD0")]
		get
		{
			return default(MDCBEIJBKIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8130", Offset = "0x5EF6930", VA = "0x185EF8130")]
	public NCJGOKIHNBJ(DBECFDFCEJG FCHBDAMJEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5EF8060", Offset = "0x5EF6860", VA = "0x185EF8060")]
	public MDCBEIJBKIC JKEHDEAKPOM()
	{
		return default(MDCBEIJBKIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7F90", Offset = "0x5EF6790", VA = "0x185EF7F90")]
	public MDCBEIJBKIC GKKMLOGBOCH()
	{
		return default(MDCBEIJBKIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7E70", Offset = "0x5EF6670", VA = "0x185EF7E70")]
	public (MDCBEIJBKIC, MDCBEIJBKIC, MDCBEIJBKIC) BGCBNLKDELI()
	{
		return default((MDCBEIJBKIC, MDCBEIJBKIC, MDCBEIJBKIC));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[DefaultMember("Item")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface HHIOINDCHOA : IEnumerable<EIAJNDAFPFP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000140")]
	NativeBitArray LIMGENKCOKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	NativeArray<int> DOGJLNDJKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	EIAJNDAFPFP OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	EIAJNDAFPFP OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EIAJNDAFPFP ICGCKDNHCII(KBACDKACLJJ LLJBEMIACPC);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JGOKKPNNOBP FNMMCMPBNFA(KBACDKACLJJ LLJBEMIACPC);
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class EEONDNEDGEI
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
[DefaultMember("Item")]
public interface IEHCBEBOFFN : IEnumerable<KNCOLNDLDAK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000145")]
	int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	KNCOLNDLDAK OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KNCOLNDLDAK ICGCKDNHCII(KBACDKACLJJ LLJBEMIACPC);

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JGOKKPNNOBP FNMMCMPBNFA(KBACDKACLJJ LLJBEMIACPC);
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public static class MHBNMJIMPLO
{
	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x259BC00", Offset = "0x259A400", VA = "0x18259BC00")]
	public static JGOKKPNNOBP FNMMCMPBNFA<T>(this IEHCBEBOFFN MJBJHGOBNAE, JFMGGGHOGCJ<T> PMDCAPIFBIP) where T : struct
	{
		return default(JGOKKPNNOBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface IGPPFGJEMBH : IEnumerable<MFHPEDEHPLF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000147")]
	int CADPCMFLDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	MFHPEDEHPLF OCCPLJKMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MFHPEDEHPLF ICGCKDNHCII(KBACDKACLJJ LLJBEMIACPC);

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JGOKKPNNOBP FNMMCMPBNFA(KBACDKACLJJ LLJBEMIACPC);
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public static class MLFPECIEHKB
{
	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x25AD0F0", Offset = "0x25AB8F0", VA = "0x1825AD0F0")]
	public static CLFFJCJMONN<T> ICGCKDNHCII<T>(this IGPPFGJEMBH MJBJHGOBNAE, KBACDKACLJJ PMDCAPIFBIP) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x25ACFF0", Offset = "0x25AB7F0", VA = "0x1825ACFF0")]
	public static JGOKKPNNOBP FNMMCMPBNFA<T>(this IGPPFGJEMBH MJBJHGOBNAE, JFMGGGHOGCJ<T> PMDCAPIFBIP) where T : struct
	{
		return default(JGOKKPNNOBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface DHADOIAAHCF
{
	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPBPDBBEPKK(KBACDKACLJJ AHFKMNKCLNN, LBMHIPMEKKA KMADMIJEPKI);

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IEFPFAJOIAA(KBACDKACLJJ AHFKMNKCLNN, LBMHIPMEKKA KMADMIJEPKI);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class NBEABGGCAKK
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface OJIEDFDKIKF
{
	[Cpp2IlInjected.Token(Token = "0x17000149")]
	BAJMBAOBCME NPEHEKFOLAL
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DAJNABGILEF(CLJMLDOJEOF AMCDBMBKIEK, JGOKKPNNOBP AHFKMNKCLNN);

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NENKGHGPAIA(CLJMLDOJEOF AMCDBMBKIEK, Span<JGOKKPNNOBP> MJBJHGOBNAE, bool AAHBNBFCJDK);

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANPHIKLGLIG(NativeArray<CLJMLDOJEOF> HHCKJOMDIOJ);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class IKDICLKCFHO
{
	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4430", Offset = "0x5EF2C30", VA = "0x185EF4430")]
	public static void NENKGHGPAIA(this OJIEDFDKIKF BGFHIGCIMBJ, CLJMLDOJEOF AMCDBMBKIEK, JGOKKPNNOBP AHFKMNKCLNN, bool AAHBNBFCJDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public readonly struct BAJMBAOBCME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly NativeBitArray KDPJIDKHHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly NativeParallelHashMap<CLJMLDOJEOF, int> AFHJBANNLEG;

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	public bool GMFECAFJFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x5EEA5C0", Offset = "0x5EE8DC0", VA = "0x185EEA5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0xB2AA10", Offset = "0xB29210", VA = "0x180B2AA10")]
	public BAJMBAOBCME(NativeBitArray KDPJIDKHHEO, NativeParallelHashMap<CLJMLDOJEOF, int> AFHJBANNLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA490", Offset = "0x5EE8C90", VA = "0x185EEA490")]
	public bool DAJNABGILEF(CLJMLDOJEOF AMCDBMBKIEK, JGOKKPNNOBP AHFKMNKCLNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface OCLOHOBNGGA
{
	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJMNCPFMAGJ(FJLCNCEHANP HFMJJPJADMB, GLDFFBHMDEM DOLICEBFIPF);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface OFGNEGHDGJA
{
	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	OECNPGLBOAO KKEDNLEGGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface ADOFEDFOMBD
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	Type ELEICAEJEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[OLKLCMINJBN(GPEEMBCHOPN.LoadInstance)]
public interface POFJJJJDDBG
{
	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHNHEOBCEHA(FJLCNCEHANP PDNACDIBMJE, bool DOLICEBFIPF);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public readonly struct EPEBOLIMLEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly IEnumerable<DDDHGAIPBMD> MODPINCOIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly IReadOnlyList<GameObject> OECLAOILNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly IReadOnlyList<int> LLAHKAIKIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly IReadOnlyList<(CLJMLDOJEOF, CLJMLDOJEOF)> MCKCBOAMLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly int OFNCGBMJIHK;

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public bool AFICHJEBJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(RVA = "0x5EEF330", Offset = "0x5EEDB30", VA = "0x185EEF330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	public int BBAMPJIIGDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x89AF10", Offset = "0x899710", VA = "0x18089AF10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public IEnumerable<GameObject> COLKJJFCLCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x836470", Offset = "0x834C70", VA = "0x180836470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public IEnumerable<(CLJMLDOJEOF src, CLJMLDOJEOF dst)> DLANAEDNNPL
	{
		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x776030", Offset = "0x774830", VA = "0x180776030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF720", Offset = "0x5EEDF20", VA = "0x185EEF720")]
	public EPEBOLIMLEC(IEnumerable<DDDHGAIPBMD> MODPINCOIGB, IReadOnlyList<GameObject> OECLAOILNEJ, IReadOnlyList<int> LLAHKAIKIKK, IReadOnlyList<(CLJMLDOJEOF src, CLJMLDOJEOF dst)> MCKCBOAMLKP, int OFNCGBMJIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEF390", Offset = "0x5EEDB90", VA = "0x185EEF390")]
	public (GameObject, int)[] PBHLGPBCGCF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface ENHFHOKJFEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000151")]
	bool CCJMMKLDNDC
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	bool JIPLBIFMKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	LLMIOGMJAKL ODPDLECHDAH
	{
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HPAJEJAAJLM PIMAEGILJNB();

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HPAJEJAAJLM LBBEIIIAANK(IEnumerable<FJLCNCEHANP> BMDBFLNMJID, [In] JBHJMHDPGEH GBBACHODCOL);

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NIEOFBAOEFH IGLJCONNFIG(ByteString FDFLGAPGNBO);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PLGIELBOHBA LEBFOPLNIJI(ByteString KAGAAHEAJHB, FJLCNCEHANP DEINPDMGBDC, [In] JBHJMHDPGEH DAMCCKMMHIM, MJFANOKEHCM NBKNJMCCNGG, bool MJFIGEBFMEC = true);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GGHKJJDPFDG();

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EPEBOLIMLEC IFOFLKGGNPP(IEnumerable<DDDHGAIPBMD> MODPINCOIGB);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public static class BFDLJHGOFOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface IOABAEALHIP
{
	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action LMFHDGCNBDD;

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action CIOBHAMLDBN;
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public struct JHMMPBEDAMP : OHCAPAOIPLG, IEquatable<JHMMPBEDAMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public GNCNNCODHCF OINDNEFNLBC;

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF49F0", Offset = "0x5EF31F0", VA = "0x185EF49F0", Slot = "5")]
	public void AEDPLFCAHJC(MMGHFMPGADP EINLOJPKPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4AA0", Offset = "0x5EF32A0", VA = "0x185EF4AA0", Slot = "4")]
	public void JMOOMJHDBEG(PFFIILDLBFJ MDONNIFBLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4AD0", Offset = "0x5EF32D0", VA = "0x185EF4AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFC0", Offset = "0x7DC7C0", VA = "0x1807DDFC0", Slot = "6")]
	public bool Equals(JHMMPBEDAMP FPJCFKAMJHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5EF4A20", Offset = "0x5EF3220", VA = "0x185EF4A20", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x85FEF0", Offset = "0x85E6F0", VA = "0x18085FEF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct CLJMLDOJEOF : IComparable<CLJMLDOJEOF>, IEquatable<CLJMLDOJEOF>, OHCAPAOIPLG
{
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public const uint EBCCELADKFL = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public const uint PMEKOAFBAAA = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly CLJMLDOJEOF MIOPHGKICKL;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private const int GKFADPGFOCJ = 24;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private const uint GNPLLHEPJCG = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private const int NHAKKJNNFJF = 8;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private const uint OGBPPMEBEDA = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly uint OCKHPPLPLMN;

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public uint EEAAJLLLAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x7C7BA0", Offset = "0x7C63A0", VA = "0x1807C7BA0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public uint HMHFMLFLMGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x5EECD50", Offset = "0x5EEB550", VA = "0x185EECD50")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	public uint KCEHPLKPMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x85FEF0", Offset = "0x85E6F0", VA = "0x18085FEF0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000157")]
	public bool AFICHJEBJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E230", Offset = "0x5E4CA30", VA = "0x185E4E230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0xD690D0", Offset = "0xD678D0", VA = "0x180D690D0")]
	public static CLJMLDOJEOF DKAHNLHAIDD(uint OCKHPPLPLMN)
	{
		return default(CLJMLDOJEOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5EECED0", Offset = "0x5EEB6D0", VA = "0x185EECED0")]
	public CLJMLDOJEOF(int BIFKICBKPCC, int OMIOLCALJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x5EECED0", Offset = "0x5EEB6D0", VA = "0x185EECED0")]
	public CLJMLDOJEOF(uint BIFKICBKPCC, int OMIOLCALJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x5EECED0", Offset = "0x5EEB6D0", VA = "0x185EECED0")]
	public CLJMLDOJEOF(uint BIFKICBKPCC, uint OMIOLCALJAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x85FF00", Offset = "0x85E700", VA = "0x18085FF00")]
	private CLJMLDOJEOF(uint OCKHPPLPLMN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x170D6A0", Offset = "0x170BEA0", VA = "0x18170D6A0")]
	public static bool FMFPLPMCDAE(CLJMLDOJEOF GIFKCLLLICD, CLJMLDOJEOF KIOLHHMPBGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x7DDFC0", Offset = "0x7DC7C0", VA = "0x1807DDFC0", Slot = "5")]
	public bool Equals(CLJMLDOJEOF MBMFHFDDILC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0x5EECD60", Offset = "0x5EEB560", VA = "0x185EECD60", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x20872A0", Offset = "0x2085AA0", VA = "0x1820872A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x5EECE40", Offset = "0x5EEB640", VA = "0x185EECE40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x5EECDE0", Offset = "0x5EEB5E0", VA = "0x185EECDE0", Slot = "6")]
	public void JMOOMJHDBEG(PFFIILDLBFJ MDONNIFBLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x5EECCE0", Offset = "0x5EEB4E0", VA = "0x185EECCE0", Slot = "7")]
	public void AEDPLFCAHJC(MMGHFMPGADP EINLOJPKPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x5EECD40", Offset = "0x5EEB540", VA = "0x185EECD40", Slot = "4")]
	public int CompareTo(CLJMLDOJEOF FPJCFKAMJHL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct DDDHGAIPBMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Guid CLGOKAHLILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public string HDHEPEBDFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Vector3 FLFCGPFDCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Quaternion JOBDANNFLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Vector3 AMKKNHFCFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public int DFKKDPEBMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public Dictionary<string, object> ICGNFMFDOBD;

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x5EED130", Offset = "0x5EEB930", VA = "0x185EED130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x5EECFA0", Offset = "0x5EEB7A0", VA = "0x185EECFA0")]
	private static string EHHPIHKABOD(Dictionary<string, object> EDJEBJGBJHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public enum CCOAOKEIIPI
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class PELELCMIGNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x542E1C0", Offset = "0x542C9C0", VA = "0x18542E1C0")]
	public static bool JBDLMNMCFBE(this CCOAOKEIIPI HJNJPNKDEFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Flags]
public enum EGOMGNIJKKA
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
public interface PLGIELBOHBA : LLMIOGMJAKL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000158")]
	MJFANOKEHCM EGAKOODFIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PODNDBGONHN();

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBLJHNEKNJC();
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface LLMIOGMJAKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000159")]
	IEnumerable<DDDHGAIPBMD> NLEAJHJELIP
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	EPEBOLIMLEC MECDDCGPMIE
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	LocalId EPAHFLJCBLN
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	HPPNLCPLKCJ FGNMFPPBGGG
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	Task MKGMAGJDGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GEGMGBLEPCF(EGOMGNIJKKA FIKDEELCDKB);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface MJFANOKEHCM
{
	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFIOCHEAHBK(Guid MHGKACIOCHE, [Out] Guid FPCLANOGJBF);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public interface NIEOFBAOEFH : LLMIOGMJAKL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[Flags]
public enum NCPJDAGECCK
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
public interface HPAJEJAAJLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	HPPNLCPLKCJ HGCCOEPCLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString NHPONOPKCGI();
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public enum HHKMGGDLNPA
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	World,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public delegate bool IJGDKOAAGHN(PALDEONJACE DOJPHOAMFJK, [In] ELJDEODHMHO DOLICEBFIPF);
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public delegate bool CFNLGMNJMJL<T>(PALDEONJACE DOJPHOAMFJK, [In] T DOLICEBFIPF);
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface LJEJKKPGHIA
{
	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPBPDBBEPKK(JGOKKPNNOBP GPPBGDKFIDI, Type CLGFIOKOLLH, IJGDKOAAGHN GANFEHPFPPC);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GNOEPCIKGHJ(JGOKKPNNOBP GPPBGDKFIDI, [Out] IJGDKOAAGHN GANFEHPFPPC);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class NBGFGMGGONJ
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class CMKPPKNJPIL<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public CFNLGMNJMJL<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public CMKPPKNJPIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x49D5960", Offset = "0x49D4160", VA = "0x1849D5960")]
		internal bool MFKOGEBIIMK(PALDEONJACE pendingList, [In] ELJDEODHMHO value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x2624780", Offset = "0x2622F80", VA = "0x182624780")]
	public static void FPBPDBBEPKK<T>(this LJEJKKPGHIA NECECMHOHDJ, JGOKKPNNOBP GPPBGDKFIDI, CFNLGMNJMJL<T> GANFEHPFPPC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x5EF7D60", Offset = "0x5EF6560", VA = "0x185EF7D60")]
	public static bool PJBGNKHDMJI(this LJEJKKPGHIA NECECMHOHDJ, PALDEONJACE DOJPHOAMFJK, JGOKKPNNOBP GPPBGDKFIDI, [In] ELJDEODHMHO DOLICEBFIPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface HGKMPOMJAOH
{
	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	uint NPBLEKKHOCB
	{
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface PALDEONJACE
{
	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OKCEENJCLOH(CLJMLDOJEOF AEDANNABEMI, JGOKKPNNOBP GPPBGDKFIDI, ReadOnlySpan<byte> MKCKNIDNPEA, ReadOnlySpan<byte> GCDAHKGNOPO);

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BGOLBPOBJCD(CLJMLDOJEOF AEDANNABEMI, JGOKKPNNOBP GPPBGDKFIDI);

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ONLBEKEANBI(CLJMLDOJEOF AEDANNABEMI, JGOKKPNNOBP GPPBGDKFIDI, ReadOnlySpan<byte> GCDAHKGNOPO);

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JOCJLLNNLGP(CLJMLDOJEOF AEDANNABEMI, JGOKKPNNOBP GPPBGDKFIDI, Span<byte> MKCKNIDNPEA, Span<byte> GCDAHKGNOPO);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public static class CNIFKALBCEP
{
	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x2334AA0", Offset = "0x23332A0", VA = "0x182334AA0")]
	public static bool JOCJLLNNLGP<T>(this PALDEONJACE FEGJFEGANDJ, CLJMLDOJEOF AEDANNABEMI, JGOKKPNNOBP GPPBGDKFIDI, [Out] T MKCKNIDNPEA, [Out] T GCDAHKGNOPO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x2334C50", Offset = "0x2333450", VA = "0x182334C50")]
	public static bool ONLBEKEANBI<T>(this PALDEONJACE FEGJFEGANDJ, CLJMLDOJEOF AEDANNABEMI, JGOKKPNNOBP GPPBGDKFIDI, T GCDAHKGNOPO) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public enum PLBCJAJCFAG
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
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface AMDILEJFLEE
{
	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKLNJPMDJBK(AKOOHFOHKCF PCNNAKCFNJC, ReadOnlySpan<byte> IOHCLNMNKCI);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNHDNAGGPFI(uint JLLJIJMMALN, ReadOnlySpan<byte> IOHCLNMNKCI);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface IABMDNMAHHL
{
	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AKOOHFOHKCF BKMHNNHMFMA(ReadOnlySpan<byte> IOHCLNMNKCI);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface GKHENIBNOGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IELKDNMCCHO(AKOOHFOHKCF EMBEECDJLJB, ReadOnlySpan<byte> IOHCLNMNKCI);

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOOMOPKJOPN(ReadOnlySpan<AKOOHFOHKCF> KPBMKEFFJHP);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct IBPGECPKCBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public AKOOHFOHKCF PCNNAKCFNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public ReadOnlyMemory<byte> IOHCLNMNKCI;
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct AKOOHFOHKCF
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public static AKOOHFOHKCF PCABODDOOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public uint BIFKICBKPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public int JNBKHBJGJJN;

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0xA106A0", Offset = "0xA0EEA0", VA = "0x180A106A0")]
	public AKOOHFOHKCF(uint BIFKICBKPCC, int JNBKHBJGJJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA350", Offset = "0x5EE8B50", VA = "0x185EEA350")]
	public static bool FMFPLPMCDAE([In] AKOOHFOHKCF NMCFAAKFHJI, [In] AKOOHFOHKCF AKHEBCAILGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA2A0", Offset = "0x5EE8AA0", VA = "0x185EEA2A0", Slot = "0")]
	public override bool Equals(object BEKFGDCEJDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA370", Offset = "0x5EE8B70", VA = "0x185EEA370", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA3A0", Offset = "0x5EE8BA0", VA = "0x185EEA3A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA290", Offset = "0x5EE8A90", VA = "0x185EEA290")]
	public void DJEJHKAEBIG([Out] uint BIFKICBKPCC, [Out] int JNBKHBJGJJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[OLKLCMINJBN(GPEEMBCHOPN.OMRoom)]
public interface AEMHHALIEGL : FMPCIPONCBO<AEMHHALIEGL>
{
	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBIEMEKDBEG(JGOKKPNNOBP MBMFHFDDILC, [Out] DLOFJBEGJPD MFFFLDEOBCN);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public static class OIBPBOELLLP
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface DLOFJBEGJPD
{
	[Cpp2IlInjected.Token(Token = "0x17000160")]
	Type NNHPNMIPFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEDPLFCAHJC(MMGHFMPGADP EINLOJPKPLI, Span<byte> MAKBFCPADHF);

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JMOOMJHDBEG(PFFIILDLBFJ MDONNIFBLDI, ReadOnlySpan<byte> PCNNAKCFNJC);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class OFCPACJKIPI
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public struct AEBIPFLLKMA : ISystemStateComponentData, IComponentData, IEquatable<AEBIPFLLKMA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public float3 OJBLIMFFNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public float3 INGCEHPCBJH;

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0x5EEA210", Offset = "0x5EE8A10", VA = "0x185EEA210", Slot = "4")]
	public bool Equals(AEBIPFLLKMA FPJCFKAMJHL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface DHPCHBOPNDB
{
	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PGCEKIOAHGF CMBADANFLGJ(int IBDHJFPOKKL);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int IHNEIHMLGHK(PGCEKIOAHGF APLJCNJGMAI);
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface MEEMFODLPCA
{
	[Cpp2IlInjected.Token(Token = "0x17000161")]
	IEnumerable<GECLPODMPPC> AAEDBJFNNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PLJCDFMPEOL(int IBDHJFPOKKL, [Out] GECLPODMPPC MFFFLDEOBCN);
}
[Cpp2IlInjected.Token(Token = "0x20000BB")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface DACLIMDDFCA
{
	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LOMEFNGJAIP(int IBDHJFPOKKL);
}
[Cpp2IlInjected.Token(Token = "0x20000BC")]
[OLKLCMINJBN(GPEEMBCHOPN.Application)]
public interface PJLADPHLFOA
{
	[Cpp2IlInjected.Token(Token = "0x17000162")]
	List<(PGCEKIOAHGF nameHash, MHMPMCNAPHK stableTypeHash, Type type)> BNHBCBMOPFI
	{
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BD")]
public class ADJKIDCLGDK
{
	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
	public ADJKIDCLGDK()
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
